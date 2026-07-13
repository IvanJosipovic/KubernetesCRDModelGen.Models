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
/// <summary>RegionURLMap is the Schema for the RegionURLMaps API. UrlMaps are used to route requests to a backend service based on rules that you define for the host and path of an incoming URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegionURLMapList : IKubernetesObject<V1ListMeta>, IItems<V1beta2RegionURLMap>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegionURLMapList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionurlmaps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionURLMapList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2RegionURLMap objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2RegionURLMap> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecDeletionPolicyEnum>))]
public enum V1beta2RegionURLMapSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see
/// W3C Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
/// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
/// the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionTimeout
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
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionUrlRewrite
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelector
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
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
/// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions, such as URL rewrites and header transformations, before forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
/// Only one of defaultRouteAction or defaultUrlRedirect must be set.
/// URL maps for Classic external HTTP(S) load balancers only support the urlRewrite action within defaultRouteAction.
/// defaultRouteAction has no effect when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see
    /// W3C Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure.
    /// As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a
    /// percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted
    /// by the Loadbalancer for a percentage of requests.
    /// timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
    /// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
    /// the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time the request has been
    /// fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries.
    /// If not specified, will use the largest timeout among all backend services associated with the route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to the matched service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match occurs.
    /// The weights determine the fraction of traffic that flows to their corresponding backend service.
    /// If all traffic needs to go to a single backend service, there must be one weightedBackendService
    /// with weight set to a non-zero number.
    /// Once a backendService is identified and before forwarding the request to the backend service,
    /// advanced routing actions like Url rewrites and header transformations are applied depending on
    /// additional settings specified in this HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2RegionURLMapSpecForProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderDefaultServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderDefaultServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecForProviderDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderDefaultServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderDefaultServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderDefaultServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderDefaultServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultServiceSelector
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
    public V1beta2RegionURLMapSpecForProviderDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderDefaultUrlRedirect
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
public partial class V1beta2RegionURLMapSpecForProviderHostRule
{
    /// <summary>
    /// An optional description of this HostRule. Provide this property
    /// when you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The list of host patterns to match. They must be valid
    /// hostnames, except * will match any string of ([a-z0-9-.]*). In
    /// that case, * must be the first character and must be followed in
    /// the pattern by either - or ..
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// The name of the PathMatcher to use to match the path portion of
    /// the URL if the hostRule matches the URL&apos;s host portion.
    /// </summary>
    [JsonPropertyName("pathMatcher")]
    public string? PathMatcher { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionMaxStreamDuration
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionTimeout
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionUrlRewrite
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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelector
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
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

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
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceSelector
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
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherDefaultUrlRedirect
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
    /// portion of the original URL is retained. The default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionTimeout
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionUrlRewrite
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector
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
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionCorsPolicy? CorsPolicy { get; set; }

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
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionUrlRewrite? UrlRewrite { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelector
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
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleUrlRedirect
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
    /// portion of the original URL is retained. The default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherPathRule
{
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
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleRouteAction? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleServiceSelector? ServiceSelector { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherPathRuleUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

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
/// the match fails. For example for a range [-5, 0]
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatches
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
    /// the match fails. For example for a range [-5, 0]
    /// </summary>
    [JsonPropertyName("rangeMatch")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch? RangeMatch { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value of the label must match the specified value. value can have a maximum
    /// length of 1024 characters.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>
    /// The list of label value pairs that must match labels in the provided metadata
    /// based on filterMatchCriteria  This list must not be empty and can have at the
    /// most 64 entries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>
    /// Specifies how individual filterLabel matches within the list of filterLabels
    /// contribute towards the overall metadataFilter match. Supported values are:
    /// </summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRules
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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionTimeout
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionUrlRewrite
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionCorsPolicy? CorsPolicy { get; set; }

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
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionUrlRewrite? UrlRewrite { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelector
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
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesUrlRedirect
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
    /// portion of the original URL is retained. The default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcherRouteRules
{
    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// The rules for determining a match.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

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
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesRouteAction? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesServiceSelector? ServiceSelector { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherRouteRulesUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderPathMatcher
{
    /// <summary>
    /// defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs
    /// advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request
    /// to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set.
    /// Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>
    /// A reference to a RegionBackendService resource. This will be used if
    /// none of the pathRules defined by this PathMatcher is matched by
    /// the URL&apos;s path portion.
    /// </summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2RegionURLMapSpecForProviderPathMatcherDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherPathRule>? PathRule { get; set; }

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
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderTestServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderTestServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderTestServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderTestServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderTestServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderTestServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderTestServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderTestServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecForProviderTestServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderTestServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecForProviderTestServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecForProviderTestServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecForProviderTestServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderTestServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecForProviderTestServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecForProviderTestServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderTestServiceSelector
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
    public V1beta2RegionURLMapSpecForProviderTestServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2RegionURLMapSpecForProviderTestServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2RegionURLMapSpecForProviderTestServiceSelector? ServiceSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecForProvider
{
    /// <summary>
    /// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions, such as URL rewrites and header transformations, before forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// URL maps for Classic external HTTP(S) load balancers only support the urlRewrite action within defaultRouteAction.
    /// defaultRouteAction has no effect when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2RegionURLMapSpecForProviderDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>
    /// The full or partial URL of the defaultService resource to which traffic is directed if
    /// none of the hostRules match. If defaultRouteAction is additionally specified, advanced
    /// routing actions like URL Rewrites, etc. take effect prior to sending the request to the
    /// backend. However, if defaultService is specified, defaultRouteAction cannot contain any
    /// weightedBackendServices. Conversely, if routeAction specifies any
    /// weightedBackendServices, service must not be specified.  Only one of defaultService,
    /// defaultUrlRedirect or defaultRouteAction.weightedBackendService must be set.
    /// </summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta2RegionURLMapSpecForProviderDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta2RegionURLMapSpecForProviderDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2RegionURLMapSpecForProviderDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The list of HostRules to use against the URL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta2RegionURLMapSpecForProviderHostRule>? HostRule { get; set; }

    /// <summary>
    /// The list of named PathMatchers to use against the URL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta2RegionURLMapSpecForProviderPathMatcher>? PathMatcher { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The Region in which the url map should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// The list of expected URL mappings. Requests to update this UrlMap will
    /// succeed only if all of the test cases pass.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("test")]
    public IList<V1beta2RegionURLMapSpecForProviderTest>? Test { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see
/// W3C Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
/// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
/// the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionTimeout
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
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionUrlRewrite
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelector
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
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
/// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions, such as URL rewrites and header transformations, before forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
/// Only one of defaultRouteAction or defaultUrlRedirect must be set.
/// URL maps for Classic external HTTP(S) load balancers only support the urlRewrite action within defaultRouteAction.
/// defaultRouteAction has no effect when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see
    /// W3C Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure.
    /// As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a
    /// percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted
    /// by the Loadbalancer for a percentage of requests.
    /// timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
    /// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
    /// the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time the request has been
    /// fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries.
    /// If not specified, will use the largest timeout among all backend services associated with the route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to the matched service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match occurs.
    /// The weights determine the fraction of traffic that flows to their corresponding backend service.
    /// If all traffic needs to go to a single backend service, there must be one weightedBackendService
    /// with weight set to a non-zero number.
    /// Once a backendService is identified and before forwarding the request to the backend service,
    /// advanced routing actions like Url rewrites and header transformations are applied depending on
    /// additional settings specified in this HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2RegionURLMapSpecInitProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderDefaultServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderDefaultServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecInitProviderDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderDefaultServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderDefaultServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderDefaultServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderDefaultServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultServiceSelector
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
    public V1beta2RegionURLMapSpecInitProviderDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderDefaultUrlRedirect
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
public partial class V1beta2RegionURLMapSpecInitProviderHostRule
{
    /// <summary>
    /// An optional description of this HostRule. Provide this property
    /// when you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The list of host patterns to match. They must be valid
    /// hostnames, except * will match any string of ([a-z0-9-.]*). In
    /// that case, * must be the first character and must be followed in
    /// the pattern by either - or ..
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// The name of the PathMatcher to use to match the path portion of
    /// the URL if the hostRule matches the URL&apos;s host portion.
    /// </summary>
    [JsonPropertyName("pathMatcher")]
    public string? PathMatcher { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionMaxStreamDuration
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionTimeout
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionUrlRewrite
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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelector
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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelector
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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultUrlRedirect
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
    /// portion of the original URL is retained. The default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector
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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicyBackendServiceSelector? BackendServiceSelector { get; set; }
}

/// <summary>
/// Specifies a non-zero timeout per retry attempt.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionTimeout
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionUrlRewrite
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector
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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
    /// forwarding the request to backendService, the loadbalancer applies any relevant
    /// headerActions specified as part of this backendServiceWeight.
    /// </summary>
    [JsonPropertyName("backendService")]
    public string? BackendService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceRef")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceRef? BackendServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate backendService.</summary>
    [JsonPropertyName("backendServiceSelector")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesBackendServiceSelector? BackendServiceSelector { get; set; }

    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionCorsPolicy? CorsPolicy { get; set; }

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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionUrlRewrite? UrlRewrite { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelector
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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleUrlRedirect
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
    /// portion of the original URL is retained. The default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherPathRule
{
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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleRouteAction? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleServiceSelector? ServiceSelector { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherPathRuleUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

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
/// the match fails. For example for a range [-5, 0]
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatches
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
    /// the match fails. For example for a range [-5, 0]
    /// </summary>
    [JsonPropertyName("rangeMatch")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch? RangeMatch { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value of the label must match the specified value. value can have a maximum
    /// length of 1024 characters.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>
    /// The list of label value pairs that must match labels in the provided metadata
    /// based on filterMatchCriteria  This list must not be empty and can have at the
    /// most 64 entries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>
    /// Specifies how individual filterLabel matches within the list of filterLabels
    /// contribute towards the overall metadataFilter match. Supported values are:
    /// </summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRules
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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionTimeout
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionUrlRewrite
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionCorsPolicy? CorsPolicy { get; set; }

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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionUrlRewrite? UrlRewrite { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelector
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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesUrlRedirect
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
    /// portion of the original URL is retained. The default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRules
{
    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// The rules for determining a match.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

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
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesRouteAction? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesServiceSelector? ServiceSelector { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRulesUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderPathMatcher
{
    /// <summary>
    /// defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs
    /// advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request
    /// to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set.
    /// Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>
    /// A reference to a RegionBackendService resource. This will be used if
    /// none of the pathRules defined by this PathMatcher is matched by
    /// the URL&apos;s path portion.
    /// </summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2RegionURLMapSpecInitProviderPathMatcherDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherPathRule>? PathRule { get; set; }

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
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderTestServiceRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderTestServiceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderTestServiceRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderTestServiceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderTestServiceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderTestServiceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderTestServiceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderTestServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecInitProviderTestServiceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderTestServiceSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderTestServiceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecInitProviderTestServiceSelectorPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecInitProviderTestServiceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderTestServiceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecInitProviderTestServiceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecInitProviderTestServiceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderTestServiceSelector
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
    public V1beta2RegionURLMapSpecInitProviderTestServiceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecInitProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta2RegionURLMapSpecInitProviderTestServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta2RegionURLMapSpecInitProviderTestServiceSelector? ServiceSelector { get; set; }
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
public partial class V1beta2RegionURLMapSpecInitProvider
{
    /// <summary>
    /// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions, such as URL rewrites and header transformations, before forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// URL maps for Classic external HTTP(S) load balancers only support the urlRewrite action within defaultRouteAction.
    /// defaultRouteAction has no effect when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2RegionURLMapSpecInitProviderDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>
    /// The full or partial URL of the defaultService resource to which traffic is directed if
    /// none of the hostRules match. If defaultRouteAction is additionally specified, advanced
    /// routing actions like URL Rewrites, etc. take effect prior to sending the request to the
    /// backend. However, if defaultService is specified, defaultRouteAction cannot contain any
    /// weightedBackendServices. Conversely, if routeAction specifies any
    /// weightedBackendServices, service must not be specified.  Only one of defaultService,
    /// defaultUrlRedirect or defaultRouteAction.weightedBackendService must be set.
    /// </summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>Reference to a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceRef")]
    public V1beta2RegionURLMapSpecInitProviderDefaultServiceRef? DefaultServiceRef { get; set; }

    /// <summary>Selector for a RegionBackendService in compute to populate defaultService.</summary>
    [JsonPropertyName("defaultServiceSelector")]
    public V1beta2RegionURLMapSpecInitProviderDefaultServiceSelector? DefaultServiceSelector { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2RegionURLMapSpecInitProviderDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The list of HostRules to use against the URL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta2RegionURLMapSpecInitProviderHostRule>? HostRule { get; set; }

    /// <summary>
    /// The list of named PathMatchers to use against the URL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pathMatcher")]
    public IList<V1beta2RegionURLMapSpecInitProviderPathMatcher>? PathMatcher { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The list of expected URL mappings. Requests to update this UrlMap will
    /// succeed only if all of the test cases pass.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("test")]
    public IList<V1beta2RegionURLMapSpecInitProviderTest>? Test { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecManagementPoliciesEnum>))]
public enum V1beta2RegionURLMapSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RegionURLMapSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionURLMapSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RegionURLMapSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionURLMapSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionURLMapSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionURLMapSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RegionURLMapSpec defines the desired state of RegionURLMap</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapSpec
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
    public V1beta2RegionURLMapSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RegionURLMapSpecForProvider ForProvider { get; set; }

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
    public V1beta2RegionURLMapSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RegionURLMapSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RegionURLMapSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RegionURLMapSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see
/// W3C Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>
/// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
/// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
/// the host / authority header is suffixed with -shadow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionTimeout
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
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionUrlRewrite
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
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
/// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions, such as URL rewrites and header transformations, before forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
/// Only one of defaultRouteAction or defaultUrlRedirect must be set.
/// URL maps for Classic external HTTP(S) load balancers only support the urlRewrite action within defaultRouteAction.
/// defaultRouteAction has no effect when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see
    /// W3C Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

    /// <summary>
    /// The specification for fault injection introduced into traffic to test the resiliency of clients to backend service failure.
    /// As part of fault injection, when clients send requests to a backend service, delays can be introduced by Loadbalancer on a
    /// percentage of requests before sending those request to the backend service. Similarly requests from clients can be aborted
    /// by the Loadbalancer for a percentage of requests.
    /// timeout and retryPolicy will be ignored by clients that are configured with a faultInjectionPolicy.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are shadowed to a separate mirrored backend service.
    /// Loadbalancer does not wait for responses from the shadow service. Prior to sending traffic to the shadow service,
    /// the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time the request has been
    /// fully processed (i.e. end-of-stream) up until the response has been completely processed. Timeout includes all retries.
    /// If not specified, will use the largest timeout among all backend services associated with the route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to the matched service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

    /// <summary>
    /// A list of weighted backend services to send traffic to when a route match occurs.
    /// The weights determine the fraction of traffic that flows to their corresponding backend service.
    /// If all traffic needs to go to a single backend service, there must be one weightedBackendService
    /// with weight set to a non-zero number.
    /// Once a backendService is identified and before forwarding the request to the backend service,
    /// advanced routing actions like Url rewrites and header transformations are applied depending on
    /// additional settings specified in this HttpRouteAction.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("weightedBackendServices")]
    public IList<V1beta2RegionURLMapStatusAtProviderDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderDefaultUrlRedirect
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
public partial class V1beta2RegionURLMapStatusAtProviderHostRule
{
    /// <summary>
    /// An optional description of this HostRule. Provide this property
    /// when you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The list of host patterns to match. They must be valid
    /// hostnames, except * will match any string of ([a-z0-9-.]*). In
    /// that case, * must be the first character and must be followed in
    /// the pattern by either - or ..
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// The name of the PathMatcher to use to match the path portion of
    /// the URL if the hostRule matches the URL&apos;s host portion.
    /// </summary>
    [JsonPropertyName("pathMatcher")]
    public string? PathMatcher { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionMaxStreamDuration
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionTimeout
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionUrlRewrite
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionCorsPolicy? CorsPolicy { get; set; }

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
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the maximum duration (timeout) for streams on the selected route.
    /// Unlike the Timeout field where the timeout duration starts from the time the request
    /// has been fully processed (known as end-of-stream), the duration in this field
    /// is computed from the beginning of the stream until the response has been processed,
    /// including all retries. A stream that does not complete in this duration is closed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxStreamDuration")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionMaxStreamDuration? MaxStreamDuration { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionUrlRewrite? UrlRewrite { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// When none of the specified hostRules match, the request is redirected to a URL specified
/// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
/// defaultRouteAction must not be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultUrlRedirect
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
    /// portion of the original URL is retained. The default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

/// <summary>
/// The specification for allowing client side cross-origin requests. Please see W3C
/// Recommendation for Cross Origin Resource Sharing
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionTimeout
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionUrlRewrite
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionCorsPolicy? CorsPolicy { get; set; }

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
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionUrlRewrite? UrlRewrite { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleUrlRedirect
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
    /// portion of the original URL is retained. The default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherPathRule
{
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
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleRouteAction? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherPathRuleUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

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
/// the match fails. For example for a range [-5, 0]
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatches
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
    /// the match fails. For example for a range [-5, 0]
    /// </summary>
    [JsonPropertyName("rangeMatch")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatchesRangeMatch? RangeMatch { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels
{
    /// <summary>
    /// The name of the query parameter to match. The query parameter must exist in the
    /// request, in the absence of which the request match fails.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value of the label must match the specified value. value can have a maximum
    /// length of 1024 characters.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFilters
{
    /// <summary>
    /// The list of label value pairs that must match labels in the provided metadata
    /// based on filterMatchCriteria  This list must not be empty and can have at the
    /// most 64 entries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("filterLabels")]
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFiltersFilterLabels>? FilterLabels { get; set; }

    /// <summary>
    /// Specifies how individual filterLabel matches within the list of filterLabels
    /// contribute towards the overall metadataFilter match. Supported values are:
    /// </summary>
    [JsonPropertyName("filterMatchCriteria")]
    public string? FilterMatchCriteria { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRules
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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesHeaderMatches>? HeaderMatches { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesMetadataFilters>? MetadataFilters { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRulesQueryParameterMatches>? QueryParameterMatches { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionCorsPolicy
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

    /// <summary>
    /// If true, specifies the CORS policy is disabled.
    /// which indicates that the CORS policy is in effect. Defaults to false.
    /// </summary>
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay
{
    /// <summary>
    /// Specifies the value of the fixed delay interval.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedDelay")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelayFixedDelay? FixedDelay { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy
{
    /// <summary>
    /// The specification for how client requests are aborted as part of fault
    /// injection.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("abort")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>
    /// The specification for how client requests are delayed as part of fault
    /// injection, before being sent to a backend service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("delay")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicyDelay? Delay { get; set; }
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicy
{
    /// <summary>Specifies the allowed number retries. This number must be &gt; 0.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>
    /// Specifies a non-zero timeout per retry attempt.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("perTryTimeout")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicyPerTryTimeout? PerTryTimeout { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionTimeout
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionUrlRewrite
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd
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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction
{
    /// <summary>
    /// Headers to add to a matching request prior to forwarding the request to the
    /// backendService.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderActionResponseHeadersToAdd>? ResponseHeadersToAdd { get; set; }

    /// <summary>
    /// A list of header names for headers that need to be removed from the response
    /// prior to sending the response back to the client.
    /// </summary>
    [JsonPropertyName("responseHeadersToRemove")]
    public IList<string>? ResponseHeadersToRemove { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServices
{
    /// <summary>
    /// The default RegionBackendService resource. Before
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
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServicesHeaderAction? HeaderAction { get; set; }

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
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteAction
{
    /// <summary>
    /// The specification for allowing client side cross-origin requests. Please see W3C
    /// Recommendation for Cross Origin Resource Sharing
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("corsPolicy")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionCorsPolicy? CorsPolicy { get; set; }

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
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>
    /// Specifies the policy on how requests intended for the route&apos;s backends are
    /// shadowed to a separate mirrored backend service. Loadbalancer does not wait for
    /// responses from the shadow service. Prior to sending traffic to the shadow
    /// service, the host / authority header is suffixed with -shadow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("requestMirrorPolicy")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRequestMirrorPolicy? RequestMirrorPolicy { get; set; }

    /// <summary>
    /// Specifies the retry policy associated with this route.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Specifies the timeout for the selected route. Timeout is computed from the time
    /// the request is has been fully processed (i.e. end-of-stream) up until the
    /// response has been completely processed. Timeout includes all retries. If not
    /// specified, the default value is 15 seconds.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeout")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionTimeout? Timeout { get; set; }

    /// <summary>
    /// The spec to modify the URL of the request, prior to forwarding the request to
    /// the matched service
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionUrlRewrite? UrlRewrite { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteActionWeightedBackendServices>? WeightedBackendServices { get; set; }
}

/// <summary>
/// When this rule is matched, the request is redirected to a URL specified by
/// urlRedirect. If urlRedirect is specified, service or routeAction must not be
/// set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesUrlRedirect
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
    /// portion of the original URL is retained. The default value is false.
    /// </summary>
    [JsonPropertyName("stripQuery")]
    public bool? StripQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRules
{
    /// <summary>
    /// Specifies changes to request and response headers that need to take effect for
    /// the selected backendService. headerAction specified here take effect before
    /// headerAction in the enclosing HttpRouteRule, PathMatcher and UrlMap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("headerAction")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesHeaderAction? HeaderAction { get; set; }

    /// <summary>
    /// The rules for determining a match.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("matchRules")]
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesMatchRules>? MatchRules { get; set; }

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
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesRouteAction? RouteAction { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// When this rule is matched, the request is redirected to a URL specified by
    /// urlRedirect. If urlRedirect is specified, service or routeAction must not be
    /// set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRulesUrlRedirect? UrlRedirect { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderPathMatcher
{
    /// <summary>
    /// defaultRouteAction takes effect when none of the pathRules or routeRules match. The load balancer performs
    /// advanced routing actions like URL rewrites, header transformations, etc. prior to forwarding the request
    /// to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set.
    /// Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>
    /// A reference to a RegionBackendService resource. This will be used if
    /// none of the pathRules defined by this PathMatcher is matched by
    /// the URL&apos;s path portion.
    /// </summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2RegionURLMapStatusAtProviderPathMatcherDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherPathRule>? PathRule { get; set; }

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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcherRouteRules>? RouteRules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProviderTest
{
    /// <summary>Description of this test case.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Host portion of the URL.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Path portion of the URL.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A reference to expected RegionBackendService resource the given URL should be mapped to.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusAtProvider
{
    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>
    /// defaultRouteAction takes effect when none of the hostRules match. The load balancer performs advanced routing actions, such as URL rewrites and header transformations, before forwarding the request to the selected backend. If defaultRouteAction specifies any weightedBackendServices, defaultService must not be set. Conversely if defaultService is set, defaultRouteAction cannot contain any weightedBackendServices.
    /// Only one of defaultRouteAction or defaultUrlRedirect must be set.
    /// URL maps for Classic external HTTP(S) load balancers only support the urlRewrite action within defaultRouteAction.
    /// defaultRouteAction has no effect when the URL map is bound to a target gRPC proxy that has the validateForProxyless field set to true.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultRouteAction")]
    public V1beta2RegionURLMapStatusAtProviderDefaultRouteAction? DefaultRouteAction { get; set; }

    /// <summary>
    /// The full or partial URL of the defaultService resource to which traffic is directed if
    /// none of the hostRules match. If defaultRouteAction is additionally specified, advanced
    /// routing actions like URL Rewrites, etc. take effect prior to sending the request to the
    /// backend. However, if defaultService is specified, defaultRouteAction cannot contain any
    /// weightedBackendServices. Conversely, if routeAction specifies any
    /// weightedBackendServices, service must not be specified.  Only one of defaultService,
    /// defaultUrlRedirect or defaultRouteAction.weightedBackendService must be set.
    /// </summary>
    [JsonPropertyName("defaultService")]
    public string? DefaultService { get; set; }

    /// <summary>
    /// When none of the specified hostRules match, the request is redirected to a URL specified
    /// by defaultUrlRedirect. If defaultUrlRedirect is specified, defaultService or
    /// defaultRouteAction must not be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("defaultUrlRedirect")]
    public V1beta2RegionURLMapStatusAtProviderDefaultUrlRedirect? DefaultUrlRedirect { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Fingerprint of this resource. This field is used internally during
    /// updates of this resource.
    /// </summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>
    /// The list of HostRules to use against the URL.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hostRule")]
    public IList<V1beta2RegionURLMapStatusAtProviderHostRule>? HostRule { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/urlMaps/{{name}}</summary>
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
    public IList<V1beta2RegionURLMapStatusAtProviderPathMatcher>? PathMatcher { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The Region in which the url map should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// The list of expected URL mappings. Requests to update this UrlMap will
    /// succeed only if all of the test cases pass.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("test")]
    public IList<V1beta2RegionURLMapStatusAtProviderTest>? Test { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatusConditions
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

/// <summary>RegionURLMapStatus defines the observed state of RegionURLMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionURLMapStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RegionURLMapStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RegionURLMapStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegionURLMap is the Schema for the RegionURLMaps API. UrlMaps are used to route requests to a backend service based on rules that you define for the host and path of an incoming URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegionURLMap : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RegionURLMapSpec>, IStatus<V1beta2RegionURLMapStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegionURLMap";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionurlmaps";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionURLMap";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionURLMapSpec defines the desired state of RegionURLMap</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RegionURLMapSpec Spec { get; set; }

    /// <summary>RegionURLMapStatus defines the observed state of RegionURLMap.</summary>
    [JsonPropertyName("status")]
    public V1beta2RegionURLMapStatus? Status { get; set; }
}