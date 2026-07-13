#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.amplify.aws.upbound.io;
/// <summary>App is the Schema for the Apps API. Provides an Amplify App resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AppList : IKubernetesObject<V1ListMeta>, IItems<V1beta2App>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AppList";
    public const string KubeGroup = "amplify.aws.upbound.io";
    public const string KubePluralName = "apps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "amplify.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AppList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2App objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2App> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecDeletionPolicyEnum>))]
public enum V1beta2AppSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Personal access token for a third-party source control system for an Amplify app. This token must have write access to the relevant repo to create a webhook and a read-only deploy key for the Amplify project. The token is not stored, so after applying this attribute can be removed and the setup token deleted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderAccessTokenSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Basic authorization credentials for the autocreated branch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderAutoBranchCreationConfigBasicAuthCredentialsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Automated branch creation configuration for an Amplify app. See auto_branch_creation_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderAutoBranchCreationConfig
{
    /// <summary>Basic authorization credentials for the autocreated branch.</summary>
    [JsonPropertyName("basicAuthCredentialsSecretRef")]
    public V1beta2AppSpecForProviderAutoBranchCreationConfigBasicAuthCredentialsSecretRef? BasicAuthCredentialsSecretRef { get; set; }

    /// <summary>Build specification (build spec) for the autocreated branch.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Enables auto building for the autocreated branch.</summary>
    [JsonPropertyName("enableAutoBuild")]
    public bool? EnableAutoBuild { get; set; }

    /// <summary>Enables basic authorization for the autocreated branch.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables performance mode for the branch.</summary>
    [JsonPropertyName("enablePerformanceMode")]
    public bool? EnablePerformanceMode { get; set; }

    /// <summary>Enables pull request previews for the autocreated branch.</summary>
    [JsonPropertyName("enablePullRequestPreview")]
    public bool? EnablePullRequestPreview { get; set; }

    /// <summary>Environment variables for the autocreated branch.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Framework for the autocreated branch.</summary>
    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    /// <summary>Amplify environment name for the pull request.</summary>
    [JsonPropertyName("pullRequestEnvironmentName")]
    public string? PullRequestEnvironmentName { get; set; }

    /// <summary>Describes the current stage for the autocreated branch. Valid values: PRODUCTION, BETA, DEVELOPMENT, EXPERIMENTAL, PULL_REQUEST.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }
}

