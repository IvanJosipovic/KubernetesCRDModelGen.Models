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
/// Gateway represents an instance of a service-traffic handling infrastructure
/// by binding Listeners to a set of IP addresses.
/// A Gateway name SHOULD be compliant with RFC 1035, consisting of a maximum of 63 lower case alphanumeric
/// characters or hyphens (&apos;-&apos;), and MUST start and end with an alphanumeric character.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1GatewayList : IKubernetesObject<V1ListMeta>, IItems<V1Gateway>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "GatewayList";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "gateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GatewayList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Gateway objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Gateway> Items { get; set; }
}

/// <summary>GatewaySpecAddress describes an address that can be bound to a Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecAddresses
{
    /// <summary>Type of the address.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// When a value is unspecified, an implementation SHOULD automatically
    /// assign an address matching the requested type if possible.
    /// 
    /// If an implementation does not support an empty value, they MUST set the
    /// &quot;Programmed&quot; condition in status to False with a reason of &quot;AddressNotAssigned&quot;.
    /// 
    /// Examples: `1.2.3.4`, `128::1`, `my-ip-address`.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// From indicates where ListenerSets can attach to this Gateway. Possible
/// values are:
/// 
/// * Same: Only ListenerSets in the same namespace may be attached to this Gateway.
/// * Selector: ListenerSets in namespaces selected by the selector may be attached to this Gateway.
/// * All: ListenerSets in all namespaces may be attached to this Gateway.
/// * None: Only listeners defined in the Gateway&apos;s spec are allowed
/// 
/// The default value None
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewaySpecAllowedListenersNamespacesFromEnum>))]
public enum V1GatewaySpecAllowedListenersNamespacesFromEnum
{
    [EnumMember(Value = "All"), JsonStringEnumMemberName("All")]
    All,
    [EnumMember(Value = "Selector"), JsonStringEnumMemberName("Selector")]
    Selector,
    [EnumMember(Value = "Same"), JsonStringEnumMemberName("Same")]
    Same,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecAllowedListenersNamespacesSelectorMatchExpressions
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
/// only ListenerSets in Namespaces matching this Selector will be selected by this
/// Gateway. This field is ignored for other values of &quot;From&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecAllowedListenersNamespacesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewaySpecAllowedListenersNamespacesSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// Namespaces defines which namespaces ListenerSets can be attached to this Gateway.
/// The default value is to allow no ListenerSets.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecAllowedListenersNamespaces
{
    /// <summary>
    /// From indicates where ListenerSets can attach to this Gateway. Possible
    /// values are:
    /// 
    /// * Same: Only ListenerSets in the same namespace may be attached to this Gateway.
    /// * Selector: ListenerSets in namespaces selected by the selector may be attached to this Gateway.
    /// * All: ListenerSets in all namespaces may be attached to this Gateway.
    /// * None: Only listeners defined in the Gateway&apos;s spec are allowed
    /// 
    /// The default value None
    /// </summary>
    [JsonPropertyName("from")]
    public V1GatewaySpecAllowedListenersNamespacesFromEnum? From { get; set; }

    /// <summary>
    /// Selector must be specified when From is set to &quot;Selector&quot;. In that case,
    /// only ListenerSets in Namespaces matching this Selector will be selected by this
    /// Gateway. This field is ignored for other values of &quot;From&quot;.
    /// </summary>
    [JsonPropertyName("selector")]
    public V1GatewaySpecAllowedListenersNamespacesSelector? Selector { get; set; }
}

/// <summary>
/// AllowedListeners defines which ListenerSets can be attached to this Gateway.
/// The default value is to allow no ListenerSets.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecAllowedListeners
{
    /// <summary>
    /// Namespaces defines which namespaces ListenerSets can be attached to this Gateway.
    /// The default value is to allow no ListenerSets.
    /// </summary>
    [JsonPropertyName("namespaces")]
    public V1GatewaySpecAllowedListenersNamespaces? Namespaces { get; set; }
}

/// <summary>
/// ParametersRef is a reference to a resource that contains the configuration
/// parameters corresponding to the Gateway. This is optional if the
/// controller does not require any additional configuration.
/// 
/// This follows the same semantics as GatewayClass&apos;s `parametersRef`, but on a per-Gateway basis
/// 
/// The Gateway&apos;s GatewayClass may provide its own `parametersRef`. When both are specified,
/// the merging behavior is implementation specific.
/// It is generally recommended that GatewayClass provides defaults that can be overridden by a Gateway.
/// 
/// If the referent cannot be found, refers to an unsupported kind, or when
/// the data within that resource is malformed, the Gateway SHOULD be
/// rejected with the &quot;Accepted&quot; status condition set to &quot;False&quot; and an
/// &quot;InvalidParameters&quot; reason.
/// 
/// Support: Implementation-specific
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecInfrastructureParametersRef
{
    /// <summary>Group is the group of the referent.</summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>Kind is kind of the referent.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name is the name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Infrastructure defines infrastructure level attributes about this Gateway instance.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecInfrastructure
{
    /// <summary>
    /// Annotations that SHOULD be applied to any resources created in response to this Gateway.
    /// 
    /// For implementations creating other Kubernetes objects, this should be the `metadata.annotations` field on resources.
    /// For other implementations, this refers to any relevant (implementation specific) &quot;annotations&quot; concepts.
    /// 
    /// An implementation may chose to add additional implementation-specific annotations as they see fit.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Labels that SHOULD be applied to any resources created in response to this Gateway.
    /// 
    /// For implementations creating other Kubernetes objects, this should be the `metadata.labels` field on resources.
    /// For other implementations, this refers to any relevant (implementation specific) &quot;labels&quot; concepts.
    /// 
    /// An implementation may chose to add additional implementation-specific labels as they see fit.
    /// 
    /// If an implementation maps these labels to Pods, or any other resource that would need to be recreated when labels
    /// change, it SHOULD clearly warn about this behavior in documentation.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// ParametersRef is a reference to a resource that contains the configuration
    /// parameters corresponding to the Gateway. This is optional if the
    /// controller does not require any additional configuration.
    /// 
    /// This follows the same semantics as GatewayClass&apos;s `parametersRef`, but on a per-Gateway basis
    /// 
    /// The Gateway&apos;s GatewayClass may provide its own `parametersRef`. When both are specified,
    /// the merging behavior is implementation specific.
    /// It is generally recommended that GatewayClass provides defaults that can be overridden by a Gateway.
    /// 
    /// If the referent cannot be found, refers to an unsupported kind, or when
    /// the data within that resource is malformed, the Gateway SHOULD be
    /// rejected with the &quot;Accepted&quot; status condition set to &quot;False&quot; and an
    /// &quot;InvalidParameters&quot; reason.
    /// 
    /// Support: Implementation-specific
    /// </summary>
    [JsonPropertyName("parametersRef")]
    public V1GatewaySpecInfrastructureParametersRef? ParametersRef { get; set; }
}

/// <summary>RouteGroupKind indicates the group and kind of a Route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListenersAllowedRoutesKinds
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
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewaySpecListenersAllowedRoutesNamespacesFromEnum>))]
public enum V1GatewaySpecListenersAllowedRoutesNamespacesFromEnum
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
public partial class V1GatewaySpecListenersAllowedRoutesNamespacesSelectorMatchExpressions
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
public partial class V1GatewaySpecListenersAllowedRoutesNamespacesSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1GatewaySpecListenersAllowedRoutesNamespacesSelectorMatchExpressions>? MatchExpressions { get; set; }

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
public partial class V1GatewaySpecListenersAllowedRoutesNamespaces
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
    public V1GatewaySpecListenersAllowedRoutesNamespacesFromEnum? From { get; set; }

    /// <summary>
    /// Selector must be specified when From is set to &quot;Selector&quot;. In that case,
    /// only Routes in Namespaces matching this Selector will be selected by this
    /// Gateway. This field is ignored for other values of &quot;From&quot;.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("selector")]
    public V1GatewaySpecListenersAllowedRoutesNamespacesSelector? Selector { get; set; }
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
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListenersAllowedRoutes
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
    public IList<V1GatewaySpecListenersAllowedRoutesKinds>? Kinds { get; set; }

    /// <summary>
    /// Namespaces indicates namespaces from which Routes may be attached to this
    /// Listener. This is restricted to the namespace of this Gateway by default.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("namespaces")]
    public V1GatewaySpecListenersAllowedRoutesNamespaces? Namespaces { get; set; }
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
public partial class V1GatewaySpecListenersTlsCertificateRefs
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
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewaySpecListenersTlsModeEnum>))]
public enum V1GatewaySpecListenersTlsModeEnum
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
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListenersTls
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
    public IList<V1GatewaySpecListenersTlsCertificateRefs>? CertificateRefs { get; set; }

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
    public V1GatewaySpecListenersTlsModeEnum? Mode { get; set; }

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

