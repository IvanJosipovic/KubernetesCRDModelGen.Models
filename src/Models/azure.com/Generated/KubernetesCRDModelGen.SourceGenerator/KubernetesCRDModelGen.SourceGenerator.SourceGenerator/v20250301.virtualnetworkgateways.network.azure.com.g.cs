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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/virtualNetworkGateway.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301VirtualNetworkGatewayList : IKubernetesObject<V1ListMeta>, IItems<V20250301VirtualNetworkGateway>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "VirtualNetworkGatewayList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworkgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworkGatewayList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250301VirtualNetworkGateway objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250301VirtualNetworkGateway> Items { get; set; }
}

/// <summary>
/// AdminState: Property to indicate if the Express Route Gateway serves traffic when there are multiple Express Route
/// Gateways in the vnet
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecAdminStateEnum>))]
public enum V20250301VirtualNetworkGatewaySpecAdminStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Bounds: The bounds of the autoscale configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecAutoScaleConfigurationBounds
{
    /// <summary>Max: Maximum Scale Units for Autoscale configuration</summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary>Min: Minimum scale Units for Autoscale configuration</summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>AutoScaleConfiguration: Autoscale configuration for virutal network gateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecAutoScaleConfiguration
{
    /// <summary>Bounds: The bounds of the autoscale configuration</summary>
    [JsonPropertyName("bounds")]
    public V20250301VirtualNetworkGatewaySpecAutoScaleConfigurationBounds? Bounds { get; set; }
}

/// <summary>Properties of IPConfigurationBgpPeeringAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecBgpSettingsBgpPeeringAddresses
{
    /// <summary>CustomBgpIpAddresses: The list of custom BGP peering addresses which belong to IP configuration.</summary>
    [JsonPropertyName("customBgpIpAddresses")]
    public IList<string>? CustomBgpIpAddresses { get; set; }

    /// <summary>IpconfigurationId: The ID of IP configuration which belongs to gateway.</summary>
    [JsonPropertyName("ipconfigurationId")]
    public string? IpconfigurationId { get; set; }
}

/// <summary>BgpSettings: Virtual network gateway&apos;s BGP speaker settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecBgpSettings
{
    /// <summary>Asn: The BGP speaker&apos;s ASN.</summary>
    [JsonPropertyName("asn")]
    public int? Asn { get; set; }

    /// <summary>BgpPeeringAddress: The BGP peering address and BGP identifier of this BGP speaker.</summary>
    [JsonPropertyName("bgpPeeringAddress")]
    public string? BgpPeeringAddress { get; set; }

    /// <summary>BgpPeeringAddresses: BGP peering address with IP configuration ID for virtual network gateway.</summary>
    [JsonPropertyName("bgpPeeringAddresses")]
    public IList<V20250301VirtualNetworkGatewaySpecBgpSettingsBgpPeeringAddresses>? BgpPeeringAddresses { get; set; }

    /// <summary>PeerWeight: The weight added to routes learned from this BGP speaker.</summary>
    [JsonPropertyName("peerWeight")]
    public int? PeerWeight { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecCustomRoutesIpamPoolPrefixAllocationsReference
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

/// <summary>IpamPool prefix allocation reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecCustomRoutesIpamPoolPrefixAllocations
{
    /// <summary>NumberOfIpAddresses: Number of IP addresses to allocate.</summary>
    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }

    /// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworkGatewaySpecCustomRoutesIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>
/// CustomRoutes: The reference to the address space resource which represents the custom routes address space specified by
/// the customer for virtual network gateway and VpnClient.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecCustomRoutes
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworkGatewaySpecCustomRoutesIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecExtendedLocationTypeEnum>))]
public enum V20250301VirtualNetworkGatewaySpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V20250301VirtualNetworkGatewaySpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecGatewayDefaultSiteReference
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
/// GatewayDefaultSite: The reference to the LocalNetworkGateway resource which represents local network site having default
/// routes. Assign Null value in case of removing existing default site setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecGatewayDefaultSite
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworkGatewaySpecGatewayDefaultSiteReference? Reference { get; set; }
}

/// <summary>GatewayType: The type of this virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecGatewayTypeEnum>))]
public enum V20250301VirtualNetworkGatewaySpecGatewayTypeEnum
{
    [EnumMember(Value = "ExpressRoute"), JsonStringEnumMemberName("ExpressRoute")]
    ExpressRoute,
    [EnumMember(Value = "LocalGateway"), JsonStringEnumMemberName("LocalGateway")]
    LocalGateway,
    [EnumMember(Value = "Vpn"), JsonStringEnumMemberName("Vpn")]
    Vpn
}

/// <summary>
/// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
/// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
/// machine.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecIdentityTypeEnum>))]
public enum V20250301VirtualNetworkGatewaySpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned, UserAssigned"), JsonStringEnumMemberName("SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworkGatewaySpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the virtual network gateway, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
    /// machine.
    /// </summary>
    [JsonPropertyName("type")]
    public V20250301VirtualNetworkGatewaySpecIdentityTypeEnum? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250301VirtualNetworkGatewaySpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>PrivateIPAllocationMethod: The private IP address allocation method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecIpConfigurationsPrivateIPAllocationMethodEnum>))]
public enum V20250301VirtualNetworkGatewaySpecIpConfigurationsPrivateIPAllocationMethodEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic,
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecIpConfigurationsPublicIPAddressReference
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

/// <summary>PublicIPAddress: The reference to the public IP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecIpConfigurationsPublicIPAddress
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworkGatewaySpecIpConfigurationsPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecIpConfigurationsSubnetReference
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
public partial class V20250301VirtualNetworkGatewaySpecIpConfigurationsSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworkGatewaySpecIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>IP configuration for virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecIpConfigurations
{
    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateIPAllocationMethod: The private IP address allocation method.</summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public V20250301VirtualNetworkGatewaySpecIpConfigurationsPrivateIPAllocationMethodEnum? PrivateIPAllocationMethod { get; set; }

