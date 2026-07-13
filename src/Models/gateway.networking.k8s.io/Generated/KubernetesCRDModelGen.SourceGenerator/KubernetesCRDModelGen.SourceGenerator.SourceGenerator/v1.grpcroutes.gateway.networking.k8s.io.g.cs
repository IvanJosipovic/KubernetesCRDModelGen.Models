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
/// GRPCRoute provides a way to route gRPC requests. This includes the capability
/// to match requests by hostname, gRPC service, gRPC method, or HTTP/2 header.
/// Filters can be used to specify additional processing steps. Backends specify
/// where matching requests will be routed.
/// 
/// GRPCRoute falls under extended support within the Gateway API. Within the
/// following specification, the word &quot;MUST&quot; indicates that an implementation
/// supporting GRPCRoute must conform to the indicated requirement, but an
/// implementation not supporting this route type need not follow the requirement
/// unless explicitly indicated.
/// 
/// Implementations supporting `GRPCRoute` with the `HTTPS` `ProtocolType` MUST
/// accept HTTP/2 connections without an initial upgrade from HTTP/1.1, i.e. via
/// ALPN. If the implementation does not support this, then it MUST set the
/// &quot;Accepted&quot; condition to &quot;False&quot; for the affected listener with a reason of
/// &quot;UnsupportedProtocol&quot;.  Implementations MAY also accept HTTP/2 connections
/// with an upgrade from HTTP/1.
/// 
/// Implementations supporting `GRPCRoute` with the `HTTP` `ProtocolType` MUST
/// support HTTP/2 over cleartext TCP (h2c,
/// https://www.rfc-editor.org/rfc/rfc7540#section-3.1) without an initial
/// upgrade from HTTP/1.1, i.e. with prior knowledge
/// (https://www.rfc-editor.org/rfc/rfc7540#section-3.4). If the implementation
/// does not support this, then it MUST set the &quot;Accepted&quot; condition to &quot;False&quot;
/// for the affected listener with a reason of &quot;UnsupportedProtocol&quot;.
/// Implementations MAY also accept HTTP/2 connections with an upgrade from
/// HTTP/1, i.e. without prior knowledge.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GRPCRouteList : IKubernetesObject<V1ListMeta>, IItems<V1GRPCRoute>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GRPCRouteList";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "grpcroutes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GRPCRouteList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1GRPCRoute objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1GRPCRoute> Items { get; set; }
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
public partial class V1GRPCRouteSpecParentRefs
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
/// ExtensionRef is an optional, implementation-specific extension to the
/// &quot;filter&quot; behavior.  For example, resource &quot;myroutefilter&quot; in group
/// &quot;networking.example.net&quot;). ExtensionRef MUST NOT be used for core and
/// extended filters.
/// 
/// Support: Implementation-specific
/// 
/// This filter can be used multiple times within the same rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpecRulesBackendRefsFiltersExtensionRef
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
public partial class V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifierAdd
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
public partial class V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifierSet
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
public partial class V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifier
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
    public IList<V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifierAdd>? Add { get; set; }

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
    public IList<V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifierSet>? Set { get; set; }
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
public partial class V1GRPCRouteSpecRulesBackendRefsFiltersRequestMirrorBackendRef
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
public partial class V1GRPCRouteSpecRulesBackendRefsFiltersRequestMirrorFraction
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
public partial class V1GRPCRouteSpecRulesBackendRefsFiltersRequestMirror
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
    public required V1GRPCRouteSpecRulesBackendRefsFiltersRequestMirrorBackendRef BackendRef { get; set; }

    /// <summary>
    /// Fraction represents the fraction of requests that should be
    /// mirrored to BackendRef.
    /// 
    /// Only one of Fraction or Percent may be specified. If neither field
    /// is specified, 100% of requests will be mirrored.
    /// </summary>
    [JsonPropertyName("fraction")]
    public V1GRPCRouteSpecRulesBackendRefsFiltersRequestMirrorFraction? Fraction { get; set; }

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

