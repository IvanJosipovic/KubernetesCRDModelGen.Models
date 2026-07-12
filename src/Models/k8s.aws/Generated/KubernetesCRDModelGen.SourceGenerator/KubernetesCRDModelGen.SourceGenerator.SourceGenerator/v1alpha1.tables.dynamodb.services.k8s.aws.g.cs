#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dynamodb.services.k8s.aws;
/// <summary>Table is the Schema for the Tables API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TableList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Table>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TableList";
    public const string KubeGroup = "dynamodb.services.k8s.aws";
    public const string KubePluralName = "tables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dynamodb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TableList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Table objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Table> Items { get; set; }
}

/// <summary>Represents an attribute for describing the schema for the table and indexes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecAttributeDefinitions
{
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    [JsonPropertyName("attributeType")]
    public string? AttributeType { get; set; }
}

/// <summary>Represents the settings used to enable point in time recovery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecContinuousBackups
{
    [JsonPropertyName("pointInTimeRecoveryEnabled")]
    public bool? PointInTimeRecoveryEnabled { get; set; }
}

/// <summary>
/// Represents a single element of a key schema. A key schema specifies the attributes
/// that make up the primary key of a table, or the key attributes of an index.
/// 
/// A KeySchemaElement represents exactly one attribute of the primary key. For
/// example, a simple primary key would be represented by one KeySchemaElement
/// (for the partition key). A composite primary key would require one KeySchemaElement
/// for the partition key, and another KeySchemaElement for the sort key.
/// 
/// A KeySchemaElement must be a scalar, top-level attribute (not a nested attribute).
/// The data type must be one of String, Number, or Binary. The attribute cannot
/// be nested within a List or a Map.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecGlobalSecondaryIndexesKeySchema
{
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>
/// Sets the maximum number of read and write units for the specified on-demand
/// table. If you use this parameter, you must specify MaxReadRequestUnits, MaxWriteRequestUnits,
/// or both.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecGlobalSecondaryIndexesOnDemandThroughput
{
    [JsonPropertyName("maxReadRequestUnits")]
    public long? MaxReadRequestUnits { get; set; }

    [JsonPropertyName("maxWriteRequestUnits")]
    public long? MaxWriteRequestUnits { get; set; }
}

/// <summary>
/// Represents attributes that are copied (projected) from the table into an
/// index. These are in addition to the primary key attributes and index key
/// attributes, which are automatically projected.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecGlobalSecondaryIndexesProjection
{
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }
}

/// <summary>
/// Represents the provisioned throughput settings for a specified table or index.
/// The settings can be modified using the UpdateTable operation.
/// 
/// For current minimum and maximum provisioned throughput values, see Service,
/// Account, and Table Quotas (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html)
/// in the Amazon DynamoDB Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecGlobalSecondaryIndexesProvisionedThroughput
{
    [JsonPropertyName("readCapacityUnits")]
    public long? ReadCapacityUnits { get; set; }

    [JsonPropertyName("writeCapacityUnits")]
    public long? WriteCapacityUnits { get; set; }
}

/// <summary>Represents the properties of a global secondary index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecGlobalSecondaryIndexes
{
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    [JsonPropertyName("keySchema")]
    public IList<V1alpha1TableSpecGlobalSecondaryIndexesKeySchema>? KeySchema { get; set; }

    /// <summary>
    /// Sets the maximum number of read and write units for the specified on-demand
    /// table. If you use this parameter, you must specify MaxReadRequestUnits, MaxWriteRequestUnits,
    /// or both.
    /// </summary>
    [JsonPropertyName("onDemandThroughput")]
    public V1alpha1TableSpecGlobalSecondaryIndexesOnDemandThroughput? OnDemandThroughput { get; set; }

    /// <summary>
    /// Represents attributes that are copied (projected) from the table into an
    /// index. These are in addition to the primary key attributes and index key
    /// attributes, which are automatically projected.
    /// </summary>
    [JsonPropertyName("projection")]
    public V1alpha1TableSpecGlobalSecondaryIndexesProjection? Projection { get; set; }

    /// <summary>
    /// Represents the provisioned throughput settings for a specified table or index.
    /// The settings can be modified using the UpdateTable operation.
    /// 
    /// For current minimum and maximum provisioned throughput values, see Service,
    /// Account, and Table Quotas (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html)
    /// in the Amazon DynamoDB Developer Guide.
    /// </summary>
    [JsonPropertyName("provisionedThroughput")]
    public V1alpha1TableSpecGlobalSecondaryIndexesProvisionedThroughput? ProvisionedThroughput { get; set; }
}

