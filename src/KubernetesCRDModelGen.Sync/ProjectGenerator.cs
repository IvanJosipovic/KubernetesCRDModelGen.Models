using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.VisualStudio.SolutionPersistence.Serializer;

namespace KubernetesCRDModelGen.Sync;

internal class ProjectGenerator
{
    private static string ModelsPath = "src/Models";

    public static void GenerateProject(string projectName, string rootDirectory)
    {
        var modelDir = Path.Combine(rootDirectory, ModelsPath);
        Directory.CreateDirectory(modelDir);

        var projectDir = Path.Combine(modelDir, projectName);
        Directory.CreateDirectory(projectDir);

        GenerateCsProj(projectName, projectDir);
        GenerateReadme(projectName, projectDir);

        GenerateReleasePlease(projectName, rootDirectory);
        AddProjectsToSolution(projectName, rootDirectory).GetAwaiter().GetResult();
    }

    private static void GenerateReadme(string projectName, string projectDir)
    {
        var readmeContent = $"""
            # KubernetesCRDModelGen.Models.{projectName}
            [![Nuget](https://img.shields.io/nuget/vpre/KubernetesCRDModelGen.Models.{projectName}.svg?style=flat-square)](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.{projectName})[![Nuget)](https://img.shields.io/nuget/dt/KubernetesCRDModelGen.Models.{projectName}.svg?style=flat-square)](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.{projectName})

            C# models for Kubernetes CRDs in group `{projectName}`.

            ## Installation

            ```shell
            dotnet add package KubernetesCRDModelGen.Models.{projectName}
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
                    <PackageId>KubernetesCRDModelGen.Models.{projectName}</PackageId>
                    <RepositoryUrl>https://github.com/IvanJosipovic/KubernetesCRDModelGen.Models</RepositoryUrl>
                    <Description>C# models for Kubernetes CRDs in group {projectName}</Description>
                    <Authors>Ivan Josipovic</Authors>
                    <PackageTags>Kubernetes CustomResourceDefinition CRD Models</PackageTags>
                    <ImplicitUsings>enable</ImplicitUsings>
                    <Nullable>enable</Nullable>
                    <LangVersion>latest</LangVersion>
                    <RepositoryType>git</RepositoryType>
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
                    <AdditionalFiles Include="crds\*.yaml" />
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
        File.WriteAllText(Path.Combine(projectDir, $"KubernetesCRDModelGen.Models.{projectName}.csproj"), csprojContent);

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

    public static void GenerateReleasePlease(string projectName, string rootDirectory)
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

        var packagePath = "src/Models/" + projectName;

        packages[packagePath] = new JsonObject
        {
            ["release-type"] = "simple",
            ["component"] = projectName,
            ["extra-files"] = new JsonArray
            {
                new JsonObject
                {
                    ["type"] = "xml",
                    ["path"] = $"{packagePath}/Directory.Build.props",
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

        releasePleaseManifest[packagePath] ??= "1.0.0";

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
                    var packageId = $"KubernetesCRDModelGen.Models.{projectName}";
                    var packagePath = $"/{ModelsPath}/{projectName}";

                    return $"| `{projectName}` | [{packagePath}]({packagePath}) | [{packageId}](https://www.nuget.org/packages/{packageId}) |";
                }).Aggregate((current, next) => current + "\r\n" + next);

        var replacementContent = readmeContent[..(startIndex + startMarker.Length)]
            + "\r\n"
            + """
            | CRD group | Project path | NuGet package |
            | --- | --- | --- |
            """
            + "\r\n"
            + packageRows
            + readmeContent[endIndex..];

        File.WriteAllText(readmePath, replacementContent);
    }

    public static async Task AddProjectsToSolution(string projectName, string rootDirectory, CancellationToken cancellationToken = default)
    {
        var solutionPath = Path.Combine(rootDirectory, "KubernetesCRDModelGen.Models.slnx");

        if (!File.Exists(solutionPath))
        {
            throw new FileNotFoundException("Solution file was not found.", solutionPath);
        }

        var serializer = SolutionSerializers.GetSerializerByMoniker(solutionPath);
        var solution = await serializer.OpenAsync(solutionPath, cancellationToken).ConfigureAwait(false);

        var solutionProjectPath = $"{ModelsPath}/{projectName}/KubernetesCRDModelGen.Models.{projectName}.csproj".Replace('/', '\\');
        if (solution.FindProject(solutionProjectPath) is not null)
        {
            return;
        }

        var modelsFolder = solution.FindFolder("/src/Models/");

        modelsFolder ??= solution.AddFolder("/src/Models/");

        solution.AddProject(solutionProjectPath, projectTypeName: null, modelsFolder);
        await serializer.SaveAsync(solutionPath, solution, cancellationToken).ConfigureAwait(false);

    }
}