/// <summary>HTTPHeader represents an HTTP Header name and value as defined by RFC 7230.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifierAdd
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
public partial class V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifierSet
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
public partial class V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifier
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
    public IList<V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifierAdd>? Add { get; set; }

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
    public IList<V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifierSet>? Set { get; set; }
}

/// <summary>
/// Type identifies the type of filter to apply. As with other API fields,
/// types are classified into three conformance levels:
/// 
/// - Core: Filter types and their corresponding configuration defined by
///   &quot;Support: Core&quot; in this package, e.g. &quot;RequestHeaderModifier&quot;. All
///   implementations supporting GRPCRoute MUST support core filters.
/// 
/// - Extended: Filter types and their corresponding configuration defined by
///   &quot;Support: Extended&quot; in this package, e.g. &quot;RequestMirror&quot;. Implementers
///   are encouraged to support extended filters.
/// 
/// - Implementation-specific: Filters that are defined and supported by specific vendors.
///   In the future, filters showing convergence in behavior across multiple
///   implementations will be considered for inclusion in extended or core
///   conformance levels. Filter-specific configuration for such filters
///   is specified using the ExtensionRef field. `Type` MUST be set to
///   &quot;ExtensionRef&quot; for custom filters.
/// 
/// Implementers are encouraged to define custom implementation types to
/// extend the core API with implementation-specific behavior.
/// 
/// If a reference to a custom filter type cannot be resolved, the filter
/// MUST NOT be skipped. Instead, requests that would have been processed by
/// that filter MUST receive a HTTP error response.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GRPCRouteSpecRulesBackendRefsFiltersTypeEnum>))]
public enum V1GRPCRouteSpecRulesBackendRefsFiltersTypeEnum
{
    [EnumMember(Value = "ResponseHeaderModifier"), JsonStringEnumMemberName("ResponseHeaderModifier")]
    ResponseHeaderModifier,
    [EnumMember(Value = "RequestHeaderModifier"), JsonStringEnumMemberName("RequestHeaderModifier")]
    RequestHeaderModifier,
    [EnumMember(Value = "RequestMirror"), JsonStringEnumMemberName("RequestMirror")]
    RequestMirror,
    [EnumMember(Value = "ExtensionRef"), JsonStringEnumMemberName("ExtensionRef")]
    ExtensionRef
}

/// <summary>
/// GRPCRouteFilter defines processing steps that must be completed during the
/// request or response lifecycle. GRPCRouteFilters are meant as an extension
/// point to express processing that may be done in Gateway implementations. Some
/// examples include request or response modification, implementing
/// authentication strategies, rate-limiting, and traffic shaping. API
/// guarantee/conformance is defined based on the type of the filter.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpecRulesBackendRefsFilters
{
    /// <summary>
    /// ExtensionRef is an optional, implementation-specific extension to the
    /// &quot;filter&quot; behavior.  For example, resource &quot;myroutefilter&quot; in group
    /// &quot;networking.example.net&quot;). ExtensionRef MUST NOT be used for core and
    /// extended filters.
    /// 
    /// Support: Implementation-specific
    /// 
    /// This filter can be used multiple times within the same rule.
    /// </summary>
    [JsonPropertyName("extensionRef")]
    public V1GRPCRouteSpecRulesBackendRefsFiltersExtensionRef? ExtensionRef { get; set; }

    /// <summary>
    /// RequestHeaderModifier defines a schema for a filter that modifies request
    /// headers.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("requestHeaderModifier")]
    public V1GRPCRouteSpecRulesBackendRefsFiltersRequestHeaderModifier? RequestHeaderModifier { get; set; }

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
    public V1GRPCRouteSpecRulesBackendRefsFiltersRequestMirror? RequestMirror { get; set; }

    /// <summary>
    /// ResponseHeaderModifier defines a schema for a filter that modifies response
    /// headers.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("responseHeaderModifier")]
    public V1GRPCRouteSpecRulesBackendRefsFiltersResponseHeaderModifier? ResponseHeaderModifier { get; set; }

    /// <summary>
    /// Type identifies the type of filter to apply. As with other API fields,
    /// types are classified into three conformance levels:
    /// 
    /// - Core: Filter types and their corresponding configuration defined by
    ///   &quot;Support: Core&quot; in this package, e.g. &quot;RequestHeaderModifier&quot;. All
    ///   implementations supporting GRPCRoute MUST support core filters.
    /// 
    /// - Extended: Filter types and their corresponding configuration defined by
    ///   &quot;Support: Extended&quot; in this package, e.g. &quot;RequestMirror&quot;. Implementers
    ///   are encouraged to support extended filters.
    /// 
    /// - Implementation-specific: Filters that are defined and supported by specific vendors.
    ///   In the future, filters showing convergence in behavior across multiple
    ///   implementations will be considered for inclusion in extended or core
    ///   conformance levels. Filter-specific configuration for such filters
    ///   is specified using the ExtensionRef field. `Type` MUST be set to
    ///   &quot;ExtensionRef&quot; for custom filters.
    /// 
    /// Implementers are encouraged to define custom implementation types to
    /// extend the core API with implementation-specific behavior.
    /// 
    /// If a reference to a custom filter type cannot be resolved, the filter
    /// MUST NOT be skipped. Instead, requests that would have been processed by
    /// that filter MUST receive a HTTP error response.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1GRPCRouteSpecRulesBackendRefsFiltersTypeEnum Type { get; set; }
}

