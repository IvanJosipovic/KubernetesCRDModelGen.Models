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
/// <summary>URLMap is the Schema for the URLMaps API. UrlMaps are used to route requests to a backend service based on rules that you define for the host and path of an incoming URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2URLMapList : IKubernetesObject<V1ListMeta>, IItems<V1beta2URLMap>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "URLMapList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "urlmaps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "URLMapList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2URLMap objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2URLMap> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecDeletionPolicyEnum>))]
public enum V1beta2URLMapSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelector
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
    public V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// For example, consider a UrlMap with the following configuration:
/// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
/// A RouteRule for /coming_soon/ is configured for the error code 404.
/// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
/// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see
/// W3C Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure.
/// As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a
/// percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted
/// by the Loadbalancer for a percentage of requests.
/// timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
/// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
/// the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time the request has been
/// fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries.
/// If not specified, will use the largest timeout among all backend services associated with the route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to the matched service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions
/// like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend.
/// If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService
/// is set, defaultRouteAction cannot contain any weightedBackendServices.
/// Only one of defaultRouteAction or defaultUrlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see
    /// W3C Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure.
    /// As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a
    /// percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted
    /// by the Loadbalancer for a percentage of requests.
    /// timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
    /// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
    /// the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time the request has been
    /// fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries.
    /// If not specified, will use the largest timeout among all backend services associated with the route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to the matched service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapSpecForProviderDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match occurs.
    /// The weights determine the fraction of traffic that flows to their corresponding backend service.
    /// If all traffic needs to go to a single backend service, there must be one weightedBackendService
    /// with weight set to a non 0 number.
    /// Once a backendService is identified and before forwarding the request to the backend service,
    /// advanced routing actions like Url rewrites and header transformations are applied depending on
    /// additional settings specified in this HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapSpecForProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderDefaultServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderDefaultServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderDefaultServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderDefaultServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderDefaultServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderDefaultServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultServiceSelector
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
    public V1beta2URLMapSpecForProviderDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderDefaultUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one that was
    /// supplied in the request. The value must be between 1 and 255 characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https. If set to
    /// false, the URL scheme of the redirected request will remain the same as that of the
    /// request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this
    /// true for TargetHttpsProxy is not permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was
    /// supplied in the request. pathRedirect cannot be supplied together with
    /// prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the
    /// original request will be used for the redirect. The value must be between 1 and 1024
    /// characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch,
    /// retaining the remaining portion of the URL before redirecting the request.
    /// prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or
    /// neither. If neither is supplied, the path of the original request will be used for
    /// the redirect. The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed prior
    /// to redirecting the request. If set to false, the query portion of the original URL is
    /// retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. The headerAction specified here take effect after
