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
/// <summary>ContentItem defines additional documentation for given resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ContentItemList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ContentItem>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ContentItemList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "contentitems";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContentItemList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ContentItem objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ContentItem> Items { get; set; }
}

/// <summary>Link is the link to the content.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentItemSpecLink
{
    /// <summary>Href is the public URL of the content.</summary>
    [JsonPropertyName("href")]
    public required string Href { get; set; }
}

/// <summary>Kind is the kind of the resource that this content belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ContentItemSpecParentRefKindEnum>))]
public enum V1alpha1ContentItemSpecParentRefKindEnum
{
    [EnumMember(Value = "APIPortal"), JsonStringEnumMemberName("APIPortal")]
    APIPortal,
    [EnumMember(Value = "API"), JsonStringEnumMemberName("API")]
    API,
    [EnumMember(Value = "APIBundle"), JsonStringEnumMemberName("APIBundle")]
    APIBundle
}

/// <summary>ParentRef is the reference to the resource that this content belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentItemSpecParentRef
{
    /// <summary>Kind is the kind of the resource that this content belongs to.</summary>
    [JsonPropertyName("kind")]
    public required V1alpha1ContentItemSpecParentRefKindEnum Kind { get; set; }

    /// <summary>Name is the name of the resource that this content belongs to.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Defines the documentation to attach to the referenced resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentItemSpec
{
    /// <summary>Content is the valid markdown content.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Link is the link to the content.</summary>
    [JsonPropertyName("link")]
    public V1alpha1ContentItemSpecLink? Link { get; set; }

    /// <summary>Order defines the order of the content in the UI.</summary>
    [JsonPropertyName("order")]
    public required int Order { get; set; }

    /// <summary>ParentRef is the reference to the resource that this content belongs to.</summary>
    [JsonPropertyName("parentRef")]
    public required V1alpha1ContentItemSpecParentRef ParentRef { get; set; }

    /// <summary>Title is the public-facing name of the ContentItem.</summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ContentItemStatusConditionsStatusEnum>))]
public enum V1alpha1ContentItemStatusConditionsStatusEnum
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
public partial class V1alpha1ContentItemStatusConditions
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
    public required V1alpha1ContentItemStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>The current status of this ContentItem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ContentItemStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ContentItemStatusConditions>? Conditions { get; set; }

    /// <summary>Hash is a hash representing the ContentItem.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    [JsonPropertyName("syncedAt")]
    public DateTime? SyncedAt { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>ContentItem defines additional documentation for given resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ContentItem : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ContentItemSpec?>, IStatus<V1alpha1ContentItemStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ContentItem";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "contentitems";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContentItem";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Defines the documentation to attach to the referenced resource.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ContentItemSpec? Spec { get; set; }

    /// <summary>The current status of this ContentItem.</summary>
    [JsonPropertyName("status")]
    public V1alpha1ContentItemStatus? Status { get; set; }
}