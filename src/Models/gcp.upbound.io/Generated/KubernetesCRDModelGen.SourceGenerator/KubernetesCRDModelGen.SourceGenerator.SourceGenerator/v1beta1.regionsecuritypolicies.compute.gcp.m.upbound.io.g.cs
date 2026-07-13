#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.m.upbound.io;
/// <summary>RegionSecurityPolicy is the Schema for the RegionSecurityPolicys API. Represents a Region Cloud Armor Security Policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionSecurityPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RegionSecurityPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionSecurityPolicyList";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "regionsecuritypolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionSecurityPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1RegionSecurityPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1RegionSecurityPolicy> Items { get; set; }
}

/// <summary>
/// Configuration for Google Cloud Armor DDOS Proctection Config.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderDdosProtectionConfig
{
    /// <summary>Google Cloud Armor offers the following options to help protect systems against DDoS attacks:</summary>
    [JsonPropertyName("ddosProtection")]
    public string? DdosProtection { get; set; }
}

/// <summary>
/// The configuration options available when specifying versionedExpr.
/// This field must be specified if versionedExpr is specified and cannot be specified if versionedExpr is not specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesMatchConfig
{
    /// <summary>Source IPv4/IPv6 addresses or CIDR prefixes, in standard text format.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }
}

