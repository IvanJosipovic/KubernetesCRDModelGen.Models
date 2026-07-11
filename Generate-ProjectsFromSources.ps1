[CmdletBinding()]
param(
    [string]$SourcesFile = (Join-Path $PSScriptRoot 'sources.json'),
    [string]$SrcDirectory = (Join-Path $PSScriptRoot 'src\Models'),
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

# Do not merge existing release-please files. Preserve only an existing '$schema' if present,
# but always regenerate and overwrite the config and manifest from sources.
$releasePleaseSchema = $null
if (Test-Path -LiteralPath $ReleasePleaseConfigFile) {
    $existing = Get-Content -LiteralPath $ReleasePleaseConfigFile -Raw | ConvertFrom-Json -AsHashtable
    if ($existing -ne $null -and $existing.ContainsKey('$schema')) {
        $releasePleaseSchema = $existing['$schema']
    }
}

$releasePleaseConfig = [ordered]@{
    '$schema' = $releasePleaseSchema
    'packages' = [ordered]@{}
}

$releasePleaseManifest = $null
if (Test-Path -LiteralPath $ReleasePleaseManifestFile) {
    $releasePleaseManifest = Get-Content -LiteralPath $ReleasePleaseManifestFile -Raw | ConvertFrom-Json -AsHashtable
}

if ($releasePleaseManifest -eq $null) {
    $releasePleaseManifest = [ordered]@{}
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
    $releasePleasePath = "src/Models/$group"

    if (-not (Test-Path -LiteralPath $groupDirectory)) {
        New-Item -ItemType Directory -Path $groupDirectory | Out-Null
    }

        $projectContent = @'
<Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <PackageId>{0}</PackageId>
    </PropertyGroup>

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
'@ -f $projectName

    # Always write/overwrite the project file on each run, but do not overwrite Version.Build.props
    $projectExisted = Test-Path -LiteralPath $projectFile
    Set-Content -LiteralPath $projectFile -Value $projectContent -NoNewline
    if ($projectExisted) {
        Write-Host "Overwrote $projectFile"
    }
    else {
        Write-Host "Wrote $projectFile"
    }

    # Also write Directory.Build.props containing the Version property if it doesn't exist.
    $propsFile = Join-Path $groupDirectory 'Directory.Build.props'
    $propsContent = @'
<Project>
    <PropertyGroup>
        <Version>1.0.0</Version>
    </PropertyGroup>
</Project>
'@

    if (Test-Path -LiteralPath $propsFile) {
        Write-Host "Left existing $propsFile"
    }
    else {
        Set-Content -LiteralPath $propsFile -Value $propsContent -NoNewline
        Write-Host "Wrote $propsFile"
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

    $releasePleaseConfig['packages'][$releasePleasePath] = [ordered]@{
        'release-type' = 'simple'
        'component' = $group
        'extra-files' = @(
            [ordered]@{
                'type' = 'xml'
                'path' = "src/Models/$($group)/Directory.Build.props"
                'xpath' = '//Project/PropertyGroup/Version'
            }
        )
    }

    Write-Host "Added $releasePleasePath to $ReleasePleaseConfigFile"

    if (-not $releasePleaseManifest.ContainsKey($releasePleasePath)) {
        $releasePleaseManifest[$releasePleasePath] = '1.0.0'
        Write-Host "Added $releasePleasePath to $ReleasePleaseManifestFile"
    }
    else {
        Write-Host "Already in release-please manifest $releasePleasePath"
    }
}

# Always overwrite release-please config file (do not merge)
$sortedPackages = [ordered]@{}
foreach ($packagePath in ($releasePleaseConfig['packages'].Keys | Sort-Object)) {
    $sortedPackages[$packagePath] = $releasePleaseConfig['packages'][$packagePath]
}

$releasePleaseConfig = [ordered]@{
    '$schema' = $releasePleaseConfig['$schema']
    'packages' = $sortedPackages
}

$releasePleaseJson = ConvertTo-JsonContent -InputObject $releasePleaseConfig
Set-Content -LiteralPath $ReleasePleaseConfigFile -Value $releasePleaseJson -NoNewline
Write-Host "Wrote $ReleasePleaseConfigFile (overwritten)"

# Always overwrite release-please manifest file (do not merge)
$sortedManifest = [ordered]@{}
foreach ($manifestPath in ($releasePleaseManifest.Keys | Sort-Object)) {
    $sortedManifest[$manifestPath] = $releasePleaseManifest[$manifestPath]
}

$releasePleaseManifestJson = ConvertTo-JsonContent -InputObject $sortedManifest
Set-Content -LiteralPath $ReleasePleaseManifestFile -Value $releasePleaseManifestJson -NoNewline
Write-Host "Wrote $ReleasePleaseManifestFile (overwritten)"

if (Set-JsonFileIfChanged -Path $SourcesFile -InputObject $sortedSources) {
    Write-Host "Sorted and wrote $SourcesFile"
}