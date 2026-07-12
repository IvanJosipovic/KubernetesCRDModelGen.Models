# KubernetesCRDModelGen.Models

Generated C# model packages for Kubernetes CustomResourceDefinitions (CRDs).

This repository uses [`KubernetesCRDModelGen.SourceGenerator`](https://www.nuget.org/packages/KubernetesCRDModelGen.SourceGenerator) to generate strongly typed .NET models from CRD YAML files. Each CRD API group is published as its own NuGet package under the [`KubernetesCRDModelGen.Models.*`](https://www.nuget.org/packages?q=KubernetesCRDModelGen.Models.) package namespace.

## Packages

Generated packages follow this layout:
<!-- StartOfReplace -->
| CRD group | Project path | NuGet package |
| --- | --- | --- |
| `akuity.io` | [/src/Models/KubernetesCRDModelGen.Models.akuity.io](/src/Models/KubernetesCRDModelGen.Models.akuity.io) | [KubernetesCRDModelGen.Models.akuity.io](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.akuity.io) |
| `aquasecurity.github.io` | [/src/Models/KubernetesCRDModelGen.Models.aquasecurity.github.io](/src/Models/KubernetesCRDModelGen.Models.aquasecurity.github.io) | [KubernetesCRDModelGen.Models.aquasecurity.github.io](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.aquasecurity.github.io) |<!-- EndOfReplace -->

New groups are generated into `src/Models/{group}` and are automatically added to the solution, release-please configuration, and release-please manifest.

## Using a generated package

Install the package for the CRD group you need:

```shell
dotnet add package KubernetesCRDModelGen.Models.aquasecurity.github.io
```

Then reference the generated model types from your application alongside the official Kubernetes .NET client.

## Repository layout

```text
.
├── sources.json                                             # CRD source configuration
├── release-please-config.json                               # release-please package configuration
├── .release-please-manifest.json                            # release-please package versions
├── src/
│   ├── KubernetesCRDModelGen.Sync/                          # Worker service that generates projects and CRD inputs
│   └── Models/                                              # Generated model package projects
│       └── {group}/
│           ├── crds/                                        # CRD YAML inputs
│           ├── Directory.Build.props                        # Package version
│           ├── KubernetesCRDModelGen.Models.{group}.csproj  # Group C# Project
│           └── README.md                                    # Group Project Readme
```

## Updating generated projects

The sync worker reads `sources.json`, creates package projects for configured CRD groups, updates release-please files, and adds generated projects to `KubernetesCRDModelGen.Models.slnx`.

Run the worker from the repository root:

```shell
dotnet run --project src/KubernetesCRDModelGen.Sync -- --RootDirectory "C:\repos\KubernetesCRDModelGen.Models"
```

The `RootDirectory` value should point to this repository root.

## Source configuration

CRD sources are configured in `sources.json`. Each entry represents one CRD API group and can use direct URLs, GitHub releases, Helm charts, or OCI artifacts depending on the source.

```json
{
  "RootDirectory": "C:\\repos\\KubernetesCRDModelGen.Models",
  "Config": [
    {
      "group": "aquasecurity.github.io",
      "helm": [
        {
          "repo": "https://aquasecurity.github.io/helm-charts/",
          "chart": "trivy-operator"
        }
      ]
    }
  ]
}
```

## Building

Build the solution:

```shell
dotnet build KubernetesCRDModelGen.Models.slnx
```

Pack a generated model project:

```shell
dotnet pack src/Models/aquasecurity.github.io/KubernetesCRDModelGen.Models.aquasecurity.github.io.csproj -c Release
```

## Releases

Releases are managed by release-please.

- `release-please-config.json` defines each package path and version file.
- `.release-please-manifest.json` tracks the current released version for each package.
- Each generated project stores its package version in `Directory.Build.props`.

## Requirements

- .NET SDK compatible with the solution target frameworks
- Helm, when using Helm chart sources
- Network access to configured CRD sources

## License

This project is licensed under the MIT License.
