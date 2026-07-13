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
/// Storage version of v20250301.VirtualNetworkGateway
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/virtualNetworkGateway.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301storageVirtualNetworkGatewayList : IKubernetesObject<V1ListMeta>, IItems<V20250301storageVirtualNetworkGateway>
{
    public const string KubeApiVersion = "v20250301storage";
    public const string KubeKind = "VirtualNetworkGatewayList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworkgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworkGatewayList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250301storageVirtualNetworkGateway objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250301storageVirtualNetworkGateway> Items { get; set; }
}

/// <summary>Storage version of v20250301.VirtualNetworkGatewayAutoScaleBounds</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecAutoScaleConfigurationBounds
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewayAutoScaleConfiguration
/// Virtual Network Gateway Autoscale Configuration details
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecAutoScaleConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250301.VirtualNetworkGatewayAutoScaleBounds</summary>
    [JsonPropertyName("bounds")]
    public V20250301storageVirtualNetworkGatewaySpecAutoScaleConfigurationBounds? Bounds { get; set; }
}

/// <summary>
/// Storage version of v20250301.IPConfigurationBgpPeeringAddress
/// Properties of IPConfigurationBgpPeeringAddress.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecBgpSettingsBgpPeeringAddresses
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customBgpIpAddresses")]
    public IList<string>? CustomBgpIpAddresses { get; set; }

    [JsonPropertyName("ipconfigurationId")]
    public string? IpconfigurationId { get; set; }
}

