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
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-01-01/webapplicationfirewall.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240101WebApplicationFirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1api20240101WebApplicationFirewallPolicy>
{
    public const string KubeApiVersion = "v1api20240101";
    public const string KubeKind = "WebApplicationFirewallPolicyList";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "webapplicationfirewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebApplicationFirewallPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240101WebApplicationFirewallPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240101WebApplicationFirewallPolicy> Items { get; set; }
}

/// <summary>Action: Type of Actions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecCustomRulesActionEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecCustomRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Block"), JsonStringEnumMemberName("Block")]
    Block,
    [EnumMember(Value = "JSChallenge"), JsonStringEnumMemberName("JSChallenge")]
    JSChallenge,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log
}

/// <summary>VariableName: User Session clause variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecCustomRulesGroupByUserSessionGroupByVariablesVariableNameEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecCustomRulesGroupByUserSessionGroupByVariablesVariableNameEnum
{
    [EnumMember(Value = "ClientAddr"), JsonStringEnumMemberName("ClientAddr")]
    ClientAddr,
    [EnumMember(Value = "GeoLocation"), JsonStringEnumMemberName("GeoLocation")]
    GeoLocation,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Define user session group by clause variables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecCustomRulesGroupByUserSessionGroupByVariables
{
    /// <summary>VariableName: User Session clause variable.</summary>
    [JsonPropertyName("variableName")]
    public required V1api20240101WebApplicationFirewallPolicySpecCustomRulesGroupByUserSessionGroupByVariablesVariableNameEnum VariableName { get; set; }
}

/// <summary>Define user session identifier group by clauses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecCustomRulesGroupByUserSession
{
    /// <summary>GroupByVariables: List of group by clause variables.</summary>
    [JsonPropertyName("groupByVariables")]
    public required IList<V1api20240101WebApplicationFirewallPolicySpecCustomRulesGroupByUserSessionGroupByVariables> GroupByVariables { get; set; }
}

/// <summary>VariableName: Match Variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditionsMatchVariablesVariableNameEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditionsMatchVariablesVariableNameEnum
{
    [EnumMember(Value = "PostArgs"), JsonStringEnumMemberName("PostArgs")]
    PostArgs,
    [EnumMember(Value = "QueryString"), JsonStringEnumMemberName("QueryString")]
    QueryString,
    [EnumMember(Value = "RemoteAddr"), JsonStringEnumMemberName("RemoteAddr")]
    RemoteAddr,
    [EnumMember(Value = "RequestBody"), JsonStringEnumMemberName("RequestBody")]
    RequestBody,
    [EnumMember(Value = "RequestCookies"), JsonStringEnumMemberName("RequestCookies")]
    RequestCookies,
    [EnumMember(Value = "RequestHeaders"), JsonStringEnumMemberName("RequestHeaders")]
    RequestHeaders,
    [EnumMember(Value = "RequestMethod"), JsonStringEnumMemberName("RequestMethod")]
    RequestMethod,
    [EnumMember(Value = "RequestUri"), JsonStringEnumMemberName("RequestUri")]
    RequestUri
}

/// <summary>Define match variables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditionsMatchVariables
{
    /// <summary>Selector: The selector of match variable.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>VariableName: Match Variable.</summary>
    [JsonPropertyName("variableName")]
    public required V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditionsMatchVariablesVariableNameEnum VariableName { get; set; }
}

/// <summary>Operator: The operator to be matched.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditionsOperatorEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditionsOperatorEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "BeginsWith"), JsonStringEnumMemberName("BeginsWith")]
    BeginsWith,
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "GeoMatch"), JsonStringEnumMemberName("GeoMatch")]
    GeoMatch,
    [EnumMember(Value = "GreaterThan"), JsonStringEnumMemberName("GreaterThan")]
    GreaterThan,
    [EnumMember(Value = "GreaterThanOrEqual"), JsonStringEnumMemberName("GreaterThanOrEqual")]
    GreaterThanOrEqual,
    [EnumMember(Value = "IPMatch"), JsonStringEnumMemberName("IPMatch")]
    IPMatch,
    [EnumMember(Value = "LessThan"), JsonStringEnumMemberName("LessThan")]
    LessThan,
    [EnumMember(Value = "LessThanOrEqual"), JsonStringEnumMemberName("LessThanOrEqual")]
    LessThanOrEqual,
    [EnumMember(Value = "Regex"), JsonStringEnumMemberName("Regex")]
    Regex
}

