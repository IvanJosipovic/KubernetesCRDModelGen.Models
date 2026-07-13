#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.policy.networking.k8s.io;
/// <summary>ClusterNetworkPolicy is a cluster-wide network policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha2ClusterNetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha2ClusterNetworkPolicy>
{
    public const string KubeApiVersion = "v1alpha2";
    public const string KubeKind = "ClusterNetworkPolicyList";
    public const string KubeGroup = "policy.networking.k8s.io";
    public const string KubePluralName = "clusternetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policy.networking.k8s.io/v1alpha2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterNetworkPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha2ClusterNetworkPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha2ClusterNetworkPolicy> Items { get; set; }
}

/// <summary>
/// Action specifies the effect this rule will have on matching
/// traffic.  Currently the following actions are supported:
/// 
/// - Accept: Accepts the selected traffic, allowing it to
///   egress. No further ClusterNetworkPolicy or NetworkPolicy
///   rules will be processed.
/// 
/// - Deny: Drops the selected traffic. No further
///   ClusterNetworkPolicy or NetworkPolicy rules will be
///   processed.
/// 
/// - Pass: Skips all further ClusterNetworkPolicy rules in the
///   current tier for the selected traffic, and passes
///   evaluation to the next tier.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2ClusterNetworkPolicySpecEgressActionEnum>))]
public enum V1alpha2ClusterNetworkPolicySpecEgressActionEnum
{
    [EnumMember(Value = "Accept"), JsonStringEnumMemberName("Accept")]
    Accept,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Pass"), JsonStringEnumMemberName("Pass")]
    Pass
}

/// <summary>Range defines a contiguous range of ports.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressProtocolsSctpDestinationPortRange
{
    /// <summary>
    /// end specifies the last port in the range. It must be
    /// greater than start.
    /// </summary>
    [JsonPropertyName("end")]
    public required int End { get; set; }

    /// <summary>
    /// start defines a network port that is the start of a port
    /// range, the Start value must be less than End.
    /// </summary>
    [JsonPropertyName("start")]
    public required int Start { get; set; }
}

/// <summary>DestinationPort for the match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressProtocolsSctpDestinationPort
{
    /// <summary>Number defines a network port value.</summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }

    /// <summary>Range defines a contiguous range of ports.</summary>
    [JsonPropertyName("range")]
    public V1alpha2ClusterNetworkPolicySpecEgressProtocolsSctpDestinationPortRange? Range { get; set; }
}

/// <summary>SCTP specific protocol matches.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressProtocolsSctp
{
    /// <summary>DestinationPort for the match.</summary>
    [JsonPropertyName("destinationPort")]
    public V1alpha2ClusterNetworkPolicySpecEgressProtocolsSctpDestinationPort? DestinationPort { get; set; }
}

/// <summary>Range defines a contiguous range of ports.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressProtocolsTcpDestinationPortRange
{
    /// <summary>
    /// end specifies the last port in the range. It must be
    /// greater than start.
    /// </summary>
    [JsonPropertyName("end")]
    public required int End { get; set; }

    /// <summary>
    /// start defines a network port that is the start of a port
    /// range, the Start value must be less than End.
    /// </summary>
    [JsonPropertyName("start")]
    public required int Start { get; set; }
}

/// <summary>DestinationPort for the match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressProtocolsTcpDestinationPort
{
    /// <summary>Number defines a network port value.</summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }

    /// <summary>Range defines a contiguous range of ports.</summary>
    [JsonPropertyName("range")]
    public V1alpha2ClusterNetworkPolicySpecEgressProtocolsTcpDestinationPortRange? Range { get; set; }
}

/// <summary>TCP specific protocol matches.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressProtocolsTcp
{
    /// <summary>DestinationPort for the match.</summary>
    [JsonPropertyName("destinationPort")]
    public V1alpha2ClusterNetworkPolicySpecEgressProtocolsTcpDestinationPort? DestinationPort { get; set; }
}

/// <summary>Range defines a contiguous range of ports.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressProtocolsUdpDestinationPortRange
{
    /// <summary>
    /// end specifies the last port in the range. It must be
    /// greater than start.
    /// </summary>
    [JsonPropertyName("end")]
    public required int End { get; set; }

    /// <summary>
    /// start defines a network port that is the start of a port
    /// range, the Start value must be less than End.
    /// </summary>
    [JsonPropertyName("start")]
    public required int Start { get; set; }
}

