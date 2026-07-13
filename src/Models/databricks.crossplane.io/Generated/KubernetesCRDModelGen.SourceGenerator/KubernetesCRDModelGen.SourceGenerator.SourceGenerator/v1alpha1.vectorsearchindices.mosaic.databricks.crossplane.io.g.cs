#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.mosaic.databricks.crossplane.io;
/// <summary>
/// VectorSearchIndex is the Schema for the VectorSearchIndexs API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VectorSearchIndexList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VectorSearchIndex>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VectorSearchIndexList";
    public const string KubeGroup = "mosaic.databricks.crossplane.io";
    public const string KubePluralName = "vectorsearchindices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mosaic.databricks.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VectorSearchIndexList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VectorSearchIndex objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VectorSearchIndex> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecDeletionPolicyEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ModelServing in serving to populate embeddingModelEndpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ModelServing in serving to populate embeddingModelEndpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint, used by default for both ingestion and querying.</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>Reference to a ModelServing in serving to populate embeddingModelEndpointName.</summary>
    [JsonPropertyName("embeddingModelEndpointNameRef")]
    public V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRef? EmbeddingModelEndpointNameRef { get; set; }

    /// <summary>Selector for a ModelServing in serving to populate embeddingModelEndpointName.</summary>
    [JsonPropertyName("embeddingModelEndpointNameSelector")]
    public V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelector? EmbeddingModelEndpointNameSelector { get; set; }

    /// <summary>The name of the embedding model endpoint which, if specified, is used for querying (not ingestion).</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>Automatically sync the vector index contents and computed embeddings to the specified Delta table. The only supported table name is the index name with the suffix _writeback_table.</summary>
    [JsonPropertyName("embeddingWritebackTable")]
    public string? EmbeddingWritebackTable { get; set; }

    /// <summary>Pipeline execution mode. Possible values are:</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>The name of the source table.</summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint, used by default for both ingestion and querying.</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>The name of the embedding model endpoint which, if specified, is used for querying (not ingestion).</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>The schema of the index in JSON format.  Check the API documentation for a list of supported data types.</summary>
    [JsonPropertyName("schemaJson")]
    public string? SchemaJson { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderEndpointNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderEndpointNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1VectorSearchIndexSpecForProviderEndpointNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderEndpointNameSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecForProvider
{
    /// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDeltaSyncIndexSpec>? DeltaSyncIndexSpec { get; set; }

    /// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderDirectAccessIndexSpec>? DirectAccessIndexSpec { get; set; }

    /// <summary>The name of the Mosaic AI Vector Search Endpoint that will be used for indexing the data.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>Reference to a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
    [JsonPropertyName("endpointNameRef")]
    public V1alpha1VectorSearchIndexSpecForProviderEndpointNameRef? EndpointNameRef { get; set; }

    /// <summary>Selector for a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
    [JsonPropertyName("endpointNameSelector")]
    public V1alpha1VectorSearchIndexSpecForProviderEndpointNameSelector? EndpointNameSelector { get; set; }

    /// <summary>Mosaic AI Vector Search index type. Currently supported values are:</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The column name that will be used as a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1VectorSearchIndexSpecForProviderProviderConfig>? ProviderConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ModelServing in serving to populate embeddingModelEndpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ModelServing in serving to populate embeddingModelEndpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint, used by default for both ingestion and querying.</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>Reference to a ModelServing in serving to populate embeddingModelEndpointName.</summary>
    [JsonPropertyName("embeddingModelEndpointNameRef")]
    public V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRef? EmbeddingModelEndpointNameRef { get; set; }

    /// <summary>Selector for a ModelServing in serving to populate embeddingModelEndpointName.</summary>
    [JsonPropertyName("embeddingModelEndpointNameSelector")]
    public V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelector? EmbeddingModelEndpointNameSelector { get; set; }

    /// <summary>The name of the embedding model endpoint which, if specified, is used for querying (not ingestion).</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>Automatically sync the vector index contents and computed embeddings to the specified Delta table. The only supported table name is the index name with the suffix _writeback_table.</summary>
    [JsonPropertyName("embeddingWritebackTable")]
    public string? EmbeddingWritebackTable { get; set; }

    /// <summary>Pipeline execution mode. Possible values are:</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>The name of the source table.</summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint, used by default for both ingestion and querying.</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>The name of the embedding model endpoint which, if specified, is used for querying (not ingestion).</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>The schema of the index in JSON format.  Check the API documentation for a list of supported data types.</summary>
    [JsonPropertyName("schemaJson")]
    public string? SchemaJson { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderEndpointNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderEndpointNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1VectorSearchIndexSpecInitProviderEndpointNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderEndpointNameSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecInitProvider
{
    /// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpec>? DeltaSyncIndexSpec { get; set; }

    /// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderDirectAccessIndexSpec>? DirectAccessIndexSpec { get; set; }

    /// <summary>The name of the Mosaic AI Vector Search Endpoint that will be used for indexing the data.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>Reference to a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
    [JsonPropertyName("endpointNameRef")]
    public V1alpha1VectorSearchIndexSpecInitProviderEndpointNameRef? EndpointNameRef { get; set; }

    /// <summary>Selector for a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
    [JsonPropertyName("endpointNameSelector")]
    public V1alpha1VectorSearchIndexSpecInitProviderEndpointNameSelector? EndpointNameSelector { get; set; }

    /// <summary>Mosaic AI Vector Search index type. Currently supported values are:</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The column name that will be used as a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1VectorSearchIndexSpecInitProviderProviderConfig>? ProviderConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecManagementPoliciesEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecProviderConfigRefPolicyResolutionEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1VectorSearchIndexSpecProviderConfigRefPolicyResolveEnum>))]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public enum V1alpha1VectorSearchIndexSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1VectorSearchIndexSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1VectorSearchIndexSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1VectorSearchIndexSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>VectorSearchIndexSpec defines the desired state of VectorSearchIndex</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1alpha1VectorSearchIndexSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1VectorSearchIndexSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1alpha1VectorSearchIndexSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1VectorSearchIndexSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1VectorSearchIndexSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1VectorSearchIndexSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint, used by default for both ingestion and querying.</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>The name of the embedding model endpoint which, if specified, is used for querying (not ingestion).</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>Automatically sync the vector index contents and computed embeddings to the specified Delta table. The only supported table name is the index name with the suffix _writeback_table.</summary>
    [JsonPropertyName("embeddingWritebackTable")]
    public string? EmbeddingWritebackTable { get; set; }

    /// <summary>ID of the associated Delta Live Table pipeline.</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }

    /// <summary>Pipeline execution mode. Possible values are:</summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>The name of the source table.</summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint, used by default for both ingestion and querying.</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>The name of the embedding model endpoint which, if specified, is used for querying (not ingestion).</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>The schema of the index in JSON format.  Check the API documentation for a list of supported data types.</summary>
    [JsonPropertyName("schemaJson")]
    public string? SchemaJson { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexStatusAtProviderStatus
{
    /// <summary>Index API Url to be used to perform operations on the index</summary>
    [JsonPropertyName("indexUrl")]
    public string? IndexUrl { get; set; }

    /// <summary>Number of rows indexed</summary>
    [JsonPropertyName("indexedRowCount")]
    public double? IndexedRowCount { get; set; }

    /// <summary>Message associated with the index status</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Whether the index is ready for search</summary>
    [JsonPropertyName("ready")]
    public bool? Ready { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexStatusAtProvider
{
    /// <summary>Creator of the endpoint.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpec>? DeltaSyncIndexSpec { get; set; }

    /// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderDirectAccessIndexSpec>? DirectAccessIndexSpec { get; set; }

    /// <summary>The name of the Mosaic AI Vector Search Endpoint that will be used for indexing the data.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>The same as the name of the index.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Mosaic AI Vector Search index type. Currently supported values are:</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The column name that will be used as a primary key.</summary>
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; set; }

    /// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
    [JsonPropertyName("providerConfig")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderProviderConfig>? ProviderConfig { get; set; }

    /// <summary>Object describing the current status of the index consisting of the following fields:</summary>
    [JsonPropertyName("status")]
    public IList<V1alpha1VectorSearchIndexStatusAtProviderStatus>? Status { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexStatusConditions
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

/// <summary>VectorSearchIndexStatus defines the observed state of VectorSearchIndex.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
public partial class V1alpha1VectorSearchIndexStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1VectorSearchIndexStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VectorSearchIndexStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>
/// VectorSearchIndex is the Schema for the VectorSearchIndexs API.
/// Deprecated: This API version (v1alpha1) has been deprecated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[global::System.Obsolete("This API version is deprecated. Please migrate to v1beta1.")]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VectorSearchIndex : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VectorSearchIndexSpec>, IStatus<V1alpha1VectorSearchIndexStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VectorSearchIndex";
    public const string KubeGroup = "mosaic.databricks.crossplane.io";
    public const string KubePluralName = "vectorsearchindices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mosaic.databricks.crossplane.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VectorSearchIndex";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VectorSearchIndexSpec defines the desired state of VectorSearchIndex</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VectorSearchIndexSpec Spec { get; set; }

    /// <summary>VectorSearchIndexStatus defines the observed state of VectorSearchIndex.</summary>
    [JsonPropertyName("status")]
    public V1alpha1VectorSearchIndexStatus? Status { get; set; }
}