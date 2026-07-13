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
/// ListenerSet defines a set of additional listeners to attach to an existing Gateway.
/// This resource provides a mechanism to merge multiple listeners into a single Gateway.
/// 
/// The parent Gateway must explicitly allow ListenerSet attachment through its
/// AllowedListeners configuration. By default, Gateways do not allow ListenerSet
/// attachment.
/// 
/// Routes can attach to a ListenerSet by specifying it as a parentRef, and can
/// optionally target specific listeners using the sectionName field.
/// 
/// Policy Attachment:
/// - Policies that attach to a ListenerSet apply to all listeners defined in that resource
/// - Policies do not impact listeners in the parent Gateway
/// - Different ListenerSets attached to the same Gateway can have different policies
/// - If an implementation cannot apply a policy to specific listeners, it should reject the policy
/// 
/// ReferenceGrant Semantics:
/// - ReferenceGrants applied to a Gateway are not inherited by child ListenerSets
/// - ReferenceGrants applied to a ListenerSet do not grant permission to the parent Gateway&apos;s listeners
/// - A ListenerSet can reference secrets/backends in its own namespace without a ReferenceGrant
/// 
/// Gateway Integration:
///   - The parent Gateway&apos;s status will include &quot;AttachedListenerSets&quot;
///     which is the count of ListenerSets that have successfully attached to a Gateway
///     A ListenerSet is successfully attached to a Gateway when all the following conditions are met:
///   - The ListenerSet is selected by the Gateway&apos;s AllowedListeners field
///   - The ListenerSet has a valid ParentRef selecting the Gateway
///   - The ListenerSet&apos;s status has the condition &quot;Accepted: true&quot;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ListenerSetList : IKubernetesObject<V1ListMeta>, IItems<V1ListenerSet>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ListenerSetList";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "listenersets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ListenerSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1ListenerSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1ListenerSet> Items { get; set; }
}

/// <summary>RouteGroupKind indicates the group and kind of a Route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetSpecListenersAllowedRoutesKinds
{
    /// <summary>Group is the group of the Route.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the kind of the Route.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }
}

