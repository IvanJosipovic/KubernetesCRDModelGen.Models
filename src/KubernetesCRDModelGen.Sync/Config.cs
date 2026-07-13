using static KubernetesCRDModelGen.Sync.CRD.CRDDownloader;

namespace KubernetesCRDModelGen.Sync;

/// <summary>
/// Configuration settings for the Kubernetes CRD Model Generator.
/// </summary>
public class Config
{
    /// <summary>
    /// Group identifier.
    /// </summary>
    /// <remarks>This property is required and must be initialized during object creation.</remarks>
    public required string Group { get; set; }

    /// <summary>
    /// Direct URL configurations.
    /// </summary>
    public DirectUrlConfig[] DirectUrl { get; set; } = default!;

    /// <summary>
    /// GitHub configurations.
    /// </summary>
    public GitHubConfig[] GitHub { get; set; } = default!;

    /// <summary>
    /// Helm configurations.
    /// </summary>
    public HelmConfig[] Helm { get; set; } = default!;

    /// <summary>
    /// OCI configurations.
    /// </summary>
    public OCIConfig[] OCI { get; set; } = default!;
}

/// <summary>
/// Configuration settings for direct URL sources.
/// </summary>
public class DirectUrlConfig
{
    /// <summary>
    /// URL to download the resource from, supports .yaml/.yml files or .zip or .tar.gz archives.
    /// </summary>
    /// <remarks>Required and must be initialized during object creation.</remarks>
    public required string Url { get; set; }

    /// <summary>
    /// Regex Filter for Archive Path when extracting from archive (zip, tar.gz, etc.)
    /// </summary>
    public string? ArchivePathRegex { get; set; }

    /// <summary>
    /// Specifies the type of compression used for the resource. Supports None,Zip,TarGz
    /// </summary>
    /// <value></value>
    public CompressionType? CompressionType { get; set; }
}

/// <summary>
/// Configuration settings for GitHub sources.
/// </summary>
public class GitHubConfig
{
    /// <summary>
    /// GitHub Repository in the format of "owner/repo"
    /// </summary>
    public required string Repo { get; set; }

    /// <summary>
    /// Regex Filter for Release Name when selecting releases from a GitHub repository.
    /// </summary>
    public string? ReleaseNameRegex { get; set; }

    /// <summary>
    /// Regex Filter for Asset Name when selecting assets from a GitHub release.
    /// </summary>
    public string? AssetNameRegex { get; set; }

    /// <summary>
    /// Regex Filter for Archive Path when extracting from archive (zip, tar.gz, etc.)
    /// </summary>
    public string? ArchivePathRegex { get; set; }

    /// <summary>
    /// Whether to include pre-release versions when selecting the latest release. If true, pre-release versions will be considered; if false, only stable versions will be considered. If null, the default behavior is to exclude pre-release versions.
    /// </summary>
    public bool? PreRelease { get; set; }

    /// <summary>
    /// Specifies the type of compression used for the resource. Supports None,Zip,TarGz
    /// </summary>
    /// <value></value>
    public CompressionType? CompressionType { get; set; }
}

/// <summary>
/// Configuration settings for Helm sources.
/// </summary>
public class HelmConfig
{
    /// <summary>
    /// Helm Repository URL (e.g., "https://myrepo.com/charts") or OCI Registry URL (e.g., "oci://myregistry.com/myrepo")
    /// </summary>
    public required string Repo { get; set; }

    /// <summary>
    /// Chart name.
    /// </summary>
    /// <remarks>Required during object initialization.</remarks>
    public required string Chart { get; set; }

    /// <summary>
    /// Whether to include pre-release versions when selecting the latest release. If true, pre-release versions will be considered; if false, only stable versions will be considered. If null, the default behavior is to exclude pre-release versions.
    /// </summary>
    public bool? PreRelease { get; set; }

    /// <summary>
    /// Custom arguments to append to the Helm Template command.
    /// </summary>
    /// <value></value>
    public string? AppendArgs { get; set; }

    public bool IsOCI => Repo.StartsWith("oci://");
}

/// <summary>
/// Configuration settings for OCI sources.
/// </summary>
public class OCIConfig
{
    /// <summary>
    /// Image reference.
    /// </summary>
    public required string Image { get; set; }

    /// <summary>
    /// Whether to include pre-release versions when selecting the latest tag. If true, pre-release versions will be considered; if false, only stable versions will be considered. If null, the default behavior is to exclude pre-release versions.
    /// </summary>
    public bool? PreRelease { get; set; }
}

public enum CompressionType
{
    None,
    Zip,
    TarGz
}