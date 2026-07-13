#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/networkInterface.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301NetworkInterfaceList : IKubernetesObject<V1ListMeta>, IItems<V1api20240301NetworkInterface>
{
    public const string KubeApiVersion = "v1api20240301";
    public const string KubeKind = "NetworkInterfaceList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "networkinterfaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkInterfaceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240301NetworkInterface objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240301NetworkInterface> Items { get; set; }
}

/// <summary>AuxiliaryMode: Auxiliary mode of Network Interface resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301NetworkInterfaceSpecAuxiliaryModeEnum>))]
public enum V1api20240301NetworkInterfaceSpecAuxiliaryModeEnum
{
    [EnumMember(Value = "AcceleratedConnections"), JsonStringEnumMemberName("AcceleratedConnections")]
    AcceleratedConnections,
    [EnumMember(Value = "Floating"), JsonStringEnumMemberName("Floating")]
    Floating,
    [EnumMember(Value = "MaxConnections"), JsonStringEnumMemberName("MaxConnections")]
    MaxConnections,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>AuxiliarySku: Auxiliary sku of Network Interface resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301NetworkInterfaceSpecAuxiliarySkuEnum>))]
public enum V1api20240301NetworkInterfaceSpecAuxiliarySkuEnum
{
    [EnumMember(Value = "A1"), JsonStringEnumMemberName("A1")]
    A1,
    [EnumMember(Value = "A2"), JsonStringEnumMemberName("A2")]
    A2,
    [EnumMember(Value = "A4"), JsonStringEnumMemberName("A4")]
    A4,
    [EnumMember(Value = "A8"), JsonStringEnumMemberName("A8")]
    A8,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>DnsSettings: The DNS settings in network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecDnsSettings
{
    /// <summary>
    /// DnsServers: List of DNS servers IP addresses. Use &apos;AzureProvidedDNS&apos; to switch to azure provided DNS resolution.
    /// &apos;AzureProvidedDNS&apos; value cannot be combined with other IPs, it must be the only value in dnsServers collection.
    /// </summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>
    /// InternalDnsNameLabel: Relative DNS name for this NIC used for internal communications between VMs in the same virtual
    /// network.
    /// </summary>
    [JsonPropertyName("internalDnsNameLabel")]
    public string? InternalDnsNameLabel { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301NetworkInterfaceSpecExtendedLocationTypeEnum>))]
public enum V1api20240301NetworkInterfaceSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V1api20240301NetworkInterfaceSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsApplicationGatewayBackendAddressPoolsReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Backend Address Pool of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsApplicationGatewayBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsApplicationSecurityGroupsReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>An application security group in a resource group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsApplicationSecurityGroups
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsApplicationSecurityGroupsReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsGatewayLoadBalancerReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>GatewayLoadBalancer: The reference to gateway load balancer frontend IP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsGatewayLoadBalancer
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsGatewayLoadBalancerReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsLoadBalancerBackendAddressPoolsReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Pool of backend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsLoadBalancerBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsLoadBalancerInboundNatRulesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Inbound NAT rule of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsLoadBalancerInboundNatRules
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsLoadBalancerInboundNatRulesReference? Reference { get; set; }
}

/// <summary>PrivateIPAddressVersion: Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301NetworkInterfaceSpecIpConfigurationsPrivateIPAddressVersionEnum>))]
public enum V1api20240301NetworkInterfaceSpecIpConfigurationsPrivateIPAddressVersionEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>PrivateIPAllocationMethod: The private IP address allocation method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301NetworkInterfaceSpecIpConfigurationsPrivateIPAllocationMethodEnum>))]
public enum V1api20240301NetworkInterfaceSpecIpConfigurationsPrivateIPAllocationMethodEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic,
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsPublicIPAddressReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicIPAddress: Public IP address bound to the IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsPublicIPAddress
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsSubnetReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Subnet: Subnet bound to the IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsVirtualNetworkTapsReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Virtual Network Tap resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurationsVirtualNetworkTaps
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsVirtualNetworkTapsReference? Reference { get; set; }
}