    /// <summary>PublicIPAddress: The reference to the public IP resource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V20250301VirtualNetworkGatewaySpecIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Subnet: The reference to the subnet resource.</summary>
    [JsonPropertyName("subnet")]
    public V20250301VirtualNetworkGatewaySpecIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Vpn NatRule mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecNatRulesExternalMappings
{
    /// <summary>AddressSpace: Address space for Vpn NatRule mapping.</summary>
    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    /// <summary>PortRange: Port range for Vpn NatRule mapping.</summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>Vpn NatRule mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecNatRulesInternalMappings
{
    /// <summary>AddressSpace: Address space for Vpn NatRule mapping.</summary>
    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    /// <summary>PortRange: Port range for Vpn NatRule mapping.</summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>Mode: The Source NAT direction of a VPN NAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecNatRulesModeEnum>))]
public enum V20250301VirtualNetworkGatewaySpecNatRulesModeEnum
{
    [EnumMember(Value = "EgressSnat"), JsonStringEnumMemberName("EgressSnat")]
    EgressSnat,
    [EnumMember(Value = "IngressSnat"), JsonStringEnumMemberName("IngressSnat")]
    IngressSnat
}

/// <summary>Type: The type of NAT rule for VPN NAT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecNatRulesTypeEnum>))]
public enum V20250301VirtualNetworkGatewaySpecNatRulesTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic,
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>VirtualNetworkGatewayNatRule Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecNatRules
{
    /// <summary>ExternalMappings: The private IP address external mapping for NAT.</summary>
    [JsonPropertyName("externalMappings")]
    public IList<V20250301VirtualNetworkGatewaySpecNatRulesExternalMappings>? ExternalMappings { get; set; }

    /// <summary>InternalMappings: The private IP address internal mapping for NAT.</summary>
    [JsonPropertyName("internalMappings")]
    public IList<V20250301VirtualNetworkGatewaySpecNatRulesInternalMappings>? InternalMappings { get; set; }

    /// <summary>IpConfigurationId: The IP Configuration ID this NAT rule applies to.</summary>
    [JsonPropertyName("ipConfigurationId")]
    public string? IpConfigurationId { get; set; }

    /// <summary>Mode: The Source NAT direction of a VPN NAT.</summary>
    [JsonPropertyName("mode")]
    public V20250301VirtualNetworkGatewaySpecNatRulesModeEnum? Mode { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of NAT rule for VPN NAT.</summary>
    [JsonPropertyName("type")]
    public V20250301VirtualNetworkGatewaySpecNatRulesTypeEnum? Type { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecOperatorSpecConfigMapExpressions
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
public partial class V20250301VirtualNetworkGatewaySpecOperatorSpecSecretExpressions
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
public partial class V20250301VirtualNetworkGatewaySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250301VirtualNetworkGatewaySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250301VirtualNetworkGatewaySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ResiliencyModel: Property to indicate if the Express Route Gateway has resiliency model of MultiHomed or SingleHomed</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecResiliencyModelEnum>))]
public enum V20250301VirtualNetworkGatewaySpecResiliencyModelEnum
{
    [EnumMember(Value = "MultiHomed"), JsonStringEnumMemberName("MultiHomed")]
    MultiHomed,
    [EnumMember(Value = "SingleHomed"), JsonStringEnumMemberName("SingleHomed")]
    SingleHomed
}

/// <summary>Name: Gateway SKU name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecSkuNameEnum>))]
public enum V20250301VirtualNetworkGatewaySpecSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "ErGw1AZ"), JsonStringEnumMemberName("ErGw1AZ")]
    ErGw1AZ,
    [EnumMember(Value = "ErGw2AZ"), JsonStringEnumMemberName("ErGw2AZ")]
    ErGw2AZ,
    [EnumMember(Value = "ErGw3AZ"), JsonStringEnumMemberName("ErGw3AZ")]
    ErGw3AZ,
    [EnumMember(Value = "ErGwScale"), JsonStringEnumMemberName("ErGwScale")]
    ErGwScale,
    [EnumMember(Value = "HighPerformance"), JsonStringEnumMemberName("HighPerformance")]
    HighPerformance,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard,
    [EnumMember(Value = "UltraPerformance"), JsonStringEnumMemberName("UltraPerformance")]
    UltraPerformance,
    [EnumMember(Value = "VpnGw1"), JsonStringEnumMemberName("VpnGw1")]
    VpnGw1,
    [EnumMember(Value = "VpnGw1AZ"), JsonStringEnumMemberName("VpnGw1AZ")]
    VpnGw1AZ,
    [EnumMember(Value = "VpnGw2"), JsonStringEnumMemberName("VpnGw2")]
    VpnGw2,
    [EnumMember(Value = "VpnGw2AZ"), JsonStringEnumMemberName("VpnGw2AZ")]
    VpnGw2AZ,
    [EnumMember(Value = "VpnGw3"), JsonStringEnumMemberName("VpnGw3")]
    VpnGw3,
    [EnumMember(Value = "VpnGw3AZ"), JsonStringEnumMemberName("VpnGw3AZ")]
    VpnGw3AZ,
    [EnumMember(Value = "VpnGw4"), JsonStringEnumMemberName("VpnGw4")]
    VpnGw4,
    [EnumMember(Value = "VpnGw4AZ"), JsonStringEnumMemberName("VpnGw4AZ")]
    VpnGw4AZ,
    [EnumMember(Value = "VpnGw5"), JsonStringEnumMemberName("VpnGw5")]
    VpnGw5,
    [EnumMember(Value = "VpnGw5AZ"), JsonStringEnumMemberName("VpnGw5AZ")]
    VpnGw5AZ
}

/// <summary>Tier: Gateway SKU tier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecSkuTierEnum>))]
public enum V20250301VirtualNetworkGatewaySpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "ErGw1AZ"), JsonStringEnumMemberName("ErGw1AZ")]
    ErGw1AZ,
    [EnumMember(Value = "ErGw2AZ"), JsonStringEnumMemberName("ErGw2AZ")]
    ErGw2AZ,
    [EnumMember(Value = "ErGw3AZ"), JsonStringEnumMemberName("ErGw3AZ")]
    ErGw3AZ,
    [EnumMember(Value = "ErGwScale"), JsonStringEnumMemberName("ErGwScale")]
    ErGwScale,
    [EnumMember(Value = "HighPerformance"), JsonStringEnumMemberName("HighPerformance")]
    HighPerformance,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard,
    [EnumMember(Value = "UltraPerformance"), JsonStringEnumMemberName("UltraPerformance")]
    UltraPerformance,
    [EnumMember(Value = "VpnGw1"), JsonStringEnumMemberName("VpnGw1")]
    VpnGw1,
    [EnumMember(Value = "VpnGw1AZ"), JsonStringEnumMemberName("VpnGw1AZ")]
    VpnGw1AZ,
    [EnumMember(Value = "VpnGw2"), JsonStringEnumMemberName("VpnGw2")]
    VpnGw2,
    [EnumMember(Value = "VpnGw2AZ"), JsonStringEnumMemberName("VpnGw2AZ")]
    VpnGw2AZ,
    [EnumMember(Value = "VpnGw3"), JsonStringEnumMemberName("VpnGw3")]
    VpnGw3,
    [EnumMember(Value = "VpnGw3AZ"), JsonStringEnumMemberName("VpnGw3AZ")]
    VpnGw3AZ,
    [EnumMember(Value = "VpnGw4"), JsonStringEnumMemberName("VpnGw4")]
    VpnGw4,
    [EnumMember(Value = "VpnGw4AZ"), JsonStringEnumMemberName("VpnGw4AZ")]
    VpnGw4AZ,
    [EnumMember(Value = "VpnGw5"), JsonStringEnumMemberName("VpnGw5")]
    VpnGw5,
    [EnumMember(Value = "VpnGw5AZ"), JsonStringEnumMemberName("VpnGw5AZ")]
    VpnGw5AZ
}

/// <summary>
/// Sku: The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network
/// gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecSku
{
    /// <summary>Name: Gateway SKU name.</summary>
    [JsonPropertyName("name")]
    public V20250301VirtualNetworkGatewaySpecSkuNameEnum? Name { get; set; }

    /// <summary>Tier: Gateway SKU tier.</summary>
    [JsonPropertyName("tier")]
    public V20250301VirtualNetworkGatewaySpecSkuTierEnum? Tier { get; set; }
}

/// <summary>
/// VNetExtendedLocationResourceReference: Customer vnet resource id. VirtualNetworkGateway of type local gateway is
/// associated with the customer vnet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVNetExtendedLocationResourceReference
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

