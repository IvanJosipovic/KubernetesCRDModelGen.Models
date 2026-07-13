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
/// <summary>TagsTagKey is the Schema for the TagsTagKey API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TagsTagKeyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TagsTagKey>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TagsTagKeyList";
    public const string KubeGroup = "tags.cnrm.cloud.google.com";
    public const string KubePluralName = "tagstagkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "tags.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TagsTagKeyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1TagsTagKey objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1TagsTagKey> Items { get; set; }
}

/// <summary>TagsTagKeySpec defines the desired state of TagsTagKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TagsTagKeySpec
{
    /// <summary>
    /// Optional. User-assigned description of the TagKey. Must not exceed 256
    ///  characters.
    /// 
    ///  Read-write.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The resource name of the TagKey&apos;s parent. A TagKey can be parented by an Organization or a Project. For a TagKey parented by an Organization, its parent must be in the form `organizations/{org_id}`. For a TagKey parented by a Project, its parent can be in the form `projects/{project_id}` or `projects/{project_number}`.</summary>
    [JsonPropertyName("parent")]
    public required string Parent { get; set; }

    /// <summary>
    /// Optional. A purpose denotes that this Tag is intended for use in policies
    ///  of a specific policy engine, and will involve that policy engine in
    ///  management operations involving this Tag. A purpose does not grant a
    ///  policy engine exclusive rights to the Tag, and it may be referenced by
    ///  other policy engines.
    /// 
    ///  A purpose cannot be changed once set.
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>
    /// Optional. Purpose data corresponds to the policy system that the tag is
    ///  intended for. See documentation for `Purpose` for formatting of this field.
    /// 
    ///  Purpose data cannot be changed once set.
    /// </summary>
    [JsonPropertyName("purposeData")]
    public IDictionary<string, string>? PurposeData { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>
    /// Required. Immutable. The user friendly name for a TagKey. The short name
    ///  should be unique for TagKeys within the same tag namespace.
    /// 
    ///  The short name must be 1-63 characters, beginning and ending with
    ///  an alphanumeric character ([a-z0-9A-Z]) with dashes (-), underscores (_),
    ///  dots (.), and alphanumerics between.
    /// </summary>
    [JsonPropertyName("shortName")]
    public required string ShortName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TagsTagKeyStatusConditions
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

/// <summary>TagsTagKeyStatus defines the config connector machine state of TagsTagKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TagsTagKeyStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TagsTagKeyStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. Creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>A unique specifier for the TagsTagKey resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>The generated numeric id for the TagKey.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. Immutable. Namespaced name of the TagKey.</summary>
    [JsonPropertyName("namespacedName")]
    public string? NamespacedName { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Output only. Update time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>TagsTagKey is the Schema for the TagsTagKey API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TagsTagKey : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TagsTagKeySpec>, IStatus<V1beta1TagsTagKeyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TagsTagKey";
    public const string KubeGroup = "tags.cnrm.cloud.google.com";
    public const string KubePluralName = "tagstagkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "tags.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TagsTagKey";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TagsTagKeySpec defines the desired state of TagsTagKey</summary>
    [JsonPropertyName("spec")]
    public required V1beta1TagsTagKeySpec Spec { get; set; }

    /// <summary>TagsTagKeyStatus defines the config connector machine state of TagsTagKey</summary>
    [JsonPropertyName("status")]
    public V1beta1TagsTagKeyStatus? Status { get; set; }
}