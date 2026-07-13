#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.traefik.io;
/// <summary>
/// TraefikService is the CRD implementation of a Traefik Service.
/// TraefikService object allows to:
/// - Apply weight to Services on load-balancing
/// - Mirror traffic on services
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/kubernetes/crd/http/traefikservice/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TraefikServiceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TraefikService>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TraefikServiceList";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "traefikservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TraefikServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TraefikService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TraefikService> Items { get; set; }
}

/// <summary>Errors defines which errors should trigger the use of the fallback service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverErrors
{
    /// <summary>
    /// MaxRequestBodyBytes defines the maximum size allowed for the body of the request.
    /// Default value is -1, which means unlimited size.
    /// </summary>
    [JsonPropertyName("maxRequestBodyBytes")]
    public long? MaxRequestBodyBytes { get; set; }

    /// <summary>Status defines the list of status code ranges for which the fallback service should be used.</summary>
    [JsonPropertyName("status")]
    public IList<string>? Status { get; set; }
}

/// <summary>Healthcheck defines health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverFallbackHealthCheck
{
    /// <summary>
    /// FollowRedirects defines whether redirects should be followed during the health check calls.
    /// Default: true
    /// </summary>
    [JsonPropertyName("followRedirects")]
    public bool? FollowRedirects { get; set; }

    /// <summary>Headers defines custom headers to be sent to the health check endpoint.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Hostname defines the value of hostname in the Host header of the health check request.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Interval defines the frequency of the health check calls for healthy targets.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("interval")]
    public IntOrString? Interval { get; set; }

    /// <summary>Method defines the healthcheck method.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Mode defines the health check mode.
    /// If defined to grpc, will use the gRPC health check protocol to probe the server.
    /// Default: http
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Path defines the server URL path for the health check endpoint.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port defines the server URL port for the health check endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Scheme replaces the server URL scheme for the health check endpoint.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>Status defines the expected HTTP status code of the response to the health check request.</summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// Timeout defines the maximum duration Traefik will wait for a health check request before considering the server unhealthy.
    /// Default: 5s
    /// </summary>
    [JsonPropertyName("timeout")]
    public IntOrString? Timeout { get; set; }

    /// <summary>
    /// UnhealthyInterval defines the frequency of the health check calls for unhealthy targets.
    /// When UnhealthyInterval is not defined, it defaults to the Interval value.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("unhealthyInterval")]
    public IntOrString? UnhealthyInterval { get; set; }
}

/// <summary>Kind defines the kind of the Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecFailoverFallbackKindEnum>))]
public enum V1alpha1TraefikServiceSpecFailoverFallbackKindEnum
{
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service,
    [EnumMember(Value = "TraefikService"), JsonStringEnumMemberName("TraefikService")]
    TraefikService
}