/// <summary>
/// GRPCBackendRef defines how a GRPCRoute forwards a gRPC request.
/// 
/// Note that when a namespace different than the local namespace is specified, a
/// ReferenceGrant object is required in the referent namespace to allow that
/// namespace&apos;s owner to accept the reference. See the ReferenceGrant
/// documentation for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpecRulesBackendRefs
{
    /// <summary>
    /// Filters defined at this level MUST be executed if and only if the
    /// request is being forwarded to the backend defined here.
    /// 
    /// Support: Implementation-specific (For broader support of filters, use the
    /// Filters field in GRPCRouteRule.)
    /// </summary>
    [JsonPropertyName("filters")]
    public IList<V1GRPCRouteSpecRulesBackendRefsFilters>? Filters { get; set; }

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

/// <summary>
/// ExtensionRef is an optional, implementation-specific extension to the
/// &quot;filter&quot; behavior.  For example, resource &quot;myroutefilter&quot; in group
/// &quot;networking.example.net&quot;). ExtensionRef MUST NOT be used for core and
/// extended filters.
/// 
/// Support: Implementation-specific
/// 
/// This filter can be used multiple times within the same rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpecRulesFiltersExtensionRef
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
public partial class V1GRPCRouteSpecRulesFiltersRequestHeaderModifierAdd
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
public partial class V1GRPCRouteSpecRulesFiltersRequestHeaderModifierSet
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
public partial class V1GRPCRouteSpecRulesFiltersRequestHeaderModifier
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
    public IList<V1GRPCRouteSpecRulesFiltersRequestHeaderModifierAdd>? Add { get; set; }

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
    public IList<V1GRPCRouteSpecRulesFiltersRequestHeaderModifierSet>? Set { get; set; }
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
public partial class V1GRPCRouteSpecRulesFiltersRequestMirrorBackendRef
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
public partial class V1GRPCRouteSpecRulesFiltersRequestMirrorFraction
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
public partial class V1GRPCRouteSpecRulesFiltersRequestMirror
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
    public required V1GRPCRouteSpecRulesFiltersRequestMirrorBackendRef BackendRef { get; set; }

    /// <summary>
    /// Fraction represents the fraction of requests that should be
    /// mirrored to BackendRef.
    /// 
    /// Only one of Fraction or Percent may be specified. If neither field
    /// is specified, 100% of requests will be mirrored.
    /// </summary>
    [JsonPropertyName("fraction")]
    public V1GRPCRouteSpecRulesFiltersRequestMirrorFraction? Fraction { get; set; }

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

/// <summary>HTTPHeader represents an HTTP Header name and value as defined by RFC 7230.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpecRulesFiltersResponseHeaderModifierAdd
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
public partial class V1GRPCRouteSpecRulesFiltersResponseHeaderModifierSet
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
public partial class V1GRPCRouteSpecRulesFiltersResponseHeaderModifier
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
    public IList<V1GRPCRouteSpecRulesFiltersResponseHeaderModifierAdd>? Add { get; set; }

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
    public IList<V1GRPCRouteSpecRulesFiltersResponseHeaderModifierSet>? Set { get; set; }
}

