#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkservices.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkServicesEdgeCacheServiceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkServicesEdgeCacheService>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkServicesEdgeCacheServiceList";
    public const string KubeGroup = "networkservices.cnrm.cloud.google.com";
    public const string KubePluralName = "networkservicesedgecacheservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkservices.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkServicesEdgeCacheServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NetworkServicesEdgeCacheService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NetworkServicesEdgeCacheService> Items { get; set; }
}

/// <summary>Specifies the logging options for the traffic served by this service. If logging is enabled, logs will be exported to Cloud Logging.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecLogConfig
{
    /// <summary>Specifies whether to enable logging for traffic served by this service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    /// Configures the sampling rate of requests, where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported. The default value is 1.0, and the value of the field must be in [0, 1].
    /// 
    /// This field can only be specified if logging is enabled for this service.
    /// </summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingHostRule
{
    /// <summary>A human-readable description of the hostRule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The list of host patterns to match.
    /// 
    /// Host patterns must be valid hostnames. Ports are not allowed. Wildcard hosts are supported in the suffix or prefix form. * matches any string of ([a-z0-9-.]*). It does not match the empty string.
    /// 
    /// When multiple hosts are specified, hosts are matched in the following priority:
    /// 
    ///   1. Exact domain names: &apos; &apos;www.foo.com&apos; &apos;.
    ///   2. Suffix domain wildcards: &apos; &apos;*.foo.com&apos; &apos; or &apos; &apos;*-bar.foo.com&apos; &apos;.
    ///   3. Prefix domain wildcards: &apos; &apos;foo.*&apos; &apos; or &apos; &apos;foo-*&apos; &apos;.
    ///   4. Special wildcard &apos; &apos;*&apos; &apos; matching any domain.
    /// 
    ///   Notes:
    /// 
    ///     The wildcard will not match the empty string. e.g. &apos; &apos;*-bar.foo.com&apos; &apos; will match &apos; &apos;baz-bar.foo.com&apos; &apos; but not &apos; &apos;-bar.foo.com&apos; &apos;. The longest wildcards match first. Only a single host in the entire service can match on &apos; &apos;*&apos; &apos;. A domain must be unique across all configured hosts within a service.
    /// 
    ///     Hosts are matched against the HTTP Host header, or for HTTP/2 and HTTP/3, the &quot;:authority&quot; header, from the incoming request.
    /// 
    ///     You may specify up to 10 hosts.
    /// </summary>
    [JsonPropertyName("hosts")]
    public required IList<string> Hosts { get; set; }

    /// <summary>The name of the pathMatcher associated with this hostRule.</summary>
    [JsonPropertyName("pathMatcher")]
    public required string PathMatcher { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleHeaderActionRequestHeaderToAdd
{
    /// <summary>The name of the header to add.</summary>
    [JsonPropertyName("headerName")]
    public required string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public required string HeaderValue { get; set; }

    /// <summary>Whether to replace all existing headers with the same name.</summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleHeaderActionRequestHeaderToRemove
{
    /// <summary>The name of the header to remove.</summary>
    [JsonPropertyName("headerName")]
    public required string HeaderName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleHeaderActionResponseHeaderToAdd
{
    /// <summary>The name of the header to add.</summary>
    [JsonPropertyName("headerName")]
    public required string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public required string HeaderValue { get; set; }

    /// <summary>Whether to replace all existing headers with the same name.</summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleHeaderActionResponseHeaderToRemove
{
    /// <summary>
    /// Headers to remove from the response prior to sending it back to the client.
    /// 
    /// Response headers are only sent to the client, and do not have an effect on the cache serving the response.
    /// </summary>
    [JsonPropertyName("headerName")]
    public required string HeaderName { get; set; }
}

/// <summary>The header actions, including adding &amp; removing headers, for requests that match this route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleHeaderAction
{
    /// <summary>Describes a header to add.</summary>
    [JsonPropertyName("requestHeaderToAdd")]
    public IList<V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleHeaderActionRequestHeaderToAdd>? RequestHeaderToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the origin.</summary>
    [JsonPropertyName("requestHeaderToRemove")]
    public IList<V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleHeaderActionRequestHeaderToRemove>? RequestHeaderToRemove { get; set; }

    /// <summary>
    /// Headers to add to the response prior to sending it back to the client.
    /// 
    /// Response headers are only sent to the client, and do not have an effect on the cache serving the response.
    /// </summary>
    [JsonPropertyName("responseHeaderToAdd")]
    public IList<V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleHeaderActionResponseHeaderToAdd>? ResponseHeaderToAdd { get; set; }

    /// <summary>A list of header names for headers that need to be removed from the request prior to forwarding the request to the origin.</summary>
    [JsonPropertyName("responseHeaderToRemove")]
    public IList<V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleHeaderActionResponseHeaderToRemove>? ResponseHeaderToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleMatchRuleHeaderMatch
{
    /// <summary>The value of the header should exactly match contents of exactMatch.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The header name to match on.</summary>
    [JsonPropertyName("headerName")]
    public required string HeaderName { get; set; }

    /// <summary>
    /// If set to false (default), the headerMatch is considered a match if the match criteria above are met.
    /// If set to true, the headerMatch is considered a match if the match criteria above are NOT met.
    /// </summary>
    [JsonPropertyName("invertMatch")]
    public bool? InvertMatch { get; set; }

    /// <summary>The value of the header must start with the contents of prefixMatch.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>A header with the contents of headerName must exist. The match takes place whether or not the request&apos;s header has a value.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>The value of the header must end with the contents of suffixMatch.</summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleMatchRuleQueryParameterMatch
{
    /// <summary>The queryParameterMatch matches if the value of the parameter exactly matches the contents of exactMatch.</summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the query parameter to match. The query parameter must exist in the request, in the absence of which the request match fails.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Specifies that the queryParameterMatch matches if the request contains the query parameter, irrespective of whether the parameter has a value or not.</summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleMatchRule
{
    /// <summary>For satisfying the matchRule condition, the path of the request must exactly match the value specified in fullPathMatch after removing any query parameters and anchor that may be part of the original URL.</summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>Specifies a list of header match criteria, all of which must match corresponding headers in the request.</summary>
    [JsonPropertyName("headerMatch")]
    public IList<V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleMatchRuleHeaderMatch>? HeaderMatch { get; set; }

    /// <summary>Specifies that prefixMatch and fullPathMatch matches are case sensitive.</summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// For satisfying the matchRule condition, the path of the request
    /// must match the wildcard pattern specified in pathTemplateMatch
    /// after removing any query parameters and anchor that may be part
    /// of the original URL.
    /// 
    /// pathTemplateMatch must be between 1 and 255 characters
    /// (inclusive).  The pattern specified by pathTemplateMatch may
    /// have at most 5 wildcard operators and at most 5 variable
    /// captures in total.
    /// </summary>
    [JsonPropertyName("pathTemplateMatch")]
    public string? PathTemplateMatch { get; set; }

    /// <summary>For satisfying the matchRule condition, the request&apos;s path must begin with the specified prefixMatch. prefixMatch must begin with a /.</summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>Specifies a list of query parameter match criteria, all of which must match corresponding query parameters in the request.</summary>
    [JsonPropertyName("queryParameterMatch")]
    public IList<V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleMatchRuleQueryParameterMatch>? QueryParameterMatch { get; set; }
}

/// <summary>
/// Enable signature generation or propagation on this route.
/// 
/// This field may only be specified when signedRequestMode is set to REQUIRE_TOKENS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionCdnPolicyAddSignatures
{
    /// <summary>The actions to take to add signatures to responses. Possible values: [&quot;GENERATE_COOKIE&quot;, &quot;GENERATE_TOKEN_HLS_COOKIELESS&quot;, &quot;PROPAGATE_TOKEN_HLS_COOKIELESS&quot;].</summary>
    [JsonPropertyName("actions")]
    public required IList<string> Actions { get; set; }

    /// <summary>
    /// The parameters to copy from the verified token to the generated token.
    /// 
    /// Only the following parameters may be copied:
    /// 
    ///   * &apos;PathGlobs&apos;
    ///   * &apos;paths&apos;
    ///   * &apos;acl&apos;
    ///   * &apos;URLPrefix&apos;
    ///   * &apos;IPRanges&apos;
    ///   * &apos;SessionID&apos;
    ///   * &apos;id&apos;
    ///   * &apos;Data&apos;
    ///   * &apos;data&apos;
    ///   * &apos;payload&apos;
    ///   * &apos;Headers&apos;
    /// 
    /// You may specify up to 6 parameters to copy.  A given parameter is be copied only if the parameter exists in the verified token.  Parameter names are matched exactly as specified.  The order of the parameters does not matter.  Duplicates are not allowed.
    /// 
    /// This field may only be specified when the GENERATE_COOKIE or GENERATE_TOKEN_HLS_COOKIELESS actions are specified.
    /// </summary>
    [JsonPropertyName("copiedParameters")]
    public IList<string>? CopiedParameters { get; set; }

    /// <summary>
    /// The keyset to use for signature generation.
    /// 
    /// The following are both valid paths to an EdgeCacheKeyset resource:
    /// 
    ///   * &apos;projects/project/locations/global/edgeCacheKeysets/yourKeyset&apos;
    ///   * &apos;yourKeyset&apos;
    /// 
    /// This must be specified when the GENERATE_COOKIE or GENERATE_TOKEN_HLS_COOKIELESS actions are specified.  This field may not be specified otherwise.
    /// </summary>
    [JsonPropertyName("keyset")]
    public string? Keyset { get; set; }

    /// <summary>
    /// The query parameter in which to put the generated token.
    /// 
    /// If not specified, defaults to &apos;edge-cache-token&apos;.
    /// 
    /// If specified, the name must be 1-64 characters long and match the regular expression &apos;[a-zA-Z]([a-zA-Z0-9_-])*&apos; which means the first character must be a letter, and all following characters must be a dash, underscore, letter or digit.
    /// 
    /// This field may only be set when the GENERATE_TOKEN_HLS_COOKIELESS or PROPAGATE_TOKEN_HLS_COOKIELESS actions are specified.
    /// </summary>
    [JsonPropertyName("tokenQueryParameter")]
    public string? TokenQueryParameter { get; set; }

    /// <summary>
    /// The duration the token is valid starting from the moment the token is first generated.
    /// 
    /// Defaults to &apos;86400s&apos; (1 day).
    /// 
    /// The TTL must be &gt;= 0 and &lt;= 604,800 seconds (1 week).
    /// 
    /// This field may only be specified when the GENERATE_COOKIE or GENERATE_TOKEN_HLS_COOKIELESS actions are specified.
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("tokenTtl")]
    public string? TokenTtl { get; set; }
}

/// <summary>Defines the request parameters that contribute to the cache key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionCdnPolicyCacheKeyPolicy
{
    /// <summary>
    /// If true, requests to different hosts will be cached separately.
    /// 
    /// Note: this should only be enabled if hosts share the same origin and content. Removing the host from the cache key may inadvertently result in different objects being cached than intended, depending on which route the first user matched.
    /// </summary>
    [JsonPropertyName("excludeHost")]
    public bool? ExcludeHost { get; set; }

    /// <summary>
    /// If true, exclude query string parameters from the cache key
    /// 
    /// If false (the default), include the query string parameters in
    /// the cache key according to includeQueryParameters and
    /// excludeQueryParameters. If neither includeQueryParameters nor
    /// excludeQueryParameters is set, the entire query string will be
    /// included.
    /// </summary>
    [JsonPropertyName("excludeQueryString")]
    public bool? ExcludeQueryString { get; set; }

    /// <summary>
    /// Names of query string parameters to exclude from cache keys. All other parameters will be included.
    /// 
    /// Either specify includedQueryParameters or excludedQueryParameters, not both. &apos; &amp; &apos; and &apos;=&apos; will be percent encoded and not treated as delimiters.
    /// </summary>
    [JsonPropertyName("excludedQueryParameters")]
    public IList<string>? ExcludedQueryParameters { get; set; }

    /// <summary>If true, http and https requests will be cached separately.</summary>
    [JsonPropertyName("includeProtocol")]
    public bool? IncludeProtocol { get; set; }

    /// <summary>
    /// Names of Cookies to include in cache keys.  The cookie name and cookie value of each cookie named will be used as part of the cache key.
    /// 
    /// Cookie names:
    ///   - must be valid RFC 6265 &quot;cookie-name&quot; tokens
    ///   - are case sensitive
    ///   - cannot start with &quot;Edge-Cache-&quot; (case insensitive)
    /// 
    ///   Note that specifying several cookies, and/or cookies that have a large range of values (e.g., per-user) will dramatically impact the cache hit rate, and may result in a higher eviction rate and reduced performance.
    /// 
    ///   You may specify up to three cookie names.
    /// </summary>
    [JsonPropertyName("includedCookieNames")]
    public IList<string>? IncludedCookieNames { get; set; }

    /// <summary>
    /// Names of HTTP request headers to include in cache keys. The value of the header field will be used as part of the cache key.
    /// 
    /// - Header names must be valid HTTP RFC 7230 header field values.
    /// - Header field names are case insensitive
    /// - To include the HTTP method, use &quot;:method&quot;
    /// 
    /// Note that specifying several headers, and/or headers that have a large range of values (e.g. per-user) will dramatically impact the cache hit rate, and may result in a higher eviction rate and reduced performance.
    /// </summary>
    [JsonPropertyName("includedHeaderNames")]
    public IList<string>? IncludedHeaderNames { get; set; }

    /// <summary>
    /// Names of query string parameters to include in cache keys. All other parameters will be excluded.
    /// 
    /// Either specify includedQueryParameters or excludedQueryParameters, not both. &apos; &amp; &apos; and &apos;=&apos; will be percent encoded and not treated as delimiters.
    /// </summary>
    [JsonPropertyName("includedQueryParameters")]
    public IList<string>? IncludedQueryParameters { get; set; }
}

/// <summary>
/// Additional options for signed tokens.
/// 
/// signedTokenOptions may only be specified when signedRequestMode is REQUIRE_TOKENS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionCdnPolicySignedTokenOptions
{
    /// <summary>
    /// The allowed signature algorithms to use.
    /// 
    /// Defaults to using only ED25519.
    /// 
    /// You may specify up to 3 signature algorithms to use. Possible values: [&quot;ED25519&quot;, &quot;HMAC_SHA_256&quot;, &quot;HMAC_SHA1&quot;].
    /// </summary>
    [JsonPropertyName("allowedSignatureAlgorithms")]
    public IList<string>? AllowedSignatureAlgorithms { get; set; }

    /// <summary>
    /// The query parameter in which to find the token.
    /// 
    /// The name must be 1-64 characters long and match the regular expression &apos;[a-zA-Z]([a-zA-Z0-9_-])*&apos; which means the first character must be a letter, and all following characters must be a dash, underscore, letter or digit.
    /// 
    /// Defaults to &apos;edge-cache-token&apos;.
    /// </summary>
    [JsonPropertyName("tokenQueryParameter")]
    public string? TokenQueryParameter { get; set; }
}

/// <summary>The policy to use for defining caching and signed request behaviour for requests that match this route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionCdnPolicy
{
    /// <summary>
    /// Enable signature generation or propagation on this route.
    /// 
    /// This field may only be specified when signedRequestMode is set to REQUIRE_TOKENS.
    /// </summary>
    [JsonPropertyName("addSignatures")]
    public V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionCdnPolicyAddSignatures? AddSignatures { get; set; }

    /// <summary>Defines the request parameters that contribute to the cache key.</summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

    /// <summary>
    /// Cache modes allow users to control the behaviour of the cache, what content it should cache automatically, whether to respect origin headers, or whether to unconditionally cache all responses.
    /// 
    /// For all cache modes, Cache-Control headers will be passed to the client. Use clientTtl to override what is sent to the client. Possible values: [&quot;CACHE_ALL_STATIC&quot;, &quot;USE_ORIGIN_HEADERS&quot;, &quot;FORCE_CACHE_ALL&quot;, &quot;BYPASS_CACHE&quot;].
    /// </summary>
    [JsonPropertyName("cacheMode")]
    public string? CacheMode { get; set; }

    /// <summary>
    /// Specifies a separate client (e.g. browser client) TTL, separate from the TTL used by the edge caches. Leaving this empty will use the same cache TTL for both the CDN and the client-facing response.
    /// 
    /// - The TTL must be &gt; 0 and &lt;= 86400s (1 day)
    /// - The clientTtl cannot be larger than the defaultTtl (if set)
    /// - Fractions of a second are not allowed.
    /// 
    /// Omit this field to use the defaultTtl, or the max-age set by the origin, as the client-facing TTL.
    /// 
    /// When the cache mode is set to &quot;USE_ORIGIN_HEADERS&quot; or &quot;BYPASS_CACHE&quot;, you must omit this field.
    /// A duration in seconds terminated by &apos;s&apos;. Example: &quot;3s&quot;.
    /// </summary>
    [JsonPropertyName("clientTtl")]
    public string? ClientTtl { get; set; }

    /// <summary>
    /// Specifies the default TTL for cached content served by this origin for responses that do not have an existing valid TTL (max-age or s-max-age).
    /// 
    /// Defaults to 3600s (1 hour).
    /// 
    /// - The TTL must be &gt;= 0 and &lt;= 31,536,000 seconds (1 year)
    /// - Setting a TTL of &quot;0&quot; means &quot;always revalidate&quot; (equivalent to must-revalidate)
    /// - The value of defaultTTL cannot be set to a value greater than that of maxTTL.
    /// - Fractions of a second are not allowed.
    /// - When the cacheMode is set to FORCE_CACHE_ALL, the defaultTTL will overwrite the TTL set in all responses.
    /// 
    /// Note that infrequently accessed objects may be evicted from the cache before the defined TTL. Objects that expire will be revalidated with the origin.
    /// 
    /// When the cache mode is set to &quot;USE_ORIGIN_HEADERS&quot; or &quot;BYPASS_CACHE&quot;, you must omit this field.
    /// 
    /// A duration in seconds terminated by &apos;s&apos;. Example: &quot;3s&quot;.
    /// </summary>
    [JsonPropertyName("defaultTtl")]
    public string? DefaultTtl { get; set; }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin.
    /// 
    /// Defaults to 86400s (1 day).
    /// 
    /// Cache directives that attempt to set a max-age or s-maxage higher than this, or an Expires header more than maxTtl seconds in the future will be capped at the value of maxTTL, as if it were the value of an s-maxage Cache-Control directive.
    /// 
    /// - The TTL must be &gt;= 0 and &lt;= 31,536,000 seconds (1 year)
    /// - Setting a TTL of &quot;0&quot; means &quot;always revalidate&quot;
    /// - The value of maxTtl must be equal to or greater than defaultTtl.
    /// - Fractions of a second are not allowed.
    /// 
    /// When the cache mode is set to &quot;USE_ORIGIN_HEADERS&quot;, &quot;FORCE_CACHE_ALL&quot;, or &quot;BYPASS_CACHE&quot;, you must omit this field.
    /// 
    /// A duration in seconds terminated by &apos;s&apos;. Example: &quot;3s&quot;.
    /// </summary>
    [JsonPropertyName("maxTtl")]
    public string? MaxTtl { get; set; }

    /// <summary>
    /// Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects. This can reduce the load on your origin and improve end-user experience by reducing response latency.
    /// 
    /// By default, the CDNPolicy will apply the following default TTLs to these status codes:
    /// 
    /// - HTTP 300 (Multiple Choice), 301, 308 (Permanent Redirects): 10m
    /// - HTTP 404 (Not Found), 410 (Gone), 451 (Unavailable For Legal Reasons): 120s
    /// - HTTP 405 (Method Not Found), 414 (URI Too Long), 501 (Not Implemented): 60s
    /// 
    /// These defaults can be overridden in negativeCachingPolicy.
    /// </summary>
    [JsonPropertyName("negativeCaching")]
    public bool? NegativeCaching { get; set; }

    /// <summary>
    /// Sets a cache TTL for the specified HTTP status code. negativeCaching must be enabled to configure negativeCachingPolicy.
    /// 
    /// - Omitting the policy and leaving negativeCaching enabled will use the default TTLs for each status code, defined in negativeCaching.
    /// - TTLs must be &gt;= 0 (where 0 is &quot;always revalidate&quot;) and &lt;= 86400s (1 day)
    /// 
    /// Note that when specifying an explicit negativeCachingPolicy, you should take care to specify a cache TTL for all response codes that you wish to cache. The CDNPolicy will not apply any default negative caching when a policy exists.
    /// </summary>
    [JsonPropertyName("negativeCachingPolicy")]
    public IDictionary<string, string>? NegativeCachingPolicy { get; set; }

    /// <summary>The EdgeCacheKeyset containing the set of public keys used to validate signed requests at the edge.</summary>
    [JsonPropertyName("signedRequestKeyset")]
    public string? SignedRequestKeyset { get; set; }

    /// <summary>
    /// Limit how far into the future the expiration time of a signed request may be.
    /// 
    /// When set, a signed request is rejected if its expiration time is later than now + signedRequestMaximumExpirationTtl, where now is the time at which the signed request is first handled by the CDN.
    /// 
    /// - The TTL must be &gt; 0.
    /// - Fractions of a second are not allowed.
    /// 
    /// By default, signedRequestMaximumExpirationTtl is not set and the expiration time of a signed request may be arbitrarily far into future.
    /// </summary>
    [JsonPropertyName("signedRequestMaximumExpirationTtl")]
    public string? SignedRequestMaximumExpirationTtl { get; set; }

    /// <summary>
    /// Whether to enforce signed requests. The default value is DISABLED, which means all content is public, and does not authorize access.
    /// 
    /// You must also set a signedRequestKeyset to enable signed requests.
    /// 
    /// When set to REQUIRE_SIGNATURES, all matching requests will have their signature validated. Requests that were not signed with the corresponding private key, or that are otherwise invalid (expired, do not match the signature, IP address, or header) will be rejected with a HTTP 403 and (if enabled) logged. Possible values: [&quot;DISABLED&quot;, &quot;REQUIRE_SIGNATURES&quot;, &quot;REQUIRE_TOKENS&quot;].
    /// </summary>
    [JsonPropertyName("signedRequestMode")]
    public string? SignedRequestMode { get; set; }

    /// <summary>
    /// Additional options for signed tokens.
    /// 
    /// signedTokenOptions may only be specified when signedRequestMode is REQUIRE_TOKENS.
    /// </summary>
    [JsonPropertyName("signedTokenOptions")]
    public V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionCdnPolicySignedTokenOptions? SignedTokenOptions { get; set; }
}

/// <summary>CORSPolicy defines Cross-Origin-Resource-Sharing configuration, including which CORS response headers will be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the actual request can include user credentials.
    /// 
    /// This translates to the Access-Control-Allow-Credentials response header.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers response header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods response header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests.
    /// 
    /// This translates to the Access-Control-Allow-Origin response header.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled. The default value is false, which indicates that the CORS policy is in effect.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers response header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long results of a preflight request can be cached by a client in seconds. Note that many browser clients enforce a maximum TTL of 600s (10 minutes).
    /// 
    /// - Setting the value to -1 forces a pre-flight check for all requests (not recommended)
    /// - A maximum TTL of 86400s can be set, but note that (as above) some clients may force pre-flight checks at a more regular interval.
    /// - This translates to the Access-Control-Max-Age header.
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public required string MaxAge { get; set; }
}

/// <summary>The URL rewrite configuration for requests that match this route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected origin, the request&apos;s host header is replaced with contents of hostRewrite.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>Prior to forwarding the request to the selected origin, the matching portion of the request&apos;s path is replaced by pathPrefixRewrite.</summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected origin, if the
    /// request matched a pathTemplateMatch, the matching portion of the
    /// request&apos;s path is replaced re-written using the pattern specified
    /// by pathTemplateRewrite.
    /// 
    /// pathTemplateRewrite must be between 1 and 255 characters
    /// (inclusive), must start with a &apos;/&apos;, and must only use variables
    /// captured by the route&apos;s pathTemplate matchers.
    /// 
    /// pathTemplateRewrite may only be used when all of a route&apos;s
    /// MatchRules specify pathTemplate.
    /// 
    /// Only one of pathPrefixRewrite and pathTemplateRewrite may be
    /// specified.
    /// </summary>
    [JsonPropertyName("pathTemplateRewrite")]
    public string? PathTemplateRewrite { get; set; }
}

/// <summary>In response to a matching path, the routeAction performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteAction
{
    /// <summary>The policy to use for defining caching and signed request behaviour for requests that match this route.</summary>
    [JsonPropertyName("cdnPolicy")]
    public V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionCdnPolicy? CdnPolicy { get; set; }

    /// <summary>CORSPolicy defines Cross-Origin-Resource-Sharing configuration, including which CORS response headers will be set.</summary>
    [JsonPropertyName("corsPolicy")]
    public V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>The URL rewrite configuration for requests that match this route.</summary>
    [JsonPropertyName("urlRewrite")]
    public V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteActionUrlRewrite? UrlRewrite { get; set; }
}

/// <summary>The URL redirect configuration for requests that match this route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleUrlRedirect
{
    /// <summary>The host that will be used in the redirect response instead of the one that was supplied in the request.</summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https. If set to false, the URL scheme of the redirected request will remain the same as that of the request.
    /// 
    /// This can only be set if there is at least one (1) edgeSslCertificate set on the service.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was supplied in the request.
    /// 
    /// pathRedirect cannot be supplied together with prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect.
    /// 
    /// The path value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the routeRule, retaining the remaining portion of the URL before redirecting the request.
    /// 
    /// prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or neither. If neither is supplied, the path of the original request will be used for the redirect.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>
    /// The HTTP Status code to use for this RedirectAction.
    /// 
    /// The supported values are:
    /// 
    /// - &apos;MOVED_PERMANENTLY_DEFAULT&apos;, which is the default value and corresponds to 301.
    /// - &apos;FOUND&apos;, which corresponds to 302.
    /// - &apos;SEE_OTHER&apos; which corresponds to 303.
    /// - &apos;TEMPORARY_REDIRECT&apos;, which corresponds to 307. in this case, the request method will be retained.
    /// - &apos;PERMANENT_REDIRECT&apos;, which corresponds to 308. in this case, the request method will be retained. Possible values: [&quot;MOVED_PERMANENTLY_DEFAULT&quot;, &quot;FOUND&quot;, &quot;SEE_OTHER&quot;, &quot;TEMPORARY_REDIRECT&quot;, &quot;PERMANENT_REDIRECT&quot;].
    /// </summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>If set to true, any accompanying query portion of the original URL is removed prior to redirecting the request. If set to false, the query portion of the original URL is retained.</summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRule
{
    /// <summary>A human-readable description of the routeRule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The header actions, including adding &amp; removing headers, for requests that match this route.</summary>
    [JsonPropertyName("headerAction")]
    public V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// The list of criteria for matching attributes of a request to this routeRule. This list has OR semantics: the request matches this routeRule when any of the matchRules are satisfied. However predicates
    /// within a given matchRule have AND semantics. All predicates within a matchRule must match for the request to match the rule.
    /// </summary>
    [JsonPropertyName("matchRule")]
    public required IList<V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleMatchRule> MatchRule { get; set; }

    /// <summary>
    /// The Origin resource that requests to this route should fetch from when a matching response is not in cache. Origins can be defined as short names (&quot;my-origin&quot;) or fully-qualified resource URLs - e.g. &quot;networkservices.googleapis.com/projects/my-project/global/edgecacheorigins/my-origin&quot;
    /// 
    /// Only one of origin or urlRedirect can be set.
    /// </summary>
    [JsonPropertyName("origin")]
    public string? Origin { get; set; }

    /// <summary>
    /// The priority of this route rule, where 1 is the highest priority.
    /// 
    /// You cannot configure two or more routeRules with the same priority. Priority for each rule must be set to a number between 1 and 999 inclusive.
    /// 
    /// Priority numbers can have gaps, which enable you to add or remove rules in the future without affecting the rest of the rules. For example, 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers
    /// to which you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the future without any impact on existing rules.
    /// </summary>
    [JsonPropertyName("priority")]
    public required string Priority { get; set; }

    /// <summary>In response to a matching path, the routeAction performs advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request to the selected origin.</summary>
    [JsonPropertyName("routeAction")]
    public V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleRouteAction? RouteAction { get; set; }

    /// <summary>The URL redirect configuration for requests that match this route.</summary>
    [JsonPropertyName("urlRedirect")]
    public V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRuleUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcher
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name to which this PathMatcher is referred by the HostRule.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The routeRules to match against. routeRules support advanced routing behaviour, and can match on paths, headers and query parameters, as well as status codes and HTTP methods.</summary>
    [JsonPropertyName("routeRule")]
    public required IList<V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcherRouteRule> RouteRule { get; set; }
}

/// <summary>Defines how requests are routed, modified, cached and/or which origin content is filled from.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpecRouting
{
    /// <summary>The list of hostRules to match against. These rules define which hostnames the EdgeCacheService will match against, and which route configurations apply.</summary>
    [JsonPropertyName("hostRule")]
    public required IList<V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingHostRule> HostRule { get; set; }

    /// <summary>The list of pathMatchers referenced via name by hostRules. PathMatcher is used to match the path portion of the URL when a HostRule matches the URL&apos;s host portion.</summary>
    [JsonPropertyName("pathMatcher")]
    public required IList<V1alpha1NetworkServicesEdgeCacheServiceSpecRoutingPathMatcher> PathMatcher { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceSpec
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Disables HTTP/2.
    /// 
    /// HTTP/2 (h2) is enabled by default and recommended for performance. HTTP/2 improves connection re-use and reduces connection setup overhead by sending multiple streams over the same connection.
    /// 
    /// Some legacy HTTP clients may have issues with HTTP/2 connections due to broken HTTP/2 implementations. Setting this to true will prevent HTTP/2 from being advertised and negotiated.
    /// </summary>
    [JsonPropertyName("disableHttp2")]
    public bool? DisableHttp2 { get; set; }

    /// <summary>HTTP/3 (IETF QUIC) and Google QUIC are enabled by default.</summary>
    [JsonPropertyName("disableQuic")]
    public bool? DisableQuic { get; set; }

    /// <summary>Resource URL that points at the Cloud Armor edge security policy that is applied on each request against the EdgeCacheService.</summary>
    [JsonPropertyName("edgeSecurityPolicy")]
    public string? EdgeSecurityPolicy { get; set; }

    /// <summary>
    /// URLs to sslCertificate resources that are used to authenticate connections between users and the EdgeCacheService.
    /// 
    /// Note that only &quot;global&quot; certificates with a &quot;scope&quot; of &quot;EDGE_CACHE&quot; can be attached to an EdgeCacheService.
    /// </summary>
    [JsonPropertyName("edgeSslCertificates")]
    public IList<string>? EdgeSslCertificates { get; set; }

    /// <summary>Specifies the logging options for the traffic served by this service. If logging is enabled, logs will be exported to Cloud Logging.</summary>
    [JsonPropertyName("logConfig")]
    public V1alpha1NetworkServicesEdgeCacheServiceSpecLogConfig? LogConfig { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1NetworkServicesEdgeCacheServiceSpecProjectRef ProjectRef { get; set; }

    /// <summary>
    /// Require TLS (HTTPS) for all clients connecting to this service.
    /// 
    /// Clients who connect over HTTP (port 80) will receive a HTTP 301 to the same URL over HTTPS (port 443).
    /// You must have at least one (1) edgeSslCertificate specified to enable this.
    /// </summary>
    [JsonPropertyName("requireTls")]
    public bool? RequireTls { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Defines how requests are routed, modified, cached and/or which origin content is filled from.</summary>
    [JsonPropertyName("routing")]
    public required V1alpha1NetworkServicesEdgeCacheServiceSpecRouting Routing { get; set; }

    /// <summary>
    /// URL of the SslPolicy resource that will be associated with the EdgeCacheService.
    /// 
    /// If not set, the EdgeCacheService has no SSL policy configured, and will default to the &quot;COMPATIBLE&quot; policy.
    /// </summary>
    [JsonPropertyName("sslPolicy")]
    public string? SslPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheServiceStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkServicesEdgeCacheServiceStatusConditions>? Conditions { get; set; }

    /// <summary>The IPv4 addresses associated with this service. Addresses are static for the lifetime of the service.</summary>
    [JsonPropertyName("ipv4Addresses")]
    public IList<string>? Ipv4Addresses { get; set; }

    /// <summary>The IPv6 addresses associated with this service. Addresses are static for the lifetime of the service.</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkServicesEdgeCacheService : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkServicesEdgeCacheServiceSpec>, IStatus<V1alpha1NetworkServicesEdgeCacheServiceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkServicesEdgeCacheService";
    public const string KubeGroup = "networkservices.cnrm.cloud.google.com";
    public const string KubePluralName = "networkservicesedgecacheservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkservices.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkServicesEdgeCacheService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1NetworkServicesEdgeCacheServiceSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1NetworkServicesEdgeCacheServiceStatus? Status { get; set; }
}