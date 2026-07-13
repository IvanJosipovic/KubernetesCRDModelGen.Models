#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.cnrm.cloud.google.com;
/// <summary>StorageAnywhereCache is the Schema for the StorageAnywhereCache API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageAnywhereCacheList : IKubernetesObject<V1ListMeta>, IItems<V1beta1StorageAnywhereCache>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageAnywhereCacheList";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storageanywherecaches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAnywhereCacheList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1StorageAnywhereCache objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1StorageAnywhereCache> Items { get; set; }
}

/// <summary>Cache admission policy. Valid values include: `admit-on-first-miss` and `admit-on-second-miss`. Defaults to `admit-on-first-miss`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StorageAnywhereCacheSpecAdmissionPolicyEnum>))]
public enum V1beta1StorageAnywhereCacheSpecAdmissionPolicyEnum
{
    [EnumMember(Value = "admit-on-first-miss"), JsonStringEnumMemberName("admit-on-first-miss")]
    AdmitOnFirstMiss,
    [EnumMember(Value = "admit-on-second-miss"), JsonStringEnumMemberName("admit-on-second-miss")]
    AdmitOnSecondMiss
}

/// <summary>Immutable. The reference to bucket where cache needs to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageAnywhereCacheSpecBucketRef
{
    /// <summary>A reference to an externally-managed StorageBucket resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a StorageBucket resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a StorageBucket resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The desired state of the cache. Possible values include &quot;running&quot;, &quot;disabled&quot;, and &quot;paused&quot;. If not specified, the default value is &quot;running&quot;. This field controls the runtime behavior of the cache. Please note that changes to the `desiredState` are prioritized over any other updates. For instance, if both the `desiredState` and `ttl` are updated simultaneously, the state would be updated first, followed by `ttl`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1StorageAnywhereCacheSpecDesiredStateEnum>))]
public enum V1beta1StorageAnywhereCacheSpecDesiredStateEnum
{
    [EnumMember(Value = "running"), JsonStringEnumMemberName("running")]
    Running,
    [EnumMember(Value = "paused"), JsonStringEnumMemberName("paused")]
    Paused,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled
}

/// <summary>StorageAnywhereCacheSpec defines the desired state of StorageAnywhereCache</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageAnywhereCacheSpec
{
    /// <summary>Cache admission policy. Valid values include: `admit-on-first-miss` and `admit-on-second-miss`. Defaults to `admit-on-first-miss`.</summary>
    [JsonPropertyName("admissionPolicy")]
    public V1beta1StorageAnywhereCacheSpecAdmissionPolicyEnum? AdmissionPolicy { get; set; }

    /// <summary>Immutable. The reference to bucket where cache needs to be created.</summary>
    [JsonPropertyName("bucketRef")]
    public required V1beta1StorageAnywhereCacheSpecBucketRef BucketRef { get; set; }

    /// <summary>The desired state of the cache. Possible values include &quot;running&quot;, &quot;disabled&quot;, and &quot;paused&quot;. If not specified, the default value is &quot;running&quot;. This field controls the runtime behavior of the cache. Please note that changes to the `desiredState` are prioritized over any other updates. For instance, if both the `desiredState` and `ttl` are updated simultaneously, the state would be updated first, followed by `ttl`.</summary>
    [JsonPropertyName("desiredState")]
    public V1beta1StorageAnywhereCacheSpecDesiredStateEnum? DesiredState { get; set; }

    /// <summary>The AnywhereCacheID generated via backend. It can be used by users to manage an existing cache.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Cache entry TTL (ranges between 1h to 7d). This is a cache-level config that defines how long a cache entry can live. Defaults to &quot;86400s&quot;. TTL must be in whole seconds.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>Immutable. The zone in which the cache instance needs to be created. For example, us-central1-a.</summary>
    [JsonPropertyName("zone")]
    public required string Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageAnywhereCacheStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageAnywhereCacheStatusObservedState
{
    /// <summary>Output only. Time when Anywhere cache instance is allocated.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. True if there is an active update operation against this cache instance. Subsequential update requests will be rejected if this field is true. Output only.</summary>
    [JsonPropertyName("pendingUpdate")]
    public bool? PendingUpdate { get; set; }

    /// <summary>Output only. Cache state including &quot;running&quot;, &quot;creating&quot;, &quot;disabled&quot; and &quot;paused&quot;.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Time when Anywhere cache instance is last updated, including creation.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>StorageAnywhereCacheStatus defines the config connector machine state of StorageAnywhereCache</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageAnywhereCacheStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StorageAnywhereCacheStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the StorageAnywhereCache resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1StorageAnywhereCacheStatusObservedState? ObservedState { get; set; }
}

/// <summary>StorageAnywhereCache is the Schema for the StorageAnywhereCache API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageAnywhereCache : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StorageAnywhereCacheSpec>, IStatus<V1beta1StorageAnywhereCacheStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageAnywhereCache";
    public const string KubeGroup = "storage.cnrm.cloud.google.com";
    public const string KubePluralName = "storageanywherecaches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAnywhereCache";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StorageAnywhereCacheSpec defines the desired state of StorageAnywhereCache</summary>
    [JsonPropertyName("spec")]
    public required V1beta1StorageAnywhereCacheSpec Spec { get; set; }

    /// <summary>StorageAnywhereCacheStatus defines the config connector machine state of StorageAnywhereCache</summary>
    [JsonPropertyName("status")]
    public V1beta1StorageAnywhereCacheStatus? Status { get; set; }
}