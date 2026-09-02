#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ai.databricks.crossplane.io;
/// <summary>AISearchIndex is the Schema for the AISearchIndexs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AISearchIndexList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AISearchIndex>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AISearchIndexList";
    public const string KubeGroup = "ai.databricks.crossplane.io";
    public const string KubePluralName = "aisearchindices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ai.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AISearchIndexList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AISearchIndex objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AISearchIndex> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AISearchIndexSpecDeletionPolicyEnum>))]
public enum V1beta1AISearchIndexSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumns
{
    /// <summary>Name of the embedding model endpoint, used by default for both ingestion and querying</summary>
    [JsonPropertyName("embeddingModelEndpoint")]
    public string? EmbeddingModelEndpoint { get; set; }

    /// <summary>Name of the embedding model endpoint which, if specified, is used for querying (not ingestion)</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Specification for a Delta Sync index. Set when index_type is DELTA_SYNC</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecForProviderDeltaSyncIndexSpec
{
    /// <summary>
    /// [Optional] Select the columns to sync with the index. If left blank, all columns
    /// from the source table are synced. The primary key column and embedding source or
    /// vector column are always synced
    /// </summary>
    [JsonPropertyName("columnsToSync")]
    public IList<string>? ColumnsToSync { get; set; }

    /// <summary>The columns that contain the embedding source</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1AISearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>The columns that contain the embedding vectors</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1AISearchIndexSpecForProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>[Optional] Name of the Delta table to sync the index contents and computed embeddings to</summary>
    [JsonPropertyName("embeddingWritebackTable")]
    public string? EmbeddingWritebackTable { get; set; }

    /// <summary>
    /// Pipeline execution mode. Required on create — the backend rejects an unset value.
    /// Storage Optimized endpoints accept only TRIGGERED; Standard endpoints accept both.
    /// No explicit stage — a REQUIRED field staged below its service would be dropped from
    /// combined specs while remaining in required, tripping the OpenAPI required-vs-properties
    /// consistency check. The field inherits the service&apos;s launch stage. Possible values are: CONTINUOUS, TRIGGERED
    /// </summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>The full name of the source Delta table</summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingSourceColumns
{
    /// <summary>Name of the embedding model endpoint, used by default for both ingestion and querying</summary>
    [JsonPropertyName("embeddingModelEndpoint")]
    public string? EmbeddingModelEndpoint { get; set; }

    /// <summary>Name of the embedding model endpoint which, if specified, is used for querying (not ingestion)</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Specification for a Direct Access index. Set when index_type is DIRECT_ACCESS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecForProviderDirectAccessIndexSpec
{
    /// <summary>The columns that contain the embedding source</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1AISearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>The columns that contain the embedding vectors</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1AISearchIndexSpecForProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>
    /// The schema of the index in JSON format. Supported types are integer, long,
    /// float, double, boolean, string, date, timestamp. Supported types for
    /// vector columns: array&lt;float&gt;, array&lt;double&gt;
    /// </summary>
    [JsonPropertyName("schemaJson")]
    public string? SchemaJson { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecForProvider
{
    /// <summary>Specification for a Delta Sync index. Set when index_type is DELTA_SYNC</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public V1beta1AISearchIndexSpecForProviderDeltaSyncIndexSpec? DeltaSyncIndexSpec { get; set; }

    /// <summary>Specification for a Direct Access index. Set when index_type is DIRECT_ACCESS</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public V1beta1AISearchIndexSpecForProviderDirectAccessIndexSpec? DirectAccessIndexSpec { get; set; }

    /// <summary>
    /// The user-supplied Unity Catalog table name for the Index, per AIP-133. The server
    /// composes the full Index.name as {parent}/indexes/{index_id}. AIP-133 does not
    /// list index_id as a fields-may-be-required entry, so we annotate it OPTIONAL on the
    /// wire; the server still rejects empty values with INVALID_PARAMETER_VALUE
    /// </summary>
    [JsonPropertyName("indexId")]
    public string? IndexId { get; set; }

    /// <summary>The subtype of the index. Set on create and immutable thereafter. Possible values are: FULL_TEXT, HYBRID, VECTOR</summary>
    [JsonPropertyName("indexSubtype")]
    public string? IndexSubtype { get; set; }

    /// <summary>Type of index. Required on create and immutable thereafter. Possible values are: DELTA_SYNC, DIRECT_ACCESS</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>
    /// The Endpoint where this Index will be created.
    /// Format: workspaces/{workspace_id}/endpoints/{endpoint_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Primary key of the index. Set on create and immutable thereafter</summary>
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1AISearchIndexSpecForProviderProviderConfig? ProviderConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumns
{
    /// <summary>Name of the embedding model endpoint, used by default for both ingestion and querying</summary>
    [JsonPropertyName("embeddingModelEndpoint")]
    public string? EmbeddingModelEndpoint { get; set; }

    /// <summary>Name of the embedding model endpoint which, if specified, is used for querying (not ingestion)</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Specification for a Delta Sync index. Set when index_type is DELTA_SYNC</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecInitProviderDeltaSyncIndexSpec
{
    /// <summary>
    /// [Optional] Select the columns to sync with the index. If left blank, all columns
    /// from the source table are synced. The primary key column and embedding source or
    /// vector column are always synced
    /// </summary>
    [JsonPropertyName("columnsToSync")]
    public IList<string>? ColumnsToSync { get; set; }

    /// <summary>The columns that contain the embedding source</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1AISearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>The columns that contain the embedding vectors</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1AISearchIndexSpecInitProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>[Optional] Name of the Delta table to sync the index contents and computed embeddings to</summary>
    [JsonPropertyName("embeddingWritebackTable")]
    public string? EmbeddingWritebackTable { get; set; }

    /// <summary>
    /// Pipeline execution mode. Required on create — the backend rejects an unset value.
    /// Storage Optimized endpoints accept only TRIGGERED; Standard endpoints accept both.
    /// No explicit stage — a REQUIRED field staged below its service would be dropped from
    /// combined specs while remaining in required, tripping the OpenAPI required-vs-properties
    /// consistency check. The field inherits the service&apos;s launch stage. Possible values are: CONTINUOUS, TRIGGERED
    /// </summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>The full name of the source Delta table</summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingSourceColumns
{
    /// <summary>Name of the embedding model endpoint, used by default for both ingestion and querying</summary>
    [JsonPropertyName("embeddingModelEndpoint")]
    public string? EmbeddingModelEndpoint { get; set; }

    /// <summary>Name of the embedding model endpoint which, if specified, is used for querying (not ingestion)</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Specification for a Direct Access index. Set when index_type is DIRECT_ACCESS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecInitProviderDirectAccessIndexSpec
{
    /// <summary>The columns that contain the embedding source</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1AISearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>The columns that contain the embedding vectors</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1AISearchIndexSpecInitProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>
    /// The schema of the index in JSON format. Supported types are integer, long,
    /// float, double, boolean, string, date, timestamp. Supported types for
    /// vector columns: array&lt;float&gt;, array&lt;double&gt;
    /// </summary>
    [JsonPropertyName("schemaJson")]
    public string? SchemaJson { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecInitProviderProviderConfig
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecInitProvider
{
    /// <summary>Specification for a Delta Sync index. Set when index_type is DELTA_SYNC</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public V1beta1AISearchIndexSpecInitProviderDeltaSyncIndexSpec? DeltaSyncIndexSpec { get; set; }

    /// <summary>Specification for a Direct Access index. Set when index_type is DIRECT_ACCESS</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public V1beta1AISearchIndexSpecInitProviderDirectAccessIndexSpec? DirectAccessIndexSpec { get; set; }

    /// <summary>
    /// The user-supplied Unity Catalog table name for the Index, per AIP-133. The server
    /// composes the full Index.name as {parent}/indexes/{index_id}. AIP-133 does not
    /// list index_id as a fields-may-be-required entry, so we annotate it OPTIONAL on the
    /// wire; the server still rejects empty values with INVALID_PARAMETER_VALUE
    /// </summary>
    [JsonPropertyName("indexId")]
    public string? IndexId { get; set; }

    /// <summary>The subtype of the index. Set on create and immutable thereafter. Possible values are: FULL_TEXT, HYBRID, VECTOR</summary>
    [JsonPropertyName("indexSubtype")]
    public string? IndexSubtype { get; set; }

    /// <summary>Type of index. Required on create and immutable thereafter. Possible values are: DELTA_SYNC, DIRECT_ACCESS</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>
    /// The Endpoint where this Index will be created.
    /// Format: workspaces/{workspace_id}/endpoints/{endpoint_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Primary key of the index. Set on create and immutable thereafter</summary>
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1AISearchIndexSpecInitProviderProviderConfig? ProviderConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AISearchIndexSpecManagementPoliciesEnum>))]
public enum V1beta1AISearchIndexSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AISearchIndexSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1AISearchIndexSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AISearchIndexSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1AISearchIndexSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1AISearchIndexSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1AISearchIndexSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AISearchIndexSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AISearchIndexSpec defines the desired state of AISearchIndex</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexSpec
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
    public V1beta1AISearchIndexSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1AISearchIndexSpecForProvider ForProvider { get; set; }

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
    public V1beta1AISearchIndexSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1AISearchIndexSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AISearchIndexSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AISearchIndexSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingSourceColumns
{
    /// <summary>Name of the embedding model endpoint, used by default for both ingestion and querying</summary>
    [JsonPropertyName("embeddingModelEndpoint")]
    public string? EmbeddingModelEndpoint { get; set; }

    /// <summary>Name of the embedding model endpoint which, if specified, is used for querying (not ingestion)</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Specification for a Delta Sync index. Set when index_type is DELTA_SYNC</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexStatusAtProviderDeltaSyncIndexSpec
{
    /// <summary>
    /// [Optional] Select the columns to sync with the index. If left blank, all columns
    /// from the source table are synced. The primary key column and embedding source or
    /// vector column are always synced
    /// </summary>
    [JsonPropertyName("columnsToSync")]
    public IList<string>? ColumnsToSync { get; set; }

    /// <summary>The columns that contain the embedding source</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1AISearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>The columns that contain the embedding vectors</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1AISearchIndexStatusAtProviderDeltaSyncIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>[Optional] Name of the Delta table to sync the index contents and computed embeddings to</summary>
    [JsonPropertyName("embeddingWritebackTable")]
    public string? EmbeddingWritebackTable { get; set; }

    /// <summary>The ID of the pipeline that is used to sync the index</summary>
    [JsonPropertyName("pipelineId")]
    public string? PipelineId { get; set; }

    /// <summary>
    /// Pipeline execution mode. Required on create — the backend rejects an unset value.
    /// Storage Optimized endpoints accept only TRIGGERED; Standard endpoints accept both.
    /// No explicit stage — a REQUIRED field staged below its service would be dropped from
    /// combined specs while remaining in required, tripping the OpenAPI required-vs-properties
    /// consistency check. The field inherits the service&apos;s launch stage. Possible values are: CONTINUOUS, TRIGGERED
    /// </summary>
    [JsonPropertyName("pipelineType")]
    public string? PipelineType { get; set; }

    /// <summary>The full name of the source Delta table</summary>
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingSourceColumns
{
    /// <summary>Name of the embedding model endpoint, used by default for both ingestion and querying</summary>
    [JsonPropertyName("embeddingModelEndpoint")]
    public string? EmbeddingModelEndpoint { get; set; }

    /// <summary>Name of the embedding model endpoint which, if specified, is used for querying (not ingestion)</summary>
    [JsonPropertyName("modelEndpointNameForQuery")]
    public string? ModelEndpointNameForQuery { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingVectorColumns
{
    /// <summary>Dimension of the embedding vector</summary>
    [JsonPropertyName("embeddingDimension")]
    public double? EmbeddingDimension { get; set; }

    /// <summary>Name of the source column</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Specification for a Direct Access index. Set when index_type is DIRECT_ACCESS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexStatusAtProviderDirectAccessIndexSpec
{
    /// <summary>The columns that contain the embedding source</summary>
    [JsonPropertyName("embeddingSourceColumns")]
    public IList<V1beta1AISearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingSourceColumns>? EmbeddingSourceColumns { get; set; }

    /// <summary>The columns that contain the embedding vectors</summary>
    [JsonPropertyName("embeddingVectorColumns")]
    public IList<V1beta1AISearchIndexStatusAtProviderDirectAccessIndexSpecEmbeddingVectorColumns>? EmbeddingVectorColumns { get; set; }

    /// <summary>
    /// The schema of the index in JSON format. Supported types are integer, long,
    /// float, double, boolean, string, date, timestamp. Supported types for
    /// vector columns: array&lt;float&gt;, array&lt;double&gt;
    /// </summary>
    [JsonPropertyName("schemaJson")]
    public string? SchemaJson { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexStatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>Current status of the index</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexStatusAtProviderStatus
{
    /// <summary>Index API URL used to perform operations on the index</summary>
    [JsonPropertyName("indexUrl")]
    public string? IndexUrl { get; set; }

    /// <summary>Number of rows indexed</summary>
    [JsonPropertyName("indexedRowCount")]
    public double? IndexedRowCount { get; set; }

    /// <summary>Human-readable detail about the index&apos;s current state</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Whether the index is ready for search</summary>
    [JsonPropertyName("ready")]
    public bool? Ready { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexStatusAtProvider
{
    /// <summary>Creator of the index</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>Specification for a Delta Sync index. Set when index_type is DELTA_SYNC</summary>
    [JsonPropertyName("deltaSyncIndexSpec")]
    public V1beta1AISearchIndexStatusAtProviderDeltaSyncIndexSpec? DeltaSyncIndexSpec { get; set; }

    /// <summary>Specification for a Direct Access index. Set when index_type is DIRECT_ACCESS</summary>
    [JsonPropertyName("directAccessIndexSpec")]
    public V1beta1AISearchIndexStatusAtProviderDirectAccessIndexSpec? DirectAccessIndexSpec { get; set; }

    /// <summary>
    /// Name of the endpoint associated with the index. Ignored on create — the endpoint is
    /// taken from CreateIndexRequest.parent; populated only on output
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The user-supplied Unity Catalog table name for the Index, per AIP-133. The server
    /// composes the full Index.name as {parent}/indexes/{index_id}. AIP-133 does not
    /// list index_id as a fields-may-be-required entry, so we annotate it OPTIONAL on the
    /// wire; the server still rejects empty values with INVALID_PARAMETER_VALUE
    /// </summary>
    [JsonPropertyName("indexId")]
    public string? IndexId { get; set; }

    /// <summary>The subtype of the index. Set on create and immutable thereafter. Possible values are: FULL_TEXT, HYBRID, VECTOR</summary>
    [JsonPropertyName("indexSubtype")]
    public string? IndexSubtype { get; set; }

    /// <summary>Type of index. Required on create and immutable thereafter. Possible values are: DELTA_SYNC, DIRECT_ACCESS</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>
    /// The Endpoint where this Index will be created.
    /// Format: workspaces/{workspace_id}/endpoints/{endpoint_id}
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Primary key of the index. Set on create and immutable thereafter</summary>
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1AISearchIndexStatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Current status of the index</summary>
    [JsonPropertyName("status")]
    public V1beta1AISearchIndexStatusAtProviderStatus? Status { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexStatusConditions
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

/// <summary>AISearchIndexStatus defines the observed state of AISearchIndex.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AISearchIndexStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1AISearchIndexStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AISearchIndexStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AISearchIndex is the Schema for the AISearchIndexs API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AISearchIndex : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AISearchIndexSpec>, IStatus<V1beta1AISearchIndexStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AISearchIndex";
    public const string KubeGroup = "ai.databricks.crossplane.io";
    public const string KubePluralName = "aisearchindices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ai.databricks.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AISearchIndex";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AISearchIndexSpec defines the desired state of AISearchIndex</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AISearchIndexSpec Spec { get; set; }

    /// <summary>AISearchIndexStatus defines the observed state of AISearchIndex.</summary>
    [JsonPropertyName("status")]
    public V1beta1AISearchIndexStatus? Status { get; set; }
}