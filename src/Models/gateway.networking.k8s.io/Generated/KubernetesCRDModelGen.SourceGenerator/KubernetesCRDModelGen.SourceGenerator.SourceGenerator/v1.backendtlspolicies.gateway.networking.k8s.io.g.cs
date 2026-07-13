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
/// BackendTLSPolicy provides a way to configure how a Gateway
/// connects to a Backend via TLS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BackendTLSPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1BackendTLSPolicy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BackendTLSPolicyList";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "backendtlspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackendTLSPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1BackendTLSPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1BackendTLSPolicy> Items { get; set; }
}

/// <summary>
/// LocalPolicyTargetReferenceWithSectionName identifies an API object to apply a
/// direct policy to. This should be used as part of Policy resources that can
/// target single resources. For more information on how this policy attachment
/// mode works, and a sample Policy resource, refer to the policy attachment
/// documentation for Gateway API.
/// 
/// Note: This should only be used for direct policy attachment when references
/// to SectionName are actually needed. In all other cases,
/// LocalPolicyTargetReference should be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackendTLSPolicySpecTargetRefs
{
    /// <summary>Group is the group of the target resource.</summary>
    [JsonPropertyName("group")]
    public required string Group { get; set; }

    /// <summary>Kind is kind of the target resource.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name is the name of the target resource.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// SectionName is the name of a section within the target resource. When
    /// unspecified, this targetRef targets the entire resource. In the following
    /// resources, SectionName is interpreted as the following:
    /// 
    /// * Gateway: Listener name
    /// * HTTPRoute: HTTPRouteRule name
    /// * Service: Port name
    /// 
    /// If a SectionName is specified, but does not exist on the targeted object,
    /// the Policy must fail to attach, and the policy implementation should record
    /// a `ResolvedRefs` or similar Condition in the Policy&apos;s status.
    /// </summary>
    [JsonPropertyName("sectionName")]
    public string? SectionName { get; set; }
}

/// <summary>
/// LocalObjectReference identifies an API object within the namespace of the
/// referrer.
/// The API object must be valid in the cluster; the Group and Kind must
/// be registered in the cluster for this reference to be valid.
/// 
/// References to objects with invalid Group and Kind are not valid, and must
/// be rejected by the implementation, with appropriate Conditions set
/// on the containing object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackendTLSPolicySpecValidationCaCertificateRefs
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

/// <summary>
/// Type determines the format of the Subject Alternative Name. Always required.
/// 
/// Support: Core
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BackendTLSPolicySpecValidationSubjectAltNamesTypeEnum>))]
public enum V1BackendTLSPolicySpecValidationSubjectAltNamesTypeEnum
{
    [EnumMember(Value = "Hostname"), JsonStringEnumMemberName("Hostname")]
    Hostname,
    [EnumMember(Value = "URI"), JsonStringEnumMemberName("URI")]
    URI
}

