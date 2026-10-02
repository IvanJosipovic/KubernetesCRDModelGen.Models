#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPAMBlockList : IKubernetesObject<V1ListMeta>, IItems<V1IPAMBlock>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPAMBlockList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ipamblocks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IPAMBlockList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1IPAMBlock objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1IPAMBlock> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPAMBlockSpecAttributes
{
    /// <summary>
    /// AlternateOwnerAttrs contains attributes of the previous or potential owner
    /// (used during live migration to track the source or target pod).
    /// </summary>
    [JsonPropertyName("alternateOwnerAttrs")]
    public IDictionary<string, string>? AlternateOwnerAttrs { get; set; }

    /// <summary>HandleID is the primary identifier for the allocation.</summary>
    [JsonPropertyName("handle_id")]
    public string? HandleId { get; set; }

    /// <summary>
    /// ReleasedAt is the time this allocation was released, and is set during the allocation&apos;s
    /// &quot;cooldown&quot; phase. After `IPCooldownSeconds` have elapsed, the IP is deallocated (moved
    /// from `Allocated` to `Unallocated`).
    /// </summary>
    [JsonPropertyName("releasedAt")]
    public DateTime? ReleasedAt { get; set; }

    /// <summary>ActiveOwnerAttrs contains attributes of the active owner (the pod currently using the IP).</summary>
    [JsonPropertyName("secondary")]
    public IDictionary<string, string>? Secondary { get; set; }
}

/// <summary>IPAMBlockSpec contains the specification for an IPAMBlock resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPAMBlockSpec
{
    /// <summary>
    /// Affinity of the block, if this block has one. If set, it will be of the form
    /// &quot;host:&lt;hostname&gt; &quot;. If not set, this block is not affine to a host.
    /// </summary>
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    [JsonPropertyName("affinityClaimTime")]
    public DateTime? AffinityClaimTime { get; set; }

    /// <summary>
    /// Array of allocations in-use within this block. nil entries mean the allocation is free.
    /// For non-nil entries at index i, the index is the ordinal of the allocation within this block
    /// and the value is the index of the associated attributes in the Attributes array.
    /// </summary>
    [JsonPropertyName("allocations")]
    public required IList<int> Allocations { get; set; }

    /// <summary>
    /// Attributes is an array of arbitrary metadata associated with allocations in the block. To find
    /// attributes for a given allocation, use the value of the allocation&apos;s entry in the Allocations array
    /// as the index of the element in this array.
    /// </summary>
    [JsonPropertyName("attributes")]
    public required IList<V1IPAMBlockSpecAttributes> Attributes { get; set; }

    /// <summary>The block&apos;s CIDR.</summary>
    [JsonPropertyName("cidr")]
    public required string Cidr { get; set; }

    /// <summary>
    /// Deleted is an internal boolean used to workaround a limitation in the Kubernetes API whereby
    /// deletion will not return a conflict error if the block has been updated. It should not be set manually.
    /// </summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>
    /// We store a sequence number that is updated each time the block is written.
    /// Each allocation will also store the sequence number of the block at the time of its creation.
    /// When releasing an IP, passing the sequence number associated with the allocation allows us
    /// to protect against a race condition and ensure the IP hasn&apos;t been released and re-allocated
    /// since the release request.
    /// </summary>
    [JsonPropertyName("sequenceNumber")]
    public long? SequenceNumber { get; set; }

    /// <summary>
    /// Map of allocated ordinal within the block to sequence number of the block at
    /// the time of allocation. Kubernetes does not allow numerical keys for maps, so
    /// the key is cast to a string.
    /// </summary>
    [JsonPropertyName("sequenceNumberForAllocation")]
    public IDictionary<string, long>? SequenceNumberForAllocation { get; set; }

    /// <summary>StrictAffinity on the IPAMBlock is deprecated and no longer used by the code. Use IPAMConfig StrictAffinity instead.</summary>
    [JsonPropertyName("strictAffinity")]
    public required bool StrictAffinity { get; set; }

    /// <summary>Unallocated is an ordered list of allocations which are free in the block.</summary>
    [JsonPropertyName("unallocated")]
    public required IList<int> Unallocated { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1IPAMBlock : IKubernetesObject<V1ObjectMeta>, ISpec<V1IPAMBlockSpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "IPAMBlock";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "ipamblocks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IPAMBlock";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IPAMBlockSpec contains the specification for an IPAMBlock resource.</summary>
    [JsonPropertyName("spec")]
    public V1IPAMBlockSpec? Spec { get; set; }
}