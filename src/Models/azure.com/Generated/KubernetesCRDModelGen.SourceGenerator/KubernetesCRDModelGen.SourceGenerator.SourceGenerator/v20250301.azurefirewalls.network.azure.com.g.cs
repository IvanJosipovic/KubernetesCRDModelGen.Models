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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/azureFirewall.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301AzureFirewallList : IKubernetesObject<V1ListMeta>, IItems<V20250301AzureFirewall>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "AzureFirewallList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "azurefirewalls";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AzureFirewallList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250301AzureFirewall objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250301AzureFirewall> Items { get; set; }
}

/// <summary>Type: The type of action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301AzureFirewallSpecApplicationRuleCollectionsActionTypeEnum>))]
public enum V20250301AzureFirewallSpecApplicationRuleCollectionsActionTypeEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>Action: The action type of a rule collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecApplicationRuleCollectionsAction
{
    /// <summary>Type: The type of action.</summary>
    [JsonPropertyName("type")]
    public V20250301AzureFirewallSpecApplicationRuleCollectionsActionTypeEnum? Type { get; set; }
}

/// <summary>ProtocolType: Protocol type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301AzureFirewallSpecApplicationRuleCollectionsRulesProtocolsProtocolTypeEnum>))]
public enum V20250301AzureFirewallSpecApplicationRuleCollectionsRulesProtocolsProtocolTypeEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https,
    [EnumMember(Value = "Mssql"), JsonStringEnumMemberName("Mssql")]
    Mssql
}

/// <summary>Properties of the application rule protocol.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecApplicationRuleCollectionsRulesProtocols
{
    /// <summary>Port: Port number for the protocol, cannot be greater than 64000. This field is optional.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>ProtocolType: Protocol type.</summary>
    [JsonPropertyName("protocolType")]
    public V20250301AzureFirewallSpecApplicationRuleCollectionsRulesProtocolsProtocolTypeEnum? ProtocolType { get; set; }
}

/// <summary>Properties of an application rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecApplicationRuleCollectionsRules
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>FqdnTags: List of FQDN Tags for this rule.</summary>
    [JsonPropertyName("fqdnTags")]
    public IList<string>? FqdnTags { get; set; }

    /// <summary>Name: Name of the application rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocols: Array of ApplicationRuleProtocols.</summary>
    [JsonPropertyName("protocols")]
    public IList<V20250301AzureFirewallSpecApplicationRuleCollectionsRulesProtocols>? Protocols { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>TargetFqdns: List of FQDNs for this rule.</summary>
    [JsonPropertyName("targetFqdns")]
    public IList<string>? TargetFqdns { get; set; }
}

/// <summary>Application rule collection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecApplicationRuleCollections
{
    /// <summary>Action: The action type of a rule collection.</summary>
    [JsonPropertyName("action")]
    public V20250301AzureFirewallSpecApplicationRuleCollectionsAction? Action { get; set; }

    /// <summary>Name: The name of the resource that is unique within the Azure firewall. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the application rule collection resource.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Rules: Collection of rules used by a application rule collection.</summary>
    [JsonPropertyName("rules")]
    public IList<V20250301AzureFirewallSpecApplicationRuleCollectionsRules>? Rules { get; set; }
}

/// <summary>AutoscaleConfiguration: Properties to provide a custom autoscale configuration to this azure firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecAutoscaleConfiguration
{
    /// <summary>
    /// MaxCapacity: The maximum number of capacity units for this azure firewall. Use null to reset the value to the service
    /// default.
    /// </summary>
    [JsonPropertyName("maxCapacity")]
    public int? MaxCapacity { get; set; }

    /// <summary>
    /// MinCapacity: The minimum number of capacity units for this azure firewall. Use null to reset the value to the service
    /// default.
    /// </summary>
    [JsonPropertyName("minCapacity")]
    public int? MinCapacity { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301AzureFirewallSpecExtendedLocationTypeEnum>))]