/// <summary>SubjectAltName represents Subject Alternative Name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackendTLSPolicySpecValidationSubjectAltNames
{
    /// <summary>
    /// Hostname contains Subject Alternative Name specified in DNS name format.
    /// Required when Type is set to Hostname, ignored otherwise.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>
    /// Type determines the format of the Subject Alternative Name. Always required.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("type")]
    public required V1BackendTLSPolicySpecValidationSubjectAltNamesTypeEnum Type { get; set; }

    /// <summary>
    /// URI contains Subject Alternative Name specified in a full URI format.
    /// It MUST include both a scheme (e.g., &quot;http&quot; or &quot;ftp&quot;) and a scheme-specific-part.
    /// Common values include SPIFFE IDs like &quot;spiffe://mycluster.example.com/ns/myns/sa/svc1sa&quot;.
    /// Required when Type is set to URI, ignored otherwise.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Validation contains backend TLS validation configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackendTLSPolicySpecValidation
{
    /// <summary>
    /// CACertificateRefs contains one or more references to Kubernetes objects that
    /// contain a PEM-encoded TLS CA certificate bundle, which is used to
    /// validate a TLS handshake between the Gateway and backend Pod.
    /// 
    /// If CACertificateRefs is empty or unspecified, then WellKnownCACertificates must be
    /// specified. Only one of CACertificateRefs or WellKnownCACertificates may be specified,
    /// not both. If CACertificateRefs is empty or unspecified, the configuration for
    /// WellKnownCACertificates MUST be honored instead if supported by the implementation.
    /// 
    /// A CACertificateRef is invalid if:
    /// 
    /// * It refers to a resource that cannot be resolved (e.g., the referenced resource
    ///   does not exist) or is misconfigured (e.g., a ConfigMap does not contain a key
    ///   named `ca.crt`). In this case, the Reason must be set to `InvalidCACertificateRef`
    ///   and the Message of the Condition must indicate which reference is invalid and why.
    /// 
    /// * It refers to an unknown or unsupported kind of resource. In this case, the Reason
    ///   must be set to `InvalidKind` and the Message of the Condition must explain which
    ///   kind of resource is unknown or unsupported.
    /// 
    /// * It refers to a resource in another namespace. This may change in future
    ///   spec updates.
    /// 
    /// Implementations MAY choose to perform further validation of the certificate
    /// content (e.g., checking expiry or enforcing specific formats). In such cases,
    /// an implementation-specific Reason and Message must be set for the invalid reference.
    /// 
    /// In all cases, the implementation MUST ensure the `ResolvedRefs` Condition on
    /// the BackendTLSPolicy is set to `status: False`, with a Reason and Message
    /// that indicate the cause of the error. Connections using an invalid
    /// CACertificateRef MUST fail, and the client MUST receive an HTTP 5xx error
    /// response. If ALL CACertificateRefs are invalid, the implementation MUST also
    /// ensure the `Accepted` Condition on the BackendTLSPolicy is set to
    /// `status: False`, with a Reason `NoValidCACertificate`.
    /// 
    /// A single CACertificateRef to a Kubernetes ConfigMap kind has &quot;Core&quot; support.
    /// Implementations MAY choose to support attaching multiple certificates to
    /// a backend, but this behavior is implementation-specific.
    /// 
    /// Support: Core - An optional single reference to a Kubernetes ConfigMap,
    /// with the CA certificate in a key named `ca.crt`.
    /// 
    /// Support: Implementation-specific - More than one reference, other kinds
    /// of resources, or a single reference that includes multiple certificates.
    /// </summary>
    [JsonPropertyName("caCertificateRefs")]
    public IList<V1BackendTLSPolicySpecValidationCaCertificateRefs>? CaCertificateRefs { get; set; }

    /// <summary>
    /// Hostname is used for two purposes in the connection between Gateways and
    /// backends:
    /// 
    /// 1. Hostname MUST be used as the SNI to connect to the backend (RFC 6066).
    /// 2. Hostname MUST be used for authentication and MUST match the certificate
    ///    served by the matching backend, unless SubjectAltNames is specified.
    /// 3. If SubjectAltNames are specified, Hostname can be used for certificate selection
    ///    but MUST NOT be used for authentication. If you want to use the value
    ///    of the Hostname field for authentication, you MUST add it to the SubjectAltNames list.
    /// 
    /// Support: Core
    /// </summary>
    [JsonPropertyName("hostname")]
    public required string Hostname { get; set; }

    /// <summary>
    /// SubjectAltNames contains one or more Subject Alternative Names.
    /// When specified the certificate served from the backend MUST
    /// have at least one Subject Alternate Name matching one of the specified SubjectAltNames.
    /// 
    /// Support: Extended
    /// </summary>
    [JsonPropertyName("subjectAltNames")]
    public IList<V1BackendTLSPolicySpecValidationSubjectAltNames>? SubjectAltNames { get; set; }

    /// <summary>
    /// WellKnownCACertificates specifies whether a well-known set of CA certificates
    /// may be used in the TLS handshake between the gateway and backend pod.
    /// 
    /// If WellKnownCACertificates is unspecified or empty (&quot; &quot;), then CACertificateRefs
    /// must be specified with at least one entry for a valid configuration. Only one of
    /// CACertificateRefs or WellKnownCACertificates may be specified, not both.
    /// If an implementation does not support the WellKnownCACertificates field, or
    /// the supplied value is not recognized, the implementation MUST ensure the
    /// `Accepted` Condition on the BackendTLSPolicy is set to `status: False`, with
    /// a Reason `Invalid`.
    /// 
    /// Valid values include:
    /// * &quot;System&quot; - indicates that well-known system CA certificates should be used.
    /// 
    /// Implementations MAY define their own sets of CA certificates. Such definitions
    /// MUST use an implementation-specific, prefixed name, such as
    /// `mycompany.com/my-custom-ca-certificates`.
    /// 
    /// Support: Implementation-specific
    /// </summary>
    [JsonPropertyName("wellKnownCACertificates")]
    public string? WellKnownCACertificates { get; set; }
}

/// <summary>Spec defines the desired state of BackendTLSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackendTLSPolicySpec
{
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

    /// <summary>
    /// TargetRefs identifies an API object to apply the policy to.
    /// Note that this config applies to the entire referenced resource
    /// by default, but this default may change in the future to provide
    /// a more granular application of the policy.
    /// 
    /// TargetRefs must be _distinct_. This means either that:
    /// 
    /// * They select different targets. If this is the case, then targetRef
    ///   entries are distinct. In terms of fields, this means that the
    ///   multi-part key defined by `group`, `kind`, and `name` must
    ///   be unique across all targetRef entries in the BackendTLSPolicy.
    /// * They select different sectionNames in the same target.
    /// 
    /// When more than one BackendTLSPolicy selects the same target and
    /// sectionName, implementations MUST determine precedence using the
    /// following criteria, continuing on ties:
    /// 
    /// * The older policy by creation timestamp takes precedence. For
    ///   example, a policy with a creation timestamp of &quot;2021-07-15
    ///   01:02:03&quot; MUST be given precedence over a policy with a
    ///   creation timestamp of &quot;2021-07-15 01:02:04&quot;.
    /// * The policy appearing first in alphabetical order by {namespace}/{name}.
    ///   For example, a policy named `foo/bar` is given precedence over a
    ///   policy named `foo/baz`.
    /// 
    /// For any BackendTLSPolicy that does not take precedence, the
    /// implementation MUST ensure the `Accepted` Condition is set to
    /// `status: False`, with Reason `Conflicted`.
    /// 
    /// Implementations SHOULD NOT support more than one targetRef at this
    /// time. Although the API technically allows for this, the current guidance
    /// for conflict resolution and status handling is lacking. Until that can be
    /// clarified in a future release, the safest approach is to support a single
    /// targetRef.
    /// 
    /// Support Levels:
    /// 
    /// * Extended: Kubernetes Service referenced by backendRefs used on a Route.
    ///   - HTTPRoute, GRPCRoute, TLSRoute with termination
    ///   - Filters that needs a backend of type Service, like Mirror and External Authorization
    /// 
    /// * Implementation-Specific: Implementations MAY use BackendTLSPolicy for:
    ///   - Services not referenced by any Route (e.g., infrastructure services)
    ///   - Service mesh workload-to-service communication
    ///   - Other resource types beyond Service
    /// 
    /// Implementations SHOULD aim to ensure that BackendTLSPolicy behavior is consistent,
    /// even outside of the extended HTTPRoute -(backendRef) -&gt; Service path.
    /// They SHOULD clearly document how BackendTLSPolicy is interpreted in these
    /// scenarios, including:
    ///   - Which resources beyond Service are supported
    ///   - How the policy is discovered and applied
    ///   - Any implementation-specific semantics or restrictions
    /// 
    /// Note that this config applies to the entire referenced resource
    /// by default, but this default may change in the future to provide
    /// a more granular application of the policy.
    /// </summary>
    [JsonPropertyName("targetRefs")]
    public required IList<V1BackendTLSPolicySpecTargetRefs> TargetRefs { get; set; }

    /// <summary>Validation contains backend TLS validation configuration.</summary>
    [JsonPropertyName("validation")]
    public required V1BackendTLSPolicySpecValidation Validation { get; set; }
}

/// <summary>
/// AncestorRef corresponds with a ParentRef in the spec that this
/// PolicyAncestorStatus struct describes the status of.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackendTLSPolicyStatusAncestorsAncestorRef
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

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1BackendTLSPolicyStatusAncestorsConditionsStatusEnum>))]
public enum V1BackendTLSPolicyStatusAncestorsConditionsStatusEnum
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
public partial class V1BackendTLSPolicyStatusAncestorsConditions
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
    public required V1BackendTLSPolicyStatusAncestorsConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// PolicyAncestorStatus describes the status of a route with respect to an
