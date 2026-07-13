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
/// <summary>Orphan is where Longhorn stores orphan object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2OrphanList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Orphan>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "OrphanList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "orphans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "OrphanList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Orphan objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Orphan> Items { get; set; }
}

/// <summary>
/// The type of data engine for instance orphan.
/// Can be &quot;v1&quot;, &quot;v2&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2OrphanSpecDataEngineEnum>))]
public enum V1beta2OrphanSpecDataEngineEnum
{
    [EnumMember(Value = "v1"), JsonStringEnumMemberName("v1")]
    V1,
    [EnumMember(Value = "v2"), JsonStringEnumMemberName("v2")]
    V2
}

/// <summary>OrphanSpec defines the desired state of the Longhorn orphaned data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrphanSpec
{
    /// <summary>
    /// The type of data engine for instance orphan.
    /// Can be &quot;v1&quot;, &quot;v2&quot;.
    /// </summary>
    [JsonPropertyName("dataEngine")]
    public V1beta2OrphanSpecDataEngineEnum? DataEngine { get; set; }

    /// <summary>The node ID on which the controller is responsible to reconcile this orphan CR.</summary>
    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }

    /// <summary>
    /// The type of the orphaned data.
    /// Can be &quot;replica&quot;.
    /// </summary>
    [JsonPropertyName("orphanType")]
    public string? OrphanType { get; set; }

    /// <summary>The parameters of the orphaned data</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrphanStatusConditions
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

/// <summary>OrphanStatus defines the observed state of the Longhorn orphaned data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2OrphanStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1beta2OrphanStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }
}

/// <summary>Orphan is where Longhorn stores orphan object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Orphan : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2OrphanSpec?>, IStatus<V1beta2OrphanStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Orphan";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "orphans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Orphan";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OrphanSpec defines the desired state of the Longhorn orphaned data</summary>
    [JsonPropertyName("spec")]
    public V1beta2OrphanSpec? Spec { get; set; }

    /// <summary>OrphanStatus defines the observed state of the Longhorn orphaned data</summary>
    [JsonPropertyName("status")]
    public V1beta2OrphanStatus? Status { get; set; }
}