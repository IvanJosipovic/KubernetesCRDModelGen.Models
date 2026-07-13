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
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301VirtualNetworksSubnetList : IKubernetesObject<V1ListMeta>, IItems<V20250301VirtualNetworksSubnet>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "VirtualNetworksSubnetList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworkssubnets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworksSubnetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250301VirtualNetworksSubnet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250301VirtualNetworksSubnet> Items { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecApplicationGatewayIPConfigurationsReference
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

/// <summary>IP configuration of an application gateway. Currently 1 public and 1 private IP configuration is allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecApplicationGatewayIPConfigurations
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksSubnetSpecApplicationGatewayIPConfigurationsReference? Reference { get; set; }
}

/// <summary>Details the service to which the subnet is delegated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecDelegations
{
    /// <summary>Name: The name of the resource that is unique within a subnet. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ServiceName: The name of the service to whom the subnet should be delegated (e.g. Microsoft.Sql/servers).</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecIpAllocationsReference
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
public partial class V20250301VirtualNetworksSubnetSpecIpAllocations
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksSubnetSpecIpAllocationsReference? Reference { get; set; }
}

/// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecIpamPoolPrefixAllocationsReference
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
public partial class V20250301VirtualNetworksSubnetSpecIpamPoolPrefixAllocations
{
    /// <summary>NumberOfIpAddresses: Number of IP addresses to allocate.</summary>
    [JsonPropertyName("numberOfIpAddresses")]
    public string? NumberOfIpAddresses { get; set; }

    /// <summary>Reference: Resource id of the associated Azure IpamPool resource.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksSubnetSpecIpamPoolPrefixAllocationsReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecNatGatewayReference
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

/// <summary>NatGateway: Nat gateway associated with this subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecNatGateway
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksSubnetSpecNatGatewayReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecNetworkSecurityGroupReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecNetworkSecurityGroup
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksSubnetSpecNetworkSecurityGroupReference? Reference { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecOperatorSpecConfigMapExpressions
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
public partial class V20250301VirtualNetworksSubnetSpecOperatorSpecSecretExpressions
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
public partial class V20250301VirtualNetworksSubnetSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250301VirtualNetworksSubnetSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250301VirtualNetworksSubnetSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/VirtualNetwork resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PrivateEndpointNetworkPolicies: Enable or Disable apply network policies on private end point in the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworksSubnetSpecPrivateEndpointNetworkPoliciesEnum>))]
public enum V20250301VirtualNetworksSubnetSpecPrivateEndpointNetworkPoliciesEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "NetworkSecurityGroupEnabled"), JsonStringEnumMemberName("NetworkSecurityGroupEnabled")]
    NetworkSecurityGroupEnabled,
    [EnumMember(Value = "RouteTableEnabled"), JsonStringEnumMemberName("RouteTableEnabled")]
    RouteTableEnabled
}

/// <summary>PrivateLinkServiceNetworkPolicies: Enable or Disable apply network policies on private link service in the subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworksSubnetSpecPrivateLinkServiceNetworkPoliciesEnum>))]
public enum V20250301VirtualNetworksSubnetSpecPrivateLinkServiceNetworkPoliciesEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecRouteTableReference
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

/// <summary>RouteTable: The reference to the RouteTable resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecRouteTable
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksSubnetSpecRouteTableReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecServiceEndpointPoliciesReference
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

/// <summary>Service End point policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecServiceEndpointPolicies
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksSubnetSpecServiceEndpointPoliciesReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecServiceEndpointsNetworkIdentifierReference
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

/// <summary>NetworkIdentifier: SubResource as network identifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecServiceEndpointsNetworkIdentifier
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301VirtualNetworksSubnetSpecServiceEndpointsNetworkIdentifierReference? Reference { get; set; }
}