/// <summary>
/// Type identifies the type of filter to apply. As with other API fields,
/// types are classified into three conformance levels:
/// 
/// - Core: Filter types and their corresponding configuration defined by
///   &quot;Support: Core&quot; in this package, e.g. &quot;RequestHeaderModifier&quot;. All
///   implementations supporting GRPCRoute MUST support core filters.
/// 
/// - Extended: Filter types and their corresponding configuration defined by
///   &quot;Support: Extended&quot; in this package, e.g. &quot;RequestMirror&quot;. Implementers
///   are encouraged to support extended filters.
/// 
/// - Implementation-specific: Filters that are defined and supported by specific vendors.
///   In the future, filters showing convergence in behavior across multiple
///   implementations will be considered for inclusion in extended or core
///   conformance levels. Filter-specific configuration for such filters
///   is specified using the ExtensionRef field. `Type` MUST be set to
///   &quot;ExtensionRef&quot; for custom filters.
/// 
/// Implementers are encouraged to define custom implementation types to
/// extend the core API with implementation-specific behavior.
/// 
/// If a reference to a custom filter type cannot be resolved, the filter
/// MUST NOT be skipped. Instead, requests that would have been processed by
/// that filter MUST receive a HTTP error response.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GRPCRouteSpecRulesFiltersTypeEnum>))]
public enum V1GRPCRouteSpecRulesFiltersTypeEnum
{
    [EnumMember(Value = "ResponseHeaderModifier"), JsonStringEnumMemberName("ResponseHeaderModifier")]
    ResponseHeaderModifier,
    [EnumMember(Value = "RequestHeaderModifier"), JsonStringEnumMemberName("RequestHeaderModifier")]
    RequestHeaderModifier,
    [EnumMember(Value = "RequestMirror"), JsonStringEnumMemberName("RequestMirror")]
    RequestMirror,
    [EnumMember(Value = "ExtensionRef"), JsonStringEnumMemberName("ExtensionRef")]
    ExtensionRef
}

/// <summary>
/// GRPCRouteFilter defines processing steps that must be completed during the
/// request or response lifecycle. GRPCRouteFilters are meant as an extension
/// point to express processing that may be done in Gateway implementations. Some
/// examples include request or response modification, implementing
/// authentication strategies, rate-limiting, and traffic shaping. API
/// guarantee/conformance is defined based on the type of the filter.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpecRulesFilters
{
    /// <summary>
    /// ExtensionRef is an optional, implementation-specific extension to the
    /// &quot;filter&quot; behavior.  For example, resource &quot;myroutefilter&quot; in group
    /// &quot;networking.example.net&quot;). ExtensionRef MUST NOT be used for core and
    /// extended filters.
    /// 
    /// Support: Implementation-specific
    /// 
    /// This filter can be used multiple times within the same rule.
    /// </summary>
    [JsonPropertyName("extensionRef")]
    public V1GRPCRouteSpecRulesFiltersExtensionRef? ExtensionRef { get; set; }

    /// <summary>
    /// RequestHeaderModifier defines a schema for a filter that modifies request
    /// headers.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("requestHeaderModifier")]
    public V1GRPCRouteSpecRulesFiltersRequestHeaderModifier? RequestHeaderModifier { get; set; }

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
    public V1GRPCRouteSpecRulesFiltersRequestMirror? RequestMirror { get; set; }

    /// <summary>
    /// ResponseHeaderModifier defines a schema for a filter that modifies response
    /// headers.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("responseHeaderModifier")]
    public V1GRPCRouteSpecRulesFiltersResponseHeaderModifier? ResponseHeaderModifier { get; set; }

    /// <summary>
    /// Type identifies the type of filter to apply. As with other API fields,
    /// types are classified into three conformance levels:
    /// 
    /// - Core: Filter types and their corresponding configuration defined by
    ///   &quot;Support: Core&quot; in this package, e.g. &quot;RequestHeaderModifier&quot;. All
    ///   implementations supporting GRPCRoute MUST support core filters.
    /// 
    /// - Extended: Filter types and their corresponding configuration defined by
    ///   &quot;Support: Extended&quot; in this package, e.g. &quot;RequestMirror&quot;. Implementers
    ///   are encouraged to support extended filters.
    /// 
    /// - Implementation-specific: Filters that are defined and supported by specific vendors.
    ///   In the future, filters showing convergence in behavior across multiple
    ///   implementations will be considered for inclusion in extended or core
    ///   conformance levels. Filter-specific configuration for such filters
    ///   is specified using the ExtensionRef field. `Type` MUST be set to
    ///   &quot;ExtensionRef&quot; for custom filters.
    /// 
    /// Implementers are encouraged to define custom implementation types to
    /// extend the core API with implementation-specific behavior.
    /// 
    /// If a reference to a custom filter type cannot be resolved, the filter
    /// MUST NOT be skipped. Instead, requests that would have been processed by
    /// that filter MUST receive a HTTP error response.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1GRPCRouteSpecRulesFiltersTypeEnum Type { get; set; }
}

