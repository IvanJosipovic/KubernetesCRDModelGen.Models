#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pubsublite.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PubSubLiteTopicList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1PubSubLiteTopic>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PubSubLiteTopicList";
    public const string KubeGroup = "pubsublite.cnrm.cloud.google.com";
    public const string KubePluralName = "pubsublitetopics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pubsublite.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PubSubLiteTopicList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1PubSubLiteTopic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1PubSubLiteTopic> Items { get; set; }
}

/// <summary>The capacity configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubLiteTopicSpecPartitionConfigCapacity
{
    /// <summary>Subscribe throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("publishMibPerSec")]
    public required int PublishMibPerSec { get; set; }

    /// <summary>Publish throughput capacity per partition in MiB/s. Must be &gt;= 4 and &lt;= 16.</summary>
    [JsonPropertyName("subscribeMibPerSec")]
    public required int SubscribeMibPerSec { get; set; }
}

/// <summary>The settings for this topic&apos;s partitions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubLiteTopicSpecPartitionConfig
{
    /// <summary>The capacity configuration.</summary>
    [JsonPropertyName("capacity")]
    public V1alpha1PubSubLiteTopicSpecPartitionConfigCapacity? Capacity { get; set; }

    /// <summary>The number of partitions in the topic. Must be at least 1.</summary>
    [JsonPropertyName("count")]
    public required int Count { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubLiteTopicSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The settings for this topic&apos;s Reservation usage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubLiteTopicSpecReservationConfig
{
    /// <summary>The Reservation to use for this topic&apos;s throughput capacity.</summary>
    [JsonPropertyName("throughputReservation")]
    public string? ThroughputReservation { get; set; }
}

/// <summary>The settings for a topic&apos;s message retention.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubLiteTopicSpecRetentionConfig
{
    /// <summary>
    /// The provisioned storage, in bytes, per partition. If the number of bytes stored
    /// in any of the topic&apos;s partitions grows beyond this value, older messages will be
    /// dropped to make room for newer ones, regardless of the value of period.
    /// </summary>
    [JsonPropertyName("perPartitionBytes")]
    public required string PerPartitionBytes { get; set; }

    /// <summary>
    /// How long a published message is retained. If unset, messages will be retained as
    /// long as the bytes retained for each partition is below perPartitionBytes. A
    /// duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;.
    /// Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubLiteTopicSpec
{
    /// <summary>The settings for this topic&apos;s partitions.</summary>
    [JsonPropertyName("partitionConfig")]
    public V1alpha1PubSubLiteTopicSpecPartitionConfig? PartitionConfig { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1PubSubLiteTopicSpecProjectRef ProjectRef { get; set; }

    /// <summary>The region of the pubsub lite topic.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The settings for this topic&apos;s Reservation usage.</summary>
    [JsonPropertyName("reservationConfig")]
    public V1alpha1PubSubLiteTopicSpecReservationConfig? ReservationConfig { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The settings for a topic&apos;s message retention.</summary>
    [JsonPropertyName("retentionConfig")]
    public V1alpha1PubSubLiteTopicSpecRetentionConfig? RetentionConfig { get; set; }

    /// <summary>The zone of the pubsub lite topic.</summary>
    [JsonPropertyName("zone")]
    public required string Zone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubLiteTopicStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1PubSubLiteTopicStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1PubSubLiteTopicStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1PubSubLiteTopic : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1PubSubLiteTopicSpec>, IStatus<V1alpha1PubSubLiteTopicStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "PubSubLiteTopic";
    public const string KubeGroup = "pubsublite.cnrm.cloud.google.com";
    public const string KubePluralName = "pubsublitetopics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pubsublite.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PubSubLiteTopic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1PubSubLiteTopicSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1PubSubLiteTopicStatus? Status { get; set; }
}