namespace KubernetesCRDModelGen.Sync.CRD;

class GitHubReleaseModel
{
    //public string tag_name { get; set; }
    public string name { get; set; } = default!;
    //public bool draft { get; set; }
    public bool prerelease { get; set; } = default!;
    public Asset[] assets { get; set; } = default!;
    //public string tarball_url { get; set; }
    //public string zipball_url { get; set; }

    public class Asset
    {
        public string name { get; set; } = default!;
        public string browser_download_url { get; set; } = default!;
    }
}
