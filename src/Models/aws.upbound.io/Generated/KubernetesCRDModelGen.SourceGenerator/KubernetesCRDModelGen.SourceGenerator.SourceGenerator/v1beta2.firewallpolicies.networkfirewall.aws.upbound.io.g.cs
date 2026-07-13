#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkfirewall.aws.upbound.io;
/// <summary>FirewallPolicy is the Schema for the FirewallPolicys API. Provides an AWS Network Firewall Policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FirewallPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2FirewallPolicy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FirewallPolicyList";
    public const string KubeGroup = "networkfirewall.aws.upbound.io";
    public const string KubePluralName = "firewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkfirewall.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2FirewallPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2FirewallPolicy> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecDeletionPolicyEnum>))]
public enum V1beta2FirewallPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you&apos;re using a key that&apos;s managed by another account. If you&apos;re using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet
{
    /// <summary>Set of IPv4 or IPv6 addresses in CIDR notation to use for the Suricata HOME_NET variable.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyPolicyVariablesRuleVariables
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet? IpSet { get; set; }

    /// <summary>An alphanumeric string to identify the ip_set. Valid values: HOME_NET</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>. Contains variables that you can use to override default Suricata settings in your firewall policy. See Rule Variables for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyPolicyVariables
{
    [JsonPropertyName("ruleVariables")]
    public IList<V1beta2FirewallPolicySpecForProviderFirewallPolicyPolicyVariablesRuleVariables>? RuleVariables { get; set; }
}

/// <summary>Amount of time that can pass without any traffic sent through the firewall before the firewall determines that the connection is idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulEngineOptionsFlowTimeouts
{
    /// <summary>Number of seconds that can pass without any TCP traffic sent through the firewall before the firewall determines that the connection is idle. After the idle timeout passes, data packets are dropped, however, the next TCP SYN packet is considered a new flow and is processed by the firewall. Clients or targets can use TCP keepalive packets to reset the idle timeout. Default value: 350.</summary>
    [JsonPropertyName("tcpIdleTimeoutSeconds")]
    public double? TcpIdleTimeoutSeconds { get; set; }
}

/// <summary>A configuration block that defines options on how the policy handles stateful rules. See Stateful Engine Options below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulEngineOptions
{
    /// <summary>Amount of time that can pass without any traffic sent through the firewall before the firewall determines that the connection is idle.</summary>
    [JsonPropertyName("flowTimeouts")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulEngineOptionsFlowTimeouts? FlowTimeouts { get; set; }

    /// <summary>Indicates how to manage the order of stateful rule evaluation for the policy. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }

    /// <summary>Describes how to treat traffic which has broken midstream. Default value: DROP. Valid values: DROP, CONTINUE, REJECT.</summary>
    [JsonPropertyName("streamExceptionPolicy")]
    public string? StreamExceptionPolicy { get; set; }
}

/// <summary>Configuration block for override values</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceOverride
{
    /// <summary>The action that changes the rule group from DROP to ALERT . This only applies to managed rule groups.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelector
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
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReference
{
    /// <summary>Whether to enable deep threat inspection, which allows AWS to analyze service logs of network traffic processed by these rule groups to identify threat indicators across customers. AWS will use these threat indicators to improve the active threat defense managed rule groups and protect the security of AWS customers and services. This only applies to active threat defense maanaged rule groups.</summary>
    [JsonPropertyName("deepThreatInspection")]
    public string? DeepThreatInspection { get; set; }

    /// <summary>Configuration block for override values</summary>
    [JsonPropertyName("override")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceOverride? Override { get; set; }

    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelector? ResourceArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The string value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks describing dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for more details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}

/// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction? PublishMetricAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessCustomActionActionDefinition? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelector
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
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReference
{
    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary>A configuration block describing the rule groups and policy actions to use in the firewall policy. See Firewall Policy below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProviderFirewallPolicy
{
    /// <summary>. Contains variables that you can use to override default Suricata settings in your firewall policy. See Rule Variables for details.</summary>
    [JsonPropertyName("policyVariables")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyPolicyVariables? PolicyVariables { get; set; }

    /// <summary>Set of actions to take on a packet if it does not match any stateful rules in the policy. This can only be specified if the policy has a stateful_engine_options block with a rule_order value of STRICT_ORDER. Value values: aws:drop_strict, aws:drop_established, aws:drop_established_app_layer, aws:alert_strict, aws:alert_established, aws:alert_established_app_layer`. For more information, see Strict evaluation order in the AWS Network Firewall Developer Guide.</summary>
    [JsonPropertyName("statefulDefaultActions")]
    public IList<string>? StatefulDefaultActions { get; set; }

    /// <summary>A configuration block that defines options on how the policy handles stateful rules. See Stateful Engine Options below for details.</summary>
    [JsonPropertyName("statefulEngineOptions")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulEngineOptions? StatefulEngineOptions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateful rule groups that are used in the policy. See Stateful Rule Group Reference below for details.</summary>
    [JsonPropertyName("statefulRuleGroupReference")]
    public IList<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatefulRuleGroupReference>? StatefulRuleGroupReference { get; set; }

    /// <summary>Set of configuration blocks describing the custom action definitions that are available for use in the firewall policy&apos;s stateless_default_actions. See Stateless Custom Action below for details.</summary>
    [JsonPropertyName("statelessCustomAction")]
    public IList<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessCustomAction>? StatelessCustomAction { get; set; }

    /// <summary>
    /// Set of actions to take on a packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe.
    /// In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.
    /// </summary>
    [JsonPropertyName("statelessDefaultActions")]
    public IList<string>? StatelessDefaultActions { get; set; }

    /// <summary>
    /// Set of actions to take on a fragmented packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe.
    /// In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.
    /// </summary>
    [JsonPropertyName("statelessFragmentDefaultActions")]
    public IList<string>? StatelessFragmentDefaultActions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateless rule groups that are used in the policy. See Stateless Rule Group Reference below for details.</summary>
    [JsonPropertyName("statelessRuleGroupReference")]
    public IList<V1beta2FirewallPolicySpecForProviderFirewallPolicyStatelessRuleGroupReference>? StatelessRuleGroupReference { get; set; }

    /// <summary>The (ARN) of the TLS Inspection policy to attach to the FW Policy.  This must be added at creation of the resource per AWS documentation. &quot;You can only add a TLS inspection configuration to a new policy, not to an existing policy.&quot;  This cannot be removed from a FW Policy.</summary>
    [JsonPropertyName("tlsInspectionConfigurationArn")]
    public string? TlsInspectionConfigurationArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecForProvider
{
    /// <summary>A friendly description of the firewall policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2FirewallPolicySpecForProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>A configuration block describing the rule groups and policy actions to use in the firewall policy. See Firewall Policy below for details.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V1beta2FirewallPolicySpecForProviderFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you&apos;re using a key that&apos;s managed by another account. If you&apos;re using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet
{
    /// <summary>Set of IPv4 or IPv6 addresses in CIDR notation to use for the Suricata HOME_NET variable.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyPolicyVariablesRuleVariables
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet? IpSet { get; set; }

    /// <summary>An alphanumeric string to identify the ip_set. Valid values: HOME_NET</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>. Contains variables that you can use to override default Suricata settings in your firewall policy. See Rule Variables for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyPolicyVariables
{
    [JsonPropertyName("ruleVariables")]
    public IList<V1beta2FirewallPolicySpecInitProviderFirewallPolicyPolicyVariablesRuleVariables>? RuleVariables { get; set; }
}

/// <summary>Amount of time that can pass without any traffic sent through the firewall before the firewall determines that the connection is idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulEngineOptionsFlowTimeouts
{
    /// <summary>Number of seconds that can pass without any TCP traffic sent through the firewall before the firewall determines that the connection is idle. After the idle timeout passes, data packets are dropped, however, the next TCP SYN packet is considered a new flow and is processed by the firewall. Clients or targets can use TCP keepalive packets to reset the idle timeout. Default value: 350.</summary>
    [JsonPropertyName("tcpIdleTimeoutSeconds")]
    public double? TcpIdleTimeoutSeconds { get; set; }
}

/// <summary>A configuration block that defines options on how the policy handles stateful rules. See Stateful Engine Options below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulEngineOptions
{
    /// <summary>Amount of time that can pass without any traffic sent through the firewall before the firewall determines that the connection is idle.</summary>
    [JsonPropertyName("flowTimeouts")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulEngineOptionsFlowTimeouts? FlowTimeouts { get; set; }

    /// <summary>Indicates how to manage the order of stateful rule evaluation for the policy. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }

    /// <summary>Describes how to treat traffic which has broken midstream. Default value: DROP. Valid values: DROP, CONTINUE, REJECT.</summary>
    [JsonPropertyName("streamExceptionPolicy")]
    public string? StreamExceptionPolicy { get; set; }
}

/// <summary>Configuration block for override values</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceOverride
{
    /// <summary>The action that changes the rule group from DROP to ALERT . This only applies to managed rule groups.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelector
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
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReference
{
    /// <summary>Whether to enable deep threat inspection, which allows AWS to analyze service logs of network traffic processed by these rule groups to identify threat indicators across customers. AWS will use these threat indicators to improve the active threat defense managed rule groups and protect the security of AWS customers and services. This only applies to active threat defense maanaged rule groups.</summary>
    [JsonPropertyName("deepThreatInspection")]
    public string? DeepThreatInspection { get; set; }

    /// <summary>Configuration block for override values</summary>
    [JsonPropertyName("override")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceOverride? Override { get; set; }

    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReferenceResourceArnSelector? ResourceArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The string value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks describing dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for more details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}

/// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction? PublishMetricAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomActionActionDefinition? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelector
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
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReference
{
    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }

    /// <summary>Reference to a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnRef")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnRef? ResourceArnRef { get; set; }

    /// <summary>Selector for a RuleGroup in networkfirewall to populate resourceArn.</summary>
    [JsonPropertyName("resourceArnSelector")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReferenceResourceArnSelector? ResourceArnSelector { get; set; }
}

/// <summary>A configuration block describing the rule groups and policy actions to use in the firewall policy. See Firewall Policy below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecInitProviderFirewallPolicy
{
    /// <summary>. Contains variables that you can use to override default Suricata settings in your firewall policy. See Rule Variables for details.</summary>
    [JsonPropertyName("policyVariables")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyPolicyVariables? PolicyVariables { get; set; }

    /// <summary>Set of actions to take on a packet if it does not match any stateful rules in the policy. This can only be specified if the policy has a stateful_engine_options block with a rule_order value of STRICT_ORDER. Value values: aws:drop_strict, aws:drop_established, aws:drop_established_app_layer, aws:alert_strict, aws:alert_established, aws:alert_established_app_layer`. For more information, see Strict evaluation order in the AWS Network Firewall Developer Guide.</summary>
    [JsonPropertyName("statefulDefaultActions")]
    public IList<string>? StatefulDefaultActions { get; set; }

    /// <summary>A configuration block that defines options on how the policy handles stateful rules. See Stateful Engine Options below for details.</summary>
    [JsonPropertyName("statefulEngineOptions")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulEngineOptions? StatefulEngineOptions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateful rule groups that are used in the policy. See Stateful Rule Group Reference below for details.</summary>
    [JsonPropertyName("statefulRuleGroupReference")]
    public IList<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatefulRuleGroupReference>? StatefulRuleGroupReference { get; set; }

    /// <summary>Set of configuration blocks describing the custom action definitions that are available for use in the firewall policy&apos;s stateless_default_actions. See Stateless Custom Action below for details.</summary>
    [JsonPropertyName("statelessCustomAction")]
    public IList<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessCustomAction>? StatelessCustomAction { get; set; }

    /// <summary>
    /// Set of actions to take on a packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe.
    /// In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.
    /// </summary>
    [JsonPropertyName("statelessDefaultActions")]
    public IList<string>? StatelessDefaultActions { get; set; }

    /// <summary>
    /// Set of actions to take on a fragmented packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe.
    /// In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.
    /// </summary>
    [JsonPropertyName("statelessFragmentDefaultActions")]
    public IList<string>? StatelessFragmentDefaultActions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateless rule groups that are used in the policy. See Stateless Rule Group Reference below for details.</summary>
    [JsonPropertyName("statelessRuleGroupReference")]
    public IList<V1beta2FirewallPolicySpecInitProviderFirewallPolicyStatelessRuleGroupReference>? StatelessRuleGroupReference { get; set; }

    /// <summary>The (ARN) of the TLS Inspection policy to attach to the FW Policy.  This must be added at creation of the resource per AWS documentation. &quot;You can only add a TLS inspection configuration to a new policy, not to an existing policy.&quot;  This cannot be removed from a FW Policy.</summary>
    [JsonPropertyName("tlsInspectionConfigurationArn")]
    public string? TlsInspectionConfigurationArn { get; set; }
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
public partial class V1beta2FirewallPolicySpecInitProvider
{
    /// <summary>A friendly description of the firewall policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2FirewallPolicySpecInitProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>A configuration block describing the rule groups and policy actions to use in the firewall policy. See Firewall Policy below for details.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V1beta2FirewallPolicySpecInitProviderFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecManagementPoliciesEnum>))]
public enum V1beta2FirewallPolicySpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FirewallPolicySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallPolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FirewallPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FirewallPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FirewallPolicySpec defines the desired state of FirewallPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicySpec
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
    public V1beta2FirewallPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FirewallPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2FirewallPolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FirewallPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FirewallPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FirewallPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you&apos;re using a key that&apos;s managed by another account. If you&apos;re using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet
{
    /// <summary>Set of IPv4 or IPv6 addresses in CIDR notation to use for the Suricata HOME_NET variable.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariablesRuleVariables
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public V1beta2FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariablesRuleVariablesIpSet? IpSet { get; set; }

    /// <summary>An alphanumeric string to identify the ip_set. Valid values: HOME_NET</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>. Contains variables that you can use to override default Suricata settings in your firewall policy. See Rule Variables for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariables
{
    [JsonPropertyName("ruleVariables")]
    public IList<V1beta2FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariablesRuleVariables>? RuleVariables { get; set; }
}

/// <summary>Amount of time that can pass without any traffic sent through the firewall before the firewall determines that the connection is idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatefulEngineOptionsFlowTimeouts
{
    /// <summary>Number of seconds that can pass without any TCP traffic sent through the firewall before the firewall determines that the connection is idle. After the idle timeout passes, data packets are dropped, however, the next TCP SYN packet is considered a new flow and is processed by the firewall. Clients or targets can use TCP keepalive packets to reset the idle timeout. Default value: 350.</summary>
    [JsonPropertyName("tcpIdleTimeoutSeconds")]
    public double? TcpIdleTimeoutSeconds { get; set; }
}

/// <summary>A configuration block that defines options on how the policy handles stateful rules. See Stateful Engine Options below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatefulEngineOptions
{
    /// <summary>Amount of time that can pass without any traffic sent through the firewall before the firewall determines that the connection is idle.</summary>
    [JsonPropertyName("flowTimeouts")]
    public V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatefulEngineOptionsFlowTimeouts? FlowTimeouts { get; set; }

    /// <summary>Indicates how to manage the order of stateful rule evaluation for the policy. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }

    /// <summary>Describes how to treat traffic which has broken midstream. Default value: DROP. Valid values: DROP, CONTINUE, REJECT.</summary>
    [JsonPropertyName("streamExceptionPolicy")]
    public string? StreamExceptionPolicy { get; set; }
}

/// <summary>Configuration block for override values</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatefulRuleGroupReferenceOverride
{
    /// <summary>The action that changes the rule group from DROP to ALERT . This only applies to managed rule groups.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatefulRuleGroupReference
{
    /// <summary>Whether to enable deep threat inspection, which allows AWS to analyze service logs of network traffic processed by these rule groups to identify threat indicators across customers. AWS will use these threat indicators to improve the active threat defense managed rule groups and protect the security of AWS customers and services. This only applies to active threat defense maanaged rule groups.</summary>
    [JsonPropertyName("deepThreatInspection")]
    public string? DeepThreatInspection { get; set; }

    /// <summary>Configuration block for override values</summary>
    [JsonPropertyName("override")]
    public V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatefulRuleGroupReferenceOverride? Override { get; set; }

    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The string value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks describing dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for more details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}

/// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinitionPublishMetricAction? PublishMetricAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomActionActionDefinition? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatelessRuleGroupReference
{
    /// <summary>An integer setting that indicates the order in which to run the stateless rule groups in a single policy. AWS Network Firewall applies each stateless rule group to a packet starting with the group that has the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the stateless rule group.</summary>
    [JsonPropertyName("resourceArn")]
    public string? ResourceArn { get; set; }
}

/// <summary>A configuration block describing the rule groups and policy actions to use in the firewall policy. See Firewall Policy below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProviderFirewallPolicy
{
    /// <summary>. Contains variables that you can use to override default Suricata settings in your firewall policy. See Rule Variables for details.</summary>
    [JsonPropertyName("policyVariables")]
    public V1beta2FirewallPolicyStatusAtProviderFirewallPolicyPolicyVariables? PolicyVariables { get; set; }

    /// <summary>Set of actions to take on a packet if it does not match any stateful rules in the policy. This can only be specified if the policy has a stateful_engine_options block with a rule_order value of STRICT_ORDER. Value values: aws:drop_strict, aws:drop_established, aws:drop_established_app_layer, aws:alert_strict, aws:alert_established, aws:alert_established_app_layer`. For more information, see Strict evaluation order in the AWS Network Firewall Developer Guide.</summary>
    [JsonPropertyName("statefulDefaultActions")]
    public IList<string>? StatefulDefaultActions { get; set; }

    /// <summary>A configuration block that defines options on how the policy handles stateful rules. See Stateful Engine Options below for details.</summary>
    [JsonPropertyName("statefulEngineOptions")]
    public V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatefulEngineOptions? StatefulEngineOptions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateful rule groups that are used in the policy. See Stateful Rule Group Reference below for details.</summary>
    [JsonPropertyName("statefulRuleGroupReference")]
    public IList<V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatefulRuleGroupReference>? StatefulRuleGroupReference { get; set; }

    /// <summary>Set of configuration blocks describing the custom action definitions that are available for use in the firewall policy&apos;s stateless_default_actions. See Stateless Custom Action below for details.</summary>
    [JsonPropertyName("statelessCustomAction")]
    public IList<V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatelessCustomAction>? StatelessCustomAction { get; set; }

    /// <summary>
    /// Set of actions to take on a packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe.
    /// In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.
    /// </summary>
    [JsonPropertyName("statelessDefaultActions")]
    public IList<string>? StatelessDefaultActions { get; set; }

    /// <summary>
    /// Set of actions to take on a fragmented packet if it does not match any of the stateless rules in the policy. You must specify one of the standard actions including: aws:drop, aws:pass, or aws:forward_to_sfe.
    /// In addition, you can specify custom actions that are compatible with your standard action choice. If you want non-matching packets to be forwarded for stateful inspection, specify aws:forward_to_sfe.
    /// </summary>
    [JsonPropertyName("statelessFragmentDefaultActions")]
    public IList<string>? StatelessFragmentDefaultActions { get; set; }

    /// <summary>Set of configuration blocks containing references to the stateless rule groups that are used in the policy. See Stateless Rule Group Reference below for details.</summary>
    [JsonPropertyName("statelessRuleGroupReference")]
    public IList<V1beta2FirewallPolicyStatusAtProviderFirewallPolicyStatelessRuleGroupReference>? StatelessRuleGroupReference { get; set; }

    /// <summary>The (ARN) of the TLS Inspection policy to attach to the FW Policy.  This must be added at creation of the resource per AWS documentation. &quot;You can only add a TLS inspection configuration to a new policy, not to an existing policy.&quot;  This cannot be removed from a FW Policy.</summary>
    [JsonPropertyName("tlsInspectionConfigurationArn")]
    public string? TlsInspectionConfigurationArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) that identifies the firewall policy.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A friendly description of the firewall policy.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2FirewallPolicyStatusAtProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>A configuration block describing the rule groups and policy actions to use in the firewall policy. See Firewall Policy below for details.</summary>
    [JsonPropertyName("firewallPolicy")]
    public V1beta2FirewallPolicyStatusAtProviderFirewallPolicy? FirewallPolicy { get; set; }

    /// <summary>The Amazon Resource Name (ARN) that identifies the firewall policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>A string token used when updating a firewall policy.</summary>
    [JsonPropertyName("updateToken")]
    public string? UpdateToken { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatusConditions
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

/// <summary>FirewallPolicyStatus defines the observed state of FirewallPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FirewallPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FirewallPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FirewallPolicy is the Schema for the FirewallPolicys API. Provides an AWS Network Firewall Policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FirewallPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FirewallPolicySpec>, IStatus<V1beta2FirewallPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FirewallPolicy";
    public const string KubeGroup = "networkfirewall.aws.upbound.io";
    public const string KubePluralName = "firewallpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkfirewall.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FirewallPolicySpec defines the desired state of FirewallPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FirewallPolicySpec Spec { get; set; }

    /// <summary>FirewallPolicyStatus defines the observed state of FirewallPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta2FirewallPolicyStatus? Status { get; set; }
}