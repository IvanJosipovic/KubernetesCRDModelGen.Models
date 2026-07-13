#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dynamodb.aws.m.upbound.io;
/// <summary>Table is the Schema for the Tables API. Provides a DynamoDB table resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TableList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Table>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TableList";
    public const string KubeGroup = "dynamodb.aws.m.upbound.io";
    public const string KubePluralName = "tables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dynamodb.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TableList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Table objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Table> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderAttribute
{
    /// <summary>Name of the attribute</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Attribute type. Valid values are S (string), N (number), B (binary).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderGlobalSecondaryIndexKeySchema
{
    /// <summary>Name of the attribute; must be defined as an attribute in the resource.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>The type of key. Valid values are HASH (partition key) or RANGE (sort key). You can specify up to 4 attributes with key_type = &quot;HASH&quot; and up to 4 attributes with key_type = &quot;RANGE&quot;.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>Sets the maximum number of read and write units for the specified on-demand index. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderGlobalSecondaryIndexOnDemandThroughput
{
    /// <summary>Maximum number of read request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxReadRequestUnits")]
    public double? MaxReadRequestUnits { get; set; }

    /// <summary>Maximum number of write request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxWriteRequestUnits")]
    public double? MaxWriteRequestUnits { get; set; }
}

/// <summary>Sets the number of warm read and write units for this index. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderGlobalSecondaryIndexWarmThroughput
{
    /// <summary>Number of read operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 12000 (default).</summary>
    [JsonPropertyName("readUnitsPerSecond")]
    public double? ReadUnitsPerSecond { get; set; }

    /// <summary>Number of write operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 4000 (default).</summary>
    [JsonPropertyName("writeUnitsPerSecond")]
    public double? WriteUnitsPerSecond { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderGlobalSecondaryIndex
{
    /// <summary>Name of the hash key in the index; must be defined as an attribute in the resource. Mutually exclusive with key_schema. Use key_schema instead.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Configuration block(s) for the key schema. Mutually exclusive with hash_key and range_key. Required if hash_key is not specified. Supports multi-attribute keys for the Multi-Attribute Keys design pattern. See below.</summary>
    [JsonPropertyName("keySchema")]
    public IList<V1beta1TableSpecForProviderGlobalSecondaryIndexKeySchema>? KeySchema { get; set; }

    /// <summary>Name of the index.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>Sets the maximum number of read and write units for the specified on-demand index. See below.</summary>
    [JsonPropertyName("onDemandThroughput")]
    public V1beta1TableSpecForProviderGlobalSecondaryIndexOnDemandThroughput? OnDemandThroughput { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects into the index only the table and index hash_key and sort_key attributes, INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that KEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key; must be defined as an attribute in the resource. Mutually exclusive with key_schema. Use key_schema instead.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>Sets the number of warm read and write units for this index. See below.</summary>
    [JsonPropertyName("warmThroughput")]
    public V1beta1TableSpecForProviderGlobalSecondaryIndexWarmThroughput? WarmThroughput { get; set; }

    /// <summary>Number of write units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
}

/// <summary>Witness Region in a Multi-Region Strong Consistency deployment. Note This must be used alongside a single replica with consistency_mode set to STRONG. Other combinations will fail to provision. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderGlobalTableWitness
{
    /// <summary>Name of the AWS Region that serves as a witness for the MRSC global table.</summary>
    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }
}

/// <summary>This block contains the processing options for the CSV file being imported:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderImportTableInputFormatOptionsCsv
{
    /// <summary>The delimiter used for separating items in the CSV file being imported.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>List of the headers used to specify a common header for all source CSV files being imported.</summary>
    [JsonPropertyName("headerList")]
    public IList<string>? HeaderList { get; set; }
}

/// <summary>
/// Describe the format options for the data that was imported into the target table.
/// There is one value, csv.
/// See below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderImportTableInputFormatOptions
{
    /// <summary>This block contains the processing options for the CSV file being imported:</summary>
    [JsonPropertyName("csv")]
    public V1beta1TableSpecForProviderImportTableInputFormatOptionsCsv? Csv { get; set; }
}

/// <summary>
/// Values for the S3 bucket the source file is imported from.
/// See below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderImportTableS3BucketSource
{
    /// <summary>The S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The account number of the S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucketOwner")]
    public string? BucketOwner { get; set; }

    /// <summary>The key prefix shared by all S3 Objects that are being imported.</summary>
    [JsonPropertyName("keyPrefix")]
    public string? KeyPrefix { get; set; }
}

/// <summary>Import Amazon S3 data into a new table. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderImportTable
{
    /// <summary>
    /// Type of compression to be used on the input coming from the imported table.
    /// Valid values are GZIP, ZSTD and NONE.
    /// </summary>
    [JsonPropertyName("inputCompressionType")]
    public string? InputCompressionType { get; set; }

    /// <summary>
    /// The format of the source data.
    /// Valid values are CSV, DYNAMODB_JSON, and ION.
    /// </summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>
    /// Describe the format options for the data that was imported into the target table.
    /// There is one value, csv.
    /// See below.
    /// </summary>
    [JsonPropertyName("inputFormatOptions")]
    public V1beta1TableSpecForProviderImportTableInputFormatOptions? InputFormatOptions { get; set; }

    /// <summary>
    /// Values for the S3 bucket the source file is imported from.
    /// See below.
    /// </summary>
    [JsonPropertyName("s3BucketSource")]
    public V1beta1TableSpecForProviderImportTableS3BucketSource? S3BucketSource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderLocalSecondaryIndex
{
    /// <summary>Name of the index</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects  into the index only the table and index hash_key and sort_key attributes ,  INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that thatKEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }
}

/// <summary>Sets the maximum number of read and write units for the specified on-demand table. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderOnDemandThroughput
{
    /// <summary>Maximum number of read request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxReadRequestUnits")]
    public double? MaxReadRequestUnits { get; set; }

    /// <summary>Maximum number of write request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxWriteRequestUnits")]
    public double? MaxWriteRequestUnits { get; set; }
}

/// <summary>Enable point-in-time recovery options. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderPointInTimeRecovery
{
    /// <summary>Whether to enable point-in-time recovery. It can take 10 minutes to enable for new tables. If the point_in_time_recovery block is not provided, this defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Number of preceding days for which continuous backups are taken and maintained. Default is 35.</summary>
    [JsonPropertyName("recoveryPeriodInDays")]
    public double? RecoveryPeriodInDays { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecForProviderReplicaKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1TableSpecForProviderReplicaKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecForProviderReplicaKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1TableSpecForProviderReplicaKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderReplicaKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TableSpecForProviderReplicaKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TableSpecForProviderReplicaKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderReplicaKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecForProviderReplicaKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecForProviderReplicaKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1TableSpecForProviderReplicaKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecForProviderReplicaKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1TableSpecForProviderReplicaKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderReplicaKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TableSpecForProviderReplicaKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TableSpecForProviderReplicaKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderReplicaKmsKeyArnSelector
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
    public V1beta1TableSpecForProviderReplicaKmsKeyArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderReplica
{
    /// <summary>Whether this global table will be using STRONG consistency mode or EVENTUAL consistency mode. Default value is EVENTUAL.</summary>
    [JsonPropertyName("consistencyMode")]
    public string? ConsistencyMode { get; set; }

    /// <summary>Whether deletion protection is enabled (true) or disabled (false) on the replica. Default is false.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// ARN of the CMK that should be used for the AWS KMS encryption.
    /// This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb.
    /// Note: This attribute will not be populated with the ARN of default keys.
    /// Note: Changing this value will recreate the replica.
    /// </summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1TableSpecForProviderReplicaKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1TableSpecForProviderReplicaKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Whether to enable Point In Time Recovery for the replica. Default is false.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public bool? PointInTimeRecovery { get; set; }

    /// <summary>
    /// Whether to propagate the global table&apos;s tags to a replica.
    /// Default is false.
    /// Changes to tags only move in one direction: from global (source) to replica.
    /// Tag drift on a replica will not trigger an update.
    /// Tag changes on the global table are propagated to replicas.
    /// Changing from true to false on a subsequent apply leaves replica tags as-is and no longer manages them.
    /// </summary>
    [JsonPropertyName("propagateTags")]
    public bool? PropagateTags { get; set; }

    /// <summary>Region name of the replica.</summary>
    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnSelector
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
    public V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Encryption at rest options. AWS DynamoDB tables are automatically encrypted at rest with an AWS-owned Customer Master Key if this argument isn&apos;t specified. Must be supplied for cross-region restores. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderServerSideEncryption
{
    /// <summary>Whether or not to enable encryption at rest using an AWS managed KMS customer master key (CMK). If enabled is false then server-side encryption is set to AWS-owned key (shown as DEFAULT in the AWS console). Potentially confusingly, if enabled is true and no kms_key_arn is specified then server-side encryption is set to the default KMS-managed key (shown as KMS in the AWS console). The AWS KMS documentation explains the difference between AWS-owned and KMS-managed keys.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ARN of the CMK that should be used for the AWS KMS encryption. This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb. Note: This attribute will not be populated with the ARN of default keys.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1TableSpecForProviderServerSideEncryptionKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
}

/// <summary>Configuration block for TTL. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderTtl
{
    /// <summary>
    /// Name of the table attribute to store the TTL timestamp in.
    /// Required if enabled is true, must not be set otherwise.
    /// </summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>
    /// Whether TTL is enabled.
    /// Default value is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Sets the number of warm read and write units for the specified table. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProviderWarmThroughput
{
    /// <summary>Number of read operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 12000 (default).</summary>
    [JsonPropertyName("readUnitsPerSecond")]
    public double? ReadUnitsPerSecond { get; set; }

    /// <summary>Number of write operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 4000 (default).</summary>
    [JsonPropertyName("writeUnitsPerSecond")]
    public double? WriteUnitsPerSecond { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecForProvider
{
    /// <summary>Set of nested attribute definitions. Only required for hash_key and range_key attributes. See below.</summary>
    [JsonPropertyName("attribute")]
    public IList<V1beta1TableSpecForProviderAttribute>? Attribute { get; set; }

    /// <summary>Controls how you are charged for read and write throughput and how you manage capacity. The valid values are PROVISIONED and PAY_PER_REQUEST. Defaults to PROVISIONED.</summary>
    [JsonPropertyName("billingMode")]
    public string? BillingMode { get; set; }

    /// <summary>Enables deletion protection for table. Defaults to false.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Describe a GSI for the table; subject to the normal limits on the number of GSIs, projected attributes, etc. See below.</summary>
    [JsonPropertyName("globalSecondaryIndex")]
    public IList<V1beta1TableSpecForProviderGlobalSecondaryIndex>? GlobalSecondaryIndex { get; set; }

    /// <summary>Witness Region in a Multi-Region Strong Consistency deployment. Note This must be used alongside a single replica with consistency_mode set to STRONG. Other combinations will fail to provision. See below.</summary>
    [JsonPropertyName("globalTableWitness")]
    public V1beta1TableSpecForProviderGlobalTableWitness? GlobalTableWitness { get; set; }

    /// <summary>Attribute to use as the hash (partition) key. Must also be defined as an attribute. See below.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Import Amazon S3 data into a new table. See below.</summary>
    [JsonPropertyName("importTable")]
    public V1beta1TableSpecForProviderImportTable? ImportTable { get; set; }

    /// <summary>Describe an LSI on the table; these can only be allocated at creation so you cannot change this definition after you have created the resource. See below.</summary>
    [JsonPropertyName("localSecondaryIndex")]
    public IList<V1beta1TableSpecForProviderLocalSecondaryIndex>? LocalSecondaryIndex { get; set; }

    /// <summary>Sets the maximum number of read and write units for the specified on-demand table. See below.</summary>
    [JsonPropertyName("onDemandThroughput")]
    public V1beta1TableSpecForProviderOnDemandThroughput? OnDemandThroughput { get; set; }

    /// <summary>Enable point-in-time recovery options. See below.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public V1beta1TableSpecForProviderPointInTimeRecovery? PointInTimeRecovery { get; set; }

    /// <summary>Attribute to use as the range (sort) key. Must also be defined as an attribute, see below.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration block(s) with DynamoDB Global Tables V2 (version 2019.11.21) replication configurations. See below.</summary>
    [JsonPropertyName("replica")]
    public IList<V1beta1TableSpecForProviderReplica>? Replica { get; set; }

    /// <summary>Time of the point-in-time recovery point to restore.</summary>
    [JsonPropertyName("restoreDateTime")]
    public string? RestoreDateTime { get; set; }

    /// <summary>Name of the table to restore. Must match the name of an existing table.</summary>
    [JsonPropertyName("restoreSourceName")]
    public string? RestoreSourceName { get; set; }

    /// <summary>ARN of the source table to restore. Must be supplied for cross-region restores.</summary>
    [JsonPropertyName("restoreSourceTableArn")]
    public string? RestoreSourceTableArn { get; set; }

    /// <summary>If set, restores table to the most recent point-in-time recovery point.</summary>
    [JsonPropertyName("restoreToLatestTime")]
    public bool? RestoreToLatestTime { get; set; }

    /// <summary>Encryption at rest options. AWS DynamoDB tables are automatically encrypted at rest with an AWS-owned Customer Master Key if this argument isn&apos;t specified. Must be supplied for cross-region restores. See below.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public V1beta1TableSpecForProviderServerSideEncryption? ServerSideEncryption { get; set; }

    /// <summary>Whether Streams are enabled.</summary>
    [JsonPropertyName("streamEnabled")]
    public bool? StreamEnabled { get; set; }

    /// <summary>
    /// When an item in the table is modified, StreamViewType determines what information is written to the table&apos;s stream.
    /// Valid values are KEYS_ONLY, NEW_IMAGE, OLD_IMAGE, NEW_AND_OLD_IMAGES.
    /// Only valid when stream_enabled is true.
    /// </summary>
    [JsonPropertyName("streamViewType")]
    public string? StreamViewType { get; set; }

    /// <summary>
    /// Storage class of the table.
    /// Valid values are STANDARD and STANDARD_INFREQUENT_ACCESS.
    /// Default value is STANDARD.
    /// </summary>
    [JsonPropertyName("tableClass")]
    public string? TableClass { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for TTL. See below.</summary>
    [JsonPropertyName("ttl")]
    public V1beta1TableSpecForProviderTtl? Ttl { get; set; }

    /// <summary>Sets the number of warm read and write units for the specified table. See below.</summary>
    [JsonPropertyName("warmThroughput")]
    public V1beta1TableSpecForProviderWarmThroughput? WarmThroughput { get; set; }

    /// <summary>Number of write units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderAttribute
{
    /// <summary>Name of the attribute</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Attribute type. Valid values are S (string), N (number), B (binary).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderGlobalSecondaryIndexKeySchema
{
    /// <summary>Name of the attribute; must be defined as an attribute in the resource.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>The type of key. Valid values are HASH (partition key) or RANGE (sort key). You can specify up to 4 attributes with key_type = &quot;HASH&quot; and up to 4 attributes with key_type = &quot;RANGE&quot;.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>Sets the maximum number of read and write units for the specified on-demand index. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderGlobalSecondaryIndexOnDemandThroughput
{
    /// <summary>Maximum number of read request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxReadRequestUnits")]
    public double? MaxReadRequestUnits { get; set; }

    /// <summary>Maximum number of write request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxWriteRequestUnits")]
    public double? MaxWriteRequestUnits { get; set; }
}

/// <summary>Sets the number of warm read and write units for this index. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderGlobalSecondaryIndexWarmThroughput
{
    /// <summary>Number of read operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 12000 (default).</summary>
    [JsonPropertyName("readUnitsPerSecond")]
    public double? ReadUnitsPerSecond { get; set; }

    /// <summary>Number of write operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 4000 (default).</summary>
    [JsonPropertyName("writeUnitsPerSecond")]
    public double? WriteUnitsPerSecond { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderGlobalSecondaryIndex
{
    /// <summary>Name of the hash key in the index; must be defined as an attribute in the resource. Mutually exclusive with key_schema. Use key_schema instead.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Configuration block(s) for the key schema. Mutually exclusive with hash_key and range_key. Required if hash_key is not specified. Supports multi-attribute keys for the Multi-Attribute Keys design pattern. See below.</summary>
    [JsonPropertyName("keySchema")]
    public IList<V1beta1TableSpecInitProviderGlobalSecondaryIndexKeySchema>? KeySchema { get; set; }

    /// <summary>Name of the index.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>Sets the maximum number of read and write units for the specified on-demand index. See below.</summary>
    [JsonPropertyName("onDemandThroughput")]
    public V1beta1TableSpecInitProviderGlobalSecondaryIndexOnDemandThroughput? OnDemandThroughput { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects into the index only the table and index hash_key and sort_key attributes, INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that KEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key; must be defined as an attribute in the resource. Mutually exclusive with key_schema. Use key_schema instead.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>Sets the number of warm read and write units for this index. See below.</summary>
    [JsonPropertyName("warmThroughput")]
    public V1beta1TableSpecInitProviderGlobalSecondaryIndexWarmThroughput? WarmThroughput { get; set; }

    /// <summary>Number of write units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
}

/// <summary>Witness Region in a Multi-Region Strong Consistency deployment. Note This must be used alongside a single replica with consistency_mode set to STRONG. Other combinations will fail to provision. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderGlobalTableWitness
{
    /// <summary>Name of the AWS Region that serves as a witness for the MRSC global table.</summary>
    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }
}

/// <summary>This block contains the processing options for the CSV file being imported:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderImportTableInputFormatOptionsCsv
{
    /// <summary>The delimiter used for separating items in the CSV file being imported.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>List of the headers used to specify a common header for all source CSV files being imported.</summary>
    [JsonPropertyName("headerList")]
    public IList<string>? HeaderList { get; set; }
}

/// <summary>
/// Describe the format options for the data that was imported into the target table.
/// There is one value, csv.
/// See below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderImportTableInputFormatOptions
{
    /// <summary>This block contains the processing options for the CSV file being imported:</summary>
    [JsonPropertyName("csv")]
    public V1beta1TableSpecInitProviderImportTableInputFormatOptionsCsv? Csv { get; set; }
}

/// <summary>
/// Values for the S3 bucket the source file is imported from.
/// See below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderImportTableS3BucketSource
{
    /// <summary>The S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The account number of the S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucketOwner")]
    public string? BucketOwner { get; set; }

    /// <summary>The key prefix shared by all S3 Objects that are being imported.</summary>
    [JsonPropertyName("keyPrefix")]
    public string? KeyPrefix { get; set; }
}

/// <summary>Import Amazon S3 data into a new table. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderImportTable
{
    /// <summary>
    /// Type of compression to be used on the input coming from the imported table.
    /// Valid values are GZIP, ZSTD and NONE.
    /// </summary>
    [JsonPropertyName("inputCompressionType")]
    public string? InputCompressionType { get; set; }

    /// <summary>
    /// The format of the source data.
    /// Valid values are CSV, DYNAMODB_JSON, and ION.
    /// </summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>
    /// Describe the format options for the data that was imported into the target table.
    /// There is one value, csv.
    /// See below.
    /// </summary>
    [JsonPropertyName("inputFormatOptions")]
    public V1beta1TableSpecInitProviderImportTableInputFormatOptions? InputFormatOptions { get; set; }

    /// <summary>
    /// Values for the S3 bucket the source file is imported from.
    /// See below.
    /// </summary>
    [JsonPropertyName("s3BucketSource")]
    public V1beta1TableSpecInitProviderImportTableS3BucketSource? S3BucketSource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderLocalSecondaryIndex
{
    /// <summary>Name of the index</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects  into the index only the table and index hash_key and sort_key attributes ,  INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that thatKEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }
}

/// <summary>Sets the maximum number of read and write units for the specified on-demand table. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderOnDemandThroughput
{
    /// <summary>Maximum number of read request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxReadRequestUnits")]
    public double? MaxReadRequestUnits { get; set; }

    /// <summary>Maximum number of write request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxWriteRequestUnits")]
    public double? MaxWriteRequestUnits { get; set; }
}

/// <summary>Enable point-in-time recovery options. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderPointInTimeRecovery
{
    /// <summary>Whether to enable point-in-time recovery. It can take 10 minutes to enable for new tables. If the point_in_time_recovery block is not provided, this defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Number of preceding days for which continuous backups are taken and maintained. Default is 35.</summary>
    [JsonPropertyName("recoveryPeriodInDays")]
    public double? RecoveryPeriodInDays { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecInitProviderReplicaKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1TableSpecInitProviderReplicaKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecInitProviderReplicaKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1TableSpecInitProviderReplicaKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderReplicaKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TableSpecInitProviderReplicaKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TableSpecInitProviderReplicaKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderReplicaKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecInitProviderReplicaKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecInitProviderReplicaKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1TableSpecInitProviderReplicaKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecInitProviderReplicaKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1TableSpecInitProviderReplicaKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderReplicaKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TableSpecInitProviderReplicaKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TableSpecInitProviderReplicaKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderReplicaKmsKeyArnSelector
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
    public V1beta1TableSpecInitProviderReplicaKmsKeyArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderReplica
{
    /// <summary>Whether this global table will be using STRONG consistency mode or EVENTUAL consistency mode. Default value is EVENTUAL.</summary>
    [JsonPropertyName("consistencyMode")]
    public string? ConsistencyMode { get; set; }

    /// <summary>Whether deletion protection is enabled (true) or disabled (false) on the replica. Default is false.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// ARN of the CMK that should be used for the AWS KMS encryption.
    /// This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb.
    /// Note: This attribute will not be populated with the ARN of default keys.
    /// Note: Changing this value will recreate the replica.
    /// </summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1TableSpecInitProviderReplicaKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1TableSpecInitProviderReplicaKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Whether to enable Point In Time Recovery for the replica. Default is false.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public bool? PointInTimeRecovery { get; set; }

    /// <summary>
    /// Whether to propagate the global table&apos;s tags to a replica.
    /// Default is false.
    /// Changes to tags only move in one direction: from global (source) to replica.
    /// Tag drift on a replica will not trigger an update.
    /// Tag changes on the global table are propagated to replicas.
    /// Changing from true to false on a subsequent apply leaves replica tags as-is and no longer manages them.
    /// </summary>
    [JsonPropertyName("propagateTags")]
    public bool? PropagateTags { get; set; }

    /// <summary>Region name of the replica.</summary>
    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnSelector
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
    public V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Encryption at rest options. AWS DynamoDB tables are automatically encrypted at rest with an AWS-owned Customer Master Key if this argument isn&apos;t specified. Must be supplied for cross-region restores. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderServerSideEncryption
{
    /// <summary>Whether or not to enable encryption at rest using an AWS managed KMS customer master key (CMK). If enabled is false then server-side encryption is set to AWS-owned key (shown as DEFAULT in the AWS console). Potentially confusingly, if enabled is true and no kms_key_arn is specified then server-side encryption is set to the default KMS-managed key (shown as KMS in the AWS console). The AWS KMS documentation explains the difference between AWS-owned and KMS-managed keys.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ARN of the CMK that should be used for the AWS KMS encryption. This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb. Note: This attribute will not be populated with the ARN of default keys.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1TableSpecInitProviderServerSideEncryptionKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
}

/// <summary>Configuration block for TTL. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderTtl
{
    /// <summary>
    /// Name of the table attribute to store the TTL timestamp in.
    /// Required if enabled is true, must not be set otherwise.
    /// </summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>
    /// Whether TTL is enabled.
    /// Default value is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Sets the number of warm read and write units for the specified table. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecInitProviderWarmThroughput
{
    /// <summary>Number of read operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 12000 (default).</summary>
    [JsonPropertyName("readUnitsPerSecond")]
    public double? ReadUnitsPerSecond { get; set; }

    /// <summary>Number of write operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 4000 (default).</summary>
    [JsonPropertyName("writeUnitsPerSecond")]
    public double? WriteUnitsPerSecond { get; set; }
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
public partial class V1beta1TableSpecInitProvider
{
    /// <summary>Set of nested attribute definitions. Only required for hash_key and range_key attributes. See below.</summary>
    [JsonPropertyName("attribute")]
    public IList<V1beta1TableSpecInitProviderAttribute>? Attribute { get; set; }

    /// <summary>Controls how you are charged for read and write throughput and how you manage capacity. The valid values are PROVISIONED and PAY_PER_REQUEST. Defaults to PROVISIONED.</summary>
    [JsonPropertyName("billingMode")]
    public string? BillingMode { get; set; }

    /// <summary>Enables deletion protection for table. Defaults to false.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Describe a GSI for the table; subject to the normal limits on the number of GSIs, projected attributes, etc. See below.</summary>
    [JsonPropertyName("globalSecondaryIndex")]
    public IList<V1beta1TableSpecInitProviderGlobalSecondaryIndex>? GlobalSecondaryIndex { get; set; }

    /// <summary>Witness Region in a Multi-Region Strong Consistency deployment. Note This must be used alongside a single replica with consistency_mode set to STRONG. Other combinations will fail to provision. See below.</summary>
    [JsonPropertyName("globalTableWitness")]
    public V1beta1TableSpecInitProviderGlobalTableWitness? GlobalTableWitness { get; set; }

    /// <summary>Attribute to use as the hash (partition) key. Must also be defined as an attribute. See below.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Import Amazon S3 data into a new table. See below.</summary>
    [JsonPropertyName("importTable")]
    public V1beta1TableSpecInitProviderImportTable? ImportTable { get; set; }

    /// <summary>Describe an LSI on the table; these can only be allocated at creation so you cannot change this definition after you have created the resource. See below.</summary>
    [JsonPropertyName("localSecondaryIndex")]
    public IList<V1beta1TableSpecInitProviderLocalSecondaryIndex>? LocalSecondaryIndex { get; set; }

    /// <summary>Sets the maximum number of read and write units for the specified on-demand table. See below.</summary>
    [JsonPropertyName("onDemandThroughput")]
    public V1beta1TableSpecInitProviderOnDemandThroughput? OnDemandThroughput { get; set; }

    /// <summary>Enable point-in-time recovery options. See below.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public V1beta1TableSpecInitProviderPointInTimeRecovery? PointInTimeRecovery { get; set; }

    /// <summary>Attribute to use as the range (sort) key. Must also be defined as an attribute, see below.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>Configuration block(s) with DynamoDB Global Tables V2 (version 2019.11.21) replication configurations. See below.</summary>
    [JsonPropertyName("replica")]
    public IList<V1beta1TableSpecInitProviderReplica>? Replica { get; set; }

    /// <summary>Time of the point-in-time recovery point to restore.</summary>
    [JsonPropertyName("restoreDateTime")]
    public string? RestoreDateTime { get; set; }

    /// <summary>Name of the table to restore. Must match the name of an existing table.</summary>
    [JsonPropertyName("restoreSourceName")]
    public string? RestoreSourceName { get; set; }

    /// <summary>ARN of the source table to restore. Must be supplied for cross-region restores.</summary>
    [JsonPropertyName("restoreSourceTableArn")]
    public string? RestoreSourceTableArn { get; set; }

    /// <summary>If set, restores table to the most recent point-in-time recovery point.</summary>
    [JsonPropertyName("restoreToLatestTime")]
    public bool? RestoreToLatestTime { get; set; }

    /// <summary>Encryption at rest options. AWS DynamoDB tables are automatically encrypted at rest with an AWS-owned Customer Master Key if this argument isn&apos;t specified. Must be supplied for cross-region restores. See below.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public V1beta1TableSpecInitProviderServerSideEncryption? ServerSideEncryption { get; set; }

    /// <summary>Whether Streams are enabled.</summary>
    [JsonPropertyName("streamEnabled")]
    public bool? StreamEnabled { get; set; }

    /// <summary>
    /// When an item in the table is modified, StreamViewType determines what information is written to the table&apos;s stream.
    /// Valid values are KEYS_ONLY, NEW_IMAGE, OLD_IMAGE, NEW_AND_OLD_IMAGES.
    /// Only valid when stream_enabled is true.
    /// </summary>
    [JsonPropertyName("streamViewType")]
    public string? StreamViewType { get; set; }

    /// <summary>
    /// Storage class of the table.
    /// Valid values are STANDARD and STANDARD_INFREQUENT_ACCESS.
    /// Default value is STANDARD.
    /// </summary>
    [JsonPropertyName("tableClass")]
    public string? TableClass { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for TTL. See below.</summary>
    [JsonPropertyName("ttl")]
    public V1beta1TableSpecInitProviderTtl? Ttl { get; set; }

    /// <summary>Sets the number of warm read and write units for the specified table. See below.</summary>
    [JsonPropertyName("warmThroughput")]
    public V1beta1TableSpecInitProviderWarmThroughput? WarmThroughput { get; set; }

    /// <summary>Number of write units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TableSpecManagementPoliciesEnum>))]
public enum V1beta1TableSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>TableSpec defines the desired state of Table</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1TableSpecForProvider ForProvider { get; set; }

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
    public V1beta1TableSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TableSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TableSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TableSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderAttribute
{
    /// <summary>Name of the attribute</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Attribute type. Valid values are S (string), N (number), B (binary).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderGlobalSecondaryIndexKeySchema
{
    /// <summary>Name of the attribute; must be defined as an attribute in the resource.</summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>The type of key. Valid values are HASH (partition key) or RANGE (sort key). You can specify up to 4 attributes with key_type = &quot;HASH&quot; and up to 4 attributes with key_type = &quot;RANGE&quot;.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>Sets the maximum number of read and write units for the specified on-demand index. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderGlobalSecondaryIndexOnDemandThroughput
{
    /// <summary>Maximum number of read request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxReadRequestUnits")]
    public double? MaxReadRequestUnits { get; set; }

    /// <summary>Maximum number of write request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxWriteRequestUnits")]
    public double? MaxWriteRequestUnits { get; set; }
}

/// <summary>Sets the number of warm read and write units for this index. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderGlobalSecondaryIndexWarmThroughput
{
    /// <summary>Number of read operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 12000 (default).</summary>
    [JsonPropertyName("readUnitsPerSecond")]
    public double? ReadUnitsPerSecond { get; set; }

    /// <summary>Number of write operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 4000 (default).</summary>
    [JsonPropertyName("writeUnitsPerSecond")]
    public double? WriteUnitsPerSecond { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderGlobalSecondaryIndex
{
    /// <summary>Name of the hash key in the index; must be defined as an attribute in the resource. Mutually exclusive with key_schema. Use key_schema instead.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Configuration block(s) for the key schema. Mutually exclusive with hash_key and range_key. Required if hash_key is not specified. Supports multi-attribute keys for the Multi-Attribute Keys design pattern. See below.</summary>
    [JsonPropertyName("keySchema")]
    public IList<V1beta1TableStatusAtProviderGlobalSecondaryIndexKeySchema>? KeySchema { get; set; }

    /// <summary>Name of the index.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>Sets the maximum number of read and write units for the specified on-demand index. See below.</summary>
    [JsonPropertyName("onDemandThroughput")]
    public V1beta1TableStatusAtProviderGlobalSecondaryIndexOnDemandThroughput? OnDemandThroughput { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects into the index only the table and index hash_key and sort_key attributes, INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that KEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key; must be defined as an attribute in the resource. Mutually exclusive with key_schema. Use key_schema instead.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>Sets the number of warm read and write units for this index. See below.</summary>
    [JsonPropertyName("warmThroughput")]
    public V1beta1TableStatusAtProviderGlobalSecondaryIndexWarmThroughput? WarmThroughput { get; set; }

    /// <summary>Number of write units for this index. Must be set if billing_mode is set to PROVISIONED.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
}

/// <summary>Witness Region in a Multi-Region Strong Consistency deployment. Note This must be used alongside a single replica with consistency_mode set to STRONG. Other combinations will fail to provision. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderGlobalTableWitness
{
    /// <summary>Name of the AWS Region that serves as a witness for the MRSC global table.</summary>
    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }
}

/// <summary>This block contains the processing options for the CSV file being imported:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderImportTableInputFormatOptionsCsv
{
    /// <summary>The delimiter used for separating items in the CSV file being imported.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>List of the headers used to specify a common header for all source CSV files being imported.</summary>
    [JsonPropertyName("headerList")]
    public IList<string>? HeaderList { get; set; }
}

/// <summary>
/// Describe the format options for the data that was imported into the target table.
/// There is one value, csv.
/// See below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderImportTableInputFormatOptions
{
    /// <summary>This block contains the processing options for the CSV file being imported:</summary>
    [JsonPropertyName("csv")]
    public V1beta1TableStatusAtProviderImportTableInputFormatOptionsCsv? Csv { get; set; }
}

/// <summary>
/// Values for the S3 bucket the source file is imported from.
/// See below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderImportTableS3BucketSource
{
    /// <summary>The S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>The account number of the S3 bucket that is being imported from.</summary>
    [JsonPropertyName("bucketOwner")]
    public string? BucketOwner { get; set; }

    /// <summary>The key prefix shared by all S3 Objects that are being imported.</summary>
    [JsonPropertyName("keyPrefix")]
    public string? KeyPrefix { get; set; }
}

/// <summary>Import Amazon S3 data into a new table. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderImportTable
{
    /// <summary>
    /// Type of compression to be used on the input coming from the imported table.
    /// Valid values are GZIP, ZSTD and NONE.
    /// </summary>
    [JsonPropertyName("inputCompressionType")]
    public string? InputCompressionType { get; set; }

    /// <summary>
    /// The format of the source data.
    /// Valid values are CSV, DYNAMODB_JSON, and ION.
    /// </summary>
    [JsonPropertyName("inputFormat")]
    public string? InputFormat { get; set; }

    /// <summary>
    /// Describe the format options for the data that was imported into the target table.
    /// There is one value, csv.
    /// See below.
    /// </summary>
    [JsonPropertyName("inputFormatOptions")]
    public V1beta1TableStatusAtProviderImportTableInputFormatOptions? InputFormatOptions { get; set; }

    /// <summary>
    /// Values for the S3 bucket the source file is imported from.
    /// See below.
    /// </summary>
    [JsonPropertyName("s3BucketSource")]
    public V1beta1TableStatusAtProviderImportTableS3BucketSource? S3BucketSource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderLocalSecondaryIndex
{
    /// <summary>Name of the index</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Only required with INCLUDE as a projection type; a list of attributes to project into the index. These do not need to be defined as attributes on the table.</summary>
    [JsonPropertyName("nonKeyAttributes")]
    public IList<string>? NonKeyAttributes { get; set; }

    /// <summary>One of ALL, INCLUDE or KEYS_ONLY where ALL projects every attribute into the index, KEYS_ONLY projects  into the index only the table and index hash_key and sort_key attributes ,  INCLUDE projects into the index all of the attributes that are defined in non_key_attributes in addition to the attributes that thatKEYS_ONLY project.</summary>
    [JsonPropertyName("projectionType")]
    public string? ProjectionType { get; set; }

    /// <summary>Name of the range key.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }
}

/// <summary>Sets the maximum number of read and write units for the specified on-demand table. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderOnDemandThroughput
{
    /// <summary>Maximum number of read request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxReadRequestUnits")]
    public double? MaxReadRequestUnits { get; set; }

    /// <summary>Maximum number of write request units for the specified table. To specify set the value greater than or equal to 1. To remove set the value to -1.</summary>
    [JsonPropertyName("maxWriteRequestUnits")]
    public double? MaxWriteRequestUnits { get; set; }
}

/// <summary>Enable point-in-time recovery options. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderPointInTimeRecovery
{
    /// <summary>Whether to enable point-in-time recovery. It can take 10 minutes to enable for new tables. If the point_in_time_recovery block is not provided, this defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Number of preceding days for which continuous backups are taken and maintained. Default is 35.</summary>
    [JsonPropertyName("recoveryPeriodInDays")]
    public double? RecoveryPeriodInDays { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderReplica
{
    /// <summary>ARN of the replica</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Whether this global table will be using STRONG consistency mode or EVENTUAL consistency mode. Default value is EVENTUAL.</summary>
    [JsonPropertyName("consistencyMode")]
    public string? ConsistencyMode { get; set; }

    /// <summary>Whether deletion protection is enabled (true) or disabled (false) on the replica. Default is false.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// ARN of the CMK that should be used for the AWS KMS encryption.
    /// This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb.
    /// Note: This attribute will not be populated with the ARN of default keys.
    /// Note: Changing this value will recreate the replica.
    /// </summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Whether to enable Point In Time Recovery for the replica. Default is false.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public bool? PointInTimeRecovery { get; set; }

    /// <summary>
    /// Whether to propagate the global table&apos;s tags to a replica.
    /// Default is false.
    /// Changes to tags only move in one direction: from global (source) to replica.
    /// Tag drift on a replica will not trigger an update.
    /// Tag changes on the global table are propagated to replicas.
    /// Changing from true to false on a subsequent apply leaves replica tags as-is and no longer manages them.
    /// </summary>
    [JsonPropertyName("propagateTags")]
    public bool? PropagateTags { get; set; }

    /// <summary>Region name of the replica.</summary>
    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }

    /// <summary>ARN of the Table Stream. Only available when stream_enabled = true</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }

    /// <summary>Timestamp, in ISO 8601 format, for this stream. Note that this timestamp is not a unique identifier for the stream on its own. However, the combination of AWS customer ID, table name and this field is guaranteed to be unique. It can be used for creating CloudWatch Alarms. Only available when stream_enabled = true.</summary>
    [JsonPropertyName("streamLabel")]
    public string? StreamLabel { get; set; }
}

/// <summary>Encryption at rest options. AWS DynamoDB tables are automatically encrypted at rest with an AWS-owned Customer Master Key if this argument isn&apos;t specified. Must be supplied for cross-region restores. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderServerSideEncryption
{
    /// <summary>Whether or not to enable encryption at rest using an AWS managed KMS customer master key (CMK). If enabled is false then server-side encryption is set to AWS-owned key (shown as DEFAULT in the AWS console). Potentially confusingly, if enabled is true and no kms_key_arn is specified then server-side encryption is set to the default KMS-managed key (shown as KMS in the AWS console). The AWS KMS documentation explains the difference between AWS-owned and KMS-managed keys.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ARN of the CMK that should be used for the AWS KMS encryption. This argument should only be used if the key is different from the default KMS-managed DynamoDB key, alias/aws/dynamodb. Note: This attribute will not be populated with the ARN of default keys.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

/// <summary>Configuration block for TTL. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderTtl
{
    /// <summary>
    /// Name of the table attribute to store the TTL timestamp in.
    /// Required if enabled is true, must not be set otherwise.
    /// </summary>
    [JsonPropertyName("attributeName")]
    public string? AttributeName { get; set; }

    /// <summary>
    /// Whether TTL is enabled.
    /// Default value is false.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Sets the number of warm read and write units for the specified table. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProviderWarmThroughput
{
    /// <summary>Number of read operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 12000 (default).</summary>
    [JsonPropertyName("readUnitsPerSecond")]
    public double? ReadUnitsPerSecond { get; set; }

    /// <summary>Number of write operations a table or index can instantaneously support. For the base table, decreasing this value will force a new resource. For a global secondary index, this value can be increased or decreased without recreation. Minimum value of 4000 (default).</summary>
    [JsonPropertyName("writeUnitsPerSecond")]
    public double? WriteUnitsPerSecond { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusAtProvider
{
    /// <summary>ARN of the table</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Set of nested attribute definitions. Only required for hash_key and range_key attributes. See below.</summary>
    [JsonPropertyName("attribute")]
    public IList<V1beta1TableStatusAtProviderAttribute>? Attribute { get; set; }

    /// <summary>Controls how you are charged for read and write throughput and how you manage capacity. The valid values are PROVISIONED and PAY_PER_REQUEST. Defaults to PROVISIONED.</summary>
    [JsonPropertyName("billingMode")]
    public string? BillingMode { get; set; }

    /// <summary>Enables deletion protection for table. Defaults to false.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary>Describe a GSI for the table; subject to the normal limits on the number of GSIs, projected attributes, etc. See below.</summary>
    [JsonPropertyName("globalSecondaryIndex")]
    public IList<V1beta1TableStatusAtProviderGlobalSecondaryIndex>? GlobalSecondaryIndex { get; set; }

    /// <summary>Witness Region in a Multi-Region Strong Consistency deployment. Note This must be used alongside a single replica with consistency_mode set to STRONG. Other combinations will fail to provision. See below.</summary>
    [JsonPropertyName("globalTableWitness")]
    public V1beta1TableStatusAtProviderGlobalTableWitness? GlobalTableWitness { get; set; }

    /// <summary>Attribute to use as the hash (partition) key. Must also be defined as an attribute. See below.</summary>
    [JsonPropertyName("hashKey")]
    public string? HashKey { get; set; }

    /// <summary>Name of the table</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Import Amazon S3 data into a new table. See below.</summary>
    [JsonPropertyName("importTable")]
    public V1beta1TableStatusAtProviderImportTable? ImportTable { get; set; }

    /// <summary>Describe an LSI on the table; these can only be allocated at creation so you cannot change this definition after you have created the resource. See below.</summary>
    [JsonPropertyName("localSecondaryIndex")]
    public IList<V1beta1TableStatusAtProviderLocalSecondaryIndex>? LocalSecondaryIndex { get; set; }

    /// <summary>Sets the maximum number of read and write units for the specified on-demand table. See below.</summary>
    [JsonPropertyName("onDemandThroughput")]
    public V1beta1TableStatusAtProviderOnDemandThroughput? OnDemandThroughput { get; set; }

    /// <summary>Enable point-in-time recovery options. See below.</summary>
    [JsonPropertyName("pointInTimeRecovery")]
    public V1beta1TableStatusAtProviderPointInTimeRecovery? PointInTimeRecovery { get; set; }

    /// <summary>Attribute to use as the range (sort) key. Must also be defined as an attribute, see below.</summary>
    [JsonPropertyName("rangeKey")]
    public string? RangeKey { get; set; }

    /// <summary>Number of read units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("readCapacity")]
    public double? ReadCapacity { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block(s) with DynamoDB Global Tables V2 (version 2019.11.21) replication configurations. See below.</summary>
    [JsonPropertyName("replica")]
    public IList<V1beta1TableStatusAtProviderReplica>? Replica { get; set; }

    /// <summary>Time of the point-in-time recovery point to restore.</summary>
    [JsonPropertyName("restoreDateTime")]
    public string? RestoreDateTime { get; set; }

    /// <summary>Name of the table to restore. Must match the name of an existing table.</summary>
    [JsonPropertyName("restoreSourceName")]
    public string? RestoreSourceName { get; set; }

    /// <summary>ARN of the source table to restore. Must be supplied for cross-region restores.</summary>
    [JsonPropertyName("restoreSourceTableArn")]
    public string? RestoreSourceTableArn { get; set; }

    /// <summary>If set, restores table to the most recent point-in-time recovery point.</summary>
    [JsonPropertyName("restoreToLatestTime")]
    public bool? RestoreToLatestTime { get; set; }

    /// <summary>Encryption at rest options. AWS DynamoDB tables are automatically encrypted at rest with an AWS-owned Customer Master Key if this argument isn&apos;t specified. Must be supplied for cross-region restores. See below.</summary>
    [JsonPropertyName("serverSideEncryption")]
    public V1beta1TableStatusAtProviderServerSideEncryption? ServerSideEncryption { get; set; }

    /// <summary>ARN of the Table Stream. Only available when stream_enabled = true</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }

    /// <summary>Whether Streams are enabled.</summary>
    [JsonPropertyName("streamEnabled")]
    public bool? StreamEnabled { get; set; }

    /// <summary>Timestamp, in ISO 8601 format, for this stream. Note that this timestamp is not a unique identifier for the stream on its own. However, the combination of AWS customer ID, table name and this field is guaranteed to be unique. It can be used for creating CloudWatch Alarms. Only available when stream_enabled = true.</summary>
    [JsonPropertyName("streamLabel")]
    public string? StreamLabel { get; set; }

    /// <summary>
    /// When an item in the table is modified, StreamViewType determines what information is written to the table&apos;s stream.
    /// Valid values are KEYS_ONLY, NEW_IMAGE, OLD_IMAGE, NEW_AND_OLD_IMAGES.
    /// Only valid when stream_enabled is true.
    /// </summary>
    [JsonPropertyName("streamViewType")]
    public string? StreamViewType { get; set; }

    /// <summary>
    /// Storage class of the table.
    /// Valid values are STANDARD and STANDARD_INFREQUENT_ACCESS.
    /// Default value is STANDARD.
    /// </summary>
    [JsonPropertyName("tableClass")]
    public string? TableClass { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block for TTL. See below.</summary>
    [JsonPropertyName("ttl")]
    public V1beta1TableStatusAtProviderTtl? Ttl { get; set; }

    /// <summary>Sets the number of warm read and write units for the specified table. See below.</summary>
    [JsonPropertyName("warmThroughput")]
    public V1beta1TableStatusAtProviderWarmThroughput? WarmThroughput { get; set; }

    /// <summary>Number of write units for this table. If the billing_mode is PROVISIONED, this field is required.</summary>
    [JsonPropertyName("writeCapacity")]
    public double? WriteCapacity { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatusConditions
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

/// <summary>TableStatus defines the observed state of Table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TableStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1TableStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TableStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Table is the Schema for the Tables API. Provides a DynamoDB table resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Table : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TableSpec>, IStatus<V1beta1TableStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Table";
    public const string KubeGroup = "dynamodb.aws.m.upbound.io";
    public const string KubePluralName = "tables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dynamodb.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Table";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TableSpec defines the desired state of Table</summary>
    [JsonPropertyName("spec")]
    public required V1beta1TableSpec Spec { get; set; }

    /// <summary>TableStatus defines the observed state of Table.</summary>
    [JsonPropertyName("status")]
    public V1beta1TableStatus? Status { get; set; }
}