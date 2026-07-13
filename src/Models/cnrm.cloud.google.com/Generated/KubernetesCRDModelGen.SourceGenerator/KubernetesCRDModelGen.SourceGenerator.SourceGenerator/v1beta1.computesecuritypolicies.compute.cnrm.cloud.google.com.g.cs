#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>ComputeSecurityPolicy is the Schema for the ComputeSecurityPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeSecurityPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeSecurityPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeSecurityPolicyList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computesecuritypolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeSecurityPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeSecurityPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeSecurityPolicy> Items { get; set; }
}

/// <summary>Auto Deploy Config of this security policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfigAutoDeployConfig
{
    /// <summary>Rules are only automatically deployed for alerts on potential attacks with confidence scores greater than this threshold.</summary>
    [JsonPropertyName("confidenceThreshold")]
    public double? ConfidenceThreshold { get; set; }

    /// <summary>Google Cloud Armor stops applying the action in the automatically deployed rule to an identified attacker after this duration. The rule continues to operate against new requests.</summary>
    [JsonPropertyName("expirationSec")]
    public int? ExpirationSec { get; set; }

    /// <summary>Rules are only automatically deployed when the estimated impact to baseline traffic from the suggested mitigation is below this threshold.</summary>
    [JsonPropertyName("impactedBaselineThreshold")]
    public double? ImpactedBaselineThreshold { get; set; }

    /// <summary>Identifies new attackers only when the load to the backend service that is under attack exceeds this threshold.</summary>
    [JsonPropertyName("loadThreshold")]
    public double? LoadThreshold { get; set; }
}

