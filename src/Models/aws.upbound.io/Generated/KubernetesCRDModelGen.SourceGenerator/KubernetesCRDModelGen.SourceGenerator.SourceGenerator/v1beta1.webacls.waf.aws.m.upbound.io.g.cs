#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.waf.aws.m.upbound.io;
/// <summary>WebACL is the Schema for the WebACLs API. Provides a AWS WAF web access control group (ACL) resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebACLList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WebACL>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebACLList";
    public const string KubeGroup = "waf.aws.m.upbound.io";
    public const string KubePluralName = "webacls";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "waf.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebACLList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1WebACL objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1WebACL> Items { get; set; }
}

/// <summary>Configuration block with action that you want AWS WAF to take when a request doesn&apos;t match the criteria in any of the rules that are associated with the web ACL. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderDefaultAction
{
    /// <summary>
    /// Specifies how you want AWS WAF to respond to requests that don&apos;t match the criteria in any of the rules.
    /// e.g., ALLOW or BLOCK
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum>))]
public enum V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum>))]
public enum V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate logDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum>))]
public enum V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum>))]
public enum V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate logDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFieldsFieldToMatch
{
    /// <summary>When the value of type is HEADER, enter the name of the header that you want the WAF to search, for example, User-Agent or Referer. If the value of type is any other value, omit data.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFields
{
    /// <summary>Set of configuration blocks for fields to redact. Detailed below.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFieldsFieldToMatch>? FieldToMatch { get; set; }
}

/// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderLoggingConfiguration
{
    /// <summary>Amazon Resource Name (ARN) of Kinesis Firehose Delivery Stream</summary>
    [JsonPropertyName("logDestination")]
    public string? LogDestination { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate logDestination.</summary>
    [JsonPropertyName("logDestinationRef")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationRef? LogDestinationRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate logDestination.</summary>
    [JsonPropertyName("logDestinationSelector")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationLogDestinationSelector? LogDestinationSelector { get; set; }

    /// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
    [JsonPropertyName("redactedFields")]
    public V1beta1WebACLSpecForProviderLoggingConfigurationRedactedFields? RedactedFields { get; set; }
}

/// <summary>The action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Not used if type is GROUP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRulesAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Only used if type is GROUP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRulesOverrideAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolutionEnum>))]
public enum V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolveEnum>))]
public enum V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRulesRuleIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLSpecForProviderRulesRuleIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Rule in waf to populate ruleId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRulesRuleIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderRulesRuleIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolutionEnum>))]
public enum V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolveEnum>))]
public enum V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Rule in waf to populate ruleId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRulesRuleIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecForProviderRulesRuleIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProviderRules
{
    /// <summary>The action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Not used if type is GROUP.</summary>
    [JsonPropertyName("action")]
    public V1beta1WebACLSpecForProviderRulesAction? Action { get; set; }

    /// <summary>Override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Only used if type is GROUP.</summary>
    [JsonPropertyName("overrideAction")]
    public V1beta1WebACLSpecForProviderRulesOverrideAction? OverrideAction { get; set; }

    /// <summary>
    /// Specifies the order in which the rules in a WebACL are evaluated.
    /// Rules with a lower value are evaluated before rules with a higher value.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the associated WAF (Global) rule (e.g., aws_waf_rule). WAF (Regional) rules cannot be used.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>Reference to a Rule in waf to populate ruleId.</summary>
    [JsonPropertyName("ruleIdRef")]
    public V1beta1WebACLSpecForProviderRulesRuleIdRef? RuleIdRef { get; set; }

    /// <summary>Selector for a Rule in waf to populate ruleId.</summary>
    [JsonPropertyName("ruleIdSelector")]
    public V1beta1WebACLSpecForProviderRulesRuleIdSelector? RuleIdSelector { get; set; }

