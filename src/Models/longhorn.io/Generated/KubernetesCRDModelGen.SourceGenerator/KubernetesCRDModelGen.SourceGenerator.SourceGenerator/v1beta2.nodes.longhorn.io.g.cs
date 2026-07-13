#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.longhorn.io;
/// <summary>Node is where Longhorn stores Longhorn node object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2NodeList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Node>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "NodeList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "nodes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NodeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Node objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Node> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodeSpecDisksDiskTypeEnum>))]
public enum V1beta2NodeSpecDisksDiskTypeEnum
{
    [EnumMember(Value = "filesystem"), JsonStringEnumMemberName("filesystem")]
    Filesystem,
    [EnumMember(Value = "block"), JsonStringEnumMemberName("block")]
    Block
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodeSpecDisks
{
    [JsonPropertyName("allowScheduling")]
    public bool? AllowScheduling { get; set; }

    [JsonPropertyName("diskDriver")]
    public string? DiskDriver { get; set; }

    [JsonPropertyName("diskType")]
    public V1beta2NodeSpecDisksDiskTypeEnum? DiskType { get; set; }

    [JsonPropertyName("evictionRequested")]
    public bool? EvictionRequested { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("storageReserved")]
    public long? StorageReserved { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>NodeSpec defines the desired state of the Longhorn node</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodeSpec
{
    [JsonPropertyName("allowScheduling")]
    public bool? AllowScheduling { get; set; }

    [JsonPropertyName("disks")]
    public IDictionary<string, V1beta2NodeSpecDisks>? Disks { get; set; }

    [JsonPropertyName("evictionRequested")]
    public bool? EvictionRequested { get; set; }

    [JsonPropertyName("instanceManagerCPURequest")]
    public int? InstanceManagerCPURequest { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodeStatusConditions
{
    /// <summary>Last time we probed the condition.</summary>
    [JsonPropertyName("lastProbeTime")]
    public string? LastProbeTime { get; set; }

    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>
    /// Status is the status of the condition.
    /// Can be True, False, Unknown.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodeStatusDiskStatusConditions
{
    /// <summary>Last time we probed the condition.</summary>
    [JsonPropertyName("lastProbeTime")]
    public string? LastProbeTime { get; set; }

    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>
    /// Status is the status of the condition.
    /// Can be True, False, Unknown.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodeStatusDiskStatusHealthDataAttributes
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("rawString")]
    public string? RawString { get; set; }

    [JsonPropertyName("rawValue")]
    public long? RawValue { get; set; }

    [JsonPropertyName("threshold")]
    public int? Threshold { get; set; }

    [JsonPropertyName("value")]
    public int? Value { get; set; }

    [JsonPropertyName("whenFailed")]
    public string? WhenFailed { get; set; }

    [JsonPropertyName("worst")]
    public int? Worst { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodeStatusDiskStatusHealthDataHealthStatusEnum>))]
public enum V1beta2NodeStatusDiskStatusHealthDataHealthStatusEnum
{
    [EnumMember(Value = "FAILED"), JsonStringEnumMemberName("FAILED")]
    FAILED,
    [EnumMember(Value = "PASSED"), JsonStringEnumMemberName("PASSED")]
    PASSED,
    [EnumMember(Value = "UNKNOWN"), JsonStringEnumMemberName("UNKNOWN")]
    UNKNOWN,
    [EnumMember(Value = "WARNING"), JsonStringEnumMemberName("WARNING")]
    WARNING
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2NodeStatusDiskStatusHealthDataSourceEnum>))]
public enum V1beta2NodeStatusDiskStatusHealthDataSourceEnum
{
    [EnumMember(Value = "SMART"), JsonStringEnumMemberName("SMART")]
    SMART,
    [EnumMember(Value = "SPDK"), JsonStringEnumMemberName("SPDK")]
    SPDK
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodeStatusDiskStatusHealthData
{
    [JsonPropertyName("attributes")]
    public IList<V1beta2NodeStatusDiskStatusHealthDataAttributes>? Attributes { get; set; }

    [JsonPropertyName("capacity")]
    public long? Capacity { get; set; }

    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("firmwareVersion")]
    public string? FirmwareVersion { get; set; }

    [JsonPropertyName("healthStatus")]
    public V1beta2NodeStatusDiskStatusHealthDataHealthStatusEnum? HealthStatus { get; set; }

    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    [JsonPropertyName("source")]
    public V1beta2NodeStatusDiskStatusHealthDataSourceEnum? Source { get; set; }

    [JsonPropertyName("temperature")]
    public int? Temperature { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodeStatusDiskStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1beta2NodeStatusDiskStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("diskDriver")]
    public string? DiskDriver { get; set; }

    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    [JsonPropertyName("diskPath")]
    public string? DiskPath { get; set; }

    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    [JsonPropertyName("diskUUID")]
    public string? DiskUUID { get; set; }

    [JsonPropertyName("filesystemType")]
    public string? FilesystemType { get; set; }

    [JsonPropertyName("healthData")]
    public IDictionary<string, V1beta2NodeStatusDiskStatusHealthData>? HealthData { get; set; }

    [JsonPropertyName("healthDataLastCollectedAt")]
    public DateTime? HealthDataLastCollectedAt { get; set; }

    [JsonPropertyName("instanceManagerName")]
    public string? InstanceManagerName { get; set; }

    [JsonPropertyName("scheduledBackingImage")]
    public IDictionary<string, long>? ScheduledBackingImage { get; set; }

    [JsonPropertyName("scheduledReplica")]
    public IDictionary<string, long>? ScheduledReplica { get; set; }

    [JsonPropertyName("storageAvailable")]
    public long? StorageAvailable { get; set; }

    [JsonPropertyName("storageMaximum")]
    public long? StorageMaximum { get; set; }

    [JsonPropertyName("storageScheduled")]
    public long? StorageScheduled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodeStatusSnapshotCheckStatus
{
    [JsonPropertyName("lastPeriodicCheckedAt")]
    public DateTime? LastPeriodicCheckedAt { get; set; }
}

/// <summary>NodeStatus defines the observed state of the Longhorn node</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2NodeStatus
{
    [JsonPropertyName("autoEvicting")]
    public bool? AutoEvicting { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1beta2NodeStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("diskStatus")]
    public IDictionary<string, V1beta2NodeStatusDiskStatus>? DiskStatus { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("snapshotCheckStatus")]
    public V1beta2NodeStatusSnapshotCheckStatus? SnapshotCheckStatus { get; set; }

    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>Node is where Longhorn stores Longhorn node object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Node : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2NodeSpec?>, IStatus<V1beta2NodeStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Node";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "nodes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Node";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NodeSpec defines the desired state of the Longhorn node</summary>
    [JsonPropertyName("spec")]
    public V1beta2NodeSpec? Spec { get; set; }

    /// <summary>NodeStatus defines the observed state of the Longhorn node</summary>
    [JsonPropertyName("status")]
    public V1beta2NodeStatus? Status { get; set; }
}