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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CalicoNodeStatusList : IKubernetesObject<V1ListMeta>, IItems<V1CalicoNodeStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CalicoNodeStatusList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "caliconodestatuses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CalicoNodeStatusList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1CalicoNodeStatus objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1CalicoNodeStatus> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusSpecClassesEnum>))]
public enum V1CalicoNodeStatusSpecClassesEnum
{
    [EnumMember(Value = "Agent"), JsonStringEnumMemberName("Agent")]
    Agent,
    [EnumMember(Value = "BGP"), JsonStringEnumMemberName("BGP")]
    BGP,
    [EnumMember(Value = "Routes"), JsonStringEnumMemberName("Routes")]
    Routes
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusSpec
{
    [JsonPropertyName("classes")]
    public IList<V1CalicoNodeStatusSpecClassesEnum>? Classes { get; set; }

    [JsonPropertyName("node")]
    public string? Node { get; set; }

    [JsonPropertyName("updatePeriodSeconds")]
    public int? UpdatePeriodSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusAgentBirdV4StateEnum>))]
public enum V1CalicoNodeStatusStatusAgentBirdV4StateEnum
{
    [EnumMember(Value = "Ready"), JsonStringEnumMemberName("Ready")]
    Ready,
    [EnumMember(Value = "NotReady"), JsonStringEnumMemberName("NotReady")]
    NotReady
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusAgentBirdV4
{
    [JsonPropertyName("lastBootTime")]
    public string? LastBootTime { get; set; }

    [JsonPropertyName("lastReconfigurationTime")]
    public string? LastReconfigurationTime { get; set; }

    [JsonPropertyName("routerID")]
    public string? RouterID { get; set; }

    [JsonPropertyName("state")]
    public V1CalicoNodeStatusStatusAgentBirdV4StateEnum? State { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusAgentBirdV6StateEnum>))]
public enum V1CalicoNodeStatusStatusAgentBirdV6StateEnum
{
    [EnumMember(Value = "Ready"), JsonStringEnumMemberName("Ready")]
    Ready,
    [EnumMember(Value = "NotReady"), JsonStringEnumMemberName("NotReady")]
    NotReady
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusAgentBirdV6
{
    [JsonPropertyName("lastBootTime")]
    public string? LastBootTime { get; set; }

    [JsonPropertyName("lastReconfigurationTime")]
    public string? LastReconfigurationTime { get; set; }

    [JsonPropertyName("routerID")]
    public string? RouterID { get; set; }

    [JsonPropertyName("state")]
    public V1CalicoNodeStatusStatusAgentBirdV6StateEnum? State { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusAgent
{
    [JsonPropertyName("birdV4")]
    public V1CalicoNodeStatusStatusAgentBirdV4? BirdV4 { get; set; }

    [JsonPropertyName("birdV6")]
    public V1CalicoNodeStatusStatusAgentBirdV6? BirdV6 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusBgpPeersV4StateEnum>))]
public enum V1CalicoNodeStatusStatusBgpPeersV4StateEnum
{
    [EnumMember(Value = "Idle"), JsonStringEnumMemberName("Idle")]
    Idle,
    [EnumMember(Value = "Connect"), JsonStringEnumMemberName("Connect")]
    Connect,
    [EnumMember(Value = "Active"), JsonStringEnumMemberName("Active")]
    Active,
    [EnumMember(Value = "OpenSent"), JsonStringEnumMemberName("OpenSent")]
    OpenSent,
    [EnumMember(Value = "OpenConfirm"), JsonStringEnumMemberName("OpenConfirm")]
    OpenConfirm,
    [EnumMember(Value = "Established"), JsonStringEnumMemberName("Established")]
    Established,
    [EnumMember(Value = "Close"), JsonStringEnumMemberName("Close")]
    Close
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusBgpPeersV4TypeEnum>))]
public enum V1CalicoNodeStatusStatusBgpPeersV4TypeEnum
{
    [EnumMember(Value = "NodeMesh"), JsonStringEnumMemberName("NodeMesh")]
    NodeMesh,
    [EnumMember(Value = "NodePeer"), JsonStringEnumMemberName("NodePeer")]
    NodePeer,
    [EnumMember(Value = "GlobalPeer"), JsonStringEnumMemberName("GlobalPeer")]
    GlobalPeer
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusBgpPeersV4
{
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    [JsonPropertyName("since")]
    public string? Since { get; set; }

    [JsonPropertyName("state")]
    public V1CalicoNodeStatusStatusBgpPeersV4StateEnum? State { get; set; }

    [JsonPropertyName("type")]
    public V1CalicoNodeStatusStatusBgpPeersV4TypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusBgpPeersV6StateEnum>))]
