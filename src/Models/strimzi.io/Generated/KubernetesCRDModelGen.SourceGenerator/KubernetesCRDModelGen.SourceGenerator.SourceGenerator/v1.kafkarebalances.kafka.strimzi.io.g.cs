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
public partial class V1KafkaRebalanceList : IKubernetesObject<V1ListMeta>, IItems<V1KafkaRebalance>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaRebalanceList";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkarebalances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaRebalanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1KafkaRebalance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1KafkaRebalance> Items { get; set; }
}

/// <summary>
/// Mode to run the rebalancing. The supported modes are `full`, `add-brokers`, `remove-brokers`.
/// If not specified, the `full` mode is used by default. 
/// 
/// * `full` mode runs the rebalancing across all the brokers in the cluster.
/// * `add-brokers` mode can be used after scaling up the cluster to move some replicas to the newly added brokers.
/// * `remove-brokers` mode can be used before scaling down the cluster to move replicas out of the brokers to be removed.
/// * `remove-disks` mode can be used to move data across the volumes within the same broker
/// .
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaRebalanceSpecModeEnum>))]
public enum V1KafkaRebalanceSpecModeEnum
{
    [EnumMember(Value = "full"), JsonStringEnumMemberName("full")]
    Full,
    [EnumMember(Value = "add-brokers"), JsonStringEnumMemberName("add-brokers")]
    AddBrokers,
    [EnumMember(Value = "remove-brokers"), JsonStringEnumMemberName("remove-brokers")]
    RemoveBrokers,
    [EnumMember(Value = "remove-disks"), JsonStringEnumMemberName("remove-disks")]
    RemoveDisks
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaRebalanceSpecMoveReplicasOffVolumes
{
    /// <summary>ID of the broker that contains the disk from which you want to move the partition replicas.</summary>
    [JsonPropertyName("brokerId")]
    public int? BrokerId { get; set; }

    /// <summary>IDs of the disks from which the partition replicas need to be moved.</summary>
    [JsonPropertyName("volumeIds")]
    public IList<int>? VolumeIds { get; set; }
}

/// <summary>The specification of the Kafka rebalance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaRebalanceSpec
{
    /// <summary>
    /// Mode to run the rebalancing. The supported modes are `full`, `add-brokers`, `remove-brokers`.
    /// If not specified, the `full` mode is used by default. 
    /// 
    /// * `full` mode runs the rebalancing across all the brokers in the cluster.
    /// * `add-brokers` mode can be used after scaling up the cluster to move some replicas to the newly added brokers.
    /// * `remove-brokers` mode can be used before scaling down the cluster to move replicas out of the brokers to be removed.
    /// * `remove-disks` mode can be used to move data across the volumes within the same broker
    /// .
    /// </summary>
    [JsonPropertyName("mode")]
    public V1KafkaRebalanceSpecModeEnum? Mode { get; set; }

    /// <summary>The list of newly added brokers in case of scaling up or the ones to be removed in case of scaling down to use for rebalancing. This list can be used only with rebalancing mode `add-brokers` and `removed-brokers`. It is ignored with `full` mode.</summary>
    [JsonPropertyName("brokers")]
    public IList<int>? Brokers { get; set; }

    /// <summary>A list of goals, ordered by decreasing priority, to use for generating and executing the rebalance proposal. The supported goals are available at https://github.com/linkedin/cruise-control#goals. If an empty goals list is provided, the goals declared in the default.goals Cruise Control configuration parameter are used.</summary>
    [JsonPropertyName("goals")]
    public IList<string>? Goals { get; set; }

    /// <summary>Whether to allow the hard goals specified in the Kafka CR to be skipped in optimization proposal generation. This can be useful when some of those hard goals are preventing a balance solution being found. Default is false.</summary>
    [JsonPropertyName("skipHardGoalCheck")]
    public bool? SkipHardGoalCheck { get; set; }

    /// <summary>Enables intra-broker disk balancing, which balances disk space utilization between disks on the same broker. Only applies to Kafka deployments that use JBOD storage with multiple disks. When enabled, inter-broker balancing is disabled. Default is false.</summary>
    [JsonPropertyName("rebalanceDisk")]
    public bool? RebalanceDisk { get; set; }

    /// <summary>A regular expression where any matching topics will be excluded from the calculation of optimization proposals. This expression will be parsed by the java.util.regex.Pattern class; for more information on the supported format consult the documentation for that class.</summary>
    [JsonPropertyName("excludedTopics")]
    public string? ExcludedTopics { get; set; }

    /// <summary>The upper bound of ongoing partition replica movements going into/out of each broker. Default is 5.</summary>
    [JsonPropertyName("concurrentPartitionMovementsPerBroker")]
    public int? ConcurrentPartitionMovementsPerBroker { get; set; }

    /// <summary>The upper bound of ongoing partition replica movements between disks within each broker. Default is 2.</summary>
    [JsonPropertyName("concurrentIntraBrokerPartitionMovements")]
    public int? ConcurrentIntraBrokerPartitionMovements { get; set; }

    /// <summary>The upper bound of ongoing partition leadership movements. Default is 1000.</summary>
    [JsonPropertyName("concurrentLeaderMovements")]
    public int? ConcurrentLeaderMovements { get; set; }

    /// <summary>The upper bound, in bytes per second, on the bandwidth used to move replicas. There is no limit by default.</summary>
    [JsonPropertyName("replicationThrottle")]
    public int? ReplicationThrottle { get; set; }

    /// <summary>A list of strategy class names used to determine the execution order for the replica movements in the generated optimization proposal. By default BaseReplicaMovementStrategy is used, which will execute the replica movements in the order that they were generated.</summary>
    [JsonPropertyName("replicaMovementStrategies")]
    public IList<string>? ReplicaMovementStrategies { get; set; }

    /// <summary>List of brokers and their corresponding volumes from which replicas need to be moved.</summary>
    [JsonPropertyName("moveReplicasOffVolumes")]
    public IList<V1KafkaRebalanceSpecMoveReplicasOffVolumes>? MoveReplicasOffVolumes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaRebalanceStatusConditions
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

/// <summary>A reference to Config Map with the progress information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaRebalanceStatusProgress
{
    /// <summary>The name of the `ConfigMap` containing information related to the progress of a partition rebalance.</summary>
    [JsonPropertyName("rebalanceProgressConfigMap")]
    public string? RebalanceProgressConfigMap { get; set; }
}

/// <summary>The status of the Kafka rebalance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaRebalanceStatus
{
    /// <summary>List of status conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1KafkaRebalanceStatusConditions>? Conditions { get; set; }

    /// <summary>The generation of the CRD that was last reconciled by the operator.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The session identifier for requests to Cruise Control pertaining to this KafkaRebalance resource. This is used by the Kafka Rebalance operator to track the status of ongoing rebalancing operations.</summary>
    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; }

    /// <summary>A reference to Config Map with the progress information.</summary>
    [JsonPropertyName("progress")]
    public V1KafkaRebalanceStatusProgress? Progress { get; set; }

    /// <summary>A JSON object describing the optimization result.</summary>
    [JsonPropertyName("optimizationResult")]
    public JsonNode? OptimizationResult { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaRebalance : IKubernetesObject<V1ObjectMeta>, ISpec<V1KafkaRebalanceSpec>, IStatus<V1KafkaRebalanceStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaRebalance";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkarebalances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaRebalance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The specification of the Kafka rebalance.</summary>
    [JsonPropertyName("spec")]
    public required V1KafkaRebalanceSpec Spec { get; set; }

    /// <summary>The status of the Kafka rebalance.</summary>
    [JsonPropertyName("status")]
    public V1KafkaRebalanceStatus? Status { get; set; }
}