/// <summary>Transforms applied before matching.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditionsTransformsEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditionsTransformsEnum
{
    [EnumMember(Value = "HtmlEntityDecode"), JsonStringEnumMemberName("HtmlEntityDecode")]
    HtmlEntityDecode,
    [EnumMember(Value = "Lowercase"), JsonStringEnumMemberName("Lowercase")]
    Lowercase,
    [EnumMember(Value = "RemoveNulls"), JsonStringEnumMemberName("RemoveNulls")]
    RemoveNulls,
    [EnumMember(Value = "Trim"), JsonStringEnumMemberName("Trim")]
    Trim,
    [EnumMember(Value = "Uppercase"), JsonStringEnumMemberName("Uppercase")]
    Uppercase,
    [EnumMember(Value = "UrlDecode"), JsonStringEnumMemberName("UrlDecode")]
    UrlDecode,
    [EnumMember(Value = "UrlEncode"), JsonStringEnumMemberName("UrlEncode")]
    UrlEncode
}

/// <summary>Define match conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditions
{
    /// <summary>MatchValues: Match value.</summary>
    [JsonPropertyName("matchValues")]
    public required IList<string> MatchValues { get; set; }

    /// <summary>MatchVariables: List of match variables.</summary>
    [JsonPropertyName("matchVariables")]
    public required IList<V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditionsMatchVariables> MatchVariables { get; set; }

    /// <summary>NegationConditon: Whether this is negate condition or not.</summary>
    [JsonPropertyName("negationConditon")]
    public bool? NegationConditon { get; set; }

    /// <summary>Operator: The operator to be matched.</summary>
    [JsonPropertyName("operator")]
    public required V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditionsOperatorEnum Operator { get; set; }

    /// <summary>Transforms: List of transforms.</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditionsTransformsEnum>? Transforms { get; set; }
}

/// <summary>RateLimitDuration: Duration over which Rate Limit policy will be applied. Applies only when ruleType is RateLimitRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecCustomRulesRateLimitDurationEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecCustomRulesRateLimitDurationEnum
{
    [EnumMember(Value = "FiveMins"), JsonStringEnumMemberName("FiveMins")]
    FiveMins,
    [EnumMember(Value = "OneMin"), JsonStringEnumMemberName("OneMin")]
    OneMin
}

/// <summary>RuleType: The rule type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecCustomRulesRuleTypeEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecCustomRulesRuleTypeEnum
{
    [EnumMember(Value = "Invalid"), JsonStringEnumMemberName("Invalid")]
    Invalid,
    [EnumMember(Value = "MatchRule"), JsonStringEnumMemberName("MatchRule")]
    MatchRule,
    [EnumMember(Value = "RateLimitRule"), JsonStringEnumMemberName("RateLimitRule")]
    RateLimitRule
}