/// <summary>Credentials for basic authorization for an Amplify app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderBasicAuthCredentialsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Cache configuration for the Amplify app. See cache_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderCacheConfig
{
    /// <summary>Type of cache configuration to use for an Amplify app. Valid values: AMPLIFY_MANAGED, AMPLIFY_MANAGED_NO_COOKIES.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecForProviderComputeRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2AppSpecForProviderComputeRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecForProviderComputeRoleArnRefPolicyResolveEnum>))]
public enum V1beta2AppSpecForProviderComputeRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderComputeRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AppSpecForProviderComputeRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AppSpecForProviderComputeRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate computeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderComputeRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AppSpecForProviderComputeRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecForProviderComputeRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2AppSpecForProviderComputeRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecForProviderComputeRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2AppSpecForProviderComputeRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderComputeRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AppSpecForProviderComputeRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AppSpecForProviderComputeRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate computeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderComputeRoleArnSelector
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
    public V1beta2AppSpecForProviderComputeRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderCustomRule
{
    /// <summary>Condition for a URL rewrite or redirect rule, such as a country code.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Source pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Status code for a URL rewrite or redirect rule. Valid values: 200, 301, 302, 404, 404-200.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecForProviderIamServiceRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2AppSpecForProviderIamServiceRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecForProviderIamServiceRoleArnRefPolicyResolveEnum>))]
public enum V1beta2AppSpecForProviderIamServiceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderIamServiceRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AppSpecForProviderIamServiceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AppSpecForProviderIamServiceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamServiceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderIamServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AppSpecForProviderIamServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecForProviderIamServiceRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2AppSpecForProviderIamServiceRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecForProviderIamServiceRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2AppSpecForProviderIamServiceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderIamServiceRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AppSpecForProviderIamServiceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AppSpecForProviderIamServiceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamServiceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderIamServiceRoleArnSelector
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
    public V1beta2AppSpecForProviderIamServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Used to configure the Amplify Application build instance compute type. See job_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderJobConfig
{
    /// <summary>Size of the build instance. Valid values: STANDARD_8GB, LARGE_16GB, and XLARGE_72GB. Default: STANDARD_8GB.</summary>
    [JsonPropertyName("buildComputeType")]
    public string? BuildComputeType { get; set; }
}

/// <summary>OAuth token for a third-party source control system for an Amplify app. The OAuth token is used to create a webhook and a read-only deploy key. The OAuth token is not stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProviderOauthTokenSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecForProvider
{
    /// <summary>Personal access token for a third-party source control system for an Amplify app. This token must have write access to the relevant repo to create a webhook and a read-only deploy key for the Amplify project. The token is not stored, so after applying this attribute can be removed and the setup token deleted.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta2AppSpecForProviderAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>Automated branch creation configuration for an Amplify app. See auto_branch_creation_config Block for details.</summary>
    [JsonPropertyName("autoBranchCreationConfig")]
    public V1beta2AppSpecForProviderAutoBranchCreationConfig? AutoBranchCreationConfig { get; set; }

    /// <summary>Automated branch creation glob patterns for an Amplify app.</summary>
    [JsonPropertyName("autoBranchCreationPatterns")]
    public IList<string>? AutoBranchCreationPatterns { get; set; }

    /// <summary>Credentials for basic authorization for an Amplify app.</summary>
    [JsonPropertyName("basicAuthCredentialsSecretRef")]
    public V1beta2AppSpecForProviderBasicAuthCredentialsSecretRef? BasicAuthCredentialsSecretRef { get; set; }

    /// <summary>The build specification (build spec) for an Amplify app.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Cache configuration for the Amplify app. See cache_config Block for details.</summary>
    [JsonPropertyName("cacheConfig")]
    public V1beta2AppSpecForProviderCacheConfig? CacheConfig { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) SSR compute role for an Amplify app.</summary>
    [JsonPropertyName("computeRoleArn")]
    public string? ComputeRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate computeRoleArn.</summary>
    [JsonPropertyName("computeRoleArnRef")]
    public V1beta2AppSpecForProviderComputeRoleArnRef? ComputeRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate computeRoleArn.</summary>
    [JsonPropertyName("computeRoleArnSelector")]
    public V1beta2AppSpecForProviderComputeRoleArnSelector? ComputeRoleArnSelector { get; set; }

    /// <summary>The custom HTTP headers for an Amplify app.</summary>
    [JsonPropertyName("customHeaders")]
    public string? CustomHeaders { get; set; }

    /// <summary>Custom rewrite and redirect rules for an Amplify app. See custom_rule Block for details.</summary>
    [JsonPropertyName("customRule")]
    public IList<V1beta2AppSpecForProviderCustomRule>? CustomRule { get; set; }

    /// <summary>Description for an Amplify app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Enables automated branch creation for an Amplify app.</summary>
    [JsonPropertyName("enableAutoBranchCreation")]
    public bool? EnableAutoBranchCreation { get; set; }

    /// <summary>Enables basic authorization for an Amplify app. This will apply to all branches that are part of this app.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables auto-building of branches for the Amplify App.</summary>
    [JsonPropertyName("enableBranchAutoBuild")]
    public bool? EnableBranchAutoBuild { get; set; }

    /// <summary>Automatically disconnects a branch in the Amplify Console when you delete a branch from your Git repository.</summary>
    [JsonPropertyName("enableBranchAutoDeletion")]
    public bool? EnableBranchAutoDeletion { get; set; }

    /// <summary>Environment variables map for an Amplify app.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) service role for an Amplify app.</summary>
    [JsonPropertyName("iamServiceRoleArn")]
    public string? IamServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate iamServiceRoleArn.</summary>
    [JsonPropertyName("iamServiceRoleArnRef")]
    public V1beta2AppSpecForProviderIamServiceRoleArnRef? IamServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamServiceRoleArn.</summary>
    [JsonPropertyName("iamServiceRoleArnSelector")]
    public V1beta2AppSpecForProviderIamServiceRoleArnSelector? IamServiceRoleArnSelector { get; set; }

    /// <summary>Used to configure the Amplify Application build instance compute type. See job_config Block for details.</summary>
    [JsonPropertyName("jobConfig")]
    public V1beta2AppSpecForProviderJobConfig? JobConfig { get; set; }

    /// <summary>Name for an Amplify app.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OAuth token for a third-party source control system for an Amplify app. The OAuth token is used to create a webhook and a read-only deploy key. The OAuth token is not stored.</summary>
    [JsonPropertyName("oauthTokenSecretRef")]
    public V1beta2AppSpecForProviderOauthTokenSecretRef? OauthTokenSecretRef { get; set; }

    /// <summary>Platform or framework for an Amplify app. Valid values: WEB, WEB_COMPUTE. Default value: WEB.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Repository for an Amplify app.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Personal access token for a third-party source control system for an Amplify app. This token must have write access to the relevant repo to create a webhook and a read-only deploy key for the Amplify project. The token is not stored, so after applying this attribute can be removed and the setup token deleted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderAccessTokenSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Basic authorization credentials for the autocreated branch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderAutoBranchCreationConfigBasicAuthCredentialsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Automated branch creation configuration for an Amplify app. See auto_branch_creation_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderAutoBranchCreationConfig
{
    /// <summary>Basic authorization credentials for the autocreated branch.</summary>
    [JsonPropertyName("basicAuthCredentialsSecretRef")]
    public V1beta2AppSpecInitProviderAutoBranchCreationConfigBasicAuthCredentialsSecretRef? BasicAuthCredentialsSecretRef { get; set; }

    /// <summary>Build specification (build spec) for the autocreated branch.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Enables auto building for the autocreated branch.</summary>
    [JsonPropertyName("enableAutoBuild")]
    public bool? EnableAutoBuild { get; set; }

    /// <summary>Enables basic authorization for the autocreated branch.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables performance mode for the branch.</summary>
    [JsonPropertyName("enablePerformanceMode")]
    public bool? EnablePerformanceMode { get; set; }

    /// <summary>Enables pull request previews for the autocreated branch.</summary>
    [JsonPropertyName("enablePullRequestPreview")]
    public bool? EnablePullRequestPreview { get; set; }

    /// <summary>Environment variables for the autocreated branch.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Framework for the autocreated branch.</summary>
    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    /// <summary>Amplify environment name for the pull request.</summary>
    [JsonPropertyName("pullRequestEnvironmentName")]
    public string? PullRequestEnvironmentName { get; set; }

    /// <summary>Describes the current stage for the autocreated branch. Valid values: PRODUCTION, BETA, DEVELOPMENT, EXPERIMENTAL, PULL_REQUEST.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }
}

/// <summary>Credentials for basic authorization for an Amplify app.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderBasicAuthCredentialsSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Cache configuration for the Amplify app. See cache_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderCacheConfig
{
    /// <summary>Type of cache configuration to use for an Amplify app. Valid values: AMPLIFY_MANAGED, AMPLIFY_MANAGED_NO_COOKIES.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecInitProviderComputeRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2AppSpecInitProviderComputeRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecInitProviderComputeRoleArnRefPolicyResolveEnum>))]
public enum V1beta2AppSpecInitProviderComputeRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderComputeRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AppSpecInitProviderComputeRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AppSpecInitProviderComputeRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate computeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderComputeRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AppSpecInitProviderComputeRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecInitProviderComputeRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2AppSpecInitProviderComputeRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecInitProviderComputeRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2AppSpecInitProviderComputeRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderComputeRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AppSpecInitProviderComputeRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AppSpecInitProviderComputeRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate computeRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderComputeRoleArnSelector
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
    public V1beta2AppSpecInitProviderComputeRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderCustomRule
{
    /// <summary>Condition for a URL rewrite or redirect rule, such as a country code.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Source pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Status code for a URL rewrite or redirect rule. Valid values: 200, 301, 302, 404, 404-200.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecInitProviderIamServiceRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2AppSpecInitProviderIamServiceRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecInitProviderIamServiceRoleArnRefPolicyResolveEnum>))]
public enum V1beta2AppSpecInitProviderIamServiceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderIamServiceRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AppSpecInitProviderIamServiceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AppSpecInitProviderIamServiceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamServiceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderIamServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AppSpecInitProviderIamServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecInitProviderIamServiceRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2AppSpecInitProviderIamServiceRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecInitProviderIamServiceRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2AppSpecInitProviderIamServiceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderIamServiceRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AppSpecInitProviderIamServiceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AppSpecInitProviderIamServiceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamServiceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderIamServiceRoleArnSelector
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
    public V1beta2AppSpecInitProviderIamServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Used to configure the Amplify Application build instance compute type. See job_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderJobConfig
{
    /// <summary>Size of the build instance. Valid values: STANDARD_8GB, LARGE_16GB, and XLARGE_72GB. Default: STANDARD_8GB.</summary>
    [JsonPropertyName("buildComputeType")]
    public string? BuildComputeType { get; set; }
}

/// <summary>OAuth token for a third-party source control system for an Amplify app. The OAuth token is used to create a webhook and a read-only deploy key. The OAuth token is not stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecInitProviderOauthTokenSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
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
public partial class V1beta2AppSpecInitProvider
{
    /// <summary>Personal access token for a third-party source control system for an Amplify app. This token must have write access to the relevant repo to create a webhook and a read-only deploy key for the Amplify project. The token is not stored, so after applying this attribute can be removed and the setup token deleted.</summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta2AppSpecInitProviderAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>Automated branch creation configuration for an Amplify app. See auto_branch_creation_config Block for details.</summary>
    [JsonPropertyName("autoBranchCreationConfig")]
    public V1beta2AppSpecInitProviderAutoBranchCreationConfig? AutoBranchCreationConfig { get; set; }

    /// <summary>Automated branch creation glob patterns for an Amplify app.</summary>
    [JsonPropertyName("autoBranchCreationPatterns")]
    public IList<string>? AutoBranchCreationPatterns { get; set; }

    /// <summary>Credentials for basic authorization for an Amplify app.</summary>
    [JsonPropertyName("basicAuthCredentialsSecretRef")]
    public V1beta2AppSpecInitProviderBasicAuthCredentialsSecretRef? BasicAuthCredentialsSecretRef { get; set; }

    /// <summary>The build specification (build spec) for an Amplify app.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Cache configuration for the Amplify app. See cache_config Block for details.</summary>
    [JsonPropertyName("cacheConfig")]
    public V1beta2AppSpecInitProviderCacheConfig? CacheConfig { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) SSR compute role for an Amplify app.</summary>
    [JsonPropertyName("computeRoleArn")]
    public string? ComputeRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate computeRoleArn.</summary>
    [JsonPropertyName("computeRoleArnRef")]
    public V1beta2AppSpecInitProviderComputeRoleArnRef? ComputeRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate computeRoleArn.</summary>
    [JsonPropertyName("computeRoleArnSelector")]
    public V1beta2AppSpecInitProviderComputeRoleArnSelector? ComputeRoleArnSelector { get; set; }

    /// <summary>The custom HTTP headers for an Amplify app.</summary>
    [JsonPropertyName("customHeaders")]
    public string? CustomHeaders { get; set; }

    /// <summary>Custom rewrite and redirect rules for an Amplify app. See custom_rule Block for details.</summary>
    [JsonPropertyName("customRule")]
    public IList<V1beta2AppSpecInitProviderCustomRule>? CustomRule { get; set; }

    /// <summary>Description for an Amplify app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Enables automated branch creation for an Amplify app.</summary>
    [JsonPropertyName("enableAutoBranchCreation")]
    public bool? EnableAutoBranchCreation { get; set; }

    /// <summary>Enables basic authorization for an Amplify app. This will apply to all branches that are part of this app.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables auto-building of branches for the Amplify App.</summary>
    [JsonPropertyName("enableBranchAutoBuild")]
    public bool? EnableBranchAutoBuild { get; set; }

    /// <summary>Automatically disconnects a branch in the Amplify Console when you delete a branch from your Git repository.</summary>
    [JsonPropertyName("enableBranchAutoDeletion")]
    public bool? EnableBranchAutoDeletion { get; set; }

    /// <summary>Environment variables map for an Amplify app.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) service role for an Amplify app.</summary>
    [JsonPropertyName("iamServiceRoleArn")]
    public string? IamServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate iamServiceRoleArn.</summary>
    [JsonPropertyName("iamServiceRoleArnRef")]
    public V1beta2AppSpecInitProviderIamServiceRoleArnRef? IamServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamServiceRoleArn.</summary>
    [JsonPropertyName("iamServiceRoleArnSelector")]
    public V1beta2AppSpecInitProviderIamServiceRoleArnSelector? IamServiceRoleArnSelector { get; set; }

    /// <summary>Used to configure the Amplify Application build instance compute type. See job_config Block for details.</summary>
    [JsonPropertyName("jobConfig")]
    public V1beta2AppSpecInitProviderJobConfig? JobConfig { get; set; }

    /// <summary>Name for an Amplify app.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OAuth token for a third-party source control system for an Amplify app. The OAuth token is used to create a webhook and a read-only deploy key. The OAuth token is not stored.</summary>
    [JsonPropertyName("oauthTokenSecretRef")]
    public V1beta2AppSpecInitProviderOauthTokenSecretRef? OauthTokenSecretRef { get; set; }

    /// <summary>Platform or framework for an Amplify app. Valid values: WEB, WEB_COMPUTE. Default value: WEB.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Repository for an Amplify app.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecManagementPoliciesEnum>))]
public enum V1beta2AppSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2AppSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AppSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2AppSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AppSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AppSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AppSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AppSpec defines the desired state of App</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppSpec
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
    public V1beta2AppSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2AppSpecForProvider ForProvider { get; set; }

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
    public V1beta2AppSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2AppSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2AppSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2AppSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Automated branch creation configuration for an Amplify app. See auto_branch_creation_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppStatusAtProviderAutoBranchCreationConfig
{
    /// <summary>Build specification (build spec) for the autocreated branch.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Enables auto building for the autocreated branch.</summary>
    [JsonPropertyName("enableAutoBuild")]
    public bool? EnableAutoBuild { get; set; }

    /// <summary>Enables basic authorization for the autocreated branch.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables performance mode for the branch.</summary>
    [JsonPropertyName("enablePerformanceMode")]
    public bool? EnablePerformanceMode { get; set; }

    /// <summary>Enables pull request previews for the autocreated branch.</summary>
    [JsonPropertyName("enablePullRequestPreview")]
    public bool? EnablePullRequestPreview { get; set; }

    /// <summary>Environment variables for the autocreated branch.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Framework for the autocreated branch.</summary>
    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    /// <summary>Amplify environment name for the pull request.</summary>
    [JsonPropertyName("pullRequestEnvironmentName")]
    public string? PullRequestEnvironmentName { get; set; }

    /// <summary>Describes the current stage for the autocreated branch. Valid values: PRODUCTION, BETA, DEVELOPMENT, EXPERIMENTAL, PULL_REQUEST.</summary>
    [JsonPropertyName("stage")]
    public string? Stage { get; set; }
}

/// <summary>Cache configuration for the Amplify app. See cache_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppStatusAtProviderCacheConfig
{
    /// <summary>Type of cache configuration to use for an Amplify app. Valid values: AMPLIFY_MANAGED, AMPLIFY_MANAGED_NO_COOKIES.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppStatusAtProviderCustomRule
{
    /// <summary>Condition for a URL rewrite or redirect rule, such as a country code.</summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>Source pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Status code for a URL rewrite or redirect rule. Valid values: 200, 301, 302, 404, 404-200.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target pattern for a URL rewrite or redirect rule.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Used to configure the Amplify Application build instance compute type. See job_config Block for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppStatusAtProviderJobConfig
{
    /// <summary>Size of the build instance. Valid values: STANDARD_8GB, LARGE_16GB, and XLARGE_72GB. Default: STANDARD_8GB.</summary>
    [JsonPropertyName("buildComputeType")]
    public string? BuildComputeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppStatusAtProviderProductionBranch
{
    /// <summary>Branch name for the production branch.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Last deploy time of the production branch.</summary>
    [JsonPropertyName("lastDeployTime")]
    public string? LastDeployTime { get; set; }

    /// <summary>Status of the production branch.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Thumbnail URL for the production branch.</summary>
    [JsonPropertyName("thumbnailUrl")]
    public string? ThumbnailUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppStatusAtProvider
{
    /// <summary>ARN of the Amplify app.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Automated branch creation configuration for an Amplify app. See auto_branch_creation_config Block for details.</summary>
    [JsonPropertyName("autoBranchCreationConfig")]
    public V1beta2AppStatusAtProviderAutoBranchCreationConfig? AutoBranchCreationConfig { get; set; }

    /// <summary>Automated branch creation glob patterns for an Amplify app.</summary>
    [JsonPropertyName("autoBranchCreationPatterns")]
    public IList<string>? AutoBranchCreationPatterns { get; set; }

    /// <summary>The build specification (build spec) for an Amplify app.</summary>
    [JsonPropertyName("buildSpec")]
    public string? BuildSpec { get; set; }

    /// <summary>Cache configuration for the Amplify app. See cache_config Block for details.</summary>
    [JsonPropertyName("cacheConfig")]
    public V1beta2AppStatusAtProviderCacheConfig? CacheConfig { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) SSR compute role for an Amplify app.</summary>
    [JsonPropertyName("computeRoleArn")]
    public string? ComputeRoleArn { get; set; }

    /// <summary>The custom HTTP headers for an Amplify app.</summary>
    [JsonPropertyName("customHeaders")]
    public string? CustomHeaders { get; set; }

    /// <summary>Custom rewrite and redirect rules for an Amplify app. See custom_rule Block for details.</summary>
    [JsonPropertyName("customRule")]
    public IList<V1beta2AppStatusAtProviderCustomRule>? CustomRule { get; set; }

    /// <summary>Default domain for the Amplify app.</summary>
    [JsonPropertyName("defaultDomain")]
    public string? DefaultDomain { get; set; }

    /// <summary>Description for an Amplify app.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Enables automated branch creation for an Amplify app.</summary>
    [JsonPropertyName("enableAutoBranchCreation")]
    public bool? EnableAutoBranchCreation { get; set; }

    /// <summary>Enables basic authorization for an Amplify app. This will apply to all branches that are part of this app.</summary>
    [JsonPropertyName("enableBasicAuth")]
    public bool? EnableBasicAuth { get; set; }

    /// <summary>Enables auto-building of branches for the Amplify App.</summary>
    [JsonPropertyName("enableBranchAutoBuild")]
    public bool? EnableBranchAutoBuild { get; set; }

    /// <summary>Automatically disconnects a branch in the Amplify Console when you delete a branch from your Git repository.</summary>
    [JsonPropertyName("enableBranchAutoDeletion")]
    public bool? EnableBranchAutoDeletion { get; set; }

    /// <summary>Environment variables map for an Amplify app.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>AWS Identity and Access Management (IAM) service role for an Amplify app.</summary>
    [JsonPropertyName("iamServiceRoleArn")]
    public string? IamServiceRoleArn { get; set; }

    /// <summary>Unique ID of the Amplify app.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Used to configure the Amplify Application build instance compute type. See job_config Block for details.</summary>
    [JsonPropertyName("jobConfig")]
    public V1beta2AppStatusAtProviderJobConfig? JobConfig { get; set; }

    /// <summary>Name for an Amplify app.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Platform or framework for an Amplify app. Valid values: WEB, WEB_COMPUTE. Default value: WEB.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>Describes the information about a production branch for an Amplify app. A production_branch block is documented below.</summary>
    [JsonPropertyName("productionBranch")]
    public IList<V1beta2AppStatusAtProviderProductionBranch>? ProductionBranch { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Repository for an Amplify app.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppStatusConditions
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

/// <summary>AppStatus defines the observed state of App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AppStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2AppStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AppStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>App is the Schema for the Apps API. Provides an Amplify App resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2App : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AppSpec>, IStatus<V1beta2AppStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "App";
    public const string KubeGroup = "amplify.aws.upbound.io";
    public const string KubePluralName = "apps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "amplify.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "App";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppSpec defines the desired state of App</summary>
    [JsonPropertyName("spec")]
    public required V1beta2AppSpec Spec { get; set; }

    /// <summary>AppStatus defines the observed state of App.</summary>
    [JsonPropertyName("status")]
    public V1beta2AppStatus? Status { get; set; }
}