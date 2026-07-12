#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkfirewall.services.k8s.aws;
/// <summary>RuleGroup is the Schema for the RuleGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RuleGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1RuleGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RuleGroupList";
    public const string KubeGroup = "networkfirewall.services.k8s.aws";
    public const string KubePluralName = "rulegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkfirewall.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1RuleGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1RuleGroup> Items { get; set; }
}

/// <summary>A complex type that contains settings for encryption of your rule group resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecEncryptionConfiguration
{
    [JsonPropertyName("keyID")]
    public string? KeyID { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// Configures one or more IP set references for a Suricata-compatible rule group.
/// This is used in CreateRuleGroup or UpdateRuleGroup. An IP set reference is
/// a rule variable that references resources that you create and manage in another
/// Amazon Web Services service, such as an Amazon VPC prefix list. Network Firewall
/// IP set references enable you to dynamically update the contents of your rules.
/// When you create, update, or delete the resource you are referencing in your
/// rule, Network Firewall automatically updates the rule&apos;s content with the
/// changes. For more information about IP set references in Network Firewall,
/// see Using IP set references (https://docs.aws.amazon.com/network-firewall/latest/developerguide/rule-groups-ip-set-references)
/// in the Network Firewall Developer Guide.
/// 
/// Network Firewall currently supports Amazon VPC prefix lists (https://docs.aws.amazon.com/vpc/latest/userguide/managed-prefix-lists.html)
/// and resource groups (https://docs.aws.amazon.com/network-firewall/latest/developerguide/rule-groups-ip-set-references.html#rule-groups-referencing-resource-groups)
/// in IP set references.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupReferenceSetsIpSetReferences
{
    [JsonPropertyName("referenceARN")]
    public string? ReferenceARN { get; set; }
}

/// <summary>Contains a set of IP set references.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupReferenceSets
{
    [JsonPropertyName("ipSetReferences")]
    public IDictionary<string, V1alpha1RuleGroupSpecRuleGroupReferenceSetsIpSetReferences>? IpSetReferences { get; set; }
}

/// <summary>
/// A list of IP addresses and address ranges, in CIDR notation. This is part
/// of a RuleVariables.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRuleVariablesIpSets
{
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

/// <summary>A set of port ranges for use in the rules in a rule group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRuleVariablesPortSets
{
    [JsonPropertyName("definition")]
    public IList<string>? Definition { get; set; }
}

/// <summary>
/// Settings that are available for use in the rules in the RuleGroup where this
/// is defined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRuleVariables
{
    [JsonPropertyName("ipSets")]
    public IDictionary<string, V1alpha1RuleGroupSpecRuleGroupRuleVariablesIpSets>? IpSets { get; set; }

    [JsonPropertyName("portSets")]
    public IDictionary<string, V1alpha1RuleGroupSpecRuleGroupRuleVariablesPortSets>? PortSets { get; set; }
}

/// <summary>
/// Stateful inspection criteria for a domain list rule group.
/// 
/// For HTTPS traffic, domain filtering is SNI-based. It uses the server name
/// indicator extension of the TLS handshake.
/// 
/// By default, Network Firewall domain list inspection only includes traffic
/// coming from the VPC where you deploy the firewall. To inspect traffic from
/// IP addresses outside of the deployment VPC, you set the HOME_NET rule variable
/// to include the CIDR range of the deployment VPC plus the other CIDR ranges.
/// For more information, see RuleVariables in this guide and Stateful domain
/// list rule groups in Network Firewall (https://docs.aws.amazon.com/network-firewall/latest/developerguide/stateful-rule-groups-domain-names.html)
/// in the Network Firewall Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceRulesSourceList
{
    [JsonPropertyName("generatedRulesType")]
    public string? GeneratedRulesType { get; set; }

    [JsonPropertyName("targetTypes")]
    public IList<string>? TargetTypes { get; set; }

    [JsonPropertyName("targets")]
    public IList<string>? Targets { get; set; }
}

/// <summary>
/// The basic rule criteria for Network Firewall to use to inspect packet headers
/// in stateful traffic flow inspection. Traffic flows that match the criteria
/// are a match for the corresponding StatefulRule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatefulRulesHeader
{
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    [JsonPropertyName("destinationPort")]
    public string? DestinationPort { get; set; }

    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("sourcePort")]
    public string? SourcePort { get; set; }
}

/// <summary>
/// Additional settings for a stateful rule. This is part of the StatefulRule
/// configuration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatefulRulesRuleOptions
{
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    [JsonPropertyName("settings")]
    public IList<string>? Settings { get; set; }
}

/// <summary>
/// A single Suricata rules specification, for use in a stateful rule group.
/// Use this option to specify a simple Suricata rule with protocol, source and
/// destination, ports, direction, and rule options. For information about the
/// Suricata Rules format, see Rules Format (https://suricata.readthedocs.io/en/suricata-6.0.9/rules/intro.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatefulRules
{
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// The basic rule criteria for Network Firewall to use to inspect packet headers
    /// in stateful traffic flow inspection. Traffic flows that match the criteria
    /// are a match for the corresponding StatefulRule.
    /// </summary>
    [JsonPropertyName("header")]
    public V1alpha1RuleGroupSpecRuleGroupRulesSourceStatefulRulesHeader? Header { get; set; }

    [JsonPropertyName("ruleOptions")]
    public IList<V1alpha1RuleGroupSpecRuleGroupRulesSourceStatefulRulesRuleOptions>? RuleOptions { get; set; }
}

/// <summary>
/// The value to use in an Amazon CloudWatch custom metric dimension. This is
/// used in the PublishMetrics CustomAction. A CloudWatch custom metric dimension
/// is a name/value pair that&apos;s part of the identity of a metric.
/// 
/// Network Firewall sets the dimension name to CustomAction and you provide
/// the dimension value.
/// 
/// For more information about CloudWatch custom metric dimensions, see Publishing
/// Custom Metrics (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html#usingDimensions)
/// in the Amazon CloudWatch User Guide (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/WhatIsCloudWatch.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionsActionDefinitionPublishMetricActionDimensions
{
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Stateless inspection criteria that publishes the specified metrics to Amazon
/// CloudWatch for the matching packet. This setting defines a CloudWatch dimension
/// value to be published.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionsActionDefinitionPublishMetricAction
{
    [JsonPropertyName("dimensions")]
    public IList<V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionsActionDefinitionPublishMetricActionDimensions>? Dimensions { get; set; }
}

/// <summary>
/// A custom action to use in stateless rule actions settings. This is used in
/// CustomAction.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionsActionDefinition
{
    /// <summary>
    /// Stateless inspection criteria that publishes the specified metrics to Amazon
    /// CloudWatch for the matching packet. This setting defines a CloudWatch dimension
    /// value to be published.
    /// </summary>
    [JsonPropertyName("publishMetricAction")]
    public V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionsActionDefinitionPublishMetricAction? PublishMetricAction { get; set; }
}

/// <summary>
/// An optional, non-standard action to use for stateless packet handling. You
/// can define this in addition to the standard action that you must specify.
/// 
/// You define and name the custom actions that you want to be able to use, and
/// then you reference them by name in your actions settings.
/// 
/// You can use custom actions in the following places:
/// 
///   - In a rule group&apos;s StatelessRulesAndCustomActions specification. The
///     custom actions are available for use by name inside the StatelessRulesAndCustomActions
///     where you define them. You can use them for your stateless rule actions
///     to specify what to do with a packet that matches the rule&apos;s match attributes.
/// 
///   - In a FirewallPolicy specification, in StatelessCustomActions. The custom
///     actions are available for use inside the policy where you define them.
///     You can use them for the policy&apos;s default stateless actions settings to
///     specify what to do with packets that don&apos;t match any of the policy&apos;s stateless
///     rules.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActions
{
    /// <summary>
    /// A custom action to use in stateless rule actions settings. This is used in
    /// CustomAction.
    /// </summary>
    [JsonPropertyName("actionDefinition")]
    public V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActionsActionDefinition? ActionDefinition { get; set; }

    [JsonPropertyName("actionName")]
    public string? ActionName { get; set; }
}

/// <summary>
/// A single port range specification. This is used for source and destination
/// port ranges in the stateless rule MatchAttributes, SourcePorts, and DestinationPorts
/// settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributesDestinationPorts
{
    [JsonPropertyName("fromPort")]
    public long? FromPort { get; set; }

    [JsonPropertyName("toPort")]
    public long? ToPort { get; set; }
}

/// <summary>
/// A single IP address specification. This is used in the MatchAttributes source
/// and destination specifications.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributesDestinations
{
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}

/// <summary>
/// A single port range specification. This is used for source and destination
/// port ranges in the stateless rule MatchAttributes, SourcePorts, and DestinationPorts
/// settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributesSourcePorts
{
    [JsonPropertyName("fromPort")]
    public long? FromPort { get; set; }

    [JsonPropertyName("toPort")]
    public long? ToPort { get; set; }
}

/// <summary>
/// A single IP address specification. This is used in the MatchAttributes source
/// and destination specifications.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributesSources
{
    [JsonPropertyName("addressDefinition")]
    public string? AddressDefinition { get; set; }
}

/// <summary>
/// TCP flags and masks to inspect packets for, used in stateless rules MatchAttributes
/// settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributesTcpFlags
{
    [JsonPropertyName("flags")]
    public IList<string>? Flags { get; set; }

    [JsonPropertyName("masks")]
    public IList<string>? Masks { get; set; }
}

/// <summary>
/// Criteria for Network Firewall to use to inspect an individual packet in stateless
/// rule inspection. Each match attributes set can include one or more items
/// such as IP address, CIDR range, port number, protocol, and TCP flags.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributes
{
    [JsonPropertyName("destinationPorts")]
    public IList<V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributesDestinationPorts>? DestinationPorts { get; set; }

    [JsonPropertyName("destinations")]
    public IList<V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributesDestinations>? Destinations { get; set; }

    [JsonPropertyName("protocols")]
    public IList<long>? Protocols { get; set; }

    [JsonPropertyName("sourcePorts")]
    public IList<V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributesSourcePorts>? SourcePorts { get; set; }

    [JsonPropertyName("sources")]
    public IList<V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributesSources>? Sources { get; set; }

    [JsonPropertyName("tcpFlags")]
    public IList<V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributesTcpFlags>? TcpFlags { get; set; }
}

/// <summary>
/// The inspection criteria and action for a single stateless rule. Network Firewall
/// inspects each packet for the specified matching criteria. When a packet matches
/// the criteria, Network Firewall performs the rule&apos;s actions on the packet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinition
{
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>
    /// Criteria for Network Firewall to use to inspect an individual packet in stateless
    /// rule inspection. Each match attributes set can include one or more items
    /// such as IP address, CIDR range, port number, protocol, and TCP flags.
    /// </summary>
    [JsonPropertyName("matchAttributes")]
    public V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinitionMatchAttributes? MatchAttributes { get; set; }
}

/// <summary>A single stateless rule. This is used in StatelessRulesAndCustomActions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRules
{
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    /// <summary>
    /// The inspection criteria and action for a single stateless rule. Network Firewall
    /// inspects each packet for the specified matching criteria. When a packet matches
    /// the criteria, Network Firewall performs the rule&apos;s actions on the packet.
    /// </summary>
    [JsonPropertyName("ruleDefinition")]
    public V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRulesRuleDefinition? RuleDefinition { get; set; }
}

/// <summary>
/// Stateless inspection criteria. Each stateless rule group uses exactly one
/// of these data types to define its stateless rules.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActions
{
    [JsonPropertyName("customActions")]
    public IList<V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsCustomActions>? CustomActions { get; set; }

    [JsonPropertyName("statelessRules")]
    public IList<V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActionsStatelessRules>? StatelessRules { get; set; }
}

/// <summary>
/// The stateless or stateful rules definitions for use in a single rule group.
/// Each rule group requires a single RulesSource. You can use an instance of
/// this for either stateless rules or stateful rules.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupRulesSource
{
    /// <summary>
    /// Stateful inspection criteria for a domain list rule group.
    /// 
    /// For HTTPS traffic, domain filtering is SNI-based. It uses the server name
    /// indicator extension of the TLS handshake.
    /// 
    /// By default, Network Firewall domain list inspection only includes traffic
    /// coming from the VPC where you deploy the firewall. To inspect traffic from
    /// IP addresses outside of the deployment VPC, you set the HOME_NET rule variable
    /// to include the CIDR range of the deployment VPC plus the other CIDR ranges.
    /// For more information, see RuleVariables in this guide and Stateful domain
    /// list rule groups in Network Firewall (https://docs.aws.amazon.com/network-firewall/latest/developerguide/stateful-rule-groups-domain-names.html)
    /// in the Network Firewall Developer Guide.
    /// </summary>
    [JsonPropertyName("rulesSourceList")]
    public V1alpha1RuleGroupSpecRuleGroupRulesSourceRulesSourceList? RulesSourceList { get; set; }

    [JsonPropertyName("rulesString")]
    public string? RulesString { get; set; }

    [JsonPropertyName("statefulRules")]
    public IList<V1alpha1RuleGroupSpecRuleGroupRulesSourceStatefulRules>? StatefulRules { get; set; }

    /// <summary>
    /// Stateless inspection criteria. Each stateless rule group uses exactly one
    /// of these data types to define its stateless rules.
    /// </summary>
    [JsonPropertyName("statelessRulesAndCustomActions")]
    public V1alpha1RuleGroupSpecRuleGroupRulesSourceStatelessRulesAndCustomActions? StatelessRulesAndCustomActions { get; set; }
}

/// <summary>
/// Additional options governing how Network Firewall handles the rule group.
/// You can only use these for stateful rule groups.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroupStatefulRuleOptions
{
    [JsonPropertyName("ruleOrder")]
    public string? RuleOrder { get; set; }
}

/// <summary>
/// An object that defines the rule group rules.
/// 
/// You must provide either this rule group setting or a Rules setting, but not
/// both.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecRuleGroup
{
    /// <summary>Contains a set of IP set references.</summary>
    [JsonPropertyName("referenceSets")]
    public V1alpha1RuleGroupSpecRuleGroupReferenceSets? ReferenceSets { get; set; }

    /// <summary>
    /// Settings that are available for use in the rules in the RuleGroup where this
    /// is defined.
    /// </summary>
    [JsonPropertyName("ruleVariables")]
    public V1alpha1RuleGroupSpecRuleGroupRuleVariables? RuleVariables { get; set; }

    /// <summary>
    /// The stateless or stateful rules definitions for use in a single rule group.
    /// Each rule group requires a single RulesSource. You can use an instance of
    /// this for either stateless rules or stateful rules.
    /// </summary>
    [JsonPropertyName("rulesSource")]
    public V1alpha1RuleGroupSpecRuleGroupRulesSource? RulesSource { get; set; }

    /// <summary>
    /// Additional options governing how Network Firewall handles the rule group.
    /// You can only use these for stateful rule groups.
    /// </summary>
    [JsonPropertyName("statefulRuleOptions")]
    public V1alpha1RuleGroupSpecRuleGroupStatefulRuleOptions? StatefulRuleOptions { get; set; }
}

/// <summary>
/// A complex type that contains metadata about the rule group that your own
/// rule group is copied from. You can use the metadata to keep track of updates
/// made to the originating rule group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecSourceMetadata
{
    [JsonPropertyName("sourceARN")]
    public string? SourceARN { get; set; }

    [JsonPropertyName("sourceUpdateToken")]
    public string? SourceUpdateToken { get; set; }
}

/// <summary>
/// A key:value pair associated with an Amazon Web Services resource. The key:value
/// pair can be anything you define. Typically, the tag key represents a category
/// (such as &quot;environment&quot;) and the tag value represents a specific value within
/// that category (such as &quot;test,&quot; &quot;development,&quot; or &quot;production&quot;). You can add
/// up to 50 tags to each Amazon Web Services resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// RuleGroupSpec defines the desired state of RuleGroup.
/// 
/// The object that defines the rules in a rule group. This, along with RuleGroupResponse,
/// define the rule group. You can retrieve all objects for a rule group by calling
/// DescribeRuleGroup.
/// 
/// Network Firewall uses a rule group to inspect and control network traffic.
/// You define stateless rule groups to inspect individual packets and you define
/// stateful rule groups to inspect packets in the context of their traffic flow.
/// 
/// To use a rule group, you include it by reference in an Network Firewall firewall
/// policy, then you use the policy in a firewall. You can reference a rule group
/// from more than one firewall policy, and you can use a firewall policy in
/// more than one firewall.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupSpec
{
    /// <summary>
    /// Indicates whether you want Network Firewall to analyze the stateless rules
    /// in the rule group for rule behavior such as asymmetric routing. If set to
    /// TRUE, Network Firewall runs the analysis and then creates the rule group
    /// for you. To run the stateless rule group analyzer without creating the rule
    /// group, set DryRun to TRUE.
    /// </summary>
    [JsonPropertyName("analyzeRuleGroup")]
    public bool? AnalyzeRuleGroup { get; set; }

    /// <summary>
    /// The maximum operating resources that this rule group can use. Rule group
    /// capacity is fixed at creation. When you update a rule group, you are limited
    /// to this capacity. When you reference a rule group from a firewall policy,
    /// Network Firewall reserves this capacity for the rule group.
    /// 
    /// You can retrieve the capacity that would be required for a rule group before
    /// you create the rule group by calling CreateRuleGroup with DryRun set to TRUE.
    /// 
    /// You can&apos;t change or exceed this capacity when you update the rule group,
    /// so leave room for your rule group to grow.
    /// 
    /// # Capacity for a stateless rule group
    /// 
    /// For a stateless rule group, the capacity required is the sum of the capacity
    /// requirements of the individual rules that you expect to have in the rule
    /// group.
    /// 
    /// To calculate the capacity requirement of a single rule, multiply the capacity
    /// requirement values of each of the rule&apos;s match settings:
    /// 
    ///   - A match setting with no criteria specified has a value of 1.
    /// 
    ///   - A match setting with Any specified has a value of 1.
    /// 
    ///   - All other match settings have a value equal to the number of elements
    ///     provided in the setting. For example, a protocol setting [&quot;UDP&quot;] and a
    ///     source setting [&quot;10.0.0.0/24&quot;] each have a value of 1. A protocol setting
    ///     [&quot;UDP&quot;,&quot;TCP&quot;] has a value of 2. A source setting [&quot;10.0.0.0/24&quot;,&quot;10.0.0.1/24&quot;,&quot;10.0.0.2/24&quot;]
    ///     has a value of 3.
    /// 
    /// A rule with no criteria specified in any of its match settings has a capacity
    /// requirement of 1. A rule with protocol setting [&quot;UDP&quot;,&quot;TCP&quot;], source setting
    /// [&quot;10.0.0.0/24&quot;,&quot;10.0.0.1/24&quot;,&quot;10.0.0.2/24&quot;], and a single specification or
    /// no specification for each of the other match settings has a capacity requirement
    /// of 6.
    /// 
    /// # Capacity for a stateful rule group
    /// 
    /// For a stateful rule group, the minimum capacity required is the number of
    /// individual rules that you expect to have in the rule group.
    /// </summary>
    [JsonPropertyName("capacity")]
    public required long Capacity { get; set; }

    /// <summary>
    /// A description of the rule group.
    /// 
    /// Regex Pattern: `^.*$`
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Indicates whether you want Network Firewall to just check the validity of
    /// the request, rather than run the request.
    /// 
    /// If set to TRUE, Network Firewall checks whether the request can run successfully,
    /// but doesn&apos;t actually make the requested changes. The call returns the value
    /// that the request would return if you ran it with dry run set to FALSE, but
    /// doesn&apos;t make additions or changes to your resources. This option allows you
    /// to make sure that you have the required permissions to run the request and
    /// that your request parameters are valid.
    /// 
    /// If set to FALSE, Network Firewall makes the requested changes to your resources.
    /// </summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>A complex type that contains settings for encryption of your rule group resources.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1alpha1RuleGroupSpecEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>
    /// An object that defines the rule group rules.
    /// 
    /// You must provide either this rule group setting or a Rules setting, but not
    /// both.
    /// </summary>
    [JsonPropertyName("ruleGroup")]
    public V1alpha1RuleGroupSpecRuleGroup? RuleGroup { get; set; }

    /// <summary>
    /// The descriptive name of the rule group. You can&apos;t change the name of a rule
    /// group after you create it.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9-]+$`
    /// </summary>
    [JsonPropertyName("ruleGroupName")]
    public required string RuleGroupName { get; set; }

    /// <summary>
    /// A string containing stateful rule group rules specifications in Suricata
    /// flat format, with one ruleper line. Use this to import your existing Suricata
    /// compatible rule groups.
    /// 
    /// You must provide either this rules setting or a populated RuleGroup setting,
    /// but not both.
    /// 
    /// You can provide your rule group specification in Suricata flat format through
    /// this setting when you create or update your rule group. The callresponse
    /// returns a RuleGroup object that Network Firewall has populated from your
    /// string.
    /// </summary>
    [JsonPropertyName("rules")]
    public string? Rules { get; set; }

    /// <summary>
    /// A complex type that contains metadata about the rule group that your own
    /// rule group is copied from. You can use the metadata to keep track of updates
    /// made to the originating rule group.
    /// </summary>
    [JsonPropertyName("sourceMetadata")]
    public V1alpha1RuleGroupSpecSourceMetadata? SourceMetadata { get; set; }

    /// <summary>The key:value pairs to associate with the resource.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1RuleGroupSpecTags>? Tags { get; set; }

    /// <summary>
    /// Indicates whether the rule group is stateless or stateful. If the rule group
    /// is stateless, it containsstateless rules. If it is stateful, it contains
    /// stateful rules.
    /// </summary>
    [JsonPropertyName("type_")]
    public required string Type { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// The analysis result for Network Firewall&apos;s stateless rule group analyzer.
/// Every time you call CreateRuleGroup, UpdateRuleGroup, or DescribeRuleGroup
/// on a stateless rule group, Network Firewall analyzes the stateless rule groups
/// in your account and identifies the rules that might adversely effect your
/// firewall&apos;s functionality. For example, if Network Firewall detects a rule
/// that&apos;s routing traffic asymmetrically, which impacts the service&apos;s ability
/// to properly process traffic, the service includes the rule in a list of analysis
/// results.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupStatusRuleGroupResponseAnalysisResults
{
    [JsonPropertyName("analysisDetail")]
    public string? AnalysisDetail { get; set; }

    [JsonPropertyName("identifiedRuleIDs")]
    public IList<string>? IdentifiedRuleIDs { get; set; }

    [JsonPropertyName("identifiedType")]
    public string? IdentifiedType { get; set; }
}

/// <summary>
/// A complex type that contains optional Amazon Web Services Key Management
/// Service (KMS) encryption settings for your Network Firewall resources. Your
/// data is encrypted by default with an Amazon Web Services owned key that Amazon
/// Web Services owns and manages for you. You can use either the Amazon Web
/// Services owned key, or provide your own customer managed key. To learn more
/// about KMS encryption of your Network Firewall resources, see Encryption at
/// rest with Amazon Web Services Key Managment Service (https://docs.aws.amazon.com/kms/latest/developerguide/kms-encryption-at-rest.html)
/// in the Network Firewall Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupStatusRuleGroupResponseEncryptionConfiguration
{
    [JsonPropertyName("keyID")]
    public string? KeyID { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// High-level information about the managed rule group that your own rule group
/// is copied from. You can use the the metadata to track version updates made
/// to the originating rule group. You can retrieve all objects for a rule group
/// by calling DescribeRuleGroup (https://docs.aws.amazon.com/network-firewall/latest/APIReference/API_DescribeRuleGroup.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupStatusRuleGroupResponseSourceMetadata
{
    [JsonPropertyName("sourceARN")]
    public string? SourceARN { get; set; }

    [JsonPropertyName("sourceUpdateToken")]
    public string? SourceUpdateToken { get; set; }
}

/// <summary>
/// A key:value pair associated with an Amazon Web Services resource. The key:value
/// pair can be anything you define. Typically, the tag key represents a category
/// (such as &quot;environment&quot;) and the tag value represents a specific value within
/// that category (such as &quot;test,&quot; &quot;development,&quot; or &quot;production&quot;). You can add
/// up to 50 tags to each Amazon Web Services resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupStatusRuleGroupResponseTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The high-level properties of a rule group. This, along with the RuleGroup,
/// define the rule group. You can retrieve all objects for a rule group by calling
/// DescribeRuleGroup.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupStatusRuleGroupResponse
{
    [JsonPropertyName("analysisResults")]
    public IList<V1alpha1RuleGroupStatusRuleGroupResponseAnalysisResults>? AnalysisResults { get; set; }

    [JsonPropertyName("capacity")]
    public long? Capacity { get; set; }

    [JsonPropertyName("consumedCapacity")]
    public long? ConsumedCapacity { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A complex type that contains optional Amazon Web Services Key Management
    /// Service (KMS) encryption settings for your Network Firewall resources. Your
    /// data is encrypted by default with an Amazon Web Services owned key that Amazon
    /// Web Services owns and manages for you. You can use either the Amazon Web
    /// Services owned key, or provide your own customer managed key. To learn more
    /// about KMS encryption of your Network Firewall resources, see Encryption at
    /// rest with Amazon Web Services Key Managment Service (https://docs.aws.amazon.com/kms/latest/developerguide/kms-encryption-at-rest.html)
    /// in the Network Firewall Developer Guide.
    /// </summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1alpha1RuleGroupStatusRuleGroupResponseEncryptionConfiguration? EncryptionConfiguration { get; set; }

    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    [JsonPropertyName("numberOfAssociations")]
    public long? NumberOfAssociations { get; set; }

    [JsonPropertyName("ruleGroupARN")]
    public string? RuleGroupARN { get; set; }

    [JsonPropertyName("ruleGroupID")]
    public string? RuleGroupID { get; set; }

    [JsonPropertyName("ruleGroupName")]
    public string? RuleGroupName { get; set; }

    [JsonPropertyName("ruleGroupStatus")]
    public string? RuleGroupStatus { get; set; }

    [JsonPropertyName("snsTopic")]
    public string? SnsTopic { get; set; }

    /// <summary>
    /// High-level information about the managed rule group that your own rule group
    /// is copied from. You can use the the metadata to track version updates made
    /// to the originating rule group. You can retrieve all objects for a rule group
    /// by calling DescribeRuleGroup (https://docs.aws.amazon.com/network-firewall/latest/APIReference/API_DescribeRuleGroup.html).
    /// </summary>
    [JsonPropertyName("sourceMetadata")]
    public V1alpha1RuleGroupStatusRuleGroupResponseSourceMetadata? SourceMetadata { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1RuleGroupStatusRuleGroupResponseTags>? Tags { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>RuleGroupStatus defines the observed state of RuleGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RuleGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1RuleGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RuleGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The high-level properties of a rule group. This, along with the RuleGroup,
    /// define the rule group. You can retrieve all objects for a rule group by calling
    /// DescribeRuleGroup.
    /// </summary>
    [JsonPropertyName("ruleGroupResponse")]
    public V1alpha1RuleGroupStatusRuleGroupResponse? RuleGroupResponse { get; set; }

    /// <summary>
    /// A token used for optimistic locking. Network Firewall returns a token to
    /// your requests that access the rule group. The token marks the state of the
    /// rule group resource at the time of the request.
    /// 
    /// To make changes to the rule group, you provide the token in your request.
    /// Network Firewall uses the token to ensure that the rule group hasn&apos;t changed
    /// since you last retrieved it. If it has changed, the operation fails with
    /// an InvalidTokenException. If this happens, retrieve the rule group again
    /// to get a current copy of it with a current token. Reapply your changes as
    /// needed, then try the operation again using the new token.
    /// 
    /// Regex Pattern: `^([0-9a-f]{8})-([0-9a-f]{4}-){3}([0-9a-f]{12})$`
    /// </summary>
    [JsonPropertyName("updateToken")]
    public string? UpdateToken { get; set; }
}

/// <summary>RuleGroup is the Schema for the RuleGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RuleGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RuleGroupSpec?>, IStatus<V1alpha1RuleGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RuleGroup";
    public const string KubeGroup = "networkfirewall.services.k8s.aws";
    public const string KubePluralName = "rulegroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkfirewall.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RuleGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// RuleGroupSpec defines the desired state of RuleGroup.
    /// 
    /// The object that defines the rules in a rule group. This, along with RuleGroupResponse,
    /// define the rule group. You can retrieve all objects for a rule group by calling
    /// DescribeRuleGroup.
    /// 
    /// Network Firewall uses a rule group to inspect and control network traffic.
    /// You define stateless rule groups to inspect individual packets and you define
    /// stateful rule groups to inspect packets in the context of their traffic flow.
    /// 
    /// To use a rule group, you include it by reference in an Network Firewall firewall
    /// policy, then you use the policy in a firewall. You can reference a rule group
    /// from more than one firewall policy, and you can use a firewall policy in
    /// more than one firewall.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1RuleGroupSpec? Spec { get; set; }

    /// <summary>RuleGroupStatus defines the observed state of RuleGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1RuleGroupStatus? Status { get; set; }
}