/// <summary>State: Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecCustomRulesStateEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecCustomRulesStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Defines contents of a web application rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecCustomRules
{
    /// <summary>Action: Type of Actions.</summary>
    [JsonPropertyName("action")]
    public required V1api20240101WebApplicationFirewallPolicySpecCustomRulesActionEnum Action { get; set; }

    /// <summary>GroupByUserSession: List of user session identifier group by clauses.</summary>
    [JsonPropertyName("groupByUserSession")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecCustomRulesGroupByUserSession>? GroupByUserSession { get; set; }

    /// <summary>MatchConditions: List of match conditions.</summary>
    [JsonPropertyName("matchConditions")]
    public required IList<V1api20240101WebApplicationFirewallPolicySpecCustomRulesMatchConditions> MatchConditions { get; set; }

    /// <summary>Name: The name of the resource that is unique within a policy. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the rule. Rules with a lower value will be evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public required int Priority { get; set; }

    /// <summary>RateLimitDuration: Duration over which Rate Limit policy will be applied. Applies only when ruleType is RateLimitRule.</summary>
    [JsonPropertyName("rateLimitDuration")]
    public V1api20240101WebApplicationFirewallPolicySpecCustomRulesRateLimitDurationEnum? RateLimitDuration { get; set; }

    /// <summary>RateLimitThreshold: Rate Limit threshold to apply in case ruleType is RateLimitRule. Must be greater than or equal to 1</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    /// <summary>RuleType: The rule type.</summary>
    [JsonPropertyName("ruleType")]
    public required V1api20240101WebApplicationFirewallPolicySpecCustomRulesRuleTypeEnum RuleType { get; set; }

    /// <summary>State: Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified.</summary>
    [JsonPropertyName("state")]
    public V1api20240101WebApplicationFirewallPolicySpecCustomRulesStateEnum? State { get; set; }
}

/// <summary>Defines a managed rule to use for exclusion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules
{
    /// <summary>RuleId: Identifier for the managed rule.</summary>
    [JsonPropertyName("ruleId")]
    public required string RuleId { get; set; }
}

/// <summary>Defines a managed rule group to use for exclusion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups
{
    /// <summary>RuleGroupName: The managed rule group for exclusion.</summary>
    [JsonPropertyName("ruleGroupName")]
    public required string RuleGroupName { get; set; }

    /// <summary>Rules: List of rules that will be excluded. If none specified, all rules in the group will be excluded.</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules>? Rules { get; set; }
}

/// <summary>Defines a managed rule set for Exclusions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSets
{
    /// <summary>RuleGroups: Defines the rule groups to apply to the rule set.</summary>
    [JsonPropertyName("ruleGroups")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups>? RuleGroups { get; set; }

    /// <summary>RuleSetType: Defines the rule set type to use.</summary>
    [JsonPropertyName("ruleSetType")]
    public required string RuleSetType { get; set; }

    /// <summary>RuleSetVersion: Defines the version of the rule set to use.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public required string RuleSetVersion { get; set; }
}

/// <summary>MatchVariable: The variable to be excluded.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsMatchVariableEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsMatchVariableEnum
{
    [EnumMember(Value = "RequestArgKeys"), JsonStringEnumMemberName("RequestArgKeys")]
    RequestArgKeys,
    [EnumMember(Value = "RequestArgNames"), JsonStringEnumMemberName("RequestArgNames")]
    RequestArgNames,
    [EnumMember(Value = "RequestArgValues"), JsonStringEnumMemberName("RequestArgValues")]
    RequestArgValues,
    [EnumMember(Value = "RequestCookieKeys"), JsonStringEnumMemberName("RequestCookieKeys")]
    RequestCookieKeys,
    [EnumMember(Value = "RequestCookieNames"), JsonStringEnumMemberName("RequestCookieNames")]
    RequestCookieNames,
    [EnumMember(Value = "RequestCookieValues"), JsonStringEnumMemberName("RequestCookieValues")]
    RequestCookieValues,
    [EnumMember(Value = "RequestHeaderKeys"), JsonStringEnumMemberName("RequestHeaderKeys")]
    RequestHeaderKeys,
    [EnumMember(Value = "RequestHeaderNames"), JsonStringEnumMemberName("RequestHeaderNames")]
    RequestHeaderNames,
    [EnumMember(Value = "RequestHeaderValues"), JsonStringEnumMemberName("RequestHeaderValues")]
    RequestHeaderValues
}

/// <summary>
/// SelectorMatchOperator: When matchVariable is a collection, operate on the selector to specify which elements in the
/// collection this exclusion applies to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsSelectorMatchOperatorEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsSelectorMatchOperatorEnum
{
    [EnumMember(Value = "Contains"), JsonStringEnumMemberName("Contains")]
    Contains,
    [EnumMember(Value = "EndsWith"), JsonStringEnumMemberName("EndsWith")]
    EndsWith,
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "EqualsAny"), JsonStringEnumMemberName("EqualsAny")]
    EqualsAny,
    [EnumMember(Value = "StartsWith"), JsonStringEnumMemberName("StartsWith")]
    StartsWith
}