public enum V20250301AzureFirewallSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V20250301AzureFirewallSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecFirewallPolicyReference
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

/// <summary>FirewallPolicy: The firewallPolicy associated with this azure firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecFirewallPolicy
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301AzureFirewallSpecFirewallPolicyReference? Reference { get; set; }
}

/// <summary>Public IP Address associated with azure firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecHubIPAddressesPublicIPsAddresses
{
    /// <summary>Address: Public IP Address value.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary>PublicIPs: Public IP addresses associated with azure firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecHubIPAddressesPublicIPs
{
    /// <summary>Addresses: The list of Public IP addresses associated with azure firewall or IP addresses to be retained.</summary>
    [JsonPropertyName("addresses")]
    public IList<V20250301AzureFirewallSpecHubIPAddressesPublicIPsAddresses>? Addresses { get; set; }

    /// <summary>Count: The number of Public IP addresses associated with azure firewall.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>HubIPAddresses: IP addresses associated with AzureFirewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecHubIPAddresses
{
    /// <summary>PrivateIPAddress: Private IP Address associated with azure firewall.</summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary>PublicIPs: Public IP addresses associated with azure firewall.</summary>
    [JsonPropertyName("publicIPs")]
    public V20250301AzureFirewallSpecHubIPAddressesPublicIPs? PublicIPs { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecIpConfigurationsPublicIPAddressReference
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

/// <summary>PublicIPAddress: Reference to the PublicIP resource. This field is a mandatory input if subnet is not null.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecIpConfigurationsPublicIPAddress
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301AzureFirewallSpecIpConfigurationsPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecIpConfigurationsSubnetReference
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
/// Subnet: Reference to the subnet resource. This resource must be named &apos;AzureFirewallSubnet&apos; or
/// &apos;AzureFirewallManagementSubnet&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecIpConfigurationsSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301AzureFirewallSpecIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>IP configuration of an Azure Firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecIpConfigurations
{
    /// <summary>Name: Name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PublicIPAddress: Reference to the PublicIP resource. This field is a mandatory input if subnet is not null.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V20250301AzureFirewallSpecIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>
    /// Subnet: Reference to the subnet resource. This resource must be named &apos;AzureFirewallSubnet&apos; or
    /// &apos;AzureFirewallManagementSubnet&apos;.
    /// </summary>
    [JsonPropertyName("subnet")]
    public V20250301AzureFirewallSpecIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecManagementIpConfigurationPublicIPAddressReference
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

/// <summary>PublicIPAddress: Reference to the PublicIP resource. This field is a mandatory input if subnet is not null.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecManagementIpConfigurationPublicIPAddress
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301AzureFirewallSpecManagementIpConfigurationPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecManagementIpConfigurationSubnetReference
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
/// Subnet: Reference to the subnet resource. This resource must be named &apos;AzureFirewallSubnet&apos; or
/// &apos;AzureFirewallManagementSubnet&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecManagementIpConfigurationSubnet
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301AzureFirewallSpecManagementIpConfigurationSubnetReference? Reference { get; set; }
}

/// <summary>ManagementIpConfiguration: IP configuration of the Azure Firewall used for management traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecManagementIpConfiguration
{
    /// <summary>Name: Name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PublicIPAddress: Reference to the PublicIP resource. This field is a mandatory input if subnet is not null.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V20250301AzureFirewallSpecManagementIpConfigurationPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>
    /// Subnet: Reference to the subnet resource. This resource must be named &apos;AzureFirewallSubnet&apos; or
    /// &apos;AzureFirewallManagementSubnet&apos;.
    /// </summary>
    [JsonPropertyName("subnet")]
    public V20250301AzureFirewallSpecManagementIpConfigurationSubnet? Subnet { get; set; }
}

/// <summary>Type: The type of action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301AzureFirewallSpecNatRuleCollectionsActionTypeEnum>))]
public enum V20250301AzureFirewallSpecNatRuleCollectionsActionTypeEnum
{
    [EnumMember(Value = "Dnat"), JsonStringEnumMemberName("Dnat")]
    Dnat,
    [EnumMember(Value = "Snat"), JsonStringEnumMemberName("Snat")]
    Snat
}

/// <summary>Action: The action type of a NAT rule collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecNatRuleCollectionsAction
{
    /// <summary>Type: The type of action.</summary>
    [JsonPropertyName("type")]
    public V20250301AzureFirewallSpecNatRuleCollectionsActionTypeEnum? Type { get; set; }
}

/// <summary>The protocol of a Network Rule resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301AzureFirewallSpecNatRuleCollectionsRulesProtocolsEnum>))]
public enum V20250301AzureFirewallSpecNatRuleCollectionsRulesProtocolsEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "ICMP"), JsonStringEnumMemberName("ICMP")]
    ICMP,
    [EnumMember(Value = "TCP"), JsonStringEnumMemberName("TCP")]
    TCP,
    [EnumMember(Value = "UDP"), JsonStringEnumMemberName("UDP")]
    UDP
}

/// <summary>Properties of a NAT rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecNatRuleCollectionsRules
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses for this rule. Supports IP ranges, prefixes, and service tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>DestinationPorts: List of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>Name: Name of the NAT rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocols: Array of AzureFirewallNetworkRuleProtocols applicable to this NAT rule.</summary>
    [JsonPropertyName("protocols")]
    public IList<V20250301AzureFirewallSpecNatRuleCollectionsRulesProtocolsEnum>? Protocols { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>TranslatedAddress: The translated address for this NAT rule.</summary>
    [JsonPropertyName("translatedAddress")]
    public string? TranslatedAddress { get; set; }

    /// <summary>TranslatedFqdn: The translated FQDN for this NAT rule.</summary>
    [JsonPropertyName("translatedFqdn")]
    public string? TranslatedFqdn { get; set; }

    /// <summary>TranslatedPort: The translated port for this NAT rule.</summary>
    [JsonPropertyName("translatedPort")]
    public string? TranslatedPort { get; set; }
}

/// <summary>NAT rule collection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecNatRuleCollections
{
    /// <summary>Action: The action type of a NAT rule collection.</summary>
    [JsonPropertyName("action")]
    public V20250301AzureFirewallSpecNatRuleCollectionsAction? Action { get; set; }

    /// <summary>Name: The name of the resource that is unique within the Azure firewall. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the NAT rule collection resource.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Rules: Collection of rules used by a NAT rule collection.</summary>
    [JsonPropertyName("rules")]
    public IList<V20250301AzureFirewallSpecNatRuleCollectionsRules>? Rules { get; set; }
}

/// <summary>Type: The type of action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301AzureFirewallSpecNetworkRuleCollectionsActionTypeEnum>))]
public enum V20250301AzureFirewallSpecNetworkRuleCollectionsActionTypeEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>Action: The action type of a rule collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecNetworkRuleCollectionsAction
{
    /// <summary>Type: The type of action.</summary>
    [JsonPropertyName("type")]
    public V20250301AzureFirewallSpecNetworkRuleCollectionsActionTypeEnum? Type { get; set; }
}

/// <summary>The protocol of a Network Rule resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301AzureFirewallSpecNetworkRuleCollectionsRulesProtocolsEnum>))]
public enum V20250301AzureFirewallSpecNetworkRuleCollectionsRulesProtocolsEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "ICMP"), JsonStringEnumMemberName("ICMP")]
    ICMP,
    [EnumMember(Value = "TCP"), JsonStringEnumMemberName("TCP")]
    TCP,
    [EnumMember(Value = "UDP"), JsonStringEnumMemberName("UDP")]
    UDP
}

