#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.developerconnect.gcp.upbound.io;
/// <summary>ConnectConnection is the Schema for the ConnectConnections API. A connection for GitHub, GitHub Enterprise, GitLab, and GitLab Enterprise.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConnectConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ConnectConnection>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConnectConnectionList";
    public const string KubeGroup = "developerconnect.gcp.upbound.io";
    public const string KubePluralName = "connectconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "developerconnect.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConnectConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ConnectConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ConnectConnection> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecDeletionPolicyEnum>))]
public enum V1beta1ConnectConnectionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderBitbucketCloudConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderBitbucketCloudConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of Bitbucket Cloud.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderBitbucketCloudConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionSpecForProviderBitbucketCloudConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionSpecForProviderBitbucketCloudConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as projects/*/secrets/*/versions/*. This is used to
    /// validate and create webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }

    /// <summary>Required. The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.</summary>
    [JsonPropertyName("workspace")]
    public string? Workspace { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderBitbucketDataCenterConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderBitbucketDataCenterConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// ServiceDirectoryConfig represents Service Directory configuration for a
/// connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderBitbucketDataCenterConfigServiceDirectoryConfig
{
    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of Bitbucket Data Center.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderBitbucketDataCenterConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionSpecForProviderBitbucketDataCenterConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. The URI of the Bitbucket Data Center host this connection is for.</summary>
    [JsonPropertyName("hostUri")]
    public string? HostUri { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionSpecForProviderBitbucketDataCenterConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// ServiceDirectoryConfig represents Service Directory configuration for a
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1beta1ConnectConnectionSpecForProviderBitbucketDataCenterConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>
    /// Optional. SSL certificate authority to trust when making requests to Bitbucket Data
    /// Center.
    /// </summary>
    [JsonPropertyName("sslCaCertificate")]
    public string? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as projects/*/secrets/*/versions/*. This is used to
    /// validate webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>
/// The crypto key configuration. This field is used by the Customer-managed
/// encryption keys (CMEK) feature.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderCryptoKeyConfig
{
    /// <summary>
    /// Required. The name of the key which is used to encrypt/decrypt customer data. For key
    /// in Cloud KMS, the key should be in the format of
    /// projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    [JsonPropertyName("keyReference")]
    public string? KeyReference { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate oauthTokenSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate oauthTokenSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Represents an OAuth token of the account that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the OAuth token that authorizes
    /// the connection. Format: projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("oauthTokenSecretVersion")]
    public string? OauthTokenSecretVersion { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate oauthTokenSecretVersion.</summary>
    [JsonPropertyName("oauthTokenSecretVersionRef")]
    public V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRef? OauthTokenSecretVersionRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate oauthTokenSecretVersion.</summary>
    [JsonPropertyName("oauthTokenSecretVersionSelector")]
    public V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelector? OauthTokenSecretVersionSelector { get; set; }
}

/// <summary>
/// Configuration for connections to github.com.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubConfig
{
    /// <summary>Optional. GitHub App installation id.</summary>
    [JsonPropertyName("appInstallationId")]
    public string? AppInstallationId { get; set; }

    /// <summary>
    /// Represents an OAuth token of the account that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionSpecForProviderGithubConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>
    /// Required. Immutable. The GitHub Application that was installed to the GitHub user or
    /// organization.
    /// Possible values:
    /// GIT_HUB_APP_UNSPECIFIED
    /// DEVELOPER_CONNECT
    /// FIREBASE
    /// </summary>
    [JsonPropertyName("githubApp")]
    public string? GithubApp { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate privateKeySecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate privateKeySecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// ServiceDirectoryConfig represents Service Directory configuration for a
/// connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigServiceDirectoryConfig
{
    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate webhookSecretSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate webhookSecretSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of GitHub Enterprise.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfig
{
    /// <summary>Optional. ID of the GitHub App created from the manifest.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>Optional. ID of the installation of the GitHub App.</summary>
    [JsonPropertyName("appInstallationId")]
    public string? AppInstallationId { get; set; }

    /// <summary>Required. The URI of the GitHub Enterprise host this connection is for.</summary>
    [JsonPropertyName("hostUri")]
    public string? HostUri { get; set; }

    /// <summary>
    /// Optional. SecretManager resource containing the private key of the GitHub App,
    /// formatted as projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("privateKeySecretVersion")]
    public string? PrivateKeySecretVersion { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate privateKeySecretVersion.</summary>
    [JsonPropertyName("privateKeySecretVersionRef")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionRef? PrivateKeySecretVersionRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate privateKeySecretVersion.</summary>
    [JsonPropertyName("privateKeySecretVersionSelector")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigPrivateKeySecretVersionSelector? PrivateKeySecretVersionSelector { get; set; }

    /// <summary>
    /// ServiceDirectoryConfig represents Service Directory configuration for a
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>Optional. SSL certificate to use for requests to GitHub Enterprise.</summary>
    [JsonPropertyName("sslCaCertificate")]
    public string? SslCaCertificate { get; set; }

    /// <summary>
    /// Optional. SecretManager resource containing the webhook secret of the GitHub App,
    /// formatted as projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate webhookSecretSecretVersion.</summary>
    [JsonPropertyName("webhookSecretSecretVersionRef")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionRef? WebhookSecretSecretVersionRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate webhookSecretSecretVersion.</summary>
    [JsonPropertyName("webhookSecretSecretVersionSelector")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelector? WebhookSecretSecretVersionSelector { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGitlabConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGitlabConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Configuration for connections to gitlab.com.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGitlabConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionSpecForProviderGitlabConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionSpecForProviderGitlabConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as projects/*/secrets/*/versions/*. This is used to validate
    /// webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGitlabEnterpriseConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGitlabEnterpriseConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// ServiceDirectoryConfig represents Service Directory configuration for a
/// connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGitlabEnterpriseConfigServiceDirectoryConfig
{
    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of GitLab Enterprise.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProviderGitlabEnterpriseConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionSpecForProviderGitlabEnterpriseConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. The URI of the GitLab Enterprise host this connection is for.</summary>
    [JsonPropertyName("hostUri")]
    public string? HostUri { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionSpecForProviderGitlabEnterpriseConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// ServiceDirectoryConfig represents Service Directory configuration for a
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1beta1ConnectConnectionSpecForProviderGitlabEnterpriseConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>
    /// Optional. SSL Certificate Authority certificate to use for requests to GitLab
    /// Enterprise instance.
    /// </summary>
    [JsonPropertyName("sslCaCertificate")]
    public string? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as projects/*/secrets/*/versions/*. This is used to validate
    /// webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecForProvider
{
    /// <summary>
    /// Optional. Allows clients to store small amounts of arbitrary data.
    /// Note: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field effective_annotations for all of the annotations present on the resource.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of Bitbucket Cloud.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bitbucketCloudConfig")]
    public V1beta1ConnectConnectionSpecForProviderBitbucketCloudConfig? BitbucketCloudConfig { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of Bitbucket Data Center.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bitbucketDataCenterConfig")]
    public V1beta1ConnectConnectionSpecForProviderBitbucketDataCenterConfig? BitbucketDataCenterConfig { get; set; }

    /// <summary>
    /// The crypto key configuration. This field is used by the Customer-managed
    /// encryption keys (CMEK) feature.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKeyConfig")]
    public V1beta1ConnectConnectionSpecForProviderCryptoKeyConfig? CryptoKeyConfig { get; set; }

    /// <summary>
    /// Optional. If disabled is set to true, functionality is disabled for this connection.
    /// Repository based API methods and webhooks processing for repositories in
    /// this connection will be disabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Configuration for connections to github.com.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("githubConfig")]
    public V1beta1ConnectConnectionSpecForProviderGithubConfig? GithubConfig { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of GitHub Enterprise.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public V1beta1ConnectConnectionSpecForProviderGithubEnterpriseConfig? GithubEnterpriseConfig { get; set; }

    /// <summary>
    /// Configuration for connections to gitlab.com.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitlabConfig")]
    public V1beta1ConnectConnectionSpecForProviderGitlabConfig? GitlabConfig { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of GitLab Enterprise.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitlabEnterpriseConfig")]
    public V1beta1ConnectConnectionSpecForProviderGitlabEnterpriseConfig? GitlabEnterpriseConfig { get; set; }

    /// <summary>
    /// Optional. Labels as key value pairs
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Resource ID segment making up resource name. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderBitbucketCloudConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderBitbucketCloudConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of Bitbucket Cloud.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderBitbucketCloudConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionSpecInitProviderBitbucketCloudConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionSpecInitProviderBitbucketCloudConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as projects/*/secrets/*/versions/*. This is used to
    /// validate and create webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }

    /// <summary>Required. The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.</summary>
    [JsonPropertyName("workspace")]
    public string? Workspace { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderBitbucketDataCenterConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderBitbucketDataCenterConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// ServiceDirectoryConfig represents Service Directory configuration for a
/// connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderBitbucketDataCenterConfigServiceDirectoryConfig
{
    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of Bitbucket Data Center.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderBitbucketDataCenterConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionSpecInitProviderBitbucketDataCenterConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. The URI of the Bitbucket Data Center host this connection is for.</summary>
    [JsonPropertyName("hostUri")]
    public string? HostUri { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionSpecInitProviderBitbucketDataCenterConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// ServiceDirectoryConfig represents Service Directory configuration for a
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1beta1ConnectConnectionSpecInitProviderBitbucketDataCenterConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>
    /// Optional. SSL certificate authority to trust when making requests to Bitbucket Data
    /// Center.
    /// </summary>
    [JsonPropertyName("sslCaCertificate")]
    public string? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as projects/*/secrets/*/versions/*. This is used to
    /// validate webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>
/// The crypto key configuration. This field is used by the Customer-managed
/// encryption keys (CMEK) feature.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderCryptoKeyConfig
{
    /// <summary>
    /// Required. The name of the key which is used to encrypt/decrypt customer data. For key
    /// in Cloud KMS, the key should be in the format of
    /// projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    [JsonPropertyName("keyReference")]
    public string? KeyReference { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate oauthTokenSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate oauthTokenSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Represents an OAuth token of the account that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the OAuth token that authorizes
    /// the connection. Format: projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("oauthTokenSecretVersion")]
    public string? OauthTokenSecretVersion { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate oauthTokenSecretVersion.</summary>
    [JsonPropertyName("oauthTokenSecretVersionRef")]
    public V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionRef? OauthTokenSecretVersionRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate oauthTokenSecretVersion.</summary>
    [JsonPropertyName("oauthTokenSecretVersionSelector")]
    public V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredentialOauthTokenSecretVersionSelector? OauthTokenSecretVersionSelector { get; set; }
}

/// <summary>
/// Configuration for connections to github.com.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubConfig
{
    /// <summary>Optional. GitHub App installation id.</summary>
    [JsonPropertyName("appInstallationId")]
    public string? AppInstallationId { get; set; }

    /// <summary>
    /// Represents an OAuth token of the account that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionSpecInitProviderGithubConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>
    /// Required. Immutable. The GitHub Application that was installed to the GitHub user or
    /// organization.
    /// Possible values:
    /// GIT_HUB_APP_UNSPECIFIED
    /// DEVELOPER_CONNECT
    /// FIREBASE
    /// </summary>
    [JsonPropertyName("githubApp")]
    public string? GithubApp { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate privateKeySecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate privateKeySecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// ServiceDirectoryConfig represents Service Directory configuration for a
/// connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigServiceDirectoryConfig
{
    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate webhookSecretSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate webhookSecretSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of GitHub Enterprise.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfig
{
    /// <summary>Optional. ID of the GitHub App created from the manifest.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>Optional. ID of the installation of the GitHub App.</summary>
    [JsonPropertyName("appInstallationId")]
    public string? AppInstallationId { get; set; }

    /// <summary>Required. The URI of the GitHub Enterprise host this connection is for.</summary>
    [JsonPropertyName("hostUri")]
    public string? HostUri { get; set; }

    /// <summary>
    /// Optional. SecretManager resource containing the private key of the GitHub App,
    /// formatted as projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("privateKeySecretVersion")]
    public string? PrivateKeySecretVersion { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate privateKeySecretVersion.</summary>
    [JsonPropertyName("privateKeySecretVersionRef")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionRef? PrivateKeySecretVersionRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate privateKeySecretVersion.</summary>
    [JsonPropertyName("privateKeySecretVersionSelector")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigPrivateKeySecretVersionSelector? PrivateKeySecretVersionSelector { get; set; }

    /// <summary>
    /// ServiceDirectoryConfig represents Service Directory configuration for a
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>Optional. SSL certificate to use for requests to GitHub Enterprise.</summary>
    [JsonPropertyName("sslCaCertificate")]
    public string? SslCaCertificate { get; set; }

    /// <summary>
    /// Optional. SecretManager resource containing the webhook secret of the GitHub App,
    /// formatted as projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate webhookSecretSecretVersion.</summary>
    [JsonPropertyName("webhookSecretSecretVersionRef")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionRef? WebhookSecretSecretVersionRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate webhookSecretSecretVersion.</summary>
    [JsonPropertyName("webhookSecretSecretVersionSelector")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfigWebhookSecretSecretVersionSelector? WebhookSecretSecretVersionSelector { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGitlabConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGitlabConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Configuration for connections to gitlab.com.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGitlabConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionSpecInitProviderGitlabConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionSpecInitProviderGitlabConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as projects/*/secrets/*/versions/*. This is used to validate
    /// webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGitlabEnterpriseConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGitlabEnterpriseConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }
}

/// <summary>
/// ServiceDirectoryConfig represents Service Directory configuration for a
/// connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGitlabEnterpriseConfigServiceDirectoryConfig
{
    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of GitLab Enterprise.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProviderGitlabEnterpriseConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionSpecInitProviderGitlabEnterpriseConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. The URI of the GitLab Enterprise host this connection is for.</summary>
    [JsonPropertyName("hostUri")]
    public string? HostUri { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionSpecInitProviderGitlabEnterpriseConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// ServiceDirectoryConfig represents Service Directory configuration for a
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1beta1ConnectConnectionSpecInitProviderGitlabEnterpriseConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>
    /// Optional. SSL Certificate Authority certificate to use for requests to GitLab
    /// Enterprise instance.
    /// </summary>
    [JsonPropertyName("sslCaCertificate")]
    public string? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as projects/*/secrets/*/versions/*. This is used to validate
    /// webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecInitProvider
{
    /// <summary>
    /// Optional. Allows clients to store small amounts of arbitrary data.
    /// Note: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field effective_annotations for all of the annotations present on the resource.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of Bitbucket Cloud.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bitbucketCloudConfig")]
    public V1beta1ConnectConnectionSpecInitProviderBitbucketCloudConfig? BitbucketCloudConfig { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of Bitbucket Data Center.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bitbucketDataCenterConfig")]
    public V1beta1ConnectConnectionSpecInitProviderBitbucketDataCenterConfig? BitbucketDataCenterConfig { get; set; }

    /// <summary>
    /// The crypto key configuration. This field is used by the Customer-managed
    /// encryption keys (CMEK) feature.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKeyConfig")]
    public V1beta1ConnectConnectionSpecInitProviderCryptoKeyConfig? CryptoKeyConfig { get; set; }

    /// <summary>
    /// Optional. If disabled is set to true, functionality is disabled for this connection.
    /// Repository based API methods and webhooks processing for repositories in
    /// this connection will be disabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Configuration for connections to github.com.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("githubConfig")]
    public V1beta1ConnectConnectionSpecInitProviderGithubConfig? GithubConfig { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of GitHub Enterprise.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public V1beta1ConnectConnectionSpecInitProviderGithubEnterpriseConfig? GithubEnterpriseConfig { get; set; }

    /// <summary>
    /// Configuration for connections to gitlab.com.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitlabConfig")]
    public V1beta1ConnectConnectionSpecInitProviderGitlabConfig? GitlabConfig { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of GitLab Enterprise.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitlabEnterpriseConfig")]
    public V1beta1ConnectConnectionSpecInitProviderGitlabEnterpriseConfig? GitlabEnterpriseConfig { get; set; }

    /// <summary>
    /// Optional. Labels as key value pairs
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecManagementPoliciesEnum>))]
public enum V1beta1ConnectConnectionSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1ConnectConnectionSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ConnectConnectionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1ConnectConnectionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ConnectConnectionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ConnectConnectionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ConnectConnectionSpec defines the desired state of ConnectConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta1ConnectConnectionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1ConnectConnectionSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConnectConnectionSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ConnectConnectionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConnectConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConnectConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderBitbucketCloudConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The username associated with this token.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderBitbucketCloudConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The username associated with this token.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of Bitbucket Cloud.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderBitbucketCloudConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionStatusAtProviderBitbucketCloudConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionStatusAtProviderBitbucketCloudConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as projects/*/secrets/*/versions/*. This is used to
    /// validate and create webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }

    /// <summary>Required. The Bitbucket Cloud Workspace ID to be connected to Google Cloud Platform.</summary>
    [JsonPropertyName("workspace")]
    public string? Workspace { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderBitbucketDataCenterConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The username associated with this token.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderBitbucketDataCenterConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The username associated with this token.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// ServiceDirectoryConfig represents Service Directory configuration for a
/// connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderBitbucketDataCenterConfigServiceDirectoryConfig
{
    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of Bitbucket Data Center.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderBitbucketDataCenterConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionStatusAtProviderBitbucketDataCenterConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. The URI of the Bitbucket Data Center host this connection is for.</summary>
    [JsonPropertyName("hostUri")]
    public string? HostUri { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionStatusAtProviderBitbucketDataCenterConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. Version of the Bitbucket Data Center server running on the host_uri.
    /// </summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }

    /// <summary>
    /// ServiceDirectoryConfig represents Service Directory configuration for a
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1beta1ConnectConnectionStatusAtProviderBitbucketDataCenterConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>
    /// Optional. SSL certificate authority to trust when making requests to Bitbucket Data
    /// Center.
    /// </summary>
    [JsonPropertyName("sslCaCertificate")]
    public string? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret used to verify webhook
    /// events, formatted as projects/*/secrets/*/versions/*. This is used to
    /// validate webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>
/// The crypto key configuration. This field is used by the Customer-managed
/// encryption keys (CMEK) feature.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderCryptoKeyConfig
{
    /// <summary>
    /// Required. The name of the key which is used to encrypt/decrypt customer data. For key
    /// in Cloud KMS, the key should be in the format of
    /// projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    [JsonPropertyName("keyReference")]
    public string? KeyReference { get; set; }
}

/// <summary>
/// Represents an OAuth token of the account that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderGithubConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the OAuth token that authorizes
    /// the connection. Format: projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("oauthTokenSecretVersion")]
    public string? OauthTokenSecretVersion { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The username associated with this token.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Configuration for connections to github.com.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderGithubConfig
{
    /// <summary>Optional. GitHub App installation id.</summary>
    [JsonPropertyName("appInstallationId")]
    public string? AppInstallationId { get; set; }

    /// <summary>
    /// Represents an OAuth token of the account that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionStatusAtProviderGithubConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>
    /// Required. Immutable. The GitHub Application that was installed to the GitHub user or
    /// organization.
    /// Possible values:
    /// GIT_HUB_APP_UNSPECIFIED
    /// DEVELOPER_CONNECT
    /// FIREBASE
    /// </summary>
    [JsonPropertyName("githubApp")]
    public string? GithubApp { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The URI to navigate to in order to manage the installation associated
    /// with this GitHubConfig.
    /// </summary>
    [JsonPropertyName("installationUri")]
    public string? InstallationUri { get; set; }
}

/// <summary>
/// ServiceDirectoryConfig represents Service Directory configuration for a
/// connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderGithubEnterpriseConfigServiceDirectoryConfig
{
    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of GitHub Enterprise.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderGithubEnterpriseConfig
{
    /// <summary>Optional. ID of the GitHub App created from the manifest.</summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; set; }

    /// <summary>Optional. ID of the installation of the GitHub App.</summary>
    [JsonPropertyName("appInstallationId")]
    public string? AppInstallationId { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The URL-friendly name of the GitHub App.
    /// </summary>
    [JsonPropertyName("appSlug")]
    public string? AppSlug { get; set; }

    /// <summary>Required. The URI of the GitHub Enterprise host this connection is for.</summary>
    [JsonPropertyName("hostUri")]
    public string? HostUri { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The URI to navigate to in order to manage the installation associated
    /// with this GitHubEnterpriseConfig.
    /// </summary>
    [JsonPropertyName("installationUri")]
    public string? InstallationUri { get; set; }

    /// <summary>
    /// Optional. SecretManager resource containing the private key of the GitHub App,
    /// formatted as projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("privateKeySecretVersion")]
    public string? PrivateKeySecretVersion { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. GitHub Enterprise version installed at the host_uri.
    /// </summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }

    /// <summary>
    /// ServiceDirectoryConfig represents Service Directory configuration for a
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1beta1ConnectConnectionStatusAtProviderGithubEnterpriseConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>Optional. SSL certificate to use for requests to GitHub Enterprise.</summary>
    [JsonPropertyName("sslCaCertificate")]
    public string? SslCaCertificate { get; set; }

    /// <summary>
    /// Optional. SecretManager resource containing the webhook secret of the GitHub App,
    /// formatted as projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderGitlabConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The username associated with this token.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderGitlabConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The username associated with this token.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Configuration for connections to gitlab.com.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderGitlabConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionStatusAtProviderGitlabConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionStatusAtProviderGitlabConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as projects/*/secrets/*/versions/*. This is used to validate
    /// webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderGitlabEnterpriseConfigAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The username associated with this token.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Represents a personal access token that authorized the Connection,
/// and associated metadata.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderGitlabEnterpriseConfigReadAuthorizerCredential
{
    /// <summary>
    /// Required. A SecretManager resource containing the user token that authorizes
    /// the Developer Connect connection. Format:
    /// projects/*/secrets/*/versions/*.
    /// </summary>
    [JsonPropertyName("userTokenSecretVersion")]
    public string? UserTokenSecretVersion { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The username associated with this token.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// ServiceDirectoryConfig represents Service Directory configuration for a
/// connection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderGitlabEnterpriseConfigServiceDirectoryConfig
{
    /// <summary>
    /// Required. The Service Directory service name.
    /// Format:
    /// projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// Configuration for connections to an instance of GitLab Enterprise.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderGitlabEnterpriseConfig
{
    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizerCredential")]
    public V1beta1ConnectConnectionStatusAtProviderGitlabEnterpriseConfigAuthorizerCredential? AuthorizerCredential { get; set; }

    /// <summary>Required. The URI of the GitLab Enterprise host this connection is for.</summary>
    [JsonPropertyName("hostUri")]
    public string? HostUri { get; set; }

    /// <summary>
    /// Represents a personal access token that authorized the Connection,
    /// and associated metadata.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("readAuthorizerCredential")]
    public V1beta1ConnectConnectionStatusAtProviderGitlabEnterpriseConfigReadAuthorizerCredential? ReadAuthorizerCredential { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. Version of the GitLab Enterprise server running on the host_uri.
    /// </summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }

    /// <summary>
    /// ServiceDirectoryConfig represents Service Directory configuration for a
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceDirectoryConfig")]
    public V1beta1ConnectConnectionStatusAtProviderGitlabEnterpriseConfigServiceDirectoryConfig? ServiceDirectoryConfig { get; set; }

    /// <summary>
    /// Optional. SSL Certificate Authority certificate to use for requests to GitLab
    /// Enterprise instance.
    /// </summary>
    [JsonPropertyName("sslCaCertificate")]
    public string? SslCaCertificate { get; set; }

    /// <summary>
    /// Required. Immutable. SecretManager resource containing the webhook secret of a GitLab project,
    /// formatted as projects/*/secrets/*/versions/*. This is used to validate
    /// webhooks.
    /// </summary>
    [JsonPropertyName("webhookSecretSecretVersion")]
    public string? WebhookSecretSecretVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProviderInstallationState
{
    /// <summary>
    /// Output only. Link to follow for next action. Empty string if the installation is already
    /// complete.
    /// </summary>
    [JsonPropertyName("actionUri")]
    public string? ActionUri { get; set; }

    /// <summary>
    /// Output only. Message of what the user should do next to continue the installation.
    /// Empty string if the installation is already complete.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. Current step of the installation process.
    /// Possible values:
    /// STAGE_UNSPECIFIED
    /// PENDING_CREATE_APP
    /// PENDING_USER_OAUTH
    /// PENDING_INSTALL_APP
    /// COMPLETE
    /// </summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusAtProvider
{
    /// <summary>
    /// Optional. Allows clients to store small amounts of arbitrary data.
    /// Note: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field effective_annotations for all of the annotations present on the resource.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of Bitbucket Cloud.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bitbucketCloudConfig")]
    public V1beta1ConnectConnectionStatusAtProviderBitbucketCloudConfig? BitbucketCloudConfig { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of Bitbucket Data Center.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bitbucketDataCenterConfig")]
    public V1beta1ConnectConnectionStatusAtProviderBitbucketDataCenterConfig? BitbucketDataCenterConfig { get; set; }

    /// <summary>Output only. [Output only] Create timestamp</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// The crypto key configuration. This field is used by the Customer-managed
    /// encryption keys (CMEK) feature.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKeyConfig")]
    public V1beta1ConnectConnectionStatusAtProviderCryptoKeyConfig? CryptoKeyConfig { get; set; }

    /// <summary>Output only. [Output only] Delete timestamp</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>
    /// Optional. If disabled is set to true, functionality is disabled for this connection.
    /// Repository based API methods and webhooks processing for repositories in
    /// this connection will be disabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// Optional. This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Configuration for connections to github.com.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("githubConfig")]
    public V1beta1ConnectConnectionStatusAtProviderGithubConfig? GithubConfig { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of GitHub Enterprise.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("githubEnterpriseConfig")]
    public V1beta1ConnectConnectionStatusAtProviderGithubEnterpriseConfig? GithubEnterpriseConfig { get; set; }

    /// <summary>
    /// Configuration for connections to gitlab.com.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitlabConfig")]
    public V1beta1ConnectConnectionStatusAtProviderGitlabConfig? GitlabConfig { get; set; }

    /// <summary>
    /// Configuration for connections to an instance of GitLab Enterprise.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitlabEnterpriseConfig")]
    public V1beta1ConnectConnectionStatusAtProviderGitlabEnterpriseConfig? GitlabEnterpriseConfig { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/connections/{{connection_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Describes stage and necessary actions to be taken by the
    /// user to complete the installation. Used for GitHub and GitHub Enterprise
    /// based connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("installationState")]
    public IList<V1beta1ConnectConnectionStatusAtProviderInstallationState>? InstallationState { get; set; }

    /// <summary>
    /// Optional. Labels as key value pairs
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Resource ID segment making up resource name. It identifies the resource within its parent collection as described in https://google.aip.dev/122.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Identifier. The resource name of the connection, in the format
    /// projects/{project}/locations/{location}/connections/{connection_id}.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Output only. Set to true when the connection is being set up or updated in the
    /// background.
    /// </summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Output only. A system-assigned unique identifier for a the GitRepositoryLink.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. [Output only] Update timestamp</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ConnectConnectionStatus defines the observed state of ConnectConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectConnectionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ConnectConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConnectConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ConnectConnection is the Schema for the ConnectConnections API. A connection for GitHub, GitHub Enterprise, GitLab, and GitLab Enterprise.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConnectConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConnectConnectionSpec>, IStatus<V1beta1ConnectConnectionStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConnectConnection";
    public const string KubeGroup = "developerconnect.gcp.upbound.io";
    public const string KubePluralName = "connectconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "developerconnect.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConnectConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectConnectionSpec defines the desired state of ConnectConnection</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ConnectConnectionSpec Spec { get; set; }

    /// <summary>ConnectConnectionStatus defines the observed state of ConnectConnection.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConnectConnectionStatus? Status { get; set; }
}