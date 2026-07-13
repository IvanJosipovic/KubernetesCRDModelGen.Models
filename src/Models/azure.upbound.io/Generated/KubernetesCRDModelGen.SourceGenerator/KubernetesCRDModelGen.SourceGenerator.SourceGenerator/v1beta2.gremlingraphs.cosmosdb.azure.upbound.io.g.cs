#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cosmosdb.azure.upbound.io;
/// <summary>GremlinGraph is the Schema for the GremlinGraphs API. Manages a Gremlin Graph within a Cosmos DB Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2GremlinGraphList : IKubernetesObject<V1ListMeta>, IItems<V1beta2GremlinGraph>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "GremlinGraphList";
    public const string KubeGroup = "cosmosdb.azure.upbound.io";
    public const string KubePluralName = "gremlingraphs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cosmosdb.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GremlinGraphList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2GremlinGraph objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2GremlinGraph> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecDeletionPolicyEnum>))]
public enum V1beta2GremlinGraphSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderAccountNameRefPolicyResolutionEnum>))]
public enum V1beta2GremlinGraphSpecForProviderAccountNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderAccountNameRefPolicyResolveEnum>))]
public enum V1beta2GremlinGraphSpecForProviderAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderAccountNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GremlinGraphSpecForProviderAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GremlinGraphSpecForProviderAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in cosmosdb to populate accountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GremlinGraphSpecForProviderAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderAccountNameSelectorPolicyResolutionEnum>))]
public enum V1beta2GremlinGraphSpecForProviderAccountNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderAccountNameSelectorPolicyResolveEnum>))]
public enum V1beta2GremlinGraphSpecForProviderAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderAccountNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GremlinGraphSpecForProviderAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GremlinGraphSpecForProviderAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in cosmosdb to populate accountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderAccountNameSelector
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
    public V1beta2GremlinGraphSpecForProviderAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the Gremlin graph (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderConflictResolutionPolicy
{
    /// <summary>The conflict resolution path in the case of LastWriterWins mode.</summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary>The procedure to resolve conflicts in the case of custom mode.</summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary>Indicates the conflict resolution mode. Possible values include: LastWriterWins, Custom.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderDatabaseNameRefPolicyResolutionEnum>))]
public enum V1beta2GremlinGraphSpecForProviderDatabaseNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderDatabaseNameRefPolicyResolveEnum>))]
public enum V1beta2GremlinGraphSpecForProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GremlinGraphSpecForProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GremlinGraphSpecForProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GremlinDatabase in cosmosdb to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GremlinGraphSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolutionEnum>))]
public enum V1beta2GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolveEnum>))]
public enum V1beta2GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GremlinDatabase in cosmosdb to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderDatabaseNameSelector
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
    public V1beta2GremlinGraphSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderIndexPolicyCompositeIndexIndex
{
    /// <summary>Order of the index. Possible values are Ascending or Descending.</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderIndexPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta2GremlinGraphSpecForProviderIndexPolicyCompositeIndexIndex>? Index { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderIndexPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>The configuration of the indexing policy. One or more index_policy blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderIndexPolicy
{
    /// <summary>Indicates if the indexing policy is automatic. Defaults to true.</summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta2GremlinGraphSpecForProviderIndexPolicyCompositeIndex>? CompositeIndex { get; set; }

    /// <summary>List of paths to exclude from indexing. Required if indexing_mode is Consistent or Lazy.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>List of paths to include in the indexing. Required if indexing_mode is Consistent or Lazy.</summary>
    [JsonPropertyName("includedPaths")]
    public IList<string>? IncludedPaths { get; set; }

    /// <summary>Indicates the indexing mode. Possible values include: Consistent, Lazy, None.</summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary>One or more spatial_index blocks as defined below.</summary>
    [JsonPropertyName("spatialIndex")]
    public IList<V1beta2GremlinGraphSpecForProviderIndexPolicySpatialIndex>? SpatialIndex { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GremlinGraphSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderResourceGroupNameSelector
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
    public V1beta2GremlinGraphSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProviderUniqueKey
{
    /// <summary>A list of paths to use for this unique key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecForProvider
{
    /// <summary>The name of the CosmosDB Account to create the Gremlin Graph within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Reference to a Account in cosmosdb to populate accountName.</summary>
    [JsonPropertyName("accountNameRef")]
    public V1beta2GremlinGraphSpecForProviderAccountNameRef? AccountNameRef { get; set; }

    /// <summary>Selector for a Account in cosmosdb to populate accountName.</summary>
    [JsonPropertyName("accountNameSelector")]
    public V1beta2GremlinGraphSpecForProviderAccountNameSelector? AccountNameSelector { get; set; }

    /// <summary>The time to live of Analytical Storage for this Cosmos DB Gremlin Graph. Possible values are between -1 to 2147483647 not including 0. If present and the value is set to -1, it means never expire.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta2GremlinGraphSpecForProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta2GremlinGraphSpecForProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>The name of the Cosmos DB Graph Database in which the Cosmos DB Gremlin Graph is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a GremlinDatabase in cosmosdb to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta2GremlinGraphSpecForProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a GremlinDatabase in cosmosdb to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta2GremlinGraphSpecForProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>The default time to live (TTL) of the Gremlin graph. If the value is missing or set to &quot;-1&quot;, items don’t expire.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>The configuration of the indexing policy. One or more index_policy blocks as defined below.</summary>
    [JsonPropertyName("indexPolicy")]
    public V1beta2GremlinGraphSpecForProviderIndexPolicy? IndexPolicy { get; set; }

    /// <summary>Define a partition key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyPath")]
    public string? PartitionKeyPath { get; set; }

    /// <summary>Define a partition key version. Changing this forces a new resource to be created. Possible values are 1and 2. This should be set to 2 in order to use large partition keys.</summary>
    [JsonPropertyName("partitionKeyVersion")]
    public double? PartitionKeyVersion { get; set; }

    /// <summary>The name of the resource group in which the Cosmos DB Gremlin Graph is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2GremlinGraphSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2GremlinGraphSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The throughput of the Gremlin graph (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>One or more unique_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uniqueKey")]
    public IList<V1beta2GremlinGraphSpecForProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecInitProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the Gremlin graph (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecInitProviderConflictResolutionPolicy
{
    /// <summary>The conflict resolution path in the case of LastWriterWins mode.</summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary>The procedure to resolve conflicts in the case of custom mode.</summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary>Indicates the conflict resolution mode. Possible values include: LastWriterWins, Custom.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecInitProviderIndexPolicyCompositeIndexIndex
{
    /// <summary>Order of the index. Possible values are Ascending or Descending.</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecInitProviderIndexPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta2GremlinGraphSpecInitProviderIndexPolicyCompositeIndexIndex>? Index { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecInitProviderIndexPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>The configuration of the indexing policy. One or more index_policy blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecInitProviderIndexPolicy
{
    /// <summary>Indicates if the indexing policy is automatic. Defaults to true.</summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta2GremlinGraphSpecInitProviderIndexPolicyCompositeIndex>? CompositeIndex { get; set; }

    /// <summary>List of paths to exclude from indexing. Required if indexing_mode is Consistent or Lazy.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>List of paths to include in the indexing. Required if indexing_mode is Consistent or Lazy.</summary>
    [JsonPropertyName("includedPaths")]
    public IList<string>? IncludedPaths { get; set; }

    /// <summary>Indicates the indexing mode. Possible values include: Consistent, Lazy, None.</summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary>One or more spatial_index blocks as defined below.</summary>
    [JsonPropertyName("spatialIndex")]
    public IList<V1beta2GremlinGraphSpecInitProviderIndexPolicySpatialIndex>? SpatialIndex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecInitProviderUniqueKey
{
    /// <summary>A list of paths to use for this unique key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
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
public partial class V1beta2GremlinGraphSpecInitProvider
{
    /// <summary>The time to live of Analytical Storage for this Cosmos DB Gremlin Graph. Possible values are between -1 to 2147483647 not including 0. If present and the value is set to -1, it means never expire.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta2GremlinGraphSpecInitProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta2GremlinGraphSpecInitProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>The default time to live (TTL) of the Gremlin graph. If the value is missing or set to &quot;-1&quot;, items don’t expire.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>The configuration of the indexing policy. One or more index_policy blocks as defined below.</summary>
    [JsonPropertyName("indexPolicy")]
    public V1beta2GremlinGraphSpecInitProviderIndexPolicy? IndexPolicy { get; set; }

    /// <summary>Define a partition key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyPath")]
    public string? PartitionKeyPath { get; set; }

    /// <summary>Define a partition key version. Changing this forces a new resource to be created. Possible values are 1and 2. This should be set to 2 in order to use large partition keys.</summary>
    [JsonPropertyName("partitionKeyVersion")]
    public double? PartitionKeyVersion { get; set; }

    /// <summary>The throughput of the Gremlin graph (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>One or more unique_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uniqueKey")]
    public IList<V1beta2GremlinGraphSpecInitProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecManagementPoliciesEnum>))]
public enum V1beta2GremlinGraphSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2GremlinGraphSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2GremlinGraphSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2GremlinGraphSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2GremlinGraphSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2GremlinGraphSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2GremlinGraphSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>GremlinGraphSpec defines the desired state of GremlinGraph</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphSpec
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
    public V1beta2GremlinGraphSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2GremlinGraphSpecForProvider ForProvider { get; set; }

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
    public V1beta2GremlinGraphSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2GremlinGraphSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2GremlinGraphSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2GremlinGraphSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphStatusAtProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the Gremlin graph (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphStatusAtProviderConflictResolutionPolicy
{
    /// <summary>The conflict resolution path in the case of LastWriterWins mode.</summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary>The procedure to resolve conflicts in the case of custom mode.</summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary>Indicates the conflict resolution mode. Possible values include: LastWriterWins, Custom.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphStatusAtProviderIndexPolicyCompositeIndexIndex
{
    /// <summary>Order of the index. Possible values are Ascending or Descending.</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphStatusAtProviderIndexPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta2GremlinGraphStatusAtProviderIndexPolicyCompositeIndexIndex>? Index { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphStatusAtProviderIndexPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>The configuration of the indexing policy. One or more index_policy blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphStatusAtProviderIndexPolicy
{
    /// <summary>Indicates if the indexing policy is automatic. Defaults to true.</summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta2GremlinGraphStatusAtProviderIndexPolicyCompositeIndex>? CompositeIndex { get; set; }

    /// <summary>List of paths to exclude from indexing. Required if indexing_mode is Consistent or Lazy.</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<string>? ExcludedPaths { get; set; }

    /// <summary>List of paths to include in the indexing. Required if indexing_mode is Consistent or Lazy.</summary>
    [JsonPropertyName("includedPaths")]
    public IList<string>? IncludedPaths { get; set; }

    /// <summary>Indicates the indexing mode. Possible values include: Consistent, Lazy, None.</summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary>One or more spatial_index blocks as defined below.</summary>
    [JsonPropertyName("spatialIndex")]
    public IList<V1beta2GremlinGraphStatusAtProviderIndexPolicySpatialIndex>? SpatialIndex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphStatusAtProviderUniqueKey
{
    /// <summary>A list of paths to use for this unique key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphStatusAtProvider
{
    /// <summary>The name of the CosmosDB Account to create the Gremlin Graph within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The time to live of Analytical Storage for this Cosmos DB Gremlin Graph. Possible values are between -1 to 2147483647 not including 0. If present and the value is set to -1, it means never expire.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta2GremlinGraphStatusAtProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta2GremlinGraphStatusAtProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>The name of the Cosmos DB Graph Database in which the Cosmos DB Gremlin Graph is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The default time to live (TTL) of the Gremlin graph. If the value is missing or set to &quot;-1&quot;, items don’t expire.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>The ID of the CosmosDB Gremlin Graph.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The configuration of the indexing policy. One or more index_policy blocks as defined below.</summary>
    [JsonPropertyName("indexPolicy")]
    public V1beta2GremlinGraphStatusAtProviderIndexPolicy? IndexPolicy { get; set; }

    /// <summary>Define a partition key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyPath")]
    public string? PartitionKeyPath { get; set; }

    /// <summary>Define a partition key version. Changing this forces a new resource to be created. Possible values are 1and 2. This should be set to 2 in order to use large partition keys.</summary>
    [JsonPropertyName("partitionKeyVersion")]
    public double? PartitionKeyVersion { get; set; }

    /// <summary>The name of the resource group in which the Cosmos DB Gremlin Graph is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The throughput of the Gremlin graph (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>One or more unique_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uniqueKey")]
    public IList<V1beta2GremlinGraphStatusAtProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphStatusConditions
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

/// <summary>GremlinGraphStatus defines the observed state of GremlinGraph.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2GremlinGraphStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2GremlinGraphStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2GremlinGraphStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GremlinGraph is the Schema for the GremlinGraphs API. Manages a Gremlin Graph within a Cosmos DB Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2GremlinGraph : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2GremlinGraphSpec>, IStatus<V1beta2GremlinGraphStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "GremlinGraph";
    public const string KubeGroup = "cosmosdb.azure.upbound.io";
    public const string KubePluralName = "gremlingraphs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cosmosdb.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GremlinGraph";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GremlinGraphSpec defines the desired state of GremlinGraph</summary>
    [JsonPropertyName("spec")]
    public required V1beta2GremlinGraphSpec Spec { get; set; }

    /// <summary>GremlinGraphStatus defines the observed state of GremlinGraph.</summary>
    [JsonPropertyName("status")]
    public V1beta2GremlinGraphStatus? Status { get; set; }
}