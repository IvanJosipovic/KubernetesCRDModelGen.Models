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
/// <summary>RegionBackendService is the Schema for the RegionBackendServices API. A Region Backend Service defines a regionally-scoped group of virtual machines that will serve traffic for load balancing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegionBackendServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2RegionBackendService>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegionBackendServiceList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionbackendservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionBackendServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2RegionBackendService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2RegionBackendService> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecDeletionPolicyEnum>))]
public enum V1beta2RegionBackendServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderBackendCustomMetrics
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderBackendGroupRefPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderBackendGroupRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderBackendGroupRefPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderBackendGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderBackendGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderBackendGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderBackendGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionInstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderBackendGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecForProviderBackendGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderBackendGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderBackendGroupSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderBackendGroupSelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderBackendGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderBackendGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderBackendGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderBackendGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionInstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderBackendGroupSelector
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
    public V1beta2RegionBackendServiceSpecForProviderBackendGroupSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderBackend
{
    /// <summary>
    /// Specifies the balancing mode for this backend.
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
    /// ~&gt;NOTE: This field cannot be set for
    /// INTERNAL region backend services (default loadBalancingScheme),
    /// but is required for non-INTERNAL backend service. The total
    /// capacity_scaler for all backends must be non-zero.
    /// A setting of 0 means the group is completely drained, offering
    /// 0% of its available Capacity. Valid range is [0.0,1.0].
    /// </summary>
    [JsonPropertyName("capacityScaler")]
    public double? CapacityScaler { get; set; }

    /// <summary>
    /// The set of custom metrics that are used for CUSTOM_METRICS BalancingMode.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2RegionBackendServiceSpecForProviderBackendCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// Provide this property when you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// This field designates whether this is a failover backend. More
    /// than one failover backend can be configured for a given RegionBackendService.
    /// </summary>
    [JsonPropertyName("failover")]
    public bool? Failover { get; set; }

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
    /// When the load_balancing_scheme is INTERNAL, only instance groups
    /// are supported.
    /// Note that you must specify an Instance Group or Network Endpoint
    /// Group resource using the fully-qualified URL, rather than a
    /// partial URL.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Reference to a RegionInstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupRef")]
    public V1beta2RegionBackendServiceSpecForProviderBackendGroupRef? GroupRef { get; set; }

    /// <summary>Selector for a RegionInstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupSelector")]
    public V1beta2RegionBackendServiceSpecForProviderBackendGroupSelector? GroupSelector { get; set; }

    /// <summary>
    /// The max number of simultaneous connections for the group. Can
    /// be used with either CONNECTION or UTILIZATION balancing modes.
    /// Cannot be set for INTERNAL backend services.
    /// For CONNECTION mode, either maxConnections or one
    /// of maxConnectionsPerInstance or maxConnectionsPerEndpoint,
    /// as appropriate for group type, must be set.
    /// </summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single backend
    /// network endpoint can handle. Cannot be set
    /// for INTERNAL backend services.
    /// This is used to calculate the capacity of the group. Can be
    /// used in either CONNECTION or UTILIZATION balancing modes. For
    /// CONNECTION mode, either maxConnections or
    /// maxConnectionsPerEndpoint must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerEndpoint")]
    public double? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single
    /// backend instance can handle. Cannot be set for INTERNAL backend
    /// services.
    /// This is used to calculate the capacity of the group.
    /// Can be used in either CONNECTION or UTILIZATION balancing modes.
    /// For CONNECTION mode, either maxConnections or
    /// maxConnectionsPerInstance must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerInstance")]
    public double? MaxConnectionsPerInstance { get; set; }

    /// <summary>
    /// The max requests per second (RPS) of the group. Cannot be set
    /// for INTERNAL backend services.
    /// Can be used with either RATE or UTILIZATION balancing modes,
    /// but required if RATE mode. Either maxRate or one
    /// of maxRatePerInstance or maxRatePerEndpoint, as appropriate for
    /// group type, must be set.
    /// </summary>
    [JsonPropertyName("maxRate")]
    public double? MaxRate { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend network
    /// endpoint can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerEndpoint must be set. Cannot be set
    /// for INTERNAL backend services.
    /// </summary>
    [JsonPropertyName("maxRatePerEndpoint")]
    public double? MaxRatePerEndpoint { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend
    /// instance can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerInstance must be set. Cannot be set
    /// for INTERNAL backend services.
    /// </summary>
    [JsonPropertyName("maxRatePerInstance")]
    public double? MaxRatePerInstance { get; set; }

    /// <summary>
    /// Used when balancingMode is UTILIZATION. This ratio defines the
    /// CPU utilization target for the group. Valid range is [0.0, 1.0].
    /// Cannot be set for INTERNAL backend services.
    /// </summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }
}

/// <summary>
/// The CacheKeyPolicy for this CdnPolicy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderCdnPolicyCacheKeyPolicy
{
    /// <summary>If true requests to different hosts will be cached separately.</summary>
    [JsonPropertyName("includeHost")]
    public bool? IncludeHost { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderCdnPolicyNegativeCachingPolicy
{
    /// <summary>
    /// The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 308, 404, 405, 410, 421, 451 and 501
    /// can be specified as values, and you cannot specify a status code more than once.
    /// </summary>
    [JsonPropertyName("code")]
    public double? Code { get; set; }
}

/// <summary>
/// Cloud CDN configuration for this BackendService.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderCdnPolicy
{
    /// <summary>
    /// The CacheKeyPolicy for this CdnPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1beta2RegionBackendServiceSpecForProviderCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

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
    public IList<V1beta2RegionBackendServiceSpecForProviderCdnPolicyNegativeCachingPolicy>? NegativeCachingPolicy { get; set; }

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
/// is applicable only when the load_balancing_scheme is set to INTERNAL_MANAGED
/// and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderCircuitBreakers
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
/// Connection Tracking configuration for this BackendService.
/// This is available only for Layer 4 Internal Load Balancing and
/// Network Load Balancing.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderConnectionTrackingPolicy
{
    /// <summary>
    /// Specifies connection persistence when backends are unhealthy.
    /// If set to DEFAULT_FOR_PROTOCOL, the existing connections persist on
    /// unhealthy backends only for connection-oriented protocols (TCP and SCTP)
    /// and only if the Tracking Mode is PER_CONNECTION (default tracking mode)
    /// or the Session Affinity is configured for 5-tuple. They do not persist
    /// for UDP.
    /// If set to NEVER_PERSIST, after a backend becomes unhealthy, the existing
    /// connections on the unhealthy backend are never persisted on the unhealthy
    /// backend. They are always diverted to newly selected healthy backends
    /// (unless all backends are unhealthy).
    /// If set to ALWAYS_PERSIST, existing connections always persist on
    /// unhealthy backends regardless of protocol and session affinity. It is
    /// generally not recommended to use this mode overriding the default.
    /// Default value is DEFAULT_FOR_PROTOCOL.
    /// Possible values are: DEFAULT_FOR_PROTOCOL, NEVER_PERSIST, ALWAYS_PERSIST.
    /// </summary>
    [JsonPropertyName("connectionPersistenceOnUnhealthyBackends")]
    public string? ConnectionPersistenceOnUnhealthyBackends { get; set; }

    /// <summary>Enable Strong Session Affinity for Network Load Balancing. This option is not available publicly.</summary>
    [JsonPropertyName("enableStrongAffinity")]
    public bool? EnableStrongAffinity { get; set; }

    /// <summary>
    /// Specifies how long to keep a Connection Tracking entry while there is
    /// no matching traffic (in seconds).
    /// For L4 ILB the minimum(default) is 10 minutes and maximum is 16 hours.
    /// For NLB the minimum(default) is 60 seconds and the maximum is 16 hours.
    /// </summary>
    [JsonPropertyName("idleTimeoutSec")]
    public double? IdleTimeoutSec { get; set; }

    /// <summary>
    /// Specifies the key used for connection tracking. There are two options:
    /// PER_CONNECTION: The Connection Tracking is performed as per the
    /// Connection Key (default Hash Method) for the specific protocol.
    /// PER_SESSION: The Connection Tracking is performed as per the
    /// configured Session Affinity. It matches the configured Session Affinity.
    /// Default value is PER_CONNECTION.
    /// Possible values are: PER_CONNECTION, PER_SESSION.
    /// </summary>
    [JsonPropertyName("trackingMode")]
    public string? TrackingMode { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderConsistentHashHttpCookieTtl
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderConsistentHashHttpCookie
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
    public V1beta2RegionBackendServiceSpecForProviderConsistentHashHttpCookieTtl? Ttl { get; set; }
}

/// <summary>
/// Consistent Hash-based load balancing can be used to provide soft session
/// affinity based on HTTP headers, cookies or other properties. This load balancing
/// policy is applicable only for HTTP connections. The affinity to a particular
/// destination host will be lost when one or more hosts are added/removed from the
/// destination service. This field specifies parameters that control consistent
/// hashing.
/// This field only applies when all of the following are true -
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderConsistentHash
{
    /// <summary>
    /// Hash is based on HTTP Cookie. This field describes a HTTP cookie
    /// that will be used as the hash key for the consistent hash load
    /// balancer. If the cookie is not present, it will be generated.
    /// This field is applicable if the sessionAffinity is set to HTTP_COOKIE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpCookie")]
    public V1beta2RegionBackendServiceSpecForProviderConsistentHashHttpCookie? HttpCookie { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderCustomMetrics
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
/// Policy for failovers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderFailoverPolicy
{
    /// <summary>
    /// On failover or failback, this field indicates whether connection drain
    /// will be honored. Setting this to true has the following effect: connections
    /// to the old active pool are not drained. Connections to the new active pool
    /// use the timeout of 10 min (currently fixed). Setting to false has the
    /// following effect: both old and new connections will have a drain timeout
    /// of 10 min.
    /// This can be set to true only if the protocol is TCP.
    /// The default is false.
    /// </summary>
    [JsonPropertyName("disableConnectionDrainOnFailover")]
    public bool? DisableConnectionDrainOnFailover { get; set; }

    /// <summary>
    /// This option is used only when no healthy VMs are detected in the primary
    /// and backup instance groups. When set to true, traffic is dropped. When
    /// set to false, new connections are sent across all VMs in the primary group.
    /// The default is false.
    /// </summary>
    [JsonPropertyName("dropTrafficIfUnhealthy")]
    public bool? DropTrafficIfUnhealthy { get; set; }

    /// <summary>
    /// The value of the field must be in [0, 1]. If the ratio of the healthy
    /// VMs in the primary backend is at or below this number, traffic arriving
    /// at the load-balanced IP will be directed to the failover backend.
    /// In case where &apos;failoverRatio&apos; is not set or all the VMs in the backup
    /// backend are unhealthy, the traffic will be directed back to the primary
    /// backend in the &quot;force&quot; mode, where traffic will be spread to the healthy
    /// VMs with the best effort, or to all VMs when no VM is healthy.
    /// This field is only used with l4 load balancing.
    /// </summary>
    [JsonPropertyName("failoverRatio")]
    public double? FailoverRatio { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupRefPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupRefPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkEndpointGroup in compute to populate backendGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupSelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkEndpointGroup in compute to populate backendGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupSelector
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
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in compute to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in compute to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceSelector
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
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The network endpoint within the leader.backendGroup that is designated as the leader.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpoint
{
    /// <summary>
    /// The name of the VM instance of the leader network endpoint. The instance must
    /// already be attached to the NEG specified in the haPolicy.leader.backendGroup.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Reference to a Instance in compute to populate instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceRef? InstanceRef { get; set; }

    /// <summary>Selector for a Instance in compute to populate instance.</summary>
    [JsonPropertyName("instanceSelector")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpointInstanceSelector? InstanceSelector { get; set; }
}

/// <summary>
/// Selects one of the network endpoints attached to the backend NEGs of this service as the
/// active endpoint (the leader) that receives all traffic.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHaPolicyLeader
{
    /// <summary>
    /// A fully-qualified URL of the zonal Network Endpoint Group (NEG) that the leader is
    /// attached to.
    /// </summary>
    [JsonPropertyName("backendGroup")]
    public string? BackendGroup { get; set; }

    /// <summary>Reference to a NetworkEndpointGroup in compute to populate backendGroup.</summary>
    [JsonPropertyName("backendGroupRef")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupRef? BackendGroupRef { get; set; }

    /// <summary>Selector for a NetworkEndpointGroup in compute to populate backendGroup.</summary>
    [JsonPropertyName("backendGroupSelector")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderBackendGroupSelector? BackendGroupSelector { get; set; }

    /// <summary>
    /// The network endpoint within the leader.backendGroup that is designated as the leader.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkEndpoint")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeaderNetworkEndpoint? NetworkEndpoint { get; set; }
}

/// <summary>
/// Configures self-managed High Availability (HA) for External and Internal Protocol Forwarding.
/// The backends of this regional backend service must only specify zonal network endpoint groups
/// (NEGs) of type GCE_VM_IP. Note that haPolicy is not for load balancing, and therefore cannot
/// be specified with sessionAffinity, connectionTrackingPolicy, and failoverPolicy. haPolicy
/// requires customers to be responsible for tracking backend endpoint health and electing a
/// leader among the healthy endpoints. Therefore, haPolicy cannot be specified with healthChecks.
/// haPolicy can only be specified for External Passthrough Network Load Balancers and Internal
/// Passthrough Network Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHaPolicy
{
    /// <summary>
    /// Specifies whether fast IP move is enabled, and if so, the mechanism to achieve it.
    /// Supported values are:
    /// </summary>
    [JsonPropertyName("fastIpMove")]
    public string? FastIpMove { get; set; }

    /// <summary>
    /// Selects one of the network endpoints attached to the backend NEGs of this service as the
    /// active endpoint (the leader) that receives all traffic.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("leader")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicyLeader? Leader { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHealthChecksRefsPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHealthChecksRefsPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHealthChecksRefsPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHealthChecksRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHealthChecksRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderHealthChecksRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderHealthChecksRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHealthChecksRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecForProviderHealthChecksRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHealthChecksSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHealthChecksSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderHealthChecksSelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderHealthChecksSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHealthChecksSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderHealthChecksSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderHealthChecksSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of RegionHealthCheck in compute to populate healthChecks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderHealthChecksSelector
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
    public V1beta2RegionBackendServiceSpecForProviderHealthChecksSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// OAuth2 Client Secret for IAP
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderIapOauth2ClientSecretSecretRef
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
/// If OAuth client is not set, Google-managed OAuth client is used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderIap
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
    public V1beta2RegionBackendServiceSpecForProviderIapOauth2ClientSecretSecretRef? Oauth2ClientSecretSecretRef { get; set; }
}

/// <summary>
/// This field denotes the logging options for the load balancer traffic served by this backend service.
/// If logging is enabled, logs will be exported to Stackdriver.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderLogConfig
{
    /// <summary>Whether to enable logging for the load balancer traffic served by this backend service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Specifies the fields to include in logging. This field can only be specified if logging is enabled for this backend service.</summary>
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
/// When configured, new connections are load balanced across healthy backend endpoints in the local zone.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderNetworkPassThroughLbTrafficPolicyZonalAffinity
{
    /// <summary>
    /// This field indicates whether zonal affinity is enabled or not.
    /// Default value is ZONAL_AFFINITY_DISABLED.
    /// Possible values are: ZONAL_AFFINITY_DISABLED, ZONAL_AFFINITY_SPILL_CROSS_ZONE, ZONAL_AFFINITY_STAY_WITHIN_ZONE.
    /// </summary>
    [JsonPropertyName("spillover")]
    public string? Spillover { get; set; }

    /// <summary>
    /// The value of the field must be in [0, 1]. When the ratio of the count of healthy backend endpoints in a zone
    /// to the count of backend endpoints in that same zone is equal to or above this threshold, the load balancer
    /// distributes new connections to all healthy endpoints in the local zone only. When the ratio of the count
    /// of healthy backend endpoints in a zone to the count of backend endpoints in that same zone is below this
    /// threshold, the load balancer distributes all new connections to all healthy endpoints across all zones.
    /// </summary>
    [JsonPropertyName("spilloverRatio")]
    public double? SpilloverRatio { get; set; }
}

/// <summary>
/// Configures traffic steering properties of internal passthrough Network Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderNetworkPassThroughLbTrafficPolicy
{
    /// <summary>
    /// When configured, new connections are load balanced across healthy backend endpoints in the local zone.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("zonalAffinity")]
    public V1beta2RegionBackendServiceSpecForProviderNetworkPassThroughLbTrafficPolicyZonalAffinity? ZonalAffinity { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderNetworkRefPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderNetworkRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderNetworkRefPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecForProviderNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderNetworkSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderNetworkSelector
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
    public V1beta2RegionBackendServiceSpecForProviderNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The base time that a host is ejected for. The real time is equal to the base
/// time multiplied by the number of times the host has been ejected. Defaults to
/// 30000ms or 30s.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderOutlierDetectionBaseEjectionTime
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderOutlierDetectionInterval
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
/// This field is applicable only when the load_balancing_scheme is set
/// to INTERNAL_MANAGED and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderOutlierDetection
{
    /// <summary>
    /// The base time that a host is ejected for. The real time is equal to the base
    /// time multiplied by the number of times the host has been ejected. Defaults to
    /// 30000ms or 30s.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseEjectionTime")]
    public V1beta2RegionBackendServiceSpecForProviderOutlierDetectionBaseEjectionTime? BaseEjectionTime { get; set; }

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
    public V1beta2RegionBackendServiceSpecForProviderOutlierDetectionInterval? Interval { get; set; }

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
/// Additional params passed with the request, but not persisted as part of resource payload
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderParams
{
    /// <summary>
    /// Resource manager tags to be bound to the region backend service. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderSecurityPolicyRefPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderSecurityPolicyRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderSecurityPolicyRefPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderSecurityPolicyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderSecurityPolicyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderSecurityPolicyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderSecurityPolicyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionSecurityPolicy in compute to populate securityPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderSecurityPolicyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecForProviderSecurityPolicyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderSecurityPolicySelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderSecurityPolicySelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecForProviderSecurityPolicySelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecForProviderSecurityPolicySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderSecurityPolicySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecForProviderSecurityPolicySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecForProviderSecurityPolicySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionSecurityPolicy in compute to populate securityPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderSecurityPolicySelector
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
    public V1beta2RegionBackendServiceSpecForProviderSecurityPolicySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderStrongSessionAffinityCookieTtl
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderStrongSessionAffinityCookie
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
    public V1beta2RegionBackendServiceSpecForProviderStrongSessionAffinityCookieTtl? Ttl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderTlsSettingsSubjectAltNames
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProviderTlsSettings
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
    public IList<V1beta2RegionBackendServiceSpecForProviderTlsSettingsSubjectAltNames>? SubjectAltNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecForProvider
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
    /// The set of backends that serve this RegionBackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("backend")]
    public IList<V1beta2RegionBackendServiceSpecForProviderBackend>? Backend { get; set; }

    /// <summary>
    /// Cloud CDN configuration for this BackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cdnPolicy")]
    public V1beta2RegionBackendServiceSpecForProviderCdnPolicy? CdnPolicy { get; set; }

    /// <summary>
    /// Settings controlling the volume of connections to a backend service. This field
    /// is applicable only when the load_balancing_scheme is set to INTERNAL_MANAGED
    /// and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("circuitBreakers")]
    public V1beta2RegionBackendServiceSpecForProviderCircuitBreakers? CircuitBreakers { get; set; }

    /// <summary>
    /// Time for which instance will be drained (not accept new
    /// connections, but still work to finish started).
    /// </summary>
    [JsonPropertyName("connectionDrainingTimeoutSec")]
    public double? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>
    /// Connection Tracking configuration for this BackendService.
    /// This is available only for Layer 4 Internal Load Balancing and
    /// Network Load Balancing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("connectionTrackingPolicy")]
    public V1beta2RegionBackendServiceSpecForProviderConnectionTrackingPolicy? ConnectionTrackingPolicy { get; set; }

    /// <summary>
    /// Consistent Hash-based load balancing can be used to provide soft session
    /// affinity based on HTTP headers, cookies or other properties. This load balancing
    /// policy is applicable only for HTTP connections. The affinity to a particular
    /// destination host will be lost when one or more hosts are added/removed from the
    /// destination service. This field specifies parameters that control consistent
    /// hashing.
    /// This field only applies when all of the following are true -
    /// </summary>
    [JsonPropertyName("consistentHash")]
    public V1beta2RegionBackendServiceSpecForProviderConsistentHash? ConsistentHash { get; set; }

    /// <summary>
    /// List of custom metrics that are used for the WEIGHTED_ROUND_ROBIN locality_lb_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2RegionBackendServiceSpecForProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, enable Cloud CDN for this RegionBackendService.</summary>
    [JsonPropertyName("enableCdn")]
    public bool? EnableCdn { get; set; }

    /// <summary>
    /// Policy for failovers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("failoverPolicy")]
    public V1beta2RegionBackendServiceSpecForProviderFailoverPolicy? FailoverPolicy { get; set; }

    /// <summary>
    /// Configures self-managed High Availability (HA) for External and Internal Protocol Forwarding.
    /// The backends of this regional backend service must only specify zonal network endpoint groups
    /// (NEGs) of type GCE_VM_IP. Note that haPolicy is not for load balancing, and therefore cannot
    /// be specified with sessionAffinity, connectionTrackingPolicy, and failoverPolicy. haPolicy
    /// requires customers to be responsible for tracking backend endpoint health and electing a
    /// leader among the healthy endpoints. Therefore, haPolicy cannot be specified with healthChecks.
    /// haPolicy can only be specified for External Passthrough Network Load Balancers and Internal
    /// Passthrough Network Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("haPolicy")]
    public V1beta2RegionBackendServiceSpecForProviderHaPolicy? HaPolicy { get; set; }

    /// <summary>
    /// The set of URLs to HealthCheck resources for health checking
    /// this RegionBackendService. Currently at most one health
    /// check can be specified.
    /// A health check must be specified unless the backend service uses an internet
    /// or serverless NEG as a backend.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public IList<string>? HealthChecks { get; set; }

    /// <summary>References to RegionHealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksRefs")]
    public IList<V1beta2RegionBackendServiceSpecForProviderHealthChecksRefs>? HealthChecksRefs { get; set; }

    /// <summary>Selector for a list of RegionHealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksSelector")]
    public V1beta2RegionBackendServiceSpecForProviderHealthChecksSelector? HealthChecksSelector { get; set; }

    /// <summary>
    /// Settings for enabling Cloud Identity Aware Proxy.
    /// If OAuth client is not set, Google-managed OAuth client is used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("iap")]
    public V1beta2RegionBackendServiceSpecForProviderIap? Iap { get; set; }

    /// <summary>
    /// Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC).
    /// Possible values are: IPV4_ONLY, PREFER_IPV6, IPV6_ONLY.
    /// </summary>
    [JsonPropertyName("ipAddressSelectionPolicy")]
    public string? IpAddressSelectionPolicy { get; set; }

    /// <summary>is set to INTERNAL_MANAGED</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>
    /// is set to MAGLEV or RING_HASH
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localityLbPolicy")]
    public string? LocalityLbPolicy { get; set; }

    /// <summary>
    /// This field denotes the logging options for the load balancer traffic served by this backend service.
    /// If logging is enabled, logs will be exported to Stackdriver.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2RegionBackendServiceSpecForProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// The URL of the network to which this backend service belongs.
    /// This field must be set for Internal Passthrough Network Load Balancers when the haPolicy is enabled, and for External Passthrough Network Load Balancers when the haPolicy fastIpMove is enabled.
    /// This field can only be specified when the load balancing scheme is set to INTERNAL, or when the load balancing scheme is set to EXTERNAL and haPolicy fastIpMove is enabled.
    /// Changes to this field force recreation of the resource.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// Configures traffic steering properties of internal passthrough Network Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkPassThroughLbTrafficPolicy")]
    public V1beta2RegionBackendServiceSpecForProviderNetworkPassThroughLbTrafficPolicy? NetworkPassThroughLbTrafficPolicy { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta2RegionBackendServiceSpecForProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta2RegionBackendServiceSpecForProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>
    /// Settings controlling eviction of unhealthy hosts from the load balancing pool.
    /// This field is applicable only when the load_balancing_scheme is set
    /// to INTERNAL_MANAGED and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta2RegionBackendServiceSpecForProviderOutlierDetection? OutlierDetection { get; set; }

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("params")]
    public V1beta2RegionBackendServiceSpecForProviderParams? Params { get; set; }

    /// <summary>
    /// A named port on a backend instance group representing the port for
    /// communication to the backend VMs in that group. Required when the
    /// loadBalancingScheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED, or INTERNAL_SELF_MANAGED
    /// and the backends are instance groups. The named port must be defined on each
    /// backend instance group. This parameter has no meaning if the backends are NEGs. API sets a
    /// default of &quot;http&quot; if not given.
    /// Must be omitted when the loadBalancingScheme is INTERNAL (Internal TCP/UDP Load Balancing).
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>is set to HTTP, HTTPS, HTTP2 or H2C</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// The Region in which the created backend service should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>Reference to a RegionSecurityPolicy in compute to populate securityPolicy.</summary>
    [JsonPropertyName("securityPolicyRef")]
    public V1beta2RegionBackendServiceSpecForProviderSecurityPolicyRef? SecurityPolicyRef { get; set; }

    /// <summary>Selector for a RegionSecurityPolicy in compute to populate securityPolicy.</summary>
    [JsonPropertyName("securityPolicySelector")]
    public V1beta2RegionBackendServiceSpecForProviderSecurityPolicySelector? SecurityPolicySelector { get; set; }

    /// <summary>
    /// Type of session affinity to use. The default is NONE. Session affinity is
    /// not applicable if the protocol is UDP.
    /// Possible values are: NONE, CLIENT_IP, CLIENT_IP_PORT_PROTO, CLIENT_IP_PROTO, GENERATED_COOKIE, HEADER_FIELD, HTTP_COOKIE, CLIENT_IP_NO_DESTINATION, STRONG_COOKIE_AFFINITY.
    /// </summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>
    /// Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("strongSessionAffinityCookie")]
    public V1beta2RegionBackendServiceSpecForProviderStrongSessionAffinityCookie? StrongSessionAffinityCookie { get; set; }

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
    public V1beta2RegionBackendServiceSpecForProviderTlsSettings? TlsSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderBackendCustomMetrics
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderBackendGroupRefPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderBackendGroupRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderBackendGroupRefPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderBackendGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderBackendGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderBackendGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderBackendGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionInstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderBackendGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecInitProviderBackendGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderBackendGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderBackendGroupSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderBackendGroupSelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderBackendGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderBackendGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderBackendGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderBackendGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionInstanceGroupManager in compute to populate group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderBackendGroupSelector
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
    public V1beta2RegionBackendServiceSpecInitProviderBackendGroupSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderBackend
{
    /// <summary>
    /// Specifies the balancing mode for this backend.
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
    /// ~&gt;NOTE: This field cannot be set for
    /// INTERNAL region backend services (default loadBalancingScheme),
    /// but is required for non-INTERNAL backend service. The total
    /// capacity_scaler for all backends must be non-zero.
    /// A setting of 0 means the group is completely drained, offering
    /// 0% of its available Capacity. Valid range is [0.0,1.0].
    /// </summary>
    [JsonPropertyName("capacityScaler")]
    public double? CapacityScaler { get; set; }

    /// <summary>
    /// The set of custom metrics that are used for CUSTOM_METRICS BalancingMode.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2RegionBackendServiceSpecInitProviderBackendCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// Provide this property when you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// This field designates whether this is a failover backend. More
    /// than one failover backend can be configured for a given RegionBackendService.
    /// </summary>
    [JsonPropertyName("failover")]
    public bool? Failover { get; set; }

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
    /// When the load_balancing_scheme is INTERNAL, only instance groups
    /// are supported.
    /// Note that you must specify an Instance Group or Network Endpoint
    /// Group resource using the fully-qualified URL, rather than a
    /// partial URL.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Reference to a RegionInstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupRef")]
    public V1beta2RegionBackendServiceSpecInitProviderBackendGroupRef? GroupRef { get; set; }

    /// <summary>Selector for a RegionInstanceGroupManager in compute to populate group.</summary>
    [JsonPropertyName("groupSelector")]
    public V1beta2RegionBackendServiceSpecInitProviderBackendGroupSelector? GroupSelector { get; set; }

    /// <summary>
    /// The max number of simultaneous connections for the group. Can
    /// be used with either CONNECTION or UTILIZATION balancing modes.
    /// Cannot be set for INTERNAL backend services.
    /// For CONNECTION mode, either maxConnections or one
    /// of maxConnectionsPerInstance or maxConnectionsPerEndpoint,
    /// as appropriate for group type, must be set.
    /// </summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single backend
    /// network endpoint can handle. Cannot be set
    /// for INTERNAL backend services.
    /// This is used to calculate the capacity of the group. Can be
    /// used in either CONNECTION or UTILIZATION balancing modes. For
    /// CONNECTION mode, either maxConnections or
    /// maxConnectionsPerEndpoint must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerEndpoint")]
    public double? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single
    /// backend instance can handle. Cannot be set for INTERNAL backend
    /// services.
    /// This is used to calculate the capacity of the group.
    /// Can be used in either CONNECTION or UTILIZATION balancing modes.
    /// For CONNECTION mode, either maxConnections or
    /// maxConnectionsPerInstance must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerInstance")]
    public double? MaxConnectionsPerInstance { get; set; }

    /// <summary>
    /// The max requests per second (RPS) of the group. Cannot be set
    /// for INTERNAL backend services.
    /// Can be used with either RATE or UTILIZATION balancing modes,
    /// but required if RATE mode. Either maxRate or one
    /// of maxRatePerInstance or maxRatePerEndpoint, as appropriate for
    /// group type, must be set.
    /// </summary>
    [JsonPropertyName("maxRate")]
    public double? MaxRate { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend network
    /// endpoint can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerEndpoint must be set. Cannot be set
    /// for INTERNAL backend services.
    /// </summary>
    [JsonPropertyName("maxRatePerEndpoint")]
    public double? MaxRatePerEndpoint { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend
    /// instance can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerInstance must be set. Cannot be set
    /// for INTERNAL backend services.
    /// </summary>
    [JsonPropertyName("maxRatePerInstance")]
    public double? MaxRatePerInstance { get; set; }

    /// <summary>
    /// Used when balancingMode is UTILIZATION. This ratio defines the
    /// CPU utilization target for the group. Valid range is [0.0, 1.0].
    /// Cannot be set for INTERNAL backend services.
    /// </summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }
}

/// <summary>
/// The CacheKeyPolicy for this CdnPolicy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderCdnPolicyCacheKeyPolicy
{
    /// <summary>If true requests to different hosts will be cached separately.</summary>
    [JsonPropertyName("includeHost")]
    public bool? IncludeHost { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderCdnPolicyNegativeCachingPolicy
{
    /// <summary>
    /// The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 308, 404, 405, 410, 421, 451 and 501
    /// can be specified as values, and you cannot specify a status code more than once.
    /// </summary>
    [JsonPropertyName("code")]
    public double? Code { get; set; }
}

/// <summary>
/// Cloud CDN configuration for this BackendService.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderCdnPolicy
{
    /// <summary>
    /// The CacheKeyPolicy for this CdnPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1beta2RegionBackendServiceSpecInitProviderCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

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
    public IList<V1beta2RegionBackendServiceSpecInitProviderCdnPolicyNegativeCachingPolicy>? NegativeCachingPolicy { get; set; }

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
/// is applicable only when the load_balancing_scheme is set to INTERNAL_MANAGED
/// and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderCircuitBreakers
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
/// Connection Tracking configuration for this BackendService.
/// This is available only for Layer 4 Internal Load Balancing and
/// Network Load Balancing.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderConnectionTrackingPolicy
{
    /// <summary>
    /// Specifies connection persistence when backends are unhealthy.
    /// If set to DEFAULT_FOR_PROTOCOL, the existing connections persist on
    /// unhealthy backends only for connection-oriented protocols (TCP and SCTP)
    /// and only if the Tracking Mode is PER_CONNECTION (default tracking mode)
    /// or the Session Affinity is configured for 5-tuple. They do not persist
    /// for UDP.
    /// If set to NEVER_PERSIST, after a backend becomes unhealthy, the existing
    /// connections on the unhealthy backend are never persisted on the unhealthy
    /// backend. They are always diverted to newly selected healthy backends
    /// (unless all backends are unhealthy).
    /// If set to ALWAYS_PERSIST, existing connections always persist on
    /// unhealthy backends regardless of protocol and session affinity. It is
    /// generally not recommended to use this mode overriding the default.
    /// Default value is DEFAULT_FOR_PROTOCOL.
    /// Possible values are: DEFAULT_FOR_PROTOCOL, NEVER_PERSIST, ALWAYS_PERSIST.
    /// </summary>
    [JsonPropertyName("connectionPersistenceOnUnhealthyBackends")]
    public string? ConnectionPersistenceOnUnhealthyBackends { get; set; }

    /// <summary>Enable Strong Session Affinity for Network Load Balancing. This option is not available publicly.</summary>
    [JsonPropertyName("enableStrongAffinity")]
    public bool? EnableStrongAffinity { get; set; }

    /// <summary>
    /// Specifies how long to keep a Connection Tracking entry while there is
    /// no matching traffic (in seconds).
    /// For L4 ILB the minimum(default) is 10 minutes and maximum is 16 hours.
    /// For NLB the minimum(default) is 60 seconds and the maximum is 16 hours.
    /// </summary>
    [JsonPropertyName("idleTimeoutSec")]
    public double? IdleTimeoutSec { get; set; }

    /// <summary>
    /// Specifies the key used for connection tracking. There are two options:
    /// PER_CONNECTION: The Connection Tracking is performed as per the
    /// Connection Key (default Hash Method) for the specific protocol.
    /// PER_SESSION: The Connection Tracking is performed as per the
    /// configured Session Affinity. It matches the configured Session Affinity.
    /// Default value is PER_CONNECTION.
    /// Possible values are: PER_CONNECTION, PER_SESSION.
    /// </summary>
    [JsonPropertyName("trackingMode")]
    public string? TrackingMode { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderConsistentHashHttpCookieTtl
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderConsistentHashHttpCookie
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
    public V1beta2RegionBackendServiceSpecInitProviderConsistentHashHttpCookieTtl? Ttl { get; set; }
}

/// <summary>
/// Consistent Hash-based load balancing can be used to provide soft session
/// affinity based on HTTP headers, cookies or other properties. This load balancing
/// policy is applicable only for HTTP connections. The affinity to a particular
/// destination host will be lost when one or more hosts are added/removed from the
/// destination service. This field specifies parameters that control consistent
/// hashing.
/// This field only applies when all of the following are true -
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderConsistentHash
{
    /// <summary>
    /// Hash is based on HTTP Cookie. This field describes a HTTP cookie
    /// that will be used as the hash key for the consistent hash load
    /// balancer. If the cookie is not present, it will be generated.
    /// This field is applicable if the sessionAffinity is set to HTTP_COOKIE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpCookie")]
    public V1beta2RegionBackendServiceSpecInitProviderConsistentHashHttpCookie? HttpCookie { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderCustomMetrics
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
/// Policy for failovers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderFailoverPolicy
{
    /// <summary>
    /// On failover or failback, this field indicates whether connection drain
    /// will be honored. Setting this to true has the following effect: connections
    /// to the old active pool are not drained. Connections to the new active pool
    /// use the timeout of 10 min (currently fixed). Setting to false has the
    /// following effect: both old and new connections will have a drain timeout
    /// of 10 min.
    /// This can be set to true only if the protocol is TCP.
    /// The default is false.
    /// </summary>
    [JsonPropertyName("disableConnectionDrainOnFailover")]
    public bool? DisableConnectionDrainOnFailover { get; set; }

    /// <summary>
    /// This option is used only when no healthy VMs are detected in the primary
    /// and backup instance groups. When set to true, traffic is dropped. When
    /// set to false, new connections are sent across all VMs in the primary group.
    /// The default is false.
    /// </summary>
    [JsonPropertyName("dropTrafficIfUnhealthy")]
    public bool? DropTrafficIfUnhealthy { get; set; }

    /// <summary>
    /// The value of the field must be in [0, 1]. If the ratio of the healthy
    /// VMs in the primary backend is at or below this number, traffic arriving
    /// at the load-balanced IP will be directed to the failover backend.
    /// In case where &apos;failoverRatio&apos; is not set or all the VMs in the backup
    /// backend are unhealthy, the traffic will be directed back to the primary
    /// backend in the &quot;force&quot; mode, where traffic will be spread to the healthy
    /// VMs with the best effort, or to all VMs when no VM is healthy.
    /// This field is only used with l4 load balancing.
    /// </summary>
    [JsonPropertyName("failoverRatio")]
    public double? FailoverRatio { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupRefPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupRefPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkEndpointGroup in compute to populate backendGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupSelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkEndpointGroup in compute to populate backendGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupSelector
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
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in compute to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in compute to populate instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceSelector
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
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The network endpoint within the leader.backendGroup that is designated as the leader.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpoint
{
    /// <summary>
    /// The name of the VM instance of the leader network endpoint. The instance must
    /// already be attached to the NEG specified in the haPolicy.leader.backendGroup.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>Reference to a Instance in compute to populate instance.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceRef? InstanceRef { get; set; }

    /// <summary>Selector for a Instance in compute to populate instance.</summary>
    [JsonPropertyName("instanceSelector")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpointInstanceSelector? InstanceSelector { get; set; }
}

/// <summary>
/// Selects one of the network endpoints attached to the backend NEGs of this service as the
/// active endpoint (the leader) that receives all traffic.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeader
{
    /// <summary>
    /// A fully-qualified URL of the zonal Network Endpoint Group (NEG) that the leader is
    /// attached to.
    /// </summary>
    [JsonPropertyName("backendGroup")]
    public string? BackendGroup { get; set; }

    /// <summary>Reference to a NetworkEndpointGroup in compute to populate backendGroup.</summary>
    [JsonPropertyName("backendGroupRef")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupRef? BackendGroupRef { get; set; }

    /// <summary>Selector for a NetworkEndpointGroup in compute to populate backendGroup.</summary>
    [JsonPropertyName("backendGroupSelector")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderBackendGroupSelector? BackendGroupSelector { get; set; }

    /// <summary>
    /// The network endpoint within the leader.backendGroup that is designated as the leader.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkEndpoint")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeaderNetworkEndpoint? NetworkEndpoint { get; set; }
}

/// <summary>
/// Configures self-managed High Availability (HA) for External and Internal Protocol Forwarding.
/// The backends of this regional backend service must only specify zonal network endpoint groups
/// (NEGs) of type GCE_VM_IP. Note that haPolicy is not for load balancing, and therefore cannot
/// be specified with sessionAffinity, connectionTrackingPolicy, and failoverPolicy. haPolicy
/// requires customers to be responsible for tracking backend endpoint health and electing a
/// leader among the healthy endpoints. Therefore, haPolicy cannot be specified with healthChecks.
/// haPolicy can only be specified for External Passthrough Network Load Balancers and Internal
/// Passthrough Network Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHaPolicy
{
    /// <summary>
    /// Specifies whether fast IP move is enabled, and if so, the mechanism to achieve it.
    /// Supported values are:
    /// </summary>
    [JsonPropertyName("fastIpMove")]
    public string? FastIpMove { get; set; }

    /// <summary>
    /// Selects one of the network endpoints attached to the backend NEGs of this service as the
    /// active endpoint (the leader) that receives all traffic.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("leader")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicyLeader? Leader { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHealthChecksRefsPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHealthChecksRefsPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHealthChecksRefsPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHealthChecksRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHealthChecksRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderHealthChecksRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderHealthChecksRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHealthChecksRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecInitProviderHealthChecksRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHealthChecksSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHealthChecksSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderHealthChecksSelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderHealthChecksSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHealthChecksSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderHealthChecksSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderHealthChecksSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of RegionHealthCheck in compute to populate healthChecks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderHealthChecksSelector
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
    public V1beta2RegionBackendServiceSpecInitProviderHealthChecksSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// OAuth2 Client Secret for IAP
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderIapOauth2ClientSecretSecretRef
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
/// If OAuth client is not set, Google-managed OAuth client is used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderIap
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
    public V1beta2RegionBackendServiceSpecInitProviderIapOauth2ClientSecretSecretRef? Oauth2ClientSecretSecretRef { get; set; }
}

/// <summary>
/// This field denotes the logging options for the load balancer traffic served by this backend service.
/// If logging is enabled, logs will be exported to Stackdriver.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderLogConfig
{
    /// <summary>Whether to enable logging for the load balancer traffic served by this backend service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Specifies the fields to include in logging. This field can only be specified if logging is enabled for this backend service.</summary>
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
/// When configured, new connections are load balanced across healthy backend endpoints in the local zone.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderNetworkPassThroughLbTrafficPolicyZonalAffinity
{
    /// <summary>
    /// This field indicates whether zonal affinity is enabled or not.
    /// Default value is ZONAL_AFFINITY_DISABLED.
    /// Possible values are: ZONAL_AFFINITY_DISABLED, ZONAL_AFFINITY_SPILL_CROSS_ZONE, ZONAL_AFFINITY_STAY_WITHIN_ZONE.
    /// </summary>
    [JsonPropertyName("spillover")]
    public string? Spillover { get; set; }

    /// <summary>
    /// The value of the field must be in [0, 1]. When the ratio of the count of healthy backend endpoints in a zone
    /// to the count of backend endpoints in that same zone is equal to or above this threshold, the load balancer
    /// distributes new connections to all healthy endpoints in the local zone only. When the ratio of the count
    /// of healthy backend endpoints in a zone to the count of backend endpoints in that same zone is below this
    /// threshold, the load balancer distributes all new connections to all healthy endpoints across all zones.
    /// </summary>
    [JsonPropertyName("spilloverRatio")]
    public double? SpilloverRatio { get; set; }
}

/// <summary>
/// Configures traffic steering properties of internal passthrough Network Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderNetworkPassThroughLbTrafficPolicy
{
    /// <summary>
    /// When configured, new connections are load balanced across healthy backend endpoints in the local zone.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("zonalAffinity")]
    public V1beta2RegionBackendServiceSpecInitProviderNetworkPassThroughLbTrafficPolicyZonalAffinity? ZonalAffinity { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderNetworkRefPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderNetworkRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderNetworkRefPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecInitProviderNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderNetworkSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderNetworkSelector
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
    public V1beta2RegionBackendServiceSpecInitProviderNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The base time that a host is ejected for. The real time is equal to the base
/// time multiplied by the number of times the host has been ejected. Defaults to
/// 30000ms or 30s.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderOutlierDetectionBaseEjectionTime
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderOutlierDetectionInterval
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
/// This field is applicable only when the load_balancing_scheme is set
/// to INTERNAL_MANAGED and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderOutlierDetection
{
    /// <summary>
    /// The base time that a host is ejected for. The real time is equal to the base
    /// time multiplied by the number of times the host has been ejected. Defaults to
    /// 30000ms or 30s.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseEjectionTime")]
    public V1beta2RegionBackendServiceSpecInitProviderOutlierDetectionBaseEjectionTime? BaseEjectionTime { get; set; }

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
    public V1beta2RegionBackendServiceSpecInitProviderOutlierDetectionInterval? Interval { get; set; }

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
/// Additional params passed with the request, but not persisted as part of resource payload
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderParams
{
    /// <summary>
    /// Resource manager tags to be bound to the region backend service. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderSecurityPolicyRefPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderSecurityPolicyRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderSecurityPolicyRefPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderSecurityPolicyRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderSecurityPolicyRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderSecurityPolicyRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderSecurityPolicyRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionSecurityPolicy in compute to populate securityPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderSecurityPolicyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecInitProviderSecurityPolicyRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderSecurityPolicySelectorPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderSecurityPolicySelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecInitProviderSecurityPolicySelectorPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecInitProviderSecurityPolicySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderSecurityPolicySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecInitProviderSecurityPolicySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecInitProviderSecurityPolicySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionSecurityPolicy in compute to populate securityPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderSecurityPolicySelector
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
    public V1beta2RegionBackendServiceSpecInitProviderSecurityPolicySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderStrongSessionAffinityCookieTtl
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderStrongSessionAffinityCookie
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
    public V1beta2RegionBackendServiceSpecInitProviderStrongSessionAffinityCookieTtl? Ttl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderTlsSettingsSubjectAltNames
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProviderTlsSettings
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
    public IList<V1beta2RegionBackendServiceSpecInitProviderTlsSettingsSubjectAltNames>? SubjectAltNames { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecInitProvider
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
    /// The set of backends that serve this RegionBackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("backend")]
    public IList<V1beta2RegionBackendServiceSpecInitProviderBackend>? Backend { get; set; }

    /// <summary>
    /// Cloud CDN configuration for this BackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cdnPolicy")]
    public V1beta2RegionBackendServiceSpecInitProviderCdnPolicy? CdnPolicy { get; set; }

    /// <summary>
    /// Settings controlling the volume of connections to a backend service. This field
    /// is applicable only when the load_balancing_scheme is set to INTERNAL_MANAGED
    /// and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("circuitBreakers")]
    public V1beta2RegionBackendServiceSpecInitProviderCircuitBreakers? CircuitBreakers { get; set; }

    /// <summary>
    /// Time for which instance will be drained (not accept new
    /// connections, but still work to finish started).
    /// </summary>
    [JsonPropertyName("connectionDrainingTimeoutSec")]
    public double? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>
    /// Connection Tracking configuration for this BackendService.
    /// This is available only for Layer 4 Internal Load Balancing and
    /// Network Load Balancing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("connectionTrackingPolicy")]
    public V1beta2RegionBackendServiceSpecInitProviderConnectionTrackingPolicy? ConnectionTrackingPolicy { get; set; }

    /// <summary>
    /// Consistent Hash-based load balancing can be used to provide soft session
    /// affinity based on HTTP headers, cookies or other properties. This load balancing
    /// policy is applicable only for HTTP connections. The affinity to a particular
    /// destination host will be lost when one or more hosts are added/removed from the
    /// destination service. This field specifies parameters that control consistent
    /// hashing.
    /// This field only applies when all of the following are true -
    /// </summary>
    [JsonPropertyName("consistentHash")]
    public V1beta2RegionBackendServiceSpecInitProviderConsistentHash? ConsistentHash { get; set; }

    /// <summary>
    /// List of custom metrics that are used for the WEIGHTED_ROUND_ROBIN locality_lb_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2RegionBackendServiceSpecInitProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, enable Cloud CDN for this RegionBackendService.</summary>
    [JsonPropertyName("enableCdn")]
    public bool? EnableCdn { get; set; }

    /// <summary>
    /// Policy for failovers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("failoverPolicy")]
    public V1beta2RegionBackendServiceSpecInitProviderFailoverPolicy? FailoverPolicy { get; set; }

    /// <summary>
    /// Configures self-managed High Availability (HA) for External and Internal Protocol Forwarding.
    /// The backends of this regional backend service must only specify zonal network endpoint groups
    /// (NEGs) of type GCE_VM_IP. Note that haPolicy is not for load balancing, and therefore cannot
    /// be specified with sessionAffinity, connectionTrackingPolicy, and failoverPolicy. haPolicy
    /// requires customers to be responsible for tracking backend endpoint health and electing a
    /// leader among the healthy endpoints. Therefore, haPolicy cannot be specified with healthChecks.
    /// haPolicy can only be specified for External Passthrough Network Load Balancers and Internal
    /// Passthrough Network Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("haPolicy")]
    public V1beta2RegionBackendServiceSpecInitProviderHaPolicy? HaPolicy { get; set; }

    /// <summary>
    /// The set of URLs to HealthCheck resources for health checking
    /// this RegionBackendService. Currently at most one health
    /// check can be specified.
    /// A health check must be specified unless the backend service uses an internet
    /// or serverless NEG as a backend.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public IList<string>? HealthChecks { get; set; }

    /// <summary>References to RegionHealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksRefs")]
    public IList<V1beta2RegionBackendServiceSpecInitProviderHealthChecksRefs>? HealthChecksRefs { get; set; }

    /// <summary>Selector for a list of RegionHealthCheck in compute to populate healthChecks.</summary>
    [JsonPropertyName("healthChecksSelector")]
    public V1beta2RegionBackendServiceSpecInitProviderHealthChecksSelector? HealthChecksSelector { get; set; }

    /// <summary>
    /// Settings for enabling Cloud Identity Aware Proxy.
    /// If OAuth client is not set, Google-managed OAuth client is used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("iap")]
    public V1beta2RegionBackendServiceSpecInitProviderIap? Iap { get; set; }

    /// <summary>
    /// Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC).
    /// Possible values are: IPV4_ONLY, PREFER_IPV6, IPV6_ONLY.
    /// </summary>
    [JsonPropertyName("ipAddressSelectionPolicy")]
    public string? IpAddressSelectionPolicy { get; set; }

    /// <summary>is set to INTERNAL_MANAGED</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>
    /// is set to MAGLEV or RING_HASH
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localityLbPolicy")]
    public string? LocalityLbPolicy { get; set; }

    /// <summary>
    /// This field denotes the logging options for the load balancer traffic served by this backend service.
    /// If logging is enabled, logs will be exported to Stackdriver.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2RegionBackendServiceSpecInitProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// The URL of the network to which this backend service belongs.
    /// This field must be set for Internal Passthrough Network Load Balancers when the haPolicy is enabled, and for External Passthrough Network Load Balancers when the haPolicy fastIpMove is enabled.
    /// This field can only be specified when the load balancing scheme is set to INTERNAL, or when the load balancing scheme is set to EXTERNAL and haPolicy fastIpMove is enabled.
    /// Changes to this field force recreation of the resource.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// Configures traffic steering properties of internal passthrough Network Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkPassThroughLbTrafficPolicy")]
    public V1beta2RegionBackendServiceSpecInitProviderNetworkPassThroughLbTrafficPolicy? NetworkPassThroughLbTrafficPolicy { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta2RegionBackendServiceSpecInitProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta2RegionBackendServiceSpecInitProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>
    /// Settings controlling eviction of unhealthy hosts from the load balancing pool.
    /// This field is applicable only when the load_balancing_scheme is set
    /// to INTERNAL_MANAGED and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta2RegionBackendServiceSpecInitProviderOutlierDetection? OutlierDetection { get; set; }

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("params")]
    public V1beta2RegionBackendServiceSpecInitProviderParams? Params { get; set; }

    /// <summary>
    /// A named port on a backend instance group representing the port for
    /// communication to the backend VMs in that group. Required when the
    /// loadBalancingScheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED, or INTERNAL_SELF_MANAGED
    /// and the backends are instance groups. The named port must be defined on each
    /// backend instance group. This parameter has no meaning if the backends are NEGs. API sets a
    /// default of &quot;http&quot; if not given.
    /// Must be omitted when the loadBalancingScheme is INTERNAL (Internal TCP/UDP Load Balancing).
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>is set to HTTP, HTTPS, HTTP2 or H2C</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>Reference to a RegionSecurityPolicy in compute to populate securityPolicy.</summary>
    [JsonPropertyName("securityPolicyRef")]
    public V1beta2RegionBackendServiceSpecInitProviderSecurityPolicyRef? SecurityPolicyRef { get; set; }

    /// <summary>Selector for a RegionSecurityPolicy in compute to populate securityPolicy.</summary>
    [JsonPropertyName("securityPolicySelector")]
    public V1beta2RegionBackendServiceSpecInitProviderSecurityPolicySelector? SecurityPolicySelector { get; set; }

    /// <summary>
    /// Type of session affinity to use. The default is NONE. Session affinity is
    /// not applicable if the protocol is UDP.
    /// Possible values are: NONE, CLIENT_IP, CLIENT_IP_PORT_PROTO, CLIENT_IP_PROTO, GENERATED_COOKIE, HEADER_FIELD, HTTP_COOKIE, CLIENT_IP_NO_DESTINATION, STRONG_COOKIE_AFFINITY.
    /// </summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>
    /// Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("strongSessionAffinityCookie")]
    public V1beta2RegionBackendServiceSpecInitProviderStrongSessionAffinityCookie? StrongSessionAffinityCookie { get; set; }

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
    public V1beta2RegionBackendServiceSpecInitProviderTlsSettings? TlsSettings { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecManagementPoliciesEnum>))]
public enum V1beta2RegionBackendServiceSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RegionBackendServiceSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionBackendServiceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RegionBackendServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionBackendServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionBackendServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionBackendServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RegionBackendServiceSpec defines the desired state of RegionBackendService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceSpec
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
    public V1beta2RegionBackendServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RegionBackendServiceSpecForProvider ForProvider { get; set; }

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
    public V1beta2RegionBackendServiceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RegionBackendServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RegionBackendServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RegionBackendServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderBackendCustomMetrics
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderBackend
{
    /// <summary>
    /// Specifies the balancing mode for this backend.
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
    /// ~&gt;NOTE: This field cannot be set for
    /// INTERNAL region backend services (default loadBalancingScheme),
    /// but is required for non-INTERNAL backend service. The total
    /// capacity_scaler for all backends must be non-zero.
    /// A setting of 0 means the group is completely drained, offering
    /// 0% of its available Capacity. Valid range is [0.0,1.0].
    /// </summary>
    [JsonPropertyName("capacityScaler")]
    public double? CapacityScaler { get; set; }

    /// <summary>
    /// The set of custom metrics that are used for CUSTOM_METRICS BalancingMode.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2RegionBackendServiceStatusAtProviderBackendCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// Provide this property when you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// This field designates whether this is a failover backend. More
    /// than one failover backend can be configured for a given RegionBackendService.
    /// </summary>
    [JsonPropertyName("failover")]
    public bool? Failover { get; set; }

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
    /// When the load_balancing_scheme is INTERNAL, only instance groups
    /// are supported.
    /// Note that you must specify an Instance Group or Network Endpoint
    /// Group resource using the fully-qualified URL, rather than a
    /// partial URL.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>
    /// The max number of simultaneous connections for the group. Can
    /// be used with either CONNECTION or UTILIZATION balancing modes.
    /// Cannot be set for INTERNAL backend services.
    /// For CONNECTION mode, either maxConnections or one
    /// of maxConnectionsPerInstance or maxConnectionsPerEndpoint,
    /// as appropriate for group type, must be set.
    /// </summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single backend
    /// network endpoint can handle. Cannot be set
    /// for INTERNAL backend services.
    /// This is used to calculate the capacity of the group. Can be
    /// used in either CONNECTION or UTILIZATION balancing modes. For
    /// CONNECTION mode, either maxConnections or
    /// maxConnectionsPerEndpoint must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerEndpoint")]
    public double? MaxConnectionsPerEndpoint { get; set; }

    /// <summary>
    /// The max number of simultaneous connections that a single
    /// backend instance can handle. Cannot be set for INTERNAL backend
    /// services.
    /// This is used to calculate the capacity of the group.
    /// Can be used in either CONNECTION or UTILIZATION balancing modes.
    /// For CONNECTION mode, either maxConnections or
    /// maxConnectionsPerInstance must be set.
    /// </summary>
    [JsonPropertyName("maxConnectionsPerInstance")]
    public double? MaxConnectionsPerInstance { get; set; }

    /// <summary>
    /// The max requests per second (RPS) of the group. Cannot be set
    /// for INTERNAL backend services.
    /// Can be used with either RATE or UTILIZATION balancing modes,
    /// but required if RATE mode. Either maxRate or one
    /// of maxRatePerInstance or maxRatePerEndpoint, as appropriate for
    /// group type, must be set.
    /// </summary>
    [JsonPropertyName("maxRate")]
    public double? MaxRate { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend network
    /// endpoint can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerEndpoint must be set. Cannot be set
    /// for INTERNAL backend services.
    /// </summary>
    [JsonPropertyName("maxRatePerEndpoint")]
    public double? MaxRatePerEndpoint { get; set; }

    /// <summary>
    /// The max requests per second (RPS) that a single backend
    /// instance can handle. This is used to calculate the capacity of
    /// the group. Can be used in either balancing mode. For RATE mode,
    /// either maxRate or maxRatePerInstance must be set. Cannot be set
    /// for INTERNAL backend services.
    /// </summary>
    [JsonPropertyName("maxRatePerInstance")]
    public double? MaxRatePerInstance { get; set; }

    /// <summary>
    /// Used when balancingMode is UTILIZATION. This ratio defines the
    /// CPU utilization target for the group. Valid range is [0.0, 1.0].
    /// Cannot be set for INTERNAL backend services.
    /// </summary>
    [JsonPropertyName("maxUtilization")]
    public double? MaxUtilization { get; set; }
}

/// <summary>
/// The CacheKeyPolicy for this CdnPolicy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderCdnPolicyCacheKeyPolicy
{
    /// <summary>If true requests to different hosts will be cached separately.</summary>
    [JsonPropertyName("includeHost")]
    public bool? IncludeHost { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderCdnPolicyNegativeCachingPolicy
{
    /// <summary>
    /// The HTTP status code to define a TTL against. Only HTTP status codes 300, 301, 308, 404, 405, 410, 421, 451 and 501
    /// can be specified as values, and you cannot specify a status code more than once.
    /// </summary>
    [JsonPropertyName("code")]
    public double? Code { get; set; }
}

/// <summary>
/// Cloud CDN configuration for this BackendService.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderCdnPolicy
{
    /// <summary>
    /// The CacheKeyPolicy for this CdnPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cacheKeyPolicy")]
    public V1beta2RegionBackendServiceStatusAtProviderCdnPolicyCacheKeyPolicy? CacheKeyPolicy { get; set; }

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
    public IList<V1beta2RegionBackendServiceStatusAtProviderCdnPolicyNegativeCachingPolicy>? NegativeCachingPolicy { get; set; }

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
/// is applicable only when the load_balancing_scheme is set to INTERNAL_MANAGED
/// and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderCircuitBreakers
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
/// Connection Tracking configuration for this BackendService.
/// This is available only for Layer 4 Internal Load Balancing and
/// Network Load Balancing.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderConnectionTrackingPolicy
{
    /// <summary>
    /// Specifies connection persistence when backends are unhealthy.
    /// If set to DEFAULT_FOR_PROTOCOL, the existing connections persist on
    /// unhealthy backends only for connection-oriented protocols (TCP and SCTP)
    /// and only if the Tracking Mode is PER_CONNECTION (default tracking mode)
    /// or the Session Affinity is configured for 5-tuple. They do not persist
    /// for UDP.
    /// If set to NEVER_PERSIST, after a backend becomes unhealthy, the existing
    /// connections on the unhealthy backend are never persisted on the unhealthy
    /// backend. They are always diverted to newly selected healthy backends
    /// (unless all backends are unhealthy).
    /// If set to ALWAYS_PERSIST, existing connections always persist on
    /// unhealthy backends regardless of protocol and session affinity. It is
    /// generally not recommended to use this mode overriding the default.
    /// Default value is DEFAULT_FOR_PROTOCOL.
    /// Possible values are: DEFAULT_FOR_PROTOCOL, NEVER_PERSIST, ALWAYS_PERSIST.
    /// </summary>
    [JsonPropertyName("connectionPersistenceOnUnhealthyBackends")]
    public string? ConnectionPersistenceOnUnhealthyBackends { get; set; }

    /// <summary>Enable Strong Session Affinity for Network Load Balancing. This option is not available publicly.</summary>
    [JsonPropertyName("enableStrongAffinity")]
    public bool? EnableStrongAffinity { get; set; }

    /// <summary>
    /// Specifies how long to keep a Connection Tracking entry while there is
    /// no matching traffic (in seconds).
    /// For L4 ILB the minimum(default) is 10 minutes and maximum is 16 hours.
    /// For NLB the minimum(default) is 60 seconds and the maximum is 16 hours.
    /// </summary>
    [JsonPropertyName("idleTimeoutSec")]
    public double? IdleTimeoutSec { get; set; }

    /// <summary>
    /// Specifies the key used for connection tracking. There are two options:
    /// PER_CONNECTION: The Connection Tracking is performed as per the
    /// Connection Key (default Hash Method) for the specific protocol.
    /// PER_SESSION: The Connection Tracking is performed as per the
    /// configured Session Affinity. It matches the configured Session Affinity.
    /// Default value is PER_CONNECTION.
    /// Possible values are: PER_CONNECTION, PER_SESSION.
    /// </summary>
    [JsonPropertyName("trackingMode")]
    public string? TrackingMode { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderConsistentHashHttpCookieTtl
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderConsistentHashHttpCookie
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
    public V1beta2RegionBackendServiceStatusAtProviderConsistentHashHttpCookieTtl? Ttl { get; set; }
}

/// <summary>
/// Consistent Hash-based load balancing can be used to provide soft session
/// affinity based on HTTP headers, cookies or other properties. This load balancing
/// policy is applicable only for HTTP connections. The affinity to a particular
/// destination host will be lost when one or more hosts are added/removed from the
/// destination service. This field specifies parameters that control consistent
/// hashing.
/// This field only applies when all of the following are true -
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderConsistentHash
{
    /// <summary>
    /// Hash is based on HTTP Cookie. This field describes a HTTP cookie
    /// that will be used as the hash key for the consistent hash load
    /// balancer. If the cookie is not present, it will be generated.
    /// This field is applicable if the sessionAffinity is set to HTTP_COOKIE.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("httpCookie")]
    public V1beta2RegionBackendServiceStatusAtProviderConsistentHashHttpCookie? HttpCookie { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderCustomMetrics
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
/// Policy for failovers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderFailoverPolicy
{
    /// <summary>
    /// On failover or failback, this field indicates whether connection drain
    /// will be honored. Setting this to true has the following effect: connections
    /// to the old active pool are not drained. Connections to the new active pool
    /// use the timeout of 10 min (currently fixed). Setting to false has the
    /// following effect: both old and new connections will have a drain timeout
    /// of 10 min.
    /// This can be set to true only if the protocol is TCP.
    /// The default is false.
    /// </summary>
    [JsonPropertyName("disableConnectionDrainOnFailover")]
    public bool? DisableConnectionDrainOnFailover { get; set; }

    /// <summary>
    /// This option is used only when no healthy VMs are detected in the primary
    /// and backup instance groups. When set to true, traffic is dropped. When
    /// set to false, new connections are sent across all VMs in the primary group.
    /// The default is false.
    /// </summary>
    [JsonPropertyName("dropTrafficIfUnhealthy")]
    public bool? DropTrafficIfUnhealthy { get; set; }

    /// <summary>
    /// The value of the field must be in [0, 1]. If the ratio of the healthy
    /// VMs in the primary backend is at or below this number, traffic arriving
    /// at the load-balanced IP will be directed to the failover backend.
    /// In case where &apos;failoverRatio&apos; is not set or all the VMs in the backup
    /// backend are unhealthy, the traffic will be directed back to the primary
    /// backend in the &quot;force&quot; mode, where traffic will be spread to the healthy
    /// VMs with the best effort, or to all VMs when no VM is healthy.
    /// This field is only used with l4 load balancing.
    /// </summary>
    [JsonPropertyName("failoverRatio")]
    public double? FailoverRatio { get; set; }
}

/// <summary>
/// The network endpoint within the leader.backendGroup that is designated as the leader.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderHaPolicyLeaderNetworkEndpoint
{
    /// <summary>
    /// The name of the VM instance of the leader network endpoint. The instance must
    /// already be attached to the NEG specified in the haPolicy.leader.backendGroup.
    /// </summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }
}

/// <summary>
/// Selects one of the network endpoints attached to the backend NEGs of this service as the
/// active endpoint (the leader) that receives all traffic.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderHaPolicyLeader
{
    /// <summary>
    /// A fully-qualified URL of the zonal Network Endpoint Group (NEG) that the leader is
    /// attached to.
    /// </summary>
    [JsonPropertyName("backendGroup")]
    public string? BackendGroup { get; set; }

    /// <summary>
    /// The network endpoint within the leader.backendGroup that is designated as the leader.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkEndpoint")]
    public V1beta2RegionBackendServiceStatusAtProviderHaPolicyLeaderNetworkEndpoint? NetworkEndpoint { get; set; }
}

/// <summary>
/// Configures self-managed High Availability (HA) for External and Internal Protocol Forwarding.
/// The backends of this regional backend service must only specify zonal network endpoint groups
/// (NEGs) of type GCE_VM_IP. Note that haPolicy is not for load balancing, and therefore cannot
/// be specified with sessionAffinity, connectionTrackingPolicy, and failoverPolicy. haPolicy
/// requires customers to be responsible for tracking backend endpoint health and electing a
/// leader among the healthy endpoints. Therefore, haPolicy cannot be specified with healthChecks.
/// haPolicy can only be specified for External Passthrough Network Load Balancers and Internal
/// Passthrough Network Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderHaPolicy
{
    /// <summary>
    /// Specifies whether fast IP move is enabled, and if so, the mechanism to achieve it.
    /// Supported values are:
    /// </summary>
    [JsonPropertyName("fastIpMove")]
    public string? FastIpMove { get; set; }

    /// <summary>
    /// Selects one of the network endpoints attached to the backend NEGs of this service as the
    /// active endpoint (the leader) that receives all traffic.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("leader")]
    public V1beta2RegionBackendServiceStatusAtProviderHaPolicyLeader? Leader { get; set; }
}

/// <summary>
/// Settings for enabling Cloud Identity Aware Proxy.
/// If OAuth client is not set, Google-managed OAuth client is used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderIap
{
    /// <summary>Whether the serving infrastructure will authenticate and authorize all incoming requests.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>OAuth2 Client ID for IAP</summary>
    [JsonPropertyName("oauth2ClientId")]
    public string? Oauth2ClientId { get; set; }
}

/// <summary>
/// This field denotes the logging options for the load balancer traffic served by this backend service.
/// If logging is enabled, logs will be exported to Stackdriver.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderLogConfig
{
    /// <summary>Whether to enable logging for the load balancer traffic served by this backend service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Specifies the fields to include in logging. This field can only be specified if logging is enabled for this backend service.</summary>
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
/// When configured, new connections are load balanced across healthy backend endpoints in the local zone.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderNetworkPassThroughLbTrafficPolicyZonalAffinity
{
    /// <summary>
    /// This field indicates whether zonal affinity is enabled or not.
    /// Default value is ZONAL_AFFINITY_DISABLED.
    /// Possible values are: ZONAL_AFFINITY_DISABLED, ZONAL_AFFINITY_SPILL_CROSS_ZONE, ZONAL_AFFINITY_STAY_WITHIN_ZONE.
    /// </summary>
    [JsonPropertyName("spillover")]
    public string? Spillover { get; set; }

    /// <summary>
    /// The value of the field must be in [0, 1]. When the ratio of the count of healthy backend endpoints in a zone
    /// to the count of backend endpoints in that same zone is equal to or above this threshold, the load balancer
    /// distributes new connections to all healthy endpoints in the local zone only. When the ratio of the count
    /// of healthy backend endpoints in a zone to the count of backend endpoints in that same zone is below this
    /// threshold, the load balancer distributes all new connections to all healthy endpoints across all zones.
    /// </summary>
    [JsonPropertyName("spilloverRatio")]
    public double? SpilloverRatio { get; set; }
}

/// <summary>
/// Configures traffic steering properties of internal passthrough Network Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderNetworkPassThroughLbTrafficPolicy
{
    /// <summary>
    /// When configured, new connections are load balanced across healthy backend endpoints in the local zone.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("zonalAffinity")]
    public V1beta2RegionBackendServiceStatusAtProviderNetworkPassThroughLbTrafficPolicyZonalAffinity? ZonalAffinity { get; set; }
}

/// <summary>
/// The base time that a host is ejected for. The real time is equal to the base
/// time multiplied by the number of times the host has been ejected. Defaults to
/// 30000ms or 30s.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderOutlierDetectionBaseEjectionTime
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderOutlierDetectionInterval
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
/// This field is applicable only when the load_balancing_scheme is set
/// to INTERNAL_MANAGED and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderOutlierDetection
{
    /// <summary>
    /// The base time that a host is ejected for. The real time is equal to the base
    /// time multiplied by the number of times the host has been ejected. Defaults to
    /// 30000ms or 30s.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseEjectionTime")]
    public V1beta2RegionBackendServiceStatusAtProviderOutlierDetectionBaseEjectionTime? BaseEjectionTime { get; set; }

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
    public V1beta2RegionBackendServiceStatusAtProviderOutlierDetectionInterval? Interval { get; set; }

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
/// Additional params passed with the request, but not persisted as part of resource payload
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderParams
{
    /// <summary>
    /// Resource manager tags to be bound to the region backend service. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
}

/// <summary>
/// Lifetime of the cookie.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderStrongSessionAffinityCookieTtl
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderStrongSessionAffinityCookie
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
    public V1beta2RegionBackendServiceStatusAtProviderStrongSessionAffinityCookieTtl? Ttl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderTlsSettingsSubjectAltNames
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProviderTlsSettings
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
    public IList<V1beta2RegionBackendServiceStatusAtProviderTlsSettingsSubjectAltNames>? SubjectAltNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusAtProvider
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
    /// The set of backends that serve this RegionBackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("backend")]
    public IList<V1beta2RegionBackendServiceStatusAtProviderBackend>? Backend { get; set; }

    /// <summary>
    /// Cloud CDN configuration for this BackendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cdnPolicy")]
    public V1beta2RegionBackendServiceStatusAtProviderCdnPolicy? CdnPolicy { get; set; }

    /// <summary>
    /// Settings controlling the volume of connections to a backend service. This field
    /// is applicable only when the load_balancing_scheme is set to INTERNAL_MANAGED
    /// and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("circuitBreakers")]
    public V1beta2RegionBackendServiceStatusAtProviderCircuitBreakers? CircuitBreakers { get; set; }

    /// <summary>
    /// Time for which instance will be drained (not accept new
    /// connections, but still work to finish started).
    /// </summary>
    [JsonPropertyName("connectionDrainingTimeoutSec")]
    public double? ConnectionDrainingTimeoutSec { get; set; }

    /// <summary>
    /// Connection Tracking configuration for this BackendService.
    /// This is available only for Layer 4 Internal Load Balancing and
    /// Network Load Balancing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("connectionTrackingPolicy")]
    public V1beta2RegionBackendServiceStatusAtProviderConnectionTrackingPolicy? ConnectionTrackingPolicy { get; set; }

    /// <summary>
    /// Consistent Hash-based load balancing can be used to provide soft session
    /// affinity based on HTTP headers, cookies or other properties. This load balancing
    /// policy is applicable only for HTTP connections. The affinity to a particular
    /// destination host will be lost when one or more hosts are added/removed from the
    /// destination service. This field specifies parameters that control consistent
    /// hashing.
    /// This field only applies when all of the following are true -
    /// </summary>
    [JsonPropertyName("consistentHash")]
    public V1beta2RegionBackendServiceStatusAtProviderConsistentHash? ConsistentHash { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>
    /// List of custom metrics that are used for the WEIGHTED_ROUND_ROBIN locality_lb_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customMetrics")]
    public IList<V1beta2RegionBackendServiceStatusAtProviderCustomMetrics>? CustomMetrics { get; set; }

    /// <summary>
    /// Defaults to DELETE.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, enable Cloud CDN for this RegionBackendService.</summary>
    [JsonPropertyName("enableCdn")]
    public bool? EnableCdn { get; set; }

    /// <summary>
    /// Policy for failovers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("failoverPolicy")]
    public V1beta2RegionBackendServiceStatusAtProviderFailoverPolicy? FailoverPolicy { get; set; }

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
    /// Configures self-managed High Availability (HA) for External and Internal Protocol Forwarding.
    /// The backends of this regional backend service must only specify zonal network endpoint groups
    /// (NEGs) of type GCE_VM_IP. Note that haPolicy is not for load balancing, and therefore cannot
    /// be specified with sessionAffinity, connectionTrackingPolicy, and failoverPolicy. haPolicy
    /// requires customers to be responsible for tracking backend endpoint health and electing a
    /// leader among the healthy endpoints. Therefore, haPolicy cannot be specified with healthChecks.
    /// haPolicy can only be specified for External Passthrough Network Load Balancers and Internal
    /// Passthrough Network Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("haPolicy")]
    public V1beta2RegionBackendServiceStatusAtProviderHaPolicy? HaPolicy { get; set; }

    /// <summary>
    /// The set of URLs to HealthCheck resources for health checking
    /// this RegionBackendService. Currently at most one health
    /// check can be specified.
    /// A health check must be specified unless the backend service uses an internet
    /// or serverless NEG as a backend.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public IList<string>? HealthChecks { get; set; }

    /// <summary>
    /// Settings for enabling Cloud Identity Aware Proxy.
    /// If OAuth client is not set, Google-managed OAuth client is used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("iap")]
    public V1beta2RegionBackendServiceStatusAtProviderIap? Iap { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/backendServices/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Specifies preference of traffic to the backend (from the proxy and from the client for proxyless gRPC).
    /// Possible values are: IPV4_ONLY, PREFER_IPV6, IPV6_ONLY.
    /// </summary>
    [JsonPropertyName("ipAddressSelectionPolicy")]
    public string? IpAddressSelectionPolicy { get; set; }

    /// <summary>is set to INTERNAL_MANAGED</summary>
    [JsonPropertyName("loadBalancingScheme")]
    public string? LoadBalancingScheme { get; set; }

    /// <summary>
    /// is set to MAGLEV or RING_HASH
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("localityLbPolicy")]
    public string? LocalityLbPolicy { get; set; }

    /// <summary>
    /// This field denotes the logging options for the load balancer traffic served by this backend service.
    /// If logging is enabled, logs will be exported to Stackdriver.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("logConfig")]
    public V1beta2RegionBackendServiceStatusAtProviderLogConfig? LogConfig { get; set; }

    /// <summary>
    /// The URL of the network to which this backend service belongs.
    /// This field must be set for Internal Passthrough Network Load Balancers when the haPolicy is enabled, and for External Passthrough Network Load Balancers when the haPolicy fastIpMove is enabled.
    /// This field can only be specified when the load balancing scheme is set to INTERNAL, or when the load balancing scheme is set to EXTERNAL and haPolicy fastIpMove is enabled.
    /// Changes to this field force recreation of the resource.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// Configures traffic steering properties of internal passthrough Network Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkPassThroughLbTrafficPolicy")]
    public V1beta2RegionBackendServiceStatusAtProviderNetworkPassThroughLbTrafficPolicy? NetworkPassThroughLbTrafficPolicy { get; set; }

    /// <summary>
    /// Settings controlling eviction of unhealthy hosts from the load balancing pool.
    /// This field is applicable only when the load_balancing_scheme is set
    /// to INTERNAL_MANAGED and the protocol is set to HTTP, HTTPS, HTTP2 or H2C.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta2RegionBackendServiceStatusAtProviderOutlierDetection? OutlierDetection { get; set; }

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("params")]
    public V1beta2RegionBackendServiceStatusAtProviderParams? Params { get; set; }

    /// <summary>
    /// A named port on a backend instance group representing the port for
    /// communication to the backend VMs in that group. Required when the
    /// loadBalancingScheme is EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED, or INTERNAL_SELF_MANAGED
    /// and the backends are instance groups. The named port must be defined on each
    /// backend instance group. This parameter has no meaning if the backends are NEGs. API sets a
    /// default of &quot;http&quot; if not given.
    /// Must be omitted when the loadBalancingScheme is INTERNAL (Internal TCP/UDP Load Balancing).
    /// </summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>is set to HTTP, HTTPS, HTTP2 or H2C</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>
    /// The Region in which the created backend service should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The security policy associated with this backend service.</summary>
    [JsonPropertyName("securityPolicy")]
    public string? SecurityPolicy { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// Type of session affinity to use. The default is NONE. Session affinity is
    /// not applicable if the protocol is UDP.
    /// Possible values are: NONE, CLIENT_IP, CLIENT_IP_PORT_PROTO, CLIENT_IP_PROTO, GENERATED_COOKIE, HEADER_FIELD, HTTP_COOKIE, CLIENT_IP_NO_DESTINATION, STRONG_COOKIE_AFFINITY.
    /// </summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>
    /// Describes the HTTP cookie used for stateful session affinity. This field is applicable and required if the sessionAffinity is set to STRONG_COOKIE_AFFINITY.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("strongSessionAffinityCookie")]
    public V1beta2RegionBackendServiceStatusAtProviderStrongSessionAffinityCookie? StrongSessionAffinityCookie { get; set; }

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
    public V1beta2RegionBackendServiceStatusAtProviderTlsSettings? TlsSettings { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatusConditions
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

/// <summary>RegionBackendServiceStatus defines the observed state of RegionBackendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionBackendServiceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RegionBackendServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RegionBackendServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegionBackendService is the Schema for the RegionBackendServices API. A Region Backend Service defines a regionally-scoped group of virtual machines that will serve traffic for load balancing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegionBackendService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RegionBackendServiceSpec>, IStatus<V1beta2RegionBackendServiceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegionBackendService";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionbackendservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionBackendService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionBackendServiceSpec defines the desired state of RegionBackendService</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RegionBackendServiceSpec Spec { get; set; }

    /// <summary>RegionBackendServiceStatus defines the observed state of RegionBackendService.</summary>
    [JsonPropertyName("status")]
    public V1beta2RegionBackendServiceStatus? Status { get; set; }
}