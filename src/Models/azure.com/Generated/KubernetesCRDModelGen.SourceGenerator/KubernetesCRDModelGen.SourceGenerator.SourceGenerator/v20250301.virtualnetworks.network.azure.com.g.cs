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
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301VirtualNetworkList : IKubernetesObject<V1ListMeta>, IItems<V20250301VirtualNetwork>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "VirtualNetworkList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworkList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250301VirtualNetwork objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250301VirtualNetwork> Items { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpecAddressSpaceIpamPoolPrefixAllocationsReference
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
public partial class V20250301VirtualNetworkSpecAddressSpaceIpamPoolPrefixAllocations
{
    /// <summary>NumberOfIpAddresses: Number of IP addresses to allocate.</summary>
    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }

    /// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworkSpecAddressSpaceIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>AddressSpace: The AddressSpace that contains an array of IP address ranges that can be used by subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpecAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworkSpecAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>BgpCommunities: Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpecBgpCommunities
{
    /// <summary>VirtualNetworkCommunity: The BGP community associated with the virtual network.</summary>
    [JsonPropertyName("virtualNetworkCommunity")]
    public required string VirtualNetworkCommunity { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpecDdosProtectionPlanReference
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

/// <summary>DdosProtectionPlan: The DDoS protection plan associated with the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpecDdosProtectionPlan
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworkSpecDdosProtectionPlanReference? Reference { get; set; }
}

/// <summary>DhcpOptions: The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpecDhcpOptions
{
    /// <summary>DnsServers: The list of DNS servers IP addresses.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

/// <summary>
/// Enforcement: If the encrypted VNet allows VM that does not support encryption. This field is for future support,
/// AllowUnencrypted is the only supported value at general availability.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkSpecEncryptionEnforcementEnum>))]
public enum V20250301VirtualNetworkSpecEncryptionEnforcementEnum
{
    [EnumMember(Value = "AllowUnencrypted"), JsonStringEnumMemberName("AllowUnencrypted")]
    AllowUnencrypted,
    [EnumMember(Value = "DropUnencrypted"), JsonStringEnumMemberName("DropUnencrypted")]
    DropUnencrypted
}

/// <summary>
/// Encryption: Indicates if encryption is enabled on virtual network and if VM without encryption is allowed in encrypted
/// VNet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpecEncryption
{
    /// <summary>Enabled: Indicates if encryption is enabled on the virtual network.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <summary>
    /// Enforcement: If the encrypted VNet allows VM that does not support encryption. This field is for future support,
    /// AllowUnencrypted is the only supported value at general availability.
    /// </summary>
    [JsonPropertyName("enforcement")]
    public V20250301VirtualNetworkSpecEncryptionEnforcementEnum? Enforcement { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkSpecExtendedLocationTypeEnum>))]
public enum V20250301VirtualNetworkSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V20250301VirtualNetworkSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpecIpAllocationsReference
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
public partial class V20250301VirtualNetworkSpecIpAllocations
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworkSpecIpAllocationsReference? Reference { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpecOperatorSpecConfigMapExpressions
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
public partial class V20250301VirtualNetworkSpecOperatorSpecSecretExpressions
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
public partial class V20250301VirtualNetworkSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250301VirtualNetworkSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250301VirtualNetworkSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PrivateEndpointVNetPolicies: Private Endpoint VNet Policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworkSpecPrivateEndpointVNetPoliciesEnum>))]
public enum V20250301VirtualNetworkSpecPrivateEndpointVNetPoliciesEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkSpec
{
    /// <summary>AddressSpace: The AddressSpace that contains an array of IP address ranges that can be used by subnets.</summary>
    [JsonPropertyName("addressSpace")]
    public V20250301VirtualNetworkSpecAddressSpace? AddressSpace { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>BgpCommunities: Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.</summary>
    [JsonPropertyName("bgpCommunities")]
    public V20250301VirtualNetworkSpecBgpCommunities? BgpCommunities { get; set; }

    /// <summary>DdosProtectionPlan: The DDoS protection plan associated with the virtual network.</summary>
    [JsonPropertyName("ddosProtectionPlan")]
    public V20250301VirtualNetworkSpecDdosProtectionPlan? DdosProtectionPlan { get; set; }

    /// <summary>DhcpOptions: The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network.</summary>
    [JsonPropertyName("dhcpOptions")]
    public V20250301VirtualNetworkSpecDhcpOptions? DhcpOptions { get; set; }

    /// <summary>
    /// EnableDdosProtection: Indicates if DDoS protection is enabled for all the protected resources in the virtual network. It
    /// requires a DDoS protection plan associated with the resource.
    /// </summary>
    [JsonPropertyName("enableDdosProtection")]
    public bool? EnableDdosProtection { get; set; }

    /// <summary>EnableVmProtection: Indicates if VM protection is enabled for all the subnets in the virtual network.</summary>
    [JsonPropertyName("enableVmProtection")]
    public bool? EnableVmProtection { get; set; }

    /// <summary>
    /// Encryption: Indicates if encryption is enabled on virtual network and if VM without encryption is allowed in encrypted
    /// VNet.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V20250301VirtualNetworkSpecEncryption? Encryption { get; set; }

    /// <summary>ExtendedLocation: The extended location of the virtual network.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20250301VirtualNetworkSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FlowTimeoutInMinutes: The FlowTimeout value (in minutes) for the Virtual Network</summary>
    [JsonPropertyName("flowTimeoutInMinutes")]
    public int? FlowTimeoutInMinutes { get; set; }

    /// <summary>IpAllocations: Array of IpAllocation which reference this VNET.</summary>
    [JsonPropertyName("ipAllocations")]
    public IList<V20250301VirtualNetworkSpecIpAllocations>? IpAllocations { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250301VirtualNetworkSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250301VirtualNetworkSpecOwner Owner { get; set; }

    /// <summary>PrivateEndpointVNetPolicies: Private Endpoint VNet Policies.</summary>
    [JsonPropertyName("privateEndpointVNetPolicies")]
    public V20250301VirtualNetworkSpecPrivateEndpointVNetPoliciesEnum? PrivateEndpointVNetPolicies { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>IpamPool prefix allocation reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatusAddressSpaceIpamPoolPrefixAllocations
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

/// <summary>AddressSpace: The AddressSpace that contains an array of IP address ranges that can be used by subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatusAddressSpace
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworkStatusAddressSpaceIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }
}

/// <summary>BgpCommunities: Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatusBgpCommunities
{
    /// <summary>RegionalCommunity: The BGP community associated with the region of the virtual network.</summary>
    [JsonPropertyName("regionalCommunity")]
    public string? RegionalCommunity { get; set; }

    /// <summary>VirtualNetworkCommunity: The BGP community associated with the virtual network.</summary>
    [JsonPropertyName("virtualNetworkCommunity")]
    public string? VirtualNetworkCommunity { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatusConditions
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

/// <summary>DdosProtectionPlan: The DDoS protection plan associated with the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatusDdosProtectionPlan
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DefaultPublicNatGateway: A reference to the default public nat gateway being used by this virtual network resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatusDefaultPublicNatGateway
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DhcpOptions: The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatusDhcpOptions
{
    /// <summary>DnsServers: The list of DNS servers IP addresses.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

/// <summary>
/// Encryption: Indicates if encryption is enabled on virtual network and if VM without encryption is allowed in encrypted
/// VNet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatusEncryption
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

/// <summary>ExtendedLocation: The extended location of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A flow log resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatusFlowLogs
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatusIpAllocations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Virtual Network resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworkStatus
{
    /// <summary>AddressSpace: The AddressSpace that contains an array of IP address ranges that can be used by subnets.</summary>
    [JsonPropertyName("addressSpace")]
    public V20250301VirtualNetworkStatusAddressSpace? AddressSpace { get; set; }

    /// <summary>BgpCommunities: Bgp Communities sent over ExpressRoute with each route corresponding to a prefix in this VNET.</summary>
    [JsonPropertyName("bgpCommunities")]
    public V20250301VirtualNetworkStatusBgpCommunities? BgpCommunities { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250301VirtualNetworkStatusConditions>? Conditions { get; set; }

    /// <summary>DdosProtectionPlan: The DDoS protection plan associated with the virtual network.</summary>
    [JsonPropertyName("ddosProtectionPlan")]
    public V20250301VirtualNetworkStatusDdosProtectionPlan? DdosProtectionPlan { get; set; }

    /// <summary>DefaultPublicNatGateway: A reference to the default public nat gateway being used by this virtual network resource.</summary>
    [JsonPropertyName("defaultPublicNatGateway")]
    public V20250301VirtualNetworkStatusDefaultPublicNatGateway? DefaultPublicNatGateway { get; set; }

    /// <summary>DhcpOptions: The dhcpOptions that contains an array of DNS servers available to VMs deployed in the virtual network.</summary>
    [JsonPropertyName("dhcpOptions")]
    public V20250301VirtualNetworkStatusDhcpOptions? DhcpOptions { get; set; }

    /// <summary>
    /// EnableDdosProtection: Indicates if DDoS protection is enabled for all the protected resources in the virtual network. It
    /// requires a DDoS protection plan associated with the resource.
    /// </summary>
    [JsonPropertyName("enableDdosProtection")]
    public bool? EnableDdosProtection { get; set; }

    /// <summary>EnableVmProtection: Indicates if VM protection is enabled for all the subnets in the virtual network.</summary>
    [JsonPropertyName("enableVmProtection")]
    public bool? EnableVmProtection { get; set; }

    /// <summary>
    /// Encryption: Indicates if encryption is enabled on virtual network and if VM without encryption is allowed in encrypted
    /// VNet.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V20250301VirtualNetworkStatusEncryption? Encryption { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ExtendedLocation: The extended location of the virtual network.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20250301VirtualNetworkStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FlowLogs: A collection of references to flow log resources.</summary>
    [JsonPropertyName("flowLogs")]
    public IList<V20250301VirtualNetworkStatusFlowLogs>? FlowLogs { get; set; }

    /// <summary>FlowTimeoutInMinutes: The FlowTimeout value (in minutes) for the Virtual Network</summary>
    [JsonPropertyName("flowTimeoutInMinutes")]
    public int? FlowTimeoutInMinutes { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IpAllocations: Array of IpAllocation which reference this VNET.</summary>
    [JsonPropertyName("ipAllocations")]
    public IList<V20250301VirtualNetworkStatusIpAllocations>? IpAllocations { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateEndpointVNetPolicies: Private Endpoint VNet Policies.</summary>
    [JsonPropertyName("privateEndpointVNetPolicies")]
    public string? PrivateEndpointVNetPolicies { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the virtual network resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceGuid: The resourceGuid property of the Virtual Network resource.</summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/virtualNetwork.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301VirtualNetwork : IKubernetesObject<V1ObjectMeta>, ISpec<V20250301VirtualNetworkSpec?>, IStatus<V20250301VirtualNetworkStatus?>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "VirtualNetwork";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetwork";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250301VirtualNetworkSpec? Spec { get; set; }

    /// <summary>Virtual Network resource.</summary>
    [JsonPropertyName("status")]
    public V20250301VirtualNetworkStatus? Status { get; set; }
}