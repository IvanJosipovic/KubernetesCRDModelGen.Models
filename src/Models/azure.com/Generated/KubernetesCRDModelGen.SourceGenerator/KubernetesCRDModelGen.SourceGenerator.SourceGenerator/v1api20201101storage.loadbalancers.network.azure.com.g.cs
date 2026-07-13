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
/// Storage version of v1api20201101.LoadBalancer
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2020-11-01/loadBalancer.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201101storageLoadBalancerList : IKubernetesObject<V1ListMeta>, IItems<V1api20201101storageLoadBalancer>
{
    public const string KubeApiVersion = "v1api20201101storage";
    public const string KubeKind = "LoadBalancerList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "loadbalancers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20201101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20201101storageLoadBalancer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20201101storageLoadBalancer> Items { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfigurationReference
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
/// Storage version of v1api20201101.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnetReference
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
/// Storage version of v1api20201101.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnetReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetworkReference
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
/// Storage version of v1api20201101.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetworkReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.LoadBalancerBackendAddress
/// Load balancer backend addresses.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddresses
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("loadBalancerFrontendIPConfiguration")]
    public V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration? LoadBalancerFrontendIPConfiguration { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("subnet")]
    public V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesSubnet? Subnet { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("virtualNetwork")]
    public V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork? VirtualNetwork { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.BackendAddressPool_LoadBalancer_SubResourceEmbedded
/// Pool of backend IP addresses.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecBackendAddressPools
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("loadBalancerBackendAddresses")]
    public IList<V1api20201101storageLoadBalancerSpecBackendAddressPoolsLoadBalancerBackendAddresses>? LoadBalancerBackendAddresses { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.ExtendedLocation
/// ExtendedLocation complex type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecExtendedLocation
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
public partial class V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsPublicIPAddressReference
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
/// Storage version of v1api20201101.PublicIPAddressSpec_LoadBalancer_SubResourceEmbedded
/// Public IP address resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsPublicIPAddress
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsPublicIPPrefixReference
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
/// Storage version of v1api20201101.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsPublicIPPrefix
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsPublicIPPrefixReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsSubnetReference
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
/// Storage version of v1api20201101.Subnet_LoadBalancer_SubResourceEmbedded
/// Subnet in a virtual network resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsSubnet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.FrontendIPConfiguration_LoadBalancer_SubResourceEmbedded
/// Frontend IP address of the load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecFrontendIPConfigurations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    [JsonPropertyName("privateIPAddressVersion")]
    public string? PrivateIPAddressVersion { get; set; }

    [JsonPropertyName("privateIPAllocationMethod")]
    public string? PrivateIPAllocationMethod { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.PublicIPAddressSpec_LoadBalancer_SubResourceEmbedded
    /// Public IP address resource.
    /// </summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.Subnet_LoadBalancer_SubResourceEmbedded
    /// Subnet in a virtual network resource.
    /// </summary>
    [JsonPropertyName("subnet")]
    public V1api20201101storageLoadBalancerSpecFrontendIPConfigurationsSubnet? Subnet { get; set; }

    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecInboundNatPoolsFrontendIPConfigurationReference
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
/// Storage version of v1api20201101.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecInboundNatPoolsFrontendIPConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecInboundNatPoolsFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.InboundNatPool
/// Inbound NAT pool of the load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecInboundNatPools
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101storageLoadBalancerSpecInboundNatPoolsFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    [JsonPropertyName("frontendPortRangeEnd")]
    public int? FrontendPortRangeEnd { get; set; }

    [JsonPropertyName("frontendPortRangeStart")]
    public int? FrontendPortRangeStart { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecInboundNatRulesFrontendIPConfigurationReference
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
/// Storage version of v1api20201101.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecInboundNatRulesFrontendIPConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecInboundNatRulesFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.InboundNatRule_LoadBalancer_SubResourceEmbedded
/// Inbound NAT rule of the load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecInboundNatRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101storageLoadBalancerSpecInboundNatRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    [JsonPropertyName("frontendPort")]
    public int? FrontendPort { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecLoadBalancingRulesBackendAddressPoolReference
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
/// Storage version of v1api20201101.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecLoadBalancingRulesBackendAddressPool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecLoadBalancingRulesBackendAddressPoolReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecLoadBalancingRulesFrontendIPConfigurationReference
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
/// Storage version of v1api20201101.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecLoadBalancingRulesFrontendIPConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecLoadBalancingRulesFrontendIPConfigurationReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecLoadBalancingRulesProbeReference
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
/// Storage version of v1api20201101.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecLoadBalancingRulesProbe
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecLoadBalancingRulesProbeReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.LoadBalancingRule
/// A load balancing rule for a load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecLoadBalancingRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20201101storageLoadBalancerSpecLoadBalancingRulesBackendAddressPool? BackendAddressPool { get; set; }

    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    [JsonPropertyName("disableOutboundSnat")]
    public bool? DisableOutboundSnat { get; set; }

    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101storageLoadBalancerSpecLoadBalancingRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    [JsonPropertyName("frontendPort")]
    public int? FrontendPort { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    [JsonPropertyName("loadDistribution")]
    public string? LoadDistribution { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("probe")]
    public V1api20201101storageLoadBalancerSpecLoadBalancingRulesProbe? Probe { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20201101storageLoadBalancerSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20201101.LoadBalancerOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20201101storageLoadBalancerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20201101storageLoadBalancerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecOutboundRulesBackendAddressPoolReference
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
/// Storage version of v1api20201101.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecOutboundRulesBackendAddressPool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecOutboundRulesBackendAddressPoolReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecOutboundRulesFrontendIPConfigurationsReference
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
/// Storage version of v1api20201101.SubResource
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecOutboundRulesFrontendIPConfigurations
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageLoadBalancerSpecOutboundRulesFrontendIPConfigurationsReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.OutboundRule
/// Outbound rule of the load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecOutboundRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20201101storageLoadBalancerSpecOutboundRulesBackendAddressPool? BackendAddressPool { get; set; }

    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20201101storageLoadBalancerSpecOutboundRulesFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.Probe
/// A load balancer probe.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecProbes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("numberOfProbes")]
    public int? NumberOfProbes { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.LoadBalancerSku
/// SKU of a load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpecSku
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

/// <summary>Storage version of v1api20201101.LoadBalancer_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20201101storageLoadBalancerSpecBackendAddressPools>? BackendAddressPools { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.ExtendedLocation
    /// ExtendedLocation complex type.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201101storageLoadBalancerSpecExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20201101storageLoadBalancerSpecFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    [JsonPropertyName("inboundNatPools")]
    public IList<V1api20201101storageLoadBalancerSpecInboundNatPools>? InboundNatPools { get; set; }

    [JsonPropertyName("inboundNatRules")]
    public IList<V1api20201101storageLoadBalancerSpecInboundNatRules>? InboundNatRules { get; set; }

    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20201101storageLoadBalancerSpecLoadBalancingRules>? LoadBalancingRules { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.LoadBalancerOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20201101storageLoadBalancerSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    [JsonPropertyName("outboundRules")]
    public IList<V1api20201101storageLoadBalancerSpecOutboundRules>? OutboundRules { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20201101storageLoadBalancerSpecOwner Owner { get; set; }

    [JsonPropertyName("probes")]
    public IList<V1api20201101storageLoadBalancerSpecProbes>? Probes { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.LoadBalancerSku
    /// SKU of a load balancer.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20201101storageLoadBalancerSpecSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.NetworkInterfaceIPConfiguration_STATUS_LoadBalancer_SubResourceEmbedded
/// IPConfiguration in a network interface.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusBackendAddressPoolsBackendIPConfigurations
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesNetworkInterfaceIPConfiguration
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesSubnet
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork
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
/// Storage version of v1api20201101.LoadBalancerBackendAddress_STATUS
/// Load balancer backend addresses.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddresses
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("loadBalancerFrontendIPConfiguration")]
    public V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesLoadBalancerFrontendIPConfiguration? LoadBalancerFrontendIPConfiguration { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("networkInterfaceIPConfiguration")]
    public V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesNetworkInterfaceIPConfiguration? NetworkInterfaceIPConfiguration { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("subnet")]
    public V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesSubnet? Subnet { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("virtualNetwork")]
    public V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddressesVirtualNetwork? VirtualNetwork { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancingRules
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusBackendAddressPoolsOutboundRule
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusBackendAddressPoolsOutboundRules
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
/// Storage version of v1api20201101.BackendAddressPool_STATUS_LoadBalancer_SubResourceEmbedded
/// Pool of backend IP addresses.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusBackendAddressPools
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backendIPConfigurations")]
    public IList<V1api20201101storageLoadBalancerStatusBackendAddressPoolsBackendIPConfigurations>? BackendIPConfigurations { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("loadBalancerBackendAddresses")]
    public IList<V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancerBackendAddresses>? LoadBalancerBackendAddresses { get; set; }

    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20201101storageLoadBalancerStatusBackendAddressPoolsLoadBalancingRules>? LoadBalancingRules { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("outboundRule")]
    public V1api20201101storageLoadBalancerStatusBackendAddressPoolsOutboundRule? OutboundRule { get; set; }

    [JsonPropertyName("outboundRules")]
    public IList<V1api20201101storageLoadBalancerStatusBackendAddressPoolsOutboundRules>? OutboundRules { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusConditions
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
/// Storage version of v1api20201101.ExtendedLocation_STATUS
/// ExtendedLocation complex type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusExtendedLocation
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsInboundNatPools
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsInboundNatRules
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsLoadBalancingRules
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsOutboundRules
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
/// Storage version of v1api20201101.PublicIPAddress_STATUS_LoadBalancer_SubResourceEmbedded
/// Public IP address resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsPublicIPAddress
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsPublicIPPrefix
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
/// Storage version of v1api20201101.Subnet_STATUS_LoadBalancer_SubResourceEmbedded
/// Subnet in a virtual network resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsSubnet
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
/// Storage version of v1api20201101.FrontendIPConfiguration_STATUS_LoadBalancer_SubResourceEmbedded
/// Frontend IP address of the load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusFrontendIPConfigurations
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

    [JsonPropertyName("inboundNatPools")]
    public IList<V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsInboundNatPools>? InboundNatPools { get; set; }

    [JsonPropertyName("inboundNatRules")]
    public IList<V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsInboundNatRules>? InboundNatRules { get; set; }

    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsLoadBalancingRules>? LoadBalancingRules { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("outboundRules")]
    public IList<V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsOutboundRules>? OutboundRules { get; set; }

    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    [JsonPropertyName("privateIPAddressVersion")]
    public string? PrivateIPAddressVersion { get; set; }

    [JsonPropertyName("privateIPAllocationMethod")]
    public string? PrivateIPAllocationMethod { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.PublicIPAddress_STATUS_LoadBalancer_SubResourceEmbedded
    /// Public IP address resource.
    /// </summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.Subnet_STATUS_LoadBalancer_SubResourceEmbedded
    /// Subnet in a virtual network resource.
    /// </summary>
    [JsonPropertyName("subnet")]
    public V1api20201101storageLoadBalancerStatusFrontendIPConfigurationsSubnet? Subnet { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusInboundNatPoolsFrontendIPConfiguration
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
/// Storage version of v1api20201101.InboundNatPool_STATUS
/// Inbound NAT pool of the load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusInboundNatPools
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101storageLoadBalancerStatusInboundNatPoolsFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    [JsonPropertyName("frontendPortRangeEnd")]
    public int? FrontendPortRangeEnd { get; set; }

    [JsonPropertyName("frontendPortRangeStart")]
    public int? FrontendPortRangeStart { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.NetworkInterfaceIPConfiguration_STATUS_LoadBalancer_SubResourceEmbedded
/// IPConfiguration in a network interface.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusInboundNatRulesBackendIPConfiguration
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusInboundNatRulesFrontendIPConfiguration
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
/// Storage version of v1api20201101.InboundNatRule_STATUS_LoadBalancer_SubResourceEmbedded
/// Inbound NAT rule of the load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusInboundNatRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.NetworkInterfaceIPConfiguration_STATUS_LoadBalancer_SubResourceEmbedded
    /// IPConfiguration in a network interface.
    /// </summary>
    [JsonPropertyName("backendIPConfiguration")]
    public V1api20201101storageLoadBalancerStatusInboundNatRulesBackendIPConfiguration? BackendIPConfiguration { get; set; }

    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101storageLoadBalancerStatusInboundNatRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    [JsonPropertyName("frontendPort")]
    public int? FrontendPort { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusLoadBalancingRulesBackendAddressPool
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusLoadBalancingRulesFrontendIPConfiguration
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusLoadBalancingRulesProbe
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
/// Storage version of v1api20201101.LoadBalancingRule_STATUS
/// A load balancing rule for a load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusLoadBalancingRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20201101storageLoadBalancerStatusLoadBalancingRulesBackendAddressPool? BackendAddressPool { get; set; }

    [JsonPropertyName("backendPort")]
    public int? BackendPort { get; set; }

    [JsonPropertyName("disableOutboundSnat")]
    public bool? DisableOutboundSnat { get; set; }

    [JsonPropertyName("enableFloatingIP")]
    public bool? EnableFloatingIP { get; set; }

    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("frontendIPConfiguration")]
    public V1api20201101storageLoadBalancerStatusLoadBalancingRulesFrontendIPConfiguration? FrontendIPConfiguration { get; set; }

    [JsonPropertyName("frontendPort")]
    public int? FrontendPort { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    [JsonPropertyName("loadDistribution")]
    public string? LoadDistribution { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("probe")]
    public V1api20201101storageLoadBalancerStatusLoadBalancingRulesProbe? Probe { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusOutboundRulesBackendAddressPool
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
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusOutboundRulesFrontendIPConfigurations
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
/// Storage version of v1api20201101.OutboundRule_STATUS
/// Outbound rule of the load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusOutboundRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("backendAddressPool")]
    public V1api20201101storageLoadBalancerStatusOutboundRulesBackendAddressPool? BackendAddressPool { get; set; }

    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20201101storageLoadBalancerStatusOutboundRulesFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusProbesLoadBalancingRules
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
/// Storage version of v1api20201101.Probe_STATUS
/// A load balancer probe.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusProbes
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

    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20201101storageLoadBalancerStatusProbesLoadBalancingRules>? LoadBalancingRules { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("numberOfProbes")]
    public int? NumberOfProbes { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("requestPath")]
    public string? RequestPath { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.LoadBalancerSku_STATUS
/// SKU of a load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatusSku
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
/// Storage version of v1api20201101.LoadBalancer_STATUS
/// LoadBalancer resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101storageLoadBalancerStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backendAddressPools")]
    public IList<V1api20201101storageLoadBalancerStatusBackendAddressPools>? BackendAddressPools { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20201101storageLoadBalancerStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.ExtendedLocation_STATUS
    /// ExtendedLocation complex type.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201101storageLoadBalancerStatusExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("frontendIPConfigurations")]
    public IList<V1api20201101storageLoadBalancerStatusFrontendIPConfigurations>? FrontendIPConfigurations { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("inboundNatPools")]
    public IList<V1api20201101storageLoadBalancerStatusInboundNatPools>? InboundNatPools { get; set; }

    [JsonPropertyName("inboundNatRules")]
    public IList<V1api20201101storageLoadBalancerStatusInboundNatRules>? InboundNatRules { get; set; }

    [JsonPropertyName("loadBalancingRules")]
    public IList<V1api20201101storageLoadBalancerStatusLoadBalancingRules>? LoadBalancingRules { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("outboundRules")]
    public IList<V1api20201101storageLoadBalancerStatusOutboundRules>? OutboundRules { get; set; }

    [JsonPropertyName("probes")]
    public IList<V1api20201101storageLoadBalancerStatusProbes>? Probes { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.LoadBalancerSku_STATUS
    /// SKU of a load balancer.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20201101storageLoadBalancerStatusSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20201101.LoadBalancer
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2020-11-01/loadBalancer.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201101storageLoadBalancer : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20201101storageLoadBalancerSpec?>, IStatus<V1api20201101storageLoadBalancerStatus?>
{
    public const string KubeApiVersion = "v1api20201101storage";
    public const string KubeKind = "LoadBalancer";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "loadbalancers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20201101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20201101.LoadBalancer_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20201101storageLoadBalancerSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v1api20201101.LoadBalancer_STATUS
    /// LoadBalancer resource.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20201101storageLoadBalancerStatus? Status { get; set; }
}