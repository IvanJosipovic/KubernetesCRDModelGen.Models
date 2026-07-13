#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>
/// ManagedSubscription defines a Subscription managed by the API manager as the result of a pre-negotiation with its
/// API consumers. This subscription grant consuming access to a set of APIs to a set of Applications.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ManagedSubscription>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedSubscriptionList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "managedsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedSubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ManagedSubscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ManagedSubscription> Items { get; set; }
}

/// <summary>APIBundleReference references an APIBundle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApiBundles
{
    /// <summary>Name of the APIBundle.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>APIPlan defines which APIPlan will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApiPlan
{
    /// <summary>Name of the APIPlan.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApiSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// APISelector selects the APIs that will be accessible.
/// Multiple ManagedSubscriptions can select the same set of APIs.
/// This field is optional and follows standard label selector semantics.
/// An empty APISelector matches any API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApiSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1ManagedSubscriptionSpecApiSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>APIReference references an API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApis
{
    /// <summary>Name of the API.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ApplicationReference references an Application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecApplications
{
    /// <summary>
    /// AppID is the public identifier of the application.
    /// In the case of OIDC, it corresponds to the clientId.
    /// </summary>
    [JsonPropertyName("appId")]
    public required string AppId { get; set; }
}

/// <summary>ManagedApplicationReference references a ManagedApplication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecManagedApplications
{
    /// <summary>Name is the name of the ManagedApplication.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// OperationFilter specifies the allowed operations on APIs and APIVersions.
/// If not set, all operations are available.
/// An empty OperationFilter prohibits all operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpecOperationFilter
{
    /// <summary>Include defines the names of OperationSets that will be accessible.</summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

/// <summary>The desired behavior of this ManagedSubscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionSpec
{
    /// <summary>
    /// APIBundles defines a set of APIBundle that will be accessible.
    /// Multiple ManagedSubscriptions can select the same APIBundles.
    /// </summary>
    [JsonPropertyName("apiBundles")]
    public IList<V1alpha1ManagedSubscriptionSpecApiBundles>? ApiBundles { get; set; }

    /// <summary>APIPlan defines which APIPlan will be used.</summary>
    [JsonPropertyName("apiPlan")]
    public required V1alpha1ManagedSubscriptionSpecApiPlan ApiPlan { get; set; }

    /// <summary>
    /// APISelector selects the APIs that will be accessible.
    /// Multiple ManagedSubscriptions can select the same set of APIs.
    /// This field is optional and follows standard label selector semantics.
    /// An empty APISelector matches any API.
    /// </summary>
    [JsonPropertyName("apiSelector")]
    public V1alpha1ManagedSubscriptionSpecApiSelector? ApiSelector { get; set; }

    /// <summary>
    /// APIs defines a set of APIs that will be accessible.
    /// Multiple ManagedSubscriptions can select the same APIs.
    /// When combined with APISelector, this set of APIs is appended to the matching APIs.
    /// </summary>
    [JsonPropertyName("apis")]
    public IList<V1alpha1ManagedSubscriptionSpecApis>? Apis { get; set; }

    /// <summary>
    /// Applications references the Applications that will gain access to the specified APIs.
    /// Multiple ManagedSubscriptions can select the same AppID.
    /// 
    /// Deprecated: Use ManagedApplications instead.
    /// </summary>
    [JsonPropertyName("applications")]
    public IList<V1alpha1ManagedSubscriptionSpecApplications>? Applications { get; set; }

    /// <summary>Claims specifies an expression that validate claims in order to authorize the request.</summary>
    [JsonPropertyName("claims")]
    public string? Claims { get; set; }

    /// <summary>
    /// ManagedApplications references the ManagedApplications that will gain access to the specified APIs.
    /// Multiple ManagedSubscriptions can select the same ManagedApplication.
    /// </summary>
    [JsonPropertyName("managedApplications")]
    public IList<V1alpha1ManagedSubscriptionSpecManagedApplications>? ManagedApplications { get; set; }

    /// <summary>
    /// OperationFilter specifies the allowed operations on APIs and APIVersions.
    /// If not set, all operations are available.
    /// An empty OperationFilter prohibits all operations.
    /// </summary>
    [JsonPropertyName("operationFilter")]
    public V1alpha1ManagedSubscriptionSpecOperationFilter? OperationFilter { get; set; }

    /// <summary>
    /// Weight specifies the evaluation order of the APIPlan.
    /// When multiple ManagedSubscriptions targets the same API and Application with different APIPlan,
    /// the APIPlan with the highest weight will be enforced. If weights are equal, alphabetical order is used.
    /// </summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ManagedSubscriptionStatusConditionsStatusEnum>))]
public enum V1alpha1ManagedSubscriptionStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1alpha1ManagedSubscriptionStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ResolvedAPIReference references a resolved API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionStatusResolvedApis
{
    /// <summary>Name of the API.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ResolvedAPIReference references a resolved API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionStatusUnresolvedApis
{
    /// <summary>Name of the API.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>The current status of this ManagedSubscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ManagedSubscriptionStatus
{
    /// <summary>Conditions is the list of status conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ManagedSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>Hash is a hash representing the ManagedSubscription.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>ResolvedAPIs is the list of APIs that were successfully resolved.</summary>
    [JsonPropertyName("resolvedApis")]
    public IList<V1alpha1ManagedSubscriptionStatusResolvedApis>? ResolvedApis { get; set; }

    [JsonPropertyName("syncedAt")]
    public DateTime? SyncedAt { get; set; }

    /// <summary>UnresolvedAPIs is the list of APIs that could not be resolved.</summary>
    [JsonPropertyName("unresolvedApis")]
    public IList<V1alpha1ManagedSubscriptionStatusUnresolvedApis>? UnresolvedApis { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// ManagedSubscription defines a Subscription managed by the API manager as the result of a pre-negotiation with its
/// API consumers. This subscription grant consuming access to a set of APIs to a set of Applications.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ManagedSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ManagedSubscriptionSpec?>, IStatus<V1alpha1ManagedSubscriptionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ManagedSubscription";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "managedsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedSubscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this ManagedSubscription.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ManagedSubscriptionSpec? Spec { get; set; }

    /// <summary>The current status of this ManagedSubscription.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ManagedSubscriptionStatus? Status { get; set; }
}