/// <summary>The service endpoint properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpecServiceEndpoints
{
    /// <summary>Locations: A list of locations.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>NetworkIdentifier: SubResource as network identifier.</summary>
    [JsonPropertyName("networkIdentifier")]
    public V20250301VirtualNetworksSubnetSpecServiceEndpointsNetworkIdentifier? NetworkIdentifier { get; set; }

    /// <summary>Service: The type of the endpoint service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>
/// SharingScope: Set this property to Tenant to allow sharing subnet with other subscriptions in your AAD tenant. This
/// property can only be set if defaultOutboundAccess is set to false, both properties can only be set if subnet is empty.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301VirtualNetworksSubnetSpecSharingScopeEnum>))]
public enum V20250301VirtualNetworksSubnetSpecSharingScopeEnum
{
    [EnumMember(Value = "DelegatedServices"), JsonStringEnumMemberName("DelegatedServices")]
    DelegatedServices,
    [EnumMember(Value = "Tenant"), JsonStringEnumMemberName("Tenant")]
    Tenant
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetSpec
{
    /// <summary>AddressPrefix: The address prefix for the subnet.</summary>
    [JsonPropertyName("addressPrefix")]
    public string? AddressPrefix { get; set; }

    /// <summary>AddressPrefixes: List of address prefixes for the subnet.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>ApplicationGatewayIPConfigurations: Application gateway IP configurations of virtual network resource.</summary>
    [JsonPropertyName("applicationGatewayIPConfigurations")]
    public IList<V20250301VirtualNetworksSubnetSpecApplicationGatewayIPConfigurations>? ApplicationGatewayIPConfigurations { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DefaultOutboundAccess: Set this property to false to disable default outbound connectivity for all VMs in the subnet.</summary>
    [JsonPropertyName("defaultOutboundAccess")]
    public bool? DefaultOutboundAccess { get; set; }

    /// <summary>Delegations: An array of references to the delegations on the subnet.</summary>
    [JsonPropertyName("delegations")]
    public IList<V20250301VirtualNetworksSubnetSpecDelegations>? Delegations { get; set; }

    /// <summary>IpAllocations: Array of IpAllocation which reference this subnet.</summary>
    [JsonPropertyName("ipAllocations")]
    public IList<V20250301VirtualNetworksSubnetSpecIpAllocations>? IpAllocations { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools for allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworksSubnetSpecIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }

    /// <summary>NatGateway: Nat gateway associated with this subnet.</summary>
    [JsonPropertyName("natGateway")]
    public V20250301VirtualNetworksSubnetSpecNatGateway? NatGateway { get; set; }

    /// <summary>NetworkSecurityGroup: The reference to the NetworkSecurityGroup resource.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V20250301VirtualNetworksSubnetSpecNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250301VirtualNetworksSubnetSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/VirtualNetwork resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250301VirtualNetworksSubnetSpecOwner Owner { get; set; }

    /// <summary>PrivateEndpointNetworkPolicies: Enable or Disable apply network policies on private end point in the subnet.</summary>
    [JsonPropertyName("privateEndpointNetworkPolicies")]
    public V20250301VirtualNetworksSubnetSpecPrivateEndpointNetworkPoliciesEnum? PrivateEndpointNetworkPolicies { get; set; }

    /// <summary>PrivateLinkServiceNetworkPolicies: Enable or Disable apply network policies on private link service in the subnet.</summary>
    [JsonPropertyName("privateLinkServiceNetworkPolicies")]
    public V20250301VirtualNetworksSubnetSpecPrivateLinkServiceNetworkPoliciesEnum? PrivateLinkServiceNetworkPolicies { get; set; }

    /// <summary>RouteTable: The reference to the RouteTable resource.</summary>
    [JsonPropertyName("routeTable")]
    public V20250301VirtualNetworksSubnetSpecRouteTable? RouteTable { get; set; }

    /// <summary>ServiceEndpointPolicies: An array of service endpoint policies.</summary>
    [JsonPropertyName("serviceEndpointPolicies")]
    public IList<V20250301VirtualNetworksSubnetSpecServiceEndpointPolicies>? ServiceEndpointPolicies { get; set; }

    /// <summary>ServiceEndpoints: An array of service endpoints.</summary>
    [JsonPropertyName("serviceEndpoints")]
    public IList<V20250301VirtualNetworksSubnetSpecServiceEndpoints>? ServiceEndpoints { get; set; }

    /// <summary>
    /// SharingScope: Set this property to Tenant to allow sharing subnet with other subscriptions in your AAD tenant. This
    /// property can only be set if defaultOutboundAccess is set to false, both properties can only be set if subnet is empty.
    /// </summary>
    [JsonPropertyName("sharingScope")]
    public V20250301VirtualNetworksSubnetSpecSharingScopeEnum? SharingScope { get; set; }
}

/// <summary>IP configuration of an application gateway. Currently 1 public and 1 private IP configuration is allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusApplicationGatewayIPConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusConditions
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

/// <summary>Details the service to which the subnet is delegated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusDelegations
{
    /// <summary>Actions: The actions permitted to the service upon delegation.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource that is unique within a subnet. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the service delegation resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ServiceName: The name of the service to whom the subnet should be delegated (e.g. Microsoft.Sql/servers).</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusIpAllocations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>IP configuration profile child resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusIpConfigurationProfiles
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusIpConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>IpamPool prefix allocation reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusIpamPoolPrefixAllocations
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

/// <summary>NatGateway: Nat gateway associated with this subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusNatGateway
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>NetworkSecurityGroup: The reference to the NetworkSecurityGroup resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusNetworkSecurityGroup
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Private endpoint resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusPrivateEndpoints
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ResourceNavigationLink resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusResourceNavigationLinks
{
    /// <summary>Id: Resource navigation link identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>RouteTable: The reference to the RouteTable resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusRouteTable
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ServiceAssociationLink resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusServiceAssociationLinks
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Service End point policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusServiceEndpointPolicies
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>NetworkIdentifier: SubResource as network identifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusServiceEndpointsNetworkIdentifier
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>The service endpoint properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatusServiceEndpoints
{
    /// <summary>Locations: A list of locations.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>NetworkIdentifier: SubResource as network identifier.</summary>
    [JsonPropertyName("networkIdentifier")]
    public V20250301VirtualNetworksSubnetStatusServiceEndpointsNetworkIdentifier? NetworkIdentifier { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the service endpoint resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Service: The type of the endpoint service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301VirtualNetworksSubnetStatus
{
    /// <summary>AddressPrefix: The address prefix for the subnet.</summary>
    [JsonPropertyName("addressPrefix")]
    public string? AddressPrefix { get; set; }

    /// <summary>AddressPrefixes: List of address prefixes for the subnet.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }

    /// <summary>ApplicationGatewayIPConfigurations: Application gateway IP configurations of virtual network resource.</summary>
    [JsonPropertyName("applicationGatewayIPConfigurations")]
    public IList<V20250301VirtualNetworksSubnetStatusApplicationGatewayIPConfigurations>? ApplicationGatewayIPConfigurations { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250301VirtualNetworksSubnetStatusConditions>? Conditions { get; set; }

    /// <summary>DefaultOutboundAccess: Set this property to false to disable default outbound connectivity for all VMs in the subnet.</summary>
    [JsonPropertyName("defaultOutboundAccess")]
    public bool? DefaultOutboundAccess { get; set; }

    /// <summary>Delegations: An array of references to the delegations on the subnet.</summary>
    [JsonPropertyName("delegations")]
    public IList<V20250301VirtualNetworksSubnetStatusDelegations>? Delegations { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IpAllocations: Array of IpAllocation which reference this subnet.</summary>
    [JsonPropertyName("ipAllocations")]
    public IList<V20250301VirtualNetworksSubnetStatusIpAllocations>? IpAllocations { get; set; }

    /// <summary>IpConfigurationProfiles: Array of IP configuration profiles which reference this subnet.</summary>
    [JsonPropertyName("ipConfigurationProfiles")]
    public IList<V20250301VirtualNetworksSubnetStatusIpConfigurationProfiles>? IpConfigurationProfiles { get; set; }

    /// <summary>
    /// IpConfigurations: An array of references to the network interface IP configurations using subnet. This field is not
    /// included if there are more than 2000 entries.
    /// </summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V20250301VirtualNetworksSubnetStatusIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>IpamPoolPrefixAllocations: A list of IPAM Pools for allocating IP address prefixes.</summary>
    [JsonPropertyName("ipamPoolPrefixAllocations")]
    public IList<V20250301VirtualNetworksSubnetStatusIpamPoolPrefixAllocations>? IpamPoolPrefixAllocations { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NatGateway: Nat gateway associated with this subnet.</summary>
    [JsonPropertyName("natGateway")]
    public V20250301VirtualNetworksSubnetStatusNatGateway? NatGateway { get; set; }

    /// <summary>NetworkSecurityGroup: The reference to the NetworkSecurityGroup resource.</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V20250301VirtualNetworksSubnetStatusNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary>PrivateEndpointNetworkPolicies: Enable or Disable apply network policies on private end point in the subnet.</summary>
    [JsonPropertyName("privateEndpointNetworkPolicies")]
    public string? PrivateEndpointNetworkPolicies { get; set; }

    /// <summary>PrivateEndpoints: An array of references to private endpoints.</summary>
    [JsonPropertyName("privateEndpoints")]
    public IList<V20250301VirtualNetworksSubnetStatusPrivateEndpoints>? PrivateEndpoints { get; set; }

    /// <summary>PrivateLinkServiceNetworkPolicies: Enable or Disable apply network policies on private link service in the subnet.</summary>
    [JsonPropertyName("privateLinkServiceNetworkPolicies")]
    public string? PrivateLinkServiceNetworkPolicies { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the subnet resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// Purpose: A read-only string identifying the intention of use for this subnet based on delegations and other user-defined
    /// properties.
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>ResourceNavigationLinks: An array of references to the external resources using subnet.</summary>
    [JsonPropertyName("resourceNavigationLinks")]
    public IList<V20250301VirtualNetworksSubnetStatusResourceNavigationLinks>? ResourceNavigationLinks { get; set; }

    /// <summary>RouteTable: The reference to the RouteTable resource.</summary>
    [JsonPropertyName("routeTable")]
    public V20250301VirtualNetworksSubnetStatusRouteTable? RouteTable { get; set; }

    /// <summary>ServiceAssociationLinks: An array of references to services injecting into this subnet.</summary>
    [JsonPropertyName("serviceAssociationLinks")]
    public IList<V20250301VirtualNetworksSubnetStatusServiceAssociationLinks>? ServiceAssociationLinks { get; set; }

    /// <summary>ServiceEndpointPolicies: An array of service endpoint policies.</summary>
    [JsonPropertyName("serviceEndpointPolicies")]
    public IList<V20250301VirtualNetworksSubnetStatusServiceEndpointPolicies>? ServiceEndpointPolicies { get; set; }

    /// <summary>ServiceEndpoints: An array of service endpoints.</summary>
    [JsonPropertyName("serviceEndpoints")]
    public IList<V20250301VirtualNetworksSubnetStatusServiceEndpoints>? ServiceEndpoints { get; set; }

    /// <summary>
    /// SharingScope: Set this property to Tenant to allow sharing subnet with other subscriptions in your AAD tenant. This
    /// property can only be set if defaultOutboundAccess is set to false, both properties can only be set if subnet is empty.
    /// </summary>
    [JsonPropertyName("sharingScope")]
    public string? SharingScope { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/virtualNetwork.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301VirtualNetworksSubnet : IKubernetesObject<V1ObjectMeta>, ISpec<V20250301VirtualNetworksSubnetSpec?>, IStatus<V20250301VirtualNetworksSubnetStatus?>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "VirtualNetworksSubnet";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworkssubnets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworksSubnet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250301VirtualNetworksSubnetSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20250301VirtualNetworksSubnetStatus? Status { get; set; }
}