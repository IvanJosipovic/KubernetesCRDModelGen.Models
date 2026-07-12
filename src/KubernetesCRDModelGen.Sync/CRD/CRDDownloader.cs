using CliWrap;
using CliWrap.Buffered;
using k8s;
using k8s.Models;
using Semver;
using System.Formats.Tar;
using System.IO.Compression;
using System.Net.Http.Json;
using System.Reflection;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace KubernetesCRDModelGen.Sync.CRD;

internal class CRDDownloader
{
    private readonly ILogger<CRDDownloader> _logger;

    private readonly IConfiguration configuration;

    private readonly IHttpClientFactory httpClientFactory;

    private readonly IDeserializer deserializer;

    public CRDDownloader(ILogger<CRDDownloader> logger, IConfiguration configuration, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        this.configuration = configuration;
        this.httpClientFactory = httpClientFactory;
        deserializer = GetDeserializer();
    }

    public async Task ProcessOCI(Config.OCIConfig item)
    {
        var streams = await OCIClient.GetYamlStreams(item);

        SaveYamlStreams(streams);
    }

    public async Task ProcessHelmChart(Config.HelmConfig config)
    {
        using var stream = new MemoryStream();

        var args = $"template {config.Chart}{(config.IsOCI ? "" : " --repo")} {config.Repo} --include-crds{(config.PreRelease.GetValueOrDefault() ? " --devel" : "")} {config.CMD}".TrimEnd();

        await Cli.Wrap("helm")
            .WithArguments(args)
            .WithStandardOutputPipe(PipeTarget.ToStream(stream))
            .WithStandardErrorPipe(PipeTarget.ToDelegate((msg) =>
            {
                _logger.LogError("Error Helm Template {chart} {repo}: {message}", config.Chart, config.Repo, msg);
            }))
            .ExecuteBufferedAsync();

        stream.Position = 0;

        SaveYamlStream(stream);
    }

    public async Task ProcessDirectUrl(Config.DirectUrlConfig config)
    {
        using var client = httpClientFactory.CreateClient();

        using var httpStream = await client.GetStreamAsync(config.Url);
        using var stream = new MemoryStream();
        await httpStream.CopyToAsync(stream);
        stream.Position = 0;

        var ext = Path.GetExtension(config.Url);

        if (ext == ".yaml" || ext == ".yml")
        {
            SaveYamlStream(stream);
        }
        else if (config.Url.EndsWith(".zip"))
        {
            SaveYamlStream(stream, CompressionType.Zip);
        }
        else if (config.Url.EndsWith(".tar.gz"))
        {
            SaveYamlStream(stream, CompressionType.TarGz);
        }
    }

    public async Task ProcessGitHub(Config.GitHubConfig config)
    {
        using var client = httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.UserAgent.TryParseAdd("KubernetesCRDModelGen");

        var gitHubReleases = await client.GetFromJsonAsync<List<GitHubReleaseModel>>($"https://api.github.com/repos/{config.Repo}/releases");

        var release = gitHubReleases
            .Where(x => x.assets.Length != 0)
            .Select(x => new { Release = x, Version = SemVersion.TryParse(x.name, SemVersionStyles.Any, out var ver) ? ver : null })
            .Where(x => x.Version is not null && (config.PreRelease == true || (!x.Version.IsPrerelease && !x.Release.prerelease)))
            .OrderByDescending(x => x.Version)
            .First().Release;

        foreach (var item in release.assets)
        {
            if (!string.IsNullOrEmpty(config.AssetFilter) && item.name.StartsWith(config.AssetFilter, StringComparison.InvariantCultureIgnoreCase))
            {
                await ProcessDirectUrl(new Config.DirectUrlConfig { Url = item.browser_download_url });
            }
        }
    }

    public enum CompressionType
    {
        Zip,
        TarGz
    }

    internal static List<Stream> ExtractAllYaml(Stream stream, CompressionType compressionType)
    {
        var result = new List<Stream>();

        switch (compressionType)
        {
            case CompressionType.Zip:
                var zip = new ZipArchive(stream, ZipArchiveMode.Read);

                foreach (var entry in zip.Entries)
                {
                    if (entry.FullName.EndsWith(".yaml", StringComparison.OrdinalIgnoreCase) ||
                        entry.FullName.EndsWith(".yml", StringComparison.OrdinalIgnoreCase))
                    {
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
                    string name = entry.Name;

                    if (entry.EntryType == TarEntryType.RegularFile &&
                        (name.EndsWith(".yaml", StringComparison.OrdinalIgnoreCase) ||
                         name.EndsWith(".yml", StringComparison.OrdinalIgnoreCase)))
                    {
                        if (entry.DataStream == null || !entry.DataStream.CanRead)
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

    private void SaveYamlStreams(List<Stream> streams)
    {
        foreach (var stream in streams)
        {
            SaveYamlStream(stream);
        }
    }

    private void SaveYamlStream(Stream stream, CompressionType compressionType)
    {
        var streams = ExtractAllYaml(stream, compressionType);
        SaveYamlStreams(streams);
    }

    private void SaveYamlStream(Stream stream)
    {
        try
        {
            var crds = LoadCRDFromStream(stream);

            var projDirctory = Path.Combine(configuration.GetValue<string>("RootDirectory"), "src", "Models", crds.First().Spec.Group);

            var crdDirectory = Path.Combine(projDirctory, "crds");

            Directory.CreateDirectory(crdDirectory);

            foreach (var crd in crds)
            {
                var filePath = Path.Combine(crdDirectory, crd.Name() + ".yaml");

                File.WriteAllText(filePath, KubernetesYaml.Serialize(crd));
            }
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
