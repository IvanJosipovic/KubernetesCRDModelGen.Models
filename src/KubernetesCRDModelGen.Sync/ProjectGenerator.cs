using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.VisualStudio.SolutionPersistence.Serializer;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;

namespace KubernetesCRDModelGen.Sync;

class ProjectGenerator
{
    public static string ModelsPath = "src/Models";

    public static string Namespace = "KubernetesCRDModelGen.Models";

    public static string CRDFolderName = "crds";

    public static async Task<string?> GetLatestNuGetReleaseVersionAsync(
        string packageId,
        bool includePrerelease = false,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(packageId);

        var repositories = Repository.Provider.GetCoreV3();
        var packageSource = new PackageSource("https://api.nuget.org/v3/index.json");
        var sourceRepository = new SourceRepository(packageSource, repositories);

        var metadataResource = await sourceRepository
            .GetResourceAsync<PackageMetadataResource>(cancellationToken)
            .ConfigureAwait(false);

        var metadata = await metadataResource
            .GetMetadataAsync(
                packageId,
                includePrerelease,
                includeUnlisted: false,
                new SourceCacheContext(),
                NullLogger.Instance,
                cancellationToken)
            .ConfigureAwait(false);

        return metadata
            .Where(package => includePrerelease || !package.Identity.Version.IsPrerelease)
            .OrderByDescending(package => package.Identity.Version)
            .Select(package => package.Identity.Version.ToNormalizedString())
            .FirstOrDefault();
    }

    public static async Task GenerateProjectAsync(string projectName, string rootDirectory, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var modelDir = Path.Combine(rootDirectory, ModelsPath);
        Directory.CreateDirectory(modelDir);

        var projectDir = Path.Combine(modelDir, projectName);
        Directory.CreateDirectory(projectDir);

        GenerateCsProj(projectName, projectDir);
        GenerateReadme(projectName, projectDir);

        await GenerateReleasePleaseAsync(projectName, rootDirectory).ConfigureAwait(false);
        await AddProjectsToSolutionAsync(projectName, rootDirectory, cancellationToken).ConfigureAwait(false);
    }

    private static void GenerateReadme(string projectName, string projectDir)
    {
        var readmeContent = $"""
            # {Namespace}.{projectName}
            [![Nuget](https://img.shields.io/nuget/vpre/{Namespace}.{projectName}.svg?style=flat-square)](https://www.nuget.org/packages/{Namespace}.{projectName})[![Nuget)](https://img.shields.io/nuget/dt/{Namespace}.{projectName}.svg?style=flat-square)](https://www.nuget.org/packages/{Namespace}.{projectName})

            C# models for Kubernetes CRDs in group `{projectName}`.

            ## Installation

            ```shell
            dotnet add package {Namespace}.{projectName}
            ```
            """;

        File.WriteAllText(Path.Combine(projectDir, "README.md"), readmeContent);
    }

