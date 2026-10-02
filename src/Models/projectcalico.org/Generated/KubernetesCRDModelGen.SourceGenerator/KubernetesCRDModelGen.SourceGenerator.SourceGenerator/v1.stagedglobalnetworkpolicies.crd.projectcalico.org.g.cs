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
public partial class V1StagedGlobalNetworkPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1StagedGlobalNetworkPolicy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedGlobalNetworkPolicyList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagedglobalnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StagedGlobalNetworkPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1StagedGlobalNetworkPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1StagedGlobalNetworkPolicy> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedGlobalNetworkPolicySpecEgressActionEnum>))]
public enum V1StagedGlobalNetworkPolicySpecEgressActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log,
    [EnumMember(Value = "Pass"), JsonStringEnumMemberName("Pass")]
    Pass
}

/// <summary>
/// ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or
/// terminates at) a pod running as a matching service account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressDestinationServiceAccounts
{
    /// <summary>
    /// Names is an optional field that restricts the rule to only apply to traffic that originates from (or terminates
    /// at) a pod running as a service account whose name is in the list.
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// Selector is an optional field that restricts the rule to only apply to traffic that originates from
    /// (or terminates at) a pod running as a service account that matches the given label selector.
    /// If both Names and Selector are specified then they are AND&apos;ed.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary>
/// Services is an optional field that contains options for matching Kubernetes Services.
/// If specified, only traffic that originates from or terminates at endpoints within the selected
/// service(s) will be matched, and only to/from each endpoint&apos;s port.
/// 
/// Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets,
/// NotNets or ServiceAccounts.
/// 
/// Ports and NotPorts can only be specified with Services on ingress rules.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressDestinationServices
{
    /// <summary>Name specifies the name of a Kubernetes Service to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace specifies the namespace of the given Service. If left empty, the rule
    /// will match within this policy&apos;s namespace.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Destination contains the match criteria that apply to destination entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressDestination
{
    /// <summary>
    /// NamespaceSelector is an optional field that contains a selector expression. Only traffic
    /// that originates from (or terminates at) endpoints within the selected namespaces will be
    /// matched. When both NamespaceSelector and another selector are defined on the same rule, then only
    /// workload endpoints that are matched by both selectors will be selected by the rule.
    /// 
    /// For NetworkPolicy, an empty NamespaceSelector implies that the Selector is limited to selecting
    /// only workload endpoints in the same namespace as the NetworkPolicy.
    /// 
    /// For NetworkPolicy, `global()` NamespaceSelector implies that the Selector is limited to selecting
    /// only GlobalNetworkSet or HostEndpoint.
    /// 
    /// For GlobalNetworkPolicy, an empty NamespaceSelector implies the Selector applies to workload
    /// endpoints across all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary>
    /// Nets is an optional field that restricts the rule to only apply to traffic that
    /// originates from (or terminates at) IP addresses in any of the given subnets.
    /// </summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary>NotNets is the negated version of the Nets field.</summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary>
    /// NotPorts is the negated version of the Ports field.
    /// Since only some protocols have ports, if any ports are specified it requires the
    /// Protocol match in the Rule to be set to &quot;TCP&quot;, &quot;UDP&quot;, or &quot;SCTP&quot;.
    /// </summary>
    [JsonPropertyName("notPorts")]
    public IList<IntOrString>? NotPorts { get; set; }

    /// <summary>
    /// NotSelector is the negated version of the Selector field.  See Selector field for
    /// subtleties with negated selectors.
    /// </summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary>
    /// Ports is an optional field that restricts the rule to only apply to traffic that has a
    /// source (destination) port that matches one of these ranges/values. This value is a
    /// list of integers or strings that represent ranges of ports.
    /// 
    /// Since only some protocols have ports, if any ports are specified it requires the
    /// Protocol match in the Rule to be set to &quot;TCP&quot;, &quot;UDP&quot;, or &quot;SCTP&quot;.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<IntOrString>? Ports { get; set; }

    /// <summary>
    /// Selector is an optional field that contains a selector expression (see Policy for
    /// sample syntax).  Only traffic that originates from (terminates at) endpoints matching
    /// the selector will be matched.
    /// 
    /// Note that: in addition to the negated version of the Selector (see NotSelector below), the
    /// selector expression syntax itself supports negation.  The two types of negation are subtly
    /// different. One negates the set of matched endpoints, the other negates the whole match:
    /// 
    /// 	Selector = &quot;!has(my_label)&quot; matches packets that are from other Calico-controlled
    /// 	endpoints that do not have the label &quot;my_label&quot;.
    /// 
    /// 	NotSelector = &quot;has(my_label)&quot; matches packets that are not from Calico-controlled
    /// 	endpoints that do have the label &quot;my_label&quot;.
    /// 
    /// The effect is that the latter will accept packets from non-Calico sources whereas the
    /// former is limited to packets from Calico-controlled endpoints.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>
    /// ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or
    /// terminates at) a pod running as a matching service account.
    /// </summary>
    [JsonPropertyName("serviceAccounts")]
    public V1StagedGlobalNetworkPolicySpecEgressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary>
    /// Services is an optional field that contains options for matching Kubernetes Services.
    /// If specified, only traffic that originates from or terminates at endpoints within the selected
    /// service(s) will be matched, and only to/from each endpoint&apos;s port.
    /// 
    /// Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets,
    /// NotNets or ServiceAccounts.
    /// 
    /// Ports and NotPorts can only be specified with Services on ingress rules.
    /// </summary>
    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecEgressDestinationServices? Services { get; set; }
}

/// <summary>
/// HTTPPath specifies an HTTP path to match. It may be either of the form:
/// exact: &lt;path&gt;: which matches the path exactly or
/// prefix: &lt;path-prefix&gt;: which matches the path prefix
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressHttpPaths
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>HTTP contains match criteria that apply to HTTP requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressHttp
{
    /// <summary>
    /// Methods is an optional field that restricts the rule to apply only to HTTP requests that use one of the listed
    /// HTTP Methods (e.g. GET, PUT, etc.)
    /// Multiple methods are OR&apos;d together.
    /// </summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>
    /// Paths is an optional field that restricts the rule to apply to HTTP requests that use one of the listed
    /// HTTP Paths.
    /// Multiple paths are OR&apos;d together.
    /// e.g:
    /// - exact: /foo
    /// - prefix: /bar
    /// NOTE: Each entry may ONLY specify either a `exact` or a `prefix` match. The validator will check for it.
    /// </summary>
    [JsonPropertyName("paths")]
    public IList<V1StagedGlobalNetworkPolicySpecEgressHttpPaths>? Paths { get; set; }
}

/// <summary>
/// ICMP is an optional field that restricts the rule to apply to a specific type and
/// code of ICMP traffic.  This should only be specified if the Protocol field is set to
/// &quot;ICMP&quot; or &quot;ICMPv6&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressIcmp
{
    /// <summary>
    /// Match on a specific ICMP code.  If specified, the Type value must also be specified.
    /// This is a technical limitation imposed by the kernel&apos;s iptables firewall, which
    /// Calico uses to enforce the rule.
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// Match on a specific ICMP type.  For example a value of 8 refers to ICMP Echo Request
    /// (i.e. pings).
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary>Metadata contains additional information for this rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressMetadata
{
    /// <summary>Annotations is a set of key value pairs that give extra information about the rule</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>NotICMP is the negated version of the ICMP field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressNotICMP
{
    /// <summary>
    /// Match on a specific ICMP code.  If specified, the Type value must also be specified.
    /// This is a technical limitation imposed by the kernel&apos;s iptables firewall, which
    /// Calico uses to enforce the rule.
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// Match on a specific ICMP type.  For example a value of 8 refers to ICMP Echo Request
    /// (i.e. pings).
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary>
/// ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or
/// terminates at) a pod running as a matching service account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressSourceServiceAccounts
{
    /// <summary>
    /// Names is an optional field that restricts the rule to only apply to traffic that originates from (or terminates
    /// at) a pod running as a service account whose name is in the list.
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// Selector is an optional field that restricts the rule to only apply to traffic that originates from
    /// (or terminates at) a pod running as a service account that matches the given label selector.
    /// If both Names and Selector are specified then they are AND&apos;ed.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary>
/// Services is an optional field that contains options for matching Kubernetes Services.
/// If specified, only traffic that originates from or terminates at endpoints within the selected
/// service(s) will be matched, and only to/from each endpoint&apos;s port.
/// 
/// Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets,
/// NotNets or ServiceAccounts.
/// 
/// Ports and NotPorts can only be specified with Services on ingress rules.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressSourceServices
{
    /// <summary>Name specifies the name of a Kubernetes Service to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace specifies the namespace of the given Service. If left empty, the rule
    /// will match within this policy&apos;s namespace.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Source contains the match criteria that apply to source entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgressSource
{
    /// <summary>
    /// NamespaceSelector is an optional field that contains a selector expression. Only traffic
    /// that originates from (or terminates at) endpoints within the selected namespaces will be
    /// matched. When both NamespaceSelector and another selector are defined on the same rule, then only
    /// workload endpoints that are matched by both selectors will be selected by the rule.
    /// 
    /// For NetworkPolicy, an empty NamespaceSelector implies that the Selector is limited to selecting
    /// only workload endpoints in the same namespace as the NetworkPolicy.
    /// 
    /// For NetworkPolicy, `global()` NamespaceSelector implies that the Selector is limited to selecting
    /// only GlobalNetworkSet or HostEndpoint.
    /// 
    /// For GlobalNetworkPolicy, an empty NamespaceSelector implies the Selector applies to workload
    /// endpoints across all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary>
    /// Nets is an optional field that restricts the rule to only apply to traffic that
    /// originates from (or terminates at) IP addresses in any of the given subnets.
    /// </summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary>NotNets is the negated version of the Nets field.</summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary>
    /// NotPorts is the negated version of the Ports field.
    /// Since only some protocols have ports, if any ports are specified it requires the
    /// Protocol match in the Rule to be set to &quot;TCP&quot;, &quot;UDP&quot;, or &quot;SCTP&quot;.
    /// </summary>
    [JsonPropertyName("notPorts")]
    public IList<IntOrString>? NotPorts { get; set; }

    /// <summary>
    /// NotSelector is the negated version of the Selector field.  See Selector field for
    /// subtleties with negated selectors.
    /// </summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary>
    /// Ports is an optional field that restricts the rule to only apply to traffic that has a
    /// source (destination) port that matches one of these ranges/values. This value is a
    /// list of integers or strings that represent ranges of ports.
    /// 
    /// Since only some protocols have ports, if any ports are specified it requires the
    /// Protocol match in the Rule to be set to &quot;TCP&quot;, &quot;UDP&quot;, or &quot;SCTP&quot;.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<IntOrString>? Ports { get; set; }

    /// <summary>
    /// Selector is an optional field that contains a selector expression (see Policy for
    /// sample syntax).  Only traffic that originates from (terminates at) endpoints matching
    /// the selector will be matched.
    /// 
    /// Note that: in addition to the negated version of the Selector (see NotSelector below), the
    /// selector expression syntax itself supports negation.  The two types of negation are subtly
    /// different. One negates the set of matched endpoints, the other negates the whole match:
    /// 
    /// 	Selector = &quot;!has(my_label)&quot; matches packets that are from other Calico-controlled
    /// 	endpoints that do not have the label &quot;my_label&quot;.
    /// 
    /// 	NotSelector = &quot;has(my_label)&quot; matches packets that are not from Calico-controlled
    /// 	endpoints that do have the label &quot;my_label&quot;.
    /// 
    /// The effect is that the latter will accept packets from non-Calico sources whereas the
    /// former is limited to packets from Calico-controlled endpoints.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>
    /// ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or
    /// terminates at) a pod running as a matching service account.
    /// </summary>
    [JsonPropertyName("serviceAccounts")]
    public V1StagedGlobalNetworkPolicySpecEgressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary>
    /// Services is an optional field that contains options for matching Kubernetes Services.
    /// If specified, only traffic that originates from or terminates at endpoints within the selected
    /// service(s) will be matched, and only to/from each endpoint&apos;s port.
    /// 
    /// Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets,
    /// NotNets or ServiceAccounts.
    /// 
    /// Ports and NotPorts can only be specified with Services on ingress rules.
    /// </summary>
    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecEgressSourceServices? Services { get; set; }
}

/// <summary>
/// A Rule encapsulates a set of match criteria and an action.  Both selector-based security Policy
/// and security Profiles reference rules - separated out as a list of rules for both
/// ingress and egress packet matching.
/// 
/// Each positive match criteria has a negated version, prefixed with &quot;Not&quot;. All the match
/// criteria within a rule must be satisfied for a packet to match. A single rule can contain
/// the positive and negative version of a match and both must be satisfied for the rule to match.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecEgress
{
    [JsonPropertyName("action")]
    public required V1StagedGlobalNetworkPolicySpecEgressActionEnum Action { get; set; }

    /// <summary>Destination contains the match criteria that apply to destination entity.</summary>
    [JsonPropertyName("destination")]
    public V1StagedGlobalNetworkPolicySpecEgressDestination? Destination { get; set; }

    /// <summary>HTTP contains match criteria that apply to HTTP requests.</summary>
    [JsonPropertyName("http")]
    public V1StagedGlobalNetworkPolicySpecEgressHttp? Http { get; set; }

    /// <summary>
    /// ICMP is an optional field that restricts the rule to apply to a specific type and
    /// code of ICMP traffic.  This should only be specified if the Protocol field is set to
    /// &quot;ICMP&quot; or &quot;ICMPv6&quot;.
    /// </summary>
    [JsonPropertyName("icmp")]
    public V1StagedGlobalNetworkPolicySpecEgressIcmp? Icmp { get; set; }

    /// <summary>
    /// IPVersion is an optional field that restricts the rule to only match a specific IP
    /// version.
    /// </summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary>Metadata contains additional information for this rule</summary>
    [JsonPropertyName("metadata")]
    public V1StagedGlobalNetworkPolicySpecEgressMetadata? Metadata { get; set; }

    /// <summary>NotICMP is the negated version of the ICMP field.</summary>
    [JsonPropertyName("notICMP")]
    public V1StagedGlobalNetworkPolicySpecEgressNotICMP? NotICMP { get; set; }

    /// <summary>NotProtocol is the negated version of the Protocol field.</summary>
    [JsonPropertyName("notProtocol")]
    public IntOrString? NotProtocol { get; set; }

    /// <summary>
    /// Protocol is an optional field that restricts the rule to only apply to traffic of
    /// a specific IP protocol. Required if any of the EntityRules contain Ports
    /// (because ports only apply to certain protocols).
    /// 
    /// Must be one of these string values: &quot;TCP&quot;, &quot;UDP&quot;, &quot;ICMP&quot;, &quot;ICMPv6&quot;, &quot;SCTP&quot;, &quot;UDPLite&quot;
    /// or an integer in the range 1-255.
    /// </summary>
    [JsonPropertyName("protocol")]
    public IntOrString? Protocol { get; set; }

    /// <summary>Source contains the match criteria that apply to source entity.</summary>
    [JsonPropertyName("source")]
    public V1StagedGlobalNetworkPolicySpecEgressSource? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedGlobalNetworkPolicySpecIngressActionEnum>))]
public enum V1StagedGlobalNetworkPolicySpecIngressActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log,
    [EnumMember(Value = "Pass"), JsonStringEnumMemberName("Pass")]
    Pass
}

/// <summary>
/// ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or
/// terminates at) a pod running as a matching service account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressDestinationServiceAccounts
{
    /// <summary>
    /// Names is an optional field that restricts the rule to only apply to traffic that originates from (or terminates
    /// at) a pod running as a service account whose name is in the list.
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// Selector is an optional field that restricts the rule to only apply to traffic that originates from
    /// (or terminates at) a pod running as a service account that matches the given label selector.
    /// If both Names and Selector are specified then they are AND&apos;ed.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary>
/// Services is an optional field that contains options for matching Kubernetes Services.
/// If specified, only traffic that originates from or terminates at endpoints within the selected
/// service(s) will be matched, and only to/from each endpoint&apos;s port.
/// 
/// Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets,
/// NotNets or ServiceAccounts.
/// 
/// Ports and NotPorts can only be specified with Services on ingress rules.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressDestinationServices
{
    /// <summary>Name specifies the name of a Kubernetes Service to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace specifies the namespace of the given Service. If left empty, the rule
    /// will match within this policy&apos;s namespace.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Destination contains the match criteria that apply to destination entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressDestination
{
    /// <summary>
    /// NamespaceSelector is an optional field that contains a selector expression. Only traffic
    /// that originates from (or terminates at) endpoints within the selected namespaces will be
    /// matched. When both NamespaceSelector and another selector are defined on the same rule, then only
    /// workload endpoints that are matched by both selectors will be selected by the rule.
    /// 
    /// For NetworkPolicy, an empty NamespaceSelector implies that the Selector is limited to selecting
    /// only workload endpoints in the same namespace as the NetworkPolicy.
    /// 
    /// For NetworkPolicy, `global()` NamespaceSelector implies that the Selector is limited to selecting
    /// only GlobalNetworkSet or HostEndpoint.
    /// 
    /// For GlobalNetworkPolicy, an empty NamespaceSelector implies the Selector applies to workload
    /// endpoints across all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary>
    /// Nets is an optional field that restricts the rule to only apply to traffic that
    /// originates from (or terminates at) IP addresses in any of the given subnets.
    /// </summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary>NotNets is the negated version of the Nets field.</summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary>
    /// NotPorts is the negated version of the Ports field.
    /// Since only some protocols have ports, if any ports are specified it requires the
    /// Protocol match in the Rule to be set to &quot;TCP&quot;, &quot;UDP&quot;, or &quot;SCTP&quot;.
    /// </summary>
    [JsonPropertyName("notPorts")]
    public IList<IntOrString>? NotPorts { get; set; }

    /// <summary>
    /// NotSelector is the negated version of the Selector field.  See Selector field for
    /// subtleties with negated selectors.
    /// </summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary>
    /// Ports is an optional field that restricts the rule to only apply to traffic that has a
    /// source (destination) port that matches one of these ranges/values. This value is a
    /// list of integers or strings that represent ranges of ports.
    /// 
    /// Since only some protocols have ports, if any ports are specified it requires the
    /// Protocol match in the Rule to be set to &quot;TCP&quot;, &quot;UDP&quot;, or &quot;SCTP&quot;.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<IntOrString>? Ports { get; set; }

    /// <summary>
    /// Selector is an optional field that contains a selector expression (see Policy for
    /// sample syntax).  Only traffic that originates from (terminates at) endpoints matching
    /// the selector will be matched.
    /// 
    /// Note that: in addition to the negated version of the Selector (see NotSelector below), the
    /// selector expression syntax itself supports negation.  The two types of negation are subtly
    /// different. One negates the set of matched endpoints, the other negates the whole match:
    /// 
    /// 	Selector = &quot;!has(my_label)&quot; matches packets that are from other Calico-controlled
    /// 	endpoints that do not have the label &quot;my_label&quot;.
    /// 
    /// 	NotSelector = &quot;has(my_label)&quot; matches packets that are not from Calico-controlled
    /// 	endpoints that do have the label &quot;my_label&quot;.
    /// 
    /// The effect is that the latter will accept packets from non-Calico sources whereas the
    /// former is limited to packets from Calico-controlled endpoints.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>
    /// ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or
    /// terminates at) a pod running as a matching service account.
    /// </summary>
    [JsonPropertyName("serviceAccounts")]
    public V1StagedGlobalNetworkPolicySpecIngressDestinationServiceAccounts? ServiceAccounts { get; set; }

    /// <summary>
    /// Services is an optional field that contains options for matching Kubernetes Services.
    /// If specified, only traffic that originates from or terminates at endpoints within the selected
    /// service(s) will be matched, and only to/from each endpoint&apos;s port.
    /// 
    /// Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets,
    /// NotNets or ServiceAccounts.
    /// 
    /// Ports and NotPorts can only be specified with Services on ingress rules.
    /// </summary>
    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecIngressDestinationServices? Services { get; set; }
}

/// <summary>
/// HTTPPath specifies an HTTP path to match. It may be either of the form:
/// exact: &lt;path&gt;: which matches the path exactly or
/// prefix: &lt;path-prefix&gt;: which matches the path prefix
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressHttpPaths
{
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>HTTP contains match criteria that apply to HTTP requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressHttp
{
    /// <summary>
    /// Methods is an optional field that restricts the rule to apply only to HTTP requests that use one of the listed
    /// HTTP Methods (e.g. GET, PUT, etc.)
    /// Multiple methods are OR&apos;d together.
    /// </summary>
    [JsonPropertyName("methods")]
    public IList<string>? Methods { get; set; }

    /// <summary>
    /// Paths is an optional field that restricts the rule to apply to HTTP requests that use one of the listed
    /// HTTP Paths.
    /// Multiple paths are OR&apos;d together.
    /// e.g:
    /// - exact: /foo
    /// - prefix: /bar
    /// NOTE: Each entry may ONLY specify either a `exact` or a `prefix` match. The validator will check for it.
    /// </summary>
    [JsonPropertyName("paths")]
    public IList<V1StagedGlobalNetworkPolicySpecIngressHttpPaths>? Paths { get; set; }
}

/// <summary>
/// ICMP is an optional field that restricts the rule to apply to a specific type and
/// code of ICMP traffic.  This should only be specified if the Protocol field is set to
/// &quot;ICMP&quot; or &quot;ICMPv6&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressIcmp
{
    /// <summary>
    /// Match on a specific ICMP code.  If specified, the Type value must also be specified.
    /// This is a technical limitation imposed by the kernel&apos;s iptables firewall, which
    /// Calico uses to enforce the rule.
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// Match on a specific ICMP type.  For example a value of 8 refers to ICMP Echo Request
    /// (i.e. pings).
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary>Metadata contains additional information for this rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressMetadata
{
    /// <summary>Annotations is a set of key value pairs that give extra information about the rule</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>NotICMP is the negated version of the ICMP field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressNotICMP
{
    /// <summary>
    /// Match on a specific ICMP code.  If specified, the Type value must also be specified.
    /// This is a technical limitation imposed by the kernel&apos;s iptables firewall, which
    /// Calico uses to enforce the rule.
    /// </summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>
    /// Match on a specific ICMP type.  For example a value of 8 refers to ICMP Echo Request
    /// (i.e. pings).
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }
}

/// <summary>
/// ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or
/// terminates at) a pod running as a matching service account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressSourceServiceAccounts
{
    /// <summary>
    /// Names is an optional field that restricts the rule to only apply to traffic that originates from (or terminates
    /// at) a pod running as a service account whose name is in the list.
    /// </summary>
    [JsonPropertyName("names")]
    public IList<string>? Names { get; set; }

    /// <summary>
    /// Selector is an optional field that restricts the rule to only apply to traffic that originates from
    /// (or terminates at) a pod running as a service account that matches the given label selector.
    /// If both Names and Selector are specified then they are AND&apos;ed.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }
}

/// <summary>
/// Services is an optional field that contains options for matching Kubernetes Services.
/// If specified, only traffic that originates from or terminates at endpoints within the selected
/// service(s) will be matched, and only to/from each endpoint&apos;s port.
/// 
/// Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets,
/// NotNets or ServiceAccounts.
/// 
/// Ports and NotPorts can only be specified with Services on ingress rules.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressSourceServices
{
    /// <summary>Name specifies the name of a Kubernetes Service to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Namespace specifies the namespace of the given Service. If left empty, the rule
    /// will match within this policy&apos;s namespace.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Source contains the match criteria that apply to source entity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngressSource
{
    /// <summary>
    /// NamespaceSelector is an optional field that contains a selector expression. Only traffic
    /// that originates from (or terminates at) endpoints within the selected namespaces will be
    /// matched. When both NamespaceSelector and another selector are defined on the same rule, then only
    /// workload endpoints that are matched by both selectors will be selected by the rule.
    /// 
    /// For NetworkPolicy, an empty NamespaceSelector implies that the Selector is limited to selecting
    /// only workload endpoints in the same namespace as the NetworkPolicy.
    /// 
    /// For NetworkPolicy, `global()` NamespaceSelector implies that the Selector is limited to selecting
    /// only GlobalNetworkSet or HostEndpoint.
    /// 
    /// For GlobalNetworkPolicy, an empty NamespaceSelector implies the Selector applies to workload
    /// endpoints across all namespaces.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary>
    /// Nets is an optional field that restricts the rule to only apply to traffic that
    /// originates from (or terminates at) IP addresses in any of the given subnets.
    /// </summary>
    [JsonPropertyName("nets")]
    public IList<string>? Nets { get; set; }

    /// <summary>NotNets is the negated version of the Nets field.</summary>
    [JsonPropertyName("notNets")]
    public IList<string>? NotNets { get; set; }

    /// <summary>
    /// NotPorts is the negated version of the Ports field.
    /// Since only some protocols have ports, if any ports are specified it requires the
    /// Protocol match in the Rule to be set to &quot;TCP&quot;, &quot;UDP&quot;, or &quot;SCTP&quot;.
    /// </summary>
    [JsonPropertyName("notPorts")]
    public IList<IntOrString>? NotPorts { get; set; }

    /// <summary>
    /// NotSelector is the negated version of the Selector field.  See Selector field for
    /// subtleties with negated selectors.
    /// </summary>
    [JsonPropertyName("notSelector")]
    public string? NotSelector { get; set; }

    /// <summary>
    /// Ports is an optional field that restricts the rule to only apply to traffic that has a
    /// source (destination) port that matches one of these ranges/values. This value is a
    /// list of integers or strings that represent ranges of ports.
    /// 
    /// Since only some protocols have ports, if any ports are specified it requires the
    /// Protocol match in the Rule to be set to &quot;TCP&quot;, &quot;UDP&quot;, or &quot;SCTP&quot;.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<IntOrString>? Ports { get; set; }

    /// <summary>
    /// Selector is an optional field that contains a selector expression (see Policy for
    /// sample syntax).  Only traffic that originates from (terminates at) endpoints matching
    /// the selector will be matched.
    /// 
    /// Note that: in addition to the negated version of the Selector (see NotSelector below), the
    /// selector expression syntax itself supports negation.  The two types of negation are subtly
    /// different. One negates the set of matched endpoints, the other negates the whole match:
    /// 
    /// 	Selector = &quot;!has(my_label)&quot; matches packets that are from other Calico-controlled
    /// 	endpoints that do not have the label &quot;my_label&quot;.
    /// 
    /// 	NotSelector = &quot;has(my_label)&quot; matches packets that are not from Calico-controlled
    /// 	endpoints that do have the label &quot;my_label&quot;.
    /// 
    /// The effect is that the latter will accept packets from non-Calico sources whereas the
    /// former is limited to packets from Calico-controlled endpoints.
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>
    /// ServiceAccounts is an optional field that restricts the rule to only apply to traffic that originates from (or
    /// terminates at) a pod running as a matching service account.
    /// </summary>
    [JsonPropertyName("serviceAccounts")]
    public V1StagedGlobalNetworkPolicySpecIngressSourceServiceAccounts? ServiceAccounts { get; set; }

    /// <summary>
    /// Services is an optional field that contains options for matching Kubernetes Services.
    /// If specified, only traffic that originates from or terminates at endpoints within the selected
    /// service(s) will be matched, and only to/from each endpoint&apos;s port.
    /// 
    /// Services cannot be specified on the same rule as Selector, NotSelector, NamespaceSelector, Nets,
    /// NotNets or ServiceAccounts.
    /// 
    /// Ports and NotPorts can only be specified with Services on ingress rules.
    /// </summary>
    [JsonPropertyName("services")]
    public V1StagedGlobalNetworkPolicySpecIngressSourceServices? Services { get; set; }
}

/// <summary>
/// A Rule encapsulates a set of match criteria and an action.  Both selector-based security Policy
/// and security Profiles reference rules - separated out as a list of rules for both
/// ingress and egress packet matching.
/// 
/// Each positive match criteria has a negated version, prefixed with &quot;Not&quot;. All the match
/// criteria within a rule must be satisfied for a packet to match. A single rule can contain
/// the positive and negative version of a match and both must be satisfied for the rule to match.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpecIngress
{
    [JsonPropertyName("action")]
    public required V1StagedGlobalNetworkPolicySpecIngressActionEnum Action { get; set; }

    /// <summary>Destination contains the match criteria that apply to destination entity.</summary>
    [JsonPropertyName("destination")]
    public V1StagedGlobalNetworkPolicySpecIngressDestination? Destination { get; set; }

    /// <summary>HTTP contains match criteria that apply to HTTP requests.</summary>
    [JsonPropertyName("http")]
    public V1StagedGlobalNetworkPolicySpecIngressHttp? Http { get; set; }

    /// <summary>
    /// ICMP is an optional field that restricts the rule to apply to a specific type and
    /// code of ICMP traffic.  This should only be specified if the Protocol field is set to
    /// &quot;ICMP&quot; or &quot;ICMPv6&quot;.
    /// </summary>
    [JsonPropertyName("icmp")]
    public V1StagedGlobalNetworkPolicySpecIngressIcmp? Icmp { get; set; }

    /// <summary>
    /// IPVersion is an optional field that restricts the rule to only match a specific IP
    /// version.
    /// </summary>
    [JsonPropertyName("ipVersion")]
    public int? IpVersion { get; set; }

    /// <summary>Metadata contains additional information for this rule</summary>
    [JsonPropertyName("metadata")]
    public V1StagedGlobalNetworkPolicySpecIngressMetadata? Metadata { get; set; }

    /// <summary>NotICMP is the negated version of the ICMP field.</summary>
    [JsonPropertyName("notICMP")]
    public V1StagedGlobalNetworkPolicySpecIngressNotICMP? NotICMP { get; set; }

    /// <summary>NotProtocol is the negated version of the Protocol field.</summary>
    [JsonPropertyName("notProtocol")]
    public IntOrString? NotProtocol { get; set; }

    /// <summary>
    /// Protocol is an optional field that restricts the rule to only apply to traffic of
    /// a specific IP protocol. Required if any of the EntityRules contain Ports
    /// (because ports only apply to certain protocols).
    /// 
    /// Must be one of these string values: &quot;TCP&quot;, &quot;UDP&quot;, &quot;ICMP&quot;, &quot;ICMPv6&quot;, &quot;SCTP&quot;, &quot;UDPLite&quot;
    /// or an integer in the range 1-255.
    /// </summary>
    [JsonPropertyName("protocol")]
    public IntOrString? Protocol { get; set; }

    /// <summary>Source contains the match criteria that apply to source entity.</summary>
    [JsonPropertyName("source")]
    public V1StagedGlobalNetworkPolicySpecIngressSource? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedGlobalNetworkPolicySpecPerformanceHintsEnum>))]
public enum V1StagedGlobalNetworkPolicySpecPerformanceHintsEnum
{
    [EnumMember(Value = "AssumeNeededOnEveryNode"), JsonStringEnumMemberName("AssumeNeededOnEveryNode")]
    AssumeNeededOnEveryNode
}

/// <summary>The staged action. If this is omitted, the default is Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedGlobalNetworkPolicySpecStagedActionEnum>))]
public enum V1StagedGlobalNetworkPolicySpecStagedActionEnum
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

/// <summary>PolicyType enumerates the possible values of the PolicySpec Types field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1StagedGlobalNetworkPolicySpecTypesEnum>))]
public enum V1StagedGlobalNetworkPolicySpecTypesEnum
{
    [EnumMember(Value = "Ingress"), JsonStringEnumMemberName("Ingress")]
    Ingress,
    [EnumMember(Value = "Egress"), JsonStringEnumMemberName("Egress")]
    Egress
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1StagedGlobalNetworkPolicySpec
{
    /// <summary>ApplyOnForward indicates to apply the rules in this policy on forward traffic.</summary>
    [JsonPropertyName("applyOnForward")]
    public bool? ApplyOnForward { get; set; }

    /// <summary>
    /// DoNotTrack indicates whether packets matched by the rules in this policy should go through
    /// the data plane&apos;s connection tracking, such as Linux conntrack.  If True, the rules in
    /// this policy are applied before any data plane connection tracking, and packets allowed by
    /// this policy are marked as not to be tracked.
    /// </summary>
    [JsonPropertyName("doNotTrack")]
    public bool? DoNotTrack { get; set; }

    /// <summary>
    /// The ordered set of egress rules.  Each rule contains a set of packet match criteria and
    /// a corresponding action to apply. Limited to 1024 rules per policy.
    /// </summary>
    [JsonPropertyName("egress")]
    public IList<V1StagedGlobalNetworkPolicySpecEgress>? Egress { get; set; }

    /// <summary>
    /// The ordered set of ingress rules.  Each rule contains a set of packet match criteria and
    /// a corresponding action to apply. Limited to 1024 rules per policy.
    /// </summary>
    [JsonPropertyName("ingress")]
    public IList<V1StagedGlobalNetworkPolicySpecIngress>? Ingress { get; set; }

    /// <summary>NamespaceSelector is an optional field for an expression used to select a pod based on namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public string? NamespaceSelector { get; set; }

    /// <summary>
    /// Order is an optional field that specifies the order in which the policy is applied.
    /// Policies with higher &quot;order&quot; are applied after those with lower
    /// order within the same tier.  If the order is omitted, it may be considered to be &quot;infinite&quot; - i.e. the
    /// policy will be applied last.  Policies with identical order will be applied in
    /// alphanumerical order based on the Policy &quot;Name&quot; within the tier.
    /// </summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>
    /// PerformanceHints contains a list of hints to Calico&apos;s policy engine to
    /// help process the policy more efficiently.  Hints never change the
    /// enforcement behaviour of the policy.
    /// 
    /// Currently, the only available hint is &quot;AssumeNeededOnEveryNode&quot;.  When
    /// that hint is set on a policy, Felix will act as if the policy matches
    /// a local endpoint even if it does not. This is useful for &quot;preloading&quot;
    /// any large static policies that are known to be used on every node.
    /// If the policy is _not_ used on a particular node then the work
    /// done to preload the policy (and to maintain it) is wasted.
    /// </summary>
    [JsonPropertyName("performanceHints")]
    public IList<V1StagedGlobalNetworkPolicySpecPerformanceHintsEnum>? PerformanceHints { get; set; }

    /// <summary>PreDNAT indicates to apply the rules in this policy before any DNAT.</summary>
    [JsonPropertyName("preDNAT")]
    public bool? PreDNAT { get; set; }

    /// <summary>
    /// The selector is an expression used to pick out the endpoints that the policy should
    /// be applied to.
    /// 
    /// Selector expressions follow this syntax:
    /// 
    /// 	label == &quot;string_literal&quot;  -&gt;  comparison, e.g. my_label == &quot;foo bar&quot;
    /// 	label != &quot;string_literal&quot;   -&gt;  not equal; also matches if label is not present
    /// 	label in { &quot;a&quot;, &quot;b&quot;, &quot;c&quot;, ... }  -&gt;  true if the value of label X is one of &quot;a&quot;, &quot;b&quot;, &quot;c&quot;
    /// 	label not in { &quot;a&quot;, &quot;b&quot;, &quot;c&quot;, ... }  -&gt;  true if the value of label X is not one of &quot;a&quot;, &quot;b&quot;, &quot;c&quot;
    /// 	has(label_name)  -&gt; True if that label is present
    /// 	! expr -&gt; negation of expr
    /// 	expr &amp; &amp; expr  -&gt; Short-circuit and
    /// 	expr || expr  -&gt; Short-circuit or
    /// 	( expr ) -&gt; parens for grouping
    /// 	all() or the empty selector -&gt; matches all endpoints.
    /// 
    /// Label names are allowed to contain alphanumerics, -, _ and /. String literals are more permissive
    /// but they do not support escape characters.
    /// 
    /// Examples (with made-up labels):
    /// 
    /// 	type == &quot;webserver&quot; &amp; &amp; deployment == &quot;prod&quot;
    /// 	type in {&quot;frontend&quot;, &quot;backend&quot;}
    /// 	deployment != &quot;dev&quot;
    /// 	! has(label_name)
    /// </summary>
    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    /// <summary>ServiceAccountSelector is an optional field for an expression used to select a pod based on service accounts.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public string? ServiceAccountSelector { get; set; }

    /// <summary>The staged action. If this is omitted, the default is Set.</summary>
    [JsonPropertyName("stagedAction")]
    public V1StagedGlobalNetworkPolicySpecStagedActionEnum? StagedAction { get; set; }

    /// <summary>
    /// The name of the tier that this policy belongs to.  If this is omitted, the default
    /// tier (name is &quot;default&quot;) is assumed.  The specified tier must exist in order to create
    /// security policies within the tier, the &quot;default&quot; tier is created automatically if it
    /// does not exist, this means for deployments requiring only a single Tier, the tier name
    /// may be omitted on all policy management requests.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>
    /// Types indicates whether this policy applies to ingress, or to egress, or to both.  When
    /// not explicitly specified (and so the value on creation is empty or nil), Calico defaults
    /// Types according to what Ingress and Egress rules are present in the policy.  The
    /// default is:
    /// 
    /// - [ PolicyTypeIngress ], if there are no Egress rules (including the case where there are
    ///   also no Ingress rules)
    /// 
    /// - [ PolicyTypeEgress ], if there are Egress rules but no Ingress rules
    /// 
    /// - [ PolicyTypeIngress, PolicyTypeEgress ], if there are both Ingress and Egress rules.
    /// 
    /// When the policy is read back again, Types will always be one of these values, never empty
    /// or nil.
    /// </summary>
    [JsonPropertyName("types")]
    public IList<V1StagedGlobalNetworkPolicySpecTypesEnum>? Types { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1StagedGlobalNetworkPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1StagedGlobalNetworkPolicySpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "StagedGlobalNetworkPolicy";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "stagedglobalnetworkpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StagedGlobalNetworkPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1StagedGlobalNetworkPolicySpec? Spec { get; set; }
}