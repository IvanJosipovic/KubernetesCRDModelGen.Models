#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firestore.cnrm.cloud.google.com;
/// <summary>FirestoreIndex is the Schema for the FirestoreIndex API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FirestoreIndexList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FirestoreIndex>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FirestoreIndexList";
    public const string KubeGroup = "firestore.cnrm.cloud.google.com";
    public const string KubePluralName = "firestoreindexes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirestoreIndexList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1FirestoreIndex objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1FirestoreIndex> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirestoreIndexSpecFields
{
    /// <summary>Immutable. Indicates that this field supports operations on arrayValues. Only one of &apos;order&apos; and &apos;arrayConfig&apos; can be specified. Possible values: [&quot;CONTAINS&quot;].</summary>
    [JsonPropertyName("arrayConfig")]
    public string? ArrayConfig { get; set; }

    /// <summary>Immutable. Name of the field.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>Immutable. Indicates that this field supports ordering by the specified order or comparing using =, &lt;, &lt;=, &gt;, &gt;=. Only one of &apos;order&apos; and &apos;arrayConfig&apos; can be specified. Possible values: [&quot;ASCENDING&quot;, &quot;DESCENDING&quot;].</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }
}

/// <summary>FirestoreIndexSpec defines the desired state of FirestoreIndex</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirestoreIndexSpec
{
    /// <summary>Immutable. The collection being indexed.</summary>
    [JsonPropertyName("collection")]
    public required string Collection { get; set; }

    /// <summary>Immutable. The Firestore database id. Defaults to &apos; &quot;(default)&quot; &apos;.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Immutable. The fields supported by this index. The last field entry is always for the field path &apos;__name__&apos;. If, on creation, &apos;__name__&apos; was not specified as the last field, it will be added automatically with the same direction as that of the last field defined. If the final field in a composite index is not directional, the &apos;__name__&apos; will be ordered &apos; &quot;ASCENDING&quot; &apos; (unless explicitly specified otherwise).</summary>
    [JsonPropertyName("fields")]
    public required IList<V1beta1FirestoreIndexSpecFields> Fields { get; set; }

    /// <summary>Immutable. The scope at which a query is run. Default value: &quot;COLLECTION&quot; Possible values: [&quot;COLLECTION&quot;, &quot;COLLECTION_GROUP&quot;].</summary>
    [JsonPropertyName("queryScope")]
    public string? QueryScope { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirestoreIndexStatusConditions
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

/// <summary>FirestoreIndexStatus defines the config connector machine state of FirestoreIndex</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FirestoreIndexStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FirestoreIndexStatusConditions>? Conditions { get; set; }

    /// <summary>A server defined name for this index. Format: &apos;projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/indexes/{{server_generated_id}}&apos;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FirestoreIndex is the Schema for the FirestoreIndex API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FirestoreIndex : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FirestoreIndexSpec?>, IStatus<V1beta1FirestoreIndexStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FirestoreIndex";
    public const string KubeGroup = "firestore.cnrm.cloud.google.com";
    public const string KubePluralName = "firestoreindexes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirestoreIndex";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FirestoreIndexSpec defines the desired state of FirestoreIndex</summary>
    [JsonPropertyName("spec")]
    public V1beta1FirestoreIndexSpec? Spec { get; set; }

    /// <summary>FirestoreIndexStatus defines the config connector machine state of FirestoreIndex</summary>
    [JsonPropertyName("status")]
    public V1beta1FirestoreIndexStatus? Status { get; set; }
}