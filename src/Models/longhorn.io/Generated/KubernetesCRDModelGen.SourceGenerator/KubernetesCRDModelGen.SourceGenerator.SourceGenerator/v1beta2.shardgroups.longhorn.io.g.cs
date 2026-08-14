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
/// <summary>ShardGroup is where Longhorn stores ShardGroup object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ShardGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ShardGroup>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ShardGroupList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "shardgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ShardGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ShardGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ShardGroup> Items { get; set; }
}

/// <summary>ShardGroupSpec defines the desired state of the Longhorn ShardGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ShardGroupSpec
{
    /// <summary>
    /// CreationSize is the volume size in bytes when the lvstore is first
    /// created. The lvstore metadata region is sized from it and never grows,
    /// so in-place expansion is limited to EcLvstoreMaxGrowthFactor (10x) of
    /// this size. Zero means the lvstore does not exist yet; the creation cap
    /// applies instead. Immutable once set.
    /// </summary>
    [JsonPropertyName("creationSize")]
    public long? CreationSize { get; set; }

    /// <summary>DataChunks is the k parameter of the EC array. Immutable after creation.</summary>
    [JsonPropertyName("dataChunks")]
    public int? DataChunks { get; set; }

    /// <summary>
    /// NodeID identifies the node hosting the long-lived ShardGroup process that owns the
    /// EC volume&apos;s bdev_ec, lvol store, head lvol, and NVMe-oF export. It is typically equal
    /// to Engine.Spec.NodeID for engine-process co-location. The Volume controller is the
    /// sole writer and sets this field at first attach. NodeID is NOT cleared on volume
    /// detach (the ShardGroup process keeps running across detach to preserve the lvstore
    /// and head lvol on the encoded shard blocks for fast re-attach); it only changes on
    /// engine-node failover or volume deletion.
    /// </summary>
    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }

    /// <summary>
    /// ParityChunks is the m parameter of the EC array. The ShardGroup tolerates up to m
    /// simultaneous shard failures. Immutable after creation.
    /// </summary>
    [JsonPropertyName("parityChunks")]
    public int? ParityChunks { get; set; }

    /// <summary>
    /// StripSizeKB is the EC chunk size in KiB. Must be a power of two in the range [4, 1024].
    /// Immutable after creation.
    /// </summary>
    [JsonPropertyName("stripSizeKB")]
    public int? StripSizeKB { get; set; }

    /// <summary>VolumeName is the name of the owning Volume CR. Immutable after creation.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ShardGroupStatusConditions
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

