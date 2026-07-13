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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/virtualNetwork.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringList : IKubernetesObject<V1ListMeta>, IItems<V20250301VirtualNetworksVirtualNetworkPeering>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "VirtualNetworksVirtualNetworkPeeringList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworksvirtualnetworkpeerings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworksVirtualNetworkPeeringList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250301VirtualNetworksVirtualNetworkPeering objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250301VirtualNetworksVirtualNetworkPeering> Items { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpaceIpamPoolPrefixAllocationsReference
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
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpaceIpamPoolPrefixAllocations
{
    /// <summary>NumberOfIpAddresses: Number of IP addresses to allocate.</summary>
    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }

    /// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpaceIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>LocalAddressSpace: The local address space of the local virtual network that is peered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocationsReference
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
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocations
{
    /// <summary>NumberOfIpAddresses: Number of IP addresses to allocate.</summary>
    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }

    /// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>LocalVirtualNetworkAddressSpace: The current local address space of the local virtual network that is peered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecOperatorSpecConfigMapExpressions
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
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecOperatorSpecSecretExpressions
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
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250301VirtualNetworksVirtualNetworkPeeringSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250301VirtualNetworksVirtualNetworkPeeringSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/VirtualNetwork resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PeeringState: The status of the virtual network peering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworksVirtualNetworkPeeringSpecPeeringStateEnum>))]
public enum V20250301VirtualNetworksVirtualNetworkPeeringSpecPeeringStateEnum
{
    [EnumMember(Value = "Connected"), JsonStringEnumMemberName("Connected")]
    Connected,
    [EnumMember(Value = "Disconnected"), JsonStringEnumMemberName("Disconnected")]
    Disconnected,
    [EnumMember(Value = "Initiated"), JsonStringEnumMemberName("Initiated")]
    Initiated
}

/// <summary>PeeringSyncLevel: The peering sync status of the virtual network peering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworksVirtualNetworkPeeringSpecPeeringSyncLevelEnum>))]
public enum V20250301VirtualNetworksVirtualNetworkPeeringSpecPeeringSyncLevelEnum
{
    [EnumMember(Value = "FullyInSync"), JsonStringEnumMemberName("FullyInSync")]
    FullyInSync,
    [EnumMember(Value = "LocalAndRemoteNotInSync"), JsonStringEnumMemberName("LocalAndRemoteNotInSync")]
    LocalAndRemoteNotInSync,
    [EnumMember(Value = "LocalNotInSync"), JsonStringEnumMemberName("LocalNotInSync")]
    LocalNotInSync,
    [EnumMember(Value = "RemoteNotInSync"), JsonStringEnumMemberName("RemoteNotInSync")]
    RemoteNotInSync
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpaceIpamPoolPrefixAllocationsReference
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
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpaceIpamPoolPrefixAllocations
{
    /// <summary>NumberOfIpAddresses: Number of IP addresses to allocate.</summary>
    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }

