#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.multicluster.xk8s.io;
/// <summary>ServiceImport describes a service imported from clusters in a ClusterSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceImportList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ServiceImport>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceImportList";
    public const string KubeGroup = "multicluster.x-k8s.io";
    public const string KubePluralName = "serviceimports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "multicluster.x-k8s.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceImportList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ServiceImport objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ServiceImport> Items { get; set; }
}

/// <summary>ServicePort represents the port on which the service is exposed</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceImportSpecPorts
{
    /// <summary>
    /// The application protocol for this port.
    /// This is used as a hint for implementations to offer richer behavior for protocols that they understand.
    /// This field follows standard Kubernetes label syntax.
    /// Valid values are either:
    /// 
    /// * Un-prefixed protocol names - reserved for IANA standard service names (as per
    /// RFC-6335 and https://www.iana.org/assignments/service-names).
    /// 
    /// * Kubernetes-defined prefixed names:
    ///   * &apos;kubernetes.io/h2c&apos; - HTTP/2 over cleartext as described in https://www.rfc-editor.org/rfc/rfc7540
    /// 
    /// * Other protocols should use implementation-defined prefixed names such as
    /// mycompany.com/my-custom-protocol.
    /// Field can be enabled with ServiceAppProtocol feature gate.
    /// </summary>
    [JsonPropertyName("appProtocol")]
    public string? AppProtocol { get; set; }

    /// <summary>
    /// The name of this port within the service. This must be a DNS_LABEL.
    /// All ports within a ServiceSpec must have unique names. When considering
    /// the endpoints for a Service, this must match the &apos;name&apos; field in the
    /// EndpointPort.
    /// Optional if only one ServicePort is defined on this service.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The port that will be exposed by this service.</summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>
    /// The IP protocol for this port. Supports &quot;TCP&quot;, &quot;UDP&quot;, and &quot;SCTP&quot;.
    /// Default is TCP.
    /// </summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>clientIP contains the configurations of Client IP based session affinity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceImportSpecSessionAffinityConfigClientIP
{
    /// <summary>
    /// timeoutSeconds specifies the seconds of ClientIP type session sticky time.
    /// The value must be &gt;0 &amp; &amp; &lt;=86400(for 1 day) if ServiceAffinity == &quot;ClientIP&quot;.
    /// Default value is 10800(for 3 hours).
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>sessionAffinityConfig contains session affinity configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceImportSpecSessionAffinityConfig
{
    /// <summary>clientIP contains the configurations of Client IP based session affinity.</summary>
    [JsonPropertyName("clientIP")]
    public V1beta1ServiceImportSpecSessionAffinityConfigClientIP? ClientIP { get; set; }
}

/// <summary>
/// type defines the type of this service.
/// Must be ClusterSetIP or Headless.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceImportSpecTypeEnum>))]
public enum V1beta1ServiceImportSpecTypeEnum
{
    [EnumMember(Value = "ClusterSetIP"), JsonStringEnumMemberName("ClusterSetIP")]
    ClusterSetIP,
    [EnumMember(Value = "Headless"), JsonStringEnumMemberName("Headless")]
    Headless
}

/// <summary>spec defines the behavior of a ServiceImport.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceImportSpec
{
    /// <summary>
    /// InternalTrafficPolicy describes how nodes distribute service traffic they
    /// receive on the ClusterIP. If set to &quot;Local&quot;, the proxy will assume that pods
    /// only want to talk to endpoints of the service on the same node as the pod,
    /// dropping the traffic if there are no local endpoints. The default value,
    /// &quot;Cluster&quot;, uses the standard behavior of routing to all endpoints evenly
    /// (possibly modified by topology and other features).
    /// </summary>
    [JsonPropertyName("internalTrafficPolicy")]
    public string? InternalTrafficPolicy { get; set; }

    /// <summary>IPFamilies identifies all the IPFamilies assigned for this ServiceImport.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<string>? IpFamilies { get; set; }

    /// <summary>ip will be used as the VIP for this service when type is ClusterSetIP.</summary>
    [JsonPropertyName("ips")]
    public IList<string>? Ips { get; set; }

    [JsonPropertyName("ports")]
    public required IList<V1beta1ServiceImportSpecPorts> Ports { get; set; }

    /// <summary>
    /// Supports &quot;ClientIP&quot; and &quot;None&quot;. Used to maintain session affinity.
    /// Enable client IP based session affinity.
    /// Must be ClientIP or None.
    /// Defaults to None.
    /// Ignored when type is Headless
    /// More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies
    /// </summary>
    [JsonPropertyName("sessionAffinity")]
    public string? SessionAffinity { get; set; }

    /// <summary>sessionAffinityConfig contains session affinity configuration.</summary>
    [JsonPropertyName("sessionAffinityConfig")]
    public V1beta1ServiceImportSpecSessionAffinityConfig? SessionAffinityConfig { get; set; }

    /// <summary>
    /// TrafficDistribution offers a way to express preferences for how traffic
    /// is distributed to Service endpoints. Implementations can use this field
    /// as a hint, but are not required to guarantee strict adherence. If the
    /// field is not set, the implementation will apply its default routing
    /// strategy. If set to &quot;PreferClose&quot;, implementations should prioritize
    /// endpoints that are in the same zone.
    /// </summary>
    [JsonPropertyName("trafficDistribution")]
    public string? TrafficDistribution { get; set; }

    /// <summary>
    /// type defines the type of this service.
    /// Must be ClusterSetIP or Headless.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1beta1ServiceImportSpecTypeEnum Type { get; set; }
}

/// <summary>ClusterStatus contains service configuration mapped to a specific source cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceImportStatusClusters
{
    /// <summary>
    /// cluster is the name of the exporting cluster. Must be a valid RFC-1123 DNS
    /// label.
    /// </summary>
    [JsonPropertyName("cluster")]
    public required string Cluster { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceImportStatusConditionsStatusEnum>))]
public enum V1beta1ServiceImportStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceImportStatusConditions
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
    public required V1beta1ServiceImportStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// EndpointSliceObjects indicates whether imported EndpointSlice objects are
/// present for this ServiceImport.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServiceImportStatusEndpointSliceObjectsEnum>))]
public enum V1beta1ServiceImportStatusEndpointSliceObjectsEnum
{
    [EnumMember(Value = "Present"), JsonStringEnumMemberName("Present")]
    Present,
    [EnumMember(Value = "Absent"), JsonStringEnumMemberName("Absent")]
    Absent
}

/// <summary>
/// status contains information about the exported services that form
/// the multi-cluster service referenced by this ServiceImport.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ServiceImportStatus
{
    /// <summary>
    /// clusters is the list of exporting clusters from which this service
    /// was derived.
    /// </summary>
    [JsonPropertyName("clusters")]
    public IList<V1beta1ServiceImportStatusClusters>? Clusters { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1beta1ServiceImportStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// EndpointSliceObjects indicates whether imported EndpointSlice objects are
    /// present for this ServiceImport.
    /// </summary>
    [JsonPropertyName("endpointSliceObjects")]
    public V1beta1ServiceImportStatusEndpointSliceObjectsEnum? EndpointSliceObjects { get; set; }
}

/// <summary>ServiceImport describes a service imported from clusters in a ClusterSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceImport : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServiceImportSpec?>, IStatus<V1beta1ServiceImportStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceImport";
    public const string KubeGroup = "multicluster.x-k8s.io";
    public const string KubePluralName = "serviceimports";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "multicluster.x-k8s.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceImport";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>spec defines the behavior of a ServiceImport.</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServiceImportSpec? Spec { get; set; }

    /// <summary>
    /// status contains information about the exported services that form
    /// the multi-cluster service referenced by this ServiceImport.
    /// </summary>
    [JsonPropertyName("status")]
    public V1beta1ServiceImportStatus? Status { get; set; }
}