/// <summary>Type specifies how to match against the value of the header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GRPCRouteSpecRulesMatchesHeadersTypeEnum>))]
public enum V1GRPCRouteSpecRulesMatchesHeadersTypeEnum
{
    [EnumMember(Value = "Exact"), JsonStringEnumMemberName("Exact")]
    Exact,
    [EnumMember(Value = "RegularExpression"), JsonStringEnumMemberName("RegularExpression")]
    RegularExpression
}

/// <summary>
/// GRPCHeaderMatch describes how to select a gRPC route by matching gRPC request
/// headers.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpecRulesMatchesHeaders
{
    /// <summary>
    /// Name is the name of the gRPC Header to be matched.
    /// 
    /// If multiple entries specify equivalent header names, only the first
    /// entry with an equivalent name MUST be considered for a match. Subsequent
    /// entries with an equivalent header name MUST be ignored. Due to the
    /// case-insensitivity of header names, &quot;foo&quot; and &quot;Foo&quot; are considered
    /// equivalent.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Type specifies how to match against the value of the header.</summary>
    [JsonPropertyName("type")]
    public V1GRPCRouteSpecRulesMatchesHeadersTypeEnum? Type { get; set; }

    /// <summary>Value is the value of the gRPC Header to be matched.</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// Type specifies how to match against the service and/or method.
/// Support: Core (Exact with service and method specified)
/// 
/// Support: Implementation-specific (Exact with method specified but no service specified)
/// 
/// Support: Implementation-specific (RegularExpression)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GRPCRouteSpecRulesMatchesMethodTypeEnum>))]
public enum V1GRPCRouteSpecRulesMatchesMethodTypeEnum
{
    [EnumMember(Value = "Exact"), JsonStringEnumMemberName("Exact")]
    Exact,
    [EnumMember(Value = "RegularExpression"), JsonStringEnumMemberName("RegularExpression")]
    RegularExpression
}

/// <summary>
/// Method specifies a gRPC request service/method matcher. If this field is
/// not specified, all services and methods will match.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpecRulesMatchesMethod
{
    /// <summary>
    /// Value of the method to match against. If left empty or omitted, will
    /// match all services.
    /// 
    /// At least one of Service and Method MUST be a non-empty string.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// Value of the service to match against. If left empty or omitted, will
    /// match any service.
    /// 
    /// At least one of Service and Method MUST be a non-empty string.
    /// </summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>
    /// Type specifies how to match against the service and/or method.
    /// Support: Core (Exact with service and method specified)
    /// 
    /// Support: Implementation-specific (Exact with method specified but no service specified)
    /// 
    /// Support: Implementation-specific (RegularExpression)
    /// </summary>
    [JsonPropertyName("type")]
    public V1GRPCRouteSpecRulesMatchesMethodTypeEnum? Type { get; set; }
}

/// <summary>
/// GRPCRouteMatch defines the predicate used to match requests to a given
/// action. Multiple match types are ANDed together, i.e. the match will
/// evaluate to true only if all conditions are satisfied.
/// 
/// For example, the match below will match a gRPC request only if its service
/// is `foo` AND it contains the `version: v1` header:
/// 
/// ```
/// matches:
///   - method:
///     type: Exact
///     service: &quot;foo&quot;
///   - headers:
///     name: &quot;version&quot;
///     value &quot;v1&quot;
/// 
/// ```
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpecRulesMatches
{
    /// <summary>
    /// Headers specifies gRPC request header matchers. Multiple match values are
    /// ANDed together, meaning, a request MUST match all the specified headers
    /// to select the route.
    /// </summary>
    [JsonPropertyName("headers")]
    public IList<V1GRPCRouteSpecRulesMatchesHeaders>? Headers { get; set; }

    /// <summary>
    /// Method specifies a gRPC request service/method matcher. If this field is
    /// not specified, all services and methods will match.
    /// </summary>
    [JsonPropertyName("method")]
    public V1GRPCRouteSpecRulesMatchesMethod? Method { get; set; }
}

/// <summary>
/// GRPCRouteRule defines the semantics for matching a gRPC request based on
/// conditions (matches), processing it (filters), and forwarding the request to
/// an API object (backendRefs).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpecRules
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
    /// receive an `UNAVAILABLE` status.
    /// 
    /// See the GRPCBackendRef definition for the rules about what makes a single
    /// GRPCBackendRef invalid.
    /// 
    /// When a GRPCBackendRef is invalid, `UNAVAILABLE` statuses MUST be returned for
    /// requests that would have otherwise been routed to an invalid backend. If
    /// multiple backends are specified, and some are invalid, the proportion of
    /// requests that would otherwise have been routed to an invalid backend
    /// MUST receive an `UNAVAILABLE` status.
    /// 
    /// For example, if two backends are specified with equal weights, and one is
    /// invalid, 50 percent of traffic MUST receive an `UNAVAILABLE` status.
    /// Implementations may choose how that 50 percent is determined.
    /// 
    /// Support: Core for Kubernetes Service
    /// 
    /// Support: Implementation-specific for any other resource
    /// 
    /// Support for weight: Core
    /// </summary>
    [JsonPropertyName("backendRefs")]
    public IList<V1GRPCRouteSpecRulesBackendRefs>? BackendRefs { get; set; }

    /// <summary>
    /// Filters define the filters that are applied to requests that match
    /// this rule.
    /// 
    /// The effects of ordering of multiple behaviors are currently unspecified.
    /// This can change in the future based on feedback during the alpha stage.
    /// 
    /// Conformance-levels at this level are defined based on the type of filter:
    /// 
    /// - ALL core filters MUST be supported by all implementations that support
    ///   GRPCRoute.
    /// - Implementers are encouraged to support extended filters.
    /// - Implementation-specific custom filters have no API guarantees across
    ///   implementations.
    /// 
    /// Specifying the same filter multiple times is not supported unless explicitly
    /// indicated in the filter.
    /// 
    /// If an implementation cannot support a combination of filters, it must clearly
    /// document that limitation. In cases where incompatible or unsupported
    /// filters are specified and cause the `Accepted` condition to be set to status
    /// `False`, implementations may use the `IncompatibleFilters` reason to specify
    /// this configuration error.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("filters")]
    public IList<V1GRPCRouteSpecRulesFilters>? Filters { get; set; }

    /// <summary>
    /// Matches define conditions used for matching the rule against incoming
    /// gRPC requests. Each match is independent, i.e. this rule will be matched
    /// if **any** one of the matches is satisfied.
    /// 
    /// For example, take the following matches configuration:
    /// 
    /// ```
    /// matches:
    /// - method:
    ///     service: foo.bar
    ///   headers:
    ///     values:
    ///       version: 2
    /// - method:
    ///     service: foo.bar.v2
    /// ```
    /// 
    /// For a request to match against this rule, it MUST satisfy
    /// EITHER of the two conditions:
    /// 
    /// - service of foo.bar AND contains the header `version: 2`
    /// - service of foo.bar.v2
    /// 
    /// See the documentation for GRPCRouteMatch on how to specify multiple
    /// match conditions to be ANDed together.
    /// 
    /// If no matches are specified, the implementation MUST match every gRPC request.
    /// 
    /// Proxy or Load Balancer routing configuration generated from GRPCRoutes
    /// MUST prioritize rules based on the following criteria, continuing on
    /// ties. Merging MUST not be done between GRPCRoutes and HTTPRoutes.
    /// Precedence MUST be given to the rule with the largest number of:
    /// 
    /// * Characters in a matching non-wildcard hostname.
    /// * Characters in a matching hostname.
    /// * Characters in a matching service.
    /// * Characters in a matching method.
    /// * Header matches.
    /// 
    /// If ties still exist across multiple Routes, matching precedence MUST be
    /// determined in order of the following criteria, continuing on ties:
    /// 
    /// * The oldest Route based on creation timestamp.
    /// * The Route appearing first in alphabetical order by
    ///   &quot;{namespace}/{name}&quot;.
    /// 
    /// If ties still exist within the Route that has been given precedence,
    /// matching precedence MUST be granted to the first matching rule meeting
    /// the above criteria.
    /// </summary>
    [JsonPropertyName("matches")]
    public IList<V1GRPCRouteSpecRulesMatches>? Matches { get; set; }

    /// <summary>
    /// Name is the name of the route rule. This name MUST be unique within a Route if it is set.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Spec defines the desired state of GRPCRoute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteSpec
{
    /// <summary>
    /// Hostnames defines a set of hostnames to match against the GRPC
    /// Host header to select a GRPCRoute to process the request. This matches
    /// the RFC 1123 definition of a hostname with 2 notable exceptions:
    /// 
    /// 1. IPs are not allowed.
    /// 2. A hostname may be prefixed with a wildcard label (`*.`). The wildcard
    ///    label MUST appear by itself as the first label.
    /// 
    /// If a hostname is specified by both the Listener and GRPCRoute, there
    /// MUST be at least one intersecting hostname for the GRPCRoute to be
    /// attached to the Listener. For example:
    /// 
    /// * A Listener with `test.example.com` as the hostname matches GRPCRoutes
    ///   that have either not specified any hostnames, or have specified at
    ///   least one of `test.example.com` or `*.example.com`.
    /// * A Listener with `*.example.com` as the hostname matches GRPCRoutes
    ///   that have either not specified any hostnames or have specified at least
    ///   one hostname that matches the Listener hostname. For example,
    ///   `test.example.com` and `*.example.com` would both match. On the other
    ///   hand, `example.com` and `test.example.net` would not match.
    /// 
    /// Hostnames that are prefixed with a wildcard label (`*.`) are interpreted
    /// as a suffix match. That means that a match for `*.example.com` would match
    /// both `test.example.com`, and `foo.test.example.com`, but not `example.com`.
    /// 
    /// If both the Listener and GRPCRoute have specified hostnames, any
    /// GRPCRoute hostnames that do not match the Listener hostname MUST be
    /// ignored. For example, if a Listener specified `*.example.com`, and the
    /// GRPCRoute specified `test.example.com` and `test.example.net`,
    /// `test.example.net` MUST NOT be considered for a match.
    /// 
    /// If both the Listener and GRPCRoute have specified hostnames, and none
    /// match with the criteria above, then the GRPCRoute MUST NOT be accepted by
    /// the implementation. The implementation MUST raise an &apos;Accepted&apos; Condition
    /// with a status of `False` in the corresponding RouteParentStatus.
    /// 
    /// If a Route (A) of type HTTPRoute or GRPCRoute is attached to a
    /// Listener and that listener already has another Route (B) of the other
    /// type attached and the intersection of the hostnames of A and B is
    /// non-empty, then the implementation MUST accept exactly one of these two
    /// routes, determined by the following criteria, in order:
    /// 
    /// * The oldest Route based on creation timestamp.
    /// * The Route appearing first in alphabetical order by
    ///   &quot;{namespace}/{name}&quot;.
    /// 
    /// The rejected Route MUST raise an &apos;Accepted&apos; condition with a status of
    /// &apos;False&apos; in the corresponding RouteParentStatus.
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
    public IList<V1GRPCRouteSpecParentRefs>? ParentRefs { get; set; }

    /// <summary>Rules are a list of GRPC matchers, filters and actions.</summary>
    [JsonPropertyName("rules")]
    public IList<V1GRPCRouteSpecRules>? Rules { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GRPCRouteStatusParentsConditionsStatusEnum>))]
