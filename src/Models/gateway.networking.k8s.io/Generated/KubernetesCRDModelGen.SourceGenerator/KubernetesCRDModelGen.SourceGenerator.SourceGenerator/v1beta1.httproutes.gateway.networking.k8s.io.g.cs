#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.gateway.networking.k8s.io;
/// <summary>
/// HTTPRoute provides a way to route HTTP requests. This includes the capability
/// to match requests by hostname, path, header, or query param. Filters can be
/// used to specify additional processing steps. Backends specify where matching
/// requests should be routed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HTTPRouteList : IKubernetesObject<V1ListMeta>, IItems<V1beta1HTTPRoute>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HTTPRouteList";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "httproutes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HTTPRouteList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1HTTPRoute objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1HTTPRoute> Items { get; set; }
}

/// <summary>
/// ParentReference identifies an API object (usually a Gateway) that can be considered
/// a parent of this resource (usually a route). There are two kinds of parent resources
/// with &quot;Core&quot; support:
/// 
/// * Gateway (Gateway conformance profile)
/// * Service (Mesh conformance profile, ClusterIP Services only)
/// 
/// This API may be extended in the future to support additional kinds of parent
/// resources.
/// 
/// The API object must be valid in the cluster; the Group and Kind must
/// be registered in the cluster for this reference to be valid.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecParentRefs
{
    /// <summary>
    /// Group is the group of the referent.
    /// When unspecified, &quot;gateway.networking.k8s.io&quot; is inferred.
    /// To set the core API group (such as for a &quot;Service&quot; kind referent),
    /// Group must be explicitly set to &quot; &quot; (empty string).
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>
    /// Kind is kind of the referent.
    /// 
    /// There are two kinds of parent resources with &quot;Core&quot; support:
    /// 
    /// * Gateway (Gateway conformance profile)
    /// * Service (Mesh conformance profile, ClusterIP Services only)
    /// 
    /// Support for other resources is Implementation-Specific.
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Name is the name of the referent.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace is the namespace of the referent. When unspecified, this refers
    /// to the local namespace of the Route.
    /// 
    /// Note that there are specific rules for ParentRefs which cross namespace
    /// boundaries. Cross-namespace references are only valid if they are explicitly
    /// allowed by something in the namespace they are referring to. For example:
    /// Gateway has the AllowedRoutes field, and ReferenceGrant provides a
    /// generic way to enable any other kind of cross-namespace reference.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Port is the network port this Route targets. It can be interpreted
    /// differently based on the type of parent resource.
    /// 
    /// When the parent resource is a Gateway, this targets all listeners
    /// listening on the specified port that also support this kind of Route(and
    /// select this Route). It&apos;s not recommended to set `Port` unless the
    /// networking behaviors specified in a Route must apply to a specific port
    /// as opposed to a listener(s) whose port(s) may be changed. When both Port
    /// and SectionName are specified, the name and port of the selected listener
    /// must match both specified values.
    /// 
    /// Implementations MAY choose to support other parent resources.
    /// Implementations supporting other types of parent resources MUST clearly
    /// document how/if Port is interpreted.
    /// 
    /// For the purpose of status, an attachment is considered successful as
    /// long as the parent resource accepts it partially. For example, Gateway
    /// listeners can restrict which Routes can attach to them by Route kind,
    /// namespace, or hostname. If 1 of 2 Gateway listeners accept attachment
    /// from the referencing Route, the Route MUST be considered successfully
    /// attached. If no Gateway listeners accept attachment from this Route,
    /// the Route MUST be considered detached from the Gateway.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>
    /// SectionName is the name of a section within the target resource. In the
    /// following resources, SectionName is interpreted as the following:
    /// 
    /// * Gateway: Listener name. When both Port (experimental) and SectionName
    /// are specified, the name and port of the selected listener must match
    /// both specified values.
    /// * Service: Port name. When both Port (experimental) and SectionName
    /// are specified, the name and port of the selected listener must match
    /// both specified values.
    /// 
    /// Implementations MAY choose to support attaching Routes to other resources.
    /// If that is the case, they MUST clearly document how SectionName is
    /// interpreted.
    /// 
    /// When unspecified (empty string), this will reference the entire resource.
    /// For the purpose of status, an attachment is considered successful if at
    /// least one section in the parent resource accepts it. For example, Gateway
    /// listeners can restrict which Routes can attach to them by Route kind,
    /// namespace, or hostname. If 1 of 2 Gateway listeners accept attachment from
    /// the referencing Route, the Route MUST be considered successfully
    /// attached. If no Gateway listeners accept attachment from this Route, the
    /// Route MUST be considered detached from the Gateway.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("sectionName")]
    public string? SectionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesBackendRefsFiltersCorsAllowMethodsEnum>))]
public enum V1beta1HTTPRouteSpecRulesBackendRefsFiltersCorsAllowMethodsEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "HEAD"), JsonStringEnumMemberName("HEAD")]
    HEAD,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST,
    [EnumMember(Value = "PUT"), JsonStringEnumMemberName("PUT")]
    PUT,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "OPTIONS"), JsonStringEnumMemberName("OPTIONS")]
    OPTIONS,
    [EnumMember(Value = "TRACE"), JsonStringEnumMemberName("TRACE")]
    TRACE,
    [EnumMember(Value = "PATCH"), JsonStringEnumMemberName("PATCH")]
    PATCH,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option9
}