/// <summary>
/// Listener embodies the concept of a logical endpoint where a Gateway accepts
/// network connections.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecListeners
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
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("allowedRoutes")]
    public V1GatewaySpecListenersAllowedRoutes? AllowedRoutes { get; set; }

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
    /// * HTTPS: The Listener Hostname SHOULD match both the SNI and Host header.
    ///   Note that this does not require the SNI and Host header to be the same.
    ///   The semantics of this are described in more detail below.
    /// 
    /// To ensure security, Section 11.1 of RFC-6066 emphasizes that server
    /// implementations that rely on SNI hostname matching MUST also verify
    /// hostnames within the application protocol.
    /// 
    /// Section 9.1.2 of RFC-7540 provides a mechanism for servers to reject the
    /// reuse of a connection by responding with the HTTP 421 Misdirected Request
    /// status code. This indicates that the origin server has rejected the
    /// request because it appears to have been misdirected.
    /// 
    /// To detect misdirected requests, Gateways SHOULD match the authority of
    /// the requests with all the SNI hostname(s) configured across all the
    /// Gateway Listeners on the same port and protocol:
    /// 
    /// * If another Listener has an exact match or more specific wildcard entry,
    ///   the Gateway SHOULD return a 421.
    /// * If the current Listener (selected by SNI matching during ClientHello)
    ///   does not match the Host:
    ///     * If another Listener does match the Host, the Gateway SHOULD return a
    ///       421.
    ///     * If no other Listener matches the Host, the Gateway MUST return a
    ///       404.
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
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Name is the name of the Listener. This name MUST be unique within a
    /// Gateway.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Port is the network port. Multiple listeners may use the
    /// same port, subject to the Listener compatibility rules.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>
    /// Protocol specifies the network protocol this listener expects to receive.
    /// 
    /// Support: Core
    /// </summary>
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
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("tls")]
    public V1GatewaySpecListenersTls? Tls { get; set; }
}