/// <summary>
/// Represents a single element of a key schema. A key schema specifies the attributes
/// that make up the primary key of a table, or the key attributes of an index.
/// 
/// A KeySchemaElement represents exactly one attribute of the primary key. For
/// example, a simple primary key would be represented by one KeySchemaElement
/// (for the partition key). A composite primary key would require one KeySchemaElement
/// for the partition key, and another KeySchemaElement for the sort key.
/// 
/// A KeySchemaElement must be a scalar, top-level attribute (not a nested attribute).
/// The data type must be one of String, Number, or Binary. The attribute cannot
/// be nested within a List or a Map.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecKeySchema
{
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>
/// Represents a single element of a key schema. A key schema specifies the attributes
/// that make up the primary key of a table, or the key attributes of an index.
/// 
/// A KeySchemaElement represents exactly one attribute of the primary key. For
/// example, a simple primary key would be represented by one KeySchemaElement
/// (for the partition key). A composite primary key would require one KeySchemaElement
/// for the partition key, and another KeySchemaElement for the sort key.
/// 
/// A KeySchemaElement must be a scalar, top-level attribute (not a nested attribute).
/// The data type must be one of String, Number, or Binary. The attribute cannot
/// be nested within a List or a Map.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecLocalSecondaryIndexesKeySchema
{
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>
/// Represents attributes that are copied (projected) from the table into an
/// index. These are in addition to the primary key attributes and index key
/// attributes, which are automatically projected.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecLocalSecondaryIndexesProjection
{
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }
}

/// <summary>Represents the properties of a local secondary index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecLocalSecondaryIndexes
{
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    [JsonPropertyName("keySchema")]
    public IList<V1alpha1TableSpecLocalSecondaryIndexesKeySchema>? KeySchema { get; set; }

    /// <summary>
    /// Represents attributes that are copied (projected) from the table into an
    /// index. These are in addition to the primary key attributes and index key
    /// attributes, which are automatically projected.
    /// </summary>
    [JsonPropertyName("projection")]
    public V1alpha1TableSpecLocalSecondaryIndexesProjection? Projection { get; set; }
}

/// <summary>
/// Sets the maximum number of read and write units for the specified table in
/// on-demand capacity mode. If you use this parameter, you must specify MaxReadRequestUnits,
/// MaxWriteRequestUnits, or both.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecOnDemandThroughput
{
    [JsonPropertyName("maxReadRequestUnits")]
    public long? MaxReadRequestUnits { get; set; }

    [JsonPropertyName("maxWriteRequestUnits")]
    public long? MaxWriteRequestUnits { get; set; }
}

/// <summary>
/// Represents the provisioned throughput settings for a specified table or index.
/// The settings can be modified using the UpdateTable operation.
/// 
/// If you set BillingMode as PROVISIONED, you must specify this property. If
/// you set BillingMode as PAY_PER_REQUEST, you cannot specify this property.
/// 
/// For current minimum and maximum provisioned throughput values, see Service,
/// Account, and Table Quotas (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html)
/// in the Amazon DynamoDB Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecProvisionedThroughput
{
    [JsonPropertyName("readCapacityUnits")]
    public long? ReadCapacityUnits { get; set; }

    [JsonPropertyName("writeCapacityUnits")]
    public long? WriteCapacityUnits { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecSseSpecificationKmsMasterKeyRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for KMSMasterKeyID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecSseSpecificationKmsMasterKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1TableSpecSseSpecificationKmsMasterKeyRefFrom? From { get; set; }
}

/// <summary>Represents the settings used to enable server-side encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecSseSpecification
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("kmsMasterKeyID")]
    public string? KmsMasterKeyID { get; set; }

    /// <summary>Reference field for KMSMasterKeyID</summary>
    [JsonPropertyName("kmsMasterKeyRef")]
    public V1alpha1TableSpecSseSpecificationKmsMasterKeyRef? KmsMasterKeyRef { get; set; }

    [JsonPropertyName("sseType")]
    public string? SseType { get; set; }
}

