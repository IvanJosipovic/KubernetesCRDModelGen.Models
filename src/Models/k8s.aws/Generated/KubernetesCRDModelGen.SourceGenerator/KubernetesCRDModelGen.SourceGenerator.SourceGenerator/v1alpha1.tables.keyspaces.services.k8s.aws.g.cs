#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keyspaces.services.k8s.aws;
/// <summary>Table is the Schema for the Tables API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TableList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Table>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TableList";
    public const string KubeGroup = "keyspaces.services.k8s.aws";
    public const string KubePluralName = "tables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keyspaces.services.k8s.aws/v1alpha1";

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

/// <summary>
/// Specifies the read/write throughput capacity mode for the table. The options
/// are:
/// 
///   - throughputMode:PAY_PER_REQUEST and
/// 
///   - throughputMode:PROVISIONED - Provisioned capacity mode requires readCapacityUnits
///     and writeCapacityUnits as input.
/// 
/// The default is throughput_mode:PAY_PER_REQUEST.
/// 
/// For more information, see Read/write capacity modes (https://docs.aws.amazon.com/keyspaces/latest/devguide/ReadWriteCapacityMode.html)
/// in the Amazon Keyspaces Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecCapacitySpecification
{
    [JsonPropertyName("readCapacityUnits")]
    public long? ReadCapacityUnits { get; set; }

    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }

    [JsonPropertyName("writeCapacityUnits")]
    public long? WriteCapacityUnits { get; set; }
}

/// <summary>
/// Enables client-side timestamps for the table. By default, the setting is
/// disabled. You can enable client-side timestamps with the following option:
/// 
///   - status: &quot;enabled&quot;
/// 
/// Once client-side timestamps are enabled for a table, this setting cannot
/// be disabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecClientSideTimestamps
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>This parameter allows to enter a description of the table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecComment
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecEncryptionSpecificationKmsKeyIdentifierRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for KMSKeyIdentifier</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecEncryptionSpecificationKmsKeyIdentifierRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1TableSpecEncryptionSpecificationKmsKeyIdentifierRefFrom? From { get; set; }
}

/// <summary>
/// Specifies how the encryption key for encryption at rest is managed for the
/// table. You can choose one of the following KMS key (KMS key):
/// 
///   - type:AWS_OWNED_KMS_KEY - This key is owned by Amazon Keyspaces.
/// 
///   - type:CUSTOMER_MANAGED_KMS_KEY - This key is stored in your account and
///     is created, owned, and managed by you. This option requires the kms_key_identifier
///     of the KMS key in Amazon Resource Name (ARN) format as input.
/// 
/// The default is type:AWS_OWNED_KMS_KEY.
/// 
/// For more information, see Encryption at rest (https://docs.aws.amazon.com/keyspaces/latest/devguide/EncryptionAtRest.html)
/// in the Amazon Keyspaces Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecEncryptionSpecification
{
    [JsonPropertyName("kmsKeyIdentifier")]
    public string? KmsKeyIdentifier { get; set; }

    /// <summary>Reference field for KMSKeyIdentifier</summary>
    [JsonPropertyName("kmsKeyIdentifierRef")]
    public V1alpha1TableSpecEncryptionSpecificationKmsKeyIdentifierRef? KmsKeyIdentifierRef { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies if pointInTimeRecovery is enabled or disabled for the table. The
/// options are:
/// 
///   - status=ENABLED
/// 
///   - status=DISABLED
/// 
/// If it&apos;s not specified, the default is status=DISABLED.
/// 
/// For more information, see Point-in-time recovery (https://docs.aws.amazon.com/keyspaces/latest/devguide/PointInTimeRecovery.html)
/// in the Amazon Keyspaces Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecPointInTimeRecovery
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The names and data types of regular columns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecSchemaDefinitionAllColumns
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// The optional clustering column portion of your primary key determines how
/// the data is clustered and sorted within each partition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecSchemaDefinitionClusteringKeys
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("orderBy")]
    public string? OrderBy { get; set; }
}

