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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/publicIpAddress.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301PublicIPAddressList : IKubernetesObject<V1ListMeta>, IItems<V20250301PublicIPAddress>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "PublicIPAddressList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "publicipaddresses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PublicIPAddressList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250301PublicIPAddress objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250301PublicIPAddress> Items { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecDdosSettingsDdosProtectionPlanReference
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

/// <summary>DdosProtectionPlan: The DDoS protection plan associated with the public IP. Can only be set if ProtectionMode is Enabled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecDdosSettingsDdosProtectionPlan
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301PublicIPAddressSpecDdosSettingsDdosProtectionPlanReference? Reference { get; set; }
}

/// <summary>ProtectionMode: The DDoS protection mode of the public IP</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301PublicIPAddressSpecDdosSettingsProtectionModeEnum>))]
public enum V20250301PublicIPAddressSpecDdosSettingsProtectionModeEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "VirtualNetworkInherited"), JsonStringEnumMemberName("VirtualNetworkInherited")]
    VirtualNetworkInherited
}

/// <summary>DdosSettings: The DDoS protection custom policy associated with the public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecDdosSettings
{
    /// <summary>DdosProtectionPlan: The DDoS protection plan associated with the public IP. Can only be set if ProtectionMode is Enabled</summary>
    [JsonPropertyName("ddosProtectionPlan")]
    public V20250301PublicIPAddressSpecDdosSettingsDdosProtectionPlan? DdosProtectionPlan { get; set; }

    /// <summary>ProtectionMode: The DDoS protection mode of the public IP</summary>
    [JsonPropertyName("protectionMode")]
    public V20250301PublicIPAddressSpecDdosSettingsProtectionModeEnum? ProtectionMode { get; set; }
}

/// <summary>DeleteOption: Specify what happens to the public IP address when the VM using it is deleted</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301PublicIPAddressSpecDeleteOptionEnum>))]
public enum V20250301PublicIPAddressSpecDeleteOptionEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Detach"), JsonStringEnumMemberName("Detach")]
    Detach
}

/// <summary>
/// DomainNameLabelScope: The domain name label scope. If a domain name label and a domain name label scope are specified,
/// an A DNS record is created for the public IP in the Microsoft Azure DNS system with a hashed value includes in FQDN.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301PublicIPAddressSpecDnsSettingsDomainNameLabelScopeEnum>))]
public enum V20250301PublicIPAddressSpecDnsSettingsDomainNameLabelScopeEnum
{
    [EnumMember(Value = "NoReuse"), JsonStringEnumMemberName("NoReuse")]
    NoReuse,
    [EnumMember(Value = "ResourceGroupReuse"), JsonStringEnumMemberName("ResourceGroupReuse")]
    ResourceGroupReuse,
    [EnumMember(Value = "SubscriptionReuse"), JsonStringEnumMemberName("SubscriptionReuse")]
    SubscriptionReuse,
    [EnumMember(Value = "TenantReuse"), JsonStringEnumMemberName("TenantReuse")]
    TenantReuse
}

/// <summary>DnsSettings: The FQDN of the DNS record associated with the public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecDnsSettings
{
    /// <summary>
    /// DomainNameLabel: The domain name label. The concatenation of the domain name label and the regionalized DNS zone make up
    /// the fully qualified domain name associated with the public IP address. If a domain name label is specified, an A DNS
    /// record is created for the public IP in the Microsoft Azure DNS system.
    /// </summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>
    /// DomainNameLabelScope: The domain name label scope. If a domain name label and a domain name label scope are specified,
    /// an A DNS record is created for the public IP in the Microsoft Azure DNS system with a hashed value includes in FQDN.
    /// </summary>
    [JsonPropertyName("domainNameLabelScope")]
    public V20250301PublicIPAddressSpecDnsSettingsDomainNameLabelScopeEnum? DomainNameLabelScope { get; set; }

    /// <summary>
    /// Fqdn: The Fully Qualified Domain Name of the A DNS record associated with the public IP. This is the concatenation of
    /// the domainNameLabel and the regionalized DNS zone.
    /// </summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>
    /// ReverseFqdn: The reverse FQDN. A user-visible, fully qualified domain name that resolves to this public IP address. If
    /// the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain
    /// to the reverse FQDN.
    /// </summary>
    [JsonPropertyName("reverseFqdn")]
    public string? ReverseFqdn { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301PublicIPAddressSpecExtendedLocationTypeEnum>))]
