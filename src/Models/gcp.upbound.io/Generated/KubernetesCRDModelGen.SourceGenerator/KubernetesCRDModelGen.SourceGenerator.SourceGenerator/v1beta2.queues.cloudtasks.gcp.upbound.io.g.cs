#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudtasks.gcp.upbound.io;
/// <summary>Queue is the Schema for the Queues API. A named resource to which messages are sent by publishers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2QueueList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Queue>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "QueueList";
    public const string KubeGroup = "cloudtasks.gcp.upbound.io";
    public const string KubePluralName = "queues";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudtasks.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "QueueList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Queue objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Queue> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecDeletionPolicyEnum>))]
public enum V1beta2QueueSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Overrides for task-level appEngineRouting. These settings apply only
/// to App Engine tasks in this queue
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderAppEngineRoutingOverride
{
    /// <summary>
    /// App instance.
    /// By default, the task is sent to an instance which is available when the task is attempted.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>
    /// App service.
    /// By default, the task is sent to the service which is the default service when the task is attempted.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// App version.
    /// By default, the task is sent to the version which is the default version when the task is attempted.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Header embodying a key and a value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetHeaderOverridesHeader
{
    /// <summary>The Key of the header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Value of the header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetHeaderOverrides
{
    /// <summary>
    /// Header embodying a key and a value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("header")]
    public V1beta2QueueSpecForProviderHttpTargetHeaderOverridesHeader? Header { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailSelector
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
    public V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If specified, an OAuth token is generated and attached as the Authorization header in the HTTP request.
/// This type of authorization should generally be used only when calling Google APIs hosted on *.googleapis.com.
/// Note that both the service account email and the scope MUST be specified when using the queue-level authorization override.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetOauthToken
{
    /// <summary>
    /// OAuth scope to be used for generating OAuth access token.
    /// If not specified, &quot;https://www.googleapis.com/auth/cloud-platform&quot; will be used.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Service account email to be used for generating OIDC token.
    /// The service account must be within the same project as the queue.
    /// The caller must have iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2QueueSpecForProviderHttpTargetOauthTokenServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailSelector
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
    public V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If specified, an OIDC token is generated and attached as an Authorization header in the HTTP request.
/// This type of authorization can be used for many scenarios, including calling Cloud Run, or endpoints where you intend to validate the token yourself.
/// Note that both the service account email and the audience MUST be specified when using the queue-level authorization override.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetOidcToken
{
    /// <summary>Audience to be used when generating OIDC token. If not specified, the URI specified in target will be used.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Service account email to be used for generating OIDC token.
    /// The service account must be within the same project as the queue.
    /// The caller must have iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2QueueSpecForProviderHttpTargetOidcTokenServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }
}

/// <summary>
/// URI path.
/// When specified, replaces the existing path of the task URL.
/// Setting the path value to an empty string clears the URI path segment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetUriOverridePathOverride
{
    /// <summary>The URI path (e.g., /users/1234). Default is an empty string.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// URI query.
/// When specified, replaces the query part of the task URI. Setting the query value to an empty string clears the URI query segment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetUriOverrideQueryOverride
{
    /// <summary>The query parameters (e.g., qparam1=123&amp;qparam2=456). Default is an empty string.</summary>
    [JsonPropertyName("queryParams")]
    public string? QueryParams { get; set; }
}

/// <summary>
/// URI override.
/// When specified, overrides the execution URI for all the tasks in the queue.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTargetUriOverride
{
    /// <summary>
    /// Host override.
    /// When specified, replaces the host part of the task URL.
    /// For example, if the task URL is &quot;https://www.google.com&quot;, and host value
    /// is set to &quot;example.net&quot;, the overridden URI will be changed to &quot;https://example.net&quot;.
    /// Host value cannot be an empty string (INVALID_ARGUMENT).
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// URI path.
    /// When specified, replaces the existing path of the task URL.
    /// Setting the path value to an empty string clears the URI path segment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pathOverride")]
    public V1beta2QueueSpecForProviderHttpTargetUriOverridePathOverride? PathOverride { get; set; }

    /// <summary>
    /// Port override.
    /// When specified, replaces the port part of the task URI.
    /// For instance, for a URI http://www.google.com/foo and port=123, the overridden URI becomes http://www.google.com:123/foo.
    /// Note that the port value must be a positive integer.
    /// Setting the port to 0 (Zero) clears the URI port.
    /// </summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// URI query.
    /// When specified, replaces the query part of the task URI. Setting the query value to an empty string clears the URI query segment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queryOverride")]
    public V1beta2QueueSpecForProviderHttpTargetUriOverrideQueryOverride? QueryOverride { get; set; }

    /// <summary>
    /// Scheme override.
    /// When specified, the task URI scheme is replaced by the provided value (HTTP or HTTPS).
    /// Possible values are: HTTP, HTTPS.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// URI Override Enforce Mode
    /// When specified, determines the Target UriOverride mode. If not specified, it defaults to ALWAYS.
    /// Possible values are: ALWAYS, IF_NOT_EXISTS.
    /// </summary>
    [JsonPropertyName("uriOverrideEnforceMode")]
    public string? UriOverrideEnforceMode { get; set; }
}

/// <summary>
/// Modifies HTTP target for HTTP tasks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderHttpTarget
{
    /// <summary>
    /// HTTP target headers.
    /// This map contains the header field names and values.
    /// Headers will be set when running the CreateTask and/or BufferTask.
    /// These headers represent a subset of the headers that will be configured for the task&apos;s HTTP request.
    /// Some HTTP request headers will be ignored or replaced.
    /// Headers which can have multiple values (according to RFC2616) can be specified using comma-separated values.
    /// The size of the headers must be less than 80KB. Queue-level headers to override headers of all the tasks in the queue.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerOverrides")]
    public IList<V1beta2QueueSpecForProviderHttpTargetHeaderOverrides>? HeaderOverrides { get; set; }

    /// <summary>
    /// The HTTP method to use for the request.
    /// When specified, it overrides HttpRequest for the task.
    /// Note that if the value is set to GET the body of the task will be ignored at execution time.
    /// Possible values are: HTTP_METHOD_UNSPECIFIED, POST, GET, HEAD, PUT, DELETE, PATCH, OPTIONS.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// If specified, an OAuth token is generated and attached as the Authorization header in the HTTP request.
    /// This type of authorization should generally be used only when calling Google APIs hosted on *.googleapis.com.
    /// Note that both the service account email and the scope MUST be specified when using the queue-level authorization override.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthToken")]
    public V1beta2QueueSpecForProviderHttpTargetOauthToken? OauthToken { get; set; }

    /// <summary>
    /// If specified, an OIDC token is generated and attached as an Authorization header in the HTTP request.
    /// This type of authorization can be used for many scenarios, including calling Cloud Run, or endpoints where you intend to validate the token yourself.
    /// Note that both the service account email and the audience MUST be specified when using the queue-level authorization override.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcToken")]
    public V1beta2QueueSpecForProviderHttpTargetOidcToken? OidcToken { get; set; }

    /// <summary>
    /// URI override.
    /// When specified, overrides the execution URI for all the tasks in the queue.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("uriOverride")]
    public V1beta2QueueSpecForProviderHttpTargetUriOverride? UriOverride { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderProjectRefPolicyResolutionEnum>))]
public enum V1beta2QueueSpecForProviderProjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderProjectRefPolicyResolveEnum>))]
public enum V1beta2QueueSpecForProviderProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderProjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecForProviderProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecForProviderProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecForProviderProjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderProjectSelectorPolicyResolutionEnum>))]
public enum V1beta2QueueSpecForProviderProjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecForProviderProjectSelectorPolicyResolveEnum>))]
public enum V1beta2QueueSpecForProviderProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderProjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecForProviderProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecForProviderProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderProjectSelector
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
    public V1beta2QueueSpecForProviderProjectSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Rate limits for task dispatches.