/// <summary>
/// From indicates where Routes will be selected for this Gateway. Possible
/// values are:
/// 
/// * All: Routes in all namespaces may be used by this Gateway.
/// * Selector: Routes in namespaces selected by the selector may be used by
///   this Gateway.
/// * Same: Only Routes in the same namespace may be used by this Gateway.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ListenerSetSpecListenersAllowedRoutesNamespacesFromEnum>))]
public enum V1ListenerSetSpecListenersAllowedRoutesNamespacesFromEnum
{
    [EnumMember(Value = "All"), JsonStringEnumMemberName("All")]
    All,
    [EnumMember(Value = "Selector"), JsonStringEnumMemberName("Selector")]
    Selector,
    [EnumMember(Value = "Same"), JsonStringEnumMemberName("Same")]
    Same
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetSpecListenersAllowedRoutesNamespacesSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Selector must be specified when From is set to &quot;Selector&quot;. In that case,
/// only Routes in Namespaces matching this Selector will be selected by this
/// Gateway. This field is ignored for other values of &quot;From&quot;.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetSpecListenersAllowedRoutesNamespacesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1ListenerSetSpecListenersAllowedRoutesNamespacesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Namespaces indicates namespaces from which Routes may be attached to this
/// Listener. This is restricted to the namespace of this Gateway by default.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetSpecListenersAllowedRoutesNamespaces
{
    /// <summary>
    /// From indicates where Routes will be selected for this Gateway. Possible
    /// values are:
    /// 
    /// * All: Routes in all namespaces may be used by this Gateway.
    /// * Selector: Routes in namespaces selected by the selector may be used by
    ///   this Gateway.
    /// * Same: Only Routes in the same namespace may be used by this Gateway.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("from")]
    public V1ListenerSetSpecListenersAllowedRoutesNamespacesFromEnum? From { get; set; }

    /// <summary>
    /// Selector must be specified when From is set to &quot;Selector&quot;. In that case,
    /// only Routes in Namespaces matching this Selector will be selected by this
    /// Gateway. This field is ignored for other values of &quot;From&quot;.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("selector")]
    public V1ListenerSetSpecListenersAllowedRoutesNamespacesSelector? Selector { get; set; }
}

/// <summary>
/// AllowedRoutes defines the types of routes that MAY be attached to a
/// Listener and the trusted namespaces where those Route resources MAY be
/// present.
/// 
/// Although a client request may match multiple route rules, only one rule
/// may ultimately receive the request. Matching precedence MUST be
/// determined in order of the following criteria:
/// 
/// * The most specific match as defined by the Route type.
/// * The oldest Route based on creation timestamp. For example, a Route with
///   a creation timestamp of &quot;2020-09-08 01:02:03&quot; is given precedence over
///   a Route with a creation timestamp of &quot;2020-09-08 01:02:04&quot;.
/// * If everything else is equivalent, the Route appearing first in
///   alphabetical order (namespace/name) should be given precedence. For
///   example, foo/bar is given precedence over foo/baz.
/// 
/// All valid rules within a Route attached to this Listener should be
/// implemented. Invalid Route rules can be ignored (sometimes that will mean
/// the full Route). If a Route rule transitions from valid to invalid,
/// support for that Route rule should be dropped to ensure consistency. For
/// example, even if a filter specified by a Route rule is invalid, the rest
/// of the rules within that Route should still be supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetSpecListenersAllowedRoutes
{
    /// <summary>
    /// Kinds specifies the groups and kinds of Routes that are allowed to bind
    /// to this Gateway Listener. When unspecified or empty, the kinds of Routes
    /// selected are determined using the Listener protocol.
    /// 
    /// A RouteGroupKind MUST correspond to kinds of Routes that are compatible
    /// with the application protocol specified in the Listener&apos;s Protocol field.
    /// If an implementation does not support or recognize this resource type, it
    /// MUST set the &quot;ResolvedRefs&quot; condition to False for this Listener with the
    /// &quot;InvalidRouteKinds&quot; reason.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("kinds")]
    public IList<V1ListenerSetSpecListenersAllowedRoutesKinds>? Kinds { get; set; }

    /// <summary>
    /// Namespaces indicates namespaces from which Routes may be attached to this
    /// Listener. This is restricted to the namespace of this Gateway by default.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("namespaces")]
    public V1ListenerSetSpecListenersAllowedRoutesNamespaces? Namespaces { get; set; }
}

/// <summary>
/// SecretObjectReference identifies an API object including its namespace,
/// defaulting to Secret.
/// 
/// The API object must be valid in the cluster; the Group and Kind must
/// be registered in the cluster for this reference to be valid.
/// 
/// References to objects with invalid Group and Kind are not valid, and must
/// be rejected by the implementation, with appropriate Conditions set
/// on the containing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetSpecListenersTlsCertificateRefs
{
    /// <summary>
    /// Group is the group of the referent. For example, &quot;gateway.networking.k8s.io&quot;.
    /// When unspecified or empty string, core API group is inferred.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is kind of the referent. For example &quot;Secret&quot;.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace is the namespace of the referenced object. When unspecified, the local
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
}

/// <summary>
/// Mode defines the TLS behavior for the TLS session initiated by the client.
/// There are two possible modes:
/// 
/// - Terminate: The TLS session between the downstream client and the
///   Gateway is terminated at the Gateway. This mode requires certificates
///   to be specified in some way, such as populating the certificateRefs
///   field.
/// - Passthrough: The TLS session is NOT terminated by the Gateway. This
///   implies that the Gateway can&apos;t decipher the TLS stream except for
///   the ClientHello message of the TLS protocol. The certificateRefs field
///   is ignored in this mode.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ListenerSetSpecListenersTlsModeEnum>))]
public enum V1ListenerSetSpecListenersTlsModeEnum
{
    [EnumMember(Value = "Terminate"), JsonStringEnumMemberName("Terminate")]
    Terminate,
    [EnumMember(Value = "Passthrough"), JsonStringEnumMemberName("Passthrough")]
    Passthrough
}

/// <summary>
/// TLS is the TLS configuration for the Listener. This field is required if
/// the Protocol field is &quot;HTTPS&quot; or &quot;TLS&quot;. It is invalid to set this field
/// if the Protocol field is &quot;HTTP&quot;, &quot;TCP&quot;, or &quot;UDP&quot;.
/// 
/// The association of SNIs to Certificate defined in ListenerTLSConfig is
/// defined based on the Hostname field for this listener.
/// 
/// The GatewayClass MUST use the longest matching SNI out of all
/// available certificates for any TLS handshake.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetSpecListenersTls
{
    /// <summary>
    /// CertificateRefs contains a series of references to Kubernetes objects that
    /// contains TLS certificates and private keys. These certificates are used to
    /// establish a TLS handshake for requests that match the hostname of the
    /// associated listener.
    /// 
    /// A single CertificateRef to a Kubernetes Secret has &quot;Core&quot; support.
    /// Implementations MAY choose to support attaching multiple certificates to
    /// a Listener, but this behavior is implementation-specific.
    /// 
    /// References to a resource in different namespace are invalid UNLESS there
    /// is a ReferenceGrant in the target namespace that allows the certificate
    /// to be attached. If a ReferenceGrant does not allow this reference, the
    /// &quot;ResolvedRefs&quot; condition MUST be set to False for this listener with the
    /// &quot;RefNotPermitted&quot; reason.
    /// 
    /// This field is required to have at least one element when the mode is set
    /// to &quot;Terminate&quot; (default) and is optional otherwise.
    /// 
    /// CertificateRefs can reference to standard Kubernetes resources, i.e.
    /// Secret, or implementation-specific custom resources.
    /// 
    /// Support: Core - A single reference to a Kubernetes Secret of type kubernetes.io/tls
    /// 
    /// Support: Implementation-specific (More than one reference or other resource types)
    /// </summary>
    [JsonPropertyName("certificateRefs")]
    public IList<V1ListenerSetSpecListenersTlsCertificateRefs>? CertificateRefs { get; set; }

    /// <summary>
    /// Mode defines the TLS behavior for the TLS session initiated by the client.
    /// There are two possible modes:
    /// 
    /// - Terminate: The TLS session between the downstream client and the
    ///   Gateway is terminated at the Gateway. This mode requires certificates
    ///   to be specified in some way, such as populating the certificateRefs
    ///   field.
    /// - Passthrough: The TLS session is NOT terminated by the Gateway. This
    ///   implies that the Gateway can&apos;t decipher the TLS stream except for
    ///   the ClientHello message of the TLS protocol. The certificateRefs field
    ///   is ignored in this mode.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("mode")]
    public V1ListenerSetSpecListenersTlsModeEnum? Mode { get; set; }

    /// <summary>
    /// Options are a list of key/value pairs to enable extended TLS
    /// configuration for each implementation. For example, configuring the
    /// minimum TLS version or supported cipher suites.
    /// 
    /// A set of common keys MAY be defined by the API in the future. To avoid
    /// any ambiguity, implementation-specific definitions MUST use
    /// domain-prefixed names, such as `example.com/my-custom-option`.
    /// Un-prefixed names are reserved for key names defined by Gateway API.
    /// 
    /// Support: Implementation-specific
    /// </summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetSpecListeners
{
    /// <summary>
    /// AllowedRoutes defines the types of routes that MAY be attached to a
    /// Listener and the trusted namespaces where those Route resources MAY be
    /// present.
    /// 
    /// Although a client request may match multiple route rules, only one rule
    /// may ultimately receive the request. Matching precedence MUST be
    /// determined in order of the following criteria:
    /// 
    /// * The most specific match as defined by the Route type.
    /// * The oldest Route based on creation timestamp. For example, a Route with
    ///   a creation timestamp of &quot;2020-09-08 01:02:03&quot; is given precedence over
    ///   a Route with a creation timestamp of &quot;2020-09-08 01:02:04&quot;.
    /// * If everything else is equivalent, the Route appearing first in
    ///   alphabetical order (namespace/name) should be given precedence. For
    ///   example, foo/bar is given precedence over foo/baz.
    /// 
    /// All valid rules within a Route attached to this Listener should be
    /// implemented. Invalid Route rules can be ignored (sometimes that will mean
    /// the full Route). If a Route rule transitions from valid to invalid,
    /// support for that Route rule should be dropped to ensure consistency. For
    /// example, even if a filter specified by a Route rule is invalid, the rest
    /// of the rules within that Route should still be supported.
    /// </summary>
    [JsonPropertyName("allowedRoutes")]
    public V1ListenerSetSpecListenersAllowedRoutes? AllowedRoutes { get; set; }

    /// <summary>
    /// Hostname specifies the virtual hostname to match for protocol types that
    /// define this concept. When unspecified, all hostnames are matched. This
    /// field is ignored for protocols that don&apos;t require hostname based
    /// matching.
    /// 
    /// Implementations MUST apply Hostname matching appropriately for each of
    /// the following protocols:
    /// 
    /// * TLS: The Listener Hostname MUST match the SNI.
    /// * HTTP: The Listener Hostname MUST match the Host header of the request.
    /// * HTTPS: The Listener Hostname SHOULD match at both the TLS and HTTP
    ///   protocol layers as described above. If an implementation does not
    ///   ensure that both the SNI and Host header match the Listener hostname,
    ///   it MUST clearly document that.
    /// 
    /// For HTTPRoute and TLSRoute resources, there is an interaction with the
    /// `spec.hostnames` array. When both listener and route specify hostnames,
    /// there MUST be an intersection between the values for a Route to be
    /// accepted. For more information, refer to the Route specific Hostnames
    /// documentation.
    /// 
    /// Hostnames that are prefixed with a wildcard label (`*.`) are interpreted
    /// as a suffix match. That means that a match for `*.example.com` would match
    /// both `test.example.com`, and `foo.test.example.com`, but not `example.com`.
    /// </summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Name is the name of the Listener. This name MUST be unique within a
    /// ListenerSet.
    /// 
    /// Name is not required to be unique across a Gateway and ListenerSets.
    /// Routes can attach to a Listener by having a ListenerSet as a parentRef
    /// and setting the SectionName
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Port is the network port. Multiple listeners may use the
    /// same port, subject to the Listener compatibility rules.
    /// </summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>Protocol specifies the network protocol this listener expects to receive.</summary>
    [JsonPropertyName("protocol")]
    public required string Protocol { get; set; }

    /// <summary>
    /// TLS is the TLS configuration for the Listener. This field is required if
    /// the Protocol field is &quot;HTTPS&quot; or &quot;TLS&quot;. It is invalid to set this field
    /// if the Protocol field is &quot;HTTP&quot;, &quot;TCP&quot;, or &quot;UDP&quot;.
    /// 
    /// The association of SNIs to Certificate defined in ListenerTLSConfig is
    /// defined based on the Hostname field for this listener.
    /// 
    /// The GatewayClass MUST use the longest matching SNI out of all
    /// available certificates for any TLS handshake.
    /// </summary>
    [JsonPropertyName("tls")]
    public V1ListenerSetSpecListenersTls? Tls { get; set; }
}

/// <summary>ParentRef references the Gateway that the listeners are attached to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetSpecParentRef
{
    /// <summary>Group is the group of the referent.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is kind of the referent. For example &quot;Gateway&quot;.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Namespace is the namespace of the referent.  If not present,
    /// the namespace of the referent is assumed to be the same as
    /// the namespace of the referring object.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Spec defines the desired state of ListenerSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetSpec
{
    /// <summary>
    /// Listeners associated with this ListenerSet. Listeners define
    /// logical endpoints that are bound on this referenced parent Gateway&apos;s addresses.
    /// 
    /// Listeners in a `Gateway` and their attached `ListenerSets` are concatenated
    /// as a list when programming the underlying infrastructure. Each listener
    /// name does not need to be unique across the Gateway and ListenerSets.
    /// See ListenerEntry.Name for more details.
    /// 
    /// Implementations MUST treat the parent Gateway as having the merged
    /// list of all listeners from itself and attached ListenerSets using
    /// the following precedence:
    /// 
    /// 1. &quot;parent&quot; Gateway
    /// 2. ListenerSet ordered by creation time (oldest first)
    /// 3. ListenerSet ordered alphabetically by &quot;{namespace}/{name}&quot;.
    /// 
    /// An implementation MAY reject listeners by setting the ListenerEntryStatus
    /// `Accepted` condition to False with the Reason `TooManyListeners`
    /// 
    /// If a listener has a conflict, this will be reported in the
    /// Status.ListenerEntryStatus setting the `Conflicted` condition to True.
    /// 
    /// Implementations SHOULD be cautious about what information from the
    /// parent or siblings are reported to avoid accidentally leaking
    /// sensitive information that the child would not otherwise have access
    /// to. This can include contents of secrets etc.
    /// </summary>
    [JsonPropertyName("listeners")]
    public required IList<V1ListenerSetSpecListeners> Listeners { get; set; }

    /// <summary>ParentRef references the Gateway that the listeners are attached to.</summary>
    [JsonPropertyName("parentRef")]
    public required V1ListenerSetSpecParentRef ParentRef { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ListenerSetStatusConditionsStatusEnum>))]
public enum V1ListenerSetStatusConditionsStatusEnum
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
public partial class V1ListenerSetStatusConditions
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
    public required V1ListenerSetStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ListenerSetStatusListenersConditionsStatusEnum>))]