    private static void GenerateCsProj(string projectName, string projectDir)
    {
        var csprojContent = $"""
            <Project Sdk="Microsoft.NET.Sdk">
                <PropertyGroup>
                    <TargetFrameworks>net8.0;net9.0;net10.0</TargetFrameworks>
                    <PackageId>{Namespace}.{projectName}</PackageId>
                    <RepositoryUrl>https://github.com/IvanJosipovic/{Namespace}</RepositoryUrl>
                    <Description>C# models for Kubernetes CRDs in group {projectName}</Description>
                    <Authors>Ivan Josipovic</Authors>
                    <PackageTags>Kubernetes CustomResourceDefinition CRD Models</PackageTags>
                    <ImplicitUsings>enable</ImplicitUsings>
                    <Nullable>enable</Nullable>
                    <LangVersion>latest</LangVersion>
                    <PackageLicenseExpression>MIT</PackageLicenseExpression>
                    <PublishRepositoryUrl>true</PublishRepositoryUrl>
                    <IncludeSymbols>true</IncludeSymbols>
                    <SymbolPackageFormat>snupkg</SymbolPackageFormat>
                    <IsPackable>true</IsPackable>
                    <GenerateDocumentationFile>true</GenerateDocumentationFile>
                    <PackageReadmeFile>README.md</PackageReadmeFile>
                    <NoWarn>$(NoWarn);CS1591;CS8618</NoWarn>
                    <WarningsAsErrors>$(WarningsAsErrors);CS8784;CS8785</WarningsAsErrors>
                    <EmitCompilerGeneratedFiles>true</EmitCompilerGeneratedFiles>
                    <CompilerGeneratedFilesOutputPath>Generated</CompilerGeneratedFilesOutputPath>
                </PropertyGroup>

                <ItemGroup>
                    <!-- Exclude the output of source generators from the compilation -->
                    <Compile Remove="$(CompilerGeneratedFilesOutputPath)/**/*.cs" />
                </ItemGroup>

                <ItemGroup>
                    <None Include="README.md" Pack="true" PackagePath="\" />
                    <AdditionalFiles Include="{ProjectGenerator.CRDFolderName}\*.yaml" />
                    <None Include="Generated\**\*.*" />
                </ItemGroup>

                <ItemGroup>
                    <PackageReference Include="KubernetesClient" Version="19.0.2"/>
                    <PackageReference Include="KubernetesCRDModelGen.SourceGenerator" Version="1.6.0">
                        <PrivateAssets>all</PrivateAssets>
                    </PackageReference>
                </ItemGroup>

                <ItemGroup Condition="'$(TargetFramework)' == 'net8.0'">
                    <PackageReference Include="System.Text.Json" Version="9.0.*"/>
                </ItemGroup>
            </Project>
            """;
        File.WriteAllText(Path.Combine(projectDir, $"{Namespace}.{projectName}.csproj"), csprojContent);

        var versionFileName = "Directory.Build.props";

        if (!File.Exists(Path.Combine(projectDir, versionFileName)))
        {
            var versionFileContent = $"""
                <Project>
                    <PropertyGroup>
                        <Version>1.0.0</Version>
                    </PropertyGroup>
                </Project>
                """;
            File.WriteAllText(Path.Combine(projectDir, versionFileName), versionFileContent);
        }
    }

    public static async Task GenerateReleasePleaseAsync(string projectName, string rootDirectory)
    {
        var releasePleasePath = Path.Combine(rootDirectory, "release-please-config.json");
        var releasePleaseConfig = File.Exists(releasePleasePath)
            ? JsonNode.Parse(File.ReadAllText(releasePleasePath))?.AsObject()
            : [];

        if (releasePleaseConfig is null)
        {
            throw new InvalidOperationException($"Unable to parse {releasePleasePath} as a JSON object.");
        }

        releasePleaseConfig["$schema"] ??= "https://raw.githubusercontent.com/googleapis/release-please/main/schemas/config.json";

        if (releasePleaseConfig["packages"] is not JsonObject packages)
        {
            packages = [];
            releasePleaseConfig["packages"] = packages;
        }

        var packagePath = $"{ModelsPath}/{projectName}";

        packages[packagePath] = new JsonObject
        {
            ["release-type"] = "simple",
            ["component"] = projectName,
            ["extra-files"] = new JsonArray
            {
                new JsonObject
                {
                    ["type"] = "xml",
                    ["path"] = "Directory.Build.props",
                    ["xpath"] = "//Project/PropertyGroup/Version"
                }
            }
        };

        var jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };
        var releasePleaseContent = releasePleaseConfig.ToJsonString(jsonSerializerOptions);
        File.WriteAllText(releasePleasePath, releasePleaseContent);

        var releasePleaseManifestPath = Path.Combine(rootDirectory, ".release-please-manifest.json");
        var releasePleaseManifest = File.Exists(releasePleaseManifestPath)
            ? JsonNode.Parse(File.ReadAllText(releasePleaseManifestPath))?.AsObject()
            : [];

