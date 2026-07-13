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
public partial class V1KafkaConnectorList : IKubernetesObject<V1ListMeta>, IItems<V1KafkaConnector>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaConnectorList";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkaconnectors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaConnectorList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1KafkaConnector objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1KafkaConnector> Items { get; set; }
}

/// <summary>Automatic restart of connector and tasks configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectorSpecAutoRestart
{
    /// <summary>Whether automatic restart for failed connectors and tasks should be enabled or disabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The maximum number of connector restarts that the operator will try. If the connector remains in a failed state after reaching this limit, it must be restarted manually by the user. Defaults to an unlimited number of restarts.</summary>
    [JsonPropertyName("maxRestarts")]
    public int? MaxRestarts { get; set; }
}

/// <summary>The state the connector should be in. Defaults to running.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectorSpecStateEnum>))]
public enum V1KafkaConnectorSpecStateEnum
{
    [EnumMember(Value = "paused"), JsonStringEnumMemberName("paused")]
    Paused,
    [EnumMember(Value = "stopped"), JsonStringEnumMemberName("stopped")]
    Stopped,
    [EnumMember(Value = "running"), JsonStringEnumMemberName("running")]
    Running
}

/// <summary>Reference to the ConfigMap where the list of offsets will be written to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectorSpecListOffsetsToConfigMap
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration for listing offsets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectorSpecListOffsets
{
    /// <summary>Reference to the ConfigMap where the list of offsets will be written to.</summary>
    [JsonPropertyName("toConfigMap")]
    public required V1KafkaConnectorSpecListOffsetsToConfigMap ToConfigMap { get; set; }
}

/// <summary>Reference to the ConfigMap where the new offsets are stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectorSpecAlterOffsetsFromConfigMap
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration for altering offsets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectorSpecAlterOffsets
{
    /// <summary>Reference to the ConfigMap where the new offsets are stored.</summary>
    [JsonPropertyName("fromConfigMap")]
    public required V1KafkaConnectorSpecAlterOffsetsFromConfigMap FromConfigMap { get; set; }
}

/// <summary>The specification of the Kafka Connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectorSpec
{
    /// <summary>The Class for the Kafka Connector.</summary>
    [JsonPropertyName("class")]
    public string? Class { get; set; }

    /// <summary>The maximum number of tasks for the Kafka Connector.</summary>
    [JsonPropertyName("tasksMax")]
    public int? TasksMax { get; set; }

    /// <summary>Automatic restart of connector and tasks configuration.</summary>
    [JsonPropertyName("autoRestart")]
    public V1KafkaConnectorSpecAutoRestart? AutoRestart { get; set; }

    /// <summary>Desired version or version range to respect when starting the Kafka Connector. This is only supported when using Kafka Connect version 4.1.0 and higher.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The Kafka Connector configuration. The following properties cannot be set: name, connector.class, tasks.max, connector.plugin.version.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>The state the connector should be in. Defaults to running.</summary>
    [JsonPropertyName("state")]
    public V1KafkaConnectorSpecStateEnum? State { get; set; }

    /// <summary>Configuration for listing offsets.</summary>
    [JsonPropertyName("listOffsets")]
    public V1KafkaConnectorSpecListOffsets? ListOffsets { get; set; }

    /// <summary>Configuration for altering offsets.</summary>
    [JsonPropertyName("alterOffsets")]
    public V1KafkaConnectorSpecAlterOffsets? AlterOffsets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectorStatusConditions
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

/// <summary>The auto restart status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectorStatusAutoRestart
{
    /// <summary>The number of times the connector or task is restarted.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>The name of the connector being restarted.</summary>
    [JsonPropertyName("connectorName")]
    public string? ConnectorName { get; set; }

    /// <summary>The last time the automatic restart was attempted. The required format is &apos;yyyy-MM-ddTHH:mm:ssZ&apos; in the UTC time zone.</summary>
    [JsonPropertyName("lastRestartTimestamp")]
    public string? LastRestartTimestamp { get; set; }
}

/// <summary>The status of the Kafka Connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectorStatus
{
    /// <summary>List of status conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1KafkaConnectorStatusConditions>? Conditions { get; set; }

    /// <summary>The generation of the CRD that was last reconciled by the operator.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The auto restart status.</summary>
    [JsonPropertyName("autoRestart")]
    public V1KafkaConnectorStatusAutoRestart? AutoRestart { get; set; }

    /// <summary>The connector status, as reported by the Kafka Connect REST API.</summary>
    [JsonPropertyName("connectorStatus")]
    public JsonNode? ConnectorStatus { get; set; }

    /// <summary>The maximum number of tasks for the Kafka Connector.</summary>
    [JsonPropertyName("tasksMax")]
    public int? TasksMax { get; set; }

    /// <summary>The list of topics used by the Kafka Connector.</summary>
    [JsonPropertyName("topics")]
    public IList<string>? Topics { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaConnector : IKubernetesObject<V1ObjectMeta>, ISpec<V1KafkaConnectorSpec>, IStatus<V1KafkaConnectorStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaConnector";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkaconnectors";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaConnector";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The specification of the Kafka Connector.</summary>
    [JsonPropertyName("spec")]
    public required V1KafkaConnectorSpec Spec { get; set; }

    /// <summary>The status of the Kafka Connector.</summary>
    [JsonPropertyName("status")]
    public V1KafkaConnectorStatus? Status { get; set; }
}