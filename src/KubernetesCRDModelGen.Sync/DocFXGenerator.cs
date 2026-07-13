using System.Text.Json;
using System.Text.Json.Nodes;

namespace KubernetesCRDModelGen.Sync;

static class DocFXGenerator
{
    private static string ModelsPath => "models";

    public static void GenerateDocFx(IEnumerable<Config> configs, string rootDirectory)
    {
        ArgumentNullException.ThrowIfNull(configs);

        var distinctGroups = configs
            .Select(config => config.Group)
            .Where(group => !string.IsNullOrWhiteSpace(group))
            .Distinct(StringComparer.Ordinal)
            .Order(StringComparer.Ordinal)
            .ToList();

        var docFxPath = Path.Combine(rootDirectory, "docfx.json");

        if (!File.Exists(docFxPath))
        {
            throw new FileNotFoundException("DocFX configuration file was not found.", docFxPath);
        }

        var docFxConfig = JsonNode.Parse(File.ReadAllText(docFxPath))?.AsObject()
            ?? throw new InvalidOperationException($"Unable to parse {docFxPath} as a JSON object.");

        if (docFxConfig["metadata"] is not JsonArray metadata)
        {
            metadata = [];
            docFxConfig["metadata"] = metadata;
        }

        foreach (var group in distinctGroups)
        {
            var metadataEntry = BuildDocFxMetadataEntry(group);
            var projectSrc = metadataEntry["src"]?[0]?["src"]?.GetValue<string>();

            var existingEntry = metadata
                .OfType<JsonObject>()
                .FirstOrDefault(entry =>
                    string.Equals(
                        entry["src"]?[0]?["src"]?.GetValue<string>(),
                        projectSrc,
                        StringComparison.Ordinal));

            if (existingEntry is null)
            {
                metadata.Add(metadataEntry);
            }
            else
            {
                existingEntry["src"] = metadataEntry["src"]?.DeepClone();
                existingEntry["dest"] = metadataEntry["dest"]?.DeepClone();
            }
        }

        var docFxContent = docFxConfig.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(docFxPath, docFxContent);

        GenerateModelsIndex(distinctGroups, rootDirectory);
        GenerateModelsToc(distinctGroups, rootDirectory);
    }

    private static JsonObject BuildDocFxMetadataEntry(string projectName)
    {
        string? currentTfm = AppContext.TargetFrameworkName;

        var projectPath = $"{ProjectGenerator.ModelsPath}/{projectName}";
        var assemblyPath = $"/bin/Release/net10.0/{ProjectGenerator.Namespace}.{projectName}.dll";
        var destinationPath = $"{ModelsPath}/{projectName}";

        return new JsonObject
        {
            ["src"] = new JsonArray
            {
                new JsonObject
                {
                    ["src"] = projectPath,
                    ["files"] = new JsonArray(assemblyPath)
                }
            },
            ["dest"] = destinationPath
        };
    }

    private static void GenerateModelsToc(IEnumerable<string> groups, string rootDirectory)
    {
        var apiDirectoryPath = Path.Combine(rootDirectory, ModelsPath);
        Directory.CreateDirectory(apiDirectoryPath);

        var apiTocPath = Path.Combine(apiDirectoryPath, "toc.yml");

        var content = $"""
            items:
            - name: API Reference
              href: index.md

            """;

        foreach (var group in groups)
        {
            content += $"- name: {group}\n";
            content += $"  href: {group}/\n";
        }

        File.WriteAllText(apiTocPath, content.ReplaceLineEndings("\n"));
    }

    private static void GenerateModelsIndex(IEnumerable<string> groups, string rootDirectory)
    {
        var apiDirectoryPath = Path.Combine(rootDirectory, ModelsPath);
        Directory.CreateDirectory(apiDirectoryPath);

        var apiIndexPath = Path.Combine(apiDirectoryPath, "index.md");

       var content = $"""
        # API Reference

        Generated API reference for the configured CRD groups.

        ## Groups


        """;

        foreach (var group in groups)
        {
            var groupDirectoryPath = Path.Combine(apiDirectoryPath, group);
            Directory.CreateDirectory(groupDirectoryPath);

            GenerateGroupIndex(group, groupDirectoryPath);

            content += $"- [{group}]({group}/index.md)\n";
        }

        File.WriteAllText(apiIndexPath, content.ReplaceLineEndings("\n"));
    }

    private static void GenerateGroupIndex(string group, string groupDirectoryPath)
    {
        var groupIndexPath = Path.Combine(groupDirectoryPath, "index.md");

        var content = $"""
            # {group}
            [![Nuget](https://img.shields.io/nuget/v/{ProjectGenerator.Namespace}.{group}.svg?style=flat-square)](https://www.nuget.org/packages/{ProjectGenerator.Namespace}.{group})[![Nuget)](https://img.shields.io/nuget/dt/{ProjectGenerator.Namespace}.{group}.svg?style=flat-square)](https://www.nuget.org/packages/{ProjectGenerator.Namespace}.{group})

            C# models for Kubernetes CRDs in group `{group}`.

            ## Installation

            ```shell
            dotnet add package {ProjectGenerator.Namespace}.{group}
            ```

            [Back to API Reference](../index.md)
            """;

        File.WriteAllText(groupIndexPath, content.ReplaceLineEndings("\n"));
    }
}