/// <summary>
/// ClientCertificateRef references an object that contains a client certificate
/// and its associated private key. It can reference standard Kubernetes resources,
/// i.e., Secret, or implementation-specific custom resources.
/// 
/// A ClientCertificateRef is considered invalid if:
/// 
/// * It refers to a resource that cannot be resolved (e.g., the referenced resource
///   does not exist) or is misconfigured (e.g., a Secret does not contain the keys
///   named `tls.crt` and `tls.key`). In this case, the `ResolvedRefs` condition
///   on the Gateway MUST be set to False with the Reason `InvalidClientCertificateRef`
///   and the Message of the Condition MUST indicate why the reference is invalid.
/// 
/// * It refers to a resource in another namespace UNLESS there is a ReferenceGrant
///   in the target namespace that allows the certificate to be attached.
///   If a ReferenceGrant does not allow this reference, the `ResolvedRefs` condition
///   on the Gateway MUST be set to False with the Reason `RefNotPermitted`.
/// 
/// Implementations MAY choose to perform further validation of the certificate
/// content (e.g., checking expiry or enforcing specific formats). In such cases,
/// an implementation-specific Reason and Message MUST be set.
/// 
/// Support: Core - Reference to a Kubernetes TLS Secret (with the type `kubernetes.io/tls`).
/// Support: Implementation-specific - Other resource kinds or Secrets with a
/// different type (e.g., `Opaque`).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecTlsBackendClientCertificateRef
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
/// Backend describes TLS configuration for gateway when connecting
/// to backends.
/// 
/// Note that this contains only details for the Gateway as a TLS client,
/// and does _not_ imply behavior about how to choose which backend should
/// get a TLS connection. That is determined by the presence of a BackendTLSPolicy.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecTlsBackend
{
    /// <summary>
    /// ClientCertificateRef references an object that contains a client certificate
    /// and its associated private key. It can reference standard Kubernetes resources,
    /// i.e., Secret, or implementation-specific custom resources.
    /// 
    /// A ClientCertificateRef is considered invalid if:
    /// 
    /// * It refers to a resource that cannot be resolved (e.g., the referenced resource
    ///   does not exist) or is misconfigured (e.g., a Secret does not contain the keys
    ///   named `tls.crt` and `tls.key`). In this case, the `ResolvedRefs` condition
    ///   on the Gateway MUST be set to False with the Reason `InvalidClientCertificateRef`
    ///   and the Message of the Condition MUST indicate why the reference is invalid.
    /// 
    /// * It refers to a resource in another namespace UNLESS there is a ReferenceGrant
    ///   in the target namespace that allows the certificate to be attached.
    ///   If a ReferenceGrant does not allow this reference, the `ResolvedRefs` condition
    ///   on the Gateway MUST be set to False with the Reason `RefNotPermitted`.
    /// 
    /// Implementations MAY choose to perform further validation of the certificate
    /// content (e.g., checking expiry or enforcing specific formats). In such cases,
    /// an implementation-specific Reason and Message MUST be set.
    /// 
    /// Support: Core - Reference to a Kubernetes TLS Secret (with the type `kubernetes.io/tls`).
    /// Support: Implementation-specific - Other resource kinds or Secrets with a
    /// different type (e.g., `Opaque`).
    /// </summary>
    [JsonPropertyName("clientCertificateRef")]
    public V1GatewaySpecTlsBackendClientCertificateRef? ClientCertificateRef { get; set; }
}

