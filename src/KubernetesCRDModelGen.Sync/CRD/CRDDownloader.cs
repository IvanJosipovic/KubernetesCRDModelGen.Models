using CliWrap;
using CliWrap.Buffered;
using k8s;
using k8s.Models;
using Semver;
using System.Formats.Tar;
using System.IO.Compression;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace KubernetesCRDModelGen.Sync.CRD;

class CRDDownloader
{
    private readonly ILogger<CRDDownloader> _logger;

    private readonly IConfiguration configuration;

    private readonly IHostEnvironment environment;

    private readonly IHttpClientFactory httpClientFactory;

    private readonly IDeserializer deserializer;

    public CRDDownloader(ILogger<CRDDownloader> logger, IConfiguration configuration, IHostEnvironment environment, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        this.configuration = configuration;
        this.environment = environment;
        this.httpClientFactory = httpClientFactory;
        deserializer = GetDeserializer();
    }

    public async Task ProcessOCIAsync(OCIConfig item, string projectName, CancellationToken cancellationToken = default)
    {
        var streams = await OCIClient.GetYamlStreamsAsync(item, cancellationToken).ConfigureAwait(false);

        SaveYamlStreams(streams, projectName, cancellationToken);
    }

    public async Task ProcessHelmChartAsync(HelmConfig config, string projectName, CancellationToken cancellationToken = default)
    {
        using var stream = new MemoryStream();
        var errors = new StringBuilder();
        var args = $"template {config.Chart}{(config.IsOCI ? "" : " --repo")} {config.Repo} --include-crds{(config.PreRelease.GetValueOrDefault() ? " --devel" : "")} {config.AppendArgs}".TrimEnd();

        var cmd = await Cli.Wrap("helm")
            .WithArguments(args)
            .WithStandardOutputPipe(PipeTarget.ToStream(stream))
            .WithStandardErrorPipe(PipeTarget.ToStringBuilder(errors))
            .ExecuteBufferedAsync(cancellationToken).ConfigureAwait(false);

        if (!cmd.IsSuccess && errors.Length > 0)
        {
            _logger.LogError("Error Helm Template {chart} {repo}: {message}", config.Chart, config.Repo, errors.ToString());
        }

        stream.Position = 0;

        SaveYamlStream(stream, projectName, cancellationToken);
    }

    public async Task ProcessDirectUrlAsync(DirectUrlConfig config, string projectName, CancellationToken cancellationToken = default)
    {
        using var client = httpClientFactory.CreateClient();

        using var httpStream = await client.GetStreamAsync(config.Url, cancellationToken).ConfigureAwait(false);
        using var stream = new MemoryStream();
        await httpStream.CopyToAsync(stream, cancellationToken).ConfigureAwait(false);
        stream.Position = 0;

        var ext = Path.GetExtension(config.Url);

        if (ext == ".yaml" || ext == ".yml")
        {
            SaveYamlStream(stream, projectName, cancellationToken);
        }
        else if (config.Url.EndsWith(".zip"))
        {
            SaveYamlStream(stream, CompressionType.Zip, projectName, config.ArchivePathRegex, cancellationToken);
        }
        else if (config.Url.EndsWith(".tar.gz"))
        {
            SaveYamlStream(stream, CompressionType.TarGz, projectName, config.ArchivePathRegex, cancellationToken);
        }
    }