/// <summary>
/// The partition key portion of the primary key is required and determines how
/// Amazon Keyspaces stores the data. The partition key can be a single column,
/// or it can be a compound value composed of two or more columns.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecSchemaDefinitionPartitionKeys
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The static columns of the table. Static columns store values that are shared
/// by all rows in the same partition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecSchemaDefinitionStaticColumns
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// The schemaDefinition consists of the following parameters.
/// 
/// For each column to be created:
/// 
///   - name - The name of the column.
/// 
///   - type - An Amazon Keyspaces data type. For more information, see Data
///     types (https://docs.aws.amazon.com/keyspaces/latest/devguide/cql.elements.html#cql.data-types)
///     in the Amazon Keyspaces Developer Guide.
/// 
/// The primary key of the table consists of the following columns:
/// 
///   - partitionKeys - The partition key can be a single column, or it can
///     be a compound value composed of two or more columns. The partition key
///     portion of the primary key is required and determines how Amazon Keyspaces
///     stores your data.
/// 
///   - name - The name of each partition key column.
/// 
///   - clusteringKeys - The optional clustering column portion of your primary
///     key determines how the data is clustered and sorted within each partition.
/// 
///   - name - The name of the clustering column.
/// 
///   - orderBy - Sets the ascendant (ASC) or descendant (DESC) order modifier.
///     To define a column as static use staticColumns - Static columns store
///     values that are shared by all rows in the same partition:
/// 
///   - name - The name of the column.
/// 
///   - type - An Amazon Keyspaces data type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecSchemaDefinition
{
    [JsonPropertyName("allColumns")]
    public IList<V1alpha1TableSpecSchemaDefinitionAllColumns>? AllColumns { get; set; }

    [JsonPropertyName("clusteringKeys")]
    public IList<V1alpha1TableSpecSchemaDefinitionClusteringKeys>? ClusteringKeys { get; set; }

    [JsonPropertyName("partitionKeys")]
    public IList<V1alpha1TableSpecSchemaDefinitionPartitionKeys>? PartitionKeys { get; set; }

    [JsonPropertyName("staticColumns")]
    public IList<V1alpha1TableSpecSchemaDefinitionStaticColumns>? StaticColumns { get; set; }
}