/// <summary>
/// CORS defines a schema for a filter that responds to the
/// cross-origin request based on HTTP response header.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersCors
{
    /// <summary>
    /// AllowCredentials indicates whether the actual cross-origin request allows
    /// to include credentials.
    /// 
    /// When set to true, the gateway will include the `Access-Control-Allow-Credentials`
    /// response header with value true (case-sensitive).
    /// 
    /// When set to false or omitted the gateway will omit the header
    /// `Access-Control-Allow-Credentials` entirely (this is the standard CORS
    /// behavior).
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>
    /// AllowHeaders indicates which HTTP request headers are supported for
    /// accessing the requested resource.
    /// 
    /// Header names are not case-sensitive.
    /// 
    /// Multiple header names in the value of the `Access-Control-Allow-Headers`
    /// response header are separated by a comma (&quot;,&quot;).
    /// 
    /// When the `allowHeaders` field is configured with one or more headers, the
    /// gateway must return the `Access-Control-Allow-Headers` response header
    /// which value is present in the `allowHeaders` field.
    /// 
    /// If any header name in the `Access-Control-Request-Headers` request header
    /// is not included in the list of header names specified by the response
    /// header `Access-Control-Allow-Headers`, it will present an error on the
    /// client side.
    /// 
    /// If any header name in the `Access-Control-Allow-Headers` response header
    /// does not recognize by the client, it will also occur an error on the
    /// client side.
    /// 
    /// A wildcard indicates that the requests with all HTTP headers are allowed.
    /// 
    /// If the configuration contains the wildcard `*` in `allowHeaders` and
    /// `allowCredentials` is set to `false`, the `Access-Control-Allow-Headers`
    /// response header may either contain the wildcard `*` or echo the value
    /// of the `Access-Control-Request-Headers` request header.
    /// 
    /// If the configuration contains the wildcard `*` in `allowHeaders` and
    /// `allowCredentials` is set to `true`, the gateway must not return `*`
    /// in the `Access-Control-Allow-Headers` response header. Instead, it must
    /// return one or more header names matching the value of the
    /// `Access-Control-Request-Headers` request header.
    /// If the `Access-Control-Request-Headers` header is not present in the
    /// request, the gateway must omit the `Access-Control-Allow-Headers`
    /// response header.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>
    /// AllowMethods indicates which HTTP methods are supported for accessing the
    /// requested resource.
    /// 
    /// Valid values are any method defined by RFC9110, along with the special
    /// value `*`, which represents all HTTP methods are allowed.
    /// 
    /// Method names are case-sensitive, so these values are also case-sensitive.
    /// (See https://www.rfc-editor.org/rfc/rfc2616#section-5.1.1)
    /// 
    /// Multiple method names in the value of the `Access-Control-Allow-Methods`
    /// response header are separated by a comma (&quot;,&quot;).
    /// 
    /// A CORS-safelisted method is a method that is `GET`, `HEAD`, or `POST`.
    /// (See https://fetch.spec.whatwg.org/#cors-safelisted-method) The
    /// CORS-safelisted methods are always allowed, regardless of whether they
    /// are specified in the `allowMethods` field.
    /// 
    /// When the `allowMethods` field is configured with one or more methods, the
    /// gateway must return the `Access-Control-Allow-Methods` response header
    /// which value is present in the `allowMethods` field.
    /// 
    /// If the HTTP method of the `Access-Control-Request-Method` request header
    /// is not included in the list of methods specified by the response header
    /// `Access-Control-Allow-Methods`, it will present an error on the client
    /// side.
    /// 
    /// If the configuration contains the wildcard `*` in `allowMethods` and
    /// `allowCredentials` is set to `false`, the `Access-Control-Allow-Methods`
    /// response header may either contain the wildcard `*` or echo the value
    /// of the `Access-Control-Request-Method` request header.
    /// 
    /// If the configuration contains the wildcard `*` in `allowMethods` and
    /// `allowCredentials` is set to `true`, the gateway must not return `*`
    /// in the `Access-Control-Allow-Methods` response header. Instead, it must
    /// return a single HTTP method matching the value of the
    /// `Access-Control-Request-Method` request header.
    /// If the `Access-Control-Request-Method` header is not present in the request,
    /// the gateway must omit the `Access-Control-Allow-Methods` response header.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("allowMethods")]
    public IList<V1beta1HTTPRouteSpecRulesBackendRefsFiltersCorsAllowMethodsEnum>? AllowMethods { get; set; }

    /// <summary>
    /// AllowOrigins indicates whether the response can be shared with requested
    /// resource from the given `Origin`.
    /// 
    /// The `Origin` consists of a scheme and a host, with an optional port, and
    /// takes the form `&lt;scheme&gt;://&lt;host&gt;(:&lt;port&gt;)`.
    /// 
    /// Valid values for scheme are: `http` and `https`.
    /// 
    /// Valid values for port are any integer between 1 and 65535 (the list of
    /// available TCP/UDP ports). Note that, if not included, port `80` is
    /// assumed for `http` scheme origins, and port `443` is assumed for `https`
    /// origins. This may affect origin matching.
    /// 
    /// The host part of the origin may contain the wildcard character `*`. These
    /// wildcard characters behave as follows:
    /// 
    /// * `*` is a greedy match to the _left_, including any number of
    ///   DNS labels to the left of its position. This also means that
    ///   `*` will include any number of period `.` characters to the
    ///   left of its position.
    /// * A wildcard by itself matches all hosts.
    /// 
    /// An origin value that includes _only_ the `*` character indicates requests
    /// from all `Origin`s are allowed.
    /// 
    /// When the `allowOrigins` field is configured with multiple origins, it
    /// means the server supports clients from multiple origins. If the request
    /// `Origin` matches the configured allowed origins, the gateway must return
    /// the given `Origin` and sets value of the header
    /// `Access-Control-Allow-Origin` same as the `Origin` header provided by the
    /// client.
    /// 
    /// The status code of a successful response to a &quot;preflight&quot; request is
    /// always an OK status (i.e., 204 or 200).
    /// 
    /// If the request `Origin` does not match the configured allowed origins,
    /// the gateway returns 204/200 response but doesn&apos;t set the relevant
    /// cross-origin response headers. Alternatively, the gateway responds with
    /// 403 status to the &quot;preflight&quot; request is denied, coupled with omitting
    /// the CORS headers. The cross-origin request fails on the client side.
    /// Therefore, the client doesn&apos;t attempt the actual cross-origin request.
    /// 
    /// Conversely, if the request `Origin` matches one of the configured
    /// allowed origins, the gateway sets the response header
    /// `Access-Control-Allow-Origin` to the same value as the `Origin`
    /// header provided by the client.
    /// 
    /// If the configuration contains the wildcard `*` in `allowOrigins` and
    /// `allowCredentials` is set to `false`, the `Access-Control-Allow-Origin`
    /// response header may either contain the wildcard `*` or echo the value
    /// of the `Origin` request header.
    /// 
    /// If the configuration contains the wildcard `*` in `allowOrigins` and
    /// `allowCredentials` is set to `true`, the gateway must not return `*`
    /// in the `Access-Control-Allow-Origin` response header. Instead, it must
    /// return a single origin matching the value of the `Origin` request header.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>
    /// ExposeHeaders indicates which HTTP response headers can be exposed
    /// to client-side scripts in response to a cross-origin request.
    /// 
    /// A CORS-safelisted response header is an HTTP header in a CORS response
    /// that it is considered safe to expose to the client scripts.
    /// The CORS-safelisted response headers include the following headers:
    /// `Cache-Control`
    /// `Content-Language`
    /// `Content-Length`
    /// `Content-Type`
    /// `Expires`
    /// `Last-Modified`
    /// `Pragma`
    /// (See https://fetch.spec.whatwg.org/#cors-safelisted-response-header-name)
    /// The CORS-safelisted response headers are exposed to client by default.
    /// 
    /// When an HTTP header name is specified using the `exposeHeaders` field,
    /// this additional header will be exposed as part of the response to the
    /// client.
    /// 
    /// Header names are not case-sensitive.
    /// 
    /// Multiple header names in the value of the `Access-Control-Expose-Headers`
    /// response header are separated by a comma (&quot;,&quot;).
    /// 
    /// A wildcard indicates that the responses with all HTTP headers are exposed
    /// to clients.
    /// 
    /// If the configuration contains the wildcard `*` in `exposeHeaders` and
    /// `allowCredentials` is set to `false`, the `Access-Control-Expose-Headers`
    /// response header can contain the wildcard `*`.
    /// 
    /// If the configuration contains the wildcard `*` in `exposeHeaders` and
    /// `allowCredentials` is set to `true`, the gateway cannot use the `*`
    /// in the `Access-Control-Expose-Headers` response header.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// MaxAge indicates the duration (in seconds) for the client to cache the
    /// results of a &quot;preflight&quot; request.
    /// 
    /// The information provided by the `Access-Control-Allow-Methods` and
    /// `Access-Control-Allow-Headers` response headers can be cached by the
    /// client until the time specified by `Access-Control-Max-Age` elapses.
    /// 
    /// The default value of `Access-Control-Max-Age` response header is 5
    /// (seconds).
    /// 
    /// When the `MaxAge` field is unspecified, the gateway sets the response
    /// header &quot;Access-Control-Max-Age: 5&quot; by default.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

/// <summary>
/// ExtensionRef is an optional, implementation-specific extension to the
/// &quot;filter&quot; behavior.  For example, resource &quot;myroutefilter&quot; in group
/// &quot;networking.example.net&quot;). ExtensionRef MUST NOT be used for core and
/// extended filters.
/// 
/// This filter can be used multiple times within the same rule.
/// 
/// Support: Implementation-specific
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersExtensionRef
{
    /// <summary>
    /// Group is the group of the referent. For example, &quot;gateway.networking.k8s.io&quot;.
    /// When unspecified or empty string, core API group is inferred.
    /// </summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>Kind is kind of the referent. For example &quot;HTTPRoute&quot; or &quot;Service&quot;.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>HTTPHeader represents an HTTP Header name and value as defined by RFC 7230.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestHeaderModifierAdd
{
    /// <summary>
    /// Name is the name of the HTTP Header to be matched. Name matching MUST be
    /// case-insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).
    /// 
    /// If multiple entries specify equivalent header names, the first entry with
    /// an equivalent name MUST be considered for a match. Subsequent entries
    /// with an equivalent header name MUST be ignored. Due to the
    /// case-insensitivity of header names, &quot;foo&quot; and &quot;Foo&quot; are considered
    /// equivalent.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>HTTPHeader represents an HTTP Header name and value as defined by RFC 7230.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestHeaderModifierSet
{
    /// <summary>
    /// Name is the name of the HTTP Header to be matched. Name matching MUST be
    /// case-insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).
    /// 
    /// If multiple entries specify equivalent header names, the first entry with
    /// an equivalent name MUST be considered for a match. Subsequent entries
    /// with an equivalent header name MUST be ignored. Due to the
    /// case-insensitivity of header names, &quot;foo&quot; and &quot;Foo&quot; are considered
    /// equivalent.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// RequestHeaderModifier defines a schema for a filter that modifies request
/// headers.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestHeaderModifier
{
    /// <summary>
    /// Add adds the given header(s) (name, value) to the request
    /// before the action. It appends to any existing values associated
    /// with the header name.
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo
    /// 
    /// Config:
    ///   add:
    ///   - name: &quot;my-header&quot;
    ///     value: &quot;bar,baz&quot;
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo,bar,baz
    /// </summary>
    [JsonPropertyName("add")]
    public IList<V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestHeaderModifierAdd>? Add { get; set; }

    /// <summary>
    /// Remove the given header(s) from the HTTP request before the action. The
    /// value of Remove is a list of HTTP header names. Note that the header
    /// names are case-insensitive (see
    /// https://datatracker.ietf.org/doc/html/rfc2616#section-4.2).
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header1: foo
    ///   my-header2: bar
    ///   my-header3: baz
    /// 
    /// Config:
    ///   remove: [&quot;my-header1&quot;, &quot;my-header3&quot;]
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header2: bar
    /// </summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary>
    /// Set overwrites the request with the given header (name, value)
    /// before the action.
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo
    /// 
    /// Config:
    ///   set:
    ///   - name: &quot;my-header&quot;
    ///     value: &quot;bar&quot;
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header: bar
    /// </summary>
    [JsonPropertyName("set")]
    public IList<V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestHeaderModifierSet>? Set { get; set; }
}

/// <summary>
/// BackendRef references a resource where mirrored requests are sent.
/// 
/// Mirrored requests must be sent only to a single destination endpoint
/// within this BackendRef, irrespective of how many endpoints are present
/// within this BackendRef.
/// 
/// If the referent cannot be found, this BackendRef is invalid and must be
/// dropped from the Gateway. The controller must ensure the &quot;ResolvedRefs&quot;
/// condition on the Route status is set to `status: False` and not configure
/// this backend in the underlying implementation.
/// 
/// If there is a cross-namespace reference to an *existing* object
/// that is not allowed by a ReferenceGrant, the controller must ensure the
/// &quot;ResolvedRefs&quot;  condition on the Route is set to `status: False`,
/// with the &quot;RefNotPermitted&quot; reason and not configure this backend in the
/// underlying implementation.
/// 
/// In either error case, the Message of the `ResolvedRefs` Condition
/// should be used to provide more detail about the problem.
/// 
/// Support: Extended for Kubernetes Service
/// 
/// Support: Implementation-specific for any other resource
/// 
/// If the backend service requires TLS, use BackendTLSPolicy to tell the
/// implementation to supply the TLS details to be used to connect to that
/// backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestMirrorBackendRef
{
    /// <summary>
    /// Group is the group of the referent. For example, &quot;gateway.networking.k8s.io&quot;.
    /// When unspecified or empty string, core API group is inferred.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>
    /// Kind is the Kubernetes resource kind of the referent. For example
    /// &quot;Service&quot;.
    /// 
    /// Defaults to &quot;Service&quot; when not specified.
    /// 
    /// ExternalName services can refer to CNAME DNS records that may live
    /// outside of the cluster and as such are difficult to reason about in
    /// terms of conformance. They also may not be safe to forward to (see
    /// CVE-2021-25740 for more information). Implementations SHOULD NOT
    /// support ExternalName Services.
    /// 
    /// Support: Core (Services with a type other than ExternalName)
    /// 
    /// Support: Implementation-specific (Services with type ExternalName)
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace is the namespace of the backend. When unspecified, the local
    /// namespace is inferred.
    /// 
    /// Note that when a namespace different than the local namespace is specified,
    /// a ReferenceGrant object is required in the referent namespace to allow that
    /// namespace&apos;s owner to accept the reference. See the ReferenceGrant
    /// documentation for details.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Port specifies the destination port number to use for this resource.
    /// Port is required when the referent is a Kubernetes Service. In this
    /// case, the port number is the service port number, not the target port.
    /// For other resources, destination port might be derived from the referent
    /// resource or this field.
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// Fraction represents the fraction of requests that should be
/// mirrored to BackendRef.
/// 
/// Only one of Fraction or Percent may be specified. If neither field
/// is specified, 100% of requests will be mirrored.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestMirrorFraction
{
    [JsonPropertyName("denominator")]
    public int? Denominator { get; set; }

    [JsonPropertyName("numerator")]
    public required int Numerator { get; set; }
}

/// <summary>
/// RequestMirror defines a schema for a filter that mirrors requests.
/// Requests are sent to the specified destination, but responses from
/// that destination are ignored.
/// 
/// This filter can be used multiple times within the same rule. Note that
/// not all implementations will be able to support mirroring to multiple
/// backends.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestMirror
{
    /// <summary>
    /// BackendRef references a resource where mirrored requests are sent.
    /// 
    /// Mirrored requests must be sent only to a single destination endpoint
    /// within this BackendRef, irrespective of how many endpoints are present
    /// within this BackendRef.
    /// 
    /// If the referent cannot be found, this BackendRef is invalid and must be
    /// dropped from the Gateway. The controller must ensure the &quot;ResolvedRefs&quot;
    /// condition on the Route status is set to `status: False` and not configure
    /// this backend in the underlying implementation.
    /// 
    /// If there is a cross-namespace reference to an *existing* object
    /// that is not allowed by a ReferenceGrant, the controller must ensure the
    /// &quot;ResolvedRefs&quot;  condition on the Route is set to `status: False`,
    /// with the &quot;RefNotPermitted&quot; reason and not configure this backend in the
    /// underlying implementation.
    /// 
    /// In either error case, the Message of the `ResolvedRefs` Condition
    /// should be used to provide more detail about the problem.
    /// 
    /// Support: Extended for Kubernetes Service
    /// 
    /// Support: Implementation-specific for any other resource
    /// 
    /// If the backend service requires TLS, use BackendTLSPolicy to tell the
    /// implementation to supply the TLS details to be used to connect to that
    /// backend.
    /// </summary>
    [JsonPropertyName("backendRef")]
    public required V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestMirrorBackendRef BackendRef { get; set; }

    /// <summary>
    /// Fraction represents the fraction of requests that should be
    /// mirrored to BackendRef.
    /// 
    /// Only one of Fraction or Percent may be specified. If neither field
    /// is specified, 100% of requests will be mirrored.
    /// </summary>
    [JsonPropertyName("fraction")]
    public V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestMirrorFraction? Fraction { get; set; }

    /// <summary>
    /// Percent represents the percentage of requests that should be
    /// mirrored to BackendRef. Its minimum value is 0 (indicating 0% of
    /// requests) and its maximum value is 100 (indicating 100% of requests).
    /// 
    /// Only one of Fraction or Percent may be specified. If neither field
    /// is specified, 100% of requests will be mirrored.
    /// </summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }
}

/// <summary>
/// Type defines the type of path modifier. Additional types may be
/// added in a future release of the API.
/// 
/// Note that values may be added to this enum, implementations
/// must ensure that unknown values will not cause a crash.
/// 
/// Unknown values here must result in the implementation setting the
/// Accepted Condition for the Route to `status: False`, with a
/// Reason of `UnsupportedValue`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestRedirectPathTypeEnum>))]
public enum V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestRedirectPathTypeEnum
{
    [EnumMember(Value = "ReplaceFullPath"), JsonStringEnumMemberName("ReplaceFullPath")]
    ReplaceFullPath,
    [EnumMember(Value = "ReplacePrefixMatch"), JsonStringEnumMemberName("ReplacePrefixMatch")]
    ReplacePrefixMatch
}

/// <summary>
/// Path defines parameters used to modify the path of the incoming request.
/// The modified path is then used to construct the `Location` header. When
/// empty, the request path is used as-is.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestRedirectPath
{
    /// <summary>
    /// ReplaceFullPath specifies the value with which to replace the full path
    /// of a request during a rewrite or redirect.
    /// </summary>
    [JsonPropertyName("replaceFullPath")]
    public string? ReplaceFullPath { get; set; }

    /// <summary>
    /// ReplacePrefixMatch specifies the value with which to replace the prefix
    /// match of a request during a rewrite or redirect. For example, a request
    /// to &quot;/foo/bar&quot; with a prefix match of &quot;/foo&quot; and a ReplacePrefixMatch
    /// of &quot;/xyz&quot; would be modified to &quot;/xyz/bar&quot;.
    /// 
    /// Note that this matches the behavior of the PathPrefix match type. This
    /// matches full path elements. A path element refers to the list of labels
    /// in the path split by the `/` separator. When specified, a trailing `/` is
    /// ignored. For example, the paths `/abc`, `/abc/`, and `/abc/def` would all
    /// match the prefix `/abc`, but the path `/abcd` would not.
    /// 
    /// ReplacePrefixMatch is only compatible with a `PathPrefix` HTTPRouteMatch.
    /// Using any other HTTPRouteMatch type on the same HTTPRouteRule will result in
    /// the implementation setting the Accepted Condition for the Route to `status: False`.
    /// 
    /// Request Path | Prefix Match | Replace Prefix | Modified Path
    /// </summary>
    [JsonPropertyName("replacePrefixMatch")]
    public string? ReplacePrefixMatch { get; set; }

    /// <summary>
    /// Type defines the type of path modifier. Additional types may be
    /// added in a future release of the API.
    /// 
    /// Note that values may be added to this enum, implementations
    /// must ensure that unknown values will not cause a crash.
    /// 
    /// Unknown values here must result in the implementation setting the
    /// Accepted Condition for the Route to `status: False`, with a
    /// Reason of `UnsupportedValue`.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestRedirectPathTypeEnum Type { get; set; }
}

/// <summary>
/// Scheme is the scheme to be used in the value of the `Location` header in
/// the response. When empty, the scheme of the request is used.
/// 
/// Scheme redirects can affect the port of the redirect, for more information,
/// refer to the documentation for the port field of this filter.
/// 
/// Note that values may be added to this enum, implementations
/// must ensure that unknown values will not cause a crash.
/// 
/// Unknown values here must result in the implementation setting the
/// Accepted Condition for the Route to `status: False`, with a
/// Reason of `UnsupportedValue`.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestRedirectSchemeEnum>))]
public enum V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestRedirectSchemeEnum
{
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "https"), JsonStringEnumMemberName("https")]
    Https
}

/// <summary>
/// RequestRedirect defines a schema for a filter that responds to the
/// request with an HTTP redirection.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestRedirect
{
    /// <summary>
    /// Hostname is the hostname to be used in the value of the `Location`
    /// header in the response.
    /// When empty, the hostname in the `Host` header of the request is used.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Path defines parameters used to modify the path of the incoming request.
    /// The modified path is then used to construct the `Location` header. When
    /// empty, the request path is used as-is.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("path")]
    public V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestRedirectPath? Path { get; set; }

    /// <summary>
    /// Port is the port to be used in the value of the `Location`
    /// header in the response.
    /// 
    /// If no port is specified, the redirect port MUST be derived using the
    /// following rules:
    /// 
    /// * If redirect scheme is not-empty, the redirect port MUST be the well-known
    ///   port associated with the redirect scheme. Specifically &quot;http&quot; to port 80
    ///   and &quot;https&quot; to port 443. If the redirect scheme does not have a
    ///   well-known port, the listener port of the Gateway SHOULD be used.
    /// * If redirect scheme is empty, the redirect port MUST be the Gateway
    ///   Listener port.
    /// 
    /// Implementations SHOULD NOT add the port number in the &apos;Location&apos;
    /// header in the following cases:
    /// 
    /// * A Location header that will use HTTP (whether that is determined via
    ///   the Listener protocol or the Scheme field) _and_ use port 80.
    /// * A Location header that will use HTTPS (whether that is determined via
    ///   the Listener protocol or the Scheme field) _and_ use port 443.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>
    /// Scheme is the scheme to be used in the value of the `Location` header in
    /// the response. When empty, the scheme of the request is used.
    /// 
    /// Scheme redirects can affect the port of the redirect, for more information,
    /// refer to the documentation for the port field of this filter.
    /// 
    /// Note that values may be added to this enum, implementations
    /// must ensure that unknown values will not cause a crash.
    /// 
    /// Unknown values here must result in the implementation setting the
    /// Accepted Condition for the Route to `status: False`, with a
    /// Reason of `UnsupportedValue`.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("scheme")]
    public V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestRedirectSchemeEnum? Scheme { get; set; }

    /// <summary>
    /// StatusCode is the HTTP status code to be used in response.
    /// 
    /// Note that values may be added to this enum, implementations
    /// must ensure that unknown values will not cause a crash.
    /// 
    /// Unknown values here must result in the implementation setting the
    /// Accepted Condition for the Route to `status: False`, with a
    /// Reason of `UnsupportedValue`.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
}

/// <summary>HTTPHeader represents an HTTP Header name and value as defined by RFC 7230.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersResponseHeaderModifierAdd
{
    /// <summary>
    /// Name is the name of the HTTP Header to be matched. Name matching MUST be
    /// case-insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).
    /// 
    /// If multiple entries specify equivalent header names, the first entry with
    /// an equivalent name MUST be considered for a match. Subsequent entries
    /// with an equivalent header name MUST be ignored. Due to the
    /// case-insensitivity of header names, &quot;foo&quot; and &quot;Foo&quot; are considered
    /// equivalent.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>HTTPHeader represents an HTTP Header name and value as defined by RFC 7230.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersResponseHeaderModifierSet
{
    /// <summary>
    /// Name is the name of the HTTP Header to be matched. Name matching MUST be
    /// case-insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).
    /// 
    /// If multiple entries specify equivalent header names, the first entry with
    /// an equivalent name MUST be considered for a match. Subsequent entries
    /// with an equivalent header name MUST be ignored. Due to the
    /// case-insensitivity of header names, &quot;foo&quot; and &quot;Foo&quot; are considered
    /// equivalent.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// ResponseHeaderModifier defines a schema for a filter that modifies response
/// headers.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersResponseHeaderModifier
{
    /// <summary>
    /// Add adds the given header(s) (name, value) to the request
    /// before the action. It appends to any existing values associated
    /// with the header name.
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo
    /// 
    /// Config:
    ///   add:
    ///   - name: &quot;my-header&quot;
    ///     value: &quot;bar,baz&quot;
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo,bar,baz
    /// </summary>
    [JsonPropertyName("add")]
    public IList<V1beta1HTTPRouteSpecRulesBackendRefsFiltersResponseHeaderModifierAdd>? Add { get; set; }

    /// <summary>
    /// Remove the given header(s) from the HTTP request before the action. The
    /// value of Remove is a list of HTTP header names. Note that the header
    /// names are case-insensitive (see
    /// https://datatracker.ietf.org/doc/html/rfc2616#section-4.2).
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header1: foo
    ///   my-header2: bar
    ///   my-header3: baz
    /// 
    /// Config:
    ///   remove: [&quot;my-header1&quot;, &quot;my-header3&quot;]
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header2: bar
    /// </summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary>
    /// Set overwrites the request with the given header (name, value)
    /// before the action.
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo
    /// 
    /// Config:
    ///   set:
    ///   - name: &quot;my-header&quot;
    ///     value: &quot;bar&quot;
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header: bar
    /// </summary>
    [JsonPropertyName("set")]
    public IList<V1beta1HTTPRouteSpecRulesBackendRefsFiltersResponseHeaderModifierSet>? Set { get; set; }
}

/// <summary>
/// Type identifies the type of filter to apply. As with other API fields,
/// types are classified into three conformance levels:
/// 
/// - Core: Filter types and their corresponding configuration defined by
///   &quot;Support: Core&quot; in this package, e.g. &quot;RequestHeaderModifier&quot;. All
///   implementations must support core filters.
/// 
/// - Extended: Filter types and their corresponding configuration defined by
///   &quot;Support: Extended&quot; in this package, e.g. &quot;RequestMirror&quot;. Implementers
///   are encouraged to support extended filters.
/// 
/// - Implementation-specific: Filters that are defined and supported by
///   specific vendors.
///   In the future, filters showing convergence in behavior across multiple
///   implementations will be considered for inclusion in extended or core
///   conformance levels. Filter-specific configuration for such filters
///   is specified using the ExtensionRef field. `Type` should be set to
///   &quot;ExtensionRef&quot; for custom filters.
/// 
/// Implementers are encouraged to define custom implementation types to
/// extend the core API with implementation-specific behavior.
/// 
/// If a reference to a custom filter type cannot be resolved, the filter
/// MUST NOT be skipped. Instead, requests that would have been processed by
/// that filter MUST receive a HTTP error response.
/// 
/// Note that values may be added to this enum, implementations
/// must ensure that unknown values will not cause a crash.
/// 
/// Unknown values here must result in the implementation setting the
/// Accepted Condition for the Route to `status: False`, with a
/// Reason of `UnsupportedValue`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesBackendRefsFiltersTypeEnum>))]
public enum V1beta1HTTPRouteSpecRulesBackendRefsFiltersTypeEnum
{
    [EnumMember(Value = "RequestHeaderModifier"), JsonStringEnumMemberName("RequestHeaderModifier")]
    RequestHeaderModifier,
    [EnumMember(Value = "ResponseHeaderModifier"), JsonStringEnumMemberName("ResponseHeaderModifier")]
    ResponseHeaderModifier,
    [EnumMember(Value = "RequestMirror"), JsonStringEnumMemberName("RequestMirror")]
    RequestMirror,
    [EnumMember(Value = "RequestRedirect"), JsonStringEnumMemberName("RequestRedirect")]
    RequestRedirect,
    [EnumMember(Value = "URLRewrite"), JsonStringEnumMemberName("URLRewrite")]
    URLRewrite,
    [EnumMember(Value = "ExtensionRef"), JsonStringEnumMemberName("ExtensionRef")]
    ExtensionRef,
    [EnumMember(Value = "CORS"), JsonStringEnumMemberName("CORS")]
    CORS
}

/// <summary>
/// Type defines the type of path modifier. Additional types may be
/// added in a future release of the API.
/// 
/// Note that values may be added to this enum, implementations
/// must ensure that unknown values will not cause a crash.
/// 
/// Unknown values here must result in the implementation setting the
/// Accepted Condition for the Route to `status: False`, with a
/// Reason of `UnsupportedValue`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesBackendRefsFiltersUrlRewritePathTypeEnum>))]
public enum V1beta1HTTPRouteSpecRulesBackendRefsFiltersUrlRewritePathTypeEnum
{
    [EnumMember(Value = "ReplaceFullPath"), JsonStringEnumMemberName("ReplaceFullPath")]
    ReplaceFullPath,
    [EnumMember(Value = "ReplacePrefixMatch"), JsonStringEnumMemberName("ReplacePrefixMatch")]
    ReplacePrefixMatch
}

/// <summary>
/// Path defines a path rewrite.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersUrlRewritePath
{
    /// <summary>
    /// ReplaceFullPath specifies the value with which to replace the full path
    /// of a request during a rewrite or redirect.
    /// </summary>
    [JsonPropertyName("replaceFullPath")]
    public string? ReplaceFullPath { get; set; }

    /// <summary>
    /// ReplacePrefixMatch specifies the value with which to replace the prefix
    /// match of a request during a rewrite or redirect. For example, a request
    /// to &quot;/foo/bar&quot; with a prefix match of &quot;/foo&quot; and a ReplacePrefixMatch
    /// of &quot;/xyz&quot; would be modified to &quot;/xyz/bar&quot;.
    /// 
    /// Note that this matches the behavior of the PathPrefix match type. This
    /// matches full path elements. A path element refers to the list of labels
    /// in the path split by the `/` separator. When specified, a trailing `/` is
    /// ignored. For example, the paths `/abc`, `/abc/`, and `/abc/def` would all
    /// match the prefix `/abc`, but the path `/abcd` would not.
    /// 
    /// ReplacePrefixMatch is only compatible with a `PathPrefix` HTTPRouteMatch.
    /// Using any other HTTPRouteMatch type on the same HTTPRouteRule will result in
    /// the implementation setting the Accepted Condition for the Route to `status: False`.
    /// 
    /// Request Path | Prefix Match | Replace Prefix | Modified Path
    /// </summary>
    [JsonPropertyName("replacePrefixMatch")]
    public string? ReplacePrefixMatch { get; set; }

    /// <summary>
    /// Type defines the type of path modifier. Additional types may be
    /// added in a future release of the API.
    /// 
    /// Note that values may be added to this enum, implementations
    /// must ensure that unknown values will not cause a crash.
    /// 
    /// Unknown values here must result in the implementation setting the
    /// Accepted Condition for the Route to `status: False`, with a
    /// Reason of `UnsupportedValue`.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1beta1HTTPRouteSpecRulesBackendRefsFiltersUrlRewritePathTypeEnum Type { get; set; }
}

/// <summary>
/// URLRewrite defines a schema for a filter that modifies a request during forwarding.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFiltersUrlRewrite
{
    /// <summary>
    /// Hostname is the value to be used to replace the Host header value during
    /// forwarding.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Path defines a path rewrite.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("path")]
    public V1beta1HTTPRouteSpecRulesBackendRefsFiltersUrlRewritePath? Path { get; set; }
}

/// <summary>
/// HTTPRouteFilter defines processing steps that must be completed during the
/// request or response lifecycle. HTTPRouteFilters are meant as an extension
/// point to express processing that may be done in Gateway implementations. Some
/// examples include request or response modification, implementing
/// authentication strategies, rate-limiting, and traffic shaping. API
/// guarantee/conformance is defined based on the type of the filter.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefsFilters
{
    /// <summary>
    /// CORS defines a schema for a filter that responds to the
    /// cross-origin request based on HTTP response header.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("cors")]
    public V1beta1HTTPRouteSpecRulesBackendRefsFiltersCors? Cors { get; set; }

    /// <summary>
    /// ExtensionRef is an optional, implementation-specific extension to the
    /// &quot;filter&quot; behavior.  For example, resource &quot;myroutefilter&quot; in group
    /// &quot;networking.example.net&quot;). ExtensionRef MUST NOT be used for core and
    /// extended filters.
    /// 
    /// This filter can be used multiple times within the same rule.
    /// 
    /// Support: Implementation-specific
    /// </summary>
    [JsonPropertyName("extensionRef")]
    public V1beta1HTTPRouteSpecRulesBackendRefsFiltersExtensionRef? ExtensionRef { get; set; }

    /// <summary>
    /// RequestHeaderModifier defines a schema for a filter that modifies request
    /// headers.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("requestHeaderModifier")]
    public V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestHeaderModifier? RequestHeaderModifier { get; set; }

    /// <summary>
    /// RequestMirror defines a schema for a filter that mirrors requests.
    /// Requests are sent to the specified destination, but responses from
    /// that destination are ignored.
    /// 
    /// This filter can be used multiple times within the same rule. Note that
    /// not all implementations will be able to support mirroring to multiple
    /// backends.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("requestMirror")]
    public V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestMirror? RequestMirror { get; set; }

    /// <summary>
    /// RequestRedirect defines a schema for a filter that responds to the
    /// request with an HTTP redirection.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("requestRedirect")]
    public V1beta1HTTPRouteSpecRulesBackendRefsFiltersRequestRedirect? RequestRedirect { get; set; }

    /// <summary>
    /// ResponseHeaderModifier defines a schema for a filter that modifies response
    /// headers.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("responseHeaderModifier")]
    public V1beta1HTTPRouteSpecRulesBackendRefsFiltersResponseHeaderModifier? ResponseHeaderModifier { get; set; }

    /// <summary>
    /// Type identifies the type of filter to apply. As with other API fields,
    /// types are classified into three conformance levels:
    /// 
    /// - Core: Filter types and their corresponding configuration defined by
    ///   &quot;Support: Core&quot; in this package, e.g. &quot;RequestHeaderModifier&quot;. All
    ///   implementations must support core filters.
    /// 
    /// - Extended: Filter types and their corresponding configuration defined by
    ///   &quot;Support: Extended&quot; in this package, e.g. &quot;RequestMirror&quot;. Implementers
    ///   are encouraged to support extended filters.
    /// 
    /// - Implementation-specific: Filters that are defined and supported by
    ///   specific vendors.
    ///   In the future, filters showing convergence in behavior across multiple
    ///   implementations will be considered for inclusion in extended or core
    ///   conformance levels. Filter-specific configuration for such filters
    ///   is specified using the ExtensionRef field. `Type` should be set to
    ///   &quot;ExtensionRef&quot; for custom filters.
    /// 
    /// Implementers are encouraged to define custom implementation types to
    /// extend the core API with implementation-specific behavior.
    /// 
    /// If a reference to a custom filter type cannot be resolved, the filter
    /// MUST NOT be skipped. Instead, requests that would have been processed by
    /// that filter MUST receive a HTTP error response.
    /// 
    /// Note that values may be added to this enum, implementations
    /// must ensure that unknown values will not cause a crash.
    /// 
    /// Unknown values here must result in the implementation setting the
    /// Accepted Condition for the Route to `status: False`, with a
    /// Reason of `UnsupportedValue`.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1beta1HTTPRouteSpecRulesBackendRefsFiltersTypeEnum Type { get; set; }

    /// <summary>
    /// URLRewrite defines a schema for a filter that modifies a request during forwarding.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta1HTTPRouteSpecRulesBackendRefsFiltersUrlRewrite? UrlRewrite { get; set; }
}

/// <summary>
/// HTTPBackendRef defines how a HTTPRoute forwards a HTTP request.
/// 
/// Note that when a namespace different than the local namespace is specified, a
/// ReferenceGrant object is required in the referent namespace to allow that
/// namespace&apos;s owner to accept the reference. See the ReferenceGrant
/// documentation for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesBackendRefs
{
    /// <summary>
    /// Filters defined at this level should be executed if and only if the
    /// request is being forwarded to the backend defined here.
    /// 
    /// Support: Implementation-specific (For broader support of filters, use the
    /// Filters field in HTTPRouteRule.)
    /// </summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1HTTPRouteSpecRulesBackendRefsFilters>? Filters { get; set; }

    /// <summary>
    /// Group is the group of the referent. For example, &quot;gateway.networking.k8s.io&quot;.
    /// When unspecified or empty string, core API group is inferred.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>
    /// Kind is the Kubernetes resource kind of the referent. For example
    /// &quot;Service&quot;.
    /// 
    /// Defaults to &quot;Service&quot; when not specified.
    /// 
    /// ExternalName services can refer to CNAME DNS records that may live
    /// outside of the cluster and as such are difficult to reason about in
    /// terms of conformance. They also may not be safe to forward to (see
    /// CVE-2021-25740 for more information). Implementations SHOULD NOT
    /// support ExternalName Services.
    /// 
    /// Support: Core (Services with a type other than ExternalName)
    /// 
    /// Support: Implementation-specific (Services with type ExternalName)
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace is the namespace of the backend. When unspecified, the local
    /// namespace is inferred.
    /// 
    /// Note that when a namespace different than the local namespace is specified,
    /// a ReferenceGrant object is required in the referent namespace to allow that
    /// namespace&apos;s owner to accept the reference. See the ReferenceGrant
    /// documentation for details.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Port specifies the destination port number to use for this resource.
    /// Port is required when the referent is a Kubernetes Service. In this
    /// case, the port number is the service port number, not the target port.
    /// For other resources, destination port might be derived from the referent
    /// resource or this field.
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>
    /// Weight specifies the proportion of requests forwarded to the referenced
    /// backend. This is computed as weight/(sum of all weights in this
    /// BackendRefs list). For non-zero values, there may be some epsilon from
    /// the exact proportion defined here depending on the precision an
    /// implementation supports. Weight is not a percentage and the sum of
    /// weights does not need to equal 100.
    /// 
    /// If only one backend is specified and it has a weight greater than 0, 100%
    /// of the traffic is forwarded to that backend. If weight is set to 0, no
    /// traffic should be forwarded for this entry. If unspecified, weight
    /// defaults to 1.
    /// 
    /// Support for this field varies based on the context where used.
    /// </summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesFiltersCorsAllowMethodsEnum>))]
public enum V1beta1HTTPRouteSpecRulesFiltersCorsAllowMethodsEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "HEAD"), JsonStringEnumMemberName("HEAD")]
    HEAD,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST,
    [EnumMember(Value = "PUT"), JsonStringEnumMemberName("PUT")]
    PUT,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "OPTIONS"), JsonStringEnumMemberName("OPTIONS")]
    OPTIONS,
    [EnumMember(Value = "TRACE"), JsonStringEnumMemberName("TRACE")]
    TRACE,
    [EnumMember(Value = "PATCH"), JsonStringEnumMemberName("PATCH")]
    PATCH,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option9
}

/// <summary>
/// CORS defines a schema for a filter that responds to the
/// cross-origin request based on HTTP response header.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersCors
{
    /// <summary>
    /// AllowCredentials indicates whether the actual cross-origin request allows
    /// to include credentials.
    /// 
    /// When set to true, the gateway will include the `Access-Control-Allow-Credentials`
    /// response header with value true (case-sensitive).
    /// 
    /// When set to false or omitted the gateway will omit the header
    /// `Access-Control-Allow-Credentials` entirely (this is the standard CORS
    /// behavior).
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("allowCredentials")]
    public bool? AllowCredentials { get; set; }

    /// <summary>
    /// AllowHeaders indicates which HTTP request headers are supported for
    /// accessing the requested resource.
    /// 
    /// Header names are not case-sensitive.
    /// 
    /// Multiple header names in the value of the `Access-Control-Allow-Headers`
    /// response header are separated by a comma (&quot;,&quot;).
    /// 
    /// When the `allowHeaders` field is configured with one or more headers, the
    /// gateway must return the `Access-Control-Allow-Headers` response header
    /// which value is present in the `allowHeaders` field.
    /// 
    /// If any header name in the `Access-Control-Request-Headers` request header
    /// is not included in the list of header names specified by the response
    /// header `Access-Control-Allow-Headers`, it will present an error on the
    /// client side.
    /// 
    /// If any header name in the `Access-Control-Allow-Headers` response header
    /// does not recognize by the client, it will also occur an error on the
    /// client side.
    /// 
    /// A wildcard indicates that the requests with all HTTP headers are allowed.
    /// 
    /// If the configuration contains the wildcard `*` in `allowHeaders` and
    /// `allowCredentials` is set to `false`, the `Access-Control-Allow-Headers`
    /// response header may either contain the wildcard `*` or echo the value
    /// of the `Access-Control-Request-Headers` request header.
    /// 
    /// If the configuration contains the wildcard `*` in `allowHeaders` and
    /// `allowCredentials` is set to `true`, the gateway must not return `*`
    /// in the `Access-Control-Allow-Headers` response header. Instead, it must
    /// return one or more header names matching the value of the
    /// `Access-Control-Request-Headers` request header.
    /// If the `Access-Control-Request-Headers` header is not present in the
    /// request, the gateway must omit the `Access-Control-Allow-Headers`
    /// response header.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("allowHeaders")]
    public IList<string>? AllowHeaders { get; set; }

    /// <summary>
    /// AllowMethods indicates which HTTP methods are supported for accessing the
    /// requested resource.
    /// 
    /// Valid values are any method defined by RFC9110, along with the special
    /// value `*`, which represents all HTTP methods are allowed.
    /// 
    /// Method names are case-sensitive, so these values are also case-sensitive.
    /// (See https://www.rfc-editor.org/rfc/rfc2616#section-5.1.1)
    /// 
    /// Multiple method names in the value of the `Access-Control-Allow-Methods`
    /// response header are separated by a comma (&quot;,&quot;).
    /// 
    /// A CORS-safelisted method is a method that is `GET`, `HEAD`, or `POST`.
    /// (See https://fetch.spec.whatwg.org/#cors-safelisted-method) The
    /// CORS-safelisted methods are always allowed, regardless of whether they
    /// are specified in the `allowMethods` field.
    /// 
    /// When the `allowMethods` field is configured with one or more methods, the
    /// gateway must return the `Access-Control-Allow-Methods` response header
    /// which value is present in the `allowMethods` field.
    /// 
    /// If the HTTP method of the `Access-Control-Request-Method` request header
    /// is not included in the list of methods specified by the response header
    /// `Access-Control-Allow-Methods`, it will present an error on the client
    /// side.
    /// 
    /// If the configuration contains the wildcard `*` in `allowMethods` and
    /// `allowCredentials` is set to `false`, the `Access-Control-Allow-Methods`
    /// response header may either contain the wildcard `*` or echo the value
    /// of the `Access-Control-Request-Method` request header.
    /// 
    /// If the configuration contains the wildcard `*` in `allowMethods` and
    /// `allowCredentials` is set to `true`, the gateway must not return `*`
    /// in the `Access-Control-Allow-Methods` response header. Instead, it must
    /// return a single HTTP method matching the value of the
    /// `Access-Control-Request-Method` request header.
    /// If the `Access-Control-Request-Method` header is not present in the request,
    /// the gateway must omit the `Access-Control-Allow-Methods` response header.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("allowMethods")]
    public IList<V1beta1HTTPRouteSpecRulesFiltersCorsAllowMethodsEnum>? AllowMethods { get; set; }

    /// <summary>
    /// AllowOrigins indicates whether the response can be shared with requested
    /// resource from the given `Origin`.
    /// 
    /// The `Origin` consists of a scheme and a host, with an optional port, and
    /// takes the form `&lt;scheme&gt;://&lt;host&gt;(:&lt;port&gt;)`.
    /// 
    /// Valid values for scheme are: `http` and `https`.
    /// 
    /// Valid values for port are any integer between 1 and 65535 (the list of
    /// available TCP/UDP ports). Note that, if not included, port `80` is
    /// assumed for `http` scheme origins, and port `443` is assumed for `https`
    /// origins. This may affect origin matching.
    /// 
    /// The host part of the origin may contain the wildcard character `*`. These
    /// wildcard characters behave as follows:
    /// 
    /// * `*` is a greedy match to the _left_, including any number of
    ///   DNS labels to the left of its position. This also means that
    ///   `*` will include any number of period `.` characters to the
    ///   left of its position.
    /// * A wildcard by itself matches all hosts.
    /// 
    /// An origin value that includes _only_ the `*` character indicates requests
    /// from all `Origin`s are allowed.
    /// 
    /// When the `allowOrigins` field is configured with multiple origins, it
    /// means the server supports clients from multiple origins. If the request
    /// `Origin` matches the configured allowed origins, the gateway must return
    /// the given `Origin` and sets value of the header
    /// `Access-Control-Allow-Origin` same as the `Origin` header provided by the
    /// client.
    /// 
    /// The status code of a successful response to a &quot;preflight&quot; request is
    /// always an OK status (i.e., 204 or 200).
    /// 
    /// If the request `Origin` does not match the configured allowed origins,
    /// the gateway returns 204/200 response but doesn&apos;t set the relevant
    /// cross-origin response headers. Alternatively, the gateway responds with
    /// 403 status to the &quot;preflight&quot; request is denied, coupled with omitting
    /// the CORS headers. The cross-origin request fails on the client side.
    /// Therefore, the client doesn&apos;t attempt the actual cross-origin request.
    /// 
    /// Conversely, if the request `Origin` matches one of the configured
    /// allowed origins, the gateway sets the response header
    /// `Access-Control-Allow-Origin` to the same value as the `Origin`
    /// header provided by the client.
    /// 
    /// If the configuration contains the wildcard `*` in `allowOrigins` and
    /// `allowCredentials` is set to `false`, the `Access-Control-Allow-Origin`
    /// response header may either contain the wildcard `*` or echo the value
    /// of the `Origin` request header.
    /// 
    /// If the configuration contains the wildcard `*` in `allowOrigins` and
    /// `allowCredentials` is set to `true`, the gateway must not return `*`
    /// in the `Access-Control-Allow-Origin` response header. Instead, it must
    /// return a single origin matching the value of the `Origin` request header.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("allowOrigins")]
    public IList<string>? AllowOrigins { get; set; }

    /// <summary>
    /// ExposeHeaders indicates which HTTP response headers can be exposed
    /// to client-side scripts in response to a cross-origin request.
    /// 
    /// A CORS-safelisted response header is an HTTP header in a CORS response
    /// that it is considered safe to expose to the client scripts.
    /// The CORS-safelisted response headers include the following headers:
    /// `Cache-Control`
    /// `Content-Language`
    /// `Content-Length`
    /// `Content-Type`
    /// `Expires`
    /// `Last-Modified`
    /// `Pragma`
    /// (See https://fetch.spec.whatwg.org/#cors-safelisted-response-header-name)
    /// The CORS-safelisted response headers are exposed to client by default.
    /// 
    /// When an HTTP header name is specified using the `exposeHeaders` field,
    /// this additional header will be exposed as part of the response to the
    /// client.
    /// 
    /// Header names are not case-sensitive.
    /// 
    /// Multiple header names in the value of the `Access-Control-Expose-Headers`
    /// response header are separated by a comma (&quot;,&quot;).
    /// 
    /// A wildcard indicates that the responses with all HTTP headers are exposed
    /// to clients.
    /// 
    /// If the configuration contains the wildcard `*` in `exposeHeaders` and
    /// `allowCredentials` is set to `false`, the `Access-Control-Expose-Headers`
    /// response header can contain the wildcard `*`.
    /// 
    /// If the configuration contains the wildcard `*` in `exposeHeaders` and
    /// `allowCredentials` is set to `true`, the gateway cannot use the `*`
    /// in the `Access-Control-Expose-Headers` response header.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    /// <summary>
    /// MaxAge indicates the duration (in seconds) for the client to cache the
    /// results of a &quot;preflight&quot; request.
    /// 
    /// The information provided by the `Access-Control-Allow-Methods` and
    /// `Access-Control-Allow-Headers` response headers can be cached by the
    /// client until the time specified by `Access-Control-Max-Age` elapses.
    /// 
    /// The default value of `Access-Control-Max-Age` response header is 5
    /// (seconds).
    /// 
    /// When the `MaxAge` field is unspecified, the gateway sets the response
    /// header &quot;Access-Control-Max-Age: 5&quot; by default.
    /// </summary>
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }
}