/// The queue&apos;s actual dispatch rate is the result of:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderRateLimits
{
    /// <summary>
    /// The maximum number of concurrent tasks that Cloud Tasks allows to
    /// be dispatched for this queue. After this threshold has been
    /// reached, Cloud Tasks stops dispatching tasks until the number of
    /// concurrent requests decreases.
    /// </summary>
    [JsonPropertyName("maxConcurrentDispatches")]
    public double? MaxConcurrentDispatches { get; set; }

    /// <summary>
    /// The maximum rate at which tasks are dispatched from this queue.
    /// If unspecified when the queue is created, Cloud Tasks will pick the default.
    /// </summary>
    [JsonPropertyName("maxDispatchesPerSecond")]
    public double? MaxDispatchesPerSecond { get; set; }
}

/// <summary>
/// Settings that determine the retry behavior.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderRetryConfig
{
    /// <summary>
    /// Number of attempts per task.
    /// Cloud Tasks will attempt the task maxAttempts times (that is, if
    /// the first attempt fails, then there will be maxAttempts - 1
    /// retries). Must be &gt;= -1.
    /// If unspecified when the queue is created, Cloud Tasks will pick
    /// the default.
    /// -1 indicates unlimited attempts.
    /// </summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&apos;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [JsonPropertyName("maxBackoff")]
    public string? MaxBackoff { get; set; }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// A task&apos;s retry interval starts at minBackoff, then doubles maxDoublings times,
    /// then increases linearly, and finally retries retries at intervals of maxBackoff
    /// up to maxAttempts times.
    /// </summary>
    [JsonPropertyName("maxDoublings")]
    public double? MaxDoublings { get; set; }

    /// <summary>
    /// If positive, maxRetryDuration specifies the time limit for
    /// retrying a failed task, measured from when the task was first
    /// attempted. Once maxRetryDuration time has passed and the task has
    /// been attempted maxAttempts times, no further attempts will be
    /// made and the task will be deleted.
    /// If zero, then the task age is unlimited.
    /// </summary>
    [JsonPropertyName("maxRetryDuration")]
    public string? MaxRetryDuration { get; set; }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&apos;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [JsonPropertyName("minBackoff")]
    public string? MinBackoff { get; set; }
}

