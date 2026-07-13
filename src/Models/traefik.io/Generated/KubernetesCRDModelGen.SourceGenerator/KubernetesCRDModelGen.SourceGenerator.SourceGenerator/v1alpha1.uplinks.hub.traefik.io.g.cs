#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>
/// Uplink is an inter-cluster service advertisement: a child cluster declares an Uplink to advertise
/// to a parent cluster that it can handle a particular workload.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1UplinkList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Uplink>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "UplinkList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "uplinks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UplinkList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Uplink objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Uplink> Items { get; set; }
}

/// <summary>HealthCheck configures the active health check on the parent cluster for this uplink&apos;s load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UplinkSpecHealthCheck
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

/// <summary>PassiveHealthCheck configures the passive health check on the parent cluster for this uplink&apos;s load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UplinkSpecPassiveHealthCheck
{
    /// <summary>FailureWindow defines the time window during which the failed attempts must occur for the server to be marked as unhealthy. It also defines for how long the server will be considered unhealthy.</summary>
    [JsonPropertyName("failureWindow")]
    public IntOrString? FailureWindow { get; set; }

    /// <summary>MaxFailedAttempts is the number of consecutive failed attempts allowed within the failure window before marking the server as unhealthy.</summary>
    [JsonPropertyName("maxFailedAttempts")]
    public int? MaxFailedAttempts { get; set; }
}

/// <summary>UplinkSpec describes the Uplink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UplinkSpec
{
    /// <summary>EntryPoints references uplinkEntryPoints. When omitted, uses default uplinkEntrypoints.</summary>
    [JsonPropertyName("entryPoints")]
    public IList<string>? EntryPoints { get; set; }

    /// <summary>
    /// ExposeName is the name of the service to expose.
    /// By default it uses &lt;namespace&gt;-&lt;name&gt;.
    /// </summary>
    [JsonPropertyName("exposeName")]
    public string? ExposeName { get; set; }

    /// <summary>HealthCheck configures the active health check on the parent cluster for this uplink&apos;s load balancer.</summary>
    [JsonPropertyName("healthCheck")]
    public V1alpha1UplinkSpecHealthCheck? HealthCheck { get; set; }

    /// <summary>PassiveHealthCheck configures the passive health check on the parent cluster for this uplink&apos;s load balancer.</summary>
    [JsonPropertyName("passiveHealthCheck")]
    public V1alpha1UplinkSpecPassiveHealthCheck? PassiveHealthCheck { get; set; }

    /// <summary>Weight for WRR on the parent.</summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1UplinkStatusConditionsStatusEnum>))]
public enum V1alpha1UplinkStatusConditionsStatusEnum
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
public partial class V1alpha1UplinkStatusConditions
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
    public required V1alpha1UplinkStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>The current status of this Uplink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1UplinkStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1UplinkStatusConditions>? Conditions { get; set; }
}

/// <summary>
/// Uplink is an inter-cluster service advertisement: a child cluster declares an Uplink to advertise
/// to a parent cluster that it can handle a particular workload.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Uplink : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1UplinkSpec?>, IStatus<V1alpha1UplinkStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Uplink";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "uplinks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Uplink";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UplinkSpec describes the Uplink.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1UplinkSpec? Spec { get; set; }

    /// <summary>The current status of this Uplink.</summary>
    [JsonPropertyName("status")]
    public V1alpha1UplinkStatus? Status { get; set; }
}