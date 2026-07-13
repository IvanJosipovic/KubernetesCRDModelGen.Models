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
/// Storage version of v1api20240301.FirewallPoliciesRuleCollectionGroup
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/firewallPolicy.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}/ruleCollectionGroups/{ruleCollectionGroupName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupList : IKubernetesObject<V1ListMeta>, IItems<V1api20240301storageFirewallPoliciesRuleCollectionGroup>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "FirewallPoliciesRuleCollectionGroupList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "firewallpoliciesrulecollectiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPoliciesRuleCollectionGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240301storageFirewallPoliciesRuleCollectionGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240301storageFirewallPoliciesRuleCollectionGroup> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20240301.FirewallPoliciesRuleCollectionGroupOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a network.azure.com/FirewallPolicy resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyFilterRuleCollectionAction
/// Properties of the FirewallPolicyFilterRuleCollectionAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionAction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyHttpHeaderToInsert
/// name and value of HTTP/S header to insert
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleHttpHeadersToInsert
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyRuleApplicationProtocol
/// Properties of the application rule protocol.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleProtocols
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("protocolType")]
    public string? ProtocolType { get; set; }
}

/// <summary>Storage version of v1api20240301.ApplicationRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("fqdnTags")]
    public IList<string>? FqdnTags { get; set; }

    [JsonPropertyName("httpHeadersToInsert")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleHttpHeadersToInsert>? HttpHeadersToInsert { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocols")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleProtocols>? Protocols { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    [JsonPropertyName("targetFqdns")]
    public IList<string>? TargetFqdns { get; set; }

    [JsonPropertyName("targetUrls")]
    public IList<string>? TargetUrls { get; set; }

    [JsonPropertyName("terminateTLS")]
    public bool? TerminateTLS { get; set; }

    [JsonPropertyName("webCategories")]
    public IList<string>? WebCategories { get; set; }
}

/// <summary>Storage version of v1api20240301.NatRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    [JsonPropertyName("translatedAddress")]
    public string? TranslatedAddress { get; set; }

    [JsonPropertyName("translatedFqdn")]
    public string? TranslatedFqdn { get; set; }

    [JsonPropertyName("translatedPort")]
    public string? TranslatedPort { get; set; }
}