/// <summary>
/// Configuration options for writing logs to Stackdriver Logging.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProviderStackdriverLoggingConfig
{
    /// <summary>
    /// Specifies the fraction of operations to write to Stackdriver Logging.
    /// This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the
    /// default and means that no operations are logged.
    /// </summary>
    [JsonPropertyName("samplingRatio")]
    public double? SamplingRatio { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecForProvider
{
    /// <summary>
    /// Overrides for task-level appEngineRouting. These settings apply only
    /// to App Engine tasks in this queue
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngineRoutingOverride")]
    public V1beta2QueueSpecForProviderAppEngineRoutingOverride? AppEngineRoutingOverride { get; set; }

    /// <summary>
    /// Modifies HTTP target for HTTP tasks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpTarget")]
    public V1beta2QueueSpecForProviderHttpTarget? HttpTarget { get; set; }

    /// <summary>The location of the queue</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta2QueueSpecForProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta2QueueSpecForProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>
    /// Rate limits for task dispatches.
    /// The queue&apos;s actual dispatch rate is the result of:
    /// </summary>
    [JsonPropertyName("rateLimits")]
    public V1beta2QueueSpecForProviderRateLimits? RateLimits { get; set; }

    /// <summary>
    /// Settings that determine the retry behavior.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryConfig")]
    public V1beta2QueueSpecForProviderRetryConfig? RetryConfig { get; set; }

    /// <summary>
    /// Configuration options for writing logs to Stackdriver Logging.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("stackdriverLoggingConfig")]
    public V1beta2QueueSpecForProviderStackdriverLoggingConfig? StackdriverLoggingConfig { get; set; }
}

/// <summary>
/// Overrides for task-level appEngineRouting. These settings apply only
/// to App Engine tasks in this queue
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderAppEngineRoutingOverride
{
    /// <summary>
    /// App instance.
    /// By default, the task is sent to an instance which is available when the task is attempted.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>
    /// App service.
    /// By default, the task is sent to the service which is the default service when the task is attempted.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// App version.
    /// By default, the task is sent to the version which is the default version when the task is attempted.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Header embodying a key and a value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetHeaderOverridesHeader
{
    /// <summary>The Key of the header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Value of the header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetHeaderOverrides
{
    /// <summary>
    /// Header embodying a key and a value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("header")]
    public V1beta2QueueSpecInitProviderHttpTargetHeaderOverridesHeader? Header { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailSelector
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
    public V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If specified, an OAuth token is generated and attached as the Authorization header in the HTTP request.
/// This type of authorization should generally be used only when calling Google APIs hosted on *.googleapis.com.
/// Note that both the service account email and the scope MUST be specified when using the queue-level authorization override.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetOauthToken
{
    /// <summary>
    /// OAuth scope to be used for generating OAuth access token.
    /// If not specified, &quot;https://www.googleapis.com/auth/cloud-platform&quot; will be used.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Service account email to be used for generating OIDC token.
    /// The service account must be within the same project as the queue.
    /// The caller must have iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2QueueSpecInitProviderHttpTargetOauthTokenServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailSelector
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
    public V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If specified, an OIDC token is generated and attached as an Authorization header in the HTTP request.
/// This type of authorization can be used for many scenarios, including calling Cloud Run, or endpoints where you intend to validate the token yourself.
/// Note that both the service account email and the audience MUST be specified when using the queue-level authorization override.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetOidcToken
{
    /// <summary>Audience to be used when generating OIDC token. If not specified, the URI specified in target will be used.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Service account email to be used for generating OIDC token.
    /// The service account must be within the same project as the queue.
    /// The caller must have iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2QueueSpecInitProviderHttpTargetOidcTokenServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }
}

/// <summary>
/// URI path.
/// When specified, replaces the existing path of the task URL.
/// Setting the path value to an empty string clears the URI path segment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetUriOverridePathOverride
{
    /// <summary>The URI path (e.g., /users/1234). Default is an empty string.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// URI query.
/// When specified, replaces the query part of the task URI. Setting the query value to an empty string clears the URI query segment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetUriOverrideQueryOverride
{
    /// <summary>The query parameters (e.g., qparam1=123&amp;qparam2=456). Default is an empty string.</summary>
    [JsonPropertyName("queryParams")]
    public string? QueryParams { get; set; }
}

/// <summary>
/// URI override.
/// When specified, overrides the execution URI for all the tasks in the queue.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTargetUriOverride
{
    /// <summary>
    /// Host override.
    /// When specified, replaces the host part of the task URL.
    /// For example, if the task URL is &quot;https://www.google.com&quot;, and host value
    /// is set to &quot;example.net&quot;, the overridden URI will be changed to &quot;https://example.net&quot;.
    /// Host value cannot be an empty string (INVALID_ARGUMENT).
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// URI path.
    /// When specified, replaces the existing path of the task URL.
    /// Setting the path value to an empty string clears the URI path segment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pathOverride")]
    public V1beta2QueueSpecInitProviderHttpTargetUriOverridePathOverride? PathOverride { get; set; }

    /// <summary>
    /// Port override.
    /// When specified, replaces the port part of the task URI.
    /// For instance, for a URI http://www.google.com/foo and port=123, the overridden URI becomes http://www.google.com:123/foo.
    /// Note that the port value must be a positive integer.
    /// Setting the port to 0 (Zero) clears the URI port.
    /// </summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// URI query.
    /// When specified, replaces the query part of the task URI. Setting the query value to an empty string clears the URI query segment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queryOverride")]
    public V1beta2QueueSpecInitProviderHttpTargetUriOverrideQueryOverride? QueryOverride { get; set; }

    /// <summary>
    /// Scheme override.
    /// When specified, the task URI scheme is replaced by the provided value (HTTP or HTTPS).
    /// Possible values are: HTTP, HTTPS.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// URI Override Enforce Mode
    /// When specified, determines the Target UriOverride mode. If not specified, it defaults to ALWAYS.
    /// Possible values are: ALWAYS, IF_NOT_EXISTS.
    /// </summary>
    [JsonPropertyName("uriOverrideEnforceMode")]
    public string? UriOverrideEnforceMode { get; set; }
}

/// <summary>
/// Modifies HTTP target for HTTP tasks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderHttpTarget
{
    /// <summary>
    /// HTTP target headers.
    /// This map contains the header field names and values.
    /// Headers will be set when running the CreateTask and/or BufferTask.
    /// These headers represent a subset of the headers that will be configured for the task&apos;s HTTP request.
    /// Some HTTP request headers will be ignored or replaced.
    /// Headers which can have multiple values (according to RFC2616) can be specified using comma-separated values.
    /// The size of the headers must be less than 80KB. Queue-level headers to override headers of all the tasks in the queue.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerOverrides")]
    public IList<V1beta2QueueSpecInitProviderHttpTargetHeaderOverrides>? HeaderOverrides { get; set; }

    /// <summary>
    /// The HTTP method to use for the request.
    /// When specified, it overrides HttpRequest for the task.
    /// Note that if the value is set to GET the body of the task will be ignored at execution time.
    /// Possible values are: HTTP_METHOD_UNSPECIFIED, POST, GET, HEAD, PUT, DELETE, PATCH, OPTIONS.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// If specified, an OAuth token is generated and attached as the Authorization header in the HTTP request.
    /// This type of authorization should generally be used only when calling Google APIs hosted on *.googleapis.com.
    /// Note that both the service account email and the scope MUST be specified when using the queue-level authorization override.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthToken")]
    public V1beta2QueueSpecInitProviderHttpTargetOauthToken? OauthToken { get; set; }

    /// <summary>
    /// If specified, an OIDC token is generated and attached as an Authorization header in the HTTP request.
    /// This type of authorization can be used for many scenarios, including calling Cloud Run, or endpoints where you intend to validate the token yourself.
    /// Note that both the service account email and the audience MUST be specified when using the queue-level authorization override.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcToken")]
    public V1beta2QueueSpecInitProviderHttpTargetOidcToken? OidcToken { get; set; }

    /// <summary>
    /// URI override.
    /// When specified, overrides the execution URI for all the tasks in the queue.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("uriOverride")]
    public V1beta2QueueSpecInitProviderHttpTargetUriOverride? UriOverride { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderProjectRefPolicyResolutionEnum>))]
public enum V1beta2QueueSpecInitProviderProjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderProjectRefPolicyResolveEnum>))]
public enum V1beta2QueueSpecInitProviderProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderProjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecInitProviderProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecInitProviderProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecInitProviderProjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderProjectSelectorPolicyResolutionEnum>))]
public enum V1beta2QueueSpecInitProviderProjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecInitProviderProjectSelectorPolicyResolveEnum>))]
public enum V1beta2QueueSpecInitProviderProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderProjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecInitProviderProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecInitProviderProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderProjectSelector
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
    public V1beta2QueueSpecInitProviderProjectSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Rate limits for task dispatches.