/// <summary>Layer 7 DDoS Defense Config of this security policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfigLayer7DdosDefenseConfig
{
    /// <summary>If set to true, enables CAAP for L7 DDoS detection.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Rule visibility. Supported values include: &quot;STANDARD&quot;, &quot;PREMIUM&quot;.</summary>
    [JsonPropertyName("ruleVisibility")]
    public string? RuleVisibility { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfig
{
    /// <summary>Auto Deploy Config of this security policy</summary>
    [JsonPropertyName("autoDeployConfig")]
    public V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfigAutoDeployConfig? AutoDeployConfig { get; set; }

    /// <summary>Layer 7 DDoS Defense Config of this security policy</summary>
    [JsonPropertyName("layer7DdosDefenseConfig")]
    public V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfigLayer7DdosDefenseConfig? Layer7DdosDefenseConfig { get; set; }
}

/// <summary>Custom configuration to apply the JSON parsing. Only applicable when json_parsing is set to STANDARD.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecAdvancedOptionsConfigJsonCustomConfig
{
    /// <summary>A list of custom Content-Type header values to apply the JSON parsing. As per RFC 1341, a Content-Type header value has the following format: Content-Type := type &quot;/&quot; subtype *[&quot;;&quot; parameter] When configuring a custom Content-Type header value, only the type/subtype needs to be specified, and the parameters should be excluded.</summary>
    [JsonPropertyName("contentTypes")]
    public required IList<string> ContentTypes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecAdvancedOptionsConfig
{
    /// <summary>Custom configuration to apply the JSON parsing. Only applicable when json_parsing is set to STANDARD.</summary>
    [JsonPropertyName("jsonCustomConfig")]
    public V1beta1ComputeSecurityPolicySpecAdvancedOptionsConfigJsonCustomConfig? JsonCustomConfig { get; set; }

    /// <summary>Check the JsonParsing enum for the list of possible values.</summary>
    [JsonPropertyName("jsonParsing")]
    public string? JsonParsing { get; set; }

    /// <summary>Check the LogLevel enum for the list of possible values.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>An optional list of case-insensitive request header names to use for resolving the callers client IP address.</summary>
    [JsonPropertyName("userIpRequestHeaders")]
    public IList<string>? UserIpRequestHeaders { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRecaptchaOptionsConfigRedirectSiteKeyRef
{
    /// <summary>The value of an externally managed RecaptchaEnterpriseKey resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a RecaptchaEnterpriseKey resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a RecaptchaEnterpriseKey resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRecaptchaOptionsConfig
{
    [JsonPropertyName("redirectSiteKeyRef")]
    public required V1beta1ComputeSecurityPolicySpecRecaptchaOptionsConfigRedirectSiteKeyRef RedirectSiteKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleHeaderActionRequestHeadersToAdds
{
    /// <summary>The name of the header to set.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value to set the named header to.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }
}

/// <summary>Optional, additional actions that are performed on headers. This field is only supported in Global Security Policies of type CLOUD_ARMOR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleHeaderAction
{
    /// <summary>The list of request headers to add or overwrite if they&apos;re already present.</summary>
    [JsonPropertyName("requestHeadersToAdds")]
    public IList<V1beta1ComputeSecurityPolicySpecRuleHeaderActionRequestHeadersToAdds>? RequestHeadersToAdds { get; set; }
}

/// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleMatchConfig
{
    /// <summary>CIDR IP address range. Maximum number of src_ip_ranges allowed is 10.</summary>
    [JsonPropertyName("srcIpRanges")]
    public required IList<string> SrcIpRanges { get; set; }
}

/// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. Expressions containing `evaluateThreatIntelligence` require Cloud Armor Managed Protection Plus tier and are not supported in Edge Policies nor in Regional Policies. Expressions containing `evaluatePreconfiguredExpr(&apos;sourceiplist-*&apos;)` require Cloud Armor Managed Protection Plus tier and are only supported in Global Security Policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleMatchExpr
{
    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }
}

/// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding &apos;action&apos; is enforced.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleMatch
{
    /// <summary>The configuration options available when specifying versioned_expr. This field must be specified if versioned_expr is specified and cannot be specified if versioned_expr is not specified.</summary>
    [JsonPropertyName("config")]
    public V1beta1ComputeSecurityPolicySpecRuleMatchConfig? Config { get; set; }

    /// <summary>User defined CEVAL expression. A CEVAL expression is used to specify match criteria such as origin.ip, source.region_code and contents in the request header. Expressions containing `evaluateThreatIntelligence` require Cloud Armor Managed Protection Plus tier and are not supported in Edge Policies nor in Regional Policies. Expressions containing `evaluatePreconfiguredExpr(&apos;sourceiplist-*&apos;)` require Cloud Armor Managed Protection Plus tier and are only supported in Global Security Policies.</summary>
    [JsonPropertyName("expr")]
    public V1beta1ComputeSecurityPolicySpecRuleMatchExpr? Expr { get; set; }

    /// <summary>Preconfigured versioned expression. If this field is specified, config must also be specified. Available preconfigured expressions along with their requirements are: SRC_IPS_V1 - must specify the corresponding src_ip_range field in config. Check the VersionedExpr enum for the list of possible values.</summary>
    [JsonPropertyName("versionedExpr")]
    public string? VersionedExpr { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestCookie
{
    /// <summary>The match operator for the field. Check the Op enum for the list of possible values.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The value of the field.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestHeader
{
    /// <summary>The match operator for the field. Check the Op enum for the list of possible values.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The value of the field.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestQueryParam
{
    /// <summary>The match operator for the field. Check the Op enum for the list of possible values.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The value of the field.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestUri
{
    /// <summary>The match operator for the field. Check the Op enum for the list of possible values.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The value of the field.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusion
{
    /// <summary>A list of request cookie names whose value will be excluded from inspection during preconfigured WAF evaluation.</summary>
    [JsonPropertyName("requestCookie")]
    public IList<V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestCookie>? RequestCookie { get; set; }

    /// <summary>A list of request header names whose value will be excluded from inspection during preconfigured WAF evaluation.</summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestHeader>? RequestHeader { get; set; }

    /// <summary>A list of request query parameter names whose value will be excluded from inspection during preconfigured WAF evaluation. Note that the parameter can be in the query string or in the POST body.</summary>
    [JsonPropertyName("requestQueryParam")]
    public IList<V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestQueryParam>? RequestQueryParam { get; set; }

    /// <summary>A list of request URIs from the request line to be excluded from inspection during preconfigured WAF evaluation. When specifying this field, the query or fragment part should be excluded.</summary>
    [JsonPropertyName("requestUri")]
    public IList<V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusionRequestUri>? RequestUri { get; set; }

    /// <summary>A list of target rule IDs under the WAF rule set to apply the preconfigured WAF exclusion. If omitted, it refers to all the rule IDs under the WAF rule set.</summary>
    [JsonPropertyName("targetRuleIds")]
    public IList<string>? TargetRuleIds { get; set; }

    /// <summary>Target WAF rule set to apply the preconfigured WAF exclusion.</summary>
    [JsonPropertyName("targetRuleSet")]
    public string? TargetRuleSet { get; set; }
}

/// <summary>Preconfigured WAF configuration to be applied for the rule. If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfig
{
    /// <summary>A list of exclusions to apply during preconfigured WAF evaluation.</summary>
    [JsonPropertyName("exclusion")]
    public IList<V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfigExclusion>? Exclusion { get; set; }
}

/// <summary>Can only be specified if the action for the rule is &quot;rate_based_ban&quot;. If specified, the key will be banned for the configured &apos;ban_duration_sec&apos; when the number of requests that exceed the &apos;rate_limit_threshold&apos; also exceed this &apos;ban_threshold&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsBanThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public required int Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public required int IntervalSec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsEnforceOnKeyConfigs
{
    /// <summary>Rate limit key name applicable only for the following key types: HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value. HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on. Possible values are: - ALL: A single rate limit threshold is applied to all the requests matching this rule. This is the default value if &quot;enforceOnKeyConfigs&quot; is not configured. - IP: The source IP address of the request is the key. Each IP has this limit enforced separately. - HTTP_HEADER: The value of the HTTP header whose name is configured under &quot;enforceOnKeyName&quot;. The key value is truncated to the first 128 bytes of the header value. If no such header is present in the request, the key type defaults to ALL. - XFF_IP: The first IP address (i.e. the originating client IP address) specified in the list of IPs under X-Forwarded-For HTTP header. If no such header is present or the value is not a valid IP, the key defaults to the source IP address of the request i.e. key type IP. - HTTP_COOKIE: The value of the HTTP cookie whose name is configured under &quot;enforceOnKeyName&quot;. The key value is truncated to the first 128 bytes of the cookie value. If no such cookie is present in the request, the key type defaults to ALL. - HTTP_PATH: The URL path of the HTTP request. The key value is truncated to the first 128 bytes. - SNI: Server name indication in the TLS session of the HTTPS request. The key value is truncated to the first 128 bytes. The key type defaults to ALL on a HTTP session. - REGION_CODE: The country/region from which the request originates. - TLS_JA3_FINGERPRINT: JA3 TLS/SSL fingerprint if the client connects using HTTPS, HTTP/2 or HTTP/3. If not available, the key type defaults to ALL. - USER_IP: The IP address of the originating client, which is resolved based on &quot;userIpRequestHeaders&quot; configured with the security policy. If there is no &quot;userIpRequestHeaders&quot; configuration or an IP address cannot be resolved from it, the key type defaults to IP. - TLS_JA4_FINGERPRINT: JA4 TLS/SSL fingerprint if the client connects using HTTPS, HTTP/2 or HTTP/3. If not available, the key type defaults to ALL. Check the EnforceOnKeyType enum for the list of possible values.</summary>
    [JsonPropertyName("enforceOnKeyType")]
    public string? EnforceOnKeyType { get; set; }
}

/// <summary>Parameters defining the redirect action that is used as the exceed action. Cannot be specified if the exceed action is not redirect. This field is only supported in Global Security Policies of type CLOUD_ARMOR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsExceedRedirectOptions
{
    /// <summary>Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Type of the redirect action. Possible values are: - GOOGLE_RECAPTCHA: redirect to reCAPTCHA for manual challenge assessment. - EXTERNAL_302: redirect to a different URL via a 302 response. Check the Type enum for the list of possible values.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Threshold at which to begin ratelimiting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsRateLimitThreshold
{
    /// <summary>Number of HTTP(S) requests for calculating the threshold.</summary>
    [JsonPropertyName("count")]
    public required int Count { get; set; }

    /// <summary>Interval over which the threshold is computed.</summary>
    [JsonPropertyName("intervalSec")]
    public required int IntervalSec { get; set; }
}

/// <summary>Must be specified if the action is &quot;rate_based_ban&quot; or &quot;throttle&quot;. Cannot be specified for any other actions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRateLimitOptions
{
    /// <summary>Can only be specified if the action for the rule is &quot;rate_based_ban&quot;. If specified, determines the time (in seconds) the traffic will continue to be banned by the rate limit after the rate falls below the threshold.</summary>
    [JsonPropertyName("banDurationSec")]
    public int? BanDurationSec { get; set; }

    /// <summary>Can only be specified if the action for the rule is &quot;rate_based_ban&quot;. If specified, the key will be banned for the configured &apos;ban_duration_sec&apos; when the number of requests that exceed the &apos;rate_limit_threshold&apos; also exceed this &apos;ban_threshold&apos;.</summary>
    [JsonPropertyName("banThreshold")]
    public V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsBanThreshold? BanThreshold { get; set; }

    /// <summary>Action to take for requests that are under the configured rate limit threshold. Valid option is &quot;allow&quot; only.</summary>
    [JsonPropertyName("conformAction")]
    public required string ConformAction { get; set; }

    /// <summary>Determines the key to enforce the rate_limit_threshold on. Possible values are: - ALL: A single rate limit threshold is applied to all the requests matching this rule. This is the default value if &quot;enforceOnKey&quot; is not configured. - IP: The source IP address of the request is the key. Each IP has this limit enforced separately. - HTTP_HEADER: The value of the HTTP header whose name is configured under &quot;enforceOnKeyName&quot;. The key value is truncated to the first 128 bytes of the header value. If no such header is present in the request, the key type defaults to ALL. - XFF_IP: The first IP address (i.e. the originating client IP address) specified in the list of IPs under X-Forwarded-For HTTP header. If no such header is present or the value is not a valid IP, the key defaults to the source IP address of the request i.e. key type IP. - HTTP_COOKIE: The value of the HTTP cookie whose name is configured under &quot;enforceOnKeyName&quot;. The key value is truncated to the first 128 bytes of the cookie value. If no such cookie is present in the request, the key type defaults to ALL. - HTTP_PATH: The URL path of the HTTP request. The key value is truncated to the first 128 bytes. - SNI: Server name indication in the TLS session of the HTTPS request. The key value is truncated to the first 128 bytes. The key type defaults to ALL on a HTTP session. - REGION_CODE: The country/region from which the request originates. - TLS_JA3_FINGERPRINT: JA3 TLS/SSL fingerprint if the client connects using HTTPS, HTTP/2 or HTTP/3. If not available, the key type defaults to ALL. - USER_IP: The IP address of the originating client, which is resolved based on &quot;userIpRequestHeaders&quot; configured with the security policy. If there is no &quot;userIpRequestHeaders&quot; configuration or an IP address cannot be resolved from it, the key type defaults to IP. - TLS_JA4_FINGERPRINT: JA4 TLS/SSL fingerprint if the client connects using HTTPS, HTTP/2 or HTTP/3. If not available, the key type defaults to ALL. Check the EnforceOnKey enum for the list of possible values.</summary>
    [JsonPropertyName("enforceOnKey")]
    public string? EnforceOnKey { get; set; }

    /// <summary>If specified, any combination of values of enforce_on_key_type/enforce_on_key_name is treated as the key on which ratelimit threshold/action is enforced. You can specify up to 3 enforce_on_key_configs. If enforce_on_key_configs is specified, enforce_on_key must not be specified.</summary>
    [JsonPropertyName("enforceOnKeyConfigs")]
    public IList<V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsEnforceOnKeyConfigs>? EnforceOnKeyConfigs { get; set; }

    /// <summary>Rate limit key name applicable only for the following key types: HTTP_HEADER -- Name of the HTTP header whose value is taken as the key value. HTTP_COOKIE -- Name of the HTTP cookie whose value is taken as the key value.</summary>
    [JsonPropertyName("enforceOnKeyName")]
    public string? EnforceOnKeyName { get; set; }

    /// <summary>Action to take for requests that are above the configured rate limit threshold, to either deny with a specified HTTP response code, or redirect to a different endpoint. Valid options are `deny(STATUS)`, where valid values for `STATUS` are 403, 404, 429, and 502, and `redirect`, where the redirect parameters come from `exceedRedirectOptions` below. The `redirect` action is only supported in Global Security Policies of type CLOUD_ARMOR.</summary>
    [JsonPropertyName("exceedAction")]
    public required string ExceedAction { get; set; }

    /// <summary>Parameters defining the redirect action that is used as the exceed action. Cannot be specified if the exceed action is not redirect. This field is only supported in Global Security Policies of type CLOUD_ARMOR.</summary>
    [JsonPropertyName("exceedRedirectOptions")]
    public V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsExceedRedirectOptions? ExceedRedirectOptions { get; set; }

    /// <summary>Threshold at which to begin ratelimiting.</summary>
    [JsonPropertyName("rateLimitThreshold")]
    public required V1beta1ComputeSecurityPolicySpecRuleRateLimitOptionsRateLimitThreshold RateLimitThreshold { get; set; }
}

/// <summary>Parameters defining the redirect action. Cannot be specified for any other actions. This field is only supported in Global Security Policies of type CLOUD_ARMOR.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRuleRedirectOptions
{
    /// <summary>Target for the redirect action. This is required if the type is EXTERNAL_302 and cannot be specified for GOOGLE_RECAPTCHA.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Type of the redirect action. Possible values are: - GOOGLE_RECAPTCHA: redirect to reCAPTCHA for manual challenge assessment. - EXTERNAL_302: redirect to a different URL via a 302 response. Check the Type enum for the list of possible values.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpecRule
{
    /// <summary>The Action to perform when the rule is matched. The following are the valid actions: - allow: allow access to target. - deny(STATUS): deny access to target, returns the HTTP response code specified. Valid values for `STATUS` are 403, 404, and 502. - rate_based_ban: limit client traffic to the configured threshold and ban the client if the traffic exceeds the threshold. Configure parameters for this action in RateLimitOptions. Requires rate_limit_options to be set. - redirect: redirect to a different target. This can either be an internal reCAPTCHA redirect, or an external URL-based redirect via a 302 response. Parameters for this action can be configured via redirectOptions. This action is only supported in Global Security Policies of type CLOUD_ARMOR. - throttle: limit client traffic to the configured threshold. Configure parameters for this action in rateLimitOptions. Requires rate_limit_options to be set for this.</summary>
    [JsonPropertyName("action")]
    public required string Action { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional, additional actions that are performed on headers. This field is only supported in Global Security Policies of type CLOUD_ARMOR.</summary>
    [JsonPropertyName("headerAction")]
    public V1beta1ComputeSecurityPolicySpecRuleHeaderAction? HeaderAction { get; set; }

    /// <summary>A match condition that incoming traffic is evaluated against. If it evaluates to true, the corresponding &apos;action&apos; is enforced.</summary>
    [JsonPropertyName("match")]
    public required V1beta1ComputeSecurityPolicySpecRuleMatch Match { get; set; }

    /// <summary>Preconfigured WAF configuration to be applied for the rule. If the rule does not evaluate preconfigured WAF rules, i.e., if evaluatePreconfiguredWaf() is not used, this field will have no effect.</summary>
    [JsonPropertyName("preconfiguredWafConfig")]
    public V1beta1ComputeSecurityPolicySpecRulePreconfiguredWafConfig? PreconfiguredWafConfig { get; set; }

    /// <summary>If set to true, the specified action is not enforced.</summary>
    [JsonPropertyName("preview")]
    public bool? Preview { get; set; }

    /// <summary>An integer indicating the priority of a rule in the list. The priority must be a positive value between 0 and 2147483647. Rules are evaluated from highest to lowest priority where 0 is the highest priority and 2147483647 is the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public required int Priority { get; set; }

    /// <summary>Must be specified if the action is &quot;rate_based_ban&quot; or &quot;throttle&quot;. Cannot be specified for any other actions.</summary>
    [JsonPropertyName("rateLimitOptions")]
    public V1beta1ComputeSecurityPolicySpecRuleRateLimitOptions? RateLimitOptions { get; set; }

    /// <summary>Parameters defining the redirect action. Cannot be specified for any other actions. This field is only supported in Global Security Policies of type CLOUD_ARMOR.</summary>
    [JsonPropertyName("redirectOptions")]
    public V1beta1ComputeSecurityPolicySpecRuleRedirectOptions? RedirectOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicySpec
{
    [JsonPropertyName("adaptiveProtectionConfig")]
    public V1beta1ComputeSecurityPolicySpecAdaptiveProtectionConfig? AdaptiveProtectionConfig { get; set; }

    [JsonPropertyName("advancedOptionsConfig")]
    public V1beta1ComputeSecurityPolicySpecAdvancedOptionsConfig? AdvancedOptionsConfig { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("recaptchaOptionsConfig")]
    public V1beta1ComputeSecurityPolicySpecRecaptchaOptionsConfig? RecaptchaOptionsConfig { get; set; }

    /// <summary>The ComputeSecurityPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    [JsonPropertyName("rule")]
    public IList<V1beta1ComputeSecurityPolicySpecRule>? Rule { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ComputeSecurityPolicyStatus defines the config connector machine state of ComputeSecurityPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSecurityPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeSecurityPolicyStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary>ComputeSecurityPolicy is the Schema for the ComputeSecurityPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeSecurityPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeSecurityPolicySpec>, IStatus<V1beta1ComputeSecurityPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeSecurityPolicy";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computesecuritypolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeSecurityPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1beta1ComputeSecurityPolicySpec Spec { get; set; }

    /// <summary>ComputeSecurityPolicyStatus defines the config connector machine state of ComputeSecurityPolicy</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeSecurityPolicyStatus? Status { get; set; }
}