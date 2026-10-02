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
public partial class V1BGPFilterList : IKubernetesObject<V1ListMeta>, IItems<V1BGPFilter>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPFilterList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpfilters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BGPFilterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1BGPFilter objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1BGPFilter> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV4ActionEnum>))]
public enum V1BGPFilterSpecExportV4ActionEnum
{
    [EnumMember(Value = "Accept"), JsonStringEnumMemberName("Accept")]
    Accept,
    [EnumMember(Value = "Reject"), JsonStringEnumMemberName("Reject")]
    Reject
}

/// <summary>
/// If set, this filter rule will only apply to routes that carry the specified BGP
/// community.  On import, this matches communities set by the remote peer.  On export,
/// this matches communities already present on the route, whether received from a BGP
/// peer (e.g. on a route reflector re-advertising to an eBGP peer) or added locally
/// by an import filter or an earlier export rule&apos;s AddCommunity operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4Communities
{
    /// <summary>Values is a list of BGP community values to match against. Exactly one value must be specified.</summary>
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

/// <summary>
/// MatchOperator defines how the route&apos;s prefix is compared against CIDR.  &quot;Equal&quot; requires
/// an exact prefix match, &quot;In&quot; requires the route to be contained within the CIDR (or equal),
/// &quot;NotEqual&quot; and &quot;NotIn&quot; are their negations.  Only meaningful when CIDR is also specified.
/// Required when CIDR is set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV4MatchOperatorEnum>))]
public enum V1BGPFilterSpecExportV4MatchOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "NotEqual"), JsonStringEnumMemberName("NotEqual")]
    NotEqual,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn
}

/// <summary>AddCommunity adds the specified BGP community to the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4OperationsAddCommunity
{
    /// <summary>Value is the BGP community to add.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>PrependASPath prepends the specified AS numbers to the route&apos;s AS path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4OperationsPrependASPath
{
    /// <summary>
    /// Prefix is the sequence of AS numbers to prepend to the route&apos;s AS path.
    /// The resulting path starts with these AS numbers in the order listed;
    /// e.g. [65000, 65001] produces the path &quot;65000 65001 &lt;original&gt; &quot;.
    /// </summary>
    [JsonPropertyName("prefix")]
    public required IList<long> Prefix { get; set; }
}

/// <summary>
/// SetPriority sets the route&apos;s priority (metric), in the same units as the
/// ...RoutePriority fields in FelixConfiguration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4OperationsSetPriority
{
    /// <summary>
    /// Value is the priority to set, in the same units as FelixConfiguration&apos;s
    /// ...RoutePriority fields.
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }
}

/// <summary>
/// BGPFilterOperation is a discriminated union representing a single route modification.
/// Exactly one field must be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4Operations
{
    /// <summary>AddCommunity adds the specified BGP community to the route.</summary>
    [JsonPropertyName("addCommunity")]
    public V1BGPFilterSpecExportV4OperationsAddCommunity? AddCommunity { get; set; }

    /// <summary>PrependASPath prepends the specified AS numbers to the route&apos;s AS path.</summary>
    [JsonPropertyName("prependASPath")]
    public V1BGPFilterSpecExportV4OperationsPrependASPath? PrependASPath { get; set; }

    /// <summary>
    /// SetPriority sets the route&apos;s priority (metric), in the same units as the
    /// ...RoutePriority fields in FelixConfiguration.
    /// </summary>
    [JsonPropertyName("setPriority")]
    public V1BGPFilterSpecExportV4OperationsSetPriority? SetPriority { get; set; }
}

/// <summary>
/// If non-empty, this filter rule will only apply to routes being imported from or exported
/// to a BGP peer of the specified type.  If empty, the rule applies to all peers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV4PeerTypeEnum>))]
public enum V1BGPFilterSpecExportV4PeerTypeEnum
{
    [EnumMember(Value = "eBGP"), JsonStringEnumMemberName("eBGP")]
    EBGP,
    [EnumMember(Value = "iBGP"), JsonStringEnumMemberName("iBGP")]
    IBGP
}