/// <summary>IPConfiguration in a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecIpConfigurations
{
    /// <summary>ApplicationGatewayBackendAddressPools: The reference to ApplicationGatewayBackendAddressPool resource.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V1api20240301NetworkInterfaceSpecIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary>ApplicationSecurityGroups: Application security groups in which the IP configuration is included.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20240301NetworkInterfaceSpecIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary>GatewayLoadBalancer: The reference to gateway load balancer frontend IP.</summary>
    [JsonPropertyName("gatewayLoadBalancer")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsGatewayLoadBalancer? GatewayLoadBalancer { get; set; }

    /// <summary>LoadBalancerBackendAddressPools: The reference to LoadBalancerBackendAddressPool resource.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V1api20240301NetworkInterfaceSpecIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    /// <summary>LoadBalancerInboundNatRules: A list of references of LoadBalancerInboundNatRules.</summary>
    [JsonPropertyName("loadBalancerInboundNatRules")]
    public IList<V1api20240301NetworkInterfaceSpecIpConfigurationsLoadBalancerInboundNatRules>? LoadBalancerInboundNatRules { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Primary: Whether this is a primary customer address on the network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>
    /// PrivateIPAddress: Private IP address of the IP configuration. It can be a single IP address or a CIDR block in the
    /// format &lt;address&gt;/&lt;prefix-length&gt;.
    /// </summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary>
    /// PrivateIPAddressPrefixLength: The private IP address prefix length. If specified and the allocation method is dynamic,
    /// the service will allocate a CIDR block instead of a single IP address.
    /// </summary>
    [JsonPropertyName("privateIPAddressPrefixLength")]
    public int? PrivateIPAddressPrefixLength { get; set; }

    /// <summary>PrivateIPAddressVersion: Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4.</summary>
    [JsonPropertyName("privateIPAddressVersion")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsPrivateIPAddressVersionEnum? PrivateIPAddressVersion { get; set; }

    /// <summary>PrivateIPAllocationMethod: The private IP address allocation method.</summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsPrivateIPAllocationMethodEnum? PrivateIPAllocationMethod { get; set; }

    /// <summary>PublicIPAddress: Public IP address bound to the IP configuration.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Subnet: Subnet bound to the IP configuration.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240301NetworkInterfaceSpecIpConfigurationsSubnet? Subnet { get; set; }

    /// <summary>VirtualNetworkTaps: The reference to Virtual Network Taps.</summary>
    [JsonPropertyName("virtualNetworkTaps")]
    public IList<V1api20240301NetworkInterfaceSpecIpConfigurationsVirtualNetworkTaps>? VirtualNetworkTaps { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecNetworkSecurityGroupReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>NetworkSecurityGroup: The reference to the NetworkSecurityGroup resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecNetworkSecurityGroup
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301NetworkInterfaceSpecNetworkSecurityGroupReference? Reference { get; set; }
}

/// <summary>NicType: Type of Network Interface resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301NetworkInterfaceSpecNicTypeEnum>))]
public enum V1api20240301NetworkInterfaceSpecNicTypeEnum
{
    [EnumMember(Value = "Elastic"), JsonStringEnumMemberName("Elastic")]
    Elastic,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301NetworkInterfaceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301NetworkInterfaceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecPrivateLinkServiceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PrivateLinkService: Privatelinkservice of the network interface resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpecPrivateLinkService
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301NetworkInterfaceSpecPrivateLinkServiceReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceSpec
{
    /// <summary>AuxiliaryMode: Auxiliary mode of Network Interface resource.</summary>
    [JsonPropertyName("auxiliaryMode")]
    public V1api20240301NetworkInterfaceSpecAuxiliaryModeEnum? AuxiliaryMode { get; set; }

    /// <summary>AuxiliarySku: Auxiliary sku of Network Interface resource.</summary>
    [JsonPropertyName("auxiliarySku")]
    public V1api20240301NetworkInterfaceSpecAuxiliarySkuEnum? AuxiliarySku { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DisableTcpStateTracking: Indicates whether to disable tcp state tracking.</summary>
    [JsonPropertyName("disableTcpStateTracking")]
    public bool? DisableTcpStateTracking { get; set; }

    /// <summary>DnsSettings: The DNS settings in network interface.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20240301NetworkInterfaceSpecDnsSettings? DnsSettings { get; set; }

    /// <summary>
    /// EnableAcceleratedNetworking: If the network interface is configured for accelerated networking. Not applicable to VM
    /// sizes which require accelerated networking.
    /// </summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>EnableIPForwarding: Indicates whether IP forwarding is enabled on this network interface.</summary>
    [JsonPropertyName("enableIPForwarding")]
    public bool? EnableIPForwarding { get; set; }

    /// <summary>ExtendedLocation: The extended location of the network interface.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240301NetworkInterfaceSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>IpConfigurations: A list of IPConfigurations of the network interface.</summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20240301NetworkInterfaceSpecIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>NetworkSecurityGroup: The reference to the NetworkSecurityGroup resource.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V1api20240301NetworkInterfaceSpecNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary>NicType: Type of Network Interface resource.</summary>
    [JsonPropertyName("nicType")]
    public V1api20240301NetworkInterfaceSpecNicTypeEnum? NicType { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301NetworkInterfaceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240301NetworkInterfaceSpecOwner Owner { get; set; }

    /// <summary>PrivateLinkService: Privatelinkservice of the network interface resource.</summary>
    [JsonPropertyName("privateLinkService")]
    public V1api20240301NetworkInterfaceSpecPrivateLinkService? PrivateLinkService { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>WorkloadType: WorkloadType of the NetworkInterface for BareMetal resources</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>DnsSettings: The DNS settings in network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusDnsSettings
{
    /// <summary>
    /// AppliedDnsServers: If the VM that uses this NIC is part of an Availability Set, then this list will have the union of
    /// all DNS servers from all NICs that are part of the Availability Set. This property is what is configured on each of
    /// those VMs.
    /// </summary>
    [JsonPropertyName("appliedDnsServers")]
    public IList<string>? AppliedDnsServers { get; set; }

    /// <summary>
    /// DnsServers: List of DNS servers IP addresses. Use &apos;AzureProvidedDNS&apos; to switch to azure provided DNS resolution.
    /// &apos;AzureProvidedDNS&apos; value cannot be combined with other IPs, it must be the only value in dnsServers collection.
    /// </summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>
    /// InternalDnsNameLabel: Relative DNS name for this NIC used for internal communications between VMs in the same virtual
    /// network.
    /// </summary>
    [JsonPropertyName("internalDnsNameLabel")]
    public string? InternalDnsNameLabel { get; set; }

    /// <summary>
    /// InternalDomainNameSuffix: Even if internalDnsNameLabel is not specified, a DNS entry is created for the primary NIC of
    /// the VM. This DNS name can be constructed by concatenating the VM name with the value of internalDomainNameSuffix.
    /// </summary>
    [JsonPropertyName("internalDomainNameSuffix")]
    public string? InternalDomainNameSuffix { get; set; }

    /// <summary>InternalFqdn: Fully qualified DNS name supporting internal communications between VMs in the same virtual network.</summary>
    [JsonPropertyName("internalFqdn")]
    public string? InternalFqdn { get; set; }
}

/// <summary>DscpConfiguration: A reference to the dscp configuration to which the network interface is linked.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusDscpConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ExtendedLocation: The extended location of the network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Backend Address Pool of an application gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>An application security group in a resource group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusIpConfigurationsApplicationSecurityGroups
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>GatewayLoadBalancer: The reference to gateway load balancer frontend IP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusIpConfigurationsGatewayLoadBalancer
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Pool of backend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Inbound NAT rule of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusIpConfigurationsLoadBalancerInboundNatRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PrivateLinkConnectionProperties: PrivateLinkConnection properties for the network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusIpConfigurationsPrivateLinkConnectionProperties
{
    /// <summary>Fqdns: List of FQDNs for current private link connection.</summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary>GroupId: The group ID for current private link connection.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>RequiredMemberName: The required member name for current private link connection.</summary>
    [JsonPropertyName("requiredMemberName")]
    public string? RequiredMemberName { get; set; }
}

/// <summary>PublicIPAddress: Public IP address bound to the IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusIpConfigurationsPublicIPAddress
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Subnet: Subnet bound to the IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusIpConfigurationsSubnet
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Virtual Network Tap resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusIpConfigurationsVirtualNetworkTaps
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>IPConfiguration in a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusIpConfigurations
{
    /// <summary>ApplicationGatewayBackendAddressPools: The reference to ApplicationGatewayBackendAddressPool resource.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V1api20240301NetworkInterfaceStatusIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary>ApplicationSecurityGroups: Application security groups in which the IP configuration is included.</summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20240301NetworkInterfaceStatusIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>GatewayLoadBalancer: The reference to gateway load balancer frontend IP.</summary>
    [JsonPropertyName("gatewayLoadBalancer")]
    public V1api20240301NetworkInterfaceStatusIpConfigurationsGatewayLoadBalancer? GatewayLoadBalancer { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>LoadBalancerBackendAddressPools: The reference to LoadBalancerBackendAddressPool resource.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V1api20240301NetworkInterfaceStatusIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    /// <summary>LoadBalancerInboundNatRules: A list of references of LoadBalancerInboundNatRules.</summary>
    [JsonPropertyName("loadBalancerInboundNatRules")]
    public IList<V1api20240301NetworkInterfaceStatusIpConfigurationsLoadBalancerInboundNatRules>? LoadBalancerInboundNatRules { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Primary: Whether this is a primary customer address on the network interface.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>
    /// PrivateIPAddress: Private IP address of the IP configuration. It can be a single IP address or a CIDR block in the
    /// format &lt;address&gt;/&lt;prefix-length&gt;.
    /// </summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary>
    /// PrivateIPAddressPrefixLength: The private IP address prefix length. If specified and the allocation method is dynamic,
    /// the service will allocate a CIDR block instead of a single IP address.
    /// </summary>
    [JsonPropertyName("privateIPAddressPrefixLength")]
    public int? PrivateIPAddressPrefixLength { get; set; }

    /// <summary>PrivateIPAddressVersion: Whether the specific IP configuration is IPv4 or IPv6. Default is IPv4.</summary>
    [JsonPropertyName("privateIPAddressVersion")]
    public string? PrivateIPAddressVersion { get; set; }

    /// <summary>PrivateIPAllocationMethod: The private IP address allocation method.</summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public string? PrivateIPAllocationMethod { get; set; }

    /// <summary>PrivateLinkConnectionProperties: PrivateLinkConnection properties for the network interface.</summary>
    [JsonPropertyName("privateLinkConnectionProperties")]
    public V1api20240301NetworkInterfaceStatusIpConfigurationsPrivateLinkConnectionProperties? PrivateLinkConnectionProperties { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the network interface IP configuration.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicIPAddress: Public IP address bound to the IP configuration.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20240301NetworkInterfaceStatusIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Subnet: Subnet bound to the IP configuration.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240301NetworkInterfaceStatusIpConfigurationsSubnet? Subnet { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VirtualNetworkTaps: The reference to Virtual Network Taps.</summary>
    [JsonPropertyName("virtualNetworkTaps")]
    public IList<V1api20240301NetworkInterfaceStatusIpConfigurationsVirtualNetworkTaps>? VirtualNetworkTaps { get; set; }
}

/// <summary>NetworkSecurityGroup: The reference to the NetworkSecurityGroup resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusNetworkSecurityGroup
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PrivateEndpoint: A reference to the private endpoint to which the network interface is linked.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusPrivateEndpoint
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PrivateLinkService: Privatelinkservice of the network interface resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusPrivateLinkService
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Tap configuration in a Network Interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusTapConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>VirtualMachine: The reference to a virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatusVirtualMachine
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A network interface in a resource group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301NetworkInterfaceStatus
{
    /// <summary>AuxiliaryMode: Auxiliary mode of Network Interface resource.</summary>
    [JsonPropertyName("auxiliaryMode")]
    public string? AuxiliaryMode { get; set; }

    /// <summary>AuxiliarySku: Auxiliary sku of Network Interface resource.</summary>
    [JsonPropertyName("auxiliarySku")]
    public string? AuxiliarySku { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240301NetworkInterfaceStatusConditions>? Conditions { get; set; }

    /// <summary>DisableTcpStateTracking: Indicates whether to disable tcp state tracking.</summary>
    [JsonPropertyName("disableTcpStateTracking")]
    public bool? DisableTcpStateTracking { get; set; }

    /// <summary>DnsSettings: The DNS settings in network interface.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20240301NetworkInterfaceStatusDnsSettings? DnsSettings { get; set; }

    /// <summary>DscpConfiguration: A reference to the dscp configuration to which the network interface is linked.</summary>
    [JsonPropertyName("dscpConfiguration")]
    public V1api20240301NetworkInterfaceStatusDscpConfiguration? DscpConfiguration { get; set; }

    /// <summary>
    /// EnableAcceleratedNetworking: If the network interface is configured for accelerated networking. Not applicable to VM
    /// sizes which require accelerated networking.
    /// </summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>EnableIPForwarding: Indicates whether IP forwarding is enabled on this network interface.</summary>
    [JsonPropertyName("enableIPForwarding")]
    public bool? EnableIPForwarding { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ExtendedLocation: The extended location of the network interface.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240301NetworkInterfaceStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>HostedWorkloads: A list of references to linked BareMetal resources.</summary>
    [JsonPropertyName("hostedWorkloads")]
    public IList<string>? HostedWorkloads { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IpConfigurations: A list of IPConfigurations of the network interface.</summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20240301NetworkInterfaceStatusIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MacAddress: The MAC address of the network interface.</summary>
    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; set; }

    /// <summary>MigrationPhase: Migration phase of Network Interface resource.</summary>
    [JsonPropertyName("migrationPhase")]
    public string? MigrationPhase { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkSecurityGroup: The reference to the NetworkSecurityGroup resource.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V1api20240301NetworkInterfaceStatusNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary>NicType: Type of Network Interface resource.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>Primary: Whether this is a primary network interface on a virtual machine.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>PrivateEndpoint: A reference to the private endpoint to which the network interface is linked.</summary>
    [JsonPropertyName("privateEndpoint")]
    public V1api20240301NetworkInterfaceStatusPrivateEndpoint? PrivateEndpoint { get; set; }

    /// <summary>PrivateLinkService: Privatelinkservice of the network interface resource.</summary>
    [JsonPropertyName("privateLinkService")]
    public V1api20240301NetworkInterfaceStatusPrivateLinkService? PrivateLinkService { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the network interface resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceGuid: The resource GUID property of the network interface resource.</summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TapConfigurations: A list of TapConfigurations of the network interface.</summary>
    [JsonPropertyName("tapConfigurations")]
    public IList<V1api20240301NetworkInterfaceStatusTapConfigurations>? TapConfigurations { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VirtualMachine: The reference to a virtual machine.</summary>
    [JsonPropertyName("virtualMachine")]
    public V1api20240301NetworkInterfaceStatusVirtualMachine? VirtualMachine { get; set; }

    /// <summary>VnetEncryptionSupported: Whether the virtual machine this nic is attached to supports encryption.</summary>
    [JsonPropertyName("vnetEncryptionSupported")]
    public bool? VnetEncryptionSupported { get; set; }

    /// <summary>WorkloadType: WorkloadType of the NetworkInterface for BareMetal resources</summary>
    [JsonPropertyName("workloadType")]
    public string? WorkloadType { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/networkInterface.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkInterfaces/{networkInterfaceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301NetworkInterface : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301NetworkInterfaceSpec?>, IStatus<V1api20240301NetworkInterfaceStatus?>
{
    public const string KubeApiVersion = "v1api20240301";
    public const string KubeKind = "NetworkInterface";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "networkinterfaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkInterface";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240301NetworkInterfaceSpec? Spec { get; set; }

    /// <summary>A network interface in a resource group.</summary>
    [JsonPropertyName("status")]
    public V1api20240301NetworkInterfaceStatus? Status { get; set; }
}