/// associated Ancestor.
/// 
/// Ancestors refer to objects that are either the Target of a policy or above it
/// in terms of object hierarchy. For example, if a policy targets a Service, the
/// Policy&apos;s Ancestors are, in order, the Service, the HTTPRoute, the Gateway, and
/// the GatewayClass. Almost always, in this hierarchy, the Gateway will be the most
/// useful object to place Policy status on, so we recommend that implementations
/// SHOULD use Gateway as the PolicyAncestorStatus object unless the designers
/// have a _very_ good reason otherwise.
/// 
/// In the context of policy attachment, the Ancestor is used to distinguish which
/// resource results in a distinct application of this policy. For example, if a policy
/// targets a Service, it may have a distinct result per attached Gateway.
/// 
/// Policies targeting the same resource may have different effects depending on the
/// ancestors of those resources. For example, different Gateways targeting the same
/// Service may have different capabilities, especially if they have different underlying
/// implementations.
/// 
/// For example, in BackendTLSPolicy, the Policy attaches to a Service that is
/// used as a backend in a HTTPRoute that is itself attached to a Gateway.
/// In this case, the relevant object for status is the Gateway, and that is the
/// ancestor object referred to in this status.
/// 
/// Note that a parent is also an ancestor, so for objects where the parent is the
/// relevant object for status, this struct SHOULD still be used.
/// 
/// This struct is intended to be used in a slice that&apos;s effectively a map,
/// with a composite key made up of the AncestorRef and the ControllerName.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackendTLSPolicyStatusAncestors
{
    /// <summary>
    /// AncestorRef corresponds with a ParentRef in the spec that this
    /// PolicyAncestorStatus struct describes the status of.
    /// </summary>
    [JsonPropertyName("ancestorRef")]
    public required V1BackendTLSPolicyStatusAncestorsAncestorRef AncestorRef { get; set; }

    /// <summary>Conditions describes the status of the Policy with respect to the given Ancestor.</summary>
    [JsonPropertyName("conditions")]
    public required IList<V1BackendTLSPolicyStatusAncestorsConditions> Conditions { get; set; }

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
}