/// <summary>
/// PrefixLength further constrains the CIDR match by restricting the range of allowed
/// prefix lengths.  For example, CIDR &quot;10.0.0.0/8&quot; with MatchOperator &quot;In&quot; and
/// PrefixLength {min: 16, max: 24} matches any route within 10.0.0.0/8 whose prefix
/// length is between /16 and /24.  Requires CIDR to be set; if CIDR is omitted,
/// PrefixLength is ignored.  If PrefixLength is nil and CIDR is set, the CIDR&apos;s own
/// prefix length is used as the minimum and /32 (for V4) as the maximum.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4PrefixLength
{
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>
/// If set to &quot;RemotePeers&quot;: for export rules, this filter rule will only apply to routes
/// learned from BGP peers (i.e. re-advertised routes), not locally originated routes.
/// For import rules, this field is redundant because imported routes are by definition
/// from BGP peers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV4SourceEnum>))]
public enum V1BGPFilterSpecExportV4SourceEnum
{
    [EnumMember(Value = "RemotePeers"), JsonStringEnumMemberName("RemotePeers")]
    RemotePeers
}

/// <summary>
/// BGPFilterRuleV4 defines a BGP filter rule consisting of match criteria, a terminal action,
/// and optional operations to apply to matching routes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV4
{
    [JsonPropertyName("action")]
    public required V1BGPFilterSpecExportV4ActionEnum Action { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes whose AS path begins with the
    /// specified sequence of AS numbers.
    /// </summary>
    [JsonPropertyName("asPathPrefix")]
    public IList<long>? AsPathPrefix { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply when the route being exported or imported
    /// &quot;matches&quot; the given CIDR - where the definition of &quot;matches&quot; is according to
    /// MatchOperator and PrefixLength.  CIDR should be in conventional CIDR notation,
    /// &lt;prefix&gt;/&lt;length&gt;.
    /// </summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary>
    /// If set, this filter rule will only apply to routes that carry the specified BGP
    /// community.  On import, this matches communities set by the remote peer.  On export,
    /// this matches communities already present on the route, whether received from a BGP
    /// peer (e.g. on a route reflector re-advertising to an eBGP peer) or added locally
    /// by an import filter or an earlier export rule&apos;s AddCommunity operation.
    /// </summary>
    [JsonPropertyName("communities")]
    public V1BGPFilterSpecExportV4Communities? Communities { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes with an outgoing interface that
    /// matches Interface.
    /// </summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>
    /// MatchOperator defines how the route&apos;s prefix is compared against CIDR.  &quot;Equal&quot; requires
    /// an exact prefix match, &quot;In&quot; requires the route to be contained within the CIDR (or equal),
    /// &quot;NotEqual&quot; and &quot;NotIn&quot; are their negations.  Only meaningful when CIDR is also specified.
    /// Required when CIDR is set.
    /// </summary>
    [JsonPropertyName("matchOperator")]
    public V1BGPFilterSpecExportV4MatchOperatorEnum? MatchOperator { get; set; }

    /// <summary>
    /// Operations is an ordered list of route modifications to apply to matching routes before
    /// accepting them.  Only valid when Action is &quot;Accept&quot;; specifying operations with &quot;Reject&quot;
    /// is rejected by validation.  Each entry must set exactly one operation field.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1BGPFilterSpecExportV4Operations>? Operations { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes being imported from or exported
    /// to a BGP peer of the specified type.  If empty, the rule applies to all peers.
    /// </summary>
    [JsonPropertyName("peerType")]
    public V1BGPFilterSpecExportV4PeerTypeEnum? PeerType { get; set; }

    /// <summary>
    /// PrefixLength further constrains the CIDR match by restricting the range of allowed
    /// prefix lengths.  For example, CIDR &quot;10.0.0.0/8&quot; with MatchOperator &quot;In&quot; and
    /// PrefixLength {min: 16, max: 24} matches any route within 10.0.0.0/8 whose prefix
    /// length is between /16 and /24.  Requires CIDR to be set; if CIDR is omitted,
    /// PrefixLength is ignored.  If PrefixLength is nil and CIDR is set, the CIDR&apos;s own
    /// prefix length is used as the minimum and /32 (for V4) as the maximum.
    /// </summary>
    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecExportV4PrefixLength? PrefixLength { get; set; }

    /// <summary>
    /// If set, this filter rule will only apply to routes with the given priority, in the
    /// same units as the ...RoutePriority fields in FelixConfiguration.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// If set to &quot;RemotePeers&quot;: for export rules, this filter rule will only apply to routes
    /// learned from BGP peers (i.e. re-advertised routes), not locally originated routes.
    /// For import rules, this field is redundant because imported routes are by definition
    /// from BGP peers.
    /// </summary>
    [JsonPropertyName("source")]
    public V1BGPFilterSpecExportV4SourceEnum? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV6ActionEnum>))]
public enum V1BGPFilterSpecExportV6ActionEnum
{
    [EnumMember(Value = "Accept"), JsonStringEnumMemberName("Accept")]
    Accept,
    [EnumMember(Value = "Reject"), JsonStringEnumMemberName("Reject")]
    Reject
}

/// <summary>
/// If set, this filter rule will only apply to routes that carry the specified BGP
/// community.  On import, this matches communities set by the remote peer.  On export,
/// this matches communities already present on the route, whether received from a BGP
/// peer (e.g. on a route reflector re-advertising to an eBGP peer) or added locally
/// by an import filter or an earlier export rule&apos;s AddCommunity operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6Communities
{
    /// <summary>Values is a list of BGP community values to match against. Exactly one value must be specified.</summary>
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

/// <summary>
/// MatchOperator defines how the route&apos;s prefix is compared against CIDR.  &quot;Equal&quot; requires
/// an exact prefix match, &quot;In&quot; requires the route to be contained within the CIDR (or equal),
/// &quot;NotEqual&quot; and &quot;NotIn&quot; are their negations.  Only meaningful when CIDR is also specified.
/// Required when CIDR is set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV6MatchOperatorEnum>))]
public enum V1BGPFilterSpecExportV6MatchOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "NotEqual"), JsonStringEnumMemberName("NotEqual")]
    NotEqual,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn
}