public enum V1ListenerSetStatusListenersConditionsStatusEnum
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
public partial class V1ListenerSetStatusListenersConditions
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
    public required V1ListenerSetStatusListenersConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>RouteGroupKind indicates the group and kind of a Route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetStatusListenersSupportedKinds
{
    /// <summary>Group is the group of the Route.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the kind of the Route.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }
}

/// <summary>ListenerStatus is the status associated with a Listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetStatusListeners
{
    /// <summary>
    /// AttachedRoutes represents the total number of Routes that have been
    /// successfully attached to this Listener.
    /// 
    /// Successful attachment of a Route to a Listener is based solely on the
    /// combination of the AllowedRoutes field on the corresponding Listener
    /// and the Route&apos;s ParentRefs field. A Route is successfully attached to
    /// a Listener when it is selected by the Listener&apos;s AllowedRoutes field
    /// AND the Route has a valid ParentRef selecting the whole Gateway
    /// resource or a specific Listener as a parent resource (more detail on
    /// attachment semantics can be found in the documentation on the various
    /// Route kinds ParentRefs fields). Listener status does not impact
    /// successful attachment, i.e. the AttachedRoutes field count MUST be set
    /// for Listeners, even if the Accepted condition of an individual Listener is set
    /// to &quot;False&quot;. The AttachedRoutes number represents the number of Routes with
    /// the Accepted condition set to &quot;True&quot; that have been attached to this Listener.
    /// Routes with any other value for the Accepted condition MUST NOT be included
    /// in this count.
    /// 
    /// Uses for this field include troubleshooting Route attachment and
    /// measuring blast radius/impact of changes to a Listener.
    /// </summary>
    [JsonPropertyName("attachedRoutes")]
    public required int AttachedRoutes { get; set; }

    /// <summary>Conditions describe the current condition of this listener.</summary>
    [JsonPropertyName("conditions")]
    public required IList<V1ListenerSetStatusListenersConditions> Conditions { get; set; }

    /// <summary>Name is the name of the Listener that this status corresponds to.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// SupportedKinds is the list indicating the Kinds supported by this
    /// listener. This MUST represent the kinds supported by an implementation for
    /// that Listener configuration.
    /// 
    /// If kinds are specified in Spec that are not supported, they MUST NOT
    /// appear in this list and an implementation MUST set the &quot;ResolvedRefs&quot;
    /// condition to &quot;False&quot; with the &quot;InvalidRouteKinds&quot; reason. If both valid
    /// and invalid Route kinds are specified, the implementation MUST
    /// reference the valid Route kinds that have been specified.
    /// </summary>
    [JsonPropertyName("supportedKinds")]
    public IList<V1ListenerSetStatusListenersSupportedKinds>? SupportedKinds { get; set; }
}