/// <summary>Status defines the current state of BackendTLSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackendTLSPolicyStatus
{
    /// <summary>
    /// Ancestors is a list of ancestor resources (usually Gateways) that are
    /// associated with the policy, and the status of the policy with respect to
    /// each ancestor. When this policy attaches to a parent, the controller that
    /// manages the parent and the ancestors MUST add an entry to this list when
    /// the controller first sees the policy and SHOULD update the entry as
    /// appropriate when the relevant ancestor is modified.
    /// 
    /// Note that choosing the relevant ancestor is left to the Policy designers;
    /// an important part of Policy design is designing the right object level at
    /// which to namespace this status.
    /// 
    /// Note also that implementations MUST ONLY populate ancestor status for
    /// the Ancestor resources they are responsible for. Implementations MUST
    /// use the ControllerName field to uniquely identify the entries in this list
    /// that they are responsible for.
    /// 
    /// Note that to achieve this, the list of PolicyAncestorStatus structs
    /// MUST be treated as a map with a composite key, made up of the AncestorRef
    /// and ControllerName fields combined.
    /// 
    /// A maximum of 16 ancestors will be represented in this list. An empty list
    /// means the Policy is not relevant for any ancestors.
    /// 
    /// If this slice is full, implementations MUST NOT add further entries.
    /// Instead they MUST consider the policy unimplementable and signal that
    /// on any related resources such as the ancestor that would be referenced
    /// here. For example, if this list was full on BackendTLSPolicy, no
    /// additional Gateways would be able to reference the Service targeted by
    /// the BackendTLSPolicy.
    /// </summary>
    [JsonPropertyName("ancestors")]
    public required IList<V1BackendTLSPolicyStatusAncestors> Ancestors { get; set; }
}

/// <summary>
/// BackendTLSPolicy provides a way to configure how a Gateway
/// connects to a Backend via TLS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BackendTLSPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1BackendTLSPolicySpec>, IStatus<V1BackendTLSPolicyStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BackendTLSPolicy";
    public const string KubeGroup = "gateway.networking.k8s.io";
    public const string KubePluralName = "backendtlspolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "gateway.networking.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackendTLSPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of BackendTLSPolicy.</summary>
    [JsonPropertyName("spec")]
    public required V1BackendTLSPolicySpec Spec { get; set; }

    /// <summary>Status defines the current state of BackendTLSPolicy.</summary>
    [JsonPropertyName("status")]
    public V1BackendTLSPolicyStatus? Status { get; set; }
}