    public async Task ProcessGitHubAsync(GitHubConfig config, string projectName, CancellationToken cancellationToken = default)
    {
        using var client = httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.UserAgent.TryParseAdd("KubernetesCRDModelGen");

        var gitHubReleases = await client.GetFromJsonAsync<List<GitHubReleaseModel>>($"https://api.github.com/repos/{config.Repo}/releases", cancellationToken).ConfigureAwait(false);

        if (gitHubReleases == null)
        {
            throw new Exception("Failed to get releases from GitHub for repo " + config.Repo);
        }

        var releaseNameRegex = config.ReleaseNameRegex != null ? new Regex(config.ReleaseNameRegex, RegexOptions.IgnoreCase) : null;

        var release = gitHubReleases
            .Where(x => x.assets.Length != 0)
            .Where(x => releaseNameRegex == null || releaseNameRegex.IsMatch(x.name))
            .Select(x => new { Release = x, Version = SemVersion.TryParse(x.name, SemVersionStyles.Any, out var ver) ? ver : null })
            .Where(x => x.Version is not null && (config.PreRelease == true || (!x.Version.IsPrerelease && !x.Release.prerelease)))
            .OrderByDescending(x => x.Version!, SemVersion.SortOrderComparer)
            .First().Release;

        var assetNameRegex = config.AssetNameRegex != null ? new Regex(config.AssetNameRegex, RegexOptions.IgnoreCase) : null;

        foreach (var item in release.assets)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (assetNameRegex != null && !assetNameRegex.IsMatch(item.name))
            {
                continue;
            }

            await ProcessDirectUrlAsync(new DirectUrlConfig { Url = item.browser_download_url, ArchivePathRegex = config.ArchivePathRegex }, projectName, cancellationToken).ConfigureAwait(false);
        }
    }

    public enum CompressionType
    {
        Zip,
        TarGz
    }

    internal static List<Stream> ExtractAllYaml(Stream stream, CompressionType compressionType, string? assetNameRegexPattern = null, CancellationToken cancellationToken = default)
    {
        var result = new List<Stream>();

        var assetNameRegex = assetNameRegexPattern != null ? new Regex(assetNameRegexPattern, RegexOptions.IgnoreCase) : null;

        switch (compressionType)
        {
            case CompressionType.Zip:
                var zip = new ZipArchive(stream, ZipArchiveMode.Read);

                foreach (var entry in zip.Entries)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    if (entry.FullName.EndsWith(".yaml", StringComparison.OrdinalIgnoreCase) ||
                        entry.FullName.EndsWith(".yml", StringComparison.OrdinalIgnoreCase))
                    {

                        if (assetNameRegex != null && !assetNameRegex.IsMatch(entry.FullName))
                        {
                            continue;
                        }

                        using var entryStream = entry.Open();
                        var ms = new MemoryStream();
                        entryStream.CopyTo(ms);
                        ms.Position = 0;

                        result.Add(ms);
                    }
                }
                break;
            case CompressionType.TarGz:
                var gz = new GZipStream(stream, CompressionMode.Decompress);
                var reader = new TarReader(gz);

                while (reader.GetNextEntry() is TarEntry entry)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    string name = entry.Name;

                    if (entry.EntryType == TarEntryType.RegularFile &&
                        (name.EndsWith(".yaml", StringComparison.OrdinalIgnoreCase) ||
                         name.EndsWith(".yml", StringComparison.OrdinalIgnoreCase)))
                    {
                        if (entry.DataStream == null || !entry.DataStream.CanRead)
                        {
                            continue;
                        }

                        if (assetNameRegex != null && !assetNameRegex.IsMatch(name))
                        {
                            continue;
                        }

                        using Stream data = entry.DataStream;
                        var ms = new MemoryStream();
                        data.CopyTo(ms);
                        ms.Position = 0;

                        result.Add(ms);
                    }
                }
                break;
            default:
                break;
        }

        return result;
    }

    private void SaveYamlStreams(List<Stream> streams, string projectName, CancellationToken cancellationToken = default)
    {
        foreach (var stream in streams)
        {
            cancellationToken.ThrowIfCancellationRequested();

            SaveYamlStream(stream, projectName, cancellationToken);
        }
    }

    private void SaveYamlStream(Stream stream, CompressionType compressionType, string projectName, string? assetNameRegexPattern = null, CancellationToken cancellationToken = default)
    {
        var streams = ExtractAllYaml(stream, compressionType, assetNameRegexPattern, cancellationToken);
        SaveYamlStreams(streams, projectName, cancellationToken);
    }

    private void SaveYamlStream(Stream stream, string projectName, CancellationToken cancellationToken = default)
    {
        try
        {
            cancellationToken.ThrowIfCancellationRequested();

            var crds = LoadCRDFromStream(stream);

            var projDirectory = Path.Combine(environment.ContentRootPath, ProjectGenerator.ModelsPath, projectName);

            var crdDirectory = Path.Combine(projDirectory, ProjectGenerator.CRDFolderName);

            Directory.CreateDirectory(crdDirectory);

            foreach (var crd in crds)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var filePath = Path.Combine(crdDirectory, crd.Name() + ".yaml");

                File.WriteAllText(filePath, KubernetesYaml.Serialize(crd));
            }
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing yaml");
        }
    }

    private static IDeserializer GetDeserializer(bool strict = false)
    {
        var method = typeof(KubernetesYaml).GetMethod("GetDeserializer", BindingFlags.NonPublic | BindingFlags.Static);

        if (method == null)
        {
            throw new Exception("GetDeserializer Method Not Found");
        }

        return (IDeserializer)method.Invoke(null, [strict])!;
    }

    private List<V1CustomResourceDefinition> LoadCRDFromStream(Stream content)
    {
        using(content)
        {
            var parser = new MergingParser(new Parser(new StreamReader(content)));
            parser.Consume<StreamStart>();

            var results = new List<V1CustomResourceDefinition>();

            while (parser.Accept<DocumentStart>(out _))
            {
                var crd = deserializer.Deserialize<V1CustomResourceDefinition>(parser);

                if (crd == null || crd.Kind != V1CustomResourceDefinition.KubeKind || crd.ApiVersion != $"{V1CustomResourceDefinition.KubeGroup}/{V1CustomResourceDefinition.KubeApiVersion}")
                {
                    continue;
                }

                results.Add(crd);
            }

            return results;
        }
    }
}
