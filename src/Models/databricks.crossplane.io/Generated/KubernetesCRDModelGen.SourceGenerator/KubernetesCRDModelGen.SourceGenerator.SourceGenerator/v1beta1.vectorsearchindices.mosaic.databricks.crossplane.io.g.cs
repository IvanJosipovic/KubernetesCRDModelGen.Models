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
/// <summary>VectorSearchIndex is the Schema for the VectorSearchIndexs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VectorSearchIndexList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VectorSearchIndex>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VectorSearchIndexList";
    public const string KubeGroup = "mosaic.databricks.crossplane.io";
    public const string KubePluralName = "vectorsearchindices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mosaic.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VectorSearchIndexList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1VectorSearchIndex objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1VectorSearchIndex> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecDeletionPolicyEnum>))]
public enum V1beta1VectorSearchIndexSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum>))]
public enum V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum>))]
public enum V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ModelServing in serving to populate embeddingModelEndpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum>))]
public enum V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum>))]
public enum V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ModelServing in serving to populate embeddingModelEndpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelector
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
    public V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint, used by default for both ingestion and querying.</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>Reference to a ModelServing in serving to populate embeddingModelEndpointName.</summary>
    [JsonPropertyName("embeddingModelEndpointNameRef")]
    public V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRef? EmbeddingModelEndpointNameRef { get; set; }

    /// <summary>Selector for a ModelServing in serving to populate embeddingModelEndpointName.</summary>
    [JsonPropertyName("embeddingModelEndpointNameSelector")]
    public V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelector? EmbeddingModelEndpointNameSelector { get; set; }

    /// <summary>The name of the embedding model endpoint which, if specified, is used for querying (not ingestion).</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

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
public partial class V1beta1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingSourceColumns
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
public partial class V1beta1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderDirectAccessIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1VectorSearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolutionEnum>))]
public enum V1beta1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolveEnum>))]
public enum V1beta1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderEndpointNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VectorSearchIndexSpecForProviderEndpointNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderEndpointNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VectorSearchIndexSpecForProviderEndpointNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolutionEnum>))]
public enum V1beta1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolveEnum>))]
public enum V1beta1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderEndpointNameSelector
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
    public V1beta1VectorSearchIndexSpecForProviderEndpointNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecForProvider
{
    /// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public V1beta1VectorSearchIndexSpecForProviderDeltaSyncIndexSpec? DeltaSyncIndexSpec { get; set; }

    /// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public V1beta1VectorSearchIndexSpecForProviderDirectAccessIndexSpec? DirectAccessIndexSpec { get; set; }

    /// <summary>The name of the Mosaic AI Vector Search Endpoint that will be used for indexing the data.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>Reference to a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
    [JsonPropertyName("endpointNameRef")]
    public V1beta1VectorSearchIndexSpecForProviderEndpointNameRef? EndpointNameRef { get; set; }

    /// <summary>Selector for a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
    [JsonPropertyName("endpointNameSelector")]
    public V1beta1VectorSearchIndexSpecForProviderEndpointNameSelector? EndpointNameSelector { get; set; }

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
    public V1beta1VectorSearchIndexSpecForProviderProviderConfig? ProviderConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum>))]
public enum V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum>))]
public enum V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ModelServing in serving to populate embeddingModelEndpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum>))]
public enum V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum>))]
public enum V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ModelServing in serving to populate embeddingModelEndpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelector
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
    public V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumns
{
    /// <summary>The name of the embedding model endpoint, used by default for both ingestion and querying.</summary>
    [JsonPropertyName("embeddingModelEndpointName")]
    public string? EmbeddingModelEndpointName { get; set; }

    /// <summary>Reference to a ModelServing in serving to populate embeddingModelEndpointName.</summary>
    [JsonPropertyName("embeddingModelEndpointNameRef")]
    public V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameRef? EmbeddingModelEndpointNameRef { get; set; }

    /// <summary>Selector for a ModelServing in serving to populate embeddingModelEndpointName.</summary>
    [JsonPropertyName("embeddingModelEndpointNameSelector")]
    public V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumnsEmbeddingModelEndpointNameSelector? EmbeddingModelEndpointNameSelector { get; set; }

    /// <summary>The name of the embedding model endpoint which, if specified, is used for querying (not ingestion).</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

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
public partial class V1beta1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingSourceColumns
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
public partial class V1beta1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderDirectAccessIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1VectorSearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolutionEnum>))]
public enum V1beta1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolveEnum>))]
public enum V1beta1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderEndpointNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VectorSearchIndexSpecInitProviderEndpointNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderEndpointNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VectorSearchIndexSpecInitProviderEndpointNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolutionEnum>))]
public enum V1beta1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolveEnum>))]
public enum V1beta1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderEndpointNameSelector
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
    public V1beta1VectorSearchIndexSpecInitProviderEndpointNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecInitProviderProviderConfig
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
public partial class V1beta1VectorSearchIndexSpecInitProvider
{
    /// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public V1beta1VectorSearchIndexSpecInitProviderDeltaSyncIndexSpec? DeltaSyncIndexSpec { get; set; }

