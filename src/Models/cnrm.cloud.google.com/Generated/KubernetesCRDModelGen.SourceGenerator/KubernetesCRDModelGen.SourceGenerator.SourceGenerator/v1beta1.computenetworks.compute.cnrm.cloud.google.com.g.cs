#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeNetworkList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeNetwork>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeNetworkList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenetworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeNetworkList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeNetwork objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeNetwork> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkSpec
{
    /// <summary>
    /// Immutable. When set to &apos;true&apos;, the network is created in &quot;auto subnet mode&quot; and
    /// it will create a subnet for each region automatically across the
    /// &apos;10.128.0.0/9&apos; address range.
    /// 
    /// When set to &apos;false&apos;, the network is created in &quot;custom subnet mode&quot; so
    /// the user can explicitly connect subnetwork resources.
    /// </summary>
    [JsonPropertyName("autoCreateSubnetworks")]
    public bool? AutoCreateSubnetworks { get; set; }

    /// <summary>
    /// If set to &apos;true&apos;, default routes (&apos;0.0.0.0/0&apos;) will be deleted
    /// immediately after network creation. Defaults to &apos;false&apos;.
    /// </summary>
    [JsonPropertyName("deleteDefaultRoutesOnCreate")]
    public bool? DeleteDefaultRoutesOnCreate { get; set; }

    /// <summary>
    /// Immutable. An optional description of this resource. The resource must be
    /// recreated to modify this field.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Enable ULA internal ipv6 on this network. Enabling this feature will assign
    /// a /48 from google defined ULA prefix fd20::/20.
    /// </summary>
    [JsonPropertyName("enableUlaInternalIpv6")]
    public bool? EnableUlaInternalIpv6 { get; set; }

    /// <summary>
    /// Immutable. When enabling ula internal ipv6, caller optionally can specify the /48 range
    /// they want from the google defined ULA prefix fd20::/20. The input must be a
    /// valid /48 ULA IPv6 address and must be within the fd20::/20. Operation will
    /// fail if the speficied /48 is already in used by another resource.
    /// If the field is not speficied, then a /48 range will be randomly allocated from fd20::/20 and returned via this field.
    /// </summary>
    [JsonPropertyName("internalIpv6Range")]
    public string? InternalIpv6Range { get; set; }

    /// <summary>
    /// Immutable. Maximum Transmission Unit in bytes. The default value is 1460 bytes.
    /// The minimum value for this field is 1300 and the maximum value is 8896 bytes (jumbo frames).
    /// Note that packets larger than 1500 bytes (standard Ethernet) can be subject to TCP-MSS clamping or dropped
    /// with an ICMP &apos;Fragmentation-Needed&apos; message if the packets are routed to the Internet or other VPCs
    /// with varying MTUs.
    /// </summary>
    [JsonPropertyName("mtu")]
    public int? Mtu { get; set; }

    /// <summary>Set the order that Firewall Rules and Firewall Policies are evaluated. Default value: &quot;AFTER_CLASSIC_FIREWALL&quot; Possible values: [&quot;BEFORE_CLASSIC_FIREWALL&quot;, &quot;AFTER_CLASSIC_FIREWALL&quot;].</summary>
    [JsonPropertyName("networkFirewallPolicyEnforcementOrder")]
    public string? NetworkFirewallPolicyEnforcementOrder { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// The network-wide routing mode to use. If set to &apos;REGIONAL&apos;, this
    /// network&apos;s cloud routers will only advertise routes with subnetworks
    /// of this network in the same region as the router. If set to &apos;GLOBAL&apos;,
    /// this network&apos;s cloud routers will advertise routes with all
    /// subnetworks of this network, across regions. Possible values: [&quot;REGIONAL&quot;, &quot;GLOBAL&quot;].
    /// </summary>
    [JsonPropertyName("routingMode")]
    public string? RoutingMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeNetworkStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The gateway address for default routing out of the network. This value
    /// is selected by GCP.
    /// </summary>
    [JsonPropertyName("gatewayIpv4")]
    public string? GatewayIpv4 { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeNetwork : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeNetworkSpec?>, IStatus<V1beta1ComputeNetworkStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeNetwork";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenetworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeNetwork";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1beta1ComputeNetworkSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta1ComputeNetworkStatus? Status { get; set; }
}