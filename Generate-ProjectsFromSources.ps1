[CmdletBinding()]
param(
    [string]$SourcesFile = (Join-Path $PSScriptRoot 'sources.json'),
    [string]$SrcDirectory = (Join-Path $PSScriptRoot 'src'),
    [string]$SolutionFile = (Join-Path $PSScriptRoot 'KubernetesCRDModelGen.Models.slnx'),
    [string]$ReleasePleaseConfigFile = (Join-Path $PSScriptRoot 'release-please-config.json'),
    [string]$ReleasePleaseManifestFile = (Join-Path $PSScriptRoot '.release-please-manifest.json')
)

$ErrorActionPreference = 'Stop'

function ConvertTo-JsonContent {
    param(
        [Parameter(Mandatory)]
        [object]$InputObject
    )

    return ($InputObject | ConvertTo-Json -Depth 10)
}

function Set-JsonFileIfChanged {
    param(
        [Parameter(Mandatory)]
        [string]$Path,

        [Parameter(Mandatory)]
        [object]$InputObject
    )

    $newContent = ConvertTo-JsonContent -InputObject $InputObject
    $existingContent = if (Test-Path -LiteralPath $Path) {
        Get-Content -LiteralPath $Path -Raw
    }
    else {
        $null
    }

    if ($existingContent -ne $newContent) {
        Set-Content -LiteralPath $Path -Value $newContent
        return $true
    }

    return $false
}

if (-not (Test-Path -LiteralPath $SourcesFile)) {
    throw "sources.json was not found at '$SourcesFile'."
}

if (-not (Test-Path -LiteralPath $SrcDirectory)) {
    New-Item -ItemType Directory -Path $SrcDirectory | Out-Null
}

$releasePleaseConfig = $null
$releasePleaseManifest = $null
$releasePleaseConfigChanged = $false
$releasePleaseManifestChanged = $false

if (Test-Path -LiteralPath $ReleasePleaseConfigFile) {
    $releasePleaseConfig = Get-Content -LiteralPath $ReleasePleaseConfigFile -Raw | ConvertFrom-Json -AsHashtable
    if (-not $releasePleaseConfig.ContainsKey('packages')) {
        $releasePleaseConfig['packages'] = [ordered]@{}
    }
}

if (Test-Path -LiteralPath $ReleasePleaseManifestFile) {
    $releasePleaseManifest = Get-Content -LiteralPath $ReleasePleaseManifestFile -Raw | ConvertFrom-Json -AsHashtable
}

$sources = Get-Content -LiteralPath $SourcesFile -Raw | ConvertFrom-Json
$sortedSources = @($sources | Sort-Object group)

$existingProjects = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::OrdinalIgnoreCase)