        if (releasePleaseManifest is null)
        {
            throw new InvalidOperationException($"Unable to parse {releasePleaseManifestPath} as a JSON object.");
        }

        releasePleaseManifest[packagePath] ??= await GetLatestNuGetReleaseVersionAsync($"{Namespace}.{projectName}")
            ?? throw new InvalidOperationException($"Unable to get the latest NuGet release version for package '{Namespace}.{projectName}'.");

        var releasePleaseManifestContent = releasePleaseManifest.ToJsonString(jsonSerializerOptions);
        File.WriteAllText(releasePleaseManifestPath, releasePleaseManifestContent);
    }

    public static void UpdateRootReadmePackageList(IEnumerable<Config> configs, string rootDirectory)
    {
        ArgumentNullException.ThrowIfNull(configs);

        var readmePath = Path.Combine(rootDirectory, "README.md");
        var readmeContent = File.ReadAllText(readmePath);

        const string startMarker = "<!-- StartOfReplace -->";
        const string endMarker = "<!-- EndOfReplace -->";

        var startIndex = readmeContent.IndexOf(startMarker, StringComparison.Ordinal);
        var endIndex = readmeContent.IndexOf(endMarker, StringComparison.Ordinal);

        if (startIndex < 0 || endIndex < 0 || endIndex < startIndex)
        {
            throw new InvalidOperationException($"Unable to find package list replacement markers in {readmePath}.");
        }

        var packageRows = configs
                .Select(config => config.Group)
                .Distinct(StringComparer.Ordinal)
                .Order(StringComparer.Ordinal)
                .Select(projectName =>
                {
                    return $"| `{projectName}` | [Docs](https://ivanjosipovic.github.io/{Namespace}/models/{projectName}) | [![Nuget](https://img.shields.io/nuget/vpre/{Namespace}.{projectName}.svg?style=flat-square)](https://www.nuget.org/packages/{Namespace}.{projectName})[![Nuget)](https://img.shields.io/nuget/dt/{Namespace}.{projectName}.svg?style=flat-square)](https://www.nuget.org/packages/{Namespace}.{projectName}) |";
                }).Aggregate((current, next) => current + "\n" + next);

        var replacementContent = readmeContent[..(startIndex + startMarker.Length)]
            + "\n"
            + "| CRD group | Project docs | NuGet package |\n"
            + "| --- | --- | --- |\n"
            + packageRows
            + readmeContent[endIndex..];

        File.WriteAllText(readmePath, replacementContent);
    }

    public static async Task AddProjectsToSolutionAsync(string projectName, string rootDirectory, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var solutionPath = Path.Combine(rootDirectory, $"{Namespace}.slnx");

        if (!File.Exists(solutionPath))
        {
            throw new FileNotFoundException("Solution file was not found.", solutionPath);
        }

        var serializer = SolutionSerializers.GetSerializerByMoniker(solutionPath)
            ?? throw new InvalidOperationException($"Unable to get a solution serializer for '{solutionPath}'.");

        var solution = await serializer.OpenAsync(solutionPath, cancellationToken).ConfigureAwait(false)
            ?? throw new InvalidOperationException($"Unable to open solution '{solutionPath}'.");

        var solutionProjectPath = $"{ModelsPath}/{projectName}/{Namespace}.{projectName}.csproj";

        if (OperatingSystem.IsWindows())
        {
            solutionProjectPath = solutionProjectPath.Replace('/', '\\');
        }

        if (solution.FindProject(solutionProjectPath) is not null)
        {
            return;
        }

        var modelsFolder = solution.FindFolder($"/{ModelsPath}/")
            ?? solution.AddFolder($"/{ModelsPath}/")
            ?? throw new InvalidOperationException($"Unable to find or create '/{ModelsPath}/' solution folder.");

        solution.AddProject(solutionProjectPath, projectTypeName: null, modelsFolder);
        await serializer.SaveAsync(solutionPath, solution, cancellationToken).ConfigureAwait(false);

    }
}
