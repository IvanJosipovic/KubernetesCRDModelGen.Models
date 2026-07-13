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
    [JsonPropertyName("alternateOwnerAttrs")]
    public IDictionary<string, string>? AlternateOwnerAttrs { get; set; }

    [JsonPropertyName("handle_id")]
    public string? HandleId { get; set; }

    [JsonPropertyName("secondary")]
    public IDictionary<string, string>? Secondary { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1IPAMBlockSpec
{
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    [JsonPropertyName("affinityClaimTime")]
    public DateTime? AffinityClaimTime { get; set; }

    [JsonPropertyName("allocations")]
    public required IList<int> Allocations { get; set; }

    [JsonPropertyName("attributes")]
    public required IList<V1IPAMBlockSpecAttributes> Attributes { get; set; }

    [JsonPropertyName("cidr")]
    public required string Cidr { get; set; }

    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    [JsonPropertyName("sequenceNumber")]
    public long? SequenceNumber { get; set; }

    [JsonPropertyName("sequenceNumberForAllocation")]
    public IDictionary<string, long>? SequenceNumberForAllocation { get; set; }

    [JsonPropertyName("strictAffinity")]
    public required bool StrictAffinity { get; set; }

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

    [JsonPropertyName("spec")]
    public V1IPAMBlockSpec? Spec { get; set; }
}