/// <summary>AddCommunity adds the specified BGP community to the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6OperationsAddCommunity
{
    /// <summary>Value is the BGP community to add.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>PrependASPath prepends the specified AS numbers to the route&apos;s AS path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6OperationsPrependASPath
{
    /// <summary>
    /// Prefix is the sequence of AS numbers to prepend to the route&apos;s AS path.
    /// The resulting path starts with these AS numbers in the order listed;
    /// e.g. [65000, 65001] produces the path &quot;65000 65001 &lt;original&gt; &quot;.
    /// </summary>
    [JsonPropertyName("prefix")]
    public required IList<long> Prefix { get; set; }
}

/// <summary>
/// SetPriority sets the route&apos;s priority (metric), in the same units as the
/// ...RoutePriority fields in FelixConfiguration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6OperationsSetPriority
{
    /// <summary>
    /// Value is the priority to set, in the same units as FelixConfiguration&apos;s
    /// ...RoutePriority fields.
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }
}

/// <summary>
/// BGPFilterOperation is a discriminated union representing a single route modification.
/// Exactly one field must be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6Operations
{
    /// <summary>AddCommunity adds the specified BGP community to the route.</summary>
    [JsonPropertyName("addCommunity")]
    public V1BGPFilterSpecExportV6OperationsAddCommunity? AddCommunity { get; set; }

    /// <summary>PrependASPath prepends the specified AS numbers to the route&apos;s AS path.</summary>
    [JsonPropertyName("prependASPath")]
    public V1BGPFilterSpecExportV6OperationsPrependASPath? PrependASPath { get; set; }

    /// <summary>
    /// SetPriority sets the route&apos;s priority (metric), in the same units as the
    /// ...RoutePriority fields in FelixConfiguration.
    /// </summary>
    [JsonPropertyName("setPriority")]
    public V1BGPFilterSpecExportV6OperationsSetPriority? SetPriority { get; set; }
}

/// <summary>
/// If non-empty, this filter rule will only apply to routes being imported from or exported
/// to a BGP peer of the specified type.  If empty, the rule applies to all peers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV6PeerTypeEnum>))]
public enum V1BGPFilterSpecExportV6PeerTypeEnum
{
    [EnumMember(Value = "eBGP"), JsonStringEnumMemberName("eBGP")]
    EBGP,
    [EnumMember(Value = "iBGP"), JsonStringEnumMemberName("iBGP")]
    IBGP
}