public enum V20250301PublicIPAddressSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the public ip address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V20250301PublicIPAddressSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>Contains the IpTag associated with the object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecIpTags
{
    /// <summary>IpTagType: The IP tag type. Example: FirstPartyUsage.</summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary>Tag: The value of the IP tag associated with the public IP. Example: SQL.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecLinkedPublicIPAddressReference
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

/// <summary>LinkedPublicIPAddress: The linked public IP address of the public IP address resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecLinkedPublicIPAddress
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301PublicIPAddressSpecLinkedPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecNatGatewayReference
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

/// <summary>NatGateway: The NatGateway for the Public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecNatGateway
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301PublicIPAddressSpecNatGatewayReference? Reference { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecOperatorSpecConfigMapExpressions
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
public partial class V20250301PublicIPAddressSpecOperatorSpecSecretExpressions
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
public partial class V20250301PublicIPAddressSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250301PublicIPAddressSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250301PublicIPAddressSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicIPAddressVersion: The public IP address version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301PublicIPAddressSpecPublicIPAddressVersionEnum>))]
public enum V20250301PublicIPAddressSpecPublicIPAddressVersionEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>PublicIPAllocationMethod: The public IP address allocation method.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301PublicIPAddressSpecPublicIPAllocationMethodEnum>))]
public enum V20250301PublicIPAddressSpecPublicIPAllocationMethodEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic,
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecPublicIPPrefixReference
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

/// <summary>PublicIPPrefix: The Public IP Prefix this Public IP Address should be allocated from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecPublicIPPrefix
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301PublicIPAddressSpecPublicIPPrefixReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecServicePublicIPAddressReference
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

/// <summary>ServicePublicIPAddress: The service public IP address of the public IP address resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecServicePublicIPAddress
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301PublicIPAddressSpecServicePublicIPAddressReference? Reference { get; set; }
}

/// <summary>Name: Name of a public IP address SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301PublicIPAddressSpecSkuNameEnum>))]
public enum V20250301PublicIPAddressSpecSkuNameEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard,
    [EnumMember(Value = "StandardV2"), JsonStringEnumMemberName("StandardV2")]
    StandardV2
}

/// <summary>Tier: Tier of a public IP address SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301PublicIPAddressSpecSkuTierEnum>))]
public enum V20250301PublicIPAddressSpecSkuTierEnum
{
    [EnumMember(Value = "Global"), JsonStringEnumMemberName("Global")]
    Global,
    [EnumMember(Value = "Regional"), JsonStringEnumMemberName("Regional")]
    Regional
}