/// <summary>
/// ObjectReference identifies an API object including its namespace.
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
public partial class V1GatewaySpecTlsFrontendDefaultValidationCaCertificateRefs
{
    /// <summary>
    /// Group is the group of the referent. For example, &quot;gateway.networking.k8s.io&quot;.
    /// When set to the empty string, core API group is inferred.
    /// </summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>Kind is kind of the referent. For example &quot;ConfigMap&quot; or &quot;Service&quot;.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

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
/// FrontendValidationMode defines the mode for validating the client certificate.
/// There are two possible modes:
/// 
/// - AllowValidOnly: In this mode, the gateway will accept connections only if
///   the client presents a valid certificate. This certificate must successfully
///   pass validation against the CA certificates specified in `CACertificateRefs`.
/// - AllowInsecureFallback: In this mode, the gateway will accept connections
///   even if the client certificate is not presented or fails verification.
/// 
///   This approach delegates client authorization to the backend and introduce
///   a significant security risk. It should be used in testing environments or
///   on a temporary basis in non-testing environments.
/// 
/// Defaults to AllowValidOnly.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewaySpecTlsFrontendDefaultValidationModeEnum>))]
public enum V1GatewaySpecTlsFrontendDefaultValidationModeEnum
{
    [EnumMember(Value = "AllowValidOnly"), JsonStringEnumMemberName("AllowValidOnly")]
    AllowValidOnly,
    [EnumMember(Value = "AllowInsecureFallback"), JsonStringEnumMemberName("AllowInsecureFallback")]
    AllowInsecureFallback
}

/// <summary>
/// Validation holds configuration information for validating the frontend (client).
/// Setting this field will result in mutual authentication when connecting to the gateway.
/// In browsers this may result in a dialog appearing
/// that requests a user to specify the client certificate.
/// The maximum depth of a certificate chain accepted in verification is Implementation specific.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecTlsFrontendDefaultValidation
{
    /// <summary>
    /// CACertificateRefs contains one or more references to Kubernetes
    /// objects that contain a PEM-encoded TLS CA certificate bundle, which
    /// is used as a trust anchor to validate the certificates presented by
    /// the client.
    /// 
    /// A CACertificateRef is invalid if:
    /// 
    /// * It refers to a resource that cannot be resolved (e.g., the
    ///   referenced resource does not exist) or is misconfigured (e.g., a
    ///   ConfigMap does not contain a key named `ca.crt`). In this case, the
    ///   Reason on all matching HTTPS listeners must be set to `InvalidCACertificateRef`
    ///   and the Message of the Condition must indicate which reference is invalid and why.
    /// 
    /// * It refers to an unknown or unsupported kind of resource. In this
    ///   case, the Reason on all matching HTTPS listeners must be set to
    ///   `InvalidCACertificateKind` and the Message of the Condition must explain
    ///   which kind of resource is unknown or unsupported.
    /// 
    /// * It refers to a resource in another namespace UNLESS there is a
    ///   ReferenceGrant in the target namespace that allows the CA
    ///   certificate to be attached. If a ReferenceGrant does not allow this
    ///   reference, the `ResolvedRefs` on all matching HTTPS listeners condition
    ///   MUST be set with the Reason `RefNotPermitted`.
    /// 
    /// Implementations MAY choose to perform further validation of the
    /// certificate content (e.g., checking expiry or enforcing specific formats).
    /// In such cases, an implementation-specific Reason and Message MUST be set.
    /// 
    /// In all cases, the implementation MUST ensure that the `ResolvedRefs`
    /// condition is set to `status: False` on all targeted listeners (i.e.,
    /// listeners serving HTTPS on a matching port). The condition MUST
    /// include a Reason and Message that indicate the cause of the error. If
    /// ALL CACertificateRefs are invalid, the implementation MUST also ensure
    /// the `Accepted` condition on the listener is set to `status: False`, with
    /// the Reason `NoValidCACertificate`.
    /// Implementations MAY choose to support attaching multiple CA certificates
    /// to a listener, but this behavior is implementation-specific.
    /// 
    /// Support: Core - A single reference to a Kubernetes ConfigMap, with the
    /// CA certificate in a key named `ca.crt`.
    /// 
    /// Support: Implementation-specific - More than one reference, other kinds
    /// of resources, or a single reference that includes multiple certificates.
    /// </summary>
    [JsonPropertyName("caCertificateRefs")]
    public required IList<V1GatewaySpecTlsFrontendDefaultValidationCaCertificateRefs> CaCertificateRefs { get; set; }

    /// <summary>
    /// FrontendValidationMode defines the mode for validating the client certificate.
    /// There are two possible modes:
    /// 
    /// - AllowValidOnly: In this mode, the gateway will accept connections only if
    ///   the client presents a valid certificate. This certificate must successfully
    ///   pass validation against the CA certificates specified in `CACertificateRefs`.
    /// - AllowInsecureFallback: In this mode, the gateway will accept connections
    ///   even if the client certificate is not presented or fails verification.
    /// 
    ///   This approach delegates client authorization to the backend and introduce
    ///   a significant security risk. It should be used in testing environments or
    ///   on a temporary basis in non-testing environments.
    /// 
    /// Defaults to AllowValidOnly.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("mode")]
    public V1GatewaySpecTlsFrontendDefaultValidationModeEnum? Mode { get; set; }
}

/// <summary>
/// Default specifies the default client certificate validation configuration
/// for all Listeners handling HTTPS traffic, unless a per-port configuration
/// is defined.
/// 
/// support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecTlsFrontendDefault
{
    /// <summary>
    /// Validation holds configuration information for validating the frontend (client).
    /// Setting this field will result in mutual authentication when connecting to the gateway.
    /// In browsers this may result in a dialog appearing
    /// that requests a user to specify the client certificate.
    /// The maximum depth of a certificate chain accepted in verification is Implementation specific.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("validation")]
    public V1GatewaySpecTlsFrontendDefaultValidation? Validation { get; set; }
}

/// <summary>
/// ObjectReference identifies an API object including its namespace.
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
public partial class V1GatewaySpecTlsFrontendPerPortTlsValidationCaCertificateRefs
{
    /// <summary>
    /// Group is the group of the referent. For example, &quot;gateway.networking.k8s.io&quot;.
    /// When set to the empty string, core API group is inferred.
    /// </summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>Kind is kind of the referent. For example &quot;ConfigMap&quot; or &quot;Service&quot;.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

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
/// FrontendValidationMode defines the mode for validating the client certificate.
/// There are two possible modes:
/// 
/// - AllowValidOnly: In this mode, the gateway will accept connections only if
///   the client presents a valid certificate. This certificate must successfully
///   pass validation against the CA certificates specified in `CACertificateRefs`.
/// - AllowInsecureFallback: In this mode, the gateway will accept connections
///   even if the client certificate is not presented or fails verification.
/// 
///   This approach delegates client authorization to the backend and introduce
///   a significant security risk. It should be used in testing environments or
///   on a temporary basis in non-testing environments.
/// 
/// Defaults to AllowValidOnly.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewaySpecTlsFrontendPerPortTlsValidationModeEnum>))]
public enum V1GatewaySpecTlsFrontendPerPortTlsValidationModeEnum
{
    [EnumMember(Value = "AllowValidOnly"), JsonStringEnumMemberName("AllowValidOnly")]
    AllowValidOnly,
    [EnumMember(Value = "AllowInsecureFallback"), JsonStringEnumMemberName("AllowInsecureFallback")]
    AllowInsecureFallback
}

/// <summary>
/// Validation holds configuration information for validating the frontend (client).
/// Setting this field will result in mutual authentication when connecting to the gateway.
/// In browsers this may result in a dialog appearing
/// that requests a user to specify the client certificate.
/// The maximum depth of a certificate chain accepted in verification is Implementation specific.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecTlsFrontendPerPortTlsValidation
{
    /// <summary>
    /// CACertificateRefs contains one or more references to Kubernetes
    /// objects that contain a PEM-encoded TLS CA certificate bundle, which
    /// is used as a trust anchor to validate the certificates presented by
    /// the client.
    /// 
    /// A CACertificateRef is invalid if:
    /// 
    /// * It refers to a resource that cannot be resolved (e.g., the
    ///   referenced resource does not exist) or is misconfigured (e.g., a
    ///   ConfigMap does not contain a key named `ca.crt`). In this case, the
    ///   Reason on all matching HTTPS listeners must be set to `InvalidCACertificateRef`
    ///   and the Message of the Condition must indicate which reference is invalid and why.
    /// 
    /// * It refers to an unknown or unsupported kind of resource. In this
    ///   case, the Reason on all matching HTTPS listeners must be set to
    ///   `InvalidCACertificateKind` and the Message of the Condition must explain
    ///   which kind of resource is unknown or unsupported.
    /// 
    /// * It refers to a resource in another namespace UNLESS there is a
    ///   ReferenceGrant in the target namespace that allows the CA
    ///   certificate to be attached. If a ReferenceGrant does not allow this
    ///   reference, the `ResolvedRefs` on all matching HTTPS listeners condition
    ///   MUST be set with the Reason `RefNotPermitted`.
    /// 
    /// Implementations MAY choose to perform further validation of the
    /// certificate content (e.g., checking expiry or enforcing specific formats).
    /// In such cases, an implementation-specific Reason and Message MUST be set.
    /// 
    /// In all cases, the implementation MUST ensure that the `ResolvedRefs`
    /// condition is set to `status: False` on all targeted listeners (i.e.,
    /// listeners serving HTTPS on a matching port). The condition MUST
    /// include a Reason and Message that indicate the cause of the error. If
    /// ALL CACertificateRefs are invalid, the implementation MUST also ensure
    /// the `Accepted` condition on the listener is set to `status: False`, with
    /// the Reason `NoValidCACertificate`.
    /// Implementations MAY choose to support attaching multiple CA certificates
    /// to a listener, but this behavior is implementation-specific.
    /// 
    /// Support: Core - A single reference to a Kubernetes ConfigMap, with the
    /// CA certificate in a key named `ca.crt`.
    /// 
    /// Support: Implementation-specific - More than one reference, other kinds
    /// of resources, or a single reference that includes multiple certificates.
    /// </summary>
    [JsonPropertyName("caCertificateRefs")]
    public required IList<V1GatewaySpecTlsFrontendPerPortTlsValidationCaCertificateRefs> CaCertificateRefs { get; set; }

    /// <summary>
    /// FrontendValidationMode defines the mode for validating the client certificate.
    /// There are two possible modes:
    /// 
    /// - AllowValidOnly: In this mode, the gateway will accept connections only if
    ///   the client presents a valid certificate. This certificate must successfully
    ///   pass validation against the CA certificates specified in `CACertificateRefs`.
    /// - AllowInsecureFallback: In this mode, the gateway will accept connections
    ///   even if the client certificate is not presented or fails verification.
    /// 
    ///   This approach delegates client authorization to the backend and introduce
    ///   a significant security risk. It should be used in testing environments or
    ///   on a temporary basis in non-testing environments.
    /// 
    /// Defaults to AllowValidOnly.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("mode")]
    public V1GatewaySpecTlsFrontendPerPortTlsValidationModeEnum? Mode { get; set; }
}

/// <summary>
/// TLS store the configuration that will be applied to all Listeners handling
/// HTTPS traffic and matching given port.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecTlsFrontendPerPortTls
{
    /// <summary>
    /// Validation holds configuration information for validating the frontend (client).
    /// Setting this field will result in mutual authentication when connecting to the gateway.
    /// In browsers this may result in a dialog appearing
    /// that requests a user to specify the client certificate.
    /// The maximum depth of a certificate chain accepted in verification is Implementation specific.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("validation")]
    public V1GatewaySpecTlsFrontendPerPortTlsValidation? Validation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecTlsFrontendPerPort
{
    /// <summary>
    /// The Port indicates the Port Number to which the TLS configuration will be
    /// applied. This configuration will be applied to all Listeners handling HTTPS
    /// traffic that match this port.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>
    /// TLS store the configuration that will be applied to all Listeners handling
    /// HTTPS traffic and matching given port.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("tls")]
    public required V1GatewaySpecTlsFrontendPerPortTls Tls { get; set; }
}

/// <summary>
/// Frontend describes TLS config when client connects to Gateway.
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecTlsFrontend
{
    /// <summary>
    /// Default specifies the default client certificate validation configuration
    /// for all Listeners handling HTTPS traffic, unless a per-port configuration
    /// is defined.
    /// 
    /// support: Core
    /// </summary>
    [JsonPropertyName("default")]
    public required V1GatewaySpecTlsFrontendDefault Default { get; set; }

    /// <summary>
    /// PerPort specifies tls configuration assigned per port.
    /// Per port configuration is optional. Once set this configuration overrides
    /// the default configuration for all Listeners handling HTTPS traffic
    /// that match this port.
    /// Each override port requires a unique TLS configuration.
    /// 
    /// support: Core
    /// </summary>
    [JsonPropertyName("perPort")]
    public IList<V1GatewaySpecTlsFrontendPerPort>? PerPort { get; set; }
}

/// <summary>
/// TLS specifies frontend and backend tls configuration for entire gateway.
/// 
/// Support: Extended
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpecTls
{
    /// <summary>
    /// Backend describes TLS configuration for gateway when connecting
    /// to backends.
    /// 
    /// Note that this contains only details for the Gateway as a TLS client,
    /// and does _not_ imply behavior about how to choose which backend should
    /// get a TLS connection. That is determined by the presence of a BackendTLSPolicy.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("backend")]
    public V1GatewaySpecTlsBackend? Backend { get; set; }

    /// <summary>
    /// Frontend describes TLS config when client connects to Gateway.
    /// Support: Core
    /// </summary>
    [JsonPropertyName("frontend")]
    public V1GatewaySpecTlsFrontend? Frontend { get; set; }
}

/// <summary>Spec defines the desired state of Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewaySpec
{
    /// <summary>
    /// Addresses requested for this Gateway. This is optional and behavior can
    /// depend on the implementation. If a value is set in the spec and the
    /// requested address is invalid or unavailable, the implementation MUST
    /// indicate this in an associated entry in GatewayStatus.Conditions.
    /// 
    /// The Addresses field represents a request for the address(es) on the
    /// &quot;outside of the Gateway&quot;, that traffic bound for this Gateway will use.
    /// This could be the IP address or hostname of an external load balancer or
    /// other networking infrastructure, or some other address that traffic will
    /// be sent to.
    /// 
    /// If no Addresses are specified, the implementation MAY schedule the
    /// Gateway in an implementation-specific manner, assigning an appropriate
    /// set of Addresses.
    /// 
    /// The implementation MUST bind all Listeners to every GatewayAddress that
    /// it assigns to the Gateway and add a corresponding entry in
    /// GatewayStatus.Addresses.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("addresses")]
    public IList<V1GatewaySpecAddresses>? Addresses { get; set; }

    /// <summary>
    /// AllowedListeners defines which ListenerSets can be attached to this Gateway.
    /// The default value is to allow no ListenerSets.
    /// </summary>
    [JsonPropertyName("allowedListeners")]
    public V1GatewaySpecAllowedListeners? AllowedListeners { get; set; }

    /// <summary>
    /// GatewayClassName used for this Gateway. This is the name of a
    /// GatewayClass resource.
    /// </summary>
    [JsonPropertyName("gatewayClassName")]
    public required string GatewayClassName { get; set; }

    /// <summary>
    /// Infrastructure defines infrastructure level attributes about this Gateway instance.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("infrastructure")]
    public V1GatewaySpecInfrastructure? Infrastructure { get; set; }

    /// <summary>
    /// Listeners associated with this Gateway. Listeners define
    /// logical endpoints that are bound on this Gateway&apos;s addresses.
    /// At least one Listener MUST be specified.
    /// 
    /// ## Distinct Listeners
    /// 
    /// Each Listener in a set of Listeners (for example, in a single Gateway)
    /// MUST be _distinct_, in that a traffic flow MUST be able to be assigned to
    /// exactly one listener. (This section uses &quot;set of Listeners&quot; rather than
    /// &quot;Listeners in a single Gateway&quot; because implementations MAY merge configuration
    /// from multiple Gateways onto a single data plane, and these rules _also_
    /// apply in that case).
    /// 
    /// Practically, this means that each listener in a set MUST have a unique
    /// combination of Port, Protocol, and, if supported by the protocol, Hostname.
    /// 
    /// Some combinations of port, protocol, and TLS settings are considered
    /// Core support and MUST be supported by implementations based on the objects
    /// they support:
    /// 
    /// HTTPRoute
    /// 
    /// 1. HTTPRoute, Port: 80, Protocol: HTTP
    /// 2. HTTPRoute, Port: 443, Protocol: HTTPS, TLS Mode: Terminate, TLS keypair provided
    /// 
    /// TLSRoute
    /// 
    /// 1. TLSRoute, Port: 443, Protocol: TLS, TLS Mode: Passthrough
    /// 
    /// &quot;Distinct&quot; Listeners have the following property:
    /// 
    /// **The implementation can match inbound requests to a single distinct
    /// Listener**.
    /// 
    /// When multiple Listeners share values for fields (for
    /// example, two Listeners with the same Port value), the implementation
    /// can match requests to only one of the Listeners using other
    /// Listener fields.
    /// 
    /// When multiple listeners have the same value for the Protocol field, then
    /// each of the Listeners with matching Protocol values MUST have different
    /// values for other fields.
    /// 
    /// The set of fields that MUST be different for a Listener differs per protocol.
    /// The following rules define the rules for what fields MUST be considered for
    /// Listeners to be distinct with each protocol currently defined in the
    /// Gateway API spec.
    /// 
    /// The set of listeners that all share a protocol value MUST have _different_
    /// values for _at least one_ of these fields to be distinct:
    /// 
    /// * **HTTP, HTTPS, TLS**: Port, Hostname
    /// * **TCP, UDP**: Port
    /// 
    /// One **very** important rule to call out involves what happens when an
    /// implementation:
    /// 
    /// * Supports TCP protocol Listeners, as well as HTTP, HTTPS, or TLS protocol
    ///   Listeners, and
    /// * sees HTTP, HTTPS, or TLS protocols with the same `port` as one with TCP
    ///   Protocol.
    /// 
    /// In this case all the Listeners that share a port with the
    /// TCP Listener are not distinct and so MUST NOT be accepted.
    /// 
    /// If an implementation does not support TCP Protocol Listeners, then the
    /// previous rule does not apply, and the TCP Listeners SHOULD NOT be
    /// accepted.
    /// 
    /// Note that the `tls` field is not used for determining if a listener is distinct, because
    /// Listeners that _only_ differ on TLS config will still conflict in all cases.
    /// 
    /// ### Listeners that are distinct only by Hostname
    /// 
    /// When the Listeners are distinct based only on Hostname, inbound request
    /// hostnames MUST match from the most specific to least specific Hostname
    /// values to choose the correct Listener and its associated set of Routes.
    /// 
    /// Exact matches MUST be processed before wildcard matches, and wildcard
    /// matches MUST be processed before fallback (empty Hostname value)
    /// matches. For example, `&quot;foo.example.com&quot;` takes precedence over
    /// `&quot;*.example.com&quot;`, and `&quot;*.example.com&quot;` takes precedence over `&quot; &quot;`.
    /// 
    /// Additionally, if there are multiple wildcard entries, more specific
    /// wildcard entries must be processed before less specific wildcard entries.
    /// For example, `&quot;*.foo.example.com&quot;` takes precedence over `&quot;*.example.com&quot;`.
    /// 
    /// The precise definition here is that the higher the number of dots in the
    /// hostname to the right of the wildcard character, the higher the precedence.
    /// 
    /// The wildcard character will match any number of characters _and dots_ to
    /// the left, however, so `&quot;*.example.com&quot;` will match both
    /// `&quot;foo.bar.example.com&quot;` _and_ `&quot;bar.example.com&quot;`.
    /// 
    /// ## Handling indistinct Listeners
    /// 
    /// If a set of Listeners contains Listeners that are not distinct, then those
    /// Listeners are _Conflicted_, and the implementation MUST set the &quot;Conflicted&quot;
    /// condition in the Listener Status to &quot;True&quot;.
    /// 
    /// The words &quot;indistinct&quot; and &quot;conflicted&quot; are considered equivalent for the
    /// purpose of this documentation.
    /// 
    /// Implementations MAY choose to accept a Gateway with some Conflicted
    /// Listeners only if they only accept the partial Listener set that contains
    /// no Conflicted Listeners.
    /// 
    /// Specifically, an implementation MAY accept a partial Listener set subject to
    /// the following rules:
    /// 
    /// * The implementation MUST NOT pick one conflicting Listener as the winner.
    ///   ALL indistinct Listeners must not be accepted for processing.
    /// * At least one distinct Listener MUST be present, or else the Gateway effectively
    ///   contains _no_ Listeners, and must be rejected from processing as a whole.
    /// 
    /// The implementation MUST set a &quot;ListenersNotValid&quot; condition on the
    /// Gateway Status when the Gateway contains Conflicted Listeners whether or
    /// not they accept the Gateway. That Condition SHOULD clearly
    /// indicate in the Message which Listeners are conflicted, and which are
    /// Accepted. Additionally, the Listener status for those listeners SHOULD
    /// indicate which Listeners are conflicted and not Accepted.
    /// 
    /// ## General Listener behavior
    /// 
    /// Note that, for all distinct Listeners, requests SHOULD match at most one Listener.
    /// For example, if Listeners are defined for &quot;foo.example.com&quot; and &quot;*.example.com&quot;, a
    /// request to &quot;foo.example.com&quot; SHOULD only be routed using routes attached
    /// to the &quot;foo.example.com&quot; Listener (and not the &quot;*.example.com&quot; Listener).
    /// 
    /// If traffic to a Gateway does not match any Listener&apos;s hostname (or if
    /// the Listener does not specify a hostname and the request does not match
    /// any attached Route), the request MUST be rejected. The specific mechanism
    /// for rejection depends on the protocol: HTTP returns a 404 status code,
    /// while gRPC returns an Unimplemented status code.
    /// 
    /// This concept is known as &quot;Listener Isolation&quot;, and it is an Extended feature
    /// of Gateway API. Implementations that do not support Listener Isolation MUST
    /// clearly document this, and MUST NOT claim support for the
    /// `GatewayHTTPListenerIsolation` feature.
    /// 
    /// Implementations that _do_ support Listener Isolation SHOULD claim support
    /// for the Extended `GatewayHTTPListenerIsolation` feature and pass the associated
    /// conformance tests.
    /// 
    /// ## Compatible Listeners
    /// 
    /// A Gateway&apos;s Listeners are considered _compatible_ if:
    /// 
    /// 1. They are distinct.
    /// 2. The implementation can serve them in compliance with the Addresses
    ///    requirement that all Listeners are available on all assigned
    ///    addresses.
    /// 
    /// Compatible combinations in Extended support are expected to vary across
    /// implementations. A combination that is compatible for one implementation
    /// may not be compatible for another.
    /// 
    /// For example, an implementation that cannot serve both TCP and UDP listeners
    /// on the same address, or cannot mix HTTPS and generic TLS listens on the same port
    /// would not consider those cases compatible, even though they are distinct.
    /// 
    /// Implementations MAY merge separate Gateways onto a single set of
    /// Addresses if all Listeners across all Gateways are compatible.
    /// 
    /// In a future release the MinItems=1 requirement MAY be dropped.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("listeners")]
    public required IList<V1GatewaySpecListeners> Listeners { get; set; }

    /// <summary>
    /// TLS specifies frontend and backend tls configuration for entire gateway.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("tls")]
    public V1GatewaySpecTls? Tls { get; set; }
}

/// <summary>GatewayStatusAddress describes a network address that is bound to a Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayStatusAddresses
{
    /// <summary>Type of the address.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Value of the address. The validity of the values will depend
    /// on the type and support by the controller.
    /// 
    /// Examples: `1.2.3.4`, `128::1`, `my-ip-address`.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewayStatusConditionsStatusEnum>))]
public enum V1GatewayStatusConditionsStatusEnum
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
public partial class V1GatewayStatusConditions
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
    public required V1GatewayStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1GatewayStatusListenersConditionsStatusEnum>))]
public enum V1GatewayStatusListenersConditionsStatusEnum
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
public partial class V1GatewayStatusListenersConditions
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
    public required V1GatewayStatusListenersConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>RouteGroupKind indicates the group and kind of a Route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayStatusListenersSupportedKinds
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
public partial class V1GatewayStatusListeners
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
    /// Route kinds ParentRefs fields). Listener or Route status does not impact
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
    public required IList<V1GatewayStatusListenersConditions> Conditions { get; set; }

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
    public IList<V1GatewayStatusListenersSupportedKinds>? SupportedKinds { get; set; }
}

