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
/// Storage version of v20250301.VirtualNetworksVirtualNetworkPeering
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/virtualNetwork.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringList : IKubernetesObject<V1ListMeta>, IItems<V20250301storageVirtualNetworksVirtualNetworkPeering>
{
    public const string KubeApiVersion = "v20250301storage";
    public const string KubeKind = "VirtualNetworksVirtualNetworkPeeringList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworksvirtualnetworkpeerings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworksVirtualNetworkPeeringList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250301storageVirtualNetworksVirtualNetworkPeering objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250301storageVirtualNetworksVirtualNetworkPeering> Items { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpaceIpamPoolPrefixAllocationsReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpaceIpamPoolPrefixAllocations
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
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpaceIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250301.AddressSpace
/// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpace
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
    public IList<V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocationsReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocations
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
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250301.AddressSpace
/// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpace
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
    public IList<V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpecConfigMapExpressions
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
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpecSecretExpressions
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
/// Storage version of v20250301.VirtualNetworksVirtualNetworkPeeringOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20250301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20250301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/VirtualNetwork resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpaceIpamPoolPrefixAllocationsReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpaceIpamPoolPrefixAllocations
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
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpaceIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250301.AddressSpace
/// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpace
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
    public IList<V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkBgpCommunities
/// Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteBgpCommunities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("virtualNetworkCommunity")]
    public string? VirtualNetworkCommunity { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetwork
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkReference? Reference { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocationsReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocations
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
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250301.AddressSpace
/// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpace
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
    public IList<V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>Storage version of v20250301.VirtualNetworksVirtualNetworkPeering_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowForwardedTraffic")]
    public bool? AllowForwardedTraffic { get; set; }

    [JsonPropertyName("allowGatewayTransit")]
    public bool? AllowGatewayTransit { get; set; }

    [JsonPropertyName("allowVirtualNetworkAccess")]
    public bool? AllowVirtualNetworkAccess { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("doNotVerifyRemoteGateways")]
    public bool? DoNotVerifyRemoteGateways { get; set; }

    [JsonPropertyName("enableOnlyIPv6Peering")]
    public bool? EnableOnlyIPv6Peering { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("localAddressSpace")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpace? LocalAddressSpace { get; set; }

    [JsonPropertyName("localSubnetNames")]
    public IList<string>? LocalSubnetNames { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("localVirtualNetworkAddressSpace")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpace? LocalVirtualNetworkAddressSpace { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworksVirtualNetworkPeeringOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/VirtualNetwork resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250301storageVirtualNetworksVirtualNetworkPeeringSpecOwner Owner { get; set; }

    [JsonPropertyName("peerCompleteVnets")]
    public bool? PeerCompleteVnets { get; set; }

    [JsonPropertyName("peeringState")]
    public string? PeeringState { get; set; }

    [JsonPropertyName("peeringSyncLevel")]
    public string? PeeringSyncLevel { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("remoteAddressSpace")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpace? RemoteAddressSpace { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworkBgpCommunities
    /// Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.
    /// </summary>
    [JsonPropertyName("remoteBgpCommunities")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteBgpCommunities? RemoteBgpCommunities { get; set; }

    [JsonPropertyName("remoteSubnetNames")]
    public IList<string>? RemoteSubnetNames { get; set; }

    /// <summary>
    /// Storage version of v20250301.SubResource
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("remoteVirtualNetwork")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetwork? RemoteVirtualNetwork { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("remoteVirtualNetworkAddressSpace")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpace? RemoteVirtualNetworkAddressSpace { get; set; }

    [JsonPropertyName("useRemoteGateways")]
    public bool? UseRemoteGateways { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusLocalAddressSpaceIpamPoolPrefixAllocations
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusLocalAddressSpace
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
    public IList<V20250301storageVirtualNetworksVirtualNetworkPeeringStatusLocalAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>
/// Storage version of v20250301.IpamPoolPrefixAllocation_STATUS
/// IpamPool prefix allocation reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocations
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusLocalVirtualNetworkAddressSpace
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
    public IList<V20250301storageVirtualNetworksVirtualNetworkPeeringStatusLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>
/// Storage version of v20250301.IpamPoolPrefixAllocation_STATUS
/// IpamPool prefix allocation reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpaceIpamPoolPrefixAllocations
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpace
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
    public IList<V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkBgpCommunities_STATUS
/// Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteBgpCommunities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("regionalCommunity")]
    public string? RegionalCommunity { get; set; }

    [JsonPropertyName("virtualNetworkCommunity")]
    public string? VirtualNetworkCommunity { get; set; }
}

/// <summary>
/// Storage version of v20250301.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetwork
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocations
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkAddressSpace
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
    public IList<V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworkEncryption_STATUS
/// Indicates if encryption is enabled on virtual network and if VM without encryption is allowed in encrypted VNet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("enforcement")]
    public string? Enforcement { get; set; }
}

/// <summary>Storage version of v20250301.VirtualNetworksVirtualNetworkPeering_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeeringStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowForwardedTraffic")]
    public bool? AllowForwardedTraffic { get; set; }

    [JsonPropertyName("allowGatewayTransit")]
    public bool? AllowGatewayTransit { get; set; }

    [JsonPropertyName("allowVirtualNetworkAccess")]
    public bool? AllowVirtualNetworkAccess { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20250301storageVirtualNetworksVirtualNetworkPeeringStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("doNotVerifyRemoteGateways")]
    public bool? DoNotVerifyRemoteGateways { get; set; }

    [JsonPropertyName("enableOnlyIPv6Peering")]
    public bool? EnableOnlyIPv6Peering { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace_STATUS
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("localAddressSpace")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringStatusLocalAddressSpace? LocalAddressSpace { get; set; }

    [JsonPropertyName("localSubnetNames")]
    public IList<string>? LocalSubnetNames { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace_STATUS
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("localVirtualNetworkAddressSpace")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringStatusLocalVirtualNetworkAddressSpace? LocalVirtualNetworkAddressSpace { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("peerCompleteVnets")]
    public bool? PeerCompleteVnets { get; set; }

    [JsonPropertyName("peeringState")]
    public string? PeeringState { get; set; }

    [JsonPropertyName("peeringSyncLevel")]
    public string? PeeringSyncLevel { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace_STATUS
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("remoteAddressSpace")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpace? RemoteAddressSpace { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworkBgpCommunities_STATUS
    /// Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.
    /// </summary>
    [JsonPropertyName("remoteBgpCommunities")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteBgpCommunities? RemoteBgpCommunities { get; set; }

    [JsonPropertyName("remoteSubnetNames")]
    public IList<string>? RemoteSubnetNames { get; set; }

    /// <summary>
    /// Storage version of v20250301.SubResource_STATUS
    /// Reference to another subresource.
    /// </summary>
    [JsonPropertyName("remoteVirtualNetwork")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetwork? RemoteVirtualNetwork { get; set; }

    /// <summary>
    /// Storage version of v20250301.AddressSpace_STATUS
    /// AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.
    /// </summary>
    [JsonPropertyName("remoteVirtualNetworkAddressSpace")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkAddressSpace? RemoteVirtualNetworkAddressSpace { get; set; }

    /// <summary>
    /// Storage version of v20250301.VirtualNetworkEncryption_STATUS
    /// Indicates if encryption is enabled on virtual network and if VM without encryption is allowed in encrypted VNet.
    /// </summary>
    [JsonPropertyName("remoteVirtualNetworkEncryption")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkEncryption? RemoteVirtualNetworkEncryption { get; set; }

    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("useRemoteGateways")]
    public bool? UseRemoteGateways { get; set; }
}

/// <summary>
/// Storage version of v20250301.VirtualNetworksVirtualNetworkPeering
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/virtualNetwork.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301storageVirtualNetworksVirtualNetworkPeering : IKubernetesObject<V1ObjectMeta>, ISpec<V20250301storageVirtualNetworksVirtualNetworkPeeringSpec?>, IStatus<V20250301storageVirtualNetworksVirtualNetworkPeeringStatus?>
{
    public const string KubeApiVersion = "v20250301storage";
    public const string KubeKind = "VirtualNetworksVirtualNetworkPeering";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworksvirtualnetworkpeerings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworksVirtualNetworkPeering";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20250301.VirtualNetworksVirtualNetworkPeering_Spec</summary>
    [JsonPropertyName("spec")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringSpec? Spec { get; set; }

    /// <summary>Storage version of v20250301.VirtualNetworksVirtualNetworkPeering_STATUS</summary>
    [JsonPropertyName("status")]
    public V20250301storageVirtualNetworksVirtualNetworkPeeringStatus? Status { get; set; }
}