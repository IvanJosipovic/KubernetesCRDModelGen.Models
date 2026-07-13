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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2020-11-01/loadBalancer.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201101LoadBalancerList : IKubernetesObject<V1ListMeta>, IItems<V1api20201101LoadBalancer>
{
    public const string KubeApiVersion = "v1api20201101";
    public const string KubeKind = "LoadBalancerList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "loadbalancers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20201101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20201101LoadBalancer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20201101LoadBalancer> Items { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfigurationReference
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

/// <summary>LoadBalancerFrontendIPConfiguration: Reference to the frontend ip address configuration defined in regional loadbalancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnetReference
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

/// <summary>Subnet: Reference to an existing subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnetReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetworkReference
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

/// <summary>VirtualNetwork: Reference to an existing virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetworkReference? Reference { get; set; }
}

/// <summary>Load balancer backend addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddresses
{
    /// <summary>IpAddress: IP Address belonging to the referenced virtual network.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>LoadBalancerFrontendIPConfiguration: Reference to the frontend ip address configuration defined in regional loadbalancer.</summary>
    [JsonPropertyName("loadBalancerFrontendIPConfiguration")]
    public V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration? LoadBalancerFrontendIPConfiguration { get; set; }

    /// <summary>Name: Name of the backend address.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Subnet: Reference to an existing subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnet? Subnet { get; set; }

    /// <summary>VirtualNetwork: Reference to an existing virtual network.</summary>
    [JsonPropertyName("virtualNetwork")]
    public V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork? VirtualNetwork { get; set; }
}

/// <summary>Pool of backend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecBackendAddressPools
{
    /// <summary>LoadBalancerBackendAddresses: An array of backend addresses.</summary>
    [JsonPropertyName("loadBalancerBackendAddresses")]
    public IList<V1api20201101LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddresses>? LoadBalancerBackendAddresses { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of backend address pools used by the load balancer. This
    /// name can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101LoadBalancerSpecExtendedLocationTypeEnum>))]
public enum V1api20201101LoadBalancerSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public required V1api20201101LoadBalancerSpecExtendedLocationTypeEnum Type { get; set; }
}

/// <summary>PrivateIPAddressVersion: Whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101LoadBalancerSpecFrontendIPConfigurationsPrivateIPAddressVersionEnum>))]
public enum V1api20201101LoadBalancerSpecFrontendIPConfigurationsPrivateIPAddressVersionEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>PrivateIPAllocationMethod: The Private IP allocation method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101LoadBalancerSpecFrontendIPConfigurationsPrivateIPAllocationMethodEnum>))]
public enum V1api20201101LoadBalancerSpecFrontendIPConfigurationsPrivateIPAllocationMethodEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic,
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecFrontendIPConfigurationsPublicIPAddressReference
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

/// <summary>PublicIPAddress: The reference to the Public IP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecFrontendIPConfigurationsPublicIPAddress
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecFrontendIPConfigurationsPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecFrontendIPConfigurationsPublicIPPrefixReference
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

/// <summary>PublicIPPrefix: The reference to the Public IP Prefix resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecFrontendIPConfigurationsPublicIPPrefix
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecFrontendIPConfigurationsPublicIPPrefixReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecFrontendIPConfigurationsSubnetReference
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

