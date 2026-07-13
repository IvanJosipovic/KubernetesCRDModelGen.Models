# KubernetesCRDModelGen.Models

Generated C# model packages for Kubernetes CustomResourceDefinitions (CRDs).

This repository uses [`KubernetesCRDModelGen`](https://www.nuget.org/packages/KubernetesCRDModelGen) to generate strongly typed .NET models from CRD YAML files.

Each CRD API group is published as its own NuGet package under the [`KubernetesCRDModelGen.Models.*`](https://www.nuget.org/packages?q=KubernetesCRDModelGen.Models.) package namespace.

[Documentation](https://ivanjosipovic.github.io/KubernetesCRDModelGen.Models/)

## Generated Packages
<!-- StartOfReplace -->
| CRD group | Project docs | NuGet package |
| --- | --- | --- |
| `akuity.io` | [Docs](https://ivanjosipovic.github.io/KubernetesCRDModelGen.Models/models/akuity.io) | [KubernetesCRDModelGen.Models.akuity.io](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.akuity.io) |
| `aquasecurity.github.io` | [Docs](https://ivanjosipovic.github.io/KubernetesCRDModelGen.Models/models/aquasecurity.github.io) | [KubernetesCRDModelGen.Models.aquasecurity.github.io](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.aquasecurity.github.io) |
| `k8s.aws` | [Docs](https://ivanjosipovic.github.io/KubernetesCRDModelGen.Models/models/k8s.aws) | [KubernetesCRDModelGen.Models.k8s.aws](https://www.nuget.org/packages/KubernetesCRDModelGen.Models.k8s.aws) |<!-- EndOfReplace -->

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
├── src/
│   ├── KubernetesCRDModelGen.Sync/                          # Worker service that generates projects sync CRDs
│   └── Models/                                              # Generated model package projects
│       └── {group}/
│           ├── crds/                                        # CRD YAML inputs
|           ├── Generated/                                   # Generated C# Models
│           ├── Directory.Build.props                        # Package version
│           ├── KubernetesCRDModelGen.Models.{group}.csproj  # Group C# Project
│           └── README.md                                    # Group Project Readme
```

## Source configuration

CRD sources are configured in `sources.json`. Each entry in the `Config` array represents one CRD API group and can use direct URLs, GitHub releases, Helm charts, or OCI artifacts depending on the source.

The current file includes examples like these:

```json
{
  "Config": [
    {
      "Group": "cnrm.cloud.google.com",
      "DirectUrl": [
        {
          "Url": "https://github.com/GoogleCloudPlatform/k8s-config-connector/archive/refs/heads/master.zip",
          "ArchivePathRegex": "k8s-config-connector-master/config/crds/resources/"
        }
      ]
    },
    {
      "Group": "knative.dev",
      "GitHub": [
        {
          "Repo": "knative/serving",
          "AssetNameRegex": "serving-crds\\.yaml"
        },
        {
          "Repo": "knative/eventing",
          "AssetNameRegex": "eventing-crds\\.yaml"
        }
      ]
    },
    {
      "Group": "aquasecurity.github.io",
      "Helm": [
        {
          "Chart": "trivy-operator",
          "Repo": "https://aquasecurity.github.io/helm-charts/"
        }
      ]
    },
    {
      "Group": "databricks.upbound.io",
      "OCI": [
        {
          "Image": "xpkg.upbound.io/upbound/provider-databricks"
        }
      ]
    }
  ]
}
```

For a live source file, see [sources.json](sources.json).

## To add a new Source

Update [sources.json](sources.json) with the required configuration. See [sources.schema.json](sources.schema.json) and PR the changes to main.

## Manually Updating generated projects

The sync worker reads `sources.json`, creates package projects for configured CRD groups, updates release-please files, updates the README package table, and generates the DocFX API landing pages.

Run the worker from the repository root:

```shell
dotnet run --project .\src\KubernetesCRDModelGen.Sync\KubernetesCRDModelGen.Sync.csproj -- --contentRoot $PWD
```

The `contentRoot` value should point to this repository root.

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
