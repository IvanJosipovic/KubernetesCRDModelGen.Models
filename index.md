---
_layout: landing
---
# KubernetesCRDModelGen.Models

Generated C# model packages for Kubernetes CustomResourceDefinitions (CRDs).

This repository uses [`KubernetesCRDModelGen.SourceGenerator`](https://www.nuget.org/packages/KubernetesCRDModelGen.SourceGenerator) to generate strongly typed .NET models from CRD YAML files. Each CRD API group is published as its own NuGet package under the [`KubernetesCRDModelGen.Models.*`](https://www.nuget.org/packages?q=KubernetesCRDModelGen.Models.) package namespace.

## Quick Links

- [Generated Models](models/index.md)
- [Repository documentation](docs/index.md)
- [README](README.md)

## Current Layout

- `docs/` is general repo documentation.
- `models/` is the root Models landing page.
- `models/{group}/` is generated for each configured CRD group.