    /// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public V1beta1VectorSearchIndexSpecInitProviderDirectAccessIndexSpec? DirectAccessIndexSpec { get; set; }

    /// <summary>The name of the Mosaic AI Vector Search Endpoint that will be used for indexing the data.</summary>
    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    /// <summary>Reference to a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
    [JsonPropertyName("endpointNameRef")]
    public V1beta1VectorSearchIndexSpecInitProviderEndpointNameRef? EndpointNameRef { get; set; }

    /// <summary>Selector for a VectorSearchEndpoint in mosaic to populate endpointName.</summary>
    [JsonPropertyName("endpointNameSelector")]
    public V1beta1VectorSearchIndexSpecInitProviderEndpointNameSelector? EndpointNameSelector { get; set; }

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
    public V1beta1VectorSearchIndexSpecInitProviderProviderConfig? ProviderConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecManagementPoliciesEnum>))]
public enum V1beta1VectorSearchIndexSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1VectorSearchIndexSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1VectorSearchIndexSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1VectorSearchIndexSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1VectorSearchIndexSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1VectorSearchIndexSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VectorSearchIndexSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexSpecWriteConnectionSecretToRef
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
public partial class V1beta1VectorSearchIndexSpec
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
    public V1beta1VectorSearchIndexSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1VectorSearchIndexSpecForProvider ForProvider { get; set; }

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
    public V1beta1VectorSearchIndexSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1VectorSearchIndexSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VectorSearchIndexSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VectorSearchIndexSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingSourceColumns
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
public partial class V1beta1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

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
public partial class V1beta1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingSourceColumns
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
public partial class V1beta1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector.</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Three-level name of the Mosaic AI Vector Search Index to create (catalog.schema.index_name).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexStatusAtProviderDirectAccessIndexSpec
{
    /// <summary>array of objects representing columns that contain the embedding source.  Each entry consists of:</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>array of objects representing columns that contain the embedding vectors. Each entry consists of:</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1VectorSearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>The schema of the index in JSON format.  Check the API documentation for a list of supported data types.</summary>
    [JsonPropertyName("schemaJson")]
    public string? SchemaJson { get; set; }
}

/// <summary>Configure the provider for management through account provider. This block consists of the following fields:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexStatusAtProviderStatus
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
public partial class V1beta1VectorSearchIndexStatusAtProvider
{
    /// <summary>Creator of the endpoint.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>(object) Specification for Delta Sync Index. Required if index_type is DELTA_SYNC. This field is a block and is documented below.</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public V1beta1VectorSearchIndexStatusAtProviderDeltaSyncIndexSpec? DeltaSyncIndexSpec { get; set; }

    /// <summary>(object) Specification for Direct Vector Access Index. Required if index_type is DIRECT_ACCESS. This field is a block and is documented below.</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public V1beta1VectorSearchIndexStatusAtProviderDirectAccessIndexSpec? DirectAccessIndexSpec { get; set; }

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
    public V1beta1VectorSearchIndexStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Object describing the current status of the index consisting of the following fields:</summary>
    [JsonPropertyName("status")]
    public IList<V1beta1VectorSearchIndexStatusAtProviderStatus>? Status { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VectorSearchIndexStatusConditions
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
public partial class V1beta1VectorSearchIndexStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1VectorSearchIndexStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VectorSearchIndexStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VectorSearchIndex is the Schema for the VectorSearchIndexs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VectorSearchIndex : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VectorSearchIndexSpec>, IStatus<V1beta1VectorSearchIndexStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VectorSearchIndex";
    public const string KubeGroup = "mosaic.databricks.crossplane.io";
    public const string KubePluralName = "vectorsearchindices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "mosaic.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VectorSearchIndex";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VectorSearchIndexSpec defines the desired state of VectorSearchIndex</summary>
    [JsonPropertyName("spec")]
    public required V1beta1VectorSearchIndexSpec Spec { get; set; }

    /// <summary>VectorSearchIndexStatus defines the observed state of VectorSearchIndex.</summary>
    [JsonPropertyName("status")]
    public V1beta1VectorSearchIndexStatus? Status { get; set; }
}