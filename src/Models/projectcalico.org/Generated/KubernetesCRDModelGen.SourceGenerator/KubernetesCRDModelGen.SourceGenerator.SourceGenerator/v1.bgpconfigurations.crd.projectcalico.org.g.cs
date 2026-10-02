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
/// <summary>BGPConfiguration contains the configuration for any BGP routing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1BGPConfiguration>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPConfigurationList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BGPConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1BGPConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1BGPConfiguration> Items { get; set; }
}

/// <summary>
/// BindMode indicates whether to listen for BGP connections on all addresses (None)
/// or only on the node&apos;s canonical IP address Node.Spec.BGP.IPvXAddress (NodeIP).
/// Default behaviour is to listen for BGP connections on all addresses.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPConfigurationSpecBindModeEnum>))]
public enum V1BGPConfigurationSpecBindModeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "NodeIP"), JsonStringEnumMemberName("NodeIP")]
    NodeIP
}

/// <summary>Community contains standard or large community value and its name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecCommunities
{
    /// <summary>Name given to community value.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Value must be of format `aa:nn` or `aa:nn:mm`.
    /// For standard community use `aa:nn` format, where `aa` and `nn` are 16 bit number.
    /// For large community use `aa:nn:mm` format, where `aa`, `nn` and `mm` are 32 bit number.
    /// Where, `aa` is an AS Number, `nn` and `mm` are per-AS identifier.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Selects a key of a secret in the node pod&apos;s namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecNodeMeshPasswordSecretKeyRef
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>
/// Optional BGP password for full node-to-mesh peerings.
/// This field can only be set on the default BGPConfiguration instance and requires that NodeMesh is enabled
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecNodeMeshPassword
{
    /// <summary>Selects a key of a secret in the node pod&apos;s namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1BGPConfigurationSpecNodeMeshPasswordSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>PrefixAdvertisement configures advertisement properties for the specified CIDR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecPrefixAdvertisements
{
    /// <summary>CIDR for which properties should be advertised.</summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary>
    /// Communities can be list of either community names already defined in `Specs.Communities` or community value of format `aa:nn` or `aa:nn:mm`.
    /// For standard community use `aa:nn` format, where `aa` and `nn` are 16 bit number.
    /// For large community use `aa:nn:mm` format, where `aa`, `nn` and `mm` are 32 bit number.
    /// Where,`aa` is an AS Number, `nn` and `mm` are per-AS identifier.
    /// </summary>
    [JsonPropertyName("communities")]
    public IList<string>? Communities { get; set; }
}

/// <summary>
/// ProgramClusterRoutes controls which &quot;cluster routes&quot; are programmed by Calico&apos;s BGP
/// stack, i.e. the routes that a node needs in order to reach workloads on other nodes.  It
/// only applies to IP Pools with vxlanMode: Never; the cluster routes for IP Pools with
/// vxlanMode: Always or vxlanMode: CrossSubnet are always programmed by Felix.  The routes
/// that BIRD does not program here are expected to be programmed by Felix instead.  Below,
/// an IPIP IP Pool is one with ipipMode: Always or CrossSubnet, and an unencapsulated one
/// has ipipMode and vxlanMode both Never.
/// 
/// - Disabled: BIRD programs no cluster routes.
/// - EnabledNoEncapOnly: BIRD programs them for unencapsulated IP Pools.
/// - EnabledIPIPOnly: BIRD programs them for IPIP IP Pools.
/// - Enabled: BIRD programs them for both.
/// 
/// This field must be kept consistent with FelixConfiguration.ProgramClusterRoutes, which
/// makes the same choice from Felix&apos;s side.  If both Felix and BIRD are enabled for the same
/// kind of IP Pool they will fight over the routes; if neither is, there will be no cluster
/// routes at all.
/// 
/// Note: asking BIRD to program IPIP cluster routes, which the Enabled and EnabledIPIPOnly
/// values do, is deprecated as of v3.33 and will be removed in v3.35.
/// 
/// [Default: EnabledNoEncapOnly]
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPConfigurationSpecProgramClusterRoutesEnum>))]
public enum V1BGPConfigurationSpecProgramClusterRoutesEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "EnabledIPIPOnly"), JsonStringEnumMemberName("EnabledIPIPOnly")]
    EnabledIPIPOnly,
    [EnumMember(Value = "EnabledNoEncapOnly"), JsonStringEnumMemberName("EnabledNoEncapOnly")]
    EnabledNoEncapOnly
}