/// <summary>Properties of the network rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecNetworkRuleCollectionsRules
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>DestinationFqdns: List of destination FQDNs.</summary>
    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    /// <summary>DestinationIpGroups: List of destination IpGroups for this rule.</summary>
    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    /// <summary>DestinationPorts: List of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>Name: Name of the network rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocols: Array of AzureFirewallNetworkRuleProtocols.</summary>
    [JsonPropertyName("protocols")]
    public IList<V20250301AzureFirewallSpecNetworkRuleCollectionsRulesProtocolsEnum>? Protocols { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>Network rule collection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecNetworkRuleCollections
{
    /// <summary>Action: The action type of a rule collection.</summary>
    [JsonPropertyName("action")]
    public V20250301AzureFirewallSpecNetworkRuleCollectionsAction? Action { get; set; }

    /// <summary>Name: The name of the resource that is unique within the Azure firewall. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the network rule collection resource.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Rules: Collection of rules used by a network rule collection.</summary>
    [JsonPropertyName("rules")]
    public IList<V20250301AzureFirewallSpecNetworkRuleCollectionsRules>? Rules { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecOperatorSpecConfigMapExpressions
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
public partial class V20250301AzureFirewallSpecOperatorSpecSecretExpressions
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
public partial class V20250301AzureFirewallSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250301AzureFirewallSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250301AzureFirewallSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Name: Name of an Azure Firewall SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301AzureFirewallSpecSkuNameEnum>))]
public enum V20250301AzureFirewallSpecSkuNameEnum
{
    [EnumMember(Value = "AZFW_Hub"), JsonStringEnumMemberName("AZFW_Hub")]
    AZFWHub,
    [EnumMember(Value = "AZFW_VNet"), JsonStringEnumMemberName("AZFW_VNet")]
    AZFWVNet
}