/// The queue&apos;s actual dispatch rate is the result of:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderRateLimits
{
    /// <summary>
    /// The maximum number of concurrent tasks that Cloud Tasks allows to
    /// be dispatched for this queue. After this threshold has been
    /// reached, Cloud Tasks stops dispatching tasks until the number of
    /// concurrent requests decreases.
    /// </summary>
    [JsonPropertyName("maxConcurrentDispatches")]
    public double? MaxConcurrentDispatches { get; set; }

    /// <summary>
    /// The maximum rate at which tasks are dispatched from this queue.
    /// If unspecified when the queue is created, Cloud Tasks will pick the default.
    /// </summary>
    [JsonPropertyName("maxDispatchesPerSecond")]
    public double? MaxDispatchesPerSecond { get; set; }
}

/// <summary>
/// Settings that determine the retry behavior.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderRetryConfig
{
    /// <summary>
    /// Number of attempts per task.
    /// Cloud Tasks will attempt the task maxAttempts times (that is, if
    /// the first attempt fails, then there will be maxAttempts - 1
    /// retries). Must be &gt;= -1.
    /// If unspecified when the queue is created, Cloud Tasks will pick
    /// the default.
    /// -1 indicates unlimited attempts.
    /// </summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&apos;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [JsonPropertyName("maxBackoff")]
    public string? MaxBackoff { get; set; }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// A task&apos;s retry interval starts at minBackoff, then doubles maxDoublings times,
    /// then increases linearly, and finally retries retries at intervals of maxBackoff
    /// up to maxAttempts times.
    /// </summary>
    [JsonPropertyName("maxDoublings")]
    public double? MaxDoublings { get; set; }

    /// <summary>
    /// If positive, maxRetryDuration specifies the time limit for
    /// retrying a failed task, measured from when the task was first
    /// attempted. Once maxRetryDuration time has passed and the task has
    /// been attempted maxAttempts times, no further attempts will be
    /// made and the task will be deleted.
    /// If zero, then the task age is unlimited.
    /// </summary>
    [JsonPropertyName("maxRetryDuration")]
    public string? MaxRetryDuration { get; set; }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&apos;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [JsonPropertyName("minBackoff")]
    public string? MinBackoff { get; set; }
}

