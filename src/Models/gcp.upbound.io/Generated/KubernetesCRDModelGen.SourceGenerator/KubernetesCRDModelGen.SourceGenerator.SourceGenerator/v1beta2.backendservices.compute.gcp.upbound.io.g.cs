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
/// <summary>BackendService is the Schema for the BackendServices API. A Backend Service defines a group of virtual machines that will serve traffic for load balancing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackendServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BackendService>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackendServiceList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "backendservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackendServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BackendService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BackendService> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecDeletionPolicyEnum>))]
public enum V1beta2BackendServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderBackendCustomMetrics
{
    /// <summary>
    /// If true, the metric data is collected and reported to Cloud
    /// Monitoring, but is not used for load balancing.
    /// </summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>
    /// Optional parameter to define a target utilization for the Custom Metrics
    /// balancing mode. The valid range is [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecForProviderBackendGroupRefPolicyResolutionEnum>))]
public enum V1beta2BackendServiceSpecForProviderBackendGroupRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecForProviderBackendGroupRefPolicyResolveEnum>))]
public enum V1beta2BackendServiceSpecForProviderBackendGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderBackendGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackendServiceSpecForProviderBackendGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackendServiceSpecForProviderBackendGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderBackendGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BackendServiceSpecForProviderBackendGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecForProviderBackendGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2BackendServiceSpecForProviderBackendGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecForProviderBackendGroupSelectorPolicyResolveEnum>))]
public enum V1beta2BackendServiceSpecForProviderBackendGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderBackendGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackendServiceSpecForProviderBackendGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackendServiceSpecForProviderBackendGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderBackendGroupSelector
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
    public V1beta2BackendServiceSpecForProviderBackendGroupSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderBackend
{
    /// <summary>
    /// Specifies the balancing mode for this backend.
    /// For global HTTP(S) or TCP/SSL load balancing, the default is
    /// UTILIZATION. Valid values are UTILIZATION, RATE (for HTTP(S)),
    /// CUSTOM_METRICS (for HTTP(s)) and CONNECTION (for TCP/SSL).
    /// See the Backend Services Overview
    /// for an explanation of load balancing modes.
    /// Default value is UTILIZATION.
    /// Possible values are: UTILIZATION, RATE, CONNECTION, CUSTOM_METRICS.
    /// </summary>
    [JsonPropertyName("balancingMode")]
    public string? BalancingMode { get; set; }

    /// <summary>
    /// A multiplier applied to the group&apos;s maximum servicing capacity
    /// (based on UTILIZATION, RATE or CONNECTION).
    /// Default value is 1, which means the group will serve up to 100%
    /// of its configured capacity (depending on balancingMode). A
    /// setting of 0 means the group is completely drained, offering
    /// 0% of its available Capacity. Valid range is [0.0,1.0].
    /// </summary>
    [JsonPropertyName("capacityScaler")]
    public double? CapacityScaler { get; set; }

    /// <summary>
    /// The set of custom metrics that are used for CUSTOM_METRICS BalancingMode.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2BackendServiceSpecForProviderBackendCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// Provide this property when you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The fully-qualified URL of an Instance Group or Network Endpoint
    /// Group resource. In case of instance group this defines the list
    /// of instances that serve traffic. Member virtual machine
    /// instances from each instance group must live in the same zone as
    /// the instance group itself. No two backends in a backend service
    /// are allowed to use same Instance Group resource.
    /// For Network Endpoint Groups this defines list of endpoints. All
    /// endpoints of Network Endpoint Group must be hosted on instances
    /// located in the same zone as the Network Endpoint Group.
    /// Backend services cannot mix Instance Group and
    /// Network Endpoint Group backends.
    /// Note that you must specify an Instance Group or Network Endpoint
    /// Group resource using the fully-qualified URL, rather than a
    /// partial URL.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Reference to a InstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupRef")]
    public V1beta2BackendServiceSpecForProviderBackendGroupRef? GroupRef { get; set; }

    /// <summary>Selector for a InstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupSelector")]
    public V1beta2BackendServiceSpecForProviderBackendGroupSelector? GroupSelector { get; set; }

    /// <summary>
    /// The max number of simultaneous connections for the group. Can
    /// be used with either CONNECTION or UTILIZATION balancing modes.
    /// For CONNECTION mode, either maxConnections or one
    /// of maxConnectionsPerInstance or maxConnectionsPerEndpoint,
    /// as appropriate for group type, must be set.
    /// </summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single backend
    /// network endpoint can handle. This is used to calculate the
    /// capacity of the group. Can be used in either CONNECTION or
    /// UTILIZATION balancing modes.
    /// For CONNECTION mode, either
    /// maxConnections or maxConnectionsPerEndpoint must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerEndpoint")]
    public double? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single
    /// backend instance can handle. This is used to calculate the
    /// capacity of the group. Can be used in either CONNECTION or
    /// UTILIZATION balancing modes.
    /// For CONNECTION mode, either maxConnections or
    /// maxConnectionsPerInstance must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerInstance")]
    public double? MaxConnectionsPerInstance { get; set; }

    /// <summary>
    /// The max requests per second (RPS) of the group.
    /// Can be used with either RATE or UTILIZATION balancing modes,
    /// but required if RATE mode. For RATE mode, either maxRate or one
    /// of maxRatePerInstance or maxRatePerEndpoint, as appropriate for
    /// group type, must be set.
    /// </summary>
    [JsonPropertyName("maxRate")]
    public double? MaxRate { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend network
    /// endpoint can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerEndpoint must be set.
    /// </summary>
    [JsonPropertyName("maxRatePerEndpoint")]
    public double? MaxRatePerEndpoint { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend
    /// instance can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerInstance must be set.
    /// </summary>
    [JsonPropertyName("maxRatePerInstance")]
    public double? MaxRatePerInstance { get; set; }

    /// <summary>
    /// Used when balancingMode is UTILIZATION. This ratio defines the
    /// CPU utilization target for the group. Valid range is [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>
    /// This field indicates whether this backend should be fully utilized before sending traffic to backends
    /// with default preference. This field cannot be set when loadBalancingScheme is set to &apos;EXTERNAL&apos;. The possible values are:
    /// </summary>
    [JsonPropertyName("preference")]
    public string? Preference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderCdnPolicyBypassCacheOnRequestHeaders
{
    /// <summary>The header field name to match on when bypassing cache. Values are case-insensitive.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }
}

/// <summary>
/// The CacheKeyPolicy for this CdnPolicy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderCdnPolicyCacheKeyPolicy
{
    /// <summary>If true requests to different hosts will be cached separately.</summary>
    [JsonPropertyName("includeHost")]
    public bool? IncludeHost { get; set; }

    /// <summary>
    /// Allows HTTP request headers (by name) to be used in the
    /// cache key.
    /// </summary>
    [JsonPropertyName("includeHttpHeaders")]
    public IList<string>? IncludeHttpHeaders { get; set; }

    /// <summary>Names of cookies to include in cache keys.</summary>
    [JsonPropertyName("includeNamedCookies")]
    public IList<string>? IncludeNamedCookies { get; set; }

    /// <summary>If true, http and https requests will be cached separately.</summary>
    [JsonPropertyName("includeProtocol")]
    public bool? IncludeProtocol { get; set; }

    /// <summary>
    /// If true, include query string parameters in the cache key
    /// according to query_string_whitelist and
    /// query_string_blacklist. If neither is set, the entire query
    /// string will be included.
    /// If false, the query string will be excluded from the cache
    /// key entirely.
    /// </summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>
    /// Names of query string parameters to exclude in cache keys.
    /// All other parameters will be included. Either specify
    /// query_string_whitelist or query_string_blacklist, not both.
    /// &apos; &amp; &apos; and &apos;=&apos; will be percent encoded and not treated as
    /// delimiters.
    /// </summary>
    [JsonPropertyName("queryStringBlacklist")]
    public IList<string>? QueryStringBlacklist { get; set; }

    /// <summary>
    /// Names of query string parameters to include in cache keys.
    /// All other parameters will be excluded. Either specify
    /// query_string_whitelist or query_string_blacklist, not both.
    /// &apos; &amp; &apos; and &apos;=&apos; will be percent encoded and not treated as
    /// delimiters.
    /// </summary>
    [JsonPropertyName("queryStringWhitelist")]
    public IList<string>? QueryStringWhitelist { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderCdnPolicyNegativeCachingPolicy
{
    /// <summary>
    /// The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 308, 404, 405, 410, 421, 451 and 501
    /// can be specified as values, and you cannot specify a status code more than once.
    /// </summary>
    [JsonPropertyName("code")]
    public double? Code { get; set; }

    /// <summary>
    /// Lifetime of the cookie.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary>
/// Cloud CDN configuration for this BackendService.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderCdnPolicy
{
    /// <summary>
    /// Bypass the cache when the specified request headers are matched - e.g. Pragma or Authorization headers. Up to 5 headers can be specified.
    /// The cache is bypassed for all cdnPolicy.cacheMode settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bypassCacheOnRequestHeaders")]
    public IList<V1beta2BackendServiceSpecForProviderCdnPolicyBypassCacheOnRequestHeaders>? BypassCacheOnRequestHeaders { get; set; }

    /// <summary>
    /// The CacheKeyPolicy for this CdnPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1beta2BackendServiceSpecForProviderCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

    /// <summary>
    /// Specifies the cache setting for all responses from this backend.
    /// The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC
    /// Possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL, CACHE_ALL_STATIC.
    /// </summary>
    [JsonPropertyName("cacheMode")]
    public string? CacheMode { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("clientTtl")]
    public double? ClientTtl { get; set; }

    /// <summary>
    /// Specifies the default TTL for cached content served by this origin for responses
    /// that do not have an existing valid TTL (max-age or s-max-age).
    /// </summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.</summary>
    [JsonPropertyName("negativeCaching")]
    public bool? NegativeCaching { get; set; }

    /// <summary>
    /// Sets a cache TTL for the specified HTTP status code. negativeCaching must be enabled to configure negativeCachingPolicy.
    /// Omitting the policy and leaving negativeCaching enabled will use Cloud CDN&apos;s default cache TTLs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("negativeCachingPolicy")]
    public IList<V1beta2BackendServiceSpecForProviderCdnPolicyNegativeCachingPolicy>? NegativeCachingPolicy { get; set; }

    /// <summary>
    /// If true then Cloud CDN will combine multiple concurrent cache fill requests into a small number of requests
    /// to the origin.
    /// </summary>
    [JsonPropertyName("requestCoalescing")]
    public bool? RequestCoalescing { get; set; }

    /// <summary>Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.</summary>
    [JsonPropertyName("serveWhileStale")]
    public double? ServeWhileStale { get; set; }

    /// <summary>
    /// Maximum number of seconds the response to a signed URL request
    /// will be considered fresh, defaults to 1hr (3600s). After this
    /// time period, the response will be revalidated before
    /// being served.
    /// When serving responses to signed URL requests, Cloud CDN will
    /// internally behave as though all responses from this backend had a
    /// &quot;Cache-Control: public, max-age=[TTL]&quot; header, regardless of any
    /// existing Cache-Control header. The actual headers served in
    /// responses will not be altered.
    /// </summary>
    [JsonPropertyName("signedUrlCacheMaxAgeSec")]
    public double? SignedUrlCacheMaxAgeSec { get; set; }
}

/// <summary>
/// Settings controlling the volume of connections to a backend service. This field
/// is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderCircuitBreakers
{
    /// <summary>
    /// The maximum number of connections to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>
    /// The maximum number of pending requests to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }

    /// <summary>
    /// The maximum number of parallel requests to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }

    /// <summary>
    /// Maximum requests for a single backend connection. This parameter
    /// is respected by both the HTTP/1.1 and HTTP/2 implementations. If
    /// not specified, there is no limit. Setting this parameter to 1
    /// will effectively disable keep alive.
    /// </summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public double? MaxRequestsPerConnection { get; set; }

    /// <summary>
    /// The maximum number of parallel retries to the backend cluster.
    /// Defaults to 3.
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderConsistentHashHttpCookieTtl
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Hash is based on HTTP Cookie. This field describes a HTTP cookie
/// that will be used as the hash key for the consistent hash load
/// balancer. If the cookie is not present, it will be generated.
/// This field is applicable if the sessionAffinity is set to HTTP_COOKIE.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Lifetime of the cookie.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttl")]
    public V1beta2BackendServiceSpecForProviderConsistentHashHttpCookieTtl? Ttl { get; set; }
}

/// <summary>
/// Consistent Hash-based load balancing can be used to provide soft session
/// affinity based on HTTP headers, cookies or other properties. This load balancing
/// policy is applicable only for HTTP connections. The affinity to a particular
/// destination host will be lost when one or more hosts are added/removed from the
/// destination service. This field specifies parameters that control consistent
/// hashing. This field only applies if the load_balancing_scheme is set to
/// INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is
/// set to MAGLEV or RING_HASH.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderConsistentHash
{
    /// <summary>
    /// Hash is based on HTTP Cookie. This field describes a HTTP cookie
    /// that will be used as the hash key for the consistent hash load
    /// balancer. If the cookie is not present, it will be generated.
    /// This field is applicable if the sessionAffinity is set to HTTP_COOKIE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpCookie")]
    public V1beta2BackendServiceSpecForProviderConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>
    /// The hash based on the value of the specified header field.
    /// This field is applicable if the sessionAffinity is set to HEADER_FIELD.
    /// </summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>
    /// The minimum number of virtual nodes to use for the hash ring.
    /// Larger ring sizes result in more granular load
    /// distributions. If the number of hosts in the load balancing pool
    /// is larger than the ring size, each host will be assigned a single
    /// virtual node.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("minimumRingSize")]
    public double? MinimumRingSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderCustomMetrics
{
    /// <summary>
    /// If true, the metric data is collected and reported to Cloud
    /// Monitoring, but is not used for load balancing.
    /// </summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>
    /// Name of a custom utilization signal. The name must be 1-64 characters
    /// long and match the regular expression a-z? which
    /// means the first character must be a lowercase letter, and all following
    /// characters must be a dash, period, underscore, lowercase letter, or
    /// digit, except the last character, which cannot be a dash, period, or
    /// underscore. For usage guidelines, see Custom Metrics balancing mode. This
    /// field can only be used for a global or regional backend service with the
    /// loadBalancingScheme set to EXTERNAL_MANAGED,
    /// INTERNAL_MANAGED INTERNAL_SELF_MANAGED.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecForProviderHealthChecksRefsPolicyResolutionEnum>))]
public enum V1beta2BackendServiceSpecForProviderHealthChecksRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecForProviderHealthChecksRefsPolicyResolveEnum>))]
public enum V1beta2BackendServiceSpecForProviderHealthChecksRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderHealthChecksRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackendServiceSpecForProviderHealthChecksRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackendServiceSpecForProviderHealthChecksRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderHealthChecksRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BackendServiceSpecForProviderHealthChecksRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecForProviderHealthChecksSelectorPolicyResolutionEnum>))]
public enum V1beta2BackendServiceSpecForProviderHealthChecksSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecForProviderHealthChecksSelectorPolicyResolveEnum>))]
public enum V1beta2BackendServiceSpecForProviderHealthChecksSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderHealthChecksSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackendServiceSpecForProviderHealthChecksSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackendServiceSpecForProviderHealthChecksSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of HealthCheck in compute to populate healthChecks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderHealthChecksSelector
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
    public V1beta2BackendServiceSpecForProviderHealthChecksSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// OAuth2 Client Secret for IAP
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderIapOauth2ClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Settings for enabling Cloud Identity Aware Proxy.
/// If OAuth client is not set, the Google-managed OAuth client is used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderIap
{
    /// <summary>Whether the serving infrastructure will authenticate and authorize all incoming requests.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>OAuth2 Client ID for IAP</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }

    /// <summary>
    /// OAuth2 Client Secret for IAP
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("oauth2ClientSecretSecretRef")]
    public V1beta2BackendServiceSpecForProviderIapOauth2ClientSecretSecretRef? Oauth2ClientSecretSecretRef { get; set; }
}

