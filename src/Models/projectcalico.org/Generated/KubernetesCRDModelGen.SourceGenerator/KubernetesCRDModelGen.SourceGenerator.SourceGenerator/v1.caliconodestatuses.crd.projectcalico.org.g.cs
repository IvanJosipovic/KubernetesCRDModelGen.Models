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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>CalicoNodeStatusSpec contains the specification for a CalicoNodeStatus resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusSpec
{
    /// <summary>
    /// Classes declares the types of information to monitor for this calico/node,
    /// and allows for selective status reporting about certain subsets of information.
    /// </summary>
    [JsonPropertyName("classes")]
    public IList<V1CalicoNodeStatusSpecClassesEnum>? Classes { get; set; }

    /// <summary>The node name identifies the Calico node instance for node status.</summary>
    [JsonPropertyName("node")]
    public string? Node { get; set; }

    /// <summary>
    /// UpdatePeriodSeconds is the period at which CalicoNodeStatus should be updated.
    /// Set to 0 to disable CalicoNodeStatus refresh. Maximum update period is one day.
    /// </summary>
    [JsonPropertyName("updatePeriodSeconds")]
    public int? UpdatePeriodSeconds { get; set; }
}

/// <summary>The state of the BGP Daemon.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusAgentBirdV4StateEnum>))]
public enum V1CalicoNodeStatusStatusAgentBirdV4StateEnum
{
    [EnumMember(Value = "Ready"), JsonStringEnumMemberName("Ready")]
    Ready,
    [EnumMember(Value = "NotReady"), JsonStringEnumMemberName("NotReady")]
    NotReady
}