/// headerAction specified under pathMatcher.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderHostRule
{
    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The list of host patterns to match. They must be valid hostnames, except * will
    /// match any string of ([a-z0-9-.]*). In that case, * must be the first character
    /// and must be followed in the pattern by either - or ..
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// The name of the PathMatcher to use to match the path portion of the URL if the
    /// hostRule matches the URL&apos;s host portion.
    /// </summary>
    [JsonPropertyName("pathMatcher")]
    public string? PathMatcher { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelector
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
    public V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// For example, consider a UrlMap with the following configuration:
/// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
/// A RouteRule for /coming_soon/ is configured for the error code 404.
/// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
/// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the
/// resiliency of clients to backend service failure. As part of fault injection,
/// when clients send requests to a backend service, delays can be introduced by
/// Loadbalancer on a percentage of requests before sending those request to the
/// backend service. Similarly requests from clients can be aborted by the
/// Loadbalancer for a percentage of requests. timeout and retry_policy will be
/// ignored by clients that are configured with a fault_injection_policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are
/// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
/// responses from the shadow service. Prior to sending traffic to the shadow
/// service, the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time
/// the request is has been fully processed (i.e. end-of-stream) up until the
/// response has been completely processed. Timeout includes all retries. If not
/// specified, the default value is 15 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to
/// the matched service
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs
/// advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request
/// to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set.
/// Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
/// Only one of defaultRouteAction or defaultUrlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the
    /// resiliency of clients to backend service failure. As part of fault injection,
    /// when clients send requests to a backend service, delays can be introduced by
    /// Loadbalancer on a percentage of requests before sending those request to the
    /// backend service. Similarly requests from clients can be aborted by the
    /// Loadbalancer for a percentage of requests. timeout and retry_policy will be
    /// ignored by clients that are configured with a fault_injection_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match
    /// occurs. The weights determine the fraction of traffic that flows to their
    /// corresponding backend service. If all traffic needs to go to a single backend
    /// service, there must be one  weightedBackendService with weight set to a non 0
    /// number. Once a backendService is identified and before forwarding the request to
    /// the backend service, advanced routing actions like Url rewrites and header
    /// transformations are applied depending on additional settings specified in this
    /// HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultServiceSelector
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
    public V1beta2URLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherDefaultUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one
    /// that was supplied in the request. The value must be between 1 and 255
    /// characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// If set to false, the URL scheme of the redirected request will remain the
    /// same as that of the request. This must only be set for UrlMaps used in
    /// TargetHttpProxys. Setting this true for TargetHttpsProxy is not
    /// permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one
    /// that was supplied in the request. pathRedirect cannot be supplied
    /// together with prefixRedirect. Supply one alone or neither. If neither is
    /// supplied, the path of the original request will be used for the redirect.
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the
    /// HttpRouteRuleMatch, retaining the remaining portion of the URL before
    /// redirecting the request. prefixRedirect cannot be supplied together with
    /// pathRedirect. Supply one alone or neither. If neither is supplied, the
    /// path of the original request will be used for the redirect. The value
    /// must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is
    /// removed prior to redirecting the request. If set to false, the query
    /// portion of the original URL is retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. HeaderAction specified here are applied after the
/// matching HttpRouteRule HeaderAction and before the HeaderAction in the UrlMap
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelector
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
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the
/// resiliency of clients to backend service failure. As part of fault injection,
/// when clients send requests to a backend service, delays can be introduced by
/// Loadbalancer on a percentage of requests before sending those request to the
/// backend service. Similarly requests from clients can be aborted by the
/// Loadbalancer for a percentage of requests. timeout and retry_policy will be
/// ignored by clients that are configured with a fault_injection_policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are
/// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
/// responses from the shadow service. Prior to sending traffic to the shadow
/// service, the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time
/// the request is has been fully processed (i.e. end-of-stream) up until the
/// response has been completely processed. Timeout includes all retries. If not
/// specified, the default value is 15 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to
/// the matched service
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector
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
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// In response to a matching matchRule, the load balancer performs advanced routing
/// actions like URL rewrites, header transformations, etc. prior to forwarding the
/// request to the selected backend. If  routeAction specifies any
/// weightedBackendServices, service must not be set. Conversely if service is set,
/// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
/// or urlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the
    /// resiliency of clients to backend service failure. As part of fault injection,
    /// when clients send requests to a backend service, delays can be introduced by
    /// Loadbalancer on a percentage of requests before sending those request to the
    /// backend service. Similarly requests from clients can be aborted by the
    /// Loadbalancer for a percentage of requests. timeout and retry_policy will be
    /// ignored by clients that are configured with a fault_injection_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match
    /// occurs. The weights determine the fraction of traffic that flows to their
    /// corresponding backend service. If all traffic needs to go to a single backend
    /// service, there must be one  weightedBackendService with weight set to a non 0
    /// number. Once a backendService is identified and before forwarding the request to
    /// the backend service, advanced routing actions like Url rewrites and header
    /// transformations are applied depending on additional settings specified in this
    /// HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceSelector
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
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRuleUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one
    /// that was supplied in the request. The value must be between 1 and 255
    /// characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// If set to false, the URL scheme of the redirected request will remain the
    /// same as that of the request. This must only be set for UrlMaps used in
    /// TargetHttpProxys. Setting this true for TargetHttpsProxy is not
    /// permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one
    /// that was supplied in the request. pathRedirect cannot be supplied
    /// together with prefixRedirect. Supply one alone or neither. If neither is
    /// supplied, the path of the original request will be used for the redirect.
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the
    /// HttpRouteRuleMatch, retaining the remaining portion of the URL before
    /// redirecting the request. prefixRedirect cannot be supplied together with
    /// pathRedirect. Supply one alone or neither. If neither is supplied, the
    /// path of the original request will be used for the redirect. The value
    /// must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is
    /// removed prior to redirecting the request. If set to false, the query
    /// portion of the original URL is retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherPathRule
{
    /// <summary>
    /// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleCustomErrorResponsePolicy? CustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// The list of path patterns to match. Each must start with / and the only place a
    /// * is allowed is at the end following a /. The string fed to the path matcher
    /// does not include any text after the first ? or #, and those chars are not
    /// allowed here.
    /// </summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>
    /// In response to a matching matchRule, the load balancer performs advanced routing
    /// actions like URL rewrites, header transformations, etc. prior to forwarding the
    /// request to the selected backend. If  routeAction specifies any
    /// weightedBackendServices, service must not be set. Conversely if service is set,
    /// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
    /// or urlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routeAction")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleRouteAction? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleServiceSelector? ServiceSelector { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2URLMapSpecForProviderPathMatcherPathRuleUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary>
/// The header value must be an integer and its value must be in the range specified
/// in rangeMatch. If the header does not contain an integer, number or is empty,
/// the match fails. For example for a range [-5, 0]   - -3 will match.  - 0 will
/// not match.  - 0.25 will not match.  - -3someString will not match.   Only one of
/// exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch
/// must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
{
    /// <summary>The end of the range (exclusive).</summary>
    [JsonPropertyName("rangeEnd")]
    public double? RangeEnd { get; set; }

    /// <summary>The start of the range (inclusive).</summary>
    [JsonPropertyName("rangeStart")]
    public double? RangeStart { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatches
{
    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter exactly matches
    /// the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch
    /// must be set.
    /// </summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>
    /// If set to false, the headerMatch is considered a match if the match criteria
    /// above are met. If set to true, the headerMatch is considered a match if the
    /// match criteria above are NOT met. Defaults to false.
    /// </summary>
    [JsonPropertyName("invertMatch")]
    public bool? InvertMatch { get; set; }

    /// <summary>
    /// For satisfying the matchRule condition, the request&apos;s path must begin with the
    /// specified prefixMatch. prefixMatch must begin with a /. The value must be
    /// between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or
    /// regexMatch must be specified.
    /// </summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>
    /// Specifies that the queryParameterMatch matches if the request contains the query
    /// parameter, irrespective of whether the parameter has a value or not. Only one of
    /// presentMatch, exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>
    /// The header value must be an integer and its value must be in the range specified
    /// in rangeMatch. If the header does not contain an integer, number or is empty,
    /// the match fails. For example for a range [-5, 0]   - -3 will match.  - 0 will
    /// not match.  - 0.25 will not match.  - -3someString will not match.   Only one of
    /// exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch
    /// must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rangeMatch")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch? RangeMatch { get; set; }

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter matches the
    /// regular expression specified by regexMatch. For the regular expression grammar,
    /// please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch,
    /// exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }

    /// <summary>
    /// The value of the header must end with the contents of suffixMatch. Only one of
    /// exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch
    /// must be set.
    /// </summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>
    /// The list of label value pairs that must match labels in the provided metadata
    /// based on filterMatchCriteria  This list must not be empty and can have at the
    /// most 64 entries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>
    /// Specifies how individual filterLabel matches within the list of filterLabels
    /// contribute towards the overall metadataFilter match. Supported values are:
    /// </summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
{
    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter exactly matches
    /// the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch
    /// must be set.
    /// </summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Specifies that the queryParameterMatch matches if the request contains the query
    /// parameter, irrespective of whether the parameter has a value or not. Only one of
    /// presentMatch, exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter matches the
    /// regular expression specified by regexMatch. For the regular expression grammar,
    /// please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch,
    /// exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRules
{
    /// <summary>
    /// For satisfying the matchRule condition, the path of the request must exactly
    /// match the value specified in fullPathMatch after removing any query parameters
    /// and anchor that may be part of the original URL. FullPathMatch must be between 1
    /// and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must
    /// be specified.
    /// </summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>
    /// Specifies a list of header match criteria, all of which must match corresponding
    /// headers in the request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>
    /// Specifies that prefixMatch and fullPathMatch matches are case sensitive.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// Opaque filter criteria used by Loadbalancer to restrict routing configuration to
    /// a limited set xDS compliant clients. In their xDS requests to Loadbalancer, xDS
    /// clients present node metadata. If a match takes place, the relevant routing
    /// configuration is made available to those proxies. For each metadataFilter in
    /// this list, if its filterMatchCriteria is set to MATCH_ANY, at least one of the
    /// filterLabels must match the corresponding label provided in the metadata. If its
    /// filterMatchCriteria is set to MATCH_ALL, then all of its filterLabels must match
    /// with corresponding labels in the provided metadata. metadataFilters specified
    /// here can be overrides those specified in ForwardingRule that refers to this
    /// UrlMap. metadataFilters only applies to Loadbalancers that have their
    /// loadBalancingScheme set to INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>
    /// For satisfying the matchRule condition, the path of the request
    /// must match the wildcard pattern specified in pathTemplateMatch
    /// after removing any query parameters and anchor that may be part
    /// of the original URL.
    /// pathTemplateMatch must be between 1 and 255 characters
    /// (inclusive).  The pattern specified by pathTemplateMatch may
    /// have at most 5 wildcard operators and at most 5 variable
    /// captures in total.
    /// </summary>
    [JsonPropertyName("pathTemplateMatch")]
    public string? PathTemplateMatch { get; set; }

    /// <summary>
    /// For satisfying the matchRule condition, the request&apos;s path must begin with the
    /// specified prefixMatch. prefixMatch must begin with a /. The value must be
    /// between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or
    /// regexMatch must be specified.
    /// </summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>
    /// Specifies a list of query parameter match criteria, all of which must match
    /// corresponding query parameters in the request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queryParameterMatches")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter matches the
    /// regular expression specified by regexMatch. For the regular expression grammar,
    /// please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch,
    /// exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the
/// resiliency of clients to backend service failure. As part of fault injection,
/// when clients send requests to a backend service, delays can be introduced by
/// Loadbalancer on a percentage of requests before sending those request to the
/// backend service. Similarly requests from clients can be aborted by the
/// Loadbalancer for a percentage of requests. timeout and retry_policy will be
/// ignored by clients that are configured with a fault_injection_policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are
/// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
/// responses from the shadow service. Prior to sending traffic to the shadow
/// service, the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time
/// the request is has been fully processed (i.e. end-of-stream) up until the
/// response has been completely processed. Timeout includes all retries. If not
/// specified, the default value is 15 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to
/// the matched service
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected origin, if the
    /// request matched a pathTemplateMatch, the matching portion of the
    /// request&apos;s path is replaced re-written using the pattern specified
    /// by pathTemplateRewrite.
    /// pathTemplateRewrite must be between 1 and 255 characters
    /// (inclusive), must start with a &apos;/&apos;, and must only use variables
    /// captured by the route&apos;s pathTemplate matchers.
    /// pathTemplateRewrite may only be used when all of a route&apos;s
    /// MatchRules specify pathTemplate.
    /// Only one of pathPrefixRewrite and pathTemplateRewrite may be
    /// specified.
    /// </summary>
    [JsonPropertyName("pathTemplateRewrite")]
    public string? PathTemplateRewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// In response to a matching matchRule, the load balancer performs advanced routing
/// actions like URL rewrites, header transformations, etc. prior to forwarding the
/// request to the selected backend. If  routeAction specifies any
/// weightedBackendServices, service must not be set. Conversely if service is set,
/// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
/// or urlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the
    /// resiliency of clients to backend service failure. As part of fault injection,
    /// when clients send requests to a backend service, delays can be introduced by
    /// Loadbalancer on a percentage of requests before sending those request to the
    /// backend service. Similarly requests from clients can be aborted by the
    /// Loadbalancer for a percentage of requests. timeout and retry_policy will be
    /// ignored by clients that are configured with a fault_injection_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match
    /// occurs. The weights determine the fraction of traffic that flows to their
    /// corresponding backend service. If all traffic needs to go to a single backend
    /// service, there must be one  weightedBackendService with weight set to a non 0
    /// number. Once a backendService is identified and before forwarding the request to
    /// the backend service, advanced routing actions like Url rewrites and header
    /// transformations are applied depending on additional settings specified in this
    /// HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceSelector
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
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRulesUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one
    /// that was supplied in the request. The value must be between 1 and 255
    /// characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// If set to false, the URL scheme of the redirected request will remain the
    /// same as that of the request. This must only be set for UrlMaps used in
    /// TargetHttpProxys. Setting this true for TargetHttpsProxy is not
    /// permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one
    /// that was supplied in the request. pathRedirect cannot be supplied
    /// together with prefixRedirect. Supply one alone or neither. If neither is
    /// supplied, the path of the original request will be used for the redirect.
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the
    /// HttpRouteRuleMatch, retaining the remaining portion of the URL before
    /// redirecting the request. prefixRedirect cannot be supplied together with
    /// pathRedirect. Supply one alone or neither. If neither is supplied, the
    /// path of the original request will be used for the redirect. The value
    /// must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is
    /// removed prior to redirecting the request. If set to false, the query
    /// portion of the original URL is retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcherRouteRules
{
    /// <summary>
    /// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesCustomErrorResponsePolicy? CustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// The rules for determining a match.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

    /// <summary>
    /// For routeRules within a given pathMatcher, priority determines the order
    /// in which load balancer will interpret routeRules. RouteRules are evaluated
    /// in order of priority, from the lowest to highest number. The priority of
    /// a rule decreases as its number increases (1, 2, 3, N+1). The first rule
    /// that matches the request is applied.
    /// You cannot configure two or more routeRules with the same priority.
    /// Priority for each rule must be set to a number between 0 and
    /// 2147483647 inclusive.
    /// Priority numbers can have gaps, which enable you to add or remove rules
    /// in the future without affecting the rest of the rules. For example,
    /// 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers to which
    /// you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the
    /// future without any impact on existing rules.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// In response to a matching matchRule, the load balancer performs advanced routing
    /// actions like URL rewrites, header transformations, etc. prior to forwarding the
    /// request to the selected backend. If  routeAction specifies any
    /// weightedBackendServices, service must not be set. Conversely if service is set,
    /// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
    /// or urlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routeAction")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesRouteAction? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesServiceSelector? ServiceSelector { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2URLMapSpecForProviderPathMatcherRouteRulesUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderPathMatcher
{
    /// <summary>
    /// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// For example, consider a UrlMap with the following configuration:
    /// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
    /// A RouteRule for /coming_soon/ is configured for the error code 404.
    /// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
    /// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultCustomErrorResponsePolicy? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs
    /// advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request
    /// to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set.
    /// Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given paths match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2URLMapSpecForProviderPathMatcherDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. HeaderAction specified here are applied after the
    /// matching HttpRouteRule HeaderAction and before the HeaderAction in the UrlMap
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecForProviderPathMatcherHeaderAction? HeaderAction { get; set; }

    /// <summary>The name to which this PathMatcher is referred by the HostRule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The list of path rules. Use this list instead of routeRules when routing based
    /// on simple path matching is all that&apos;s required. The order by which path rules
    /// are specified does not matter. Matches are always done on the longest-path-first
    /// basis. For example: a pathRule with a path /a/b/c/* will match before /a/b/*
    /// irrespective of the order in which those paths appear in this list. Within a
    /// given pathMatcher, only one of pathRules or routeRules must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherPathRule>? PathRule { get; set; }

    /// <summary>
    /// The list of ordered HTTP route rules. Use this list instead of pathRules when
    /// advanced route matching and routing actions are desired. The order of specifying
    /// routeRules matters: the first rule that matches will cause its specified routing
    /// action to take effect. Within a given pathMatcher, only one of pathRules or
    /// routeRules must be set. routeRules are not supported in UrlMaps intended for
    /// External load balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routeRules")]
    public IList<V1beta2URLMapSpecForProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderTestHeaders
{
    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderTestServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderTestServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderTestServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderTestServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderTestServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderTestServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderTestServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderTestServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecForProviderTestServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderTestServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecForProviderTestServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecForProviderTestServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecForProviderTestServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderTestServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecForProviderTestServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecForProviderTestServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderTestServiceSelector
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
    public V1beta2URLMapSpecForProviderTestServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The expected output URL evaluated by the load balancer containing the scheme, host, path and query parameters.
    /// For rules that forward requests to backends, the test passes only when expectedOutputUrl matches the request forwarded by the load balancer to backends. For rules with urlRewrite, the test verifies that the forwarded request matches hostRewrite and pathPrefixRewrite in the urlRewrite action. When service is specified, expectedOutputUrl`s scheme is ignored.
    /// For rules with urlRedirect, the test passes only if expectedOutputUrl matches the URL in the load balancer&apos;s redirect response. If urlRedirect specifies httpsRedirect, the test passes only if the scheme in expectedOutputUrl is also set to HTTPS. If urlRedirect specifies stripQuery, the test passes only if expectedOutputUrl does not contain any query parameters.
    /// expectedOutputUrl is optional when service is specified.
    /// </summary>
    [JsonPropertyName("expectedOutputUrl")]
    public string? ExpectedOutputUrl { get; set; }

    /// <summary>
    /// For rules with urlRedirect, the test passes only if expectedRedirectResponseCode matches the HTTP status code in load balancer&apos;s redirect response.
    /// expectedRedirectResponseCode cannot be set when service is set.
    /// </summary>
    [JsonPropertyName("expectedRedirectResponseCode")]
    public double? ExpectedRedirectResponseCode { get; set; }

    /// <summary>
    /// HTTP headers for this request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2URLMapSpecForProviderTestHeaders>? Headers { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2URLMapSpecForProviderTestServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2URLMapSpecForProviderTestServiceSelector? ServiceSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecForProvider
{
    /// <summary>
    /// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// For example, consider a UrlMap with the following configuration:
    /// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
    /// A RouteRule for /coming_soon/ is configured for the error code 404.
    /// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
    /// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public V1beta2URLMapSpecForProviderDefaultCustomErrorResponsePolicy? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions
    /// like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend.
    /// If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService
    /// is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2URLMapSpecForProviderDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given rules match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta2URLMapSpecForProviderDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta2URLMapSpecForProviderDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2URLMapSpecForProviderDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. The headerAction specified here take effect after
    /// headerAction specified under pathMatcher.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecForProviderHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// The list of HostRules to use against the URL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta2URLMapSpecForProviderHostRule>? HostRule { get; set; }

    /// <summary>
    /// The list of named PathMatchers to use against the URL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta2URLMapSpecForProviderPathMatcher>? PathMatcher { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The list of expected URL mapping tests. Request to update this UrlMap will
    /// succeed only if all of the test cases pass. You can specify a maximum of 100
    /// tests per UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("test")]
    public IList<V1beta2URLMapSpecForProviderTest>? Test { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelector
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
    public V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// For example, consider a UrlMap with the following configuration:
/// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
/// A RouteRule for /coming_soon/ is configured for the error code 404.
/// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
/// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see
/// W3C Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure.
/// As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a
/// percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted
/// by the Loadbalancer for a percentage of requests.
/// timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
/// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
/// the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time the request has been
/// fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries.
/// If not specified, will use the largest timeout among all backend services associated with the route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to the matched service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions
/// like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend.
/// If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService
/// is set, defaultRouteAction cannot contain any weightedBackendServices.
/// Only one of defaultRouteAction or defaultUrlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see
    /// W3C Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure.
    /// As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a
    /// percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted
    /// by the Loadbalancer for a percentage of requests.
    /// timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
    /// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
    /// the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time the request has been
    /// fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries.
    /// If not specified, will use the largest timeout among all backend services associated with the route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to the matched service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapSpecInitProviderDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match occurs.
    /// The weights determine the fraction of traffic that flows to their corresponding backend service.
    /// If all traffic needs to go to a single backend service, there must be one weightedBackendService
    /// with weight set to a non 0 number.
    /// Once a backendService is identified and before forwarding the request to the backend service,
    /// advanced routing actions like Url rewrites and header transformations are applied depending on
    /// additional settings specified in this HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapSpecInitProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderDefaultServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderDefaultServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderDefaultServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderDefaultServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderDefaultServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderDefaultServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultServiceSelector
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
    public V1beta2URLMapSpecInitProviderDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderDefaultUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one that was
    /// supplied in the request. The value must be between 1 and 255 characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https. If set to
    /// false, the URL scheme of the redirected request will remain the same as that of the
    /// request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this
    /// true for TargetHttpsProxy is not permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was
    /// supplied in the request. pathRedirect cannot be supplied together with
    /// prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the
    /// original request will be used for the redirect. The value must be between 1 and 1024
    /// characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch,
    /// retaining the remaining portion of the URL before redirecting the request.
    /// prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or
    /// neither. If neither is supplied, the path of the original request will be used for
    /// the redirect. The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed prior
    /// to redirecting the request. If set to false, the query portion of the original URL is
    /// retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. The headerAction specified here take effect after
/// headerAction specified under pathMatcher.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderHostRule
{
    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The list of host patterns to match. They must be valid hostnames, except * will
    /// match any string of ([a-z0-9-.]*). In that case, * must be the first character
    /// and must be followed in the pattern by either - or ..
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// The name of the PathMatcher to use to match the path portion of the URL if the
    /// hostRule matches the URL&apos;s host portion.
    /// </summary>
    [JsonPropertyName("pathMatcher")]
    public string? PathMatcher { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelector
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
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// For example, consider a UrlMap with the following configuration:
/// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
/// A RouteRule for /coming_soon/ is configured for the error code 404.
/// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
/// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the
/// resiliency of clients to backend service failure. As part of fault injection,
/// when clients send requests to a backend service, delays can be introduced by
/// Loadbalancer on a percentage of requests before sending those request to the
/// backend service. Similarly requests from clients can be aborted by the
/// Loadbalancer for a percentage of requests. timeout and retry_policy will be
/// ignored by clients that are configured with a fault_injection_policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are
/// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
/// responses from the shadow service. Prior to sending traffic to the shadow
/// service, the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time
/// the request is has been fully processed (i.e. end-of-stream) up until the
/// response has been completely processed. Timeout includes all retries. If not
/// specified, the default value is 15 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to
/// the matched service
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs
/// advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request
/// to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set.
/// Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
/// Only one of defaultRouteAction or defaultUrlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the
    /// resiliency of clients to backend service failure. As part of fault injection,
    /// when clients send requests to a backend service, delays can be introduced by
    /// Loadbalancer on a percentage of requests before sending those request to the
    /// backend service. Similarly requests from clients can be aborted by the
    /// Loadbalancer for a percentage of requests. timeout and retry_policy will be
    /// ignored by clients that are configured with a fault_injection_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match
    /// occurs. The weights determine the fraction of traffic that flows to their
    /// corresponding backend service. If all traffic needs to go to a single backend
    /// service, there must be one  weightedBackendService with weight set to a non 0
    /// number. Once a backendService is identified and before forwarding the request to
    /// the backend service, advanced routing actions like Url rewrites and header
    /// transformations are applied depending on additional settings specified in this
    /// HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceSelector
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
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherDefaultUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one
    /// that was supplied in the request. The value must be between 1 and 255
    /// characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// If set to false, the URL scheme of the redirected request will remain the
    /// same as that of the request. This must only be set for UrlMaps used in
    /// TargetHttpProxys. Setting this true for TargetHttpsProxy is not
    /// permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one
    /// that was supplied in the request. pathRedirect cannot be supplied
    /// together with prefixRedirect. Supply one alone or neither. If neither is
    /// supplied, the path of the original request will be used for the redirect.
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the
    /// HttpRouteRuleMatch, retaining the remaining portion of the URL before
    /// redirecting the request. prefixRedirect cannot be supplied together with
    /// pathRedirect. Supply one alone or neither. If neither is supplied, the
    /// path of the original request will be used for the redirect. The value
    /// must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is
    /// removed prior to redirecting the request. If set to false, the query
    /// portion of the original URL is retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. HeaderAction specified here are applied after the
/// matching HttpRouteRule HeaderAction and before the HeaderAction in the UrlMap
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelector
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
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceRef")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceRef? ErrorServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate errorService.</summary>
    [JsonPropertyName("errorServiceSelector")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorServiceSelector? ErrorServiceSelector { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the
/// resiliency of clients to backend service failure. As part of fault injection,
/// when clients send requests to a backend service, delays can be introduced by
/// Loadbalancer on a percentage of requests before sending those request to the
/// backend service. Similarly requests from clients can be aborted by the
/// Loadbalancer for a percentage of requests. timeout and retry_policy will be
/// ignored by clients that are configured with a fault_injection_policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are
/// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
/// responses from the shadow service. Prior to sending traffic to the shadow
/// service, the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time
/// the request is has been fully processed (i.e. end-of-stream) up until the
/// response has been completely processed. Timeout includes all retries. If not
/// specified, the default value is 15 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to
/// the matched service
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector
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
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// In response to a matching matchRule, the load balancer performs advanced routing
/// actions like URL rewrites, header transformations, etc. prior to forwarding the
/// request to the selected backend. If  routeAction specifies any
/// weightedBackendServices, service must not be set. Conversely if service is set,
/// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
/// or urlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the
    /// resiliency of clients to backend service failure. As part of fault injection,
    /// when clients send requests to a backend service, delays can be introduced by
    /// Loadbalancer on a percentage of requests before sending those request to the
    /// backend service. Similarly requests from clients can be aborted by the
    /// Loadbalancer for a percentage of requests. timeout and retry_policy will be
    /// ignored by clients that are configured with a fault_injection_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match
    /// occurs. The weights determine the fraction of traffic that flows to their
    /// corresponding backend service. If all traffic needs to go to a single backend
    /// service, there must be one  weightedBackendService with weight set to a non 0
    /// number. Once a backendService is identified and before forwarding the request to
    /// the backend service, advanced routing actions like Url rewrites and header
    /// transformations are applied depending on additional settings specified in this
    /// HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceSelector
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
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRuleUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one
    /// that was supplied in the request. The value must be between 1 and 255
    /// characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// If set to false, the URL scheme of the redirected request will remain the
    /// same as that of the request. This must only be set for UrlMaps used in
    /// TargetHttpProxys. Setting this true for TargetHttpsProxy is not
    /// permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one
    /// that was supplied in the request. pathRedirect cannot be supplied
    /// together with prefixRedirect. Supply one alone or neither. If neither is
    /// supplied, the path of the original request will be used for the redirect.
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the
    /// HttpRouteRuleMatch, retaining the remaining portion of the URL before
    /// redirecting the request. prefixRedirect cannot be supplied together with
    /// pathRedirect. Supply one alone or neither. If neither is supplied, the
    /// path of the original request will be used for the redirect. The value
    /// must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is
    /// removed prior to redirecting the request. If set to false, the query
    /// portion of the original URL is retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherPathRule
{
    /// <summary>
    /// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleCustomErrorResponsePolicy? CustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// The list of path patterns to match. Each must start with / and the only place a
    /// * is allowed is at the end following a /. The string fed to the path matcher
    /// does not include any text after the first ? or #, and those chars are not
    /// allowed here.
    /// </summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>
    /// In response to a matching matchRule, the load balancer performs advanced routing
    /// actions like URL rewrites, header transformations, etc. prior to forwarding the
    /// request to the selected backend. If  routeAction specifies any
    /// weightedBackendServices, service must not be set. Conversely if service is set,
    /// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
    /// or urlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routeAction")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleRouteAction? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleServiceSelector? ServiceSelector { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2URLMapSpecInitProviderPathMatcherPathRuleUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary>
/// The header value must be an integer and its value must be in the range specified
/// in rangeMatch. If the header does not contain an integer, number or is empty,
/// the match fails. For example for a range [-5, 0]   - -3 will match.  - 0 will
/// not match.  - 0.25 will not match.  - -3someString will not match.   Only one of
/// exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch
/// must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
{
    /// <summary>The end of the range (exclusive).</summary>
    [JsonPropertyName("rangeEnd")]
    public double? RangeEnd { get; set; }

    /// <summary>The start of the range (inclusive).</summary>
    [JsonPropertyName("rangeStart")]
    public double? RangeStart { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatches
{
    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter exactly matches
    /// the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch
    /// must be set.
    /// </summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>
    /// If set to false, the headerMatch is considered a match if the match criteria
    /// above are met. If set to true, the headerMatch is considered a match if the
    /// match criteria above are NOT met. Defaults to false.
    /// </summary>
    [JsonPropertyName("invertMatch")]
    public bool? InvertMatch { get; set; }

    /// <summary>
    /// For satisfying the matchRule condition, the request&apos;s path must begin with the
    /// specified prefixMatch. prefixMatch must begin with a /. The value must be
    /// between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or
    /// regexMatch must be specified.
    /// </summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>
    /// Specifies that the queryParameterMatch matches if the request contains the query
    /// parameter, irrespective of whether the parameter has a value or not. Only one of
    /// presentMatch, exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>
    /// The header value must be an integer and its value must be in the range specified
    /// in rangeMatch. If the header does not contain an integer, number or is empty,
    /// the match fails. For example for a range [-5, 0]   - -3 will match.  - 0 will
    /// not match.  - 0.25 will not match.  - -3someString will not match.   Only one of
    /// exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch
    /// must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rangeMatch")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch? RangeMatch { get; set; }

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter matches the
    /// regular expression specified by regexMatch. For the regular expression grammar,
    /// please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch,
    /// exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }

    /// <summary>
    /// The value of the header must end with the contents of suffixMatch. Only one of
    /// exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch
    /// must be set.
    /// </summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>
    /// The list of label value pairs that must match labels in the provided metadata
    /// based on filterMatchCriteria  This list must not be empty and can have at the
    /// most 64 entries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>
    /// Specifies how individual filterLabel matches within the list of filterLabels
    /// contribute towards the overall metadataFilter match. Supported values are:
    /// </summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
{
    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter exactly matches
    /// the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch
    /// must be set.
    /// </summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Specifies that the queryParameterMatch matches if the request contains the query
    /// parameter, irrespective of whether the parameter has a value or not. Only one of
    /// presentMatch, exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter matches the
    /// regular expression specified by regexMatch. For the regular expression grammar,
    /// please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch,
    /// exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRules
{
    /// <summary>
    /// For satisfying the matchRule condition, the path of the request must exactly
    /// match the value specified in fullPathMatch after removing any query parameters
    /// and anchor that may be part of the original URL. FullPathMatch must be between 1
    /// and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must
    /// be specified.
    /// </summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>
    /// Specifies a list of header match criteria, all of which must match corresponding
    /// headers in the request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>
    /// Specifies that prefixMatch and fullPathMatch matches are case sensitive.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// Opaque filter criteria used by Loadbalancer to restrict routing configuration to
    /// a limited set xDS compliant clients. In their xDS requests to Loadbalancer, xDS
    /// clients present node metadata. If a match takes place, the relevant routing
    /// configuration is made available to those proxies. For each metadataFilter in
    /// this list, if its filterMatchCriteria is set to MATCH_ANY, at least one of the
    /// filterLabels must match the corresponding label provided in the metadata. If its
    /// filterMatchCriteria is set to MATCH_ALL, then all of its filterLabels must match
    /// with corresponding labels in the provided metadata. metadataFilters specified
    /// here can be overrides those specified in ForwardingRule that refers to this
    /// UrlMap. metadataFilters only applies to Loadbalancers that have their
    /// loadBalancingScheme set to INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>
    /// For satisfying the matchRule condition, the path of the request
    /// must match the wildcard pattern specified in pathTemplateMatch
    /// after removing any query parameters and anchor that may be part
    /// of the original URL.
    /// pathTemplateMatch must be between 1 and 255 characters
    /// (inclusive).  The pattern specified by pathTemplateMatch may
    /// have at most 5 wildcard operators and at most 5 variable
    /// captures in total.
    /// </summary>
    [JsonPropertyName("pathTemplateMatch")]
    public string? PathTemplateMatch { get; set; }

    /// <summary>
    /// For satisfying the matchRule condition, the request&apos;s path must begin with the
    /// specified prefixMatch. prefixMatch must begin with a /. The value must be
    /// between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or
    /// regexMatch must be specified.
    /// </summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>
    /// Specifies a list of query parameter match criteria, all of which must match
    /// corresponding query parameters in the request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queryParameterMatches")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter matches the
    /// regular expression specified by regexMatch. For the regular expression grammar,
    /// please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch,
    /// exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the
/// resiliency of clients to backend service failure. As part of fault injection,
/// when clients send requests to a backend service, delays can be introduced by
/// Loadbalancer on a percentage of requests before sending those request to the
/// backend service. Similarly requests from clients can be aborted by the
/// Loadbalancer for a percentage of requests. timeout and retry_policy will be
/// ignored by clients that are configured with a fault_injection_policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are
/// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
/// responses from the shadow service. Prior to sending traffic to the shadow
/// service, the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time
/// the request is has been fully processed (i.e. end-of-stream) up until the
/// response has been completely processed. Timeout includes all retries. If not
/// specified, the default value is 15 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to
/// the matched service
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected origin, if the
    /// request matched a pathTemplateMatch, the matching portion of the
    /// request&apos;s path is replaced re-written using the pattern specified
    /// by pathTemplateRewrite.
    /// pathTemplateRewrite must be between 1 and 255 characters
    /// (inclusive), must start with a &apos;/&apos;, and must only use variables
    /// captured by the route&apos;s pathTemplate matchers.
    /// pathTemplateRewrite may only be used when all of a route&apos;s
    /// MatchRules specify pathTemplate.
    /// Only one of pathPrefixRewrite and pathTemplateRewrite may be
    /// specified.
    /// </summary>
    [JsonPropertyName("pathTemplateRewrite")]
    public string? PathTemplateRewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// In response to a matching matchRule, the load balancer performs advanced routing
/// actions like URL rewrites, header transformations, etc. prior to forwarding the
/// request to the selected backend. If  routeAction specifies any
/// weightedBackendServices, service must not be set. Conversely if service is set,
/// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
/// or urlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the
    /// resiliency of clients to backend service failure. As part of fault injection,
    /// when clients send requests to a backend service, delays can be introduced by
    /// Loadbalancer on a percentage of requests before sending those request to the
    /// backend service. Similarly requests from clients can be aborted by the
    /// Loadbalancer for a percentage of requests. timeout and retry_policy will be
    /// ignored by clients that are configured with a fault_injection_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match
    /// occurs. The weights determine the fraction of traffic that flows to their
    /// corresponding backend service. If all traffic needs to go to a single backend
    /// service, there must be one  weightedBackendService with weight set to a non 0
    /// number. Once a backendService is identified and before forwarding the request to
    /// the backend service, advanced routing actions like Url rewrites and header
    /// transformations are applied depending on additional settings specified in this
    /// HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceSelector
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
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRulesUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one
    /// that was supplied in the request. The value must be between 1 and 255
    /// characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// If set to false, the URL scheme of the redirected request will remain the
    /// same as that of the request. This must only be set for UrlMaps used in
    /// TargetHttpProxys. Setting this true for TargetHttpsProxy is not
    /// permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one
    /// that was supplied in the request. pathRedirect cannot be supplied
    /// together with prefixRedirect. Supply one alone or neither. If neither is
    /// supplied, the path of the original request will be used for the redirect.
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the
    /// HttpRouteRuleMatch, retaining the remaining portion of the URL before
    /// redirecting the request. prefixRedirect cannot be supplied together with
    /// pathRedirect. Supply one alone or neither. If neither is supplied, the
    /// path of the original request will be used for the redirect. The value
    /// must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is
    /// removed prior to redirecting the request. If set to false, the query
    /// portion of the original URL is retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcherRouteRules
{
    /// <summary>
    /// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesCustomErrorResponsePolicy? CustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// The rules for determining a match.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

    /// <summary>
    /// For routeRules within a given pathMatcher, priority determines the order
    /// in which load balancer will interpret routeRules. RouteRules are evaluated
    /// in order of priority, from the lowest to highest number. The priority of
    /// a rule decreases as its number increases (1, 2, 3, N+1). The first rule
    /// that matches the request is applied.
    /// You cannot configure two or more routeRules with the same priority.
    /// Priority for each rule must be set to a number between 0 and
    /// 2147483647 inclusive.
    /// Priority numbers can have gaps, which enable you to add or remove rules
    /// in the future without affecting the rest of the rules. For example,
    /// 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers to which
    /// you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the
    /// future without any impact on existing rules.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// In response to a matching matchRule, the load balancer performs advanced routing
    /// actions like URL rewrites, header transformations, etc. prior to forwarding the
    /// request to the selected backend. If  routeAction specifies any
    /// weightedBackendServices, service must not be set. Conversely if service is set,
    /// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
    /// or urlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routeAction")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesRouteAction? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesServiceSelector? ServiceSelector { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2URLMapSpecInitProviderPathMatcherRouteRulesUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderPathMatcher
{
    /// <summary>
    /// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// For example, consider a UrlMap with the following configuration:
    /// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
    /// A RouteRule for /coming_soon/ is configured for the error code 404.
    /// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
    /// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultCustomErrorResponsePolicy? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs
    /// advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request
    /// to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set.
    /// Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given paths match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2URLMapSpecInitProviderPathMatcherDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. HeaderAction specified here are applied after the
    /// matching HttpRouteRule HeaderAction and before the HeaderAction in the UrlMap
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecInitProviderPathMatcherHeaderAction? HeaderAction { get; set; }

    /// <summary>The name to which this PathMatcher is referred by the HostRule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The list of path rules. Use this list instead of routeRules when routing based
    /// on simple path matching is all that&apos;s required. The order by which path rules
    /// are specified does not matter. Matches are always done on the longest-path-first
    /// basis. For example: a pathRule with a path /a/b/c/* will match before /a/b/*
    /// irrespective of the order in which those paths appear in this list. Within a
    /// given pathMatcher, only one of pathRules or routeRules must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherPathRule>? PathRule { get; set; }

    /// <summary>
    /// The list of ordered HTTP route rules. Use this list instead of pathRules when
    /// advanced route matching and routing actions are desired. The order of specifying
    /// routeRules matters: the first rule that matches will cause its specified routing
    /// action to take effect. Within a given pathMatcher, only one of pathRules or
    /// routeRules must be set. routeRules are not supported in UrlMaps intended for
    /// External load balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routeRules")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderTestHeaders
{
    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderTestServiceRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderTestServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderTestServiceRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderTestServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderTestServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderTestServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderTestServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderTestServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecInitProviderTestServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderTestServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecInitProviderTestServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecInitProviderTestServiceSelectorPolicyResolveEnum>))]
public enum V1beta2URLMapSpecInitProviderTestServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderTestServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecInitProviderTestServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecInitProviderTestServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BackendBucket in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderTestServiceSelector
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
    public V1beta2URLMapSpecInitProviderTestServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecInitProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The expected output URL evaluated by the load balancer containing the scheme, host, path and query parameters.
    /// For rules that forward requests to backends, the test passes only when expectedOutputUrl matches the request forwarded by the load balancer to backends. For rules with urlRewrite, the test verifies that the forwarded request matches hostRewrite and pathPrefixRewrite in the urlRewrite action. When service is specified, expectedOutputUrl`s scheme is ignored.
    /// For rules with urlRedirect, the test passes only if expectedOutputUrl matches the URL in the load balancer&apos;s redirect response. If urlRedirect specifies httpsRedirect, the test passes only if the scheme in expectedOutputUrl is also set to HTTPS. If urlRedirect specifies stripQuery, the test passes only if expectedOutputUrl does not contain any query parameters.
    /// expectedOutputUrl is optional when service is specified.
    /// </summary>
    [JsonPropertyName("expectedOutputUrl")]
    public string? ExpectedOutputUrl { get; set; }

    /// <summary>
    /// For rules with urlRedirect, the test passes only if expectedRedirectResponseCode matches the HTTP status code in load balancer&apos;s redirect response.
    /// expectedRedirectResponseCode cannot be set when service is set.
    /// </summary>
    [JsonPropertyName("expectedRedirectResponseCode")]
    public double? ExpectedRedirectResponseCode { get; set; }

    /// <summary>
    /// HTTP headers for this request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2URLMapSpecInitProviderTestHeaders>? Headers { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2URLMapSpecInitProviderTestServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2URLMapSpecInitProviderTestServiceSelector? ServiceSelector { get; set; }
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
public partial class V1beta2URLMapSpecInitProvider
{
    /// <summary>
    /// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// For example, consider a UrlMap with the following configuration:
    /// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
    /// A RouteRule for /coming_soon/ is configured for the error code 404.
    /// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
    /// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public V1beta2URLMapSpecInitProviderDefaultCustomErrorResponsePolicy? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions
    /// like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend.
    /// If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService
    /// is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2URLMapSpecInitProviderDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given rules match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta2URLMapSpecInitProviderDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a BackendBucket in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta2URLMapSpecInitProviderDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2URLMapSpecInitProviderDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. The headerAction specified here take effect after
    /// headerAction specified under pathMatcher.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapSpecInitProviderHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// The list of HostRules to use against the URL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta2URLMapSpecInitProviderHostRule>? HostRule { get; set; }

    /// <summary>
    /// The list of named PathMatchers to use against the URL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta2URLMapSpecInitProviderPathMatcher>? PathMatcher { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The list of expected URL mapping tests. Request to update this UrlMap will
    /// succeed only if all of the test cases pass. You can specify a maximum of 100
    /// tests per UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("test")]
    public IList<V1beta2URLMapSpecInitProviderTest>? Test { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecManagementPoliciesEnum>))]
public enum V1beta2URLMapSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2URLMapSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2URLMapSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2URLMapSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2URLMapSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2URLMapSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2URLMapSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>URLMapSpec defines the desired state of URLMap</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapSpec
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
    public V1beta2URLMapSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2URLMapSpecForProvider ForProvider { get; set; }

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
    public V1beta2URLMapSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2URLMapSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2URLMapSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2URLMapSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// For example, consider a UrlMap with the following configuration:
/// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
/// A RouteRule for /coming_soon/ is configured for the error code 404.
/// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
/// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapStatusAtProviderDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see
/// W3C Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure.
/// As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a
/// percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted
/// by the Loadbalancer for a percentage of requests.
/// timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
/// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
/// the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time the request has been
/// fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries.
/// If not specified, will use the largest timeout among all backend services associated with the route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to the matched service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions
/// like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend.
/// If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService
/// is set, defaultRouteAction cannot contain any weightedBackendServices.
/// Only one of defaultRouteAction or defaultUrlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see
    /// W3C Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure.
    /// As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a
    /// percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted
    /// by the Loadbalancer for a percentage of requests.
    /// timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
    /// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
    /// the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time the request has been
    /// fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries.
    /// If not specified, will use the largest timeout among all backend services associated with the route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to the matched service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapStatusAtProviderDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match occurs.
    /// The weights determine the fraction of traffic that flows to their corresponding backend service.
    /// If all traffic needs to go to a single backend service, there must be one weightedBackendService
    /// with weight set to a non 0 number.
    /// Once a backendService is identified and before forwarding the request to the backend service,
    /// advanced routing actions like Url rewrites and header transformations are applied depending on
    /// additional settings specified in this HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapStatusAtProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderDefaultUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one that was
    /// supplied in the request. The value must be between 1 and 255 characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https. If set to
    /// false, the URL scheme of the redirected request will remain the same as that of the
    /// request. This must only be set for UrlMaps used in TargetHttpProxys. Setting this
    /// true for TargetHttpsProxy is not permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one that was
    /// supplied in the request. pathRedirect cannot be supplied together with
    /// prefixRedirect. Supply one alone or neither. If neither is supplied, the path of the
    /// original request will be used for the redirect. The value must be between 1 and 1024
    /// characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the HttpRouteRuleMatch,
    /// retaining the remaining portion of the URL before redirecting the request.
    /// prefixRedirect cannot be supplied together with pathRedirect. Supply one alone or
    /// neither. If neither is supplied, the path of the original request will be used for
    /// the redirect. The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is removed prior
    /// to redirecting the request. If set to false, the query portion of the original URL is
    /// retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. The headerAction specified here take effect after
/// headerAction specified under pathMatcher.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderHostRule
{
    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The list of host patterns to match. They must be valid hostnames, except * will
    /// match any string of ([a-z0-9-.]*). In that case, * must be the first character
    /// and must be followed in the pattern by either - or ..
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// The name of the PathMatcher to use to match the path portion of the URL if the
    /// hostRule matches the URL&apos;s host portion.
    /// </summary>
    [JsonPropertyName("pathMatcher")]
    public string? PathMatcher { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// For example, consider a UrlMap with the following configuration:
/// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
/// A RouteRule for /coming_soon/ is configured for the error code 404.
/// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
/// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
/// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherDefaultCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the
/// resiliency of clients to backend service failure. As part of fault injection,
/// when clients send requests to a backend service, delays can be introduced by
/// Loadbalancer on a percentage of requests before sending those request to the
/// backend service. Similarly requests from clients can be aborted by the
/// Loadbalancer for a percentage of requests. timeout and retry_policy will be
/// ignored by clients that are configured with a fault_injection_policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are
/// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
/// responses from the shadow service. Prior to sending traffic to the shadow
/// service, the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time
/// the request is has been fully processed (i.e. end-of-stream) up until the
/// response has been completely processed. Timeout includes all retries. If not
/// specified, the default value is 15 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to
/// the matched service
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs
/// advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request
/// to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set.
/// Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
/// Only one of defaultRouteAction or defaultUrlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the
    /// resiliency of clients to backend service failure. As part of fault injection,
    /// when clients send requests to a backend service, delays can be introduced by
    /// Loadbalancer on a percentage of requests before sending those request to the
    /// backend service. Similarly requests from clients can be aborted by the
    /// Loadbalancer for a percentage of requests. timeout and retry_policy will be
    /// ignored by clients that are configured with a fault_injection_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match
    /// occurs. The weights determine the fraction of traffic that flows to their
    /// corresponding backend service. If all traffic needs to go to a single backend
    /// service, there must be one  weightedBackendService with weight set to a non 0
    /// number. Once a backendService is identified and before forwarding the request to
    /// the backend service, advanced routing actions like Url rewrites and header
    /// transformations are applied depending on additional settings specified in this
    /// HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherDefaultUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one
    /// that was supplied in the request. The value must be between 1 and 255
    /// characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// If set to false, the URL scheme of the redirected request will remain the
    /// same as that of the request. This must only be set for UrlMaps used in
    /// TargetHttpProxys. Setting this true for TargetHttpsProxy is not
    /// permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one
    /// that was supplied in the request. pathRedirect cannot be supplied
    /// together with prefixRedirect. Supply one alone or neither. If neither is
    /// supplied, the path of the original request will be used for the redirect.
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the
    /// HttpRouteRuleMatch, retaining the remaining portion of the URL before
    /// redirecting the request. prefixRedirect cannot be supplied together with
    /// pathRedirect. Supply one alone or neither. If neither is supplied, the
    /// path of the original request will be used for the redirect. The value
    /// must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is
    /// removed prior to redirecting the request. If set to false, the query
    /// portion of the original URL is retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. HeaderAction specified here are applied after the
/// matching HttpRouteRule HeaderAction and before the HeaderAction in the UrlMap
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherPathRuleCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the
/// resiliency of clients to backend service failure. As part of fault injection,
/// when clients send requests to a backend service, delays can be introduced by
/// Loadbalancer on a percentage of requests before sending those request to the
/// backend service. Similarly requests from clients can be aborted by the
/// Loadbalancer for a percentage of requests. timeout and retry_policy will be
/// ignored by clients that are configured with a fault_injection_policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are
/// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
/// responses from the shadow service. Prior to sending traffic to the shadow
/// service, the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time
/// the request is has been fully processed (i.e. end-of-stream) up until the
/// response has been completely processed. Timeout includes all retries. If not
/// specified, the default value is 15 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to
/// the matched service
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// In response to a matching matchRule, the load balancer performs advanced routing
/// actions like URL rewrites, header transformations, etc. prior to forwarding the
/// request to the selected backend. If  routeAction specifies any
/// weightedBackendServices, service must not be set. Conversely if service is set,
/// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
/// or urlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the
    /// resiliency of clients to backend service failure. As part of fault injection,
    /// when clients send requests to a backend service, delays can be introduced by
    /// Loadbalancer on a percentage of requests before sending those request to the
    /// backend service. Similarly requests from clients can be aborted by the
    /// Loadbalancer for a percentage of requests. timeout and retry_policy will be
    /// ignored by clients that are configured with a fault_injection_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match
    /// occurs. The weights determine the fraction of traffic that flows to their
    /// corresponding backend service. If all traffic needs to go to a single backend
    /// service, there must be one  weightedBackendService with weight set to a non 0
    /// number. Once a backendService is identified and before forwarding the request to
    /// the backend service, advanced routing actions like Url rewrites and header
    /// transformations are applied depending on additional settings specified in this
    /// HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRuleUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one
    /// that was supplied in the request. The value must be between 1 and 255
    /// characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// If set to false, the URL scheme of the redirected request will remain the
    /// same as that of the request. This must only be set for UrlMaps used in
    /// TargetHttpProxys. Setting this true for TargetHttpsProxy is not
    /// permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one
    /// that was supplied in the request. pathRedirect cannot be supplied
    /// together with prefixRedirect. Supply one alone or neither. If neither is
    /// supplied, the path of the original request will be used for the redirect.
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the
    /// HttpRouteRuleMatch, retaining the remaining portion of the URL before
    /// redirecting the request. prefixRedirect cannot be supplied together with
    /// pathRedirect. Supply one alone or neither. If neither is supplied, the
    /// path of the original request will be used for the redirect. The value
    /// must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is
    /// removed prior to redirecting the request. If set to false, the query
    /// portion of the original URL is retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherPathRule
{
    /// <summary>
    /// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleCustomErrorResponsePolicy? CustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// The list of path patterns to match. Each must start with / and the only place a
    /// * is allowed is at the end following a /. The string fed to the path matcher
    /// does not include any text after the first ? or #, and those chars are not
    /// allowed here.
    /// </summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>
    /// In response to a matching matchRule, the load balancer performs advanced routing
    /// actions like URL rewrites, header transformations, etc. prior to forwarding the
    /// request to the selected backend. If  routeAction specifies any
    /// weightedBackendServices, service must not be set. Conversely if service is set,
    /// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
    /// or urlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routeAction")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleRouteAction? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2URLMapStatusAtProviderPathMatcherPathRuleUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule
{
    /// <summary>Valid values include:</summary>
    [JsonPropertyName("matchResponseCodes")]
    public IList<string>? MatchResponseCodes { get; set; }

    /// <summary>
    /// The HTTP status code returned with the response containing the custom error content.
    /// If overrideResponseCode is not supplied, the same response code returned by the original backend bucket or backend service is returned to the client.
    /// </summary>
    [JsonPropertyName("overrideResponseCode")]
    public double? OverrideResponseCode { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>
/// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesCustomErrorResponsePolicy
{
    /// <summary>
    /// Specifies rules for returning error responses.
    /// In a given policy, if you specify rules for both a range of error codes as well as rules for specific error codes then rules with specific error codes have a higher priority.
    /// For example, assume that you configure a rule for 401 (Un-authorized) code, and another for all 4 series error codes (4XX).
    /// If the backend service returns a 401, then the rule for 401 will be applied. However if the backend service returns a 403, the rule for 4xx takes effect.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("errorResponseRule")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRulesCustomErrorResponsePolicyErrorResponseRule>? ErrorResponseRule { get; set; }

    /// <summary>
    /// The full or partial URL to the BackendBucket resource that contains the custom error content. Examples are:
    /// https://www.googleapis.com/compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// compute/v1/projects/project/global/backendBuckets/myBackendBucket
    /// global/backendBuckets/myBackendBucket
    /// If errorService is not specified at lower levels like pathMatcher, pathRule and routeRule, an errorService specified at a higher level in the UrlMap will be used. If UrlMap.defaultCustomErrorResponsePolicy contains one or more errorResponseRules[], it must specify errorService.
    /// If load balancer cannot reach the backendBucket, a simple Not Found Error will be returned, with the original response code (or overrideResponseCode if configured).
    /// </summary>
    [JsonPropertyName("errorService")]
    public string? ErrorService { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

/// <summary>
/// The header value must be an integer and its value must be in the range specified
/// in rangeMatch. If the header does not contain an integer, number or is empty,
/// the match fails. For example for a range [-5, 0]   - -3 will match.  - 0 will
/// not match.  - 0.25 will not match.  - -3someString will not match.   Only one of
/// exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch
/// must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
{
    /// <summary>The end of the range (exclusive).</summary>
    [JsonPropertyName("rangeEnd")]
    public double? RangeEnd { get; set; }

    /// <summary>The start of the range (inclusive).</summary>
    [JsonPropertyName("rangeStart")]
    public double? RangeStart { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatches
{
    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter exactly matches
    /// the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch
    /// must be set.
    /// </summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>
    /// If set to false, the headerMatch is considered a match if the match criteria
    /// above are met. If set to true, the headerMatch is considered a match if the
    /// match criteria above are NOT met. Defaults to false.
    /// </summary>
    [JsonPropertyName("invertMatch")]
    public bool? InvertMatch { get; set; }

    /// <summary>
    /// For satisfying the matchRule condition, the request&apos;s path must begin with the
    /// specified prefixMatch. prefixMatch must begin with a /. The value must be
    /// between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or
    /// regexMatch must be specified.
    /// </summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>
    /// Specifies that the queryParameterMatch matches if the request contains the query
    /// parameter, irrespective of whether the parameter has a value or not. Only one of
    /// presentMatch, exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>
    /// The header value must be an integer and its value must be in the range specified
    /// in rangeMatch. If the header does not contain an integer, number or is empty,
    /// the match fails. For example for a range [-5, 0]   - -3 will match.  - 0 will
    /// not match.  - 0.25 will not match.  - -3someString will not match.   Only one of
    /// exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch
    /// must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rangeMatch")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch? RangeMatch { get; set; }

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter matches the
    /// regular expression specified by regexMatch. For the regular expression grammar,
    /// please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch,
    /// exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }

    /// <summary>
    /// The value of the header must end with the contents of suffixMatch. Only one of
    /// exactMatch, prefixMatch, suffixMatch, regexMatch, presentMatch or rangeMatch
    /// must be set.
    /// </summary>
    [JsonPropertyName("suffixMatch")]
    public string? SuffixMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>
    /// The list of label value pairs that must match labels in the provided metadata
    /// based on filterMatchCriteria  This list must not be empty and can have at the
    /// most 64 entries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>
    /// Specifies how individual filterLabel matches within the list of filterLabels
    /// contribute towards the overall metadataFilter match. Supported values are:
    /// </summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
{
    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter exactly matches
    /// the contents of exactMatch. Only one of presentMatch, exactMatch and regexMatch
    /// must be set.
    /// </summary>
    [JsonPropertyName("exactMatch")]
    public string? ExactMatch { get; set; }

    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Specifies that the queryParameterMatch matches if the request contains the query
    /// parameter, irrespective of whether the parameter has a value or not. Only one of
    /// presentMatch, exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("presentMatch")]
    public bool? PresentMatch { get; set; }

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter matches the
    /// regular expression specified by regexMatch. For the regular expression grammar,
    /// please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch,
    /// exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRules
{
    /// <summary>
    /// For satisfying the matchRule condition, the path of the request must exactly
    /// match the value specified in fullPathMatch after removing any query parameters
    /// and anchor that may be part of the original URL. FullPathMatch must be between 1
    /// and 1024 characters. Only one of prefixMatch, fullPathMatch or regexMatch must
    /// be specified.
    /// </summary>
    [JsonPropertyName("fullPathMatch")]
    public string? FullPathMatch { get; set; }

    /// <summary>
    /// Specifies a list of header match criteria, all of which must match corresponding
    /// headers in the request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerMatches")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

    /// <summary>
    /// Specifies that prefixMatch and fullPathMatch matches are case sensitive.
    /// Defaults to false.
    /// </summary>
    [JsonPropertyName("ignoreCase")]
    public bool? IgnoreCase { get; set; }

    /// <summary>
    /// Opaque filter criteria used by Loadbalancer to restrict routing configuration to
    /// a limited set xDS compliant clients. In their xDS requests to Loadbalancer, xDS
    /// clients present node metadata. If a match takes place, the relevant routing
    /// configuration is made available to those proxies. For each metadataFilter in
    /// this list, if its filterMatchCriteria is set to MATCH_ANY, at least one of the
    /// filterLabels must match the corresponding label provided in the metadata. If its
    /// filterMatchCriteria is set to MATCH_ALL, then all of its filterLabels must match
    /// with corresponding labels in the provided metadata. metadataFilters specified
    /// here can be overrides those specified in ForwardingRule that refers to this
    /// UrlMap. metadataFilters only applies to Loadbalancers that have their
    /// loadBalancingScheme set to INTERNAL_SELF_MANAGED.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metadataFilters")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

    /// <summary>
    /// For satisfying the matchRule condition, the path of the request
    /// must match the wildcard pattern specified in pathTemplateMatch
    /// after removing any query parameters and anchor that may be part
    /// of the original URL.
    /// pathTemplateMatch must be between 1 and 255 characters
    /// (inclusive).  The pattern specified by pathTemplateMatch may
    /// have at most 5 wildcard operators and at most 5 variable
    /// captures in total.
    /// </summary>
    [JsonPropertyName("pathTemplateMatch")]
    public string? PathTemplateMatch { get; set; }

    /// <summary>
    /// For satisfying the matchRule condition, the request&apos;s path must begin with the
    /// specified prefixMatch. prefixMatch must begin with a /. The value must be
    /// between 1 and 1024 characters. Only one of prefixMatch, fullPathMatch or
    /// regexMatch must be specified.
    /// </summary>
    [JsonPropertyName("prefixMatch")]
    public string? PrefixMatch { get; set; }

    /// <summary>
    /// Specifies a list of query parameter match criteria, all of which must match
    /// corresponding query parameters in the request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("queryParameterMatches")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

    /// <summary>
    /// The queryParameterMatch matches if the value of the parameter matches the
    /// regular expression specified by regexMatch. For the regular expression grammar,
    /// please see en.cppreference.com/w/cpp/regex/ecmascript  Only one of presentMatch,
    /// exactMatch and regexMatch must be set.
    /// </summary>
    [JsonPropertyName("regexMatch")]
    public string? RegexMatch { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionCorsPolicy
{
    /// <summary>
    /// In response to a preflight request, setting this to true indicates that the
    /// actual request can include user credentials. This translates to the Access-
    /// Control-Allow-Credentials header. Defaults to false.
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Headers header.</summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>Specifies the content for the Access-Control-Allow-Methods header.</summary>
    [JsonPropertyName("allowMethods")]
    public IList<string>? AllowMethods { get; set; }

    /// <summary>
    /// Specifies the regular expression patterns that match allowed origins. For
    /// regular expression grammar please see en.cppreference.com/w/cpp/regex/ecmascript
    /// An origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOriginRegexes")]
    public IList<string>? AllowOriginRegexes { get; set; }

    /// <summary>
    /// Specifies the list of origins that will be allowed to do CORS requests. An
    /// origin is allowed if it matches either allow_origins or allow_origin_regex.
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>If true, specifies the CORS policy is disabled.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Specifies the content for the Access-Control-Expose-Headers header.</summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// Specifies how long the results of a preflight request can be cached. This
    /// translates to the content for the Access-Control-Max-Age header.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public double? MaxAge { get; set; }
}

/// <summary>
/// The specification for how client requests are aborted as part of fault
/// injection.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
{
    /// <summary>
    /// The HTTP status code used to abort the request. The value must be between 200
    /// and 599 inclusive.
    /// </summary>
    [JsonPropertyName("httpStatus")]
    public double? HttpStatus { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// Specifies the value of the fixed delay interval.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The specification for how client requests are delayed as part of fault
/// injection, before being sent to a backend service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

    /// <summary>
    /// The percentage of traffic (connections/operations/requests) on which delay will
    /// be introduced as part of fault injection. The value must be between 0.0 and
    /// 100.0 inclusive.
    /// </summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>
/// The specification for fault injection introduced into traffic to test the
/// resiliency of clients to backend service failure. As part of fault injection,
/// when clients send requests to a backend service, delays can be introduced by
/// Loadbalancer on a percentage of requests before sending those request to the
/// backend service. Similarly requests from clients can be aborted by the
/// Loadbalancer for a percentage of requests. timeout and retry_policy will be
/// ignored by clients that are configured with a fault_injection_policy.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the maximum duration (timeout) for streams on the selected route.
/// Unlike the Timeout field where the timeout duration starts from the time the request
/// has been fully processed (known as end-of-stream), the duration in this field
/// is computed from the beginning of the stream until the response has been processed,
/// including all retries. A stream that does not complete in this duration is closed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionMaxStreamDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are
/// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
/// responses from the shadow service. Prior to sending traffic to the shadow
/// service, the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// Specifies the retry policy associated with this route.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

    /// <summary>Specifies one or more conditions when this retry rule applies. Valid values are:</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>
/// Specifies the timeout for the selected route. Timeout is computed from the time
/// the request is has been fully processed (i.e. end-of-stream) up until the
/// response has been completely processed. Timeout includes all retries. If not
/// specified, the default value is 15 seconds.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond resolution. Durations
    /// less than one second are represented with a 0 seconds field and a positive
    /// nanos field. Must be from 0 to 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second. Must be from 0 to 315,576,000,000
    /// inclusive.
    /// </summary>
    [JsonPropertyName("seconds")]
    public string? Seconds { get; set; }
}

/// <summary>
/// The spec to modify the URL of the request, prior to forwarding the request to
/// the matched service
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionUrlRewrite
{
    /// <summary>
    /// Prior to forwarding the request to the selected service, the request&apos;s host
    /// header is replaced with contents of hostRewrite. The value must be between 1 and
    /// 255 characters.
    /// </summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected backend service, the matching
    /// portion of the request&apos;s path is replaced by pathPrefixRewrite. The value must
    /// be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathPrefixRewrite")]
    public string? PathPrefixRewrite { get; set; }

    /// <summary>
    /// Prior to forwarding the request to the selected origin, if the
    /// request matched a pathTemplateMatch, the matching portion of the
    /// request&apos;s path is replaced re-written using the pattern specified
    /// by pathTemplateRewrite.
    /// pathTemplateRewrite must be between 1 and 255 characters
    /// (inclusive), must start with a &apos;/&apos;, and must only use variables
    /// captured by the route&apos;s pathTemplate matchers.
    /// pathTemplateRewrite may only be used when all of a route&apos;s
    /// MatchRules specify pathTemplate.
    /// Only one of pathPrefixRewrite and pathTemplateRewrite may be
    /// specified.
    /// </summary>
    [JsonPropertyName("pathTemplateRewrite")]
    public string? PathTemplateRewrite { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
{
    /// <summary>The name of the header.</summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string? HeaderValue { get; set; }

    /// <summary>
    /// If false, headerValue is appended to any values that already exist for the
    /// header. If true, headerValue is set for the header, discarding any values that
    /// were set for that header.
    /// </summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

/// <summary>
/// Specifies changes to request and response headers that need to take effect for
/// the selected backendService. headerAction specified here take effect before
/// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the request
    /// prior to forwarding the request to the backendService.
    /// </summary>
    [JsonPropertyName("requestHeadersToRemove")]
    public IList<string>? RequestHeadersToRemove { get; set; }

    /// <summary>
    /// Headers to add the response prior to sending the response back to the client.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("responseHeadersToAdd")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default BackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// Specifies the fraction of traffic sent to backendService, computed as weight /
    /// (sum of all weightedBackendService weights in routeAction) . The selection of a
    /// backend service is determined only for new traffic. Once a user&apos;s request has
    /// been directed to a backendService, subsequent requests will be sent to the same
    /// backendService as determined by the BackendService&apos;s session affinity policy.
    /// The value must be between 0 and 1000
    /// </summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// In response to a matching matchRule, the load balancer performs advanced routing
/// actions like URL rewrites, header transformations, etc. prior to forwarding the
/// request to the selected backend. If  routeAction specifies any
/// weightedBackendServices, service must not be set. Conversely if service is set,
/// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
/// or urlRedirect must be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the
    /// resiliency of clients to backend service failure. As part of fault injection,
    /// when clients send requests to a backend service, delays can be introduced by
    /// Loadbalancer on a percentage of requests before sending those request to the
    /// backend service. Similarly requests from clients can be aborted by the
    /// Loadbalancer for a percentage of requests. timeout and retry_policy will be
    /// ignored by clients that are configured with a fault_injection_policy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match
    /// occurs. The weights determine the fraction of traffic that flows to their
    /// corresponding backend service. If all traffic needs to go to a single backend
    /// service, there must be one  weightedBackendService with weight set to a non 0
    /// number. Once a backendService is identified and before forwarding the request to
    /// the backend service, advanced routing actions like Url rewrites and header
    /// transformations are applied depending on additional settings specified in this
    /// HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRulesUrlRedirect
{
    /// <summary>
    /// The host that will be used in the redirect response instead of the one
    /// that was supplied in the request. The value must be between 1 and 255
    /// characters.
    /// </summary>
    [JsonPropertyName("hostRedirect")]
    public string? HostRedirect { get; set; }

    /// <summary>
    /// If set to true, the URL scheme in the redirected request is set to https.
    /// If set to false, the URL scheme of the redirected request will remain the
    /// same as that of the request. This must only be set for UrlMaps used in
    /// TargetHttpProxys. Setting this true for TargetHttpsProxy is not
    /// permitted. The default is set to false.
    /// </summary>
    [JsonPropertyName("httpsRedirect")]
    public bool? HttpsRedirect { get; set; }

    /// <summary>
    /// The path that will be used in the redirect response instead of the one
    /// that was supplied in the request. pathRedirect cannot be supplied
    /// together with prefixRedirect. Supply one alone or neither. If neither is
    /// supplied, the path of the original request will be used for the redirect.
    /// The value must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("pathRedirect")]
    public string? PathRedirect { get; set; }

    /// <summary>
    /// The prefix that replaces the prefixMatch specified in the
    /// HttpRouteRuleMatch, retaining the remaining portion of the URL before
    /// redirecting the request. prefixRedirect cannot be supplied together with
    /// pathRedirect. Supply one alone or neither. If neither is supplied, the
    /// path of the original request will be used for the redirect. The value
    /// must be between 1 and 1024 characters.
    /// </summary>
    [JsonPropertyName("prefixRedirect")]
    public string? PrefixRedirect { get; set; }

    /// <summary>The HTTP Status code to use for this RedirectAction. Supported values are:</summary>
    [JsonPropertyName("redirectResponseCode")]
    public string? RedirectResponseCode { get; set; }

    /// <summary>
    /// If set to true, any accompanying query portion of the original URL is
    /// removed prior to redirecting the request. If set to false, the query
    /// portion of the original URL is retained.
    /// This field is required to ensure an empty block is not set. The normal default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcherRouteRules
{
    /// <summary>
    /// customErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customErrorResponsePolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesCustomErrorResponsePolicy? CustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// The rules for determining a match.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

    /// <summary>
    /// For routeRules within a given pathMatcher, priority determines the order
    /// in which load balancer will interpret routeRules. RouteRules are evaluated
    /// in order of priority, from the lowest to highest number. The priority of
    /// a rule decreases as its number increases (1, 2, 3, N+1). The first rule
    /// that matches the request is applied.
    /// You cannot configure two or more routeRules with the same priority.
    /// Priority for each rule must be set to a number between 0 and
    /// 2147483647 inclusive.
    /// Priority numbers can have gaps, which enable you to add or remove rules
    /// in the future without affecting the rest of the rules. For example,
    /// 1, 2, 3, 4, 5, 9, 12, 16 is a valid series of priority numbers to which
    /// you could add rules numbered from 6 to 8, 10 to 11, and 13 to 15 in the
    /// future without any impact on existing rules.
    /// </summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// In response to a matching matchRule, the load balancer performs advanced routing
    /// actions like URL rewrites, header transformations, etc. prior to forwarding the
    /// request to the selected backend. If  routeAction specifies any
    /// weightedBackendServices, service must not be set. Conversely if service is set,
    /// routeAction cannot contain any  weightedBackendServices. Only one of routeAction
    /// or urlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routeAction")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesRouteAction? RouteAction { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2URLMapStatusAtProviderPathMatcherRouteRulesUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderPathMatcher
{
    /// <summary>
    /// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// For example, consider a UrlMap with the following configuration:
    /// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
    /// A RouteRule for /coming_soon/ is configured for the error code 404.
    /// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
    /// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultCustomErrorResponsePolicy? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs
    /// advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request
    /// to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set.
    /// Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given paths match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2URLMapStatusAtProviderPathMatcherDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. HeaderAction specified here are applied after the
    /// matching HttpRouteRule HeaderAction and before the HeaderAction in the UrlMap
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapStatusAtProviderPathMatcherHeaderAction? HeaderAction { get; set; }

    /// <summary>The name to which this PathMatcher is referred by the HostRule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The list of path rules. Use this list instead of routeRules when routing based
    /// on simple path matching is all that&apos;s required. The order by which path rules
    /// are specified does not matter. Matches are always done on the longest-path-first
    /// basis. For example: a pathRule with a path /a/b/c/* will match before /a/b/*
    /// irrespective of the order in which those paths appear in this list. Within a
    /// given pathMatcher, only one of pathRules or routeRules must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pathRule")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherPathRule>? PathRule { get; set; }

    /// <summary>
    /// The list of ordered HTTP route rules. Use this list instead of pathRules when
    /// advanced route matching and routing actions are desired. The order of specifying
    /// routeRules matters: the first rule that matches will cause its specified routing
    /// action to take effect. Within a given pathMatcher, only one of pathRules or
    /// routeRules must be set. routeRules are not supported in UrlMaps intended for
    /// External load balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("routeRules")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderTestHeaders
{
    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The expected output URL evaluated by the load balancer containing the scheme, host, path and query parameters.
    /// For rules that forward requests to backends, the test passes only when expectedOutputUrl matches the request forwarded by the load balancer to backends. For rules with urlRewrite, the test verifies that the forwarded request matches hostRewrite and pathPrefixRewrite in the urlRewrite action. When service is specified, expectedOutputUrl`s scheme is ignored.
    /// For rules with urlRedirect, the test passes only if expectedOutputUrl matches the URL in the load balancer&apos;s redirect response. If urlRedirect specifies httpsRedirect, the test passes only if the scheme in expectedOutputUrl is also set to HTTPS. If urlRedirect specifies stripQuery, the test passes only if expectedOutputUrl does not contain any query parameters.
    /// expectedOutputUrl is optional when service is specified.
    /// </summary>
    [JsonPropertyName("expectedOutputUrl")]
    public string? ExpectedOutputUrl { get; set; }

    /// <summary>
    /// For rules with urlRedirect, the test passes only if expectedRedirectResponseCode matches the HTTP status code in load balancer&apos;s redirect response.
    /// expectedRedirectResponseCode cannot be set when service is set.
    /// </summary>
    [JsonPropertyName("expectedRedirectResponseCode")]
    public double? ExpectedRedirectResponseCode { get; set; }

    /// <summary>
    /// HTTP headers for this request.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headers")]
    public IList<V1beta2URLMapStatusAtProviderTestHeaders>? Headers { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The backend service or backend bucket link that should be matched by this test.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusAtProvider
{
    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>
    /// defaultCustomErrorResponsePolicy specifies how the Load Balancer returns error responses when BackendService or BackendBucket responds with an error.
    /// This policy takes effect at the PathMatcher level and applies only when no policy has been defined for the error code at lower levels like RouteRule and PathRule within this PathMatcher. If an error code does not have a policy defined in defaultCustomErrorResponsePolicy, then a policy defined for the error code in UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// For example, consider a UrlMap with the following configuration:
    /// UrlMap.defaultCustomErrorResponsePolicy is configured with policies for 5xx and 4xx errors
    /// A RouteRule for /coming_soon/ is configured for the error code 404.
    /// If the request is for www.myotherdomain.com and a 404 is encountered, the policy under UrlMap.defaultCustomErrorResponsePolicy takes effect. If a 404 response is encountered for the request www.example.com/current_events/, the pathMatcher&apos;s policy takes effect. If however, the request for www.example.com/coming_soon/ encounters a 404, the policy in RouteRule.customErrorResponsePolicy takes effect. If any of the requests in this example encounter a 500 error code, the policy at UrlMap.defaultCustomErrorResponsePolicy takes effect.
    /// When used in conjunction with pathMatcher.defaultRouteAction.retryPolicy, retries take precedence. Only once all retries are exhausted, the defaultCustomErrorResponsePolicy is applied. While attempting a retry, if load balancer is successful in reaching the service, the defaultCustomErrorResponsePolicy is ignored and the response from the service is returned to the client.
    /// defaultCustomErrorResponsePolicy is supported only for global external Application Load Balancers.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultCustomErrorResponsePolicy")]
    public V1beta2URLMapStatusAtProviderDefaultCustomErrorResponsePolicy? DefaultCustomErrorResponsePolicy { get; set; }

    /// <summary>
    /// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions
    /// like URL rewrites, header transformations, etc. prior to forwarding the request to the selected backend.
    /// If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService
    /// is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2URLMapStatusAtProviderDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>The backend service or backend bucket to use when none of the given rules match.</summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2URLMapStatusAtProviderDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when you create
    /// the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Fingerprint of this resource. A hash of the contents stored in this object. This
    /// field is used in optimistic locking.
    /// </summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. The headerAction specified here take effect after
    /// headerAction specified under pathMatcher.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2URLMapStatusAtProviderHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// The list of HostRules to use against the URL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta2URLMapStatusAtProviderHostRule>? HostRule { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/urlMaps/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The unique identifier for the resource.</summary>
    [JsonPropertyName("mapId")]
    public double? MapId { get; set; }

    /// <summary>
    /// The list of named PathMatchers to use against the URL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta2URLMapStatusAtProviderPathMatcher>? PathMatcher { get; set; }

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
    /// The list of expected URL mapping tests. Request to update this UrlMap will
    /// succeed only if all of the test cases pass. You can specify a maximum of 100
    /// tests per UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("test")]
    public IList<V1beta2URLMapStatusAtProviderTest>? Test { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatusConditions
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

/// <summary>URLMapStatus defines the observed state of URLMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2URLMapStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2URLMapStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2URLMapStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>URLMap is the Schema for the URLMaps API. UrlMaps are used to route requests to a backend service based on rules that you define for the host and path of an incoming URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2URLMap : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2URLMapSpec>, IStatus<V1beta2URLMapStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "URLMap";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "urlmaps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "URLMap";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>URLMapSpec defines the desired state of URLMap</summary>
    [JsonPropertyName("spec")]
    public required V1beta2URLMapSpec Spec { get; set; }

    /// <summary>URLMapStatus defines the observed state of URLMap.</summary>
    [JsonPropertyName("status")]
    public V1beta2URLMapStatus? Status { get; set; }
}