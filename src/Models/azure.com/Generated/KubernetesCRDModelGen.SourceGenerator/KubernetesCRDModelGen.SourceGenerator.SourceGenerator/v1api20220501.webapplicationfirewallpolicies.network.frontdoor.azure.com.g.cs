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
/// Generator information:
/// - Generated from: /frontdoor/resource-manager/Microsoft.Network/stable/2022-05-01/webapplicationfirewall.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220501WebApplicationFirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1api20220501WebApplicationFirewallPolicy>
{
    public const string KubeApiVersion = "v1api20220501";
    public const string KubeKind = "WebApplicationFirewallPolicyList";
    public const string KubeGroup = "network.frontdoor.azure.com";
    public const string KubePluralName = "webapplicationfirewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.frontdoor.azure.com/v1api20220501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebApplicationFirewallPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220501WebApplicationFirewallPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220501WebApplicationFirewallPolicy> Items { get; set; }
}

/// <summary>Action: Describes what action to be applied when rule matches.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesActionEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "AnomalyScoring"), JsonStringEnumMemberName("AnomalyScoring")]
    AnomalyScoring,
    [EnumMember(Value = "Block"), JsonStringEnumMemberName("Block")]
    Block,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log,
    [EnumMember(Value = "Redirect"), JsonStringEnumMemberName("Redirect")]
    Redirect
}

/// <summary>EnabledState: Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesEnabledStateEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesEnabledStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>MatchVariable: Request variable to compare with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesMatchConditionsMatchVariableEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesMatchConditionsMatchVariableEnum
{
    [EnumMember(Value = "Cookies"), JsonStringEnumMemberName("Cookies")]
    Cookies,
    [EnumMember(Value = "PostArgs"), JsonStringEnumMemberName("PostArgs")]
    PostArgs,
    [EnumMember(Value = "QueryString"), JsonStringEnumMemberName("QueryString")]
    QueryString,
    [EnumMember(Value = "RemoteAddr"), JsonStringEnumMemberName("RemoteAddr")]
    RemoteAddr,
    [EnumMember(Value = "RequestBody"), JsonStringEnumMemberName("RequestBody")]
    RequestBody,
    [EnumMember(Value = "RequestHeader"), JsonStringEnumMemberName("RequestHeader")]
    RequestHeader,
    [EnumMember(Value = "RequestMethod"), JsonStringEnumMemberName("RequestMethod")]
    RequestMethod,
    [EnumMember(Value = "RequestUri"), JsonStringEnumMemberName("RequestUri")]
    RequestUri,
    [EnumMember(Value = "SocketAddr"), JsonStringEnumMemberName("SocketAddr")]
    SocketAddr
}

/// <summary>Operator: Comparison type to use for matching with the variable value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesMatchConditionsOperatorEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesMatchConditionsOperatorEnum
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
    [EnumMember(Value = "RegEx"), JsonStringEnumMemberName("RegEx")]
    RegEx
}

