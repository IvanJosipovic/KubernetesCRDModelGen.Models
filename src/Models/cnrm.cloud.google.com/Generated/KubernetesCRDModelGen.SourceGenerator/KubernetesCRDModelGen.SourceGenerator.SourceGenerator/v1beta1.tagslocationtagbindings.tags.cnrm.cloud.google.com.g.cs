#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.tags.cnrm.cloud.google.com;
/// <summary>TagsLocationTagBinding is the Schema for the TagsLocationTagBinding API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TagsLocationTagBindingList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TagsLocationTagBinding>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TagsLocationTagBindingList";
    public const string KubeGroup = "tags.cnrm.cloud.google.com";
    public const string KubePluralName = "tagslocationtagbindings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "tags.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TagsLocationTagBindingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1TagsLocationTagBinding objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1TagsLocationTagBinding> Items { get; set; }
}

/// <summary>ParentRef is a reference to a parent resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TagsLocationTagBindingSpecParentRef
{
    /// <summary>Allowed value: string of the format `//cloudresourcemanager.googleapis.com/projects/{{value}}`, where {{value}} is the `number` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind to which we are binding the tag.  Defaults to Project if not specified.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>TagsTagValueRef is a reference to a TagsTagValue resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TagsLocationTagBindingSpecTagValueRef
{
    /// <summary>A reference to an externally managed TagsTagValue resource. Should be in the format &quot;tagValues/{{tagValueID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a TagsTagValue resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a TagsTagValue resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>TagsLocationTagBindingSpec defines the desired state of TagsLocationTagBinding</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TagsLocationTagBindingSpec
{
    /// <summary>The location for the resource being tagged.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>ParentRef is a reference to a parent resource.</summary>
    [JsonPropertyName("parentRef")]
    public required V1beta1TagsLocationTagBindingSpecParentRef ParentRef { get; set; }

    /// <summary>The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>TagsTagValueRef is a reference to a TagsTagValue resource.</summary>
    [JsonPropertyName("tagValueRef")]
    public required V1beta1TagsLocationTagBindingSpecTagValueRef TagValueRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TagsLocationTagBindingStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>TagsLocationTagBindingStatus defines the config connector machine state of TagsLocationTagBinding</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TagsLocationTagBindingStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TagsLocationTagBindingStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the TagsLocationTagBinding resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>The generated id for the TagBinding. This is a string of the form: tagBindings/{full-resource-name}/{tag-value-name}.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TagsLocationTagBinding is the Schema for the TagsLocationTagBinding API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TagsLocationTagBinding : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TagsLocationTagBindingSpec>, IStatus<V1beta1TagsLocationTagBindingStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TagsLocationTagBinding";
    public const string KubeGroup = "tags.cnrm.cloud.google.com";
    public const string KubePluralName = "tagslocationtagbindings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "tags.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TagsLocationTagBinding";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TagsLocationTagBindingSpec defines the desired state of TagsLocationTagBinding</summary>
    [JsonPropertyName("spec")]
    public required V1beta1TagsLocationTagBindingSpec Spec { get; set; }

    /// <summary>TagsLocationTagBindingStatus defines the config connector machine state of TagsLocationTagBinding</summary>
    [JsonPropertyName("status")]
    public V1beta1TagsLocationTagBindingStatus? Status { get; set; }
}