/// <summary>Phase: Represent the current migration phase of gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayMigrationStatusPhaseEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayMigrationStatusPhaseEnum
{
    [EnumMember(Value = "Abort"), JsonStringEnumMemberName("Abort")]
    Abort,
    [EnumMember(Value = "AbortSucceeded"), JsonStringEnumMemberName("AbortSucceeded")]
    AbortSucceeded,
    [EnumMember(Value = "Commit"), JsonStringEnumMemberName("Commit")]
    Commit,
    [EnumMember(Value = "CommitSucceeded"), JsonStringEnumMemberName("CommitSucceeded")]
    CommitSucceeded,
    [EnumMember(Value = "Execute"), JsonStringEnumMemberName("Execute")]
    Execute,
    [EnumMember(Value = "ExecuteSucceeded"), JsonStringEnumMemberName("ExecuteSucceeded")]
    ExecuteSucceeded,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Prepare"), JsonStringEnumMemberName("Prepare")]
    Prepare,
    [EnumMember(Value = "PrepareSucceeded"), JsonStringEnumMemberName("PrepareSucceeded")]
    PrepareSucceeded
}

/// <summary>State: Represent the current state of gateway migration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayMigrationStatusStateEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayMigrationStatusStateEnum
{
    [EnumMember(Value = "Failed"), JsonStringEnumMemberName("Failed")]
    Failed,
    [EnumMember(Value = "InProgress"), JsonStringEnumMemberName("InProgress")]
    InProgress,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Succeeded"), JsonStringEnumMemberName("Succeeded")]
    Succeeded
}

/// <summary>
/// VirtualNetworkGatewayMigrationStatus: The reference to the VirtualNetworkGatewayMigrationStatus which represents the
/// status of migration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayMigrationStatus
{
    /// <summary>ErrorMessage: Error if any occurs during migration.</summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>Phase: Represent the current migration phase of gateway.</summary>
    [JsonPropertyName("phase")]
    public V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayMigrationStatusPhaseEnum? Phase { get; set; }

    /// <summary>State: Represent the current state of gateway migration.</summary>
    [JsonPropertyName("state")]
    public V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayMigrationStatusStateEnum? State { get; set; }
}

/// <summary>AttributeType: The Vpn Policy member attribute type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroupsPolicyMembersAttributeTypeEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroupsPolicyMembersAttributeTypeEnum
{
    [EnumMember(Value = "AADGroupId"), JsonStringEnumMemberName("AADGroupId")]
    AADGroupId,
    [EnumMember(Value = "CertificateGroupId"), JsonStringEnumMemberName("CertificateGroupId")]
    CertificateGroupId,
    [EnumMember(Value = "RadiusAzureGroupId"), JsonStringEnumMemberName("RadiusAzureGroupId")]
    RadiusAzureGroupId
}

