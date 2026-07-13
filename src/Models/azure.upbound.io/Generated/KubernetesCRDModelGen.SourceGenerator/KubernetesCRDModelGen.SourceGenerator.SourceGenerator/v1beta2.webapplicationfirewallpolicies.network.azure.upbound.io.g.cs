#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary>WebApplicationFirewallPolicy is the Schema for the WebApplicationFirewallPolicys API. Manages a Azure Web Application Firewall Policy instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WebApplicationFirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2WebApplicationFirewallPolicy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WebApplicationFirewallPolicyList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "webapplicationfirewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebApplicationFirewallPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2WebApplicationFirewallPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2WebApplicationFirewallPolicy> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WebApplicationFirewallPolicySpecDeletionPolicyEnum>))]
public enum V1beta2WebApplicationFirewallPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderCustomRulesMatchConditionsMatchVariables
{
    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>The name of the Match Variable. Possible values are RemoteAddr, RequestMethod, QueryString, PostArgs, RequestUri, RequestHeaders, RequestBody and RequestCookies.</summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderCustomRulesMatchConditions
{
    /// <summary>A list of match values. This is Required when the operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>One or more match_variables blocks as defined below.</summary>
    [JsonPropertyName("matchVariables")]
    public IList<V1beta2WebApplicationFirewallPolicySpecForProviderCustomRulesMatchConditionsMatchVariables>? MatchVariables { get; set; }

    /// <summary>Describes if this is negate condition or not</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>Describes operator to be matched. Possible values are Any, IPMatch, GeoMatch, Equal, Contains, LessThan, GreaterThan, LessThanOrEqual, GreaterThanOrEqual, BeginsWith, EndsWith and Regex.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transformations to do before the match is attempted. Possible values are HtmlEntityDecode, Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode and UrlEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderCustomRules
{
    /// <summary>Type of action. Possible values are Allow, Block, JSChallenge and Log.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies what grouping the rate limit will count requests by. Possible values are ClientAddr, ClientAddrXFFHeader, GeoLocation, GeoLocationXFFHeader and None.</summary>
    [JsonPropertyName("groupRateLimitBy")]
    public string? GroupRateLimitBy { get; set; }

    /// <summary>One or more match_conditions blocks as defined below.</summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1beta2WebApplicationFirewallPolicySpecForProviderCustomRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary>Gets name of the resource that is unique within a policy. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the duration at which the rate limit policy will be applied. Should be used with RateLimitRule rule type. Possible values are FiveMins and OneMin.</summary>
    [JsonPropertyName("rateLimitDuration")]
    public string? RateLimitDuration { get; set; }

    /// <summary>Specifies the threshold value for the rate limit policy. Must be greater than or equal to 1 if provided.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public double? RateLimitThreshold { get; set; }

    /// <summary>Describes the type of rule. Possible values are MatchRule, RateLimitRule and Invalid.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesExclusionExcludedRuleSetRuleGroup
{
    /// <summary>One or more Rule IDs for exclusion.</summary>
    [JsonPropertyName("excludedRules")]
    public IList<string>? ExcludedRules { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary>One or more excluded_rule_set block defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesExclusionExcludedRuleSet
{
    /// <summary>One or more rule_group block defined below.</summary>
    [JsonPropertyName("ruleGroup")]
    public IList<V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesExclusionExcludedRuleSetRuleGroup>? RuleGroup { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesExclusion
{
    /// <summary>One or more excluded_rule_set block defined below.</summary>
    [JsonPropertyName("excludedRuleSet")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesExclusionExcludedRuleSet? ExcludedRuleSet { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSetRuleGroupOverrideRule
{
    /// <summary>Describes the override action to be applied when rule matches. Possible values are Allow, AnomalyScoring, Block, JSChallenge and Log. JSChallenge is only valid for rulesets of type Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Identifier for the managed rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSetRuleGroupOverride
{
    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSetRuleGroupOverrideRule>? Rule { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSet
{
    /// <summary>One or more rule_group_override block defined below.</summary>
    [JsonPropertyName("ruleGroupOverride")]
    public IList<V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSetRuleGroupOverride>? RuleGroupOverride { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A managed_rules blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderManagedRules
{
    /// <summary>One or more exclusion block defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesExclusion>? Exclusion { get; set; }

    /// <summary>One or more managed_rule_set block defined below.</summary>
    [JsonPropertyName("managedRuleSet")]
    public IList<V1beta2WebApplicationFirewallPolicySpecForProviderManagedRulesManagedRuleSet>? ManagedRuleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderPolicySettingsLogScrubbingRule
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>
    /// Specifies which elements in the collection this rule applies to.
    /// When matchVariable is a collection, operator used to specify which elements in the collection this rule applies to.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>One log_scrubbing block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderPolicySettingsLogScrubbing
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2WebApplicationFirewallPolicySpecForProviderPolicySettingsLogScrubbingRule>? Rule { get; set; }
}

/// <summary>A policy_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderPolicySettings
{
    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>- Whether the firewall should block a request with upload size greater then file_upload_limit_in_mb.</summary>
    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1 to 4000. Defaults to 100.</summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public double? FileUploadLimitInMb { get; set; }

    /// <summary>Specifies the JavaScript challenge cookie validity lifetime in minutes. The user is challenged after the lifetime expires. Accepted values are in the range 5 to 1440. Defaults to 30.</summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMinutes")]
    public double? JsChallengeCookieExpirationInMinutes { get; set; }

    /// <summary>One log_scrubbing block as defined below.</summary>
    [JsonPropertyName("logScrubbing")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 8 to 2000. Defaults to 128.</summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public double? MaxRequestBodySizeInKb { get; set; }

    /// <summary>Describes if it is in detection mode or prevention mode at the policy level. Valid values are Detection and Prevention. Defaults to Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>Whether the firewall should block a request with body size greater then max_request_body_size_in_kb. Defaults to true.</summary>
    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    /// <summary>Specifies the maximum request body inspection limit in KB for the Web Application Firewall. Defaults to 128.</summary>
    [JsonPropertyName("requestBodyInspectLimitInKb")]
    public double? RequestBodyInspectLimitInKb { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecForProvider
{
    /// <summary>One or more custom_rules blocks as defined below.</summary>
    [JsonPropertyName("customRules")]
    public IList<V1beta2WebApplicationFirewallPolicySpecForProviderCustomRules>? CustomRules { get; set; }

    /// <summary>Resource location. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A managed_rules blocks as defined below.</summary>
    [JsonPropertyName("managedRules")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderManagedRules? ManagedRules { get; set; }

    /// <summary>A policy_settings block as defined below.</summary>
    [JsonPropertyName("policySettings")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderPolicySettings? PolicySettings { get; set; }

    /// <summary>The name of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2WebApplicationFirewallPolicySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the Web Application Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderCustomRulesMatchConditionsMatchVariables
{
    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>The name of the Match Variable. Possible values are RemoteAddr, RequestMethod, QueryString, PostArgs, RequestUri, RequestHeaders, RequestBody and RequestCookies.</summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderCustomRulesMatchConditions
{
    /// <summary>A list of match values. This is Required when the operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>One or more match_variables blocks as defined below.</summary>
    [JsonPropertyName("matchVariables")]
    public IList<V1beta2WebApplicationFirewallPolicySpecInitProviderCustomRulesMatchConditionsMatchVariables>? MatchVariables { get; set; }

    /// <summary>Describes if this is negate condition or not</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>Describes operator to be matched. Possible values are Any, IPMatch, GeoMatch, Equal, Contains, LessThan, GreaterThan, LessThanOrEqual, GreaterThanOrEqual, BeginsWith, EndsWith and Regex.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transformations to do before the match is attempted. Possible values are HtmlEntityDecode, Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode and UrlEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderCustomRules
{
    /// <summary>Type of action. Possible values are Allow, Block, JSChallenge and Log.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies what grouping the rate limit will count requests by. Possible values are ClientAddr, ClientAddrXFFHeader, GeoLocation, GeoLocationXFFHeader and None.</summary>
    [JsonPropertyName("groupRateLimitBy")]
    public string? GroupRateLimitBy { get; set; }

    /// <summary>One or more match_conditions blocks as defined below.</summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1beta2WebApplicationFirewallPolicySpecInitProviderCustomRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary>Gets name of the resource that is unique within a policy. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the duration at which the rate limit policy will be applied. Should be used with RateLimitRule rule type. Possible values are FiveMins and OneMin.</summary>
    [JsonPropertyName("rateLimitDuration")]
    public string? RateLimitDuration { get; set; }

    /// <summary>Specifies the threshold value for the rate limit policy. Must be greater than or equal to 1 if provided.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public double? RateLimitThreshold { get; set; }

    /// <summary>Describes the type of rule. Possible values are MatchRule, RateLimitRule and Invalid.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusionExcludedRuleSetRuleGroup
{
    /// <summary>One or more Rule IDs for exclusion.</summary>
    [JsonPropertyName("excludedRules")]
    public IList<string>? ExcludedRules { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary>One or more excluded_rule_set block defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusionExcludedRuleSet
{
    /// <summary>One or more rule_group block defined below.</summary>
    [JsonPropertyName("ruleGroup")]
    public IList<V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusionExcludedRuleSetRuleGroup>? RuleGroup { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusion
{
    /// <summary>One or more excluded_rule_set block defined below.</summary>
    [JsonPropertyName("excludedRuleSet")]
    public V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusionExcludedRuleSet? ExcludedRuleSet { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSetRuleGroupOverrideRule
{
    /// <summary>Describes the override action to be applied when rule matches. Possible values are Allow, AnomalyScoring, Block, JSChallenge and Log. JSChallenge is only valid for rulesets of type Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Identifier for the managed rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSetRuleGroupOverride
{
    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSetRuleGroupOverrideRule>? Rule { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSet
{
    /// <summary>One or more rule_group_override block defined below.</summary>
    [JsonPropertyName("ruleGroupOverride")]
    public IList<V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSetRuleGroupOverride>? RuleGroupOverride { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A managed_rules blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRules
{
    /// <summary>One or more exclusion block defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesExclusion>? Exclusion { get; set; }

    /// <summary>One or more managed_rule_set block defined below.</summary>
    [JsonPropertyName("managedRuleSet")]
    public IList<V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRulesManagedRuleSet>? ManagedRuleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderPolicySettingsLogScrubbingRule
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>
    /// Specifies which elements in the collection this rule applies to.
    /// When matchVariable is a collection, operator used to specify which elements in the collection this rule applies to.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>One log_scrubbing block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderPolicySettingsLogScrubbing
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2WebApplicationFirewallPolicySpecInitProviderPolicySettingsLogScrubbingRule>? Rule { get; set; }
}

/// <summary>A policy_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProviderPolicySettings
{
    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>- Whether the firewall should block a request with upload size greater then file_upload_limit_in_mb.</summary>
    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1 to 4000. Defaults to 100.</summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public double? FileUploadLimitInMb { get; set; }

    /// <summary>Specifies the JavaScript challenge cookie validity lifetime in minutes. The user is challenged after the lifetime expires. Accepted values are in the range 5 to 1440. Defaults to 30.</summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMinutes")]
    public double? JsChallengeCookieExpirationInMinutes { get; set; }

    /// <summary>One log_scrubbing block as defined below.</summary>
    [JsonPropertyName("logScrubbing")]
    public V1beta2WebApplicationFirewallPolicySpecInitProviderPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 8 to 2000. Defaults to 128.</summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public double? MaxRequestBodySizeInKb { get; set; }

    /// <summary>Describes if it is in detection mode or prevention mode at the policy level. Valid values are Detection and Prevention. Defaults to Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>Whether the firewall should block a request with body size greater then max_request_body_size_in_kb. Defaults to true.</summary>
    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    /// <summary>Specifies the maximum request body inspection limit in KB for the Web Application Firewall. Defaults to 128.</summary>
    [JsonPropertyName("requestBodyInspectLimitInKb")]
    public double? RequestBodyInspectLimitInKb { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecInitProvider
{
    /// <summary>One or more custom_rules blocks as defined below.</summary>
    [JsonPropertyName("customRules")]
    public IList<V1beta2WebApplicationFirewallPolicySpecInitProviderCustomRules>? CustomRules { get; set; }

    /// <summary>Resource location. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A managed_rules blocks as defined below.</summary>
    [JsonPropertyName("managedRules")]
    public V1beta2WebApplicationFirewallPolicySpecInitProviderManagedRules? ManagedRules { get; set; }

    /// <summary>A policy_settings block as defined below.</summary>
    [JsonPropertyName("policySettings")]
    public V1beta2WebApplicationFirewallPolicySpecInitProviderPolicySettings? PolicySettings { get; set; }

    /// <summary>A mapping of tags to assign to the Web Application Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WebApplicationFirewallPolicySpecManagementPoliciesEnum>))]
public enum V1beta2WebApplicationFirewallPolicySpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WebApplicationFirewallPolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2WebApplicationFirewallPolicySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WebApplicationFirewallPolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2WebApplicationFirewallPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WebApplicationFirewallPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WebApplicationFirewallPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WebApplicationFirewallPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>WebApplicationFirewallPolicySpec defines the desired state of WebApplicationFirewallPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicySpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta2WebApplicationFirewallPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2WebApplicationFirewallPolicySpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta2WebApplicationFirewallPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2WebApplicationFirewallPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2WebApplicationFirewallPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2WebApplicationFirewallPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderCustomRulesMatchConditionsMatchVariables
{
    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>The name of the Match Variable. Possible values are RemoteAddr, RequestMethod, QueryString, PostArgs, RequestUri, RequestHeaders, RequestBody and RequestCookies.</summary>
    [JsonPropertyName("variableName")]
    public string? VariableName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderCustomRulesMatchConditions
{
    /// <summary>A list of match values. This is Required when the operator is not Any.</summary>
    [JsonPropertyName("matchValues")]
    public IList<string>? MatchValues { get; set; }

    /// <summary>One or more match_variables blocks as defined below.</summary>
    [JsonPropertyName("matchVariables")]
    public IList<V1beta2WebApplicationFirewallPolicyStatusAtProviderCustomRulesMatchConditionsMatchVariables>? MatchVariables { get; set; }

    /// <summary>Describes if this is negate condition or not</summary>
    [JsonPropertyName("negationCondition")]
    public bool? NegationCondition { get; set; }

    /// <summary>Describes operator to be matched. Possible values are Any, IPMatch, GeoMatch, Equal, Contains, LessThan, GreaterThan, LessThanOrEqual, GreaterThanOrEqual, BeginsWith, EndsWith and Regex.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of transformations to do before the match is attempted. Possible values are HtmlEntityDecode, Lowercase, RemoveNulls, Trim, Uppercase, UrlDecode and UrlEncode.</summary>
    [JsonPropertyName("transforms")]
    public IList<string>? Transforms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderCustomRules
{
    /// <summary>Type of action. Possible values are Allow, Block, JSChallenge and Log.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies what grouping the rate limit will count requests by. Possible values are ClientAddr, ClientAddrXFFHeader, GeoLocation, GeoLocationXFFHeader and None.</summary>
    [JsonPropertyName("groupRateLimitBy")]
    public string? GroupRateLimitBy { get; set; }

    /// <summary>One or more match_conditions blocks as defined below.</summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1beta2WebApplicationFirewallPolicyStatusAtProviderCustomRulesMatchConditions>? MatchConditions { get; set; }

    /// <summary>Gets name of the resource that is unique within a policy. This name can be used to access the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Describes priority of the rule. Rules with a lower value will be evaluated before rules with a higher value.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Specifies the duration at which the rate limit policy will be applied. Should be used with RateLimitRule rule type. Possible values are FiveMins and OneMin.</summary>
    [JsonPropertyName("rateLimitDuration")]
    public string? RateLimitDuration { get; set; }

    /// <summary>Specifies the threshold value for the rate limit policy. Must be greater than or equal to 1 if provided.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public double? RateLimitThreshold { get; set; }

    /// <summary>Describes the type of rule. Possible values are MatchRule, RateLimitRule and Invalid.</summary>
    [JsonPropertyName("ruleType")]
    public string? RuleType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusionExcludedRuleSetRuleGroup
{
    /// <summary>One or more Rule IDs for exclusion.</summary>
    [JsonPropertyName("excludedRules")]
    public IList<string>? ExcludedRules { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

/// <summary>One or more excluded_rule_set block defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusionExcludedRuleSet
{
    /// <summary>One or more rule_group block defined below.</summary>
    [JsonPropertyName("ruleGroup")]
    public IList<V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusionExcludedRuleSetRuleGroup>? RuleGroup { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusion
{
    /// <summary>One or more excluded_rule_set block defined below.</summary>
    [JsonPropertyName("excludedRuleSet")]
    public V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusionExcludedRuleSet? ExcludedRuleSet { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>Specifies which elements in the collection this rule applies to.</summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSetRuleGroupOverrideRule
{
    /// <summary>Describes the override action to be applied when rule matches. Possible values are Allow, AnomalyScoring, Block, JSChallenge and Log. JSChallenge is only valid for rulesets of type Microsoft_BotManagerRuleSet.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Identifier for the managed rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSetRuleGroupOverride
{
    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSetRuleGroupOverrideRule>? Rule { get; set; }

    /// <summary>The name of the Rule Group. Possible values are BadBots, crs_20_protocol_violations, crs_21_protocol_anomalies, crs_23_request_limits, crs_30_http_policy, crs_35_bad_robots, crs_40_generic_attacks, crs_41_sql_injection_attacks, crs_41_xss_attacks, crs_42_tight_security, crs_45_trojans, crs_49_inbound_blocking, General, GoodBots, KnownBadBots, Known-CVEs, REQUEST-911-METHOD-ENFORCEMENT, REQUEST-913-SCANNER-DETECTION, REQUEST-920-PROTOCOL-ENFORCEMENT, REQUEST-921-PROTOCOL-ATTACK, REQUEST-930-APPLICATION-ATTACK-LFI, REQUEST-931-APPLICATION-ATTACK-RFI, REQUEST-932-APPLICATION-ATTACK-RCE, REQUEST-933-APPLICATION-ATTACK-PHP, REQUEST-941-APPLICATION-ATTACK-XSS, REQUEST-942-APPLICATION-ATTACK-SQLI, REQUEST-943-APPLICATION-ATTACK-SESSION-FIXATION, REQUEST-944-APPLICATION-ATTACK-JAVA, UnknownBots, METHOD-ENFORCEMENT, PROTOCOL-ENFORCEMENT, PROTOCOL-ATTACK, LFI, RFI, RCE, PHP, NODEJS, XSS, SQLI, FIX, JAVA, MS-ThreatIntel-WebShells, MS-ThreatIntel-AppSec, MS-ThreatIntel-SQLI and MS-ThreatIntel-CVEsMS-ThreatIntel-WebShells`,.</summary>
    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSet
{
    /// <summary>One or more rule_group_override block defined below.</summary>
    [JsonPropertyName("ruleGroupOverride")]
    public IList<V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSetRuleGroupOverride>? RuleGroupOverride { get; set; }

    /// <summary>The rule set type. Possible values: Microsoft_BotManagerRuleSet, Microsoft_DefaultRuleSet and OWASP. Defaults to OWASP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The rule set version. Possible values: 0.1, 1.0, 1.1, 2.1, 2.2.9, 3.0, 3.1 and 3.2.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A managed_rules blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRules
{
    /// <summary>One or more exclusion block defined below.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesExclusion>? Exclusion { get; set; }

    /// <summary>One or more managed_rule_set block defined below.</summary>
    [JsonPropertyName("managedRuleSet")]
    public IList<V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRulesManagedRuleSet>? ManagedRuleSet { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderPolicySettingsLogScrubbingRule
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the variable to be scrubbed from the logs. Possible values are RequestHeaderNames, RequestCookieNames, RequestArgNames, RequestPostArgNames, RequestJSONArgNames and RequestIPAddress.</summary>
    [JsonPropertyName("matchVariable")]
    public string? MatchVariable { get; set; }

    /// <summary>
    /// Specifies which elements in the collection this rule applies to.
    /// When matchVariable is a collection, operator used to specify which elements in the collection this rule applies to.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>Specifies the operating on the selector. Possible values are Equals and EqualsAny. Defaults to Equals.</summary>
    [JsonPropertyName("selectorMatchOperator")]
    public string? SelectorMatchOperator { get; set; }
}

/// <summary>One log_scrubbing block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderPolicySettingsLogScrubbing
{
    /// <summary>Whether this rule is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>One or more rule block defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta2WebApplicationFirewallPolicyStatusAtProviderPolicySettingsLogScrubbingRule>? Rule { get; set; }
}

/// <summary>A policy_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProviderPolicySettings
{
    /// <summary>Describes if the policy is in enabled state or disabled state. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>- Whether the firewall should block a request with upload size greater then file_upload_limit_in_mb.</summary>
    [JsonPropertyName("fileUploadEnforcement")]
    public bool? FileUploadEnforcement { get; set; }

    /// <summary>The File Upload Limit in MB. Accepted values are in the range 1 to 4000. Defaults to 100.</summary>
    [JsonPropertyName("fileUploadLimitInMb")]
    public double? FileUploadLimitInMb { get; set; }

    /// <summary>Specifies the JavaScript challenge cookie validity lifetime in minutes. The user is challenged after the lifetime expires. Accepted values are in the range 5 to 1440. Defaults to 30.</summary>
    [JsonPropertyName("jsChallengeCookieExpirationInMinutes")]
    public double? JsChallengeCookieExpirationInMinutes { get; set; }

    /// <summary>One log_scrubbing block as defined below.</summary>
    [JsonPropertyName("logScrubbing")]
    public V1beta2WebApplicationFirewallPolicyStatusAtProviderPolicySettingsLogScrubbing? LogScrubbing { get; set; }

    /// <summary>The Maximum Request Body Size in KB. Accepted values are in the range 8 to 2000. Defaults to 128.</summary>
    [JsonPropertyName("maxRequestBodySizeInKb")]
    public double? MaxRequestBodySizeInKb { get; set; }

    /// <summary>Describes if it is in detection mode or prevention mode at the policy level. Valid values are Detection and Prevention. Defaults to Prevention.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Is Request Body Inspection enabled? Defaults to true.</summary>
    [JsonPropertyName("requestBodyCheck")]
    public bool? RequestBodyCheck { get; set; }

    /// <summary>Whether the firewall should block a request with body size greater then max_request_body_size_in_kb. Defaults to true.</summary>
    [JsonPropertyName("requestBodyEnforcement")]
    public bool? RequestBodyEnforcement { get; set; }

    /// <summary>Specifies the maximum request body inspection limit in KB for the Web Application Firewall. Defaults to 128.</summary>
    [JsonPropertyName("requestBodyInspectLimitInKb")]
    public double? RequestBodyInspectLimitInKb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusAtProvider
{
    /// <summary>One or more custom_rules blocks as defined below.</summary>
    [JsonPropertyName("customRules")]
    public IList<V1beta2WebApplicationFirewallPolicyStatusAtProviderCustomRules>? CustomRules { get; set; }

    /// <summary>A list of HTTP Listener IDs from an azurerm_application_gateway.</summary>
    [JsonPropertyName("httpListenerIds")]
    public IList<string>? HttpListenerIds { get; set; }

    /// <summary>The ID of the Web Application Firewall Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Resource location. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A managed_rules blocks as defined below.</summary>
    [JsonPropertyName("managedRules")]
    public V1beta2WebApplicationFirewallPolicyStatusAtProviderManagedRules? ManagedRules { get; set; }

    /// <summary>A list of URL Path Map Path Rule IDs from an azurerm_application_gateway.</summary>
    [JsonPropertyName("pathBasedRuleIds")]
    public IList<string>? PathBasedRuleIds { get; set; }

    /// <summary>A policy_settings block as defined below.</summary>
    [JsonPropertyName("policySettings")]
    public V1beta2WebApplicationFirewallPolicyStatusAtProviderPolicySettings? PolicySettings { get; set; }

    /// <summary>The name of the resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the Web Application Firewall Policy.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>WebApplicationFirewallPolicyStatus defines the observed state of WebApplicationFirewallPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WebApplicationFirewallPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2WebApplicationFirewallPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2WebApplicationFirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WebApplicationFirewallPolicy is the Schema for the WebApplicationFirewallPolicys API. Manages a Azure Web Application Firewall Policy instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WebApplicationFirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2WebApplicationFirewallPolicySpec>, IStatus<V1beta2WebApplicationFirewallPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WebApplicationFirewallPolicy";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "webapplicationfirewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebApplicationFirewallPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebApplicationFirewallPolicySpec defines the desired state of WebApplicationFirewallPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2WebApplicationFirewallPolicySpec Spec { get; set; }

    /// <summary>WebApplicationFirewallPolicyStatus defines the observed state of WebApplicationFirewallPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta2WebApplicationFirewallPolicyStatus? Status { get; set; }
}