/// <summary>
/// The configuration for a custom policy implemented by the user and
/// deployed with the client.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderLocalityLbPoliciesCustomPolicy
{
    /// <summary>
    /// An optional, arbitrary JSON object with configuration data, understood
    /// by a locally installed custom policy implementation.
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The configuration for a built-in load balancing policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderLocalityLbPoliciesPolicy
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderLocalityLbPolicies
{
    /// <summary>
    /// The configuration for a custom policy implemented by the user and
    /// deployed with the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customPolicy")]
    public V1beta2BackendServiceSpecForProviderLocalityLbPoliciesCustomPolicy? CustomPolicy { get; set; }

    /// <summary>
    /// The configuration for a built-in load balancing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policy")]
    public V1beta2BackendServiceSpecForProviderLocalityLbPoliciesPolicy? Policy { get; set; }
}

/// <summary>
/// This field denotes the logging options for the load balancer traffic served by this backend service.
/// If logging is enabled, logs will be exported to Stackdriver.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderLogConfig
{
    /// <summary>Whether to enable logging for the load balancer traffic served by this backend service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    /// This field can only be specified if logging is enabled for this backend service and &quot;logConfig.optionalMode&quot;
    /// was set to CUSTOM. Contains a list of optional fields you want to include in the logs.
    /// For example: serverInstance, serverGkeDetails.cluster, serverGkeDetails.pod.podNamespace
    /// For example: orca_load_report, tls.protocol
    /// </summary>
    [JsonPropertyName("optionalFields")]
    public IList<string>? OptionalFields { get; set; }

    /// <summary>
    /// Specifies the optional logging mode for the load balancer traffic.
    /// Supported values: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM.
    /// Possible values are: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM.
    /// </summary>
    [JsonPropertyName("optionalMode")]
    public string? OptionalMode { get; set; }

    /// <summary>
    /// This field can only be specified if logging is enabled for this backend service. The value of
    /// the field must be in [0, 1]. This configures the sampling rate of requests to the load balancer
    /// where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported.
    /// The default value is 1.0.
    /// </summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>
/// Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the
/// beginning of the stream until the response has been completely processed, including all retries. A stream that
/// does not complete in this duration is closed.
/// If not specified, there will be no timeout limit, i.e. the maximum duration is infinite.
/// This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service.
/// This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution.
    /// Durations less than one second are represented with a 0 seconds field and a positive nanos field.
    /// Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. (int64 format)</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The base time that a host is ejected for. The real time is equal to the base
/// time multiplied by the number of times the host has been ejected. Defaults to
/// 30000ms or 30s.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderOutlierDetectionBaseEjectionTime
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Time interval between ejection sweep analysis. This can result in both new
/// ejections as well as hosts being returned to service. Defaults to 10 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderOutlierDetectionInterval
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Settings controlling eviction of unhealthy hosts from the load balancing pool.
/// Applicable backend service types can be a global backend service with the
/// loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderOutlierDetection
{
    /// <summary>
    /// The base time that a host is ejected for. The real time is equal to the base
    /// time multiplied by the number of times the host has been ejected. Defaults to
    /// 30000ms or 30s.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseEjectionTime")]
    public V1beta2BackendServiceSpecForProviderOutlierDetectionBaseEjectionTime? BaseEjectionTime { get; set; }

    /// <summary>
    /// Number of errors before a host is ejected from the connection pool. When the
    /// backend host is accessed over HTTP, a 5xx return code qualifies as an error.
    /// Defaults to 5.
    /// </summary>
    [JsonPropertyName("consecutiveErrors")]
    public double? ConsecutiveErrors { get; set; }

    /// <summary>
    /// The number of consecutive gateway failures (502, 503, 504 status or connection
    /// errors that are mapped to one of those status codes) before a consecutive
    /// gateway failure ejection occurs. Defaults to 5.
    /// </summary>
    [JsonPropertyName("consecutiveGatewayFailure")]
    public double? ConsecutiveGatewayFailure { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through consecutive 5xx. This setting can be used to disable
    /// ejection or to ramp it up slowly. Defaults to 100.
    /// </summary>
    [JsonPropertyName("enforcingConsecutiveErrors")]
    public double? EnforcingConsecutiveErrors { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through consecutive gateway failures. This setting can be
    /// used to disable ejection or to ramp it up slowly. Defaults to 0.
    /// </summary>
    [JsonPropertyName("enforcingConsecutiveGatewayFailure")]
    public double? EnforcingConsecutiveGatewayFailure { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through success rate statistics. This setting can be used to
    /// disable ejection or to ramp it up slowly. Defaults to 100.
    /// </summary>
    [JsonPropertyName("enforcingSuccessRate")]
    public double? EnforcingSuccessRate { get; set; }

    /// <summary>
    /// Time interval between ejection sweep analysis. This can result in both new
    /// ejections as well as hosts being returned to service. Defaults to 10 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("interval")]
    public V1beta2BackendServiceSpecForProviderOutlierDetectionInterval? Interval { get; set; }

    /// <summary>
    /// Maximum percentage of hosts in the load balancing pool for the backend service
    /// that can be ejected. Defaults to 10%.
    /// </summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>
    /// The number of hosts in a cluster that must have enough request volume to detect
    /// success rate outliers. If the number of hosts is less than this setting, outlier
    /// detection via success rate statistics is not performed for any host in the
    /// cluster. Defaults to 5.
    /// </summary>
    [JsonPropertyName("successRateMinimumHosts")]
    public double? SuccessRateMinimumHosts { get; set; }

    /// <summary>
    /// The minimum number of total requests that must be collected in one interval (as
    /// defined by the interval duration above) to include this host in success rate
    /// based outlier detection. If the volume is lower than this setting, outlier
    /// detection via success rate statistics is not performed for that host. Defaults
    /// to 100.
    /// </summary>
    [JsonPropertyName("successRateRequestVolume")]
    public double? SuccessRateRequestVolume { get; set; }

    /// <summary>
    /// This factor is used to determine the ejection threshold for success rate outlier
    /// ejection. The ejection threshold is the difference between the mean success
    /// rate, and the product of this factor and the standard deviation of the mean
    /// success rate: mean - (stdev * success_rate_stdev_factor). This factor is divided
    /// by a thousand to get a double. That is, if the desired factor is 1.9, the
    /// runtime value should be 1900. Defaults to 1900.
    /// </summary>
    [JsonPropertyName("successRateStdevFactor")]
    public double? SuccessRateStdevFactor { get; set; }
}

/// <summary>
/// The access key used for s3 bucket authentication.
/// Required for updating or creating a backend that uses AWS v4 signature authentication, but will not be returned as part of the configuration when queried with a REST API GET request.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderSecuritySettingsAwsV4AuthenticationAccessKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The configuration needed to generate a signature for access to private storage buckets that support AWS&apos;s Signature Version 4 for authentication.
/// Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderSecuritySettingsAwsV4Authentication
{
    /// <summary>The identifier of an access key used for s3 bucket authentication.</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>
    /// The access key used for s3 bucket authentication.
    /// Required for updating or creating a backend that uses AWS v4 signature authentication, but will not be returned as part of the configuration when queried with a REST API GET request.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1beta2BackendServiceSpecForProviderSecuritySettingsAwsV4AuthenticationAccessKeySecretRef? AccessKeySecretRef { get; set; }

    /// <summary>The optional version identifier for the access key. You can use this to keep track of different iterations of your access key.</summary>
    [JsonPropertyName("accessKeyVersion")]
    public string? AccessKeyVersion { get; set; }

    /// <summary>
    /// The name of the cloud region of your origin. This is a free-form field with the name of the region your cloud uses to host your origin.
    /// For example, &quot;us-east-1&quot; for AWS or &quot;us-ashburn-1&quot; for OCI.
    /// </summary>
    [JsonPropertyName("originRegion")]
    public string? OriginRegion { get; set; }
}

/// <summary>
/// The security settings that apply to this backend service. This field is applicable to either
/// a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and
/// load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the
/// load_balancing_scheme set to INTERNAL_SELF_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderSecuritySettings
{
    /// <summary>
    /// The configuration needed to generate a signature for access to private storage buckets that support AWS&apos;s Signature Version 4 for authentication.
    /// Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("awsV4Authentication")]
    public V1beta2BackendServiceSpecForProviderSecuritySettingsAwsV4Authentication? AwsV4Authentication { get; set; }

    /// <summary>
    /// ClientTlsPolicy is a resource that specifies how a client should authenticate
    /// connections to backends of a service. This resource itself does not affect
    /// configuration unless it is attached to a backend service resource.
    /// </summary>
    [JsonPropertyName("clientTlsPolicy")]
    public string? ClientTlsPolicy { get; set; }

    /// <summary>
    /// A list of alternate names to verify the subject identity in the certificate.
    /// If specified, the client will verify that the server certificate&apos;s subject
    /// alt name matches one of the specified values.
    /// </summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderStrongSessionAffinityCookieTtl
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderStrongSessionAffinityCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Lifetime of the cookie.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttl")]
    public V1beta2BackendServiceSpecForProviderStrongSessionAffinityCookieTtl? Ttl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderTlsSettingsSubjectAltNames
{
    /// <summary>The SAN specified as a DNS Name.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>The SAN specified as a URI.</summary>
    [JsonPropertyName("uniformResourceIdentifier")]
    public string? UniformResourceIdentifier { get; set; }
}

/// <summary>
/// Configuration for Backend Authenticated TLS and mTLS. May only be specified when the backend protocol is SSL, HTTPS or HTTP2.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProviderTlsSettings
{
    /// <summary>
    /// Reference to the BackendAuthenticationConfig resource from the networksecurity.googleapis.com namespace.
    /// Can be used in authenticating TLS connections to the backend, as specified by the authenticationMode field.
    /// Can only be specified if authenticationMode is not NONE.
    /// </summary>
    [JsonPropertyName("authenticationConfig")]
    public string? AuthenticationConfig { get; set; }

    /// <summary>
    /// Server Name Indication - see RFC3546 section 3.1. If set, the load balancer sends this string as the SNI hostname in the
    /// TLS connection to the backend, and requires that this string match a Subject Alternative Name (SAN) in the backend&apos;s
    /// server certificate. With a Regional Internet NEG backend, if the SNI is specified here, the load balancer uses it
    /// regardless of whether the Regional Internet NEG is specified with FQDN or IP address and port.
    /// </summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>
    /// A list of Subject Alternative Names (SANs) that the Load Balancer verifies during a TLS handshake with the backend.
    /// When the server presents its X.509 certificate to the Load Balancer, the Load Balancer inspects the certificate&apos;s SAN field,
    /// and requires that at least one SAN match one of the subjectAltNames in the list. This field is limited to 5 entries.
    /// When both sni and subjectAltNames are specified, the load balancer matches the backend certificate&apos;s SAN only to
    /// subjectAltNames.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<V1beta2BackendServiceSpecForProviderTlsSettingsSubjectAltNames>? SubjectAltNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecForProvider
{
    /// <summary>
    /// Lifetime of cookies in seconds if session_affinity is
    /// GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts
    /// only until the end of the browser session (or equivalent). The
    /// maximum allowed value for TTL is one day.
    /// When the load balancing scheme is INTERNAL, this field is not used.
    /// </summary>
    [JsonPropertyName("affinityCookieTtlSec")]
    public double? AffinityCookieTtlSec { get; set; }

    /// <summary>
    /// The set of backends that serve this BackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("backend")]
    public IList<V1beta2BackendServiceSpecForProviderBackend>? Backend { get; set; }

    /// <summary>
    /// Cloud CDN configuration for this BackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cdnPolicy")]
    public V1beta2BackendServiceSpecForProviderCdnPolicy? CdnPolicy { get; set; }

    /// <summary>
    /// Settings controlling the volume of connections to a backend service. This field
    /// is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("circuitBreakers")]
    public V1beta2BackendServiceSpecForProviderCircuitBreakers? CircuitBreakers { get; set; }

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&apos;s Accept-Encoding header.
    /// Possible values are: AUTOMATIC, DISABLED.
    /// </summary>
    [JsonPropertyName("compressionMode")]
    public string? CompressionMode { get; set; }

    /// <summary>
    /// Time for which instance will be drained (not accept new
    /// connections, but still work to finish started).
    /// </summary>
    [JsonPropertyName("connectionDrainingTimeoutSec")]
    public double? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>
    /// Consistent Hash-based load balancing can be used to provide soft session
    /// affinity based on HTTP headers, cookies or other properties. This load balancing
    /// policy is applicable only for HTTP connections. The affinity to a particular
    /// destination host will be lost when one or more hosts are added/removed from the
    /// destination service. This field specifies parameters that control consistent
    /// hashing. This field only applies if the load_balancing_scheme is set to
    /// INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is
    /// set to MAGLEV or RING_HASH.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("consistentHash")]
    public V1beta2BackendServiceSpecForProviderConsistentHash? ConsistentHash { get; set; }

    /// <summary>
    /// List of custom metrics that are used for the WEIGHTED_ROUND_ROBIN locality_lb_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2BackendServiceSpecForProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied
    /// requests.
    /// </summary>
    [JsonPropertyName("customRequestHeaders")]
    public IList<string>? CustomRequestHeaders { get; set; }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied
    /// responses.
    /// </summary>
    [JsonPropertyName("customResponseHeaders")]
    public IList<string>? CustomResponseHeaders { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The resource URL for the edge security policy associated with this backend service.</summary>
    [JsonPropertyName("edgeSecurityPolicy")]
    public string? EdgeSecurityPolicy { get; set; }

    /// <summary>If true, enable Cloud CDN for this BackendService.</summary>
    [JsonPropertyName("enableCdn")]
    public bool? EnableCdn { get; set; }

    /// <summary>
    /// Specifies the canary migration state. Possible values are PREPARE, TEST_BY_PERCENTAGE, and
    /// TEST_ALL_TRAFFIC.
    /// To begin the migration from EXTERNAL to EXTERNAL_MANAGED, the state must be changed to
    /// PREPARE. The state must be changed to TEST_ALL_TRAFFIC before the loadBalancingScheme can be
    /// changed to EXTERNAL_MANAGED. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate
    /// traffic by percentage using externalManagedMigrationTestingPercentage.
    /// Rolling back a migration requires the states to be set in reverse order. So changing the
    /// scheme from EXTERNAL_MANAGED to EXTERNAL requires the state to be set to TEST_ALL_TRAFFIC at
    /// the same time. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate some traffic
    /// back to EXTERNAL or PREPARE can be used to migrate all traffic back to EXTERNAL.
    /// Possible values are: PREPARE, TEST_BY_PERCENTAGE, TEST_ALL_TRAFFIC.
    /// </summary>
    [JsonPropertyName("externalManagedMigrationState")]
    public string? ExternalManagedMigrationState { get; set; }

    /// <summary>
    /// Determines the fraction of requests that should be processed by the Global external
    /// Application Load Balancer.
    /// The value of this field must be in the range [0, 100].
    /// Session affinity options will slightly affect this routing behavior, for more details,
    /// see: Session Affinity.
    /// This value can only be set if the loadBalancingScheme in the backend service is set to
    /// EXTERNAL (when using the Classic ALB) and the migration state is TEST_BY_PERCENTAGE.
    /// </summary>
    [JsonPropertyName("externalManagedMigrationTestingPercentage")]
    public double? ExternalManagedMigrationTestingPercentage { get; set; }

    /// <summary>
    /// The set of URLs to the HttpHealthCheck or HttpsHealthCheck resource
    /// for health checking this BackendService. Currently at most one health
    /// check can be specified.
    /// A health check must be specified unless the backend service uses an internet
    /// or serverless NEG as a backend.
    /// For internal load balancing, a URL to a HealthCheck resource must be specified instead.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public IList<string>? HealthChecks { get; set; }

    /// <summary>References to HealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksRefs")]
    public IList<V1beta2BackendServiceSpecForProviderHealthChecksRefs>? HealthChecksRefs { get; set; }

    /// <summary>Selector for a list of HealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksSelector")]
    public V1beta2BackendServiceSpecForProviderHealthChecksSelector? HealthChecksSelector { get; set; }

    /// <summary>
    /// Settings for enabling Cloud Identity Aware Proxy.
    /// If OAuth client is not set, the Google-managed OAuth client is used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("iap")]
    public V1beta2BackendServiceSpecForProviderIap? Iap { get; set; }

    /// <summary>
    /// Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC).
    /// Possible values are: IPV4_ONLY, PREFER_IPV6, IPV6_ONLY.
    /// </summary>
    [JsonPropertyName("ipAddressSelectionPolicy")]
    public string? IpAddressSelectionPolicy { get; set; }

    /// <summary>
    /// Indicates whether the backend service will be used with internal or
    /// external load balancing. A backend service created for one type of
    /// load balancing cannot be used with the other. For more information, refer to
    /// Choosing a load balancer.
    /// Default value is EXTERNAL.
    /// Possible values are: EXTERNAL, INTERNAL_SELF_MANAGED, INTERNAL_MANAGED, EXTERNAL_MANAGED.
    /// </summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>
    /// A list of locality load balancing policies to be used in order of
    /// preference. Either the policy or the customPolicy field should be set.
    /// Overrides any value set in the localityLbPolicy field.
    /// localityLbPolicies is only supported when the BackendService is referenced
    /// by a URL Map that is referenced by a target gRPC proxy that has the
    /// validateForProxyless field set to true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localityLbPolicies")]
    public IList<V1beta2BackendServiceSpecForProviderLocalityLbPolicies>? LocalityLbPolicies { get; set; }

    /// <summary>
    /// The load balancing algorithm used within the scope of the locality.
    /// The possible values are:
    /// </summary>
    [JsonPropertyName("localityLbPolicy")]
    public string? LocalityLbPolicy { get; set; }

    /// <summary>
    /// This field denotes the logging options for the load balancer traffic served by this backend service.
    /// If logging is enabled, logs will be exported to Stackdriver.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2BackendServiceSpecForProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the
    /// beginning of the stream until the response has been completely processed, including all retries. A stream that
    /// does not complete in this duration is closed.
    /// If not specified, there will be no timeout limit, i.e. the maximum duration is infinite.
    /// This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service.
    /// This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2BackendServiceSpecForProviderMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Settings controlling eviction of unhealthy hosts from the load balancing pool.
    /// Applicable backend service types can be a global backend service with the
    /// loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta2BackendServiceSpecForProviderOutlierDetection? OutlierDetection { get; set; }

    /// <summary>
    /// Name of backend port. The same name should appear in the instance
    /// groups referenced by this service. Required when the load balancing
    /// scheme is EXTERNAL.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The protocol this BackendService uses to communicate with backends.
    /// The default is HTTP. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP
    /// or GRPC. Refer to the documentation for the load balancers or for Traffic Director
    /// for more information. Must be set to GRPC when the backend service is referenced
    /// by a URL map that is bound to target gRPC proxy.
    /// Possible values are: HTTP, HTTPS, HTTP2, TCP, SSL, UDP, GRPC, UNSPECIFIED, H2C.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>
    /// The security settings that apply to this backend service. This field is applicable to either
    /// a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and
    /// load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the
    /// load_balancing_scheme set to INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("securitySettings")]
    public V1beta2BackendServiceSpecForProviderSecuritySettings? SecuritySettings { get; set; }

    /// <summary>
    /// URL to networkservices.ServiceLbPolicy resource.
    /// Can only be set if load balancing scheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED or INTERNAL_SELF_MANAGED and the scope is global.
    /// </summary>
    [JsonPropertyName("serviceLbPolicy")]
    public string? ServiceLbPolicy { get; set; }

    /// <summary>
    /// Type of session affinity to use. The default is NONE. Session affinity is
    /// not applicable if the protocol is UDP.
    /// Possible values are: NONE, CLIENT_IP, CLIENT_IP_PORT_PROTO, CLIENT_IP_PROTO, GENERATED_COOKIE, HEADER_FIELD, HTTP_COOKIE, STRONG_COOKIE_AFFINITY.
    /// </summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>
    /// Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("strongSessionAffinityCookie")]
    public V1beta2BackendServiceSpecForProviderStrongSessionAffinityCookie? StrongSessionAffinityCookie { get; set; }

    /// <summary>
    /// The backend service timeout has a different meaning depending on the type of load balancer.
    /// For more information see, Backend service settings.
    /// The default is 30 seconds.
    /// The full range of timeout values allowed goes from 1 through 2,147,483,647 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>
    /// Configuration for Backend Authenticated TLS and mTLS. May only be specified when the backend protocol is SSL, HTTPS or HTTP2.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tlsSettings")]
    public V1beta2BackendServiceSpecForProviderTlsSettings? TlsSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderBackendCustomMetrics
{
    /// <summary>
    /// If true, the metric data is collected and reported to Cloud
    /// Monitoring, but is not used for load balancing.
    /// </summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>
    /// Optional parameter to define a target utilization for the Custom Metrics
    /// balancing mode. The valid range is [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecInitProviderBackendGroupRefPolicyResolutionEnum>))]
public enum V1beta2BackendServiceSpecInitProviderBackendGroupRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecInitProviderBackendGroupRefPolicyResolveEnum>))]
public enum V1beta2BackendServiceSpecInitProviderBackendGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderBackendGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackendServiceSpecInitProviderBackendGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackendServiceSpecInitProviderBackendGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderBackendGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BackendServiceSpecInitProviderBackendGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecInitProviderBackendGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2BackendServiceSpecInitProviderBackendGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecInitProviderBackendGroupSelectorPolicyResolveEnum>))]
public enum V1beta2BackendServiceSpecInitProviderBackendGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderBackendGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackendServiceSpecInitProviderBackendGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackendServiceSpecInitProviderBackendGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderBackendGroupSelector
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
    public V1beta2BackendServiceSpecInitProviderBackendGroupSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderBackend
{
    /// <summary>
    /// Specifies the balancing mode for this backend.
    /// For global HTTP(S) or TCP/SSL load balancing, the default is
    /// UTILIZATION. Valid values are UTILIZATION, RATE (for HTTP(S)),
    /// CUSTOM_METRICS (for HTTP(s)) and CONNECTION (for TCP/SSL).
    /// See the Backend Services Overview
    /// for an explanation of load balancing modes.
    /// Default value is UTILIZATION.
    /// Possible values are: UTILIZATION, RATE, CONNECTION, CUSTOM_METRICS.
    /// </summary>
    [JsonPropertyName("balancingMode")]
    public string? BalancingMode { get; set; }

    /// <summary>
    /// A multiplier applied to the group&apos;s maximum servicing capacity
    /// (based on UTILIZATION, RATE or CONNECTION).
    /// Default value is 1, which means the group will serve up to 100%
    /// of its configured capacity (depending on balancingMode). A
    /// setting of 0 means the group is completely drained, offering
    /// 0% of its available Capacity. Valid range is [0.0,1.0].
    /// </summary>
    [JsonPropertyName("capacityScaler")]
    public double? CapacityScaler { get; set; }

    /// <summary>
    /// The set of custom metrics that are used for CUSTOM_METRICS BalancingMode.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2BackendServiceSpecInitProviderBackendCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// Provide this property when you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The fully-qualified URL of an Instance Group or Network Endpoint
    /// Group resource. In case of instance group this defines the list
    /// of instances that serve traffic. Member virtual machine
    /// instances from each instance group must live in the same zone as
    /// the instance group itself. No two backends in a backend service
    /// are allowed to use same Instance Group resource.
    /// For Network Endpoint Groups this defines list of endpoints. All
    /// endpoints of Network Endpoint Group must be hosted on instances
    /// located in the same zone as the Network Endpoint Group.
    /// Backend services cannot mix Instance Group and
    /// Network Endpoint Group backends.
    /// Note that you must specify an Instance Group or Network Endpoint
    /// Group resource using the fully-qualified URL, rather than a
    /// partial URL.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Reference to a InstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupRef")]
    public V1beta2BackendServiceSpecInitProviderBackendGroupRef? GroupRef { get; set; }

    /// <summary>Selector for a InstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupSelector")]
    public V1beta2BackendServiceSpecInitProviderBackendGroupSelector? GroupSelector { get; set; }

    /// <summary>
    /// The max number of simultaneous connections for the group. Can
    /// be used with either CONNECTION or UTILIZATION balancing modes.
    /// For CONNECTION mode, either maxConnections or one
    /// of maxConnectionsPerInstance or maxConnectionsPerEndpoint,
    /// as appropriate for group type, must be set.
    /// </summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single backend
    /// network endpoint can handle. This is used to calculate the
    /// capacity of the group. Can be used in either CONNECTION or
    /// UTILIZATION balancing modes.
    /// For CONNECTION mode, either
    /// maxConnections or maxConnectionsPerEndpoint must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerEndpoint")]
    public double? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single
    /// backend instance can handle. This is used to calculate the
    /// capacity of the group. Can be used in either CONNECTION or
    /// UTILIZATION balancing modes.
    /// For CONNECTION mode, either maxConnections or
    /// maxConnectionsPerInstance must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerInstance")]
    public double? MaxConnectionsPerInstance { get; set; }

    /// <summary>
    /// The max requests per second (RPS) of the group.
    /// Can be used with either RATE or UTILIZATION balancing modes,
    /// but required if RATE mode. For RATE mode, either maxRate or one
    /// of maxRatePerInstance or maxRatePerEndpoint, as appropriate for
    /// group type, must be set.
    /// </summary>
    [JsonPropertyName("maxRate")]
    public double? MaxRate { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend network
    /// endpoint can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerEndpoint must be set.
    /// </summary>
    [JsonPropertyName("maxRatePerEndpoint")]
    public double? MaxRatePerEndpoint { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend
    /// instance can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerInstance must be set.
    /// </summary>
    [JsonPropertyName("maxRatePerInstance")]
    public double? MaxRatePerInstance { get; set; }

    /// <summary>
    /// Used when balancingMode is UTILIZATION. This ratio defines the
    /// CPU utilization target for the group. Valid range is [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>
    /// This field indicates whether this backend should be fully utilized before sending traffic to backends
    /// with default preference. This field cannot be set when loadBalancingScheme is set to &apos;EXTERNAL&apos;. The possible values are:
    /// </summary>
    [JsonPropertyName("preference")]
    public string? Preference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderCdnPolicyBypassCacheOnRequestHeaders
{
    /// <summary>The header field name to match on when bypassing cache. Values are case-insensitive.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }
}

/// <summary>
/// The CacheKeyPolicy for this CdnPolicy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderCdnPolicyCacheKeyPolicy
{
    /// <summary>If true requests to different hosts will be cached separately.</summary>
    [JsonPropertyName("includeHost")]
    public bool? IncludeHost { get; set; }

    /// <summary>
    /// Allows HTTP request headers (by name) to be used in the
    /// cache key.
    /// </summary>
    [JsonPropertyName("includeHttpHeaders")]
    public IList<string>? IncludeHttpHeaders { get; set; }

    /// <summary>Names of cookies to include in cache keys.</summary>
    [JsonPropertyName("includeNamedCookies")]
    public IList<string>? IncludeNamedCookies { get; set; }

    /// <summary>If true, http and https requests will be cached separately.</summary>
    [JsonPropertyName("includeProtocol")]
    public bool? IncludeProtocol { get; set; }

    /// <summary>
    /// If true, include query string parameters in the cache key
    /// according to query_string_whitelist and
    /// query_string_blacklist. If neither is set, the entire query
    /// string will be included.
    /// If false, the query string will be excluded from the cache
    /// key entirely.
    /// </summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>
    /// Names of query string parameters to exclude in cache keys.
    /// All other parameters will be included. Either specify
    /// query_string_whitelist or query_string_blacklist, not both.
    /// &apos; &amp; &apos; and &apos;=&apos; will be percent encoded and not treated as
    /// delimiters.
    /// </summary>
    [JsonPropertyName("queryStringBlacklist")]
    public IList<string>? QueryStringBlacklist { get; set; }

    /// <summary>
    /// Names of query string parameters to include in cache keys.
    /// All other parameters will be excluded. Either specify
    /// query_string_whitelist or query_string_blacklist, not both.
    /// &apos; &amp; &apos; and &apos;=&apos; will be percent encoded and not treated as
    /// delimiters.
    /// </summary>
    [JsonPropertyName("queryStringWhitelist")]
    public IList<string>? QueryStringWhitelist { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderCdnPolicyNegativeCachingPolicy
{
    /// <summary>
    /// The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 308, 404, 405, 410, 421, 451 and 501
    /// can be specified as values, and you cannot specify a status code more than once.
    /// </summary>
    [JsonPropertyName("code")]
    public double? Code { get; set; }

    /// <summary>
    /// Lifetime of the cookie.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary>
/// Cloud CDN configuration for this BackendService.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderCdnPolicy
{
    /// <summary>
    /// Bypass the cache when the specified request headers are matched - e.g. Pragma or Authorization headers. Up to 5 headers can be specified.
    /// The cache is bypassed for all cdnPolicy.cacheMode settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bypassCacheOnRequestHeaders")]
    public IList<V1beta2BackendServiceSpecInitProviderCdnPolicyBypassCacheOnRequestHeaders>? BypassCacheOnRequestHeaders { get; set; }

    /// <summary>
    /// The CacheKeyPolicy for this CdnPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1beta2BackendServiceSpecInitProviderCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

    /// <summary>
    /// Specifies the cache setting for all responses from this backend.
    /// The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC
    /// Possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL, CACHE_ALL_STATIC.
    /// </summary>
    [JsonPropertyName("cacheMode")]
    public string? CacheMode { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("clientTtl")]
    public double? ClientTtl { get; set; }

    /// <summary>
    /// Specifies the default TTL for cached content served by this origin for responses
    /// that do not have an existing valid TTL (max-age or s-max-age).
    /// </summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.</summary>
    [JsonPropertyName("negativeCaching")]
    public bool? NegativeCaching { get; set; }

    /// <summary>
    /// Sets a cache TTL for the specified HTTP status code. negativeCaching must be enabled to configure negativeCachingPolicy.
    /// Omitting the policy and leaving negativeCaching enabled will use Cloud CDN&apos;s default cache TTLs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("negativeCachingPolicy")]
    public IList<V1beta2BackendServiceSpecInitProviderCdnPolicyNegativeCachingPolicy>? NegativeCachingPolicy { get; set; }

    /// <summary>
    /// If true then Cloud CDN will combine multiple concurrent cache fill requests into a small number of requests
    /// to the origin.
    /// </summary>
    [JsonPropertyName("requestCoalescing")]
    public bool? RequestCoalescing { get; set; }

    /// <summary>Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.</summary>
    [JsonPropertyName("serveWhileStale")]
    public double? ServeWhileStale { get; set; }

    /// <summary>
    /// Maximum number of seconds the response to a signed URL request
    /// will be considered fresh, defaults to 1hr (3600s). After this
    /// time period, the response will be revalidated before
    /// being served.
    /// When serving responses to signed URL requests, Cloud CDN will
    /// internally behave as though all responses from this backend had a
    /// &quot;Cache-Control: public, max-age=[TTL]&quot; header, regardless of any
    /// existing Cache-Control header. The actual headers served in
    /// responses will not be altered.
    /// </summary>
    [JsonPropertyName("signedUrlCacheMaxAgeSec")]
    public double? SignedUrlCacheMaxAgeSec { get; set; }
}

/// <summary>
/// Settings controlling the volume of connections to a backend service. This field
/// is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderCircuitBreakers
{
    /// <summary>
    /// The maximum number of connections to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>
    /// The maximum number of pending requests to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }

    /// <summary>
    /// The maximum number of parallel requests to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }

    /// <summary>
    /// Maximum requests for a single backend connection. This parameter
    /// is respected by both the HTTP/1.1 and HTTP/2 implementations. If
    /// not specified, there is no limit. Setting this parameter to 1
    /// will effectively disable keep alive.
    /// </summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public double? MaxRequestsPerConnection { get; set; }

    /// <summary>
    /// The maximum number of parallel retries to the backend cluster.
    /// Defaults to 3.
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderConsistentHashHttpCookieTtl
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Hash is based on HTTP Cookie. This field describes a HTTP cookie
/// that will be used as the hash key for the consistent hash load
/// balancer. If the cookie is not present, it will be generated.
/// This field is applicable if the sessionAffinity is set to HTTP_COOKIE.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Lifetime of the cookie.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttl")]
    public V1beta2BackendServiceSpecInitProviderConsistentHashHttpCookieTtl? Ttl { get; set; }
}

/// <summary>
/// Consistent Hash-based load balancing can be used to provide soft session
/// affinity based on HTTP headers, cookies or other properties. This load balancing
/// policy is applicable only for HTTP connections. The affinity to a particular
/// destination host will be lost when one or more hosts are added/removed from the
/// destination service. This field specifies parameters that control consistent
/// hashing. This field only applies if the load_balancing_scheme is set to
/// INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is
/// set to MAGLEV or RING_HASH.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderConsistentHash
{
    /// <summary>
    /// Hash is based on HTTP Cookie. This field describes a HTTP cookie
    /// that will be used as the hash key for the consistent hash load
    /// balancer. If the cookie is not present, it will be generated.
    /// This field is applicable if the sessionAffinity is set to HTTP_COOKIE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpCookie")]
    public V1beta2BackendServiceSpecInitProviderConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>
    /// The hash based on the value of the specified header field.
    /// This field is applicable if the sessionAffinity is set to HEADER_FIELD.
    /// </summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>
    /// The minimum number of virtual nodes to use for the hash ring.
    /// Larger ring sizes result in more granular load
    /// distributions. If the number of hosts in the load balancing pool
    /// is larger than the ring size, each host will be assigned a single
    /// virtual node.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("minimumRingSize")]
    public double? MinimumRingSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderCustomMetrics
{
    /// <summary>
    /// If true, the metric data is collected and reported to Cloud
    /// Monitoring, but is not used for load balancing.
    /// </summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>
    /// Name of a custom utilization signal. The name must be 1-64 characters
    /// long and match the regular expression a-z? which
    /// means the first character must be a lowercase letter, and all following
    /// characters must be a dash, period, underscore, lowercase letter, or
    /// digit, except the last character, which cannot be a dash, period, or
    /// underscore. For usage guidelines, see Custom Metrics balancing mode. This
    /// field can only be used for a global or regional backend service with the
    /// loadBalancingScheme set to EXTERNAL_MANAGED,
    /// INTERNAL_MANAGED INTERNAL_SELF_MANAGED.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecInitProviderHealthChecksRefsPolicyResolutionEnum>))]
public enum V1beta2BackendServiceSpecInitProviderHealthChecksRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecInitProviderHealthChecksRefsPolicyResolveEnum>))]
public enum V1beta2BackendServiceSpecInitProviderHealthChecksRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderHealthChecksRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackendServiceSpecInitProviderHealthChecksRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackendServiceSpecInitProviderHealthChecksRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderHealthChecksRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BackendServiceSpecInitProviderHealthChecksRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecInitProviderHealthChecksSelectorPolicyResolutionEnum>))]
public enum V1beta2BackendServiceSpecInitProviderHealthChecksSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecInitProviderHealthChecksSelectorPolicyResolveEnum>))]
public enum V1beta2BackendServiceSpecInitProviderHealthChecksSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderHealthChecksSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackendServiceSpecInitProviderHealthChecksSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackendServiceSpecInitProviderHealthChecksSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of HealthCheck in compute to populate healthChecks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderHealthChecksSelector
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
    public V1beta2BackendServiceSpecInitProviderHealthChecksSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// OAuth2 Client Secret for IAP
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderIapOauth2ClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Settings for enabling Cloud Identity Aware Proxy.
/// If OAuth client is not set, the Google-managed OAuth client is used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderIap
{
    /// <summary>Whether the serving infrastructure will authenticate and authorize all incoming requests.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>OAuth2 Client ID for IAP</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }

    /// <summary>
    /// OAuth2 Client Secret for IAP
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("oauth2ClientSecretSecretRef")]
    public V1beta2BackendServiceSpecInitProviderIapOauth2ClientSecretSecretRef? Oauth2ClientSecretSecretRef { get; set; }
}

/// <summary>
/// The configuration for a custom policy implemented by the user and
/// deployed with the client.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderLocalityLbPoliciesCustomPolicy
{
    /// <summary>
    /// An optional, arbitrary JSON object with configuration data, understood
    /// by a locally installed custom policy implementation.
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The configuration for a built-in load balancing policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderLocalityLbPoliciesPolicy
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderLocalityLbPolicies
{
    /// <summary>
    /// The configuration for a custom policy implemented by the user and
    /// deployed with the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customPolicy")]
    public V1beta2BackendServiceSpecInitProviderLocalityLbPoliciesCustomPolicy? CustomPolicy { get; set; }

    /// <summary>
    /// The configuration for a built-in load balancing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policy")]
    public V1beta2BackendServiceSpecInitProviderLocalityLbPoliciesPolicy? Policy { get; set; }
}

/// <summary>
/// This field denotes the logging options for the load balancer traffic served by this backend service.
/// If logging is enabled, logs will be exported to Stackdriver.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderLogConfig
{
    /// <summary>Whether to enable logging for the load balancer traffic served by this backend service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    /// This field can only be specified if logging is enabled for this backend service and &quot;logConfig.optionalMode&quot;
    /// was set to CUSTOM. Contains a list of optional fields you want to include in the logs.
    /// For example: serverInstance, serverGkeDetails.cluster, serverGkeDetails.pod.podNamespace
    /// For example: orca_load_report, tls.protocol
    /// </summary>
    [JsonPropertyName("optionalFields")]
    public IList<string>? OptionalFields { get; set; }

    /// <summary>
    /// Specifies the optional logging mode for the load balancer traffic.
    /// Supported values: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM.
    /// Possible values are: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM.
    /// </summary>
    [JsonPropertyName("optionalMode")]
    public string? OptionalMode { get; set; }

    /// <summary>
    /// This field can only be specified if logging is enabled for this backend service. The value of
    /// the field must be in [0, 1]. This configures the sampling rate of requests to the load balancer
    /// where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported.
    /// The default value is 1.0.
    /// </summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>
/// Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the
/// beginning of the stream until the response has been completely processed, including all retries. A stream that
/// does not complete in this duration is closed.
/// If not specified, there will be no timeout limit, i.e. the maximum duration is infinite.
/// This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service.
/// This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution.
    /// Durations less than one second are represented with a 0 seconds field and a positive nanos field.
    /// Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. (int64 format)</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The base time that a host is ejected for. The real time is equal to the base
/// time multiplied by the number of times the host has been ejected. Defaults to
/// 30000ms or 30s.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderOutlierDetectionBaseEjectionTime
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Time interval between ejection sweep analysis. This can result in both new
/// ejections as well as hosts being returned to service. Defaults to 10 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderOutlierDetectionInterval
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Settings controlling eviction of unhealthy hosts from the load balancing pool.
/// Applicable backend service types can be a global backend service with the
/// loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderOutlierDetection
{
    /// <summary>
    /// The base time that a host is ejected for. The real time is equal to the base
    /// time multiplied by the number of times the host has been ejected. Defaults to
    /// 30000ms or 30s.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseEjectionTime")]
    public V1beta2BackendServiceSpecInitProviderOutlierDetectionBaseEjectionTime? BaseEjectionTime { get; set; }

    /// <summary>
    /// Number of errors before a host is ejected from the connection pool. When the
    /// backend host is accessed over HTTP, a 5xx return code qualifies as an error.
    /// Defaults to 5.
    /// </summary>
    [JsonPropertyName("consecutiveErrors")]
    public double? ConsecutiveErrors { get; set; }

    /// <summary>
    /// The number of consecutive gateway failures (502, 503, 504 status or connection
    /// errors that are mapped to one of those status codes) before a consecutive
    /// gateway failure ejection occurs. Defaults to 5.
    /// </summary>
    [JsonPropertyName("consecutiveGatewayFailure")]
    public double? ConsecutiveGatewayFailure { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through consecutive 5xx. This setting can be used to disable
    /// ejection or to ramp it up slowly. Defaults to 100.
    /// </summary>
    [JsonPropertyName("enforcingConsecutiveErrors")]
    public double? EnforcingConsecutiveErrors { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through consecutive gateway failures. This setting can be
    /// used to disable ejection or to ramp it up slowly. Defaults to 0.
    /// </summary>
    [JsonPropertyName("enforcingConsecutiveGatewayFailure")]
    public double? EnforcingConsecutiveGatewayFailure { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through success rate statistics. This setting can be used to
    /// disable ejection or to ramp it up slowly. Defaults to 100.
    /// </summary>
    [JsonPropertyName("enforcingSuccessRate")]
    public double? EnforcingSuccessRate { get; set; }

    /// <summary>
    /// Time interval between ejection sweep analysis. This can result in both new
    /// ejections as well as hosts being returned to service. Defaults to 10 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("interval")]
    public V1beta2BackendServiceSpecInitProviderOutlierDetectionInterval? Interval { get; set; }

    /// <summary>
    /// Maximum percentage of hosts in the load balancing pool for the backend service
    /// that can be ejected. Defaults to 10%.
    /// </summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>
    /// The number of hosts in a cluster that must have enough request volume to detect
    /// success rate outliers. If the number of hosts is less than this setting, outlier
    /// detection via success rate statistics is not performed for any host in the
    /// cluster. Defaults to 5.
    /// </summary>
    [JsonPropertyName("successRateMinimumHosts")]
    public double? SuccessRateMinimumHosts { get; set; }

    /// <summary>
    /// The minimum number of total requests that must be collected in one interval (as
    /// defined by the interval duration above) to include this host in success rate
    /// based outlier detection. If the volume is lower than this setting, outlier
    /// detection via success rate statistics is not performed for that host. Defaults
    /// to 100.
    /// </summary>
    [JsonPropertyName("successRateRequestVolume")]
    public double? SuccessRateRequestVolume { get; set; }

    /// <summary>
    /// This factor is used to determine the ejection threshold for success rate outlier
    /// ejection. The ejection threshold is the difference between the mean success
    /// rate, and the product of this factor and the standard deviation of the mean
    /// success rate: mean - (stdev * success_rate_stdev_factor). This factor is divided
    /// by a thousand to get a double. That is, if the desired factor is 1.9, the
    /// runtime value should be 1900. Defaults to 1900.
    /// </summary>
    [JsonPropertyName("successRateStdevFactor")]
    public double? SuccessRateStdevFactor { get; set; }
}

/// <summary>
/// The access key used for s3 bucket authentication.
/// Required for updating or creating a backend that uses AWS v4 signature authentication, but will not be returned as part of the configuration when queried with a REST API GET request.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderSecuritySettingsAwsV4AuthenticationAccessKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The configuration needed to generate a signature for access to private storage buckets that support AWS&apos;s Signature Version 4 for authentication.
/// Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderSecuritySettingsAwsV4Authentication
{
    /// <summary>The identifier of an access key used for s3 bucket authentication.</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>
    /// The access key used for s3 bucket authentication.
    /// Required for updating or creating a backend that uses AWS v4 signature authentication, but will not be returned as part of the configuration when queried with a REST API GET request.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("accessKeySecretRef")]
    public V1beta2BackendServiceSpecInitProviderSecuritySettingsAwsV4AuthenticationAccessKeySecretRef? AccessKeySecretRef { get; set; }

    /// <summary>The optional version identifier for the access key. You can use this to keep track of different iterations of your access key.</summary>
    [JsonPropertyName("accessKeyVersion")]
    public string? AccessKeyVersion { get; set; }

    /// <summary>
    /// The name of the cloud region of your origin. This is a free-form field with the name of the region your cloud uses to host your origin.
    /// For example, &quot;us-east-1&quot; for AWS or &quot;us-ashburn-1&quot; for OCI.
    /// </summary>
    [JsonPropertyName("originRegion")]
    public string? OriginRegion { get; set; }
}

/// <summary>
/// The security settings that apply to this backend service. This field is applicable to either
/// a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and
/// load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the
/// load_balancing_scheme set to INTERNAL_SELF_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderSecuritySettings
{
    /// <summary>
    /// The configuration needed to generate a signature for access to private storage buckets that support AWS&apos;s Signature Version 4 for authentication.
    /// Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("awsV4Authentication")]
    public V1beta2BackendServiceSpecInitProviderSecuritySettingsAwsV4Authentication? AwsV4Authentication { get; set; }

    /// <summary>
    /// ClientTlsPolicy is a resource that specifies how a client should authenticate
    /// connections to backends of a service. This resource itself does not affect
    /// configuration unless it is attached to a backend service resource.
    /// </summary>
    [JsonPropertyName("clientTlsPolicy")]
    public string? ClientTlsPolicy { get; set; }

    /// <summary>
    /// A list of alternate names to verify the subject identity in the certificate.
    /// If specified, the client will verify that the server certificate&apos;s subject
    /// alt name matches one of the specified values.
    /// </summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderStrongSessionAffinityCookieTtl
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderStrongSessionAffinityCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Lifetime of the cookie.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttl")]
    public V1beta2BackendServiceSpecInitProviderStrongSessionAffinityCookieTtl? Ttl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderTlsSettingsSubjectAltNames
{
    /// <summary>The SAN specified as a DNS Name.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>The SAN specified as a URI.</summary>
    [JsonPropertyName("uniformResourceIdentifier")]
    public string? UniformResourceIdentifier { get; set; }
}

/// <summary>
/// Configuration for Backend Authenticated TLS and mTLS. May only be specified when the backend protocol is SSL, HTTPS or HTTP2.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecInitProviderTlsSettings
{
    /// <summary>
    /// Reference to the BackendAuthenticationConfig resource from the networksecurity.googleapis.com namespace.
    /// Can be used in authenticating TLS connections to the backend, as specified by the authenticationMode field.
    /// Can only be specified if authenticationMode is not NONE.
    /// </summary>
    [JsonPropertyName("authenticationConfig")]
    public string? AuthenticationConfig { get; set; }

    /// <summary>
    /// Server Name Indication - see RFC3546 section 3.1. If set, the load balancer sends this string as the SNI hostname in the
    /// TLS connection to the backend, and requires that this string match a Subject Alternative Name (SAN) in the backend&apos;s
    /// server certificate. With a Regional Internet NEG backend, if the SNI is specified here, the load balancer uses it
    /// regardless of whether the Regional Internet NEG is specified with FQDN or IP address and port.
    /// </summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>
    /// A list of Subject Alternative Names (SANs) that the Load Balancer verifies during a TLS handshake with the backend.
    /// When the server presents its X.509 certificate to the Load Balancer, the Load Balancer inspects the certificate&apos;s SAN field,
    /// and requires that at least one SAN match one of the subjectAltNames in the list. This field is limited to 5 entries.
    /// When both sni and subjectAltNames are specified, the load balancer matches the backend certificate&apos;s SAN only to
    /// subjectAltNames.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<V1beta2BackendServiceSpecInitProviderTlsSettingsSubjectAltNames>? SubjectAltNames { get; set; }
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
public partial class V1beta2BackendServiceSpecInitProvider
{
    /// <summary>
    /// Lifetime of cookies in seconds if session_affinity is
    /// GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts
    /// only until the end of the browser session (or equivalent). The
    /// maximum allowed value for TTL is one day.
    /// When the load balancing scheme is INTERNAL, this field is not used.
    /// </summary>
    [JsonPropertyName("affinityCookieTtlSec")]
    public double? AffinityCookieTtlSec { get; set; }

    /// <summary>
    /// The set of backends that serve this BackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("backend")]
    public IList<V1beta2BackendServiceSpecInitProviderBackend>? Backend { get; set; }

    /// <summary>
    /// Cloud CDN configuration for this BackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cdnPolicy")]
    public V1beta2BackendServiceSpecInitProviderCdnPolicy? CdnPolicy { get; set; }

    /// <summary>
    /// Settings controlling the volume of connections to a backend service. This field
    /// is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("circuitBreakers")]
    public V1beta2BackendServiceSpecInitProviderCircuitBreakers? CircuitBreakers { get; set; }

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&apos;s Accept-Encoding header.
    /// Possible values are: AUTOMATIC, DISABLED.
    /// </summary>
    [JsonPropertyName("compressionMode")]
    public string? CompressionMode { get; set; }

    /// <summary>
    /// Time for which instance will be drained (not accept new
    /// connections, but still work to finish started).
    /// </summary>
    [JsonPropertyName("connectionDrainingTimeoutSec")]
    public double? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>
    /// Consistent Hash-based load balancing can be used to provide soft session
    /// affinity based on HTTP headers, cookies or other properties. This load balancing
    /// policy is applicable only for HTTP connections. The affinity to a particular
    /// destination host will be lost when one or more hosts are added/removed from the
    /// destination service. This field specifies parameters that control consistent
    /// hashing. This field only applies if the load_balancing_scheme is set to
    /// INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is
    /// set to MAGLEV or RING_HASH.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("consistentHash")]
    public V1beta2BackendServiceSpecInitProviderConsistentHash? ConsistentHash { get; set; }

    /// <summary>
    /// List of custom metrics that are used for the WEIGHTED_ROUND_ROBIN locality_lb_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2BackendServiceSpecInitProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied
    /// requests.
    /// </summary>
    [JsonPropertyName("customRequestHeaders")]
    public IList<string>? CustomRequestHeaders { get; set; }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied
    /// responses.
    /// </summary>
    [JsonPropertyName("customResponseHeaders")]
    public IList<string>? CustomResponseHeaders { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The resource URL for the edge security policy associated with this backend service.</summary>
    [JsonPropertyName("edgeSecurityPolicy")]
    public string? EdgeSecurityPolicy { get; set; }

    /// <summary>If true, enable Cloud CDN for this BackendService.</summary>
    [JsonPropertyName("enableCdn")]
    public bool? EnableCdn { get; set; }

    /// <summary>
    /// Specifies the canary migration state. Possible values are PREPARE, TEST_BY_PERCENTAGE, and
    /// TEST_ALL_TRAFFIC.
    /// To begin the migration from EXTERNAL to EXTERNAL_MANAGED, the state must be changed to
    /// PREPARE. The state must be changed to TEST_ALL_TRAFFIC before the loadBalancingScheme can be
    /// changed to EXTERNAL_MANAGED. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate
    /// traffic by percentage using externalManagedMigrationTestingPercentage.
    /// Rolling back a migration requires the states to be set in reverse order. So changing the
    /// scheme from EXTERNAL_MANAGED to EXTERNAL requires the state to be set to TEST_ALL_TRAFFIC at
    /// the same time. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate some traffic
    /// back to EXTERNAL or PREPARE can be used to migrate all traffic back to EXTERNAL.
    /// Possible values are: PREPARE, TEST_BY_PERCENTAGE, TEST_ALL_TRAFFIC.
    /// </summary>
    [JsonPropertyName("externalManagedMigrationState")]
    public string? ExternalManagedMigrationState { get; set; }

    /// <summary>
    /// Determines the fraction of requests that should be processed by the Global external
    /// Application Load Balancer.
    /// The value of this field must be in the range [0, 100].
    /// Session affinity options will slightly affect this routing behavior, for more details,
    /// see: Session Affinity.
    /// This value can only be set if the loadBalancingScheme in the backend service is set to
    /// EXTERNAL (when using the Classic ALB) and the migration state is TEST_BY_PERCENTAGE.
    /// </summary>
    [JsonPropertyName("externalManagedMigrationTestingPercentage")]
    public double? ExternalManagedMigrationTestingPercentage { get; set; }

    /// <summary>
    /// The set of URLs to the HttpHealthCheck or HttpsHealthCheck resource
    /// for health checking this BackendService. Currently at most one health
    /// check can be specified.
    /// A health check must be specified unless the backend service uses an internet
    /// or serverless NEG as a backend.
    /// For internal load balancing, a URL to a HealthCheck resource must be specified instead.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public IList<string>? HealthChecks { get; set; }

    /// <summary>References to HealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksRefs")]
    public IList<V1beta2BackendServiceSpecInitProviderHealthChecksRefs>? HealthChecksRefs { get; set; }

    /// <summary>Selector for a list of HealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksSelector")]
    public V1beta2BackendServiceSpecInitProviderHealthChecksSelector? HealthChecksSelector { get; set; }

    /// <summary>
    /// Settings for enabling Cloud Identity Aware Proxy.
    /// If OAuth client is not set, the Google-managed OAuth client is used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("iap")]
    public V1beta2BackendServiceSpecInitProviderIap? Iap { get; set; }

    /// <summary>
    /// Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC).
    /// Possible values are: IPV4_ONLY, PREFER_IPV6, IPV6_ONLY.
    /// </summary>
    [JsonPropertyName("ipAddressSelectionPolicy")]
    public string? IpAddressSelectionPolicy { get; set; }

    /// <summary>
    /// Indicates whether the backend service will be used with internal or
    /// external load balancing. A backend service created for one type of
    /// load balancing cannot be used with the other. For more information, refer to
    /// Choosing a load balancer.
    /// Default value is EXTERNAL.
    /// Possible values are: EXTERNAL, INTERNAL_SELF_MANAGED, INTERNAL_MANAGED, EXTERNAL_MANAGED.
    /// </summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>
    /// A list of locality load balancing policies to be used in order of
    /// preference. Either the policy or the customPolicy field should be set.
    /// Overrides any value set in the localityLbPolicy field.
    /// localityLbPolicies is only supported when the BackendService is referenced
    /// by a URL Map that is referenced by a target gRPC proxy that has the
    /// validateForProxyless field set to true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localityLbPolicies")]
    public IList<V1beta2BackendServiceSpecInitProviderLocalityLbPolicies>? LocalityLbPolicies { get; set; }

    /// <summary>
    /// The load balancing algorithm used within the scope of the locality.
    /// The possible values are:
    /// </summary>
    [JsonPropertyName("localityLbPolicy")]
    public string? LocalityLbPolicy { get; set; }

    /// <summary>
    /// This field denotes the logging options for the load balancer traffic served by this backend service.
    /// If logging is enabled, logs will be exported to Stackdriver.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2BackendServiceSpecInitProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the
    /// beginning of the stream until the response has been completely processed, including all retries. A stream that
    /// does not complete in this duration is closed.
    /// If not specified, there will be no timeout limit, i.e. the maximum duration is infinite.
    /// This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service.
    /// This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2BackendServiceSpecInitProviderMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Settings controlling eviction of unhealthy hosts from the load balancing pool.
    /// Applicable backend service types can be a global backend service with the
    /// loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta2BackendServiceSpecInitProviderOutlierDetection? OutlierDetection { get; set; }

    /// <summary>
    /// Name of backend port. The same name should appear in the instance
    /// groups referenced by this service. Required when the load balancing
    /// scheme is EXTERNAL.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The protocol this BackendService uses to communicate with backends.
    /// The default is HTTP. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP
    /// or GRPC. Refer to the documentation for the load balancers or for Traffic Director
    /// for more information. Must be set to GRPC when the backend service is referenced
    /// by a URL map that is bound to target gRPC proxy.
    /// Possible values are: HTTP, HTTPS, HTTP2, TCP, SSL, UDP, GRPC, UNSPECIFIED, H2C.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>
    /// The security settings that apply to this backend service. This field is applicable to either
    /// a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and
    /// load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the
    /// load_balancing_scheme set to INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("securitySettings")]
    public V1beta2BackendServiceSpecInitProviderSecuritySettings? SecuritySettings { get; set; }

    /// <summary>
    /// URL to networkservices.ServiceLbPolicy resource.
    /// Can only be set if load balancing scheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED or INTERNAL_SELF_MANAGED and the scope is global.
    /// </summary>
    [JsonPropertyName("serviceLbPolicy")]
    public string? ServiceLbPolicy { get; set; }

    /// <summary>
    /// Type of session affinity to use. The default is NONE. Session affinity is
    /// not applicable if the protocol is UDP.
    /// Possible values are: NONE, CLIENT_IP, CLIENT_IP_PORT_PROTO, CLIENT_IP_PROTO, GENERATED_COOKIE, HEADER_FIELD, HTTP_COOKIE, STRONG_COOKIE_AFFINITY.
    /// </summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>
    /// Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("strongSessionAffinityCookie")]
    public V1beta2BackendServiceSpecInitProviderStrongSessionAffinityCookie? StrongSessionAffinityCookie { get; set; }

    /// <summary>
    /// The backend service timeout has a different meaning depending on the type of load balancer.
    /// For more information see, Backend service settings.
    /// The default is 30 seconds.
    /// The full range of timeout values allowed goes from 1 through 2,147,483,647 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>
    /// Configuration for Backend Authenticated TLS and mTLS. May only be specified when the backend protocol is SSL, HTTPS or HTTP2.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tlsSettings")]
    public V1beta2BackendServiceSpecInitProviderTlsSettings? TlsSettings { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecManagementPoliciesEnum>))]
public enum V1beta2BackendServiceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2BackendServiceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackendServiceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2BackendServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2BackendServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2BackendServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2BackendServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>BackendServiceSpec defines the desired state of BackendService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceSpec
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
    public V1beta2BackendServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2BackendServiceSpecForProvider ForProvider { get; set; }

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
    public V1beta2BackendServiceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2BackendServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2BackendServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2BackendServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderBackendCustomMetrics
{
    /// <summary>
    /// If true, the metric data is collected and reported to Cloud
    /// Monitoring, but is not used for load balancing.
    /// </summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>
    /// Optional parameter to define a target utilization for the Custom Metrics
    /// balancing mode. The valid range is [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderBackend
{
    /// <summary>
    /// Specifies the balancing mode for this backend.
    /// For global HTTP(S) or TCP/SSL load balancing, the default is
    /// UTILIZATION. Valid values are UTILIZATION, RATE (for HTTP(S)),
    /// CUSTOM_METRICS (for HTTP(s)) and CONNECTION (for TCP/SSL).
    /// See the Backend Services Overview
    /// for an explanation of load balancing modes.
    /// Default value is UTILIZATION.
    /// Possible values are: UTILIZATION, RATE, CONNECTION, CUSTOM_METRICS.
    /// </summary>
    [JsonPropertyName("balancingMode")]
    public string? BalancingMode { get; set; }

    /// <summary>
    /// A multiplier applied to the group&apos;s maximum servicing capacity
    /// (based on UTILIZATION, RATE or CONNECTION).
    /// Default value is 1, which means the group will serve up to 100%
    /// of its configured capacity (depending on balancingMode). A
    /// setting of 0 means the group is completely drained, offering
    /// 0% of its available Capacity. Valid range is [0.0,1.0].
    /// </summary>
    [JsonPropertyName("capacityScaler")]
    public double? CapacityScaler { get; set; }

    /// <summary>
    /// The set of custom metrics that are used for CUSTOM_METRICS BalancingMode.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2BackendServiceStatusAtProviderBackendCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// Provide this property when you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The fully-qualified URL of an Instance Group or Network Endpoint
    /// Group resource. In case of instance group this defines the list
    /// of instances that serve traffic. Member virtual machine
    /// instances from each instance group must live in the same zone as
    /// the instance group itself. No two backends in a backend service
    /// are allowed to use same Instance Group resource.
    /// For Network Endpoint Groups this defines list of endpoints. All
    /// endpoints of Network Endpoint Group must be hosted on instances
    /// located in the same zone as the Network Endpoint Group.
    /// Backend services cannot mix Instance Group and
    /// Network Endpoint Group backends.
    /// Note that you must specify an Instance Group or Network Endpoint
    /// Group resource using the fully-qualified URL, rather than a
    /// partial URL.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>
    /// The max number of simultaneous connections for the group. Can
    /// be used with either CONNECTION or UTILIZATION balancing modes.
    /// For CONNECTION mode, either maxConnections or one
    /// of maxConnectionsPerInstance or maxConnectionsPerEndpoint,
    /// as appropriate for group type, must be set.
    /// </summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single backend
    /// network endpoint can handle. This is used to calculate the
    /// capacity of the group. Can be used in either CONNECTION or
    /// UTILIZATION balancing modes.
    /// For CONNECTION mode, either
    /// maxConnections or maxConnectionsPerEndpoint must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerEndpoint")]
    public double? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single
    /// backend instance can handle. This is used to calculate the
    /// capacity of the group. Can be used in either CONNECTION or
    /// UTILIZATION balancing modes.
    /// For CONNECTION mode, either maxConnections or
    /// maxConnectionsPerInstance must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerInstance")]
    public double? MaxConnectionsPerInstance { get; set; }

    /// <summary>
    /// The max requests per second (RPS) of the group.
    /// Can be used with either RATE or UTILIZATION balancing modes,
    /// but required if RATE mode. For RATE mode, either maxRate or one
    /// of maxRatePerInstance or maxRatePerEndpoint, as appropriate for
    /// group type, must be set.
    /// </summary>
    [JsonPropertyName("maxRate")]
    public double? MaxRate { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend network
    /// endpoint can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerEndpoint must be set.
    /// </summary>
    [JsonPropertyName("maxRatePerEndpoint")]
    public double? MaxRatePerEndpoint { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend
    /// instance can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerInstance must be set.
    /// </summary>
    [JsonPropertyName("maxRatePerInstance")]
    public double? MaxRatePerInstance { get; set; }

    /// <summary>
    /// Used when balancingMode is UTILIZATION. This ratio defines the
    /// CPU utilization target for the group. Valid range is [0.0, 1.0].
    /// </summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }

    /// <summary>
    /// This field indicates whether this backend should be fully utilized before sending traffic to backends
    /// with default preference. This field cannot be set when loadBalancingScheme is set to &apos;EXTERNAL&apos;. The possible values are:
    /// </summary>
    [JsonPropertyName("preference")]
    public string? Preference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderCdnPolicyBypassCacheOnRequestHeaders
{
    /// <summary>The header field name to match on when bypassing cache. Values are case-insensitive.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }
}

/// <summary>
/// The CacheKeyPolicy for this CdnPolicy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderCdnPolicyCacheKeyPolicy
{
    /// <summary>If true requests to different hosts will be cached separately.</summary>
    [JsonPropertyName("includeHost")]
    public bool? IncludeHost { get; set; }

    /// <summary>
    /// Allows HTTP request headers (by name) to be used in the
    /// cache key.
    /// </summary>
    [JsonPropertyName("includeHttpHeaders")]
    public IList<string>? IncludeHttpHeaders { get; set; }

    /// <summary>Names of cookies to include in cache keys.</summary>
    [JsonPropertyName("includeNamedCookies")]
    public IList<string>? IncludeNamedCookies { get; set; }

    /// <summary>If true, http and https requests will be cached separately.</summary>
    [JsonPropertyName("includeProtocol")]
    public bool? IncludeProtocol { get; set; }

    /// <summary>
    /// If true, include query string parameters in the cache key
    /// according to query_string_whitelist and
    /// query_string_blacklist. If neither is set, the entire query
    /// string will be included.
    /// If false, the query string will be excluded from the cache
    /// key entirely.
    /// </summary>
    [JsonPropertyName("includeQueryString")]
    public bool? IncludeQueryString { get; set; }

    /// <summary>
    /// Names of query string parameters to exclude in cache keys.
    /// All other parameters will be included. Either specify
    /// query_string_whitelist or query_string_blacklist, not both.
    /// &apos; &amp; &apos; and &apos;=&apos; will be percent encoded and not treated as
    /// delimiters.
    /// </summary>
    [JsonPropertyName("queryStringBlacklist")]
    public IList<string>? QueryStringBlacklist { get; set; }

    /// <summary>
    /// Names of query string parameters to include in cache keys.
    /// All other parameters will be excluded. Either specify
    /// query_string_whitelist or query_string_blacklist, not both.
    /// &apos; &amp; &apos; and &apos;=&apos; will be percent encoded and not treated as
    /// delimiters.
    /// </summary>
    [JsonPropertyName("queryStringWhitelist")]
    public IList<string>? QueryStringWhitelist { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderCdnPolicyNegativeCachingPolicy
{
    /// <summary>
    /// The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 308, 404, 405, 410, 421, 451 and 501
    /// can be specified as values, and you cannot specify a status code more than once.
    /// </summary>
    [JsonPropertyName("code")]
    public double? Code { get; set; }

    /// <summary>
    /// Lifetime of the cookie.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }
}

/// <summary>
/// Cloud CDN configuration for this BackendService.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderCdnPolicy
{
    /// <summary>
    /// Bypass the cache when the specified request headers are matched - e.g. Pragma or Authorization headers. Up to 5 headers can be specified.
    /// The cache is bypassed for all cdnPolicy.cacheMode settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bypassCacheOnRequestHeaders")]
    public IList<V1beta2BackendServiceStatusAtProviderCdnPolicyBypassCacheOnRequestHeaders>? BypassCacheOnRequestHeaders { get; set; }

    /// <summary>
    /// The CacheKeyPolicy for this CdnPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1beta2BackendServiceStatusAtProviderCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

    /// <summary>
    /// Specifies the cache setting for all responses from this backend.
    /// The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC
    /// Possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL, CACHE_ALL_STATIC.
    /// </summary>
    [JsonPropertyName("cacheMode")]
    public string? CacheMode { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("clientTtl")]
    public double? ClientTtl { get; set; }

    /// <summary>
    /// Specifies the default TTL for cached content served by this origin for responses
    /// that do not have an existing valid TTL (max-age or s-max-age).
    /// </summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>Specifies the maximum allowed TTL for cached content served by this origin.</summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

    /// <summary>Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.</summary>
    [JsonPropertyName("negativeCaching")]
    public bool? NegativeCaching { get; set; }

    /// <summary>
    /// Sets a cache TTL for the specified HTTP status code. negativeCaching must be enabled to configure negativeCachingPolicy.
    /// Omitting the policy and leaving negativeCaching enabled will use Cloud CDN&apos;s default cache TTLs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("negativeCachingPolicy")]
    public IList<V1beta2BackendServiceStatusAtProviderCdnPolicyNegativeCachingPolicy>? NegativeCachingPolicy { get; set; }

    /// <summary>
    /// If true then Cloud CDN will combine multiple concurrent cache fill requests into a small number of requests
    /// to the origin.
    /// </summary>
    [JsonPropertyName("requestCoalescing")]
    public bool? RequestCoalescing { get; set; }

    /// <summary>Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.</summary>
    [JsonPropertyName("serveWhileStale")]
    public double? ServeWhileStale { get; set; }

    /// <summary>
    /// Maximum number of seconds the response to a signed URL request
    /// will be considered fresh, defaults to 1hr (3600s). After this
    /// time period, the response will be revalidated before
    /// being served.
    /// When serving responses to signed URL requests, Cloud CDN will
    /// internally behave as though all responses from this backend had a
    /// &quot;Cache-Control: public, max-age=[TTL]&quot; header, regardless of any
    /// existing Cache-Control header. The actual headers served in
    /// responses will not be altered.
    /// </summary>
    [JsonPropertyName("signedUrlCacheMaxAgeSec")]
    public double? SignedUrlCacheMaxAgeSec { get; set; }
}

/// <summary>
/// Settings controlling the volume of connections to a backend service. This field
/// is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderCircuitBreakers
{
    /// <summary>
    /// The maximum number of connections to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>
    /// The maximum number of pending requests to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }

    /// <summary>
    /// The maximum number of parallel requests to the backend cluster.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }

    /// <summary>
    /// Maximum requests for a single backend connection. This parameter
    /// is respected by both the HTTP/1.1 and HTTP/2 implementations. If
    /// not specified, there is no limit. Setting this parameter to 1
    /// will effectively disable keep alive.
    /// </summary>
    [JsonPropertyName("maxRequestsPerConnection")]
    public double? MaxRequestsPerConnection { get; set; }

    /// <summary>
    /// The maximum number of parallel retries to the backend cluster.
    /// Defaults to 3.
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderConsistentHashHttpCookieTtl
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Hash is based on HTTP Cookie. This field describes a HTTP cookie
/// that will be used as the hash key for the consistent hash load
/// balancer. If the cookie is not present, it will be generated.
/// This field is applicable if the sessionAffinity is set to HTTP_COOKIE.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderConsistentHashHttpCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Lifetime of the cookie.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttl")]
    public V1beta2BackendServiceStatusAtProviderConsistentHashHttpCookieTtl? Ttl { get; set; }
}

/// <summary>
/// Consistent Hash-based load balancing can be used to provide soft session
/// affinity based on HTTP headers, cookies or other properties. This load balancing
/// policy is applicable only for HTTP connections. The affinity to a particular
/// destination host will be lost when one or more hosts are added/removed from the
/// destination service. This field specifies parameters that control consistent
/// hashing. This field only applies if the load_balancing_scheme is set to
/// INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is
/// set to MAGLEV or RING_HASH.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderConsistentHash
{
    /// <summary>
    /// Hash is based on HTTP Cookie. This field describes a HTTP cookie
    /// that will be used as the hash key for the consistent hash load
    /// balancer. If the cookie is not present, it will be generated.
    /// This field is applicable if the sessionAffinity is set to HTTP_COOKIE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpCookie")]
    public V1beta2BackendServiceStatusAtProviderConsistentHashHttpCookie? HttpCookie { get; set; }

    /// <summary>
    /// The hash based on the value of the specified header field.
    /// This field is applicable if the sessionAffinity is set to HEADER_FIELD.
    /// </summary>
    [JsonPropertyName("httpHeaderName")]
    public string? HttpHeaderName { get; set; }

    /// <summary>
    /// The minimum number of virtual nodes to use for the hash ring.
    /// Larger ring sizes result in more granular load
    /// distributions. If the number of hosts in the load balancing pool
    /// is larger than the ring size, each host will be assigned a single
    /// virtual node.
    /// Defaults to 1024.
    /// </summary>
    [JsonPropertyName("minimumRingSize")]
    public double? MinimumRingSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderCustomMetrics
{
    /// <summary>
    /// If true, the metric data is collected and reported to Cloud
    /// Monitoring, but is not used for load balancing.
    /// </summary>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }

    /// <summary>
    /// Name of a custom utilization signal. The name must be 1-64 characters
    /// long and match the regular expression a-z? which
    /// means the first character must be a lowercase letter, and all following
    /// characters must be a dash, period, underscore, lowercase letter, or
    /// digit, except the last character, which cannot be a dash, period, or
    /// underscore. For usage guidelines, see Custom Metrics balancing mode. This
    /// field can only be used for a global or regional backend service with the
    /// loadBalancingScheme set to EXTERNAL_MANAGED,
    /// INTERNAL_MANAGED INTERNAL_SELF_MANAGED.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Settings for enabling Cloud Identity Aware Proxy.
/// If OAuth client is not set, the Google-managed OAuth client is used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderIap
{
    /// <summary>Whether the serving infrastructure will authenticate and authorize all incoming requests.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>OAuth2 Client ID for IAP</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }
}

/// <summary>
/// The configuration for a custom policy implemented by the user and
/// deployed with the client.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderLocalityLbPoliciesCustomPolicy
{
    /// <summary>
    /// An optional, arbitrary JSON object with configuration data, understood
    /// by a locally installed custom policy implementation.
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The configuration for a built-in load balancing policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderLocalityLbPoliciesPolicy
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderLocalityLbPolicies
{
    /// <summary>
    /// The configuration for a custom policy implemented by the user and
    /// deployed with the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customPolicy")]
    public V1beta2BackendServiceStatusAtProviderLocalityLbPoliciesCustomPolicy? CustomPolicy { get; set; }

    /// <summary>
    /// The configuration for a built-in load balancing policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policy")]
    public V1beta2BackendServiceStatusAtProviderLocalityLbPoliciesPolicy? Policy { get; set; }
}

/// <summary>
/// This field denotes the logging options for the load balancer traffic served by this backend service.
/// If logging is enabled, logs will be exported to Stackdriver.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderLogConfig
{
    /// <summary>Whether to enable logging for the load balancer traffic served by this backend service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    /// This field can only be specified if logging is enabled for this backend service and &quot;logConfig.optionalMode&quot;
    /// was set to CUSTOM. Contains a list of optional fields you want to include in the logs.
    /// For example: serverInstance, serverGkeDetails.cluster, serverGkeDetails.pod.podNamespace
    /// For example: orca_load_report, tls.protocol
    /// </summary>
    [JsonPropertyName("optionalFields")]
    public IList<string>? OptionalFields { get; set; }

    /// <summary>
    /// Specifies the optional logging mode for the load balancer traffic.
    /// Supported values: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM.
    /// Possible values are: INCLUDE_ALL_OPTIONAL, EXCLUDE_ALL_OPTIONAL, CUSTOM.
    /// </summary>
    [JsonPropertyName("optionalMode")]
    public string? OptionalMode { get; set; }

    /// <summary>
    /// This field can only be specified if logging is enabled for this backend service. The value of
    /// the field must be in [0, 1]. This configures the sampling rate of requests to the load balancer
    /// where 1.0 means all logged requests are reported and 0.0 means no logged requests are reported.
    /// The default value is 1.0.
    /// </summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>
/// Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the
/// beginning of the stream until the response has been completely processed, including all retries. A stream that
/// does not complete in this duration is closed.
/// If not specified, there will be no timeout limit, i.e. the maximum duration is infinite.
/// This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service.
/// This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution.
    /// Durations less than one second are represented with a 0 seconds field and a positive nanos field.
    /// Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Span of time at a resolution of a second. Must be from 0 to 315,576,000,000 inclusive. (int64 format)</summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The base time that a host is ejected for. The real time is equal to the base
/// time multiplied by the number of times the host has been ejected. Defaults to
/// 30000ms or 30s.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderOutlierDetectionBaseEjectionTime
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Time interval between ejection sweep analysis. This can result in both new
/// ejections as well as hosts being returned to service. Defaults to 10 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderOutlierDetectionInterval
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Settings controlling eviction of unhealthy hosts from the load balancing pool.
/// Applicable backend service types can be a global backend service with the
/// loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderOutlierDetection
{
    /// <summary>
    /// The base time that a host is ejected for. The real time is equal to the base
    /// time multiplied by the number of times the host has been ejected. Defaults to
    /// 30000ms or 30s.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseEjectionTime")]
    public V1beta2BackendServiceStatusAtProviderOutlierDetectionBaseEjectionTime? BaseEjectionTime { get; set; }

    /// <summary>
    /// Number of errors before a host is ejected from the connection pool. When the
    /// backend host is accessed over HTTP, a 5xx return code qualifies as an error.
    /// Defaults to 5.
    /// </summary>
    [JsonPropertyName("consecutiveErrors")]
    public double? ConsecutiveErrors { get; set; }

    /// <summary>
    /// The number of consecutive gateway failures (502, 503, 504 status or connection
    /// errors that are mapped to one of those status codes) before a consecutive
    /// gateway failure ejection occurs. Defaults to 5.
    /// </summary>
    [JsonPropertyName("consecutiveGatewayFailure")]
    public double? ConsecutiveGatewayFailure { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through consecutive 5xx. This setting can be used to disable
    /// ejection or to ramp it up slowly. Defaults to 100.
    /// </summary>
    [JsonPropertyName("enforcingConsecutiveErrors")]
    public double? EnforcingConsecutiveErrors { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through consecutive gateway failures. This setting can be
    /// used to disable ejection or to ramp it up slowly. Defaults to 0.
    /// </summary>
    [JsonPropertyName("enforcingConsecutiveGatewayFailure")]
    public double? EnforcingConsecutiveGatewayFailure { get; set; }

    /// <summary>
    /// The percentage chance that a host will be actually ejected when an outlier
    /// status is detected through success rate statistics. This setting can be used to
    /// disable ejection or to ramp it up slowly. Defaults to 100.
    /// </summary>
    [JsonPropertyName("enforcingSuccessRate")]
    public double? EnforcingSuccessRate { get; set; }

    /// <summary>
    /// Time interval between ejection sweep analysis. This can result in both new
    /// ejections as well as hosts being returned to service. Defaults to 10 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("interval")]
    public V1beta2BackendServiceStatusAtProviderOutlierDetectionInterval? Interval { get; set; }

    /// <summary>
    /// Maximum percentage of hosts in the load balancing pool for the backend service
    /// that can be ejected. Defaults to 10%.
    /// </summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>
    /// The number of hosts in a cluster that must have enough request volume to detect
    /// success rate outliers. If the number of hosts is less than this setting, outlier
    /// detection via success rate statistics is not performed for any host in the
    /// cluster. Defaults to 5.
    /// </summary>
    [JsonPropertyName("successRateMinimumHosts")]
    public double? SuccessRateMinimumHosts { get; set; }

    /// <summary>
    /// The minimum number of total requests that must be collected in one interval (as
    /// defined by the interval duration above) to include this host in success rate
    /// based outlier detection. If the volume is lower than this setting, outlier
    /// detection via success rate statistics is not performed for that host. Defaults
    /// to 100.
    /// </summary>
    [JsonPropertyName("successRateRequestVolume")]
    public double? SuccessRateRequestVolume { get; set; }

    /// <summary>
    /// This factor is used to determine the ejection threshold for success rate outlier
    /// ejection. The ejection threshold is the difference between the mean success
    /// rate, and the product of this factor and the standard deviation of the mean
    /// success rate: mean - (stdev * success_rate_stdev_factor). This factor is divided
    /// by a thousand to get a double. That is, if the desired factor is 1.9, the
    /// runtime value should be 1900. Defaults to 1900.
    /// </summary>
    [JsonPropertyName("successRateStdevFactor")]
    public double? SuccessRateStdevFactor { get; set; }
}

/// <summary>
/// The configuration needed to generate a signature for access to private storage buckets that support AWS&apos;s Signature Version 4 for authentication.
/// Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderSecuritySettingsAwsV4Authentication
{
    /// <summary>The identifier of an access key used for s3 bucket authentication.</summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>The optional version identifier for the access key. You can use this to keep track of different iterations of your access key.</summary>
    [JsonPropertyName("accessKeyVersion")]
    public string? AccessKeyVersion { get; set; }

    /// <summary>
    /// The name of the cloud region of your origin. This is a free-form field with the name of the region your cloud uses to host your origin.
    /// For example, &quot;us-east-1&quot; for AWS or &quot;us-ashburn-1&quot; for OCI.
    /// </summary>
    [JsonPropertyName("originRegion")]
    public string? OriginRegion { get; set; }
}

/// <summary>
/// The security settings that apply to this backend service. This field is applicable to either
/// a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and
/// load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the
/// load_balancing_scheme set to INTERNAL_SELF_MANAGED.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderSecuritySettings
{
    /// <summary>
    /// The configuration needed to generate a signature for access to private storage buckets that support AWS&apos;s Signature Version 4 for authentication.
    /// Allowed only for INTERNET_IP_PORT and INTERNET_FQDN_PORT NEG backends.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("awsV4Authentication")]
    public V1beta2BackendServiceStatusAtProviderSecuritySettingsAwsV4Authentication? AwsV4Authentication { get; set; }

    /// <summary>
    /// ClientTlsPolicy is a resource that specifies how a client should authenticate
    /// connections to backends of a service. This resource itself does not affect
    /// configuration unless it is attached to a backend service resource.
    /// </summary>
    [JsonPropertyName("clientTlsPolicy")]
    public string? ClientTlsPolicy { get; set; }

    /// <summary>
    /// A list of alternate names to verify the subject identity in the certificate.
    /// If specified, the client will verify that the server certificate&apos;s subject
    /// alt name matches one of the specified values.
    /// </summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<string>? SubjectAltNames { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderStrongSessionAffinityCookieTtl
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented
    /// with a 0 seconds field and a positive nanos field. Must
    /// be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// Must be from 0 to 315,576,000,000 inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderStrongSessionAffinityCookie
{
    /// <summary>Name of the cookie.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path to set for the cookie.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Lifetime of the cookie.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ttl")]
    public V1beta2BackendServiceStatusAtProviderStrongSessionAffinityCookieTtl? Ttl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderTlsSettingsSubjectAltNames
{
    /// <summary>The SAN specified as a DNS Name.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>The SAN specified as a URI.</summary>
    [JsonPropertyName("uniformResourceIdentifier")]
    public string? UniformResourceIdentifier { get; set; }
}

/// <summary>
/// Configuration for Backend Authenticated TLS and mTLS. May only be specified when the backend protocol is SSL, HTTPS or HTTP2.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProviderTlsSettings
{
    /// <summary>
    /// Reference to the BackendAuthenticationConfig resource from the networksecurity.googleapis.com namespace.
    /// Can be used in authenticating TLS connections to the backend, as specified by the authenticationMode field.
    /// Can only be specified if authenticationMode is not NONE.
    /// </summary>
    [JsonPropertyName("authenticationConfig")]
    public string? AuthenticationConfig { get; set; }

    /// <summary>
    /// Server Name Indication - see RFC3546 section 3.1. If set, the load balancer sends this string as the SNI hostname in the
    /// TLS connection to the backend, and requires that this string match a Subject Alternative Name (SAN) in the backend&apos;s
    /// server certificate. With a Regional Internet NEG backend, if the SNI is specified here, the load balancer uses it
    /// regardless of whether the Regional Internet NEG is specified with FQDN or IP address and port.
    /// </summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>
    /// A list of Subject Alternative Names (SANs) that the Load Balancer verifies during a TLS handshake with the backend.
    /// When the server presents its X.509 certificate to the Load Balancer, the Load Balancer inspects the certificate&apos;s SAN field,
    /// and requires that at least one SAN match one of the subjectAltNames in the list. This field is limited to 5 entries.
    /// When both sni and subjectAltNames are specified, the load balancer matches the backend certificate&apos;s SAN only to
    /// subjectAltNames.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<V1beta2BackendServiceStatusAtProviderTlsSettingsSubjectAltNames>? SubjectAltNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusAtProvider
{
    /// <summary>
    /// Lifetime of cookies in seconds if session_affinity is
    /// GENERATED_COOKIE. If set to 0, the cookie is non-persistent and lasts
    /// only until the end of the browser session (or equivalent). The
    /// maximum allowed value for TTL is one day.
    /// When the load balancing scheme is INTERNAL, this field is not used.
    /// </summary>
    [JsonPropertyName("affinityCookieTtlSec")]
    public double? AffinityCookieTtlSec { get; set; }

    /// <summary>
    /// The set of backends that serve this BackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("backend")]
    public IList<V1beta2BackendServiceStatusAtProviderBackend>? Backend { get; set; }

    /// <summary>
    /// Cloud CDN configuration for this BackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cdnPolicy")]
    public V1beta2BackendServiceStatusAtProviderCdnPolicy? CdnPolicy { get; set; }

    /// <summary>
    /// Settings controlling the volume of connections to a backend service. This field
    /// is applicable only when the load_balancing_scheme is set to INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("circuitBreakers")]
    public V1beta2BackendServiceStatusAtProviderCircuitBreakers? CircuitBreakers { get; set; }

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&apos;s Accept-Encoding header.
    /// Possible values are: AUTOMATIC, DISABLED.
    /// </summary>
    [JsonPropertyName("compressionMode")]
    public string? CompressionMode { get; set; }

    /// <summary>
    /// Time for which instance will be drained (not accept new
    /// connections, but still work to finish started).
    /// </summary>
    [JsonPropertyName("connectionDrainingTimeoutSec")]
    public double? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>
    /// Consistent Hash-based load balancing can be used to provide soft session
    /// affinity based on HTTP headers, cookies or other properties. This load balancing
    /// policy is applicable only for HTTP connections. The affinity to a particular
    /// destination host will be lost when one or more hosts are added/removed from the
    /// destination service. This field specifies parameters that control consistent
    /// hashing. This field only applies if the load_balancing_scheme is set to
    /// INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is
    /// set to MAGLEV or RING_HASH.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("consistentHash")]
    public V1beta2BackendServiceStatusAtProviderConsistentHash? ConsistentHash { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>
    /// List of custom metrics that are used for the WEIGHTED_ROUND_ROBIN locality_lb_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2BackendServiceStatusAtProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied
    /// requests.
    /// </summary>
    [JsonPropertyName("customRequestHeaders")]
    public IList<string>? CustomRequestHeaders { get; set; }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied
    /// responses.
    /// </summary>
    [JsonPropertyName("customResponseHeaders")]
    public IList<string>? CustomResponseHeaders { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The resource URL for the edge security policy associated with this backend service.</summary>
    [JsonPropertyName("edgeSecurityPolicy")]
    public string? EdgeSecurityPolicy { get; set; }

    /// <summary>If true, enable Cloud CDN for this BackendService.</summary>
    [JsonPropertyName("enableCdn")]
    public bool? EnableCdn { get; set; }

    /// <summary>
    /// Specifies the canary migration state. Possible values are PREPARE, TEST_BY_PERCENTAGE, and
    /// TEST_ALL_TRAFFIC.
    /// To begin the migration from EXTERNAL to EXTERNAL_MANAGED, the state must be changed to
    /// PREPARE. The state must be changed to TEST_ALL_TRAFFIC before the loadBalancingScheme can be
    /// changed to EXTERNAL_MANAGED. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate
    /// traffic by percentage using externalManagedMigrationTestingPercentage.
    /// Rolling back a migration requires the states to be set in reverse order. So changing the
    /// scheme from EXTERNAL_MANAGED to EXTERNAL requires the state to be set to TEST_ALL_TRAFFIC at
    /// the same time. Optionally, the TEST_BY_PERCENTAGE state can be used to migrate some traffic
    /// back to EXTERNAL or PREPARE can be used to migrate all traffic back to EXTERNAL.
    /// Possible values are: PREPARE, TEST_BY_PERCENTAGE, TEST_ALL_TRAFFIC.
    /// </summary>
    [JsonPropertyName("externalManagedMigrationState")]
    public string? ExternalManagedMigrationState { get; set; }

    /// <summary>
    /// Determines the fraction of requests that should be processed by the Global external
    /// Application Load Balancer.
    /// The value of this field must be in the range [0, 100].
    /// Session affinity options will slightly affect this routing behavior, for more details,
    /// see: Session Affinity.
    /// This value can only be set if the loadBalancingScheme in the backend service is set to
    /// EXTERNAL (when using the Classic ALB) and the migration state is TEST_BY_PERCENTAGE.
    /// </summary>
    [JsonPropertyName("externalManagedMigrationTestingPercentage")]
    public double? ExternalManagedMigrationTestingPercentage { get; set; }

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this
    /// object. This field is used in optimistic locking.
    /// </summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("generatedId")]
    public double? GeneratedId { get; set; }

    /// <summary>
    /// The set of URLs to the HttpHealthCheck or HttpsHealthCheck resource
    /// for health checking this BackendService. Currently at most one health
    /// check can be specified.
    /// A health check must be specified unless the backend service uses an internet
    /// or serverless NEG as a backend.
    /// For internal load balancing, a URL to a HealthCheck resource must be specified instead.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public IList<string>? HealthChecks { get; set; }

    /// <summary>
    /// Settings for enabling Cloud Identity Aware Proxy.
    /// If OAuth client is not set, the Google-managed OAuth client is used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("iap")]
    public V1beta2BackendServiceStatusAtProviderIap? Iap { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/backendServices/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC).
    /// Possible values are: IPV4_ONLY, PREFER_IPV6, IPV6_ONLY.
    /// </summary>
    [JsonPropertyName("ipAddressSelectionPolicy")]
    public string? IpAddressSelectionPolicy { get; set; }

    /// <summary>
    /// Indicates whether the backend service will be used with internal or
    /// external load balancing. A backend service created for one type of
    /// load balancing cannot be used with the other. For more information, refer to
    /// Choosing a load balancer.
    /// Default value is EXTERNAL.
    /// Possible values are: EXTERNAL, INTERNAL_SELF_MANAGED, INTERNAL_MANAGED, EXTERNAL_MANAGED.
    /// </summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>
    /// A list of locality load balancing policies to be used in order of
    /// preference. Either the policy or the customPolicy field should be set.
    /// Overrides any value set in the localityLbPolicy field.
    /// localityLbPolicies is only supported when the BackendService is referenced
    /// by a URL Map that is referenced by a target gRPC proxy that has the
    /// validateForProxyless field set to true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localityLbPolicies")]
    public IList<V1beta2BackendServiceStatusAtProviderLocalityLbPolicies>? LocalityLbPolicies { get; set; }

    /// <summary>
    /// The load balancing algorithm used within the scope of the locality.
    /// The possible values are:
    /// </summary>
    [JsonPropertyName("localityLbPolicy")]
    public string? LocalityLbPolicy { get; set; }

    /// <summary>
    /// This field denotes the logging options for the load balancer traffic served by this backend service.
    /// If logging is enabled, logs will be exported to Stackdriver.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2BackendServiceStatusAtProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// Specifies the default maximum duration (timeout) for streams to this service. Duration is computed from the
    /// beginning of the stream until the response has been completely processed, including all retries. A stream that
    /// does not complete in this duration is closed.
    /// If not specified, there will be no timeout limit, i.e. the maximum duration is infinite.
    /// This value can be overridden in the PathMatcher configuration of the UrlMap that references this backend service.
    /// This field is only allowed when the loadBalancingScheme of the backend service is INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2BackendServiceStatusAtProviderMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Settings controlling eviction of unhealthy hosts from the load balancing pool.
    /// Applicable backend service types can be a global backend service with the
    /// loadBalancingScheme set to INTERNAL_SELF_MANAGED or EXTERNAL_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta2BackendServiceStatusAtProviderOutlierDetection? OutlierDetection { get; set; }

    /// <summary>
    /// Name of backend port. The same name should appear in the instance
    /// groups referenced by this service. Required when the load balancing
    /// scheme is EXTERNAL.
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The protocol this BackendService uses to communicate with backends.
    /// The default is HTTP. Possible values are HTTP, HTTPS, HTTP2, H2C, TCP, SSL, UDP
    /// or GRPC. Refer to the documentation for the load balancers or for Traffic Director
    /// for more information. Must be set to GRPC when the backend service is referenced
    /// by a URL map that is bound to target gRPC proxy.
    /// Possible values are: HTTP, HTTPS, HTTP2, TCP, SSL, UDP, GRPC, UNSPECIFIED, H2C.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>
    /// The security settings that apply to this backend service. This field is applicable to either
    /// a regional backend service with the service_protocol set to HTTP, HTTPS, HTTP2 or H2C, and
    /// load_balancing_scheme set to INTERNAL_MANAGED; or a global backend service with the
    /// load_balancing_scheme set to INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("securitySettings")]
    public V1beta2BackendServiceStatusAtProviderSecuritySettings? SecuritySettings { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// URL to networkservices.ServiceLbPolicy resource.
    /// Can only be set if load balancing scheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED or INTERNAL_SELF_MANAGED and the scope is global.
    /// </summary>
    [JsonPropertyName("serviceLbPolicy")]
    public string? ServiceLbPolicy { get; set; }

    /// <summary>
    /// Type of session affinity to use. The default is NONE. Session affinity is
    /// not applicable if the protocol is UDP.
    /// Possible values are: NONE, CLIENT_IP, CLIENT_IP_PORT_PROTO, CLIENT_IP_PROTO, GENERATED_COOKIE, HEADER_FIELD, HTTP_COOKIE, STRONG_COOKIE_AFFINITY.
    /// </summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>
    /// Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("strongSessionAffinityCookie")]
    public V1beta2BackendServiceStatusAtProviderStrongSessionAffinityCookie? StrongSessionAffinityCookie { get; set; }

    /// <summary>
    /// The backend service timeout has a different meaning depending on the type of load balancer.
    /// For more information see, Backend service settings.
    /// The default is 30 seconds.
    /// The full range of timeout values allowed goes from 1 through 2,147,483,647 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSec")]
    public double? TimeoutSec { get; set; }

    /// <summary>
    /// Configuration for Backend Authenticated TLS and mTLS. May only be specified when the backend protocol is SSL, HTTPS or HTTP2.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("tlsSettings")]
    public V1beta2BackendServiceStatusAtProviderTlsSettings? TlsSettings { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatusConditions
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

/// <summary>BackendServiceStatus defines the observed state of BackendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackendServiceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2BackendServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2BackendServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BackendService is the Schema for the BackendServices API. A Backend Service defines a group of virtual machines that will serve traffic for load balancing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackendService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BackendServiceSpec>, IStatus<V1beta2BackendServiceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackendService";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "backendservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackendService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackendServiceSpec defines the desired state of BackendService</summary>
    [JsonPropertyName("spec")]
    public required V1beta2BackendServiceSpec Spec { get; set; }

    /// <summary>BackendServiceStatus defines the observed state of BackendService.</summary>
    [JsonPropertyName("status")]
    public V1beta2BackendServiceStatus? Status { get; set; }
}