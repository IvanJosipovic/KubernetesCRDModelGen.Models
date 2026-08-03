#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firestore.gcp.upbound.io;
/// <summary>Index is the Schema for the Indexs API. Cloud Firestore indexes enable simple and complex queries against documents in a database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1IndexList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Index>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "IndexList";
    public const string KubeGroup = "firestore.gcp.upbound.io";
    public const string KubePluralName = "indices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IndexList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Index objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Index> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecDeletionPolicyEnum>))]
public enum V1beta1IndexSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecForProviderDatabaseRefPolicyResolutionEnum>))]
public enum V1beta1IndexSpecForProviderDatabaseRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecForProviderDatabaseRefPolicyResolveEnum>))]
public enum V1beta1IndexSpecForProviderDatabaseRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderDatabaseRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1IndexSpecForProviderDatabaseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1IndexSpecForProviderDatabaseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Database in firestore to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderDatabaseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IndexSpecForProviderDatabaseRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecForProviderDatabaseSelectorPolicyResolutionEnum>))]
public enum V1beta1IndexSpecForProviderDatabaseSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecForProviderDatabaseSelectorPolicyResolveEnum>))]
public enum V1beta1IndexSpecForProviderDatabaseSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderDatabaseSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1IndexSpecForProviderDatabaseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1IndexSpecForProviderDatabaseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Database in firestore to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderDatabaseSelector
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
    public V1beta1IndexSpecForProviderDatabaseSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The specification for building a geo search index for a field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderFieldsSearchConfigGeoSpec
{
    /// <summary>
    /// If true, disables GeoJSON indexing for the field. By default, GeoJSON points are indexed.
    /// Firestore GeoPoints are indexed regardless of the value of this field.
    /// </summary>
    [JsonPropertyName("geoJsonIndexingDisabled")]
    public bool? GeoJsonIndexingDisabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderFieldsSearchConfigTextSpecIndexSpecs
{
    /// <summary>Ways to index the text field value.</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>How to match the text field value.</summary>
    [JsonPropertyName("matchType")]
    public string? MatchType { get; set; }
}

/// <summary>
/// The specification for building a text search index for a field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderFieldsSearchConfigTextSpec
{
    /// <summary>
    /// Specifications for how the field should be indexed. Repeated so that the field can be indexed in multiple ways.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("indexSpecs")]
    public IList<V1beta1IndexSpecForProviderFieldsSearchConfigTextSpecIndexSpecs>? IndexSpecs { get; set; }
}

/// <summary>
/// Indicates that this field supports text or geo-search operations. Only one of order, arrayConfig, searchConfig and
/// vectorConfig can be specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderFieldsSearchConfig
{
    /// <summary>
    /// The specification for building a geo search index for a field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("geoSpec")]
    public V1beta1IndexSpecForProviderFieldsSearchConfigGeoSpec? GeoSpec { get; set; }

    /// <summary>
    /// The specification for building a text search index for a field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("textSpec")]
    public V1beta1IndexSpecForProviderFieldsSearchConfigTextSpec? TextSpec { get; set; }
}

/// <summary>Indicates the vector index is a flat index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderFieldsVectorConfigFlat
{
}

/// <summary>
/// Indicates that this field supports vector search operations. Only one of order, arrayConfig, searchConfig and
/// vectorConfig can be specified. Vector Fields should come after the field path __name__.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderFieldsVectorConfig
{
    /// <summary>
    /// The resulting index will only include vectors of this dimension, and can be used for vector search
    /// with the same dimension.
    /// </summary>
    [JsonPropertyName("dimension")]
    public double? Dimension { get; set; }

    /// <summary>Indicates the vector index is a flat index.</summary>
    [JsonPropertyName("flat")]
    public V1beta1IndexSpecForProviderFieldsVectorConfigFlat? Flat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProviderFields
{
    /// <summary>
    /// Indicates that this field supports operations on arrayValues. Only one of order, arrayConfig, searchConfig and
    /// vectorConfig can be specified.
    /// Possible values are: CONTAINS.
    /// </summary>
    [JsonPropertyName("arrayConfig")]
    public string? ArrayConfig { get; set; }

    /// <summary>Name of the field.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>
    /// Indicates that this field supports ordering by the specified order or comparing using =, &lt;, &lt;=, &gt;, &gt;=.
    /// Only one of order, arrayConfig, searchConfig and vectorConfig can be specified.
    /// Possible values are: ASCENDING, DESCENDING.
    /// </summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>
    /// Indicates that this field supports text or geo-search operations. Only one of order, arrayConfig, searchConfig and
    /// vectorConfig can be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("searchConfig")]
    public V1beta1IndexSpecForProviderFieldsSearchConfig? SearchConfig { get; set; }

    /// <summary>
    /// Indicates that this field supports vector search operations. Only one of order, arrayConfig, searchConfig and
    /// vectorConfig can be specified. Vector Fields should come after the field path __name__.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vectorConfig")]
    public V1beta1IndexSpecForProviderFieldsVectorConfig? VectorConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecForProvider
{
    /// <summary>
    /// The API scope at which a query is run.
    /// Default value is ANY_API.
    /// Possible values are: ANY_API, DATASTORE_MODE_API, MONGODB_COMPATIBLE_API.
    /// </summary>
    [JsonPropertyName("apiScope")]
    public string? ApiScope { get; set; }

    /// <summary>The collection being indexed.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>The Firestore database id. Defaults to &quot;(default)&quot;.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to a Database in firestore to populate database.</summary>
    [JsonPropertyName("databaseRef")]
    public V1beta1IndexSpecForProviderDatabaseRef? DatabaseRef { get; set; }

    /// <summary>Selector for a Database in firestore to populate database.</summary>
    [JsonPropertyName("databaseSelector")]
    public V1beta1IndexSpecForProviderDatabaseSelector? DatabaseSelector { get; set; }

    /// <summary>
    /// Defaults to DELETE.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// The density configuration for this index.
    /// Possible values are: SPARSE_ALL, SPARSE_ANY, DENSE.
    /// </summary>
    [JsonPropertyName("density")]
    public string? Density { get; set; }

    /// <summary>
    /// The fields supported by this index. The last non-stored field entry is
    /// always for the field path __name__. If, on creation, __name__ was not
    /// specified as the last field, it will be added automatically with the same
    /// direction as that of the last field defined. If the final field in a
    /// composite index is not directional, the __name__ will be ordered
    /// &quot;ASCENDING&quot; (unless explicitly specified otherwise).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1IndexSpecForProviderFields>? Fields { get; set; }

    /// <summary>Optional. Whether the index is multikey. By default, the index is not multikey. For non-multikey indexes, none of the paths in the index definition reach or traverse an array, except via an explicit array index. For multikey indexes, at most one of the paths in the index definition reach or traverse an array, except via an explicit array index. Violations will result in errors. Note this field only applies to indexes with MONGODB_COMPATIBLE_API ApiScope.</summary>
    [JsonPropertyName("multikey")]
    public bool? Multikey { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The scope at which a query is run.
    /// Default value is COLLECTION.
    /// Possible values are: COLLECTION, COLLECTION_GROUP, COLLECTION_RECURSIVE.
    /// </summary>
    [JsonPropertyName("queryScope")]
    public string? QueryScope { get; set; }

    /// <summary>Whether to skip waiting for the index to be created.</summary>
    [JsonPropertyName("skipWait")]
    public bool? SkipWait { get; set; }

    /// <summary>Whether it is an unique index. Unique index ensures all values for the indexed field(s) are unique across documents.</summary>
    [JsonPropertyName("unique")]
    public bool? Unique { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecInitProviderDatabaseRefPolicyResolutionEnum>))]
public enum V1beta1IndexSpecInitProviderDatabaseRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecInitProviderDatabaseRefPolicyResolveEnum>))]
public enum V1beta1IndexSpecInitProviderDatabaseRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderDatabaseRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1IndexSpecInitProviderDatabaseRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1IndexSpecInitProviderDatabaseRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Database in firestore to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderDatabaseRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IndexSpecInitProviderDatabaseRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecInitProviderDatabaseSelectorPolicyResolutionEnum>))]
public enum V1beta1IndexSpecInitProviderDatabaseSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecInitProviderDatabaseSelectorPolicyResolveEnum>))]
public enum V1beta1IndexSpecInitProviderDatabaseSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderDatabaseSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1IndexSpecInitProviderDatabaseSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1IndexSpecInitProviderDatabaseSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Database in firestore to populate database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderDatabaseSelector
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
    public V1beta1IndexSpecInitProviderDatabaseSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The specification for building a geo search index for a field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderFieldsSearchConfigGeoSpec
{
    /// <summary>
    /// If true, disables GeoJSON indexing for the field. By default, GeoJSON points are indexed.
    /// Firestore GeoPoints are indexed regardless of the value of this field.
    /// </summary>
    [JsonPropertyName("geoJsonIndexingDisabled")]
    public bool? GeoJsonIndexingDisabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderFieldsSearchConfigTextSpecIndexSpecs
{
    /// <summary>Ways to index the text field value.</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>How to match the text field value.</summary>
    [JsonPropertyName("matchType")]
    public string? MatchType { get; set; }
}

/// <summary>
/// The specification for building a text search index for a field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderFieldsSearchConfigTextSpec
{
    /// <summary>
    /// Specifications for how the field should be indexed. Repeated so that the field can be indexed in multiple ways.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("indexSpecs")]
    public IList<V1beta1IndexSpecInitProviderFieldsSearchConfigTextSpecIndexSpecs>? IndexSpecs { get; set; }
}

/// <summary>
/// Indicates that this field supports text or geo-search operations. Only one of order, arrayConfig, searchConfig and
/// vectorConfig can be specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderFieldsSearchConfig
{
    /// <summary>
    /// The specification for building a geo search index for a field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("geoSpec")]
    public V1beta1IndexSpecInitProviderFieldsSearchConfigGeoSpec? GeoSpec { get; set; }

    /// <summary>
    /// The specification for building a text search index for a field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("textSpec")]
    public V1beta1IndexSpecInitProviderFieldsSearchConfigTextSpec? TextSpec { get; set; }
}

/// <summary>Indicates the vector index is a flat index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderFieldsVectorConfigFlat
{
}

/// <summary>
/// Indicates that this field supports vector search operations. Only one of order, arrayConfig, searchConfig and
/// vectorConfig can be specified. Vector Fields should come after the field path __name__.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderFieldsVectorConfig
{
    /// <summary>
    /// The resulting index will only include vectors of this dimension, and can be used for vector search
    /// with the same dimension.
    /// </summary>
    [JsonPropertyName("dimension")]
    public double? Dimension { get; set; }

    /// <summary>Indicates the vector index is a flat index.</summary>
    [JsonPropertyName("flat")]
    public V1beta1IndexSpecInitProviderFieldsVectorConfigFlat? Flat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecInitProviderFields
{
    /// <summary>
    /// Indicates that this field supports operations on arrayValues. Only one of order, arrayConfig, searchConfig and
    /// vectorConfig can be specified.
    /// Possible values are: CONTAINS.
    /// </summary>
    [JsonPropertyName("arrayConfig")]
    public string? ArrayConfig { get; set; }

    /// <summary>Name of the field.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>
    /// Indicates that this field supports ordering by the specified order or comparing using =, &lt;, &lt;=, &gt;, &gt;=.
    /// Only one of order, arrayConfig, searchConfig and vectorConfig can be specified.
    /// Possible values are: ASCENDING, DESCENDING.
    /// </summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>
    /// Indicates that this field supports text or geo-search operations. Only one of order, arrayConfig, searchConfig and
    /// vectorConfig can be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("searchConfig")]
    public V1beta1IndexSpecInitProviderFieldsSearchConfig? SearchConfig { get; set; }

    /// <summary>
    /// Indicates that this field supports vector search operations. Only one of order, arrayConfig, searchConfig and
    /// vectorConfig can be specified. Vector Fields should come after the field path __name__.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vectorConfig")]
    public V1beta1IndexSpecInitProviderFieldsVectorConfig? VectorConfig { get; set; }
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
public partial class V1beta1IndexSpecInitProvider
{
    /// <summary>
    /// The API scope at which a query is run.
    /// Default value is ANY_API.
    /// Possible values are: ANY_API, DATASTORE_MODE_API, MONGODB_COMPATIBLE_API.
    /// </summary>
    [JsonPropertyName("apiScope")]
    public string? ApiScope { get; set; }

    /// <summary>The collection being indexed.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>The Firestore database id. Defaults to &quot;(default)&quot;.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>Reference to a Database in firestore to populate database.</summary>
    [JsonPropertyName("databaseRef")]
    public V1beta1IndexSpecInitProviderDatabaseRef? DatabaseRef { get; set; }

    /// <summary>Selector for a Database in firestore to populate database.</summary>
    [JsonPropertyName("databaseSelector")]
    public V1beta1IndexSpecInitProviderDatabaseSelector? DatabaseSelector { get; set; }

    /// <summary>
    /// Defaults to DELETE.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// The density configuration for this index.
    /// Possible values are: SPARSE_ALL, SPARSE_ANY, DENSE.
    /// </summary>
    [JsonPropertyName("density")]
    public string? Density { get; set; }

    /// <summary>
    /// The fields supported by this index. The last non-stored field entry is
    /// always for the field path __name__. If, on creation, __name__ was not
    /// specified as the last field, it will be added automatically with the same
    /// direction as that of the last field defined. If the final field in a
    /// composite index is not directional, the __name__ will be ordered
    /// &quot;ASCENDING&quot; (unless explicitly specified otherwise).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1IndexSpecInitProviderFields>? Fields { get; set; }

    /// <summary>Optional. Whether the index is multikey. By default, the index is not multikey. For non-multikey indexes, none of the paths in the index definition reach or traverse an array, except via an explicit array index. For multikey indexes, at most one of the paths in the index definition reach or traverse an array, except via an explicit array index. Violations will result in errors. Note this field only applies to indexes with MONGODB_COMPATIBLE_API ApiScope.</summary>
    [JsonPropertyName("multikey")]
    public bool? Multikey { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The scope at which a query is run.
    /// Default value is COLLECTION.
    /// Possible values are: COLLECTION, COLLECTION_GROUP, COLLECTION_RECURSIVE.
    /// </summary>
    [JsonPropertyName("queryScope")]
    public string? QueryScope { get; set; }

    /// <summary>Whether to skip waiting for the index to be created.</summary>
    [JsonPropertyName("skipWait")]
    public bool? SkipWait { get; set; }

    /// <summary>Whether it is an unique index. Unique index ensures all values for the indexed field(s) are unique across documents.</summary>
    [JsonPropertyName("unique")]
    public bool? Unique { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecManagementPoliciesEnum>))]
public enum V1beta1IndexSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1IndexSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1IndexSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1IndexSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1IndexSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1IndexSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1IndexSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>IndexSpec defines the desired state of Index</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexSpec
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
    public V1beta1IndexSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1IndexSpecForProvider ForProvider { get; set; }

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
    public V1beta1IndexSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1IndexSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1IndexSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1IndexSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The specification for building a geo search index for a field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderFieldsSearchConfigGeoSpec
{
    /// <summary>
    /// If true, disables GeoJSON indexing for the field. By default, GeoJSON points are indexed.
    /// Firestore GeoPoints are indexed regardless of the value of this field.
    /// </summary>
    [JsonPropertyName("geoJsonIndexingDisabled")]
    public bool? GeoJsonIndexingDisabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderFieldsSearchConfigTextSpecIndexSpecs
{
    /// <summary>Ways to index the text field value.</summary>
    [JsonPropertyName("indexType")]
    public string? IndexType { get; set; }

    /// <summary>How to match the text field value.</summary>
    [JsonPropertyName("matchType")]
    public string? MatchType { get; set; }
}

/// <summary>
/// The specification for building a text search index for a field.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderFieldsSearchConfigTextSpec
{
    /// <summary>
    /// Specifications for how the field should be indexed. Repeated so that the field can be indexed in multiple ways.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("indexSpecs")]
    public IList<V1beta1IndexStatusAtProviderFieldsSearchConfigTextSpecIndexSpecs>? IndexSpecs { get; set; }
}

/// <summary>
/// Indicates that this field supports text or geo-search operations. Only one of order, arrayConfig, searchConfig and
/// vectorConfig can be specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderFieldsSearchConfig
{
    /// <summary>
    /// The specification for building a geo search index for a field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("geoSpec")]
    public V1beta1IndexStatusAtProviderFieldsSearchConfigGeoSpec? GeoSpec { get; set; }

    /// <summary>
    /// The specification for building a text search index for a field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("textSpec")]
    public V1beta1IndexStatusAtProviderFieldsSearchConfigTextSpec? TextSpec { get; set; }
}

/// <summary>Indicates the vector index is a flat index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderFieldsVectorConfigFlat
{
}

/// <summary>
/// Indicates that this field supports vector search operations. Only one of order, arrayConfig, searchConfig and
/// vectorConfig can be specified. Vector Fields should come after the field path __name__.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderFieldsVectorConfig
{
    /// <summary>
    /// The resulting index will only include vectors of this dimension, and can be used for vector search
    /// with the same dimension.
    /// </summary>
    [JsonPropertyName("dimension")]
    public double? Dimension { get; set; }

    /// <summary>Indicates the vector index is a flat index.</summary>
    [JsonPropertyName("flat")]
    public V1beta1IndexStatusAtProviderFieldsVectorConfigFlat? Flat { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProviderFields
{
    /// <summary>
    /// Indicates that this field supports operations on arrayValues. Only one of order, arrayConfig, searchConfig and
    /// vectorConfig can be specified.
    /// Possible values are: CONTAINS.
    /// </summary>
    [JsonPropertyName("arrayConfig")]
    public string? ArrayConfig { get; set; }

    /// <summary>Name of the field.</summary>
    [JsonPropertyName("fieldPath")]
    public string? FieldPath { get; set; }

    /// <summary>
    /// Indicates that this field supports ordering by the specified order or comparing using =, &lt;, &lt;=, &gt;, &gt;=.
    /// Only one of order, arrayConfig, searchConfig and vectorConfig can be specified.
    /// Possible values are: ASCENDING, DESCENDING.
    /// </summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>
    /// Indicates that this field supports text or geo-search operations. Only one of order, arrayConfig, searchConfig and
    /// vectorConfig can be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("searchConfig")]
    public V1beta1IndexStatusAtProviderFieldsSearchConfig? SearchConfig { get; set; }

    /// <summary>
    /// Indicates that this field supports vector search operations. Only one of order, arrayConfig, searchConfig and
    /// vectorConfig can be specified. Vector Fields should come after the field path __name__.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vectorConfig")]
    public V1beta1IndexStatusAtProviderFieldsVectorConfig? VectorConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusAtProvider
{
    /// <summary>
    /// The API scope at which a query is run.
    /// Default value is ANY_API.
    /// Possible values are: ANY_API, DATASTORE_MODE_API, MONGODB_COMPATIBLE_API.
    /// </summary>
    [JsonPropertyName("apiScope")]
    public string? ApiScope { get; set; }

    /// <summary>The collection being indexed.</summary>
    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    /// <summary>The Firestore database id. Defaults to &quot;(default)&quot;.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>
    /// Defaults to DELETE.
    /// When set to &quot;DELETE&quot;, deleting the resource is allowed.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>
    /// The density configuration for this index.
    /// Possible values are: SPARSE_ALL, SPARSE_ANY, DENSE.
    /// </summary>
    [JsonPropertyName("density")]
    public string? Density { get; set; }

    /// <summary>
    /// The fields supported by this index. The last non-stored field entry is
    /// always for the field path __name__. If, on creation, __name__ was not
    /// specified as the last field, it will be added automatically with the same
    /// direction as that of the last field defined. If the final field in a
    /// composite index is not directional, the __name__ will be ordered
    /// &quot;ASCENDING&quot; (unless explicitly specified otherwise).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta1IndexStatusAtProviderFields>? Fields { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Optional. Whether the index is multikey. By default, the index is not multikey. For non-multikey indexes, none of the paths in the index definition reach or traverse an array, except via an explicit array index. For multikey indexes, at most one of the paths in the index definition reach or traverse an array, except via an explicit array index. Violations will result in errors. Note this field only applies to indexes with MONGODB_COMPATIBLE_API ApiScope.</summary>
    [JsonPropertyName("multikey")]
    public bool? Multikey { get; set; }

    /// <summary>
    /// A server defined name for this index. Format:
    /// projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/indexes/{{server_generated_id}}
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The scope at which a query is run.
    /// Default value is COLLECTION.
    /// Possible values are: COLLECTION, COLLECTION_GROUP, COLLECTION_RECURSIVE.
    /// </summary>
    [JsonPropertyName("queryScope")]
    public string? QueryScope { get; set; }

    /// <summary>Whether to skip waiting for the index to be created.</summary>
    [JsonPropertyName("skipWait")]
    public bool? SkipWait { get; set; }

    /// <summary>Whether it is an unique index. Unique index ensures all values for the indexed field(s) are unique across documents.</summary>
    [JsonPropertyName("unique")]
    public bool? Unique { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatusConditions
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

/// <summary>IndexStatus defines the observed state of Index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1IndexStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1IndexStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1IndexStatusConditions>? Conditions { get; set; }

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

/// <summary>Index is the Schema for the Indexs API. Cloud Firestore indexes enable simple and complex queries against documents in a database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Index : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1IndexSpec>, IStatus<V1beta1IndexStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Index";
    public const string KubeGroup = "firestore.gcp.upbound.io";
    public const string KubePluralName = "indices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.gcp.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Index";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>IndexSpec defines the desired state of Index</summary>
    [JsonPropertyName("spec")]
    public required V1beta1IndexSpec Spec { get; set; }

    /// <summary>IndexStatus defines the observed state of Index.</summary>
    [JsonPropertyName("status")]
    public V1beta1IndexStatus? Status { get; set; }
}