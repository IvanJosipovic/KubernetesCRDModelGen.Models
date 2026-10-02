#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1StagedKubernetesNetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1StagedKubernetesNetworkPolicy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedKubernetesNetworkPolicyList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagedkubernetesnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StagedKubernetesNetworkPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1StagedKubernetesNetworkPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1StagedKubernetesNetworkPolicy> Items { get; set; }
}

/// <summary>NetworkPolicyPort describes a port to allow traffic on</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressPorts
{
    /// <summary>
    /// endPort indicates that the range of ports from port to endPort if set, inclusive,
    /// should be allowed by the policy. This field cannot be defined if the port field
    /// is not defined or if the port field is defined as a named (string) port.
    /// The endPort must be equal or greater than port.
    /// </summary>
    [JsonPropertyName("endPort")]
    public int? EndPort { get; set; }

    /// <summary>
    /// port represents the port on the given protocol. This can either be a numerical or named
    /// port on a pod. If this field is not provided, this matches all port names and
    /// numbers.
    /// If present, only traffic on the specified protocol AND port will be matched.
    /// </summary>
    [JsonPropertyName("port")]
    public IntOrString? Port { get; set; }

    /// <summary>
    /// protocol represents the protocol (TCP, UDP, or SCTP) which traffic must match.
    /// If not specified, this field defaults to TCP.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// ipBlock defines policy on a particular IPBlock. If this field is set then
/// neither of the other fields can be.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToIpBlock
{
    /// <summary>
    /// cidr is a string representing the IPBlock
    /// Valid examples are &quot;192.168.1.0/24&quot; or &quot;2001:db8::/64&quot;
    /// </summary>
    [JsonPropertyName("cidr")]
    public required string Cidr { get; set; }

    /// <summary>
    /// except is a slice of CIDRs that should not be included within an IPBlock
    /// Valid examples are &quot;192.168.1.0/24&quot; or &quot;2001:db8::/64&quot;
    /// Except values will be rejected if they are outside the cidr range
    /// </summary>
    [JsonPropertyName("except")]
    public IList<string>? Except { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelectorMatchExpressions
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
/// namespaceSelector selects namespaces using cluster-scoped labels. This field follows
/// standard label selector semantics; if present but empty, it selects all namespaces.
/// 
/// If podSelector is also set, then the NetworkPolicyPeer as a whole selects
/// the pods matching podSelector in the namespaces selected by namespaceSelector.
/// Otherwise it selects all pods in the namespaces selected by namespaceSelector.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToPodSelectorMatchExpressions
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
/// podSelector is a label selector which selects pods. This field follows standard label
/// selector semantics; if present but empty, it selects all pods.
/// 
/// If namespaceSelector is also set, then the NetworkPolicyPeer as a whole selects
/// the pods matching podSelector in the Namespaces selected by NamespaceSelector.
/// Otherwise it selects the pods matching podSelector in the policy&apos;s own namespace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressToPodSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressToPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// NetworkPolicyPeer describes a peer to allow traffic to/from. Only certain combinations of
/// fields are allowed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgressTo
{
    /// <summary>
    /// ipBlock defines policy on a particular IPBlock. If this field is set then
    /// neither of the other fields can be.
    /// </summary>
    [JsonPropertyName("ipBlock")]
    public V1StagedKubernetesNetworkPolicySpecEgressToIpBlock? IpBlock { get; set; }

    /// <summary>
    /// namespaceSelector selects namespaces using cluster-scoped labels. This field follows
    /// standard label selector semantics; if present but empty, it selects all namespaces.
    /// 
    /// If podSelector is also set, then the NetworkPolicyPeer as a whole selects
    /// the pods matching podSelector in the namespaces selected by namespaceSelector.
    /// Otherwise it selects all pods in the namespaces selected by namespaceSelector.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1StagedKubernetesNetworkPolicySpecEgressToNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// podSelector is a label selector which selects pods. This field follows standard label
    /// selector semantics; if present but empty, it selects all pods.
    /// 
    /// If namespaceSelector is also set, then the NetworkPolicyPeer as a whole selects
    /// the pods matching podSelector in the Namespaces selected by NamespaceSelector.
    /// Otherwise it selects the pods matching podSelector in the policy&apos;s own namespace.
    /// </summary>
    [JsonPropertyName("podSelector")]
    public V1StagedKubernetesNetworkPolicySpecEgressToPodSelector? PodSelector { get; set; }
}

/// <summary>
/// NetworkPolicyEgressRule describes a particular set of traffic that is allowed out of pods
/// matched by a NetworkPolicySpec&apos;s podSelector. The traffic must match both ports and to.
/// This type is beta-level in 1.8
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecEgress
{
    /// <summary>
    /// ports is a list of destination ports for outgoing traffic.
    /// Each item in this list is combined using a logical OR. If this field is
    /// empty or missing, this rule matches all ports (traffic not restricted by port).
    /// If this field is present and contains at least one item, then this rule allows
    /// traffic only if the traffic matches at least one port in the list.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressPorts>? Ports { get; set; }

    /// <summary>
    /// to is a list of destinations for outgoing traffic of pods selected for this rule.
    /// Items in this list are combined using a logical OR operation. If this field is
    /// empty or missing, this rule matches all destinations (traffic not restricted by
    /// destination). If this field is present and contains at least one item, this rule
    /// allows traffic only if the traffic matches at least one item in the to list.
    /// </summary>
    [JsonPropertyName("to")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgressTo>? To { get; set; }
}

/// <summary>
/// ipBlock defines policy on a particular IPBlock. If this field is set then
/// neither of the other fields can be.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromIpBlock
{
    /// <summary>
    /// cidr is a string representing the IPBlock
    /// Valid examples are &quot;192.168.1.0/24&quot; or &quot;2001:db8::/64&quot;
    /// </summary>
    [JsonPropertyName("cidr")]
    public required string Cidr { get; set; }

    /// <summary>
    /// except is a slice of CIDRs that should not be included within an IPBlock
    /// Valid examples are &quot;192.168.1.0/24&quot; or &quot;2001:db8::/64&quot;
    /// Except values will be rejected if they are outside the cidr range
    /// </summary>
    [JsonPropertyName("except")]
    public IList<string>? Except { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelectorMatchExpressions
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
/// namespaceSelector selects namespaces using cluster-scoped labels. This field follows
/// standard label selector semantics; if present but empty, it selects all namespaces.
/// 
/// If podSelector is also set, then the NetworkPolicyPeer as a whole selects
/// the pods matching podSelector in the namespaces selected by namespaceSelector.
/// Otherwise it selects all pods in the namespaces selected by namespaceSelector.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromPodSelectorMatchExpressions
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
/// podSelector is a label selector which selects pods. This field follows standard label
/// selector semantics; if present but empty, it selects all pods.
/// 
/// If namespaceSelector is also set, then the NetworkPolicyPeer as a whole selects
/// the pods matching podSelector in the Namespaces selected by NamespaceSelector.
/// Otherwise it selects the pods matching podSelector in the policy&apos;s own namespace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFromPodSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressFromPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// NetworkPolicyPeer describes a peer to allow traffic to/from. Only certain combinations of
/// fields are allowed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressFrom
{
    /// <summary>
    /// ipBlock defines policy on a particular IPBlock. If this field is set then
    /// neither of the other fields can be.
    /// </summary>
    [JsonPropertyName("ipBlock")]
    public V1StagedKubernetesNetworkPolicySpecIngressFromIpBlock? IpBlock { get; set; }

    /// <summary>
    /// namespaceSelector selects namespaces using cluster-scoped labels. This field follows
    /// standard label selector semantics; if present but empty, it selects all namespaces.
    /// 
    /// If podSelector is also set, then the NetworkPolicyPeer as a whole selects
    /// the pods matching podSelector in the namespaces selected by namespaceSelector.
    /// Otherwise it selects all pods in the namespaces selected by namespaceSelector.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1StagedKubernetesNetworkPolicySpecIngressFromNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// podSelector is a label selector which selects pods. This field follows standard label
    /// selector semantics; if present but empty, it selects all pods.
    /// 
    /// If namespaceSelector is also set, then the NetworkPolicyPeer as a whole selects
    /// the pods matching podSelector in the Namespaces selected by NamespaceSelector.
    /// Otherwise it selects the pods matching podSelector in the policy&apos;s own namespace.
    /// </summary>
    [JsonPropertyName("podSelector")]
    public V1StagedKubernetesNetworkPolicySpecIngressFromPodSelector? PodSelector { get; set; }
}

/// <summary>NetworkPolicyPort describes a port to allow traffic on</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngressPorts
{
    /// <summary>
    /// endPort indicates that the range of ports from port to endPort if set, inclusive,
    /// should be allowed by the policy. This field cannot be defined if the port field
    /// is not defined or if the port field is defined as a named (string) port.
    /// The endPort must be equal or greater than port.
    /// </summary>
    [JsonPropertyName("endPort")]
    public int? EndPort { get; set; }

    /// <summary>
    /// port represents the port on the given protocol. This can either be a numerical or named
    /// port on a pod. If this field is not provided, this matches all port names and
    /// numbers.
    /// If present, only traffic on the specified protocol AND port will be matched.
    /// </summary>
    [JsonPropertyName("port")]
    public IntOrString? Port { get; set; }

    /// <summary>
    /// protocol represents the protocol (TCP, UDP, or SCTP) which traffic must match.
    /// If not specified, this field defaults to TCP.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// NetworkPolicyIngressRule describes a particular set of traffic that is allowed to the pods
/// matched by a NetworkPolicySpec&apos;s podSelector. The traffic must match both ports and from.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecIngress
{
    /// <summary>
    /// from is a list of sources which should be able to access the pods selected for this rule.
    /// Items in this list are combined using a logical OR operation. If this field is
    /// empty or missing, this rule matches all sources (traffic not restricted by
    /// source). If this field is present and contains at least one item, this rule
    /// allows traffic only if the traffic matches at least one item in the from list.
    /// </summary>
    [JsonPropertyName("from")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressFrom>? From { get; set; }

    /// <summary>
    /// ports is a list of ports which should be made accessible on the pods selected for
    /// this rule. Each item in this list is combined using a logical OR. If this field is
    /// empty or missing, this rule matches all ports (traffic not restricted by port).
    /// If this field is present and contains at least one item, then this rule allows
    /// traffic only if the traffic matches at least one port in the list.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngressPorts>? Ports { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecPodSelectorMatchExpressions
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
/// Selects the pods to which this NetworkPolicy object applies. The array of
/// ingress rules is applied to any pods selected by this field. Multiple network
/// policies can select the same set of pods. In this case, the ingress rules for
/// each are combined additively. This field is NOT optional and follows standard
/// label selector semantics. An empty podSelector matches all pods in this
/// namespace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpecPodSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1StagedKubernetesNetworkPolicySpecPodSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>The staged action. If this is omitted, the default is Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedKubernetesNetworkPolicySpecStagedActionEnum>))]
public enum V1StagedKubernetesNetworkPolicySpecStagedActionEnum
{
    [EnumMember(Value = "Set"), JsonStringEnumMemberName("Set")]
    Set,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Learn"), JsonStringEnumMemberName("Learn")]
    Learn,
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedKubernetesNetworkPolicySpec
{
    /// <summary>
    /// List of egress rules to be applied to the selected pods. Outgoing traffic is
    /// allowed if there are no NetworkPolicies selecting the pod (and cluster policy
    /// otherwise allows the traffic), OR if the traffic matches at least one egress rule
    /// across all of the NetworkPolicy objects whose podSelector matches the pod. If
    /// this field is empty then this NetworkPolicy limits all outgoing traffic (and serves
    /// solely to ensure that the pods it selects are isolated by default).
    /// This field is beta-level in 1.8
    /// </summary>
    [JsonPropertyName("egress")]
    public IList<V1StagedKubernetesNetworkPolicySpecEgress>? Egress { get; set; }

    /// <summary>
    /// List of ingress rules to be applied to the selected pods. Traffic is allowed to
    /// a pod if there are no NetworkPolicies selecting the pod
    /// (and cluster policy otherwise allows the traffic), OR if the traffic source is
    /// the pod&apos;s local node, OR if the traffic matches at least one ingress rule
    /// across all of the NetworkPolicy objects whose podSelector matches the pod. If
    /// this field is empty then this NetworkPolicy does not allow any traffic (and serves
    /// solely to ensure that the pods it selects are isolated by default)
    /// </summary>
    [JsonPropertyName("ingress")]
    public IList<V1StagedKubernetesNetworkPolicySpecIngress>? Ingress { get; set; }

    /// <summary>
    /// Selects the pods to which this NetworkPolicy object applies. The array of
    /// ingress rules is applied to any pods selected by this field. Multiple network
    /// policies can select the same set of pods. In this case, the ingress rules for
    /// each are combined additively. This field is NOT optional and follows standard
    /// label selector semantics. An empty podSelector matches all pods in this
    /// namespace.
    /// </summary>
    [JsonPropertyName("podSelector")]
    public V1StagedKubernetesNetworkPolicySpecPodSelector? PodSelector { get; set; }

    /// <summary>
    /// List of rule types that the NetworkPolicy relates to.
    /// Valid options are Ingress, Egress, or Ingress,Egress.
    /// If this field is not specified, it will default based on the existence of Ingress or Egress rules;
    /// policies that contain an Egress section are assumed to affect Egress, and all policies
    /// (whether or not they contain an Ingress section) are assumed to affect Ingress.
    /// If you want to write an egress-only policy, you must explicitly specify policyTypes [ &quot;Egress&quot; ].
    /// Likewise, if you want to write a policy that specifies that no egress is allowed,
    /// you must specify a policyTypes value that include &quot;Egress&quot; (since such a policy would not include
    /// an Egress section and would otherwise default to just [ &quot;Ingress&quot; ]).
    /// This field is beta-level in 1.8
    /// </summary>
    [JsonPropertyName("policyTypes")]
    public IList<string>? PolicyTypes { get; set; }

    /// <summary>The staged action. If this is omitted, the default is Set.</summary>
    [JsonPropertyName("stagedAction")]
    public V1StagedKubernetesNetworkPolicySpecStagedActionEnum? StagedAction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1StagedKubernetesNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1StagedKubernetesNetworkPolicySpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedKubernetesNetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagedkubernetesnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StagedKubernetesNetworkPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1StagedKubernetesNetworkPolicySpec? Spec { get; set; }
}