/// <summary>DestinationPort for the match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressProtocolsUdpDestinationPort
{
    /// <summary>Number defines a network port value.</summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }

    /// <summary>Range defines a contiguous range of ports.</summary>
    [JsonPropertyName("range")]
    public V1alpha2ClusterNetworkPolicySpecEgressProtocolsUdpDestinationPortRange? Range { get; set; }
}

/// <summary>UDP specific protocol matches.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressProtocolsUdp
{
    /// <summary>DestinationPort for the match.</summary>
    [JsonPropertyName("destinationPort")]
    public V1alpha2ClusterNetworkPolicySpecEgressProtocolsUdpDestinationPort? DestinationPort { get; set; }
}

/// <summary>
/// ClusterNetworkPolicyProtocol describes additional protocol-specific match rules.
/// Exactly one field must be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressProtocols
{
    /// <summary>
    /// DestinationNamedPort selects a destination port on a pod based on the
    /// ContainerPort name. You can&apos;t use this in a rule that targets resources
    /// without named ports (e.g. Nodes or Networks).
    /// </summary>
    [JsonPropertyName("destinationNamedPort")]
    public string? DestinationNamedPort { get; set; }

    /// <summary>SCTP specific protocol matches.</summary>
    [JsonPropertyName("sctp")]
    public V1alpha2ClusterNetworkPolicySpecEgressProtocolsSctp? Sctp { get; set; }

    /// <summary>TCP specific protocol matches.</summary>
    [JsonPropertyName("tcp")]
    public V1alpha2ClusterNetworkPolicySpecEgressProtocolsTcp? Tcp { get; set; }

    /// <summary>UDP specific protocol matches.</summary>
    [JsonPropertyName("udp")]
    public V1alpha2ClusterNetworkPolicySpecEgressProtocolsUdp? Udp { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressToNamespacesMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Namespaces defines a way to select all pods within a set of Namespaces.
/// Note that host-networked pods are not included in this type of peer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressToNamespaces
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha2ClusterNetworkPolicySpecEgressToNamespacesMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressToPodsNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector follows standard label selector
/// semantics; if empty, it selects all Namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressToPodsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha2ClusterNetworkPolicySpecEgressToPodsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressToPodsPodSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// PodSelector is used to explicitly select pods within a namespace;
/// if empty, it selects all Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressToPodsPodSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha2ClusterNetworkPolicySpecEgressToPodsPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Pods defines a way to select a set of pods in
/// a set of namespaces. Note that host-networked pods
/// are not included in this type of peer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressToPods
{
    /// <summary>
    /// NamespaceSelector follows standard label selector
    /// semantics; if empty, it selects all Namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha2ClusterNetworkPolicySpecEgressToPodsNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// PodSelector is used to explicitly select pods within a namespace;
    /// if empty, it selects all Pods.
    /// </summary>
    [JsonPropertyName("podSelector")]
    public required V1alpha2ClusterNetworkPolicySpecEgressToPodsPodSelector PodSelector { get; set; }
}

/// <summary>
/// ClusterNetworkPolicyEgressPeer defines a peer to allow traffic to.
/// 
/// Exactly one of the fields must be set for a given peer and this is enforced
/// by the validation rules on the CRD. If an implementation sees no fields are
/// set then it can infer that the deployed CRD is of an incompatible version
/// with an unknown field.  In that case it should fail closed.
/// 
/// For &quot;Accept&quot; rules, &quot;fail closed&quot; means: &quot;treat the rule as matching no
/// traffic&quot;. For &quot;Deny&quot; and &quot;Pass&quot; rules, &quot;fail closed&quot; means: &quot;treat the rule
/// as a &apos;Deny all&apos; rule&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgressTo
{
    /// <summary>
    /// Namespaces defines a way to select all pods within a set of Namespaces.
    /// Note that host-networked pods are not included in this type of peer.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public V1alpha2ClusterNetworkPolicySpecEgressToNamespaces? Namespaces { get; set; }

    /// <summary>
    /// Networks defines a way to select peers via CIDR blocks.
    /// This is intended for representing entities that live outside the cluster,
    /// which can&apos;t be selected by pods, namespaces and nodes peers, but note
    /// that cluster-internal traffic will be checked against the rule as
    /// well. So if you Accept or Deny traffic to `&quot;0.0.0.0/0&quot;`, that will allow
    /// or deny all IPv4 pod-to-pod traffic as well. If you don&apos;t want that,
    /// add a rule that Passes all pod traffic before the Networks rule.
    /// 
    /// Each item in Networks should be provided in the CIDR format and should be
    /// IPv4 or IPv6, for example &quot;10.0.0.0/8&quot; or &quot;fd00::/8&quot;.
    /// 
    /// Networks can have up to 25 CIDRs specified.
    /// </summary>
    [JsonPropertyName("networks")]
    public IList<string>? Networks { get; set; }

    /// <summary>
    /// Pods defines a way to select a set of pods in
    /// a set of namespaces. Note that host-networked pods
    /// are not included in this type of peer.
    /// </summary>
    [JsonPropertyName("pods")]
    public V1alpha2ClusterNetworkPolicySpecEgressToPods? Pods { get; set; }
}

/// <summary>
/// ClusterNetworkPolicyEgressRule describes an action to take on a particular
/// set of traffic originating from pods selected by a ClusterNetworkPolicy&apos;s
/// Subject field.
/// 
/// &lt;network-policy-api:experimental:validation&gt;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecEgress
{
    /// <summary>
    /// Action specifies the effect this rule will have on matching
    /// traffic.  Currently the following actions are supported:
    /// 
    /// - Accept: Accepts the selected traffic, allowing it to
    ///   egress. No further ClusterNetworkPolicy or NetworkPolicy
    ///   rules will be processed.
    /// 
    /// - Deny: Drops the selected traffic. No further
    ///   ClusterNetworkPolicy or NetworkPolicy rules will be
    ///   processed.
    /// 
    /// - Pass: Skips all further ClusterNetworkPolicy rules in the
    ///   current tier for the selected traffic, and passes
    ///   evaluation to the next tier.
    /// </summary>
    [JsonPropertyName("action")]
    public required V1alpha2ClusterNetworkPolicySpecEgressActionEnum Action { get; set; }

    /// <summary>
    /// Name is an identifier for this rule, that may be no more than
    /// 100 characters in length. This field should be used by the implementation
    /// to help improve observability, readability and error-reporting
    /// for any applied policies.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Protocols allows for more fine-grain matching of traffic on
    /// protocol-specific attributes such as the port. If
    /// unspecified, protocol-specific attributes will not be used
    /// to match traffic.
    /// </summary>
    [JsonPropertyName("protocols")]
    public IList<V1alpha2ClusterNetworkPolicySpecEgressProtocols>? Protocols { get; set; }

    /// <summary>
    /// To is the list of destinations whose traffic this rule applies to. If any
    /// element matches the destination of outgoing traffic then the specified
    /// action is applied. This field must be defined and contain at least one
    /// item.
    /// </summary>
    [JsonPropertyName("to")]
    public required IList<V1alpha2ClusterNetworkPolicySpecEgressTo> To { get; set; }
}

/// <summary>
/// Action specifies the effect this rule will have on matching
/// traffic. Currently the following actions are supported:
/// 
/// - Accept: Accepts the selected traffic, allowing it into
///   the destination. No further ClusterNetworkPolicy or
///   NetworkPolicy rules will be processed.
/// 
///   Note: while Accept ensures traffic is accepted by
///   Kubernetes network policy, it is still possible that the
///   packet is blocked in other ways: custom nftable rules,
///   high-layers e.g. service mesh.
/// 
/// - Deny: Drops the selected traffic. No further
///   ClusterNetworkPolicy or NetworkPolicy rules will be
///   processed.
/// 
/// - Pass: Skips all further ClusterNetworkPolicy rules in the
///   current tier for the selected traffic, and passes
///   evaluation to the next tier.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2ClusterNetworkPolicySpecIngressActionEnum>))]
public enum V1alpha2ClusterNetworkPolicySpecIngressActionEnum
{
    [EnumMember(Value = "Accept"), JsonStringEnumMemberName("Accept")]
    Accept,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Pass"), JsonStringEnumMemberName("Pass")]
    Pass
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressFromNamespacesMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Namespaces defines a way to select all pods within a set of Namespaces.
/// Note that host-networked pods are not included in this type of peer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressFromNamespaces
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha2ClusterNetworkPolicySpecIngressFromNamespacesMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressFromPodsNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector follows standard label selector
/// semantics; if empty, it selects all Namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressFromPodsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha2ClusterNetworkPolicySpecIngressFromPodsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressFromPodsPodSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// PodSelector is used to explicitly select pods within a namespace;
/// if empty, it selects all Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressFromPodsPodSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha2ClusterNetworkPolicySpecIngressFromPodsPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Pods defines a way to select a set of pods in
/// a set of namespaces. Note that host-networked pods
/// are not included in this type of peer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressFromPods
{
    /// <summary>
    /// NamespaceSelector follows standard label selector
    /// semantics; if empty, it selects all Namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha2ClusterNetworkPolicySpecIngressFromPodsNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// PodSelector is used to explicitly select pods within a namespace;
    /// if empty, it selects all Pods.
    /// </summary>
    [JsonPropertyName("podSelector")]
    public required V1alpha2ClusterNetworkPolicySpecIngressFromPodsPodSelector PodSelector { get; set; }
}

/// <summary>
/// ClusterNetworkPolicyIngressPeer defines a peer to allow traffic from.
/// 
/// Exactly one of the fields must be set for a given peer and this is enforced
/// by the validation rules on the CRD. If an implementation sees no fields are
/// set then it can infer that the deployed CRD is of an incompatible version
/// with an unknown field.  In that case it should fail closed.
/// 
/// For &quot;Accept&quot; rules, &quot;fail closed&quot; means: &quot;treat the rule as matching no
/// traffic&quot;. For &quot;Deny&quot; and &quot;Pass&quot; rules, &quot;fail closed&quot; means: &quot;treat the rule
/// as a &apos;Deny all&apos; rule&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressFrom
{
    /// <summary>
    /// Namespaces defines a way to select all pods within a set of Namespaces.
    /// Note that host-networked pods are not included in this type of peer.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public V1alpha2ClusterNetworkPolicySpecIngressFromNamespaces? Namespaces { get; set; }

    /// <summary>
    /// Pods defines a way to select a set of pods in
    /// a set of namespaces. Note that host-networked pods
    /// are not included in this type of peer.
    /// </summary>
    [JsonPropertyName("pods")]
    public V1alpha2ClusterNetworkPolicySpecIngressFromPods? Pods { get; set; }
}

/// <summary>Range defines a contiguous range of ports.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressProtocolsSctpDestinationPortRange
{
    /// <summary>
    /// end specifies the last port in the range. It must be
    /// greater than start.
    /// </summary>
    [JsonPropertyName("end")]
    public required int End { get; set; }

    /// <summary>
    /// start defines a network port that is the start of a port
    /// range, the Start value must be less than End.
    /// </summary>
    [JsonPropertyName("start")]
    public required int Start { get; set; }
}

/// <summary>DestinationPort for the match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressProtocolsSctpDestinationPort
{
    /// <summary>Number defines a network port value.</summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }

    /// <summary>Range defines a contiguous range of ports.</summary>
    [JsonPropertyName("range")]
    public V1alpha2ClusterNetworkPolicySpecIngressProtocolsSctpDestinationPortRange? Range { get; set; }
}

/// <summary>SCTP specific protocol matches.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressProtocolsSctp
{
    /// <summary>DestinationPort for the match.</summary>
    [JsonPropertyName("destinationPort")]
    public V1alpha2ClusterNetworkPolicySpecIngressProtocolsSctpDestinationPort? DestinationPort { get; set; }
}

/// <summary>Range defines a contiguous range of ports.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressProtocolsTcpDestinationPortRange
{
    /// <summary>
    /// end specifies the last port in the range. It must be
    /// greater than start.
    /// </summary>
    [JsonPropertyName("end")]
    public required int End { get; set; }

    /// <summary>
    /// start defines a network port that is the start of a port
    /// range, the Start value must be less than End.
    /// </summary>
    [JsonPropertyName("start")]
    public required int Start { get; set; }
}

/// <summary>DestinationPort for the match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressProtocolsTcpDestinationPort
{
    /// <summary>Number defines a network port value.</summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }

    /// <summary>Range defines a contiguous range of ports.</summary>
    [JsonPropertyName("range")]
    public V1alpha2ClusterNetworkPolicySpecIngressProtocolsTcpDestinationPortRange? Range { get; set; }
}

/// <summary>TCP specific protocol matches.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressProtocolsTcp
{
    /// <summary>DestinationPort for the match.</summary>
    [JsonPropertyName("destinationPort")]
    public V1alpha2ClusterNetworkPolicySpecIngressProtocolsTcpDestinationPort? DestinationPort { get; set; }
}

/// <summary>Range defines a contiguous range of ports.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressProtocolsUdpDestinationPortRange
{
    /// <summary>
    /// end specifies the last port in the range. It must be
    /// greater than start.
    /// </summary>
    [JsonPropertyName("end")]
    public required int End { get; set; }

    /// <summary>
    /// start defines a network port that is the start of a port
    /// range, the Start value must be less than End.
    /// </summary>
    [JsonPropertyName("start")]
    public required int Start { get; set; }
}

/// <summary>DestinationPort for the match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressProtocolsUdpDestinationPort
{
    /// <summary>Number defines a network port value.</summary>
    [JsonPropertyName("number")]
    public int? Number { get; set; }

    /// <summary>Range defines a contiguous range of ports.</summary>
    [JsonPropertyName("range")]
    public V1alpha2ClusterNetworkPolicySpecIngressProtocolsUdpDestinationPortRange? Range { get; set; }
}

/// <summary>UDP specific protocol matches.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressProtocolsUdp
{
    /// <summary>DestinationPort for the match.</summary>
    [JsonPropertyName("destinationPort")]
    public V1alpha2ClusterNetworkPolicySpecIngressProtocolsUdpDestinationPort? DestinationPort { get; set; }
}

/// <summary>
/// ClusterNetworkPolicyProtocol describes additional protocol-specific match rules.
/// Exactly one field must be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngressProtocols
{
    /// <summary>
    /// DestinationNamedPort selects a destination port on a pod based on the
    /// ContainerPort name. You can&apos;t use this in a rule that targets resources
    /// without named ports (e.g. Nodes or Networks).
    /// </summary>
    [JsonPropertyName("destinationNamedPort")]
    public string? DestinationNamedPort { get; set; }

    /// <summary>SCTP specific protocol matches.</summary>
    [JsonPropertyName("sctp")]
    public V1alpha2ClusterNetworkPolicySpecIngressProtocolsSctp? Sctp { get; set; }

    /// <summary>TCP specific protocol matches.</summary>
    [JsonPropertyName("tcp")]
    public V1alpha2ClusterNetworkPolicySpecIngressProtocolsTcp? Tcp { get; set; }

    /// <summary>UDP specific protocol matches.</summary>
    [JsonPropertyName("udp")]
    public V1alpha2ClusterNetworkPolicySpecIngressProtocolsUdp? Udp { get; set; }
}

/// <summary>
/// ClusterNetworkPolicyIngressRule describes an action to take on a particular
/// set of traffic destined for pods selected by a ClusterNetworkPolicy&apos;s
/// Subject field.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecIngress
{
    /// <summary>
    /// Action specifies the effect this rule will have on matching
    /// traffic. Currently the following actions are supported:
    /// 
    /// - Accept: Accepts the selected traffic, allowing it into
    ///   the destination. No further ClusterNetworkPolicy or
    ///   NetworkPolicy rules will be processed.
    /// 
    ///   Note: while Accept ensures traffic is accepted by
    ///   Kubernetes network policy, it is still possible that the
    ///   packet is blocked in other ways: custom nftable rules,
    ///   high-layers e.g. service mesh.
    /// 
    /// - Deny: Drops the selected traffic. No further
    ///   ClusterNetworkPolicy or NetworkPolicy rules will be
    ///   processed.
    /// 
    /// - Pass: Skips all further ClusterNetworkPolicy rules in the
    ///   current tier for the selected traffic, and passes
    ///   evaluation to the next tier.
    /// </summary>
    [JsonPropertyName("action")]
    public required V1alpha2ClusterNetworkPolicySpecIngressActionEnum Action { get; set; }

    /// <summary>
    /// From is the list of sources whose traffic this rule applies to.
    /// If any element matches the source of incoming
    /// traffic then the specified action is applied.
    /// This field must be defined and contain at least one item.
    /// </summary>
    [JsonPropertyName("from")]
    public required IList<V1alpha2ClusterNetworkPolicySpecIngressFrom> From { get; set; }

    /// <summary>
    /// Name is an identifier for this rule, that may be no more than
    /// 100 characters in length. This field should be used by the implementation
    /// to help improve observability, readability and error-reporting
    /// for any applied policies.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Protocols allows for more fine-grain matching of traffic on
    /// protocol-specific attributes such as the port. If
    /// unspecified, protocol-specific attributes will not be used
    /// to match traffic.
    /// </summary>
    [JsonPropertyName("protocols")]
    public IList<V1alpha2ClusterNetworkPolicySpecIngressProtocols>? Protocols { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecSubjectNamespacesMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Namespaces is used to select pods via namespace selectors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecSubjectNamespaces
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha2ClusterNetworkPolicySpecSubjectNamespacesMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecSubjectPodsNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector follows standard label selector
/// semantics; if empty, it selects all Namespaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecSubjectPodsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha2ClusterNetworkPolicySpecSubjectPodsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecSubjectPodsPodSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// PodSelector is used to explicitly select pods within a namespace;
/// if empty, it selects all Pods.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecSubjectPodsPodSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1alpha2ClusterNetworkPolicySpecSubjectPodsPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Pods is used to select pods via namespace AND pod selectors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecSubjectPods
{
    /// <summary>
    /// NamespaceSelector follows standard label selector
    /// semantics; if empty, it selects all Namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1alpha2ClusterNetworkPolicySpecSubjectPodsNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// PodSelector is used to explicitly select pods within a namespace;
    /// if empty, it selects all Pods.
    /// </summary>
    [JsonPropertyName("podSelector")]
    public required V1alpha2ClusterNetworkPolicySpecSubjectPodsPodSelector PodSelector { get; set; }
}

/// <summary>Subject defines the pods to which this ClusterNetworkPolicy applies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpecSubject
{
    /// <summary>Namespaces is used to select pods via namespace selectors.</summary>
    [JsonPropertyName("namespaces")]
    public V1alpha2ClusterNetworkPolicySpecSubjectNamespaces? Namespaces { get; set; }

    /// <summary>Pods is used to select pods via namespace AND pod selectors.</summary>
    [JsonPropertyName("pods")]
    public V1alpha2ClusterNetworkPolicySpecSubjectPods? Pods { get; set; }
}

/// <summary>
/// Tier is used as the top-level grouping for network policy prioritization.
/// 
/// Policy tiers are evaluated in the following order:
/// * Admin tier
/// * NetworkPolicy tier
/// * Baseline tier
/// 
/// ClusterNetworkPolicy can use 2 of these tiers: Admin and Baseline.
/// 
/// The Admin tier takes precedence over all other policies. Policies
/// defined in this tier are used to set cluster-wide security rules
/// that cannot be overridden in the other tiers. If Admin tier has
/// made a final decision (Accept or Deny) on a connection, then no
/// further evaluation is done.
/// 
/// NetworkPolicy tier is the tier for the namespaced v1.NetworkPolicy.
/// These policies are intended for the application developer to describe
/// the security policy associated with their deployments inside their
/// namespace. v1.NetworkPolicy always makes a final decision for selected
/// pods. Further evaluation only happens for Pods not selected by a
/// v1.NetworkPolicy.
/// 
/// Baseline tier is a cluster-wide policy that can be overridden by the
/// v1.NetworkPolicy. If Baseline tier has made a final decision (Accept or
/// Deny) on a connection, then no further evaluation is done.
/// 
/// If a given connection wasn&apos;t allowed or denied by any of the tiers,
/// the default kubernetes policy is applied, which says that
/// all pods can communicate with each other.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2ClusterNetworkPolicySpecTierEnum>))]
public enum V1alpha2ClusterNetworkPolicySpecTierEnum
{
    [EnumMember(Value = "Admin"), JsonStringEnumMemberName("Admin")]
    Admin,
    [EnumMember(Value = "Baseline"), JsonStringEnumMemberName("Baseline")]
    Baseline
}

/// <summary>Spec defines the desired behavior of ClusterNetworkPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicySpec
{
    /// <summary>
    /// Egress is the list of Egress rules to be applied to the selected pods.
    /// 
    /// A maximum of 25 rules is allowed in this block.
    /// 
    /// The relative precedence of egress rules within a single CNP object
    /// (all of which share the priority) will be determined by the order
    /// in which the rule is written.
    /// Thus, a rule that appears at the top of the egress rules
    /// would take the highest precedence.
    /// CNPs with no egress rules do not affect egress traffic.
    /// </summary>
    [JsonPropertyName("egress")]
    public IList<V1alpha2ClusterNetworkPolicySpecEgress>? Egress { get; set; }

    /// <summary>
    /// Ingress is the list of Ingress rules to be applied to the selected pods.
    /// 
    /// A maximum of 25 rules is allowed in this block.
    /// 
    /// The relative precedence of ingress rules within a single CNP object
    /// (all of which share the priority) will be determined by the order
    /// in which the rule is written.
    /// Thus, a rule that appears at the top of the ingress rules
    /// would take the highest precedence.
    /// CNPs with no ingress rules do not affect ingress traffic.
    /// </summary>
    [JsonPropertyName("ingress")]
    public IList<V1alpha2ClusterNetworkPolicySpecIngress>? Ingress { get; set; }

    /// <summary>
    /// Priority is a value from 0 to 1000 indicating the precedence of
    /// the policy within its tier. Policies with lower priority values have
    /// higher precedence, and are checked before policies with higher priority
    /// values in the same tier. All Admin tier rules have higher precedence than
    /// NetworkPolicy or Baseline tier rules.
    /// If two (or more) policies in the same tier with the same priority
    /// could match a connection, then the implementation can apply any of the
    /// matching policies to the connection, and there is no way for the user to
    /// reliably determine which one it will choose. Administrators must be
    /// careful about assigning the priorities for policies with rules that will
    /// match many connections, and ensure that policies have unique priority
    /// values in cases where ambiguity would be unacceptable.
    /// </summary>
    [JsonPropertyName("priority")]
    public required int Priority { get; set; }

    /// <summary>Subject defines the pods to which this ClusterNetworkPolicy applies.</summary>
    [JsonPropertyName("subject")]
    public required V1alpha2ClusterNetworkPolicySpecSubject Subject { get; set; }

    /// <summary>
    /// Tier is used as the top-level grouping for network policy prioritization.
    /// 
    /// Policy tiers are evaluated in the following order:
    /// * Admin tier
    /// * NetworkPolicy tier
    /// * Baseline tier
    /// 
    /// ClusterNetworkPolicy can use 2 of these tiers: Admin and Baseline.
    /// 
    /// The Admin tier takes precedence over all other policies. Policies
    /// defined in this tier are used to set cluster-wide security rules
    /// that cannot be overridden in the other tiers. If Admin tier has
    /// made a final decision (Accept or Deny) on a connection, then no
    /// further evaluation is done.
    /// 
    /// NetworkPolicy tier is the tier for the namespaced v1.NetworkPolicy.
    /// These policies are intended for the application developer to describe
    /// the security policy associated with their deployments inside their
    /// namespace. v1.NetworkPolicy always makes a final decision for selected
    /// pods. Further evaluation only happens for Pods not selected by a
    /// v1.NetworkPolicy.
    /// 
    /// Baseline tier is a cluster-wide policy that can be overridden by the
    /// v1.NetworkPolicy. If Baseline tier has made a final decision (Accept or
    /// Deny) on a connection, then no further evaluation is done.
    /// 
    /// If a given connection wasn&apos;t allowed or denied by any of the tiers,
    /// the default kubernetes policy is applied, which says that
    /// all pods can communicate with each other.
    /// </summary>
    [JsonPropertyName("tier")]
    public required V1alpha2ClusterNetworkPolicySpecTierEnum Tier { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha2ClusterNetworkPolicyStatusConditionsStatusEnum>))]
public enum V1alpha2ClusterNetworkPolicyStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicyStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1alpha2ClusterNetworkPolicyStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Status is the status to be reported by the implementation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha2ClusterNetworkPolicyStatus
{
    [JsonPropertyName("conditions")]
    public required IList<V1alpha2ClusterNetworkPolicyStatusConditions> Conditions { get; set; }
}

/// <summary>ClusterNetworkPolicy is a cluster-wide network policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha2ClusterNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha2ClusterNetworkPolicySpec>, IStatus<V1alpha2ClusterNetworkPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha2";
    public const string KubeKind = "ClusterNetworkPolicy";
    public const string KubeGroup = "policy.networking.k8s.io";
    public const string KubePluralName = "clusternetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policy.networking.k8s.io/v1alpha2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterNetworkPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired behavior of ClusterNetworkPolicy.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha2ClusterNetworkPolicySpec Spec { get; set; }

    /// <summary>Status is the status to be reported by the implementation.</summary>
    [JsonPropertyName("status")]
    public V1alpha2ClusterNetworkPolicyStatus? Status { get; set; }
}