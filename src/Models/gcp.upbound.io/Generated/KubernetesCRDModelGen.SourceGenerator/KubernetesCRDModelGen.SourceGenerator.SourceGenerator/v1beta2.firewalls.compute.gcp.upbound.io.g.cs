#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>Firewall is the Schema for the Firewalls API. Each network has its own firewall controlling access to and from the instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FirewallList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Firewall>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FirewallList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "firewalls";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirewallList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Firewall objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Firewall> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecDeletionPolicyEnum>))]
public enum V1beta2FirewallSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecForProviderAllow
{
    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// Example inputs include: [22], [80, 443], and
    /// [&quot;12345-12349&quot;].
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecForProviderDeny
{
    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// Example inputs include: [22], [80, 443], and
    /// [&quot;12345-12349&quot;].
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// This field denotes the logging options for a particular firewall rule.
/// If defined, logging is enabled, and logs will be exported to Cloud Logging.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecForProviderLogConfig
{
    /// <summary>
    /// This field denotes whether to include or exclude metadata for firewall logs.
    /// Possible values are: EXCLUDE_ALL_METADATA, INCLUDE_ALL_METADATA.
    /// </summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecForProviderNetworkRefPolicyResolutionEnum>))]
public enum V1beta2FirewallSpecForProviderNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecForProviderNetworkRefPolicyResolveEnum>))]
public enum V1beta2FirewallSpecForProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecForProviderNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallSpecForProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallSpecForProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecForProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FirewallSpecForProviderNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecForProviderNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2FirewallSpecForProviderNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecForProviderNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2FirewallSpecForProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecForProviderNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallSpecForProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallSpecForProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecForProviderNetworkSelector
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
    public V1beta2FirewallSpecForProviderNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Additional params passed with the request, but not persisted as part of resource payload
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecForProviderParams
{
    /// <summary>
    /// Resource manager tags to be bound to the firewall. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is ignored when empty.
    /// The field is immutable and causes resource replacement when mutated. This field is only
    /// set at create time and modifying this field after creation will trigger recreation.
    /// To apply tags to an existing resource, see the google_tags_tag_binding resource.
    /// </summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecForProvider
{
    /// <summary>
    /// The list of ALLOW rules specified by this firewall. Each rule
    /// specifies a protocol and port-range tuple that describes a permitted
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("allow")]
    public IList<V1beta2FirewallSpecForProviderAllow>? Allow { get; set; }

    /// <summary>
    /// The list of DENY rules specified by this firewall. Each rule specifies
    /// a protocol and port-range tuple that describes a denied connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deny")]
    public IList<V1beta2FirewallSpecForProviderDeny>? Deny { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If destination ranges are specified, the firewall will apply only to
    /// traffic that has destination IP address in these ranges. These ranges
    /// must be expressed in CIDR format. IPv4 or IPv6 ranges are supported.
    /// </summary>
    [JsonPropertyName("destinationRanges")]
    public IList<string>? DestinationRanges { get; set; }

    /// <summary>
    /// Direction of traffic to which this firewall applies; default is
    /// INGRESS. Note: For INGRESS traffic, one of source_ranges,
    /// source_tags or source_service_accounts is required.
    /// Possible values are: INGRESS, EGRESS.
    /// </summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>
    /// Denotes whether the firewall rule is disabled, i.e not applied to the
    /// network it is associated with. When set to true, the firewall rule is
    /// not enforced and the network behaves as if it did not exist. If this
    /// is unspecified, the firewall rule will be enabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// This field denotes whether to enable logging for a particular firewall rule.
    /// If logging is enabled, logs will be exported to Stackdriver. Deprecated in favor of log_config
    /// </summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>
    /// This field denotes the logging options for a particular firewall rule.
    /// If defined, logging is enabled, and logs will be exported to Cloud Logging.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2FirewallSpecForProviderLogConfig? LogConfig { get; set; }

    /// <summary>The name or self_link of the network to attach this firewall to.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta2FirewallSpecForProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta2FirewallSpecForProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("params")]
    public V1beta2FirewallSpecForProviderParams? Params { get; set; }

    /// <summary>
    /// Priority for this rule. This is an integer between 0 and 65535, both
    /// inclusive. When not specified, the value assumed is 1000. Relative
    /// priorities determine precedence of conflicting rules. Lower value of
    /// priority implies higher precedence (eg, a rule with priority 0 has
    /// higher precedence than a rule with priority 1). DENY rules take
    /// precedence over ALLOW rules having equal priority.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// If source ranges are specified, the firewall will apply only to
    /// traffic that has source IP address in these ranges. These ranges must
    /// be expressed in CIDR format. One or both of sourceRanges and
    /// sourceTags may be set. If both properties are set, the firewall will
    /// apply to traffic that has source IP address within sourceRanges OR the
    /// source IP that belongs to a tag listed in the sourceTags property. The
    /// connection does not need to match both properties for the firewall to
    /// apply. IPv4 or IPv6 ranges are supported. For INGRESS traffic, one of
    /// source_ranges, source_tags or source_service_accounts is required.
    /// </summary>
    [JsonPropertyName("sourceRanges")]
    public IList<string>? SourceRanges { get; set; }

    /// <summary>
    /// If source service accounts are specified, the firewall will apply only
    /// to traffic originating from an instance with a service account in this
    /// list. Source service accounts cannot be used to control traffic to an
    /// instance&apos;s external IP address because service accounts are associated
    /// with an instance, not an IP address. sourceRanges can be set at the
    /// same time as sourceServiceAccounts. If both are set, the firewall will
    /// apply to traffic that has source IP address within sourceRanges OR the
    /// source IP belongs to an instance with service account listed in
    /// sourceServiceAccount. The connection does not need to match both
    /// properties for the firewall to apply. sourceServiceAccounts cannot be
    /// used at the same time as sourceTags or targetTags. For INGRESS traffic,
    /// one of source_ranges, source_tags or source_service_accounts is required.
    /// </summary>
    [JsonPropertyName("sourceServiceAccounts")]
    public IList<string>? SourceServiceAccounts { get; set; }

    /// <summary>
    /// If source tags are specified, the firewall will apply only to traffic
    /// with source IP that belongs to a tag listed in source tags. Source
    /// tags cannot be used to control traffic to an instance&apos;s external IP
    /// address. Because tags are associated with an instance, not an IP
    /// address. One or both of sourceRanges and sourceTags may be set. If
    /// both properties are set, the firewall will apply to traffic that has
    /// source IP address within sourceRanges OR the source IP that belongs to
    /// a tag listed in the sourceTags property. The connection does not need
    /// to match both properties for the firewall to apply. For INGRESS traffic,
    /// one of source_ranges, source_tags or source_service_accounts is required.
    /// </summary>
    [JsonPropertyName("sourceTags")]
    public IList<string>? SourceTags { get; set; }

    /// <summary>
    /// A list of service accounts indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// targetServiceAccounts cannot be used at the same time as targetTags or
    /// sourceTags. If neither targetServiceAccounts nor targetTags are
    /// specified, the firewall rule applies to all instances on the specified
    /// network.
    /// </summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }

    /// <summary>
    /// A list of instance tags indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// If no targetTags are specified, the firewall rule applies to all
    /// instances on the specified network.
    /// </summary>
    [JsonPropertyName("targetTags")]
    public IList<string>? TargetTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecInitProviderAllow
{
    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// Example inputs include: [22], [80, 443], and
    /// [&quot;12345-12349&quot;].
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecInitProviderDeny
{
    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// Example inputs include: [22], [80, 443], and
    /// [&quot;12345-12349&quot;].
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// This field denotes the logging options for a particular firewall rule.
/// If defined, logging is enabled, and logs will be exported to Cloud Logging.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecInitProviderLogConfig
{
    /// <summary>
    /// This field denotes whether to include or exclude metadata for firewall logs.
    /// Possible values are: EXCLUDE_ALL_METADATA, INCLUDE_ALL_METADATA.
    /// </summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecInitProviderNetworkRefPolicyResolutionEnum>))]
public enum V1beta2FirewallSpecInitProviderNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecInitProviderNetworkRefPolicyResolveEnum>))]
public enum V1beta2FirewallSpecInitProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecInitProviderNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallSpecInitProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallSpecInitProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecInitProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FirewallSpecInitProviderNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecInitProviderNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2FirewallSpecInitProviderNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecInitProviderNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2FirewallSpecInitProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecInitProviderNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallSpecInitProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallSpecInitProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecInitProviderNetworkSelector
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
    public V1beta2FirewallSpecInitProviderNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Additional params passed with the request, but not persisted as part of resource payload
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecInitProviderParams
{
    /// <summary>
    /// Resource manager tags to be bound to the firewall. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is ignored when empty.
    /// The field is immutable and causes resource replacement when mutated. This field is only
    /// set at create time and modifying this field after creation will trigger recreation.
    /// To apply tags to an existing resource, see the google_tags_tag_binding resource.
    /// </summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
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
public partial class V1beta2FirewallSpecInitProvider
{
    /// <summary>
    /// The list of ALLOW rules specified by this firewall. Each rule
    /// specifies a protocol and port-range tuple that describes a permitted
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("allow")]
    public IList<V1beta2FirewallSpecInitProviderAllow>? Allow { get; set; }

    /// <summary>
    /// The list of DENY rules specified by this firewall. Each rule specifies
    /// a protocol and port-range tuple that describes a denied connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deny")]
    public IList<V1beta2FirewallSpecInitProviderDeny>? Deny { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If destination ranges are specified, the firewall will apply only to
    /// traffic that has destination IP address in these ranges. These ranges
    /// must be expressed in CIDR format. IPv4 or IPv6 ranges are supported.
    /// </summary>
    [JsonPropertyName("destinationRanges")]
    public IList<string>? DestinationRanges { get; set; }

    /// <summary>
    /// Direction of traffic to which this firewall applies; default is
    /// INGRESS. Note: For INGRESS traffic, one of source_ranges,
    /// source_tags or source_service_accounts is required.
    /// Possible values are: INGRESS, EGRESS.
    /// </summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>
    /// Denotes whether the firewall rule is disabled, i.e not applied to the
    /// network it is associated with. When set to true, the firewall rule is
    /// not enforced and the network behaves as if it did not exist. If this
    /// is unspecified, the firewall rule will be enabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// This field denotes whether to enable logging for a particular firewall rule.
    /// If logging is enabled, logs will be exported to Stackdriver. Deprecated in favor of log_config
    /// </summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>
    /// This field denotes the logging options for a particular firewall rule.
    /// If defined, logging is enabled, and logs will be exported to Cloud Logging.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2FirewallSpecInitProviderLogConfig? LogConfig { get; set; }

    /// <summary>The name or self_link of the network to attach this firewall to.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta2FirewallSpecInitProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta2FirewallSpecInitProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("params")]
    public V1beta2FirewallSpecInitProviderParams? Params { get; set; }

    /// <summary>
    /// Priority for this rule. This is an integer between 0 and 65535, both
    /// inclusive. When not specified, the value assumed is 1000. Relative
    /// priorities determine precedence of conflicting rules. Lower value of
    /// priority implies higher precedence (eg, a rule with priority 0 has
    /// higher precedence than a rule with priority 1). DENY rules take
    /// precedence over ALLOW rules having equal priority.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// If source ranges are specified, the firewall will apply only to
    /// traffic that has source IP address in these ranges. These ranges must
    /// be expressed in CIDR format. One or both of sourceRanges and
    /// sourceTags may be set. If both properties are set, the firewall will
    /// apply to traffic that has source IP address within sourceRanges OR the
    /// source IP that belongs to a tag listed in the sourceTags property. The
    /// connection does not need to match both properties for the firewall to
    /// apply. IPv4 or IPv6 ranges are supported. For INGRESS traffic, one of
    /// source_ranges, source_tags or source_service_accounts is required.
    /// </summary>
    [JsonPropertyName("sourceRanges")]
    public IList<string>? SourceRanges { get; set; }

    /// <summary>
    /// If source service accounts are specified, the firewall will apply only
    /// to traffic originating from an instance with a service account in this
    /// list. Source service accounts cannot be used to control traffic to an
    /// instance&apos;s external IP address because service accounts are associated
    /// with an instance, not an IP address. sourceRanges can be set at the
    /// same time as sourceServiceAccounts. If both are set, the firewall will
    /// apply to traffic that has source IP address within sourceRanges OR the
    /// source IP belongs to an instance with service account listed in
    /// sourceServiceAccount. The connection does not need to match both
    /// properties for the firewall to apply. sourceServiceAccounts cannot be
    /// used at the same time as sourceTags or targetTags. For INGRESS traffic,
    /// one of source_ranges, source_tags or source_service_accounts is required.
    /// </summary>
    [JsonPropertyName("sourceServiceAccounts")]
    public IList<string>? SourceServiceAccounts { get; set; }

    /// <summary>
    /// If source tags are specified, the firewall will apply only to traffic
    /// with source IP that belongs to a tag listed in source tags. Source
    /// tags cannot be used to control traffic to an instance&apos;s external IP
    /// address. Because tags are associated with an instance, not an IP
    /// address. One or both of sourceRanges and sourceTags may be set. If
    /// both properties are set, the firewall will apply to traffic that has
    /// source IP address within sourceRanges OR the source IP that belongs to
    /// a tag listed in the sourceTags property. The connection does not need
    /// to match both properties for the firewall to apply. For INGRESS traffic,
    /// one of source_ranges, source_tags or source_service_accounts is required.
    /// </summary>
    [JsonPropertyName("sourceTags")]
    public IList<string>? SourceTags { get; set; }

    /// <summary>
    /// A list of service accounts indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// targetServiceAccounts cannot be used at the same time as targetTags or
    /// sourceTags. If neither targetServiceAccounts nor targetTags are
    /// specified, the firewall rule applies to all instances on the specified
    /// network.
    /// </summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }

    /// <summary>
    /// A list of instance tags indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// If no targetTags are specified, the firewall rule applies to all
    /// instances on the specified network.
    /// </summary>
    [JsonPropertyName("targetTags")]
    public IList<string>? TargetTags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecManagementPoliciesEnum>))]
public enum V1beta2FirewallSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FirewallSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FirewallSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FirewallSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FirewallSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FirewallSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FirewallSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FirewallSpec defines the desired state of Firewall</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallSpec
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
    public V1beta2FirewallSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FirewallSpecForProvider ForProvider { get; set; }

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
    public V1beta2FirewallSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FirewallSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FirewallSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FirewallSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallStatusAtProviderAllow
{
    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// Example inputs include: [22], [80, 443], and
    /// [&quot;12345-12349&quot;].
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallStatusAtProviderDeny
{
    /// <summary>
    /// An optional list of ports to which this rule applies. This field
    /// is only applicable for UDP or TCP protocol. Each entry must be
    /// either an integer or a range. If not specified, this rule
    /// applies to connections through any port.
    /// Example inputs include: [22], [80, 443], and
    /// [&quot;12345-12349&quot;].
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<string>? Ports { get; set; }

    /// <summary>
    /// The IP protocol to which this rule applies. The protocol type is
    /// required when creating a firewall rule. This value can either be
    /// one of the following well known protocol strings (tcp, udp,
    /// icmp, esp, ah, sctp, ipip, all), or the IP protocol number.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// This field denotes the logging options for a particular firewall rule.
/// If defined, logging is enabled, and logs will be exported to Cloud Logging.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallStatusAtProviderLogConfig
{
    /// <summary>
    /// This field denotes whether to include or exclude metadata for firewall logs.
    /// Possible values are: EXCLUDE_ALL_METADATA, INCLUDE_ALL_METADATA.
    /// </summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Additional params passed with the request, but not persisted as part of resource payload
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallStatusAtProviderParams
{
    /// <summary>
    /// Resource manager tags to be bound to the firewall. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is ignored when empty.
    /// The field is immutable and causes resource replacement when mutated. This field is only
    /// set at create time and modifying this field after creation will trigger recreation.
    /// To apply tags to an existing resource, see the google_tags_tag_binding resource.
    /// </summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallStatusAtProvider
{
    /// <summary>
    /// The list of ALLOW rules specified by this firewall. Each rule
    /// specifies a protocol and port-range tuple that describes a permitted
    /// connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("allow")]
    public IList<V1beta2FirewallStatusAtProviderAllow>? Allow { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>
    /// The list of DENY rules specified by this firewall. Each rule specifies
    /// a protocol and port-range tuple that describes a denied connection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deny")]
    public IList<V1beta2FirewallStatusAtProviderDeny>? Deny { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If destination ranges are specified, the firewall will apply only to
    /// traffic that has destination IP address in these ranges. These ranges
    /// must be expressed in CIDR format. IPv4 or IPv6 ranges are supported.
    /// </summary>
    [JsonPropertyName("destinationRanges")]
    public IList<string>? DestinationRanges { get; set; }

    /// <summary>
    /// Direction of traffic to which this firewall applies; default is
    /// INGRESS. Note: For INGRESS traffic, one of source_ranges,
    /// source_tags or source_service_accounts is required.
    /// Possible values are: INGRESS, EGRESS.
    /// </summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>
    /// Denotes whether the firewall rule is disabled, i.e not applied to the
    /// network it is associated with. When set to true, the firewall rule is
    /// not enforced and the network behaves as if it did not exist. If this
    /// is unspecified, the firewall rule will be enabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// This field denotes whether to enable logging for a particular firewall rule.
    /// If logging is enabled, logs will be exported to Stackdriver. Deprecated in favor of log_config
    /// </summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/firewalls/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// This field denotes the logging options for a particular firewall rule.
    /// If defined, logging is enabled, and logs will be exported to Cloud Logging.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2FirewallStatusAtProviderLogConfig? LogConfig { get; set; }

    /// <summary>The name or self_link of the network to attach this firewall to.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("params")]
    public V1beta2FirewallStatusAtProviderParams? Params { get; set; }

    /// <summary>
    /// Priority for this rule. This is an integer between 0 and 65535, both
    /// inclusive. When not specified, the value assumed is 1000. Relative
    /// priorities determine precedence of conflicting rules. Lower value of
    /// priority implies higher precedence (eg, a rule with priority 0 has
    /// higher precedence than a rule with priority 1). DENY rules take
    /// precedence over ALLOW rules having equal priority.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// If source ranges are specified, the firewall will apply only to
    /// traffic that has source IP address in these ranges. These ranges must
    /// be expressed in CIDR format. One or both of sourceRanges and
    /// sourceTags may be set. If both properties are set, the firewall will
    /// apply to traffic that has source IP address within sourceRanges OR the
    /// source IP that belongs to a tag listed in the sourceTags property. The
    /// connection does not need to match both properties for the firewall to
    /// apply. IPv4 or IPv6 ranges are supported. For INGRESS traffic, one of
    /// source_ranges, source_tags or source_service_accounts is required.
    /// </summary>
    [JsonPropertyName("sourceRanges")]
    public IList<string>? SourceRanges { get; set; }

    /// <summary>
    /// If source service accounts are specified, the firewall will apply only
    /// to traffic originating from an instance with a service account in this
    /// list. Source service accounts cannot be used to control traffic to an
    /// instance&apos;s external IP address because service accounts are associated
    /// with an instance, not an IP address. sourceRanges can be set at the
    /// same time as sourceServiceAccounts. If both are set, the firewall will
    /// apply to traffic that has source IP address within sourceRanges OR the
    /// source IP belongs to an instance with service account listed in
    /// sourceServiceAccount. The connection does not need to match both
    /// properties for the firewall to apply. sourceServiceAccounts cannot be
    /// used at the same time as sourceTags or targetTags. For INGRESS traffic,
    /// one of source_ranges, source_tags or source_service_accounts is required.
    /// </summary>
    [JsonPropertyName("sourceServiceAccounts")]
    public IList<string>? SourceServiceAccounts { get; set; }

    /// <summary>
    /// If source tags are specified, the firewall will apply only to traffic
    /// with source IP that belongs to a tag listed in source tags. Source
    /// tags cannot be used to control traffic to an instance&apos;s external IP
    /// address. Because tags are associated with an instance, not an IP
    /// address. One or both of sourceRanges and sourceTags may be set. If
    /// both properties are set, the firewall will apply to traffic that has
    /// source IP address within sourceRanges OR the source IP that belongs to
    /// a tag listed in the sourceTags property. The connection does not need
    /// to match both properties for the firewall to apply. For INGRESS traffic,
    /// one of source_ranges, source_tags or source_service_accounts is required.
    /// </summary>
    [JsonPropertyName("sourceTags")]
    public IList<string>? SourceTags { get; set; }

    /// <summary>
    /// A list of service accounts indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// targetServiceAccounts cannot be used at the same time as targetTags or
    /// sourceTags. If neither targetServiceAccounts nor targetTags are
    /// specified, the firewall rule applies to all instances on the specified
    /// network.
    /// </summary>
    [JsonPropertyName("targetServiceAccounts")]
    public IList<string>? TargetServiceAccounts { get; set; }

    /// <summary>
    /// A list of instance tags indicating sets of instances located in the
    /// network that may make network connections as specified in allowed[].
    /// If no targetTags are specified, the firewall rule applies to all
    /// instances on the specified network.
    /// </summary>
    [JsonPropertyName("targetTags")]
    public IList<string>? TargetTags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallStatusConditions
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

/// <summary>FirewallStatus defines the observed state of Firewall.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FirewallStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FirewallStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FirewallStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Firewall is the Schema for the Firewalls API. Each network has its own firewall controlling access to and from the instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Firewall : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FirewallSpec>, IStatus<V1beta2FirewallStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Firewall";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "firewalls";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Firewall";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FirewallSpec defines the desired state of Firewall</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FirewallSpec Spec { get; set; }

    /// <summary>FirewallStatus defines the observed state of Firewall.</summary>
    [JsonPropertyName("status")]
    public V1beta2FirewallStatus? Status { get; set; }
}