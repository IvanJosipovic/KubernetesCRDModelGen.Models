#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.autoscaling.@internal.knative.dev;
/// <summary>Metric represents a resource to configure the metric collector with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetricList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Metric>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetricList";
    public const string KubeGroup = "autoscaling.internal.knative.dev";
    public const string KubePluralName = "metrics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "autoscaling.internal.knative.dev/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Metric objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Metric> Items { get; set; }
}

/// <summary>Spec holds the desired state of the Metric (from the client).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricSpec
{
    /// <summary>PanicWindow is the aggregation window for metrics where quick reactions are needed.</summary>
    [JsonPropertyName("panicWindow")]
    public required long PanicWindow { get; set; }

    /// <summary>ScrapeTarget is the K8s service that publishes the metric endpoint.</summary>
    [JsonPropertyName("scrapeTarget")]
    public required string ScrapeTarget { get; set; }

    /// <summary>StableWindow is the aggregation window for metrics in a stable state.</summary>
    [JsonPropertyName("stableWindow")]
    public required long StableWindow { get; set; }
}

/// <summary>
/// Condition defines a readiness condition for a Knative resource.
/// See: https://github.com/kubernetes/community/blob/master/contributors/devel/sig-architecture/api-conventions.md#typical-status-properties
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time the condition transitioned from one status to another.
    /// We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic
    /// differences (all other things held constant).
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// When this is not specified, it defaults to Error.
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Status communicates the observed state of the Metric (from the controller).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricStatus
{
    /// <summary>
    /// Annotations is additional Status fields for the Resource to save some
    /// additional State as well as convey more information to the user. This is
    /// roughly akin to Annotations on any k8s resource, just the reconciler conveying
    /// richer information outwards.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Conditions the latest available observations of a resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MetricStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the &apos;Generation&apos; of the Service that
    /// was last processed by the controller.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Metric represents a resource to configure the metric collector with.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Metric : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MetricSpec?>, IStatus<V1alpha1MetricStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Metric";
    public const string KubeGroup = "autoscaling.internal.knative.dev";
    public const string KubePluralName = "metrics";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "autoscaling.internal.knative.dev/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Metric";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec holds the desired state of the Metric (from the client).</summary>
    [JsonPropertyName("spec")]
    public V1alpha1MetricSpec? Spec { get; set; }

    /// <summary>Status communicates the observed state of the Metric (from the controller).</summary>
    [JsonPropertyName("status")]
    public V1alpha1MetricStatus? Status { get; set; }
}