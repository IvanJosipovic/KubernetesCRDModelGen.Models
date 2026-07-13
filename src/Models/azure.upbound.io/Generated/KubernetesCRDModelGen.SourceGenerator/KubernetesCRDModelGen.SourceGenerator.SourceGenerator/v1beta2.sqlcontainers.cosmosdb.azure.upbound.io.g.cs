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
/// <summary>SQLContainer is the Schema for the SQLContainers API. Manages a SQL Container within a Cosmos DB Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SQLContainerList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SQLContainer>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SQLContainerList";
    public const string KubeGroup = "cosmosdb.azure.upbound.io";
    public const string KubePluralName = "sqlcontainers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cosmosdb.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SQLContainerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SQLContainer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SQLContainer> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecDeletionPolicyEnum>))]
public enum V1beta2SQLContainerSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderAccountNameRefPolicyResolutionEnum>))]
public enum V1beta2SQLContainerSpecForProviderAccountNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderAccountNameRefPolicyResolveEnum>))]
public enum V1beta2SQLContainerSpecForProviderAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderAccountNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SQLContainerSpecForProviderAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SQLContainerSpecForProviderAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in cosmosdb to populate accountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SQLContainerSpecForProviderAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderAccountNameSelectorPolicyResolutionEnum>))]
public enum V1beta2SQLContainerSpecForProviderAccountNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderAccountNameSelectorPolicyResolveEnum>))]
public enum V1beta2SQLContainerSpecForProviderAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderAccountNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SQLContainerSpecForProviderAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SQLContainerSpecForProviderAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in cosmosdb to populate accountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderAccountNameSelector
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
    public V1beta2SQLContainerSpecForProviderAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary>An autoscale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the SQL container (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderConflictResolutionPolicy
{
    /// <summary>The conflict resolution path in the case of LastWriterWins mode.</summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary>The procedure to resolve conflicts in the case of Custom mode.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderDatabaseNameRefPolicyResolutionEnum>))]
public enum V1beta2SQLContainerSpecForProviderDatabaseNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderDatabaseNameRefPolicyResolveEnum>))]
public enum V1beta2SQLContainerSpecForProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SQLContainerSpecForProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SQLContainerSpecForProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SQLDatabase in cosmosdb to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SQLContainerSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderDatabaseNameSelectorPolicyResolutionEnum>))]
public enum V1beta2SQLContainerSpecForProviderDatabaseNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderDatabaseNameSelectorPolicyResolveEnum>))]
public enum V1beta2SQLContainerSpecForProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SQLContainerSpecForProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SQLContainerSpecForProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SQLDatabase in cosmosdb to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderDatabaseNameSelector
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
    public V1beta2SQLContainerSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderIndexingPolicyCompositeIndexIndex
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
public partial class V1beta2SQLContainerSpecForProviderIndexingPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta2SQLContainerSpecForProviderIndexingPolicyCompositeIndexIndex>? Index { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderIndexingPolicyExcludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderIndexingPolicyIncludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderIndexingPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>An indexing_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderIndexingPolicy
{
    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta2SQLContainerSpecForProviderIndexingPolicyCompositeIndex>? CompositeIndex { get; set; }

    /// <summary>One or more excluded_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("excludedPath")]
    public IList<V1beta2SQLContainerSpecForProviderIndexingPolicyExcludedPath>? ExcludedPath { get; set; }

    /// <summary>One or more included_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("includedPath")]
    public IList<V1beta2SQLContainerSpecForProviderIndexingPolicyIncludedPath>? IncludedPath { get; set; }

