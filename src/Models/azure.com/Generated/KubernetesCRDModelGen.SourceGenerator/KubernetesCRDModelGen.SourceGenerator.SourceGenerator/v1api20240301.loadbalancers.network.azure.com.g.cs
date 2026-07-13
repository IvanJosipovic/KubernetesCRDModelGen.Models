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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/loadBalancer.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301LoadBalancerList : IKubernetesObject<V1ListMeta>, IItems<V1api20240301LoadBalancer>
{
    public const string KubeApiVersion = "v1api20240301";
    public const string KubeKind = "LoadBalancerList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "loadbalancers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240301LoadBalancer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240301LoadBalancer> Items { get; set; }
}

/// <summary>
/// AdminState: A list of administrative states which once set can override health probe so that Load Balancer will always
/// forward new connections to backend, or deny new connections and reset existing connections.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesAdminStateEnum>))]
public enum V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesAdminStateEnum
{
    [EnumMember(Value = "Down"), JsonStringEnumMemberName("Down")]
    Down,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Up"), JsonStringEnumMemberName("Up")]
    Up
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfigurationReference
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
public partial class V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnetReference
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
public partial class V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnetReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetworkReference
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
public partial class V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetworkReference? Reference { get; set; }
}

/// <summary>Load balancer backend addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddresses
{
    /// <summary>
    /// AdminState: A list of administrative states which once set can override health probe so that Load Balancer will always
    /// forward new connections to backend, or deny new connections and reset existing connections.
    /// </summary>
    [JsonPropertyName("adminState")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesAdminStateEnum? AdminState { get; set; }

    /// <summary>IpAddress: IP Address belonging to the referenced virtual network.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>LoadBalancerFrontendIPConfiguration: Reference to the frontend ip address configuration defined in regional loadbalancer.</summary>
    [JsonPropertyName("loadBalancerFrontendIPConfiguration")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration? LoadBalancerFrontendIPConfiguration { get; set; }

    /// <summary>Name: Name of the backend address.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Subnet: Reference to an existing subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnet? Subnet { get; set; }

    /// <summary>VirtualNetwork: Reference to an existing virtual network.</summary>
    [JsonPropertyName("virtualNetwork")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork? VirtualNetwork { get; set; }
}

/// <summary>SyncMode: Backend address synchronous mode for the backend pool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecBackendAddressPoolsSyncModeEnum>))]
public enum V1api20240301LoadBalancerSpecBackendAddressPoolsSyncModeEnum
{
    [EnumMember(Value = "Automatic"), JsonStringEnumMemberName("Automatic")]
    Automatic,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual
}

/// <summary>Protocol: Protocol of gateway load balancer tunnel interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecBackendAddressPoolsTunnelInterfacesProtocolEnum>))]
public enum V1api20240301LoadBalancerSpecBackendAddressPoolsTunnelInterfacesProtocolEnum
{
    [EnumMember(Value = "Native"), JsonStringEnumMemberName("Native")]
    Native,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "VXLAN"), JsonStringEnumMemberName("VXLAN")]
    VXLAN
}

/// <summary>Type: Traffic type of gateway load balancer tunnel interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecBackendAddressPoolsTunnelInterfacesTypeEnum>))]
public enum V1api20240301LoadBalancerSpecBackendAddressPoolsTunnelInterfacesTypeEnum
{
    [EnumMember(Value = "External"), JsonStringEnumMemberName("External")]
    External,
    [EnumMember(Value = "Internal"), JsonStringEnumMemberName("Internal")]
    Internal,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Gateway load balancer tunnel interface of a load balancer backend address pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecBackendAddressPoolsTunnelInterfaces
{
    /// <summary>Identifier: Identifier of gateway load balancer tunnel interface.</summary>
    [JsonPropertyName("identifier")]
    public int? Identifier { get; set; }

    /// <summary>Port: Port of gateway load balancer tunnel interface.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Protocol: Protocol of gateway load balancer tunnel interface.</summary>
    [JsonPropertyName("protocol")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsTunnelInterfacesProtocolEnum? Protocol { get; set; }

    /// <summary>Type: Traffic type of gateway load balancer tunnel interface.</summary>
    [JsonPropertyName("type")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsTunnelInterfacesTypeEnum? Type { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecBackendAddressPoolsVirtualNetworkReference
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

/// <summary>VirtualNetwork: A reference to a virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecBackendAddressPoolsVirtualNetwork
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsVirtualNetworkReference? Reference { get; set; }
}

/// <summary>Pool of backend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecBackendAddressPools
{
    /// <summary>DrainPeriodInSeconds: Amount of seconds Load Balancer waits for before sending RESET to client and backend address.</summary>
    [JsonPropertyName("drainPeriodInSeconds")]
    public int? DrainPeriodInSeconds { get; set; }

    /// <summary>LoadBalancerBackendAddresses: An array of backend addresses.</summary>
    [JsonPropertyName("loadBalancerBackendAddresses")]
    public IList<V1api20240301LoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddresses>? LoadBalancerBackendAddresses { get; set; }

    /// <summary>Location: The location of the backend address pool.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of backend address pools used by the load balancer. This
    /// name can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SyncMode: Backend address synchronous mode for the backend pool</summary>
    [JsonPropertyName("syncMode")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsSyncModeEnum? SyncMode { get; set; }

    /// <summary>TunnelInterfaces: An array of gateway load balancer tunnel interfaces.</summary>
    [JsonPropertyName("tunnelInterfaces")]
    public IList<V1api20240301LoadBalancerSpecBackendAddressPoolsTunnelInterfaces>? TunnelInterfaces { get; set; }

    /// <summary>VirtualNetwork: A reference to a virtual network.</summary>
    [JsonPropertyName("virtualNetwork")]
    public V1api20240301LoadBalancerSpecBackendAddressPoolsVirtualNetwork? VirtualNetwork { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecExtendedLocationTypeEnum>))]
public enum V1api20240301LoadBalancerSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V1api20240301LoadBalancerSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecFrontendIPConfigurationsGatewayLoadBalancerReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecFrontendIPConfigurationsGatewayLoadBalancer
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecFrontendIPConfigurationsGatewayLoadBalancerReference? Reference { get; set; }
}

/// <summary>PrivateIPAddressVersion: Whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecFrontendIPConfigurationsPrivateIPAddressVersionEnum>))]
public enum V1api20240301LoadBalancerSpecFrontendIPConfigurationsPrivateIPAddressVersionEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>PrivateIPAllocationMethod: The Private IP allocation method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecFrontendIPConfigurationsPrivateIPAllocationMethodEnum>))]
public enum V1api20240301LoadBalancerSpecFrontendIPConfigurationsPrivateIPAllocationMethodEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic,
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecFrontendIPConfigurationsPublicIPAddressReference
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
public partial class V1api20240301LoadBalancerSpecFrontendIPConfigurationsPublicIPAddress
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecFrontendIPConfigurationsPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecFrontendIPConfigurationsPublicIPPrefixReference
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
public partial class V1api20240301LoadBalancerSpecFrontendIPConfigurationsPublicIPPrefix
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecFrontendIPConfigurationsPublicIPPrefixReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecFrontendIPConfigurationsSubnetReference
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
public partial class V1api20240301LoadBalancerSpecFrontendIPConfigurationsSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecFrontendIPConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>Frontend IP address of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecFrontendIPConfigurations
{
    /// <summary>GatewayLoadBalancer: The reference to gateway load balancer frontend IP.</summary>
    [JsonPropertyName("gatewayLoadBalancer")]
    public V1api20240301LoadBalancerSpecFrontendIPConfigurationsGatewayLoadBalancer? GatewayLoadBalancer { get; set; }

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
    public V1api20240301LoadBalancerSpecFrontendIPConfigurationsPrivateIPAddressVersionEnum? PrivateIPAddressVersion { get; set; }

    /// <summary>PrivateIPAllocationMethod: The Private IP allocation method.</summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public V1api20240301LoadBalancerSpecFrontendIPConfigurationsPrivateIPAllocationMethodEnum? PrivateIPAllocationMethod { get; set; }

    /// <summary>PublicIPAddress: The reference to the Public IP resource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20240301LoadBalancerSpecFrontendIPConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>PublicIPPrefix: The reference to the Public IP Prefix resource.</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20240301LoadBalancerSpecFrontendIPConfigurationsPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Subnet: The reference to the subnet resource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240301LoadBalancerSpecFrontendIPConfigurationsSubnet? Subnet { get; set; }

    /// <summary>Zones: A list of availability zones denoting the IP allocated for the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecInboundNatPoolsFrontendIPConfigurationReference
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
public partial class V1api20240301LoadBalancerSpecInboundNatPoolsFrontendIPConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecInboundNatPoolsFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>Protocol: The reference to the transport protocol used by the inbound NAT pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecInboundNatPoolsProtocolEnum>))]
public enum V1api20240301LoadBalancerSpecInboundNatPoolsProtocolEnum
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
public partial class V1api20240301LoadBalancerSpecInboundNatPools
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
    public V1api20240301LoadBalancerSpecInboundNatPoolsFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

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
    public required V1api20240301LoadBalancerSpecInboundNatPoolsProtocolEnum Protocol { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecInboundNatRulesBackendAddressPoolReference
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

/// <summary>BackendAddressPool: A reference to backendAddressPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecInboundNatRulesBackendAddressPool
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecInboundNatRulesBackendAddressPoolReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecInboundNatRulesFrontendIPConfigurationReference
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
public partial class V1api20240301LoadBalancerSpecInboundNatRulesFrontendIPConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecInboundNatRulesFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>Protocol: The reference to the transport protocol used by the load balancing rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecInboundNatRulesProtocolEnum>))]
public enum V1api20240301LoadBalancerSpecInboundNatRulesProtocolEnum
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
public partial class V1api20240301LoadBalancerSpecInboundNatRules
{
    /// <summary>BackendAddressPool: A reference to backendAddressPool resource.</summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20240301LoadBalancerSpecInboundNatRulesBackendAddressPool? BackendAddressPool { get; set; }

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
    public V1api20240301LoadBalancerSpecInboundNatRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>
    /// FrontendPort: The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer.
    /// Acceptable values range from 1 to 65534.
    /// </summary>
    [JsonPropertyName("frontendPort")]
    public int? FrontendPort { get; set; }