/// <summary>ServiceClusterIPBlock represents a single allowed ClusterIP CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceClusterIPs
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary>ServiceExternalIPBlock represents a single allowed External IP CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceExternalIPs
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary>
/// ServiceLoadBalancerAggregation controls how LoadBalancer service IPs are advertised.
/// When set to &quot;Disabled&quot;, individual /32 routes are advertised for each service instead of
/// the full CIDR range. This is useful for anycast failover mechanisms where failed service
/// routes need to be withdrawn. [Default: Enabled]
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPConfigurationSpecServiceLoadBalancerAggregationEnum>))]
public enum V1BGPConfigurationSpecServiceLoadBalancerAggregationEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

/// <summary>ServiceLoadBalancerIPBlock represents a single allowed LoadBalancer IP CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpecServiceLoadBalancerIPs
{
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }
}

/// <summary>BGPConfigurationSpec contains the values of the BGP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPConfigurationSpec
{
    /// <summary>ASNumber is the default AS number used by a node. [Default: 64512]</summary>
    [JsonPropertyName("asNumber")]
    public long? AsNumber { get; set; }

    /// <summary>
    /// BindMode indicates whether to listen for BGP connections on all addresses (None)
    /// or only on the node&apos;s canonical IP address Node.Spec.BGP.IPvXAddress (NodeIP).
    /// Default behaviour is to listen for BGP connections on all addresses.
    /// </summary>
    [JsonPropertyName("bindMode")]
    public V1BGPConfigurationSpecBindModeEnum? BindMode { get; set; }

    /// <summary>Communities is a list of BGP community values and their arbitrary names for tagging routes.</summary>
    [JsonPropertyName("communities")]
    public IList<V1BGPConfigurationSpecCommunities>? Communities { get; set; }

    /// <summary>IgnoredInterfaces indicates the network interfaces that needs to be excluded when reading device routes.</summary>
    [JsonPropertyName("ignoredInterfaces")]
    public IList<string>? IgnoredInterfaces { get; set; }

    /// <summary>
    /// IPv4NormalRoutePriority is the normal route priority (metric) that Felix uses for IPv4
    /// workload routes. This must match the value configured in FelixConfiguration. BIRD uses
    /// this to identify elevated-priority routes during live migration and to override local
    /// workload routes with higher-priority BGP-learned routes. [Default: 1024]
    /// </summary>
    [JsonPropertyName("ipv4NormalRoutePriority")]
    public int? Ipv4NormalRoutePriority { get; set; }

    /// <summary>
    /// IPv6NormalRoutePriority is the normal route priority (metric) that Felix uses for IPv6
    /// workload routes. This must match the value configured in FelixConfiguration. BIRD uses
    /// this to identify elevated-priority routes during live migration and to override local
    /// workload routes with higher-priority BGP-learned routes. [Default: 1024]
    /// </summary>
    [JsonPropertyName("ipv6NormalRoutePriority")]
    public int? Ipv6NormalRoutePriority { get; set; }

    /// <summary>ListenPort is the port where BGP protocol should listen. Defaults to 179</summary>
    [JsonPropertyName("listenPort")]
    public int? ListenPort { get; set; }

    /// <summary>
    /// The virtual IPv4 address of the node with which its local workload is expected to peer.
    /// It is recommended to use a link-local address.
    /// </summary>
    [JsonPropertyName("localWorkloadPeeringIPV4")]
    public string? LocalWorkloadPeeringIPV4 { get; set; }

    /// <summary>
    /// The virtual IPv6 address of the node with which its local workload is expected to peer.
    /// It is recommended to use a link-local address.
    /// </summary>
    [JsonPropertyName("localWorkloadPeeringIPV6")]
    public string? LocalWorkloadPeeringIPV6 { get; set; }

    /// <summary>LogSeverityScreen is the log severity above which logs are sent to the stdout. [Default: Info]</summary>
    [JsonPropertyName("logSeverityScreen")]
    public string? LogSeverityScreen { get; set; }

    /// <summary>
    /// Time to allow for software restart for node-to-mesh peerings.  When specified, this is configured
    /// as the graceful restart timeout.  When not specified, the BIRD default of 120s is used.
    /// This field can only be set on the default BGPConfiguration instance and requires that NodeMesh is enabled
    /// </summary>
    [JsonPropertyName("nodeMeshMaxRestartTime")]
    public string? NodeMeshMaxRestartTime { get; set; }

    /// <summary>
    /// Optional BGP password for full node-to-mesh peerings.
    /// This field can only be set on the default BGPConfiguration instance and requires that NodeMesh is enabled
    /// </summary>
    [JsonPropertyName("nodeMeshPassword")]
    public V1BGPConfigurationSpecNodeMeshPassword? NodeMeshPassword { get; set; }

    /// <summary>NodeToNodeMeshEnabled sets whether full node to node BGP mesh is enabled. [Default: true]</summary>
    [JsonPropertyName("nodeToNodeMeshEnabled")]
    public bool? NodeToNodeMeshEnabled { get; set; }

    /// <summary>PrefixAdvertisements contains per-prefix advertisement configuration.</summary>
    [JsonPropertyName("prefixAdvertisements")]
    public IList<V1BGPConfigurationSpecPrefixAdvertisements>? PrefixAdvertisements { get; set; }

    /// <summary>
    /// ProgramClusterRoutes controls which &quot;cluster routes&quot; are programmed by Calico&apos;s BGP
    /// stack, i.e. the routes that a node needs in order to reach workloads on other nodes.  It
    /// only applies to IP Pools with vxlanMode: Never; the cluster routes for IP Pools with
    /// vxlanMode: Always or vxlanMode: CrossSubnet are always programmed by Felix.  The routes
    /// that BIRD does not program here are expected to be programmed by Felix instead.  Below,
    /// an IPIP IP Pool is one with ipipMode: Always or CrossSubnet, and an unencapsulated one
    /// has ipipMode and vxlanMode both Never.
    /// 
    /// - Disabled: BIRD programs no cluster routes.
    /// - EnabledNoEncapOnly: BIRD programs them for unencapsulated IP Pools.
    /// - EnabledIPIPOnly: BIRD programs them for IPIP IP Pools.
    /// - Enabled: BIRD programs them for both.
    /// 
    /// This field must be kept consistent with FelixConfiguration.ProgramClusterRoutes, which
    /// makes the same choice from Felix&apos;s side.  If both Felix and BIRD are enabled for the same
    /// kind of IP Pool they will fight over the routes; if neither is, there will be no cluster
    /// routes at all.
    /// 
    /// Note: asking BIRD to program IPIP cluster routes, which the Enabled and EnabledIPIPOnly
    /// values do, is deprecated as of v3.33 and will be removed in v3.35.
    /// 
    /// [Default: EnabledNoEncapOnly]
    /// </summary>
    [JsonPropertyName("programClusterRoutes")]
    public V1BGPConfigurationSpecProgramClusterRoutesEnum? ProgramClusterRoutes { get; set; }

    /// <summary>
    /// ServiceClusterIPs are the CIDR blocks from which service cluster IPs are allocated.
    /// If specified, Calico will advertise these blocks, as well as any cluster IPs within them.
    /// </summary>
    [JsonPropertyName("serviceClusterIPs")]
    public IList<V1BGPConfigurationSpecServiceClusterIPs>? ServiceClusterIPs { get; set; }

    /// <summary>
    /// ServiceExternalIPs are the CIDR blocks for Kubernetes Service External IPs.
    /// Kubernetes Service ExternalIPs will only be advertised if they are within one of these blocks.
    /// </summary>
    [JsonPropertyName("serviceExternalIPs")]
    public IList<V1BGPConfigurationSpecServiceExternalIPs>? ServiceExternalIPs { get; set; }

    /// <summary>
    /// ServiceLoadBalancerAggregation controls how LoadBalancer service IPs are advertised.
    /// When set to &quot;Disabled&quot;, individual /32 routes are advertised for each service instead of
    /// the full CIDR range. This is useful for anycast failover mechanisms where failed service
    /// routes need to be withdrawn. [Default: Enabled]
    /// </summary>
    [JsonPropertyName("serviceLoadBalancerAggregation")]
    public V1BGPConfigurationSpecServiceLoadBalancerAggregationEnum? ServiceLoadBalancerAggregation { get; set; }

    /// <summary>
    /// ServiceLoadBalancerIPs are the CIDR blocks for Kubernetes Service LoadBalancer IPs.
    /// Kubernetes Service status.LoadBalancer.Ingress IPs will only be advertised if they are within one of these blocks.
    /// </summary>
    [JsonPropertyName("serviceLoadBalancerIPs")]
    public IList<V1BGPConfigurationSpecServiceLoadBalancerIPs>? ServiceLoadBalancerIPs { get; set; }
}

/// <summary>BGPConfiguration contains the configuration for any BGP routing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1BGPConfigurationSpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPConfiguration";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BGPConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BGPConfigurationSpec contains the values of the BGP configuration.</summary>
    [JsonPropertyName("spec")]
    public V1BGPConfigurationSpec? Spec { get; set; }
}