/// <summary>ShardGroupStatus defines the observed state of the Longhorn ShardGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ShardGroupStatus
{
    /// <summary>
    /// Conditions holds the latest observations of the ShardGroup&apos;s state, such as a
    /// degraded read that returned EIO.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ShardGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ECShardAddressMap maps shard slot index (as string) to the NVMe-oF address (&quot;ip:port&quot;)
    /// of each healthy shard instance (ShardStateNormal with a non-empty StorageIP and Port).
    /// It is the base-bdev list for the ShardGroup process&apos;s EC array, and acts as the readiness
    /// gate (together with every Shard CR being in ShardStateNormal) before the ShardGroup
    /// process is provisioned.
    /// </summary>
    [JsonPropertyName("ecShardAddressMap")]
    public IDictionary<string, string>? EcShardAddressMap { get; set; }

    /// <summary>
    /// EvictingSlots is the ordered list of slot indices currently in the eviction
    /// pipeline (old Shard CR deleted, replacement not yet rebuilt). Tracked in
    /// status so VolumeEvictionController can observe progress without annotation parsing.
    /// </summary>
    [JsonPropertyName("evictingSlots")]
    public IList<int>? EvictingSlots { get; set; }

    /// <summary>
    /// FailedCount is the number of slots currently in the failed state. Slots being replaced
    /// (ShardStateReplacing) are not counted; an active rebuild is tracked separately via
    /// RebuildInProgress.
    /// </summary>
    [JsonPropertyName("failedCount")]
    public int? FailedCount { get; set; }

    /// <summary>GrowInProgress indicates whether a capacity expansion is currently running.</summary>
    [JsonPropertyName("growInProgress")]
    public bool? GrowInProgress { get; set; }

    /// <summary>
    /// HeadLvolUUID is the UUID of the head lvol on the ShardGroup-process-owned lvol
    /// store. Surfaced for observability and debugging only.
    /// </summary>
    [JsonPropertyName("headLvolUUID")]
    public string? HeadLvolUUID { get; set; }

    /// <summary>
    /// InstanceManagerName is the InstanceManager currently hosting the ShardGroup process,
    /// set during provisioning and cleared on teardown. During a re-bind to a new node it may
    /// still reference the previous InstanceManager until teardown completes, so consumers must
    /// validate it against Spec.NodeID before trusting the endpoint above.
    /// </summary>
    [JsonPropertyName("instanceManagerName")]
    public string? InstanceManagerName { get; set; }

    /// <summary>
    /// IntentionalDeleteSlots is the list of slot indices whose old Shard CR was
    /// deleted intentionally (admin kubectl delete, eviction, drain). The replacement
    /// Shard CR&apos;s failure-recovery debounce is bypassed for these slots so the
    /// replace+rebuild sequence runs immediately rather than after the full
    /// replica-replenishment-wait-interval. Cleared once the replacement reaches
    /// ShardStateNormal with StorageIP set, and defensively cleared on ShardGroup
    /// process re-bind.
    /// </summary>
    [JsonPropertyName("intentionalDeleteSlots")]
    public IList<int>? IntentionalDeleteSlots { get; set; }

    /// <summary>
    /// LvstoreUUID is reserved for the UUID of the lvol store created on bdev_ec inside the
    /// ShardGroup process. It is currently unpopulated: the ShardGroup instance does not surface
    /// the lvstore UUID over the instance-manager proto yet. Kept for forward-compatible
    /// observability; not on the engine data path.
    /// </summary>
    [JsonPropertyName("lvstoreUUID")]
    public string? LvstoreUUID { get; set; }

    /// <summary>NQN is the NVMe-oF subsystem NQN of the ShardGroup process&apos;s exposed head lvol.</summary>
    [JsonPropertyName("nqn")]
    public string? Nqn { get; set; }

    /// <summary>OwnerID is the ID of the node that owns this ShardGroup.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>Port is the NVMe-oF port allocated for the ShardGroup process&apos;s exposed head lvol.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>ProcessState is the runtime state of the ShardGroup process owned by this CR.</summary>
    [JsonPropertyName("processState")]
    public string? ProcessState { get; set; }

    /// <summary>RebuildInProgress indicates whether a background shard rebuild is currently running.</summary>
    [JsonPropertyName("rebuildInProgress")]
    public bool? RebuildInProgress { get; set; }

    /// <summary>ScrubInProgress indicates whether a background scrub is currently running.</summary>
    [JsonPropertyName("scrubInProgress")]
    public bool? ScrubInProgress { get; set; }

    /// <summary>ShardRefs is an ordered list of Shard CR names, where the list index equals the EC slot index.</summary>
    [JsonPropertyName("shardRefs")]
    public IList<string>? ShardRefs { get; set; }

    /// <summary>State is the aggregate health state of the EC array.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// StorageIP is the storage-network IP of the InstanceManager pod hosting the ShardGroup
    /// process. Combined with Port and NQN, it forms the NVMe-oF endpoint that an EC volume&apos;s
    /// engine attaches to.
    /// </summary>
    [JsonPropertyName("storageIP")]
    public string? StorageIP { get; set; }

    /// <summary>WIBDirtyRegion is the number of dirty WIB regions reported by the EC bdev.</summary>
    [JsonPropertyName("wibDirtyRegion")]
    public int? WibDirtyRegion { get; set; }
}

/// <summary>ShardGroup is where Longhorn stores ShardGroup object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ShardGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ShardGroupSpec?>, IStatus<V1beta2ShardGroupStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ShardGroup";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "shardgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ShardGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ShardGroupSpec defines the desired state of the Longhorn ShardGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta2ShardGroupSpec? Spec { get; set; }

    /// <summary>ShardGroupStatus defines the observed state of the Longhorn ShardGroup</summary>
    [JsonPropertyName("status")]
    public V1beta2ShardGroupStatus? Status { get; set; }
}