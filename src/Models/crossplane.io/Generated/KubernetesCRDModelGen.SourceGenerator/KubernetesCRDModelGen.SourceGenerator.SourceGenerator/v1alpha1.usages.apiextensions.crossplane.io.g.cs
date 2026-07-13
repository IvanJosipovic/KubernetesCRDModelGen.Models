#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apiextensions.crossplane.io;
/// <summary>
/// A Usage defines a deletion blocking relationship between two resources.
/// 
/// Usages prevent accidental deletion of a single resource or deletion of
/// resources with dependent resources.
/// 
/// Read the Crossplane documentation for
/// [more information about Usages](https://docs.crossplane.io/latest/managed-resources/usages/).
/// 
/// Deprecated: Use protection.crossplane.io Usage or ClusterUsage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("apiextensions.crossplane.io Usage is deprecated; migrate to protection.crossplane.io Usage or ClusterUsage")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1UsageList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Usage>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "UsageList";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "usages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apiextensions.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "UsageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Usage objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Usage> Items { get; set; }
}

/// <summary>Reference to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("apiextensions.crossplane.io Usage is deprecated; migrate to protection.crossplane.io Usage or ClusterUsage")]
public partial class V1alpha1UsageSpecByResourceRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Selector to the resource.
/// This field will be ignored if ResourceRef is set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("apiextensions.crossplane.io Usage is deprecated; migrate to protection.crossplane.io Usage or ClusterUsage")]
public partial class V1alpha1UsageSpecByResourceSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>By is the resource that is &quot;using the other resource&quot;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("apiextensions.crossplane.io Usage is deprecated; migrate to protection.crossplane.io Usage or ClusterUsage")]
public partial class V1alpha1UsageSpecBy
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// Kind of the referent.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Reference to the resource.</summary>
    [JsonPropertyName("resourceRef")]
    public V1alpha1UsageSpecByResourceRef? ResourceRef { get; set; }

    /// <summary>
    /// Selector to the resource.
    /// This field will be ignored if ResourceRef is set.
    /// </summary>
    [JsonPropertyName("resourceSelector")]
    public V1alpha1UsageSpecByResourceSelector? ResourceSelector { get; set; }
}

/// <summary>Reference to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("apiextensions.crossplane.io Usage is deprecated; migrate to protection.crossplane.io Usage or ClusterUsage")]
public partial class V1alpha1UsageSpecOfResourceRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Selector to the resource.
/// This field will be ignored if ResourceRef is set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("apiextensions.crossplane.io Usage is deprecated; migrate to protection.crossplane.io Usage or ClusterUsage")]
public partial class V1alpha1UsageSpecOfResourceSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Of is the resource that is &quot;being used&quot;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("apiextensions.crossplane.io Usage is deprecated; migrate to protection.crossplane.io Usage or ClusterUsage")]
public partial class V1alpha1UsageSpecOf
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// Kind of the referent.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Reference to the resource.</summary>
    [JsonPropertyName("resourceRef")]
    public V1alpha1UsageSpecOfResourceRef? ResourceRef { get; set; }

    /// <summary>
    /// Selector to the resource.
    /// This field will be ignored if ResourceRef is set.
    /// </summary>
    [JsonPropertyName("resourceSelector")]
    public V1alpha1UsageSpecOfResourceSelector? ResourceSelector { get; set; }
}

/// <summary>UsageSpec defines the desired state of Usage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("apiextensions.crossplane.io Usage is deprecated; migrate to protection.crossplane.io Usage or ClusterUsage")]
public partial class V1alpha1UsageSpec
{
    /// <summary>By is the resource that is &quot;using the other resource&quot;.</summary>
    [JsonPropertyName("by")]
    public V1alpha1UsageSpecBy? By { get; set; }

    /// <summary>Of is the resource that is &quot;being used&quot;.</summary>
    [JsonPropertyName("of")]
    public required V1alpha1UsageSpecOf Of { get; set; }

    /// <summary>Reason is the reason for blocking deletion of the resource.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>ReplayDeletion will trigger a deletion on the used resource during the deletion of the usage itself, if it was attempted to be deleted at least once.</summary>
    [JsonPropertyName("replayDeletion")]
    public bool? ReplayDeletion { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("apiextensions.crossplane.io Usage is deprecated; migrate to protection.crossplane.io Usage or ClusterUsage")]
public partial class V1alpha1UsageStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>UsageStatus defines the observed state of Usage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("apiextensions.crossplane.io Usage is deprecated; migrate to protection.crossplane.io Usage or ClusterUsage")]
public partial class V1alpha1UsageStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1UsageStatusConditions>? Conditions { get; set; }
}

/// <summary>
/// A Usage defines a deletion blocking relationship between two resources.
/// 
/// Usages prevent accidental deletion of a single resource or deletion of
/// resources with dependent resources.
/// 
/// Read the Crossplane documentation for
/// [more information about Usages](https://docs.crossplane.io/latest/managed-resources/usages/).
/// 
/// Deprecated: Use protection.crossplane.io Usage or ClusterUsage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("apiextensions.crossplane.io Usage is deprecated; migrate to protection.crossplane.io Usage or ClusterUsage")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Usage : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1UsageSpec>, IStatus<V1alpha1UsageStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Usage";
    public const string KubeGroup = "apiextensions.crossplane.io";
    public const string KubePluralName = "usages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apiextensions.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Usage";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>UsageSpec defines the desired state of Usage.</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1UsageSpec Spec { get; set; }

    /// <summary>UsageStatus defines the observed state of Usage.</summary>
    [JsonPropertyName("status")]
    public V1alpha1UsageStatus? Status { get; set; }
}