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
/// Storage version of v1api20240101.WebApplicationFirewallPolicy
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-01-01/webapplicationfirewall.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240101storageWebApplicationFirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1api20240101storageWebApplicationFirewallPolicy>
{
    public const string KubeApiVersion = "v1api20240101storage";
    public const string KubeKind = "WebApplicationFirewallPolicyList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "webapplicationfirewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebApplicationFirewallPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240101storageWebApplicationFirewallPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240101storageWebApplicationFirewallPolicy> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.GroupByVariable
/// Define user session group by clause variables.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesGroupByUserSessionGroupByVariables
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.GroupByUserSession
/// Define user session identifier group by clauses.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesGroupByUserSession
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("groupByVariables")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesGroupByUserSessionGroupByVariables>? GroupByVariables { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.MatchVariable
/// Define match variables.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesMatchConditionsMatchVariables
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.MatchCondition
/// Define match conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesMatchConditions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    [JsonPropertyName("matchVariables")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesMatchConditionsMatchVariables>? MatchVariables { get; set; }

    [JsonPropertyName("negationConditon")]
    public bool? NegationConditon { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.WebApplicationFirewallCustomRule
/// Defines contents of a web application rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecCustomRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("groupByUserSession")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesGroupByUserSession>? GroupByUserSession { get; set; }

    [JsonPropertyName("matchConditions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecCustomRulesMatchConditions>? MatchConditions { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("rateLimitDuration")]
    public string? RateLimitDuration { get; set; }

    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ExclusionManagedRule
/// Defines a managed rule to use for exclusion.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ExclusionManagedRuleGroup
/// Defines a managed rule group to use for exclusion.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ExclusionManagedRuleSet
/// Defines a managed rule set for Exclusions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ruleGroups")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups>? RuleGroups { get; set; }

    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.OwaspCrsExclusionEntry
/// Allow to exclude some variable satisfy the condition for the WAF check.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exclusionManagedRuleSets")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSets>? ExclusionManagedRuleSets { get; set; }

    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ManagedRuleOverride
/// Defines a managed rule group override setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ManagedRuleGroupOverride
/// Defines a managed rule group override setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ManagedRuleSet
/// Defines a managed rule set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ManagedRulesDefinition
/// Allow to exclude some variable satisfy the condition for the WAF check.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecManagedRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesExclusions>? Exclusions { get; set; }

    [JsonPropertyName("managedRuleSets")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecManagedRulesManagedRuleSets>? ManagedRuleSets { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240101storageWebApplicationFirewallPolicySpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20240101.WebApplicationFirewallPolicyOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.WebApplicationFirewallScrubbingRules
/// Allow certain variables to be scrubbed on WAF logs
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRules
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

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.PolicySettings_LogScrubbing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecPolicySettingsLogScrubbing
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scrubbingRules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRules>? ScrubbingRules { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.PolicySettings
/// Defines contents of a web application firewall global configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpecPolicySettings
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

    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    [JsonPropertyName("fileUploadLimitInMb")]
    public int? FileUploadLimitInMb { get; set; }

    [JsonPropertyName("jsChallengeCookieExpirationInMins")]
    public int? JsChallengeCookieExpirationInMins { get; set; }

    /// <summary>Storage version of v1api20240101.PolicySettings_LogScrubbing</summary>
    [JsonPropertyName("logScrubbing")]
    public V1api20240101storageWebApplicationFirewallPolicySpecPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    [JsonPropertyName("maxRequestBodySizeInKb")]
    public int? MaxRequestBodySizeInKb { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    [JsonPropertyName("requestBodyInspectLimitInKB")]
    public int? RequestBodyInspectLimitInKB { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.WebApplicationFirewallPolicy_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicySpec
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

    [JsonPropertyName("customRules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicySpecCustomRules>? CustomRules { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20240101.ManagedRulesDefinition
    /// Allow to exclude some variable satisfy the condition for the WAF check.
    /// </summary>
    [JsonPropertyName("managedRules")]
    public V1api20240101storageWebApplicationFirewallPolicySpecManagedRules? ManagedRules { get; set; }

    /// <summary>
    /// Storage version of v1api20240101.WebApplicationFirewallPolicyOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240101storageWebApplicationFirewallPolicySpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240101storageWebApplicationFirewallPolicySpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20240101.PolicySettings
    /// Defines contents of a web application firewall global configuration.
    /// </summary>
    [JsonPropertyName("policySettings")]
    public V1api20240101storageWebApplicationFirewallPolicySpecPolicySettings? PolicySettings { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ApplicationGateway_STATUS_ApplicationGatewayWebApplicationFirewallPolicy_SubResourceEmbedded
/// Application gateway resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusApplicationGateways
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

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusConditions
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
/// Storage version of v1api20240101.GroupByVariable_STATUS
/// Define user session group by clause variables.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesGroupByUserSessionGroupByVariables
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.GroupByUserSession_STATUS
/// Define user session identifier group by clauses.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesGroupByUserSession
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("groupByVariables")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesGroupByUserSessionGroupByVariables>? GroupByVariables { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.MatchVariable_STATUS
/// Define match variables.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesMatchConditionsMatchVariables
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.MatchCondition_STATUS
/// Define match conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesMatchConditions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    [JsonPropertyName("matchVariables")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesMatchConditionsMatchVariables>? MatchVariables { get; set; }

    [JsonPropertyName("negationConditon")]
    public bool? NegationConditon { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.WebApplicationFirewallCustomRule_STATUS
/// Defines contents of a web application rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusCustomRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("groupByUserSession")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesGroupByUserSession>? GroupByUserSession { get; set; }

    [JsonPropertyName("matchConditions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusCustomRulesMatchConditions>? MatchConditions { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    [JsonPropertyName("rateLimitDuration")]
    public string? RateLimitDuration { get; set; }

    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusHttpListeners
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
/// Storage version of v1api20240101.ExclusionManagedRule_STATUS
/// Defines a managed rule to use for exclusion.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ExclusionManagedRuleGroup_STATUS
/// Defines a managed rule group to use for exclusion.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ExclusionManagedRuleSet_STATUS
/// Defines a managed rule set for Exclusions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ruleGroups")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups>? RuleGroups { get; set; }

    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.OwaspCrsExclusionEntry_STATUS
/// Allow to exclude some variable satisfy the condition for the WAF check.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exclusionManagedRuleSets")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSets>? ExclusionManagedRuleSets { get; set; }

    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ManagedRuleOverride_STATUS
/// Defines a managed rule group override setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ManagedRuleGroupOverride_STATUS
/// Defines a managed rule group override setting.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ManagedRuleSet_STATUS
/// Defines a managed rule set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.ManagedRulesDefinition_STATUS
/// Allow to exclude some variable satisfy the condition for the WAF check.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusManagedRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("exclusions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesExclusions>? Exclusions { get; set; }

    [JsonPropertyName("managedRuleSets")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets>? ManagedRuleSets { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.SubResource_STATUS
/// Reference to another subresource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusPathBasedRules
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
/// Storage version of v1api20240101.WebApplicationFirewallScrubbingRules_STATUS
/// Allow certain variables to be scrubbed on WAF logs
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettingsLogScrubbingScrubbingRules
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

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.PolicySettings_LogScrubbing_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettingsLogScrubbing
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("scrubbingRules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettingsLogScrubbingScrubbingRules>? ScrubbingRules { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.PolicySettings_STATUS
/// Defines contents of a web application firewall global configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettings
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

    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    [JsonPropertyName("fileUploadLimitInMb")]
    public int? FileUploadLimitInMb { get; set; }

    [JsonPropertyName("jsChallengeCookieExpirationInMins")]
    public int? JsChallengeCookieExpirationInMins { get; set; }

    /// <summary>Storage version of v1api20240101.PolicySettings_LogScrubbing_STATUS</summary>
    [JsonPropertyName("logScrubbing")]
    public V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    [JsonPropertyName("maxRequestBodySizeInKb")]
    public int? MaxRequestBodySizeInKb { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    [JsonPropertyName("requestBodyInspectLimitInKB")]
    public int? RequestBodyInspectLimitInKB { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20240101.WebApplicationFirewallPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101storageWebApplicationFirewallPolicyStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("applicationGateways")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusApplicationGateways>? ApplicationGateways { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("customRules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusCustomRules>? CustomRules { get; set; }

    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("httpListeners")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusHttpListeners>? HttpListeners { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20240101.ManagedRulesDefinition_STATUS
    /// Allow to exclude some variable satisfy the condition for the WAF check.
    /// </summary>
    [JsonPropertyName("managedRules")]
    public V1api20240101storageWebApplicationFirewallPolicyStatusManagedRules? ManagedRules { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pathBasedRules")]
    public IList<V1api20240101storageWebApplicationFirewallPolicyStatusPathBasedRules>? PathBasedRules { get; set; }

    /// <summary>
    /// Storage version of v1api20240101.PolicySettings_STATUS
    /// Defines contents of a web application firewall global configuration.
    /// </summary>
    [JsonPropertyName("policySettings")]
    public V1api20240101storageWebApplicationFirewallPolicyStatusPolicySettings? PolicySettings { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("resourceState")]
    public string? ResourceState { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20240101.WebApplicationFirewallPolicy
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-01-01/webapplicationfirewall.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240101storageWebApplicationFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240101storageWebApplicationFirewallPolicySpec?>, IStatus<V1api20240101storageWebApplicationFirewallPolicyStatus?>
{
    public const string KubeApiVersion = "v1api20240101storage";
    public const string KubeKind = "WebApplicationFirewallPolicy";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "webapplicationfirewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebApplicationFirewallPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240101.WebApplicationFirewallPolicy_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240101storageWebApplicationFirewallPolicySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240101.WebApplicationFirewallPolicy_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240101storageWebApplicationFirewallPolicyStatus? Status { get; set; }
}