/// <summary>Allow to exclude some variable satisfy the condition for the WAF check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusions
{
    /// <summary>ExclusionManagedRuleSets: The managed rule sets that are associated with the exclusion.</summary>
    [JsonPropertyName("exclusionManagedRuleSets")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsExclusionManagedRuleSets>? ExclusionManagedRuleSets { get; set; }

    /// <summary>MatchVariable: The variable to be excluded.</summary>
    [JsonPropertyName("matchVariable")]
    public required V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsMatchVariableEnum MatchVariable { get; set; }

    /// <summary>
    /// Selector: When matchVariable is a collection, operator used to specify which elements in the collection this exclusion
    /// applies to.
    /// </summary>
    [JsonPropertyName("selector")]
    public required string Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: When matchVariable is a collection, operate on the selector to specify which elements in the
    /// collection this exclusion applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public required V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusionsSelectorMatchOperatorEnum SelectorMatchOperator { get; set; }
}

/// <summary>Action: Describes the override action to be applied when rule matches.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesActionEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "AnomalyScoring"), JsonStringEnumMemberName("AnomalyScoring")]
    AnomalyScoring,
    [EnumMember(Value = "Block"), JsonStringEnumMemberName("Block")]
    Block,
    [EnumMember(Value = "JSChallenge"), JsonStringEnumMemberName("JSChallenge")]
    JSChallenge,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log
}

/// <summary>State: The state of the managed rule. Defaults to Disabled if not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesStateEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>Action: Describes the override action to be applied when rule matches.</summary>
    [JsonPropertyName("action")]
    public V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesActionEnum? Action { get; set; }

    /// <summary>RuleId: Identifier for the managed rule.</summary>
    [JsonPropertyName("ruleId")]
    public required string RuleId { get; set; }

    /// <summary>State: The state of the managed rule. Defaults to Disabled if not specified.</summary>
    [JsonPropertyName("state")]
    public V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesStateEnum? State { get; set; }
}

/// <summary>Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>RuleGroupName: The managed rule group to override.</summary>
    [JsonPropertyName("ruleGroupName")]
    public required string RuleGroupName { get; set; }

    /// <summary>Rules: List of rules that will be disabled. If none specified, all rules in the group will be disabled.</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

/// <summary>Defines a managed rule set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSets
{
    /// <summary>RuleGroupOverrides: Defines the rule group overrides to apply to the rule set.</summary>
    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    /// <summary>RuleSetType: Defines the rule set type to use.</summary>
    [JsonPropertyName("ruleSetType")]
    public required string RuleSetType { get; set; }

    /// <summary>RuleSetVersion: Defines the version of the rule set to use.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public required string RuleSetVersion { get; set; }
}

