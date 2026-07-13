#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.frontdoor.azure.com;
/// <summary>
/// Storage version of v1api20220501.WebApplicationFirewallPolicy
/// Generator information:
/// - Generated from: /frontdoor/resource-manager/Microsoft.Network/stable/2022-05-01/webapplicationfirewall.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220501storageWebApplicationFirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1api20220501storageWebApplicationFirewallPolicy>
{
    public const string KubeApiVersion = "v1api20220501storage";
    public const string KubeKind = "WebApplicationFirewallPolicyList";
    public const string KubeGroup = "network.frontdoor.azure.com";
    public const string KubePluralName = "webapplicationfirewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.frontdoor.azure.com/v1api20220501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebApplicationFirewallPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220501storageWebApplicationFirewallPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220501storageWebApplicationFirewallPolicy> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.MatchCondition
/// Define a match condition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecCustomRulesRulesMatchConditions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("matchValue")]
    public IList<string>? MatchValue { get; set; }

    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.CustomRule
/// Defines contents of a web application rule
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecCustomRulesRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    [JsonPropertyName("matchConditions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecCustomRulesRulesMatchConditions>? MatchConditions { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("rateLimitDurationInMinutes")]
    public int? RateLimitDurationInMinutes { get; set; }

    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.CustomRuleList
/// Defines contents of custom rules
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecCustomRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecCustomRulesRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleExclusion
/// Exclude variables from managed rule evaluation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleExclusion
/// Exclude variables from managed rule evaluation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleExclusion
/// Exclude variables from managed rule evaluation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleOverride
/// Defines a managed rule group override setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions>? Exclusions { get; set; }

    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleGroupOverride
/// Defines a managed rule group override setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusions>? Exclusions { get; set; }

    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleSet
/// Defines a managed rule set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusions>? Exclusions { get; set; }

    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    [JsonPropertyName("ruleSetAction")]
    public string? RuleSetAction { get; set; }

    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleSetList
/// Defines the list of managed rule sets for the policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecManagedRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("managedRuleSets")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSets>? ManagedRuleSets { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20220501storageWebApplicationFirewallPolicySpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20220501.WebApplicationFirewallPolicyOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.PolicySettings
/// Defines top-level WebApplicationFirewallPolicy configuration settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecPolicySettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customBlockResponseBody")]
    public string? CustomBlockResponseBody { get; set; }

    [JsonPropertyName("customBlockResponseStatusCode")]
    public int? CustomBlockResponseStatusCode { get; set; }

    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    [JsonPropertyName("requestBodyCheck")]
    public string? RequestBodyCheck { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.Sku
/// The pricing tier of the web application firewall policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpecSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220501.WebApplicationFirewallPolicy_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicySpec
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
    /// Storage version of v1api20220501.CustomRuleList
    /// Defines contents of custom rules
    /// </summary>
    [JsonPropertyName("customRules")]
    public V1api20220501storageWebApplicationFirewallPolicySpecCustomRules? CustomRules { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20220501.ManagedRuleSetList
    /// Defines the list of managed rule sets for the policy.
    /// </summary>
    [JsonPropertyName("managedRules")]
    public V1api20220501storageWebApplicationFirewallPolicySpecManagedRules? ManagedRules { get; set; }

    /// <summary>
    /// Storage version of v1api20220501.WebApplicationFirewallPolicyOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220501storageWebApplicationFirewallPolicySpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220501storageWebApplicationFirewallPolicySpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20220501.PolicySettings
    /// Defines top-level WebApplicationFirewallPolicy configuration settings.
    /// </summary>
    [JsonPropertyName("policySettings")]
    public V1api20220501storageWebApplicationFirewallPolicySpecPolicySettings? PolicySettings { get; set; }

    /// <summary>
    /// Storage version of v1api20220501.Sku
    /// The pricing tier of the web application firewall policy.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20220501storageWebApplicationFirewallPolicySpecSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusConditions
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
/// Storage version of v1api20220501.MatchCondition_STATUS
/// Define a match condition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusCustomRulesRulesMatchConditions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("matchValue")]
    public IList<string>? MatchValue { get; set; }

    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.CustomRule_STATUS
/// Defines contents of a web application rule
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusCustomRulesRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    [JsonPropertyName("matchConditions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusCustomRulesRulesMatchConditions>? MatchConditions { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("rateLimitDurationInMinutes")]
    public int? RateLimitDurationInMinutes { get; set; }

    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.CustomRuleList_STATUS
/// Defines contents of custom rules
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusCustomRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusCustomRulesRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.FrontendEndpointLink_STATUS
/// Defines the Resource ID for a Frontend Endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusFrontendEndpointLinks
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
/// Storage version of v1api20220501.ManagedRuleExclusion_STATUS
/// Exclude variables from managed rule evaluation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsExclusions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleExclusion_STATUS
/// Exclude variables from managed rule evaluation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesExclusions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleExclusion_STATUS
/// Exclude variables from managed rule evaluation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleOverride_STATUS
/// Defines a managed rule group override setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions>? Exclusions { get; set; }

    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleGroupOverride_STATUS
/// Defines a managed rule group override setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesExclusions>? Exclusions { get; set; }

    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleSet_STATUS
/// Defines a managed rule set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsExclusions>? Exclusions { get; set; }

    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    [JsonPropertyName("ruleSetAction")]
    public string? RuleSetAction { get; set; }

    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.ManagedRuleSetList_STATUS
/// Defines the list of managed rule sets for the policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusManagedRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("managedRuleSets")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets>? ManagedRuleSets { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.PolicySettings_STATUS
/// Defines top-level WebApplicationFirewallPolicy configuration settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusPolicySettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customBlockResponseBody")]
    public string? CustomBlockResponseBody { get; set; }

    [JsonPropertyName("customBlockResponseStatusCode")]
    public int? CustomBlockResponseStatusCode { get; set; }

    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    [JsonPropertyName("requestBodyCheck")]
    public string? RequestBodyCheck { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.RoutingRuleLink_STATUS
/// Defines the Resource ID for a Routing Rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusRoutingRuleLinks
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
/// Storage version of v1api20220501.SecurityPolicyLink_STATUS
/// Defines the Resource ID for a Security Policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusSecurityPolicyLinks
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
/// Storage version of v1api20220501.Sku_STATUS
/// The pricing tier of the web application firewall policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatusSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220501.WebApplicationFirewallPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501storageWebApplicationFirewallPolicyStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v1api20220501.CustomRuleList_STATUS
    /// Defines contents of custom rules
    /// </summary>
    [JsonPropertyName("customRules")]
    public V1api20220501storageWebApplicationFirewallPolicyStatusCustomRules? CustomRules { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("frontendEndpointLinks")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusFrontendEndpointLinks>? FrontendEndpointLinks { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20220501.ManagedRuleSetList_STATUS
    /// Defines the list of managed rule sets for the policy.
    /// </summary>
    [JsonPropertyName("managedRules")]
    public V1api20220501storageWebApplicationFirewallPolicyStatusManagedRules? ManagedRules { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20220501.PolicySettings_STATUS
    /// Defines top-level WebApplicationFirewallPolicy configuration settings.
    /// </summary>
    [JsonPropertyName("policySettings")]
    public V1api20220501storageWebApplicationFirewallPolicyStatusPolicySettings? PolicySettings { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("resourceState")]
    public string? ResourceState { get; set; }

    [JsonPropertyName("routingRuleLinks")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusRoutingRuleLinks>? RoutingRuleLinks { get; set; }

    [JsonPropertyName("securityPolicyLinks")]
    public IList<V1api20220501storageWebApplicationFirewallPolicyStatusSecurityPolicyLinks>? SecurityPolicyLinks { get; set; }

    /// <summary>
    /// Storage version of v1api20220501.Sku_STATUS
    /// The pricing tier of the web application firewall policy.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20220501storageWebApplicationFirewallPolicyStatusSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20220501.WebApplicationFirewallPolicy
/// Generator information:
/// - Generated from: /frontdoor/resource-manager/Microsoft.Network/stable/2022-05-01/webapplicationfirewall.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220501storageWebApplicationFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220501storageWebApplicationFirewallPolicySpec?>, IStatus<V1api20220501storageWebApplicationFirewallPolicyStatus?>
{
    public const string KubeApiVersion = "v1api20220501storage";
    public const string KubeKind = "WebApplicationFirewallPolicy";
    public const string KubeGroup = "network.frontdoor.azure.com";
    public const string KubePluralName = "webapplicationfirewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.frontdoor.azure.com/v1api20220501storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebApplicationFirewallPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220501.WebApplicationFirewallPolicy_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220501storageWebApplicationFirewallPolicySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220501.WebApplicationFirewallPolicy_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20220501storageWebApplicationFirewallPolicyStatus? Status { get; set; }
}