/// <summary>
/// Storage version of v20250301.BgpSettings
/// BGP settings details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecBgpSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("asn")]
    public int? Asn { get; set; }

    [JsonPropertyName("bgpPeeringAddress")]
    public string? BgpPeeringAddress { get; set; }

    [JsonPropertyName("bgpPeeringAddresses")]
    public IList<V20250301storageVirtualNetworkGatewaySpecBgpSettingsBgpPeeringAddresses>? BgpPeeringAddresses { get; set; }

    [JsonPropertyName("peerWeight")]
    public int? PeerWeight { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecCustomRoutesIpamPoolPrefixAllocationsReference
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
/// Storage version of v20250301.IpamPoolPrefixAllocation
/// IpamPool prefix allocation reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecCustomRoutesIpamPoolPrefixAllocations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }

    /// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("reference")]
    public V20250301storageVirtualNetworkGatewaySpecCustomRoutesIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250301.AddressSpace
/// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecCustomRoutes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301storageVirtualNetworkGatewaySpecCustomRoutesIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>
/// Storage version of v20250301.ExtendedLocation
/// ExtendedLocation complex type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecExtendedLocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecGatewayDefaultSiteReference
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
/// Storage version of v20250301.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecGatewayDefaultSite
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301storageVirtualNetworkGatewaySpecGatewayDefaultSiteReference? Reference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v20250301.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250301storageVirtualNetworkGatewaySpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250301.ManagedServiceIdentity
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250301storageVirtualNetworkGatewaySpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddressReference
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
/// Storage version of v20250301.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddress
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecIpConfigurationsSubnetReference
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
/// Storage version of v20250301.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecIpConfigurationsSubnet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301storageVirtualNetworkGatewaySpecIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewayIPConfiguration
/// IP configuration for virtual network gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecIpConfigurations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("privateIPAllocationMethod")]
    public string? PrivateIPAllocationMethod { get; set; }

    /// <summary>
    /// Storage version of v20250301.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("publicIPAddress")]
    public V20250301storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>
    /// Storage version of v20250301.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("subnet")]
    public V20250301storageVirtualNetworkGatewaySpecIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>
/// Storage version of v20250301.VpnNatRuleMapping
/// Vpn NatRule mapping.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecNatRulesExternalMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>
/// Storage version of v20250301.VpnNatRuleMapping
/// Vpn NatRule mapping.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecNatRulesInternalMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewayNatRule
/// VirtualNetworkGatewayNatRule Resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecNatRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("externalMappings")]
    public IList<V20250301storageVirtualNetworkGatewaySpecNatRulesExternalMappings>? ExternalMappings { get; set; }

    [JsonPropertyName("internalMappings")]
    public IList<V20250301storageVirtualNetworkGatewaySpecNatRulesInternalMappings>? InternalMappings { get; set; }

    [JsonPropertyName("ipConfigurationId")]
    public string? IpConfigurationId { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecOperatorSpecConfigMapExpressions
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
public partial class V20250301storageVirtualNetworkGatewaySpecOperatorSpecSecretExpressions
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
/// Storage version of v20250301.VirtualNetworkGatewayOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20250301storageVirtualNetworkGatewaySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20250301storageVirtualNetworkGatewaySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewaySku
/// VirtualNetworkGatewaySku details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// VNetExtendedLocationResourceReference: Customer vnet resource id. VirtualNetworkGateway of type local gateway is
/// associated with the customer vnet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVNetExtendedLocationResourceReference
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
/// Storage version of v20250301.VirtualNetworkGatewayMigrationStatus
/// Migration status for the Virtual Network Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVirtualNetworkGatewayMigrationStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewayPolicyGroupMember
/// Vpn Client Connection configuration PolicyGroup member
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroupsPolicyMembers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("attributeType")]
    public string? AttributeType { get; set; }

    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewayPolicyGroup
/// Parameters for VirtualNetworkGatewayPolicyGroup.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroups
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("policyMembers")]
    public IList<V20250301storageVirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroupsPolicyMembers>? PolicyMembers { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationRadiusServerSecret
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
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationRadiusServersRadiusServerSecret
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
/// Storage version of v20250301.RadiusServer
/// Radius Server Settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationRadiusServers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    [JsonPropertyName("radiusServerScore")]
    public int? RadiusServerScore { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("radiusServerSecret")]
    public V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationRadiusServersRadiusServerSecret? RadiusServerSecret { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurationsReference
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
/// Storage version of v20250301.VngClientConnectionConfiguration
/// A vpn client connection configuration for client connection configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurationsReference? Reference { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocationsReference
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
/// Storage version of v20250301.IpamPoolPrefixAllocation
/// IpamPool prefix allocation reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }

    /// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("reference")]
    public V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250301.AddressSpace
/// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>
/// Storage version of v20250301.IpsecPolicy
/// An IPSec Policy configuration for a virtual network gateway connection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPolicies
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    [JsonPropertyName("saDataSizeKilobytes")]
    public int? SaDataSizeKilobytes { get; set; }

    [JsonPropertyName("saLifeTimeSeconds")]
    public int? SaLifeTimeSeconds { get; set; }
}

/// <summary>
/// Storage version of v20250301.VpnClientRevokedCertificate
/// VPN client revoked certificate of virtual network gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRevokedCertificates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>
/// Storage version of v20250301.VpnClientRootCertificate
/// VPN client root certificate of virtual network gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRootCertificates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>
/// Storage version of v20250301.VpnClientConfiguration
/// VpnClientConfiguration for P2S client.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpecVpnClientConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("aadAudience")]
    public string? AadAudience { get; set; }

    [JsonPropertyName("aadIssuer")]
    public string? AadIssuer { get; set; }

    [JsonPropertyName("aadTenant")]
    public string? AadTenant { get; set; }

    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("radiusServerSecret")]
    public V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationRadiusServerSecret? RadiusServerSecret { get; set; }

    [JsonPropertyName("radiusServers")]
    public IList<V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationRadiusServers>? RadiusServers { get; set; }

    [JsonPropertyName("vngClientConnectionConfigurations")]
    public IList<V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurations>? VngClientConnectionConfigurations { get; set; }

    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }

    [JsonPropertyName("vpnClientIpsecPolicies")]
    public IList<V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPolicies>? VpnClientIpsecPolicies { get; set; }

    [JsonPropertyName("vpnClientProtocols")]
    public IList<string>? VpnClientProtocols { get; set; }

    [JsonPropertyName("vpnClientRevokedCertificates")]
    public IList<V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRevokedCertificates>? VpnClientRevokedCertificates { get; set; }

    [JsonPropertyName("vpnClientRootCertificates")]
    public IList<V20250301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRootCertificates>? VpnClientRootCertificates { get; set; }
}

