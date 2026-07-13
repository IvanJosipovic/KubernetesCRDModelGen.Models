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
/// <summary>Engine is where Longhorn stores engine object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EngineList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Engine>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EngineList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "engines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EngineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Engine objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Engine> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EngineSpecDataEngineEnum>))]
public enum V1beta2EngineSpecDataEngineEnum
{
    [EnumMember(Value = "v1"), JsonStringEnumMemberName("v1")]
    V1,
    [EnumMember(Value = "v2"), JsonStringEnumMemberName("v2")]
    V2
}

/// <summary>EngineSpec defines the desired state of the Longhorn engine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineSpec
{
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    [JsonPropertyName("backupVolume")]
    public string? BackupVolume { get; set; }

    [JsonPropertyName("dataEngine")]
    public V1beta2EngineSpecDataEngineEnum? DataEngine { get; set; }

    [JsonPropertyName("desireState")]
    public string? DesireState { get; set; }

    [JsonPropertyName("disableFrontend")]
    public bool? DisableFrontend { get; set; }

    [JsonPropertyName("frontend")]
    public string? Frontend { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("logRequested")]
    public bool? LogRequested { get; set; }

    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }

    /// <summary>
    /// RebuildConcurrentSyncLimit controls the maximum number of file synchronization operations that can run
    /// concurrently during a single replica rebuild.
    /// It is determined by the global setting or the volume spec field with the same name.
    /// </summary>
    [JsonPropertyName("rebuildConcurrentSyncLimit")]
    public int? RebuildConcurrentSyncLimit { get; set; }

    [JsonPropertyName("replicaAddressMap")]
    public IDictionary<string, string>? ReplicaAddressMap { get; set; }

    [JsonPropertyName("requestedBackupRestore")]
    public string? RequestedBackupRestore { get; set; }

    [JsonPropertyName("requestedDataSource")]
    public string? RequestedDataSource { get; set; }

    [JsonPropertyName("revisionCounterDisabled")]
    public bool? RevisionCounterDisabled { get; set; }

    [JsonPropertyName("salvageRequested")]
    public bool? SalvageRequested { get; set; }

    [JsonPropertyName("snapshotMaxCount")]
    public int? SnapshotMaxCount { get; set; }

    [JsonPropertyName("snapshotMaxSize")]
    public string? SnapshotMaxSize { get; set; }

    /// <summary>ublkNumberOfQueue controls the number of queues for ublk frontend.</summary>
    [JsonPropertyName("ublkNumberOfQueue")]
    public int? UblkNumberOfQueue { get; set; }

    /// <summary>ublkQueueDepth controls the depth of each queue for ublk frontend.</summary>
    [JsonPropertyName("ublkQueueDepth")]
    public int? UblkQueueDepth { get; set; }

    [JsonPropertyName("unmapMarkSnapChainRemovedEnabled")]
    public bool? UnmapMarkSnapChainRemovedEnabled { get; set; }

    [JsonPropertyName("upgradedReplicaAddressMap")]
    public IDictionary<string, string>? UpgradedReplicaAddressMap { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }

    [JsonPropertyName("volumeSize")]
    public string? VolumeSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineStatusBackupStatus
{
    [JsonPropertyName("backupURL")]
    public string? BackupURL { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("replicaAddress")]
    public string? ReplicaAddress { get; set; }

    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineStatusCloneStatus
{
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("fromReplicaAddress")]
    public string? FromReplicaAddress { get; set; }

    [JsonPropertyName("isCloning")]
    public bool? IsCloning { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineStatusConditions
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
public partial class V1beta2EngineStatusPurgeStatus
{
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("isPurging")]
    public bool? IsPurging { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineStatusRebuildStatus
{
    [JsonPropertyName("appliedRebuildingMBps")]
    public long? AppliedRebuildingMBps { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>Deprecated. We are now using FromReplicaAddressList to list all source replicas.</summary>
    [JsonPropertyName("fromReplicaAddress")]
    public string? FromReplicaAddress { get; set; }

    [JsonPropertyName("fromReplicaAddressList")]
    public IList<string>? FromReplicaAddressList { get; set; }

    [JsonPropertyName("isRebuilding")]
    public bool? IsRebuilding { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineStatusRestoreStatus
{
    [JsonPropertyName("backupURL")]
    public string? BackupURL { get; set; }

    [JsonPropertyName("currentRestoringBackup")]
    public string? CurrentRestoringBackup { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    [JsonPropertyName("isRestoring")]
    public bool? IsRestoring { get; set; }

    [JsonPropertyName("lastRestored")]
    public string? LastRestored { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineStatusSnapshots
{
    [JsonPropertyName("children")]
    public IDictionary<string, bool>? Children { get; set; }

    [JsonPropertyName("created")]
    public string? Created { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    [JsonPropertyName("removed")]
    public bool? Removed { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("usercreated")]
    public bool? Usercreated { get; set; }
}

/// <summary>EngineStatus defines the observed state of the Longhorn engine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineStatus
{
    [JsonPropertyName("backupStatus")]
    public IDictionary<string, V1beta2EngineStatusBackupStatus>? BackupStatus { get; set; }

    [JsonPropertyName("cloneStatus")]
    public IDictionary<string, V1beta2EngineStatusCloneStatus>? CloneStatus { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1beta2EngineStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("currentImage")]
    public string? CurrentImage { get; set; }

    [JsonPropertyName("currentReplicaAddressMap")]
    public IDictionary<string, string>? CurrentReplicaAddressMap { get; set; }

    [JsonPropertyName("currentSize")]
    public string? CurrentSize { get; set; }

    [JsonPropertyName("currentState")]
    public string? CurrentState { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("instanceManagerName")]
    public string? InstanceManagerName { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("isExpanding")]
    public bool? IsExpanding { get; set; }

    [JsonPropertyName("lastExpansionError")]
    public string? LastExpansionError { get; set; }

    [JsonPropertyName("lastExpansionFailedAt")]
    public string? LastExpansionFailedAt { get; set; }

    [JsonPropertyName("lastRestoredBackup")]
    public string? LastRestoredBackup { get; set; }

    [JsonPropertyName("logFetched")]
    public bool? LogFetched { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("purgeStatus")]
    public IDictionary<string, V1beta2EngineStatusPurgeStatus>? PurgeStatus { get; set; }

    /// <summary>
    /// RebuildConcurrentSyncLimit controls the maximum number of file synchronization operations that can run
    /// concurrently during a single replica rebuild.
    /// It is determined by the global setting or the volume spec field with the same name.
    /// </summary>
    [JsonPropertyName("rebuildConcurrentSyncLimit")]
    public int? RebuildConcurrentSyncLimit { get; set; }

    [JsonPropertyName("rebuildStatus")]
    public IDictionary<string, V1beta2EngineStatusRebuildStatus>? RebuildStatus { get; set; }

    [JsonPropertyName("replicaModeMap")]
    public IDictionary<string, string>? ReplicaModeMap { get; set; }

    /// <summary>
    /// ReplicaTransitionTimeMap records the time a replica in ReplicaModeMap transitions from one mode to another (or
    /// from not being in the ReplicaModeMap to being in it). This information is sometimes required by other controllers
    /// (e.g. the volume controller uses it to determine the correct value for replica.Spec.lastHealthyAt).
    /// </summary>
    [JsonPropertyName("replicaTransitionTimeMap")]
    public IDictionary<string, string>? ReplicaTransitionTimeMap { get; set; }

    [JsonPropertyName("restoreStatus")]
    public IDictionary<string, V1beta2EngineStatusRestoreStatus>? RestoreStatus { get; set; }

    [JsonPropertyName("salvageExecuted")]
    public bool? SalvageExecuted { get; set; }

    [JsonPropertyName("snapshotMaxCount")]
    public int? SnapshotMaxCount { get; set; }

    [JsonPropertyName("snapshotMaxSize")]
    public string? SnapshotMaxSize { get; set; }

    [JsonPropertyName("snapshots")]
    public IDictionary<string, V1beta2EngineStatusSnapshots>? Snapshots { get; set; }

    [JsonPropertyName("snapshotsError")]
    public string? SnapshotsError { get; set; }

    [JsonPropertyName("started")]
    public bool? Started { get; set; }

    [JsonPropertyName("starting")]
    public bool? Starting { get; set; }

    [JsonPropertyName("storageIP")]
    public string? StorageIP { get; set; }

    [JsonPropertyName("ublkID")]
    public int? UblkID { get; set; }

    [JsonPropertyName("unmapMarkSnapChainRemovedEnabled")]
    public bool? UnmapMarkSnapChainRemovedEnabled { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

/// <summary>Engine is where Longhorn stores engine object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Engine : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2EngineSpec?>, IStatus<V1beta2EngineStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Engine";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "engines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Engine";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EngineSpec defines the desired state of the Longhorn engine</summary>
    [JsonPropertyName("spec")]
    public V1beta2EngineSpec? Spec { get; set; }

    /// <summary>EngineStatus defines the observed state of the Longhorn engine</summary>
    [JsonPropertyName("status")]
    public V1beta2EngineStatus? Status { get; set; }
}