/// <summary>
/// The settings for DynamoDB Streams on the table. These settings consist of:
/// 
///   - StreamEnabled - Indicates whether DynamoDB Streams is to be enabled
///     (true) or disabled (false).
/// 
///   - StreamViewType - When an item in the table is modified, StreamViewType
///     determines what information is written to the table&apos;s stream. Valid values
///     for StreamViewType are: KEYS_ONLY - Only the key attributes of the modified
///     item are written to the stream. NEW_IMAGE - The entire item, as it appears
///     after it was modified, is written to the stream. OLD_IMAGE - The entire
///     item, as it appeared before it was modified, is written to the stream.
///     NEW_AND_OLD_IMAGES - Both the new and the old item images of the item
///     are written to the stream.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecStreamSpecification
{
    [JsonPropertyName("streamEnabled")]
    public bool? StreamEnabled { get; set; }

    [JsonPropertyName("streamViewType")]
    public string? StreamViewType { get; set; }
}

/// <summary>
/// Replica-specific provisioned throughput settings. If not specified, uses
/// the source table&apos;s provisioned throughput settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecTableReplicasGlobalSecondaryIndexesProvisionedThroughputOverride
{
    [JsonPropertyName("readCapacityUnits")]
    public long? ReadCapacityUnits { get; set; }
}

/// <summary>Represents the properties of a replica global secondary index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecTableReplicasGlobalSecondaryIndexes
{
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>
    /// Replica-specific provisioned throughput settings. If not specified, uses
    /// the source table&apos;s provisioned throughput settings.
    /// </summary>
    [JsonPropertyName("provisionedThroughputOverride")]
    public V1alpha1TableSpecTableReplicasGlobalSecondaryIndexesProvisionedThroughputOverride? ProvisionedThroughputOverride { get; set; }
}

/// <summary>
/// Replica-specific provisioned throughput settings. If not specified, uses
/// the source table&apos;s provisioned throughput settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecTableReplicasProvisionedThroughputOverride
{
    [JsonPropertyName("readCapacityUnits")]
    public long? ReadCapacityUnits { get; set; }
}

/// <summary>Represents a replica to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecTableReplicas
{
    [JsonPropertyName("globalSecondaryIndexes")]
    public IList<V1alpha1TableSpecTableReplicasGlobalSecondaryIndexes>? GlobalSecondaryIndexes { get; set; }

    [JsonPropertyName("kmsMasterKeyID")]
    public string? KmsMasterKeyID { get; set; }

    /// <summary>
    /// Replica-specific provisioned throughput settings. If not specified, uses
    /// the source table&apos;s provisioned throughput settings.
    /// </summary>
    [JsonPropertyName("provisionedThroughputOverride")]
    public V1alpha1TableSpecTableReplicasProvisionedThroughputOverride? ProvisionedThroughputOverride { get; set; }

    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }

    [JsonPropertyName("tableClassOverride")]
    public string? TableClassOverride { get; set; }
}