/// <summary>Storage version of v20250301.VirtualNetworkGateway_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewaySpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    [JsonPropertyName("adminState")]
    public string? AdminState { get; set; }

    [JsonPropertyName("allowRemoteVnetTraffic")]
    public bool? AllowRemoteVnetTraffic { get; set; }

    [JsonPropertyName("allowVirtualWanTraffic")]
    public bool? AllowVirtualWanTraffic { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworkGatewayAutoScaleConfiguration
    /// Virtual Network Gateway Autoscale Configuration details
    /// </summary>
    [JsonPropertyName("autoScaleConfiguration")]
    public V20250301storageVirtualNetworkGatewaySpecAutoScaleConfiguration? AutoScaleConfiguration { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v20250301.BgpSettings
    /// BGP settings details.
    /// </summary>
    [JsonPropertyName("bgpSettings")]
    public V20250301storageVirtualNetworkGatewaySpecBgpSettings? BgpSettings { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("customRoutes")]
    public V20250301storageVirtualNetworkGatewaySpecCustomRoutes? CustomRoutes { get; set; }

    [JsonPropertyName("disableIPSecReplayProtection")]
    public bool? DisableIPSecReplayProtection { get; set; }

    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    [JsonPropertyName("enableBgpRouteTranslationForNat")]
    public bool? EnableBgpRouteTranslationForNat { get; set; }

    [JsonPropertyName("enableDnsForwarding")]
    public bool? EnableDnsForwarding { get; set; }

    [JsonPropertyName("enableHighBandwidthVpnGateway")]
    public bool? EnableHighBandwidthVpnGateway { get; set; }

    [JsonPropertyName("enablePrivateIpAddress")]
    public bool? EnablePrivateIpAddress { get; set; }

    /// <summary>
    /// Storage version of v20250301.ExtendedLocation
    /// ExtendedLocation complex type.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20250301storageVirtualNetworkGatewaySpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// Storage version of v20250301.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("gatewayDefaultSite")]
    public V20250301storageVirtualNetworkGatewaySpecGatewayDefaultSite? GatewayDefaultSite { get; set; }

    [JsonPropertyName("gatewayType")]
    public string? GatewayType { get; set; }

    /// <summary>
    /// Storage version of v20250301.ManagedServiceIdentity
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250301storageVirtualNetworkGatewaySpecIdentity? Identity { get; set; }

    [JsonPropertyName("ipConfigurations")]
    public IList<V20250301storageVirtualNetworkGatewaySpecIpConfigurations>? IpConfigurations { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("natRules")]
    public IList<V20250301storageVirtualNetworkGatewaySpecNatRules>? NatRules { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworkGatewayOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250301storageVirtualNetworkGatewaySpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250301storageVirtualNetworkGatewaySpecOwner Owner { get; set; }

    [JsonPropertyName("resiliencyModel")]
    public string? ResiliencyModel { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworkGatewaySku
    /// VirtualNetworkGatewaySku details.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20250301storageVirtualNetworkGatewaySpecSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// VNetExtendedLocationResourceReference: Customer vnet resource id. VirtualNetworkGateway of type local gateway is
    /// associated with the customer vnet.
    /// </summary>
    [JsonPropertyName("vNetExtendedLocationResourceReference")]
    public V20250301storageVirtualNetworkGatewaySpecVNetExtendedLocationResourceReference? VNetExtendedLocationResourceReference { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworkGatewayMigrationStatus
    /// Migration status for the Virtual Network Gateway.
    /// </summary>
    [JsonPropertyName("virtualNetworkGatewayMigrationStatus")]
    public V20250301storageVirtualNetworkGatewaySpecVirtualNetworkGatewayMigrationStatus? VirtualNetworkGatewayMigrationStatus { get; set; }

    [JsonPropertyName("virtualNetworkGatewayPolicyGroups")]
    public IList<V20250301storageVirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroups>? VirtualNetworkGatewayPolicyGroups { get; set; }

    /// <summary>
    /// Storage version of v20250301.VpnClientConfiguration
    /// VpnClientConfiguration for P2S client.
    /// </summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public V20250301storageVirtualNetworkGatewaySpecVpnClientConfiguration? VpnClientConfiguration { get; set; }

    [JsonPropertyName("vpnGatewayGeneration")]
    public string? VpnGatewayGeneration { get; set; }

    [JsonPropertyName("vpnType")]
    public string? VpnType { get; set; }
}

/// <summary>Storage version of v20250301.VirtualNetworkGatewayAutoScaleBounds_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusAutoScaleConfigurationBounds
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewayAutoScaleConfiguration_STATUS
/// Virtual Network Gateway Autoscale Configuration details
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusAutoScaleConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250301.VirtualNetworkGatewayAutoScaleBounds_STATUS</summary>
    [JsonPropertyName("bounds")]
    public V20250301storageVirtualNetworkGatewayStatusAutoScaleConfigurationBounds? Bounds { get; set; }
}

/// <summary>
/// Storage version of v20250301.IPConfigurationBgpPeeringAddress_STATUS
/// Properties of IPConfigurationBgpPeeringAddress.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusBgpSettingsBgpPeeringAddresses
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customBgpIpAddresses")]
    public IList<string>? CustomBgpIpAddresses { get; set; }

    [JsonPropertyName("defaultBgpIpAddresses")]
    public IList<string>? DefaultBgpIpAddresses { get; set; }

    [JsonPropertyName("ipconfigurationId")]
    public string? IpconfigurationId { get; set; }

    [JsonPropertyName("tunnelIpAddresses")]
    public IList<string>? TunnelIpAddresses { get; set; }
}

/// <summary>
/// Storage version of v20250301.BgpSettings_STATUS
/// BGP settings details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusBgpSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("asn")]
    public int? Asn { get; set; }

    [JsonPropertyName("bgpPeeringAddress")]
    public string? BgpPeeringAddress { get; set; }

    [JsonPropertyName("bgpPeeringAddresses")]
    public IList<V20250301storageVirtualNetworkGatewayStatusBgpSettingsBgpPeeringAddresses>? BgpPeeringAddresses { get; set; }

    [JsonPropertyName("peerWeight")]
    public int? PeerWeight { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusConditions
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

/// <summary>
/// Storage version of v20250301.IpamPoolPrefixAllocation_STATUS
/// IpamPool prefix allocation reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusCustomRoutesIpamPoolPrefixAllocations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allocatedAddressPrefixes")]
    public IList<string>? AllocatedAddressPrefixes { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }
}

/// <summary>
/// Storage version of v20250301.AddressSpace_STATUS
/// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusCustomRoutes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301storageVirtualNetworkGatewayStatusCustomRoutesIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>
/// Storage version of v20250301.ExtendedLocation_STATUS
/// ExtendedLocation complex type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusExtendedLocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250301.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusGatewayDefaultSite
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v20250301.ManagedServiceIdentity_UserAssignedIdentities_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Storage version of v20250301.ManagedServiceIdentity_STATUS
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250301storageVirtualNetworkGatewayStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v20250301.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusIpConfigurationsPublicIPAddress
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20250301.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusIpConfigurationsSubnet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewayIPConfiguration_STATUS
/// IP configuration for virtual network gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusIpConfigurations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    [JsonPropertyName("privateIPAllocationMethod")]
    public string? PrivateIPAllocationMethod { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// Storage version of v20250301.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("publicIPAddress")]
    public V20250301storageVirtualNetworkGatewayStatusIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>
    /// Storage version of v20250301.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("subnet")]
    public V20250301storageVirtualNetworkGatewayStatusIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>
/// Storage version of v20250301.VpnNatRuleMapping_STATUS
/// Vpn NatRule mapping.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusNatRulesExternalMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>
/// Storage version of v20250301.VpnNatRuleMapping_STATUS
/// Vpn NatRule mapping.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusNatRulesInternalMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewayNatRule_STATUS
/// VirtualNetworkGatewayNatRule Resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusNatRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("externalMappings")]
    public IList<V20250301storageVirtualNetworkGatewayStatusNatRulesExternalMappings>? ExternalMappings { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("internalMappings")]
    public IList<V20250301storageVirtualNetworkGatewayStatusNatRulesInternalMappings>? InternalMappings { get; set; }

    [JsonPropertyName("ipConfigurationId")]
    public string? IpConfigurationId { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewaySku_STATUS
/// VirtualNetworkGatewaySku details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewayMigrationStatus_STATUS
/// Migration status for the Virtual Network Gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayMigrationStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewayPolicyGroupMember_STATUS
/// Vpn Client Connection configuration PolicyGroup member
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsPolicyMembers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("attributeType")]
    public string? AttributeType { get; set; }

    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20250301.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsVngClientConnectionConfigurations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGatewayPolicyGroup_STATUS
/// Parameters for VirtualNetworkGatewayPolicyGroup.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroups
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("policyMembers")]
    public IList<V20250301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsPolicyMembers>? PolicyMembers { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("vngClientConnectionConfigurations")]
    public IList<V20250301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsVngClientConnectionConfigurations>? VngClientConnectionConfigurations { get; set; }
}

/// <summary>
/// Storage version of v20250301.RadiusServer_STATUS
/// Radius Server Settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationRadiusServers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    [JsonPropertyName("radiusServerScore")]
    public int? RadiusServerScore { get; set; }
}