/// <summary>BIRDV4 represents the latest observed status of bird4.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusAgentBirdV4
{
    /// <summary>LastBootTime holds the value of lastBootTime from bird.ctl output.</summary>
    [JsonPropertyName("lastBootTime")]
    public string? LastBootTime { get; set; }

    /// <summary>LastReconfigurationTime holds the value of lastReconfigTime from bird.ctl output.</summary>
    [JsonPropertyName("lastReconfigurationTime")]
    public string? LastReconfigurationTime { get; set; }

    /// <summary>Router ID used by bird.</summary>
    [JsonPropertyName("routerID")]
    public string? RouterID { get; set; }

    /// <summary>The state of the BGP Daemon.</summary>
    [JsonPropertyName("state")]
    public V1CalicoNodeStatusStatusAgentBirdV4StateEnum? State { get; set; }

    /// <summary>Version of the BGP daemon</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The state of the BGP Daemon.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusAgentBirdV6StateEnum>))]
public enum V1CalicoNodeStatusStatusAgentBirdV6StateEnum
{
    [EnumMember(Value = "Ready"), JsonStringEnumMemberName("Ready")]
    Ready,
    [EnumMember(Value = "NotReady"), JsonStringEnumMemberName("NotReady")]
    NotReady
}

/// <summary>BIRDV6 represents the latest observed status of bird6.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusAgentBirdV6
{
    /// <summary>LastBootTime holds the value of lastBootTime from bird.ctl output.</summary>
    [JsonPropertyName("lastBootTime")]
    public string? LastBootTime { get; set; }

    /// <summary>LastReconfigurationTime holds the value of lastReconfigTime from bird.ctl output.</summary>
    [JsonPropertyName("lastReconfigurationTime")]
    public string? LastReconfigurationTime { get; set; }

    /// <summary>Router ID used by bird.</summary>
    [JsonPropertyName("routerID")]
    public string? RouterID { get; set; }

    /// <summary>The state of the BGP Daemon.</summary>
    [JsonPropertyName("state")]
    public V1CalicoNodeStatusStatusAgentBirdV6StateEnum? State { get; set; }

    /// <summary>Version of the BGP daemon</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Agent holds agent status on the node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusAgent
{
    /// <summary>BIRDV4 represents the latest observed status of bird4.</summary>
    [JsonPropertyName("birdV4")]
    public V1CalicoNodeStatusStatusAgentBirdV4? BirdV4 { get; set; }

    /// <summary>BIRDV6 represents the latest observed status of bird6.</summary>
    [JsonPropertyName("birdV6")]
    public V1CalicoNodeStatusStatusAgentBirdV6? BirdV6 { get; set; }
}

/// <summary>State is the BGP session state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>
/// Type indicates whether this peer is configured via the node-to-node mesh,
/// or via an explicit global or per-node BGPPeer object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>CalicoNodePeer contains the status of BGP peers on the node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusBgpPeersV4
{
    /// <summary>IP address of the peer whose condition we are reporting.</summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary>Since the state or reason last changed.</summary>
    [JsonPropertyName("since")]
    public string? Since { get; set; }

    /// <summary>State is the BGP session state.</summary>
    [JsonPropertyName("state")]
    public V1CalicoNodeStatusStatusBgpPeersV4StateEnum? State { get; set; }

    /// <summary>
    /// Type indicates whether this peer is configured via the node-to-node mesh,
    /// or via an explicit global or per-node BGPPeer object.
    /// </summary>
    [JsonPropertyName("type")]
    public V1CalicoNodeStatusStatusBgpPeersV4TypeEnum? Type { get; set; }
}

/// <summary>State is the BGP session state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>
/// Type indicates whether this peer is configured via the node-to-node mesh,
/// or via an explicit global or per-node BGPPeer object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>CalicoNodePeer contains the status of BGP peers on the node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusBgpPeersV6
{
    /// <summary>IP address of the peer whose condition we are reporting.</summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary>Since the state or reason last changed.</summary>
    [JsonPropertyName("since")]
    public string? Since { get; set; }

    /// <summary>State is the BGP session state.</summary>
    [JsonPropertyName("state")]
    public V1CalicoNodeStatusStatusBgpPeersV6StateEnum? State { get; set; }

    /// <summary>
    /// Type indicates whether this peer is configured via the node-to-node mesh,
    /// or via an explicit global or per-node BGPPeer object.
    /// </summary>
    [JsonPropertyName("type")]
    public V1CalicoNodeStatusStatusBgpPeersV6TypeEnum? Type { get; set; }
}

/// <summary>BGP holds node BGP status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusBgp
{
    /// <summary>The total number of IPv4 established bgp sessions.</summary>
    [JsonPropertyName("numberEstablishedV4")]
    public required int NumberEstablishedV4 { get; set; }

    /// <summary>The total number of IPv6 established bgp sessions.</summary>
    [JsonPropertyName("numberEstablishedV6")]
    public required int NumberEstablishedV6 { get; set; }

    /// <summary>The total number of IPv4 non-established bgp sessions.</summary>
    [JsonPropertyName("numberNotEstablishedV4")]
    public required int NumberNotEstablishedV4 { get; set; }

    /// <summary>The total number of IPv6 non-established bgp sessions.</summary>
    [JsonPropertyName("numberNotEstablishedV6")]
    public required int NumberNotEstablishedV6 { get; set; }

    /// <summary>PeersV4 represents IPv4 BGP peers status on the node.</summary>
    [JsonPropertyName("peersV4")]
    public IList<V1CalicoNodeStatusStatusBgpPeersV4>? PeersV4 { get; set; }

    /// <summary>PeersV6 represents IPv6 BGP peers status on the node.</summary>
    [JsonPropertyName("peersV6")]
    public IList<V1CalicoNodeStatusStatusBgpPeersV6>? PeersV6 { get; set; }
}

/// <summary>Type of the source where a route is learned from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>LearnedFrom contains information regarding where this route originated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFrom
{
    /// <summary>If sourceType is NodeMesh or BGPPeer, IP address of the router that sent us this route.</summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary>Type of the source where a route is learned from.</summary>
    [JsonPropertyName("sourceType")]
    public V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFromSourceTypeEnum? SourceType { get; set; }
}

/// <summary>Type indicates if the route is being used for forwarding or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusRoutesRoutesV4TypeEnum>))]
public enum V1CalicoNodeStatusStatusRoutesRoutesV4TypeEnum
{
    [EnumMember(Value = "FIB"), JsonStringEnumMemberName("FIB")]
    FIB,
    [EnumMember(Value = "RIB"), JsonStringEnumMemberName("RIB")]
    RIB
}

/// <summary>CalicoNodeRoute contains the status of BGP routes on the node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV4
{
    /// <summary>Destination of the route.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Gateway for the destination.</summary>
    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    /// <summary>Interface for the destination</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>LearnedFrom contains information regarding where this route originated.</summary>
    [JsonPropertyName("learnedFrom")]
    public V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFrom? LearnedFrom { get; set; }

    /// <summary>Type indicates if the route is being used for forwarding or not.</summary>
    [JsonPropertyName("type")]
    public V1CalicoNodeStatusStatusRoutesRoutesV4TypeEnum? Type { get; set; }
}

/// <summary>Type of the source where a route is learned from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

/// <summary>LearnedFrom contains information regarding where this route originated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFrom
{
    /// <summary>If sourceType is NodeMesh or BGPPeer, IP address of the router that sent us this route.</summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary>Type of the source where a route is learned from.</summary>
    [JsonPropertyName("sourceType")]
    public V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFromSourceTypeEnum? SourceType { get; set; }
}

/// <summary>Type indicates if the route is being used for forwarding or not.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CalicoNodeStatusStatusRoutesRoutesV6TypeEnum>))]
public enum V1CalicoNodeStatusStatusRoutesRoutesV6TypeEnum
{
    [EnumMember(Value = "FIB"), JsonStringEnumMemberName("FIB")]
    FIB,
    [EnumMember(Value = "RIB"), JsonStringEnumMemberName("RIB")]
    RIB
}

/// <summary>CalicoNodeRoute contains the status of BGP routes on the node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutesRoutesV6
{
    /// <summary>Destination of the route.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Gateway for the destination.</summary>
    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    /// <summary>Interface for the destination</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>LearnedFrom contains information regarding where this route originated.</summary>
    [JsonPropertyName("learnedFrom")]
    public V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFrom? LearnedFrom { get; set; }

    /// <summary>Type indicates if the route is being used for forwarding or not.</summary>
    [JsonPropertyName("type")]
    public V1CalicoNodeStatusStatusRoutesRoutesV6TypeEnum? Type { get; set; }
}

/// <summary>Routes reports routes known to the Calico BGP daemon on the node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatusRoutes
{
    /// <summary>RoutesV4 represents IPv4 routes on the node.</summary>
    [JsonPropertyName("routesV4")]
    public IList<V1CalicoNodeStatusStatusRoutesRoutesV4>? RoutesV4 { get; set; }

    /// <summary>RoutesV6 represents IPv6 routes on the node.</summary>
    [JsonPropertyName("routesV6")]
    public IList<V1CalicoNodeStatusStatusRoutesRoutesV6>? RoutesV6 { get; set; }
}

/// <summary>
/// CalicoNodeStatusStatus defines the observed state of CalicoNodeStatus.
/// No validation needed for status since it is updated by Calico.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CalicoNodeStatusStatus
{
    /// <summary>Agent holds agent status on the node.</summary>
    [JsonPropertyName("agent")]
    public V1CalicoNodeStatusStatusAgent? Agent { get; set; }

    /// <summary>BGP holds node BGP status.</summary>
    [JsonPropertyName("bgp")]
    public V1CalicoNodeStatusStatusBgp? Bgp { get; set; }

    /// <summary>
    /// LastUpdated is a timestamp representing the server time when CalicoNodeStatus object
    /// last updated. It is represented in RFC3339 form and is in UTC.
    /// </summary>
    [JsonPropertyName("lastUpdated")]
    public DateTime? LastUpdated { get; set; }

    /// <summary>Routes reports routes known to the Calico BGP daemon on the node.</summary>
    [JsonPropertyName("routes")]
    public V1CalicoNodeStatusStatusRoutes? Routes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
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

    /// <summary>CalicoNodeStatusSpec contains the specification for a CalicoNodeStatus resource.</summary>
    [JsonPropertyName("spec")]
    public V1CalicoNodeStatusSpec? Spec { get; set; }

    /// <summary>
    /// CalicoNodeStatusStatus defines the observed state of CalicoNodeStatus.
    /// No validation needed for status since it is updated by Calico.
    /// </summary>
    [JsonPropertyName("status")]
    public V1CalicoNodeStatusStatus? Status { get; set; }
}