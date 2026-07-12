#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kargo.akuity.io;
/// <summary>
/// Project is a resource type that reconciles to a specially labeled namespace
/// and other TODO: TBD project-level resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ProjectList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Project>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ProjectList";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "projects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProjectList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Project objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Project> Items { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ProjectStatusConditionsStatusEnum>))]
public enum V1alpha1ProjectStatusConditionsStatusEnum
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
public partial class V1alpha1ProjectStatusConditions
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
    public required V1alpha1ProjectStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Health contains a summary of the collective health of a Project&apos;s Stages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatusStatsStagesHealth
{
    /// <summary>Healthy contains the number of resources that are explicitly healthy.</summary>
    [JsonPropertyName("healthy")]
    public long? Healthy { get; set; }
}

/// <summary>Stages contains a summary of the collective state of the Project&apos;s Stages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatusStatsStages
{
    /// <summary>Count contains the total number of Stages in the Project.</summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    /// <summary>Health contains a summary of the collective health of a Project&apos;s Stages.</summary>
    [JsonPropertyName("health")]
    public V1alpha1ProjectStatusStatsStagesHealth? Health { get; set; }
}

/// <summary>
/// Health contains a summary of the collective health of a Project&apos;s
/// Warehouses.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatusStatsWarehousesHealth
{
    /// <summary>Healthy contains the number of resources that are explicitly healthy.</summary>
    [JsonPropertyName("healthy")]
    public long? Healthy { get; set; }
}

/// <summary>
/// Warehouses contains a summary of the collective state of the Project&apos;s
/// Warehouses.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatusStatsWarehouses
{
    /// <summary>Count contains the total number of Warehouses in the Project.</summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    /// <summary>
    /// Health contains a summary of the collective health of a Project&apos;s
    /// Warehouses.
    /// </summary>
    [JsonPropertyName("health")]
    public V1alpha1ProjectStatusStatsWarehousesHealth? Health { get; set; }
}

/// <summary>
/// Stats contains a summary of the collective state of a Project&apos;s
/// constituent resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatusStats
{
    /// <summary>Stages contains a summary of the collective state of the Project&apos;s Stages.</summary>
    [JsonPropertyName("stages")]
    public V1alpha1ProjectStatusStatsStages? Stages { get; set; }

    /// <summary>
    /// Warehouses contains a summary of the collective state of the Project&apos;s
    /// Warehouses.
    /// </summary>
    [JsonPropertyName("warehouses")]
    public V1alpha1ProjectStatusStatsWarehouses? Warehouses { get; set; }
}

/// <summary>Status describes the Project&apos;s current status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProjectStatus
{
    /// <summary>
    /// Conditions contains the last observations of the Project&apos;s current
    /// state.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ProjectStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Stats contains a summary of the collective state of a Project&apos;s
    /// constituent resources.
    /// </summary>
    [JsonPropertyName("stats")]
    public V1alpha1ProjectStatusStats? Stats { get; set; }
}

/// <summary>
/// Project is a resource type that reconciles to a specially labeled namespace
/// and other TODO: TBD project-level resources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Project : IKubernetesObject<V1ObjectMeta>, IStatus<V1alpha1ProjectStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Project";
    public const string KubeGroup = "kargo.akuity.io";
    public const string KubePluralName = "projects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kargo.akuity.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Project";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Status describes the Project&apos;s current status.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ProjectStatus? Status { get; set; }
}