#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2021-05-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210515SqlDatabaseContainerList : IKubernetesObject<V1ListMeta>, IItems<V1api20210515SqlDatabaseContainer>
{
    public const string KubeApiVersion = "v1api20210515";
    public const string KubeKind = "SqlDatabaseContainerList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "sqldatabasecontainers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20210515";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SqlDatabaseContainerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210515SqlDatabaseContainer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210515SqlDatabaseContainer> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210515SqlDatabaseContainerSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210515SqlDatabaseContainerSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>AutoscaleSettings: Specifies the Autoscale settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecOptionsAutoscaleSettings
{
    /// <summary>MaxThroughput: Represents maximum throughput, the resource can scale up to.</summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>
/// Options: A key-value pair of options to be applied for the request. This corresponds to the headers sent with the
/// request.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecOptions
{
    /// <summary>AutoscaleSettings: Specifies the Autoscale settings.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20210515SqlDatabaseContainerSpecOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>Throughput: Request Units per second. For example, &quot;throughput&quot;: 10000.</summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a documentdb.azure.com/SqlDatabase resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Mode: Indicates the conflict resolution mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515SqlDatabaseContainerSpecResourceConflictResolutionPolicyModeEnum>))]
public enum V1api20210515SqlDatabaseContainerSpecResourceConflictResolutionPolicyModeEnum
{
    [EnumMember(Value = "Custom"), JsonStringEnumMemberName("Custom")]
    Custom,
    [EnumMember(Value = "LastWriterWins"), JsonStringEnumMemberName("LastWriterWins")]
    LastWriterWins
}

/// <summary>ConflictResolutionPolicy: The conflict resolution policy for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecResourceConflictResolutionPolicy
{
    /// <summary>ConflictResolutionPath: The conflict resolution path in the case of LastWriterWins mode.</summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary>ConflictResolutionProcedure: The procedure to resolve conflicts in the case of custom mode.</summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary>Mode: Indicates the conflict resolution mode.</summary>
    [JsonPropertyName("mode")]
    public V1api20210515SqlDatabaseContainerSpecResourceConflictResolutionPolicyModeEnum? Mode { get; set; }
}

/// <summary>Order: Sort order for composite paths.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyCompositeIndexesOrderEnum>))]
public enum V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyCompositeIndexesOrderEnum
{
    [EnumMember(Value = "ascending"), JsonStringEnumMemberName("ascending")]
    Ascending,
    [EnumMember(Value = "descending"), JsonStringEnumMemberName("descending")]
    Descending
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyCompositeIndexes
{
    /// <summary>Order: Sort order for composite paths.</summary>
    [JsonPropertyName("order")]
    public V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyCompositeIndexesOrderEnum? Order { get; set; }

    /// <summary>
    /// Path: The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard
    /// (/path/*)
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyExcludedPaths
{
    /// <summary>
    /// Path: The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard
    /// (/path/*)
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>DataType: The datatype for which the indexing behavior is applied to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexesDataTypeEnum>))]
public enum V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexesDataTypeEnum
{
    [EnumMember(Value = "LineString"), JsonStringEnumMemberName("LineString")]
    LineString,
    [EnumMember(Value = "MultiPolygon"), JsonStringEnumMemberName("MultiPolygon")]
    MultiPolygon,
    [EnumMember(Value = "Number"), JsonStringEnumMemberName("Number")]
    Number,
    [EnumMember(Value = "Point"), JsonStringEnumMemberName("Point")]
    Point,
    [EnumMember(Value = "Polygon"), JsonStringEnumMemberName("Polygon")]
    Polygon,
    [EnumMember(Value = "String"), JsonStringEnumMemberName("String")]
    String
}

/// <summary>Kind: Indicates the type of index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexesKindEnum>))]
public enum V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexesKindEnum
{
    [EnumMember(Value = "Hash"), JsonStringEnumMemberName("Hash")]
    Hash,
    [EnumMember(Value = "Range"), JsonStringEnumMemberName("Range")]
    Range,
    [EnumMember(Value = "Spatial"), JsonStringEnumMemberName("Spatial")]
    Spatial
}

/// <summary>The indexes for the path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexes
{
    /// <summary>DataType: The datatype for which the indexing behavior is applied to.</summary>
    [JsonPropertyName("dataType")]
    public V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexesDataTypeEnum? DataType { get; set; }

    /// <summary>Kind: Indicates the type of index.</summary>
    [JsonPropertyName("kind")]
    public V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexesKindEnum? Kind { get; set; }

    /// <summary>Precision: The precision of the index. -1 is maximum precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }
}

/// <summary>The paths that are included in indexing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIncludedPaths
{
    /// <summary>Indexes: List of indexes for this path</summary>
    [JsonPropertyName("indexes")]
    public IList<V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIncludedPathsIndexes>? Indexes { get; set; }

    /// <summary>
    /// Path: The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard
    /// (/path/*)
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>IndexingMode: Indicates the indexing mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIndexingModeEnum>))]
public enum V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIndexingModeEnum
{
    [EnumMember(Value = "consistent"), JsonStringEnumMemberName("consistent")]
    Consistent,
    [EnumMember(Value = "lazy"), JsonStringEnumMemberName("lazy")]
    Lazy,
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    None
}

/// <summary>Indicates the spatial type of index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicySpatialIndexesTypesEnum>))]
public enum V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicySpatialIndexesTypesEnum
{
    [EnumMember(Value = "LineString"), JsonStringEnumMemberName("LineString")]
    LineString,
    [EnumMember(Value = "MultiPolygon"), JsonStringEnumMemberName("MultiPolygon")]
    MultiPolygon,
    [EnumMember(Value = "Point"), JsonStringEnumMemberName("Point")]
    Point,
    [EnumMember(Value = "Polygon"), JsonStringEnumMemberName("Polygon")]
    Polygon
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicySpatialIndexes
{
    /// <summary>
    /// Path: The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard
    /// (/path/*)
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Types: List of path&apos;s spatial type</summary>
    [JsonPropertyName("types")]
    public IList<V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicySpatialIndexesTypesEnum>? Types { get; set; }
}

/// <summary>
/// IndexingPolicy: The configuration of the indexing policy. By default, the indexing is automatic for all document paths
/// within the container
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicy
{
    /// <summary>Automatic: Indicates if the indexing policy is automatic</summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary>CompositeIndexes: List of composite path list</summary>
    [JsonPropertyName("compositeIndexes")]
    public IList<IList<V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyCompositeIndexes>>? CompositeIndexes { get; set; }

    /// <summary>ExcludedPaths: List of paths to exclude from indexing</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyExcludedPaths>? ExcludedPaths { get; set; }

    /// <summary>IncludedPaths: List of paths to include in the indexing</summary>
    [JsonPropertyName("includedPaths")]
    public IList<V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIncludedPaths>? IncludedPaths { get; set; }

    /// <summary>IndexingMode: Indicates the indexing mode.</summary>
    [JsonPropertyName("indexingMode")]
    public V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicyIndexingModeEnum? IndexingMode { get; set; }

    /// <summary>SpatialIndexes: List of spatial specifics</summary>
    [JsonPropertyName("spatialIndexes")]
    public IList<V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicySpatialIndexes>? SpatialIndexes { get; set; }
}

/// <summary>
/// Kind: Indicates the kind of algorithm used for partitioning. For MultiHash, multiple partition keys (upto three maximum)
/// are supported for container create
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210515SqlDatabaseContainerSpecResourcePartitionKeyKindEnum>))]
public enum V1api20210515SqlDatabaseContainerSpecResourcePartitionKeyKindEnum
{
    [EnumMember(Value = "Hash"), JsonStringEnumMemberName("Hash")]
    Hash,
    [EnumMember(Value = "MultiHash"), JsonStringEnumMemberName("MultiHash")]
    MultiHash,
    [EnumMember(Value = "Range"), JsonStringEnumMemberName("Range")]
    Range
}

