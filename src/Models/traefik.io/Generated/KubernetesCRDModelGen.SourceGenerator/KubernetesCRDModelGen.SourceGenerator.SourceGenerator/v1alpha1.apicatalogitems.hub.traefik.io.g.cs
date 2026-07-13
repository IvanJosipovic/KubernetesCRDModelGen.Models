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
/// <summary>APICatalogItem defines APIs that will be part of the API catalog on the portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APICatalogItemList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APICatalogItem>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APICatalogItemList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apicatalogitems";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APICatalogItemList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APICatalogItem objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APICatalogItem> Items { get; set; }
}

/// <summary>APIBundleReference references an APIBundle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpecApiBundles
{
    /// <summary>Name of the APIBundle.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// APIPlan defines which APIPlan will be available.
/// If multiple APICatalogItem specify the same API with different APIPlan, the API consumer will be able to pick
/// a plan from this list.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpecApiPlan
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
public partial class V1alpha1APICatalogItemSpecApiSelectorMatchExpressions
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
/// APISelector selects the APIs that will be visible to the configured audience.
/// Multiple APICatalogItem can select the same set of APIs.
/// This field is optional and follows standard label selector semantics.
/// An empty APISelector matches any API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpecApiSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha1APICatalogItemSpecApiSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1alpha1APICatalogItemSpecApis
{
    /// <summary>Name of the API.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// OperationFilter specifies the visible operations on APIs and APIVersions.
/// If not set, all operations are available.
/// An empty OperationFilter prohibits all operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpecOperationFilter
{
    /// <summary>Include defines the names of OperationSets that will be accessible.</summary>
    [JsonPropertyName("include")]
    public IList<string>? Include { get; set; }
}

/// <summary>The desired behavior of this APICatalogItem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemSpec
{
    /// <summary>
    /// APIBundles defines a set of APIBundle that will be visible to the configured audience.
    /// Multiple APICatalogItem can select the same APIBundles.
    /// </summary>
    [JsonPropertyName("apiBundles")]
    public IList<V1alpha1APICatalogItemSpecApiBundles>? ApiBundles { get; set; }

    /// <summary>
    /// APIPlan defines which APIPlan will be available.
    /// If multiple APICatalogItem specify the same API with different APIPlan, the API consumer will be able to pick
    /// a plan from this list.
    /// </summary>
    [JsonPropertyName("apiPlan")]
    public V1alpha1APICatalogItemSpecApiPlan? ApiPlan { get; set; }

    /// <summary>
    /// APISelector selects the APIs that will be visible to the configured audience.
    /// Multiple APICatalogItem can select the same set of APIs.
    /// This field is optional and follows standard label selector semantics.
    /// An empty APISelector matches any API.
    /// </summary>
    [JsonPropertyName("apiSelector")]
    public V1alpha1APICatalogItemSpecApiSelector? ApiSelector { get; set; }

    /// <summary>
    /// APIs defines a set of APIs that will be visible to the configured audience.
    /// Multiple APICatalogItem can select the same APIs.
    /// When combined with APISelector, this set of APIs is appended to the matching APIs.
    /// </summary>
    [JsonPropertyName("apis")]
    public IList<V1alpha1APICatalogItemSpecApis>? Apis { get; set; }

    /// <summary>Everyone indicates that all users will see these APIs.</summary>
    [JsonPropertyName("everyone")]
    public bool? Everyone { get; set; }

    /// <summary>Groups are the consumer groups that will see the APIs.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>
    /// OperationFilter specifies the visible operations on APIs and APIVersions.
    /// If not set, all operations are available.
    /// An empty OperationFilter prohibits all operations.
    /// </summary>
    [JsonPropertyName("operationFilter")]
    public V1alpha1APICatalogItemSpecOperationFilter? OperationFilter { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1APICatalogItemStatusConditionsStatusEnum>))]
public enum V1alpha1APICatalogItemStatusConditionsStatusEnum
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
public partial class V1alpha1APICatalogItemStatusConditions
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
    public required V1alpha1APICatalogItemStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ResolvedAPIReference references a resolved API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemStatusResolvedApis
{
    /// <summary>Name of the API.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ResolvedAPIReference references a resolved API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemStatusUnresolvedApis
{
    /// <summary>Name of the API.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>The current status of this APICatalogItem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APICatalogItemStatus
{
    /// <summary>Conditions is the list of status conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APICatalogItemStatusConditions>? Conditions { get; set; }

    /// <summary>Hash is a hash representing the APICatalogItem.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>ResolvedAPIs is the list of APIs that were successfully resolved.</summary>
    [JsonPropertyName("resolvedApis")]
    public IList<V1alpha1APICatalogItemStatusResolvedApis>? ResolvedApis { get; set; }

    [JsonPropertyName("syncedAt")]
    public DateTime? SyncedAt { get; set; }

    /// <summary>UnresolvedAPIs is the list of APIs that could not be resolved.</summary>
    [JsonPropertyName("unresolvedApis")]
    public IList<V1alpha1APICatalogItemStatusUnresolvedApis>? UnresolvedApis { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>APICatalogItem defines APIs that will be part of the API catalog on the portal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APICatalogItem : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APICatalogItemSpec?>, IStatus<V1alpha1APICatalogItemStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APICatalogItem";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apicatalogitems";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APICatalogItem";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APICatalogItem.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APICatalogItemSpec? Spec { get; set; }

    /// <summary>The current status of this APICatalogItem.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APICatalogItemStatus? Status { get; set; }
}