    /// <summary>
    /// FrontendPortRangeEnd: The port range end for the external endpoint. This property is used together with
    /// BackendAddressPool and FrontendPortRangeStart. Individual inbound NAT rule port mappings will be created for each
    /// backend address from BackendAddressPool. Acceptable values range from 1 to 65534.
    /// </summary>
    [JsonPropertyName("frontendPortRangeEnd")]
    public int? FrontendPortRangeEnd { get; set; }

    /// <summary>
    /// FrontendPortRangeStart: The port range start for the external endpoint. This property is used together with
    /// BackendAddressPool and FrontendPortRangeEnd. Individual inbound NAT rule port mappings will be created for each backend
    /// address from BackendAddressPool. Acceptable values range from 1 to 65534.
    /// </summary>
    [JsonPropertyName("frontendPortRangeStart")]
    public int? FrontendPortRangeStart { get; set; }

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
    public V1api20240301LoadBalancerSpecInboundNatRulesProtocolEnum? Protocol { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecLoadBalancingRulesBackendAddressPoolReference
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
public partial class V1api20240301LoadBalancerSpecLoadBalancingRulesBackendAddressPool
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecLoadBalancingRulesBackendAddressPoolReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecLoadBalancingRulesBackendAddressPoolsReference
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
public partial class V1api20240301LoadBalancerSpecLoadBalancingRulesBackendAddressPools
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecLoadBalancingRulesBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecLoadBalancingRulesFrontendIPConfigurationReference
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
public partial class V1api20240301LoadBalancerSpecLoadBalancingRulesFrontendIPConfiguration
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecLoadBalancingRulesFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>LoadDistribution: The load distribution policy for this rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecLoadBalancingRulesLoadDistributionEnum>))]
public enum V1api20240301LoadBalancerSpecLoadBalancingRulesLoadDistributionEnum
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
public partial class V1api20240301LoadBalancerSpecLoadBalancingRulesProbeReference
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
public partial class V1api20240301LoadBalancerSpecLoadBalancingRulesProbe
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecLoadBalancingRulesProbeReference? Reference { get; set; }
}