/// <summary>
/// PrefixLength further constrains the CIDR match by restricting the range of allowed
/// prefix lengths.  For example, CIDR &quot;fd00::/8&quot; with MatchOperator &quot;In&quot; and
/// PrefixLength {min: 48, max: 64} matches any route within fd00::/8 whose prefix
/// length is between /48 and /64.  Requires CIDR to be set; if CIDR is omitted,
/// PrefixLength is ignored.  If PrefixLength is nil and CIDR is set, the CIDR&apos;s own
/// prefix length is used as the minimum and /128 (for V6) as the maximum.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6PrefixLength
{
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>
/// If set to &quot;RemotePeers&quot;: for export rules, this filter rule will only apply to routes
/// learned from BGP peers (i.e. re-advertised routes), not locally originated routes.
/// For import rules, this field is redundant because imported routes are by definition
/// from BGP peers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecExportV6SourceEnum>))]
public enum V1BGPFilterSpecExportV6SourceEnum
{
    [EnumMember(Value = "RemotePeers"), JsonStringEnumMemberName("RemotePeers")]
    RemotePeers
}

/// <summary>
/// BGPFilterRuleV6 defines a BGP filter rule consisting of match criteria, a terminal action,
/// and optional operations to apply to matching routes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecExportV6
{
    [JsonPropertyName("action")]
    public required V1BGPFilterSpecExportV6ActionEnum Action { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes whose AS path begins with the
    /// specified sequence of AS numbers.
    /// </summary>
    [JsonPropertyName("asPathPrefix")]
    public IList<long>? AsPathPrefix { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply when the route being exported or imported
    /// &quot;matches&quot; the given CIDR - where the definition of &quot;matches&quot; is according to
    /// MatchOperator and PrefixLength.  CIDR should be in conventional CIDR notation,
    /// &lt;prefix&gt;/&lt;length&gt;.
    /// </summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary>
    /// If set, this filter rule will only apply to routes that carry the specified BGP
    /// community.  On import, this matches communities set by the remote peer.  On export,
    /// this matches communities already present on the route, whether received from a BGP
    /// peer (e.g. on a route reflector re-advertising to an eBGP peer) or added locally
    /// by an import filter or an earlier export rule&apos;s AddCommunity operation.
    /// </summary>
    [JsonPropertyName("communities")]
    public V1BGPFilterSpecExportV6Communities? Communities { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes with an outgoing interface that
    /// matches Interface.
    /// </summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>
    /// MatchOperator defines how the route&apos;s prefix is compared against CIDR.  &quot;Equal&quot; requires
    /// an exact prefix match, &quot;In&quot; requires the route to be contained within the CIDR (or equal),
    /// &quot;NotEqual&quot; and &quot;NotIn&quot; are their negations.  Only meaningful when CIDR is also specified.
    /// Required when CIDR is set.
    /// </summary>
    [JsonPropertyName("matchOperator")]
    public V1BGPFilterSpecExportV6MatchOperatorEnum? MatchOperator { get; set; }

    /// <summary>
    /// Operations is an ordered list of route modifications to apply to matching routes before
    /// accepting them.  Only valid when Action is &quot;Accept&quot;; specifying operations with &quot;Reject&quot;
    /// is rejected by validation.  Each entry must set exactly one operation field.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1BGPFilterSpecExportV6Operations>? Operations { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes being imported from or exported
    /// to a BGP peer of the specified type.  If empty, the rule applies to all peers.
    /// </summary>
    [JsonPropertyName("peerType")]
    public V1BGPFilterSpecExportV6PeerTypeEnum? PeerType { get; set; }

    /// <summary>
    /// PrefixLength further constrains the CIDR match by restricting the range of allowed
    /// prefix lengths.  For example, CIDR &quot;fd00::/8&quot; with MatchOperator &quot;In&quot; and
    /// PrefixLength {min: 48, max: 64} matches any route within fd00::/8 whose prefix
    /// length is between /48 and /64.  Requires CIDR to be set; if CIDR is omitted,
    /// PrefixLength is ignored.  If PrefixLength is nil and CIDR is set, the CIDR&apos;s own
    /// prefix length is used as the minimum and /128 (for V6) as the maximum.
    /// </summary>
    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecExportV6PrefixLength? PrefixLength { get; set; }

    /// <summary>
    /// If set, this filter rule will only apply to routes with the given priority, in the
    /// same units as the ...RoutePriority fields in FelixConfiguration.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// If set to &quot;RemotePeers&quot;: for export rules, this filter rule will only apply to routes
    /// learned from BGP peers (i.e. re-advertised routes), not locally originated routes.
    /// For import rules, this field is redundant because imported routes are by definition
    /// from BGP peers.
    /// </summary>
    [JsonPropertyName("source")]
    public V1BGPFilterSpecExportV6SourceEnum? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV4ActionEnum>))]
public enum V1BGPFilterSpecImportV4ActionEnum
{
    [EnumMember(Value = "Accept"), JsonStringEnumMemberName("Accept")]
    Accept,
    [EnumMember(Value = "Reject"), JsonStringEnumMemberName("Reject")]
    Reject
}

/// <summary>
/// If set, this filter rule will only apply to routes that carry the specified BGP
/// community.  On import, this matches communities set by the remote peer.  On export,
/// this matches communities already present on the route, whether received from a BGP
/// peer (e.g. on a route reflector re-advertising to an eBGP peer) or added locally
/// by an import filter or an earlier export rule&apos;s AddCommunity operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4Communities
{
    /// <summary>Values is a list of BGP community values to match against. Exactly one value must be specified.</summary>
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

/// <summary>
/// MatchOperator defines how the route&apos;s prefix is compared against CIDR.  &quot;Equal&quot; requires
/// an exact prefix match, &quot;In&quot; requires the route to be contained within the CIDR (or equal),
/// &quot;NotEqual&quot; and &quot;NotIn&quot; are their negations.  Only meaningful when CIDR is also specified.
/// Required when CIDR is set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV4MatchOperatorEnum>))]
public enum V1BGPFilterSpecImportV4MatchOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "NotEqual"), JsonStringEnumMemberName("NotEqual")]
    NotEqual,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn
}