if (Test-Path -LiteralPath $SolutionFile) {
    $solutionListOutput = & dotnet sln $SolutionFile list
    if ($LASTEXITCODE -ne 0) {
        throw "Failed to read solution projects from '$SolutionFile'."
    }

    foreach ($line in $solutionListOutput) {
        $projectPath = $line.Trim()
        if ($projectPath -like '*.csproj') {
            [void]$existingProjects.Add($projectPath.Replace('/', '\'))
        }
    }
}

foreach ($source in $sortedSources) {
    if ([string]::IsNullOrWhiteSpace($source.group)) {
        throw 'Each sources.json entry must include a non-empty group value.'
    }

    $group = $source.group.Trim()
    $groupDirectory = Join-Path $SrcDirectory $group
    $projectName = "KubernetesCRDModelGen.Models.$group"
    $projectFile = Join-Path $groupDirectory "$projectName.csproj"
    $releasePleasePath = "src/$group"

    if (-not (Test-Path -LiteralPath $groupDirectory)) {
        New-Item -ItemType Directory -Path $groupDirectory | Out-Null
    }

        $projectContent = @'
<Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <PackageId>{0}</PackageId>
        <Version>1.0.0</Version>
    </PropertyGroup>

    <ItemGroup>
        <PackageReference Include="KubernetesClient" Version="19.0.2" />
        <PackageReference Include="KubernetesCRDModelGen.SourceGenerator" Version="1.6.0">
            <PrivateAssets>all</PrivateAssets>
        </PackageReference>
    </ItemGroup>

    <ItemGroup Condition="'$(TargetFramework)' == 'net8.0'">
        <PackageReference Include="System.Text.Json" Version="9.0.*" />
    </ItemGroup>

</Project>
'@ -f $projectName

    if (Test-Path -LiteralPath $projectFile) {
        Write-Host "Skipped existing $projectFile"
    }
    else {
        Set-Content -LiteralPath $projectFile -Value $projectContent -NoNewline
        Write-Host "Wrote $projectFile"
    }

    if (Test-Path -LiteralPath $SolutionFile) {
        $relativeProjectPath = [System.IO.Path]::GetRelativePath($PSScriptRoot, $projectFile).Replace('/', '\')
        if (-not $existingProjects.Contains($relativeProjectPath)) {
            $null = & dotnet sln $SolutionFile add $projectFile
            if ($LASTEXITCODE -ne 0) {
                throw "Failed to add '$projectFile' to solution '$SolutionFile'."
            }

            [void]$existingProjects.Add($relativeProjectPath)
            Write-Host "Added $relativeProjectPath to $SolutionFile"
        }
        else {
            Write-Host "Already in solution $relativeProjectPath"
        }
    }

    if ($null -ne $releasePleaseConfig) {
        if (-not $releasePleaseConfig['packages'].ContainsKey($releasePleasePath)) {
            $releasePleaseConfig['packages'][$releasePleasePath] = [ordered]@{
                'release-type' = 'simple'
                'component' = $group
                'changelog-path' = 'CHANGELOG.md'
                'extra-files' = @(
                    [ordered]@{
                        'type' = 'xml'
                        'path' = '*.csproj'
                        'xpath' = '/Project/PropertyGroup/Version'
                        'glob' = $true
                    }
                )
            }
            $releasePleaseConfigChanged = $true
            Write-Host "Added $releasePleasePath to $ReleasePleaseConfigFile"
        }
        else {
            Write-Host "Already in release-please config $releasePleasePath"
        }
    }

    if ($null -ne $releasePleaseManifest) {
        if (-not $releasePleaseManifest.ContainsKey($releasePleasePath)) {
            $releasePleaseManifest[$releasePleasePath] = '1.0.0'
            $releasePleaseManifestChanged = $true
            Write-Host "Added $releasePleasePath to $ReleasePleaseManifestFile"
        }
        else {
            Write-Host "Already in release-please manifest $releasePleasePath"
        }
    }
}

if ($null -ne $releasePleaseConfig) {
    $sortedPackages = [ordered]@{}
    foreach ($packagePath in ($releasePleaseConfig['packages'].Keys | Sort-Object)) {
        $sortedPackages[$packagePath] = $releasePleaseConfig['packages'][$packagePath]
    }

    $releasePleaseConfig = [ordered]@{
        '$schema' = $releasePleaseConfig['$schema']
        'packages' = $sortedPackages
    }

    if (Set-JsonFileIfChanged -Path $ReleasePleaseConfigFile -InputObject $releasePleaseConfig) {
        $releasePleaseConfigChanged = $true
        Write-Host "Sorted and wrote $ReleasePleaseConfigFile"
    }
}

if ($null -ne $releasePleaseManifest) {
    $sortedManifest = [ordered]@{}
    foreach ($manifestPath in ($releasePleaseManifest.Keys | Sort-Object)) {
        $sortedManifest[$manifestPath] = $releasePleaseManifest[$manifestPath]
    }

    if (Set-JsonFileIfChanged -Path $ReleasePleaseManifestFile -InputObject $sortedManifest) {
        $releasePleaseManifestChanged = $true
        Write-Host "Sorted and wrote $ReleasePleaseManifestFile"
    }
}

if (Set-JsonFileIfChanged -Path $SourcesFile -InputObject $sortedSources) {
    Write-Host "Sorted and wrote $SourcesFile"
}