/// <summary>ManagedRules: Describes the managedRules structure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecManagedRules
{
    /// <summary>Exclusions: The Exclusions that are applied on the policy.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecManagedRulesExclusions>? Exclusions { get; set; }

    /// <summary>ManagedRuleSets: The managed rule sets that are associated with the policy.</summary>
    [JsonPropertyName("managedRuleSets")]
    public required IList<V1api20240101WebApplicationFirewallPolicySpecManagedRulesManagedRuleSets> ManagedRuleSets { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240101WebApplicationFirewallPolicySpecOperatorSpecSecretExpressions
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
public partial class V1api20240101WebApplicationFirewallPolicySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>MatchVariable: The variable to be scrubbed from the logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRulesMatchVariableEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRulesMatchVariableEnum
{
    [EnumMember(Value = "RequestArgNames"), JsonStringEnumMemberName("RequestArgNames")]
    RequestArgNames,
    [EnumMember(Value = "RequestCookieNames"), JsonStringEnumMemberName("RequestCookieNames")]
    RequestCookieNames,
    [EnumMember(Value = "RequestHeaderNames"), JsonStringEnumMemberName("RequestHeaderNames")]
    RequestHeaderNames,
    [EnumMember(Value = "RequestIPAddress"), JsonStringEnumMemberName("RequestIPAddress")]
    RequestIPAddress,
    [EnumMember(Value = "RequestJSONArgNames"), JsonStringEnumMemberName("RequestJSONArgNames")]
    RequestJSONArgNames,
    [EnumMember(Value = "RequestPostArgNames"), JsonStringEnumMemberName("RequestPostArgNames")]
    RequestPostArgNames
}

/// <summary>
/// SelectorMatchOperator: When matchVariable is a collection, operate on the selector to specify which elements in the
/// collection this rule applies to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRulesSelectorMatchOperatorEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRulesSelectorMatchOperatorEnum
{
    [EnumMember(Value = "Equals"), JsonStringEnumMemberName("Equals")]
    Equals,
    [EnumMember(Value = "EqualsAny"), JsonStringEnumMemberName("EqualsAny")]
    EqualsAny
}

/// <summary>State: Defines the state of log scrubbing rule. Default value is Enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRulesStateEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRulesStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Allow certain variables to be scrubbed on WAF logs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRules
{
    /// <summary>MatchVariable: The variable to be scrubbed from the logs.</summary>
    [JsonPropertyName("matchVariable")]
    public required V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRulesMatchVariableEnum MatchVariable { get; set; }

    /// <summary>
    /// Selector: When matchVariable is a collection, operator used to specify which elements in the collection this rule
    /// applies to.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: When matchVariable is a collection, operate on the selector to specify which elements in the
    /// collection this rule applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public required V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRulesSelectorMatchOperatorEnum SelectorMatchOperator { get; set; }

    /// <summary>State: Defines the state of log scrubbing rule. Default value is Enabled.</summary>
    [JsonPropertyName("state")]
    public V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRulesStateEnum? State { get; set; }
}

/// <summary>State: State of the log scrubbing config. Default value is Enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingStateEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>LogScrubbing: To scrub sensitive log fields</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbing
{
    /// <summary>ScrubbingRules: The rules that are applied to the logs for scrubbing.</summary>
    [JsonPropertyName("scrubbingRules")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingScrubbingRules>? ScrubbingRules { get; set; }

    /// <summary>State: State of the log scrubbing config. Default value is Enabled.</summary>
    [JsonPropertyName("state")]
    public V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbingStateEnum? State { get; set; }
}

/// <summary>Mode: The mode of the policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecPolicySettingsModeEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecPolicySettingsModeEnum
{
    [EnumMember(Value = "Detection"), JsonStringEnumMemberName("Detection")]
    Detection,
    [EnumMember(Value = "Prevention"), JsonStringEnumMemberName("Prevention")]
    Prevention
}

/// <summary>State: The state of the policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240101WebApplicationFirewallPolicySpecPolicySettingsStateEnum>))]
public enum V1api20240101WebApplicationFirewallPolicySpecPolicySettingsStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>PolicySettings: The PolicySettings for policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpecPolicySettings
{
    /// <summary>
    /// CustomBlockResponseBody: If the action type is block, customer can override the response body. The body must be
    /// specified in base64 encoding.
    /// </summary>
    [JsonPropertyName("customBlockResponseBody")]
    public string? CustomBlockResponseBody { get; set; }

    /// <summary>CustomBlockResponseStatusCode: If the action type is block, customer can override the response status code.</summary>
    [JsonPropertyName("customBlockResponseStatusCode")]
    public int? CustomBlockResponseStatusCode { get; set; }

    /// <summary>FileUploadEnforcement: Whether allow WAF to enforce file upload limits.</summary>
    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    /// <summary>FileUploadLimitInMb: Maximum file upload size in Mb for WAF.</summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public int? FileUploadLimitInMb { get; set; }

    /// <summary>JsChallengeCookieExpirationInMins: Web Application Firewall JavaScript Challenge Cookie Expiration time in minutes.</summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMins")]
    public int? JsChallengeCookieExpirationInMins { get; set; }

    /// <summary>LogScrubbing: To scrub sensitive log fields</summary>
    [JsonPropertyName("logScrubbing")]
    public V1api20240101WebApplicationFirewallPolicySpecPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    /// <summary>MaxRequestBodySizeInKb: Maximum request body size in Kb for WAF.</summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public int? MaxRequestBodySizeInKb { get; set; }

    /// <summary>Mode: The mode of the policy.</summary>
    [JsonPropertyName("mode")]
    public V1api20240101WebApplicationFirewallPolicySpecPolicySettingsModeEnum? Mode { get; set; }

    /// <summary>RequestBodyCheck: Whether to allow WAF to check request Body.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>RequestBodyEnforcement: Whether allow WAF to enforce request body limits.</summary>
    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    /// <summary>RequestBodyInspectLimitInKB: Max inspection limit in KB for request body inspection for WAF.</summary>
    [JsonPropertyName("requestBodyInspectLimitInKB")]
    public int? RequestBodyInspectLimitInKB { get; set; }

    /// <summary>State: The state of the policy.</summary>
    [JsonPropertyName("state")]
    public V1api20240101WebApplicationFirewallPolicySpecPolicySettingsStateEnum? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicySpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CustomRules: The custom rules inside the policy.</summary>
    [JsonPropertyName("customRules")]
    public IList<V1api20240101WebApplicationFirewallPolicySpecCustomRules>? CustomRules { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedRules: Describes the managedRules structure.</summary>
    [JsonPropertyName("managedRules")]
    public required V1api20240101WebApplicationFirewallPolicySpecManagedRules ManagedRules { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240101WebApplicationFirewallPolicySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240101WebApplicationFirewallPolicySpecOwner Owner { get; set; }

    /// <summary>PolicySettings: The PolicySettings for policy.</summary>
    [JsonPropertyName("policySettings")]
    public V1api20240101WebApplicationFirewallPolicySpecPolicySettings? PolicySettings { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Application gateway resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusApplicationGateways
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusConditions
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

/// <summary>Define user session group by clause variables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusCustomRulesGroupByUserSessionGroupByVariables
{
    /// <summary>VariableName: User Session clause variable.</summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary>Define user session identifier group by clauses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusCustomRulesGroupByUserSession
{
    /// <summary>GroupByVariables: List of group by clause variables.</summary>
    [JsonPropertyName("groupByVariables")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusCustomRulesGroupByUserSessionGroupByVariables>? GroupByVariables { get; set; }
}

/// <summary>Define match variables.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusCustomRulesMatchConditionsMatchVariables
{
    /// <summary>Selector: The selector of match variable.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>VariableName: Match Variable.</summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

/// <summary>Define match conditions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusCustomRulesMatchConditions
{
    /// <summary>MatchValues: Match value.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>MatchVariables: List of match variables.</summary>
    [JsonPropertyName("matchVariables")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusCustomRulesMatchConditionsMatchVariables>? MatchVariables { get; set; }

    /// <summary>NegationConditon: Whether this is negate condition or not.</summary>
    [JsonPropertyName("negationConditon")]
    public bool? NegationConditon { get; set; }

    /// <summary>Operator: The operator to be matched.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Transforms: List of transforms.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>Defines contents of a web application rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusCustomRules
{
    /// <summary>Action: Type of Actions.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>GroupByUserSession: List of user session identifier group by clauses.</summary>
    [JsonPropertyName("groupByUserSession")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusCustomRulesGroupByUserSession>? GroupByUserSession { get; set; }

    /// <summary>MatchConditions: List of match conditions.</summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusCustomRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary>Name: The name of the resource that is unique within a policy. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Priority of the rule. Rules with a lower value will be evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>RateLimitDuration: Duration over which Rate Limit policy will be applied. Applies only when ruleType is RateLimitRule.</summary>
    [JsonPropertyName("rateLimitDuration")]
    public string? RateLimitDuration { get; set; }

    /// <summary>RateLimitThreshold: Rate Limit threshold to apply in case ruleType is RateLimitRule. Must be greater than or equal to 1</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    /// <summary>RuleType: The rule type.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }

    /// <summary>State: Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusHttpListeners
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Defines a managed rule to use for exclusion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules
{
    /// <summary>RuleId: Identifier for the managed rule.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

/// <summary>Defines a managed rule group to use for exclusion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups
{
    /// <summary>RuleGroupName: The managed rule group for exclusion.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary>Rules: List of rules that will be excluded. If none specified, all rules in the group will be excluded.</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroupsRules>? Rules { get; set; }
}

/// <summary>Defines a managed rule set for Exclusions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSets
{
    /// <summary>RuleGroups: Defines the rule groups to apply to the rule set.</summary>
    [JsonPropertyName("ruleGroups")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSetsRuleGroups>? RuleGroups { get; set; }

    /// <summary>RuleSetType: Defines the rule set type to use.</summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary>RuleSetVersion: Defines the version of the rule set to use.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>Allow to exclude some variable satisfy the condition for the WAF check.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusManagedRulesExclusions
{
    /// <summary>ExclusionManagedRuleSets: The managed rule sets that are associated with the exclusion.</summary>
    [JsonPropertyName("exclusionManagedRuleSets")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusManagedRulesExclusionsExclusionManagedRuleSets>? ExclusionManagedRuleSets { get; set; }

    /// <summary>MatchVariable: The variable to be excluded.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>
    /// Selector: When matchVariable is a collection, operator used to specify which elements in the collection this exclusion
    /// applies to.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: When matchVariable is a collection, operate on the selector to specify which elements in the
    /// collection this exclusion applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>Action: Describes the override action to be applied when rule matches.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>RuleId: Identifier for the managed rule.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>State: The state of the managed rule. Defaults to Disabled if not specified.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>RuleGroupName: The managed rule group to override.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary>Rules: List of rules that will be disabled. If none specified, all rules in the group will be disabled.</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

/// <summary>Defines a managed rule set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets
{
    /// <summary>RuleGroupOverrides: Defines the rule group overrides to apply to the rule set.</summary>
    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    /// <summary>RuleSetType: Defines the rule set type to use.</summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary>RuleSetVersion: Defines the version of the rule set to use.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>ManagedRules: Describes the managedRules structure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusManagedRules
{
    /// <summary>Exclusions: The Exclusions that are applied on the policy.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusManagedRulesExclusions>? Exclusions { get; set; }

    /// <summary>ManagedRuleSets: The managed rule sets that are associated with the policy.</summary>
    [JsonPropertyName("managedRuleSets")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets>? ManagedRuleSets { get; set; }
}

/// <summary>Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusPathBasedRules
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Allow certain variables to be scrubbed on WAF logs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusPolicySettingsLogScrubbingScrubbingRules
{
    /// <summary>MatchVariable: The variable to be scrubbed from the logs.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>
    /// Selector: When matchVariable is a collection, operator used to specify which elements in the collection this rule
    /// applies to.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: When matchVariable is a collection, operate on the selector to specify which elements in the
    /// collection this rule applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }

    /// <summary>State: Defines the state of log scrubbing rule. Default value is Enabled.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>LogScrubbing: To scrub sensitive log fields</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusPolicySettingsLogScrubbing
{
    /// <summary>ScrubbingRules: The rules that are applied to the logs for scrubbing.</summary>
    [JsonPropertyName("scrubbingRules")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusPolicySettingsLogScrubbingScrubbingRules>? ScrubbingRules { get; set; }

    /// <summary>State: State of the log scrubbing config. Default value is Enabled.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>PolicySettings: The PolicySettings for policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatusPolicySettings
{
    /// <summary>
    /// CustomBlockResponseBody: If the action type is block, customer can override the response body. The body must be
    /// specified in base64 encoding.
    /// </summary>
    [JsonPropertyName("customBlockResponseBody")]
    public string? CustomBlockResponseBody { get; set; }

    /// <summary>CustomBlockResponseStatusCode: If the action type is block, customer can override the response status code.</summary>
    [JsonPropertyName("customBlockResponseStatusCode")]
    public int? CustomBlockResponseStatusCode { get; set; }

    /// <summary>FileUploadEnforcement: Whether allow WAF to enforce file upload limits.</summary>
    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    /// <summary>FileUploadLimitInMb: Maximum file upload size in Mb for WAF.</summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public int? FileUploadLimitInMb { get; set; }

    /// <summary>JsChallengeCookieExpirationInMins: Web Application Firewall JavaScript Challenge Cookie Expiration time in minutes.</summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMins")]
    public int? JsChallengeCookieExpirationInMins { get; set; }

    /// <summary>LogScrubbing: To scrub sensitive log fields</summary>
    [JsonPropertyName("logScrubbing")]
    public V1api20240101WebApplicationFirewallPolicyStatusPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    /// <summary>MaxRequestBodySizeInKb: Maximum request body size in Kb for WAF.</summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public int? MaxRequestBodySizeInKb { get; set; }

    /// <summary>Mode: The mode of the policy.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>RequestBodyCheck: Whether to allow WAF to check request Body.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>RequestBodyEnforcement: Whether allow WAF to enforce request body limits.</summary>
    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    /// <summary>RequestBodyInspectLimitInKB: Max inspection limit in KB for request body inspection for WAF.</summary>
    [JsonPropertyName("requestBodyInspectLimitInKB")]
    public int? RequestBodyInspectLimitInKB { get; set; }

    /// <summary>State: The state of the policy.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101WebApplicationFirewallPolicyStatus
{
    /// <summary>ApplicationGateways: A collection of references to application gateways.</summary>
    [JsonPropertyName("applicationGateways")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusApplicationGateways>? ApplicationGateways { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>CustomRules: The custom rules inside the policy.</summary>
    [JsonPropertyName("customRules")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusCustomRules>? CustomRules { get; set; }

    /// <summary>Etag: A unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>HttpListeners: A collection of references to application gateway http listeners.</summary>
    [JsonPropertyName("httpListeners")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusHttpListeners>? HttpListeners { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedRules: Describes the managedRules structure.</summary>
    [JsonPropertyName("managedRules")]
    public V1api20240101WebApplicationFirewallPolicyStatusManagedRules? ManagedRules { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PathBasedRules: A collection of references to application gateway path rules.</summary>
    [JsonPropertyName("pathBasedRules")]
    public IList<V1api20240101WebApplicationFirewallPolicyStatusPathBasedRules>? PathBasedRules { get; set; }

    /// <summary>PolicySettings: The PolicySettings for policy.</summary>
    [JsonPropertyName("policySettings")]
    public V1api20240101WebApplicationFirewallPolicyStatusPolicySettings? PolicySettings { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the web application firewall policy resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>ResourceState: Resource status of the policy.</summary>
    [JsonPropertyName("resourceState")]
    public string? ResourceState { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /network/resource-manager/Microsoft.Network/Network/stable/2024-01-01/webapplicationfirewall.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ApplicationGatewayWebApplicationFirewallPolicies/{policyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240101WebApplicationFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240101WebApplicationFirewallPolicySpec?>, IStatus<V1api20240101WebApplicationFirewallPolicyStatus?>
{
    public const string KubeApiVersion = "v1api20240101";
    public const string KubeKind = "WebApplicationFirewallPolicy";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "webapplicationfirewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.com/v1api20240101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebApplicationFirewallPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240101WebApplicationFirewallPolicySpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20240101WebApplicationFirewallPolicyStatus? Status { get; set; }
}