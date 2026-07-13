# Getting Started

## Updating the repository

Run the sync worker from the repository root:

```shell
dotnet run --project .\src\KubernetesCRDModelGen.Sync\KubernetesCRDModelGen.Sync.csproj -- --contentRoot $PWD
```

The worker updates generated projects, release-please files, the README package table, and the DocFX API pages.
