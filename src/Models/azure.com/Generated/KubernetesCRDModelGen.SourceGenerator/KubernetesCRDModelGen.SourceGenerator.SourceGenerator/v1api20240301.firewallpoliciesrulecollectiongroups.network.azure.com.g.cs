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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/firewallPolicy.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}/ruleCollectionGroups/{ruleCollectionGroupName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupList : IKubernetesObject<V1ListMeta>, IItems<V1api20240301FirewallPoliciesRuleCollectionGroup>
{
    public const string KubeApiVersion = "v1api20240301";
    public const string KubeKind = "FirewallPoliciesRuleCollectionGroupList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "firewallpoliciesrulecollectiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPoliciesRuleCollectionGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240301FirewallPoliciesRuleCollectionGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240301FirewallPoliciesRuleCollectionGroup> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecOperatorSpecSecretExpressions
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
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/FirewallPolicy resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Type: The type of action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionActionTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionActionTypeEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>Action: The action type of a Filter rule collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionAction
{
    /// <summary>Type: The type of action.</summary>
    [JsonPropertyName("type")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionActionTypeEnum? Type { get; set; }
}

/// <summary>RuleCollectionType: The type of the rule collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRuleCollectionTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRuleCollectionTypeEnum
{
    [EnumMember(Value = "FirewallPolicyFilterRuleCollection"), JsonStringEnumMemberName("FirewallPolicyFilterRuleCollection")]
    FirewallPolicyFilterRuleCollection
}

/// <summary>name and value of HTTP/S header to insert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleHttpHeadersToInsert
{
    /// <summary>HeaderName: Contains the name of the header</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>HeaderValue: Contains the value of the header</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>ProtocolType: Protocol type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleProtocolsProtocolTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleProtocolsProtocolTypeEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https
}

/// <summary>Properties of the application rule protocol.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleProtocols
{
    /// <summary>Port: Port number for the protocol, cannot be greater than 64000.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>ProtocolType: Protocol type.</summary>
    [JsonPropertyName("protocolType")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleProtocolsProtocolTypeEnum? ProtocolType { get; set; }
}

/// <summary>RuleType: Rule Type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleRuleTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleRuleTypeEnum
{
    [EnumMember(Value = "ApplicationRule"), JsonStringEnumMemberName("ApplicationRule")]
    ApplicationRule
}

/// <summary>Application: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>FqdnTags: List of FQDN Tags for this rule.</summary>
    [JsonPropertyName("fqdnTags")]
    public IList<string>? FqdnTags { get; set; }

    /// <summary>HttpHeadersToInsert: List of HTTP/S headers to insert.</summary>
    [JsonPropertyName("httpHeadersToInsert")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleHttpHeadersToInsert>? HttpHeadersToInsert { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocols: Array of Application Protocols.</summary>
    [JsonPropertyName("protocols")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleProtocols>? Protocols { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public required V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleRuleTypeEnum RuleType { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>TargetFqdns: List of FQDNs for this rule.</summary>
    [JsonPropertyName("targetFqdns")]
    public IList<string>? TargetFqdns { get; set; }

    /// <summary>TargetUrls: List of Urls for this rule condition.</summary>
    [JsonPropertyName("targetUrls")]
    public IList<string>? TargetUrls { get; set; }

    /// <summary>TerminateTLS: Terminate TLS connections for this rule.</summary>
    [JsonPropertyName("terminateTLS")]
    public bool? TerminateTLS { get; set; }

    /// <summary>WebCategories: List of destination azure web categories.</summary>
    [JsonPropertyName("webCategories")]
    public IList<string>? WebCategories { get; set; }
}

/// <summary>The Network protocol of a Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRuleIpProtocolsEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRuleIpProtocolsEnum
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

/// <summary>RuleType: Rule Type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRuleRuleTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRuleRuleTypeEnum
{
    [EnumMember(Value = "NatRule"), JsonStringEnumMemberName("NatRule")]
    NatRule
}

/// <summary>Nat: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>DestinationPorts: List of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>IpProtocols: Array of FirewallPolicyRuleNetworkProtocols.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRuleIpProtocolsEnum>? IpProtocols { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public required V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRuleRuleTypeEnum RuleType { get; set; }

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

/// <summary>The Network protocol of a Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRuleIpProtocolsEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRuleIpProtocolsEnum
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

/// <summary>RuleType: Rule Type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRuleRuleTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRuleRuleTypeEnum
{
    [EnumMember(Value = "NetworkRule"), JsonStringEnumMemberName("NetworkRule")]
    NetworkRule
}

/// <summary>Network: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
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

    /// <summary>IpProtocols: Array of FirewallPolicyRuleNetworkProtocols.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRuleIpProtocolsEnum>? IpProtocols { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public required V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRuleRuleTypeEnum RuleType { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRules
{
    /// <summary>Application: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("applicationRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRule? ApplicationRule { get; set; }

    /// <summary>Nat: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("natRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRule? NatRule { get; set; }

    /// <summary>Network: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("networkRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRule? NetworkRule { get; set; }
}

/// <summary>FirewallPolicyFilter: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollection
{
    /// <summary>Action: The action type of a Filter rule collection.</summary>
    [JsonPropertyName("action")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionAction? Action { get; set; }

    /// <summary>Name: The name of the rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the Firewall Policy Rule Collection resource.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>RuleCollectionType: The type of the rule collection.</summary>
    [JsonPropertyName("ruleCollectionType")]
    public required V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRuleCollectionTypeEnum RuleCollectionType { get; set; }

    /// <summary>Rules: List of rules included in a rule collection.</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRules>? Rules { get; set; }
}

/// <summary>Type: The type of action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionActionTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionActionTypeEnum
{
    [EnumMember(Value = "DNAT"), JsonStringEnumMemberName("DNAT")]
    DNAT
}

/// <summary>Action: The action type of a Nat rule collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionAction
{
    /// <summary>Type: The type of action.</summary>
    [JsonPropertyName("type")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionActionTypeEnum? Type { get; set; }
}

/// <summary>RuleCollectionType: The type of the rule collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRuleCollectionTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRuleCollectionTypeEnum
{
    [EnumMember(Value = "FirewallPolicyNatRuleCollection"), JsonStringEnumMemberName("FirewallPolicyNatRuleCollection")]
    FirewallPolicyNatRuleCollection
}

/// <summary>name and value of HTTP/S header to insert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleHttpHeadersToInsert
{
    /// <summary>HeaderName: Contains the name of the header</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>HeaderValue: Contains the value of the header</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>ProtocolType: Protocol type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleProtocolsProtocolTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleProtocolsProtocolTypeEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https
}

/// <summary>Properties of the application rule protocol.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleProtocols
{
    /// <summary>Port: Port number for the protocol, cannot be greater than 64000.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>ProtocolType: Protocol type.</summary>
    [JsonPropertyName("protocolType")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleProtocolsProtocolTypeEnum? ProtocolType { get; set; }
}

/// <summary>RuleType: Rule Type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleRuleTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleRuleTypeEnum
{
    [EnumMember(Value = "ApplicationRule"), JsonStringEnumMemberName("ApplicationRule")]
    ApplicationRule
}

/// <summary>Application: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>FqdnTags: List of FQDN Tags for this rule.</summary>
    [JsonPropertyName("fqdnTags")]
    public IList<string>? FqdnTags { get; set; }

    /// <summary>HttpHeadersToInsert: List of HTTP/S headers to insert.</summary>
    [JsonPropertyName("httpHeadersToInsert")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleHttpHeadersToInsert>? HttpHeadersToInsert { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocols: Array of Application Protocols.</summary>
    [JsonPropertyName("protocols")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleProtocols>? Protocols { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public required V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleRuleTypeEnum RuleType { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>TargetFqdns: List of FQDNs for this rule.</summary>
    [JsonPropertyName("targetFqdns")]
    public IList<string>? TargetFqdns { get; set; }

    /// <summary>TargetUrls: List of Urls for this rule condition.</summary>
    [JsonPropertyName("targetUrls")]
    public IList<string>? TargetUrls { get; set; }

    /// <summary>TerminateTLS: Terminate TLS connections for this rule.</summary>
    [JsonPropertyName("terminateTLS")]
    public bool? TerminateTLS { get; set; }

    /// <summary>WebCategories: List of destination azure web categories.</summary>
    [JsonPropertyName("webCategories")]
    public IList<string>? WebCategories { get; set; }
}

/// <summary>The Network protocol of a Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRuleIpProtocolsEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRuleIpProtocolsEnum
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

/// <summary>RuleType: Rule Type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRuleRuleTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRuleRuleTypeEnum
{
    [EnumMember(Value = "NatRule"), JsonStringEnumMemberName("NatRule")]
    NatRule
}

/// <summary>Nat: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>DestinationPorts: List of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>IpProtocols: Array of FirewallPolicyRuleNetworkProtocols.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRuleIpProtocolsEnum>? IpProtocols { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public required V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRuleRuleTypeEnum RuleType { get; set; }

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

/// <summary>The Network protocol of a Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRuleIpProtocolsEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRuleIpProtocolsEnum
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

/// <summary>RuleType: Rule Type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRuleRuleTypeEnum>))]
public enum V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRuleRuleTypeEnum
{
    [EnumMember(Value = "NetworkRule"), JsonStringEnumMemberName("NetworkRule")]
    NetworkRule
}

/// <summary>Network: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
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

    /// <summary>IpProtocols: Array of FirewallPolicyRuleNetworkProtocols.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRuleIpProtocolsEnum>? IpProtocols { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public required V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRuleRuleTypeEnum RuleType { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRules
{
    /// <summary>Application: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("applicationRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRule? ApplicationRule { get; set; }

    /// <summary>Nat: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("natRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRule? NatRule { get; set; }

    /// <summary>Network: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("networkRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRule? NetworkRule { get; set; }
}

/// <summary>FirewallPolicyNat: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollection
{
    /// <summary>Action: The action type of a Nat rule collection.</summary>
    [JsonPropertyName("action")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionAction? Action { get; set; }

    /// <summary>Name: The name of the rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the Firewall Policy Rule Collection resource.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>RuleCollectionType: The type of the rule collection.</summary>
    [JsonPropertyName("ruleCollectionType")]
    public required V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRuleCollectionTypeEnum RuleCollectionType { get; set; }

    /// <summary>Rules: List of rules included in a rule collection.</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollections
{
    /// <summary>FirewallPolicyFilter: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("firewallPolicyFilterRuleCollection")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollection? FirewallPolicyFilterRuleCollection { get; set; }

    /// <summary>FirewallPolicyNat: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("firewallPolicyNatRuleCollection")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollection? FirewallPolicyNatRuleCollection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/FirewallPolicy resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240301FirewallPoliciesRuleCollectionGroupSpecOwner Owner { get; set; }

    /// <summary>Priority: Priority of the Firewall Policy Rule Collection Group resource.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>RuleCollections: Group of Firewall Policy rule collections.</summary>
    [JsonPropertyName("ruleCollections")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupSpecRuleCollections>? RuleCollections { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusConditions
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

/// <summary>Action: The action type of a Filter rule collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionAction
{
    /// <summary>Type: The type of action.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>name and value of HTTP/S header to insert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleHttpHeadersToInsert
{
    /// <summary>HeaderName: Contains the name of the header</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>HeaderValue: Contains the value of the header</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>Properties of the application rule protocol.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleProtocols
{
    /// <summary>Port: Port number for the protocol, cannot be greater than 64000.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>ProtocolType: Protocol type.</summary>
    [JsonPropertyName("protocolType")]
    public string? ProtocolType { get; set; }
}

/// <summary>Application: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>FqdnTags: List of FQDN Tags for this rule.</summary>
    [JsonPropertyName("fqdnTags")]
    public IList<string>? FqdnTags { get; set; }

    /// <summary>HttpHeadersToInsert: List of HTTP/S headers to insert.</summary>
    [JsonPropertyName("httpHeadersToInsert")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleHttpHeadersToInsert>? HttpHeadersToInsert { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocols: Array of Application Protocols.</summary>
    [JsonPropertyName("protocols")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleProtocols>? Protocols { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>TargetFqdns: List of FQDNs for this rule.</summary>
    [JsonPropertyName("targetFqdns")]
    public IList<string>? TargetFqdns { get; set; }

    /// <summary>TargetUrls: List of Urls for this rule condition.</summary>
    [JsonPropertyName("targetUrls")]
    public IList<string>? TargetUrls { get; set; }

    /// <summary>TerminateTLS: Terminate TLS connections for this rule.</summary>
    [JsonPropertyName("terminateTLS")]
    public bool? TerminateTLS { get; set; }

    /// <summary>WebCategories: List of destination azure web categories.</summary>
    [JsonPropertyName("webCategories")]
    public IList<string>? WebCategories { get; set; }
}

/// <summary>Nat: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>DestinationPorts: List of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>IpProtocols: Array of FirewallPolicyRuleNetworkProtocols.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

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

/// <summary>Network: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
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

    /// <summary>IpProtocols: Array of FirewallPolicyRuleNetworkProtocols.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRules
{
    /// <summary>Application: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("applicationRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRule? ApplicationRule { get; set; }

    /// <summary>Nat: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("natRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRule? NatRule { get; set; }

    /// <summary>Network: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("networkRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRule? NetworkRule { get; set; }
}

/// <summary>FirewallPolicyFilter: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollection
{
    /// <summary>Action: The action type of a Filter rule collection.</summary>
    [JsonPropertyName("action")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionAction? Action { get; set; }

    /// <summary>Name: The name of the rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the Firewall Policy Rule Collection resource.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>RuleCollectionType: The type of the rule collection.</summary>
    [JsonPropertyName("ruleCollectionType")]
    public string? RuleCollectionType { get; set; }

    /// <summary>Rules: List of rules included in a rule collection.</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRules>? Rules { get; set; }
}

/// <summary>Action: The action type of a Nat rule collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionAction
{
    /// <summary>Type: The type of action.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>name and value of HTTP/S header to insert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleHttpHeadersToInsert
{
    /// <summary>HeaderName: Contains the name of the header</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>HeaderValue: Contains the value of the header</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>Properties of the application rule protocol.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleProtocols
{
    /// <summary>Port: Port number for the protocol, cannot be greater than 64000.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>ProtocolType: Protocol type.</summary>
    [JsonPropertyName("protocolType")]
    public string? ProtocolType { get; set; }
}

/// <summary>Application: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>FqdnTags: List of FQDN Tags for this rule.</summary>
    [JsonPropertyName("fqdnTags")]
    public IList<string>? FqdnTags { get; set; }

    /// <summary>HttpHeadersToInsert: List of HTTP/S headers to insert.</summary>
    [JsonPropertyName("httpHeadersToInsert")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleHttpHeadersToInsert>? HttpHeadersToInsert { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Protocols: Array of Application Protocols.</summary>
    [JsonPropertyName("protocols")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleProtocols>? Protocols { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    /// <summary>TargetFqdns: List of FQDNs for this rule.</summary>
    [JsonPropertyName("targetFqdns")]
    public IList<string>? TargetFqdns { get; set; }

    /// <summary>TargetUrls: List of Urls for this rule condition.</summary>
    [JsonPropertyName("targetUrls")]
    public IList<string>? TargetUrls { get; set; }

    /// <summary>TerminateTLS: Terminate TLS connections for this rule.</summary>
    [JsonPropertyName("terminateTLS")]
    public bool? TerminateTLS { get; set; }

    /// <summary>WebCategories: List of destination azure web categories.</summary>
    [JsonPropertyName("webCategories")]
    public IList<string>? WebCategories { get; set; }
}

/// <summary>Nat: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    /// <summary>DestinationPorts: List of destination ports.</summary>
    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    /// <summary>IpProtocols: Array of FirewallPolicyRuleNetworkProtocols.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

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

/// <summary>Network: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRule
{
    /// <summary>Description: Description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>DestinationAddresses: List of destination IP addresses or Service Tags.</summary>
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

    /// <summary>IpProtocols: Array of FirewallPolicyRuleNetworkProtocols.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    /// <summary>Name: Name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RuleType: Rule Type.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>SourceAddresses: List of source IP addresses for this rule.</summary>
    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    /// <summary>SourceIpGroups: List of source IpGroups for this rule.</summary>
    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRules
{
    /// <summary>Application: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("applicationRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRule? ApplicationRule { get; set; }

    /// <summary>Nat: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("natRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRule? NatRule { get; set; }

    /// <summary>Network: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("networkRule")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRule? NetworkRule { get; set; }
}

/// <summary>FirewallPolicyNat: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollection
{
    /// <summary>Action: The action type of a Nat rule collection.</summary>
    [JsonPropertyName("action")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionAction? Action { get; set; }

    /// <summary>Name: The name of the rule collection.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the Firewall Policy Rule Collection resource.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>RuleCollectionType: The type of the rule collection.</summary>
    [JsonPropertyName("ruleCollectionType")]
    public string? RuleCollectionType { get; set; }

    /// <summary>Rules: List of rules included in a rule collection.</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollections
{
    /// <summary>FirewallPolicyFilter: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("firewallPolicyFilterRuleCollection")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollection? FirewallPolicyFilterRuleCollection { get; set; }

    /// <summary>FirewallPolicyNat: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("firewallPolicyNatRuleCollection")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollection? FirewallPolicyNatRuleCollection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroupStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupStatusConditions>? Conditions { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: The name of the resource that is unique within a resource group. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the Firewall Policy Rule Collection Group resource.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the firewall policy rule collection group resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>RuleCollections: Group of Firewall Policy rule collections.</summary>
    [JsonPropertyName("ruleCollections")]
    public IList<V1api20240301FirewallPoliciesRuleCollectionGroupStatusRuleCollections>? RuleCollections { get; set; }

    /// <summary>Size: A read-only string that represents the size of the FirewallPolicyRuleCollectionGroupProperties in MB. (ex 1.2MB)</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Type: Rule Group type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/firewallPolicy.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}/ruleCollectionGroups/{ruleCollectionGroupName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301FirewallPoliciesRuleCollectionGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301FirewallPoliciesRuleCollectionGroupSpec?>, IStatus<V1api20240301FirewallPoliciesRuleCollectionGroupStatus?>
{
    public const string KubeApiVersion = "v1api20240301";
    public const string KubeKind = "FirewallPoliciesRuleCollectionGroup";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "firewallpoliciesrulecollectiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPoliciesRuleCollectionGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20240301FirewallPoliciesRuleCollectionGroupStatus? Status { get; set; }
}