/// <summary>AddCommunity adds the specified BGP community to the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4OperationsAddCommunity
{
    /// <summary>Value is the BGP community to add.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>PrependASPath prepends the specified AS numbers to the route&apos;s AS path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4OperationsPrependASPath
{
    /// <summary>
    /// Prefix is the sequence of AS numbers to prepend to the route&apos;s AS path.
    /// The resulting path starts with these AS numbers in the order listed;
    /// e.g. [65000, 65001] produces the path &quot;65000 65001 &lt;original&gt; &quot;.
    /// </summary>
    [JsonPropertyName("prefix")]
    public required IList<long> Prefix { get; set; }
}

/// <summary>
/// SetPriority sets the route&apos;s priority (metric), in the same units as the
/// ...RoutePriority fields in FelixConfiguration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4OperationsSetPriority
{
    /// <summary>
    /// Value is the priority to set, in the same units as FelixConfiguration&apos;s
    /// ...RoutePriority fields.
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }
}

/// <summary>
/// BGPFilterOperation is a discriminated union representing a single route modification.
/// Exactly one field must be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4Operations
{
    /// <summary>AddCommunity adds the specified BGP community to the route.</summary>
    [JsonPropertyName("addCommunity")]
    public V1BGPFilterSpecImportV4OperationsAddCommunity? AddCommunity { get; set; }

    /// <summary>PrependASPath prepends the specified AS numbers to the route&apos;s AS path.</summary>
    [JsonPropertyName("prependASPath")]
    public V1BGPFilterSpecImportV4OperationsPrependASPath? PrependASPath { get; set; }

    /// <summary>
    /// SetPriority sets the route&apos;s priority (metric), in the same units as the
    /// ...RoutePriority fields in FelixConfiguration.
    /// </summary>
    [JsonPropertyName("setPriority")]
    public V1BGPFilterSpecImportV4OperationsSetPriority? SetPriority { get; set; }
}

/// <summary>
/// If non-empty, this filter rule will only apply to routes being imported from or exported
/// to a BGP peer of the specified type.  If empty, the rule applies to all peers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV4PeerTypeEnum>))]
public enum V1BGPFilterSpecImportV4PeerTypeEnum
{
    [EnumMember(Value = "eBGP"), JsonStringEnumMemberName("eBGP")]
    EBGP,
    [EnumMember(Value = "iBGP"), JsonStringEnumMemberName("iBGP")]
    IBGP
}

