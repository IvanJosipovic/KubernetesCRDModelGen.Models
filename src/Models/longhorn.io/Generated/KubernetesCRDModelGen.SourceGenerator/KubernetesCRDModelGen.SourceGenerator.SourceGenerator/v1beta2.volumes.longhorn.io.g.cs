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
/// <summary>Volume is where Longhorn stores volume object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2VolumeList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Volume>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "VolumeList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "volumes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VolumeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Volume objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Volume> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecAccessModeEnum>))]
public enum V1beta2VolumeSpecAccessModeEnum
{
    [EnumMember(Value = "rwo"), JsonStringEnumMemberName("rwo")]
    Rwo,
    [EnumMember(Value = "rwop"), JsonStringEnumMemberName("rwop")]
    Rwop,
    [EnumMember(Value = "rwx"), JsonStringEnumMemberName("rwx")]
    Rwx
}

/// <summary>BackupBlockSize indicate the block size to create backups. The block size is immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecBackupBlockSizeEnum>))]
public enum V1beta2VolumeSpecBackupBlockSizeEnum
{
    [EnumMember(Value = "2097152"), JsonStringEnumMemberName("2097152")]
    _2097152,
    [EnumMember(Value = "16777216"), JsonStringEnumMemberName("16777216")]
    _16777216
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecBackupCompressionMethodEnum>))]
public enum V1beta2VolumeSpecBackupCompressionMethodEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    [EnumMember(Value = "lz4"), JsonStringEnumMemberName("lz4")]
    Lz4,
    [EnumMember(Value = "gzip"), JsonStringEnumMemberName("gzip")]
    Gzip
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecDataEngineEnum>))]
public enum V1beta2VolumeSpecDataEngineEnum
{
    [EnumMember(Value = "v1"), JsonStringEnumMemberName("v1")]
    V1,
    [EnumMember(Value = "v2"), JsonStringEnumMemberName("v2")]
    V2
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecDataLocalityEnum>))]
public enum V1beta2VolumeSpecDataLocalityEnum
{
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "best-effort"), JsonStringEnumMemberName("best-effort")]
    BestEffort,
    [EnumMember(Value = "strict-local"), JsonStringEnumMemberName("strict-local")]
    StrictLocal
}

/// <summary>Setting that freezes the filesystem on the root partition before a snapshot is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecFreezeFilesystemForSnapshotEnum>))]
public enum V1beta2VolumeSpecFreezeFilesystemForSnapshotEnum
{
    [EnumMember(Value = "ignored"), JsonStringEnumMemberName("ignored")]
    Ignored,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled
}

/// <summary>
/// Specifies whether Longhorn should rebuild replicas while the detached volume is degraded.
/// - ignored: Use the global setting for offline replica rebuilding.
/// - enabled: Enable offline rebuilding for this volume, regardless of the global setting.
/// - disabled: Disable offline rebuilding for this volume, regardless of the global setting
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecOfflineRebuildingEnum>))]
public enum V1beta2VolumeSpecOfflineRebuildingEnum
{
    [EnumMember(Value = "ignored"), JsonStringEnumMemberName("ignored")]
    Ignored,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecReplicaAutoBalanceEnum>))]
public enum V1beta2VolumeSpecReplicaAutoBalanceEnum
{
    [EnumMember(Value = "ignored"), JsonStringEnumMemberName("ignored")]
    Ignored,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "least-effort"), JsonStringEnumMemberName("least-effort")]
    LeastEffort,
    [EnumMember(Value = "best-effort"), JsonStringEnumMemberName("best-effort")]
    BestEffort
}

/// <summary>Replica disk soft anti affinity of the volume. Set enabled to allow replicas to be scheduled in the same disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecReplicaDiskSoftAntiAffinityEnum>))]
public enum V1beta2VolumeSpecReplicaDiskSoftAntiAffinityEnum
{
    [EnumMember(Value = "ignored"), JsonStringEnumMemberName("ignored")]
    Ignored,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled
}

/// <summary>Replica soft anti affinity of the volume. Set enabled to allow replicas to be scheduled on the same node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecReplicaSoftAntiAffinityEnum>))]
public enum V1beta2VolumeSpecReplicaSoftAntiAffinityEnum
{
    [EnumMember(Value = "ignored"), JsonStringEnumMemberName("ignored")]
    Ignored,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled
}

/// <summary>Replica zone soft anti affinity of the volume. Set enabled to allow replicas to be scheduled in the same zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecReplicaZoneSoftAntiAffinityEnum>))]
public enum V1beta2VolumeSpecReplicaZoneSoftAntiAffinityEnum
{
    [EnumMember(Value = "ignored"), JsonStringEnumMemberName("ignored")]
    Ignored,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecRestoreVolumeRecurringJobEnum>))]
