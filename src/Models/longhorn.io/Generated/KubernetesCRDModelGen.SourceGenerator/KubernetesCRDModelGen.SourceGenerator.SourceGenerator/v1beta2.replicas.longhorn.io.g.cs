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
/// <summary>Replica is where Longhorn stores replica object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ReplicaList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Replica>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ReplicaList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "replicas";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReplicaList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Replica objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Replica> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ReplicaSpecDataEngineEnum>))]
public enum V1beta2ReplicaSpecDataEngineEnum
{
    [EnumMember(Value = "v1"), JsonStringEnumMemberName("v1")]
    V1,
    [EnumMember(Value = "v2"), JsonStringEnumMemberName("v2")]
    V2
}

/// <summary>ReplicaSpec defines the desired state of the Longhorn replica</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReplicaSpec
{
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    [JsonPropertyName("backingImage")]
    public string? BackingImage { get; set; }

    [JsonPropertyName("dataDirectoryName")]
    public string? DataDirectoryName { get; set; }

    [JsonPropertyName("dataEngine")]
    public V1beta2ReplicaSpecDataEngineEnum? DataEngine { get; set; }

    [JsonPropertyName("desireState")]
    public string? DesireState { get; set; }

    [JsonPropertyName("diskID")]
    public string? DiskID { get; set; }

    [JsonPropertyName("diskPath")]
    public string? DiskPath { get; set; }

    [JsonPropertyName("engineName")]
    public string? EngineName { get; set; }

    [JsonPropertyName("evictionRequested")]
    public bool? EvictionRequested { get; set; }

    /// <summary>
    /// FailedAt is set when a running replica fails or when a running engine is unable to use a replica for any reason.
    /// FailedAt indicates the time the failure occurred. When FailedAt is set, a replica is likely to have useful
    /// (though possibly stale) data. A replica with FailedAt set must be rebuilt from a non-failed replica (or it can
    /// be used in a salvage if all replicas are failed). FailedAt is cleared before a rebuild or salvage. FailedAt may
    /// be later than the corresponding entry in an engine&apos;s replicaTransitionTimeMap because it is set when the volume
    /// controller acknowledges the change.
    /// </summary>
    [JsonPropertyName("failedAt")]
    public string? FailedAt { get; set; }

    [JsonPropertyName("hardNodeAffinity")]
    public string? HardNodeAffinity { get; set; }

    /// <summary>
    /// HealthyAt is set the first time a replica becomes read/write in an engine after creation or rebuild. HealthyAt
    /// indicates the time the last successful rebuild occurred. When HealthyAt is set, a replica is likely to have
    /// useful (though possibly stale) data. HealthyAt is cleared before a rebuild. HealthyAt may be later than the
    /// corresponding entry in an engine&apos;s replicaTransitionTimeMap because it is set when the volume controller
    /// acknowledges the change.
    /// </summary>
    [JsonPropertyName("healthyAt")]
    public string? HealthyAt { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// LastFailedAt is always set at the same time as FailedAt. Unlike FailedAt, LastFailedAt is never cleared.
    /// LastFailedAt is not a reliable indicator of the state of a replica&apos;s data. For example, a replica with
    /// LastFailedAt may already be healthy and in use again. However, because it is never cleared, it can be compared to
    /// LastHealthyAt to help prevent dangerous replica deletion in some corner cases. LastFailedAt may be later than the
    /// corresponding entry in an engine&apos;s replicaTransitionTimeMap because it is set when the volume controller
    /// acknowledges the change.
    /// </summary>
    [JsonPropertyName("lastFailedAt")]
    public string? LastFailedAt { get; set; }

    /// <summary>
    /// LastHealthyAt is set every time a replica becomes read/write in an engine. Unlike HealthyAt, LastHealthyAt is
    /// never cleared. LastHealthyAt is not a reliable indicator of the state of a replica&apos;s data. For example, a
    /// replica with LastHealthyAt set may be in the middle of a rebuild. However, because it is never cleared, it can be
    /// compared to LastFailedAt to help prevent dangerous replica deletion in some corner cases. LastHealthyAt may be
    /// later than the corresponding entry in an engine&apos;s replicaTransitionTimeMap because it is set when the volume
    /// controller acknowledges the change.
    /// </summary>
    [JsonPropertyName("lastHealthyAt")]
    public string? LastHealthyAt { get; set; }

    [JsonPropertyName("logRequested")]
    public bool? LogRequested { get; set; }

    /// <summary>
    /// MigrationEngineName is indicating the migrating engine which current connected to this replica. This is only
    /// used for live migration of v2 data engine
    /// </summary>
    [JsonPropertyName("migrationEngineName")]
    public string? MigrationEngineName { get; set; }

    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }

    [JsonPropertyName("rebuildRetryCount")]
    public int? RebuildRetryCount { get; set; }

    [JsonPropertyName("revisionCounterDisabled")]
    public bool? RevisionCounterDisabled { get; set; }

    [JsonPropertyName("salvageRequested")]
    public bool? SalvageRequested { get; set; }

    [JsonPropertyName("snapshotMaxCount")]
    public int? SnapshotMaxCount { get; set; }

    [JsonPropertyName("snapshotMaxSize")]
    public string? SnapshotMaxSize { get; set; }

    [JsonPropertyName("unmapMarkDiskChainRemovedEnabled")]
    public bool? UnmapMarkDiskChainRemovedEnabled { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }

    [JsonPropertyName("volumeSize")]
    public string? VolumeSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReplicaStatusConditions
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

/// <summary>ReplicaStatus defines the observed state of the Longhorn replica</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ReplicaStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1beta2ReplicaStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("currentImage")]
    public string? CurrentImage { get; set; }

    [JsonPropertyName("currentState")]
    public string? CurrentState { get; set; }

    [JsonPropertyName("instanceManagerName")]
    public string? InstanceManagerName { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("logFetched")]
    public bool? LogFetched { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("salvageExecuted")]
    public bool? SalvageExecuted { get; set; }

    [JsonPropertyName("started")]
    public bool? Started { get; set; }

    [JsonPropertyName("starting")]
    public bool? Starting { get; set; }

    [JsonPropertyName("storageIP")]
    public string? StorageIP { get; set; }

    [JsonPropertyName("ublkID")]
    public int? UblkID { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

/// <summary>Replica is where Longhorn stores replica object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Replica : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ReplicaSpec?>, IStatus<V1beta2ReplicaStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Replica";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "replicas";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Replica";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ReplicaSpec defines the desired state of the Longhorn replica</summary>
    [JsonPropertyName("spec")]
    public V1beta2ReplicaSpec? Spec { get; set; }

    /// <summary>ReplicaStatus defines the observed state of the Longhorn replica</summary>
    [JsonPropertyName("status")]
    public V1beta2ReplicaStatus? Status { get; set; }
}