/// <summary>
/// PrefixLength further constrains the CIDR match by restricting the range of allowed
/// prefix lengths.  For example, CIDR &quot;10.0.0.0/8&quot; with MatchOperator &quot;In&quot; and
/// PrefixLength {min: 16, max: 24} matches any route within 10.0.0.0/8 whose prefix
/// length is between /16 and /24.  Requires CIDR to be set; if CIDR is omitted,
/// PrefixLength is ignored.  If PrefixLength is nil and CIDR is set, the CIDR&apos;s own
/// prefix length is used as the minimum and /32 (for V4) as the maximum.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4PrefixLength
{
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>
/// If set to &quot;RemotePeers&quot;: for export rules, this filter rule will only apply to routes
/// learned from BGP peers (i.e. re-advertised routes), not locally originated routes.
/// For import rules, this field is redundant because imported routes are by definition
/// from BGP peers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV4SourceEnum>))]
public enum V1BGPFilterSpecImportV4SourceEnum
{
    [EnumMember(Value = "RemotePeers"), JsonStringEnumMemberName("RemotePeers")]
    RemotePeers
}

/// <summary>
/// BGPFilterRuleV4 defines a BGP filter rule consisting of match criteria, a terminal action,
/// and optional operations to apply to matching routes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV4
{
    [JsonPropertyName("action")]
    public required V1BGPFilterSpecImportV4ActionEnum Action { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes whose AS path begins with the
    /// specified sequence of AS numbers.
    /// </summary>
    [JsonPropertyName("asPathPrefix")]
    public IList<long>? AsPathPrefix { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply when the route being exported or imported
    /// &quot;matches&quot; the given CIDR - where the definition of &quot;matches&quot; is according to
    /// MatchOperator and PrefixLength.  CIDR should be in conventional CIDR notation,
    /// &lt;prefix&gt;/&lt;length&gt;.
    /// </summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary>
    /// If set, this filter rule will only apply to routes that carry the specified BGP
    /// community.  On import, this matches communities set by the remote peer.  On export,
    /// this matches communities already present on the route, whether received from a BGP
    /// peer (e.g. on a route reflector re-advertising to an eBGP peer) or added locally
    /// by an import filter or an earlier export rule&apos;s AddCommunity operation.
    /// </summary>
    [JsonPropertyName("communities")]
    public V1BGPFilterSpecImportV4Communities? Communities { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes with an outgoing interface that
    /// matches Interface.
    /// </summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>
    /// MatchOperator defines how the route&apos;s prefix is compared against CIDR.  &quot;Equal&quot; requires
    /// an exact prefix match, &quot;In&quot; requires the route to be contained within the CIDR (or equal),
    /// &quot;NotEqual&quot; and &quot;NotIn&quot; are their negations.  Only meaningful when CIDR is also specified.
    /// Required when CIDR is set.
    /// </summary>
    [JsonPropertyName("matchOperator")]
    public V1BGPFilterSpecImportV4MatchOperatorEnum? MatchOperator { get; set; }

    /// <summary>
    /// Operations is an ordered list of route modifications to apply to matching routes before
    /// accepting them.  Only valid when Action is &quot;Accept&quot;; specifying operations with &quot;Reject&quot;
    /// is rejected by validation.  Each entry must set exactly one operation field.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1BGPFilterSpecImportV4Operations>? Operations { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes being imported from or exported
    /// to a BGP peer of the specified type.  If empty, the rule applies to all peers.
    /// </summary>
    [JsonPropertyName("peerType")]
    public V1BGPFilterSpecImportV4PeerTypeEnum? PeerType { get; set; }

    /// <summary>
    /// PrefixLength further constrains the CIDR match by restricting the range of allowed
    /// prefix lengths.  For example, CIDR &quot;10.0.0.0/8&quot; with MatchOperator &quot;In&quot; and
    /// PrefixLength {min: 16, max: 24} matches any route within 10.0.0.0/8 whose prefix
    /// length is between /16 and /24.  Requires CIDR to be set; if CIDR is omitted,
    /// PrefixLength is ignored.  If PrefixLength is nil and CIDR is set, the CIDR&apos;s own
    /// prefix length is used as the minimum and /32 (for V4) as the maximum.
    /// </summary>
    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecImportV4PrefixLength? PrefixLength { get; set; }

    /// <summary>
    /// If set, this filter rule will only apply to routes with the given priority, in the
    /// same units as the ...RoutePriority fields in FelixConfiguration.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// If set to &quot;RemotePeers&quot;: for export rules, this filter rule will only apply to routes
    /// learned from BGP peers (i.e. re-advertised routes), not locally originated routes.
    /// For import rules, this field is redundant because imported routes are by definition
    /// from BGP peers.
    /// </summary>
    [JsonPropertyName("source")]
    public V1BGPFilterSpecImportV4SourceEnum? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV6ActionEnum>))]
public enum V1BGPFilterSpecImportV6ActionEnum
{
    [EnumMember(Value = "Accept"), JsonStringEnumMemberName("Accept")]
    Accept,
    [EnumMember(Value = "Reject"), JsonStringEnumMemberName("Reject")]
    Reject
}

/// <summary>
/// If set, this filter rule will only apply to routes that carry the specified BGP
/// community.  On import, this matches communities set by the remote peer.  On export,
/// this matches communities already present on the route, whether received from a BGP
/// peer (e.g. on a route reflector re-advertising to an eBGP peer) or added locally
/// by an import filter or an earlier export rule&apos;s AddCommunity operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6Communities
{
    /// <summary>Values is a list of BGP community values to match against. Exactly one value must be specified.</summary>
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

/// <summary>
/// MatchOperator defines how the route&apos;s prefix is compared against CIDR.  &quot;Equal&quot; requires
/// an exact prefix match, &quot;In&quot; requires the route to be contained within the CIDR (or equal),
/// &quot;NotEqual&quot; and &quot;NotIn&quot; are their negations.  Only meaningful when CIDR is also specified.
/// Required when CIDR is set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV6MatchOperatorEnum>))]
public enum V1BGPFilterSpecImportV6MatchOperatorEnum
{
    [EnumMember(Value = "Equal"), JsonStringEnumMemberName("Equal")]
    Equal,
    [EnumMember(Value = "NotEqual"), JsonStringEnumMemberName("NotEqual")]
    NotEqual,
    [EnumMember(Value = "In"), JsonStringEnumMemberName("In")]
    In,
    [EnumMember(Value = "NotIn"), JsonStringEnumMemberName("NotIn")]
    NotIn
}

/// <summary>AddCommunity adds the specified BGP community to the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6OperationsAddCommunity
{
    /// <summary>Value is the BGP community to add.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>PrependASPath prepends the specified AS numbers to the route&apos;s AS path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6OperationsPrependASPath
{
    /// <summary>
    /// Prefix is the sequence of AS numbers to prepend to the route&apos;s AS path.
    /// The resulting path starts with these AS numbers in the order listed;
    /// e.g. [65000, 65001] produces the path &quot;65000 65001 &lt;original&gt; &quot;.
    /// </summary>
    [JsonPropertyName("prefix")]
    public required IList<long> Prefix { get; set; }
}

/// <summary>
/// SetPriority sets the route&apos;s priority (metric), in the same units as the
/// ...RoutePriority fields in FelixConfiguration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6OperationsSetPriority
{
    /// <summary>
    /// Value is the priority to set, in the same units as FelixConfiguration&apos;s
    /// ...RoutePriority fields.
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }
}

/// <summary>
/// BGPFilterOperation is a discriminated union representing a single route modification.
/// Exactly one field must be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6Operations
{
    /// <summary>AddCommunity adds the specified BGP community to the route.</summary>
    [JsonPropertyName("addCommunity")]
    public V1BGPFilterSpecImportV6OperationsAddCommunity? AddCommunity { get; set; }

    /// <summary>PrependASPath prepends the specified AS numbers to the route&apos;s AS path.</summary>
    [JsonPropertyName("prependASPath")]
    public V1BGPFilterSpecImportV6OperationsPrependASPath? PrependASPath { get; set; }

    /// <summary>
    /// SetPriority sets the route&apos;s priority (metric), in the same units as the
    /// ...RoutePriority fields in FelixConfiguration.
    /// </summary>
    [JsonPropertyName("setPriority")]
    public V1BGPFilterSpecImportV6OperationsSetPriority? SetPriority { get; set; }
}

/// <summary>
/// If non-empty, this filter rule will only apply to routes being imported from or exported
/// to a BGP peer of the specified type.  If empty, the rule applies to all peers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV6PeerTypeEnum>))]
public enum V1BGPFilterSpecImportV6PeerTypeEnum
{
    [EnumMember(Value = "eBGP"), JsonStringEnumMemberName("eBGP")]
    EBGP,
    [EnumMember(Value = "iBGP"), JsonStringEnumMemberName("iBGP")]
    IBGP
}

/// <summary>
/// PrefixLength further constrains the CIDR match by restricting the range of allowed
/// prefix lengths.  For example, CIDR &quot;fd00::/8&quot; with MatchOperator &quot;In&quot; and
/// PrefixLength {min: 48, max: 64} matches any route within fd00::/8 whose prefix
/// length is between /48 and /64.  Requires CIDR to be set; if CIDR is omitted,
/// PrefixLength is ignored.  If PrefixLength is nil and CIDR is set, the CIDR&apos;s own
/// prefix length is used as the minimum and /128 (for V6) as the maximum.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6PrefixLength
{
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>
/// If set to &quot;RemotePeers&quot;: for export rules, this filter rule will only apply to routes
/// learned from BGP peers (i.e. re-advertised routes), not locally originated routes.
/// For import rules, this field is redundant because imported routes are by definition
/// from BGP peers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BGPFilterSpecImportV6SourceEnum>))]
public enum V1BGPFilterSpecImportV6SourceEnum
{
    [EnumMember(Value = "RemotePeers"), JsonStringEnumMemberName("RemotePeers")]
    RemotePeers
}

/// <summary>
/// BGPFilterRuleV6 defines a BGP filter rule consisting of match criteria, a terminal action,
/// and optional operations to apply to matching routes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpecImportV6
{
    [JsonPropertyName("action")]
    public required V1BGPFilterSpecImportV6ActionEnum Action { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes whose AS path begins with the
    /// specified sequence of AS numbers.
    /// </summary>
    [JsonPropertyName("asPathPrefix")]
    public IList<long>? AsPathPrefix { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply when the route being exported or imported
    /// &quot;matches&quot; the given CIDR - where the definition of &quot;matches&quot; is according to
    /// MatchOperator and PrefixLength.  CIDR should be in conventional CIDR notation,
    /// &lt;prefix&gt;/&lt;length&gt;.
    /// </summary>
    [JsonPropertyName("cidr")]
    public string? Cidr { get; set; }

    /// <summary>
    /// If set, this filter rule will only apply to routes that carry the specified BGP
    /// community.  On import, this matches communities set by the remote peer.  On export,
    /// this matches communities already present on the route, whether received from a BGP
    /// peer (e.g. on a route reflector re-advertising to an eBGP peer) or added locally
    /// by an import filter or an earlier export rule&apos;s AddCommunity operation.
    /// </summary>
    [JsonPropertyName("communities")]
    public V1BGPFilterSpecImportV6Communities? Communities { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes with an outgoing interface that
    /// matches Interface.
    /// </summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>
    /// MatchOperator defines how the route&apos;s prefix is compared against CIDR.  &quot;Equal&quot; requires
    /// an exact prefix match, &quot;In&quot; requires the route to be contained within the CIDR (or equal),
    /// &quot;NotEqual&quot; and &quot;NotIn&quot; are their negations.  Only meaningful when CIDR is also specified.
    /// Required when CIDR is set.
    /// </summary>
    [JsonPropertyName("matchOperator")]
    public V1BGPFilterSpecImportV6MatchOperatorEnum? MatchOperator { get; set; }

    /// <summary>
    /// Operations is an ordered list of route modifications to apply to matching routes before
    /// accepting them.  Only valid when Action is &quot;Accept&quot;; specifying operations with &quot;Reject&quot;
    /// is rejected by validation.  Each entry must set exactly one operation field.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<V1BGPFilterSpecImportV6Operations>? Operations { get; set; }

    /// <summary>
    /// If non-empty, this filter rule will only apply to routes being imported from or exported
    /// to a BGP peer of the specified type.  If empty, the rule applies to all peers.
    /// </summary>
    [JsonPropertyName("peerType")]
    public V1BGPFilterSpecImportV6PeerTypeEnum? PeerType { get; set; }

    /// <summary>
    /// PrefixLength further constrains the CIDR match by restricting the range of allowed
    /// prefix lengths.  For example, CIDR &quot;fd00::/8&quot; with MatchOperator &quot;In&quot; and
    /// PrefixLength {min: 48, max: 64} matches any route within fd00::/8 whose prefix
    /// length is between /48 and /64.  Requires CIDR to be set; if CIDR is omitted,
    /// PrefixLength is ignored.  If PrefixLength is nil and CIDR is set, the CIDR&apos;s own
    /// prefix length is used as the minimum and /128 (for V6) as the maximum.
    /// </summary>
    [JsonPropertyName("prefixLength")]
    public V1BGPFilterSpecImportV6PrefixLength? PrefixLength { get; set; }

    /// <summary>
    /// If set, this filter rule will only apply to routes with the given priority, in the
    /// same units as the ...RoutePriority fields in FelixConfiguration.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// If set to &quot;RemotePeers&quot;: for export rules, this filter rule will only apply to routes
    /// learned from BGP peers (i.e. re-advertised routes), not locally originated routes.
    /// For import rules, this field is redundant because imported routes are by definition
    /// from BGP peers.
    /// </summary>
    [JsonPropertyName("source")]
    public V1BGPFilterSpecImportV6SourceEnum? Source { get; set; }
}

/// <summary>BGPFilterSpec contains the IPv4 and IPv6 filter rules of the BGP Filter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BGPFilterSpec
{
    /// <summary>The ordered set of IPv4 BGPFilter rules acting on exporting routes to a peer.</summary>
    [JsonPropertyName("exportV4")]
    public IList<V1BGPFilterSpecExportV4>? ExportV4 { get; set; }

    /// <summary>The ordered set of IPv6 BGPFilter rules acting on exporting routes to a peer.</summary>
    [JsonPropertyName("exportV6")]
    public IList<V1BGPFilterSpecExportV6>? ExportV6 { get; set; }

    /// <summary>The ordered set of IPv4 BGPFilter rules acting on importing routes from a peer.</summary>
    [JsonPropertyName("importV4")]
    public IList<V1BGPFilterSpecImportV4>? ImportV4 { get; set; }

    /// <summary>The ordered set of IPv6 BGPFilter rules acting on importing routes from a peer.</summary>
    [JsonPropertyName("importV6")]
    public IList<V1BGPFilterSpecImportV6>? ImportV6 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPFilter : IKubernetesObject<V1ObjectMeta>, ISpec<V1BGPFilterSpec?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPFilter";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgpfilters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BGPFilter";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BGPFilterSpec contains the IPv4 and IPv6 filter rules of the BGP Filter.</summary>
    [JsonPropertyName("spec")]
    public V1BGPFilterSpec? Spec { get; set; }
}