    /// <summary>The rule type, either REGULAR, as defined by Rule, RATE_BASED, as defined by RateBasedRule, or GROUP, as defined by RuleGroup. The default is REGULAR. If you add a RATE_BASED rule, you need to set type as RATE_BASED. If you add a GROUP rule, you need to set type as GROUP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecForProvider
{
    /// <summary>Configuration block with action that you want AWS WAF to take when a request doesn&apos;t match the criteria in any of the rules that are associated with the web ACL. Detailed below.</summary>
    [JsonPropertyName("defaultAction")]
    public V1beta1WebACLSpecForProviderDefaultAction? DefaultAction { get; set; }

    /// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public V1beta1WebACLSpecForProviderLoggingConfiguration? LoggingConfiguration { get; set; }

    /// <summary>The name or description for the Amazon CloudWatch metric of this web ACL.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the web ACL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration blocks containing rules to associate with the web ACL and the settings for each rule. Detailed below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1WebACLSpecForProviderRules>? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configuration block with action that you want AWS WAF to take when a request doesn&apos;t match the criteria in any of the rules that are associated with the web ACL. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderDefaultAction
{
    /// <summary>
    /// Specifies how you want AWS WAF to respond to requests that don&apos;t match the criteria in any of the rules.
    /// e.g., ALLOW or BLOCK
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum>))]
public enum V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum>))]
public enum V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a DeliveryStream in firehose to populate logDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum>))]
public enum V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum>))]
public enum V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a DeliveryStream in firehose to populate logDestination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFieldsFieldToMatch
{
    /// <summary>When the value of type is HEADER, enter the name of the header that you want the WAF to search, for example, User-Agent or Referer. If the value of type is any other value, omit data.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFields
{
    /// <summary>Set of configuration blocks for fields to redact. Detailed below.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFieldsFieldToMatch>? FieldToMatch { get; set; }
}

/// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderLoggingConfiguration
{
    /// <summary>Amazon Resource Name (ARN) of Kinesis Firehose Delivery Stream</summary>
    [JsonPropertyName("logDestination")]
    public string? LogDestination { get; set; }

    /// <summary>Reference to a DeliveryStream in firehose to populate logDestination.</summary>
    [JsonPropertyName("logDestinationRef")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationRef? LogDestinationRef { get; set; }

    /// <summary>Selector for a DeliveryStream in firehose to populate logDestination.</summary>
    [JsonPropertyName("logDestinationSelector")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationLogDestinationSelector? LogDestinationSelector { get; set; }

    /// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
    [JsonPropertyName("redactedFields")]
    public V1beta1WebACLSpecInitProviderLoggingConfigurationRedactedFields? RedactedFields { get; set; }
}

/// <summary>The action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Not used if type is GROUP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRulesAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Only used if type is GROUP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRulesOverrideAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolutionEnum>))]
public enum V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolveEnum>))]
public enum V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Rule in waf to populate ruleId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRulesRuleIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolutionEnum>))]
public enum V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolveEnum>))]
public enum V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Rule in waf to populate ruleId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRulesRuleIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProviderRules
{
    /// <summary>The action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Not used if type is GROUP.</summary>
    [JsonPropertyName("action")]
    public V1beta1WebACLSpecInitProviderRulesAction? Action { get; set; }

    /// <summary>Override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Only used if type is GROUP.</summary>
    [JsonPropertyName("overrideAction")]
    public V1beta1WebACLSpecInitProviderRulesOverrideAction? OverrideAction { get; set; }

