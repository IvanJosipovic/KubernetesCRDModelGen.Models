#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.argoproj.io;
/// <summary>WorkflowEventBinding is the definition of an event resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowEventBindingList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1WorkflowEventBinding>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowEventBindingList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "workfloweventbindings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "argoproj.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkflowEventBindingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1WorkflowEventBinding objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1WorkflowEventBinding> Items { get; set; }
}

/// <summary>Event is the event to bind to</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecEvent
{
    /// <summary>Selector (https://github.com/expr-lang/expr) that we must must match the event. E.g. `payload.message == &quot;test&quot;`</summary>
    [JsonPropertyName("selector")]
    public required string Selector { get; set; }
}

/// <summary>
/// NoneStrategy indicates to skip tar process and upload the files or directory tree as independent
/// files. Note that if the artifact is a directory, the artifact driver must support the ability to
/// save/load the directory appropriately.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveNone
{
}

/// <summary>TarStrategy will tar and gzip the file or directory when saving</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveTar
{
    /// <summary>
    /// CompressionLevel specifies the gzip compression level to use for the artifact.
    /// Defaults to gzip.DefaultCompression.
    /// </summary>
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

/// <summary>ZipStrategy will unzip zipped input artifacts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveZip
{
}

/// <summary>Archive controls how the artifact will be saved to the artifact repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchive
{
    /// <summary>
    /// NoneStrategy indicates to skip tar process and upload the files or directory tree as independent
    /// files. Note that if the artifact is a directory, the artifact driver must support the ability to
    /// save/load the directory appropriately.
    /// </summary>
    [JsonPropertyName("none")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveNone? None { get; set; }

    /// <summary>TarStrategy will tar and gzip the file or directory when saving</summary>
    [JsonPropertyName("tar")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveTar? Tar { get; set; }

    /// <summary>ZipStrategy will unzip zipped input artifacts</summary>
    [JsonPropertyName("zip")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchiveZip? Zip { get; set; }
}

/// <summary>PodMetadata is an optional field for specifying the Labels and Annotations that should be assigned to the Pod doing the deletion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactGCPodMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>ArtifactGC describes the strategy to use when to deleting an artifact from completed or deleted workflows</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactGC
{
    /// <summary>PodMetadata is an optional field for specifying the Labels and Annotations that should be assigned to the Pod doing the deletion</summary>
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    /// <summary>ServiceAccountName is an optional field for specifying the Service Account that should be assigned to the Pod doing the deletion</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>Strategy is the strategy to use.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary>PasswordSecret is the secret selector to the repository password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactoryPasswordSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>UsernameSecret is the secret selector to the repository username</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactoryUsernameSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Artifactory contains artifactory artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactory
{
    /// <summary>PasswordSecret is the secret selector to the repository password</summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    /// <summary>URL of the artifact</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>UsernameSecret is the secret selector to the repository username</summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

/// <summary>AccountKeySecret is the secret selector to the Azure Blob Storage account access key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsAzureAccountKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Azure contains Azure Storage artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsAzure
{
    /// <summary>AccountKeySecret is the secret selector to the Azure Blob Storage account access key</summary>
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

    /// <summary>Blob is the blob name (i.e., path) in the container where the artifact resides</summary>
    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    /// <summary>Container is the container where resources will be stored</summary>
    [JsonPropertyName("container")]
    public required string Container { get; set; }

    /// <summary>Endpoint is the service url associated with an account. It is most likely &quot;https://&lt;ACCOUNT_NAME&gt;.blob.core.windows.net&quot;</summary>
    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    /// <summary>UseSDKCreds tells the driver to figure out credentials based on sdk defaults.</summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

/// <summary>ServiceAccountKeySecret is the secret selector to the bucket&apos;s service account key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGcsServiceAccountKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>GCS contains GCS artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGcs
{
    /// <summary>Bucket is the name of the bucket</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Key is the path in the bucket where the artifact resides</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>ServiceAccountKeySecret is the secret selector to the bucket&apos;s service account key</summary>
    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

/// <summary>PasswordSecret is the secret selector to the repository password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitPasswordSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>SSHPrivateKeySecret is the secret selector to the repository ssh private key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitSshPrivateKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>UsernameSecret is the secret selector to the repository username</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitUsernameSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Git contains git artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGit
{
    /// <summary>Branch is the branch to fetch when `SingleBranch` is enabled</summary>
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    /// <summary>
    /// Depth specifies clones/fetches should be shallow and include the given
    /// number of commits from the branch tip
    /// </summary>
    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    /// <summary>DisableSubmodules disables submodules during git clone</summary>
    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    /// <summary>Fetch specifies a number of refs that should be fetched before checkout</summary>
    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    /// <summary>InsecureIgnoreHostKey disables SSH strict host key checking during git clone</summary>
    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    /// <summary>InsecureSkipTLS disables server certificate verification resulting in insecure HTTPS connections</summary>
    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    /// <summary>PasswordSecret is the secret selector to the repository password</summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitPasswordSecret? PasswordSecret { get; set; }

    /// <summary>Repo is the git repository</summary>
    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    /// <summary>Revision is the git commit, tag, branch to checkout</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>SingleBranch enables single branch clone, using the `branch` parameter</summary>
    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    /// <summary>SSHPrivateKeySecret is the secret selector to the repository ssh private key</summary>
    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    /// <summary>UsernameSecret is the secret selector to the repository username</summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}

/// <summary>
/// KrbCCacheSecret is the secret selector for Kerberos ccache
/// Either ccache or keytab can be set to use Kerberos.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbCCacheSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>
/// KrbConfig is the configmap selector for Kerberos config as string
/// It must be set if either ccache or keytab is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbConfigConfigMap
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>
/// KrbKeytabSecret is the secret selector for Kerberos keytab
/// Either ccache or keytab can be set to use Kerberos.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbKeytabSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>HDFS contains HDFS artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfs
{
    /// <summary>Addresses is accessible addresses of HDFS name nodes</summary>
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    /// <summary>
    /// DataTransferProtection is the protection level for HDFS data transfer.
    /// It corresponds to the dfs.data.transfer.protection configuration in HDFS.
    /// </summary>
    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    /// <summary>Force copies a file forcibly even if it exists</summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    /// <summary>
    /// HDFSUser is the user to access HDFS file system.
    /// It is ignored if either ccache or keytab is used.
    /// </summary>
    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    /// <summary>
    /// KrbCCacheSecret is the secret selector for Kerberos ccache
    /// Either ccache or keytab can be set to use Kerberos.
    /// </summary>
    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    /// <summary>
    /// KrbConfig is the configmap selector for Kerberos config as string
    /// It must be set if either ccache or keytab is used.
    /// </summary>
    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    /// <summary>
    /// KrbKeytabSecret is the secret selector for Kerberos keytab
    /// Either ccache or keytab can be set to use Kerberos.
    /// </summary>
    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    /// <summary>
    /// KrbRealm is the Kerberos realm used with Kerberos keytab
    /// It must be set if keytab is used.
    /// </summary>
    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    /// <summary>
    /// KrbServicePrincipalName is the principal name of Kerberos service
    /// It must be set if either ccache or keytab is used.
    /// </summary>
    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    /// <summary>
    /// KrbUsername is the Kerberos username used with Kerberos keytab
    /// It must be set if keytab is used.
    /// </summary>
    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    /// <summary>Path is a file path in HDFS</summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

/// <summary>PasswordSecret is the secret selector to the repository password</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuthPasswordSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>UsernameSecret is the secret selector to the repository username</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuthUsernameSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>BasicAuth describes the secret selectors required for basic authentication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuth
{
    /// <summary>PasswordSecret is the secret selector to the repository password</summary>
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    /// <summary>UsernameSecret is the secret selector to the repository username</summary>
    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

/// <summary>SecretKeySelector selects a key of a Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCertClientCertSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>SecretKeySelector selects a key of a Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCertClientKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ClientCertAuth holds necessary information for client authentication via certificates</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCert
{
    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

/// <summary>SecretKeySelector selects a key of a Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2ClientIDSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>SecretKeySelector selects a key of a Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2ClientSecretSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>EndpointParam is for requesting optional fields that should be sent in the oauth request</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2EndpointParams
{
    /// <summary>Name is the header name</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Value is the literal value to use for the header</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>SecretKeySelector selects a key of a Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2TokenURLSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>OAuth2Auth holds all information for client authentication via OAuth2 tokens</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2
{
    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

/// <summary>Auth contains information for client authentication</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuth
{
    /// <summary>BasicAuth describes the secret selectors required for basic authentication</summary>
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    /// <summary>ClientCertAuth holds necessary information for client authentication via certificates</summary>
    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthClientCert? ClientCert { get; set; }

    /// <summary>OAuth2Auth holds all information for client authentication via OAuth2 tokens</summary>
    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}

/// <summary>Header indicate a key-value request header to be used when fetching artifacts over HTTP</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpHeaders
{
    /// <summary>Name is the header name</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value is the literal value to use for the header</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>HTTP contains HTTP artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttp
{
    /// <summary>Auth contains information for client authentication</summary>
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpAuth? Auth { get; set; }

    /// <summary>Headers are an optional list of headers to send with HTTP requests for artifacts</summary>
    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttpHeaders>? Headers { get; set; }

    /// <summary>URL of the artifact</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>AccessKeySecret is the secret selector to the bucket&apos;s access key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssAccessKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>LifecycleRule specifies how to manage bucket&apos;s lifecycle</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssLifecycleRule
{
    /// <summary>MarkDeletionAfterDays is the number of days before we delete objects in the bucket</summary>
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    /// <summary>MarkInfrequentAccessAfterDays is the number of days before we convert the objects in the bucket to Infrequent Access (IA) storage type</summary>
    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

/// <summary>SecretKeySecret is the secret selector to the bucket&apos;s secret key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssSecretKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>OSS contains OSS artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOss
{
    /// <summary>AccessKeySecret is the secret selector to the bucket&apos;s access key</summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

    /// <summary>Bucket is the name of the bucket</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>CreateBucketIfNotPresent tells the driver to attempt to create the OSS bucket for output artifacts, if it doesn&apos;t exist</summary>
    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    /// <summary>Endpoint is the hostname of the bucket endpoint</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Key is the path in the bucket where the artifact resides</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>LifecycleRule specifies how to manage bucket&apos;s lifecycle</summary>
    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    /// <summary>SecretKeySecret is the secret selector to the bucket&apos;s secret key</summary>
    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    /// <summary>SecurityToken is the user&apos;s temporary security token. For more details, check out: https://www.alibabacloud.com/help/doc-detail/100624.htm</summary>
    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    /// <summary>UseSDKCreds tells the driver to figure out credentials based on sdk defaults.</summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

/// <summary>Plugin contains plugin artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsPlugin
{
    /// <summary>Configuration is the plugin defined configuration for the artifact driver plugin</summary>
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    /// <summary>ConnectionTimeoutSeconds is the timeout for the artifact driver connection, overriding the driver&apos;s timeout</summary>
    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    /// <summary>Key is the path in the artifact repository where the artifact resides</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name is the name of the artifact driver plugin</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Raw contains raw artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsRaw
{
    /// <summary>Data is the string contents of the artifact</summary>
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

/// <summary>AccessKeySecret is the secret selector to the bucket&apos;s access key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3AccessKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>CASecret specifies the secret that contains the CA, used to verify the TLS connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3CaSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>CreateBucketIfNotPresent tells the driver to attempt to create the S3 bucket for output artifacts, if it doesn&apos;t exist. Setting Enabled Encryption will apply either SSE-S3 to the bucket if KmsKeyId is not set or SSE-KMS if it is.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3CreateBucketIfNotPresent
{
    /// <summary>ObjectLocking Enable object locking</summary>
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

/// <summary>ServerSideCustomerKeySecret tells the driver to encrypt the output artifacts using SSE-C with the specified secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>S3EncryptionOptions used to determine encryption options during s3 operations</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3EncryptionOptions
{
    /// <summary>EnableEncryption tells the driver to encrypt objects if set to true. If kmsKeyId and serverSideCustomerKeySecret are not set, SSE-S3 will be used</summary>
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    /// <summary>KmsEncryptionContext is a json blob that contains an encryption context. See https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context for more information</summary>
    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    /// <summary>KMSKeyId tells the driver to encrypt the object using the specified KMS Key.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>ServerSideCustomerKeySecret tells the driver to encrypt the output artifacts using SSE-C with the specified secret.</summary>
    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

/// <summary>SecretKeySecret is the secret selector to the bucket&apos;s secret key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3SecretKeySecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>SessionTokenSecret is used for ephemeral credentials like an IAM assume role or S3 access grant</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3SessionTokenSecret
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>S3 contains S3 artifact location details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3
{
    /// <summary>AccessKeySecret is the secret selector to the bucket&apos;s access key</summary>
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    /// <summary>Bucket is the name of the bucket</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>CASecret specifies the secret that contains the CA, used to verify the TLS connection</summary>
    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3CaSecret? CaSecret { get; set; }

    /// <summary>CreateBucketIfNotPresent tells the driver to attempt to create the S3 bucket for output artifacts, if it doesn&apos;t exist. Setting Enabled Encryption will apply either SSE-S3 to the bucket if KmsKeyId is not set or SSE-KMS if it is.</summary>
    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    /// <summary>S3EncryptionOptions used to determine encryption options during s3 operations</summary>
    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

    /// <summary>Endpoint is the hostname of the bucket endpoint</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Insecure will connect to the service with TLS</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>Key is the key in the bucket where the artifact resides</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Region contains the optional bucket region</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>RoleARN is the Amazon Resource Name (ARN) of the role to assume.</summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>SecretKeySecret is the secret selector to the bucket&apos;s secret key</summary>
    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    /// <summary>SessionTokenSecret is used for ephemeral credentials like an IAM assume role or S3 access grant</summary>
    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    /// <summary>UseSDKCreds tells the driver to figure out credentials based on sdk defaults.</summary>
    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

/// <summary>Artifact indicates an artifact to place at a specified path</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifacts
{
    /// <summary>Archive controls how the artifact will be saved to the artifact repository.</summary>
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArchive? Archive { get; set; }

    /// <summary>ArchiveLogs indicates if the container logs should be archived</summary>
    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    /// <summary>ArtifactGC describes the strategy to use when to deleting an artifact from completed or deleted workflows</summary>
    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactGC? ArtifactGC { get; set; }

    /// <summary>Artifactory contains artifactory artifact location details</summary>
    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsArtifactory? Artifactory { get; set; }

    /// <summary>Azure contains Azure Storage artifact location details</summary>
    [JsonPropertyName("azure")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsAzure? Azure { get; set; }

    /// <summary>Has this been deleted?</summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>From allows an artifact to reference an artifact from a previous step</summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>FromExpression, if defined, is evaluated to specify the value for the artifact</summary>
    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    /// <summary>GCS contains GCS artifact location details</summary>
    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGcs? Gcs { get; set; }

    /// <summary>Git contains git artifact location details</summary>
    [JsonPropertyName("git")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsGit? Git { get; set; }

    /// <summary>
    /// GlobalName exports an output artifact to the global scope, making it available as
    /// workflow.outputs.artifacts.XXXX and in workflow.status.outputs.artifacts
    /// </summary>
    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    /// <summary>HDFS contains HDFS artifact location details</summary>
    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHdfs? Hdfs { get; set; }

    /// <summary>HTTP contains HTTP artifact location details</summary>
    [JsonPropertyName("http")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsHttp? Http { get; set; }

    /// <summary>
    /// mode bits to use on this file, must be a value between 0 and 0777.
    /// Set when loading input artifacts. It is recommended to set the mode value
    /// to ensure the artifact has the expected permissions in your container.
    /// </summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>name of the artifact. must be unique within a template&apos;s inputs/outputs.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Make Artifacts optional, if Artifacts doesn&apos;t generate or exist</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>OSS contains OSS artifact location details</summary>
    [JsonPropertyName("oss")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsOss? Oss { get; set; }

    /// <summary>Path is the container path to the artifact</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Plugin contains plugin artifact location details</summary>
    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsPlugin? Plugin { get; set; }

    /// <summary>Raw contains raw artifact location details</summary>
    [JsonPropertyName("raw")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsRaw? Raw { get; set; }

    /// <summary>If mode is set, apply the permission recursively into the artifact if it is a folder</summary>
    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    /// <summary>S3 contains S3 artifact location details</summary>
    [JsonPropertyName("s3")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifactsS3? S3 { get; set; }

    /// <summary>SubPath allows an artifact to be sourced from a subpath within the specified source</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

/// <summary>ConfigMapKeyRef is configmap selector for input parameter configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFromConfigMapKeyRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the ConfigMap or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Supplied value to be filled in directly, either through the CLI, API, etc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFromSupplied
{
}

/// <summary>ValueFrom is the source for the output parameter&apos;s value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFrom
{
    /// <summary>ConfigMapKeyRef is configmap selector for input parameter configuration</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }

    /// <summary>Default specifies a value to be used if retrieving the value from the specified source fails</summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary>Selector (https://github.com/expr-lang/expr) that is evaluated against the event to get the value of the parameter. E.g. `payload.message`</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>Expression, if defined, is evaluated to specify the value for the parameter</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>JQFilter expression against the resource object in resource templates</summary>
    [JsonPropertyName("jqFilter")]
    public string? JqFilter { get; set; }

    /// <summary>JSONPath of a resource to retrieve an output parameter value from in resource templates</summary>
    [JsonPropertyName("jsonPath")]
    public string? JsonPath { get; set; }

    /// <summary>
    /// Parameter reference to a step or dag task in which to retrieve an output parameter value from
    /// (e.g. steps.mystep.outputs.myparam)
    /// </summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>Path in the container to retrieve an output parameter value from in container templates</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Supplied value to be filled in directly, either through the CLI, API, etc.</summary>
    [JsonPropertyName("supplied")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFromSupplied? Supplied { get; set; }
}

/// <summary>Parameter indicate a passed string parameter to a service template with an optional default value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArgumentsParameters
{
    /// <summary>Default is the default value to use for an input parameter if a value was not supplied</summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary>Description is the parameter description</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Enum holds a list of string values to choose from, for the actual value of the parameter</summary>
    [JsonPropertyName("enum")]
    public IList<string>? Enum { get; set; }

    /// <summary>
    /// GlobalName exports an output parameter to the global scope, making it available as
    /// workflow.outputs.parameters.XXXX and in workflow.status.outputs.parameters
    /// </summary>
    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    /// <summary>Name is the parameter name</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is the literal value to use for the parameter.
    /// If specified in the context of an input parameter, any passed values take precedence over the specified value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFrom is the source for the output parameter&apos;s value</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1WorkflowEventBindingSpecSubmitArgumentsParametersValueFrom? ValueFrom { get; set; }
}

/// <summary>Arguments extracted from the event and then set as arguments to the workflow created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitArguments
{
    /// <summary>Artifacts is the list of artifacts to pass to the template or workflow</summary>
    [JsonPropertyName("artifacts")]
    public IList<V1alpha1WorkflowEventBindingSpecSubmitArgumentsArtifacts>? Artifacts { get; set; }

    /// <summary>Parameters is the list of parameters to pass to the template or workflow</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1WorkflowEventBindingSpecSubmitArgumentsParameters>? Parameters { get; set; }
}

/// <summary>Metadata optional means to customize select fields of the workflow metadata</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("finalizers")]
    public IList<string>? Finalizers { get; set; }

    [JsonPropertyName("generateName")]
    public string? GenerateName { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>WorkflowTemplateRef the workflow template to submit</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmitWorkflowTemplateRef
{
    /// <summary>ClusterScope indicates the referred template is cluster scoped (i.e. a ClusterWorkflowTemplate).</summary>
    [JsonPropertyName("clusterScope")]
    public bool? ClusterScope { get; set; }

    /// <summary>Name is the resource name of the workflow template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Submit is the workflow template to submit</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpecSubmit
{
    /// <summary>Arguments extracted from the event and then set as arguments to the workflow created.</summary>
    [JsonPropertyName("arguments")]
    public V1alpha1WorkflowEventBindingSpecSubmitArguments? Arguments { get; set; }

    /// <summary>Metadata optional means to customize select fields of the workflow metadata</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1WorkflowEventBindingSpecSubmitMetadata? Metadata { get; set; }

    /// <summary>WorkflowTemplateRef the workflow template to submit</summary>
    [JsonPropertyName("workflowTemplateRef")]
    public required V1alpha1WorkflowEventBindingSpecSubmitWorkflowTemplateRef WorkflowTemplateRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowEventBindingSpec
{
    /// <summary>Event is the event to bind to</summary>
    [JsonPropertyName("event")]
    public required V1alpha1WorkflowEventBindingSpecEvent Event { get; set; }

    /// <summary>Submit is the workflow template to submit</summary>
    [JsonPropertyName("submit")]
    public V1alpha1WorkflowEventBindingSpecSubmit? Submit { get; set; }
}

/// <summary>WorkflowEventBinding is the definition of an event resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowEventBinding : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WorkflowEventBindingSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowEventBinding";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "workfloweventbindings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "argoproj.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkflowEventBinding";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1WorkflowEventBindingSpec Spec { get; set; }
}