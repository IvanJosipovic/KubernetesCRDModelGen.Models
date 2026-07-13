#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafka.strimzi.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaTopicList : IKubernetesObject<V1ListMeta>, IItems<V1KafkaTopic>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaTopicList";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkatopics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaTopicList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1KafkaTopic objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1KafkaTopic> Items { get; set; }
}

/// <summary>The specification of the topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaTopicSpec
{
    /// <summary>The name of the topic. When absent this will default to the metadata.name of the topic. It is recommended to not set this unless the topic name is not a valid Kubernetes resource name.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }

    /// <summary>The number of partitions the topic should have. This cannot be decreased after topic creation. It can be increased after topic creation, but it is important to understand the consequences that has, especially for topics with semantic partitioning. When absent this will default to the broker configuration for `num.partitions`.</summary>
    [JsonPropertyName("partitions")]
    public int? Partitions { get; set; }

    /// <summary>The number of replicas the topic should have. When absent this will default to the broker configuration for `default.replication.factor`.</summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary>The topic configuration.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaTopicStatusConditions
{
    /// <summary>The unique identifier of a condition, used to distinguish between other conditions in the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The status of the condition, either True, False or Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Last time the condition of a type changed from one status to another. The required format is &apos;yyyy-MM-ddTHH:mm:ssZ&apos;, in the UTC time zone.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>The reason for the condition&apos;s last transition (a single word in CamelCase).</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Human-readable message indicating details about the condition&apos;s last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>Current state of the replicas change operation. This can be `pending`, when the change has been requested, or `ongoing`, when the change has been successfully submitted to Cruise Control.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaTopicStatusReplicasChangeStateEnum>))]
public enum V1KafkaTopicStatusReplicasChangeStateEnum
{
    [EnumMember(Value = "pending"), JsonStringEnumMemberName("pending")]
    Pending,
    [EnumMember(Value = "ongoing"), JsonStringEnumMemberName("ongoing")]
    Ongoing
}

/// <summary>Replication factor change status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaTopicStatusReplicasChange
{
    /// <summary>The target replicas value requested by the user. This may be different from .spec.replicas when a change is ongoing.</summary>
    [JsonPropertyName("targetReplicas")]
    public int? TargetReplicas { get; set; }

    /// <summary>Current state of the replicas change operation. This can be `pending`, when the change has been requested, or `ongoing`, when the change has been successfully submitted to Cruise Control.</summary>
    [JsonPropertyName("state")]
    public V1KafkaTopicStatusReplicasChangeStateEnum? State { get; set; }

    /// <summary>Message for the user related to the replicas change request. This may contain transient error messages that would disappear on periodic reconciliations.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The session identifier for replicas change requests pertaining to this KafkaTopic resource. This is used by the Topic Operator to track the status of `ongoing` replicas change operations.</summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }
}

/// <summary>The status of the topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaTopicStatus
{
    /// <summary>List of status conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1KafkaTopicStatusConditions>? Conditions { get; set; }

    /// <summary>The generation of the CRD that was last reconciled by the operator.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Topic name.</summary>
    [JsonPropertyName("topicName")]
    public string? TopicName { get; set; }

    /// <summary>The topic&apos;s id. For a KafkaTopic with the ready condition, this will change only if the topic gets deleted and recreated with the same name.</summary>
    [JsonPropertyName("topicId")]
    public string? TopicId { get; set; }

    /// <summary>Replication factor change status.</summary>
    [JsonPropertyName("replicasChange")]
    public V1KafkaTopicStatusReplicasChange? ReplicasChange { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaTopic : IKubernetesObject<V1ObjectMeta>, ISpec<V1KafkaTopicSpec>, IStatus<V1KafkaTopicStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaTopic";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkatopics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaTopic";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The specification of the topic.</summary>
    [JsonPropertyName("spec")]
    public required V1KafkaTopicSpec Spec { get; set; }

    /// <summary>The status of the topic.</summary>
    [JsonPropertyName("status")]
    public V1KafkaTopicStatus? Status { get; set; }
}