public enum V1beta2VolumeSpecRestoreVolumeRecurringJobEnum
{
    [EnumMember(Value = "ignored"), JsonStringEnumMemberName("ignored")]
    Ignored,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecSnapshotDataIntegrityEnum>))]
public enum V1beta2VolumeSpecSnapshotDataIntegrityEnum
{
    [EnumMember(Value = "ignored"), JsonStringEnumMemberName("ignored")]
    Ignored,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled,
    [EnumMember(Value = "fast-check"), JsonStringEnumMemberName("fast-check")]
    FastCheck
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VolumeSpecUnmapMarkSnapChainRemovedEnum>))]
public enum V1beta2VolumeSpecUnmapMarkSnapChainRemovedEnum
{
    [EnumMember(Value = "ignored"), JsonStringEnumMemberName("ignored")]
    Ignored,
    [EnumMember(Value = "disabled"), JsonStringEnumMemberName("disabled")]
    Disabled,
    [EnumMember(Value = "enabled"), JsonStringEnumMemberName("enabled")]
    Enabled
}

/// <summary>VolumeSpec defines the desired state of the Longhorn volume</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VolumeSpec
{
    [JsonPropertyName("Standby")]
    public bool? Standby { get; set; }

    [JsonPropertyName("accessMode")]
    public V1beta2VolumeSpecAccessModeEnum? AccessMode { get; set; }

    [JsonPropertyName("backingImage")]
    public string? BackingImage { get; set; }

    /// <summary>BackupBlockSize indicate the block size to create backups. The block size is immutable.</summary>
    [JsonPropertyName("backupBlockSize")]
    public V1beta2VolumeSpecBackupBlockSizeEnum? BackupBlockSize { get; set; }

    [JsonPropertyName("backupCompressionMethod")]
    public V1beta2VolumeSpecBackupCompressionMethodEnum? BackupCompressionMethod { get; set; }

    /// <summary>The backup target name that the volume will be backed up to or is synced.</summary>
    [JsonPropertyName("backupTargetName")]
    public string? BackupTargetName { get; set; }

    [JsonPropertyName("cloneMode")]
    public string? CloneMode { get; set; }

    [JsonPropertyName("dataEngine")]
    public V1beta2VolumeSpecDataEngineEnum? DataEngine { get; set; }

    [JsonPropertyName("dataLocality")]
    public V1beta2VolumeSpecDataLocalityEnum? DataLocality { get; set; }

    [JsonPropertyName("dataSource")]
    public string? DataSource { get; set; }

    [JsonPropertyName("disableFrontend")]
    public bool? DisableFrontend { get; set; }

    [JsonPropertyName("diskSelector")]
    public IList<string>? DiskSelector { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>
    /// engineNodeID defines the node where the backend engine (target) runs.
    /// If empty, falls back to NodeID.
    /// </summary>
    [JsonPropertyName("engineNodeID")]
    public string? EngineNodeID { get; set; }

    /// <summary>Setting that freezes the filesystem on the root partition before a snapshot is created.</summary>
    [JsonPropertyName("freezeFilesystemForSnapshot")]
    public V1beta2VolumeSpecFreezeFilesystemForSnapshotEnum? FreezeFilesystemForSnapshot { get; set; }

    [JsonPropertyName("fromBackup")]
    public string? FromBackup { get; set; }

    [JsonPropertyName("frontend")]
    public string? Frontend { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("lastAttachedBy")]
    public string? LastAttachedBy { get; set; }

    [JsonPropertyName("migratable")]
    public bool? Migratable { get; set; }

    [JsonPropertyName("migrationNodeID")]
    public string? MigrationNodeID { get; set; }

    /// <summary>nodeID defines the node where the volume is attached (where the frontend initiator runs).</summary>
    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }

    [JsonPropertyName("nodeSelector")]
    public IList<string>? NodeSelector { get; set; }

    [JsonPropertyName("numberOfReplicas")]
    public int? NumberOfReplicas { get; set; }

    /// <summary>
    /// Specifies whether Longhorn should rebuild replicas while the detached volume is degraded.
    /// - ignored: Use the global setting for offline replica rebuilding.
    /// - enabled: Enable offline rebuilding for this volume, regardless of the global setting.
    /// - disabled: Disable offline rebuilding for this volume, regardless of the global setting
    /// </summary>
    [JsonPropertyName("offlineRebuilding")]
    public V1beta2VolumeSpecOfflineRebuildingEnum? OfflineRebuilding { get; set; }

    /// <summary>
    /// RebuildConcurrentSyncLimit controls the maximum number of file synchronization operations that can run
    /// concurrently during a single replica rebuild.
    /// When set to 0, it means following the global setting.
    /// </summary>
    [JsonPropertyName("rebuildConcurrentSyncLimit")]
    public int? RebuildConcurrentSyncLimit { get; set; }

    [JsonPropertyName("replicaAutoBalance")]
    public V1beta2VolumeSpecReplicaAutoBalanceEnum? ReplicaAutoBalance { get; set; }

    /// <summary>Replica disk soft anti affinity of the volume. Set enabled to allow replicas to be scheduled in the same disk.</summary>
    [JsonPropertyName("replicaDiskSoftAntiAffinity")]
    public V1beta2VolumeSpecReplicaDiskSoftAntiAffinityEnum? ReplicaDiskSoftAntiAffinity { get; set; }

    /// <summary>ReplicaRebuildingBandwidthLimit controls the maximum write bandwidth (in megabytes per second) allowed on the destination replica during the rebuilding process. Set this value to 0 to disable bandwidth limiting.</summary>
    [JsonPropertyName("replicaRebuildingBandwidthLimit")]
    public long? ReplicaRebuildingBandwidthLimit { get; set; }

    /// <summary>Replica soft anti affinity of the volume. Set enabled to allow replicas to be scheduled on the same node.</summary>
    [JsonPropertyName("replicaSoftAntiAffinity")]
    public V1beta2VolumeSpecReplicaSoftAntiAffinityEnum? ReplicaSoftAntiAffinity { get; set; }

    /// <summary>Replica zone soft anti affinity of the volume. Set enabled to allow replicas to be scheduled in the same zone.</summary>
    [JsonPropertyName("replicaZoneSoftAntiAffinity")]
    public V1beta2VolumeSpecReplicaZoneSoftAntiAffinityEnum? ReplicaZoneSoftAntiAffinity { get; set; }

    [JsonPropertyName("restoreVolumeRecurringJob")]
    public V1beta2VolumeSpecRestoreVolumeRecurringJobEnum? RestoreVolumeRecurringJob { get; set; }

    [JsonPropertyName("revisionCounterDisabled")]
    public bool? RevisionCounterDisabled { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("snapshotDataIntegrity")]
    public V1beta2VolumeSpecSnapshotDataIntegrityEnum? SnapshotDataIntegrity { get; set; }

    /// <summary>
    /// SnapshotHashingRequestedAt is the RFC3339 timestamp (e.g., &quot;2026-03-16T10:30:00Z&quot;) when an on-demand snapshot checksum calculation is requested.
    /// When this value is set and is later than LastOnDemandSnapshotHashingCompleteAt, the system will calculate checksums
    /// for all user snapshots.
    /// 
    /// If SnapshotHashingRequestedAt differs from LastOnDemandSnapshotHashingCompleteAt, it indicates that a hashing request
    /// is still in progress, and a new request will be rejected.
    /// </summary>
    [JsonPropertyName("snapshotHashingRequestedAt")]
    public string? SnapshotHashingRequestedAt { get; set; }

    [JsonPropertyName("snapshotMaxCount")]
    public int? SnapshotMaxCount { get; set; }

    [JsonPropertyName("snapshotMaxSize")]
    public string? SnapshotMaxSize { get; set; }

    [JsonPropertyName("staleReplicaTimeout")]
    public int? StaleReplicaTimeout { get; set; }

    /// <summary>ublkNumberOfQueue controls the number of queues for ublk frontend.</summary>
    [JsonPropertyName("ublkNumberOfQueue")]
    public int? UblkNumberOfQueue { get; set; }

    /// <summary>ublkQueueDepth controls the depth of each queue for ublk frontend.</summary>
    [JsonPropertyName("ublkQueueDepth")]
    public int? UblkQueueDepth { get; set; }

    [JsonPropertyName("unmapMarkSnapChainRemoved")]
    public V1beta2VolumeSpecUnmapMarkSnapChainRemovedEnum? UnmapMarkSnapChainRemoved { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VolumeStatusCloneStatus
{
    [JsonPropertyName("attemptCount")]
    public int? AttemptCount { get; set; }

    [JsonPropertyName("nextAllowedAttemptAt")]
    public string? NextAllowedAttemptAt { get; set; }

    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    [JsonPropertyName("sourceVolume")]
    public string? SourceVolume { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VolumeStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VolumeStatusKubernetesStatusWorkloadsStatus
{
    [JsonPropertyName("podName")]
    public string? PodName { get; set; }

    [JsonPropertyName("podStatus")]
    public string? PodStatus { get; set; }

    [JsonPropertyName("workloadName")]
    public string? WorkloadName { get; set; }

    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VolumeStatusKubernetesStatus
{
    [JsonPropertyName("lastPVCRefAt")]
    public string? LastPVCRefAt { get; set; }

    [JsonPropertyName("lastPodRefAt")]
    public string? LastPodRefAt { get; set; }

    /// <summary>determine if PVC/Namespace is history or not</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("pvName")]
    public string? PvName { get; set; }

    [JsonPropertyName("pvStatus")]
    public string? PvStatus { get; set; }

    [JsonPropertyName("pvcName")]
    public string? PvcName { get; set; }

    /// <summary>determine if Pod/Workload is history or not</summary>
    [JsonPropertyName("workloadsStatus")]
    public IList<V1beta2VolumeStatusKubernetesStatusWorkloadsStatus>? WorkloadsStatus { get; set; }
}

/// <summary>VolumeStatus defines the observed state of the Longhorn volume</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VolumeStatus
{
    [JsonPropertyName("actualSize")]
    public long? ActualSize { get; set; }

    [JsonPropertyName("cloneStatus")]
    public V1beta2VolumeStatusCloneStatus? CloneStatus { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1beta2VolumeStatusConditions>? Conditions { get; set; }

    /// <summary>the node that the engine (target) is currently running on.</summary>
    [JsonPropertyName("currentEngineNodeID")]
    public string? CurrentEngineNodeID { get; set; }

    [JsonPropertyName("currentImage")]
    public string? CurrentImage { get; set; }

    /// <summary>the node that this volume is currently migrating to</summary>
    [JsonPropertyName("currentMigrationNodeID")]
    public string? CurrentMigrationNodeID { get; set; }

    [JsonPropertyName("currentNodeID")]
    public string? CurrentNodeID { get; set; }

    [JsonPropertyName("expansionRequired")]
    public bool? ExpansionRequired { get; set; }

    [JsonPropertyName("frontendDisabled")]
    public bool? FrontendDisabled { get; set; }

    [JsonPropertyName("isStandby")]
    public bool? IsStandby { get; set; }

    [JsonPropertyName("kubernetesStatus")]
    public V1beta2VolumeStatusKubernetesStatus? KubernetesStatus { get; set; }

    [JsonPropertyName("lastAutoSalvagedAt")]
    public string? LastAutoSalvagedAt { get; set; }

    [JsonPropertyName("lastBackup")]
    public string? LastBackup { get; set; }

    [JsonPropertyName("lastBackupAt")]
    public string? LastBackupAt { get; set; }

    [JsonPropertyName("lastDegradedAt")]
    public string? LastDegradedAt { get; set; }

    /// <summary>
    /// LastOnDemandSnapshotHashingCompleteAt is the RFC3339 timestamp (e.g., &quot;2026-03-16T10:30:00Z&quot;) when the
    /// most recent on-demand snapshot checksum calculation completed.
    /// When this value matches SnapshotHashingRequestedAt, the requested on-demand checksum calculation is considered complete.
    /// </summary>
    [JsonPropertyName("lastOnDemandSnapshotHashingCompleteAt")]
    public string? LastOnDemandSnapshotHashingCompleteAt { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    [JsonPropertyName("remountRequestedAt")]
    public string? RemountRequestedAt { get; set; }

    [JsonPropertyName("restoreInitiated")]
    public bool? RestoreInitiated { get; set; }

    [JsonPropertyName("restoreRequired")]
    public bool? RestoreRequired { get; set; }

    [JsonPropertyName("robustness")]
    public string? Robustness { get; set; }

    [JsonPropertyName("shareEndpoint")]
    public string? ShareEndpoint { get; set; }

    [JsonPropertyName("shareState")]
    public string? ShareState { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// SwitchoverState describes the current progress of a v2 engine live switchover.
    /// Empty when no switchover is in progress.
    /// </summary>
    [JsonPropertyName("switchoverState")]
    public string? SwitchoverState { get; set; }
}

/// <summary>Volume is where Longhorn stores volume object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Volume : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2VolumeSpec?>, IStatus<V1beta2VolumeStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Volume";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "volumes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Volume";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VolumeSpec defines the desired state of the Longhorn volume</summary>
    [JsonPropertyName("spec")]
    public V1beta2VolumeSpec? Spec { get; set; }

    /// <summary>VolumeStatus defines the observed state of the Longhorn volume</summary>
    [JsonPropertyName("status")]
    public V1beta2VolumeStatus? Status { get; set; }
}