/// <summary>Vpn Client Connection configuration PolicyGroup member</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroupsPolicyMembers
{
    /// <summary>AttributeType: The Vpn Policy member attribute type.</summary>
    [JsonPropertyName("attributeType")]
    public V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroupsPolicyMembersAttributeTypeEnum? AttributeType { get; set; }

    /// <summary>AttributeValue: The value of Attribute used for this VirtualNetworkGatewayPolicyGroupMember.</summary>
    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }

    /// <summary>Name: Name of the VirtualNetworkGatewayPolicyGroupMember.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Parameters for VirtualNetworkGatewayPolicyGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroups
{
    /// <summary>IsDefault: Shows if this is a Default VirtualNetworkGatewayPolicyGroup or not.</summary>
    [JsonPropertyName("isDefault")]
    public required bool IsDefault { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PolicyMembers: Multiple PolicyMembers for VirtualNetworkGatewayPolicyGroup.</summary>
    [JsonPropertyName("policyMembers")]
    public required IList<V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroupsPolicyMembers> PolicyMembers { get; set; }

    /// <summary>Priority: Priority for VirtualNetworkGatewayPolicyGroup.</summary>
    [JsonPropertyName("priority")]
    public required int Priority { get; set; }
}

/// <summary>
/// RadiusServerSecret: The radius secret property of the VirtualNetworkGateway resource for vpn client connection. We will
/// no longer return radiusServerSecret in VirtualNetworkGateway Create/Update/Get/List/UpdateTags APIs response. Please use
/// VirtualNetworkGateway ListRadiusSecrets API to fetch radius server secrets.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServerSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// RadiusServerSecret: The secret used for this radius server. We will no longer return radiusServerSecret in
/// VirtualNetworkGateway Create/Update/Get/List/UpdateTags APIs response. Please use VirtualNetworkGateway
/// ListRadiusSecrets API to fetch radius server secrets.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServersRadiusServerSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Radius Server Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServers
{
    /// <summary>RadiusServerAddress: The address of this radius server.</summary>
    [JsonPropertyName("radiusServerAddress")]
    public required string RadiusServerAddress { get; set; }

    /// <summary>RadiusServerScore: The initial score assigned to this radius server.</summary>
    [JsonPropertyName("radiusServerScore")]
    public int? RadiusServerScore { get; set; }

    /// <summary>
    /// RadiusServerSecret: The secret used for this radius server. We will no longer return radiusServerSecret in
    /// VirtualNetworkGateway Create/Update/Get/List/UpdateTags APIs response. Please use VirtualNetworkGateway
    /// ListRadiusSecrets API to fetch radius server secrets.
    /// </summary>
    [JsonPropertyName("radiusServerSecret")]
    public V20250301VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServersRadiusServerSecret? RadiusServerSecret { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurationsReference
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

/// <summary>A vpn client connection configuration for client connection configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurations
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurationsReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnAuthenticationTypesEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnAuthenticationTypesEnum
{
    [EnumMember(Value = "AAD"), JsonStringEnumMemberName("AAD")]
    AAD,
    [EnumMember(Value = "Certificate"), JsonStringEnumMemberName("Certificate")]
    Certificate,
    [EnumMember(Value = "Radius"), JsonStringEnumMemberName("Radius")]
    Radius
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocationsReference
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

/// <summary>IpamPool prefix allocation reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocations
{
    /// <summary>NumberOfIpAddresses: Number of IP addresses to allocate.</summary>
    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }

    /// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>VpnClientAddressPool: The reference to the address space resource which represents Address space for P2S VpnClient.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPool
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>DhGroup: The DH Group used in IKE Phase 1 for initial SA.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesDhGroupEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesDhGroupEnum
{
    [EnumMember(Value = "DHGroup1"), JsonStringEnumMemberName("DHGroup1")]
    DHGroup1,
    [EnumMember(Value = "DHGroup14"), JsonStringEnumMemberName("DHGroup14")]
    DHGroup14,
    [EnumMember(Value = "DHGroup2"), JsonStringEnumMemberName("DHGroup2")]
    DHGroup2,
    [EnumMember(Value = "DHGroup2048"), JsonStringEnumMemberName("DHGroup2048")]
    DHGroup2048,
    [EnumMember(Value = "DHGroup24"), JsonStringEnumMemberName("DHGroup24")]
    DHGroup24,
    [EnumMember(Value = "ECP256"), JsonStringEnumMemberName("ECP256")]
    ECP256,
    [EnumMember(Value = "ECP384"), JsonStringEnumMemberName("ECP384")]
    ECP384,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>IkeEncryption: The IKE encryption algorithm (IKE phase 2).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeEncryptionEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeEncryptionEnum
{
    [EnumMember(Value = "AES128"), JsonStringEnumMemberName("AES128")]
    AES128,
    [EnumMember(Value = "AES192"), JsonStringEnumMemberName("AES192")]
    AES192,
    [EnumMember(Value = "AES256"), JsonStringEnumMemberName("AES256")]
    AES256,
    [EnumMember(Value = "DES"), JsonStringEnumMemberName("DES")]
    DES,
    [EnumMember(Value = "DES3"), JsonStringEnumMemberName("DES3")]
    DES3,
    [EnumMember(Value = "GCMAES128"), JsonStringEnumMemberName("GCMAES128")]
    GCMAES128,
    [EnumMember(Value = "GCMAES256"), JsonStringEnumMemberName("GCMAES256")]
    GCMAES256
}

/// <summary>IkeIntegrity: The IKE integrity algorithm (IKE phase 2).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeIntegrityEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeIntegrityEnum
{
    [EnumMember(Value = "GCMAES128"), JsonStringEnumMemberName("GCMAES128")]
    GCMAES128,
    [EnumMember(Value = "GCMAES256"), JsonStringEnumMemberName("GCMAES256")]
    GCMAES256,
    [EnumMember(Value = "MD5"), JsonStringEnumMemberName("MD5")]
    MD5,
    [EnumMember(Value = "SHA1"), JsonStringEnumMemberName("SHA1")]
    SHA1,
    [EnumMember(Value = "SHA256"), JsonStringEnumMemberName("SHA256")]
    SHA256,
    [EnumMember(Value = "SHA384"), JsonStringEnumMemberName("SHA384")]
    SHA384
}

/// <summary>IpsecEncryption: The IPSec encryption algorithm (IKE phase 1).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecEncryptionEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecEncryptionEnum
{
    [EnumMember(Value = "AES128"), JsonStringEnumMemberName("AES128")]
    AES128,
    [EnumMember(Value = "AES192"), JsonStringEnumMemberName("AES192")]
    AES192,
    [EnumMember(Value = "AES256"), JsonStringEnumMemberName("AES256")]
    AES256,
    [EnumMember(Value = "DES"), JsonStringEnumMemberName("DES")]
    DES,
    [EnumMember(Value = "DES3"), JsonStringEnumMemberName("DES3")]
    DES3,
    [EnumMember(Value = "GCMAES128"), JsonStringEnumMemberName("GCMAES128")]
    GCMAES128,
    [EnumMember(Value = "GCMAES192"), JsonStringEnumMemberName("GCMAES192")]
    GCMAES192,
    [EnumMember(Value = "GCMAES256"), JsonStringEnumMemberName("GCMAES256")]
    GCMAES256,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>IpsecIntegrity: The IPSec integrity algorithm (IKE phase 1).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecIntegrityEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecIntegrityEnum
{
    [EnumMember(Value = "GCMAES128"), JsonStringEnumMemberName("GCMAES128")]
    GCMAES128,
    [EnumMember(Value = "GCMAES192"), JsonStringEnumMemberName("GCMAES192")]
    GCMAES192,
    [EnumMember(Value = "GCMAES256"), JsonStringEnumMemberName("GCMAES256")]
    GCMAES256,
    [EnumMember(Value = "MD5"), JsonStringEnumMemberName("MD5")]
    MD5,
    [EnumMember(Value = "SHA1"), JsonStringEnumMemberName("SHA1")]
    SHA1,
    [EnumMember(Value = "SHA256"), JsonStringEnumMemberName("SHA256")]
    SHA256
}

/// <summary>PfsGroup: The Pfs Group used in IKE Phase 2 for new child SA.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesPfsGroupEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesPfsGroupEnum
{
    [EnumMember(Value = "ECP256"), JsonStringEnumMemberName("ECP256")]
    ECP256,
    [EnumMember(Value = "ECP384"), JsonStringEnumMemberName("ECP384")]
    ECP384,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "PFS1"), JsonStringEnumMemberName("PFS1")]
    PFS1,
    [EnumMember(Value = "PFS14"), JsonStringEnumMemberName("PFS14")]
    PFS14,
    [EnumMember(Value = "PFS2"), JsonStringEnumMemberName("PFS2")]
    PFS2,
    [EnumMember(Value = "PFS2048"), JsonStringEnumMemberName("PFS2048")]
    PFS2048,
    [EnumMember(Value = "PFS24"), JsonStringEnumMemberName("PFS24")]
    PFS24,
    [EnumMember(Value = "PFSMM"), JsonStringEnumMemberName("PFSMM")]
    PFSMM
}

/// <summary>An IPSec Policy configuration for a virtual network gateway connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPolicies
{
    /// <summary>DhGroup: The DH Group used in IKE Phase 1 for initial SA.</summary>
    [JsonPropertyName("dhGroup")]
    public required V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesDhGroupEnum DhGroup { get; set; }

    /// <summary>IkeEncryption: The IKE encryption algorithm (IKE phase 2).</summary>
    [JsonPropertyName("ikeEncryption")]
    public required V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeEncryptionEnum IkeEncryption { get; set; }

    /// <summary>IkeIntegrity: The IKE integrity algorithm (IKE phase 2).</summary>
    [JsonPropertyName("ikeIntegrity")]
    public required V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeIntegrityEnum IkeIntegrity { get; set; }

    /// <summary>IpsecEncryption: The IPSec encryption algorithm (IKE phase 1).</summary>
    [JsonPropertyName("ipsecEncryption")]
    public required V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecEncryptionEnum IpsecEncryption { get; set; }

    /// <summary>IpsecIntegrity: The IPSec integrity algorithm (IKE phase 1).</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public required V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecIntegrityEnum IpsecIntegrity { get; set; }

    /// <summary>PfsGroup: The Pfs Group used in IKE Phase 2 for new child SA.</summary>
    [JsonPropertyName("pfsGroup")]
    public required V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesPfsGroupEnum PfsGroup { get; set; }

    /// <summary>
    /// SaDataSizeKilobytes: The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for a site
    /// to site VPN tunnel.
    /// </summary>
    [JsonPropertyName("saDataSizeKilobytes")]
    public required int SaDataSizeKilobytes { get; set; }

    /// <summary>
    /// SaLifeTimeSeconds: The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for a site
    /// to site VPN tunnel.
    /// </summary>
    [JsonPropertyName("saLifeTimeSeconds")]
    public required int SaLifeTimeSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientProtocolsEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientProtocolsEnum
{
    [EnumMember(Value = "IkeV2"), JsonStringEnumMemberName("IkeV2")]
    IkeV2,
    [EnumMember(Value = "OpenVPN"), JsonStringEnumMemberName("OpenVPN")]
    OpenVPN,
    [EnumMember(Value = "SSTP"), JsonStringEnumMemberName("SSTP")]
    SSTP
}

/// <summary>VPN client revoked certificate of virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRevokedCertificates
{
    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Thumbprint: The revoked VPN client certificate thumbprint.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>VPN client root certificate of virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRootCertificates
{
    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PublicCertData: The certificate public data.</summary>
    [JsonPropertyName("publicCertData")]
    public required string PublicCertData { get; set; }
}

/// <summary>
/// VpnClientConfiguration: The reference to the VpnClientConfiguration resource which represents the P2S VpnClient
/// configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpecVpnClientConfiguration
{
    /// <summary>
    /// AadAudience: The AADAudience property of the VirtualNetworkGateway resource for vpn client connection used for AAD
    /// authentication.
    /// </summary>
    [JsonPropertyName("aadAudience")]
    public string? AadAudience { get; set; }

    /// <summary>
    /// AadIssuer: The AADIssuer property of the VirtualNetworkGateway resource for vpn client connection used for AAD
    /// authentication.
    /// </summary>
    [JsonPropertyName("aadIssuer")]
    public string? AadIssuer { get; set; }

    /// <summary>
    /// AadTenant: The AADTenant property of the VirtualNetworkGateway resource for vpn client connection used for AAD
    /// authentication.
    /// </summary>
    [JsonPropertyName("aadTenant")]
    public string? AadTenant { get; set; }

    /// <summary>RadiusServerAddress: The radius server address property of the VirtualNetworkGateway resource for vpn client connection.</summary>
    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary>
    /// RadiusServerSecret: The radius secret property of the VirtualNetworkGateway resource for vpn client connection. We will
    /// no longer return radiusServerSecret in VirtualNetworkGateway Create/Update/Get/List/UpdateTags APIs response. Please use
    /// VirtualNetworkGateway ListRadiusSecrets API to fetch radius server secrets.
    /// </summary>
    [JsonPropertyName("radiusServerSecret")]
    public V20250301VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServerSecret? RadiusServerSecret { get; set; }

    /// <summary>RadiusServers: The radiusServers property for multiple radius server configuration.</summary>
    [JsonPropertyName("radiusServers")]
    public IList<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServers>? RadiusServers { get; set; }

    /// <summary>VngClientConnectionConfigurations: per ip address pool connection policy for virtual network gateway P2S client.</summary>
    [JsonPropertyName("vngClientConnectionConfigurations")]
    public IList<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurations>? VngClientConnectionConfigurations { get; set; }

    /// <summary>VpnAuthenticationTypes: VPN authentication types for the virtual network gateway..</summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnAuthenticationTypesEnum>? VpnAuthenticationTypes { get; set; }

    /// <summary>VpnClientAddressPool: The reference to the address space resource which represents Address space for P2S VpnClient.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }

    /// <summary>VpnClientIpsecPolicies: VpnClientIpsecPolicies for virtual network gateway P2S client.</summary>
    [JsonPropertyName("vpnClientIpsecPolicies")]
    public IList<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPolicies>? VpnClientIpsecPolicies { get; set; }

    /// <summary>VpnClientProtocols: VpnClientProtocols for Virtual network gateway.</summary>
    [JsonPropertyName("vpnClientProtocols")]
    public IList<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientProtocolsEnum>? VpnClientProtocols { get; set; }

    /// <summary>VpnClientRevokedCertificates: VpnClientRevokedCertificate for Virtual network gateway.</summary>
    [JsonPropertyName("vpnClientRevokedCertificates")]
    public IList<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRevokedCertificates>? VpnClientRevokedCertificates { get; set; }

    /// <summary>VpnClientRootCertificates: VpnClientRootCertificate for virtual network gateway.</summary>
    [JsonPropertyName("vpnClientRootCertificates")]
    public IList<V20250301VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRootCertificates>? VpnClientRootCertificates { get; set; }
}

/// <summary>VpnGatewayGeneration: The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVpnGatewayGenerationEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVpnGatewayGenerationEnum
{
    [EnumMember(Value = "Generation1"), JsonStringEnumMemberName("Generation1")]
    Generation1,
    [EnumMember(Value = "Generation2"), JsonStringEnumMemberName("Generation2")]
    Generation2,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>VpnType: The type of this virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkGatewaySpecVpnTypeEnum>))]
public enum V20250301VirtualNetworkGatewaySpecVpnTypeEnum
{
    [EnumMember(Value = "PolicyBased"), JsonStringEnumMemberName("PolicyBased")]
    PolicyBased,
    [EnumMember(Value = "RouteBased"), JsonStringEnumMemberName("RouteBased")]
    RouteBased
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewaySpec
{
    /// <summary>ActiveActive: ActiveActive flag.</summary>
    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    /// <summary>
    /// AdminState: Property to indicate if the Express Route Gateway serves traffic when there are multiple Express Route
    /// Gateways in the vnet
    /// </summary>
    [JsonPropertyName("adminState")]
    public V20250301VirtualNetworkGatewaySpecAdminStateEnum? AdminState { get; set; }

    /// <summary>
    /// AllowRemoteVnetTraffic: Configure this gateway to accept traffic from other Azure Virtual Networks. This configuration
    /// does not support connectivity to Azure Virtual WAN.
    /// </summary>
    [JsonPropertyName("allowRemoteVnetTraffic")]
    public bool? AllowRemoteVnetTraffic { get; set; }

    /// <summary>AllowVirtualWanTraffic: Configures this gateway to accept traffic from remote Virtual WAN networks.</summary>
    [JsonPropertyName("allowVirtualWanTraffic")]
    public bool? AllowVirtualWanTraffic { get; set; }

    /// <summary>AutoScaleConfiguration: Autoscale configuration for virutal network gateway</summary>
    [JsonPropertyName("autoScaleConfiguration")]
    public V20250301VirtualNetworkGatewaySpecAutoScaleConfiguration? AutoScaleConfiguration { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>BgpSettings: Virtual network gateway&apos;s BGP speaker settings.</summary>
    [JsonPropertyName("bgpSettings")]
    public V20250301VirtualNetworkGatewaySpecBgpSettings? BgpSettings { get; set; }

    /// <summary>
    /// CustomRoutes: The reference to the address space resource which represents the custom routes address space specified by
    /// the customer for virtual network gateway and VpnClient.
    /// </summary>
    [JsonPropertyName("customRoutes")]
    public V20250301VirtualNetworkGatewaySpecCustomRoutes? CustomRoutes { get; set; }

    /// <summary>DisableIPSecReplayProtection: disableIPSecReplayProtection flag.</summary>
    [JsonPropertyName("disableIPSecReplayProtection")]
    public bool? DisableIPSecReplayProtection { get; set; }

    /// <summary>EnableBgp: Whether BGP is enabled for this virtual network gateway or not.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>EnableBgpRouteTranslationForNat: EnableBgpRouteTranslationForNat flag.</summary>
    [JsonPropertyName("enableBgpRouteTranslationForNat")]
    public bool? EnableBgpRouteTranslationForNat { get; set; }

    /// <summary>EnableDnsForwarding: Whether dns forwarding is enabled or not.</summary>
    [JsonPropertyName("enableDnsForwarding")]
    public bool? EnableDnsForwarding { get; set; }

    /// <summary>EnableHighBandwidthVpnGateway: To enable Advanced Connectivity feature for VPN gateway</summary>
    [JsonPropertyName("enableHighBandwidthVpnGateway")]
    public bool? EnableHighBandwidthVpnGateway { get; set; }

    /// <summary>EnablePrivateIpAddress: Whether private IP needs to be enabled on this gateway for connections or not.</summary>
    [JsonPropertyName("enablePrivateIpAddress")]
    public bool? EnablePrivateIpAddress { get; set; }

    /// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20250301VirtualNetworkGatewaySpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// GatewayDefaultSite: The reference to the LocalNetworkGateway resource which represents local network site having default
    /// routes. Assign Null value in case of removing existing default site setting.
    /// </summary>
    [JsonPropertyName("gatewayDefaultSite")]
    public V20250301VirtualNetworkGatewaySpecGatewayDefaultSite? GatewayDefaultSite { get; set; }

    /// <summary>GatewayType: The type of this virtual network gateway.</summary>
    [JsonPropertyName("gatewayType")]
    public V20250301VirtualNetworkGatewaySpecGatewayTypeEnum? GatewayType { get; set; }

    /// <summary>Identity: The identity of the virtual network gateway, if configured.</summary>
    [JsonPropertyName("identity")]
    public V20250301VirtualNetworkGatewaySpecIdentity? Identity { get; set; }

    /// <summary>IpConfigurations: IP configurations for virtual network gateway.</summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V20250301VirtualNetworkGatewaySpecIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>NatRules: NatRules for virtual network gateway.</summary>
    [JsonPropertyName("natRules")]
    public IList<V20250301VirtualNetworkGatewaySpecNatRules>? NatRules { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250301VirtualNetworkGatewaySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250301VirtualNetworkGatewaySpecOwner Owner { get; set; }

    /// <summary>ResiliencyModel: Property to indicate if the Express Route Gateway has resiliency model of MultiHomed or SingleHomed</summary>
    [JsonPropertyName("resiliencyModel")]
    public V20250301VirtualNetworkGatewaySpecResiliencyModelEnum? ResiliencyModel { get; set; }

    /// <summary>
    /// Sku: The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network
    /// gateway.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20250301VirtualNetworkGatewaySpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// VNetExtendedLocationResourceReference: Customer vnet resource id. VirtualNetworkGateway of type local gateway is
    /// associated with the customer vnet.
    /// </summary>
    [JsonPropertyName("vNetExtendedLocationResourceReference")]
    public V20250301VirtualNetworkGatewaySpecVNetExtendedLocationResourceReference? VNetExtendedLocationResourceReference { get; set; }

    /// <summary>
    /// VirtualNetworkGatewayMigrationStatus: The reference to the VirtualNetworkGatewayMigrationStatus which represents the
    /// status of migration.
    /// </summary>
    [JsonPropertyName("virtualNetworkGatewayMigrationStatus")]
    public V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayMigrationStatus? VirtualNetworkGatewayMigrationStatus { get; set; }

    /// <summary>
    /// VirtualNetworkGatewayPolicyGroups: The reference to the VirtualNetworkGatewayPolicyGroup resource which represents the
    /// available VirtualNetworkGatewayPolicyGroup for the gateway.
    /// </summary>
    [JsonPropertyName("virtualNetworkGatewayPolicyGroups")]
    public IList<V20250301VirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroups>? VirtualNetworkGatewayPolicyGroups { get; set; }

    /// <summary>
    /// VpnClientConfiguration: The reference to the VpnClientConfiguration resource which represents the P2S VpnClient
    /// configurations.
    /// </summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public V20250301VirtualNetworkGatewaySpecVpnClientConfiguration? VpnClientConfiguration { get; set; }

    /// <summary>VpnGatewayGeneration: The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN.</summary>
    [JsonPropertyName("vpnGatewayGeneration")]
    public V20250301VirtualNetworkGatewaySpecVpnGatewayGenerationEnum? VpnGatewayGeneration { get; set; }

    /// <summary>VpnType: The type of this virtual network gateway.</summary>
    [JsonPropertyName("vpnType")]
    public V20250301VirtualNetworkGatewaySpecVpnTypeEnum? VpnType { get; set; }
}

/// <summary>Bounds: The bounds of the autoscale configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusAutoScaleConfigurationBounds
{
    /// <summary>Max: Maximum Scale Units for Autoscale configuration</summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary>Min: Minimum scale Units for Autoscale configuration</summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>AutoScaleConfiguration: Autoscale configuration for virutal network gateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusAutoScaleConfiguration
{
    /// <summary>Bounds: The bounds of the autoscale configuration</summary>
    [JsonPropertyName("bounds")]
    public V20250301VirtualNetworkGatewayStatusAutoScaleConfigurationBounds? Bounds { get; set; }
}

/// <summary>Properties of IPConfigurationBgpPeeringAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusBgpSettingsBgpPeeringAddresses
{
    /// <summary>CustomBgpIpAddresses: The list of custom BGP peering addresses which belong to IP configuration.</summary>
    [JsonPropertyName("customBgpIpAddresses")]
    public IList<string>? CustomBgpIpAddresses { get; set; }

    /// <summary>DefaultBgpIpAddresses: The list of default BGP peering addresses which belong to IP configuration.</summary>
    [JsonPropertyName("defaultBgpIpAddresses")]
    public IList<string>? DefaultBgpIpAddresses { get; set; }

    /// <summary>IpconfigurationId: The ID of IP configuration which belongs to gateway.</summary>
    [JsonPropertyName("ipconfigurationId")]
    public string? IpconfigurationId { get; set; }

    /// <summary>TunnelIpAddresses: The list of tunnel public IP addresses which belong to IP configuration.</summary>
    [JsonPropertyName("tunnelIpAddresses")]
    public IList<string>? TunnelIpAddresses { get; set; }
}

/// <summary>BgpSettings: Virtual network gateway&apos;s BGP speaker settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusBgpSettings
{
    /// <summary>Asn: The BGP speaker&apos;s ASN.</summary>
    [JsonPropertyName("asn")]
    public int? Asn { get; set; }

    /// <summary>BgpPeeringAddress: The BGP peering address and BGP identifier of this BGP speaker.</summary>
    [JsonPropertyName("bgpPeeringAddress")]
    public string? BgpPeeringAddress { get; set; }

    /// <summary>BgpPeeringAddresses: BGP peering address with IP configuration ID for virtual network gateway.</summary>
    [JsonPropertyName("bgpPeeringAddresses")]
    public IList<V20250301VirtualNetworkGatewayStatusBgpSettingsBgpPeeringAddresses>? BgpPeeringAddresses { get; set; }

    /// <summary>PeerWeight: The weight added to routes learned from this BGP speaker.</summary>
    [JsonPropertyName("peerWeight")]
    public int? PeerWeight { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusConditions
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

/// <summary>IpamPool prefix allocation reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusCustomRoutesIpamPoolPrefixAllocations
{
    /// <summary>AllocatedAddressPrefixes: List of assigned IP address prefixes in the IpamPool of the associated resource.</summary>
    [JsonPropertyName("allocatedAddressPrefixes")]
    public IList<string>? AllocatedAddressPrefixes { get; set; }

    /// <summary>Id: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>NumberOfIpAddresses: Number of IP addresses to allocate.</summary>
    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }
}

/// <summary>
/// CustomRoutes: The reference to the address space resource which represents the custom routes address space specified by
/// the customer for virtual network gateway and VpnClient.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusCustomRoutes
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworkGatewayStatusCustomRoutesIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// GatewayDefaultSite: The reference to the LocalNetworkGateway resource which represents local network site having default
/// routes. Assign Null value in case of removing existing default site setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusGatewayDefaultSite
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the virtual network gateway, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusIdentity
{
    /// <summary>
    /// PrincipalId: The principal id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant id of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the resource. The type &apos;SystemAssigned, UserAssigned&apos; includes both an implicitly
    /// created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the virtual
    /// machine.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: The list of user identities associated with resource. The user identity dictionary key
    /// references will be ARM resource ids in the form:
    /// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250301VirtualNetworkGatewayStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>PublicIPAddress: The reference to the public IP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusIpConfigurationsPublicIPAddress
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Subnet: The reference to the subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusIpConfigurationsSubnet
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>IP configuration for virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusIpConfigurations
{
    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateIPAddress: Private IP Address for this gateway.</summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary>PrivateIPAllocationMethod: The private IP address allocation method.</summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public string? PrivateIPAllocationMethod { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the virtual network gateway IP configuration resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicIPAddress: The reference to the public IP resource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V20250301VirtualNetworkGatewayStatusIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Subnet: The reference to the subnet resource.</summary>
    [JsonPropertyName("subnet")]
    public V20250301VirtualNetworkGatewayStatusIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Vpn NatRule mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusNatRulesExternalMappings
{
    /// <summary>AddressSpace: Address space for Vpn NatRule mapping.</summary>
    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    /// <summary>PortRange: Port range for Vpn NatRule mapping.</summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>Vpn NatRule mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusNatRulesInternalMappings
{
    /// <summary>AddressSpace: Address space for Vpn NatRule mapping.</summary>
    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    /// <summary>PortRange: Port range for Vpn NatRule mapping.</summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>VirtualNetworkGatewayNatRule Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusNatRules
{
    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ExternalMappings: The private IP address external mapping for NAT.</summary>
    [JsonPropertyName("externalMappings")]
    public IList<V20250301VirtualNetworkGatewayStatusNatRulesExternalMappings>? ExternalMappings { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>InternalMappings: The private IP address internal mapping for NAT.</summary>
    [JsonPropertyName("internalMappings")]
    public IList<V20250301VirtualNetworkGatewayStatusNatRulesInternalMappings>? InternalMappings { get; set; }

    /// <summary>IpConfigurationId: The IP Configuration ID this NAT rule applies to.</summary>
    [JsonPropertyName("ipConfigurationId")]
    public string? IpConfigurationId { get; set; }

    /// <summary>Mode: The Source NAT direction of a VPN NAT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PropertiesType: The type of NAT rule for VPN NAT.</summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the NAT Rule resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Sku: The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network
/// gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusSku
{
    /// <summary>Capacity: The capacity.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Name: Gateway SKU name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Gateway SKU tier.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// VirtualNetworkGatewayMigrationStatus: The reference to the VirtualNetworkGatewayMigrationStatus which represents the
/// status of migration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVirtualNetworkGatewayMigrationStatus
{
    /// <summary>ErrorMessage: Error if any occurs during migration.</summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>Phase: Represent the current migration phase of gateway.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>State: Represent the current state of gateway migration.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Vpn Client Connection configuration PolicyGroup member</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsPolicyMembers
{
    /// <summary>AttributeType: The Vpn Policy member attribute type.</summary>
    [JsonPropertyName("attributeType")]
    public string? AttributeType { get; set; }

    /// <summary>AttributeValue: The value of Attribute used for this VirtualNetworkGatewayPolicyGroupMember.</summary>
    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }

    /// <summary>Name: Name of the VirtualNetworkGatewayPolicyGroupMember.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsVngClientConnectionConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Parameters for VirtualNetworkGatewayPolicyGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroups
{
    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsDefault: Shows if this is a Default VirtualNetworkGatewayPolicyGroup or not.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PolicyMembers: Multiple PolicyMembers for VirtualNetworkGatewayPolicyGroup.</summary>
    [JsonPropertyName("policyMembers")]
    public IList<V20250301VirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsPolicyMembers>? PolicyMembers { get; set; }

    /// <summary>Priority: Priority for VirtualNetworkGatewayPolicyGroup.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the VirtualNetworkGatewayPolicyGroup resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>VngClientConnectionConfigurations: List of references to vngClientConnectionConfigurations.</summary>
    [JsonPropertyName("vngClientConnectionConfigurations")]
    public IList<V20250301VirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsVngClientConnectionConfigurations>? VngClientConnectionConfigurations { get; set; }
}

/// <summary>Radius Server Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVpnClientConfigurationRadiusServers
{
    /// <summary>RadiusServerAddress: The address of this radius server.</summary>
    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary>RadiusServerScore: The initial score assigned to this radius server.</summary>
    [JsonPropertyName("radiusServerScore")]
    public int? RadiusServerScore { get; set; }
}

/// <summary>A vpn client connection configuration for client connection configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVngClientConnectionConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>IpamPool prefix allocation reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocations
{
    /// <summary>AllocatedAddressPrefixes: List of assigned IP address prefixes in the IpamPool of the associated resource.</summary>
    [JsonPropertyName("allocatedAddressPrefixes")]
    public IList<string>? AllocatedAddressPrefixes { get; set; }

    /// <summary>Id: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>NumberOfIpAddresses: Number of IP addresses to allocate.</summary>
    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }
}

/// <summary>VpnClientAddressPool: The reference to the address space resource which represents Address space for P2S VpnClient.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPool
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>An IPSec Policy configuration for a virtual network gateway connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientIpsecPolicies
{
    /// <summary>DhGroup: The DH Group used in IKE Phase 1 for initial SA.</summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary>IkeEncryption: The IKE encryption algorithm (IKE phase 2).</summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary>IkeIntegrity: The IKE integrity algorithm (IKE phase 2).</summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary>IpsecEncryption: The IPSec encryption algorithm (IKE phase 1).</summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary>IpsecIntegrity: The IPSec integrity algorithm (IKE phase 1).</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary>PfsGroup: The Pfs Group used in IKE Phase 2 for new child SA.</summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary>
    /// SaDataSizeKilobytes: The IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB for a site
    /// to site VPN tunnel.
    /// </summary>
    [JsonPropertyName("saDataSizeKilobytes")]
    public int? SaDataSizeKilobytes { get; set; }

    /// <summary>
    /// SaLifeTimeSeconds: The IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds for a site
    /// to site VPN tunnel.
    /// </summary>
    [JsonPropertyName("saLifeTimeSeconds")]
    public int? SaLifeTimeSeconds { get; set; }
}

/// <summary>VPN client revoked certificate of virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRevokedCertificates
{
    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the VPN client revoked certificate resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Thumbprint: The revoked VPN client certificate thumbprint.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>VPN client root certificate of virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRootCertificates
{
    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the VPN client root certificate resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicCertData: The certificate public data.</summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>
/// VpnClientConfiguration: The reference to the VpnClientConfiguration resource which represents the P2S VpnClient
/// configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatusVpnClientConfiguration
{
    /// <summary>
    /// AadAudience: The AADAudience property of the VirtualNetworkGateway resource for vpn client connection used for AAD
    /// authentication.
    /// </summary>
    [JsonPropertyName("aadAudience")]
    public string? AadAudience { get; set; }

    /// <summary>
    /// AadIssuer: The AADIssuer property of the VirtualNetworkGateway resource for vpn client connection used for AAD
    /// authentication.
    /// </summary>
    [JsonPropertyName("aadIssuer")]
    public string? AadIssuer { get; set; }

    /// <summary>
    /// AadTenant: The AADTenant property of the VirtualNetworkGateway resource for vpn client connection used for AAD
    /// authentication.
    /// </summary>
    [JsonPropertyName("aadTenant")]
    public string? AadTenant { get; set; }

    /// <summary>RadiusServerAddress: The radius server address property of the VirtualNetworkGateway resource for vpn client connection.</summary>
    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary>RadiusServers: The radiusServers property for multiple radius server configuration.</summary>
    [JsonPropertyName("radiusServers")]
    public IList<V20250301VirtualNetworkGatewayStatusVpnClientConfigurationRadiusServers>? RadiusServers { get; set; }

    /// <summary>VngClientConnectionConfigurations: per ip address pool connection policy for virtual network gateway P2S client.</summary>
    [JsonPropertyName("vngClientConnectionConfigurations")]
    public IList<V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVngClientConnectionConfigurations>? VngClientConnectionConfigurations { get; set; }

    /// <summary>VpnAuthenticationTypes: VPN authentication types for the virtual network gateway..</summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>VpnClientAddressPool: The reference to the address space resource which represents Address space for P2S VpnClient.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }

    /// <summary>VpnClientIpsecPolicies: VpnClientIpsecPolicies for virtual network gateway P2S client.</summary>
    [JsonPropertyName("vpnClientIpsecPolicies")]
    public IList<V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientIpsecPolicies>? VpnClientIpsecPolicies { get; set; }

    /// <summary>VpnClientProtocols: VpnClientProtocols for Virtual network gateway.</summary>
    [JsonPropertyName("vpnClientProtocols")]
    public IList<string>? VpnClientProtocols { get; set; }

    /// <summary>VpnClientRevokedCertificates: VpnClientRevokedCertificate for Virtual network gateway.</summary>
    [JsonPropertyName("vpnClientRevokedCertificates")]
    public IList<V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRevokedCertificates>? VpnClientRevokedCertificates { get; set; }

    /// <summary>VpnClientRootCertificates: VpnClientRootCertificate for virtual network gateway.</summary>
    [JsonPropertyName("vpnClientRootCertificates")]
    public IList<V20250301VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRootCertificates>? VpnClientRootCertificates { get; set; }
}

/// <summary>A common class for general resource information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkGatewayStatus
{
    /// <summary>ActiveActive: ActiveActive flag.</summary>
    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    /// <summary>
    /// AdminState: Property to indicate if the Express Route Gateway serves traffic when there are multiple Express Route
    /// Gateways in the vnet
    /// </summary>
    [JsonPropertyName("adminState")]
    public string? AdminState { get; set; }

    /// <summary>
    /// AllowRemoteVnetTraffic: Configure this gateway to accept traffic from other Azure Virtual Networks. This configuration
    /// does not support connectivity to Azure Virtual WAN.
    /// </summary>
    [JsonPropertyName("allowRemoteVnetTraffic")]
    public bool? AllowRemoteVnetTraffic { get; set; }

    /// <summary>AllowVirtualWanTraffic: Configures this gateway to accept traffic from remote Virtual WAN networks.</summary>
    [JsonPropertyName("allowVirtualWanTraffic")]
    public bool? AllowVirtualWanTraffic { get; set; }

    /// <summary>AutoScaleConfiguration: Autoscale configuration for virutal network gateway</summary>
    [JsonPropertyName("autoScaleConfiguration")]
    public V20250301VirtualNetworkGatewayStatusAutoScaleConfiguration? AutoScaleConfiguration { get; set; }

    /// <summary>BgpSettings: Virtual network gateway&apos;s BGP speaker settings.</summary>
    [JsonPropertyName("bgpSettings")]
    public V20250301VirtualNetworkGatewayStatusBgpSettings? BgpSettings { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250301VirtualNetworkGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// CustomRoutes: The reference to the address space resource which represents the custom routes address space specified by
    /// the customer for virtual network gateway and VpnClient.
    /// </summary>
    [JsonPropertyName("customRoutes")]
    public V20250301VirtualNetworkGatewayStatusCustomRoutes? CustomRoutes { get; set; }

    /// <summary>DisableIPSecReplayProtection: disableIPSecReplayProtection flag.</summary>
    [JsonPropertyName("disableIPSecReplayProtection")]
    public bool? DisableIPSecReplayProtection { get; set; }

    /// <summary>EnableBgp: Whether BGP is enabled for this virtual network gateway or not.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>EnableBgpRouteTranslationForNat: EnableBgpRouteTranslationForNat flag.</summary>
    [JsonPropertyName("enableBgpRouteTranslationForNat")]
    public bool? EnableBgpRouteTranslationForNat { get; set; }

    /// <summary>EnableDnsForwarding: Whether dns forwarding is enabled or not.</summary>
    [JsonPropertyName("enableDnsForwarding")]
    public bool? EnableDnsForwarding { get; set; }

    /// <summary>EnableHighBandwidthVpnGateway: To enable Advanced Connectivity feature for VPN gateway</summary>
    [JsonPropertyName("enableHighBandwidthVpnGateway")]
    public bool? EnableHighBandwidthVpnGateway { get; set; }

    /// <summary>EnablePrivateIpAddress: Whether private IP needs to be enabled on this gateway for connections or not.</summary>
    [JsonPropertyName("enablePrivateIpAddress")]
    public bool? EnablePrivateIpAddress { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20250301VirtualNetworkGatewayStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// GatewayDefaultSite: The reference to the LocalNetworkGateway resource which represents local network site having default
    /// routes. Assign Null value in case of removing existing default site setting.
    /// </summary>
    [JsonPropertyName("gatewayDefaultSite")]
    public V20250301VirtualNetworkGatewayStatusGatewayDefaultSite? GatewayDefaultSite { get; set; }

    /// <summary>GatewayType: The type of this virtual network gateway.</summary>
    [JsonPropertyName("gatewayType")]
    public string? GatewayType { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the virtual network gateway, if configured.</summary>
    [JsonPropertyName("identity")]
    public V20250301VirtualNetworkGatewayStatusIdentity? Identity { get; set; }

    /// <summary>InboundDnsForwardingEndpoint: The IP address allocated by the gateway to which dns requests can be sent.</summary>
    [JsonPropertyName("inboundDnsForwardingEndpoint")]
    public string? InboundDnsForwardingEndpoint { get; set; }

    /// <summary>IpConfigurations: IP configurations for virtual network gateway.</summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V20250301VirtualNetworkGatewayStatusIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NatRules: NatRules for virtual network gateway.</summary>
    [JsonPropertyName("natRules")]
    public IList<V20250301VirtualNetworkGatewayStatusNatRules>? NatRules { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the virtual network gateway resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResiliencyModel: Property to indicate if the Express Route Gateway has resiliency model of MultiHomed or SingleHomed</summary>
    [JsonPropertyName("resiliencyModel")]
    public string? ResiliencyModel { get; set; }

    /// <summary>ResourceGuid: The resource GUID property of the virtual network gateway resource.</summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>
    /// Sku: The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network
    /// gateway.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20250301VirtualNetworkGatewayStatusSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// VNetExtendedLocationResourceId: Customer vnet resource id. VirtualNetworkGateway of type local gateway is associated
    /// with the customer vnet.
    /// </summary>
    [JsonPropertyName("vNetExtendedLocationResourceId")]
    public string? VNetExtendedLocationResourceId { get; set; }

    /// <summary>
    /// VirtualNetworkGatewayMigrationStatus: The reference to the VirtualNetworkGatewayMigrationStatus which represents the
    /// status of migration.
    /// </summary>
    [JsonPropertyName("virtualNetworkGatewayMigrationStatus")]
    public V20250301VirtualNetworkGatewayStatusVirtualNetworkGatewayMigrationStatus? VirtualNetworkGatewayMigrationStatus { get; set; }

    /// <summary>
    /// VirtualNetworkGatewayPolicyGroups: The reference to the VirtualNetworkGatewayPolicyGroup resource which represents the
    /// available VirtualNetworkGatewayPolicyGroup for the gateway.
    /// </summary>
    [JsonPropertyName("virtualNetworkGatewayPolicyGroups")]
    public IList<V20250301VirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroups>? VirtualNetworkGatewayPolicyGroups { get; set; }

    /// <summary>
    /// VpnClientConfiguration: The reference to the VpnClientConfiguration resource which represents the P2S VpnClient
    /// configurations.
    /// </summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public V20250301VirtualNetworkGatewayStatusVpnClientConfiguration? VpnClientConfiguration { get; set; }

    /// <summary>VpnGatewayGeneration: The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN.</summary>
    [JsonPropertyName("vpnGatewayGeneration")]
    public string? VpnGatewayGeneration { get; set; }

    /// <summary>VpnType: The type of this virtual network gateway.</summary>
    [JsonPropertyName("vpnType")]
    public string? VpnType { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/virtualNetworkGateway.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301VirtualNetworkGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V20250301VirtualNetworkGatewaySpec?>, IStatus<V20250301VirtualNetworkGatewayStatus?>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "VirtualNetworkGateway";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworkgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworkGateway";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250301VirtualNetworkGatewaySpec? Spec { get; set; }

    /// <summary>A common class for general resource information.</summary>
    [JsonPropertyName("status")]
    public V20250301VirtualNetworkGatewayStatus? Status { get; set; }
}