/// <summary>Protocol: The reference to the transport protocol used by the load balancing rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecLoadBalancingRulesProtocolEnum>))]
public enum V1api20240301LoadBalancerSpecLoadBalancingRulesProtocolEnum
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
public partial class V1api20240301LoadBalancerSpecLoadBalancingRules
{
    /// <summary>
    /// BackendAddressPool: A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend
    /// IPs.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20240301LoadBalancerSpecLoadBalancingRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>BackendAddressPools: An array of references to pool of DIPs.</summary>
    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20240301LoadBalancerSpecLoadBalancingRulesBackendAddressPools>? BackendAddressPools { get; set; }

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
    public V1api20240301LoadBalancerSpecLoadBalancingRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

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
    public V1api20240301LoadBalancerSpecLoadBalancingRulesLoadDistributionEnum? LoadDistribution { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of load balancing rules used by the load balancer. This
    /// name can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Probe: The reference to the load balancer probe used by the load balancing rule.</summary>
    [JsonPropertyName("probe")]
    public V1api20240301LoadBalancerSpecLoadBalancingRulesProbe? Probe { get; set; }

    /// <summary>Protocol: The reference to the transport protocol used by the load balancing rule.</summary>
    [JsonPropertyName("protocol")]
    public required V1api20240301LoadBalancerSpecLoadBalancingRulesProtocolEnum Protocol { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240301LoadBalancerSpecOperatorSpecSecretExpressions
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
public partial class V1api20240301LoadBalancerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301LoadBalancerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301LoadBalancerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecOutboundRulesBackendAddressPoolReference
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
public partial class V1api20240301LoadBalancerSpecOutboundRulesBackendAddressPool
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecOutboundRulesBackendAddressPoolReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecOutboundRulesFrontendIPConfigurationsReference
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
public partial class V1api20240301LoadBalancerSpecOutboundRulesFrontendIPConfigurations
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301LoadBalancerSpecOutboundRulesFrontendIPConfigurationsReference? Reference { get; set; }
}

/// <summary>Protocol: The protocol for the outbound rule in load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecOutboundRulesProtocolEnum>))]
public enum V1api20240301LoadBalancerSpecOutboundRulesProtocolEnum
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
public partial class V1api20240301LoadBalancerSpecOutboundRules
{
    /// <summary>AllocatedOutboundPorts: The number of outbound ports to be used for NAT.</summary>
    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary>
    /// BackendAddressPool: A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend
    /// IPs.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public required V1api20240301LoadBalancerSpecOutboundRulesBackendAddressPool BackendAddressPool { get; set; }

    /// <summary>
    /// EnableTcpReset: Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This
    /// element is only used when the protocol is set to TCP.
    /// </summary>
    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>FrontendIPConfigurations: The Frontend IP addresses of the load balancer.</summary>
    [JsonPropertyName("frontendIPConfigurations")]
    public required IList<V1api20240301LoadBalancerSpecOutboundRulesFrontendIPConfigurations> FrontendIPConfigurations { get; set; }

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
    public required V1api20240301LoadBalancerSpecOutboundRulesProtocolEnum Protocol { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// NoHealthyBackendsBehavior: Determines how new connections are handled by the load balancer when all backend instances
/// are probed down.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecProbesNoHealthyBackendsBehaviorEnum>))]
public enum V1api20240301LoadBalancerSpecProbesNoHealthyBackendsBehaviorEnum
{
    [EnumMember(Value = "AllProbedDown"), JsonStringEnumMemberName("AllProbedDown")]
    AllProbedDown,
    [EnumMember(Value = "AllProbedUp"), JsonStringEnumMemberName("AllProbedUp")]
    AllProbedUp
}

/// <summary>
/// Protocol: The protocol of the end point. If &apos;Tcp&apos; is specified, a received ACK is required for the probe to be
/// successful. If &apos;Http&apos; or &apos;Https&apos; is specified, a 200 OK response from the specifies URI is required for the probe to be
/// successful.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecProbesProtocolEnum>))]
public enum V1api20240301LoadBalancerSpecProbesProtocolEnum
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
public partial class V1api20240301LoadBalancerSpecProbes
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
    /// NoHealthyBackendsBehavior: Determines how new connections are handled by the load balancer when all backend instances
    /// are probed down.
    /// </summary>
    [JsonPropertyName("noHealthyBackendsBehavior")]
    public V1api20240301LoadBalancerSpecProbesNoHealthyBackendsBehaviorEnum? NoHealthyBackendsBehavior { get; set; }

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
    /// ProbeThreshold: The number of consecutive successful or failed probes in order to allow or deny traffic from being
    /// delivered to this endpoint. After failing the number of consecutive probes equal to this value, the endpoint will be
    /// taken out of rotation and require the same number of successful consecutive probes to be placed back in rotation.
    /// </summary>
    [JsonPropertyName("probeThreshold")]
    public int? ProbeThreshold { get; set; }

    /// <summary>
    /// Protocol: The protocol of the end point. If &apos;Tcp&apos; is specified, a received ACK is required for the probe to be
    /// successful. If &apos;Http&apos; or &apos;Https&apos; is specified, a 200 OK response from the specifies URI is required for the probe to be
    /// successful.
    /// </summary>
    [JsonPropertyName("protocol")]
    public required V1api20240301LoadBalancerSpecProbesProtocolEnum Protocol { get; set; }

    /// <summary>
    /// RequestPath: The URI used for requesting health status from the VM. Path is required if a protocol is set to http.
    /// Otherwise, it is not allowed. There is no default value.
    /// </summary>
    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }
}

/// <summary>Name: Name of a load balancer SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecSkuNameEnum>))]
public enum V1api20240301LoadBalancerSpecSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Gateway"), JsonStringEnumMemberName("Gateway")]
    Gateway,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Tier: Tier of a load balancer SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301LoadBalancerSpecSkuTierEnum>))]
