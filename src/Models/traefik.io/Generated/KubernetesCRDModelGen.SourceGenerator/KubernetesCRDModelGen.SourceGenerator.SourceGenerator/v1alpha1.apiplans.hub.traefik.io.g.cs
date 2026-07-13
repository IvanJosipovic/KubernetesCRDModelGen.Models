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
/// <summary>APIPlan defines API Plan policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIPlanList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIPlan>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIPlanList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiplans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIPlanList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APIPlan objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APIPlan> Items { get; set; }
}

/// <summary>Bucket defines the bucket strategy for the quota.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1APIPlanSpecQuotaBucketEnum>))]
public enum V1alpha1APIPlanSpecQuotaBucketEnum
{
    [EnumMember(Value = "subscription"), JsonStringEnumMemberName("subscription")]
    Subscription,
    [EnumMember(Value = "application-api"), JsonStringEnumMemberName("application-api")]
    ApplicationApi,
    [EnumMember(Value = "application"), JsonStringEnumMemberName("application")]
    Application
}

/// <summary>Quota defines the quota policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPlanSpecQuota
{
    /// <summary>Bucket defines the bucket strategy for the quota.</summary>
    [JsonPropertyName("bucket")]
    public V1alpha1APIPlanSpecQuotaBucketEnum? Bucket { get; set; }

    /// <summary>Limit is the maximum number of requests per sliding Period.</summary>
    [JsonPropertyName("limit")]
    public required int Limit { get; set; }

    /// <summary>Period is the unit of time for the Limit.</summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary>Bucket defines the bucket strategy for the rate limit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1APIPlanSpecRateLimitBucketEnum>))]
public enum V1alpha1APIPlanSpecRateLimitBucketEnum
{
    [EnumMember(Value = "subscription"), JsonStringEnumMemberName("subscription")]
    Subscription,
    [EnumMember(Value = "application-api"), JsonStringEnumMemberName("application-api")]
    ApplicationApi,
    [EnumMember(Value = "application"), JsonStringEnumMemberName("application")]
    Application
}

/// <summary>RateLimit defines the rate limit policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPlanSpecRateLimit
{
    /// <summary>Bucket defines the bucket strategy for the rate limit.</summary>
    [JsonPropertyName("bucket")]
    public V1alpha1APIPlanSpecRateLimitBucketEnum? Bucket { get; set; }

    /// <summary>
    /// Limit is the number of requests per Period used to calculate the regeneration rate.
    /// Traffic will converge to this rate over time by delaying requests when possible, and dropping them when throttling alone is not enough.
    /// </summary>
    [JsonPropertyName("limit")]
    public required int Limit { get; set; }

    /// <summary>
    /// Period is the time unit used to express the rate.
    /// Combined with Limit, it defines the rate at which request capacity regenerates (Limit ÷ Period).
    /// </summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary>The desired behavior of this APIPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPlanSpec
{
    /// <summary>Description describes the plan.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Quota defines the quota policy.</summary>
    [JsonPropertyName("quota")]
    public V1alpha1APIPlanSpecQuota? Quota { get; set; }

    /// <summary>RateLimit defines the rate limit policy.</summary>
    [JsonPropertyName("rateLimit")]
    public V1alpha1APIPlanSpecRateLimit? RateLimit { get; set; }

    /// <summary>Title is the human-readable name of the plan.</summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1APIPlanStatusConditionsStatusEnum>))]
public enum V1alpha1APIPlanStatusConditionsStatusEnum
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
public partial class V1alpha1APIPlanStatusConditions
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
    public required V1alpha1APIPlanStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>The current status of this APIPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPlanStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIPlanStatusConditions>? Conditions { get; set; }

    /// <summary>Hash is a hash representing the APIPlan.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    [JsonPropertyName("syncedAt")]
    public DateTime? SyncedAt { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>APIPlan defines API Plan policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIPlan : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIPlanSpec?>, IStatus<V1alpha1APIPlanStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIPlan";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiplans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIPlan";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIPlan.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIPlanSpec? Spec { get; set; }

    /// <summary>The current status of this APIPlan.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIPlanStatus? Status { get; set; }
}