/// <summary>
/// Configuration options for writing logs to Stackdriver Logging.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecInitProviderStackdriverLoggingConfig
{
    /// <summary>
    /// Specifies the fraction of operations to write to Stackdriver Logging.
    /// This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the
    /// default and means that no operations are logged.
    /// </summary>
    [JsonPropertyName("samplingRatio")]
    public double? SamplingRatio { get; set; }
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
public partial class V1beta2QueueSpecInitProvider
{
    /// <summary>
    /// Overrides for task-level appEngineRouting. These settings apply only
    /// to App Engine tasks in this queue
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngineRoutingOverride")]
    public V1beta2QueueSpecInitProviderAppEngineRoutingOverride? AppEngineRoutingOverride { get; set; }

    /// <summary>
    /// Modifies HTTP target for HTTP tasks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpTarget")]
    public V1beta2QueueSpecInitProviderHttpTarget? HttpTarget { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta2QueueSpecInitProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta2QueueSpecInitProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>
    /// Rate limits for task dispatches.
    /// The queue&apos;s actual dispatch rate is the result of:
    /// </summary>
    [JsonPropertyName("rateLimits")]
    public V1beta2QueueSpecInitProviderRateLimits? RateLimits { get; set; }

    /// <summary>
    /// Settings that determine the retry behavior.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryConfig")]
    public V1beta2QueueSpecInitProviderRetryConfig? RetryConfig { get; set; }

    /// <summary>
    /// Configuration options for writing logs to Stackdriver Logging.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("stackdriverLoggingConfig")]
    public V1beta2QueueSpecInitProviderStackdriverLoggingConfig? StackdriverLoggingConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecManagementPoliciesEnum>))]