/// <summary>PartitionKey: The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecResourcePartitionKey
{
    /// <summary>
    /// Kind: Indicates the kind of algorithm used for partitioning. For MultiHash, multiple partition keys (upto three maximum)
    /// are supported for container create
    /// </summary>
    [JsonPropertyName("kind")]
    public V1api20210515SqlDatabaseContainerSpecResourcePartitionKeyKindEnum? Kind { get; set; }

    /// <summary>Paths: List of paths using which data within the container can be partitioned</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>Version: Indicates the version of the partition key definition</summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}

/// <summary>The unique key on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecResourceUniqueKeyPolicyUniqueKeys
{
    /// <summary>Paths: List of paths must be unique for each document in the Azure Cosmos DB service</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary>
/// UniqueKeyPolicy: The unique key policy configuration for specifying uniqueness constraints on documents in the
/// collection in the Azure Cosmos DB service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecResourceUniqueKeyPolicy
{
    /// <summary>
    /// UniqueKeys: List of unique keys on that enforces uniqueness constraint on documents in the collection in the Azure
    /// Cosmos DB service.
    /// </summary>
    [JsonPropertyName("uniqueKeys")]
    public IList<V1api20210515SqlDatabaseContainerSpecResourceUniqueKeyPolicyUniqueKeys>? UniqueKeys { get; set; }
}

/// <summary>Resource: The standard JSON format of a container</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpecResource
{
    /// <summary>AnalyticalStorageTtl: Analytical TTL.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public int? AnalyticalStorageTtl { get; set; }

    /// <summary>ConflictResolutionPolicy: The conflict resolution policy for the container.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1api20210515SqlDatabaseContainerSpecResourceConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>DefaultTtl: Default time to live</summary>
    [JsonPropertyName("defaultTtl")]
    public int? DefaultTtl { get; set; }

    /// <summary>Id: Name of the Cosmos DB SQL container</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// IndexingPolicy: The configuration of the indexing policy. By default, the indexing is automatic for all document paths
    /// within the container
    /// </summary>
    [JsonPropertyName("indexingPolicy")]
    public V1api20210515SqlDatabaseContainerSpecResourceIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>PartitionKey: The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
    [JsonPropertyName("partitionKey")]
    public V1api20210515SqlDatabaseContainerSpecResourcePartitionKey? PartitionKey { get; set; }

    /// <summary>
    /// UniqueKeyPolicy: The unique key policy configuration for specifying uniqueness constraints on documents in the
    /// collection in the Azure Cosmos DB service.
    /// </summary>
    [JsonPropertyName("uniqueKeyPolicy")]
    public V1api20210515SqlDatabaseContainerSpecResourceUniqueKeyPolicy? UniqueKeyPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210515SqlDatabaseContainerSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Options: A key-value pair of options to be applied for the request. This corresponds to the headers sent with the
    /// request.
    /// </summary>
    [JsonPropertyName("options")]
    public V1api20210515SqlDatabaseContainerSpecOptions? Options { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a documentdb.azure.com/SqlDatabase resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210515SqlDatabaseContainerSpecOwner Owner { get; set; }

    /// <summary>Resource: The standard JSON format of a container</summary>
    [JsonPropertyName("resource")]
    public required V1api20210515SqlDatabaseContainerSpecResource Resource { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>AutoscaleSettings: Specifies the Autoscale settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusOptionsAutoscaleSettings
{
    /// <summary>MaxThroughput: Represents maximum throughput, the resource can scale up to.</summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>Options: Cosmos DB options resource object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusOptions
{
    /// <summary>AutoscaleSettings: Specifies the Autoscale settings.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20210515SqlDatabaseContainerStatusOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>
    /// Throughput: Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when
    /// retrieving offer details.
    /// </summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>ConflictResolutionPolicy: The conflict resolution policy for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusResourceConflictResolutionPolicy
{
    /// <summary>ConflictResolutionPath: The conflict resolution path in the case of LastWriterWins mode.</summary>
    [JsonPropertyName("conflictResolutionPath")]
    public string? ConflictResolutionPath { get; set; }

    /// <summary>ConflictResolutionProcedure: The procedure to resolve conflicts in the case of custom mode.</summary>
    [JsonPropertyName("conflictResolutionProcedure")]
    public string? ConflictResolutionProcedure { get; set; }

    /// <summary>Mode: Indicates the conflict resolution mode.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicyCompositeIndexes
{
    /// <summary>Order: Sort order for composite paths.</summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }

    /// <summary>
    /// Path: The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard
    /// (/path/*)
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicyExcludedPaths
{
    /// <summary>
    /// Path: The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard
    /// (/path/*)
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>The indexes for the path.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicyIncludedPathsIndexes
{
    /// <summary>DataType: The datatype for which the indexing behavior is applied to.</summary>
    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    /// <summary>Kind: Indicates the type of index.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Precision: The precision of the index. -1 is maximum precision.</summary>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }
}

/// <summary>The paths that are included in indexing</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicyIncludedPaths
{
    /// <summary>Indexes: List of indexes for this path</summary>
    [JsonPropertyName("indexes")]
    public IList<V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicyIncludedPathsIndexes>? Indexes { get; set; }

    /// <summary>
    /// Path: The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard
    /// (/path/*)
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicySpatialIndexes
{
    /// <summary>
    /// Path: The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard
    /// (/path/*)
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Types: List of path&apos;s spatial type</summary>
    [JsonPropertyName("types")]
    public IList<string>? Types { get; set; }
}

/// <summary>
/// IndexingPolicy: The configuration of the indexing policy. By default, the indexing is automatic for all document paths
/// within the container
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicy
{
    /// <summary>Automatic: Indicates if the indexing policy is automatic</summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary>CompositeIndexes: List of composite path list</summary>
    [JsonPropertyName("compositeIndexes")]
    public IList<IList<V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicyCompositeIndexes>>? CompositeIndexes { get; set; }

    /// <summary>ExcludedPaths: List of paths to exclude from indexing</summary>
    [JsonPropertyName("excludedPaths")]
    public IList<V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicyExcludedPaths>? ExcludedPaths { get; set; }

    /// <summary>IncludedPaths: List of paths to include in the indexing</summary>
    [JsonPropertyName("includedPaths")]
    public IList<V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicyIncludedPaths>? IncludedPaths { get; set; }

    /// <summary>IndexingMode: Indicates the indexing mode.</summary>
    [JsonPropertyName("indexingMode")]
    public string? IndexingMode { get; set; }

    /// <summary>SpatialIndexes: List of spatial specifics</summary>
    [JsonPropertyName("spatialIndexes")]
    public IList<V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicySpatialIndexes>? SpatialIndexes { get; set; }
}

/// <summary>PartitionKey: The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusResourcePartitionKey
{
    /// <summary>
    /// Kind: Indicates the kind of algorithm used for partitioning. For MultiHash, multiple partition keys (upto three maximum)
    /// are supported for container create
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Paths: List of paths using which data within the container can be partitioned</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }

    /// <summary>SystemKey: Indicates if the container is using a system generated partition key</summary>
    [JsonPropertyName("systemKey")]
    public bool? SystemKey { get; set; }

    /// <summary>Version: Indicates the version of the partition key definition</summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }
}

/// <summary>The unique key on that enforces uniqueness constraint on documents in the collection in the Azure Cosmos DB service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusResourceUniqueKeyPolicyUniqueKeys
{
    /// <summary>Paths: List of paths must be unique for each document in the Azure Cosmos DB service</summary>
    [JsonPropertyName("paths")]
    public IList<string>? Paths { get; set; }
}

/// <summary>
/// UniqueKeyPolicy: The unique key policy configuration for specifying uniqueness constraints on documents in the
/// collection in the Azure Cosmos DB service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusResourceUniqueKeyPolicy
{
    /// <summary>
    /// UniqueKeys: List of unique keys on that enforces uniqueness constraint on documents in the collection in the Azure
    /// Cosmos DB service.
    /// </summary>
    [JsonPropertyName("uniqueKeys")]
    public IList<V1api20210515SqlDatabaseContainerStatusResourceUniqueKeyPolicyUniqueKeys>? UniqueKeys { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatusResource
{
    /// <summary>Etag: A system generated property representing the resource etag required for optimistic concurrency control.</summary>
    [JsonPropertyName("_etag")]
    public string? Etag { get; set; }

    /// <summary>Rid: A system generated property. A unique identifier.</summary>
    [JsonPropertyName("_rid")]
    public string? Rid { get; set; }

    /// <summary>Ts: A system generated property that denotes the last updated timestamp of the resource.</summary>
    [JsonPropertyName("_ts")]
    public double? Ts { get; set; }

    /// <summary>AnalyticalStorageTtl: Analytical TTL.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public int? AnalyticalStorageTtl { get; set; }

    /// <summary>ConflictResolutionPolicy: The conflict resolution policy for the container.</summary>
    [JsonPropertyName("conflictResolutionPolicy")]
    public V1api20210515SqlDatabaseContainerStatusResourceConflictResolutionPolicy? ConflictResolutionPolicy { get; set; }

    /// <summary>DefaultTtl: Default time to live</summary>
    [JsonPropertyName("defaultTtl")]
    public int? DefaultTtl { get; set; }

    /// <summary>Id: Name of the Cosmos DB SQL container</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IndexingPolicy: The configuration of the indexing policy. By default, the indexing is automatic for all document paths
    /// within the container
    /// </summary>
    [JsonPropertyName("indexingPolicy")]
    public V1api20210515SqlDatabaseContainerStatusResourceIndexingPolicy? IndexingPolicy { get; set; }

    /// <summary>PartitionKey: The configuration of the partition key to be used for partitioning data into multiple partitions</summary>
    [JsonPropertyName("partitionKey")]
    public V1api20210515SqlDatabaseContainerStatusResourcePartitionKey? PartitionKey { get; set; }

    /// <summary>
    /// UniqueKeyPolicy: The unique key policy configuration for specifying uniqueness constraints on documents in the
    /// collection in the Azure Cosmos DB service.
    /// </summary>
    [JsonPropertyName("uniqueKeyPolicy")]
    public V1api20210515SqlDatabaseContainerStatusResourceUniqueKeyPolicy? UniqueKeyPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210515SqlDatabaseContainerStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210515SqlDatabaseContainerStatusConditions>? Conditions { get; set; }

    /// <summary>Id: The unique resource identifier of the ARM resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the ARM resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Options: Cosmos DB options resource object</summary>
    [JsonPropertyName("options")]
    public V1api20210515SqlDatabaseContainerStatusOptions? Options { get; set; }

    [JsonPropertyName("resource")]
    public V1api20210515SqlDatabaseContainerStatusResource? Resource { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of Azure resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2021-05-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210515SqlDatabaseContainer : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210515SqlDatabaseContainerSpec?>, IStatus<V1api20210515SqlDatabaseContainerStatus?>
{
    public const string KubeApiVersion = "v1api20210515";
    public const string KubeKind = "SqlDatabaseContainer";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "sqldatabasecontainers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20210515";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SqlDatabaseContainer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210515SqlDatabaseContainerSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20210515SqlDatabaseContainerStatus? Status { get; set; }
}