    /// <summary>Indicates the indexing mode. Possible values include: consistent and none. Defaults to consistent.</summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary>One or more spatial_index blocks as defined below.</summary>
    [JsonPropertyName("spatialIndex")]
    public IList<V1beta2SQLContainerSpecForProviderIndexingPolicySpatialIndex>? SpatialIndex { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2SQLContainerSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2SQLContainerSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SQLContainerSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SQLContainerSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SQLContainerSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2SQLContainerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2SQLContainerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SQLContainerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SQLContainerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderResourceGroupNameSelector
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
    public V1beta2SQLContainerSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProviderUniqueKey
{
    /// <summary>A list of paths to use for this unique key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecForProvider
{
    /// <summary>The name of the Cosmos DB Account to create the container within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Reference to a Account in cosmosdb to populate accountName.</summary>
    [JsonPropertyName("accountNameRef")]
    public V1beta2SQLContainerSpecForProviderAccountNameRef? AccountNameRef { get; set; }

    /// <summary>Selector for a Account in cosmosdb to populate accountName.</summary>
    [JsonPropertyName("accountNameSelector")]
    public V1beta2SQLContainerSpecForProviderAccountNameSelector? AccountNameSelector { get; set; }

    /// <summary>The default time to live of Analytical Storage for this SQL container. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta2SQLContainerSpecForProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta2SQLContainerSpecForProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>The name of the Cosmos DB SQL Database to create the container within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a SQLDatabase in cosmosdb to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta2SQLContainerSpecForProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a SQLDatabase in cosmosdb to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta2SQLContainerSpecForProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>The default time to live of SQL container. If missing, items are not expired automatically. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>An indexing_policy block as defined below.</summary>
    [JsonPropertyName("indexingPolicy")]
    public V1beta2SQLContainerSpecForProviderIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>Define a partition key kind. Possible values are Hash and MultiHash. Defaults to Hash. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyKind")]
    public string? PartitionKeyKind { get; set; }

    /// <summary>A list of partition key paths. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyPaths")]
    public IList<string>? PartitionKeyPaths { get; set; }

    /// <summary>Define a partition key version. Possible values are 1and 2. This should be set to 2 in order to use large partition keys.</summary>
    [JsonPropertyName("partitionKeyVersion")]
    public double? PartitionKeyVersion { get; set; }

    /// <summary>The name of the resource group in which the Cosmos DB SQL Container is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2SQLContainerSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2SQLContainerSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The throughput of SQL container (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>One or more unique_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uniqueKey")]
    public IList<V1beta2SQLContainerSpecForProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>An autoscale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecInitProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the SQL container (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecInitProviderConflictResolutionPolicy
{
    /// <summary>The conflict resolution path in the case of LastWriterWins mode.</summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary>The procedure to resolve conflicts in the case of Custom mode.</summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary>Indicates the conflict resolution mode. Possible values include: LastWriterWins, Custom.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecInitProviderIndexingPolicyCompositeIndexIndex
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
public partial class V1beta2SQLContainerSpecInitProviderIndexingPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta2SQLContainerSpecInitProviderIndexingPolicyCompositeIndexIndex>? Index { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecInitProviderIndexingPolicyExcludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecInitProviderIndexingPolicyIncludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecInitProviderIndexingPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>An indexing_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecInitProviderIndexingPolicy
{
    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta2SQLContainerSpecInitProviderIndexingPolicyCompositeIndex>? CompositeIndex { get; set; }

    /// <summary>One or more excluded_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("excludedPath")]
    public IList<V1beta2SQLContainerSpecInitProviderIndexingPolicyExcludedPath>? ExcludedPath { get; set; }

    /// <summary>One or more included_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("includedPath")]
    public IList<V1beta2SQLContainerSpecInitProviderIndexingPolicyIncludedPath>? IncludedPath { get; set; }

    /// <summary>Indicates the indexing mode. Possible values include: consistent and none. Defaults to consistent.</summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary>One or more spatial_index blocks as defined below.</summary>
    [JsonPropertyName("spatialIndex")]
    public IList<V1beta2SQLContainerSpecInitProviderIndexingPolicySpatialIndex>? SpatialIndex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecInitProviderUniqueKey
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
public partial class V1beta2SQLContainerSpecInitProvider
{
    /// <summary>The default time to live of Analytical Storage for this SQL container. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta2SQLContainerSpecInitProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta2SQLContainerSpecInitProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>The default time to live of SQL container. If missing, items are not expired automatically. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>An indexing_policy block as defined below.</summary>
    [JsonPropertyName("indexingPolicy")]
    public V1beta2SQLContainerSpecInitProviderIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>Define a partition key kind. Possible values are Hash and MultiHash. Defaults to Hash. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyKind")]
    public string? PartitionKeyKind { get; set; }

    /// <summary>A list of partition key paths. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyPaths")]
    public IList<string>? PartitionKeyPaths { get; set; }

    /// <summary>Define a partition key version. Possible values are 1and 2. This should be set to 2 in order to use large partition keys.</summary>
    [JsonPropertyName("partitionKeyVersion")]
    public double? PartitionKeyVersion { get; set; }

    /// <summary>The throughput of SQL container (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>One or more unique_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uniqueKey")]
    public IList<V1beta2SQLContainerSpecInitProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecManagementPoliciesEnum>))]
public enum V1beta2SQLContainerSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SQLContainerSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SQLContainerSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SQLContainerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SQLContainerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SQLContainerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SQLContainerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SQLContainerSpec defines the desired state of SQLContainer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerSpec
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
    public V1beta2SQLContainerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SQLContainerSpecForProvider ForProvider { get; set; }

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
    public V1beta2SQLContainerSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SQLContainerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SQLContainerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SQLContainerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An autoscale_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerStatusAtProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the SQL container (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerStatusAtProviderConflictResolutionPolicy
{
    /// <summary>The conflict resolution path in the case of LastWriterWins mode.</summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary>The procedure to resolve conflicts in the case of Custom mode.</summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary>Indicates the conflict resolution mode. Possible values include: LastWriterWins, Custom.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerStatusAtProviderIndexingPolicyCompositeIndexIndex
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
public partial class V1beta2SQLContainerStatusAtProviderIndexingPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta2SQLContainerStatusAtProviderIndexingPolicyCompositeIndexIndex>? Index { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerStatusAtProviderIndexingPolicyExcludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerStatusAtProviderIndexingPolicyIncludedPath
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerStatusAtProviderIndexingPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>A set of spatial types of the path.</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>An indexing_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerStatusAtProviderIndexingPolicy
{
    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta2SQLContainerStatusAtProviderIndexingPolicyCompositeIndex>? CompositeIndex { get; set; }

    /// <summary>One or more excluded_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("excludedPath")]
    public IList<V1beta2SQLContainerStatusAtProviderIndexingPolicyExcludedPath>? ExcludedPath { get; set; }

    /// <summary>One or more included_path blocks as defined below. Either included_path or excluded_path must contain the path /*</summary>
    [JsonPropertyName("includedPath")]
    public IList<V1beta2SQLContainerStatusAtProviderIndexingPolicyIncludedPath>? IncludedPath { get; set; }

    /// <summary>Indicates the indexing mode. Possible values include: consistent and none. Defaults to consistent.</summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary>One or more spatial_index blocks as defined below.</summary>
    [JsonPropertyName("spatialIndex")]
    public IList<V1beta2SQLContainerStatusAtProviderIndexingPolicySpatialIndex>? SpatialIndex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerStatusAtProviderUniqueKey
{
    /// <summary>A list of paths to use for this unique key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerStatusAtProvider
{
    /// <summary>The name of the Cosmos DB Account to create the container within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The default time to live of Analytical Storage for this SQL container. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta2SQLContainerStatusAtProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta2SQLContainerStatusAtProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>The name of the Cosmos DB SQL Database to create the container within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>The default time to live of SQL container. If missing, items are not expired automatically. If present and the value is set to -1, it is equal to infinity, and items don’t expire by default. If present and the value is set to some number n – items will expire n seconds after their last modified time.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>The ID of the CosmosDB SQL Container.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An indexing_policy block as defined below.</summary>
    [JsonPropertyName("indexingPolicy")]
    public V1beta2SQLContainerStatusAtProviderIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>Define a partition key kind. Possible values are Hash and MultiHash. Defaults to Hash. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyKind")]
    public string? PartitionKeyKind { get; set; }

    /// <summary>A list of partition key paths. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("partitionKeyPaths")]
    public IList<string>? PartitionKeyPaths { get; set; }

    /// <summary>Define a partition key version. Possible values are 1and 2. This should be set to 2 in order to use large partition keys.</summary>
    [JsonPropertyName("partitionKeyVersion")]
    public double? PartitionKeyVersion { get; set; }

    /// <summary>The name of the resource group in which the Cosmos DB SQL Container is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The throughput of SQL container (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>One or more unique_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uniqueKey")]
    public IList<V1beta2SQLContainerStatusAtProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerStatusConditions
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

/// <summary>SQLContainerStatus defines the observed state of SQLContainer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SQLContainerStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SQLContainerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SQLContainerStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SQLContainer is the Schema for the SQLContainers API. Manages a SQL Container within a Cosmos DB Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SQLContainer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SQLContainerSpec>, IStatus<V1beta2SQLContainerStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SQLContainer";
    public const string KubeGroup = "cosmosdb.azure.upbound.io";
    public const string KubePluralName = "sqlcontainers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cosmosdb.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SQLContainer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLContainerSpec defines the desired state of SQLContainer</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SQLContainerSpec Spec { get; set; }

    /// <summary>SQLContainerStatus defines the observed state of SQLContainer.</summary>
    [JsonPropertyName("status")]
    public V1beta2SQLContainerStatus? Status { get; set; }
}