/// <summary>Status defines the current state of ListenerSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ListenerSetStatus
{
    /// <summary>
    /// Conditions describe the current conditions of the ListenerSet.
    /// 
    /// Implementations MUST express ListenerSet conditions using the
    /// `ListenerSetConditionType` and `ListenerSetConditionReason`
    /// constants so that operators and tools can converge on a common
    /// vocabulary to describe ListenerSet state.
    /// 
    /// Known condition types are:
    /// 
    /// * &quot;Accepted&quot;
    /// * &quot;Programmed&quot;
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1ListenerSetStatusConditions>? Conditions { get; set; }

    /// <summary>Listeners provide status for each unique listener port defined in the Spec.</summary>
    [JsonPropertyName("listeners")]
    public IList<V1ListenerSetStatusListeners>? Listeners { get; set; }
}

/// <summary>
/// ListenerSet defines a set of additional listeners to attach to an existing Gateway.
/// This resource provides a mechanism to merge multiple listeners into a single Gateway.
/// 
/// The parent Gateway must explicitly allow ListenerSet attachment through its
/// AllowedListeners configuration. By default, Gateways do not allow ListenerSet
/// attachment.
/// 
/// Routes can attach to a ListenerSet by specifying it as a parentRef, and can
/// optionally target specific listeners using the sectionName field.
/// 
/// Policy Attachment:
/// - Policies that attach to a ListenerSet apply to all listeners defined in that resource
/// - Policies do not impact listeners in the parent Gateway
/// - Different ListenerSets attached to the same Gateway can have different policies
/// - If an implementation cannot apply a policy to specific listeners, it should reject the policy
/// 
/// ReferenceGrant Semantics:
/// - ReferenceGrants applied to a Gateway are not inherited by child ListenerSets
/// - ReferenceGrants applied to a ListenerSet do not grant permission to the parent Gateway&apos;s listeners
/// - A ListenerSet can reference secrets/backends in its own namespace without a ReferenceGrant
/// 
/// Gateway Integration:
///   - The parent Gateway&apos;s status will include &quot;AttachedListenerSets&quot;
///     which is the count of ListenerSets that have successfully attached to a Gateway
///     A ListenerSet is successfully attached to a Gateway when all the following conditions are met:
///   - The ListenerSet is selected by the Gateway&apos;s AllowedListeners field
///   - The ListenerSet has a valid ParentRef selecting the Gateway
///   - The ListenerSet&apos;s status has the condition &quot;Accepted: true&quot;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ListenerSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1ListenerSetSpec>, IStatus<V1ListenerSetStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ListenerSet";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "listenersets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ListenerSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of ListenerSet.</summary>
    [JsonPropertyName("spec")]
    public required V1ListenerSetSpec Spec { get; set; }

    /// <summary>Status defines the current state of ListenerSet.</summary>
    [JsonPropertyName("status")]
    public V1ListenerSetStatus? Status { get; set; }
}