/// <summary>MiddlewareRef is a reference to a Middleware resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverFallbackMiddlewares
{
    /// <summary>Name defines the name of the referenced Middleware resource.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Middleware resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverFallbackPassiveHealthCheck
{
    /// <summary>FailureWindow defines the time window during which the failed attempts must occur for the server to be marked as unhealthy. It also defines for how long the server will be considered unhealthy.</summary>
    [JsonPropertyName("failureWindow")]
    public IntOrString? FailureWindow { get; set; }

    /// <summary>MaxFailedAttempts is the number of consecutive failed attempts allowed within the failure window before marking the server as unhealthy.</summary>
    [JsonPropertyName("maxFailedAttempts")]
    public int? MaxFailedAttempts { get; set; }
}

/// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverFallbackResponseForwarding
{
    /// <summary>
    /// FlushInterval defines the interval, in milliseconds, in between flushes to the client while copying the response body.
    /// A negative value means to flush immediately after each write to the client.
    /// This configuration is ignored when ReverseProxy recognizes a response as a streaming response;
    /// for such responses, writes are flushed to the client immediately.
    /// Default: 100ms
    /// </summary>
    [JsonPropertyName("flushInterval")]
    public string? FlushInterval { get; set; }
}

/// <summary>
/// SameSite defines the same site policy.
/// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecFailoverFallbackStickyCookieSameSiteEnum>))]
public enum V1alpha1TraefikServiceSpecFailoverFallbackStickyCookieSameSiteEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    [EnumMember(Value = "lax"), JsonStringEnumMemberName("lax")]
    Lax,
    [EnumMember(Value = "strict"), JsonStringEnumMemberName("strict")]
    Strict,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None1,
    [EnumMember(Value = "Lax"), JsonStringEnumMemberName("Lax")]
    Lax1,
    [EnumMember(Value = "Strict"), JsonStringEnumMemberName("Strict")]
    Strict1
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverFallbackStickyCookie
{
    /// <summary>
    /// Domain defines the host to which the cookie will be sent.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#domaindomain-value
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>HTTPOnly defines whether the cookie can be accessed by client-side APIs, such as JavaScript.</summary>
    [JsonPropertyName("httpOnly")]
    public bool? HttpOnly { get; set; }

    /// <summary>
    /// MaxAge defines the number of seconds until the cookie expires.
    /// When set to a negative number, the cookie expires immediately.
    /// When set to zero, the cookie never expires.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    /// <summary>Name defines the Cookie name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path defines the path that must exist in the requested URL for the browser to send the Cookie header.
    /// When not provided the cookie will be sent on every request to the domain.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#pathpath-value
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// SameSite defines the same site policy.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
    /// </summary>
    [JsonPropertyName("sameSite")]
    public V1alpha1TraefikServiceSpecFailoverFallbackStickyCookieSameSiteEnum? SameSite { get; set; }

    /// <summary>Secure defines whether the cookie can only be transmitted over an encrypted connection (i.e. HTTPS).</summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

/// <summary>
/// Sticky defines the sticky sessions configuration.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverFallbackSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1TraefikServiceSpecFailoverFallbackStickyCookie? Cookie { get; set; }
}

/// <summary>
/// Strategy defines the load balancing strategy between the servers.
/// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
/// RoundRobin value is deprecated and supported for backward compatibility.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecFailoverFallbackStrategyEnum>))]
public enum V1alpha1TraefikServiceSpecFailoverFallbackStrategyEnum
{
    [EnumMember(Value = "wrr"), JsonStringEnumMemberName("wrr")]
    Wrr,
    [EnumMember(Value = "p2c"), JsonStringEnumMemberName("p2c")]
    P2c,
    [EnumMember(Value = "hrw"), JsonStringEnumMemberName("hrw")]
    Hrw,
    [EnumMember(Value = "leasttime"), JsonStringEnumMemberName("leasttime")]
    Leasttime,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin
}

/// <summary>Fallback defines the fallback service to use when the main service returns an error.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverFallback
{
    /// <summary>Healthcheck defines health checks for ExternalName services.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1TraefikServiceSpecFailoverFallbackHealthCheck? HealthCheck { get; set; }

    /// <summary>Kind defines the kind of the Service.</summary>
    [JsonPropertyName("kind")]
    public V1alpha1TraefikServiceSpecFailoverFallbackKindEnum? Kind { get; set; }

    /// <summary>Middlewares defines the list of references to Middleware resources to apply to the service.</summary>
    [JsonPropertyName("middlewares")]
    public IList<V1alpha1TraefikServiceSpecFailoverFallbackMiddlewares>? Middlewares { get; set; }

    /// <summary>
    /// Name defines the name of the referenced Kubernetes Service or TraefikService.
    /// The differentiation between the two is specified in the Kind field.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Kubernetes Service or TraefikService.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// NativeLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the pods IPs or if the only child is the Kubernetes Service clusterIP.
    /// The Kubernetes Service itself does load-balance to the pods.
    /// By default, NativeLB is false.
    /// </summary>
    [JsonPropertyName("nativeLB")]
    public bool? NativeLB { get; set; }

    /// <summary>
    /// NodePortLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the nodes internal IPs using the nodePort when the service type is NodePort.
    /// It allows services to be reachable when Traefik runs externally from the Kubernetes cluster but within the same network of the nodes.
    /// By default, NodePortLB is false.
    /// </summary>
    [JsonPropertyName("nodePortLB")]
    public bool? NodePortLB { get; set; }

    /// <summary>
    /// PassHostHeader defines whether the client Host header is forwarded to the upstream Kubernetes Service.
    /// By default, passHostHeader is true.
    /// </summary>
    [JsonPropertyName("passHostHeader")]
    public bool? PassHostHeader { get; set; }

    /// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
    [JsonPropertyName("passiveHealthCheck")]
    public V1alpha1TraefikServiceSpecFailoverFallbackPassiveHealthCheck? PassiveHealthCheck { get; set; }

    /// <summary>
    /// Port defines the port of a Kubernetes Service.
    /// This can be a reference to a named port.
    /// </summary>
    [JsonPropertyName("port")]
    public IntOrString? Port { get; set; }

    /// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
    [JsonPropertyName("responseForwarding")]
    public V1alpha1TraefikServiceSpecFailoverFallbackResponseForwarding? ResponseForwarding { get; set; }

    /// <summary>
    /// Scheme defines the scheme to use for the request to the upstream Kubernetes Service.
    /// It defaults to https when Kubernetes Service port is 443, http otherwise.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// ServersTransport defines the name of ServersTransport resource to use.
    /// It allows to configure the transport between Traefik and your servers.
    /// Can only be used on a Kubernetes Service.
    /// </summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>
    /// Sticky defines the sticky sessions configuration.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
    /// </summary>
    [JsonPropertyName("sticky")]
    public V1alpha1TraefikServiceSpecFailoverFallbackSticky? Sticky { get; set; }

    /// <summary>
    /// Strategy defines the load balancing strategy between the servers.
    /// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
    /// RoundRobin value is deprecated and supported for backward compatibility.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V1alpha1TraefikServiceSpecFailoverFallbackStrategyEnum? Strategy { get; set; }

    /// <summary>
    /// Weight defines the weight and should only be specified when Name references a TraefikService object
    /// (and to be precise, one that embeds a Weighted Round Robin).
    /// </summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Healthcheck defines health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverServiceHealthCheck
{
    /// <summary>
    /// FollowRedirects defines whether redirects should be followed during the health check calls.
    /// Default: true
    /// </summary>
    [JsonPropertyName("followRedirects")]
    public bool? FollowRedirects { get; set; }

    /// <summary>Headers defines custom headers to be sent to the health check endpoint.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Hostname defines the value of hostname in the Host header of the health check request.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Interval defines the frequency of the health check calls for healthy targets.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("interval")]
    public IntOrString? Interval { get; set; }

    /// <summary>Method defines the healthcheck method.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Mode defines the health check mode.
    /// If defined to grpc, will use the gRPC health check protocol to probe the server.
    /// Default: http
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Path defines the server URL path for the health check endpoint.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port defines the server URL port for the health check endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Scheme replaces the server URL scheme for the health check endpoint.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>Status defines the expected HTTP status code of the response to the health check request.</summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// Timeout defines the maximum duration Traefik will wait for a health check request before considering the server unhealthy.
    /// Default: 5s
    /// </summary>
    [JsonPropertyName("timeout")]
    public IntOrString? Timeout { get; set; }

    /// <summary>
    /// UnhealthyInterval defines the frequency of the health check calls for unhealthy targets.
    /// When UnhealthyInterval is not defined, it defaults to the Interval value.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("unhealthyInterval")]
    public IntOrString? UnhealthyInterval { get; set; }
}

/// <summary>Kind defines the kind of the Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecFailoverServiceKindEnum>))]
public enum V1alpha1TraefikServiceSpecFailoverServiceKindEnum
{
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service,
    [EnumMember(Value = "TraefikService"), JsonStringEnumMemberName("TraefikService")]
    TraefikService
}

/// <summary>MiddlewareRef is a reference to a Middleware resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverServiceMiddlewares
{
    /// <summary>Name defines the name of the referenced Middleware resource.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Middleware resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverServicePassiveHealthCheck
{
    /// <summary>FailureWindow defines the time window during which the failed attempts must occur for the server to be marked as unhealthy. It also defines for how long the server will be considered unhealthy.</summary>
    [JsonPropertyName("failureWindow")]
    public IntOrString? FailureWindow { get; set; }

    /// <summary>MaxFailedAttempts is the number of consecutive failed attempts allowed within the failure window before marking the server as unhealthy.</summary>
    [JsonPropertyName("maxFailedAttempts")]
    public int? MaxFailedAttempts { get; set; }
}

/// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverServiceResponseForwarding
{
    /// <summary>
    /// FlushInterval defines the interval, in milliseconds, in between flushes to the client while copying the response body.
    /// A negative value means to flush immediately after each write to the client.
    /// This configuration is ignored when ReverseProxy recognizes a response as a streaming response;
    /// for such responses, writes are flushed to the client immediately.
    /// Default: 100ms
    /// </summary>
    [JsonPropertyName("flushInterval")]
    public string? FlushInterval { get; set; }
}

/// <summary>
/// SameSite defines the same site policy.
/// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecFailoverServiceStickyCookieSameSiteEnum>))]
public enum V1alpha1TraefikServiceSpecFailoverServiceStickyCookieSameSiteEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    [EnumMember(Value = "lax"), JsonStringEnumMemberName("lax")]
    Lax,
    [EnumMember(Value = "strict"), JsonStringEnumMemberName("strict")]
    Strict,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None1,
    [EnumMember(Value = "Lax"), JsonStringEnumMemberName("Lax")]
    Lax1,
    [EnumMember(Value = "Strict"), JsonStringEnumMemberName("Strict")]
    Strict1
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverServiceStickyCookie
{
    /// <summary>
    /// Domain defines the host to which the cookie will be sent.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#domaindomain-value
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>HTTPOnly defines whether the cookie can be accessed by client-side APIs, such as JavaScript.</summary>
    [JsonPropertyName("httpOnly")]
    public bool? HttpOnly { get; set; }

    /// <summary>
    /// MaxAge defines the number of seconds until the cookie expires.
    /// When set to a negative number, the cookie expires immediately.
    /// When set to zero, the cookie never expires.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    /// <summary>Name defines the Cookie name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path defines the path that must exist in the requested URL for the browser to send the Cookie header.
    /// When not provided the cookie will be sent on every request to the domain.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#pathpath-value
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// SameSite defines the same site policy.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
    /// </summary>
    [JsonPropertyName("sameSite")]
    public V1alpha1TraefikServiceSpecFailoverServiceStickyCookieSameSiteEnum? SameSite { get; set; }

    /// <summary>Secure defines whether the cookie can only be transmitted over an encrypted connection (i.e. HTTPS).</summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

/// <summary>
/// Sticky defines the sticky sessions configuration.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverServiceSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1TraefikServiceSpecFailoverServiceStickyCookie? Cookie { get; set; }
}

/// <summary>
/// Strategy defines the load balancing strategy between the servers.
/// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
/// RoundRobin value is deprecated and supported for backward compatibility.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecFailoverServiceStrategyEnum>))]
public enum V1alpha1TraefikServiceSpecFailoverServiceStrategyEnum
{
    [EnumMember(Value = "wrr"), JsonStringEnumMemberName("wrr")]
    Wrr,
    [EnumMember(Value = "p2c"), JsonStringEnumMemberName("p2c")]
    P2c,
    [EnumMember(Value = "hrw"), JsonStringEnumMemberName("hrw")]
    Hrw,
    [EnumMember(Value = "leasttime"), JsonStringEnumMemberName("leasttime")]
    Leasttime,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin
}

/// <summary>Service defines the main service to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailoverService
{
    /// <summary>Healthcheck defines health checks for ExternalName services.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1TraefikServiceSpecFailoverServiceHealthCheck? HealthCheck { get; set; }

    /// <summary>Kind defines the kind of the Service.</summary>
    [JsonPropertyName("kind")]
    public V1alpha1TraefikServiceSpecFailoverServiceKindEnum? Kind { get; set; }

    /// <summary>Middlewares defines the list of references to Middleware resources to apply to the service.</summary>
    [JsonPropertyName("middlewares")]
    public IList<V1alpha1TraefikServiceSpecFailoverServiceMiddlewares>? Middlewares { get; set; }

    /// <summary>
    /// Name defines the name of the referenced Kubernetes Service or TraefikService.
    /// The differentiation between the two is specified in the Kind field.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Kubernetes Service or TraefikService.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// NativeLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the pods IPs or if the only child is the Kubernetes Service clusterIP.
    /// The Kubernetes Service itself does load-balance to the pods.
    /// By default, NativeLB is false.
    /// </summary>
    [JsonPropertyName("nativeLB")]
    public bool? NativeLB { get; set; }

    /// <summary>
    /// NodePortLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the nodes internal IPs using the nodePort when the service type is NodePort.
    /// It allows services to be reachable when Traefik runs externally from the Kubernetes cluster but within the same network of the nodes.
    /// By default, NodePortLB is false.
    /// </summary>
    [JsonPropertyName("nodePortLB")]
    public bool? NodePortLB { get; set; }

    /// <summary>
    /// PassHostHeader defines whether the client Host header is forwarded to the upstream Kubernetes Service.
    /// By default, passHostHeader is true.
    /// </summary>
    [JsonPropertyName("passHostHeader")]
    public bool? PassHostHeader { get; set; }

    /// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
    [JsonPropertyName("passiveHealthCheck")]
    public V1alpha1TraefikServiceSpecFailoverServicePassiveHealthCheck? PassiveHealthCheck { get; set; }

    /// <summary>
    /// Port defines the port of a Kubernetes Service.
    /// This can be a reference to a named port.
    /// </summary>
    [JsonPropertyName("port")]
    public IntOrString? Port { get; set; }

    /// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
    [JsonPropertyName("responseForwarding")]
    public V1alpha1TraefikServiceSpecFailoverServiceResponseForwarding? ResponseForwarding { get; set; }

    /// <summary>
    /// Scheme defines the scheme to use for the request to the upstream Kubernetes Service.
    /// It defaults to https when Kubernetes Service port is 443, http otherwise.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// ServersTransport defines the name of ServersTransport resource to use.
    /// It allows to configure the transport between Traefik and your servers.
    /// Can only be used on a Kubernetes Service.
    /// </summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>
    /// Sticky defines the sticky sessions configuration.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
    /// </summary>
    [JsonPropertyName("sticky")]
    public V1alpha1TraefikServiceSpecFailoverServiceSticky? Sticky { get; set; }

    /// <summary>
    /// Strategy defines the load balancing strategy between the servers.
    /// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
    /// RoundRobin value is deprecated and supported for backward compatibility.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V1alpha1TraefikServiceSpecFailoverServiceStrategyEnum? Strategy { get; set; }

    /// <summary>
    /// Weight defines the weight and should only be specified when Name references a TraefikService object
    /// (and to be precise, one that embeds a Weighted Round Robin).
    /// </summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Failover defines the Failover service configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecFailover
{
    /// <summary>Errors defines which errors should trigger the use of the fallback service.</summary>
    [JsonPropertyName("errors")]
    public required V1alpha1TraefikServiceSpecFailoverErrors Errors { get; set; }

    /// <summary>Fallback defines the fallback service to use when the main service returns an error.</summary>
    [JsonPropertyName("fallback")]
    public required V1alpha1TraefikServiceSpecFailoverFallback Fallback { get; set; }

    /// <summary>Service defines the main service to use.</summary>
    [JsonPropertyName("service")]
    public required V1alpha1TraefikServiceSpecFailoverService Service { get; set; }
}

/// <summary>Healthcheck defines health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecHighestRandomWeightServicesHealthCheck
{
    /// <summary>
    /// FollowRedirects defines whether redirects should be followed during the health check calls.
    /// Default: true
    /// </summary>
    [JsonPropertyName("followRedirects")]
    public bool? FollowRedirects { get; set; }

    /// <summary>Headers defines custom headers to be sent to the health check endpoint.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Hostname defines the value of hostname in the Host header of the health check request.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Interval defines the frequency of the health check calls for healthy targets.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("interval")]
    public IntOrString? Interval { get; set; }

    /// <summary>Method defines the healthcheck method.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Mode defines the health check mode.
    /// If defined to grpc, will use the gRPC health check protocol to probe the server.
    /// Default: http
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Path defines the server URL path for the health check endpoint.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port defines the server URL port for the health check endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Scheme replaces the server URL scheme for the health check endpoint.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>Status defines the expected HTTP status code of the response to the health check request.</summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// Timeout defines the maximum duration Traefik will wait for a health check request before considering the server unhealthy.
    /// Default: 5s
    /// </summary>
    [JsonPropertyName("timeout")]
    public IntOrString? Timeout { get; set; }

    /// <summary>
    /// UnhealthyInterval defines the frequency of the health check calls for unhealthy targets.
    /// When UnhealthyInterval is not defined, it defaults to the Interval value.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("unhealthyInterval")]
    public IntOrString? UnhealthyInterval { get; set; }
}

/// <summary>Kind defines the kind of the Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecHighestRandomWeightServicesKindEnum>))]
public enum V1alpha1TraefikServiceSpecHighestRandomWeightServicesKindEnum
{
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service,
    [EnumMember(Value = "TraefikService"), JsonStringEnumMemberName("TraefikService")]
    TraefikService
}

/// <summary>MiddlewareRef is a reference to a Middleware resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecHighestRandomWeightServicesMiddlewares
{
    /// <summary>Name defines the name of the referenced Middleware resource.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Middleware resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecHighestRandomWeightServicesPassiveHealthCheck
{
    /// <summary>FailureWindow defines the time window during which the failed attempts must occur for the server to be marked as unhealthy. It also defines for how long the server will be considered unhealthy.</summary>
    [JsonPropertyName("failureWindow")]
    public IntOrString? FailureWindow { get; set; }

    /// <summary>MaxFailedAttempts is the number of consecutive failed attempts allowed within the failure window before marking the server as unhealthy.</summary>
    [JsonPropertyName("maxFailedAttempts")]
    public int? MaxFailedAttempts { get; set; }
}

/// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecHighestRandomWeightServicesResponseForwarding
{
    /// <summary>
    /// FlushInterval defines the interval, in milliseconds, in between flushes to the client while copying the response body.
    /// A negative value means to flush immediately after each write to the client.
    /// This configuration is ignored when ReverseProxy recognizes a response as a streaming response;
    /// for such responses, writes are flushed to the client immediately.
    /// Default: 100ms
    /// </summary>
    [JsonPropertyName("flushInterval")]
    public string? FlushInterval { get; set; }
}

/// <summary>
/// SameSite defines the same site policy.
/// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecHighestRandomWeightServicesStickyCookieSameSiteEnum>))]
public enum V1alpha1TraefikServiceSpecHighestRandomWeightServicesStickyCookieSameSiteEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    [EnumMember(Value = "lax"), JsonStringEnumMemberName("lax")]
    Lax,
    [EnumMember(Value = "strict"), JsonStringEnumMemberName("strict")]
    Strict,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None1,
    [EnumMember(Value = "Lax"), JsonStringEnumMemberName("Lax")]
    Lax1,
    [EnumMember(Value = "Strict"), JsonStringEnumMemberName("Strict")]
    Strict1
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecHighestRandomWeightServicesStickyCookie
{
    /// <summary>
    /// Domain defines the host to which the cookie will be sent.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#domaindomain-value
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>HTTPOnly defines whether the cookie can be accessed by client-side APIs, such as JavaScript.</summary>
    [JsonPropertyName("httpOnly")]
    public bool? HttpOnly { get; set; }

    /// <summary>
    /// MaxAge defines the number of seconds until the cookie expires.
    /// When set to a negative number, the cookie expires immediately.
    /// When set to zero, the cookie never expires.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    /// <summary>Name defines the Cookie name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path defines the path that must exist in the requested URL for the browser to send the Cookie header.
    /// When not provided the cookie will be sent on every request to the domain.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#pathpath-value
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// SameSite defines the same site policy.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
    /// </summary>
    [JsonPropertyName("sameSite")]
    public V1alpha1TraefikServiceSpecHighestRandomWeightServicesStickyCookieSameSiteEnum? SameSite { get; set; }

    /// <summary>Secure defines whether the cookie can only be transmitted over an encrypted connection (i.e. HTTPS).</summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

/// <summary>
/// Sticky defines the sticky sessions configuration.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecHighestRandomWeightServicesSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1TraefikServiceSpecHighestRandomWeightServicesStickyCookie? Cookie { get; set; }
}

/// <summary>
/// Strategy defines the load balancing strategy between the servers.
/// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
/// RoundRobin value is deprecated and supported for backward compatibility.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecHighestRandomWeightServicesStrategyEnum>))]
public enum V1alpha1TraefikServiceSpecHighestRandomWeightServicesStrategyEnum
{
    [EnumMember(Value = "wrr"), JsonStringEnumMemberName("wrr")]
    Wrr,
    [EnumMember(Value = "p2c"), JsonStringEnumMemberName("p2c")]
    P2c,
    [EnumMember(Value = "hrw"), JsonStringEnumMemberName("hrw")]
    Hrw,
    [EnumMember(Value = "leasttime"), JsonStringEnumMemberName("leasttime")]
    Leasttime,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin
}

/// <summary>Service defines an upstream HTTP service to proxy traffic to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecHighestRandomWeightServices
{
    /// <summary>Healthcheck defines health checks for ExternalName services.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1TraefikServiceSpecHighestRandomWeightServicesHealthCheck? HealthCheck { get; set; }

    /// <summary>Kind defines the kind of the Service.</summary>
    [JsonPropertyName("kind")]
    public V1alpha1TraefikServiceSpecHighestRandomWeightServicesKindEnum? Kind { get; set; }

    /// <summary>Middlewares defines the list of references to Middleware resources to apply to the service.</summary>
    [JsonPropertyName("middlewares")]
    public IList<V1alpha1TraefikServiceSpecHighestRandomWeightServicesMiddlewares>? Middlewares { get; set; }

    /// <summary>
    /// Name defines the name of the referenced Kubernetes Service or TraefikService.
    /// The differentiation between the two is specified in the Kind field.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Kubernetes Service or TraefikService.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// NativeLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the pods IPs or if the only child is the Kubernetes Service clusterIP.
    /// The Kubernetes Service itself does load-balance to the pods.
    /// By default, NativeLB is false.
    /// </summary>
    [JsonPropertyName("nativeLB")]
    public bool? NativeLB { get; set; }

    /// <summary>
    /// NodePortLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the nodes internal IPs using the nodePort when the service type is NodePort.
    /// It allows services to be reachable when Traefik runs externally from the Kubernetes cluster but within the same network of the nodes.
    /// By default, NodePortLB is false.
    /// </summary>
    [JsonPropertyName("nodePortLB")]
    public bool? NodePortLB { get; set; }

    /// <summary>
    /// PassHostHeader defines whether the client Host header is forwarded to the upstream Kubernetes Service.
    /// By default, passHostHeader is true.
    /// </summary>
    [JsonPropertyName("passHostHeader")]
    public bool? PassHostHeader { get; set; }

    /// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
    [JsonPropertyName("passiveHealthCheck")]
    public V1alpha1TraefikServiceSpecHighestRandomWeightServicesPassiveHealthCheck? PassiveHealthCheck { get; set; }

    /// <summary>
    /// Port defines the port of a Kubernetes Service.
    /// This can be a reference to a named port.
    /// </summary>
    [JsonPropertyName("port")]
    public IntOrString? Port { get; set; }

    /// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
    [JsonPropertyName("responseForwarding")]
    public V1alpha1TraefikServiceSpecHighestRandomWeightServicesResponseForwarding? ResponseForwarding { get; set; }

    /// <summary>
    /// Scheme defines the scheme to use for the request to the upstream Kubernetes Service.
    /// It defaults to https when Kubernetes Service port is 443, http otherwise.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// ServersTransport defines the name of ServersTransport resource to use.
    /// It allows to configure the transport between Traefik and your servers.
    /// Can only be used on a Kubernetes Service.
    /// </summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>
    /// Sticky defines the sticky sessions configuration.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
    /// </summary>
    [JsonPropertyName("sticky")]
    public V1alpha1TraefikServiceSpecHighestRandomWeightServicesSticky? Sticky { get; set; }

    /// <summary>
    /// Strategy defines the load balancing strategy between the servers.
    /// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
    /// RoundRobin value is deprecated and supported for backward compatibility.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V1alpha1TraefikServiceSpecHighestRandomWeightServicesStrategyEnum? Strategy { get; set; }

    /// <summary>
    /// Weight defines the weight and should only be specified when Name references a TraefikService object
    /// (and to be precise, one that embeds a Weighted Round Robin).
    /// </summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>HighestRandomWeight defines the highest random weight service configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecHighestRandomWeight
{
    /// <summary>Services defines the list of Kubernetes Service and/or TraefikService to load-balance, with weight.</summary>
    [JsonPropertyName("services")]
    public IList<V1alpha1TraefikServiceSpecHighestRandomWeightServices>? Services { get; set; }
}

/// <summary>Healthcheck defines health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringHealthCheck
{
    /// <summary>
    /// FollowRedirects defines whether redirects should be followed during the health check calls.
    /// Default: true
    /// </summary>
    [JsonPropertyName("followRedirects")]
    public bool? FollowRedirects { get; set; }

    /// <summary>Headers defines custom headers to be sent to the health check endpoint.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Hostname defines the value of hostname in the Host header of the health check request.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Interval defines the frequency of the health check calls for healthy targets.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("interval")]
    public IntOrString? Interval { get; set; }

    /// <summary>Method defines the healthcheck method.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Mode defines the health check mode.
    /// If defined to grpc, will use the gRPC health check protocol to probe the server.
    /// Default: http
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Path defines the server URL path for the health check endpoint.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port defines the server URL port for the health check endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Scheme replaces the server URL scheme for the health check endpoint.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>Status defines the expected HTTP status code of the response to the health check request.</summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// Timeout defines the maximum duration Traefik will wait for a health check request before considering the server unhealthy.
    /// Default: 5s
    /// </summary>
    [JsonPropertyName("timeout")]
    public IntOrString? Timeout { get; set; }

    /// <summary>
    /// UnhealthyInterval defines the frequency of the health check calls for unhealthy targets.
    /// When UnhealthyInterval is not defined, it defaults to the Interval value.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("unhealthyInterval")]
    public IntOrString? UnhealthyInterval { get; set; }
}

/// <summary>Kind defines the kind of the Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecMirroringKindEnum>))]
public enum V1alpha1TraefikServiceSpecMirroringKindEnum
{
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service,
    [EnumMember(Value = "TraefikService"), JsonStringEnumMemberName("TraefikService")]
    TraefikService
}

/// <summary>MiddlewareRef is a reference to a Middleware resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMiddlewares
{
    /// <summary>Name defines the name of the referenced Middleware resource.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Middleware resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Healthcheck defines health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrorsHealthCheck
{
    /// <summary>
    /// FollowRedirects defines whether redirects should be followed during the health check calls.
    /// Default: true
    /// </summary>
    [JsonPropertyName("followRedirects")]
    public bool? FollowRedirects { get; set; }

    /// <summary>Headers defines custom headers to be sent to the health check endpoint.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Hostname defines the value of hostname in the Host header of the health check request.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Interval defines the frequency of the health check calls for healthy targets.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("interval")]
    public IntOrString? Interval { get; set; }

    /// <summary>Method defines the healthcheck method.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Mode defines the health check mode.
    /// If defined to grpc, will use the gRPC health check protocol to probe the server.
    /// Default: http
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Path defines the server URL path for the health check endpoint.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port defines the server URL port for the health check endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Scheme replaces the server URL scheme for the health check endpoint.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>Status defines the expected HTTP status code of the response to the health check request.</summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// Timeout defines the maximum duration Traefik will wait for a health check request before considering the server unhealthy.
    /// Default: 5s
    /// </summary>
    [JsonPropertyName("timeout")]
    public IntOrString? Timeout { get; set; }

    /// <summary>
    /// UnhealthyInterval defines the frequency of the health check calls for unhealthy targets.
    /// When UnhealthyInterval is not defined, it defaults to the Interval value.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("unhealthyInterval")]
    public IntOrString? UnhealthyInterval { get; set; }
}

/// <summary>Kind defines the kind of the Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecMirroringMirrorsKindEnum>))]
public enum V1alpha1TraefikServiceSpecMirroringMirrorsKindEnum
{
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service,
    [EnumMember(Value = "TraefikService"), JsonStringEnumMemberName("TraefikService")]
    TraefikService
}

/// <summary>MiddlewareRef is a reference to a Middleware resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrorsMiddlewares
{
    /// <summary>Name defines the name of the referenced Middleware resource.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Middleware resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrorsPassiveHealthCheck
{
    /// <summary>FailureWindow defines the time window during which the failed attempts must occur for the server to be marked as unhealthy. It also defines for how long the server will be considered unhealthy.</summary>
    [JsonPropertyName("failureWindow")]
    public IntOrString? FailureWindow { get; set; }

    /// <summary>MaxFailedAttempts is the number of consecutive failed attempts allowed within the failure window before marking the server as unhealthy.</summary>
    [JsonPropertyName("maxFailedAttempts")]
    public int? MaxFailedAttempts { get; set; }
}

/// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrorsResponseForwarding
{
    /// <summary>
    /// FlushInterval defines the interval, in milliseconds, in between flushes to the client while copying the response body.
    /// A negative value means to flush immediately after each write to the client.
    /// This configuration is ignored when ReverseProxy recognizes a response as a streaming response;
    /// for such responses, writes are flushed to the client immediately.
    /// Default: 100ms
    /// </summary>
    [JsonPropertyName("flushInterval")]
    public string? FlushInterval { get; set; }
}

/// <summary>
/// SameSite defines the same site policy.
/// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecMirroringMirrorsStickyCookieSameSiteEnum>))]
public enum V1alpha1TraefikServiceSpecMirroringMirrorsStickyCookieSameSiteEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    [EnumMember(Value = "lax"), JsonStringEnumMemberName("lax")]
    Lax,
    [EnumMember(Value = "strict"), JsonStringEnumMemberName("strict")]
    Strict,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None1,
    [EnumMember(Value = "Lax"), JsonStringEnumMemberName("Lax")]
    Lax1,
    [EnumMember(Value = "Strict"), JsonStringEnumMemberName("Strict")]
    Strict1
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrorsStickyCookie
{
    /// <summary>
    /// Domain defines the host to which the cookie will be sent.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#domaindomain-value
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>HTTPOnly defines whether the cookie can be accessed by client-side APIs, such as JavaScript.</summary>
    [JsonPropertyName("httpOnly")]
    public bool? HttpOnly { get; set; }

    /// <summary>
    /// MaxAge defines the number of seconds until the cookie expires.
    /// When set to a negative number, the cookie expires immediately.
    /// When set to zero, the cookie never expires.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    /// <summary>Name defines the Cookie name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path defines the path that must exist in the requested URL for the browser to send the Cookie header.
    /// When not provided the cookie will be sent on every request to the domain.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#pathpath-value
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// SameSite defines the same site policy.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
    /// </summary>
    [JsonPropertyName("sameSite")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsStickyCookieSameSiteEnum? SameSite { get; set; }

    /// <summary>Secure defines whether the cookie can only be transmitted over an encrypted connection (i.e. HTTPS).</summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

/// <summary>
/// Sticky defines the sticky sessions configuration.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrorsSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsStickyCookie? Cookie { get; set; }
}

/// <summary>
/// Strategy defines the load balancing strategy between the servers.
/// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
/// RoundRobin value is deprecated and supported for backward compatibility.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecMirroringMirrorsStrategyEnum>))]
public enum V1alpha1TraefikServiceSpecMirroringMirrorsStrategyEnum
{
    [EnumMember(Value = "wrr"), JsonStringEnumMemberName("wrr")]
    Wrr,
    [EnumMember(Value = "p2c"), JsonStringEnumMemberName("p2c")]
    P2c,
    [EnumMember(Value = "hrw"), JsonStringEnumMemberName("hrw")]
    Hrw,
    [EnumMember(Value = "leasttime"), JsonStringEnumMemberName("leasttime")]
    Leasttime,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin
}

/// <summary>MirrorService holds the mirror configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringMirrors
{
    /// <summary>Healthcheck defines health checks for ExternalName services.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsHealthCheck? HealthCheck { get; set; }

    /// <summary>Kind defines the kind of the Service.</summary>
    [JsonPropertyName("kind")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsKindEnum? Kind { get; set; }

    /// <summary>Middlewares defines the list of references to Middleware resources to apply to the service.</summary>
    [JsonPropertyName("middlewares")]
    public IList<V1alpha1TraefikServiceSpecMirroringMirrorsMiddlewares>? Middlewares { get; set; }

    /// <summary>
    /// Name defines the name of the referenced Kubernetes Service or TraefikService.
    /// The differentiation between the two is specified in the Kind field.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Kubernetes Service or TraefikService.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// NativeLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the pods IPs or if the only child is the Kubernetes Service clusterIP.
    /// The Kubernetes Service itself does load-balance to the pods.
    /// By default, NativeLB is false.
    /// </summary>
    [JsonPropertyName("nativeLB")]
    public bool? NativeLB { get; set; }

    /// <summary>
    /// NodePortLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the nodes internal IPs using the nodePort when the service type is NodePort.
    /// It allows services to be reachable when Traefik runs externally from the Kubernetes cluster but within the same network of the nodes.
    /// By default, NodePortLB is false.
    /// </summary>
    [JsonPropertyName("nodePortLB")]
    public bool? NodePortLB { get; set; }

    /// <summary>
    /// PassHostHeader defines whether the client Host header is forwarded to the upstream Kubernetes Service.
    /// By default, passHostHeader is true.
    /// </summary>
    [JsonPropertyName("passHostHeader")]
    public bool? PassHostHeader { get; set; }

    /// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
    [JsonPropertyName("passiveHealthCheck")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsPassiveHealthCheck? PassiveHealthCheck { get; set; }

    /// <summary>
    /// Percent defines the part of the traffic to mirror.
    /// Supported values: 0 to 100.
    /// </summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }

    /// <summary>
    /// Port defines the port of a Kubernetes Service.
    /// This can be a reference to a named port.
    /// </summary>
    [JsonPropertyName("port")]
    public IntOrString? Port { get; set; }

    /// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
    [JsonPropertyName("responseForwarding")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsResponseForwarding? ResponseForwarding { get; set; }

    /// <summary>
    /// Scheme defines the scheme to use for the request to the upstream Kubernetes Service.
    /// It defaults to https when Kubernetes Service port is 443, http otherwise.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// ServersTransport defines the name of ServersTransport resource to use.
    /// It allows to configure the transport between Traefik and your servers.
    /// Can only be used on a Kubernetes Service.
    /// </summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>
    /// Sticky defines the sticky sessions configuration.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
    /// </summary>
    [JsonPropertyName("sticky")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsSticky? Sticky { get; set; }

    /// <summary>
    /// Strategy defines the load balancing strategy between the servers.
    /// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
    /// RoundRobin value is deprecated and supported for backward compatibility.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V1alpha1TraefikServiceSpecMirroringMirrorsStrategyEnum? Strategy { get; set; }

    /// <summary>
    /// Weight defines the weight and should only be specified when Name references a TraefikService object
    /// (and to be precise, one that embeds a Weighted Round Robin).
    /// </summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringPassiveHealthCheck
{
    /// <summary>FailureWindow defines the time window during which the failed attempts must occur for the server to be marked as unhealthy. It also defines for how long the server will be considered unhealthy.</summary>
    [JsonPropertyName("failureWindow")]
    public IntOrString? FailureWindow { get; set; }

    /// <summary>MaxFailedAttempts is the number of consecutive failed attempts allowed within the failure window before marking the server as unhealthy.</summary>
    [JsonPropertyName("maxFailedAttempts")]
    public int? MaxFailedAttempts { get; set; }
}

/// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringResponseForwarding
{
    /// <summary>
    /// FlushInterval defines the interval, in milliseconds, in between flushes to the client while copying the response body.
    /// A negative value means to flush immediately after each write to the client.
    /// This configuration is ignored when ReverseProxy recognizes a response as a streaming response;
    /// for such responses, writes are flushed to the client immediately.
    /// Default: 100ms
    /// </summary>
    [JsonPropertyName("flushInterval")]
    public string? FlushInterval { get; set; }
}

/// <summary>
/// SameSite defines the same site policy.
/// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecMirroringStickyCookieSameSiteEnum>))]
public enum V1alpha1TraefikServiceSpecMirroringStickyCookieSameSiteEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    [EnumMember(Value = "lax"), JsonStringEnumMemberName("lax")]
    Lax,
    [EnumMember(Value = "strict"), JsonStringEnumMemberName("strict")]
    Strict,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None1,
    [EnumMember(Value = "Lax"), JsonStringEnumMemberName("Lax")]
    Lax1,
    [EnumMember(Value = "Strict"), JsonStringEnumMemberName("Strict")]
    Strict1
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringStickyCookie
{
    /// <summary>
    /// Domain defines the host to which the cookie will be sent.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#domaindomain-value
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>HTTPOnly defines whether the cookie can be accessed by client-side APIs, such as JavaScript.</summary>
    [JsonPropertyName("httpOnly")]
    public bool? HttpOnly { get; set; }

    /// <summary>
    /// MaxAge defines the number of seconds until the cookie expires.
    /// When set to a negative number, the cookie expires immediately.
    /// When set to zero, the cookie never expires.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    /// <summary>Name defines the Cookie name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path defines the path that must exist in the requested URL for the browser to send the Cookie header.
    /// When not provided the cookie will be sent on every request to the domain.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#pathpath-value
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// SameSite defines the same site policy.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
    /// </summary>
    [JsonPropertyName("sameSite")]
    public V1alpha1TraefikServiceSpecMirroringStickyCookieSameSiteEnum? SameSite { get; set; }

    /// <summary>Secure defines whether the cookie can only be transmitted over an encrypted connection (i.e. HTTPS).</summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

/// <summary>
/// Sticky defines the sticky sessions configuration.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroringSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1TraefikServiceSpecMirroringStickyCookie? Cookie { get; set; }
}

/// <summary>
/// Strategy defines the load balancing strategy between the servers.
/// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
/// RoundRobin value is deprecated and supported for backward compatibility.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecMirroringStrategyEnum>))]
public enum V1alpha1TraefikServiceSpecMirroringStrategyEnum
{
    [EnumMember(Value = "wrr"), JsonStringEnumMemberName("wrr")]
    Wrr,
    [EnumMember(Value = "p2c"), JsonStringEnumMemberName("p2c")]
    P2c,
    [EnumMember(Value = "hrw"), JsonStringEnumMemberName("hrw")]
    Hrw,
    [EnumMember(Value = "leasttime"), JsonStringEnumMemberName("leasttime")]
    Leasttime,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin
}

/// <summary>Mirroring defines the Mirroring service configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecMirroring
{
    /// <summary>Healthcheck defines health checks for ExternalName services.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1TraefikServiceSpecMirroringHealthCheck? HealthCheck { get; set; }

    /// <summary>Kind defines the kind of the Service.</summary>
    [JsonPropertyName("kind")]
    public V1alpha1TraefikServiceSpecMirroringKindEnum? Kind { get; set; }

    /// <summary>
    /// MaxBodySize defines the maximum size allowed for the body of the request.
    /// If the body is larger, the request is not mirrored.
    /// Default value is -1, which means unlimited size.
    /// </summary>
    [JsonPropertyName("maxBodySize")]
    public long? MaxBodySize { get; set; }

    /// <summary>Middlewares defines the list of references to Middleware resources to apply to the service.</summary>
    [JsonPropertyName("middlewares")]
    public IList<V1alpha1TraefikServiceSpecMirroringMiddlewares>? Middlewares { get; set; }

    /// <summary>
    /// MirrorBody defines whether the body of the request should be mirrored.
    /// Default value is true.
    /// </summary>
    [JsonPropertyName("mirrorBody")]
    public bool? MirrorBody { get; set; }

    /// <summary>Mirrors defines the list of mirrors where Traefik will duplicate the traffic.</summary>
    [JsonPropertyName("mirrors")]
    public IList<V1alpha1TraefikServiceSpecMirroringMirrors>? Mirrors { get; set; }

    /// <summary>
    /// Name defines the name of the referenced Kubernetes Service or TraefikService.
    /// The differentiation between the two is specified in the Kind field.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Kubernetes Service or TraefikService.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// NativeLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the pods IPs or if the only child is the Kubernetes Service clusterIP.
    /// The Kubernetes Service itself does load-balance to the pods.
    /// By default, NativeLB is false.
    /// </summary>
    [JsonPropertyName("nativeLB")]
    public bool? NativeLB { get; set; }

    /// <summary>
    /// NodePortLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the nodes internal IPs using the nodePort when the service type is NodePort.
    /// It allows services to be reachable when Traefik runs externally from the Kubernetes cluster but within the same network of the nodes.
    /// By default, NodePortLB is false.
    /// </summary>
    [JsonPropertyName("nodePortLB")]
    public bool? NodePortLB { get; set; }

    /// <summary>
    /// PassHostHeader defines whether the client Host header is forwarded to the upstream Kubernetes Service.
    /// By default, passHostHeader is true.
    /// </summary>
    [JsonPropertyName("passHostHeader")]
    public bool? PassHostHeader { get; set; }

    /// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
    [JsonPropertyName("passiveHealthCheck")]
    public V1alpha1TraefikServiceSpecMirroringPassiveHealthCheck? PassiveHealthCheck { get; set; }

    /// <summary>
    /// Port defines the port of a Kubernetes Service.
    /// This can be a reference to a named port.
    /// </summary>
    [JsonPropertyName("port")]
    public IntOrString? Port { get; set; }

    /// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
    [JsonPropertyName("responseForwarding")]
    public V1alpha1TraefikServiceSpecMirroringResponseForwarding? ResponseForwarding { get; set; }

    /// <summary>
    /// Scheme defines the scheme to use for the request to the upstream Kubernetes Service.
    /// It defaults to https when Kubernetes Service port is 443, http otherwise.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// ServersTransport defines the name of ServersTransport resource to use.
    /// It allows to configure the transport between Traefik and your servers.
    /// Can only be used on a Kubernetes Service.
    /// </summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>
    /// Sticky defines the sticky sessions configuration.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
    /// </summary>
    [JsonPropertyName("sticky")]
    public V1alpha1TraefikServiceSpecMirroringSticky? Sticky { get; set; }

    /// <summary>
    /// Strategy defines the load balancing strategy between the servers.
    /// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
    /// RoundRobin value is deprecated and supported for backward compatibility.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V1alpha1TraefikServiceSpecMirroringStrategyEnum? Strategy { get; set; }

    /// <summary>
    /// Weight defines the weight and should only be specified when Name references a TraefikService object
    /// (and to be precise, one that embeds a Weighted Round Robin).
    /// </summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>Healthcheck defines health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServicesHealthCheck
{
    /// <summary>
    /// FollowRedirects defines whether redirects should be followed during the health check calls.
    /// Default: true
    /// </summary>
    [JsonPropertyName("followRedirects")]
    public bool? FollowRedirects { get; set; }

    /// <summary>Headers defines custom headers to be sent to the health check endpoint.</summary>
    [JsonPropertyName("headers")]
    public IDictionary<string, string>? Headers { get; set; }

    /// <summary>Hostname defines the value of hostname in the Host header of the health check request.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Interval defines the frequency of the health check calls for healthy targets.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("interval")]
    public IntOrString? Interval { get; set; }

    /// <summary>Method defines the healthcheck method.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Mode defines the health check mode.
    /// If defined to grpc, will use the gRPC health check protocol to probe the server.
    /// Default: http
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Path defines the server URL path for the health check endpoint.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port defines the server URL port for the health check endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Scheme replaces the server URL scheme for the health check endpoint.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>Status defines the expected HTTP status code of the response to the health check request.</summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// Timeout defines the maximum duration Traefik will wait for a health check request before considering the server unhealthy.
    /// Default: 5s
    /// </summary>
    [JsonPropertyName("timeout")]
    public IntOrString? Timeout { get; set; }

    /// <summary>
    /// UnhealthyInterval defines the frequency of the health check calls for unhealthy targets.
    /// When UnhealthyInterval is not defined, it defaults to the Interval value.
    /// Default: 30s
    /// </summary>
    [JsonPropertyName("unhealthyInterval")]
    public IntOrString? UnhealthyInterval { get; set; }
}

/// <summary>Kind defines the kind of the Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecWeightedServicesKindEnum>))]
public enum V1alpha1TraefikServiceSpecWeightedServicesKindEnum
{
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service,
    [EnumMember(Value = "TraefikService"), JsonStringEnumMemberName("TraefikService")]
    TraefikService
}

/// <summary>MiddlewareRef is a reference to a Middleware resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServicesMiddlewares
{
    /// <summary>Name defines the name of the referenced Middleware resource.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Middleware resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServicesPassiveHealthCheck
{
    /// <summary>FailureWindow defines the time window during which the failed attempts must occur for the server to be marked as unhealthy. It also defines for how long the server will be considered unhealthy.</summary>
    [JsonPropertyName("failureWindow")]
    public IntOrString? FailureWindow { get; set; }

    /// <summary>MaxFailedAttempts is the number of consecutive failed attempts allowed within the failure window before marking the server as unhealthy.</summary>
    [JsonPropertyName("maxFailedAttempts")]
    public int? MaxFailedAttempts { get; set; }
}

/// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServicesResponseForwarding
{
    /// <summary>
    /// FlushInterval defines the interval, in milliseconds, in between flushes to the client while copying the response body.
    /// A negative value means to flush immediately after each write to the client.
    /// This configuration is ignored when ReverseProxy recognizes a response as a streaming response;
    /// for such responses, writes are flushed to the client immediately.
    /// Default: 100ms
    /// </summary>
    [JsonPropertyName("flushInterval")]
    public string? FlushInterval { get; set; }
}

/// <summary>
/// SameSite defines the same site policy.
/// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecWeightedServicesStickyCookieSameSiteEnum>))]
public enum V1alpha1TraefikServiceSpecWeightedServicesStickyCookieSameSiteEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    [EnumMember(Value = "lax"), JsonStringEnumMemberName("lax")]
    Lax,
    [EnumMember(Value = "strict"), JsonStringEnumMemberName("strict")]
    Strict,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None1,
    [EnumMember(Value = "Lax"), JsonStringEnumMemberName("Lax")]
    Lax1,
    [EnumMember(Value = "Strict"), JsonStringEnumMemberName("Strict")]
    Strict1
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServicesStickyCookie
{
    /// <summary>
    /// Domain defines the host to which the cookie will be sent.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#domaindomain-value
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>HTTPOnly defines whether the cookie can be accessed by client-side APIs, such as JavaScript.</summary>
    [JsonPropertyName("httpOnly")]
    public bool? HttpOnly { get; set; }

    /// <summary>
    /// MaxAge defines the number of seconds until the cookie expires.
    /// When set to a negative number, the cookie expires immediately.
    /// When set to zero, the cookie never expires.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    /// <summary>Name defines the Cookie name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path defines the path that must exist in the requested URL for the browser to send the Cookie header.
    /// When not provided the cookie will be sent on every request to the domain.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#pathpath-value
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// SameSite defines the same site policy.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
    /// </summary>
    [JsonPropertyName("sameSite")]
    public V1alpha1TraefikServiceSpecWeightedServicesStickyCookieSameSiteEnum? SameSite { get; set; }

    /// <summary>Secure defines whether the cookie can only be transmitted over an encrypted connection (i.e. HTTPS).</summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

/// <summary>
/// Sticky defines the sticky sessions configuration.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServicesSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1TraefikServiceSpecWeightedServicesStickyCookie? Cookie { get; set; }
}

/// <summary>
/// Strategy defines the load balancing strategy between the servers.
/// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
/// RoundRobin value is deprecated and supported for backward compatibility.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecWeightedServicesStrategyEnum>))]
public enum V1alpha1TraefikServiceSpecWeightedServicesStrategyEnum
{
    [EnumMember(Value = "wrr"), JsonStringEnumMemberName("wrr")]
    Wrr,
    [EnumMember(Value = "p2c"), JsonStringEnumMemberName("p2c")]
    P2c,
    [EnumMember(Value = "hrw"), JsonStringEnumMemberName("hrw")]
    Hrw,
    [EnumMember(Value = "leasttime"), JsonStringEnumMemberName("leasttime")]
    Leasttime,
    [EnumMember(Value = "RoundRobin"), JsonStringEnumMemberName("RoundRobin")]
    RoundRobin
}

/// <summary>Service defines an upstream HTTP service to proxy traffic to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedServices
{
    /// <summary>Healthcheck defines health checks for ExternalName services.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1TraefikServiceSpecWeightedServicesHealthCheck? HealthCheck { get; set; }

    /// <summary>Kind defines the kind of the Service.</summary>
    [JsonPropertyName("kind")]
    public V1alpha1TraefikServiceSpecWeightedServicesKindEnum? Kind { get; set; }

    /// <summary>Middlewares defines the list of references to Middleware resources to apply to the service.</summary>
    [JsonPropertyName("middlewares")]
    public IList<V1alpha1TraefikServiceSpecWeightedServicesMiddlewares>? Middlewares { get; set; }

    /// <summary>
    /// Name defines the name of the referenced Kubernetes Service or TraefikService.
    /// The differentiation between the two is specified in the Kind field.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace defines the namespace of the referenced Kubernetes Service or TraefikService.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// NativeLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the pods IPs or if the only child is the Kubernetes Service clusterIP.
    /// The Kubernetes Service itself does load-balance to the pods.
    /// By default, NativeLB is false.
    /// </summary>
    [JsonPropertyName("nativeLB")]
    public bool? NativeLB { get; set; }

    /// <summary>
    /// NodePortLB controls, when creating the load-balancer,
    /// whether the LB&apos;s children are directly the nodes internal IPs using the nodePort when the service type is NodePort.
    /// It allows services to be reachable when Traefik runs externally from the Kubernetes cluster but within the same network of the nodes.
    /// By default, NodePortLB is false.
    /// </summary>
    [JsonPropertyName("nodePortLB")]
    public bool? NodePortLB { get; set; }

    /// <summary>
    /// PassHostHeader defines whether the client Host header is forwarded to the upstream Kubernetes Service.
    /// By default, passHostHeader is true.
    /// </summary>
    [JsonPropertyName("passHostHeader")]
    public bool? PassHostHeader { get; set; }

    /// <summary>PassiveHealthCheck defines passive health checks for ExternalName services.</summary>
    [JsonPropertyName("passiveHealthCheck")]
    public V1alpha1TraefikServiceSpecWeightedServicesPassiveHealthCheck? PassiveHealthCheck { get; set; }

    /// <summary>
    /// Port defines the port of a Kubernetes Service.
    /// This can be a reference to a named port.
    /// </summary>
    [JsonPropertyName("port")]
    public IntOrString? Port { get; set; }

    /// <summary>ResponseForwarding defines how Traefik forwards the response from the upstream Kubernetes Service to the client.</summary>
    [JsonPropertyName("responseForwarding")]
    public V1alpha1TraefikServiceSpecWeightedServicesResponseForwarding? ResponseForwarding { get; set; }

    /// <summary>
    /// Scheme defines the scheme to use for the request to the upstream Kubernetes Service.
    /// It defaults to https when Kubernetes Service port is 443, http otherwise.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// ServersTransport defines the name of ServersTransport resource to use.
    /// It allows to configure the transport between Traefik and your servers.
    /// Can only be used on a Kubernetes Service.
    /// </summary>
    [JsonPropertyName("serversTransport")]
    public string? ServersTransport { get; set; }

    /// <summary>
    /// Sticky defines the sticky sessions configuration.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/http/load-balancing/service/#sticky-sessions
    /// </summary>
    [JsonPropertyName("sticky")]
    public V1alpha1TraefikServiceSpecWeightedServicesSticky? Sticky { get; set; }

    /// <summary>
    /// Strategy defines the load balancing strategy between the servers.
    /// Supported values are: wrr (Weighed round-robin), p2c (Power of two choices), hrw (Highest Random Weight), and leasttime (Least-Time).
    /// RoundRobin value is deprecated and supported for backward compatibility.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V1alpha1TraefikServiceSpecWeightedServicesStrategyEnum? Strategy { get; set; }

    /// <summary>
    /// Weight defines the weight and should only be specified when Name references a TraefikService object
    /// (and to be precise, one that embeds a Weighted Round Robin).
    /// </summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>
/// SameSite defines the same site policy.
/// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1TraefikServiceSpecWeightedStickyCookieSameSiteEnum>))]
public enum V1alpha1TraefikServiceSpecWeightedStickyCookieSameSiteEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None,
    [EnumMember(Value = "lax"), JsonStringEnumMemberName("lax")]
    Lax,
    [EnumMember(Value = "strict"), JsonStringEnumMemberName("strict")]
    Strict,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None1,
    [EnumMember(Value = "Lax"), JsonStringEnumMemberName("Lax")]
    Lax1,
    [EnumMember(Value = "Strict"), JsonStringEnumMemberName("Strict")]
    Strict1
}

/// <summary>Cookie defines the sticky cookie configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedStickyCookie
{
    /// <summary>
    /// Domain defines the host to which the cookie will be sent.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#domaindomain-value
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>HTTPOnly defines whether the cookie can be accessed by client-side APIs, such as JavaScript.</summary>
    [JsonPropertyName("httpOnly")]
    public bool? HttpOnly { get; set; }

    /// <summary>
    /// MaxAge defines the number of seconds until the cookie expires.
    /// When set to a negative number, the cookie expires immediately.
    /// When set to zero, the cookie never expires.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    /// <summary>Name defines the Cookie name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Path defines the path that must exist in the requested URL for the browser to send the Cookie header.
    /// When not provided the cookie will be sent on every request to the domain.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie#pathpath-value
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// SameSite defines the same site policy.
    /// More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Set-Cookie/SameSite
    /// </summary>
    [JsonPropertyName("sameSite")]
    public V1alpha1TraefikServiceSpecWeightedStickyCookieSameSiteEnum? SameSite { get; set; }

    /// <summary>Secure defines whether the cookie can only be transmitted over an encrypted connection (i.e. HTTPS).</summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }
}

/// <summary>
/// Sticky defines whether sticky sessions are enabled.
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/kubernetes/crd/http/traefikservice/#stickiness-and-load-balancing
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeightedSticky
{
    /// <summary>Cookie defines the sticky cookie configuration.</summary>
    [JsonPropertyName("cookie")]
    public V1alpha1TraefikServiceSpecWeightedStickyCookie? Cookie { get; set; }
}

/// <summary>Weighted defines the Weighted Round Robin configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpecWeighted
{
    /// <summary>Services defines the list of Kubernetes Service and/or TraefikService to load-balance, with weight.</summary>
    [JsonPropertyName("services")]
    public IList<V1alpha1TraefikServiceSpecWeightedServices>? Services { get; set; }

    /// <summary>
    /// Sticky defines whether sticky sessions are enabled.
    /// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/kubernetes/crd/http/traefikservice/#stickiness-and-load-balancing
    /// </summary>
    [JsonPropertyName("sticky")]
    public V1alpha1TraefikServiceSpecWeightedSticky? Sticky { get; set; }
}

/// <summary>TraefikServiceSpec defines the desired state of a TraefikService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TraefikServiceSpec
{
    /// <summary>Failover defines the Failover service configuration.</summary>
    [JsonPropertyName("failover")]
    public V1alpha1TraefikServiceSpecFailover? Failover { get; set; }

    /// <summary>HighestRandomWeight defines the highest random weight service configuration.</summary>
    [JsonPropertyName("highestRandomWeight")]
    public V1alpha1TraefikServiceSpecHighestRandomWeight? HighestRandomWeight { get; set; }

    /// <summary>Mirroring defines the Mirroring service configuration.</summary>
    [JsonPropertyName("mirroring")]
    public V1alpha1TraefikServiceSpecMirroring? Mirroring { get; set; }

    /// <summary>Weighted defines the Weighted Round Robin configuration.</summary>
    [JsonPropertyName("weighted")]
    public V1alpha1TraefikServiceSpecWeighted? Weighted { get; set; }
}

/// <summary>
/// TraefikService is the CRD implementation of a Traefik Service.
/// TraefikService object allows to:
/// - Apply weight to Services on load-balancing
/// - Mirror traffic on services
/// More info: https://doc.traefik.io/traefik/v3.7/reference/routing-configuration/kubernetes/crd/http/traefikservice/
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TraefikService : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TraefikServiceSpec>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TraefikService";
    public const string KubeGroup = "traefik.io";
    public const string KubePluralName = "traefikservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TraefikService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TraefikServiceSpec defines the desired state of a TraefikService.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1TraefikServiceSpec Spec { get; set; }
}