/// <summary>Sku: The public IP address SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpecSku
{
    /// <summary>Name: Name of a public IP address SKU.</summary>
    [JsonPropertyName("name")]
    public V20250301PublicIPAddressSpecSkuNameEnum? Name { get; set; }

    /// <summary>Tier: Tier of a public IP address SKU.</summary>
    [JsonPropertyName("tier")]
    public V20250301PublicIPAddressSpecSkuTierEnum? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DdosSettings: The DDoS protection custom policy associated with the public IP address.</summary>
    [JsonPropertyName("ddosSettings")]
    public V20250301PublicIPAddressSpecDdosSettings? DdosSettings { get; set; }

    /// <summary>DeleteOption: Specify what happens to the public IP address when the VM using it is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public V20250301PublicIPAddressSpecDeleteOptionEnum? DeleteOption { get; set; }

    /// <summary>DnsSettings: The FQDN of the DNS record associated with the public IP address.</summary>
    [JsonPropertyName("dnsSettings")]
    public V20250301PublicIPAddressSpecDnsSettings? DnsSettings { get; set; }

    /// <summary>ExtendedLocation: The extended location of the public ip address.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20250301PublicIPAddressSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>IdleTimeoutInMinutes: The idle timeout of the public IP address.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>IpAddress: The IP address associated with the public IP address resource.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>IpTags: The list of tags associated with the public IP address.</summary>
    [JsonPropertyName("ipTags")]
    public IList<V20250301PublicIPAddressSpecIpTags>? IpTags { get; set; }

    /// <summary>LinkedPublicIPAddress: The linked public IP address of the public IP address resource.</summary>
    [JsonPropertyName("linkedPublicIPAddress")]
    public V20250301PublicIPAddressSpecLinkedPublicIPAddress? LinkedPublicIPAddress { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>NatGateway: The NatGateway for the Public IP address.</summary>
    [JsonPropertyName("natGateway")]
    public V20250301PublicIPAddressSpecNatGateway? NatGateway { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250301PublicIPAddressSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250301PublicIPAddressSpecOwner Owner { get; set; }

    /// <summary>PublicIPAddressVersion: The public IP address version.</summary>
    [JsonPropertyName("publicIPAddressVersion")]
    public V20250301PublicIPAddressSpecPublicIPAddressVersionEnum? PublicIPAddressVersion { get; set; }

    /// <summary>PublicIPAllocationMethod: The public IP address allocation method.</summary>
    [JsonPropertyName("publicIPAllocationMethod")]
    public V20250301PublicIPAddressSpecPublicIPAllocationMethodEnum? PublicIPAllocationMethod { get; set; }

    /// <summary>PublicIPPrefix: The Public IP Prefix this Public IP Address should be allocated from.</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V20250301PublicIPAddressSpecPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>ServicePublicIPAddress: The service public IP address of the public IP address resource.</summary>
    [JsonPropertyName("servicePublicIPAddress")]
    public V20250301PublicIPAddressSpecServicePublicIPAddress? ServicePublicIPAddress { get; set; }

    /// <summary>Sku: The public IP address SKU.</summary>
    [JsonPropertyName("sku")]
    public V20250301PublicIPAddressSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Zones: A list of availability zones denoting the IP allocated for the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressStatusConditions
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

/// <summary>DdosProtectionPlan: The DDoS protection plan associated with the public IP. Can only be set if ProtectionMode is Enabled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressStatusDdosSettingsDdosProtectionPlan
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DdosSettings: The DDoS protection custom policy associated with the public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressStatusDdosSettings
{
    /// <summary>DdosProtectionPlan: The DDoS protection plan associated with the public IP. Can only be set if ProtectionMode is Enabled</summary>
    [JsonPropertyName("ddosProtectionPlan")]
    public V20250301PublicIPAddressStatusDdosSettingsDdosProtectionPlan? DdosProtectionPlan { get; set; }

    /// <summary>ProtectionMode: The DDoS protection mode of the public IP</summary>
    [JsonPropertyName("protectionMode")]
    public string? ProtectionMode { get; set; }
}

/// <summary>DnsSettings: The FQDN of the DNS record associated with the public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressStatusDnsSettings
{
    /// <summary>
    /// DomainNameLabel: The domain name label. The concatenation of the domain name label and the regionalized DNS zone make up
    /// the fully qualified domain name associated with the public IP address. If a domain name label is specified, an A DNS
    /// record is created for the public IP in the Microsoft Azure DNS system.
    /// </summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>
    /// DomainNameLabelScope: The domain name label scope. If a domain name label and a domain name label scope are specified,
    /// an A DNS record is created for the public IP in the Microsoft Azure DNS system with a hashed value includes in FQDN.
    /// </summary>
    [JsonPropertyName("domainNameLabelScope")]
    public string? DomainNameLabelScope { get; set; }

    /// <summary>
    /// Fqdn: The Fully Qualified Domain Name of the A DNS record associated with the public IP. This is the concatenation of
    /// the domainNameLabel and the regionalized DNS zone.
    /// </summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>
    /// ReverseFqdn: The reverse FQDN. A user-visible, fully qualified domain name that resolves to this public IP address. If
    /// the reverseFqdn is specified, then a PTR DNS record is created pointing from the IP address in the in-addr.arpa domain
    /// to the reverse FQDN.
    /// </summary>
    [JsonPropertyName("reverseFqdn")]
    public string? ReverseFqdn { get; set; }
}

/// <summary>ExtendedLocation: The extended location of the public ip address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>IpConfiguration: The IP configuration associated with the public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressStatusIpConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Contains the IpTag associated with the object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressStatusIpTags
{
    /// <summary>IpTagType: The IP tag type. Example: FirstPartyUsage.</summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary>Tag: The value of the IP tag associated with the public IP. Example: SQL.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>NatGateway: The NatGateway for the Public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressStatusNatGateway
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>PublicIPPrefix: The Public IP Prefix this Public IP Address should be allocated from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressStatusPublicIPPrefix
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: The public IP address SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressStatusSku
{
    /// <summary>Name: Name of a public IP address SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Tier of a public IP address SKU.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Public IP address resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301PublicIPAddressStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250301PublicIPAddressStatusConditions>? Conditions { get; set; }

    /// <summary>DdosSettings: The DDoS protection custom policy associated with the public IP address.</summary>
    [JsonPropertyName("ddosSettings")]
    public V20250301PublicIPAddressStatusDdosSettings? DdosSettings { get; set; }

    /// <summary>DeleteOption: Specify what happens to the public IP address when the VM using it is deleted</summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>DnsSettings: The FQDN of the DNS record associated with the public IP address.</summary>
    [JsonPropertyName("dnsSettings")]
    public V20250301PublicIPAddressStatusDnsSettings? DnsSettings { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ExtendedLocation: The extended location of the public ip address.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20250301PublicIPAddressStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IdleTimeoutInMinutes: The idle timeout of the public IP address.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>IpAddress: The IP address associated with the public IP address resource.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>IpConfiguration: The IP configuration associated with the public IP address.</summary>
    [JsonPropertyName("ipConfiguration")]
    public V20250301PublicIPAddressStatusIpConfiguration? IpConfiguration { get; set; }

    /// <summary>IpTags: The list of tags associated with the public IP address.</summary>
    [JsonPropertyName("ipTags")]
    public IList<V20250301PublicIPAddressStatusIpTags>? IpTags { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MigrationPhase: Migration phase of Public IP Address.</summary>
    [JsonPropertyName("migrationPhase")]
    public string? MigrationPhase { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NatGateway: The NatGateway for the Public IP address.</summary>
    [JsonPropertyName("natGateway")]
    public V20250301PublicIPAddressStatusNatGateway? NatGateway { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the public IP address resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicIPAddressVersion: The public IP address version.</summary>
    [JsonPropertyName("publicIPAddressVersion")]
    public string? PublicIPAddressVersion { get; set; }

    /// <summary>PublicIPAllocationMethod: The public IP address allocation method.</summary>
    [JsonPropertyName("publicIPAllocationMethod")]
    public string? PublicIPAllocationMethod { get; set; }

    /// <summary>PublicIPPrefix: The Public IP Prefix this Public IP Address should be allocated from.</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V20250301PublicIPAddressStatusPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>ResourceGuid: The resource GUID property of the public IP address resource.</summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>Sku: The public IP address SKU.</summary>
    [JsonPropertyName("sku")]
    public V20250301PublicIPAddressStatusSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Zones: A list of availability zones denoting the IP allocated for the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/publicIpAddress.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301PublicIPAddress : IKubernetesObject<V1ObjectMeta>, ISpec<V20250301PublicIPAddressSpec?>, IStatus<V20250301PublicIPAddressStatus?>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "PublicIPAddress";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "publicipaddresses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PublicIPAddress";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250301PublicIPAddressSpec? Spec { get; set; }

    /// <summary>Public IP address resource.</summary>
    [JsonPropertyName("status")]
    public V20250301PublicIPAddressStatus? Status { get; set; }
}