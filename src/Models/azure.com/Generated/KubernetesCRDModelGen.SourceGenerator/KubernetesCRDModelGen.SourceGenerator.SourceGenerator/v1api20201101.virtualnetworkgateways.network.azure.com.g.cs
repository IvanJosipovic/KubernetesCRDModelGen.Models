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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2020-11-01/virtualNetworkGateway.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201101VirtualNetworkGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1api20201101VirtualNetworkGateway>
{
    public const string KubeApiVersion = "v1api20201101";
    public const string KubeKind = "VirtualNetworkGatewayList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworkgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20201101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworkGatewayList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20201101VirtualNetworkGateway objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20201101VirtualNetworkGateway> Items { get; set; }
}

/// <summary>Properties of IPConfigurationBgpPeeringAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecBgpSettingsBgpPeeringAddresses
{
    /// <summary>CustomBgpIpAddresses: The list of custom BGP peering addresses which belong to IP configuration.</summary>
    [JsonPropertyName("customBgpIpAddresses")]
    public IList<string>? CustomBgpIpAddresses { get; set; }

    /// <summary>IpconfigurationId: The ID of IP configuration which belongs to gateway.</summary>
    [JsonPropertyName("ipconfigurationId")]
    public string? IpconfigurationId { get; set; }
}

/// <summary>BgpSettings: Virtual network gateway&apos;s BGP speaker settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecBgpSettings
{
    /// <summary>Asn: The BGP speaker&apos;s ASN.</summary>
    [JsonPropertyName("asn")]
    public int? Asn { get; set; }

    /// <summary>BgpPeeringAddress: The BGP peering address and BGP identifier of this BGP speaker.</summary>
    [JsonPropertyName("bgpPeeringAddress")]
    public string? BgpPeeringAddress { get; set; }

    /// <summary>BgpPeeringAddresses: BGP peering address with IP configuration ID for virtual network gateway.</summary>
    [JsonPropertyName("bgpPeeringAddresses")]
    public IList<V1api20201101VirtualNetworkGatewaySpecBgpSettingsBgpPeeringAddresses>? BgpPeeringAddresses { get; set; }

    /// <summary>PeerWeight: The weight added to routes learned from this BGP speaker.</summary>
    [JsonPropertyName("peerWeight")]
    public int? PeerWeight { get; set; }
}

/// <summary>
/// CustomRoutes: The reference to the address space resource which represents the custom routes address space specified by
/// the customer for virtual network gateway and VpnClient.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecCustomRoutes
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecExtendedLocationTypeEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public required V1api20201101VirtualNetworkGatewaySpecExtendedLocationTypeEnum Type { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecGatewayDefaultSiteReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecGatewayDefaultSite
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101VirtualNetworkGatewaySpecGatewayDefaultSiteReference? Reference { get; set; }
}

/// <summary>GatewayType: The type of this virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecGatewayTypeEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecGatewayTypeEnum
{
    [EnumMember(Value = "ExpressRoute"), JsonStringEnumMemberName("ExpressRoute")]
    ExpressRoute,
    [EnumMember(Value = "LocalGateway"), JsonStringEnumMemberName("LocalGateway")]
    LocalGateway,
    [EnumMember(Value = "Vpn"), JsonStringEnumMemberName("Vpn")]
    Vpn
}

