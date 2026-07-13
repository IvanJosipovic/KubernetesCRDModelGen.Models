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
/// <summary>RuleGroup is the Schema for the RuleGroups API. Provides an AWS Network Firewall Rule Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RuleGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2RuleGroup>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RuleGroupList";
    public const string KubeGroup = "networkfirewall.aws.upbound.io";
    public const string KubePluralName = "rulegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkfirewall.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2RuleGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2RuleGroup> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecDeletionPolicyEnum>))]
public enum V1beta2RuleGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you&apos;re using a key that&apos;s managed by another account. If you&apos;re using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolutionEnum>))]
public enum V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolveEnum>))]
public enum V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedPrefixList in ec2 to populate referenceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolveEnum>))]
public enum V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedPrefixList in ec2 to populate referenceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelector
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
    public V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference
{
    /// <summary>Set of Managed Prefix IP ARN(s)</summary>
    [JsonPropertyName("referenceArn")]
    public string? ReferenceArn { get; set; }

    /// <summary>Reference to a ManagedPrefixList in ec2 to populate referenceArn.</summary>
    [JsonPropertyName("referenceArnRef")]
    public V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRef? ReferenceArnRef { get; set; }

    /// <summary>Selector for a ManagedPrefixList in ec2 to populate referenceArn.</summary>
    [JsonPropertyName("referenceArnSelector")]
    public V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelector? ReferenceArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferences
{
    /// <summary>Set of configuration blocks that define the IP Reference information. See IP Set Reference below for details.</summary>
    [JsonPropertyName("ipSetReference")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference>? IpSetReference { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupReferenceSets
{
    [JsonPropertyName("ipSetReferences")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupReferenceSetsIpSetReferences>? IpSetReferences { get; set; }
}

/// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRuleVariablesIpSetsIpSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRuleVariablesIpSets
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public V1beta2RuleGroupSpecForProviderRuleGroupRuleVariablesIpSetsIpSet? IpSet { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRuleVariablesPortSetsPortSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRuleVariablesPortSets
{
    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
    [JsonPropertyName("portSet")]
    public V1beta2RuleGroupSpecForProviderRuleGroupRuleVariablesPortSetsPortSet? PortSet { get; set; }
}

/// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRuleVariables
{
    /// <summary>Set of configuration blocks that define IP address information. See IP Sets below for details.</summary>
    [JsonPropertyName("ipSets")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRuleVariablesIpSets>? IpSets { get; set; }

    /// <summary>Set of configuration blocks that define port range information. See Port Sets below for details.</summary>
    [JsonPropertyName("portSets")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRuleVariablesPortSets>? PortSets { get; set; }
}

/// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceRulesSourceList
{
    /// <summary>String value to specify whether domains in the target list are allowed or denied access. Valid values: ALLOWLIST, DENYLIST.</summary>
    [JsonPropertyName("generatedRulesType")]
    public string? GeneratedRulesType { get; set; }

    /// <summary>Set of types of domain specifications that are provided in the targets argument. Valid values: HTTP_HOST, TLS_SNI.</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }

    /// <summary>Set of domains that you want to inspect for in your traffic flows.</summary>
    [JsonPropertyName("targets")]
    public IList<string>? Targets { get; set; }
}

/// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRuleHeader
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public string? DestinationPort { get; set; }

    /// <summary>The direction of traffic flow to inspect. Valid values: ANY or FORWARD.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The protocol to inspect. Valid values: IP, TCP, UDP, ICMP, HTTP, FTP, TLS, SMB, DNS, DCERPC, SSH, SMTP, IMAP, MSN, KRB5, IKEV2, TFTP, NTP, DHCP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public string? SourcePort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRuleRuleOption
{
    /// <summary>
    /// Keyword defined by open source detection systems like Snort or Suricata for stateful rule inspection.
    /// See Snort General Rule Options or Suricata Rule Options for more details.
    /// </summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>Set of strings for additional settings to use in stateful rule inspection.</summary>
    [JsonPropertyName("settings")]
    public IList<string>? Settings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRule
{
    /// <summary>Action to take with packets in a traffic flow when the flow matches the stateful rule criteria. For all actions, AWS Network Firewall performs the specified action and discontinues stateful inspection of the traffic flow. Valid values: ALERT, DROP, PASS, or REJECT.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
    [JsonPropertyName("header")]
    public V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRuleHeader? Header { get; set; }

    /// <summary>Set of configuration blocks containing additional settings for a stateful rule. See Rule Option below for details.</summary>
    [JsonPropertyName("ruleOption")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRuleRuleOption>? RuleOption { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks containing the dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}

/// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction? PublishMetricAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4 and IPv6.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4 and IPv6.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag
{
    /// <summary>
    /// Set of flags to look for in a packet. This setting can only specify values that are also specified in masks.
    /// Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.
    /// </summary>
    [JsonPropertyName("flags")]
    public IList<string>? Flags { get; set; }

    /// <summary>
    /// Set of flags to consider in the inspection. To inspect all flags, leave this empty.
    /// Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.
    /// </summary>
    [JsonPropertyName("masks")]
    public IList<string>? Masks { get; set; }
}

/// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination>? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort>? DestinationPort { get; set; }

    /// <summary>Set of protocols to inspect for, specified using the protocol&apos;s assigned internet protocol number (IANA). If not specified, this matches with any protocol.</summary>
    [JsonPropertyName("protocols")]
    public IList<double>? Protocols { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource>? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort>? SourcePort { get; set; }

    /// <summary>Set of configuration blocks containing the TCP flags and masks to inspect for. If not specified, this matches with any settings.</summary>
    [JsonPropertyName("tcpFlag")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag>? TcpFlag { get; set; }
}

/// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition
{
    /// <summary>Set of actions to take on a packet that matches one of the stateless rule definition&apos;s match_attributes. For every rule you must specify 1 standard action, and you can add custom actions. Standard actions include: aws:pass, aws:drop, aws:forward_to_sfe.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
    [JsonPropertyName("matchAttributes")]
    public V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes? MatchAttributes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule
{
    /// <summary>A setting that indicates the order in which to run this rule relative to all of the rules that are defined for a stateless rule group. AWS Network Firewall evaluates the rules in a rule group starting with the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
    [JsonPropertyName("ruleDefinition")]
    public V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition? RuleDefinition { get; set; }
}

/// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActions
{
    /// <summary>Set of configuration blocks containing custom action definitions that are available for use by the set of stateless rule. See Custom Action below for details.</summary>
    [JsonPropertyName("customAction")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction>? CustomAction { get; set; }

    /// <summary>Set of configuration blocks containing the stateless rules for use in the stateless rule group. See Stateless Rule below for details.</summary>
    [JsonPropertyName("statelessRule")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule>? StatelessRule { get; set; }
}

/// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupRulesSource
{
    /// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
    [JsonPropertyName("rulesSourceList")]
    public V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceRulesSourceList? RulesSourceList { get; set; }

    /// <summary>Stateful inspection criteria, provided in Suricata compatible rules. These rules contain the inspection criteria and the action to take for traffic that matches the criteria, so this type of rule group doesn’t have a separate action setting.</summary>
    [JsonPropertyName("rulesString")]
    public string? RulesString { get; set; }

    /// <summary>Set of configuration blocks containing stateful inspection criteria for 5-tuple rules to be used together in a rule group. See Stateful Rule below for details.</summary>
    [JsonPropertyName("statefulRule")]
    public IList<V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatefulRule>? StatefulRule { get; set; }

    /// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
    [JsonPropertyName("statelessRulesAndCustomActions")]
    public V1beta2RuleGroupSpecForProviderRuleGroupRulesSourceStatelessRulesAndCustomActions? StatelessRulesAndCustomActions { get; set; }
}

/// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroupStatefulRuleOptions
{
    /// <summary>Indicates how to manage the order of the rule evaluation for the rule group. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }
}

/// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProviderRuleGroup
{
    /// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
    [JsonPropertyName("referenceSets")]
    public V1beta2RuleGroupSpecForProviderRuleGroupReferenceSets? ReferenceSets { get; set; }

    /// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
    [JsonPropertyName("ruleVariables")]
    public V1beta2RuleGroupSpecForProviderRuleGroupRuleVariables? RuleVariables { get; set; }

    /// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
    [JsonPropertyName("rulesSource")]
    public V1beta2RuleGroupSpecForProviderRuleGroupRulesSource? RulesSource { get; set; }

    /// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
    [JsonPropertyName("statefulRuleOptions")]
    public V1beta2RuleGroupSpecForProviderRuleGroupStatefulRuleOptions? StatefulRuleOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecForProvider
{
    /// <summary>The maximum number of operating resources that this rule group can use. For a stateless rule group, the capacity required is the sum of the capacity requirements of the individual rules. For a stateful rule group, the minimum capacity required is the number of individual rules.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>A friendly description of the rule group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2RuleGroupSpecForProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>A friendly name of the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
    [JsonPropertyName("ruleGroup")]
    public V1beta2RuleGroupSpecForProviderRuleGroup? RuleGroup { get; set; }

    /// <summary>The stateful rule group rules specifications in Suricata file format, with one rule per line. Use this to import your existing Suricata compatible rule groups. Required unless rule_group is specified.</summary>
    [JsonPropertyName("rules")]
    public string? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether the rule group is stateless (containing stateless rules) or stateful (containing stateful rules). Valid values include: STATEFUL or STATELESS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you&apos;re using a key that&apos;s managed by another account. If you&apos;re using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolutionEnum>))]
public enum V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolveEnum>))]
public enum V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedPrefixList in ec2 to populate referenceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolutionEnum>))]
public enum V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolveEnum>))]
public enum V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedPrefixList in ec2 to populate referenceArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelector
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
    public V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference
{
    /// <summary>Set of Managed Prefix IP ARN(s)</summary>
    [JsonPropertyName("referenceArn")]
    public string? ReferenceArn { get; set; }

    /// <summary>Reference to a ManagedPrefixList in ec2 to populate referenceArn.</summary>
    [JsonPropertyName("referenceArnRef")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnRef? ReferenceArnRef { get; set; }

    /// <summary>Selector for a ManagedPrefixList in ec2 to populate referenceArn.</summary>
    [JsonPropertyName("referenceArnSelector")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReferenceReferenceArnSelector? ReferenceArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferences
{
    /// <summary>Set of configuration blocks that define the IP Reference information. See IP Set Reference below for details.</summary>
    [JsonPropertyName("ipSetReference")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference>? IpSetReference { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSets
{
    [JsonPropertyName("ipSetReferences")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSetsIpSetReferences>? IpSetReferences { get; set; }
}

/// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRuleVariablesIpSetsIpSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRuleVariablesIpSets
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupRuleVariablesIpSetsIpSet? IpSet { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRuleVariablesPortSetsPortSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRuleVariablesPortSets
{
    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
    [JsonPropertyName("portSet")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupRuleVariablesPortSetsPortSet? PortSet { get; set; }
}

/// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRuleVariables
{
    /// <summary>Set of configuration blocks that define IP address information. See IP Sets below for details.</summary>
    [JsonPropertyName("ipSets")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRuleVariablesIpSets>? IpSets { get; set; }

    /// <summary>Set of configuration blocks that define port range information. See Port Sets below for details.</summary>
    [JsonPropertyName("portSets")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRuleVariablesPortSets>? PortSets { get; set; }
}

/// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceRulesSourceList
{
    /// <summary>String value to specify whether domains in the target list are allowed or denied access. Valid values: ALLOWLIST, DENYLIST.</summary>
    [JsonPropertyName("generatedRulesType")]
    public string? GeneratedRulesType { get; set; }

    /// <summary>Set of types of domain specifications that are provided in the targets argument. Valid values: HTTP_HOST, TLS_SNI.</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }

    /// <summary>Set of domains that you want to inspect for in your traffic flows.</summary>
    [JsonPropertyName("targets")]
    public IList<string>? Targets { get; set; }
}

/// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRuleHeader
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public string? DestinationPort { get; set; }

    /// <summary>The direction of traffic flow to inspect. Valid values: ANY or FORWARD.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The protocol to inspect. Valid values: IP, TCP, UDP, ICMP, HTTP, FTP, TLS, SMB, DNS, DCERPC, SSH, SMTP, IMAP, MSN, KRB5, IKEV2, TFTP, NTP, DHCP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public string? SourcePort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRuleRuleOption
{
    /// <summary>
    /// Keyword defined by open source detection systems like Snort or Suricata for stateful rule inspection.
    /// See Snort General Rule Options or Suricata Rule Options for more details.
    /// </summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>Set of strings for additional settings to use in stateful rule inspection.</summary>
    [JsonPropertyName("settings")]
    public IList<string>? Settings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRule
{
    /// <summary>Action to take with packets in a traffic flow when the flow matches the stateful rule criteria. For all actions, AWS Network Firewall performs the specified action and discontinues stateful inspection of the traffic flow. Valid values: ALERT, DROP, PASS, or REJECT.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
    [JsonPropertyName("header")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRuleHeader? Header { get; set; }

    /// <summary>Set of configuration blocks containing additional settings for a stateful rule. See Rule Option below for details.</summary>
    [JsonPropertyName("ruleOption")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRuleRuleOption>? RuleOption { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks containing the dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}

/// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction? PublishMetricAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4 and IPv6.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4 and IPv6.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag
{
    /// <summary>
    /// Set of flags to look for in a packet. This setting can only specify values that are also specified in masks.
    /// Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.
    /// </summary>
    [JsonPropertyName("flags")]
    public IList<string>? Flags { get; set; }

    /// <summary>
    /// Set of flags to consider in the inspection. To inspect all flags, leave this empty.
    /// Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.
    /// </summary>
    [JsonPropertyName("masks")]
    public IList<string>? Masks { get; set; }
}

/// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination>? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort>? DestinationPort { get; set; }

    /// <summary>Set of protocols to inspect for, specified using the protocol&apos;s assigned internet protocol number (IANA). If not specified, this matches with any protocol.</summary>
    [JsonPropertyName("protocols")]
    public IList<double>? Protocols { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource>? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort>? SourcePort { get; set; }

    /// <summary>Set of configuration blocks containing the TCP flags and masks to inspect for. If not specified, this matches with any settings.</summary>
    [JsonPropertyName("tcpFlag")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag>? TcpFlag { get; set; }
}

/// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition
{
    /// <summary>Set of actions to take on a packet that matches one of the stateless rule definition&apos;s match_attributes. For every rule you must specify 1 standard action, and you can add custom actions. Standard actions include: aws:pass, aws:drop, aws:forward_to_sfe.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
    [JsonPropertyName("matchAttributes")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes? MatchAttributes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule
{
    /// <summary>A setting that indicates the order in which to run this rule relative to all of the rules that are defined for a stateless rule group. AWS Network Firewall evaluates the rules in a rule group starting with the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
    [JsonPropertyName("ruleDefinition")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition? RuleDefinition { get; set; }
}

/// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActions
{
    /// <summary>Set of configuration blocks containing custom action definitions that are available for use by the set of stateless rule. See Custom Action below for details.</summary>
    [JsonPropertyName("customAction")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction>? CustomAction { get; set; }

    /// <summary>Set of configuration blocks containing the stateless rules for use in the stateless rule group. See Stateless Rule below for details.</summary>
    [JsonPropertyName("statelessRule")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule>? StatelessRule { get; set; }
}

/// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupRulesSource
{
    /// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
    [JsonPropertyName("rulesSourceList")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceRulesSourceList? RulesSourceList { get; set; }

    /// <summary>Stateful inspection criteria, provided in Suricata compatible rules. These rules contain the inspection criteria and the action to take for traffic that matches the criteria, so this type of rule group doesn’t have a separate action setting.</summary>
    [JsonPropertyName("rulesString")]
    public string? RulesString { get; set; }

    /// <summary>Set of configuration blocks containing stateful inspection criteria for 5-tuple rules to be used together in a rule group. See Stateful Rule below for details.</summary>
    [JsonPropertyName("statefulRule")]
    public IList<V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatefulRule>? StatefulRule { get; set; }

    /// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
    [JsonPropertyName("statelessRulesAndCustomActions")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupRulesSourceStatelessRulesAndCustomActions? StatelessRulesAndCustomActions { get; set; }
}

/// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroupStatefulRuleOptions
{
    /// <summary>Indicates how to manage the order of the rule evaluation for the rule group. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }
}

/// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecInitProviderRuleGroup
{
    /// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
    [JsonPropertyName("referenceSets")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupReferenceSets? ReferenceSets { get; set; }

    /// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
    [JsonPropertyName("ruleVariables")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupRuleVariables? RuleVariables { get; set; }

    /// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
    [JsonPropertyName("rulesSource")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupRulesSource? RulesSource { get; set; }

    /// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
    [JsonPropertyName("statefulRuleOptions")]
    public V1beta2RuleGroupSpecInitProviderRuleGroupStatefulRuleOptions? StatefulRuleOptions { get; set; }
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
public partial class V1beta2RuleGroupSpecInitProvider
{
    /// <summary>The maximum number of operating resources that this rule group can use. For a stateless rule group, the capacity required is the sum of the capacity requirements of the individual rules. For a stateful rule group, the minimum capacity required is the number of individual rules.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>A friendly description of the rule group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2RuleGroupSpecInitProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>A friendly name of the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
    [JsonPropertyName("ruleGroup")]
    public V1beta2RuleGroupSpecInitProviderRuleGroup? RuleGroup { get; set; }

    /// <summary>The stateful rule group rules specifications in Suricata file format, with one rule per line. Use this to import your existing Suricata compatible rule groups. Required unless rule_group is specified.</summary>
    [JsonPropertyName("rules")]
    public string? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether the rule group is stateless (containing stateless rules) or stateful (containing stateful rules). Valid values include: STATEFUL or STATELESS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecManagementPoliciesEnum>))]
public enum V1beta2RuleGroupSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RuleGroupSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RuleGroupSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RuleGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RuleGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RuleGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RuleGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RuleGroupSpec defines the desired state of RuleGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupSpec
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
    public V1beta2RuleGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RuleGroupSpecForProvider ForProvider { get; set; }

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
    public V1beta2RuleGroupSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RuleGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RuleGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RuleGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderEncryptionConfiguration
{
    /// <summary>The ID of the customer managed key. You can use any of the key identifiers that KMS supports, unless you&apos;re using a key that&apos;s managed by another account. If you&apos;re using a key managed by another account, then specify the key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>The type of AWS KMS key to use for encryption of your Network Firewall resources. Valid values are CUSTOMER_KMS and AWS_OWNED_KMS_KEY.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference
{
    /// <summary>Set of Managed Prefix IP ARN(s)</summary>
    [JsonPropertyName("referenceArn")]
    public string? ReferenceArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupReferenceSetsIpSetReferences
{
    /// <summary>Set of configuration blocks that define the IP Reference information. See IP Set Reference below for details.</summary>
    [JsonPropertyName("ipSetReference")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupReferenceSetsIpSetReferencesIpSetReference>? IpSetReference { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupReferenceSets
{
    [JsonPropertyName("ipSetReferences")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupReferenceSetsIpSetReferences>? IpSetReferences { get; set; }
}

/// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRuleVariablesIpSetsIpSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRuleVariablesIpSets
{
    /// <summary>A configuration block that defines a set of IP addresses. See IP Set below for details.</summary>
    [JsonPropertyName("ipSet")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupRuleVariablesIpSetsIpSet? IpSet { get; set; }

    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRuleVariablesPortSetsPortSet
{
    /// <summary>Set of port ranges.</summary>
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRuleVariablesPortSets
{
    /// <summary>An unique alphanumeric string to identify the port_set.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>A configuration block that defines a set of port ranges. See Port Set below for details.</summary>
    [JsonPropertyName("portSet")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupRuleVariablesPortSetsPortSet? PortSet { get; set; }
}

/// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRuleVariables
{
    /// <summary>Set of configuration blocks that define IP address information. See IP Sets below for details.</summary>
    [JsonPropertyName("ipSets")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRuleVariablesIpSets>? IpSets { get; set; }

    /// <summary>Set of configuration blocks that define port range information. See Port Sets below for details.</summary>
    [JsonPropertyName("portSets")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRuleVariablesPortSets>? PortSets { get; set; }
}

/// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceRulesSourceList
{
    /// <summary>String value to specify whether domains in the target list are allowed or denied access. Valid values: ALLOWLIST, DENYLIST.</summary>
    [JsonPropertyName("generatedRulesType")]
    public string? GeneratedRulesType { get; set; }

    /// <summary>Set of types of domain specifications that are provided in the targets argument. Valid values: HTTP_HOST, TLS_SNI.</summary>
    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }

    /// <summary>Set of domains that you want to inspect for in your traffic flows.</summary>
    [JsonPropertyName("targets")]
    public IList<string>? Targets { get; set; }
}

/// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRuleHeader
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public string? DestinationPort { get; set; }

    /// <summary>The direction of traffic flow to inspect. Valid values: ANY or FORWARD.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The protocol to inspect. Valid values: IP, TCP, UDP, ICMP, HTTP, FTP, TLS, SMB, DNS, DCERPC, SSH, SMTP, IMAP, MSN, KRB5, IKEV2, TFTP, NTP, DHCP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public string? SourcePort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRuleRuleOption
{
    /// <summary>
    /// Keyword defined by open source detection systems like Snort or Suricata for stateful rule inspection.
    /// See Snort General Rule Options or Suricata Rule Options for more details.
    /// </summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>Set of strings for additional settings to use in stateful rule inspection.</summary>
    [JsonPropertyName("settings")]
    public IList<string>? Settings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRule
{
    /// <summary>Action to take with packets in a traffic flow when the flow matches the stateful rule criteria. For all actions, AWS Network Firewall performs the specified action and discontinues stateful inspection of the traffic flow. Valid values: ALERT, DROP, PASS, or REJECT.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>A configuration block containing the stateful 5-tuple inspection criteria for the rule, used to inspect traffic flows. See Header below for details.</summary>
    [JsonPropertyName("header")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRuleHeader? Header { get; set; }

    /// <summary>Set of configuration blocks containing additional settings for a stateful rule. See Rule Option below for details.</summary>
    [JsonPropertyName("ruleOption")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRuleRuleOption>? RuleOption { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension
{
    /// <summary>The value to use in the custom metric dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction
{
    /// <summary>Set of configuration blocks containing the dimension settings to use for Amazon CloudWatch custom metrics. See Dimension below for details.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricActionDimension>? Dimension { get; set; }
}

/// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition
{
    /// <summary>A configuration block describing the stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch for the matching packet. You can pair this custom action with any of the standard stateless rule actions. See Publish Metric Action below for details.</summary>
    [JsonPropertyName("publishMetricAction")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinitionPublishMetricAction? PublishMetricAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction
{
    /// <summary>A configuration block describing the custom action associated with the action_name. See Action Definition below for details.</summary>
    [JsonPropertyName("actionDefinition")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionActionDefinition? ActionDefinition { get; set; }

    /// <summary>A friendly name of the custom action.</summary>
    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4 and IPv6.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource
{
    /// <summary>An IP address or a block of IP addresses in CIDR notation. AWS Network Firewall supports all address ranges for IPv4 and IPv6.</summary>
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort
{
    /// <summary>The lower limit of the port range. This must be less than or equal to the to_port.</summary>
    [JsonPropertyName("fromPort")]
    public double? FromPort { get; set; }

    /// <summary>The upper limit of the port range. This must be greater than or equal to the from_port.</summary>
    [JsonPropertyName("toPort")]
    public double? ToPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag
{
    /// <summary>
    /// Set of flags to look for in a packet. This setting can only specify values that are also specified in masks.
    /// Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.
    /// </summary>
    [JsonPropertyName("flags")]
    public IList<string>? Flags { get; set; }

    /// <summary>
    /// Set of flags to consider in the inspection. To inspect all flags, leave this empty.
    /// Valid values: FIN, SYN, RST, PSH, ACK, URG, ECE, CWR.
    /// </summary>
    [JsonPropertyName("masks")]
    public IList<string>? Masks { get; set; }
}

/// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes
{
    /// <summary>Set of configuration blocks describing the destination IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any destination address. See Destination below for details.</summary>
    [JsonPropertyName("destination")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestination>? Destination { get; set; }

    /// <summary>Set of configuration blocks describing the destination ports to inspect for. If not specified, this matches with any destination port. See Destination Port below for details.</summary>
    [JsonPropertyName("destinationPort")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesDestinationPort>? DestinationPort { get; set; }

    /// <summary>Set of protocols to inspect for, specified using the protocol&apos;s assigned internet protocol number (IANA). If not specified, this matches with any protocol.</summary>
    [JsonPropertyName("protocols")]
    public IList<double>? Protocols { get; set; }

    /// <summary>Set of configuration blocks describing the source IP address and address ranges to inspect for, in CIDR notation. If not specified, this matches with any source address. See Source below for details.</summary>
    [JsonPropertyName("source")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSource>? Source { get; set; }

    /// <summary>Set of configuration blocks describing the source ports to inspect for. If not specified, this matches with any source port. See Source Port below for details.</summary>
    [JsonPropertyName("sourcePort")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesSourcePort>? SourcePort { get; set; }

    /// <summary>Set of configuration blocks containing the TCP flags and masks to inspect for. If not specified, this matches with any settings.</summary>
    [JsonPropertyName("tcpFlag")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributesTcpFlag>? TcpFlag { get; set; }
}

/// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition
{
    /// <summary>Set of actions to take on a packet that matches one of the stateless rule definition&apos;s match_attributes. For every rule you must specify 1 standard action, and you can add custom actions. Standard actions include: aws:pass, aws:drop, aws:forward_to_sfe.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>A configuration block containing criteria for AWS Network Firewall to use to inspect an individual packet in stateless rule inspection. See Match Attributes below for details.</summary>
    [JsonPropertyName("matchAttributes")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinitionMatchAttributes? MatchAttributes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule
{
    /// <summary>A setting that indicates the order in which to run this rule relative to all of the rules that are defined for a stateless rule group. AWS Network Firewall evaluates the rules in a rule group starting with the lowest priority setting.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>A configuration block defining the stateless 5-tuple packet inspection criteria and the action to take on a packet that matches the criteria. See Rule Definition below for details.</summary>
    [JsonPropertyName("ruleDefinition")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRuleRuleDefinition? RuleDefinition { get; set; }
}

/// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActions
{
    /// <summary>Set of configuration blocks containing custom action definitions that are available for use by the set of stateless rule. See Custom Action below for details.</summary>
    [JsonPropertyName("customAction")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomAction>? CustomAction { get; set; }

    /// <summary>Set of configuration blocks containing the stateless rules for use in the stateless rule group. See Stateless Rule below for details.</summary>
    [JsonPropertyName("statelessRule")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRule>? StatelessRule { get; set; }
}

/// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupRulesSource
{
    /// <summary>A configuration block containing stateful inspection criteria for a domain list rule group. See Rules Source List below for details.</summary>
    [JsonPropertyName("rulesSourceList")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceRulesSourceList? RulesSourceList { get; set; }

    /// <summary>Stateful inspection criteria, provided in Suricata compatible rules. These rules contain the inspection criteria and the action to take for traffic that matches the criteria, so this type of rule group doesn’t have a separate action setting.</summary>
    [JsonPropertyName("rulesString")]
    public string? RulesString { get; set; }

    /// <summary>Set of configuration blocks containing stateful inspection criteria for 5-tuple rules to be used together in a rule group. See Stateful Rule below for details.</summary>
    [JsonPropertyName("statefulRule")]
    public IList<V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatefulRule>? StatefulRule { get; set; }

    /// <summary>A configuration block containing stateless inspection criteria for a stateless rule group. See Stateless Rules and Custom Actions below for details.</summary>
    [JsonPropertyName("statelessRulesAndCustomActions")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupRulesSourceStatelessRulesAndCustomActions? StatelessRulesAndCustomActions { get; set; }
}

/// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroupStatefulRuleOptions
{
    /// <summary>Indicates how to manage the order of the rule evaluation for the rule group. Default value: DEFAULT_ACTION_ORDER. Valid values: DEFAULT_ACTION_ORDER, STRICT_ORDER.</summary>
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }
}

/// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProviderRuleGroup
{
    /// <summary>A configuration block that defines the IP Set References for the rule group. See Reference Sets below for details. Please notes that there can only be a maximum of 5 reference_sets in a rule_group. See the AWS documentation for details.</summary>
    [JsonPropertyName("referenceSets")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupReferenceSets? ReferenceSets { get; set; }

    /// <summary>A configuration block that defines additional settings available to use in the rules defined in the rule group. Can only be specified for stateful rule groups. See Rule Variables below for details.</summary>
    [JsonPropertyName("ruleVariables")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupRuleVariables? RuleVariables { get; set; }

    /// <summary>A configuration block that defines the stateful or stateless rules for the rule group. See Rules Source below for details.</summary>
    [JsonPropertyName("rulesSource")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupRulesSource? RulesSource { get; set; }

    /// <summary>A configuration block that defines stateful rule options for the rule group. See Stateful Rule Options below for details.</summary>
    [JsonPropertyName("statefulRuleOptions")]
    public V1beta2RuleGroupStatusAtProviderRuleGroupStatefulRuleOptions? StatefulRuleOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) that identifies the rule group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The maximum number of operating resources that this rule group can use. For a stateless rule group, the capacity required is the sum of the capacity requirements of the individual rules. For a stateful rule group, the minimum capacity required is the number of individual rules.</summary>
    [JsonPropertyName("capacity")]
    public double? Capacity { get; set; }

    /// <summary>A friendly description of the rule group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>KMS encryption configuration settings. See Encryption Configuration below for details.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2RuleGroupStatusAtProviderEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>The Amazon Resource Name (ARN) that identifies the rule group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A friendly name of the rule group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A configuration block that defines the rule group rules. Required unless rules is specified. See Rule Group below for details.</summary>
    [JsonPropertyName("ruleGroup")]
    public V1beta2RuleGroupStatusAtProviderRuleGroup? RuleGroup { get; set; }

    /// <summary>The stateful rule group rules specifications in Suricata file format, with one rule per line. Use this to import your existing Suricata compatible rule groups. Required unless rule_group is specified.</summary>
    [JsonPropertyName("rules")]
    public string? Rules { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Whether the rule group is stateless (containing stateless rules) or stateful (containing stateful rules). Valid values include: STATEFUL or STATELESS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>A string token used when updating the rule group.</summary>
    [JsonPropertyName("updateToken")]
    public string? UpdateToken { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatusConditions
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

/// <summary>RuleGroupStatus defines the observed state of RuleGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RuleGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RuleGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RuleGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RuleGroup is the Schema for the RuleGroups API. Provides an AWS Network Firewall Rule Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RuleGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RuleGroupSpec>, IStatus<V1beta2RuleGroupStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RuleGroup";
    public const string KubeGroup = "networkfirewall.aws.upbound.io";
    public const string KubePluralName = "rulegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkfirewall.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RuleGroupSpec defines the desired state of RuleGroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RuleGroupSpec Spec { get; set; }

    /// <summary>RuleGroupStatus defines the observed state of RuleGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta2RuleGroupStatus? Status { get; set; }
}