/// <summary>
/// Describes a tag. A tag is a key-value pair. You can add up to 50 tags to
/// a single Amazon Keyspaces resource.
/// 
/// Amazon Web Services-assigned tag names and values are automatically assigned
/// the aws: prefix, which the user cannot assign. Amazon Web Services-assigned
/// tag names do not count towards the tag limit of 50. User-assigned tag names
/// have the prefix user: in the Cost Allocation Report. You cannot backdate
/// the application of a tag.
/// 
/// For more information, see Adding tags and labels to Amazon Keyspaces resources
/// (https://docs.aws.amazon.com/keyspaces/latest/devguide/tagging-keyspaces.html)
/// in the Amazon Keyspaces Developer Guide.
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
/// Enables Time to Live custom settings for the table. The options are:
/// 
///   - status:enabled
/// 
///   - status:disabled
/// 
/// The default is status:disabled. After ttl is enabled, you can&apos;t disable it
/// for the table.
/// 
/// For more information, see Expiring data by using Amazon Keyspaces Time to
/// Live (TTL) (https://docs.aws.amazon.com/keyspaces/latest/devguide/TTL.html)
/// in the Amazon Keyspaces Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpecTtl
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>TableSpec defines the desired state of Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TableSpec
{
    /// <summary>
    /// Specifies the read/write throughput capacity mode for the table. The options
    /// are:
    /// 
    ///   - throughputMode:PAY_PER_REQUEST and
    /// 
    ///   - throughputMode:PROVISIONED - Provisioned capacity mode requires readCapacityUnits
    ///     and writeCapacityUnits as input.
    /// 
    /// The default is throughput_mode:PAY_PER_REQUEST.
    /// 
    /// For more information, see Read/write capacity modes (https://docs.aws.amazon.com/keyspaces/latest/devguide/ReadWriteCapacityMode.html)
    /// in the Amazon Keyspaces Developer Guide.
    /// </summary>
    [JsonPropertyName("capacitySpecification")]
    public V1alpha1TableSpecCapacitySpecification? CapacitySpecification { get; set; }

    /// <summary>
    /// Enables client-side timestamps for the table. By default, the setting is
    /// disabled. You can enable client-side timestamps with the following option:
    /// 
    ///   - status: &quot;enabled&quot;
    /// 
    /// Once client-side timestamps are enabled for a table, this setting cannot
    /// be disabled.
    /// </summary>
    [JsonPropertyName("clientSideTimestamps")]
    public V1alpha1TableSpecClientSideTimestamps? ClientSideTimestamps { get; set; }

    /// <summary>This parameter allows to enter a description of the table.</summary>
    [JsonPropertyName("comment")]
    public V1alpha1TableSpecComment? Comment { get; set; }

    /// <summary>
    /// The default Time to Live setting in seconds for the table.
    /// 
    /// For more information, see Setting the default TTL value for a table (https://docs.aws.amazon.com/keyspaces/latest/devguide/TTL-how-it-works.html#ttl-howitworks_default_ttl)
    /// in the Amazon Keyspaces Developer Guide.
    /// </summary>
    [JsonPropertyName("defaultTimeToLive")]
    public long? DefaultTimeToLive { get; set; }

    /// <summary>
    /// Specifies how the encryption key for encryption at rest is managed for the
    /// table. You can choose one of the following KMS key (KMS key):
    /// 
    ///   - type:AWS_OWNED_KMS_KEY - This key is owned by Amazon Keyspaces.
    /// 
    ///   - type:CUSTOMER_MANAGED_KMS_KEY - This key is stored in your account and
    ///     is created, owned, and managed by you. This option requires the kms_key_identifier
    ///     of the KMS key in Amazon Resource Name (ARN) format as input.
    /// 
    /// The default is type:AWS_OWNED_KMS_KEY.
    /// 
    /// For more information, see Encryption at rest (https://docs.aws.amazon.com/keyspaces/latest/devguide/EncryptionAtRest.html)
    /// in the Amazon Keyspaces Developer Guide.
    /// </summary>
    [JsonPropertyName("encryptionSpecification")]
    public V1alpha1TableSpecEncryptionSpecification? EncryptionSpecification { get; set; }

    /// <summary>
    /// The name of the keyspace that the table is going to be created in.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9][a-zA-Z0-9_]{0,47}$`
    /// </summary>
    [JsonPropertyName("keyspaceName")]
    public required string KeyspaceName { get; set; }

    /// <summary>
    /// Specifies if pointInTimeRecovery is enabled or disabled for the table. The
    /// options are:
    /// 
    ///   - status=ENABLED
    /// 
    ///   - status=DISABLED
    /// 
    /// If it&apos;s not specified, the default is status=DISABLED.
    /// 
    /// For more information, see Point-in-time recovery (https://docs.aws.amazon.com/keyspaces/latest/devguide/PointInTimeRecovery.html)
    /// in the Amazon Keyspaces Developer Guide.
    /// </summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public V1alpha1TableSpecPointInTimeRecovery? PointInTimeRecovery { get; set; }

    /// <summary>
    /// The schemaDefinition consists of the following parameters.
    /// 
    /// For each column to be created:
    /// 
    ///   - name - The name of the column.
    /// 
    ///   - type - An Amazon Keyspaces data type. For more information, see Data
    ///     types (https://docs.aws.amazon.com/keyspaces/latest/devguide/cql.elements.html#cql.data-types)
    ///     in the Amazon Keyspaces Developer Guide.
    /// 
    /// The primary key of the table consists of the following columns:
    /// 
    ///   - partitionKeys - The partition key can be a single column, or it can
    ///     be a compound value composed of two or more columns. The partition key
    ///     portion of the primary key is required and determines how Amazon Keyspaces
    ///     stores your data.
    /// 
    ///   - name - The name of each partition key column.
    /// 
    ///   - clusteringKeys - The optional clustering column portion of your primary
    ///     key determines how the data is clustered and sorted within each partition.
    /// 
    ///   - name - The name of the clustering column.
    /// 
    ///   - orderBy - Sets the ascendant (ASC) or descendant (DESC) order modifier.
    ///     To define a column as static use staticColumns - Static columns store
    ///     values that are shared by all rows in the same partition:
    /// 
    ///   - name - The name of the column.
    /// 
    ///   - type - An Amazon Keyspaces data type.
    /// </summary>
    [JsonPropertyName("schemaDefinition")]
    public required V1alpha1TableSpecSchemaDefinition SchemaDefinition { get; set; }

    /// <summary>
    /// The name of the table.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9][a-zA-Z0-9_]{0,47}$`
    /// </summary>
    [JsonPropertyName("tableName")]
    public required string TableName { get; set; }

    /// <summary>
    /// A list of key-value pair tags to be attached to the resource.
    /// 
    /// For more information, see Adding tags and labels to Amazon Keyspaces resources
    /// (https://docs.aws.amazon.com/keyspaces/latest/devguide/tagging-keyspaces.html)
    /// in the Amazon Keyspaces Developer Guide.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1TableSpecTags>? Tags { get; set; }

    /// <summary>
    /// Enables Time to Live custom settings for the table. The options are:
    /// 
    ///   - status:enabled
    /// 
    ///   - status:disabled
    /// 
    /// The default is status:disabled. After ttl is enabled, you can&apos;t disable it
    /// for the table.
    /// 
    /// For more information, see Expiring data by using Amazon Keyspaces Time to
    /// Live (TTL) (https://docs.aws.amazon.com/keyspaces/latest/devguide/TTL.html)
    /// in the Amazon Keyspaces Developer Guide.
    /// </summary>
    [JsonPropertyName("ttl")]
    public V1alpha1TableSpecTtl? Ttl { get; set; }
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

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1TableStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Table is the Schema for the Tables API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Table : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TableSpec?>, IStatus<V1alpha1TableStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Table";
    public const string KubeGroup = "keyspaces.services.k8s.aws";
    public const string KubePluralName = "tables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keyspaces.services.k8s.aws/v1alpha1";

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