public enum V1CalicoNodeStatusStatusBgpPeersV6StateEnum
{
    [EnumMember(Value = "Idle"), JsonStringEnumMemberName("Idle")]
    Idle,
    [EnumMember(Value = "Connect"), JsonStringEnumMemberName("Connect")]
    Connect,
    [EnumMember(Value = "Active"), JsonStringEnumMemberName("Active")]
    Active,
    [EnumMember(Value = "OpenSent"), JsonStringEnumMemberName("OpenSent")]
    OpenSent,
    [EnumMember(Value = "OpenConfirm"), JsonStringEnumMemberName("OpenConfirm")]
    OpenConfirm,
    [EnumMember(Value = "Established"), JsonStringEnumMemberName("Established")]
    Established,
    [EnumMember(Value = "Close"), JsonStringEnumMemberName("Close")]
    Close
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusBgpPeersV6TypeEnum>))]
public enum V1CalicoNodeStatusStatusBgpPeersV6TypeEnum
{
    [EnumMember(Value = "NodeMesh"), JsonStringEnumMemberName("NodeMesh")]
    NodeMesh,
    [EnumMember(Value = "NodePeer"), JsonStringEnumMemberName("NodePeer")]
    NodePeer,
    [EnumMember(Value = "GlobalPeer"), JsonStringEnumMemberName("GlobalPeer")]
    GlobalPeer
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusBgpPeersV6
{
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    [JsonPropertyName("since")]
    public string? Since { get; set; }

    [JsonPropertyName("state")]
    public V1CalicoNodeStatusStatusBgpPeersV6StateEnum? State { get; set; }

    [JsonPropertyName("type")]
    public V1CalicoNodeStatusStatusBgpPeersV6TypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusBgp
{
    [JsonPropertyName("numberEstablishedV4")]
    public required int NumberEstablishedV4 { get; set; }

    [JsonPropertyName("numberEstablishedV6")]
    public required int NumberEstablishedV6 { get; set; }

    [JsonPropertyName("numberNotEstablishedV4")]
    public required int NumberNotEstablishedV4 { get; set; }

    [JsonPropertyName("numberNotEstablishedV6")]
    public required int NumberNotEstablishedV6 { get; set; }

    [JsonPropertyName("peersV4")]
    public IList<V1CalicoNodeStatusStatusBgpPeersV4>? PeersV4 { get; set; }

    [JsonPropertyName("peersV6")]
    public IList<V1CalicoNodeStatusStatusBgpPeersV6>? PeersV6 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFromSourceTypeEnum>))]
public enum V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFromSourceTypeEnum
{
    [EnumMember(Value = "Kernel"), JsonStringEnumMemberName("Kernel")]
    Kernel,
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static,
    [EnumMember(Value = "Direct"), JsonStringEnumMemberName("Direct")]
    Direct,
    [EnumMember(Value = "NodeMesh"), JsonStringEnumMemberName("NodeMesh")]
    NodeMesh,
    [EnumMember(Value = "BGPPeer"), JsonStringEnumMemberName("BGPPeer")]
    BGPPeer
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFrom
{
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    [JsonPropertyName("sourceType")]
    public V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFromSourceTypeEnum? SourceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusRoutesRoutesV4TypeEnum>))]
public enum V1CalicoNodeStatusStatusRoutesRoutesV4TypeEnum
{
    [EnumMember(Value = "FIB"), JsonStringEnumMemberName("FIB")]
    FIB,
    [EnumMember(Value = "RIB"), JsonStringEnumMemberName("RIB")]
    RIB
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV4
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    [JsonPropertyName("learnedFrom")]
    public V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFrom? LearnedFrom { get; set; }

    [JsonPropertyName("type")]
    public V1CalicoNodeStatusStatusRoutesRoutesV4TypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFromSourceTypeEnum>))]
public enum V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFromSourceTypeEnum
{
    [EnumMember(Value = "Kernel"), JsonStringEnumMemberName("Kernel")]
    Kernel,
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static,
    [EnumMember(Value = "Direct"), JsonStringEnumMemberName("Direct")]
    Direct,
    [EnumMember(Value = "NodeMesh"), JsonStringEnumMemberName("NodeMesh")]
    NodeMesh,
    [EnumMember(Value = "BGPPeer"), JsonStringEnumMemberName("BGPPeer")]
    BGPPeer
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFrom
{
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    [JsonPropertyName("sourceType")]
    public V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFromSourceTypeEnum? SourceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusRoutesRoutesV6TypeEnum>))]
public enum V1CalicoNodeStatusStatusRoutesRoutesV6TypeEnum
{
    [EnumMember(Value = "FIB"), JsonStringEnumMemberName("FIB")]
    FIB,
    [EnumMember(Value = "RIB"), JsonStringEnumMemberName("RIB")]
    RIB
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV6
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    [JsonPropertyName("learnedFrom")]
    public V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFrom? LearnedFrom { get; set; }

    [JsonPropertyName("type")]
    public V1CalicoNodeStatusStatusRoutesRoutesV6TypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutes
{
    [JsonPropertyName("routesV4")]
    public IList<V1CalicoNodeStatusStatusRoutesRoutesV4>? RoutesV4 { get; set; }

    [JsonPropertyName("routesV6")]
    public IList<V1CalicoNodeStatusStatusRoutesRoutesV6>? RoutesV6 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatus
{
    [JsonPropertyName("agent")]
    public V1CalicoNodeStatusStatusAgent? Agent { get; set; }

    [JsonPropertyName("bgp")]
    public V1CalicoNodeStatusStatusBgp? Bgp { get; set; }

    [JsonPropertyName("lastUpdated")]
    public DateTime? LastUpdated { get; set; }

    [JsonPropertyName("routes")]
    public V1CalicoNodeStatusStatusRoutes? Routes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CalicoNodeStatus : IKubernetesObject<V1ObjectMeta>, ISpec<V1CalicoNodeStatusSpec?>, IStatus<V1CalicoNodeStatusStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CalicoNodeStatus";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "caliconodestatuses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CalicoNodeStatus";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1CalicoNodeStatusSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1CalicoNodeStatusStatus? Status { get; set; }
}