/// <summary>Describes what transforms applied before matching.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesMatchConditionsTransformsEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesMatchConditionsTransformsEnum
{
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

/// <summary>Define a match condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesMatchConditions
{
    /// <summary>MatchValue: List of possible match values.</summary>
    [JsonPropertyName("matchValue")]
    public required IList<string> MatchValue { get; set; }

    /// <summary>MatchVariable: Request variable to compare with.</summary>
    [JsonPropertyName("matchVariable")]
    public required V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesMatchConditionsMatchVariableEnum MatchVariable { get; set; }

    /// <summary>NegateCondition: Describes if the result of this condition should be negated.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Comparison type to use for matching with the variable value.</summary>
    [JsonPropertyName("operator")]
    public required V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesMatchConditionsOperatorEnum Operator { get; set; }

    /// <summary>
    /// Selector: Match against a specific key from the QueryString, PostArgs, RequestHeader or Cookies variables. Default is
    /// null.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Transforms: List of transforms.</summary>
    [JsonPropertyName("transforms")]
    public IList<V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesMatchConditionsTransformsEnum>? Transforms { get; set; }
}

/// <summary>RuleType: Describes type of rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesRuleTypeEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesRuleTypeEnum
{
    [EnumMember(Value = "MatchRule"), JsonStringEnumMemberName("MatchRule")]
    MatchRule,
    [EnumMember(Value = "RateLimitRule"), JsonStringEnumMemberName("RateLimitRule")]
    RateLimitRule
}

/// <summary>Defines contents of a web application rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecCustomRulesRules
{
    /// <summary>Action: Describes what action to be applied when rule matches.</summary>
    [JsonPropertyName("action")]
    public required V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesActionEnum Action { get; set; }

    /// <summary>EnabledState: Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified.</summary>
    [JsonPropertyName("enabledState")]
    public V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesEnabledStateEnum? EnabledState { get; set; }

    /// <summary>MatchConditions: List of match conditions.</summary>
    [JsonPropertyName("matchConditions")]
    public required IList<V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesMatchConditions> MatchConditions { get; set; }

    /// <summary>Name: Describes the name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public required int Priority { get; set; }

    /// <summary>RateLimitDurationInMinutes: Time window for resetting the rate limit count. Default is 1 minute.</summary>
    [JsonPropertyName("rateLimitDurationInMinutes")]
    public int? RateLimitDurationInMinutes { get; set; }

    /// <summary>RateLimitThreshold: Number of allowed requests per client within the time window.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    /// <summary>RuleType: Describes type of rule.</summary>
    [JsonPropertyName("ruleType")]
    public required V1api20220501WebApplicationFirewallPolicySpecCustomRulesRulesRuleTypeEnum RuleType { get; set; }
}

/// <summary>CustomRules: Describes custom rules inside the policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecCustomRules
{
    /// <summary>Rules: List of rules</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20220501WebApplicationFirewallPolicySpecCustomRulesRules>? Rules { get; set; }
}

/// <summary>MatchVariable: The variable type to be excluded.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusionsMatchVariableEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusionsMatchVariableEnum
{
    [EnumMember(Value = "QueryStringArgNames"), JsonStringEnumMemberName("QueryStringArgNames")]
    QueryStringArgNames,
    [EnumMember(Value = "RequestBodyJsonArgNames"), JsonStringEnumMemberName("RequestBodyJsonArgNames")]
    RequestBodyJsonArgNames,
    [EnumMember(Value = "RequestBodyPostArgNames"), JsonStringEnumMemberName("RequestBodyPostArgNames")]
    RequestBodyPostArgNames,
    [EnumMember(Value = "RequestCookieNames"), JsonStringEnumMemberName("RequestCookieNames")]
    RequestCookieNames,
    [EnumMember(Value = "RequestHeaderNames"), JsonStringEnumMemberName("RequestHeaderNames")]
    RequestHeaderNames
}

/// <summary>
/// SelectorMatchOperator: Comparison operator to apply to the selector when specifying which elements in the collection
/// this exclusion applies to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusionsSelectorMatchOperatorEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusionsSelectorMatchOperatorEnum
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

/// <summary>Exclude variables from managed rule evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusions
{
    /// <summary>MatchVariable: The variable type to be excluded.</summary>
    [JsonPropertyName("matchVariable")]
    public required V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusionsMatchVariableEnum MatchVariable { get; set; }

    /// <summary>Selector: Selector value for which elements in the collection this exclusion applies to.</summary>
    [JsonPropertyName("selector")]
    public required string Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: Comparison operator to apply to the selector when specifying which elements in the collection
    /// this exclusion applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public required V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusionsSelectorMatchOperatorEnum SelectorMatchOperator { get; set; }
}

/// <summary>MatchVariable: The variable type to be excluded.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusionsMatchVariableEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusionsMatchVariableEnum
{
    [EnumMember(Value = "QueryStringArgNames"), JsonStringEnumMemberName("QueryStringArgNames")]
    QueryStringArgNames,
    [EnumMember(Value = "RequestBodyJsonArgNames"), JsonStringEnumMemberName("RequestBodyJsonArgNames")]
    RequestBodyJsonArgNames,
    [EnumMember(Value = "RequestBodyPostArgNames"), JsonStringEnumMemberName("RequestBodyPostArgNames")]
    RequestBodyPostArgNames,
    [EnumMember(Value = "RequestCookieNames"), JsonStringEnumMemberName("RequestCookieNames")]
    RequestCookieNames,
    [EnumMember(Value = "RequestHeaderNames"), JsonStringEnumMemberName("RequestHeaderNames")]
    RequestHeaderNames
}

/// <summary>
/// SelectorMatchOperator: Comparison operator to apply to the selector when specifying which elements in the collection
/// this exclusion applies to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusionsSelectorMatchOperatorEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusionsSelectorMatchOperatorEnum
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

/// <summary>Exclude variables from managed rule evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusions
{
    /// <summary>MatchVariable: The variable type to be excluded.</summary>
    [JsonPropertyName("matchVariable")]
    public required V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusionsMatchVariableEnum MatchVariable { get; set; }

    /// <summary>Selector: Selector value for which elements in the collection this exclusion applies to.</summary>
    [JsonPropertyName("selector")]
    public required string Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: Comparison operator to apply to the selector when specifying which elements in the collection
    /// this exclusion applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public required V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusionsSelectorMatchOperatorEnum SelectorMatchOperator { get; set; }
}

/// <summary>Action: Describes the override action to be applied when rule matches.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesActionEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "AnomalyScoring"), JsonStringEnumMemberName("AnomalyScoring")]
    AnomalyScoring,
    [EnumMember(Value = "Block"), JsonStringEnumMemberName("Block")]
    Block,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log,
    [EnumMember(Value = "Redirect"), JsonStringEnumMemberName("Redirect")]
    Redirect
}

