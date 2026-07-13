using Semver;
using Valleysoft.DockerRegistryClient;
using Valleysoft.DockerRegistryClient.Models.Manifests;
using static KubernetesCRDModelGen.Sync.CRD.CRDDownloader;

namespace KubernetesCRDModelGen.Sync.CRD;

static class OCIClient
{
    internal static async Task<List<Stream>> GetYamlStreamsAsync(OCIConfig config, CancellationToken cancellationToken = default)
    {
        var registryUri = config.Image.Contains("://")
            ? new Uri(config.Image)
            : new Uri($"https://{config.Image}");

        var registry = registryUri.Host + (registryUri.IsDefaultPort ? string.Empty : $":{registryUri.Port}");
        var repositoryName = registryUri.AbsolutePath.TrimStart('/');

        var client = new RegistryClient(registry);

        var tags = await client.Tags.GetAllAsync(repositoryName, cancellationToken).ConfigureAwait(false);

        var latestVersion = tags
            .Select(tag => new { Tag = tag, Version = SemVersion.TryParse(tag, SemVersionStyles.Any, out var ver) ? ver : null })
            .Where(x => x.Version is not null && (config.PreRelease == true || !x.Version.IsPrerelease))
            .OrderByDescending(x => x.Version!, SemVersion.SortOrderComparer)
            .FirstOrDefault();

        if (latestVersion == null)
        {
            throw new Exception($"No tags match for {config.Image}");
        }

        cancellationToken.ThrowIfCancellationRequested();

        var manifest = await client.Manifests.GetAsync(repositoryName, latestVersion.Tag, cancellationToken).ConfigureAwait(false);

        var yamls = await ProcessManifestsAsync(client, repositoryName, manifest.Manifest, cancellationToken).ConfigureAwait(false);

        return yamls;
    }

    private static async Task<List<Stream>> ProcessManifestsAsync(RegistryClient client, string repositoryName, IManifest manifest, CancellationToken cancellationToken = default)
    {
        var yamls = new List<Stream>();

        if (manifest is IManifestList manifestList)
        {
            foreach (var manifestReference in manifestList.Manifests)
            {
                cancellationToken.ThrowIfCancellationRequested();

                var manifestInfo = await client.Manifests.GetAsync(repositoryName, manifestReference.Digest, cancellationToken).ConfigureAwait(false);

                var newYamls = await ProcessManifestsAsync(client, repositoryName, manifestInfo.Manifest, cancellationToken).ConfigureAwait(false);
                yamls.AddRange(newYamls);
            }
        }
        else if (manifest is IImageManifest imageManifest)
        {
            foreach (var layer in imageManifest.Layers)
            {
                cancellationToken.ThrowIfCancellationRequested();

                using var stream = await client.Blobs.GetAsync(repositoryName, layer.Digest, cancellationToken).ConfigureAwait(false);

                using var copy = new MemoryStream();
                await stream.CopyToAsync(copy, cancellationToken).ConfigureAwait(false);
                copy.Position = 0;

                var newYamls = CRDDownloader.ExtractAllYaml(copy, CompressionType.TarGz, cancellationToken: cancellationToken);
                yamls.AddRange(newYamls);
            }
        }
        else
        {
            throw new Exception($"Unsupported manifest type: {manifest.GetType().Name}");
        }

        return yamls;
    }
}

static class Extensions
{
    internal static async Task<string[]> GetAllAsync(this ITagOperations client, string repositoryName, CancellationToken cancellationToken = default)
    {
        List<string> allTags = [];

        cancellationToken.ThrowIfCancellationRequested();

        var tagsPage = await client.GetAsync(repositoryName, cancellationToken: cancellationToken).ConfigureAwait(false);
        allTags.AddRange(tagsPage.Value.Tags);

        while (!string.IsNullOrEmpty(tagsPage.NextPageLink))
        {
            cancellationToken.ThrowIfCancellationRequested();

            tagsPage = await client.GetNextAsync(tagsPage.NextPageLink, cancellationToken).ConfigureAwait(false);
            allTags.AddRange(tagsPage.Value.Tags);
        }

        return allTags.ToArray();
    }
}