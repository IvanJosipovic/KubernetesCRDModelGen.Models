using Semver;
using Valleysoft.DockerRegistryClient;
using Valleysoft.DockerRegistryClient.Models.Manifests;
using static KubernetesCRDModelGen.Sync.CRD.CRDDownloader;

namespace KubernetesCRDModelGen.Sync.CRD;

internal static partial class OCIClient
{
    public static async Task<List<Stream>> GetYamlStreams(Config.OCIConfig config)
    {
        var registryUri = config.Image.Contains("://")
            ? new Uri(config.Image)
            : new Uri($"https://{config.Image}");

        var registry = registryUri.Host + (registryUri.IsDefaultPort ? string.Empty : $":{registryUri.Port}");
        var repositoryName = registryUri.AbsolutePath.TrimStart('/');

        var client = new RegistryClient(registry);

        var tags = await client.Tags.GetAllAsync(repositoryName);

        var latestVersion = tags
            .Select(tag => new { Tag = tag, Version = SemVersion.TryParse(tag, SemVersionStyles.Any, out var ver) ? ver : null })
            .Where(x => x.Version is not null && (config.PreRelease == true || !x.Version.IsPrerelease))
            .OrderByDescending(x => x.Version!, SemVersion.SortOrderComparer)
            .FirstOrDefault();

        if (latestVersion == null)
        {
            throw new Exception($"No tags match for {config.Image}");
        }

        var manifest = await client.Manifests.GetAsync(repositoryName, latestVersion.Tag);

        var yamls = await ProcessManifests(client, repositoryName, manifest.Manifest);

        return yamls;
    }

    private static async Task<List<Stream>> ProcessManifests(RegistryClient client, string repositoryName, IManifest manifest)
    {
        var yamls = new List<Stream>();

        if (manifest is IManifestList manifestList)
        {
            foreach (var manifestReference in manifestList.Manifests)
            {
                var manifestInfo = await client.Manifests.GetAsync(repositoryName, manifestReference.Digest);

                var newYamls = await ProcessManifests(client, repositoryName, manifestInfo.Manifest);
                yamls.AddRange(newYamls);
            }
        }
        else if (manifest is IImageManifest imageManifest)
        {
            foreach (var layer in imageManifest.Layers)
            {
                using var stream = await client.Blobs.GetAsync(repositoryName, layer.Digest);

                using var copy = new MemoryStream();
                await stream.CopyToAsync(copy);
                copy.Position = 0;

                var newYamls = CRDDownloader.ExtractAllYaml(copy, CompressionType.TarGz);
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

public static class Extensions
{
    public static async Task<string[]> GetAllAsync(this ITagOperations client, string repositoryName)
    {
        List<string> allTags = [];

        var tagsPage = await client.GetAsync(repositoryName);
        allTags.AddRange(tagsPage.Value.Tags);

        while (!string.IsNullOrEmpty(tagsPage.NextPageLink))
        {
            tagsPage = await client.GetNextAsync(tagsPage.NextPageLink);
            allTags.AddRange(tagsPage.Value.Tags);
        }

        return allTags.ToArray();
    }
}