/// <summary>Subnet: The reference to the subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecFrontendIPConfigurationsSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecFrontendIPConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>Frontend IP address of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecFrontendIPConfigurations
{
    /// <summary>
    /// Name: The name of the resource that is unique within the set of frontend IP configurations used by the load balancer.
    /// This name can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateIPAddress: The private IP address of the IP configuration.</summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary>PrivateIPAddressVersion: Whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.</summary>
    [JsonPropertyName("privateIPAddressVersion")]
    public V1api20201101LoadBalancerSpecFrontendIPConfigurationsPrivateIPAddressVersionEnum? PrivateIPAddressVersion { get; set; }

    /// <summary>PrivateIPAllocationMethod: The Private IP allocation method.</summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public V1api20201101LoadBalancerSpecFrontendIPConfigurationsPrivateIPAllocationMethodEnum? PrivateIPAllocationMethod { get; set; }

    /// <summary>PublicIPAddress: The reference to the Public IP resource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20201101LoadBalancerSpecFrontendIPConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>PublicIPPrefix: The reference to the Public IP Prefix resource.</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20201101LoadBalancerSpecFrontendIPConfigurationsPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Subnet: The reference to the subnet resource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20201101LoadBalancerSpecFrontendIPConfigurationsSubnet? Subnet { get; set; }

    /// <summary>Zones: A list of availability zones denoting the IP allocated for the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecInboundNatPoolsFrontendIPConfigurationReference
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

/// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecInboundNatPoolsFrontendIPConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecInboundNatPoolsFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>Protocol: The reference to the transport protocol used by the inbound NAT pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101LoadBalancerSpecInboundNatPoolsProtocolEnum>))]
public enum V1api20201101LoadBalancerSpecInboundNatPoolsProtocolEnum
{
    [EnumMember(Value = "All"), JsonStringEnumMemberName("All")]
    All,
    [EnumMember(Value = "Tcp"), JsonStringEnumMemberName("Tcp")]
    Tcp,
    [EnumMember(Value = "Udp"), JsonStringEnumMemberName("Udp")]
    Udp
}

/// <summary>Inbound NAT pool of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecInboundNatPools
{
    /// <summary>BackendPort: The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535.</summary>
    [JsonPropertyName("backendPort")]
    public required int BackendPort { get; set; }

    /// <summary>
    /// EnableFloatingIP: Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL
    /// AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server.
    /// This setting can&apos;t be changed after you create the endpoint.
    /// </summary>
    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    /// <summary>
    /// EnableTcpReset: Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This
    /// element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101LoadBalancerSpecInboundNatPoolsFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>
    /// FrontendPortRangeEnd: The last port number in the range of external ports that will be used to provide Inbound Nat to
    /// NICs associated with a load balancer. Acceptable values range between 1 and 65535.
    /// </summary>
    [JsonPropertyName("frontendPortRangeEnd")]
    public required int FrontendPortRangeEnd { get; set; }

    /// <summary>
    /// FrontendPortRangeStart: The first port number in the range of external ports that will be used to provide Inbound Nat to
    /// NICs associated with a load balancer. Acceptable values range between 1 and 65534.
    /// </summary>
    [JsonPropertyName("frontendPortRangeStart")]
    public required int FrontendPortRangeStart { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The
    /// default value is 4 minutes. This element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of inbound NAT pools used by the load balancer. This name
    /// can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: The reference to the transport protocol used by the inbound NAT pool.</summary>
    [JsonPropertyName("protocol")]
    public required V1api20201101LoadBalancerSpecInboundNatPoolsProtocolEnum Protocol { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecInboundNatRulesFrontendIPConfigurationReference
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

/// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecInboundNatRulesFrontendIPConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecInboundNatRulesFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>Protocol: The reference to the transport protocol used by the load balancing rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101LoadBalancerSpecInboundNatRulesProtocolEnum>))]
public enum V1api20201101LoadBalancerSpecInboundNatRulesProtocolEnum
{
    [EnumMember(Value = "All"), JsonStringEnumMemberName("All")]
    All,
    [EnumMember(Value = "Tcp"), JsonStringEnumMemberName("Tcp")]
    Tcp,
    [EnumMember(Value = "Udp"), JsonStringEnumMemberName("Udp")]
    Udp
}

/// <summary>Inbound NAT rule of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecInboundNatRules
{
    /// <summary>BackendPort: The port used for the internal endpoint. Acceptable values range from 1 to 65535.</summary>
    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    /// <summary>
    /// EnableFloatingIP: Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL
    /// AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server.
    /// This setting can&apos;t be changed after you create the endpoint.
    /// </summary>
    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    /// <summary>
    /// EnableTcpReset: Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This
    /// element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101LoadBalancerSpecInboundNatRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>
    /// FrontendPort: The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer.
    /// Acceptable values range from 1 to 65534.
    /// </summary>
    [JsonPropertyName("frontendPort")]
    public int? FrontendPort { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The
    /// default value is 4 minutes. This element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of inbound NAT rules used by the load balancer. This name
    /// can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: The reference to the transport protocol used by the load balancing rule.</summary>
    [JsonPropertyName("protocol")]
    public V1api20201101LoadBalancerSpecInboundNatRulesProtocolEnum? Protocol { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecLoadBalancingRulesBackendAddressPoolReference
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

/// <summary>
/// BackendAddressPool: A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend
/// IPs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecLoadBalancingRulesBackendAddressPool
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecLoadBalancingRulesBackendAddressPoolReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecLoadBalancingRulesFrontendIPConfigurationReference
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

/// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecLoadBalancingRulesFrontendIPConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecLoadBalancingRulesFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>LoadDistribution: The load distribution policy for this rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101LoadBalancerSpecLoadBalancingRulesLoadDistributionEnum>))]
public enum V1api20201101LoadBalancerSpecLoadBalancingRulesLoadDistributionEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "SourceIP"), JsonStringEnumMemberName("SourceIP")]
    SourceIP,
    [EnumMember(Value = "SourceIPProtocol"), JsonStringEnumMemberName("SourceIPProtocol")]
    SourceIPProtocol
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecLoadBalancingRulesProbeReference
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

/// <summary>Probe: The reference to the load balancer probe used by the load balancing rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecLoadBalancingRulesProbe
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecLoadBalancingRulesProbeReference? Reference { get; set; }
}

/// <summary>Protocol: The reference to the transport protocol used by the load balancing rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101LoadBalancerSpecLoadBalancingRulesProtocolEnum>))]
public enum V1api20201101LoadBalancerSpecLoadBalancingRulesProtocolEnum
{
    [EnumMember(Value = "All"), JsonStringEnumMemberName("All")]
    All,
    [EnumMember(Value = "Tcp"), JsonStringEnumMemberName("Tcp")]
    Tcp,
    [EnumMember(Value = "Udp"), JsonStringEnumMemberName("Udp")]
    Udp
}

/// <summary>A load balancing rule for a load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecLoadBalancingRules
{
    /// <summary>
    /// BackendAddressPool: A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend
    /// IPs.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20201101LoadBalancerSpecLoadBalancingRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>
    /// BackendPort: The port used for internal connections on the endpoint. Acceptable values are between 0 and 65535. Note
    /// that value 0 enables &quot;Any Port&quot;.
    /// </summary>
    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    /// <summary>
    /// DisableOutboundSnat: Configures SNAT for the VMs in the backend pool to use the publicIP address specified in the
    /// frontend of the load balancing rule.
    /// </summary>
    [JsonPropertyName("disableOutboundSnat")]
    public bool? DisableOutboundSnat { get; set; }

    /// <summary>
    /// EnableFloatingIP: Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL
    /// AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server.
    /// This setting can&apos;t be changed after you create the endpoint.
    /// </summary>
    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    /// <summary>
    /// EnableTcpReset: Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This
    /// element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101LoadBalancerSpecLoadBalancingRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>
    /// FrontendPort: The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer.
    /// Acceptable values are between 0 and 65534. Note that value 0 enables &quot;Any Port&quot;.
    /// </summary>
    [JsonPropertyName("frontendPort")]
    public required int FrontendPort { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The
    /// default value is 4 minutes. This element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>LoadDistribution: The load distribution policy for this rule.</summary>
    [JsonPropertyName("loadDistribution")]
    public V1api20201101LoadBalancerSpecLoadBalancingRulesLoadDistributionEnum? LoadDistribution { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of load balancing rules used by the load balancer. This
    /// name can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Probe: The reference to the load balancer probe used by the load balancing rule.</summary>
    [JsonPropertyName("probe")]
    public V1api20201101LoadBalancerSpecLoadBalancingRulesProbe? Probe { get; set; }

    /// <summary>Protocol: The reference to the transport protocol used by the load balancing rule.</summary>
    [JsonPropertyName("protocol")]
    public required V1api20201101LoadBalancerSpecLoadBalancingRulesProtocolEnum Protocol { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20201101LoadBalancerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20201101LoadBalancerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecOutboundRulesBackendAddressPoolReference
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

/// <summary>
/// BackendAddressPool: A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend
/// IPs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecOutboundRulesBackendAddressPool
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecOutboundRulesBackendAddressPoolReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecOutboundRulesFrontendIPConfigurationsReference
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

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecOutboundRulesFrontendIPConfigurations
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101LoadBalancerSpecOutboundRulesFrontendIPConfigurationsReference? Reference { get; set; }
}

/// <summary>Protocol: The protocol for the outbound rule in load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101LoadBalancerSpecOutboundRulesProtocolEnum>))]
public enum V1api20201101LoadBalancerSpecOutboundRulesProtocolEnum
{
    [EnumMember(Value = "All"), JsonStringEnumMemberName("All")]
    All,
    [EnumMember(Value = "Tcp"), JsonStringEnumMemberName("Tcp")]
    Tcp,
    [EnumMember(Value = "Udp"), JsonStringEnumMemberName("Udp")]
    Udp
}

/// <summary>Outbound rule of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecOutboundRules
{
    /// <summary>AllocatedOutboundPorts: The number of outbound ports to be used for NAT.</summary>
    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary>
    /// BackendAddressPool: A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend
    /// IPs.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public required V1api20201101LoadBalancerSpecOutboundRulesBackendAddressPool BackendAddressPool { get; set; }

    /// <summary>
    /// EnableTcpReset: Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This
    /// element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>FrontendIPConfigurations: The Frontend IP addresses of the load balancer.</summary>
    [JsonPropertyName("frontendIPConfigurations")]
    public required IList<V1api20201101LoadBalancerSpecOutboundRulesFrontendIPConfigurations> FrontendIPConfigurations { get; set; }

    /// <summary>IdleTimeoutInMinutes: The timeout for the TCP idle connection.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of outbound rules used by the load balancer. This name can
    /// be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: The protocol for the outbound rule in load balancer.</summary>
    [JsonPropertyName("protocol")]
    public required V1api20201101LoadBalancerSpecOutboundRulesProtocolEnum Protocol { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Protocol: The protocol of the end point. If &apos;Tcp&apos; is specified, a received ACK is required for the probe to be
/// successful. If &apos;Http&apos; or &apos;Https&apos; is specified, a 200 OK response from the specifies URI is required for the probe to be
/// successful.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101LoadBalancerSpecProbesProtocolEnum>))]
public enum V1api20201101LoadBalancerSpecProbesProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https,
    [EnumMember(Value = "Tcp"), JsonStringEnumMemberName("Tcp")]
    Tcp
}

/// <summary>A load balancer probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecProbes
{
    /// <summary>
    /// IntervalInSeconds: The interval, in seconds, for how frequently to probe the endpoint for health status. Typically, the
    /// interval is slightly less than half the allocated timeout period (in seconds) which allows two full probes before taking
    /// the instance out of rotation. The default value is 15, the minimum value is 5.
    /// </summary>
    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of probes used by the load balancer. This name can be used
    /// to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// NumberOfProbes: The number of probes where if no response, will result in stopping further traffic from being delivered
    /// to the endpoint. This values allows endpoints to be taken out of rotation faster or slower than the typical times used
    /// in Azure.
    /// </summary>
    [JsonPropertyName("numberOfProbes")]
    public int? NumberOfProbes { get; set; }

    /// <summary>Port: The port for communicating the probe. Possible values range from 1 to 65535, inclusive.</summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>
    /// Protocol: The protocol of the end point. If &apos;Tcp&apos; is specified, a received ACK is required for the probe to be
    /// successful. If &apos;Http&apos; or &apos;Https&apos; is specified, a 200 OK response from the specifies URI is required for the probe to be
    /// successful.
    /// </summary>
    [JsonPropertyName("protocol")]
    public required V1api20201101LoadBalancerSpecProbesProtocolEnum Protocol { get; set; }

    /// <summary>
    /// RequestPath: The URI used for requesting health status from the VM. Path is required if a protocol is set to http.
    /// Otherwise, it is not allowed. There is no default value.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }
}

/// <summary>Name: Name of a load balancer SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101LoadBalancerSpecSkuNameEnum>))]
public enum V1api20201101LoadBalancerSpecSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Tier: Tier of a load balancer SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101LoadBalancerSpecSkuTierEnum>))]
public enum V1api20201101LoadBalancerSpecSkuTierEnum
{
    [EnumMember(Value = "Global"), JsonStringEnumMemberName("Global")]
    Global,
    [EnumMember(Value = "Regional"), JsonStringEnumMemberName("Regional")]
    Regional
}

/// <summary>Sku: The load balancer SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpecSku
{
    /// <summary>Name: Name of a load balancer SKU.</summary>
    [JsonPropertyName("name")]
    public V1api20201101LoadBalancerSpecSkuNameEnum? Name { get; set; }

    /// <summary>Tier: Tier of a load balancer SKU.</summary>
    [JsonPropertyName("tier")]
    public V1api20201101LoadBalancerSpecSkuTierEnum? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>BackendAddressPools: Collection of backend address pools used by a load balancer.</summary>
    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20201101LoadBalancerSpecBackendAddressPools>? BackendAddressPools { get; set; }

    /// <summary>ExtendedLocation: The extended location of the load balancer.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201101LoadBalancerSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FrontendIPConfigurations: Object representing the frontend IPs to be used for the load balancer.</summary>
    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20201101LoadBalancerSpecFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    /// <summary>
    /// InboundNatPools: Defines an external port range for inbound NAT to a single backend port on NICs associated with a load
    /// balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external
    /// port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound Nat
    /// rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual
    /// virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules.
    /// </summary>
    [JsonPropertyName("inboundNatPools")]
    public IList<V1api20201101LoadBalancerSpecInboundNatPools>? InboundNatPools { get; set; }

    /// <summary>
    /// InboundNatRules: Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load
    /// balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine
    /// scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to
    /// reference individual inbound NAT rules.
    /// </summary>
    [JsonPropertyName("inboundNatRules")]
    public IList<V1api20201101LoadBalancerSpecInboundNatRules>? InboundNatRules { get; set; }

    /// <summary>LoadBalancingRules: Object collection representing the load balancing rules Gets the provisioning.</summary>
    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20201101LoadBalancerSpecLoadBalancingRules>? LoadBalancingRules { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20201101LoadBalancerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>OutboundRules: The outbound rules.</summary>
    [JsonPropertyName("outboundRules")]
    public IList<V1api20201101LoadBalancerSpecOutboundRules>? OutboundRules { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20201101LoadBalancerSpecOwner Owner { get; set; }

    /// <summary>Probes: Collection of probe objects used in the load balancer.</summary>
    [JsonPropertyName("probes")]
    public IList<V1api20201101LoadBalancerSpecProbes>? Probes { get; set; }

    /// <summary>Sku: The load balancer SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20201101LoadBalancerSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>IPConfiguration in a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusBackendAddressPoolsBackendIPConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>LoadBalancerFrontendIPConfiguration: Reference to the frontend ip address configuration defined in regional loadbalancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>NetworkInterfaceIPConfiguration: Reference to IP address defined in network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesNetworkInterfaceIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Subnet: Reference to an existing subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesSubnet
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>VirtualNetwork: Reference to an existing virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Load balancer backend addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddresses
{
    /// <summary>IpAddress: IP Address belonging to the referenced virtual network.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>LoadBalancerFrontendIPConfiguration: Reference to the frontend ip address configuration defined in regional loadbalancer.</summary>
    [JsonPropertyName("loadBalancerFrontendIPConfiguration")]
    public V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration? LoadBalancerFrontendIPConfiguration { get; set; }

    /// <summary>Name: Name of the backend address.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkInterfaceIPConfiguration: Reference to IP address defined in network interfaces.</summary>
    [JsonPropertyName("networkInterfaceIPConfiguration")]
    public V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesNetworkInterfaceIPConfiguration? NetworkInterfaceIPConfiguration { get; set; }

    /// <summary>Subnet: Reference to an existing subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesSubnet? Subnet { get; set; }

    /// <summary>VirtualNetwork: Reference to an existing virtual network.</summary>
    [JsonPropertyName("virtualNetwork")]
    public V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork? VirtualNetwork { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancingRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>OutboundRule: A reference to an outbound rule that uses this backend address pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusBackendAddressPoolsOutboundRule
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusBackendAddressPoolsOutboundRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Pool of backend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusBackendAddressPools
{
    /// <summary>BackendIPConfigurations: An array of references to IP addresses defined in network interfaces.</summary>
    [JsonPropertyName("backendIPConfigurations")]
    public IList<V1api20201101LoadBalancerStatusBackendAddressPoolsBackendIPConfigurations>? BackendIPConfigurations { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>LoadBalancerBackendAddresses: An array of backend addresses.</summary>
    [JsonPropertyName("loadBalancerBackendAddresses")]
    public IList<V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddresses>? LoadBalancerBackendAddresses { get; set; }

    /// <summary>LoadBalancingRules: An array of references to load balancing rules that use this backend address pool.</summary>
    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20201101LoadBalancerStatusBackendAddressPoolsLoadBalancingRules>? LoadBalancingRules { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of backend address pools used by the load balancer. This
    /// name can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OutboundRule: A reference to an outbound rule that uses this backend address pool.</summary>
    [JsonPropertyName("outboundRule")]
    public V1api20201101LoadBalancerStatusBackendAddressPoolsOutboundRule? OutboundRule { get; set; }

    /// <summary>OutboundRules: An array of references to outbound rules that use this backend address pool.</summary>
    [JsonPropertyName("outboundRules")]
    public IList<V1api20201101LoadBalancerStatusBackendAddressPoolsOutboundRules>? OutboundRules { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the backend address pool resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusConditions
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

/// <summary>ExtendedLocation: The extended location of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusFrontendIPConfigurationsInboundNatPools
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusFrontendIPConfigurationsInboundNatRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusFrontendIPConfigurationsLoadBalancingRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusFrontendIPConfigurationsOutboundRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PublicIPAddress: The reference to the Public IP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusFrontendIPConfigurationsPublicIPAddress
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PublicIPPrefix: The reference to the Public IP Prefix resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusFrontendIPConfigurationsPublicIPPrefix
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Subnet: The reference to the subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusFrontendIPConfigurationsSubnet
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Frontend IP address of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusFrontendIPConfigurations
{
    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>InboundNatPools: An array of references to inbound pools that use this frontend IP.</summary>
    [JsonPropertyName("inboundNatPools")]
    public IList<V1api20201101LoadBalancerStatusFrontendIPConfigurationsInboundNatPools>? InboundNatPools { get; set; }

    /// <summary>InboundNatRules: An array of references to inbound rules that use this frontend IP.</summary>
    [JsonPropertyName("inboundNatRules")]
    public IList<V1api20201101LoadBalancerStatusFrontendIPConfigurationsInboundNatRules>? InboundNatRules { get; set; }

    /// <summary>LoadBalancingRules: An array of references to load balancing rules that use this frontend IP.</summary>
    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20201101LoadBalancerStatusFrontendIPConfigurationsLoadBalancingRules>? LoadBalancingRules { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of frontend IP configurations used by the load balancer.
    /// This name can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OutboundRules: An array of references to outbound rules that use this frontend IP.</summary>
    [JsonPropertyName("outboundRules")]
    public IList<V1api20201101LoadBalancerStatusFrontendIPConfigurationsOutboundRules>? OutboundRules { get; set; }

    /// <summary>PrivateIPAddress: The private IP address of the IP configuration.</summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary>PrivateIPAddressVersion: Whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.</summary>
    [JsonPropertyName("privateIPAddressVersion")]
    public string? PrivateIPAddressVersion { get; set; }

    /// <summary>PrivateIPAllocationMethod: The Private IP allocation method.</summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public string? PrivateIPAllocationMethod { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the frontend IP configuration resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicIPAddress: The reference to the Public IP resource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20201101LoadBalancerStatusFrontendIPConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>PublicIPPrefix: The reference to the Public IP Prefix resource.</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20201101LoadBalancerStatusFrontendIPConfigurationsPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Subnet: The reference to the subnet resource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20201101LoadBalancerStatusFrontendIPConfigurationsSubnet? Subnet { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Zones: A list of availability zones denoting the IP allocated for the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusInboundNatPoolsFrontendIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Inbound NAT pool of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusInboundNatPools
{
    /// <summary>BackendPort: The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535.</summary>
    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    /// <summary>
    /// EnableFloatingIP: Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL
    /// AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server.
    /// This setting can&apos;t be changed after you create the endpoint.
    /// </summary>
    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    /// <summary>
    /// EnableTcpReset: Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This
    /// element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101LoadBalancerStatusInboundNatPoolsFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>
    /// FrontendPortRangeEnd: The last port number in the range of external ports that will be used to provide Inbound Nat to
    /// NICs associated with a load balancer. Acceptable values range between 1 and 65535.
    /// </summary>
    [JsonPropertyName("frontendPortRangeEnd")]
    public int? FrontendPortRangeEnd { get; set; }

    /// <summary>
    /// FrontendPortRangeStart: The first port number in the range of external ports that will be used to provide Inbound Nat to
    /// NICs associated with a load balancer. Acceptable values range between 1 and 65534.
    /// </summary>
    [JsonPropertyName("frontendPortRangeStart")]
    public int? FrontendPortRangeStart { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The
    /// default value is 4 minutes. This element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of inbound NAT pools used by the load balancer. This name
    /// can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: The reference to the transport protocol used by the inbound NAT pool.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the inbound NAT pool resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// BackendIPConfiguration: A reference to a private IP address defined on a network interface of a VM. Traffic sent to the
/// frontend port of each of the frontend IP configurations is forwarded to the backend IP.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusInboundNatRulesBackendIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusInboundNatRulesFrontendIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Inbound NAT rule of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusInboundNatRules
{
    /// <summary>
    /// BackendIPConfiguration: A reference to a private IP address defined on a network interface of a VM. Traffic sent to the
    /// frontend port of each of the frontend IP configurations is forwarded to the backend IP.
    /// </summary>
    [JsonPropertyName("backendIPConfiguration")]
    public V1api20201101LoadBalancerStatusInboundNatRulesBackendIPConfiguration? BackendIPConfiguration { get; set; }

    /// <summary>BackendPort: The port used for the internal endpoint. Acceptable values range from 1 to 65535.</summary>
    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    /// <summary>
    /// EnableFloatingIP: Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL
    /// AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server.
    /// This setting can&apos;t be changed after you create the endpoint.
    /// </summary>
    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    /// <summary>
    /// EnableTcpReset: Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This
    /// element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101LoadBalancerStatusInboundNatRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>
    /// FrontendPort: The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer.
    /// Acceptable values range from 1 to 65534.
    /// </summary>
    [JsonPropertyName("frontendPort")]
    public int? FrontendPort { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The
    /// default value is 4 minutes. This element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of inbound NAT rules used by the load balancer. This name
    /// can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: The reference to the transport protocol used by the load balancing rule.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the inbound NAT rule resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// BackendAddressPool: A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend
/// IPs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusLoadBalancingRulesBackendAddressPool
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusLoadBalancingRulesFrontendIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Probe: The reference to the load balancer probe used by the load balancing rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusLoadBalancingRulesProbe
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A load balancing rule for a load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusLoadBalancingRules
{
    /// <summary>
    /// BackendAddressPool: A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend
    /// IPs.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20201101LoadBalancerStatusLoadBalancingRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>
    /// BackendPort: The port used for internal connections on the endpoint. Acceptable values are between 0 and 65535. Note
    /// that value 0 enables &quot;Any Port&quot;.
    /// </summary>
    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    /// <summary>
    /// DisableOutboundSnat: Configures SNAT for the VMs in the backend pool to use the publicIP address specified in the
    /// frontend of the load balancing rule.
    /// </summary>
    [JsonPropertyName("disableOutboundSnat")]
    public bool? DisableOutboundSnat { get; set; }

    /// <summary>
    /// EnableFloatingIP: Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL
    /// AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server.
    /// This setting can&apos;t be changed after you create the endpoint.
    /// </summary>
    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    /// <summary>
    /// EnableTcpReset: Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This
    /// element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101LoadBalancerStatusLoadBalancingRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>
    /// FrontendPort: The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer.
    /// Acceptable values are between 0 and 65534. Note that value 0 enables &quot;Any Port&quot;.
    /// </summary>
    [JsonPropertyName("frontendPort")]
    public int? FrontendPort { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IdleTimeoutInMinutes: The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The
    /// default value is 4 minutes. This element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>LoadDistribution: The load distribution policy for this rule.</summary>
    [JsonPropertyName("loadDistribution")]
    public string? LoadDistribution { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of load balancing rules used by the load balancer. This
    /// name can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Probe: The reference to the load balancer probe used by the load balancing rule.</summary>
    [JsonPropertyName("probe")]
    public V1api20201101LoadBalancerStatusLoadBalancingRulesProbe? Probe { get; set; }

    /// <summary>Protocol: The reference to the transport protocol used by the load balancing rule.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the load balancing rule resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// BackendAddressPool: A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend
/// IPs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusOutboundRulesBackendAddressPool
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusOutboundRulesFrontendIPConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Outbound rule of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusOutboundRules
{
    /// <summary>AllocatedOutboundPorts: The number of outbound ports to be used for NAT.</summary>
    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary>
    /// BackendAddressPool: A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend
    /// IPs.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20201101LoadBalancerStatusOutboundRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>
    /// EnableTcpReset: Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This
    /// element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>FrontendIPConfigurations: The Frontend IP addresses of the load balancer.</summary>
    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20201101LoadBalancerStatusOutboundRulesFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IdleTimeoutInMinutes: The timeout for the TCP idle connection.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of outbound rules used by the load balancer. This name can
    /// be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocol: The protocol for the outbound rule in load balancer.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the outbound rule resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusProbesLoadBalancingRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A load balancer probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusProbes
{
    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IntervalInSeconds: The interval, in seconds, for how frequently to probe the endpoint for health status. Typically, the
    /// interval is slightly less than half the allocated timeout period (in seconds) which allows two full probes before taking
    /// the instance out of rotation. The default value is 15, the minimum value is 5.
    /// </summary>
    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    /// <summary>LoadBalancingRules: The load balancer rules that use this probe.</summary>
    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20201101LoadBalancerStatusProbesLoadBalancingRules>? LoadBalancingRules { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of probes used by the load balancer. This name can be used
    /// to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// NumberOfProbes: The number of probes where if no response, will result in stopping further traffic from being delivered
    /// to the endpoint. This values allows endpoints to be taken out of rotation faster or slower than the typical times used
    /// in Azure.
    /// </summary>
    [JsonPropertyName("numberOfProbes")]
    public int? NumberOfProbes { get; set; }

    /// <summary>Port: The port for communicating the probe. Possible values range from 1 to 65535, inclusive.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>
    /// Protocol: The protocol of the end point. If &apos;Tcp&apos; is specified, a received ACK is required for the probe to be
    /// successful. If &apos;Http&apos; or &apos;Https&apos; is specified, a 200 OK response from the specifies URI is required for the probe to be
    /// successful.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the probe resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RequestPath: The URI used for requesting health status from the VM. Path is required if a protocol is set to http.
    /// Otherwise, it is not allowed. There is no default value.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Sku: The load balancer SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatusSku
{
    /// <summary>Name: Name of a load balancer SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Tier of a load balancer SKU.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>LoadBalancer resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101LoadBalancerStatus
{
    /// <summary>BackendAddressPools: Collection of backend address pools used by a load balancer.</summary>
    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20201101LoadBalancerStatusBackendAddressPools>? BackendAddressPools { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20201101LoadBalancerStatusConditions>? Conditions { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ExtendedLocation: The extended location of the load balancer.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201101LoadBalancerStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FrontendIPConfigurations: Object representing the frontend IPs to be used for the load balancer.</summary>
    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20201101LoadBalancerStatusFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// InboundNatPools: Defines an external port range for inbound NAT to a single backend port on NICs associated with a load
    /// balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external
    /// port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound Nat
    /// rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual
    /// virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules.
    /// </summary>
    [JsonPropertyName("inboundNatPools")]
    public IList<V1api20201101LoadBalancerStatusInboundNatPools>? InboundNatPools { get; set; }

    /// <summary>
    /// InboundNatRules: Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load
    /// balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine
    /// scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to
    /// reference individual inbound NAT rules.
    /// </summary>
    [JsonPropertyName("inboundNatRules")]
    public IList<V1api20201101LoadBalancerStatusInboundNatRules>? InboundNatRules { get; set; }

    /// <summary>LoadBalancingRules: Object collection representing the load balancing rules Gets the provisioning.</summary>
    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20201101LoadBalancerStatusLoadBalancingRules>? LoadBalancingRules { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OutboundRules: The outbound rules.</summary>
    [JsonPropertyName("outboundRules")]
    public IList<V1api20201101LoadBalancerStatusOutboundRules>? OutboundRules { get; set; }

    /// <summary>Probes: Collection of probe objects used in the load balancer.</summary>
    [JsonPropertyName("probes")]
    public IList<V1api20201101LoadBalancerStatusProbes>? Probes { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the load balancer resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceGuid: The resource GUID property of the load balancer resource.</summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>Sku: The load balancer SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20201101LoadBalancerStatusSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2020-11-01/loadBalancer.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201101LoadBalancer : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20201101LoadBalancerSpec?>, IStatus<V1api20201101LoadBalancerStatus?>
{
    public const string KubeApiVersion = "v1api20201101";
    public const string KubeKind = "LoadBalancer";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "loadbalancers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20201101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20201101LoadBalancerSpec? Spec { get; set; }

    /// <summary>LoadBalancer resource.</summary>
    [JsonPropertyName("status")]
    public V1api20201101LoadBalancerStatus? Status { get; set; }
}