public enum V1api20240301LoadBalancerSpecSkuTierEnum
{
    [EnumMember(Value = "Global"), JsonStringEnumMemberName("Global")]
    Global,
    [EnumMember(Value = "Regional"), JsonStringEnumMemberName("Regional")]
    Regional
}

/// <summary>Sku: The load balancer SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpecSku
{
    /// <summary>Name: Name of a load balancer SKU.</summary>
    [JsonPropertyName("name")]
    public V1api20240301LoadBalancerSpecSkuNameEnum? Name { get; set; }

    /// <summary>Tier: Tier of a load balancer SKU.</summary>
    [JsonPropertyName("tier")]
    public V1api20240301LoadBalancerSpecSkuTierEnum? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>BackendAddressPools: Collection of backend address pools used by a load balancer.</summary>
    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20240301LoadBalancerSpecBackendAddressPools>? BackendAddressPools { get; set; }

    /// <summary>ExtendedLocation: The extended location of the load balancer.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240301LoadBalancerSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FrontendIPConfigurations: Object representing the frontend IPs to be used for the load balancer.</summary>
    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20240301LoadBalancerSpecFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    /// <summary>
    /// InboundNatPools: Defines an external port range for inbound NAT to a single backend port on NICs associated with a load
    /// balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external
    /// port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound NAT
    /// rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual
    /// virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules.
    /// </summary>
    [JsonPropertyName("inboundNatPools")]
    public IList<V1api20240301LoadBalancerSpecInboundNatPools>? InboundNatPools { get; set; }

    /// <summary>
    /// InboundNatRules: Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load
    /// balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine
    /// scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to
    /// reference individual inbound NAT rules.
    /// </summary>
    [JsonPropertyName("inboundNatRules")]
    public IList<V1api20240301LoadBalancerSpecInboundNatRules>? InboundNatRules { get; set; }

    /// <summary>LoadBalancingRules: Object collection representing the load balancing rules Gets the provisioning.</summary>
    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20240301LoadBalancerSpecLoadBalancingRules>? LoadBalancingRules { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301LoadBalancerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>OutboundRules: The outbound rules.</summary>
    [JsonPropertyName("outboundRules")]
    public IList<V1api20240301LoadBalancerSpecOutboundRules>? OutboundRules { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240301LoadBalancerSpecOwner Owner { get; set; }

    /// <summary>Probes: Collection of probe objects used in the load balancer.</summary>
    [JsonPropertyName("probes")]
    public IList<V1api20240301LoadBalancerSpecProbes>? Probes { get; set; }

    /// <summary>Sku: The load balancer SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20240301LoadBalancerSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>IPConfiguration in a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsBackendIPConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsInboundNatRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Individual port mappings for inbound NAT rule created for backend pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesInboundNatRulesPortMapping
{
    /// <summary>BackendPort: Backend port.</summary>
    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    /// <summary>FrontendPort: Frontend port.</summary>
    [JsonPropertyName("frontendPort")]
    public int? FrontendPort { get; set; }

    /// <summary>InboundNatRuleName: Name of inbound NAT rule.</summary>
    [JsonPropertyName("inboundNatRuleName")]
    public string? InboundNatRuleName { get; set; }
}

/// <summary>LoadBalancerFrontendIPConfiguration: Reference to the frontend ip address configuration defined in regional loadbalancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>NetworkInterfaceIPConfiguration: Reference to IP address defined in network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesNetworkInterfaceIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Subnet: Reference to an existing subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesSubnet
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>VirtualNetwork: Reference to an existing virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Load balancer backend addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddresses
{
    /// <summary>
    /// AdminState: A list of administrative states which once set can override health probe so that Load Balancer will always
    /// forward new connections to backend, or deny new connections and reset existing connections.
    /// </summary>
    [JsonPropertyName("adminState")]
    public string? AdminState { get; set; }

    /// <summary>InboundNatRulesPortMapping: Collection of inbound NAT rule port mappings.</summary>
    [JsonPropertyName("inboundNatRulesPortMapping")]
    public IList<V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesInboundNatRulesPortMapping>? InboundNatRulesPortMapping { get; set; }

    /// <summary>IpAddress: IP Address belonging to the referenced virtual network.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>LoadBalancerFrontendIPConfiguration: Reference to the frontend ip address configuration defined in regional loadbalancer.</summary>
    [JsonPropertyName("loadBalancerFrontendIPConfiguration")]
    public V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration? LoadBalancerFrontendIPConfiguration { get; set; }

    /// <summary>Name: Name of the backend address.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkInterfaceIPConfiguration: Reference to IP address defined in network interfaces.</summary>
    [JsonPropertyName("networkInterfaceIPConfiguration")]
    public V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesNetworkInterfaceIPConfiguration? NetworkInterfaceIPConfiguration { get; set; }

    /// <summary>Subnet: Reference to an existing subnet.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesSubnet? Subnet { get; set; }

    /// <summary>VirtualNetwork: Reference to an existing virtual network.</summary>
    [JsonPropertyName("virtualNetwork")]
    public V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork? VirtualNetwork { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancingRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>OutboundRule: A reference to an outbound rule that uses this backend address pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsOutboundRule
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsOutboundRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Gateway load balancer tunnel interface of a load balancer backend address pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsTunnelInterfaces
{
    /// <summary>Identifier: Identifier of gateway load balancer tunnel interface.</summary>
    [JsonPropertyName("identifier")]
    public int? Identifier { get; set; }

    /// <summary>Port: Port of gateway load balancer tunnel interface.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Protocol: Protocol of gateway load balancer tunnel interface.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Type: Traffic type of gateway load balancer tunnel interface.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>VirtualNetwork: A reference to a virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPoolsVirtualNetwork
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Pool of backend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusBackendAddressPools
{
    /// <summary>BackendIPConfigurations: An array of references to IP addresses defined in network interfaces.</summary>
    [JsonPropertyName("backendIPConfigurations")]
    public IList<V1api20240301LoadBalancerStatusBackendAddressPoolsBackendIPConfigurations>? BackendIPConfigurations { get; set; }

    /// <summary>DrainPeriodInSeconds: Amount of seconds Load Balancer waits for before sending RESET to client and backend address.</summary>
    [JsonPropertyName("drainPeriodInSeconds")]
    public int? DrainPeriodInSeconds { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>InboundNatRules: An array of references to inbound NAT rules that use this backend address pool.</summary>
    [JsonPropertyName("inboundNatRules")]
    public IList<V1api20240301LoadBalancerStatusBackendAddressPoolsInboundNatRules>? InboundNatRules { get; set; }

    /// <summary>LoadBalancerBackendAddresses: An array of backend addresses.</summary>
    [JsonPropertyName("loadBalancerBackendAddresses")]
    public IList<V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddresses>? LoadBalancerBackendAddresses { get; set; }

    /// <summary>LoadBalancingRules: An array of references to load balancing rules that use this backend address pool.</summary>
    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20240301LoadBalancerStatusBackendAddressPoolsLoadBalancingRules>? LoadBalancingRules { get; set; }

    /// <summary>Location: The location of the backend address pool.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of backend address pools used by the load balancer. This
    /// name can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OutboundRule: A reference to an outbound rule that uses this backend address pool.</summary>
    [JsonPropertyName("outboundRule")]
    public V1api20240301LoadBalancerStatusBackendAddressPoolsOutboundRule? OutboundRule { get; set; }

    /// <summary>OutboundRules: An array of references to outbound rules that use this backend address pool.</summary>
    [JsonPropertyName("outboundRules")]
    public IList<V1api20240301LoadBalancerStatusBackendAddressPoolsOutboundRules>? OutboundRules { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the backend address pool resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>SyncMode: Backend address synchronous mode for the backend pool</summary>
    [JsonPropertyName("syncMode")]
    public string? SyncMode { get; set; }

    /// <summary>TunnelInterfaces: An array of gateway load balancer tunnel interfaces.</summary>
    [JsonPropertyName("tunnelInterfaces")]
    public IList<V1api20240301LoadBalancerStatusBackendAddressPoolsTunnelInterfaces>? TunnelInterfaces { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VirtualNetwork: A reference to a virtual network.</summary>
    [JsonPropertyName("virtualNetwork")]
    public V1api20240301LoadBalancerStatusBackendAddressPoolsVirtualNetwork? VirtualNetwork { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusConditions
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
public partial class V1api20240301LoadBalancerStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>GatewayLoadBalancer: The reference to gateway load balancer frontend IP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusFrontendIPConfigurationsGatewayLoadBalancer
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusFrontendIPConfigurationsInboundNatPools
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusFrontendIPConfigurationsInboundNatRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusFrontendIPConfigurationsLoadBalancingRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusFrontendIPConfigurationsOutboundRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PublicIPAddress: The reference to the Public IP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusFrontendIPConfigurationsPublicIPAddress
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PublicIPPrefix: The reference to the Public IP Prefix resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusFrontendIPConfigurationsPublicIPPrefix
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Subnet: The reference to the subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusFrontendIPConfigurationsSubnet
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Frontend IP address of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusFrontendIPConfigurations
{
    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>GatewayLoadBalancer: The reference to gateway load balancer frontend IP.</summary>
    [JsonPropertyName("gatewayLoadBalancer")]
    public V1api20240301LoadBalancerStatusFrontendIPConfigurationsGatewayLoadBalancer? GatewayLoadBalancer { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>InboundNatPools: An array of references to inbound pools that use this frontend IP.</summary>
    [JsonPropertyName("inboundNatPools")]
    public IList<V1api20240301LoadBalancerStatusFrontendIPConfigurationsInboundNatPools>? InboundNatPools { get; set; }

    /// <summary>InboundNatRules: An array of references to inbound rules that use this frontend IP.</summary>
    [JsonPropertyName("inboundNatRules")]
    public IList<V1api20240301LoadBalancerStatusFrontendIPConfigurationsInboundNatRules>? InboundNatRules { get; set; }

    /// <summary>LoadBalancingRules: An array of references to load balancing rules that use this frontend IP.</summary>
    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20240301LoadBalancerStatusFrontendIPConfigurationsLoadBalancingRules>? LoadBalancingRules { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of frontend IP configurations used by the load balancer.
    /// This name can be used to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OutboundRules: An array of references to outbound rules that use this frontend IP.</summary>
    [JsonPropertyName("outboundRules")]
    public IList<V1api20240301LoadBalancerStatusFrontendIPConfigurationsOutboundRules>? OutboundRules { get; set; }

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
    public V1api20240301LoadBalancerStatusFrontendIPConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>PublicIPPrefix: The reference to the Public IP Prefix resource.</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20240301LoadBalancerStatusFrontendIPConfigurationsPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Subnet: The reference to the subnet resource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240301LoadBalancerStatusFrontendIPConfigurationsSubnet? Subnet { get; set; }

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
public partial class V1api20240301LoadBalancerStatusInboundNatPoolsFrontendIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Inbound NAT pool of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusInboundNatPools
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
    public V1api20240301LoadBalancerStatusInboundNatPoolsFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

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

/// <summary>BackendAddressPool: A reference to backendAddressPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusInboundNatRulesBackendAddressPool
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// BackendIPConfiguration: A reference to a private IP address defined on a network interface of a VM. Traffic sent to the
/// frontend port of each of the frontend IP configurations is forwarded to the backend IP.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusInboundNatRulesBackendIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusInboundNatRulesFrontendIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Inbound NAT rule of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusInboundNatRules
{
    /// <summary>BackendAddressPool: A reference to backendAddressPool resource.</summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20240301LoadBalancerStatusInboundNatRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>
    /// BackendIPConfiguration: A reference to a private IP address defined on a network interface of a VM. Traffic sent to the
    /// frontend port of each of the frontend IP configurations is forwarded to the backend IP.
    /// </summary>
    [JsonPropertyName("backendIPConfiguration")]
    public V1api20240301LoadBalancerStatusInboundNatRulesBackendIPConfiguration? BackendIPConfiguration { get; set; }

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
    public V1api20240301LoadBalancerStatusInboundNatRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    /// <summary>
    /// FrontendPort: The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer.
    /// Acceptable values range from 1 to 65534.
    /// </summary>
    [JsonPropertyName("frontendPort")]
    public int? FrontendPort { get; set; }

    /// <summary>
    /// FrontendPortRangeEnd: The port range end for the external endpoint. This property is used together with
    /// BackendAddressPool and FrontendPortRangeStart. Individual inbound NAT rule port mappings will be created for each
    /// backend address from BackendAddressPool. Acceptable values range from 1 to 65534.
    /// </summary>
    [JsonPropertyName("frontendPortRangeEnd")]
    public int? FrontendPortRangeEnd { get; set; }

    /// <summary>
    /// FrontendPortRangeStart: The port range start for the external endpoint. This property is used together with
    /// BackendAddressPool and FrontendPortRangeEnd. Individual inbound NAT rule port mappings will be created for each backend
    /// address from BackendAddressPool. Acceptable values range from 1 to 65534.
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
public partial class V1api20240301LoadBalancerStatusLoadBalancingRulesBackendAddressPool
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusLoadBalancingRulesBackendAddressPools
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>FrontendIPConfiguration: A reference to frontend IP addresses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusLoadBalancingRulesFrontendIPConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Probe: The reference to the load balancer probe used by the load balancing rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusLoadBalancingRulesProbe
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A load balancing rule for a load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusLoadBalancingRules
{
    /// <summary>
    /// BackendAddressPool: A reference to a pool of DIPs. Inbound traffic is randomly load balanced across IPs in the backend
    /// IPs.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20240301LoadBalancerStatusLoadBalancingRulesBackendAddressPool? BackendAddressPool { get; set; }

    /// <summary>BackendAddressPools: An array of references to pool of DIPs.</summary>
    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20240301LoadBalancerStatusLoadBalancingRulesBackendAddressPools>? BackendAddressPools { get; set; }

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
    public V1api20240301LoadBalancerStatusLoadBalancingRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

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
    public V1api20240301LoadBalancerStatusLoadBalancingRulesProbe? Probe { get; set; }

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
public partial class V1api20240301LoadBalancerStatusOutboundRulesBackendAddressPool
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusOutboundRulesFrontendIPConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Outbound rule of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusOutboundRules
{
    /// <summary>AllocatedOutboundPorts: The number of outbound ports to be used for NAT.</summary>
    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary>
    /// BackendAddressPool: A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend
    /// IPs.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20240301LoadBalancerStatusOutboundRulesBackendAddressPool? BackendAddressPool { get; set; }

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
    public IList<V1api20240301LoadBalancerStatusOutboundRulesFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

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
public partial class V1api20240301LoadBalancerStatusProbesLoadBalancingRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>A load balancer probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301LoadBalancerStatusProbes
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
    public IList<V1api20240301LoadBalancerStatusProbesLoadBalancingRules>? LoadBalancingRules { get; set; }

    /// <summary>
    /// Name: The name of the resource that is unique within the set of probes used by the load balancer. This name can be used
    /// to access the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// NoHealthyBackendsBehavior: Determines how new connections are handled by the load balancer when all backend instances
    /// are probed down.
    /// </summary>
    [JsonPropertyName("noHealthyBackendsBehavior")]
    public string? NoHealthyBackendsBehavior { get; set; }

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
    /// ProbeThreshold: The number of consecutive successful or failed probes in order to allow or deny traffic from being
    /// delivered to this endpoint. After failing the number of consecutive probes equal to this value, the endpoint will be
    /// taken out of rotation and require the same number of successful consecutive probes to be placed back in rotation.
    /// </summary>
    [JsonPropertyName("probeThreshold")]
    public int? ProbeThreshold { get; set; }

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
public partial class V1api20240301LoadBalancerStatusSku
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
public partial class V1api20240301LoadBalancerStatus
{
    /// <summary>BackendAddressPools: Collection of backend address pools used by a load balancer.</summary>
    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20240301LoadBalancerStatusBackendAddressPools>? BackendAddressPools { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240301LoadBalancerStatusConditions>? Conditions { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ExtendedLocation: The extended location of the load balancer.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240301LoadBalancerStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FrontendIPConfigurations: Object representing the frontend IPs to be used for the load balancer.</summary>
    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20240301LoadBalancerStatusFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// InboundNatPools: Defines an external port range for inbound NAT to a single backend port on NICs associated with a load
    /// balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external
    /// port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound NAT
    /// rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual
    /// virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules.
    /// </summary>
    [JsonPropertyName("inboundNatPools")]
    public IList<V1api20240301LoadBalancerStatusInboundNatPools>? InboundNatPools { get; set; }

    /// <summary>
    /// InboundNatRules: Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load
    /// balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine
    /// scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to
    /// reference individual inbound NAT rules.
    /// </summary>
    [JsonPropertyName("inboundNatRules")]
    public IList<V1api20240301LoadBalancerStatusInboundNatRules>? InboundNatRules { get; set; }

    /// <summary>LoadBalancingRules: Object collection representing the load balancing rules Gets the provisioning.</summary>
    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20240301LoadBalancerStatusLoadBalancingRules>? LoadBalancingRules { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OutboundRules: The outbound rules.</summary>
    [JsonPropertyName("outboundRules")]
    public IList<V1api20240301LoadBalancerStatusOutboundRules>? OutboundRules { get; set; }

    /// <summary>Probes: Collection of probe objects used in the load balancer.</summary>
    [JsonPropertyName("probes")]
    public IList<V1api20240301LoadBalancerStatusProbes>? Probes { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the load balancer resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceGuid: The resource GUID property of the load balancer resource.</summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>Sku: The load balancer SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20240301LoadBalancerStatusSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/loadBalancer.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301LoadBalancer : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301LoadBalancerSpec?>, IStatus<V1api20240301LoadBalancerStatus?>
{
    public const string KubeApiVersion = "v1api20240301";
    public const string KubeKind = "LoadBalancer";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "loadbalancers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240301LoadBalancerSpec? Spec { get; set; }

    /// <summary>LoadBalancer resource.</summary>
    [JsonPropertyName("status")]
    public V1api20240301LoadBalancerStatus? Status { get; set; }
}