    /// <summary>
    /// Specifies the order in which the rules in a WebACL are evaluated.
    /// Rules with a lower value are evaluated before rules with a higher value.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the associated WAF (Global) rule (e.g., aws_waf_rule). WAF (Regional) rules cannot be used.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>Reference to a Rule in waf to populate ruleId.</summary>
    [JsonPropertyName("ruleIdRef")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdRef? RuleIdRef { get; set; }

    /// <summary>Selector for a Rule in waf to populate ruleId.</summary>
    [JsonPropertyName("ruleIdSelector")]
    public V1beta1WebACLSpecInitProviderRulesRuleIdSelector? RuleIdSelector { get; set; }

    /// <summary>The rule type, either REGULAR, as defined by Rule, RATE_BASED, as defined by RateBasedRule, or GROUP, as defined by RuleGroup. The default is REGULAR. If you add a RATE_BASED rule, you need to set type as RATE_BASED. If you add a GROUP rule, you need to set type as GROUP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecInitProvider
{
    /// <summary>Configuration block with action that you want AWS WAF to take when a request doesn&apos;t match the criteria in any of the rules that are associated with the web ACL. Detailed below.</summary>
    [JsonPropertyName("defaultAction")]
    public V1beta1WebACLSpecInitProviderDefaultAction? DefaultAction { get; set; }

    /// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public V1beta1WebACLSpecInitProviderLoggingConfiguration? LoggingConfiguration { get; set; }

    /// <summary>The name or description for the Amazon CloudWatch metric of this web ACL.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the web ACL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration blocks containing rules to associate with the web ACL and the settings for each rule. Detailed below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1WebACLSpecInitProviderRules>? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WebACLSpecManagementPoliciesEnum>))]
public enum V1beta1WebACLSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WebACLSpec defines the desired state of WebACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1WebACLSpecForProvider ForProvider { get; set; }

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
    public V1beta1WebACLSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WebACLSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WebACLSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WebACLSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block with action that you want AWS WAF to take when a request doesn&apos;t match the criteria in any of the rules that are associated with the web ACL. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderDefaultAction
{
    /// <summary>
    /// Specifies how you want AWS WAF to respond to requests that don&apos;t match the criteria in any of the rules.
    /// e.g., ALLOW or BLOCK
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFieldsFieldToMatch
{
    /// <summary>When the value of type is HEADER, enter the name of the header that you want the WAF to search, for example, User-Agent or Referer. If the value of type is any other value, omit data.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFields
{
    /// <summary>Set of configuration blocks for fields to redact. Detailed below.</summary>
    [JsonPropertyName("fieldToMatch")]
    public IList<V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFieldsFieldToMatch>? FieldToMatch { get; set; }
}

/// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderLoggingConfiguration
{
    /// <summary>Amazon Resource Name (ARN) of Kinesis Firehose Delivery Stream</summary>
    [JsonPropertyName("logDestination")]
    public string? LogDestination { get; set; }

    /// <summary>Configuration block containing parts of the request that you want redacted from the logs. Detailed below.</summary>
    [JsonPropertyName("redactedFields")]
    public V1beta1WebACLStatusAtProviderLoggingConfigurationRedactedFields? RedactedFields { get; set; }
}

/// <summary>The action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Not used if type is GROUP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderRulesAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Only used if type is GROUP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderRulesOverrideAction
{
    /// <summary>valid values are: BLOCK, ALLOW, or COUNT</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProviderRules
{
    /// <summary>The action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Not used if type is GROUP.</summary>
    [JsonPropertyName("action")]
    public V1beta1WebACLStatusAtProviderRulesAction? Action { get; set; }

    /// <summary>Override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule. Only used if type is GROUP.</summary>
    [JsonPropertyName("overrideAction")]
    public V1beta1WebACLStatusAtProviderRulesOverrideAction? OverrideAction { get; set; }

    /// <summary>
    /// Specifies the order in which the rules in a WebACL are evaluated.
    /// Rules with a lower value are evaluated before rules with a higher value.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the associated WAF (Global) rule (e.g., aws_waf_rule). WAF (Regional) rules cannot be used.</summary>
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; set; }

    /// <summary>The rule type, either REGULAR, as defined by Rule, RATE_BASED, as defined by RateBasedRule, or GROUP, as defined by RuleGroup. The default is REGULAR. If you add a RATE_BASED rule, you need to set type as RATE_BASED. If you add a GROUP rule, you need to set type as GROUP.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusAtProvider
{
    /// <summary>The ARN of the WAF WebACL.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block with action that you want AWS WAF to take when a request doesn&apos;t match the criteria in any of the rules that are associated with the web ACL. Detailed below.</summary>
    [JsonPropertyName("defaultAction")]
    public V1beta1WebACLStatusAtProviderDefaultAction? DefaultAction { get; set; }

    /// <summary>The ID of the WAF WebACL.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block to enable WAF logging. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public V1beta1WebACLStatusAtProviderLoggingConfiguration? LoggingConfiguration { get; set; }

    /// <summary>The name or description for the Amazon CloudWatch metric of this web ACL.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The name or description of the web ACL.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration blocks containing rules to associate with the web ACL and the settings for each rule. Detailed below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1WebACLStatusAtProviderRules>? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatusConditions
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

/// <summary>WebACLStatus defines the observed state of WebACL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WebACLStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1WebACLStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WebACLStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WebACL is the Schema for the WebACLs API. Provides a AWS WAF web access control group (ACL) resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WebACL : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WebACLSpec>, IStatus<V1beta1WebACLStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WebACL";
    public const string KubeGroup = "waf.aws.m.upbound.io";
    public const string KubePluralName = "webacls";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "waf.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WebACL";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WebACLSpec defines the desired state of WebACL</summary>
    [JsonPropertyName("spec")]
    public required V1beta1WebACLSpec Spec { get; set; }

    /// <summary>WebACLStatus defines the observed state of WebACL.</summary>
    [JsonPropertyName("status")]
    public V1beta1WebACLStatus? Status { get; set; }
}