/// <summary>Status defines the current state of Gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1GatewayStatus
{
    /// <summary>
    /// Addresses lists the network addresses that have been bound to the
    /// Gateway.
    /// 
    /// This list may differ from the addresses provided in the spec under some
    /// conditions:
    /// 
    ///   * no addresses are specified, all addresses are dynamically assigned
    ///   * a combination of specified and dynamic addresses are assigned
    ///   * a specified address was unusable (e.g. already in use)
    /// </summary>
    [JsonPropertyName("addresses")]
    public IList<V1GatewayStatusAddresses>? Addresses { get; set; }

    /// <summary>
    /// AttachedListenerSets represents the total number of ListenerSets that have been
    /// successfully attached to this Gateway.
    /// 
    /// A ListenerSet is successfully attached to a Gateway when all the following conditions are met:
    /// - The ListenerSet is selected by the Gateway&apos;s AllowedListeners field
    /// - The ListenerSet has a valid ParentRef selecting the Gateway
    /// - The ListenerSet&apos;s status has the condition &quot;Accepted: true&quot;
    /// 
    /// Uses for this field include troubleshooting AttachedListenerSets attachment and
    /// measuring blast radius/impact of changes to a Gateway.
    /// </summary>
    [JsonPropertyName("attachedListenerSets")]
    public int? AttachedListenerSets { get; set; }

    /// <summary>
    /// Conditions describe the current conditions of the Gateway.
    /// 
    /// Implementations should prefer to express Gateway conditions
    /// using the `GatewayConditionType` and `GatewayConditionReason`
    /// constants so that operators and tools can converge on a common
    /// vocabulary to describe Gateway state.
    /// 
    /// Known condition types are:
    /// 
    /// * &quot;Accepted&quot;
    /// * &quot;Programmed&quot;
    /// * &quot;Ready&quot;
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1GatewayStatusConditions>? Conditions { get; set; }

    /// <summary>Listeners provide status for each unique listener port defined in the Spec.</summary>
    [JsonPropertyName("listeners")]
    public IList<V1GatewayStatusListeners>? Listeners { get; set; }
}

/// <summary>
/// Gateway represents an instance of a service-traffic handling infrastructure
/// by binding Listeners to a set of IP addresses.
/// A Gateway name SHOULD be compliant with RFC 1035, consisting of a maximum of 63 lower case alphanumeric
/// characters or hyphens (&apos;-&apos;), and MUST start and end with an alphanumeric character.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Gateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1GatewaySpec>, IStatus<V1GatewayStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Gateway";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "gateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Gateway";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of Gateway.</summary>
    [JsonPropertyName("spec")]
    public required V1GatewaySpec Spec { get; set; }

    /// <summary>Status defines the current state of Gateway.</summary>
    [JsonPropertyName("status")]
    public V1GatewayStatus? Status { get; set; }
}