/// <summary>Storage version of v1api20240301.NetworkRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPolicyRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.ApplicationRule</summary>
    [JsonPropertyName("applicationRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRule? ApplicationRule { get; set; }

    /// <summary>Storage version of v1api20240301.NatRule</summary>
    [JsonPropertyName("natRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRule? NatRule { get; set; }

    /// <summary>Storage version of v1api20240301.NetworkRule</summary>
    [JsonPropertyName("networkRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRule? NetworkRule { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPolicyFilterRuleCollection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyFilterRuleCollectionAction
    /// Properties of the FirewallPolicyFilterRuleCollectionAction.
    /// </summary>
    [JsonPropertyName("action")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionAction? Action { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("ruleCollectionType")]
    public string? RuleCollectionType { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollectionRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyNatRuleCollectionAction
/// Properties of the FirewallPolicyNatRuleCollectionAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionAction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyHttpHeaderToInsert
/// name and value of HTTP/S header to insert
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleHttpHeadersToInsert
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyRuleApplicationProtocol
/// Properties of the application rule protocol.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleProtocols
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("protocolType")]
    public string? ProtocolType { get; set; }
}

/// <summary>Storage version of v1api20240301.ApplicationRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("fqdnTags")]
    public IList<string>? FqdnTags { get; set; }

    [JsonPropertyName("httpHeadersToInsert")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleHttpHeadersToInsert>? HttpHeadersToInsert { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocols")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleProtocols>? Protocols { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    [JsonPropertyName("targetFqdns")]
    public IList<string>? TargetFqdns { get; set; }

    [JsonPropertyName("targetUrls")]
    public IList<string>? TargetUrls { get; set; }

    [JsonPropertyName("terminateTLS")]
    public bool? TerminateTLS { get; set; }

    [JsonPropertyName("webCategories")]
    public IList<string>? WebCategories { get; set; }
}

/// <summary>Storage version of v1api20240301.NatRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    [JsonPropertyName("translatedAddress")]
    public string? TranslatedAddress { get; set; }

    [JsonPropertyName("translatedFqdn")]
    public string? TranslatedFqdn { get; set; }

    [JsonPropertyName("translatedPort")]
    public string? TranslatedPort { get; set; }
}

/// <summary>Storage version of v1api20240301.NetworkRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPolicyRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.ApplicationRule</summary>
    [JsonPropertyName("applicationRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRule? ApplicationRule { get; set; }

    /// <summary>Storage version of v1api20240301.NatRule</summary>
    [JsonPropertyName("natRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRule? NatRule { get; set; }

    /// <summary>Storage version of v1api20240301.NetworkRule</summary>
    [JsonPropertyName("networkRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRule? NetworkRule { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPolicyNatRuleCollection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyNatRuleCollectionAction
    /// Properties of the FirewallPolicyNatRuleCollectionAction.
    /// </summary>
    [JsonPropertyName("action")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionAction? Action { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("ruleCollectionType")]
    public string? RuleCollectionType { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollectionRules>? Rules { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPolicyRuleCollection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollections
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.FirewallPolicyFilterRuleCollection</summary>
    [JsonPropertyName("firewallPolicyFilterRuleCollection")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyFilterRuleCollection? FirewallPolicyFilterRuleCollection { get; set; }

    /// <summary>Storage version of v1api20240301.FirewallPolicyNatRuleCollection</summary>
    [JsonPropertyName("firewallPolicyNatRuleCollection")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollectionsFirewallPolicyNatRuleCollection? FirewallPolicyNatRuleCollection { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPoliciesRuleCollectionGroup_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupSpec
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

    /// <summary>
    /// Storage version of v1api20240301.FirewallPoliciesRuleCollectionGroupOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a network.azure.com/FirewallPolicy resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecOwner Owner { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("ruleCollections")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupSpecRuleCollections>? RuleCollections { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusConditions
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
/// Storage version of v1api20240301.FirewallPolicyFilterRuleCollectionAction_STATUS
/// Properties of the FirewallPolicyFilterRuleCollectionAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionAction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyHttpHeaderToInsert_STATUS
/// name and value of HTTP/S header to insert
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleHttpHeadersToInsert
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyRuleApplicationProtocol_STATUS
/// Properties of the application rule protocol.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleProtocols
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("protocolType")]
    public string? ProtocolType { get; set; }
}

/// <summary>Storage version of v1api20240301.ApplicationRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("fqdnTags")]
    public IList<string>? FqdnTags { get; set; }

    [JsonPropertyName("httpHeadersToInsert")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleHttpHeadersToInsert>? HttpHeadersToInsert { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocols")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRuleProtocols>? Protocols { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    [JsonPropertyName("targetFqdns")]
    public IList<string>? TargetFqdns { get; set; }

    [JsonPropertyName("targetUrls")]
    public IList<string>? TargetUrls { get; set; }

    [JsonPropertyName("terminateTLS")]
    public bool? TerminateTLS { get; set; }

    [JsonPropertyName("webCategories")]
    public IList<string>? WebCategories { get; set; }
}

/// <summary>Storage version of v1api20240301.NatRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    [JsonPropertyName("translatedAddress")]
    public string? TranslatedAddress { get; set; }

    [JsonPropertyName("translatedFqdn")]
    public string? TranslatedFqdn { get; set; }

    [JsonPropertyName("translatedPort")]
    public string? TranslatedPort { get; set; }
}

/// <summary>Storage version of v1api20240301.NetworkRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPolicyRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.ApplicationRule_STATUS</summary>
    [JsonPropertyName("applicationRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesApplicationRule? ApplicationRule { get; set; }

    /// <summary>Storage version of v1api20240301.NatRule_STATUS</summary>
    [JsonPropertyName("natRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNatRule? NatRule { get; set; }

    /// <summary>Storage version of v1api20240301.NetworkRule_STATUS</summary>
    [JsonPropertyName("networkRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRulesNetworkRule? NetworkRule { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPolicyFilterRuleCollection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyFilterRuleCollectionAction_STATUS
    /// Properties of the FirewallPolicyFilterRuleCollectionAction.
    /// </summary>
    [JsonPropertyName("action")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionAction? Action { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("ruleCollectionType")]
    public string? RuleCollectionType { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollectionRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyNatRuleCollectionAction_STATUS
/// Properties of the FirewallPolicyNatRuleCollectionAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionAction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyHttpHeaderToInsert_STATUS
/// name and value of HTTP/S header to insert
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleHttpHeadersToInsert
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPolicyRuleApplicationProtocol_STATUS
/// Properties of the application rule protocol.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleProtocols
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("protocolType")]
    public string? ProtocolType { get; set; }
}

/// <summary>Storage version of v1api20240301.ApplicationRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("fqdnTags")]
    public IList<string>? FqdnTags { get; set; }

    [JsonPropertyName("httpHeadersToInsert")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleHttpHeadersToInsert>? HttpHeadersToInsert { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("protocols")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRuleProtocols>? Protocols { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    [JsonPropertyName("targetFqdns")]
    public IList<string>? TargetFqdns { get; set; }

    [JsonPropertyName("targetUrls")]
    public IList<string>? TargetUrls { get; set; }

    [JsonPropertyName("terminateTLS")]
    public bool? TerminateTLS { get; set; }

    [JsonPropertyName("webCategories")]
    public IList<string>? WebCategories { get; set; }
}

/// <summary>Storage version of v1api20240301.NatRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }

    [JsonPropertyName("translatedAddress")]
    public string? TranslatedAddress { get; set; }

    [JsonPropertyName("translatedFqdn")]
    public string? TranslatedFqdn { get; set; }

    [JsonPropertyName("translatedPort")]
    public string? TranslatedPort { get; set; }
}

/// <summary>Storage version of v1api20240301.NetworkRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRule
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("destinationAddresses")]
    public IList<string>? DestinationAddresses { get; set; }

    [JsonPropertyName("destinationFqdns")]
    public IList<string>? DestinationFqdns { get; set; }

    [JsonPropertyName("destinationIpGroups")]
    public IList<string>? DestinationIpGroups { get; set; }

    [JsonPropertyName("destinationPorts")]
    public IList<string>? DestinationPorts { get; set; }

    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("sourceAddresses")]
    public IList<string>? SourceAddresses { get; set; }

    [JsonPropertyName("sourceIpGroups")]
    public IList<string>? SourceIpGroups { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPolicyRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.ApplicationRule_STATUS</summary>
    [JsonPropertyName("applicationRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesApplicationRule? ApplicationRule { get; set; }

    /// <summary>Storage version of v1api20240301.NatRule_STATUS</summary>
    [JsonPropertyName("natRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesNatRule? NatRule { get; set; }

    /// <summary>Storage version of v1api20240301.NetworkRule_STATUS</summary>
    [JsonPropertyName("networkRule")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRulesNetworkRule? NetworkRule { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPolicyNatRuleCollection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20240301.FirewallPolicyNatRuleCollectionAction_STATUS
    /// Properties of the FirewallPolicyNatRuleCollectionAction.
    /// </summary>
    [JsonPropertyName("action")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionAction? Action { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("ruleCollectionType")]
    public string? RuleCollectionType { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollectionRules>? Rules { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPolicyRuleCollection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollections
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.FirewallPolicyFilterRuleCollection_STATUS</summary>
    [JsonPropertyName("firewallPolicyFilterRuleCollection")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyFilterRuleCollection? FirewallPolicyFilterRuleCollection { get; set; }

    /// <summary>Storage version of v1api20240301.FirewallPolicyNatRuleCollection_STATUS</summary>
    [JsonPropertyName("firewallPolicyNatRuleCollection")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollectionsFirewallPolicyNatRuleCollection? FirewallPolicyNatRuleCollection { get; set; }
}

/// <summary>Storage version of v1api20240301.FirewallPoliciesRuleCollectionGroup_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroupStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("ruleCollections")]
    public IList<V1api20240301storageFirewallPoliciesRuleCollectionGroupStatusRuleCollections>? RuleCollections { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240301.FirewallPoliciesRuleCollectionGroup
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-03-01/firewallPolicy.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/firewallPolicies/{firewallPolicyName}/ruleCollectionGroups/{ruleCollectionGroupName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageFirewallPoliciesRuleCollectionGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301storageFirewallPoliciesRuleCollectionGroupSpec?>, IStatus<V1api20240301storageFirewallPoliciesRuleCollectionGroupStatus?>
{
    public const string KubeApiVersion = "v1api20240301storage";
    public const string KubeKind = "FirewallPoliciesRuleCollectionGroup";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "firewallpoliciesrulecollectiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPoliciesRuleCollectionGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240301.FirewallPoliciesRuleCollectionGroup_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240301.FirewallPoliciesRuleCollectionGroup_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240301storageFirewallPoliciesRuleCollectionGroupStatus? Status { get; set; }
}