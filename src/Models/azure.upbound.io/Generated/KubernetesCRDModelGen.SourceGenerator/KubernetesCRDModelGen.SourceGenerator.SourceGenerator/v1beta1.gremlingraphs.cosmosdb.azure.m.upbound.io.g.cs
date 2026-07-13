#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cosmosdb.azure.m.upbound.io;
/// <summary>GremlinGraph is the Schema for the GremlinGraphs API. Manages a Gremlin Graph within a Cosmos DB Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GremlinGraphList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GremlinGraph>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GremlinGraphList";
    public const string KubeGroup = "cosmosdb.azure.m.upbound.io";
    public const string KubePluralName = "gremlingraphs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cosmosdb.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GremlinGraphList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1GremlinGraph objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1GremlinGraph> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderAccountNameRefPolicyResolutionEnum>))]
public enum V1beta1GremlinGraphSpecForProviderAccountNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderAccountNameRefPolicyResolveEnum>))]
public enum V1beta1GremlinGraphSpecForProviderAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderAccountNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GremlinGraphSpecForProviderAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GremlinGraphSpecForProviderAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in cosmosdb to populate accountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GremlinGraphSpecForProviderAccountNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderAccountNameSelectorPolicyResolutionEnum>))]
public enum V1beta1GremlinGraphSpecForProviderAccountNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderAccountNameSelectorPolicyResolveEnum>))]
public enum V1beta1GremlinGraphSpecForProviderAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderAccountNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GremlinGraphSpecForProviderAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GremlinGraphSpecForProviderAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in cosmosdb to populate accountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderAccountNameSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GremlinGraphSpecForProviderAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the Gremlin graph (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderConflictResolutionPolicy
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderDatabaseNameRefPolicyResolutionEnum>))]
public enum V1beta1GremlinGraphSpecForProviderDatabaseNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderDatabaseNameRefPolicyResolveEnum>))]
public enum V1beta1GremlinGraphSpecForProviderDatabaseNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderDatabaseNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GremlinGraphSpecForProviderDatabaseNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GremlinGraphSpecForProviderDatabaseNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a GremlinDatabase in cosmosdb to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderDatabaseNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GremlinGraphSpecForProviderDatabaseNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolutionEnum>))]
public enum V1beta1GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolveEnum>))]
public enum V1beta1GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderDatabaseNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GremlinGraphSpecForProviderDatabaseNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a GremlinDatabase in cosmosdb to populate databaseName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderDatabaseNameSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GremlinGraphSpecForProviderDatabaseNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderIndexPolicyCompositeIndexIndex
{
    /// <summary>Order of the index. Possible values are Ascending or Descending.</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderIndexPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta1GremlinGraphSpecForProviderIndexPolicyCompositeIndexIndex>? Index { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderIndexPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>The configuration of the indexing policy. One or more index_policy blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderIndexPolicy
{
    /// <summary>Indicates if the indexing policy is automatic. Defaults to true.</summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta1GremlinGraphSpecForProviderIndexPolicyCompositeIndex>? CompositeIndex { get; set; }

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
    public IList<V1beta1GremlinGraphSpecForProviderIndexPolicySpatialIndex>? SpatialIndex { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GremlinGraphSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GremlinGraphSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1GremlinGraphSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderResourceGroupNameSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GremlinGraphSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProviderUniqueKey
{
    /// <summary>A list of paths to use for this unique key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecForProvider
{
    /// <summary>The name of the CosmosDB Account to create the Gremlin Graph within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Reference to a Account in cosmosdb to populate accountName.</summary>
    [JsonPropertyName("accountNameRef")]
    public V1beta1GremlinGraphSpecForProviderAccountNameRef? AccountNameRef { get; set; }

    /// <summary>Selector for a Account in cosmosdb to populate accountName.</summary>
    [JsonPropertyName("accountNameSelector")]
    public V1beta1GremlinGraphSpecForProviderAccountNameSelector? AccountNameSelector { get; set; }

    /// <summary>The time to live of Analytical Storage for this Cosmos DB Gremlin Graph. Possible values are between -1 to 2147483647 not including 0. If present and the value is set to -1, it means never expire.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta1GremlinGraphSpecForProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta1GremlinGraphSpecForProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>The name of the Cosmos DB Graph Database in which the Cosmos DB Gremlin Graph is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Reference to a GremlinDatabase in cosmosdb to populate databaseName.</summary>
    [JsonPropertyName("databaseNameRef")]
    public V1beta1GremlinGraphSpecForProviderDatabaseNameRef? DatabaseNameRef { get; set; }

    /// <summary>Selector for a GremlinDatabase in cosmosdb to populate databaseName.</summary>
    [JsonPropertyName("databaseNameSelector")]
    public V1beta1GremlinGraphSpecForProviderDatabaseNameSelector? DatabaseNameSelector { get; set; }

    /// <summary>The default time to live (TTL) of the Gremlin graph. If the value is missing or set to &quot;-1&quot;, items don’t expire.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>The configuration of the indexing policy. One or more index_policy blocks as defined below.</summary>
    [JsonPropertyName("indexPolicy")]
    public V1beta1GremlinGraphSpecForProviderIndexPolicy? IndexPolicy { get; set; }

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
    public V1beta1GremlinGraphSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1GremlinGraphSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The throughput of the Gremlin graph (RU/s). Must be set in increments of 100. The minimum value is 400.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>One or more unique_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uniqueKey")]
    public IList<V1beta1GremlinGraphSpecForProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecInitProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the Gremlin graph (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecInitProviderConflictResolutionPolicy
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecInitProviderIndexPolicyCompositeIndexIndex
{
    /// <summary>Order of the index. Possible values are Ascending or Descending.</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecInitProviderIndexPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta1GremlinGraphSpecInitProviderIndexPolicyCompositeIndexIndex>? Index { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecInitProviderIndexPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>The configuration of the indexing policy. One or more index_policy blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecInitProviderIndexPolicy
{
    /// <summary>Indicates if the indexing policy is automatic. Defaults to true.</summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta1GremlinGraphSpecInitProviderIndexPolicyCompositeIndex>? CompositeIndex { get; set; }

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
    public IList<V1beta1GremlinGraphSpecInitProviderIndexPolicySpatialIndex>? SpatialIndex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecInitProviderUniqueKey
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecInitProvider
{
    /// <summary>The time to live of Analytical Storage for this Cosmos DB Gremlin Graph. Possible values are between -1 to 2147483647 not including 0. If present and the value is set to -1, it means never expire.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta1GremlinGraphSpecInitProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta1GremlinGraphSpecInitProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>The default time to live (TTL) of the Gremlin graph. If the value is missing or set to &quot;-1&quot;, items don’t expire.</summary>
    [JsonPropertyName("defaultTtl")]
    public double? DefaultTtl { get; set; }

    /// <summary>The configuration of the indexing policy. One or more index_policy blocks as defined below.</summary>
    [JsonPropertyName("indexPolicy")]
    public V1beta1GremlinGraphSpecInitProviderIndexPolicy? IndexPolicy { get; set; }

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
    public IList<V1beta1GremlinGraphSpecInitProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1GremlinGraphSpecManagementPoliciesEnum>))]
public enum V1beta1GremlinGraphSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>GremlinGraphSpec defines the desired state of GremlinGraph</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1GremlinGraphSpecForProvider ForProvider { get; set; }

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
    public V1beta1GremlinGraphSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1GremlinGraphSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GremlinGraphSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GremlinGraphSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphStatusAtProviderAutoscaleSettings
{
    /// <summary>The maximum throughput of the Gremlin graph (RU/s). Must be between 1,000 and 1,000,000. Must be set in increments of 1,000. Conflicts with throughput.</summary>
    [JsonPropertyName("maxThroughput")]
    public double? MaxThroughput { get; set; }
}

/// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphStatusAtProviderConflictResolutionPolicy
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphStatusAtProviderIndexPolicyCompositeIndexIndex
{
    /// <summary>Order of the index. Possible values are Ascending or Descending.</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphStatusAtProviderIndexPolicyCompositeIndex
{
    /// <summary>One or more index blocks as defined below.</summary>
    [JsonPropertyName("index")]
    public IList<V1beta1GremlinGraphStatusAtProviderIndexPolicyCompositeIndexIndex>? Index { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphStatusAtProviderIndexPolicySpatialIndex
{
    /// <summary>Path for which the indexing behaviour applies to. According to the service design, all spatial types including LineString, MultiPolygon, Point, and Polygon will be applied to the path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>The configuration of the indexing policy. One or more index_policy blocks as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphStatusAtProviderIndexPolicy
{
    /// <summary>Indicates if the indexing policy is automatic. Defaults to true.</summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary>One or more composite_index blocks as defined below.</summary>
    [JsonPropertyName("compositeIndex")]
    public IList<V1beta1GremlinGraphStatusAtProviderIndexPolicyCompositeIndex>? CompositeIndex { get; set; }

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
    public IList<V1beta1GremlinGraphStatusAtProviderIndexPolicySpatialIndex>? SpatialIndex { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphStatusAtProviderUniqueKey
{
    /// <summary>A list of paths to use for this unique key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphStatusAtProvider
{
    /// <summary>The name of the CosmosDB Account to create the Gremlin Graph within. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>The time to live of Analytical Storage for this Cosmos DB Gremlin Graph. Possible values are between -1 to 2147483647 not including 0. If present and the value is set to -1, it means never expire.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public double? AnalyticalStorageTtl { get; set; }

    /// <summary>An autoscale_settings block as defined below. Requires partition_key_path to be set.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1beta1GremlinGraphStatusAtProviderAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>A conflict_resolution_policy blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1beta1GremlinGraphStatusAtProviderConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

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
    public V1beta1GremlinGraphStatusAtProviderIndexPolicy? IndexPolicy { get; set; }

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
    public IList<V1beta1GremlinGraphStatusAtProviderUniqueKey>? UniqueKey { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GremlinGraphStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1GremlinGraphStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GremlinGraphStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GremlinGraph is the Schema for the GremlinGraphs API. Manages a Gremlin Graph within a Cosmos DB Account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GremlinGraph : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GremlinGraphSpec>, IStatus<V1beta1GremlinGraphStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GremlinGraph";
    public const string KubeGroup = "cosmosdb.azure.m.upbound.io";
    public const string KubePluralName = "gremlingraphs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cosmosdb.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GremlinGraph";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GremlinGraphSpec defines the desired state of GremlinGraph</summary>
    [JsonPropertyName("spec")]
    public required V1beta1GremlinGraphSpec Spec { get; set; }

    /// <summary>GremlinGraphStatus defines the observed state of GremlinGraph.</summary>
    [JsonPropertyName("status")]
    public V1beta1GremlinGraphStatus? Status { get; set; }
}