/// <summary>EnabledState: Describes if the managed rule is in enabled or disabled state. Defaults to Disabled if not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesEnabledStateEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesEnabledStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>MatchVariable: The variable type to be excluded.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusionsMatchVariableEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusionsMatchVariableEnum
{
    [EnumMember(Value = "QueryStringArgNames"), JsonStringEnumMemberName("QueryStringArgNames")]
    QueryStringArgNames,
    [EnumMember(Value = "RequestBodyJsonArgNames"), JsonStringEnumMemberName("RequestBodyJsonArgNames")]
    RequestBodyJsonArgNames,
    [EnumMember(Value = "RequestBodyPostArgNames"), JsonStringEnumMemberName("RequestBodyPostArgNames")]
    RequestBodyPostArgNames,
    [EnumMember(Value = "RequestCookieNames"), JsonStringEnumMemberName("RequestCookieNames")]
    RequestCookieNames,
    [EnumMember(Value = "RequestHeaderNames"), JsonStringEnumMemberName("RequestHeaderNames")]
    RequestHeaderNames
}

/// <summary>
/// SelectorMatchOperator: Comparison operator to apply to the selector when specifying which elements in the collection
/// this exclusion applies to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusionsSelectorMatchOperatorEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusionsSelectorMatchOperatorEnum
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

/// <summary>Exclude variables from managed rule evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions
{
    /// <summary>MatchVariable: The variable type to be excluded.</summary>
    [JsonPropertyName("matchVariable")]
    public required V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusionsMatchVariableEnum MatchVariable { get; set; }

    /// <summary>Selector: Selector value for which elements in the collection this exclusion applies to.</summary>
    [JsonPropertyName("selector")]
    public required string Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: Comparison operator to apply to the selector when specifying which elements in the collection
    /// this exclusion applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public required V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusionsSelectorMatchOperatorEnum SelectorMatchOperator { get; set; }
}

/// <summary>Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>Action: Describes the override action to be applied when rule matches.</summary>
    [JsonPropertyName("action")]
    public V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesActionEnum? Action { get; set; }

    /// <summary>EnabledState: Describes if the managed rule is in enabled or disabled state. Defaults to Disabled if not specified.</summary>
    [JsonPropertyName("enabledState")]
    public V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesEnabledStateEnum? EnabledState { get; set; }

    /// <summary>Exclusions: Describes the exclusions that are applied to this specific rule.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions>? Exclusions { get; set; }

    /// <summary>RuleId: Identifier for the managed rule.</summary>
    [JsonPropertyName("ruleId")]
    public required string RuleId { get; set; }
}

/// <summary>Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>Exclusions: Describes the exclusions that are applied to all rules in the group.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesExclusions>? Exclusions { get; set; }

    /// <summary>RuleGroupName: Describes the managed rule group to override.</summary>
    [JsonPropertyName("ruleGroupName")]
    public required string RuleGroupName { get; set; }

    /// <summary>Rules: List of rules that will be disabled. If none specified, all rules in the group will be disabled.</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

/// <summary>RuleSetAction: Defines the rule set action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleSetActionEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleSetActionEnum
{
    [EnumMember(Value = "Block"), JsonStringEnumMemberName("Block")]
    Block,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log,
    [EnumMember(Value = "Redirect"), JsonStringEnumMemberName("Redirect")]
    Redirect
}