/// <summary>
/// User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. See Sample expressions for examples.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesMatchExpr
{
    /// <summary>Textual representation of an expression in Common Expression Language syntax. The application context of the containing message determines which well-known feature set of CEL is supported.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary>
/// A match condition that incoming traffic is evaluated against.
/// If it evaluates to true, the corresponding &apos;action&apos; is enforced.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesMatch
{
    /// <summary>
    /// The configuration options available when specifying versionedExpr.
    /// This field must be specified if versionedExpr is specified and cannot be specified if versionedExpr is not specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("config")]
    public V1beta1RegionSecurityPolicySpecForProviderRulesMatchConfig? Config { get; set; }

    /// <summary>
    /// User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. See Sample expressions for examples.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expr")]
    public V1beta1RegionSecurityPolicySpecForProviderRulesMatchExpr? Expr { get; set; }

    /// <summary>
    /// Preconfigured versioned expression. If this field is specified, config must also be specified.
    /// Available preconfigured expressions along with their requirements are: SRC_IPS_V1 - must specify the corresponding srcIpRange field in config.
    /// Possible values are: SRC_IPS_V1.
    /// </summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesNetworkMatchUserDefinedFields
{
    /// <summary>The name of this field. Must be unique within the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Matching values of the field. Each element can be a 32-bit unsigned decimal or hexadecimal (starting with &quot;0x&quot;) number (e.g. &quot;64&quot;) or range (e.g. &quot;0x400-0x7ff&quot;).</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A match condition that incoming packets are evaluated against for CLOUD_ARMOR_NETWORK security policies. If it matches, the corresponding &apos;action&apos; is enforced.
/// The match criteria for a rule consists of built-in match fields (like &apos;srcIpRanges&apos;) and potentially multiple user-defined match fields (&apos;userDefinedFields&apos;).
/// Field values may be extracted directly from the packet or derived from it (e.g. &apos;srcRegionCodes&apos;). Some fields may not be present in every packet (e.g. &apos;srcPorts&apos;). A user-defined field is only present if the base header is found in the packet and the entire field is in bounds.
/// Each match field may specify which values can match it, listing one or more ranges, prefixes, or exact values that are considered a match for the field. A field value must be present in order to match a specified match field. If no match values are specified for a match field, then any field value is considered to match it, and it&apos;s not required to be present. For strings specifying &apos;*&apos; is also equivalent to match all.
/// For a packet to match a rule, all specified match fields must match the corresponding field values derived from the packet.
/// Example:
/// networkMatch: srcIpRanges: - &quot;192.0.2.0/24&quot; - &quot;198.51.100.0/24&quot; userDefinedFields: - name: &quot;ipv4_fragment_offset&quot; values: - &quot;1-0x1fff&quot;
/// The above match condition matches packets with a source IP in 192.0.2.0/24 or 198.51.100.0/24 and a user-defined field named &quot;ipv4_fragment_offset&quot; with a value between 1 and 0x1fff inclusive
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesNetworkMatch
{
    /// <summary>Destination IPv4/IPv6 addresses or CIDR prefixes, in standard text format.</summary>
    [JsonPropertyName("destIpRanges")]
    public IList<string>? DestIpRanges { get; set; }

    /// <summary>Destination port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &quot;80&quot;) or range (e.g. &quot;0-1023&quot;).</summary>
    [JsonPropertyName("destPorts")]
    public IList<string>? DestPorts { get; set; }

    /// <summary>IPv4 protocol / IPv6 next header (after extension headers). Each element can be an 8-bit unsigned decimal number (e.g. &quot;6&quot;), range (e.g. &quot;253-254&quot;), or one of the following protocol names: &quot;tcp&quot;, &quot;udp&quot;, &quot;icmp&quot;, &quot;esp&quot;, &quot;ah&quot;, &quot;ipip&quot;, or &quot;sctp&quot;.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    /// <summary>BGP Autonomous System Number associated with the source IP address.</summary>
    [JsonPropertyName("srcAsns")]
    public IList<double>? SrcAsns { get; set; }

    /// <summary>Source IPv4/IPv6 addresses or CIDR prefixes, in standard text format.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }

    /// <summary>Source port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &quot;80&quot;) or range (e.g. &quot;0-1023&quot;).</summary>
    [JsonPropertyName("srcPorts")]
    public IList<string>? SrcPorts { get; set; }

    /// <summary>Two-letter ISO 3166-1 alpha-2 country code associated with the source IP address.</summary>
    [JsonPropertyName("srcRegionCodes")]
    public IList<string>? SrcRegionCodes { get; set; }

    /// <summary>
    /// Definitions of user-defined fields for CLOUD_ARMOR_NETWORK policies.
    /// A user-defined field consists of up to 4 bytes extracted from a fixed offset in the packet, relative to the IPv4, IPv6, TCP, or UDP header, with an optional mask to select certain bits.
    /// Rules may then specify matching values for these fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("userDefinedFields")]
    public IList<V1beta1RegionSecurityPolicySpecForProviderRulesNetworkMatchUserDefinedFields>? UserDefinedFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfigExclusionRequestCookie
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfigExclusionRequestHeader
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfigExclusionRequestQueryParam
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfigExclusionRequestUri
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfigExclusion
{
    /// <summary>
    /// Request cookie whose value will be excluded from inspection during preconfigured WAF evaluation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestCookie")]
    public IList<V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfigExclusionRequestCookie>? RequestCookie { get; set; }

    /// <summary>
    /// Request header whose value will be excluded from inspection during preconfigured WAF evaluation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfigExclusionRequestHeader>? RequestHeader { get; set; }

    /// <summary>
    /// Request query parameter whose value will be excluded from inspection during preconfigured WAF evaluation.
    /// Note that the parameter can be in the query string or in the POST body.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestQueryParam")]
    public IList<V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfigExclusionRequestQueryParam>? RequestQueryParam { get; set; }

    /// <summary>
    /// Request URI from the request line to be excluded from inspection during preconfigured WAF evaluation.
    /// When specifying this field, the query or fragment part should be excluded.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestUri")]
    public IList<V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfigExclusionRequestUri>? RequestUri { get; set; }

    /// <summary>
    /// A list of target rule IDs under the WAF rule set to apply the preconfigured WAF exclusion.
    /// If omitted, it refers to all the rule IDs under the WAF rule set.
    /// </summary>
    [JsonPropertyName("targetRuleIds")]
    public IList<string>? TargetRuleIds { get; set; }

    /// <summary>Target WAF rule set to apply the preconfigured WAF exclusion.</summary>
    [JsonPropertyName("targetRuleSet")]
    public string? TargetRuleSet { get; set; }
}

/// <summary>
/// Preconfigured WAF configuration to be applied for the rule.
/// If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfig
{
    /// <summary>
    /// An exclusion to apply during preconfigured WAF evaluation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfigExclusion>? Exclusion { get; set; }
}

/// <summary>
/// Can only be specified if the action for the rule is &quot;rate_based_ban&quot;.
/// If specified, the key will be banned for the configured &apos;banDurationSec&apos; when the number of requests that exceed the &apos;rateLimitThreshold&apos; also exceed this &apos;banThreshold&apos;.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesRateLimitOptionsBanThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesRateLimitOptionsEnforceOnKeyConfigs
{
    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>Determines the key to enforce the rateLimitThreshold on. Possible values are:</summary>
    [JsonPropertyName("enforceOnKeyType")]
    public string? EnforceOnKeyType { get; set; }
}

/// <summary>
/// Threshold at which to begin ratelimiting.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesRateLimitOptionsRateLimitThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

/// <summary>
/// Must be specified if the action is &quot;rate_based_ban&quot; or &quot;throttle&quot;. Cannot be specified for any other actions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRulesRateLimitOptions
{
    /// <summary>
    /// Can only be specified if the action for the rule is &quot;rate_based_ban&quot;.
    /// If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.
    /// </summary>
    [JsonPropertyName("banDurationSec")]
    public double? BanDurationSec { get; set; }

    /// <summary>
    /// Can only be specified if the action for the rule is &quot;rate_based_ban&quot;.
    /// If specified, the key will be banned for the configured &apos;banDurationSec&apos; when the number of requests that exceed the &apos;rateLimitThreshold&apos; also exceed this &apos;banThreshold&apos;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("banThreshold")]
    public V1beta1RegionSecurityPolicySpecForProviderRulesRateLimitOptionsBanThreshold? BanThreshold { get; set; }

    /// <summary>
    /// Action to take for requests that are under the configured rate limit threshold.
    /// Valid option is &quot;allow&quot; only.
    /// </summary>
    [JsonPropertyName("conformAction")]
    public string? ConformAction { get; set; }

    /// <summary>Determines the key to enforce the rateLimitThreshold on. Possible values are:</summary>
    [JsonPropertyName("enforceOnKey")]
    public string? EnforceOnKey { get; set; }

    /// <summary>
    /// If specified, any combination of values of enforceOnKeyType/enforceOnKeyName is treated as the key on which ratelimit threshold/action is enforced.
    /// You can specify up to 3 enforceOnKeyConfigs.
    /// If enforceOnKeyConfigs is specified, enforceOnKey must not be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("enforceOnKeyConfigs")]
    public IList<V1beta1RegionSecurityPolicySpecForProviderRulesRateLimitOptionsEnforceOnKeyConfigs>? EnforceOnKeyConfigs { get; set; }

    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>
    /// Action to take for requests that are above the configured rate limit threshold, to deny with a specified HTTP response code.
    /// Valid options are deny(STATUS), where valid values for STATUS are 403, 404, 429, and 502.
    /// </summary>
    [JsonPropertyName("exceedAction")]
    public string? ExceedAction { get; set; }

    /// <summary>
    /// Threshold at which to begin ratelimiting.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rateLimitThreshold")]
    public V1beta1RegionSecurityPolicySpecForProviderRulesRateLimitOptionsRateLimitThreshold? RateLimitThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderRules
{
    /// <summary>The Action to perform when the rule is matched. The following are the valid actions:</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A match condition that incoming traffic is evaluated against.
    /// If it evaluates to true, the corresponding &apos;action&apos; is enforced.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1RegionSecurityPolicySpecForProviderRulesMatch? Match { get; set; }

    /// <summary>
    /// A match condition that incoming packets are evaluated against for CLOUD_ARMOR_NETWORK security policies. If it matches, the corresponding &apos;action&apos; is enforced.
    /// The match criteria for a rule consists of built-in match fields (like &apos;srcIpRanges&apos;) and potentially multiple user-defined match fields (&apos;userDefinedFields&apos;).
    /// Field values may be extracted directly from the packet or derived from it (e.g. &apos;srcRegionCodes&apos;). Some fields may not be present in every packet (e.g. &apos;srcPorts&apos;). A user-defined field is only present if the base header is found in the packet and the entire field is in bounds.
    /// Each match field may specify which values can match it, listing one or more ranges, prefixes, or exact values that are considered a match for the field. A field value must be present in order to match a specified match field. If no match values are specified for a match field, then any field value is considered to match it, and it&apos;s not required to be present. For strings specifying &apos;*&apos; is also equivalent to match all.
    /// For a packet to match a rule, all specified match fields must match the corresponding field values derived from the packet.
    /// Example:
    /// networkMatch: srcIpRanges: - &quot;192.0.2.0/24&quot; - &quot;198.51.100.0/24&quot; userDefinedFields: - name: &quot;ipv4_fragment_offset&quot; values: - &quot;1-0x1fff&quot;
    /// The above match condition matches packets with a source IP in 192.0.2.0/24 or 198.51.100.0/24 and a user-defined field named &quot;ipv4_fragment_offset&quot; with a value between 1 and 0x1fff inclusive
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkMatch")]
    public V1beta1RegionSecurityPolicySpecForProviderRulesNetworkMatch? NetworkMatch { get; set; }

    /// <summary>
    /// Preconfigured WAF configuration to be applied for the rule.
    /// If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("preconfiguredWafConfig")]
    public V1beta1RegionSecurityPolicySpecForProviderRulesPreconfiguredWafConfig? PreconfiguredWafConfig { get; set; }

    /// <summary>If set to true, the specified action is not enforced.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Must be specified if the action is &quot;rate_based_ban&quot; or &quot;throttle&quot;. Cannot be specified for any other actions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rateLimitOptions")]
    public V1beta1RegionSecurityPolicySpecForProviderRulesRateLimitOptions? RateLimitOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProviderUserDefinedFields
{
    /// <summary>The base relative to which &apos;offset&apos; is measured. Possible values are:</summary>
    [JsonPropertyName("base")]
    public string? Base { get; set; }

    /// <summary>
    /// If specified, apply this mask (bitwise AND) to the field to ignore bits before matching.
    /// Encoded as a hexadecimal number (starting with &quot;0x&quot;).
    /// The last byte of the field (in network byte order) corresponds to the least significant byte of the mask.
    /// </summary>
    [JsonPropertyName("mask")]
    public string? Mask { get; set; }

    /// <summary>The name of this field. Must be unique within the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Offset of the first byte of the field (in network byte order) relative to &apos;base&apos;.</summary>
    [JsonPropertyName("offset")]
    public double? Offset { get; set; }

    /// <summary>Size of the field in bytes. Valid values: 1-4.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecForProvider
{
    /// <summary>
    /// Configuration for Google Cloud Armor DDOS Proctection Config.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ddosProtectionConfig")]
    public V1beta1RegionSecurityPolicySpecForProviderDdosProtectionConfig? DdosProtectionConfig { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The Region in which the created Region Security Policy should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match &quot;*&quot;). If no rules are provided when creating a security policy, a default rule with action &quot;allow&quot; will be added.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1RegionSecurityPolicySpecForProviderRules>? Rules { get; set; }

    /// <summary>The type indicates the intended use of the security policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Definitions of user-defined fields for CLOUD_ARMOR_NETWORK policies.
    /// A user-defined field consists of up to 4 bytes extracted from a fixed offset in the packet, relative to the IPv4, IPv6, TCP, or UDP header, with an optional mask to select certain bits.
    /// Rules may then specify matching values for these fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("userDefinedFields")]
    public IList<V1beta1RegionSecurityPolicySpecForProviderUserDefinedFields>? UserDefinedFields { get; set; }
}

/// <summary>
/// Configuration for Google Cloud Armor DDOS Proctection Config.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderDdosProtectionConfig
{
    /// <summary>Google Cloud Armor offers the following options to help protect systems against DDoS attacks:</summary>
    [JsonPropertyName("ddosProtection")]
    public string? DdosProtection { get; set; }
}

/// <summary>
/// The configuration options available when specifying versionedExpr.
/// This field must be specified if versionedExpr is specified and cannot be specified if versionedExpr is not specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesMatchConfig
{
    /// <summary>Source IPv4/IPv6 addresses or CIDR prefixes, in standard text format.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }
}

/// <summary>
/// User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. See Sample expressions for examples.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesMatchExpr
{
    /// <summary>Textual representation of an expression in Common Expression Language syntax. The application context of the containing message determines which well-known feature set of CEL is supported.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary>
/// A match condition that incoming traffic is evaluated against.
/// If it evaluates to true, the corresponding &apos;action&apos; is enforced.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesMatch
{
    /// <summary>
    /// The configuration options available when specifying versionedExpr.
    /// This field must be specified if versionedExpr is specified and cannot be specified if versionedExpr is not specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("config")]
    public V1beta1RegionSecurityPolicySpecInitProviderRulesMatchConfig? Config { get; set; }

    /// <summary>
    /// User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. See Sample expressions for examples.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expr")]
    public V1beta1RegionSecurityPolicySpecInitProviderRulesMatchExpr? Expr { get; set; }

    /// <summary>
    /// Preconfigured versioned expression. If this field is specified, config must also be specified.
    /// Available preconfigured expressions along with their requirements are: SRC_IPS_V1 - must specify the corresponding srcIpRange field in config.
    /// Possible values are: SRC_IPS_V1.
    /// </summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesNetworkMatchUserDefinedFields
{
    /// <summary>The name of this field. Must be unique within the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Matching values of the field. Each element can be a 32-bit unsigned decimal or hexadecimal (starting with &quot;0x&quot;) number (e.g. &quot;64&quot;) or range (e.g. &quot;0x400-0x7ff&quot;).</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A match condition that incoming packets are evaluated against for CLOUD_ARMOR_NETWORK security policies. If it matches, the corresponding &apos;action&apos; is enforced.
/// The match criteria for a rule consists of built-in match fields (like &apos;srcIpRanges&apos;) and potentially multiple user-defined match fields (&apos;userDefinedFields&apos;).
/// Field values may be extracted directly from the packet or derived from it (e.g. &apos;srcRegionCodes&apos;). Some fields may not be present in every packet (e.g. &apos;srcPorts&apos;). A user-defined field is only present if the base header is found in the packet and the entire field is in bounds.
/// Each match field may specify which values can match it, listing one or more ranges, prefixes, or exact values that are considered a match for the field. A field value must be present in order to match a specified match field. If no match values are specified for a match field, then any field value is considered to match it, and it&apos;s not required to be present. For strings specifying &apos;*&apos; is also equivalent to match all.
/// For a packet to match a rule, all specified match fields must match the corresponding field values derived from the packet.
/// Example:
/// networkMatch: srcIpRanges: - &quot;192.0.2.0/24&quot; - &quot;198.51.100.0/24&quot; userDefinedFields: - name: &quot;ipv4_fragment_offset&quot; values: - &quot;1-0x1fff&quot;
/// The above match condition matches packets with a source IP in 192.0.2.0/24 or 198.51.100.0/24 and a user-defined field named &quot;ipv4_fragment_offset&quot; with a value between 1 and 0x1fff inclusive
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesNetworkMatch
{
    /// <summary>Destination IPv4/IPv6 addresses or CIDR prefixes, in standard text format.</summary>
    [JsonPropertyName("destIpRanges")]
    public IList<string>? DestIpRanges { get; set; }

    /// <summary>Destination port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &quot;80&quot;) or range (e.g. &quot;0-1023&quot;).</summary>
    [JsonPropertyName("destPorts")]
    public IList<string>? DestPorts { get; set; }

    /// <summary>IPv4 protocol / IPv6 next header (after extension headers). Each element can be an 8-bit unsigned decimal number (e.g. &quot;6&quot;), range (e.g. &quot;253-254&quot;), or one of the following protocol names: &quot;tcp&quot;, &quot;udp&quot;, &quot;icmp&quot;, &quot;esp&quot;, &quot;ah&quot;, &quot;ipip&quot;, or &quot;sctp&quot;.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    /// <summary>BGP Autonomous System Number associated with the source IP address.</summary>
    [JsonPropertyName("srcAsns")]
    public IList<double>? SrcAsns { get; set; }

    /// <summary>Source IPv4/IPv6 addresses or CIDR prefixes, in standard text format.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }

    /// <summary>Source port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &quot;80&quot;) or range (e.g. &quot;0-1023&quot;).</summary>
    [JsonPropertyName("srcPorts")]
    public IList<string>? SrcPorts { get; set; }

    /// <summary>Two-letter ISO 3166-1 alpha-2 country code associated with the source IP address.</summary>
    [JsonPropertyName("srcRegionCodes")]
    public IList<string>? SrcRegionCodes { get; set; }

    /// <summary>
    /// Definitions of user-defined fields for CLOUD_ARMOR_NETWORK policies.
    /// A user-defined field consists of up to 4 bytes extracted from a fixed offset in the packet, relative to the IPv4, IPv6, TCP, or UDP header, with an optional mask to select certain bits.
    /// Rules may then specify matching values for these fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("userDefinedFields")]
    public IList<V1beta1RegionSecurityPolicySpecInitProviderRulesNetworkMatchUserDefinedFields>? UserDefinedFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfigExclusionRequestCookie
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfigExclusionRequestHeader
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfigExclusionRequestQueryParam
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfigExclusionRequestUri
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfigExclusion
{
    /// <summary>
    /// Request cookie whose value will be excluded from inspection during preconfigured WAF evaluation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestCookie")]
    public IList<V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfigExclusionRequestCookie>? RequestCookie { get; set; }

    /// <summary>
    /// Request header whose value will be excluded from inspection during preconfigured WAF evaluation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfigExclusionRequestHeader>? RequestHeader { get; set; }

    /// <summary>
    /// Request query parameter whose value will be excluded from inspection during preconfigured WAF evaluation.
    /// Note that the parameter can be in the query string or in the POST body.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestQueryParam")]
    public IList<V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfigExclusionRequestQueryParam>? RequestQueryParam { get; set; }

    /// <summary>
    /// Request URI from the request line to be excluded from inspection during preconfigured WAF evaluation.
    /// When specifying this field, the query or fragment part should be excluded.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestUri")]
    public IList<V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfigExclusionRequestUri>? RequestUri { get; set; }

    /// <summary>
    /// A list of target rule IDs under the WAF rule set to apply the preconfigured WAF exclusion.
    /// If omitted, it refers to all the rule IDs under the WAF rule set.
    /// </summary>
    [JsonPropertyName("targetRuleIds")]
    public IList<string>? TargetRuleIds { get; set; }

    /// <summary>Target WAF rule set to apply the preconfigured WAF exclusion.</summary>
    [JsonPropertyName("targetRuleSet")]
    public string? TargetRuleSet { get; set; }
}

/// <summary>
/// Preconfigured WAF configuration to be applied for the rule.
/// If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfig
{
    /// <summary>
    /// An exclusion to apply during preconfigured WAF evaluation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfigExclusion>? Exclusion { get; set; }
}

/// <summary>
/// Can only be specified if the action for the rule is &quot;rate_based_ban&quot;.
/// If specified, the key will be banned for the configured &apos;banDurationSec&apos; when the number of requests that exceed the &apos;rateLimitThreshold&apos; also exceed this &apos;banThreshold&apos;.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesRateLimitOptionsBanThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesRateLimitOptionsEnforceOnKeyConfigs
{
    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>Determines the key to enforce the rateLimitThreshold on. Possible values are:</summary>
    [JsonPropertyName("enforceOnKeyType")]
    public string? EnforceOnKeyType { get; set; }
}

/// <summary>
/// Threshold at which to begin ratelimiting.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesRateLimitOptionsRateLimitThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

/// <summary>
/// Must be specified if the action is &quot;rate_based_ban&quot; or &quot;throttle&quot;. Cannot be specified for any other actions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRulesRateLimitOptions
{
    /// <summary>
    /// Can only be specified if the action for the rule is &quot;rate_based_ban&quot;.
    /// If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.
    /// </summary>
    [JsonPropertyName("banDurationSec")]
    public double? BanDurationSec { get; set; }

    /// <summary>
    /// Can only be specified if the action for the rule is &quot;rate_based_ban&quot;.
    /// If specified, the key will be banned for the configured &apos;banDurationSec&apos; when the number of requests that exceed the &apos;rateLimitThreshold&apos; also exceed this &apos;banThreshold&apos;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("banThreshold")]
    public V1beta1RegionSecurityPolicySpecInitProviderRulesRateLimitOptionsBanThreshold? BanThreshold { get; set; }

    /// <summary>
    /// Action to take for requests that are under the configured rate limit threshold.
    /// Valid option is &quot;allow&quot; only.
    /// </summary>
    [JsonPropertyName("conformAction")]
    public string? ConformAction { get; set; }

    /// <summary>Determines the key to enforce the rateLimitThreshold on. Possible values are:</summary>
    [JsonPropertyName("enforceOnKey")]
    public string? EnforceOnKey { get; set; }

    /// <summary>
    /// If specified, any combination of values of enforceOnKeyType/enforceOnKeyName is treated as the key on which ratelimit threshold/action is enforced.
    /// You can specify up to 3 enforceOnKeyConfigs.
    /// If enforceOnKeyConfigs is specified, enforceOnKey must not be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("enforceOnKeyConfigs")]
    public IList<V1beta1RegionSecurityPolicySpecInitProviderRulesRateLimitOptionsEnforceOnKeyConfigs>? EnforceOnKeyConfigs { get; set; }

    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>
    /// Action to take for requests that are above the configured rate limit threshold, to deny with a specified HTTP response code.
    /// Valid options are deny(STATUS), where valid values for STATUS are 403, 404, 429, and 502.
    /// </summary>
    [JsonPropertyName("exceedAction")]
    public string? ExceedAction { get; set; }

    /// <summary>
    /// Threshold at which to begin ratelimiting.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rateLimitThreshold")]
    public V1beta1RegionSecurityPolicySpecInitProviderRulesRateLimitOptionsRateLimitThreshold? RateLimitThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderRules
{
    /// <summary>The Action to perform when the rule is matched. The following are the valid actions:</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A match condition that incoming traffic is evaluated against.
    /// If it evaluates to true, the corresponding &apos;action&apos; is enforced.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1RegionSecurityPolicySpecInitProviderRulesMatch? Match { get; set; }

    /// <summary>
    /// A match condition that incoming packets are evaluated against for CLOUD_ARMOR_NETWORK security policies. If it matches, the corresponding &apos;action&apos; is enforced.
    /// The match criteria for a rule consists of built-in match fields (like &apos;srcIpRanges&apos;) and potentially multiple user-defined match fields (&apos;userDefinedFields&apos;).
    /// Field values may be extracted directly from the packet or derived from it (e.g. &apos;srcRegionCodes&apos;). Some fields may not be present in every packet (e.g. &apos;srcPorts&apos;). A user-defined field is only present if the base header is found in the packet and the entire field is in bounds.
    /// Each match field may specify which values can match it, listing one or more ranges, prefixes, or exact values that are considered a match for the field. A field value must be present in order to match a specified match field. If no match values are specified for a match field, then any field value is considered to match it, and it&apos;s not required to be present. For strings specifying &apos;*&apos; is also equivalent to match all.
    /// For a packet to match a rule, all specified match fields must match the corresponding field values derived from the packet.
    /// Example:
    /// networkMatch: srcIpRanges: - &quot;192.0.2.0/24&quot; - &quot;198.51.100.0/24&quot; userDefinedFields: - name: &quot;ipv4_fragment_offset&quot; values: - &quot;1-0x1fff&quot;
    /// The above match condition matches packets with a source IP in 192.0.2.0/24 or 198.51.100.0/24 and a user-defined field named &quot;ipv4_fragment_offset&quot; with a value between 1 and 0x1fff inclusive
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkMatch")]
    public V1beta1RegionSecurityPolicySpecInitProviderRulesNetworkMatch? NetworkMatch { get; set; }

    /// <summary>
    /// Preconfigured WAF configuration to be applied for the rule.
    /// If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("preconfiguredWafConfig")]
    public V1beta1RegionSecurityPolicySpecInitProviderRulesPreconfiguredWafConfig? PreconfiguredWafConfig { get; set; }

    /// <summary>If set to true, the specified action is not enforced.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Must be specified if the action is &quot;rate_based_ban&quot; or &quot;throttle&quot;. Cannot be specified for any other actions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rateLimitOptions")]
    public V1beta1RegionSecurityPolicySpecInitProviderRulesRateLimitOptions? RateLimitOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpecInitProviderUserDefinedFields
{
    /// <summary>The base relative to which &apos;offset&apos; is measured. Possible values are:</summary>
    [JsonPropertyName("base")]
    public string? Base { get; set; }

    /// <summary>
    /// If specified, apply this mask (bitwise AND) to the field to ignore bits before matching.
    /// Encoded as a hexadecimal number (starting with &quot;0x&quot;).
    /// The last byte of the field (in network byte order) corresponds to the least significant byte of the mask.
    /// </summary>
    [JsonPropertyName("mask")]
    public string? Mask { get; set; }

    /// <summary>The name of this field. Must be unique within the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Offset of the first byte of the field (in network byte order) relative to &apos;base&apos;.</summary>
    [JsonPropertyName("offset")]
    public double? Offset { get; set; }

    /// <summary>Size of the field in bytes. Valid values: 1-4.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
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
public partial class V1beta1RegionSecurityPolicySpecInitProvider
{
    /// <summary>
    /// Configuration for Google Cloud Armor DDOS Proctection Config.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ddosProtectionConfig")]
    public V1beta1RegionSecurityPolicySpecInitProviderDdosProtectionConfig? DdosProtectionConfig { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match &quot;*&quot;). If no rules are provided when creating a security policy, a default rule with action &quot;allow&quot; will be added.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1RegionSecurityPolicySpecInitProviderRules>? Rules { get; set; }

    /// <summary>The type indicates the intended use of the security policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Definitions of user-defined fields for CLOUD_ARMOR_NETWORK policies.
    /// A user-defined field consists of up to 4 bytes extracted from a fixed offset in the packet, relative to the IPv4, IPv6, TCP, or UDP header, with an optional mask to select certain bits.
    /// Rules may then specify matching values for these fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("userDefinedFields")]
    public IList<V1beta1RegionSecurityPolicySpecInitProviderUserDefinedFields>? UserDefinedFields { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1RegionSecurityPolicySpecManagementPoliciesEnum>))]
public enum V1beta1RegionSecurityPolicySpecManagementPoliciesEnum
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
public partial class V1beta1RegionSecurityPolicySpecProviderConfigRef
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
public partial class V1beta1RegionSecurityPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>RegionSecurityPolicySpec defines the desired state of RegionSecurityPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1RegionSecurityPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta1RegionSecurityPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1RegionSecurityPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RegionSecurityPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RegionSecurityPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Configuration for Google Cloud Armor DDOS Proctection Config.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderDdosProtectionConfig
{
    /// <summary>Google Cloud Armor offers the following options to help protect systems against DDoS attacks:</summary>
    [JsonPropertyName("ddosProtection")]
    public string? DdosProtection { get; set; }
}

/// <summary>
/// The configuration options available when specifying versionedExpr.
/// This field must be specified if versionedExpr is specified and cannot be specified if versionedExpr is not specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesMatchConfig
{
    /// <summary>Source IPv4/IPv6 addresses or CIDR prefixes, in standard text format.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }
}

/// <summary>
/// User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. See Sample expressions for examples.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesMatchExpr
{
    /// <summary>Textual representation of an expression in Common Expression Language syntax. The application context of the containing message determines which well-known feature set of CEL is supported.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary>
/// A match condition that incoming traffic is evaluated against.
/// If it evaluates to true, the corresponding &apos;action&apos; is enforced.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesMatch
{
    /// <summary>
    /// The configuration options available when specifying versionedExpr.
    /// This field must be specified if versionedExpr is specified and cannot be specified if versionedExpr is not specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("config")]
    public V1beta1RegionSecurityPolicyStatusAtProviderRulesMatchConfig? Config { get; set; }

    /// <summary>
    /// User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. See Sample expressions for examples.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expr")]
    public V1beta1RegionSecurityPolicyStatusAtProviderRulesMatchExpr? Expr { get; set; }

    /// <summary>
    /// Preconfigured versioned expression. If this field is specified, config must also be specified.
    /// Available preconfigured expressions along with their requirements are: SRC_IPS_V1 - must specify the corresponding srcIpRange field in config.
    /// Possible values are: SRC_IPS_V1.
    /// </summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesNetworkMatchUserDefinedFields
{
    /// <summary>The name of this field. Must be unique within the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Matching values of the field. Each element can be a 32-bit unsigned decimal or hexadecimal (starting with &quot;0x&quot;) number (e.g. &quot;64&quot;) or range (e.g. &quot;0x400-0x7ff&quot;).</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// A match condition that incoming packets are evaluated against for CLOUD_ARMOR_NETWORK security policies. If it matches, the corresponding &apos;action&apos; is enforced.
/// The match criteria for a rule consists of built-in match fields (like &apos;srcIpRanges&apos;) and potentially multiple user-defined match fields (&apos;userDefinedFields&apos;).
/// Field values may be extracted directly from the packet or derived from it (e.g. &apos;srcRegionCodes&apos;). Some fields may not be present in every packet (e.g. &apos;srcPorts&apos;). A user-defined field is only present if the base header is found in the packet and the entire field is in bounds.
/// Each match field may specify which values can match it, listing one or more ranges, prefixes, or exact values that are considered a match for the field. A field value must be present in order to match a specified match field. If no match values are specified for a match field, then any field value is considered to match it, and it&apos;s not required to be present. For strings specifying &apos;*&apos; is also equivalent to match all.
/// For a packet to match a rule, all specified match fields must match the corresponding field values derived from the packet.
/// Example:
/// networkMatch: srcIpRanges: - &quot;192.0.2.0/24&quot; - &quot;198.51.100.0/24&quot; userDefinedFields: - name: &quot;ipv4_fragment_offset&quot; values: - &quot;1-0x1fff&quot;
/// The above match condition matches packets with a source IP in 192.0.2.0/24 or 198.51.100.0/24 and a user-defined field named &quot;ipv4_fragment_offset&quot; with a value between 1 and 0x1fff inclusive
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesNetworkMatch
{
    /// <summary>Destination IPv4/IPv6 addresses or CIDR prefixes, in standard text format.</summary>
    [JsonPropertyName("destIpRanges")]
    public IList<string>? DestIpRanges { get; set; }

    /// <summary>Destination port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &quot;80&quot;) or range (e.g. &quot;0-1023&quot;).</summary>
    [JsonPropertyName("destPorts")]
    public IList<string>? DestPorts { get; set; }

    /// <summary>IPv4 protocol / IPv6 next header (after extension headers). Each element can be an 8-bit unsigned decimal number (e.g. &quot;6&quot;), range (e.g. &quot;253-254&quot;), or one of the following protocol names: &quot;tcp&quot;, &quot;udp&quot;, &quot;icmp&quot;, &quot;esp&quot;, &quot;ah&quot;, &quot;ipip&quot;, or &quot;sctp&quot;.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }

    /// <summary>BGP Autonomous System Number associated with the source IP address.</summary>
    [JsonPropertyName("srcAsns")]
    public IList<double>? SrcAsns { get; set; }

    /// <summary>Source IPv4/IPv6 addresses or CIDR prefixes, in standard text format.</summary>
    [JsonPropertyName("srcIpRanges")]
    public IList<string>? SrcIpRanges { get; set; }

    /// <summary>Source port numbers for TCP/UDP/SCTP. Each element can be a 16-bit unsigned decimal number (e.g. &quot;80&quot;) or range (e.g. &quot;0-1023&quot;).</summary>
    [JsonPropertyName("srcPorts")]
    public IList<string>? SrcPorts { get; set; }

    /// <summary>Two-letter ISO 3166-1 alpha-2 country code associated with the source IP address.</summary>
    [JsonPropertyName("srcRegionCodes")]
    public IList<string>? SrcRegionCodes { get; set; }

    /// <summary>
    /// Definitions of user-defined fields for CLOUD_ARMOR_NETWORK policies.
    /// A user-defined field consists of up to 4 bytes extracted from a fixed offset in the packet, relative to the IPv4, IPv6, TCP, or UDP header, with an optional mask to select certain bits.
    /// Rules may then specify matching values for these fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("userDefinedFields")]
    public IList<V1beta1RegionSecurityPolicyStatusAtProviderRulesNetworkMatchUserDefinedFields>? UserDefinedFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfigExclusionRequestCookie
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfigExclusionRequestHeader
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfigExclusionRequestQueryParam
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfigExclusionRequestUri
{
    /// <summary>
    /// You can specify an exact match or a partial match by using a field operator and a field value.
    /// Available options:
    /// EQUALS: The operator matches if the field value equals the specified value.
    /// STARTS_WITH: The operator matches if the field value starts with the specified value.
    /// ENDS_WITH: The operator matches if the field value ends with the specified value.
    /// CONTAINS: The operator matches if the field value contains the specified value.
    /// EQUALS_ANY: The operator matches if the field value is any value.
    /// Possible values are: CONTAINS, ENDS_WITH, EQUALS, EQUALS_ANY, STARTS_WITH.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// A request field matching the specified value will be excluded from inspection during preconfigured WAF evaluation.
    /// The field value must be given if the field operator is not EQUALS_ANY, and cannot be given if the field operator is EQUALS_ANY.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfigExclusion
{
    /// <summary>
    /// Request cookie whose value will be excluded from inspection during preconfigured WAF evaluation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestCookie")]
    public IList<V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfigExclusionRequestCookie>? RequestCookie { get; set; }

    /// <summary>
    /// Request header whose value will be excluded from inspection during preconfigured WAF evaluation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfigExclusionRequestHeader>? RequestHeader { get; set; }

    /// <summary>
    /// Request query parameter whose value will be excluded from inspection during preconfigured WAF evaluation.
    /// Note that the parameter can be in the query string or in the POST body.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestQueryParam")]
    public IList<V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfigExclusionRequestQueryParam>? RequestQueryParam { get; set; }

    /// <summary>
    /// Request URI from the request line to be excluded from inspection during preconfigured WAF evaluation.
    /// When specifying this field, the query or fragment part should be excluded.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestUri")]
    public IList<V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfigExclusionRequestUri>? RequestUri { get; set; }

    /// <summary>
    /// A list of target rule IDs under the WAF rule set to apply the preconfigured WAF exclusion.
    /// If omitted, it refers to all the rule IDs under the WAF rule set.
    /// </summary>
    [JsonPropertyName("targetRuleIds")]
    public IList<string>? TargetRuleIds { get; set; }

    /// <summary>Target WAF rule set to apply the preconfigured WAF exclusion.</summary>
    [JsonPropertyName("targetRuleSet")]
    public string? TargetRuleSet { get; set; }
}

/// <summary>
/// Preconfigured WAF configuration to be applied for the rule.
/// If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfig
{
    /// <summary>
    /// An exclusion to apply during preconfigured WAF evaluation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfigExclusion>? Exclusion { get; set; }
}

/// <summary>
/// Can only be specified if the action for the rule is &quot;rate_based_ban&quot;.
/// If specified, the key will be banned for the configured &apos;banDurationSec&apos; when the number of requests that exceed the &apos;rateLimitThreshold&apos; also exceed this &apos;banThreshold&apos;.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesRateLimitOptionsBanThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesRateLimitOptionsEnforceOnKeyConfigs
{
    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>Determines the key to enforce the rateLimitThreshold on. Possible values are:</summary>
    [JsonPropertyName("enforceOnKeyType")]
    public string? EnforceOnKeyType { get; set; }
}

/// <summary>
/// Threshold at which to begin ratelimiting.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesRateLimitOptionsRateLimitThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public double? IntervalSec { get; set; }
}

/// <summary>
/// Must be specified if the action is &quot;rate_based_ban&quot; or &quot;throttle&quot;. Cannot be specified for any other actions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRulesRateLimitOptions
{
    /// <summary>
    /// Can only be specified if the action for the rule is &quot;rate_based_ban&quot;.
    /// If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.
    /// </summary>
    [JsonPropertyName("banDurationSec")]
    public double? BanDurationSec { get; set; }

    /// <summary>
    /// Can only be specified if the action for the rule is &quot;rate_based_ban&quot;.
    /// If specified, the key will be banned for the configured &apos;banDurationSec&apos; when the number of requests that exceed the &apos;rateLimitThreshold&apos; also exceed this &apos;banThreshold&apos;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("banThreshold")]
    public V1beta1RegionSecurityPolicyStatusAtProviderRulesRateLimitOptionsBanThreshold? BanThreshold { get; set; }

    /// <summary>
    /// Action to take for requests that are under the configured rate limit threshold.
    /// Valid option is &quot;allow&quot; only.
    /// </summary>
    [JsonPropertyName("conformAction")]
    public string? ConformAction { get; set; }

    /// <summary>Determines the key to enforce the rateLimitThreshold on. Possible values are:</summary>
    [JsonPropertyName("enforceOnKey")]
    public string? EnforceOnKey { get; set; }

    /// <summary>
    /// If specified, any combination of values of enforceOnKeyType/enforceOnKeyName is treated as the key on which ratelimit threshold/action is enforced.
    /// You can specify up to 3 enforceOnKeyConfigs.
    /// If enforceOnKeyConfigs is specified, enforceOnKey must not be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("enforceOnKeyConfigs")]
    public IList<V1beta1RegionSecurityPolicyStatusAtProviderRulesRateLimitOptionsEnforceOnKeyConfigs>? EnforceOnKeyConfigs { get; set; }

    /// <summary>
    /// Rate limit key name applicable only for the following key types:
    /// HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value.
    /// HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.
    /// </summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>
    /// Action to take for requests that are above the configured rate limit threshold, to deny with a specified HTTP response code.
    /// Valid options are deny(STATUS), where valid values for STATUS are 403, 404, 429, and 502.
    /// </summary>
    [JsonPropertyName("exceedAction")]
    public string? ExceedAction { get; set; }

    /// <summary>
    /// Threshold at which to begin ratelimiting.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rateLimitThreshold")]
    public V1beta1RegionSecurityPolicyStatusAtProviderRulesRateLimitOptionsRateLimitThreshold? RateLimitThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderRules
{
    /// <summary>The Action to perform when the rule is matched. The following are the valid actions:</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A match condition that incoming traffic is evaluated against.
    /// If it evaluates to true, the corresponding &apos;action&apos; is enforced.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("match")]
    public V1beta1RegionSecurityPolicyStatusAtProviderRulesMatch? Match { get; set; }

    /// <summary>
    /// A match condition that incoming packets are evaluated against for CLOUD_ARMOR_NETWORK security policies. If it matches, the corresponding &apos;action&apos; is enforced.
    /// The match criteria for a rule consists of built-in match fields (like &apos;srcIpRanges&apos;) and potentially multiple user-defined match fields (&apos;userDefinedFields&apos;).
    /// Field values may be extracted directly from the packet or derived from it (e.g. &apos;srcRegionCodes&apos;). Some fields may not be present in every packet (e.g. &apos;srcPorts&apos;). A user-defined field is only present if the base header is found in the packet and the entire field is in bounds.
    /// Each match field may specify which values can match it, listing one or more ranges, prefixes, or exact values that are considered a match for the field. A field value must be present in order to match a specified match field. If no match values are specified for a match field, then any field value is considered to match it, and it&apos;s not required to be present. For strings specifying &apos;*&apos; is also equivalent to match all.
    /// For a packet to match a rule, all specified match fields must match the corresponding field values derived from the packet.
    /// Example:
    /// networkMatch: srcIpRanges: - &quot;192.0.2.0/24&quot; - &quot;198.51.100.0/24&quot; userDefinedFields: - name: &quot;ipv4_fragment_offset&quot; values: - &quot;1-0x1fff&quot;
    /// The above match condition matches packets with a source IP in 192.0.2.0/24 or 198.51.100.0/24 and a user-defined field named &quot;ipv4_fragment_offset&quot; with a value between 1 and 0x1fff inclusive
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkMatch")]
    public V1beta1RegionSecurityPolicyStatusAtProviderRulesNetworkMatch? NetworkMatch { get; set; }

    /// <summary>
    /// Preconfigured WAF configuration to be applied for the rule.
    /// If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("preconfiguredWafConfig")]
    public V1beta1RegionSecurityPolicyStatusAtProviderRulesPreconfiguredWafConfig? PreconfiguredWafConfig { get; set; }

    /// <summary>If set to true, the specified action is not enforced.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>
    /// An integer indicating the priority of a rule in the list.
    /// The priority must be a positive value between 0 and 2147483647.
    /// Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest priority.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// Must be specified if the action is &quot;rate_based_ban&quot; or &quot;throttle&quot;. Cannot be specified for any other actions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rateLimitOptions")]
    public V1beta1RegionSecurityPolicyStatusAtProviderRulesRateLimitOptions? RateLimitOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProviderUserDefinedFields
{
    /// <summary>The base relative to which &apos;offset&apos; is measured. Possible values are:</summary>
    [JsonPropertyName("base")]
    public string? Base { get; set; }

    /// <summary>
    /// If specified, apply this mask (bitwise AND) to the field to ignore bits before matching.
    /// Encoded as a hexadecimal number (starting with &quot;0x&quot;).
    /// The last byte of the field (in network byte order) corresponds to the least significant byte of the mask.
    /// </summary>
    [JsonPropertyName("mask")]
    public string? Mask { get; set; }

    /// <summary>The name of this field. Must be unique within the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Offset of the first byte of the field (in network byte order) relative to &apos;base&apos;.</summary>
    [JsonPropertyName("offset")]
    public double? Offset { get; set; }

    /// <summary>Size of the field in bytes. Valid values: 1-4.</summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusAtProvider
{
    /// <summary>
    /// Configuration for Google Cloud Armor DDOS Proctection Config.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ddosProtectionConfig")]
    public V1beta1RegionSecurityPolicyStatusAtProviderDdosProtectionConfig? DdosProtectionConfig { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/securityPolicies/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The Region in which the created Region Security Policy should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The set of rules that belong to this policy. There must always be a default rule (rule with priority 2147483647 and match &quot;*&quot;). If no rules are provided when creating a security policy, a default rule with action &quot;allow&quot; will be added.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1RegionSecurityPolicyStatusAtProviderRules>? Rules { get; set; }

    /// <summary>Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Server-defined URL for this resource with the resource id.</summary>
    [JsonPropertyName("selfLinkWithPolicyId")]
    public string? SelfLinkWithPolicyId { get; set; }

    /// <summary>The type indicates the intended use of the security policy.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Definitions of user-defined fields for CLOUD_ARMOR_NETWORK policies.
    /// A user-defined field consists of up to 4 bytes extracted from a fixed offset in the packet, relative to the IPv4, IPv6, TCP, or UDP header, with an optional mask to select certain bits.
    /// Rules may then specify matching values for these fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("userDefinedFields")]
    public IList<V1beta1RegionSecurityPolicyStatusAtProviderUserDefinedFields>? UserDefinedFields { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatusConditions
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

/// <summary>RegionSecurityPolicyStatus defines the observed state of RegionSecurityPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RegionSecurityPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1RegionSecurityPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RegionSecurityPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegionSecurityPolicy is the Schema for the RegionSecurityPolicys API. Represents a Region Cloud Armor Security Policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RegionSecurityPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RegionSecurityPolicySpec>, IStatus<V1beta1RegionSecurityPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RegionSecurityPolicy";
    public const string KubeGroup = "compute.gcp.m.upbound.io";
    public const string KubePluralName = "regionsecuritypolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionSecurityPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionSecurityPolicySpec defines the desired state of RegionSecurityPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RegionSecurityPolicySpec Spec { get; set; }

    /// <summary>RegionSecurityPolicyStatus defines the observed state of RegionSecurityPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1RegionSecurityPolicyStatus? Status { get; set; }
}