/// <summary>PrivateIPAllocationMethod: The private IP address allocation method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecIpConfigurationsPrivateIPAllocationMethodEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecIpConfigurationsPrivateIPAllocationMethodEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic,
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecIpConfigurationsPublicIPAddressReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecIpConfigurationsPublicIPAddress
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101VirtualNetworkGatewaySpecIpConfigurationsPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecIpConfigurationsSubnetReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecIpConfigurationsSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101VirtualNetworkGatewaySpecIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>IP configuration for virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecIpConfigurations
{
    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateIPAllocationMethod: The private IP address allocation method.</summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public V1api20201101VirtualNetworkGatewaySpecIpConfigurationsPrivateIPAllocationMethodEnum? PrivateIPAllocationMethod { get; set; }

    /// <summary>PublicIPAddress: The reference to the public IP resource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20201101VirtualNetworkGatewaySpecIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Subnet: The reference to the subnet resource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20201101VirtualNetworkGatewaySpecIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20201101VirtualNetworkGatewaySpecOperatorSpecSecretExpressions
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
public partial class V1api20201101VirtualNetworkGatewaySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20201101VirtualNetworkGatewaySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20201101VirtualNetworkGatewaySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Name: Gateway SKU name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecSkuNameEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "ErGw1AZ"), JsonStringEnumMemberName("ErGw1AZ")]
    ErGw1AZ,
    [EnumMember(Value = "ErGw2AZ"), JsonStringEnumMemberName("ErGw2AZ")]
    ErGw2AZ,
    [EnumMember(Value = "ErGw3AZ"), JsonStringEnumMemberName("ErGw3AZ")]
    ErGw3AZ,
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecSkuTierEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "ErGw1AZ"), JsonStringEnumMemberName("ErGw1AZ")]
    ErGw1AZ,
    [EnumMember(Value = "ErGw2AZ"), JsonStringEnumMemberName("ErGw2AZ")]
    ErGw2AZ,
    [EnumMember(Value = "ErGw3AZ"), JsonStringEnumMemberName("ErGw3AZ")]
    ErGw3AZ,
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecSku
{
    /// <summary>Name: Gateway SKU name.</summary>
    [JsonPropertyName("name")]
    public V1api20201101VirtualNetworkGatewaySpecSkuNameEnum? Name { get; set; }

    /// <summary>Tier: Gateway SKU tier.</summary>
    [JsonPropertyName("tier")]
    public V1api20201101VirtualNetworkGatewaySpecSkuTierEnum? Tier { get; set; }
}

/// <summary>
/// VNetExtendedLocationResourceReference: Customer vnet resource id. VirtualNetworkGateway of type local gateway is
/// associated with the customer vnet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecVNetExtendedLocationResourceReference
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

/// <summary>RadiusServerSecret: The radius secret property of the VirtualNetworkGateway resource for vpn client connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServerSecret
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