/// <summary>
/// Storage version of v20250301.VngClientConnectionConfiguration_STATUS
/// A vpn client connection configuration for client connection configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVngClientConnectionConfigurations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20250301.IpamPoolPrefixAllocation_STATUS
/// IpamPool prefix allocation reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allocatedAddressPrefixes")]
    public IList<string>? AllocatedAddressPrefixes { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }
}

/// <summary>
/// Storage version of v20250301.AddressSpace_STATUS
/// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPoolIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>
/// Storage version of v20250301.IpsecPolicy_STATUS
/// An IPSec Policy configuration for a virtual network gateway connection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientIpsecPolicies
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    [JsonPropertyName("saDataSizeKilobytes")]
    public int? SaDataSizeKilobytes { get; set; }

    [JsonPropertyName("saLifeTimeSeconds")]
    public int? SaLifeTimeSeconds { get; set; }
}

/// <summary>
/// Storage version of v20250301.VpnClientRevokedCertificate_STATUS
/// VPN client revoked certificate of virtual network gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRevokedCertificates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>
/// Storage version of v20250301.VpnClientRootCertificate_STATUS
/// VPN client root certificate of virtual network gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRootCertificates
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>
/// Storage version of v20250301.VpnClientConfiguration_STATUS
/// VpnClientConfiguration for P2S client.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatusVpnClientConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("aadAudience")]
    public string? AadAudience { get; set; }

    [JsonPropertyName("aadIssuer")]
    public string? AadIssuer { get; set; }

    [JsonPropertyName("aadTenant")]
    public string? AadTenant { get; set; }

    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    [JsonPropertyName("radiusServers")]
    public IList<V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationRadiusServers>? RadiusServers { get; set; }

    [JsonPropertyName("vngClientConnectionConfigurations")]
    public IList<V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVngClientConnectionConfigurations>? VngClientConnectionConfigurations { get; set; }

    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace_STATUS
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }

    [JsonPropertyName("vpnClientIpsecPolicies")]
    public IList<V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientIpsecPolicies>? VpnClientIpsecPolicies { get; set; }

    [JsonPropertyName("vpnClientProtocols")]
    public IList<string>? VpnClientProtocols { get; set; }

    [JsonPropertyName("vpnClientRevokedCertificates")]
    public IList<V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRevokedCertificates>? VpnClientRevokedCertificates { get; set; }

    [JsonPropertyName("vpnClientRootCertificates")]
    public IList<V20250301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRootCertificates>? VpnClientRootCertificates { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGateway_STATUS
/// A common class for general resource information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworkGatewayStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    [JsonPropertyName("adminState")]
    public string? AdminState { get; set; }

    [JsonPropertyName("allowRemoteVnetTraffic")]
    public bool? AllowRemoteVnetTraffic { get; set; }

    [JsonPropertyName("allowVirtualWanTraffic")]
    public bool? AllowVirtualWanTraffic { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworkGatewayAutoScaleConfiguration_STATUS
    /// Virtual Network Gateway Autoscale Configuration details
    /// </summary>
    [JsonPropertyName("autoScaleConfiguration")]
    public V20250301storageVirtualNetworkGatewayStatusAutoScaleConfiguration? AutoScaleConfiguration { get; set; }

    /// <summary>
    /// Storage version of v20250301.BgpSettings_STATUS
    /// BGP settings details.
    /// </summary>
    [JsonPropertyName("bgpSettings")]
    public V20250301storageVirtualNetworkGatewayStatusBgpSettings? BgpSettings { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20250301storageVirtualNetworkGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace_STATUS
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("customRoutes")]
    public V20250301storageVirtualNetworkGatewayStatusCustomRoutes? CustomRoutes { get; set; }

    [JsonPropertyName("disableIPSecReplayProtection")]
    public bool? DisableIPSecReplayProtection { get; set; }

    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    [JsonPropertyName("enableBgpRouteTranslationForNat")]
    public bool? EnableBgpRouteTranslationForNat { get; set; }

    [JsonPropertyName("enableDnsForwarding")]
    public bool? EnableDnsForwarding { get; set; }

    [JsonPropertyName("enableHighBandwidthVpnGateway")]
    public bool? EnableHighBandwidthVpnGateway { get; set; }

    [JsonPropertyName("enablePrivateIpAddress")]
    public bool? EnablePrivateIpAddress { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Storage version of v20250301.ExtendedLocation_STATUS
    /// ExtendedLocation complex type.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20250301storageVirtualNetworkGatewayStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// Storage version of v20250301.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("gatewayDefaultSite")]
    public V20250301storageVirtualNetworkGatewayStatusGatewayDefaultSite? GatewayDefaultSite { get; set; }

    [JsonPropertyName("gatewayType")]
    public string? GatewayType { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20250301.ManagedServiceIdentity_STATUS
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250301storageVirtualNetworkGatewayStatusIdentity? Identity { get; set; }

    [JsonPropertyName("inboundDnsForwardingEndpoint")]
    public string? InboundDnsForwardingEndpoint { get; set; }

    [JsonPropertyName("ipConfigurations")]
    public IList<V20250301storageVirtualNetworkGatewayStatusIpConfigurations>? IpConfigurations { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("natRules")]
    public IList<V20250301storageVirtualNetworkGatewayStatusNatRules>? NatRules { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("resiliencyModel")]
    public string? ResiliencyModel { get; set; }

    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworkGatewaySku_STATUS
    /// VirtualNetworkGatewaySku details.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20250301storageVirtualNetworkGatewayStatusSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("vNetExtendedLocationResourceId")]
    public string? VNetExtendedLocationResourceId { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworkGatewayMigrationStatus_STATUS
    /// Migration status for the Virtual Network Gateway.
    /// </summary>
    [JsonPropertyName("virtualNetworkGatewayMigrationStatus")]
    public V20250301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayMigrationStatus? VirtualNetworkGatewayMigrationStatus { get; set; }

    [JsonPropertyName("virtualNetworkGatewayPolicyGroups")]
    public IList<V20250301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroups>? VirtualNetworkGatewayPolicyGroups { get; set; }

    /// <summary>
    /// Storage version of v20250301.VpnClientConfiguration_STATUS
    /// VpnClientConfiguration for P2S client.
    /// </summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public V20250301storageVirtualNetworkGatewayStatusVpnClientConfiguration? VpnClientConfiguration { get; set; }

    [JsonPropertyName("vpnGatewayGeneration")]
    public string? VpnGatewayGeneration { get; set; }

    [JsonPropertyName("vpnType")]
    public string? VpnType { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkGateway
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/virtualNetworkGateway.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301storageVirtualNetworkGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V20250301storageVirtualNetworkGatewaySpec?>, IStatus<V20250301storageVirtualNetworkGatewayStatus?>
{
    public const string KubeApiVersion = "v20250301storage";
    public const string KubeKind = "VirtualNetworkGateway";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworkgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworkGateway";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20250301.VirtualNetworkGateway_Spec</summary>
    [JsonPropertyName("spec")]
    public V20250301storageVirtualNetworkGatewaySpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworkGateway_STATUS
    /// A common class for general resource information.
    /// </summary>
    [JsonPropertyName("status")]
    public V20250301storageVirtualNetworkGatewayStatus? Status { get; set; }
}