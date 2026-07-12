namespace KubernetesCRDModelGen.Sync;

internal class Config
{
    /// <summary>
    /// Gets or sets the group identifier.
    /// </summary>
    /// <remarks>This property is required and must be initialized during object creation.</remarks>
    public required string Group { get; set; }

    public DirectUrlConfig[] DirectUrl { get; set; }

    public GitHubConfig[] GitHub { get; set; }

    public HelmConfig[] Helm { get; set; }

    public OCIConfig[] OCI { get; set; }

    internal class DirectUrlConfig
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <remarks>Required and must be initialized during object creation.</remarks>
        public required string Url { get; set; }

        /// <summary>
        /// Regex Filter for Archive Path when extracting from archive (zip, tar.gz, etc.)
        /// </summary>
        public string? ArchivePathRegex { get; set; }
    }

    internal class GitHubConfig
    {
        /// <summary>
        /// GitHub Repository in the format of "owner/repo"
        /// </summary>
        public required string Repo { get; set; }

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
    }

    internal class HelmConfig
    {
        /// <summary>
        /// Helm Repository URL (e.g., "https://myrepo.com/charts") or OCI Registry URL (e.g., "oci://myregistry.com/myrepo")
        /// </summary>
        public required string Repo { get; set; }

        /// <summary>
        /// Gets or sets the chart name.
        /// </summary>
        /// <remarks>Required during object initialization.</remarks>
        public required string Chart { get; set; }

        /// <summary>
        /// Whether to include pre-release versions when selecting the latest release. If true, pre-release versions will be considered; if false, only stable versions will be considered. If null, the default behavior is to exclude pre-release versions.
        /// </summary>
        public bool? PreRelease { get; set; }

        public string? CMD { get; set; }

        public bool IsOCI => Repo.StartsWith("oci://");
    }

    internal class OCIConfig
    {
        /// <summary>
        /// Gets or sets the image reference.
        /// </summary>
        public required string Image { get; set; }

        /// <summary>
        /// Whether to include pre-release versions when selecting the latest tag. If true, pre-release versions will be considered; if false, only stable versions will be considered. If null, the default behavior is to exclude pre-release versions.
        /// </summary>
        public bool? PreRelease { get; set; }
    }
}