public enum V1GRPCRouteStatusParentsConditionsStatusEnum
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
public partial class V1GRPCRouteStatusParentsConditions
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
    public required V1GRPCRouteStatusParentsConditionsStatusEnum Status { get; set; }

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
public partial class V1GRPCRouteStatusParentsParentRef
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
public partial class V1GRPCRouteStatusParents
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
    public required IList<V1GRPCRouteStatusParentsConditions> Conditions { get; set; }

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
    public required V1GRPCRouteStatusParentsParentRef ParentRef { get; set; }
}

/// <summary>Status defines the current state of GRPCRoute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GRPCRouteStatus
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
    public required IList<V1GRPCRouteStatusParents> Parents { get; set; }
}

/// <summary>
/// GRPCRoute provides a way to route gRPC requests. This includes the capability
/// to match requests by hostname, gRPC service, gRPC method, or HTTP/2 header.
/// Filters can be used to specify additional processing steps. Backends specify
/// where matching requests will be routed.
/// 
/// GRPCRoute falls under extended support within the Gateway API. Within the
/// following specification, the word &quot;MUST&quot; indicates that an implementation
/// supporting GRPCRoute must conform to the indicated requirement, but an
/// implementation not supporting this route type need not follow the requirement
/// unless explicitly indicated.
/// 
/// Implementations supporting `GRPCRoute` with the `HTTPS` `ProtocolType` MUST
/// accept HTTP/2 connections without an initial upgrade from HTTP/1.1, i.e. via
/// ALPN. If the implementation does not support this, then it MUST set the
/// &quot;Accepted&quot; condition to &quot;False&quot; for the affected listener with a reason of
/// &quot;UnsupportedProtocol&quot;.  Implementations MAY also accept HTTP/2 connections
/// with an upgrade from HTTP/1.
/// 
/// Implementations supporting `GRPCRoute` with the `HTTP` `ProtocolType` MUST
/// support HTTP/2 over cleartext TCP (h2c,
/// https://www.rfc-editor.org/rfc/rfc7540#section-3.1) without an initial
/// upgrade from HTTP/1.1, i.e. with prior knowledge
/// (https://www.rfc-editor.org/rfc/rfc7540#section-3.4). If the implementation
/// does not support this, then it MUST set the &quot;Accepted&quot; condition to &quot;False&quot;
/// for the affected listener with a reason of &quot;UnsupportedProtocol&quot;.
/// Implementations MAY also accept HTTP/2 connections with an upgrade from
/// HTTP/1, i.e. without prior knowledge.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GRPCRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1GRPCRouteSpec>, IStatus<V1GRPCRouteStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GRPCRoute";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "grpcroutes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GRPCRoute";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of GRPCRoute.</summary>
    [JsonPropertyName("spec")]
    public required V1GRPCRouteSpec Spec { get; set; }

    /// <summary>Status defines the current state of GRPCRoute.</summary>
    [JsonPropertyName("status")]
    public V1GRPCRouteStatus? Status { get; set; }
}