/// <summary>
/// ExtensionRef is an optional, implementation-specific extension to the
/// &quot;filter&quot; behavior.  For example, resource &quot;myroutefilter&quot; in group
/// &quot;networking.example.net&quot;). ExtensionRef MUST NOT be used for core and
/// extended filters.
/// 
/// This filter can be used multiple times within the same rule.
/// 
/// Support: Implementation-specific
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersExtensionRef
{
    /// <summary>
    /// Group is the group of the referent. For example, &quot;gateway.networking.k8s.io&quot;.
    /// When unspecified or empty string, core API group is inferred.
    /// </summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>Kind is kind of the referent. For example &quot;HTTPRoute&quot; or &quot;Service&quot;.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>HTTPHeader represents an HTTP Header name and value as defined by RFC 7230.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersRequestHeaderModifierAdd
{
    /// <summary>
    /// Name is the name of the HTTP Header to be matched. Name matching MUST be
    /// case-insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).
    /// 
    /// If multiple entries specify equivalent header names, the first entry with
    /// an equivalent name MUST be considered for a match. Subsequent entries
    /// with an equivalent header name MUST be ignored. Due to the
    /// case-insensitivity of header names, &quot;foo&quot; and &quot;Foo&quot; are considered
    /// equivalent.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>HTTPHeader represents an HTTP Header name and value as defined by RFC 7230.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersRequestHeaderModifierSet
{
    /// <summary>
    /// Name is the name of the HTTP Header to be matched. Name matching MUST be
    /// case-insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).
    /// 
    /// If multiple entries specify equivalent header names, the first entry with
    /// an equivalent name MUST be considered for a match. Subsequent entries
    /// with an equivalent header name MUST be ignored. Due to the
    /// case-insensitivity of header names, &quot;foo&quot; and &quot;Foo&quot; are considered
    /// equivalent.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// RequestHeaderModifier defines a schema for a filter that modifies request
/// headers.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersRequestHeaderModifier
{
    /// <summary>
    /// Add adds the given header(s) (name, value) to the request
    /// before the action. It appends to any existing values associated
    /// with the header name.
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo
    /// 
    /// Config:
    ///   add:
    ///   - name: &quot;my-header&quot;
    ///     value: &quot;bar,baz&quot;
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo,bar,baz
    /// </summary>
    [JsonPropertyName("add")]
    public IList<V1beta1HTTPRouteSpecRulesFiltersRequestHeaderModifierAdd>? Add { get; set; }

    /// <summary>
    /// Remove the given header(s) from the HTTP request before the action. The
    /// value of Remove is a list of HTTP header names. Note that the header
    /// names are case-insensitive (see
    /// https://datatracker.ietf.org/doc/html/rfc2616#section-4.2).
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header1: foo
    ///   my-header2: bar
    ///   my-header3: baz
    /// 
    /// Config:
    ///   remove: [&quot;my-header1&quot;, &quot;my-header3&quot;]
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header2: bar
    /// </summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary>
    /// Set overwrites the request with the given header (name, value)
    /// before the action.
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo
    /// 
    /// Config:
    ///   set:
    ///   - name: &quot;my-header&quot;
    ///     value: &quot;bar&quot;
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header: bar
    /// </summary>
    [JsonPropertyName("set")]
    public IList<V1beta1HTTPRouteSpecRulesFiltersRequestHeaderModifierSet>? Set { get; set; }
}

/// <summary>
/// BackendRef references a resource where mirrored requests are sent.
/// 
/// Mirrored requests must be sent only to a single destination endpoint
/// within this BackendRef, irrespective of how many endpoints are present
/// within this BackendRef.
/// 
/// If the referent cannot be found, this BackendRef is invalid and must be
/// dropped from the Gateway. The controller must ensure the &quot;ResolvedRefs&quot;
/// condition on the Route status is set to `status: False` and not configure
/// this backend in the underlying implementation.
/// 
/// If there is a cross-namespace reference to an *existing* object
/// that is not allowed by a ReferenceGrant, the controller must ensure the
/// &quot;ResolvedRefs&quot;  condition on the Route is set to `status: False`,
/// with the &quot;RefNotPermitted&quot; reason and not configure this backend in the
/// underlying implementation.
/// 
/// In either error case, the Message of the `ResolvedRefs` Condition
/// should be used to provide more detail about the problem.
/// 
/// Support: Extended for Kubernetes Service
/// 
/// Support: Implementation-specific for any other resource
/// 
/// If the backend service requires TLS, use BackendTLSPolicy to tell the
/// implementation to supply the TLS details to be used to connect to that
/// backend.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersRequestMirrorBackendRef
{
    /// <summary>
    /// Group is the group of the referent. For example, &quot;gateway.networking.k8s.io&quot;.
    /// When unspecified or empty string, core API group is inferred.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>
    /// Kind is the Kubernetes resource kind of the referent. For example
    /// &quot;Service&quot;.
    /// 
    /// Defaults to &quot;Service&quot; when not specified.
    /// 
    /// ExternalName services can refer to CNAME DNS records that may live
    /// outside of the cluster and as such are difficult to reason about in
    /// terms of conformance. They also may not be safe to forward to (see
    /// CVE-2021-25740 for more information). Implementations SHOULD NOT
    /// support ExternalName Services.
    /// 
    /// Support: Core (Services with a type other than ExternalName)
    /// 
    /// Support: Implementation-specific (Services with type ExternalName)
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace is the namespace of the backend. When unspecified, the local
    /// namespace is inferred.
    /// 
    /// Note that when a namespace different than the local namespace is specified,
    /// a ReferenceGrant object is required in the referent namespace to allow that
    /// namespace&apos;s owner to accept the reference. See the ReferenceGrant
    /// documentation for details.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Port specifies the destination port number to use for this resource.
    /// Port is required when the referent is a Kubernetes Service. In this
    /// case, the port number is the service port number, not the target port.
    /// For other resources, destination port might be derived from the referent
    /// resource or this field.
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// Fraction represents the fraction of requests that should be
/// mirrored to BackendRef.
/// 
/// Only one of Fraction or Percent may be specified. If neither field
/// is specified, 100% of requests will be mirrored.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersRequestMirrorFraction
{
    [JsonPropertyName("denominator")]
    public int? Denominator { get; set; }

    [JsonPropertyName("numerator")]
    public required int Numerator { get; set; }
}

/// <summary>
/// RequestMirror defines a schema for a filter that mirrors requests.
/// Requests are sent to the specified destination, but responses from
/// that destination are ignored.
/// 
/// This filter can be used multiple times within the same rule. Note that
/// not all implementations will be able to support mirroring to multiple
/// backends.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersRequestMirror
{
    /// <summary>
    /// BackendRef references a resource where mirrored requests are sent.
    /// 
    /// Mirrored requests must be sent only to a single destination endpoint
    /// within this BackendRef, irrespective of how many endpoints are present
    /// within this BackendRef.
    /// 
    /// If the referent cannot be found, this BackendRef is invalid and must be
    /// dropped from the Gateway. The controller must ensure the &quot;ResolvedRefs&quot;
    /// condition on the Route status is set to `status: False` and not configure
    /// this backend in the underlying implementation.
    /// 
    /// If there is a cross-namespace reference to an *existing* object
    /// that is not allowed by a ReferenceGrant, the controller must ensure the
    /// &quot;ResolvedRefs&quot;  condition on the Route is set to `status: False`,
    /// with the &quot;RefNotPermitted&quot; reason and not configure this backend in the
    /// underlying implementation.
    /// 
    /// In either error case, the Message of the `ResolvedRefs` Condition
    /// should be used to provide more detail about the problem.
    /// 
    /// Support: Extended for Kubernetes Service
    /// 
    /// Support: Implementation-specific for any other resource
    /// 
    /// If the backend service requires TLS, use BackendTLSPolicy to tell the
    /// implementation to supply the TLS details to be used to connect to that
    /// backend.
    /// </summary>
    [JsonPropertyName("backendRef")]
    public required V1beta1HTTPRouteSpecRulesFiltersRequestMirrorBackendRef BackendRef { get; set; }

    /// <summary>
    /// Fraction represents the fraction of requests that should be
    /// mirrored to BackendRef.
    /// 
    /// Only one of Fraction or Percent may be specified. If neither field
    /// is specified, 100% of requests will be mirrored.
    /// </summary>
    [JsonPropertyName("fraction")]
    public V1beta1HTTPRouteSpecRulesFiltersRequestMirrorFraction? Fraction { get; set; }

    /// <summary>
    /// Percent represents the percentage of requests that should be
    /// mirrored to BackendRef. Its minimum value is 0 (indicating 0% of
    /// requests) and its maximum value is 100 (indicating 100% of requests).
    /// 
    /// Only one of Fraction or Percent may be specified. If neither field
    /// is specified, 100% of requests will be mirrored.
    /// </summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }
}

/// <summary>
/// Type defines the type of path modifier. Additional types may be
/// added in a future release of the API.
/// 
/// Note that values may be added to this enum, implementations
/// must ensure that unknown values will not cause a crash.
/// 
/// Unknown values here must result in the implementation setting the
/// Accepted Condition for the Route to `status: False`, with a
/// Reason of `UnsupportedValue`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesFiltersRequestRedirectPathTypeEnum>))]
public enum V1beta1HTTPRouteSpecRulesFiltersRequestRedirectPathTypeEnum
{
    [EnumMember(Value = "ReplaceFullPath"), JsonStringEnumMemberName("ReplaceFullPath")]
    ReplaceFullPath,
    [EnumMember(Value = "ReplacePrefixMatch"), JsonStringEnumMemberName("ReplacePrefixMatch")]
    ReplacePrefixMatch
}

/// <summary>
/// Path defines parameters used to modify the path of the incoming request.
/// The modified path is then used to construct the `Location` header. When
/// empty, the request path is used as-is.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersRequestRedirectPath
{
    /// <summary>
    /// ReplaceFullPath specifies the value with which to replace the full path
    /// of a request during a rewrite or redirect.
    /// </summary>
    [JsonPropertyName("replaceFullPath")]
    public string? ReplaceFullPath { get; set; }

    /// <summary>
    /// ReplacePrefixMatch specifies the value with which to replace the prefix
    /// match of a request during a rewrite or redirect. For example, a request
    /// to &quot;/foo/bar&quot; with a prefix match of &quot;/foo&quot; and a ReplacePrefixMatch
    /// of &quot;/xyz&quot; would be modified to &quot;/xyz/bar&quot;.
    /// 
    /// Note that this matches the behavior of the PathPrefix match type. This
    /// matches full path elements. A path element refers to the list of labels
    /// in the path split by the `/` separator. When specified, a trailing `/` is
    /// ignored. For example, the paths `/abc`, `/abc/`, and `/abc/def` would all
    /// match the prefix `/abc`, but the path `/abcd` would not.
    /// 
    /// ReplacePrefixMatch is only compatible with a `PathPrefix` HTTPRouteMatch.
    /// Using any other HTTPRouteMatch type on the same HTTPRouteRule will result in
    /// the implementation setting the Accepted Condition for the Route to `status: False`.
    /// 
    /// Request Path | Prefix Match | Replace Prefix | Modified Path
    /// </summary>
    [JsonPropertyName("replacePrefixMatch")]
    public string? ReplacePrefixMatch { get; set; }

    /// <summary>
    /// Type defines the type of path modifier. Additional types may be
    /// added in a future release of the API.
    /// 
    /// Note that values may be added to this enum, implementations
    /// must ensure that unknown values will not cause a crash.
    /// 
    /// Unknown values here must result in the implementation setting the
    /// Accepted Condition for the Route to `status: False`, with a
    /// Reason of `UnsupportedValue`.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1beta1HTTPRouteSpecRulesFiltersRequestRedirectPathTypeEnum Type { get; set; }
}

/// <summary>
/// Scheme is the scheme to be used in the value of the `Location` header in
/// the response. When empty, the scheme of the request is used.
/// 
/// Scheme redirects can affect the port of the redirect, for more information,
/// refer to the documentation for the port field of this filter.
/// 
/// Note that values may be added to this enum, implementations
/// must ensure that unknown values will not cause a crash.
/// 
/// Unknown values here must result in the implementation setting the
/// Accepted Condition for the Route to `status: False`, with a
/// Reason of `UnsupportedValue`.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesFiltersRequestRedirectSchemeEnum>))]
public enum V1beta1HTTPRouteSpecRulesFiltersRequestRedirectSchemeEnum
{
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "https"), JsonStringEnumMemberName("https")]
    Https
}

/// <summary>
/// RequestRedirect defines a schema for a filter that responds to the
/// request with an HTTP redirection.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersRequestRedirect
{
    /// <summary>
    /// Hostname is the hostname to be used in the value of the `Location`
    /// header in the response.
    /// When empty, the hostname in the `Host` header of the request is used.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Path defines parameters used to modify the path of the incoming request.
    /// The modified path is then used to construct the `Location` header. When
    /// empty, the request path is used as-is.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("path")]
    public V1beta1HTTPRouteSpecRulesFiltersRequestRedirectPath? Path { get; set; }

    /// <summary>
    /// Port is the port to be used in the value of the `Location`
    /// header in the response.
    /// 
    /// If no port is specified, the redirect port MUST be derived using the
    /// following rules:
    /// 
    /// * If redirect scheme is not-empty, the redirect port MUST be the well-known
    ///   port associated with the redirect scheme. Specifically &quot;http&quot; to port 80
    ///   and &quot;https&quot; to port 443. If the redirect scheme does not have a
    ///   well-known port, the listener port of the Gateway SHOULD be used.
    /// * If redirect scheme is empty, the redirect port MUST be the Gateway
    ///   Listener port.
    /// 
    /// Implementations SHOULD NOT add the port number in the &apos;Location&apos;
    /// header in the following cases:
    /// 
    /// * A Location header that will use HTTP (whether that is determined via
    ///   the Listener protocol or the Scheme field) _and_ use port 80.
    /// * A Location header that will use HTTPS (whether that is determined via
    ///   the Listener protocol or the Scheme field) _and_ use port 443.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>
    /// Scheme is the scheme to be used in the value of the `Location` header in
    /// the response. When empty, the scheme of the request is used.
    /// 
    /// Scheme redirects can affect the port of the redirect, for more information,
    /// refer to the documentation for the port field of this filter.
    /// 
    /// Note that values may be added to this enum, implementations
    /// must ensure that unknown values will not cause a crash.
    /// 
    /// Unknown values here must result in the implementation setting the
    /// Accepted Condition for the Route to `status: False`, with a
    /// Reason of `UnsupportedValue`.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("scheme")]
    public V1beta1HTTPRouteSpecRulesFiltersRequestRedirectSchemeEnum? Scheme { get; set; }

    /// <summary>
    /// StatusCode is the HTTP status code to be used in response.
    /// 
    /// Note that values may be added to this enum, implementations
    /// must ensure that unknown values will not cause a crash.
    /// 
    /// Unknown values here must result in the implementation setting the
    /// Accepted Condition for the Route to `status: False`, with a
    /// Reason of `UnsupportedValue`.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
}

/// <summary>HTTPHeader represents an HTTP Header name and value as defined by RFC 7230.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersResponseHeaderModifierAdd
{
    /// <summary>
    /// Name is the name of the HTTP Header to be matched. Name matching MUST be
    /// case-insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).
    /// 
    /// If multiple entries specify equivalent header names, the first entry with
    /// an equivalent name MUST be considered for a match. Subsequent entries
    /// with an equivalent header name MUST be ignored. Due to the
    /// case-insensitivity of header names, &quot;foo&quot; and &quot;Foo&quot; are considered
    /// equivalent.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>HTTPHeader represents an HTTP Header name and value as defined by RFC 7230.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersResponseHeaderModifierSet
{
    /// <summary>
    /// Name is the name of the HTTP Header to be matched. Name matching MUST be
    /// case-insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).
    /// 
    /// If multiple entries specify equivalent header names, the first entry with
    /// an equivalent name MUST be considered for a match. Subsequent entries
    /// with an equivalent header name MUST be ignored. Due to the
    /// case-insensitivity of header names, &quot;foo&quot; and &quot;Foo&quot; are considered
    /// equivalent.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// ResponseHeaderModifier defines a schema for a filter that modifies response
/// headers.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersResponseHeaderModifier
{
    /// <summary>
    /// Add adds the given header(s) (name, value) to the request
    /// before the action. It appends to any existing values associated
    /// with the header name.
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo
    /// 
    /// Config:
    ///   add:
    ///   - name: &quot;my-header&quot;
    ///     value: &quot;bar,baz&quot;
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo,bar,baz
    /// </summary>
    [JsonPropertyName("add")]
    public IList<V1beta1HTTPRouteSpecRulesFiltersResponseHeaderModifierAdd>? Add { get; set; }

    /// <summary>
    /// Remove the given header(s) from the HTTP request before the action. The
    /// value of Remove is a list of HTTP header names. Note that the header
    /// names are case-insensitive (see
    /// https://datatracker.ietf.org/doc/html/rfc2616#section-4.2).
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header1: foo
    ///   my-header2: bar
    ///   my-header3: baz
    /// 
    /// Config:
    ///   remove: [&quot;my-header1&quot;, &quot;my-header3&quot;]
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header2: bar
    /// </summary>
    [JsonPropertyName("remove")]
    public IList<string>? Remove { get; set; }

    /// <summary>
    /// Set overwrites the request with the given header (name, value)
    /// before the action.
    /// 
    /// Input:
    ///   GET /foo HTTP/1.1
    ///   my-header: foo
    /// 
    /// Config:
    ///   set:
    ///   - name: &quot;my-header&quot;
    ///     value: &quot;bar&quot;
    /// 
    /// Output:
    ///   GET /foo HTTP/1.1
    ///   my-header: bar
    /// </summary>
    [JsonPropertyName("set")]
    public IList<V1beta1HTTPRouteSpecRulesFiltersResponseHeaderModifierSet>? Set { get; set; }
}

/// <summary>
/// Type identifies the type of filter to apply. As with other API fields,
/// types are classified into three conformance levels:
/// 
/// - Core: Filter types and their corresponding configuration defined by
///   &quot;Support: Core&quot; in this package, e.g. &quot;RequestHeaderModifier&quot;. All
///   implementations must support core filters.
/// 
/// - Extended: Filter types and their corresponding configuration defined by
///   &quot;Support: Extended&quot; in this package, e.g. &quot;RequestMirror&quot;. Implementers
///   are encouraged to support extended filters.
/// 
/// - Implementation-specific: Filters that are defined and supported by
///   specific vendors.
///   In the future, filters showing convergence in behavior across multiple
///   implementations will be considered for inclusion in extended or core
///   conformance levels. Filter-specific configuration for such filters
///   is specified using the ExtensionRef field. `Type` should be set to
///   &quot;ExtensionRef&quot; for custom filters.
/// 
/// Implementers are encouraged to define custom implementation types to
/// extend the core API with implementation-specific behavior.
/// 
/// If a reference to a custom filter type cannot be resolved, the filter
/// MUST NOT be skipped. Instead, requests that would have been processed by
/// that filter MUST receive a HTTP error response.
/// 
/// Note that values may be added to this enum, implementations
/// must ensure that unknown values will not cause a crash.
/// 
/// Unknown values here must result in the implementation setting the
/// Accepted Condition for the Route to `status: False`, with a
/// Reason of `UnsupportedValue`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesFiltersTypeEnum>))]
public enum V1beta1HTTPRouteSpecRulesFiltersTypeEnum
{
    [EnumMember(Value = "RequestHeaderModifier"), JsonStringEnumMemberName("RequestHeaderModifier")]
    RequestHeaderModifier,
    [EnumMember(Value = "ResponseHeaderModifier"), JsonStringEnumMemberName("ResponseHeaderModifier")]
    ResponseHeaderModifier,
    [EnumMember(Value = "RequestMirror"), JsonStringEnumMemberName("RequestMirror")]
    RequestMirror,
    [EnumMember(Value = "RequestRedirect"), JsonStringEnumMemberName("RequestRedirect")]
    RequestRedirect,
    [EnumMember(Value = "URLRewrite"), JsonStringEnumMemberName("URLRewrite")]
    URLRewrite,
    [EnumMember(Value = "ExtensionRef"), JsonStringEnumMemberName("ExtensionRef")]
    ExtensionRef,
    [EnumMember(Value = "CORS"), JsonStringEnumMemberName("CORS")]
    CORS
}

/// <summary>
/// Type defines the type of path modifier. Additional types may be
/// added in a future release of the API.
/// 
/// Note that values may be added to this enum, implementations
/// must ensure that unknown values will not cause a crash.
/// 
/// Unknown values here must result in the implementation setting the
/// Accepted Condition for the Route to `status: False`, with a
/// Reason of `UnsupportedValue`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesFiltersUrlRewritePathTypeEnum>))]
public enum V1beta1HTTPRouteSpecRulesFiltersUrlRewritePathTypeEnum
{
    [EnumMember(Value = "ReplaceFullPath"), JsonStringEnumMemberName("ReplaceFullPath")]
    ReplaceFullPath,
    [EnumMember(Value = "ReplacePrefixMatch"), JsonStringEnumMemberName("ReplacePrefixMatch")]
    ReplacePrefixMatch
}

/// <summary>
/// Path defines a path rewrite.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersUrlRewritePath
{
    /// <summary>
    /// ReplaceFullPath specifies the value with which to replace the full path
    /// of a request during a rewrite or redirect.
    /// </summary>
    [JsonPropertyName("replaceFullPath")]
    public string? ReplaceFullPath { get; set; }

    /// <summary>
    /// ReplacePrefixMatch specifies the value with which to replace the prefix
    /// match of a request during a rewrite or redirect. For example, a request
    /// to &quot;/foo/bar&quot; with a prefix match of &quot;/foo&quot; and a ReplacePrefixMatch
    /// of &quot;/xyz&quot; would be modified to &quot;/xyz/bar&quot;.
    /// 
    /// Note that this matches the behavior of the PathPrefix match type. This
    /// matches full path elements. A path element refers to the list of labels
    /// in the path split by the `/` separator. When specified, a trailing `/` is
    /// ignored. For example, the paths `/abc`, `/abc/`, and `/abc/def` would all
    /// match the prefix `/abc`, but the path `/abcd` would not.
    /// 
    /// ReplacePrefixMatch is only compatible with a `PathPrefix` HTTPRouteMatch.
    /// Using any other HTTPRouteMatch type on the same HTTPRouteRule will result in
    /// the implementation setting the Accepted Condition for the Route to `status: False`.
    /// 
    /// Request Path | Prefix Match | Replace Prefix | Modified Path
    /// </summary>
    [JsonPropertyName("replacePrefixMatch")]
    public string? ReplacePrefixMatch { get; set; }

    /// <summary>
    /// Type defines the type of path modifier. Additional types may be
    /// added in a future release of the API.
    /// 
    /// Note that values may be added to this enum, implementations
    /// must ensure that unknown values will not cause a crash.
    /// 
    /// Unknown values here must result in the implementation setting the
    /// Accepted Condition for the Route to `status: False`, with a
    /// Reason of `UnsupportedValue`.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1beta1HTTPRouteSpecRulesFiltersUrlRewritePathTypeEnum Type { get; set; }
}

/// <summary>
/// URLRewrite defines a schema for a filter that modifies a request during forwarding.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFiltersUrlRewrite
{
    /// <summary>
    /// Hostname is the value to be used to replace the Host header value during
    /// forwarding.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Path defines a path rewrite.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("path")]
    public V1beta1HTTPRouteSpecRulesFiltersUrlRewritePath? Path { get; set; }
}

/// <summary>
/// HTTPRouteFilter defines processing steps that must be completed during the
/// request or response lifecycle. HTTPRouteFilters are meant as an extension
/// point to express processing that may be done in Gateway implementations. Some
/// examples include request or response modification, implementing
/// authentication strategies, rate-limiting, and traffic shaping. API
/// guarantee/conformance is defined based on the type of the filter.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesFilters
{
    /// <summary>
    /// CORS defines a schema for a filter that responds to the
    /// cross-origin request based on HTTP response header.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("cors")]
    public V1beta1HTTPRouteSpecRulesFiltersCors? Cors { get; set; }

    /// <summary>
    /// ExtensionRef is an optional, implementation-specific extension to the
    /// &quot;filter&quot; behavior.  For example, resource &quot;myroutefilter&quot; in group
    /// &quot;networking.example.net&quot;). ExtensionRef MUST NOT be used for core and
    /// extended filters.
    /// 
    /// This filter can be used multiple times within the same rule.
    /// 
    /// Support: Implementation-specific
    /// </summary>
    [JsonPropertyName("extensionRef")]
    public V1beta1HTTPRouteSpecRulesFiltersExtensionRef? ExtensionRef { get; set; }

    /// <summary>
    /// RequestHeaderModifier defines a schema for a filter that modifies request
    /// headers.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("requestHeaderModifier")]
    public V1beta1HTTPRouteSpecRulesFiltersRequestHeaderModifier? RequestHeaderModifier { get; set; }

    /// <summary>
    /// RequestMirror defines a schema for a filter that mirrors requests.
    /// Requests are sent to the specified destination, but responses from
    /// that destination are ignored.
    /// 
    /// This filter can be used multiple times within the same rule. Note that
    /// not all implementations will be able to support mirroring to multiple
    /// backends.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("requestMirror")]
    public V1beta1HTTPRouteSpecRulesFiltersRequestMirror? RequestMirror { get; set; }

    /// <summary>
    /// RequestRedirect defines a schema for a filter that responds to the
    /// request with an HTTP redirection.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("requestRedirect")]
    public V1beta1HTTPRouteSpecRulesFiltersRequestRedirect? RequestRedirect { get; set; }

    /// <summary>
    /// ResponseHeaderModifier defines a schema for a filter that modifies response
    /// headers.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("responseHeaderModifier")]
    public V1beta1HTTPRouteSpecRulesFiltersResponseHeaderModifier? ResponseHeaderModifier { get; set; }

    /// <summary>
    /// Type identifies the type of filter to apply. As with other API fields,
    /// types are classified into three conformance levels:
    /// 
    /// - Core: Filter types and their corresponding configuration defined by
    ///   &quot;Support: Core&quot; in this package, e.g. &quot;RequestHeaderModifier&quot;. All
    ///   implementations must support core filters.
    /// 
    /// - Extended: Filter types and their corresponding configuration defined by
    ///   &quot;Support: Extended&quot; in this package, e.g. &quot;RequestMirror&quot;. Implementers
    ///   are encouraged to support extended filters.
    /// 
    /// - Implementation-specific: Filters that are defined and supported by
    ///   specific vendors.
    ///   In the future, filters showing convergence in behavior across multiple
    ///   implementations will be considered for inclusion in extended or core
    ///   conformance levels. Filter-specific configuration for such filters
    ///   is specified using the ExtensionRef field. `Type` should be set to
    ///   &quot;ExtensionRef&quot; for custom filters.
    /// 
    /// Implementers are encouraged to define custom implementation types to
    /// extend the core API with implementation-specific behavior.
    /// 
    /// If a reference to a custom filter type cannot be resolved, the filter
    /// MUST NOT be skipped. Instead, requests that would have been processed by
    /// that filter MUST receive a HTTP error response.
    /// 
    /// Note that values may be added to this enum, implementations
    /// must ensure that unknown values will not cause a crash.
    /// 
    /// Unknown values here must result in the implementation setting the
    /// Accepted Condition for the Route to `status: False`, with a
    /// Reason of `UnsupportedValue`.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1beta1HTTPRouteSpecRulesFiltersTypeEnum Type { get; set; }

    /// <summary>
    /// URLRewrite defines a schema for a filter that modifies a request during forwarding.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("urlRewrite")]
    public V1beta1HTTPRouteSpecRulesFiltersUrlRewrite? UrlRewrite { get; set; }
}

/// <summary>
/// Type specifies how to match against the value of the header.
/// 
/// Support: Core (Exact)
/// 
/// Support: Implementation-specific (RegularExpression)
/// 
/// Since RegularExpression HeaderMatchType has implementation-specific
/// conformance, implementations can support POSIX, PCRE or any other dialects
/// of regular expressions. Please read the implementation&apos;s documentation to
/// determine the supported dialect.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesMatchesHeadersTypeEnum>))]
public enum V1beta1HTTPRouteSpecRulesMatchesHeadersTypeEnum
{
    [EnumMember(Value = "Exact"), JsonStringEnumMemberName("Exact")]
    Exact,
    [EnumMember(Value = "RegularExpression"), JsonStringEnumMemberName("RegularExpression")]
    RegularExpression
}

/// <summary>
/// HTTPHeaderMatch describes how to select a HTTP route by matching HTTP request
/// headers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesMatchesHeaders
{
    /// <summary>
    /// Name is the name of the HTTP Header to be matched. Name matching MUST be
    /// case-insensitive. (See https://tools.ietf.org/html/rfc7230#section-3.2).
    /// 
    /// If multiple entries specify equivalent header names, only the first
    /// entry with an equivalent name MUST be considered for a match. Subsequent
    /// entries with an equivalent header name MUST be ignored. Due to the
    /// case-insensitivity of header names, &quot;foo&quot; and &quot;Foo&quot; are considered
    /// equivalent.
    /// 
    /// When a header is repeated in an HTTP request, it is
    /// implementation-specific behavior as to how this is represented.
    /// Generally, proxies should follow the guidance from the RFC:
    /// https://www.rfc-editor.org/rfc/rfc7230.html#section-3.2.2 regarding
    /// processing a repeated header, with special handling for &quot;Set-Cookie&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Type specifies how to match against the value of the header.
    /// 
    /// Support: Core (Exact)
    /// 
    /// Support: Implementation-specific (RegularExpression)
    /// 
    /// Since RegularExpression HeaderMatchType has implementation-specific
    /// conformance, implementations can support POSIX, PCRE or any other dialects
    /// of regular expressions. Please read the implementation&apos;s documentation to
    /// determine the supported dialect.
    /// </summary>
    [JsonPropertyName("type")]
    public V1beta1HTTPRouteSpecRulesMatchesHeadersTypeEnum? Type { get; set; }

    /// <summary>Value is the value of HTTP Header to be matched.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Method specifies HTTP method matcher.
/// When specified, this route will be matched only if the request has the
/// specified method.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesMatchesMethodEnum>))]
public enum V1beta1HTTPRouteSpecRulesMatchesMethodEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "HEAD"), JsonStringEnumMemberName("HEAD")]
    HEAD,
    [EnumMember(Value = "POST"), JsonStringEnumMemberName("POST")]
    POST,
    [EnumMember(Value = "PUT"), JsonStringEnumMemberName("PUT")]
    PUT,
    [EnumMember(Value = "DELETE"), JsonStringEnumMemberName("DELETE")]
    DELETE,
    [EnumMember(Value = "CONNECT"), JsonStringEnumMemberName("CONNECT")]
    CONNECT,
    [EnumMember(Value = "OPTIONS"), JsonStringEnumMemberName("OPTIONS")]
    OPTIONS,
    [EnumMember(Value = "TRACE"), JsonStringEnumMemberName("TRACE")]
    TRACE,
    [EnumMember(Value = "PATCH"), JsonStringEnumMemberName("PATCH")]
    PATCH
}

/// <summary>
/// Type specifies how to match against the path Value.
/// 
/// Support: Core (Exact, PathPrefix)
/// 
/// Support: Implementation-specific (RegularExpression)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesMatchesPathTypeEnum>))]
public enum V1beta1HTTPRouteSpecRulesMatchesPathTypeEnum
{
    [EnumMember(Value = "Exact"), JsonStringEnumMemberName("Exact")]
    Exact,
    [EnumMember(Value = "PathPrefix"), JsonStringEnumMemberName("PathPrefix")]
    PathPrefix,
    [EnumMember(Value = "RegularExpression"), JsonStringEnumMemberName("RegularExpression")]
    RegularExpression
}

/// <summary>
/// Path specifies a HTTP request path matcher. If this field is not
/// specified, a default prefix match on the &quot;/&quot; path is provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesMatchesPath
{
    /// <summary>
    /// Type specifies how to match against the path Value.
    /// 
    /// Support: Core (Exact, PathPrefix)
    /// 
    /// Support: Implementation-specific (RegularExpression)
    /// </summary>
    [JsonPropertyName("type")]
    public V1beta1HTTPRouteSpecRulesMatchesPathTypeEnum? Type { get; set; }

    /// <summary>Value of the HTTP path to match against.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Type specifies how to match against the value of the query parameter.
/// 
/// Support: Extended (Exact)
/// 
/// Support: Implementation-specific (RegularExpression)
/// 
/// Since RegularExpression QueryParamMatchType has Implementation-specific
/// conformance, implementations can support POSIX, PCRE or any other
/// dialects of regular expressions. Please read the implementation&apos;s
/// documentation to determine the supported dialect.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteSpecRulesMatchesQueryParamsTypeEnum>))]
public enum V1beta1HTTPRouteSpecRulesMatchesQueryParamsTypeEnum
{
    [EnumMember(Value = "Exact"), JsonStringEnumMemberName("Exact")]
    Exact,
    [EnumMember(Value = "RegularExpression"), JsonStringEnumMemberName("RegularExpression")]
    RegularExpression
}

/// <summary>
/// HTTPQueryParamMatch describes how to select a HTTP route by matching HTTP
/// query parameters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesMatchesQueryParams
{
    /// <summary>
    /// Name is the name of the HTTP query param to be matched. This must be an
    /// exact string match. (See
    /// https://tools.ietf.org/html/rfc7230#section-2.7.3).
    /// 
    /// If multiple entries specify equivalent query param names, only the first
    /// entry with an equivalent name MUST be considered for a match. Subsequent
    /// entries with an equivalent query param name MUST be ignored.
    /// 
    /// If a query param is repeated in an HTTP request, the behavior is
    /// purposely left undefined, since different data planes have different
    /// capabilities. However, it is *recommended* that implementations should
    /// match against the first value of the param if the data plane supports it,
    /// as this behavior is expected in other load balancing contexts outside of
    /// the Gateway API.
    /// 
    /// Users SHOULD NOT route traffic based on repeated query params to guard
    /// themselves against potential differences in the implementations.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Type specifies how to match against the value of the query parameter.
    /// 
    /// Support: Extended (Exact)
    /// 
    /// Support: Implementation-specific (RegularExpression)
    /// 
    /// Since RegularExpression QueryParamMatchType has Implementation-specific
    /// conformance, implementations can support POSIX, PCRE or any other
    /// dialects of regular expressions. Please read the implementation&apos;s
    /// documentation to determine the supported dialect.
    /// </summary>
    [JsonPropertyName("type")]
    public V1beta1HTTPRouteSpecRulesMatchesQueryParamsTypeEnum? Type { get; set; }

    /// <summary>Value is the value of HTTP query param to be matched.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// HTTPRouteMatch defines the predicate used to match requests to a given
/// action. Multiple match types are ANDed together, i.e. the match will
/// evaluate to true only if all conditions are satisfied.
/// 
/// For example, the match below will match a HTTP request only if its path
/// starts with `/foo` AND it contains the `version: v1` header:
/// 
/// ```
/// match:
/// 
/// 	path:
/// 	  value: &quot;/foo&quot;
/// 	headers:
/// 	- name: &quot;version&quot;
/// 	  value &quot;v1&quot;
/// 
/// ```
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesMatches
{
    /// <summary>
    /// Headers specifies HTTP request header matchers. Multiple match values are
    /// ANDed together, meaning, a request must match all the specified headers
    /// to select the route.
    /// </summary>
    [JsonPropertyName("headers")]
    public IList<V1beta1HTTPRouteSpecRulesMatchesHeaders>? Headers { get; set; }

    /// <summary>
    /// Method specifies HTTP method matcher.
    /// When specified, this route will be matched only if the request has the
    /// specified method.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("method")]
    public V1beta1HTTPRouteSpecRulesMatchesMethodEnum? Method { get; set; }

    /// <summary>
    /// Path specifies a HTTP request path matcher. If this field is not
    /// specified, a default prefix match on the &quot;/&quot; path is provided.
    /// </summary>
    [JsonPropertyName("path")]
    public V1beta1HTTPRouteSpecRulesMatchesPath? Path { get; set; }

    /// <summary>
    /// QueryParams specifies HTTP query parameter matchers. Multiple match
    /// values are ANDed together, meaning, a request must match all the
    /// specified query parameters to select the route.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("queryParams")]
    public IList<V1beta1HTTPRouteSpecRulesMatchesQueryParams>? QueryParams { get; set; }
}

/// <summary>
/// Timeouts defines the timeouts that can be configured for an HTTP request.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRulesTimeouts
{
    /// <summary>
    /// BackendRequest specifies a timeout for an individual request from the gateway
    /// to a backend. This covers the time from when the request first starts being
    /// sent from the gateway to when the full response has been received from the backend.
    /// 
    /// Setting a timeout to the zero duration (e.g. &quot;0s&quot;) SHOULD disable the timeout
    /// completely. Implementations that cannot completely disable the timeout MUST
    /// instead interpret the zero duration as the longest possible value to which
    /// the timeout can be set.
    /// 
    /// An entire client HTTP transaction with a gateway, covered by the Request timeout,
    /// may result in more than one call from the gateway to the destination backend,
    /// for example, if automatic retries are supported.
    /// 
    /// The value of BackendRequest must be a Gateway API Duration string as defined by
    /// GEP-2257.  When this field is unspecified, its behavior is implementation-specific;
    /// when specified, the value of BackendRequest must be no more than the value of the
    /// Request timeout (since the Request timeout encompasses the BackendRequest timeout).
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("backendRequest")]
    public string? BackendRequest { get; set; }

    /// <summary>
    /// Request specifies the maximum duration for a gateway to respond to an HTTP request.
    /// If the gateway has not been able to respond before this deadline is met, the gateway
    /// MUST return a timeout error.
    /// 
    /// For example, setting the `rules.timeouts.request` field to the value `10s` in an
    /// `HTTPRoute` will cause a timeout if a client request is taking longer than 10 seconds
    /// to complete.
    /// 
    /// Setting a timeout to the zero duration (e.g. &quot;0s&quot;) SHOULD disable the timeout
    /// completely. Implementations that cannot completely disable the timeout MUST
    /// instead interpret the zero duration as the longest possible value to which
    /// the timeout can be set.
    /// 
    /// This timeout is intended to cover as close to the whole request-response transaction
    /// as possible although an implementation MAY choose to start the timeout after the entire
    /// request stream has been received instead of immediately after the transaction is
    /// initiated by the client.
    /// 
    /// The value of Request is a Gateway API Duration string as defined by GEP-2257. When this
    /// field is unspecified, request timeout behavior is implementation-specific.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>
/// HTTPRouteRule defines semantics for matching an HTTP request based on
/// conditions (matches), processing it (filters), and forwarding the request to
/// an API object (backendRefs).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpecRules
{
    /// <summary>
    /// BackendRefs defines the backend(s) where matching requests should be
    /// sent.
    /// 
    /// Failure behavior here depends on how many BackendRefs are specified and
    /// how many are invalid.
    /// 
    /// If *all* entries in BackendRefs are invalid, and there are also no filters
    /// specified in this route rule, *all* traffic which matches this rule MUST
    /// receive a 500 status code.
    /// 
    /// See the HTTPBackendRef definition for the rules about what makes a single
    /// HTTPBackendRef invalid.
    /// 
    /// When a HTTPBackendRef is invalid, 500 status codes MUST be returned for
    /// requests that would have otherwise been routed to an invalid backend. If
    /// multiple backends are specified, and some are invalid, the proportion of
    /// requests that would otherwise have been routed to an invalid backend
    /// MUST receive a 500 status code.
    /// 
    /// For example, if two backends are specified with equal weights, and one is
    /// invalid, 50 percent of traffic must receive a 500. Implementations may
    /// choose how that 50 percent is determined.
    /// 
    /// When a HTTPBackendRef refers to a Service that has no ready endpoints,
    /// implementations SHOULD return a 503 for requests to that backend instead.
    /// If an implementation chooses to do this, all of the above rules for 500 responses
    /// MUST also apply for responses that return a 503.
    /// 
    /// Support: Core for Kubernetes Service
    /// 
    /// Support: Extended for Kubernetes ServiceImport
    /// 
    /// Support: Implementation-specific for any other resource
    /// 
    /// Support for weight: Core
    /// </summary>
    [JsonPropertyName("backendRefs")]
    public IList<V1beta1HTTPRouteSpecRulesBackendRefs>? BackendRefs { get; set; }

    /// <summary>
    /// Filters define the filters that are applied to requests that match
    /// this rule.
    /// 
    /// Wherever possible, implementations SHOULD implement filters in the order
    /// they are specified.
    /// 
    /// Implementations MAY choose to implement this ordering strictly, rejecting
    /// any combination or order of filters that cannot be supported. If implementations
    /// choose a strict interpretation of filter ordering, they MUST clearly document
    /// that behavior.
    /// 
    /// To reject an invalid combination or order of filters, implementations SHOULD
    /// consider the Route Rules with this configuration invalid. If all Route Rules
    /// in a Route are invalid, the entire Route would be considered invalid. If only
    /// a portion of Route Rules are invalid, implementations MUST set the
    /// &quot;PartiallyInvalid&quot; condition for the Route.
    /// 
    /// Conformance-levels at this level are defined based on the type of filter:
    /// 
    /// - ALL core filters MUST be supported by all implementations.
    /// - Implementers are encouraged to support extended filters.
    /// - Implementation-specific custom filters have no API guarantees across
    ///   implementations.
    /// 
    /// Specifying the same filter multiple times is not supported unless explicitly
    /// indicated in the filter.
    /// 
    /// All filters are expected to be compatible with each other except for the
    /// URLRewrite and RequestRedirect filters, which may not be combined. If an
    /// implementation cannot support other combinations of filters, they must clearly
    /// document that limitation. In cases where incompatible or unsupported
    /// filters are specified and cause the `Accepted` condition to be set to status
    /// `False`, implementations may use the `IncompatibleFilters` reason to specify
    /// this configuration error.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("filters")]
    public IList<V1beta1HTTPRouteSpecRulesFilters>? Filters { get; set; }

    /// <summary>
    /// Matches define conditions used for matching the rule against incoming
    /// HTTP requests. Each match is independent, i.e. this rule will be matched
    /// if **any** one of the matches is satisfied.
    /// 
    /// For example, take the following matches configuration:
    /// 
    /// ```
    /// matches:
    /// - path:
    ///     value: &quot;/foo&quot;
    ///   headers:
    ///   - name: &quot;version&quot;
    ///     value: &quot;v2&quot;
    /// - path:
    ///     value: &quot;/v2/foo&quot;
    /// ```
    /// 
    /// For a request to match against this rule, a request must satisfy
    /// EITHER of the two conditions:
    /// 
    /// - path prefixed with `/foo` AND contains the header `version: v2`
    /// - path prefix of `/v2/foo`
    /// 
    /// See the documentation for HTTPRouteMatch on how to specify multiple
    /// match conditions that should be ANDed together.
    /// 
    /// If no matches are specified, the default is a prefix
    /// path match on &quot;/&quot;, which has the effect of matching every
    /// HTTP request.
    /// 
    /// Proxy or Load Balancer routing configuration generated from HTTPRoutes
    /// MUST prioritize matches based on the following criteria, continuing on
    /// ties. Across all rules specified on applicable Routes, precedence must be
    /// given to the match having:
    /// 
    /// * &quot;Exact&quot; path match.
    /// * &quot;Prefix&quot; path match with largest number of characters.
    /// * Method match.
    /// * Largest number of header matches.
    /// * Largest number of query param matches.
    /// 
    /// Note: The precedence of RegularExpression path matches are implementation-specific.
    /// 
    /// If ties still exist across multiple Routes, matching precedence MUST be
    /// determined in order of the following criteria, continuing on ties:
    /// 
    /// * The oldest Route based on creation timestamp.
    /// * The Route appearing first in alphabetical order by
    ///   &quot;{namespace}/{name}&quot;.
    /// 
    /// If ties still exist within an HTTPRoute, matching precedence MUST be granted
    /// to the FIRST matching rule (in list order) with a match meeting the above
    /// criteria.
    /// 
    /// When no rules matching a request have been successfully attached to the
    /// parent a request is coming from, a HTTP 404 status code MUST be returned.
    /// </summary>
    [JsonPropertyName("matches")]
    public IList<V1beta1HTTPRouteSpecRulesMatches>? Matches { get; set; }

    /// <summary>
    /// Name is the name of the route rule. This name MUST be unique within a Route if it is set.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Timeouts defines the timeouts that can be configured for an HTTP request.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("timeouts")]
    public V1beta1HTTPRouteSpecRulesTimeouts? Timeouts { get; set; }
}

/// <summary>Spec defines the desired state of HTTPRoute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteSpec
{
    /// <summary>
    /// Hostnames defines a set of hostnames that should match against the HTTP Host
    /// header to select a HTTPRoute used to process the request. Implementations
    /// MUST ignore any port value specified in the HTTP Host header while
    /// performing a match and (absent of any applicable header modification
    /// configuration) MUST forward this header unmodified to the backend.
    /// 
    /// Valid values for Hostnames are determined by RFC 1123 definition of a
    /// hostname with 2 notable exceptions:
    /// 
    /// 1. IPs are not allowed.
    /// 2. A hostname may be prefixed with a wildcard label (`*.`). The wildcard
    ///    label must appear by itself as the first label.
    /// 
    /// If a hostname is specified by both the Listener and HTTPRoute, there
    /// must be at least one intersecting hostname for the HTTPRoute to be
    /// attached to the Listener. For example:
    /// 
    /// * A Listener with `test.example.com` as the hostname matches HTTPRoutes
    ///   that have either not specified any hostnames, or have specified at
    ///   least one of `test.example.com` or `*.example.com`.
    /// * A Listener with `*.example.com` as the hostname matches HTTPRoutes
    ///   that have either not specified any hostnames or have specified at least
    ///   one hostname that matches the Listener hostname. For example,
    ///   `*.example.com`, `test.example.com`, and `foo.test.example.com` would
    ///   all match. On the other hand, `example.com` and `test.example.net` would
    ///   not match.
    /// 
    /// Hostnames that are prefixed with a wildcard label (`*.`) are interpreted
    /// as a suffix match. That means that a match for `*.example.com` would match
    /// both `test.example.com`, and `foo.test.example.com`, but not `example.com`.
    /// 
    /// If both the Listener and HTTPRoute have specified hostnames, any
    /// HTTPRoute hostnames that do not match the Listener hostname MUST be
    /// ignored. For example, if a Listener specified `*.example.com`, and the
    /// HTTPRoute specified `test.example.com` and `test.example.net`,
    /// `test.example.net` must not be considered for a match.
    /// 
    /// If both the Listener and HTTPRoute have specified hostnames, and none
    /// match with the criteria above, then the HTTPRoute is not accepted. The
    /// implementation must raise an &apos;Accepted&apos; Condition with a status of
    /// `False` in the corresponding RouteParentStatus.
    /// 
    /// In the event that multiple HTTPRoutes specify intersecting hostnames (e.g.
    /// overlapping wildcard matching and exact matching hostnames), precedence must
    /// be given to rules from the HTTPRoute with the largest number of:
    /// 
    /// * Characters in a matching non-wildcard hostname.
    /// * Characters in a matching hostname.
    /// 
    /// If ties exist across multiple Routes, the matching precedence rules for
    /// HTTPRouteMatches takes over.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    /// <summary>
    /// ParentRefs references the resources (usually Gateways) that a Route wants
    /// to be attached to. Note that the referenced parent resource needs to
    /// allow this for the attachment to be complete. For Gateways, that means
    /// the Gateway needs to allow attachment from Routes of this kind and
    /// namespace. For Services, that means the Service must either be in the same
    /// namespace for a &quot;producer&quot; route, or the mesh implementation must support
    /// and allow &quot;consumer&quot; routes for the referenced Service. ReferenceGrant is
    /// not applicable for governing ParentRefs to Services - it is not possible to
    /// create a &quot;producer&quot; route for a Service in a different namespace from the
    /// Route.
    /// 
    /// There are two kinds of parent resources with &quot;Core&quot; support:
    /// 
    /// * Gateway (Gateway conformance profile)
    /// * Service (Mesh conformance profile, ClusterIP Services only)
    /// 
    /// This API may be extended in the future to support additional kinds of parent
    /// resources.
    /// 
    /// ParentRefs must be _distinct_. This means either that:
    /// 
    /// * They select different objects.  If this is the case, then parentRef
    ///   entries are distinct. In terms of fields, this means that the
    ///   multi-part key defined by `group`, `kind`, `namespace`, and `name` must
    ///   be unique across all parentRef entries in the Route.
    /// * They do not select different objects, but for each optional field used,
    ///   each ParentRef that selects the same object must set the same set of
    ///   optional fields to different values. If one ParentRef sets a
    ///   combination of optional fields, all must set the same combination.
    /// 
    /// Some examples:
    /// 
    /// * If one ParentRef sets `sectionName`, all ParentRefs referencing the
    ///   same object must also set `sectionName`.
    /// * If one ParentRef sets `port`, all ParentRefs referencing the same
    ///   object must also set `port`.
    /// * If one ParentRef sets `sectionName` and `port`, all ParentRefs
    ///   referencing the same object must also set `sectionName` and `port`.
    /// 
    /// It is possible to separately reference multiple distinct objects that may
    /// be collapsed by an implementation. For example, some implementations may
    /// choose to merge compatible Gateway Listeners together. If that is the
    /// case, the list of routes attached to those resources should also be
    /// merged.
    /// 
    /// Note that for ParentRefs that cross namespace boundaries, there are specific
    /// rules. Cross-namespace references are only valid if they are explicitly
    /// allowed by something in the namespace they are referring to. For example,
    /// Gateway has the AllowedRoutes field, and ReferenceGrant provides a
    /// generic way to enable other kinds of cross-namespace reference.
    /// </summary>
    [JsonPropertyName("parentRefs")]
    public IList<V1beta1HTTPRouteSpecParentRefs>? ParentRefs { get; set; }

    /// <summary>Rules are a list of HTTP matchers, filters and actions.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1HTTPRouteSpecRules>? Rules { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1HTTPRouteStatusParentsConditionsStatusEnum>))]
public enum V1beta1HTTPRouteStatusParentsConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteStatusParentsConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1beta1HTTPRouteStatusParentsConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// ParentRef corresponds with a ParentRef in the spec that this
/// RouteParentStatus struct describes the status of.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteStatusParentsParentRef
{
    /// <summary>
    /// Group is the group of the referent.
    /// When unspecified, &quot;gateway.networking.k8s.io&quot; is inferred.
    /// To set the core API group (such as for a &quot;Service&quot; kind referent),
    /// Group must be explicitly set to &quot; &quot; (empty string).
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>
    /// Kind is kind of the referent.
    /// 
    /// There are two kinds of parent resources with &quot;Core&quot; support:
    /// 
    /// * Gateway (Gateway conformance profile)
    /// * Service (Mesh conformance profile, ClusterIP Services only)
    /// 
    /// Support for other resources is Implementation-Specific.
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// Name is the name of the referent.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace is the namespace of the referent. When unspecified, this refers
    /// to the local namespace of the Route.
    /// 
    /// Note that there are specific rules for ParentRefs which cross namespace
    /// boundaries. Cross-namespace references are only valid if they are explicitly
    /// allowed by something in the namespace they are referring to. For example:
    /// Gateway has the AllowedRoutes field, and ReferenceGrant provides a
    /// generic way to enable any other kind of cross-namespace reference.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Port is the network port this Route targets. It can be interpreted
    /// differently based on the type of parent resource.
    /// 
    /// When the parent resource is a Gateway, this targets all listeners
    /// listening on the specified port that also support this kind of Route(and
    /// select this Route). It&apos;s not recommended to set `Port` unless the
    /// networking behaviors specified in a Route must apply to a specific port
    /// as opposed to a listener(s) whose port(s) may be changed. When both Port
    /// and SectionName are specified, the name and port of the selected listener
    /// must match both specified values.
    /// 
    /// Implementations MAY choose to support other parent resources.
    /// Implementations supporting other types of parent resources MUST clearly
    /// document how/if Port is interpreted.
    /// 
    /// For the purpose of status, an attachment is considered successful as
    /// long as the parent resource accepts it partially. For example, Gateway
    /// listeners can restrict which Routes can attach to them by Route kind,
    /// namespace, or hostname. If 1 of 2 Gateway listeners accept attachment
    /// from the referencing Route, the Route MUST be considered successfully
    /// attached. If no Gateway listeners accept attachment from this Route,
    /// the Route MUST be considered detached from the Gateway.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>
    /// SectionName is the name of a section within the target resource. In the
    /// following resources, SectionName is interpreted as the following:
    /// 
    /// * Gateway: Listener name. When both Port (experimental) and SectionName
    /// are specified, the name and port of the selected listener must match
    /// both specified values.
    /// * Service: Port name. When both Port (experimental) and SectionName
    /// are specified, the name and port of the selected listener must match
    /// both specified values.
    /// 
    /// Implementations MAY choose to support attaching Routes to other resources.
    /// If that is the case, they MUST clearly document how SectionName is
    /// interpreted.
    /// 
    /// When unspecified (empty string), this will reference the entire resource.
    /// For the purpose of status, an attachment is considered successful if at
    /// least one section in the parent resource accepts it. For example, Gateway
    /// listeners can restrict which Routes can attach to them by Route kind,
    /// namespace, or hostname. If 1 of 2 Gateway listeners accept attachment from
    /// the referencing Route, the Route MUST be considered successfully
    /// attached. If no Gateway listeners accept attachment from this Route, the
    /// Route MUST be considered detached from the Gateway.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("sectionName")]
    public string? SectionName { get; set; }
}

/// <summary>
/// RouteParentStatus describes the status of a route with respect to an
/// associated Parent.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteStatusParents
{
    /// <summary>
    /// Conditions describes the status of the route with respect to the Gateway.
    /// Note that the route&apos;s availability is also subject to the Gateway&apos;s own
    /// status conditions and listener status.
    /// 
    /// If the Route&apos;s ParentRef specifies an existing Gateway that supports
    /// Routes of this kind AND that Gateway&apos;s controller has sufficient access,
    /// then that Gateway&apos;s controller MUST set the &quot;Accepted&quot; condition on the
    /// Route, to indicate whether the route has been accepted or rejected by the
    /// Gateway, and why.
    /// 
    /// A Route MUST be considered &quot;Accepted&quot; if at least one of the Route&apos;s
    /// rules is implemented by the Gateway.
    /// 
    /// There are a number of cases where the &quot;Accepted&quot; condition may not be set
    /// due to lack of controller visibility, that includes when:
    /// 
    /// * The Route refers to a nonexistent parent.
    /// * The Route is of a type that the controller does not support.
    /// * The Route is in a namespace to which the controller does not have access.
    /// </summary>
    [JsonPropertyName("conditions")]
    public required IList<V1beta1HTTPRouteStatusParentsConditions> Conditions { get; set; }

    /// <summary>
    /// ControllerName is a domain/path string that indicates the name of the
    /// controller that wrote this status. This corresponds with the
    /// controllerName field on GatewayClass.
    /// 
    /// Example: &quot;example.net/gateway-controller&quot;.
    /// 
    /// The format of this field is DOMAIN &quot;/&quot; PATH, where DOMAIN and PATH are
    /// valid Kubernetes names
    /// (https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
    /// 
    /// Controllers MUST populate this field when writing status. Controllers should ensure that
    /// entries to status populated with their ControllerName are cleaned up when they are no
    /// longer necessary.
    /// </summary>
    [JsonPropertyName("controllerName")]
    public required string ControllerName { get; set; }

    /// <summary>
    /// ParentRef corresponds with a ParentRef in the spec that this
    /// RouteParentStatus struct describes the status of.
    /// </summary>
    [JsonPropertyName("parentRef")]
    public required V1beta1HTTPRouteStatusParentsParentRef ParentRef { get; set; }
}

/// <summary>Status defines the current state of HTTPRoute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1HTTPRouteStatus
{
    /// <summary>
    /// Parents is a list of parent resources (usually Gateways) that are
    /// associated with the route, and the status of the route with respect to
    /// each parent. When this route attaches to a parent, the controller that
    /// manages the parent must add an entry to this list when the controller
    /// first sees the route and should update the entry as appropriate when the
    /// route or gateway is modified.
    /// 
    /// Note that parent references that cannot be resolved by an implementation
    /// of this API will not be added to this list. Implementations of this API
    /// can only populate Route status for the Gateways/parent resources they are
    /// responsible for.
    /// 
    /// A maximum of 32 Gateways will be represented in this list. An empty list
    /// means the route has not been attached to any Gateway.
    /// </summary>
    [JsonPropertyName("parents")]
    public required IList<V1beta1HTTPRouteStatusParents> Parents { get; set; }
}

/// <summary>
/// HTTPRoute provides a way to route HTTP requests. This includes the capability
/// to match requests by hostname, path, header, or query param. Filters can be
/// used to specify additional processing steps. Backends specify where matching
/// requests should be routed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1HTTPRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1HTTPRouteSpec>, IStatus<V1beta1HTTPRouteStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "HTTPRoute";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "httproutes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HTTPRoute";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of HTTPRoute.</summary>
    [JsonPropertyName("spec")]
    public required V1beta1HTTPRouteSpec Spec { get; set; }

    /// <summary>Status defines the current state of HTTPRoute.</summary>
    [JsonPropertyName("status")]
    public V1beta1HTTPRouteStatus? Status { get; set; }
}