    /// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpaceIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>RemoteAddressSpace: The reference to the address space peered with the remote virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>RemoteBgpCommunities: The reference to the remote virtual network&apos;s Bgp Communities.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteBgpCommunities
{
    /// <summary>VirtualNetworkCommunity: The BGP community associated with the virtual network.</summary>
    [JsonPropertyName("virtualNetworkCommunity")]
    public required string VirtualNetworkCommunity { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkReference
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
/// RemoteVirtualNetwork: The reference to the remote virtual network. The remote virtual network can be in the same or
/// different region (preview). See here to register for the preview and learn more
/// (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetwork
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkReference? Reference { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocationsReference
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
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocations
{
    /// <summary>NumberOfIpAddresses: Number of IP addresses to allocate.</summary>
    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }

    /// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>RemoteVirtualNetworkAddressSpace: The reference to the current address space of the remote virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringSpec
{
    /// <summary>
    /// AllowForwardedTraffic: Whether the forwarded traffic from the VMs in the local virtual network will be
    /// allowed/disallowed in remote virtual network.
    /// </summary>
    [JsonPropertyName("allowForwardedTraffic")]
    public bool? AllowForwardedTraffic { get; set; }

    /// <summary>AllowGatewayTransit: If gateway links can be used in remote virtual networking to link to this virtual network.</summary>
    [JsonPropertyName("allowGatewayTransit")]
    public bool? AllowGatewayTransit { get; set; }

    /// <summary>
    /// AllowVirtualNetworkAccess: Whether the VMs in the local virtual network space would be able to access the VMs in remote
    /// virtual network space.
    /// </summary>
    [JsonPropertyName("allowVirtualNetworkAccess")]
    public bool? AllowVirtualNetworkAccess { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DoNotVerifyRemoteGateways: If we need to verify the provisioning state of the remote gateway.</summary>
    [JsonPropertyName("doNotVerifyRemoteGateways")]
    public bool? DoNotVerifyRemoteGateways { get; set; }

    /// <summary>EnableOnlyIPv6Peering: Whether only Ipv6 address space is peered for subnet peering.</summary>
    [JsonPropertyName("enableOnlyIPv6Peering")]
    public bool? EnableOnlyIPv6Peering { get; set; }

    /// <summary>LocalAddressSpace: The local address space of the local virtual network that is peered.</summary>
    [JsonPropertyName("localAddressSpace")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalAddressSpace? LocalAddressSpace { get; set; }

    /// <summary>LocalSubnetNames: List of local subnet names that are subnet peered with remote virtual network.</summary>
    [JsonPropertyName("localSubnetNames")]
    public IList<string>? LocalSubnetNames { get; set; }

    /// <summary>LocalVirtualNetworkAddressSpace: The current local address space of the local virtual network that is peered.</summary>
    [JsonPropertyName("localVirtualNetworkAddressSpace")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecLocalVirtualNetworkAddressSpace? LocalVirtualNetworkAddressSpace { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/VirtualNetwork resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250301VirtualNetworksVirtualNetworkPeeringSpecOwner Owner { get; set; }

    /// <summary>PeerCompleteVnets: Whether complete virtual network address space is peered.</summary>
    [JsonPropertyName("peerCompleteVnets")]
    public bool? PeerCompleteVnets { get; set; }

    /// <summary>PeeringState: The status of the virtual network peering.</summary>
    [JsonPropertyName("peeringState")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecPeeringStateEnum? PeeringState { get; set; }

    /// <summary>PeeringSyncLevel: The peering sync status of the virtual network peering.</summary>
    [JsonPropertyName("peeringSyncLevel")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecPeeringSyncLevelEnum? PeeringSyncLevel { get; set; }

    /// <summary>RemoteAddressSpace: The reference to the address space peered with the remote virtual network.</summary>
    [JsonPropertyName("remoteAddressSpace")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteAddressSpace? RemoteAddressSpace { get; set; }

    /// <summary>RemoteBgpCommunities: The reference to the remote virtual network&apos;s Bgp Communities.</summary>
    [JsonPropertyName("remoteBgpCommunities")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteBgpCommunities? RemoteBgpCommunities { get; set; }

    /// <summary>RemoteSubnetNames: List of remote subnet names from remote virtual network that are subnet peered.</summary>
    [JsonPropertyName("remoteSubnetNames")]
    public IList<string>? RemoteSubnetNames { get; set; }

    /// <summary>
    /// RemoteVirtualNetwork: The reference to the remote virtual network. The remote virtual network can be in the same or
    /// different region (preview). See here to register for the preview and learn more
    /// (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
    /// </summary>
    [JsonPropertyName("remoteVirtualNetwork")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetwork? RemoteVirtualNetwork { get; set; }

    /// <summary>RemoteVirtualNetworkAddressSpace: The reference to the current address space of the remote virtual network.</summary>
    [JsonPropertyName("remoteVirtualNetworkAddressSpace")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpecRemoteVirtualNetworkAddressSpace? RemoteVirtualNetworkAddressSpace { get; set; }

    /// <summary>
    /// UseRemoteGateways: If remote gateways can be used on this virtual network. If the flag is set to true, and
    /// allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for
    /// transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a
    /// gateway.
    /// </summary>
    [JsonPropertyName("useRemoteGateways")]
    public bool? UseRemoteGateways { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusConditions
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
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusLocalAddressSpaceIpamPoolPrefixAllocations
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

/// <summary>LocalAddressSpace: The local address space of the local virtual network that is peered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusLocalAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworksVirtualNetworkPeeringStatusLocalAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>IpamPool prefix allocation reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocations
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

/// <summary>LocalVirtualNetworkAddressSpace: The current local address space of the local virtual network that is peered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusLocalVirtualNetworkAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworksVirtualNetworkPeeringStatusLocalVirtualNetworkAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>IpamPool prefix allocation reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpaceIpamPoolPrefixAllocations
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

/// <summary>RemoteAddressSpace: The reference to the address space peered with the remote virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>RemoteBgpCommunities: The reference to the remote virtual network&apos;s Bgp Communities.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteBgpCommunities
{
    /// <summary>RegionalCommunity: The BGP community associated with the region of the virtual network.</summary>
    [JsonPropertyName("regionalCommunity")]
    public string? RegionalCommunity { get; set; }

    /// <summary>VirtualNetworkCommunity: The BGP community associated with the virtual network.</summary>
    [JsonPropertyName("virtualNetworkCommunity")]
    public string? VirtualNetworkCommunity { get; set; }
}

/// <summary>
/// RemoteVirtualNetwork: The reference to the remote virtual network. The remote virtual network can be in the same or
/// different region (preview). See here to register for the preview and learn more
/// (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetwork
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>IpamPool prefix allocation reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocations
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

/// <summary>RemoteVirtualNetworkAddressSpace: The reference to the current address space of the remote virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>RemoteVirtualNetworkEncryption: The reference to the remote virtual network&apos;s encryption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkEncryption
{
    /// <summary>Enabled: Indicates if encryption is enabled on the virtual network.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Enforcement: If the encrypted VNet allows VM that does not support encryption. This field is for future support,
    /// AllowUnencrypted is the only supported value at general availability.
    /// </summary>
    [JsonPropertyName("enforcement")]
    public string? Enforcement { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksVirtualNetworkPeeringStatus
{
    /// <summary>
    /// AllowForwardedTraffic: Whether the forwarded traffic from the VMs in the local virtual network will be
    /// allowed/disallowed in remote virtual network.
    /// </summary>
    [JsonPropertyName("allowForwardedTraffic")]
    public bool? AllowForwardedTraffic { get; set; }

    /// <summary>AllowGatewayTransit: If gateway links can be used in remote virtual networking to link to this virtual network.</summary>
    [JsonPropertyName("allowGatewayTransit")]
    public bool? AllowGatewayTransit { get; set; }

    /// <summary>
    /// AllowVirtualNetworkAccess: Whether the VMs in the local virtual network space would be able to access the VMs in remote
    /// virtual network space.
    /// </summary>
    [JsonPropertyName("allowVirtualNetworkAccess")]
    public bool? AllowVirtualNetworkAccess { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250301VirtualNetworksVirtualNetworkPeeringStatusConditions>? Conditions { get; set; }

    /// <summary>DoNotVerifyRemoteGateways: If we need to verify the provisioning state of the remote gateway.</summary>
    [JsonPropertyName("doNotVerifyRemoteGateways")]
    public bool? DoNotVerifyRemoteGateways { get; set; }

    /// <summary>EnableOnlyIPv6Peering: Whether only Ipv6 address space is peered for subnet peering.</summary>
    [JsonPropertyName("enableOnlyIPv6Peering")]
    public bool? EnableOnlyIPv6Peering { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>LocalAddressSpace: The local address space of the local virtual network that is peered.</summary>
    [JsonPropertyName("localAddressSpace")]
    public V20250301VirtualNetworksVirtualNetworkPeeringStatusLocalAddressSpace? LocalAddressSpace { get; set; }

    /// <summary>LocalSubnetNames: List of local subnet names that are subnet peered with remote virtual network.</summary>
    [JsonPropertyName("localSubnetNames")]
    public IList<string>? LocalSubnetNames { get; set; }

    /// <summary>LocalVirtualNetworkAddressSpace: The current local address space of the local virtual network that is peered.</summary>
    [JsonPropertyName("localVirtualNetworkAddressSpace")]
    public V20250301VirtualNetworksVirtualNetworkPeeringStatusLocalVirtualNetworkAddressSpace? LocalVirtualNetworkAddressSpace { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PeerCompleteVnets: Whether complete virtual network address space is peered.</summary>
    [JsonPropertyName("peerCompleteVnets")]
    public bool? PeerCompleteVnets { get; set; }

    /// <summary>PeeringState: The status of the virtual network peering.</summary>
    [JsonPropertyName("peeringState")]
    public string? PeeringState { get; set; }

    /// <summary>PeeringSyncLevel: The peering sync status of the virtual network peering.</summary>
    [JsonPropertyName("peeringSyncLevel")]
    public string? PeeringSyncLevel { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the virtual network peering resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>RemoteAddressSpace: The reference to the address space peered with the remote virtual network.</summary>
    [JsonPropertyName("remoteAddressSpace")]
    public V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteAddressSpace? RemoteAddressSpace { get; set; }

    /// <summary>RemoteBgpCommunities: The reference to the remote virtual network&apos;s Bgp Communities.</summary>
    [JsonPropertyName("remoteBgpCommunities")]
    public V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteBgpCommunities? RemoteBgpCommunities { get; set; }

    /// <summary>RemoteSubnetNames: List of remote subnet names from remote virtual network that are subnet peered.</summary>
    [JsonPropertyName("remoteSubnetNames")]
    public IList<string>? RemoteSubnetNames { get; set; }

    /// <summary>
    /// RemoteVirtualNetwork: The reference to the remote virtual network. The remote virtual network can be in the same or
    /// different region (preview). See here to register for the preview and learn more
    /// (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
    /// </summary>
    [JsonPropertyName("remoteVirtualNetwork")]
    public V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetwork? RemoteVirtualNetwork { get; set; }

    /// <summary>RemoteVirtualNetworkAddressSpace: The reference to the current address space of the remote virtual network.</summary>
    [JsonPropertyName("remoteVirtualNetworkAddressSpace")]
    public V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkAddressSpace? RemoteVirtualNetworkAddressSpace { get; set; }

    /// <summary>RemoteVirtualNetworkEncryption: The reference to the remote virtual network&apos;s encryption</summary>
    [JsonPropertyName("remoteVirtualNetworkEncryption")]
    public V20250301VirtualNetworksVirtualNetworkPeeringStatusRemoteVirtualNetworkEncryption? RemoteVirtualNetworkEncryption { get; set; }

    /// <summary>ResourceGuid: The resourceGuid property of the Virtual Network peering resource.</summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UseRemoteGateways: If remote gateways can be used on this virtual network. If the flag is set to true, and
    /// allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for
    /// transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a
    /// gateway.
    /// </summary>
    [JsonPropertyName("useRemoteGateways")]
    public bool? UseRemoteGateways { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/virtualNetwork.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/virtualNetworkPeerings/{virtualNetworkPeeringName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301VirtualNetworksVirtualNetworkPeering : IKubernetesObject<V1ObjectMeta>, ISpec<V20250301VirtualNetworksVirtualNetworkPeeringSpec?>, IStatus<V20250301VirtualNetworksVirtualNetworkPeeringStatus?>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "VirtualNetworksVirtualNetworkPeering";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworksvirtualnetworkpeerings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworksVirtualNetworkPeering";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250301VirtualNetworksVirtualNetworkPeeringSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20250301VirtualNetworksVirtualNetworkPeeringStatus? Status { get; set; }
}