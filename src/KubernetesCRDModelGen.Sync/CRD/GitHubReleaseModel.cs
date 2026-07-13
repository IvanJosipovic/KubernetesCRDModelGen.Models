namespace KubernetesCRDModelGen.Sync.CRD;

class GitHubReleaseModel
{
    //public string tag_name { get; set; }
    internal string name { get; set; } = default!;
    //public bool draft { get; set; }
    internal bool prerelease { get; set; } = default!;
    internal Asset[] assets { get; set; } = default!;
    //public string tarball_url { get; set; }
    //public string zipball_url { get; set; }

    internal class Asset
    {
        internal string name { get; set; } = default!;
        internal string browser_download_url { get; set; } = default!;
    }
}
