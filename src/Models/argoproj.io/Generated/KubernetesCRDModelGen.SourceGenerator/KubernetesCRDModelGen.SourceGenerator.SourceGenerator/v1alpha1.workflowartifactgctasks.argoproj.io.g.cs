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
/// <summary>WorkflowArtifactGCTask specifies the Artifacts that need to be deleted as well as the status of deletion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowArtifactGCTaskList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1WorkflowArtifactGCTask>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowArtifactGCTaskList";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "workflowartifactgctasks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "argoproj.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkflowArtifactGCTaskList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1WorkflowArtifactGCTask objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1WorkflowArtifactGCTask> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactoryPasswordSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactoryUsernameSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactory
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactoryPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationAzureAccountKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationAzure
{
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationAzureAccountKeySecret? AccountKeySecret { get; set; }

    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGcsServiceAccountKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGcs
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitPasswordSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitSshPrivateKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitUsernameSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGit
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGitUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbCCacheSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbConfigConfigMap
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbKeytabSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfs
{
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuthPasswordSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuthUsernameSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuth
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCertClientCertSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCertClientKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCert
{
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2ClientIDSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2ClientSecretSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2EndpointParams
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2TokenURLSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2
{
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuth
{
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthBasicAuth? BasicAuth { get; set; }

    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthClientCert? ClientCert { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuthOauth2? Oauth2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttp
{
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpAuth? Auth { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssAccessKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssLifecycleRule
{
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssSecretKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOss
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssAccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssLifecycleRule? LifecycleRule { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOssSecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationPlugin
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationRaw
{
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3AccessKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3CaSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3CreateBucketIfNotPresent
{
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3EncryptionOptionsServerSideCustomerKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3EncryptionOptions
{
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3SecretKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3SessionTokenSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3AccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3CaSecret? CaSecret { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3EncryptionOptions? EncryptionOptions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3SecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3SessionTokenSecret? SessionTokenSecret { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocation
{
    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationArtifactory? Artifactory { get; set; }

    [JsonPropertyName("azure")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationAzure? Azure { get; set; }

    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGcs? Gcs { get; set; }

    [JsonPropertyName("git")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationGit? Git { get; set; }

    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHdfs? Hdfs { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationHttp? Http { get; set; }

    [JsonPropertyName("oss")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationOss? Oss { get; set; }

    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationPlugin? Plugin { get; set; }

    [JsonPropertyName("raw")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationRaw? Raw { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocationS3? S3 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveNone
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveTar
{
    [JsonPropertyName("compressionLevel")]
    public int? CompressionLevel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveZip
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchive
{
    [JsonPropertyName("none")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveNone? None { get; set; }

    [JsonPropertyName("tar")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveTar? Tar { get; set; }

    [JsonPropertyName("zip")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchiveZip? Zip { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactGCPodMetadata
{
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactGC
{
    [JsonPropertyName("podMetadata")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactGCPodMetadata? PodMetadata { get; set; }

    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactoryPasswordSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactoryUsernameSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactory
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactoryPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactoryUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsAzureAccountKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsAzure
{
    [JsonPropertyName("accountKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsAzureAccountKeySecret? AccountKeySecret { get; set; }

    [JsonPropertyName("blob")]
    public required string Blob { get; set; }

    [JsonPropertyName("container")]
    public required string Container { get; set; }

    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGcsServiceAccountKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGcs
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("serviceAccountKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGcsServiceAccountKeySecret? ServiceAccountKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitPasswordSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitSshPrivateKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitUsernameSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGit
{
    [JsonPropertyName("branch")]
    public string? Branch { get; set; }

    [JsonPropertyName("depth")]
    public long? Depth { get; set; }

    [JsonPropertyName("disableSubmodules")]
    public bool? DisableSubmodules { get; set; }

    [JsonPropertyName("fetch")]
    public IList<string>? Fetch { get; set; }

    [JsonPropertyName("insecureIgnoreHostKey")]
    public bool? InsecureIgnoreHostKey { get; set; }

    [JsonPropertyName("insecureSkipTLS")]
    public bool? InsecureSkipTLS { get; set; }

    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("repo")]
    public required string Repo { get; set; }

    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    [JsonPropertyName("singleBranch")]
    public bool? SingleBranch { get; set; }

    [JsonPropertyName("sshPrivateKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitSshPrivateKeySecret? SshPrivateKeySecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGitUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbCCacheSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbConfigConfigMap
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbKeytabSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfs
{
    [JsonPropertyName("addresses")]
    public IList<string>? Addresses { get; set; }

    [JsonPropertyName("dataTransferProtection")]
    public string? DataTransferProtection { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("hdfsUser")]
    public string? HdfsUser { get; set; }

    [JsonPropertyName("krbCCacheSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbCCacheSecret? KrbCCacheSecret { get; set; }

    [JsonPropertyName("krbConfigConfigMap")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbConfigConfigMap? KrbConfigConfigMap { get; set; }

    [JsonPropertyName("krbKeytabSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfsKrbKeytabSecret? KrbKeytabSecret { get; set; }

    [JsonPropertyName("krbRealm")]
    public string? KrbRealm { get; set; }

    [JsonPropertyName("krbServicePrincipalName")]
    public string? KrbServicePrincipalName { get; set; }

    [JsonPropertyName("krbUsername")]
    public string? KrbUsername { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuthPasswordSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuthUsernameSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuth
{
    [JsonPropertyName("passwordSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuthPasswordSecret? PasswordSecret { get; set; }

    [JsonPropertyName("usernameSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuthUsernameSecret? UsernameSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCertClientCertSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCertClientKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCert
{
    [JsonPropertyName("clientCertSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCertClientCertSecret? ClientCertSecret { get; set; }

    [JsonPropertyName("clientKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCertClientKeySecret? ClientKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2ClientIDSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2ClientSecretSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2EndpointParams
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2TokenURLSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2
{
    [JsonPropertyName("clientIDSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2ClientIDSecret? ClientIDSecret { get; set; }

    [JsonPropertyName("clientSecretSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2ClientSecretSecret? ClientSecretSecret { get; set; }

    [JsonPropertyName("endpointParams")]
    public IList<V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2EndpointParams>? EndpointParams { get; set; }

    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    [JsonPropertyName("tokenURLSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2TokenURLSecret? TokenURLSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuth
{
    [JsonPropertyName("basicAuth")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthBasicAuth? BasicAuth { get; set; }

    [JsonPropertyName("clientCert")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthClientCert? ClientCert { get; set; }

    [JsonPropertyName("oauth2")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuthOauth2? Oauth2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpHeaders
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttp
{
    [JsonPropertyName("auth")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpAuth? Auth { get; set; }

    [JsonPropertyName("headers")]
    public IList<V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttpHeaders>? Headers { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssAccessKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssLifecycleRule
{
    [JsonPropertyName("markDeletionAfterDays")]
    public int? MarkDeletionAfterDays { get; set; }

    [JsonPropertyName("markInfrequentAccessAfterDays")]
    public int? MarkInfrequentAccessAfterDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssSecretKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOss
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssAccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public bool? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("lifecycleRule")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssLifecycleRule? LifecycleRule { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOssSecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("securityToken")]
    public string? SecurityToken { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsPlugin
{
    [JsonPropertyName("configuration")]
    public string? Configuration { get; set; }

    [JsonPropertyName("connectionTimeoutSeconds")]
    public int? ConnectionTimeoutSeconds { get; set; }

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsRaw
{
    [JsonPropertyName("data")]
    public required string Data { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3AccessKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3CaSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3CreateBucketIfNotPresent
{
    [JsonPropertyName("objectLocking")]
    public bool? ObjectLocking { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3EncryptionOptionsServerSideCustomerKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3EncryptionOptions
{
    [JsonPropertyName("enableEncryption")]
    public bool? EnableEncryption { get; set; }

    [JsonPropertyName("kmsEncryptionContext")]
    public string? KmsEncryptionContext { get; set; }

    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("serverSideCustomerKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3EncryptionOptionsServerSideCustomerKeySecret? ServerSideCustomerKeySecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3SecretKeySecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3SessionTokenSecret
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3
{
    [JsonPropertyName("accessKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3AccessKeySecret? AccessKeySecret { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("caSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3CaSecret? CaSecret { get; set; }

    [JsonPropertyName("createBucketIfNotPresent")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3CreateBucketIfNotPresent? CreateBucketIfNotPresent { get; set; }

    [JsonPropertyName("encryptionOptions")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3EncryptionOptions? EncryptionOptions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("secretKeySecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3SecretKeySecret? SecretKeySecret { get; set; }

    [JsonPropertyName("sessionTokenSecret")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3SessionTokenSecret? SessionTokenSecret { get; set; }

    [JsonPropertyName("useSDKCreds")]
    public bool? UseSDKCreds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifacts
{
    [JsonPropertyName("archive")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArchive? Archive { get; set; }

    [JsonPropertyName("archiveLogs")]
    public bool? ArchiveLogs { get; set; }

    [JsonPropertyName("artifactGC")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactGC? ArtifactGC { get; set; }

    [JsonPropertyName("artifactory")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsArtifactory? Artifactory { get; set; }

    [JsonPropertyName("azure")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsAzure? Azure { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("from")]
    public string? From { get; set; }

    [JsonPropertyName("fromExpression")]
    public string? FromExpression { get; set; }

    [JsonPropertyName("gcs")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGcs? Gcs { get; set; }

    [JsonPropertyName("git")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsGit? Git { get; set; }

    [JsonPropertyName("globalName")]
    public string? GlobalName { get; set; }

    [JsonPropertyName("hdfs")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHdfs? Hdfs { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsHttp? Http { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("oss")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsOss? Oss { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("plugin")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsPlugin? Plugin { get; set; }

    [JsonPropertyName("raw")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsRaw? Raw { get; set; }

    [JsonPropertyName("recurseMode")]
    public bool? RecurseMode { get; set; }

    [JsonPropertyName("s3")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifactsS3? S3 { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNode
{
    [JsonPropertyName("archiveLocation")]
    public V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArchiveLocation? ArchiveLocation { get; set; }

    [JsonPropertyName("artifacts")]
    public IDictionary<string, V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNodeArtifacts>? Artifacts { get; set; }
}

/// <summary>
/// ArtifactGCSpec specifies the Artifacts that need to be deleted.
/// All nested field descriptions have been dropped due to Kubernetes size limitations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskSpec
{
    [JsonPropertyName("artifactsByNode")]
    public IDictionary<string, V1alpha1WorkflowArtifactGCTaskSpecArtifactsByNode>? ArtifactsByNode { get; set; }
}

/// <summary>ArtifactResult describes the result of attempting to delete a given Artifact</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskStatusArtifactResultsByNodeArtifactResults
{
    /// <summary>Error is an optional error message which should be set if Success==false</summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>Name is the name of the Artifact</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Success describes whether the deletion succeeded</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>ArtifactResultNodeStatus describes the result of the deletion on a given node</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskStatusArtifactResultsByNode
{
    /// <summary>ArtifactResults maps Artifact name to result of the deletion</summary>
    [JsonPropertyName("artifactResults")]
    public IDictionary<string, V1alpha1WorkflowArtifactGCTaskStatusArtifactResultsByNodeArtifactResults>? ArtifactResults { get; set; }
}

/// <summary>ArtifactGCStatus describes the result of the deletion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowArtifactGCTaskStatus
{
    /// <summary>ArtifactResultsByNode maps Node name to result</summary>
    [JsonPropertyName("artifactResultsByNode")]
    public IDictionary<string, V1alpha1WorkflowArtifactGCTaskStatusArtifactResultsByNode>? ArtifactResultsByNode { get; set; }
}

/// <summary>WorkflowArtifactGCTask specifies the Artifacts that need to be deleted as well as the status of deletion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowArtifactGCTask : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WorkflowArtifactGCTaskSpec>, IStatus<V1alpha1WorkflowArtifactGCTaskStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowArtifactGCTask";
    public const string KubeGroup = "argoproj.io";
    public const string KubePluralName = "workflowartifactgctasks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "argoproj.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkflowArtifactGCTask";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ArtifactGCSpec specifies the Artifacts that need to be deleted.
    /// All nested field descriptions have been dropped due to Kubernetes size limitations.
    /// </summary>
    [JsonPropertyName("spec")]
    public required V1alpha1WorkflowArtifactGCTaskSpec Spec { get; set; }

    /// <summary>ArtifactGCStatus describes the result of the deletion</summary>
    [JsonPropertyName("status")]
    public V1alpha1WorkflowArtifactGCTaskStatus? Status { get; set; }
}