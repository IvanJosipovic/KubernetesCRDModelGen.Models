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
/// <summary>FirestoreField is the Schema for the FirestoreField API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirestoreFieldList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1FirestoreField>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirestoreFieldList";
    public const string KubeGroup = "firestore.cnrm.cloud.google.com";
    public const string KubePluralName = "firestorefields";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirestoreFieldList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1FirestoreField objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1FirestoreField> Items { get; set; }
}

/// <summary>The FirestoreDatabase containing the collection group for this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldSpecDatabaseRef
{
    /// <summary>A reference to an externally managed Firestore database resource. Should be in the format &quot;projects/{{projectID}}/databases/{{databaseID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a FirestoreDatabase resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a FirestoreDatabase resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Indicates the vector index is a flat index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldSpecIndexConfigIndexesFieldsVectorConfigFlat
{
}

/// <summary>Indicates that this field supports nearest neighbor and distance operations on vector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldSpecIndexConfigIndexesFieldsVectorConfig
{
    /// <summary>
    /// Required. The vector dimension this configuration applies to.
    /// 
    ///  The resulting index will only include vectors of this dimension, and
    ///  can be used for vector search with the same dimension.
    /// </summary>
    [JsonPropertyName("dimension")]
    public int? Dimension { get; set; }

    /// <summary>Indicates the vector index is a flat index.</summary>
    [JsonPropertyName("flat")]
    public V1alpha1FirestoreFieldSpecIndexConfigIndexesFieldsVectorConfigFlat? Flat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldSpecIndexConfigIndexesFields
{
    /// <summary>Indicates that this field supports operations on `array_value`s.</summary>
    [JsonPropertyName("arrayConfig")]
    public string? ArrayConfig { get; set; }

    /// <summary>Can be __name__. For single field indexes, this must match the name of the field or may be omitted.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>Indicates that this field supports ordering by the specified order or comparing using =, !=, &lt;, &lt;=, &gt;, &gt;=.</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>Indicates that this field supports nearest neighbor and distance operations on vector.</summary>
    [JsonPropertyName("vectorConfig")]
    public V1alpha1FirestoreFieldSpecIndexConfigIndexesFieldsVectorConfig? VectorConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldSpecIndexConfigIndexes
{
    /// <summary>The API scope supported by this index.</summary>
    [JsonPropertyName("apiScope")]
    public string? ApiScope { get; set; }

    /// <summary>Immutable. The density configuration of the index.</summary>
    [JsonPropertyName("density")]
    public string? Density { get; set; }

    /// <summary>
    /// The fields supported by this index.
    /// 
    ///  For composite indexes, this requires a minimum of 2 and a maximum of 100
    ///  fields. The last field entry is always for the field path `__name__`. If,
    ///  on creation, `__name__` was not specified as the last field, it will be
    ///  added automatically with the same direction as that of the last field
    ///  defined. If the final field in a composite index is not directional, the
    ///  `__name__` will be ordered ASCENDING (unless explicitly specified).
    /// 
    ///  For single field indexes, this will always be exactly one entry with a
    ///  field path equal to the field path of the associated field.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1alpha1FirestoreFieldSpecIndexConfigIndexesFields>? Fields { get; set; }

    /// <summary>
    /// Optional. Whether the index is multikey. By default, the index is not
    ///  multikey. For non-multikey indexes, none of the paths in the index
    ///  definition reach or traverse an array, except via an explicit array index.
    ///  For multikey indexes, at most one of the paths in the index definition
    ///  reach or traverse an array, except via an explicit array index. Violations
    ///  will result in errors.
    /// 
    ///  Note this field only applies to index with MONGODB_COMPATIBLE_API ApiScope.
    /// </summary>
    [JsonPropertyName("multikey")]
    public bool? Multikey { get; set; }

    /// <summary>
    /// Indexes with a collection query scope specified allow queries
    ///  against a collection that is the child of a specific document, specified at
    ///  query time, and that has the same collection ID.
    /// 
    ///  Indexes with a collection group query scope specified allow queries against
    ///  all collections descended from a specific document, specified at query
    ///  time, and that have the same collection ID as this index.
    /// </summary>
    [JsonPropertyName("queryScope")]
    public string? QueryScope { get; set; }

    /// <summary>Optional. The number of shards for the index.</summary>
    [JsonPropertyName("shardCount")]
    public int? ShardCount { get; set; }
}

/// <summary>The index configuration for this field. If unset, field indexing will revert to the configuration defined by the `ancestor_field`. To explicitly remove all indexes for this field, specify an index config with an empty list of indexes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldSpecIndexConfig
{
    /// <summary>The indexes supported for this field.</summary>
    [JsonPropertyName("indexes")]
    public IList<V1alpha1FirestoreFieldSpecIndexConfigIndexes>? Indexes { get; set; }
}

/// <summary>The TTL configuration for this `Field`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldSpecTtlConfig
{
    /// <summary>Whether to enable TTL for documents based on this field.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>FirestoreFieldSpec defines the desired state of FirestoreField</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldSpec
{
    /// <summary>The collectionGroup of which this field is a part.</summary>
    [JsonPropertyName("collectionGroup")]
    public required string CollectionGroup { get; set; }

    /// <summary>The FirestoreDatabase containing the collection group for this field.</summary>
    [JsonPropertyName("databaseRef")]
    public required V1alpha1FirestoreFieldSpecDatabaseRef DatabaseRef { get; set; }

    /// <summary>The index configuration for this field. If unset, field indexing will revert to the configuration defined by the `ancestor_field`. To explicitly remove all indexes for this field, specify an index config with an empty list of indexes.</summary>
    [JsonPropertyName("indexConfig")]
    public V1alpha1FirestoreFieldSpecIndexConfig? IndexConfig { get; set; }

    /// <summary>The FirestoreField name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The TTL configuration for this `Field`.</summary>
    [JsonPropertyName("ttlConfig")]
    public V1alpha1FirestoreFieldSpecTtlConfig? TtlConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldStatusObservedStateIndexConfigIndexes
{
    /// <summary>Output only. A server defined name for this index. The form of this name for composite indexes will be: `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{composite_index_id}` For single field indexes, this field will be empty.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. The serving state of the index.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>The index state for this field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldStatusObservedStateIndexConfig
{
    /// <summary>Output only. Specifies the resource name of the `Field` from which this field&apos;s index configuration is set (when `uses_ancestor_config` is true), or from which it *would* be set if this field had no index configuration (when `uses_ancestor_config` is false).</summary>
    [JsonPropertyName("ancestorField")]
    public string? AncestorField { get; set; }

    /// <summary>The indexes supported for this field.</summary>
    [JsonPropertyName("indexes")]
    public IList<V1alpha1FirestoreFieldStatusObservedStateIndexConfigIndexes>? Indexes { get; set; }

    /// <summary>Output only When true, the `Field`&apos;s index configuration is in the process of being reverted. Once complete, the index config will transition to the same state as the field specified by `ancestor_field`, at which point `uses_ancestor_config` will be `true` and `reverting` will be `false`.</summary>
    [JsonPropertyName("reverting")]
    public bool? Reverting { get; set; }

    /// <summary>Output only. When true, the `Field`&apos;s index configuration is set from the configuration specified by the `ancestor_field`. When false, the `Field`&apos;s index configuration is defined explicitly.</summary>
    [JsonPropertyName("usesAncestorConfig")]
    public bool? UsesAncestorConfig { get; set; }
}

/// <summary>The TTL state for this `Field`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldStatusObservedStateTtlConfig
{
    /// <summary>Output only. The state of the TTL configuration.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldStatusObservedState
{
    /// <summary>The index state for this field.</summary>
    [JsonPropertyName("indexConfig")]
    public V1alpha1FirestoreFieldStatusObservedStateIndexConfig? IndexConfig { get; set; }

    /// <summary>The TTL state for this `Field`.</summary>
    [JsonPropertyName("ttlConfig")]
    public V1alpha1FirestoreFieldStatusObservedStateTtlConfig? TtlConfig { get; set; }
}

/// <summary>FirestoreFieldStatus defines the config connector machine state of FirestoreField</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreFieldStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FirestoreFieldStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the FirestoreField resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1FirestoreFieldStatusObservedState? ObservedState { get; set; }
}

/// <summary>FirestoreField is the Schema for the FirestoreField API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirestoreField : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FirestoreFieldSpec>, IStatus<V1alpha1FirestoreFieldStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirestoreField";
    public const string KubeGroup = "firestore.cnrm.cloud.google.com";
    public const string KubePluralName = "firestorefields";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirestoreField";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FirestoreFieldSpec defines the desired state of FirestoreField</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1FirestoreFieldSpec Spec { get; set; }

    /// <summary>FirestoreFieldStatus defines the config connector machine state of FirestoreField</summary>
    [JsonPropertyName("status")]
    public V1alpha1FirestoreFieldStatus? Status { get; set; }
}