/// <summary>
/// Describes a tag. A tag is a key-value pair. You can add up to 50 tags to
/// a single DynamoDB table.
/// 
/// Amazon Web Services-assigned tag names and values are automatically assigned
/// the aws: prefix, which the user cannot assign. Amazon Web Services-assigned
/// tag names do not count towards the tag limit of 50. User-assigned tag names
/// have the prefix user: in the Cost Allocation Report. You cannot backdate
/// the application of a tag.
/// 
/// For an overview on tagging DynamoDB resources, see Tagging for DynamoDB (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Tagging.html)
/// in the Amazon DynamoDB Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Represents the settings used to enable or disable Time to Live for the specified
/// table.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecTimeToLive
{
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>TableSpec defines the desired state of Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpec
{
    /// <summary>An array of attributes that describe the key schema for the table and indexes.</summary>
    [JsonPropertyName("attributeDefinitions")]
    public required IList<V1alpha1TableSpecAttributeDefinitions> AttributeDefinitions { get; set; }

    /// <summary>
    /// Controls how you are charged for read and write throughput and how you manage
    /// capacity. This setting can be changed later.
    /// 
    ///   - PROVISIONED - We recommend using PROVISIONED for predictable workloads.
    ///     PROVISIONED sets the billing mode to Provisioned capacity mode (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/provisioned-capacity-mode.html).
    /// 
    ///   - PAY_PER_REQUEST - We recommend using PAY_PER_REQUEST for unpredictable
    ///     workloads. PAY_PER_REQUEST sets the billing mode to On-demand capacity
    ///     mode (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/on-demand-capacity-mode.html).
    /// </summary>
    [JsonPropertyName("billingMode")]
    public string? BillingMode { get; set; }

    /// <summary>Represents the settings used to enable point in time recovery.</summary>
    [JsonPropertyName("continuousBackups")]
    public V1alpha1TableSpecContinuousBackups? ContinuousBackups { get; set; }

    /// <summary>Represents the contributor insights action.</summary>
    [JsonPropertyName("contributorInsights")]
    public string? ContributorInsights { get; set; }

    /// <summary>
    /// Indicates whether deletion protection is to be enabled (true) or disabled
    /// (false) on the table.
    /// </summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// One or more global secondary indexes (the maximum is 20) to be created on
    /// the table. Each global secondary index in the array includes the following:
    /// 
    ///   - IndexName - The name of the global secondary index. Must be unique only
    ///     for this table.
    /// 
    ///   - KeySchema - Specifies the key schema for the global secondary index.
    /// 
    ///   - Projection - Specifies attributes that are copied (projected) from the
    ///     table into the index. These are in addition to the primary key attributes
    ///     and index key attributes, which are automatically projected. Each attribute
    ///     specification is composed of: ProjectionType - One of the following: KEYS_ONLY
    /// 
    ///   - Only the index and primary keys are projected into the index. INCLUDE
    /// 
    ///   - Only the specified table attributes are projected into the index. The
    ///     list of projected attributes is in NonKeyAttributes. ALL - All of the
    ///     table attributes are projected into the index. NonKeyAttributes - A list
    ///     of one or more non-key attribute names that are projected into the secondary
    ///     index. The total count of attributes provided in NonKeyAttributes, summed
    ///     across all of the secondary indexes, must not exceed 100. If you project
    ///     the same attribute into two different indexes, this counts as two distinct
    ///     attributes when determining the total.
    /// 
    ///   - ProvisionedThroughput - The provisioned throughput settings for the
    ///     global secondary index, consisting of read and write capacity units.
    /// </summary>
    [JsonPropertyName("globalSecondaryIndexes")]
    public IList<V1alpha1TableSpecGlobalSecondaryIndexes>? GlobalSecondaryIndexes { get; set; }

    /// <summary>
    /// Specifies the attributes that make up the primary key for a table or an index.
    /// The attributes in KeySchema must also be defined in the AttributeDefinitions
    /// array. For more information, see Data Model (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html)
    /// in the Amazon DynamoDB Developer Guide.
    /// 
    /// Each KeySchemaElement in the array is composed of:
    /// 
    ///   - AttributeName - The name of this key attribute.
    /// 
    ///   - KeyType - The role that the key attribute will assume: HASH - partition
    ///     key RANGE - sort key
    /// 
    /// The partition key of an item is also known as its hash attribute. The term
    /// &quot;hash attribute&quot; derives from the DynamoDB usage of an internal hash function
    /// to evenly distribute data items across partitions, based on their partition
    /// key values.
    /// 
    /// The sort key of an item is also known as its range attribute. The term &quot;range
    /// attribute&quot; derives from the way DynamoDB stores items with the same partition
    /// key physically close together, in sorted order by the sort key value.
    /// 
    /// For a simple primary key (partition key), you must provide exactly one element
    /// with a KeyType of HASH.
    /// 
    /// For a composite primary key (partition key and sort key), you must provide
    /// exactly two elements, in this order: The first element must have a KeyType
    /// of HASH, and the second element must have a KeyType of RANGE.
    /// 
    /// For more information, see Working with Tables (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#WorkingWithTables.primary.key)
    /// in the Amazon DynamoDB Developer Guide.
    /// </summary>
    [JsonPropertyName("keySchema")]
    public required IList<V1alpha1TableSpecKeySchema> KeySchema { get; set; }

    /// <summary>
    /// One or more local secondary indexes (the maximum is 5) to be created on the
    /// table. Each index is scoped to a given partition key value. There is a 10
    /// GB size limit per partition key value; otherwise, the size of a local secondary
    /// index is unconstrained.
    /// 
    /// Each local secondary index in the array includes the following:
    /// 
    ///   - IndexName - The name of the local secondary index. Must be unique only
    ///     for this table.
    /// 
    ///   - KeySchema - Specifies the key schema for the local secondary index.
    ///     The key schema must begin with the same partition key as the table.
    /// 
    ///   - Projection - Specifies attributes that are copied (projected) from the
    ///     table into the index. These are in addition to the primary key attributes
    ///     and index key attributes, which are automatically projected. Each attribute
    ///     specification is composed of: ProjectionType - One of the following: KEYS_ONLY
    /// 
    ///   - Only the index and primary keys are projected into the index. INCLUDE
    /// 
    ///   - Only the specified table attributes are projected into the index. The
    ///     list of projected attributes is in NonKeyAttributes. ALL - All of the
    ///     table attributes are projected into the index. NonKeyAttributes - A list
    ///     of one or more non-key attribute names that are projected into the secondary
    ///     index. The total count of attributes provided in NonKeyAttributes, summed
    ///     across all of the secondary indexes, must not exceed 100. If you project
    ///     the same attribute into two different indexes, this counts as two distinct
    ///     attributes when determining the total.
    /// </summary>
    [JsonPropertyName("localSecondaryIndexes")]
    public IList<V1alpha1TableSpecLocalSecondaryIndexes>? LocalSecondaryIndexes { get; set; }

    /// <summary>
    /// Sets the maximum number of read and write units for the specified table in
    /// on-demand capacity mode. If you use this parameter, you must specify MaxReadRequestUnits,
    /// MaxWriteRequestUnits, or both.
    /// </summary>
    [JsonPropertyName("onDemandThroughput")]
    public V1alpha1TableSpecOnDemandThroughput? OnDemandThroughput { get; set; }

    /// <summary>
    /// Represents the provisioned throughput settings for a specified table or index.
    /// The settings can be modified using the UpdateTable operation.
    /// 
    /// If you set BillingMode as PROVISIONED, you must specify this property. If
    /// you set BillingMode as PAY_PER_REQUEST, you cannot specify this property.
    /// 
    /// For current minimum and maximum provisioned throughput values, see Service,
    /// Account, and Table Quotas (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html)
    /// in the Amazon DynamoDB Developer Guide.
    /// </summary>
    [JsonPropertyName("provisionedThroughput")]
    public V1alpha1TableSpecProvisionedThroughput? ProvisionedThroughput { get; set; }

    /// <summary>
    /// An Amazon Web Services resource-based policy document in JSON format.
    /// 
    ///   - The maximum size supported for a resource-based policy document is 20
    ///     KB. DynamoDB counts whitespaces when calculating the size of a policy
    ///     against this limit.
    /// 
    ///   - Within a resource-based policy, if the action for a DynamoDB service-linked
    ///     role (SLR) to replicate data for a global table is denied, adding or deleting
    ///     a replica will fail with an error.
    /// 
    /// For a full list of all considerations that apply while attaching a resource-based
    /// policy, see Resource-based policy considerations (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/rbac-considerations.html).
    /// </summary>
    [JsonPropertyName("resourcePolicy")]
    public string? ResourcePolicy { get; set; }

    /// <summary>Represents the settings used to enable server-side encryption.</summary>
    [JsonPropertyName("sseSpecification")]
    public V1alpha1TableSpecSseSpecification? SseSpecification { get; set; }

    /// <summary>
    /// The settings for DynamoDB Streams on the table. These settings consist of:
    /// 
    ///   - StreamEnabled - Indicates whether DynamoDB Streams is to be enabled
    ///     (true) or disabled (false).
    /// 
    ///   - StreamViewType - When an item in the table is modified, StreamViewType
    ///     determines what information is written to the table&apos;s stream. Valid values
    ///     for StreamViewType are: KEYS_ONLY - Only the key attributes of the modified
    ///     item are written to the stream. NEW_IMAGE - The entire item, as it appears
    ///     after it was modified, is written to the stream. OLD_IMAGE - The entire
    ///     item, as it appeared before it was modified, is written to the stream.
    ///     NEW_AND_OLD_IMAGES - Both the new and the old item images of the item
    ///     are written to the stream.
    /// </summary>
    [JsonPropertyName("streamSpecification")]
    public V1alpha1TableSpecStreamSpecification? StreamSpecification { get; set; }

    /// <summary>The table class of the new table. Valid values are STANDARD and STANDARD_INFREQUENT_ACCESS.</summary>
    [JsonPropertyName("tableClass")]
    public string? TableClass { get; set; }

    /// <summary>
    /// The name of the table to create. You can also provide the Amazon Resource
    /// Name (ARN) of the table in this parameter.
    /// </summary>
    [JsonPropertyName("tableName")]
    public required string TableName { get; set; }

    [JsonPropertyName("tableReplicas")]
    public IList<V1alpha1TableSpecTableReplicas>? TableReplicas { get; set; }

    /// <summary>
    /// A list of key-value pairs to label the table. For more information, see Tagging
    /// for DynamoDB (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Tagging.html).
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1TableSpecTags>? Tags { get; set; }

    /// <summary>
    /// Represents the settings used to enable or disable Time to Live for the specified
    /// table.
    /// </summary>
    [JsonPropertyName("timeToLive")]
    public V1alpha1TableSpecTimeToLive? TimeToLive { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>Contains information about the table archive.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusArchivalSummary
{
    [JsonPropertyName("archivalBackupARN")]
    public string? ArchivalBackupARN { get; set; }

    [JsonPropertyName("archivalDateTime")]
    public DateTime? ArchivalDateTime { get; set; }

    [JsonPropertyName("archivalReason")]
    public string? ArchivalReason { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// Represents a single element of a key schema. A key schema specifies the attributes
/// that make up the primary key of a table, or the key attributes of an index.
/// 
/// A KeySchemaElement represents exactly one attribute of the primary key. For
/// example, a simple primary key would be represented by one KeySchemaElement
/// (for the partition key). A composite primary key would require one KeySchemaElement
/// for the partition key, and another KeySchemaElement for the sort key.
/// 
/// A KeySchemaElement must be a scalar, top-level attribute (not a nested attribute).
/// The data type must be one of String, Number, or Binary. The attribute cannot
/// be nested within a List or a Map.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusGlobalSecondaryIndexesDescriptionsKeySchema
{
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>
/// Sets the maximum number of read and write units for the specified on-demand
/// table. If you use this parameter, you must specify MaxReadRequestUnits, MaxWriteRequestUnits,
/// or both.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusGlobalSecondaryIndexesDescriptionsOnDemandThroughput
{
    [JsonPropertyName("maxReadRequestUnits")]
    public long? MaxReadRequestUnits { get; set; }

    [JsonPropertyName("maxWriteRequestUnits")]
    public long? MaxWriteRequestUnits { get; set; }
}

/// <summary>
/// Represents attributes that are copied (projected) from the table into an
/// index. These are in addition to the primary key attributes and index key
/// attributes, which are automatically projected.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusGlobalSecondaryIndexesDescriptionsProjection
{
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }
}

/// <summary>
/// Represents the provisioned throughput settings for the table, consisting
/// of read and write capacity units, along with data about increases and decreases.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusGlobalSecondaryIndexesDescriptionsProvisionedThroughput
{
    [JsonPropertyName("lastDecreaseDateTime")]
    public DateTime? LastDecreaseDateTime { get; set; }

    [JsonPropertyName("lastIncreaseDateTime")]
    public DateTime? LastIncreaseDateTime { get; set; }

    [JsonPropertyName("numberOfDecreasesToday")]
    public long? NumberOfDecreasesToday { get; set; }

    [JsonPropertyName("readCapacityUnits")]
    public long? ReadCapacityUnits { get; set; }

    [JsonPropertyName("writeCapacityUnits")]
    public long? WriteCapacityUnits { get; set; }
}

/// <summary>Represents the properties of a global secondary index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusGlobalSecondaryIndexesDescriptions
{
    [JsonPropertyName("backfilling")]
    public bool? Backfilling { get; set; }

    [JsonPropertyName("indexARN")]
    public string? IndexARN { get; set; }

    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    [JsonPropertyName("indexSizeBytes")]
    public long? IndexSizeBytes { get; set; }

    [JsonPropertyName("indexStatus")]
    public string? IndexStatus { get; set; }

    [JsonPropertyName("itemCount")]
    public long? ItemCount { get; set; }

    [JsonPropertyName("keySchema")]
    public IList<V1alpha1TableStatusGlobalSecondaryIndexesDescriptionsKeySchema>? KeySchema { get; set; }

    /// <summary>
    /// Sets the maximum number of read and write units for the specified on-demand
    /// table. If you use this parameter, you must specify MaxReadRequestUnits, MaxWriteRequestUnits,
    /// or both.
    /// </summary>
    [JsonPropertyName("onDemandThroughput")]
    public V1alpha1TableStatusGlobalSecondaryIndexesDescriptionsOnDemandThroughput? OnDemandThroughput { get; set; }

    /// <summary>
    /// Represents attributes that are copied (projected) from the table into an
    /// index. These are in addition to the primary key attributes and index key
    /// attributes, which are automatically projected.
    /// </summary>
    [JsonPropertyName("projection")]
    public V1alpha1TableStatusGlobalSecondaryIndexesDescriptionsProjection? Projection { get; set; }

    /// <summary>
    /// Represents the provisioned throughput settings for the table, consisting
    /// of read and write capacity units, along with data about increases and decreases.
    /// </summary>
    [JsonPropertyName("provisionedThroughput")]
    public V1alpha1TableStatusGlobalSecondaryIndexesDescriptionsProvisionedThroughput? ProvisionedThroughput { get; set; }
}

/// <summary>
/// Replica-specific provisioned throughput settings. If not specified, uses
/// the source table&apos;s provisioned throughput settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusReplicasGlobalSecondaryIndexesProvisionedThroughputOverride
{
    [JsonPropertyName("readCapacityUnits")]
    public long? ReadCapacityUnits { get; set; }
}

/// <summary>Represents the properties of a replica global secondary index.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusReplicasGlobalSecondaryIndexes
{
    [JsonPropertyName("indexName")]
    public string? IndexName { get; set; }

    /// <summary>
    /// Replica-specific provisioned throughput settings. If not specified, uses
    /// the source table&apos;s provisioned throughput settings.
    /// </summary>
    [JsonPropertyName("provisionedThroughputOverride")]
    public V1alpha1TableStatusReplicasGlobalSecondaryIndexesProvisionedThroughputOverride? ProvisionedThroughputOverride { get; set; }
}

/// <summary>
/// Replica-specific provisioned throughput settings. If not specified, uses
/// the source table&apos;s provisioned throughput settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusReplicasProvisionedThroughputOverride
{
    [JsonPropertyName("readCapacityUnits")]
    public long? ReadCapacityUnits { get; set; }
}

/// <summary>Contains details of the table class.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusReplicasReplicaTableClassSummary
{
    [JsonPropertyName("lastUpdateDateTime")]
    public DateTime? LastUpdateDateTime { get; set; }

    [JsonPropertyName("tableClass")]
    public string? TableClass { get; set; }
}

/// <summary>Contains the details of the replica.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusReplicas
{
    [JsonPropertyName("globalSecondaryIndexes")]
    public IList<V1alpha1TableStatusReplicasGlobalSecondaryIndexes>? GlobalSecondaryIndexes { get; set; }

    [JsonPropertyName("kmsMasterKeyID")]
    public string? KmsMasterKeyID { get; set; }

    /// <summary>
    /// Replica-specific provisioned throughput settings. If not specified, uses
    /// the source table&apos;s provisioned throughput settings.
    /// </summary>
    [JsonPropertyName("provisionedThroughputOverride")]
    public V1alpha1TableStatusReplicasProvisionedThroughputOverride? ProvisionedThroughputOverride { get; set; }

    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }

    [JsonPropertyName("replicaInaccessibleDateTime")]
    public DateTime? ReplicaInaccessibleDateTime { get; set; }

    [JsonPropertyName("replicaStatus")]
    public string? ReplicaStatus { get; set; }

    [JsonPropertyName("replicaStatusDescription")]
    public string? ReplicaStatusDescription { get; set; }

    [JsonPropertyName("replicaStatusPercentProgress")]
    public string? ReplicaStatusPercentProgress { get; set; }

    /// <summary>Contains details of the table class.</summary>
    [JsonPropertyName("replicaTableClassSummary")]
    public V1alpha1TableStatusReplicasReplicaTableClassSummary? ReplicaTableClassSummary { get; set; }
}

/// <summary>Contains details for the restore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatusRestoreSummary
{
    [JsonPropertyName("restoreDateTime")]
    public DateTime? RestoreDateTime { get; set; }

    [JsonPropertyName("restoreInProgress")]
    public bool? RestoreInProgress { get; set; }

    [JsonPropertyName("sourceBackupARN")]
    public string? SourceBackupARN { get; set; }

    [JsonPropertyName("sourceTableARN")]
    public string? SourceTableARN { get; set; }
}

/// <summary>TableStatus defines the observed state of Table</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1TableStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>Contains information about the table archive.</summary>
    [JsonPropertyName("archivalSummary")]
    public V1alpha1TableStatusArchivalSummary? ArchivalSummary { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1TableStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time when the table was created, in UNIX epoch time (http://www.epochconverter.com/)
    /// format.
    /// </summary>
    [JsonPropertyName("creationDateTime")]
    public DateTime? CreationDateTime { get; set; }

    [JsonPropertyName("globalSecondaryIndexesDescriptions")]
    public IList<V1alpha1TableStatusGlobalSecondaryIndexesDescriptions>? GlobalSecondaryIndexesDescriptions { get; set; }

    /// <summary>
    /// Represents the version of global tables (https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html)
    /// in use, if the table is replicated across Amazon Web Services Regions.
    /// </summary>
    [JsonPropertyName("globalTableVersion")]
    public string? GlobalTableVersion { get; set; }

    /// <summary>
    /// The number of items in the specified table. DynamoDB updates this value approximately
    /// every six hours. Recent changes might not be reflected in this value.
    /// </summary>
    [JsonPropertyName("itemCount")]
    public long? ItemCount { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) that uniquely identifies the latest stream
    /// for this table.
    /// </summary>
    [JsonPropertyName("latestStreamARN")]
    public string? LatestStreamARN { get; set; }

    /// <summary>
    /// A timestamp, in ISO 8601 format, for this stream.
    /// 
    /// Note that LatestStreamLabel is not a unique identifier for the stream, because
    /// it is possible that a stream from another table might have the same timestamp.
    /// However, the combination of the following three elements is guaranteed to
    /// be unique:
    /// 
    ///    * Amazon Web Services customer ID
    /// 
    ///    * Table name
    /// 
    ///    * StreamLabel
    /// </summary>
    [JsonPropertyName("latestStreamLabel")]
    public string? LatestStreamLabel { get; set; }

    /// <summary>Represents replicas of the table.</summary>
    [JsonPropertyName("replicas")]
    public IList<V1alpha1TableStatusReplicas>? Replicas { get; set; }

    /// <summary>Contains details for the restore.</summary>
    [JsonPropertyName("restoreSummary")]
    public V1alpha1TableStatusRestoreSummary? RestoreSummary { get; set; }

    /// <summary>
    /// Unique identifier for the table for which the backup was created.
    /// 
    /// Regex Pattern: `^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$`
    /// </summary>
    [JsonPropertyName("tableID")]
    public string? TableID { get; set; }

    /// <summary>
    /// The total size of the specified table, in bytes. DynamoDB updates this value
    /// approximately every six hours. Recent changes might not be reflected in this
    /// value.
    /// </summary>
    [JsonPropertyName("tableSizeBytes")]
    public long? TableSizeBytes { get; set; }

    /// <summary>
    /// The current state of the table:
    /// 
    ///    * CREATING - The table is being created.
    /// 
    ///    * UPDATING - The table/index configuration is being updated. The table/index
    ///    remains available for data operations when UPDATING.
    /// 
    ///    * DELETING - The table is being deleted.
    /// 
    ///    * ACTIVE - The table is ready for use.
    /// 
    ///    * INACCESSIBLE_ENCRYPTION_CREDENTIALS - The KMS key used to encrypt the
    ///    table in inaccessible. Table operations may fail due to failure to use
    ///    the KMS key. DynamoDB will initiate the table archival process when a
    ///    table&apos;s KMS key remains inaccessible for more than seven days.
    /// 
    ///    * ARCHIVING - The table is being archived. Operations are not allowed
    ///    until archival is complete.
    /// 
    ///    * ARCHIVED - The table has been archived. See the ArchivalReason for more
    ///    information.
    /// </summary>
    [JsonPropertyName("tableStatus")]
    public string? TableStatus { get; set; }
}

/// <summary>Table is the Schema for the Tables API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Table : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TableSpec?>, IStatus<V1alpha1TableStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Table";
    public const string KubeGroup = "dynamodb.services.k8s.aws";
    public const string KubePluralName = "tables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dynamodb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Table";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TableSpec defines the desired state of Table.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1TableSpec? Spec { get; set; }

    /// <summary>TableStatus defines the observed state of Table</summary>
    [JsonPropertyName("status")]
    public V1alpha1TableStatus? Status { get; set; }
}