/// <summary>Defines a managed rule set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSets
{
    /// <summary>Exclusions: Describes the exclusions that are applied to all rules in the set.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsExclusions>? Exclusions { get; set; }

    /// <summary>RuleGroupOverrides: Defines the rule group overrides to apply to the rule set.</summary>
    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    /// <summary>RuleSetAction: Defines the rule set action.</summary>
    [JsonPropertyName("ruleSetAction")]
    public V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSetsRuleSetActionEnum? RuleSetAction { get; set; }

    /// <summary>RuleSetType: Defines the rule set type to use.</summary>
    [JsonPropertyName("ruleSetType")]
    public required string RuleSetType { get; set; }

    /// <summary>RuleSetVersion: Defines the version of the rule set to use.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public required string RuleSetVersion { get; set; }
}

/// <summary>ManagedRules: Describes managed rules inside the policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecManagedRules
{
    /// <summary>ManagedRuleSets: List of rule sets.</summary>
    [JsonPropertyName("managedRuleSets")]
    public IList<V1api20220501WebApplicationFirewallPolicySpecManagedRulesManagedRuleSets>? ManagedRuleSets { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20220501WebApplicationFirewallPolicySpecOperatorSpecSecretExpressions
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
public partial class V1api20220501WebApplicationFirewallPolicySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220501WebApplicationFirewallPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220501WebApplicationFirewallPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>EnabledState: Describes if the policy is in enabled or disabled state. Defaults to Enabled if not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecPolicySettingsEnabledStateEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecPolicySettingsEnabledStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Mode: Describes if it is in detection mode or prevention mode at policy level.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecPolicySettingsModeEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecPolicySettingsModeEnum
{
    [EnumMember(Value = "Detection"), JsonStringEnumMemberName("Detection")]
    Detection,
    [EnumMember(Value = "Prevention"), JsonStringEnumMemberName("Prevention")]
    Prevention
}

/// <summary>RequestBodyCheck: Describes if policy managed rules will inspect the request body content.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecPolicySettingsRequestBodyCheckEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecPolicySettingsRequestBodyCheckEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>PolicySettings: Describes settings for the policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecPolicySettings
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

    /// <summary>EnabledState: Describes if the policy is in enabled or disabled state. Defaults to Enabled if not specified.</summary>
    [JsonPropertyName("enabledState")]
    public V1api20220501WebApplicationFirewallPolicySpecPolicySettingsEnabledStateEnum? EnabledState { get; set; }

    /// <summary>Mode: Describes if it is in detection mode or prevention mode at policy level.</summary>
    [JsonPropertyName("mode")]
    public V1api20220501WebApplicationFirewallPolicySpecPolicySettingsModeEnum? Mode { get; set; }

    /// <summary>RedirectUrl: If action type is redirect, this field represents redirect URL for the client.</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>RequestBodyCheck: Describes if policy managed rules will inspect the request body content.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public V1api20220501WebApplicationFirewallPolicySpecPolicySettingsRequestBodyCheckEnum? RequestBodyCheck { get; set; }
}

/// <summary>Name: Name of the pricing tier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20220501WebApplicationFirewallPolicySpecSkuNameEnum>))]
public enum V1api20220501WebApplicationFirewallPolicySpecSkuNameEnum
{
    [EnumMember(Value = "Classic_AzureFrontDoor"), JsonStringEnumMemberName("Classic_AzureFrontDoor")]
    ClassicAzureFrontDoor,
    [EnumMember(Value = "Premium_AzureFrontDoor"), JsonStringEnumMemberName("Premium_AzureFrontDoor")]
    PremiumAzureFrontDoor,
    [EnumMember(Value = "Standard_AzureFrontDoor"), JsonStringEnumMemberName("Standard_AzureFrontDoor")]
    StandardAzureFrontDoor
}

/// <summary>Sku: The pricing tier of web application firewall policy. Defaults to Classic_AzureFrontDoor if not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpecSku
{
    /// <summary>Name: Name of the pricing tier.</summary>
    [JsonPropertyName("name")]
    public V1api20220501WebApplicationFirewallPolicySpecSkuNameEnum? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicySpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CustomRules: Describes custom rules inside the policy.</summary>
    [JsonPropertyName("customRules")]
    public V1api20220501WebApplicationFirewallPolicySpecCustomRules? CustomRules { get; set; }

    /// <summary>Etag: Gets a unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedRules: Describes managed rules inside the policy.</summary>
    [JsonPropertyName("managedRules")]
    public V1api20220501WebApplicationFirewallPolicySpecManagedRules? ManagedRules { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220501WebApplicationFirewallPolicySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220501WebApplicationFirewallPolicySpecOwner Owner { get; set; }

    /// <summary>PolicySettings: Describes settings for the policy.</summary>
    [JsonPropertyName("policySettings")]
    public V1api20220501WebApplicationFirewallPolicySpecPolicySettings? PolicySettings { get; set; }

    /// <summary>Sku: The pricing tier of web application firewall policy. Defaults to Classic_AzureFrontDoor if not specified.</summary>
    [JsonPropertyName("sku")]
    public V1api20220501WebApplicationFirewallPolicySpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusConditions
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

/// <summary>Define a match condition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusCustomRulesRulesMatchConditions
{
    /// <summary>MatchValue: List of possible match values.</summary>
    [JsonPropertyName("matchValue")]
    public IList<string>? MatchValue { get; set; }

    /// <summary>MatchVariable: Request variable to compare with.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>NegateCondition: Describes if the result of this condition should be negated.</summary>
    [JsonPropertyName("negateCondition")]
    public bool? NegateCondition { get; set; }

    /// <summary>Operator: Comparison type to use for matching with the variable value.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Selector: Match against a specific key from the QueryString, PostArgs, RequestHeader or Cookies variables. Default is
    /// null.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Transforms: List of transforms.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

/// <summary>Defines contents of a web application rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusCustomRulesRules
{
    /// <summary>Action: Describes what action to be applied when rule matches.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>EnabledState: Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified.</summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary>MatchConditions: List of match conditions.</summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusCustomRulesRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary>Name: Describes the name of the rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Priority: Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>RateLimitDurationInMinutes: Time window for resetting the rate limit count. Default is 1 minute.</summary>
    [JsonPropertyName("rateLimitDurationInMinutes")]
    public int? RateLimitDurationInMinutes { get; set; }

    /// <summary>RateLimitThreshold: Number of allowed requests per client within the time window.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public int? RateLimitThreshold { get; set; }

    /// <summary>RuleType: Describes type of rule.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}

/// <summary>CustomRules: Describes custom rules inside the policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusCustomRules
{
    /// <summary>Rules: List of rules</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusCustomRulesRules>? Rules { get; set; }
}

/// <summary>Defines the Resource ID for a Frontend Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusFrontendEndpointLinks
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Exclude variables from managed rule evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsExclusions
{
    /// <summary>MatchVariable: The variable type to be excluded.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Selector: Selector value for which elements in the collection this exclusion applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: Comparison operator to apply to the selector when specifying which elements in the collection
    /// this exclusion applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>Exclude variables from managed rule evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesExclusions
{
    /// <summary>MatchVariable: The variable type to be excluded.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Selector: Selector value for which elements in the collection this exclusion applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: Comparison operator to apply to the selector when specifying which elements in the collection
    /// this exclusion applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>Exclude variables from managed rule evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions
{
    /// <summary>MatchVariable: The variable type to be excluded.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Selector: Selector value for which elements in the collection this exclusion applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>
    /// SelectorMatchOperator: Comparison operator to apply to the selector when specifying which elements in the collection
    /// this exclusion applies to.
    /// </summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules
{
    /// <summary>Action: Describes the override action to be applied when rule matches.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>EnabledState: Describes if the managed rule is in enabled or disabled state. Defaults to Disabled if not specified.</summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary>Exclusions: Describes the exclusions that are applied to this specific rule.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRulesExclusions>? Exclusions { get; set; }

    /// <summary>RuleId: Identifier for the managed rule.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }
}

/// <summary>Defines a managed rule group override setting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides
{
    /// <summary>Exclusions: Describes the exclusions that are applied to all rules in the group.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesExclusions>? Exclusions { get; set; }

    /// <summary>RuleGroupName: Describes the managed rule group to override.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    /// <summary>Rules: List of rules that will be disabled. If none specified, all rules in the group will be disabled.</summary>
    [JsonPropertyName("rules")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverridesRules>? Rules { get; set; }
}

/// <summary>Defines a managed rule set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets
{
    /// <summary>Exclusions: Describes the exclusions that are applied to all rules in the set.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsExclusions>? Exclusions { get; set; }

    /// <summary>RuleGroupOverrides: Defines the rule group overrides to apply to the rule set.</summary>
    [JsonPropertyName("ruleGroupOverrides")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSetsRuleGroupOverrides>? RuleGroupOverrides { get; set; }

    /// <summary>RuleSetAction: Defines the rule set action.</summary>
    [JsonPropertyName("ruleSetAction")]
    public string? RuleSetAction { get; set; }

    /// <summary>RuleSetType: Defines the rule set type to use.</summary>
    [JsonPropertyName("ruleSetType")]
    public string? RuleSetType { get; set; }

    /// <summary>RuleSetVersion: Defines the version of the rule set to use.</summary>
    [JsonPropertyName("ruleSetVersion")]
    public string? RuleSetVersion { get; set; }
}

/// <summary>ManagedRules: Describes managed rules inside the policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusManagedRules
{
    /// <summary>ManagedRuleSets: List of rule sets.</summary>
    [JsonPropertyName("managedRuleSets")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusManagedRulesManagedRuleSets>? ManagedRuleSets { get; set; }
}

/// <summary>PolicySettings: Describes settings for the policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusPolicySettings
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

    /// <summary>EnabledState: Describes if the policy is in enabled or disabled state. Defaults to Enabled if not specified.</summary>
    [JsonPropertyName("enabledState")]
    public string? EnabledState { get; set; }

    /// <summary>Mode: Describes if it is in detection mode or prevention mode at policy level.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>RedirectUrl: If action type is redirect, this field represents redirect URL for the client.</summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>RequestBodyCheck: Describes if policy managed rules will inspect the request body content.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public string? RequestBodyCheck { get; set; }
}

/// <summary>Defines the Resource ID for a Routing Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusRoutingRuleLinks
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Defines the Resource ID for a Security Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusSecurityPolicyLinks
{
    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Sku: The pricing tier of web application firewall policy. Defaults to Classic_AzureFrontDoor if not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatusSku
{
    /// <summary>Name: Name of the pricing tier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220501WebApplicationFirewallPolicyStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>CustomRules: Describes custom rules inside the policy.</summary>
    [JsonPropertyName("customRules")]
    public V1api20220501WebApplicationFirewallPolicyStatusCustomRules? CustomRules { get; set; }

    /// <summary>Etag: Gets a unique read-only string that changes whenever the resource is updated.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>FrontendEndpointLinks: Describes Frontend Endpoints associated with this Web Application Firewall policy.</summary>
    [JsonPropertyName("frontendEndpointLinks")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusFrontendEndpointLinks>? FrontendEndpointLinks { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedRules: Describes managed rules inside the policy.</summary>
    [JsonPropertyName("managedRules")]
    public V1api20220501WebApplicationFirewallPolicyStatusManagedRules? ManagedRules { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PolicySettings: Describes settings for the policy.</summary>
    [JsonPropertyName("policySettings")]
    public V1api20220501WebApplicationFirewallPolicyStatusPolicySettings? PolicySettings { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the policy.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("resourceState")]
    public string? ResourceState { get; set; }

    /// <summary>RoutingRuleLinks: Describes Routing Rules associated with this Web Application Firewall policy.</summary>
    [JsonPropertyName("routingRuleLinks")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusRoutingRuleLinks>? RoutingRuleLinks { get; set; }

    /// <summary>SecurityPolicyLinks: Describes Security Policy associated with this Web Application Firewall policy.</summary>
    [JsonPropertyName("securityPolicyLinks")]
    public IList<V1api20220501WebApplicationFirewallPolicyStatusSecurityPolicyLinks>? SecurityPolicyLinks { get; set; }

    /// <summary>Sku: The pricing tier of web application firewall policy. Defaults to Classic_AzureFrontDoor if not specified.</summary>
    [JsonPropertyName("sku")]
    public V1api20220501WebApplicationFirewallPolicyStatusSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /frontdoor/resource-manager/Microsoft.Network/stable/2022-05-01/webapplicationfirewall.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/FrontDoorWebApplicationFirewallPolicies/{policyName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220501WebApplicationFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220501WebApplicationFirewallPolicySpec?>, IStatus<V1api20220501WebApplicationFirewallPolicyStatus?>
{
    public const string KubeApiVersion = "v1api20220501";
    public const string KubeKind = "WebApplicationFirewallPolicy";
    public const string KubeGroup = "network.frontdoor.azure.com";
    public const string KubePluralName = "webapplicationfirewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.frontdoor.azure.com/v1api20220501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebApplicationFirewallPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20220501WebApplicationFirewallPolicySpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20220501WebApplicationFirewallPolicyStatus? Status { get; set; }
}