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
/// <summary>Shard is where Longhorn stores Shard object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ShardList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Shard>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ShardList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "shards";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ShardList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Shard objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Shard> Items { get; set; }
}

/// <summary>ShardSpec defines the desired state of the Longhorn Shard</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ShardSpec
{
    /// <summary>DiskPath is the path of the disk that hosts the shard lvol.</summary>
    [JsonPropertyName("diskPath")]
    public string? DiskPath { get; set; }

    /// <summary>DiskUUID is the UUID of the disk that hosts the shard lvol.</summary>
    [JsonPropertyName("diskUUID")]
    public string? DiskUUID { get; set; }

    /// <summary>
    /// EvictionRequested indicates this shard should be relocated to a different node or disk.
    /// Set by the node controller when the shard&apos;s node is being drained or its disk is evicted.
    /// </summary>
    [JsonPropertyName("evictionRequested")]
    public bool? EvictionRequested { get; set; }

    /// <summary>NodeID is the node where this shard&apos;s lvol resides and its NVMe-oF target runs.</summary>
    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }

    /// <summary>ShardGroupName is the name of the owning ShardGroup CR. Immutable after creation.</summary>
    [JsonPropertyName("shardGroupName")]
    public string? ShardGroupName { get; set; }

    /// <summary>
    /// Size is the shard lvol size in bytes. Set by the ShardGroup controller at creation time
    /// and used for idempotent reconciliation.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>
    /// SlotIndex is the zero-based position of this shard in the EC base-bdev array.
    /// Determines the shard&apos;s role: indices 0..k-1 are DATA, k..k+m-1 are PARITY.
    /// Immutable after creation.
    /// </summary>
    [JsonPropertyName("slotIndex")]
    public int? SlotIndex { get; set; }
}

/// <summary>ShardStatus defines the observed state of the Longhorn Shard</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ShardStatus
{
    /// <summary>LastFailureTimestamp is the RFC3339 timestamp of the most recent shard failure.</summary>
    [JsonPropertyName("lastFailureTimestamp")]
    public string? LastFailureTimestamp { get; set; }

    /// <summary>OwnerID is the ID of the node that owns this Shard.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>Port is the NVMe-oF port of the shard&apos;s target export.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>RebuildProgress is the rebuild completion percentage (0-100).</summary>
    [JsonPropertyName("rebuildProgress")]
    public int? RebuildProgress { get; set; }

    /// <summary>
    /// ReplaceTriggered is set to true after shard replacement has been initiated, to prevent
    /// re-issuing the replace command on subsequent cycles while SPDK advances the slot state.
    /// Cleared when the slot state transitions away from Failed.
    /// </summary>
    [JsonPropertyName("replaceTriggered")]
    public bool? ReplaceTriggered { get; set; }

    /// <summary>
    /// Role is the EC role of this slot (data or parity). Derived from SlotIndex and the parent
    /// ShardGroup&apos;s DataChunks; stored here for informational purposes only.
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>State is the health state of this EC shard slot.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// StorageIP is the IP address of the NVMe-oF target exported by the shard&apos;s InstanceManager.
    /// Populated after the shard instance is running.
    /// </summary>
    [JsonPropertyName("storageIP")]
    public string? StorageIP { get; set; }
}

/// <summary>Shard is where Longhorn stores Shard object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Shard : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ShardSpec?>, IStatus<V1beta2ShardStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Shard";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "shards";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Shard";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ShardSpec defines the desired state of the Longhorn Shard</summary>
    [JsonPropertyName("spec")]
    public V1beta2ShardSpec? Spec { get; set; }

    /// <summary>ShardStatus defines the observed state of the Longhorn Shard</summary>
    [JsonPropertyName("status")]
    public V1beta2ShardStatus? Status { get; set; }
}