/// <summary>RadiusServerSecret: The secret used for this radius server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServersRadiusServerSecret
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServers
{
    /// <summary>RadiusServerAddress: The address of this radius server.</summary>
    [JsonPropertyName("radiusServerAddress")]
    public required string RadiusServerAddress { get; set; }

    /// <summary>RadiusServerScore: The initial score assigned to this radius server.</summary>
    [JsonPropertyName("radiusServerScore")]
    public int? RadiusServerScore { get; set; }

    /// <summary>RadiusServerSecret: The secret used for this radius server.</summary>
    [JsonPropertyName("radiusServerSecret")]
    public V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServersRadiusServerSecret? RadiusServerSecret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnAuthenticationTypesEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnAuthenticationTypesEnum
{
    [EnumMember(Value = "AAD"), JsonStringEnumMemberName("AAD")]
    AAD,
    [EnumMember(Value = "Certificate"), JsonStringEnumMemberName("Certificate")]
    Certificate,
    [EnumMember(Value = "Radius"), JsonStringEnumMemberName("Radius")]
    Radius
}

/// <summary>VpnClientAddressPool: The reference to the address space resource which represents Address space for P2S VpnClient.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPool
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>DhGroup: The DH Group used in IKE Phase 1 for initial SA.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesDhGroupEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesDhGroupEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeEncryptionEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeEncryptionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeIntegrityEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeIntegrityEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecEncryptionEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecEncryptionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecIntegrityEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecIntegrityEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesPfsGroupEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesPfsGroupEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPolicies
{
    /// <summary>DhGroup: The DH Group used in IKE Phase 1 for initial SA.</summary>
    [JsonPropertyName("dhGroup")]
    public required V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesDhGroupEnum DhGroup { get; set; }

    /// <summary>IkeEncryption: The IKE encryption algorithm (IKE phase 2).</summary>
    [JsonPropertyName("ikeEncryption")]
    public required V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeEncryptionEnum IkeEncryption { get; set; }

    /// <summary>IkeIntegrity: The IKE integrity algorithm (IKE phase 2).</summary>
    [JsonPropertyName("ikeIntegrity")]
    public required V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIkeIntegrityEnum IkeIntegrity { get; set; }

    /// <summary>IpsecEncryption: The IPSec encryption algorithm (IKE phase 1).</summary>
    [JsonPropertyName("ipsecEncryption")]
    public required V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecEncryptionEnum IpsecEncryption { get; set; }

    /// <summary>IpsecIntegrity: The IPSec integrity algorithm (IKE phase 1).</summary>
    [JsonPropertyName("ipsecIntegrity")]
    public required V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesIpsecIntegrityEnum IpsecIntegrity { get; set; }

    /// <summary>PfsGroup: The Pfs Group used in IKE Phase 2 for new child SA.</summary>
    [JsonPropertyName("pfsGroup")]
    public required V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPoliciesPfsGroupEnum PfsGroup { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientProtocolsEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientProtocolsEnum
{
    [EnumMember(Value = "IkeV2"), JsonStringEnumMemberName("IkeV2")]
    IkeV2,
    [EnumMember(Value = "OpenVPN"), JsonStringEnumMemberName("OpenVPN")]
    OpenVPN,
    [EnumMember(Value = "SSTP"), JsonStringEnumMemberName("SSTP")]
    SSTP
}

/// <summary>VPN client revoked certificate of virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRevokedCertificates
{
    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Thumbprint: The revoked VPN client certificate thumbprint.</summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>VPN client root certificate of virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRootCertificates
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpecVpnClientConfiguration
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

    /// <summary>RadiusServerSecret: The radius secret property of the VirtualNetworkGateway resource for vpn client connection.</summary>
    [JsonPropertyName("radiusServerSecret")]
    public V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServerSecret? RadiusServerSecret { get; set; }

    /// <summary>RadiusServers: The radiusServers property for multiple radius server configuration.</summary>
    [JsonPropertyName("radiusServers")]
    public IList<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationRadiusServers>? RadiusServers { get; set; }

    /// <summary>VpnAuthenticationTypes: VPN authentication types for the virtual network gateway..</summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnAuthenticationTypesEnum>? VpnAuthenticationTypes { get; set; }

    /// <summary>VpnClientAddressPool: The reference to the address space resource which represents Address space for P2S VpnClient.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }

    /// <summary>VpnClientIpsecPolicies: VpnClientIpsecPolicies for virtual network gateway P2S client.</summary>
    [JsonPropertyName("vpnClientIpsecPolicies")]
    public IList<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPolicies>? VpnClientIpsecPolicies { get; set; }

    /// <summary>VpnClientProtocols: VpnClientProtocols for Virtual network gateway.</summary>
    [JsonPropertyName("vpnClientProtocols")]
    public IList<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientProtocolsEnum>? VpnClientProtocols { get; set; }

    /// <summary>VpnClientRevokedCertificates: VpnClientRevokedCertificate for Virtual network gateway.</summary>
    [JsonPropertyName("vpnClientRevokedCertificates")]
    public IList<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRevokedCertificates>? VpnClientRevokedCertificates { get; set; }

    /// <summary>VpnClientRootCertificates: VpnClientRootCertificate for virtual network gateway.</summary>
    [JsonPropertyName("vpnClientRootCertificates")]
    public IList<V1api20201101VirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRootCertificates>? VpnClientRootCertificates { get; set; }
}

/// <summary>VpnGatewayGeneration: The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecVpnGatewayGenerationEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecVpnGatewayGenerationEnum
{
    [EnumMember(Value = "Generation1"), JsonStringEnumMemberName("Generation1")]
    Generation1,
    [EnumMember(Value = "Generation2"), JsonStringEnumMemberName("Generation2")]
    Generation2,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>VpnType: The type of this virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20201101VirtualNetworkGatewaySpecVpnTypeEnum>))]
public enum V1api20201101VirtualNetworkGatewaySpecVpnTypeEnum
{
    [EnumMember(Value = "PolicyBased"), JsonStringEnumMemberName("PolicyBased")]
    PolicyBased,
    [EnumMember(Value = "RouteBased"), JsonStringEnumMemberName("RouteBased")]
    RouteBased
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewaySpec
{
    /// <summary>ActiveActive: ActiveActive flag.</summary>
    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>BgpSettings: Virtual network gateway&apos;s BGP speaker settings.</summary>
    [JsonPropertyName("bgpSettings")]
    public V1api20201101VirtualNetworkGatewaySpecBgpSettings? BgpSettings { get; set; }

    /// <summary>
    /// CustomRoutes: The reference to the address space resource which represents the custom routes address space specified by
    /// the customer for virtual network gateway and VpnClient.
    /// </summary>
    [JsonPropertyName("customRoutes")]
    public V1api20201101VirtualNetworkGatewaySpecCustomRoutes? CustomRoutes { get; set; }

    /// <summary>EnableBgp: Whether BGP is enabled for this virtual network gateway or not.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>EnableDnsForwarding: Whether dns forwarding is enabled or not.</summary>
    [JsonPropertyName("enableDnsForwarding")]
    public bool? EnableDnsForwarding { get; set; }

    /// <summary>EnablePrivateIpAddress: Whether private IP needs to be enabled on this gateway for connections or not.</summary>
    [JsonPropertyName("enablePrivateIpAddress")]
    public bool? EnablePrivateIpAddress { get; set; }

    /// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201101VirtualNetworkGatewaySpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// GatewayDefaultSite: The reference to the LocalNetworkGateway resource which represents local network site having default
    /// routes. Assign Null value in case of removing existing default site setting.
    /// </summary>
    [JsonPropertyName("gatewayDefaultSite")]
    public V1api20201101VirtualNetworkGatewaySpecGatewayDefaultSite? GatewayDefaultSite { get; set; }

    /// <summary>GatewayType: The type of this virtual network gateway.</summary>
    [JsonPropertyName("gatewayType")]
    public V1api20201101VirtualNetworkGatewaySpecGatewayTypeEnum? GatewayType { get; set; }

    /// <summary>IpConfigurations: IP configurations for virtual network gateway.</summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20201101VirtualNetworkGatewaySpecIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20201101VirtualNetworkGatewaySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20201101VirtualNetworkGatewaySpecOwner Owner { get; set; }

    /// <summary>
    /// Sku: The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network
    /// gateway.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20201101VirtualNetworkGatewaySpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// VNetExtendedLocationResourceReference: Customer vnet resource id. VirtualNetworkGateway of type local gateway is
    /// associated with the customer vnet.
    /// </summary>
    [JsonPropertyName("vNetExtendedLocationResourceReference")]
    public V1api20201101VirtualNetworkGatewaySpecVNetExtendedLocationResourceReference? VNetExtendedLocationResourceReference { get; set; }

    /// <summary>
    /// VpnClientConfiguration: The reference to the VpnClientConfiguration resource which represents the P2S VpnClient
    /// configurations.
    /// </summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public V1api20201101VirtualNetworkGatewaySpecVpnClientConfiguration? VpnClientConfiguration { get; set; }

    /// <summary>VpnGatewayGeneration: The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN.</summary>
    [JsonPropertyName("vpnGatewayGeneration")]
    public V1api20201101VirtualNetworkGatewaySpecVpnGatewayGenerationEnum? VpnGatewayGeneration { get; set; }

    /// <summary>VpnType: The type of this virtual network gateway.</summary>
    [JsonPropertyName("vpnType")]
    public V1api20201101VirtualNetworkGatewaySpecVpnTypeEnum? VpnType { get; set; }
}

/// <summary>Properties of IPConfigurationBgpPeeringAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusBgpSettingsBgpPeeringAddresses
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusBgpSettings
{
    /// <summary>Asn: The BGP speaker&apos;s ASN.</summary>
    [JsonPropertyName("asn")]
    public int? Asn { get; set; }

    /// <summary>BgpPeeringAddress: The BGP peering address and BGP identifier of this BGP speaker.</summary>
    [JsonPropertyName("bgpPeeringAddress")]
    public string? BgpPeeringAddress { get; set; }

    /// <summary>BgpPeeringAddresses: BGP peering address with IP configuration ID for virtual network gateway.</summary>
    [JsonPropertyName("bgpPeeringAddresses")]
    public IList<V1api20201101VirtualNetworkGatewayStatusBgpSettingsBgpPeeringAddresses>? BgpPeeringAddresses { get; set; }

    /// <summary>PeerWeight: The weight added to routes learned from this BGP speaker.</summary>
    [JsonPropertyName("peerWeight")]
    public int? PeerWeight { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusConditions
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
/// CustomRoutes: The reference to the address space resource which represents the custom routes address space specified by
/// the customer for virtual network gateway and VpnClient.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusCustomRoutes
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusExtendedLocation
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusGatewayDefaultSite
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PublicIPAddress: The reference to the public IP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusIpConfigurationsPublicIPAddress
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Subnet: The reference to the subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusIpConfigurationsSubnet
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>IP configuration for virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusIpConfigurations
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
    public V1api20201101VirtualNetworkGatewayStatusIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Subnet: The reference to the subnet resource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20201101VirtualNetworkGatewayStatusIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>
/// Sku: The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network
/// gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusSku
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

/// <summary>Radius Server Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusVpnClientConfigurationRadiusServers
{
    /// <summary>RadiusServerAddress: The address of this radius server.</summary>
    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary>RadiusServerScore: The initial score assigned to this radius server.</summary>
    [JsonPropertyName("radiusServerScore")]
    public int? RadiusServerScore { get; set; }
}

/// <summary>VpnClientAddressPool: The reference to the address space resource which represents Address space for P2S VpnClient.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPool
{
    /// <summary>AddressPrefixes: A list of address blocks reserved for this virtual network in CIDR notation.</summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>An IPSec Policy configuration for a virtual network gateway connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientIpsecPolicies
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRevokedCertificates
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRootCertificates
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatusVpnClientConfiguration
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
    public IList<V1api20201101VirtualNetworkGatewayStatusVpnClientConfigurationRadiusServers>? RadiusServers { get; set; }

    /// <summary>VpnAuthenticationTypes: VPN authentication types for the virtual network gateway..</summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>VpnClientAddressPool: The reference to the address space resource which represents Address space for P2S VpnClient.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V1api20201101VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }

    /// <summary>VpnClientIpsecPolicies: VpnClientIpsecPolicies for virtual network gateway P2S client.</summary>
    [JsonPropertyName("vpnClientIpsecPolicies")]
    public IList<V1api20201101VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientIpsecPolicies>? VpnClientIpsecPolicies { get; set; }

    /// <summary>VpnClientProtocols: VpnClientProtocols for Virtual network gateway.</summary>
    [JsonPropertyName("vpnClientProtocols")]
    public IList<string>? VpnClientProtocols { get; set; }

    /// <summary>VpnClientRevokedCertificates: VpnClientRevokedCertificate for Virtual network gateway.</summary>
    [JsonPropertyName("vpnClientRevokedCertificates")]
    public IList<V1api20201101VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRevokedCertificates>? VpnClientRevokedCertificates { get; set; }

    /// <summary>VpnClientRootCertificates: VpnClientRootCertificate for virtual network gateway.</summary>
    [JsonPropertyName("vpnClientRootCertificates")]
    public IList<V1api20201101VirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRootCertificates>? VpnClientRootCertificates { get; set; }
}

/// <summary>A common class for general resource information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20201101VirtualNetworkGatewayStatus
{
    /// <summary>ActiveActive: ActiveActive flag.</summary>
    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    /// <summary>BgpSettings: Virtual network gateway&apos;s BGP speaker settings.</summary>
    [JsonPropertyName("bgpSettings")]
    public V1api20201101VirtualNetworkGatewayStatusBgpSettings? BgpSettings { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20201101VirtualNetworkGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// CustomRoutes: The reference to the address space resource which represents the custom routes address space specified by
    /// the customer for virtual network gateway and VpnClient.
    /// </summary>
    [JsonPropertyName("customRoutes")]
    public V1api20201101VirtualNetworkGatewayStatusCustomRoutes? CustomRoutes { get; set; }

    /// <summary>EnableBgp: Whether BGP is enabled for this virtual network gateway or not.</summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary>EnableDnsForwarding: Whether dns forwarding is enabled or not.</summary>
    [JsonPropertyName("enableDnsForwarding")]
    public bool? EnableDnsForwarding { get; set; }

    /// <summary>EnablePrivateIpAddress: Whether private IP needs to be enabled on this gateway for connections or not.</summary>
    [JsonPropertyName("enablePrivateIpAddress")]
    public bool? EnablePrivateIpAddress { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201101VirtualNetworkGatewayStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// GatewayDefaultSite: The reference to the LocalNetworkGateway resource which represents local network site having default
    /// routes. Assign Null value in case of removing existing default site setting.
    /// </summary>
    [JsonPropertyName("gatewayDefaultSite")]
    public V1api20201101VirtualNetworkGatewayStatusGatewayDefaultSite? GatewayDefaultSite { get; set; }

    /// <summary>GatewayType: The type of this virtual network gateway.</summary>
    [JsonPropertyName("gatewayType")]
    public string? GatewayType { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>InboundDnsForwardingEndpoint: The IP address allocated by the gateway to which dns requests can be sent.</summary>
    [JsonPropertyName("inboundDnsForwardingEndpoint")]
    public string? InboundDnsForwardingEndpoint { get; set; }

    /// <summary>IpConfigurations: IP configurations for virtual network gateway.</summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20201101VirtualNetworkGatewayStatusIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the virtual network gateway resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceGuid: The resource GUID property of the virtual network gateway resource.</summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>
    /// Sku: The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network
    /// gateway.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20201101VirtualNetworkGatewayStatusSku? Sku { get; set; }

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
    /// VpnClientConfiguration: The reference to the VpnClientConfiguration resource which represents the P2S VpnClient
    /// configurations.
    /// </summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public V1api20201101VirtualNetworkGatewayStatusVpnClientConfiguration? VpnClientConfiguration { get; set; }

    /// <summary>VpnGatewayGeneration: The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN.</summary>
    [JsonPropertyName("vpnGatewayGeneration")]
    public string? VpnGatewayGeneration { get; set; }

    /// <summary>VpnType: The type of this virtual network gateway.</summary>
    [JsonPropertyName("vpnType")]
    public string? VpnType { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2020-11-01/virtualNetworkGateway.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20201101VirtualNetworkGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20201101VirtualNetworkGatewaySpec?>, IStatus<V1api20201101VirtualNetworkGatewayStatus?>
{
    public const string KubeApiVersion = "v1api20201101";
    public const string KubeKind = "VirtualNetworkGateway";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworkgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20201101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNetworkGateway";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20201101VirtualNetworkGatewaySpec? Spec { get; set; }

    /// <summary>A common class for general resource information.</summary>
    [JsonPropertyName("status")]
    public V1api20201101VirtualNetworkGatewayStatus? Status { get; set; }
}