/// <summary>Tier: Tier of an Azure Firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301AzureFirewallSpecSkuTierEnum>))]
public enum V20250301AzureFirewallSpecSkuTierEnum
{
    [EnumMember(Value = "Basic"), JsonStringEnumMemberName("Basic")]
    Basic,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: The Azure Firewall Resource SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecSku
{
    /// <summary>Name: Name of an Azure Firewall SKU.</summary>
    [JsonPropertyName("name")]
    public V20250301AzureFirewallSpecSkuNameEnum? Name { get; set; }

    /// <summary>Tier: Tier of an Azure Firewall.</summary>
    [JsonPropertyName("tier")]
    public V20250301AzureFirewallSpecSkuTierEnum? Tier { get; set; }
}

/// <summary>ThreatIntelMode: The operation mode for Threat Intelligence.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250301AzureFirewallSpecThreatIntelModeEnum>))]
public enum V20250301AzureFirewallSpecThreatIntelModeEnum
{
    [EnumMember(Value = "Alert"), JsonStringEnumMemberName("Alert")]
    Alert,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Off"), JsonStringEnumMemberName("Off")]
    Off
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecVirtualHubReference
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

/// <summary>VirtualHub: The virtualHub to which the firewall belongs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpecVirtualHub
{
    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V20250301AzureFirewallSpecVirtualHubReference? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallSpec
{
    /// <summary>AdditionalProperties: The additional properties used to further config this azure firewall.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>ApplicationRuleCollections: Collection of application rule collections used by Azure Firewall.</summary>
    [JsonPropertyName("applicationRuleCollections")]
    public IList<V20250301AzureFirewallSpecApplicationRuleCollections>? ApplicationRuleCollections { get; set; }

    /// <summary>AutoscaleConfiguration: Properties to provide a custom autoscale configuration to this azure firewall.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public V20250301AzureFirewallSpecAutoscaleConfiguration? AutoscaleConfiguration { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20250301AzureFirewallSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FirewallPolicy: The firewallPolicy associated with this azure firewall.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V20250301AzureFirewallSpecFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary>HubIPAddresses: IP addresses associated with AzureFirewall.</summary>
    [JsonPropertyName("hubIPAddresses")]
    public V20250301AzureFirewallSpecHubIPAddresses? HubIPAddresses { get; set; }

    /// <summary>IpConfigurations: IP configuration of the Azure Firewall resource.</summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V20250301AzureFirewallSpecIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagementIpConfiguration: IP configuration of the Azure Firewall used for management traffic.</summary>
    [JsonPropertyName("managementIpConfiguration")]
    public V20250301AzureFirewallSpecManagementIpConfiguration? ManagementIpConfiguration { get; set; }

    /// <summary>NatRuleCollections: Collection of NAT rule collections used by Azure Firewall.</summary>
    [JsonPropertyName("natRuleCollections")]
    public IList<V20250301AzureFirewallSpecNatRuleCollections>? NatRuleCollections { get; set; }

    /// <summary>NetworkRuleCollections: Collection of network rule collections used by Azure Firewall.</summary>
    [JsonPropertyName("networkRuleCollections")]
    public IList<V20250301AzureFirewallSpecNetworkRuleCollections>? NetworkRuleCollections { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250301AzureFirewallSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250301AzureFirewallSpecOwner Owner { get; set; }

    /// <summary>Sku: The Azure Firewall Resource SKU.</summary>
    [JsonPropertyName("sku")]
    public V20250301AzureFirewallSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ThreatIntelMode: The operation mode for Threat Intelligence.</summary>
    [JsonPropertyName("threatIntelMode")]
    public V20250301AzureFirewallSpecThreatIntelModeEnum? ThreatIntelMode { get; set; }

    /// <summary>VirtualHub: The virtualHub to which the firewall belongs.</summary>
    [JsonPropertyName("virtualHub")]
    public V20250301AzureFirewallSpecVirtualHub? VirtualHub { get; set; }

    /// <summary>Zones: A list of availability zones denoting where the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Application rule collection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusApplicationRuleCollections
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>AutoscaleConfiguration: Properties to provide a custom autoscale configuration to this azure firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusAutoscaleConfiguration
{
    /// <summary>
    /// MaxCapacity: The maximum number of capacity units for this azure firewall. Use null to reset the value to the service
    /// default.
    /// </summary>
    [JsonPropertyName("maxCapacity")]
    public int? MaxCapacity { get; set; }

    /// <summary>
    /// MinCapacity: The minimum number of capacity units for this azure firewall. Use null to reset the value to the service
    /// default.
    /// </summary>
    [JsonPropertyName("minCapacity")]
    public int? MinCapacity { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusConditions
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

/// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>FirewallPolicy: The firewallPolicy associated with this azure firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusFirewallPolicy
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Public IP Address associated with azure firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusHubIPAddressesPublicIPsAddresses
{
    /// <summary>Address: Public IP Address value.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }
}

/// <summary>PublicIPs: Public IP addresses associated with azure firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusHubIPAddressesPublicIPs
{
    /// <summary>Addresses: The list of Public IP addresses associated with azure firewall or IP addresses to be retained.</summary>
    [JsonPropertyName("addresses")]
    public IList<V20250301AzureFirewallStatusHubIPAddressesPublicIPsAddresses>? Addresses { get; set; }

    /// <summary>Count: The number of Public IP addresses associated with azure firewall.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>HubIPAddresses: IP addresses associated with AzureFirewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusHubIPAddresses
{
    /// <summary>PrivateIPAddress: Private IP Address associated with azure firewall.</summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary>PublicIPs: Public IP addresses associated with azure firewall.</summary>
    [JsonPropertyName("publicIPs")]
    public V20250301AzureFirewallStatusHubIPAddressesPublicIPs? PublicIPs { get; set; }
}

/// <summary>IP configuration of an Azure Firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusIpConfigurations
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>IpGroups associated with azure firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusIpGroups
{
    /// <summary>ChangeNumber: The iteration number.</summary>
    [JsonPropertyName("changeNumber")]
    public string? ChangeNumber { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagementIpConfiguration: IP configuration of the Azure Firewall used for management traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusManagementIpConfiguration
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>NAT rule collection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusNatRuleCollections
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Network rule collection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusNetworkRuleCollections
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: The Azure Firewall Resource SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusSku
{
    /// <summary>Name: Name of an Azure Firewall SKU.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: Tier of an Azure Firewall.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>VirtualHub: The virtualHub to which the firewall belongs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatusVirtualHub
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Azure Firewall resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250301AzureFirewallStatus
{
    /// <summary>AdditionalProperties: The additional properties used to further config this azure firewall.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>ApplicationRuleCollections: Collection of application rule collections used by Azure Firewall.</summary>
    [JsonPropertyName("applicationRuleCollections")]
    public IList<V20250301AzureFirewallStatusApplicationRuleCollections>? ApplicationRuleCollections { get; set; }

    /// <summary>AutoscaleConfiguration: Properties to provide a custom autoscale configuration to this azure firewall.</summary>
    [JsonPropertyName("autoscaleConfiguration")]
    public V20250301AzureFirewallStatusAutoscaleConfiguration? AutoscaleConfiguration { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250301AzureFirewallStatusConditions>? Conditions { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ExtendedLocation: The extended location of type local virtual network gateway.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20250301AzureFirewallStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FirewallPolicy: The firewallPolicy associated with this azure firewall.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V20250301AzureFirewallStatusFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary>HubIPAddresses: IP addresses associated with AzureFirewall.</summary>
    [JsonPropertyName("hubIPAddresses")]
    public V20250301AzureFirewallStatusHubIPAddresses? HubIPAddresses { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IpConfigurations: IP configuration of the Azure Firewall resource.</summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V20250301AzureFirewallStatusIpConfigurations>? IpConfigurations { get; set; }

    /// <summary>IpGroups: IpGroups associated with AzureFirewall.</summary>
    [JsonPropertyName("ipGroups")]
    public IList<V20250301AzureFirewallStatusIpGroups>? IpGroups { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagementIpConfiguration: IP configuration of the Azure Firewall used for management traffic.</summary>
    [JsonPropertyName("managementIpConfiguration")]
    public V20250301AzureFirewallStatusManagementIpConfiguration? ManagementIpConfiguration { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NatRuleCollections: Collection of NAT rule collections used by Azure Firewall.</summary>
    [JsonPropertyName("natRuleCollections")]
    public IList<V20250301AzureFirewallStatusNatRuleCollections>? NatRuleCollections { get; set; }

    /// <summary>NetworkRuleCollections: Collection of network rule collections used by Azure Firewall.</summary>
    [JsonPropertyName("networkRuleCollections")]
    public IList<V20250301AzureFirewallStatusNetworkRuleCollections>? NetworkRuleCollections { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the Azure firewall resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Sku: The Azure Firewall Resource SKU.</summary>
    [JsonPropertyName("sku")]
    public V20250301AzureFirewallStatusSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>ThreatIntelMode: The operation mode for Threat Intelligence.</summary>
    [JsonPropertyName("threatIntelMode")]
    public string? ThreatIntelMode { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>VirtualHub: The virtualHub to which the firewall belongs.</summary>
    [JsonPropertyName("virtualHub")]
    public V20250301AzureFirewallStatusVirtualHub? VirtualHub { get; set; }

    /// <summary>Zones: A list of availability zones denoting where the resource needs to come from.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2025-03-01/azureFirewall.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/azureFirewalls/{azureFirewallName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250301AzureFirewall : IKubernetesObject<V1ObjectMeta>, ISpec<V20250301AzureFirewallSpec?>, IStatus<V20250301AzureFirewallStatus?>
{
    public const string KubeApiVersion = "v20250301";
    public const string KubeKind = "AzureFirewall";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "azurefirewalls";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AzureFirewall";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250301AzureFirewallSpec? Spec { get; set; }

    /// <summary>Azure Firewall resource.</summary>
    [JsonPropertyName("status")]
    public V20250301AzureFirewallStatus? Status { get; set; }
}