public enum V1beta2QueueSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2QueueSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2QueueSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2QueueSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2QueueSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2QueueSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2QueueSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>QueueSpec defines the desired state of Queue</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueSpec
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
    public V1beta2QueueSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2QueueSpecForProvider ForProvider { get; set; }

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
    public V1beta2QueueSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2QueueSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2QueueSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2QueueSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Overrides for task-level appEngineRouting. These settings apply only
/// to App Engine tasks in this queue
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderAppEngineRoutingOverride
{
    /// <summary>
    /// (Output)
    /// The host that the task is sent to.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// App instance.
    /// By default, the task is sent to an instance which is available when the task is attempted.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>
    /// App service.
    /// By default, the task is sent to the service which is the default service when the task is attempted.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// App version.
    /// By default, the task is sent to the version which is the default version when the task is attempted.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Header embodying a key and a value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderHttpTargetHeaderOverridesHeader
{
    /// <summary>The Key of the header.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Value of the header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderHttpTargetHeaderOverrides
{
    /// <summary>
    /// Header embodying a key and a value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("header")]
    public V1beta2QueueStatusAtProviderHttpTargetHeaderOverridesHeader? Header { get; set; }
}

/// <summary>
/// If specified, an OAuth token is generated and attached as the Authorization header in the HTTP request.
/// This type of authorization should generally be used only when calling Google APIs hosted on *.googleapis.com.
/// Note that both the service account email and the scope MUST be specified when using the queue-level authorization override.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderHttpTargetOauthToken
{
    /// <summary>
    /// OAuth scope to be used for generating OAuth access token.
    /// If not specified, &quot;https://www.googleapis.com/auth/cloud-platform&quot; will be used.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Service account email to be used for generating OIDC token.
    /// The service account must be within the same project as the queue.
    /// The caller must have iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary>
/// If specified, an OIDC token is generated and attached as an Authorization header in the HTTP request.
/// This type of authorization can be used for many scenarios, including calling Cloud Run, or endpoints where you intend to validate the token yourself.
/// Note that both the service account email and the audience MUST be specified when using the queue-level authorization override.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderHttpTargetOidcToken
{
    /// <summary>Audience to be used when generating OIDC token. If not specified, the URI specified in target will be used.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }

    /// <summary>
    /// Service account email to be used for generating OIDC token.
    /// The service account must be within the same project as the queue.
    /// The caller must have iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }
}

/// <summary>
/// URI path.
/// When specified, replaces the existing path of the task URL.
/// Setting the path value to an empty string clears the URI path segment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderHttpTargetUriOverridePathOverride
{
    /// <summary>The URI path (e.g., /users/1234). Default is an empty string.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// URI query.
/// When specified, replaces the query part of the task URI. Setting the query value to an empty string clears the URI query segment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderHttpTargetUriOverrideQueryOverride
{
    /// <summary>The query parameters (e.g., qparam1=123&amp;qparam2=456). Default is an empty string.</summary>
    [JsonPropertyName("queryParams")]
    public string? QueryParams { get; set; }
}

/// <summary>
/// URI override.
/// When specified, overrides the execution URI for all the tasks in the queue.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderHttpTargetUriOverride
{
    /// <summary>
    /// Host override.
    /// When specified, replaces the host part of the task URL.
    /// For example, if the task URL is &quot;https://www.google.com&quot;, and host value
    /// is set to &quot;example.net&quot;, the overridden URI will be changed to &quot;https://example.net&quot;.
    /// Host value cannot be an empty string (INVALID_ARGUMENT).
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// URI path.
    /// When specified, replaces the existing path of the task URL.
    /// Setting the path value to an empty string clears the URI path segment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pathOverride")]
    public V1beta2QueueStatusAtProviderHttpTargetUriOverridePathOverride? PathOverride { get; set; }

    /// <summary>
    /// Port override.
    /// When specified, replaces the port part of the task URI.
    /// For instance, for a URI http://www.google.com/foo and port=123, the overridden URI becomes http://www.google.com:123/foo.
    /// Note that the port value must be a positive integer.
    /// Setting the port to 0 (Zero) clears the URI port.
    /// </summary>
    [JsonPropertyName("port")]
    public string? Port { get; set; }

    /// <summary>
    /// URI query.
    /// When specified, replaces the query part of the task URI. Setting the query value to an empty string clears the URI query segment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queryOverride")]
    public V1beta2QueueStatusAtProviderHttpTargetUriOverrideQueryOverride? QueryOverride { get; set; }

    /// <summary>
    /// Scheme override.
    /// When specified, the task URI scheme is replaced by the provided value (HTTP or HTTPS).
    /// Possible values are: HTTP, HTTPS.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// URI Override Enforce Mode
    /// When specified, determines the Target UriOverride mode. If not specified, it defaults to ALWAYS.
    /// Possible values are: ALWAYS, IF_NOT_EXISTS.
    /// </summary>
    [JsonPropertyName("uriOverrideEnforceMode")]
    public string? UriOverrideEnforceMode { get; set; }
}

/// <summary>
/// Modifies HTTP target for HTTP tasks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderHttpTarget
{
    /// <summary>
    /// HTTP target headers.
    /// This map contains the header field names and values.
    /// Headers will be set when running the CreateTask and/or BufferTask.
    /// These headers represent a subset of the headers that will be configured for the task&apos;s HTTP request.
    /// Some HTTP request headers will be ignored or replaced.
    /// Headers which can have multiple values (according to RFC2616) can be specified using comma-separated values.
    /// The size of the headers must be less than 80KB. Queue-level headers to override headers of all the tasks in the queue.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerOverrides")]
    public IList<V1beta2QueueStatusAtProviderHttpTargetHeaderOverrides>? HeaderOverrides { get; set; }

    /// <summary>
    /// The HTTP method to use for the request.
    /// When specified, it overrides HttpRequest for the task.
    /// Note that if the value is set to GET the body of the task will be ignored at execution time.
    /// Possible values are: HTTP_METHOD_UNSPECIFIED, POST, GET, HEAD, PUT, DELETE, PATCH, OPTIONS.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public string? HttpMethod { get; set; }

    /// <summary>
    /// If specified, an OAuth token is generated and attached as the Authorization header in the HTTP request.
    /// This type of authorization should generally be used only when calling Google APIs hosted on *.googleapis.com.
    /// Note that both the service account email and the scope MUST be specified when using the queue-level authorization override.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oauthToken")]
    public V1beta2QueueStatusAtProviderHttpTargetOauthToken? OauthToken { get; set; }

    /// <summary>
    /// If specified, an OIDC token is generated and attached as an Authorization header in the HTTP request.
    /// This type of authorization can be used for many scenarios, including calling Cloud Run, or endpoints where you intend to validate the token yourself.
    /// Note that both the service account email and the audience MUST be specified when using the queue-level authorization override.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidcToken")]
    public V1beta2QueueStatusAtProviderHttpTargetOidcToken? OidcToken { get; set; }

    /// <summary>
    /// URI override.
    /// When specified, overrides the execution URI for all the tasks in the queue.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("uriOverride")]
    public V1beta2QueueStatusAtProviderHttpTargetUriOverride? UriOverride { get; set; }
}

/// <summary>
/// Rate limits for task dispatches.
/// The queue&apos;s actual dispatch rate is the result of:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderRateLimits
{
    /// <summary>
    /// (Output)
    /// The max burst size.
    /// Max burst size limits how fast tasks in queue are processed when many tasks are
    /// in the queue and the rate is high. This field allows the queue to have a high
    /// rate so processing starts shortly after a task is enqueued, but still limits
    /// resource usage when many tasks are enqueued in a short period of time.
    /// </summary>
    [JsonPropertyName("maxBurstSize")]
    public double? MaxBurstSize { get; set; }

    /// <summary>
    /// The maximum number of concurrent tasks that Cloud Tasks allows to
    /// be dispatched for this queue. After this threshold has been
    /// reached, Cloud Tasks stops dispatching tasks until the number of
    /// concurrent requests decreases.
    /// </summary>
    [JsonPropertyName("maxConcurrentDispatches")]
    public double? MaxConcurrentDispatches { get; set; }

    /// <summary>
    /// The maximum rate at which tasks are dispatched from this queue.
    /// If unspecified when the queue is created, Cloud Tasks will pick the default.
    /// </summary>
    [JsonPropertyName("maxDispatchesPerSecond")]
    public double? MaxDispatchesPerSecond { get; set; }
}

/// <summary>
/// Settings that determine the retry behavior.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderRetryConfig
{
    /// <summary>
    /// Number of attempts per task.
    /// Cloud Tasks will attempt the task maxAttempts times (that is, if
    /// the first attempt fails, then there will be maxAttempts - 1
    /// retries). Must be &gt;= -1.
    /// If unspecified when the queue is created, Cloud Tasks will pick
    /// the default.
    /// -1 indicates unlimited attempts.
    /// </summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&apos;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [JsonPropertyName("maxBackoff")]
    public string? MaxBackoff { get; set; }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// A task&apos;s retry interval starts at minBackoff, then doubles maxDoublings times,
    /// then increases linearly, and finally retries retries at intervals of maxBackoff
    /// up to maxAttempts times.
    /// </summary>
    [JsonPropertyName("maxDoublings")]
    public double? MaxDoublings { get; set; }

    /// <summary>
    /// If positive, maxRetryDuration specifies the time limit for
    /// retrying a failed task, measured from when the task was first
    /// attempted. Once maxRetryDuration time has passed and the task has
    /// been attempted maxAttempts times, no further attempts will be
    /// made and the task will be deleted.
    /// If zero, then the task age is unlimited.
    /// </summary>
    [JsonPropertyName("maxRetryDuration")]
    public string? MaxRetryDuration { get; set; }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&apos;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [JsonPropertyName("minBackoff")]
    public string? MinBackoff { get; set; }
}

/// <summary>
/// Configuration options for writing logs to Stackdriver Logging.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProviderStackdriverLoggingConfig
{
    /// <summary>
    /// Specifies the fraction of operations to write to Stackdriver Logging.
    /// This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the
    /// default and means that no operations are logged.
    /// </summary>
    [JsonPropertyName("samplingRatio")]
    public double? SamplingRatio { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusAtProvider
{
    /// <summary>
    /// Overrides for task-level appEngineRouting. These settings apply only
    /// to App Engine tasks in this queue
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("appEngineRoutingOverride")]
    public V1beta2QueueStatusAtProviderAppEngineRoutingOverride? AppEngineRoutingOverride { get; set; }

    /// <summary>
    /// Modifies HTTP target for HTTP tasks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpTarget")]
    public V1beta2QueueStatusAtProviderHttpTarget? HttpTarget { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/queues/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The location of the queue</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Rate limits for task dispatches.
    /// The queue&apos;s actual dispatch rate is the result of:
    /// </summary>
    [JsonPropertyName("rateLimits")]
    public V1beta2QueueStatusAtProviderRateLimits? RateLimits { get; set; }

    /// <summary>
    /// Settings that determine the retry behavior.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryConfig")]
    public V1beta2QueueStatusAtProviderRetryConfig? RetryConfig { get; set; }

    /// <summary>
    /// Configuration options for writing logs to Stackdriver Logging.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("stackdriverLoggingConfig")]
    public V1beta2QueueStatusAtProviderStackdriverLoggingConfig? StackdriverLoggingConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatusConditions
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

/// <summary>QueueStatus defines the observed state of Queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2QueueStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2QueueStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2QueueStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Queue is the Schema for the Queues API. A named resource to which messages are sent by publishers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Queue : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2QueueSpec>, IStatus<V1beta2QueueStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Queue";
    public const string KubeGroup = "cloudtasks.gcp.upbound.io";
    public const string KubePluralName = "queues";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudtasks.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Queue";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>QueueSpec defines the desired state of Queue</summary>
    [JsonPropertyName("spec")]
    public required V1beta2QueueSpec Spec { get; set; }

    /// <summary>QueueStatus defines the observed state of Queue.</summary>
    [JsonPropertyName("status")]
    public V1beta2QueueStatus? Status { get; set; }
}