#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3.services.k8s.aws;
/// <summary>Bucket is the Schema for the Buckets API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BucketList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Bucket>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BucketList";
    public const string KubeGroup = "s3.services.k8s.aws";
    public const string KubePluralName = "buckets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "s3.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BucketList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Bucket objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Bucket> Items { get; set; }
}

/// <summary>Container for setting the transfer acceleration state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecAccelerate
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>A container of a key value name pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecAnalyticsFilterAndTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A conjunction (logical AND) of predicates, which is used in evaluating a
/// metrics filter. The operator must have at least two predicates in any combination,
/// and an object must match all of the predicates for the filter to apply.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecAnalyticsFilterAnd
{
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1BucketSpecAnalyticsFilterAndTags>? Tags { get; set; }
}

/// <summary>A container of a key value name pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecAnalyticsFilterTag
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The filter used to describe a set of objects for analyses. A filter must
/// have exactly one prefix, one tag, or one conjunction (AnalyticsAndOperator).
/// If no filter is provided, all objects will be considered in any analysis.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecAnalyticsFilter
{
    /// <summary>
    /// A conjunction (logical AND) of predicates, which is used in evaluating a
    /// metrics filter. The operator must have at least two predicates in any combination,
    /// and an object must match all of the predicates for the filter to apply.
    /// </summary>
    [JsonPropertyName("and")]
    public V1alpha1BucketSpecAnalyticsFilterAnd? And { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>A container of a key value name pair.</summary>
    [JsonPropertyName("tag")]
    public V1alpha1BucketSpecAnalyticsFilterTag? Tag { get; set; }
}

/// <summary>Contains information about where to publish the analytics results.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecAnalyticsStorageClassAnalysisDataExportDestinationS3BucketDestination
{
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("bucketAccountID")]
    public string? BucketAccountID { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Where to publish the analytics results.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecAnalyticsStorageClassAnalysisDataExportDestination
{
    /// <summary>Contains information about where to publish the analytics results.</summary>
    [JsonPropertyName("s3BucketDestination")]
    public V1alpha1BucketSpecAnalyticsStorageClassAnalysisDataExportDestinationS3BucketDestination? S3BucketDestination { get; set; }
}

/// <summary>
/// Container for data related to the storage class analysis for an Amazon S3
/// bucket for export.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecAnalyticsStorageClassAnalysisDataExport
{
    /// <summary>Where to publish the analytics results.</summary>
    [JsonPropertyName("destination")]
    public V1alpha1BucketSpecAnalyticsStorageClassAnalysisDataExportDestination? Destination { get; set; }

    [JsonPropertyName("outputSchemaVersion")]
    public string? OutputSchemaVersion { get; set; }
}

/// <summary>
/// Specifies data related to access patterns to be collected and made available
/// to analyze the tradeoffs between different storage classes for an Amazon
/// S3 bucket.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecAnalyticsStorageClassAnalysis
{
    /// <summary>
    /// Container for data related to the storage class analysis for an Amazon S3
    /// bucket for export.
    /// </summary>
    [JsonPropertyName("dataExport")]
    public V1alpha1BucketSpecAnalyticsStorageClassAnalysisDataExport? DataExport { get; set; }
}

/// <summary>
/// Specifies the configuration and any analyses for the analytics filter of
/// an Amazon S3 bucket.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecAnalytics
{
    /// <summary>
    /// The filter used to describe a set of objects for analyses. A filter must
    /// have exactly one prefix, one tag, or one conjunction (AnalyticsAndOperator).
    /// If no filter is provided, all objects will be considered in any analysis.
    /// </summary>
    [JsonPropertyName("filter")]
    public V1alpha1BucketSpecAnalyticsFilter? Filter { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Specifies data related to access patterns to be collected and made available
    /// to analyze the tradeoffs between different storage classes for an Amazon
    /// S3 bucket.
    /// </summary>
    [JsonPropertyName("storageClassAnalysis")]
    public V1alpha1BucketSpecAnalyticsStorageClassAnalysis? StorageClassAnalysis { get; set; }
}

/// <summary>Specifies a cross-origin access rule for an Amazon S3 bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecCorsCorsRules
{
    [JsonPropertyName("allowedHeaders")]
    public IList<string>? AllowedHeaders { get; set; }

    [JsonPropertyName("allowedMethods")]
    public IList<string>? AllowedMethods { get; set; }

    [JsonPropertyName("allowedOrigins")]
    public IList<string>? AllowedOrigins { get; set; }

    [JsonPropertyName("exposeHeaders")]
    public IList<string>? ExposeHeaders { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("maxAgeSeconds")]
    public long? MaxAgeSeconds { get; set; }
}

/// <summary>
/// Describes the cross-origin access configuration for objects in an Amazon
/// S3 bucket. For more information, see Enabling Cross-Origin Resource Sharing
/// (https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html) in the Amazon
/// S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecCors
{
    [JsonPropertyName("corsRules")]
    public IList<V1alpha1BucketSpecCorsCorsRules>? CorsRules { get; set; }
}

/// <summary>
/// Specifies the information about the bucket that will be created. For more
/// information about directory buckets, see Directory buckets (https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html)
/// in the Amazon S3 User Guide.
/// 
/// This functionality is only supported by directory buckets.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecCreateBucketConfigurationBucket
{
    [JsonPropertyName("dataRedundancy")]
    public string? DataRedundancy { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies the location where the bucket will be created.
/// 
/// For directory buckets, the location type is Availability Zone or Local Zone.
/// For more information about directory buckets, see Working with directory
/// buckets (https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html)
/// in the Amazon S3 User Guide.
/// 
/// This functionality is only supported by directory buckets.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecCreateBucketConfigurationLocation
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The configuration information for the bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecCreateBucketConfiguration
{
    /// <summary>
    /// Specifies the information about the bucket that will be created. For more
    /// information about directory buckets, see Directory buckets (https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html)
    /// in the Amazon S3 User Guide.
    /// 
    /// This functionality is only supported by directory buckets.
    /// </summary>
    [JsonPropertyName("bucket")]
    public V1alpha1BucketSpecCreateBucketConfigurationBucket? Bucket { get; set; }

    /// <summary>
    /// Specifies the location where the bucket will be created.
    /// 
    /// For directory buckets, the location type is Availability Zone or Local Zone.
    /// For more information about directory buckets, see Working with directory
    /// buckets (https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html)
    /// in the Amazon S3 User Guide.
    /// 
    /// This functionality is only supported by directory buckets.
    /// </summary>
    [JsonPropertyName("location")]
    public V1alpha1BucketSpecCreateBucketConfigurationLocation? Location { get; set; }

    [JsonPropertyName("locationConstraint")]
    public string? LocationConstraint { get; set; }
}

/// <summary>
/// Describes the default server-side encryption to apply to new objects in the
/// bucket. If a PUT Object request doesn&apos;t specify any server-side encryption,
/// this default encryption will be applied. For more information, see PutBucketEncryption
/// (https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTencryption.html).
/// 
///    * General purpose buckets - If you don&apos;t specify a customer managed key
///    at configuration, Amazon S3 automatically creates an Amazon Web Services
///    KMS key (aws/s3) in your Amazon Web Services account the first time that
///    you add an object encrypted with SSE-KMS to a bucket. By default, Amazon
///    S3 uses this KMS key for SSE-KMS.
/// 
///    * Directory buckets - Your SSE-KMS configuration can only support 1 customer
///    managed key (https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk)
///    per directory bucket&apos;s lifetime. The Amazon Web Services managed key (https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk)
///    (aws/s3) isn&apos;t supported.
/// 
///    * Directory buckets - For directory buckets, there are only two supported
///    options for server-side encryption: SSE-S3 and SSE-KMS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecEncryptionRulesApplyServerSideEncryptionByDefault
{
    [JsonPropertyName("kmsMasterKeyID")]
    public string? KmsMasterKeyID { get; set; }

    [JsonPropertyName("sseAlgorithm")]
    public string? SseAlgorithm { get; set; }
}

/// <summary>
/// Specifies the default server-side encryption configuration.
/// 
///   - General purpose buckets - If you&apos;re specifying a customer managed KMS
///     key, we recommend using a fully qualified KMS key ARN. If you use a KMS
///     key alias instead, then KMS resolves the key within the requester’s
///     account. This behavior can result in data that&apos;s encrypted with a KMS
///     key that belongs to the requester, and not the bucket owner.
/// 
///   - Directory buckets - When you specify an KMS customer managed key (https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk)
///     for encryption in your directory bucket, only use the key ID or key ARN.
///     The key alias format of the KMS key isn&apos;t supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecEncryptionRules
{
    /// <summary>
    /// Describes the default server-side encryption to apply to new objects in the
    /// bucket. If a PUT Object request doesn&apos;t specify any server-side encryption,
    /// this default encryption will be applied. For more information, see PutBucketEncryption
    /// (https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTencryption.html).
    /// 
    ///    * General purpose buckets - If you don&apos;t specify a customer managed key
    ///    at configuration, Amazon S3 automatically creates an Amazon Web Services
    ///    KMS key (aws/s3) in your Amazon Web Services account the first time that
    ///    you add an object encrypted with SSE-KMS to a bucket. By default, Amazon
    ///    S3 uses this KMS key for SSE-KMS.
    /// 
    ///    * Directory buckets - Your SSE-KMS configuration can only support 1 customer
    ///    managed key (https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk)
    ///    per directory bucket&apos;s lifetime. The Amazon Web Services managed key (https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk)
    ///    (aws/s3) isn&apos;t supported.
    /// 
    ///    * Directory buckets - For directory buckets, there are only two supported
    ///    options for server-side encryption: SSE-S3 and SSE-KMS.
    /// </summary>
    [JsonPropertyName("applyServerSideEncryptionByDefault")]
    public V1alpha1BucketSpecEncryptionRulesApplyServerSideEncryptionByDefault? ApplyServerSideEncryptionByDefault { get; set; }

    [JsonPropertyName("bucketKeyEnabled")]
    public bool? BucketKeyEnabled { get; set; }
}

/// <summary>Specifies the default server-side-encryption configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecEncryption
{
    [JsonPropertyName("rules")]
    public IList<V1alpha1BucketSpecEncryptionRules>? Rules { get; set; }
}

/// <summary>A container of a key value name pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecIntelligentTieringFilterAndTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A container for specifying S3 Intelligent-Tiering filters. The filters determine
/// the subset of objects to which the rule applies.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecIntelligentTieringFilterAnd
{
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1BucketSpecIntelligentTieringFilterAndTags>? Tags { get; set; }
}

/// <summary>A container of a key value name pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecIntelligentTieringFilterTag
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The Filter is used to identify objects that the S3 Intelligent-Tiering configuration
/// applies to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecIntelligentTieringFilter
{
    /// <summary>
    /// A container for specifying S3 Intelligent-Tiering filters. The filters determine
    /// the subset of objects to which the rule applies.
    /// </summary>
    [JsonPropertyName("and")]
    public V1alpha1BucketSpecIntelligentTieringFilterAnd? And { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>A container of a key value name pair.</summary>
    [JsonPropertyName("tag")]
    public V1alpha1BucketSpecIntelligentTieringFilterTag? Tag { get; set; }
}

/// <summary>
/// The S3 Intelligent-Tiering storage class is designed to optimize storage
/// costs by automatically moving data to the most cost-effective storage access
/// tier, without additional operational overhead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecIntelligentTieringTierings
{
    [JsonPropertyName("accessTier")]
    public string? AccessTier { get; set; }

    [JsonPropertyName("days")]
    public long? Days { get; set; }
}

/// <summary>
/// Specifies the S3 Intelligent-Tiering configuration for an Amazon S3 bucket.
/// 
/// For information about the S3 Intelligent-Tiering storage class, see Storage
/// class for automatically optimizing frequently and infrequently accessed objects
/// (https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html#sc-dynamic-data-access).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecIntelligentTiering
{
    /// <summary>
    /// The Filter is used to identify objects that the S3 Intelligent-Tiering configuration
    /// applies to.
    /// </summary>
    [JsonPropertyName("filter")]
    public V1alpha1BucketSpecIntelligentTieringFilter? Filter { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("tierings")]
    public IList<V1alpha1BucketSpecIntelligentTieringTierings>? Tierings { get; set; }
}

/// <summary>Specifies the use of SSE-KMS to encrypt delivered inventory reports.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecInventoryDestinationS3BucketDestinationEncryptionSseKMS
{
    [JsonPropertyName("keyID")]
    public string? KeyID { get; set; }
}

/// <summary>
/// Contains the type of server-side encryption used to encrypt the S3 Inventory
/// results.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecInventoryDestinationS3BucketDestinationEncryption
{
    /// <summary>Specifies the use of SSE-KMS to encrypt delivered inventory reports.</summary>
    [JsonPropertyName("sseKMS")]
    public V1alpha1BucketSpecInventoryDestinationS3BucketDestinationEncryptionSseKMS? SseKMS { get; set; }
}

/// <summary>
/// Contains the bucket name, file format, bucket owner (optional), and prefix
/// (optional) where S3 Inventory results are published.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecInventoryDestinationS3BucketDestination
{
    [JsonPropertyName("accountID")]
    public string? AccountID { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Contains the type of server-side encryption used to encrypt the S3 Inventory
    /// results.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V1alpha1BucketSpecInventoryDestinationS3BucketDestinationEncryption? Encryption { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Specifies the S3 Inventory configuration for an Amazon S3 bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecInventoryDestination
{
    /// <summary>
    /// Contains the bucket name, file format, bucket owner (optional), and prefix
    /// (optional) where S3 Inventory results are published.
    /// </summary>
    [JsonPropertyName("s3BucketDestination")]
    public V1alpha1BucketSpecInventoryDestinationS3BucketDestination? S3BucketDestination { get; set; }
}

/// <summary>
/// Specifies an S3 Inventory filter. The inventory only includes objects that
/// meet the filter&apos;s criteria.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecInventoryFilter
{
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Specifies the schedule for generating S3 Inventory results.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecInventorySchedule
{
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }
}

/// <summary>
/// Specifies the S3 Inventory configuration for an Amazon S3 bucket. For more
/// information, see GET Bucket inventory (https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketGETInventoryConfig.html)
/// in the Amazon S3 API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecInventory
{
    /// <summary>Specifies the S3 Inventory configuration for an Amazon S3 bucket.</summary>
    [JsonPropertyName("destination")]
    public V1alpha1BucketSpecInventoryDestination? Destination { get; set; }

    /// <summary>
    /// Specifies an S3 Inventory filter. The inventory only includes objects that
    /// meet the filter&apos;s criteria.
    /// </summary>
    [JsonPropertyName("filter")]
    public V1alpha1BucketSpecInventoryFilter? Filter { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("includedObjectVersions")]
    public string? IncludedObjectVersions { get; set; }

    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }

    [JsonPropertyName("optionalFields")]
    public IList<string>? OptionalFields { get; set; }

    /// <summary>Specifies the schedule for generating S3 Inventory results.</summary>
    [JsonPropertyName("schedule")]
    public V1alpha1BucketSpecInventorySchedule? Schedule { get; set; }
}

/// <summary>
/// Specifies the days since the initiation of an incomplete multipart upload
/// that Amazon S3 will wait before permanently removing all parts of the upload.
/// For more information, see Aborting Incomplete Multipart Uploads Using a Bucket
/// Lifecycle Configuration (https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html#mpu-abort-incomplete-mpu-lifecycle-config)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLifecycleRulesAbortIncompleteMultipartUpload
{
    [JsonPropertyName("daysAfterInitiation")]
    public long? DaysAfterInitiation { get; set; }
}

/// <summary>
/// Container for the expiration for the lifecycle of the object.
/// 
/// For more information see, Managing your storage lifecycle (https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lifecycle-mgmt.html)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLifecycleRulesExpiration
{
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }

    [JsonPropertyName("days")]
    public long? Days { get; set; }

    [JsonPropertyName("expiredObjectDeleteMarker")]
    public bool? ExpiredObjectDeleteMarker { get; set; }
}

/// <summary>A container of a key value name pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLifecycleRulesFilterAndTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// This is used in a Lifecycle Rule Filter to apply a logical AND to two or
/// more predicates. The Lifecycle Rule will apply to any object matching all
/// of the predicates configured inside the And operator.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLifecycleRulesFilterAnd
{
    [JsonPropertyName("objectSizeGreaterThan")]
    public long? ObjectSizeGreaterThan { get; set; }

    [JsonPropertyName("objectSizeLessThan")]
    public long? ObjectSizeLessThan { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1BucketSpecLifecycleRulesFilterAndTags>? Tags { get; set; }
}

/// <summary>A container of a key value name pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLifecycleRulesFilterTag
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The Filter is used to identify objects that a Lifecycle Rule applies to.
/// A Filter can have exactly one of Prefix, Tag, ObjectSizeGreaterThan, ObjectSizeLessThan,
/// or And specified. If the Filter element is left empty, the Lifecycle Rule
/// applies to all objects in the bucket.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLifecycleRulesFilter
{
    /// <summary>
    /// This is used in a Lifecycle Rule Filter to apply a logical AND to two or
    /// more predicates. The Lifecycle Rule will apply to any object matching all
    /// of the predicates configured inside the And operator.
    /// </summary>
    [JsonPropertyName("and")]
    public V1alpha1BucketSpecLifecycleRulesFilterAnd? And { get; set; }

    [JsonPropertyName("objectSizeGreaterThan")]
    public long? ObjectSizeGreaterThan { get; set; }

    [JsonPropertyName("objectSizeLessThan")]
    public long? ObjectSizeLessThan { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>A container of a key value name pair.</summary>
    [JsonPropertyName("tag")]
    public V1alpha1BucketSpecLifecycleRulesFilterTag? Tag { get; set; }
}

/// <summary>
/// Specifies when noncurrent object versions expire. Upon expiration, Amazon
/// S3 permanently deletes the noncurrent object versions. You set this lifecycle
/// configuration action on a bucket that has versioning enabled (or suspended)
/// to request that Amazon S3 delete noncurrent object versions at a specific
/// period in the object&apos;s lifetime.
/// 
/// This parameter applies to general purpose buckets only. It is not supported
/// for directory bucket lifecycle configurations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLifecycleRulesNoncurrentVersionExpiration
{
    [JsonPropertyName("newerNoncurrentVersions")]
    public long? NewerNoncurrentVersions { get; set; }

    [JsonPropertyName("noncurrentDays")]
    public long? NoncurrentDays { get; set; }
}

/// <summary>
/// Container for the transition rule that describes when noncurrent objects
/// transition to the STANDARD_IA, ONEZONE_IA, INTELLIGENT_TIERING, GLACIER_IR,
/// GLACIER, or DEEP_ARCHIVE storage class. If your bucket is versioning-enabled
/// (or versioning is suspended), you can set this action to request that Amazon
/// S3 transition noncurrent object versions to the STANDARD_IA, ONEZONE_IA,
/// INTELLIGENT_TIERING, GLACIER_IR, GLACIER, or DEEP_ARCHIVE storage class at
/// a specific period in the object&apos;s lifetime.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLifecycleRulesNoncurrentVersionTransitions
{
    [JsonPropertyName("newerNoncurrentVersions")]
    public long? NewerNoncurrentVersions { get; set; }

    [JsonPropertyName("noncurrentDays")]
    public long? NoncurrentDays { get; set; }

    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>
/// Specifies when an object transitions to a specified storage class. For more
/// information about Amazon S3 lifecycle configuration rules, see Transitioning
/// Objects Using Amazon S3 Lifecycle (https://docs.aws.amazon.com/AmazonS3/latest/dev/lifecycle-transition-general-considerations.html)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLifecycleRulesTransitions
{
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }

    [JsonPropertyName("days")]
    public long? Days { get; set; }

    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>
/// A lifecycle rule for individual objects in an Amazon S3 bucket.
/// 
/// For more information see, Managing your storage lifecycle (https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lifecycle-mgmt.html)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLifecycleRules
{
    /// <summary>
    /// Specifies the days since the initiation of an incomplete multipart upload
    /// that Amazon S3 will wait before permanently removing all parts of the upload.
    /// For more information, see Aborting Incomplete Multipart Uploads Using a Bucket
    /// Lifecycle Configuration (https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html#mpu-abort-incomplete-mpu-lifecycle-config)
    /// in the Amazon S3 User Guide.
    /// </summary>
    [JsonPropertyName("abortIncompleteMultipartUpload")]
    public V1alpha1BucketSpecLifecycleRulesAbortIncompleteMultipartUpload? AbortIncompleteMultipartUpload { get; set; }

    /// <summary>
    /// Container for the expiration for the lifecycle of the object.
    /// 
    /// For more information see, Managing your storage lifecycle (https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lifecycle-mgmt.html)
    /// in the Amazon S3 User Guide.
    /// </summary>
    [JsonPropertyName("expiration")]
    public V1alpha1BucketSpecLifecycleRulesExpiration? Expiration { get; set; }

    /// <summary>
    /// The Filter is used to identify objects that a Lifecycle Rule applies to.
    /// A Filter can have exactly one of Prefix, Tag, ObjectSizeGreaterThan, ObjectSizeLessThan,
    /// or And specified. If the Filter element is left empty, the Lifecycle Rule
    /// applies to all objects in the bucket.
    /// </summary>
    [JsonPropertyName("filter")]
    public V1alpha1BucketSpecLifecycleRulesFilter? Filter { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Specifies when noncurrent object versions expire. Upon expiration, Amazon
    /// S3 permanently deletes the noncurrent object versions. You set this lifecycle
    /// configuration action on a bucket that has versioning enabled (or suspended)
    /// to request that Amazon S3 delete noncurrent object versions at a specific
    /// period in the object&apos;s lifetime.
    /// 
    /// This parameter applies to general purpose buckets only. It is not supported
    /// for directory bucket lifecycle configurations.
    /// </summary>
    [JsonPropertyName("noncurrentVersionExpiration")]
    public V1alpha1BucketSpecLifecycleRulesNoncurrentVersionExpiration? NoncurrentVersionExpiration { get; set; }

    [JsonPropertyName("noncurrentVersionTransitions")]
    public IList<V1alpha1BucketSpecLifecycleRulesNoncurrentVersionTransitions>? NoncurrentVersionTransitions { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("transitions")]
    public IList<V1alpha1BucketSpecLifecycleRulesTransitions>? Transitions { get; set; }
}

/// <summary>Container for lifecycle rules. You can add as many as 1,000 rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLifecycle
{
    [JsonPropertyName("rules")]
    public IList<V1alpha1BucketSpecLifecycleRules>? Rules { get; set; }
}

/// <summary>Container for the person being granted permissions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLoggingLoggingEnabledTargetGrantsGrantee
{
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("emailAddress")]
    public string? EmailAddress { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("uRI")]
    public string? URI { get; set; }
}

/// <summary>
/// Container for granting information.
/// 
/// Buckets that use the bucket owner enforced setting for Object Ownership don&apos;t
/// support target grants. For more information, see Permissions server access
/// log delivery (https://docs.aws.amazon.com/AmazonS3/latest/userguide/enable-server-access-logging.html#grant-log-delivery-permissions-general)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLoggingLoggingEnabledTargetGrants
{
    /// <summary>Container for the person being granted permissions.</summary>
    [JsonPropertyName("grantee")]
    public V1alpha1BucketSpecLoggingLoggingEnabledTargetGrantsGrantee? Grantee { get; set; }

    [JsonPropertyName("permission")]
    public string? Permission { get; set; }
}

/// <summary>
/// Describes where logs are stored and the prefix that Amazon S3 assigns to
/// all log object keys for a bucket. For more information, see PUT Bucket logging
/// (https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTlogging.html)
/// in the Amazon S3 API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLoggingLoggingEnabled
{
    [JsonPropertyName("targetBucket")]
    public string? TargetBucket { get; set; }

    [JsonPropertyName("targetGrants")]
    public IList<V1alpha1BucketSpecLoggingLoggingEnabledTargetGrants>? TargetGrants { get; set; }

    [JsonPropertyName("targetPrefix")]
    public string? TargetPrefix { get; set; }
}

/// <summary>Container for logging status information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecLogging
{
    /// <summary>
    /// Describes where logs are stored and the prefix that Amazon S3 assigns to
    /// all log object keys for a bucket. For more information, see PUT Bucket logging
    /// (https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTlogging.html)
    /// in the Amazon S3 API Reference.
    /// </summary>
    [JsonPropertyName("loggingEnabled")]
    public V1alpha1BucketSpecLoggingLoggingEnabled? LoggingEnabled { get; set; }
}

/// <summary>A container of a key value name pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecMetricsFilterAndTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A conjunction (logical AND) of predicates, which is used in evaluating a
/// metrics filter. The operator must have at least two predicates, and an object
/// must match all of the predicates in order for the filter to apply.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecMetricsFilterAnd
{
    [JsonPropertyName("accessPointARN")]
    public string? AccessPointARN { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1BucketSpecMetricsFilterAndTags>? Tags { get; set; }
}

/// <summary>A container of a key value name pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecMetricsFilterTag
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Specifies a metrics configuration filter. The metrics configuration only
/// includes objects that meet the filter&apos;s criteria. A filter must be a prefix,
/// an object tag, an access point ARN, or a conjunction (MetricsAndOperator).
/// For more information, see PutBucketMetricsConfiguration (https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketMetricsConfiguration.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecMetricsFilter
{
    [JsonPropertyName("accessPointARN")]
    public string? AccessPointARN { get; set; }

    /// <summary>
    /// A conjunction (logical AND) of predicates, which is used in evaluating a
    /// metrics filter. The operator must have at least two predicates, and an object
    /// must match all of the predicates in order for the filter to apply.
    /// </summary>
    [JsonPropertyName("and")]
    public V1alpha1BucketSpecMetricsFilterAnd? And { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>A container of a key value name pair.</summary>
    [JsonPropertyName("tag")]
    public V1alpha1BucketSpecMetricsFilterTag? Tag { get; set; }
}

/// <summary>
/// Specifies a metrics configuration for the CloudWatch request metrics (specified
/// by the metrics configuration ID) from an Amazon S3 bucket. If you&apos;re updating
/// an existing metrics configuration, note that this is a full replacement of
/// the existing metrics configuration. If you don&apos;t include the elements you
/// want to keep, they are erased. For more information, see PutBucketMetricsConfiguration
/// (https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTMetricConfiguration.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecMetrics
{
    /// <summary>
    /// Specifies a metrics configuration filter. The metrics configuration only
    /// includes objects that meet the filter&apos;s criteria. A filter must be a prefix,
    /// an object tag, an access point ARN, or a conjunction (MetricsAndOperator).
    /// For more information, see PutBucketMetricsConfiguration (https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketMetricsConfiguration.html).
    /// </summary>
    [JsonPropertyName("filter")]
    public V1alpha1BucketSpecMetricsFilter? Filter { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Specifies the Amazon S3 object key name to filter on. An object key name
/// is the name assigned to an object in your Amazon S3 bucket. You specify whether
/// to filter on the suffix or prefix of the object key name. A prefix is a specific
/// string of characters at the beginning of an object key name, which you can
/// use to organize objects. For example, you can start the key names of related
/// objects with a prefix, such as 2023- or engineering/. Then, you can use FilterRule
/// to find objects in a bucket with key names that have the same prefix. A suffix
/// is similar to a prefix, but it is at the end of the object key name instead
/// of at the beginning.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationLambdaFunctionConfigurationsFilterKeyFilterRules
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A container for object key name prefix and suffix filtering rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationLambdaFunctionConfigurationsFilterKey
{
    /// <summary>
    /// A list of containers for the key-value pair that defines the criteria for
    /// the filter rule.
    /// </summary>
    [JsonPropertyName("filterRules")]
    public IList<V1alpha1BucketSpecNotificationLambdaFunctionConfigurationsFilterKeyFilterRules>? FilterRules { get; set; }
}

/// <summary>
/// Specifies object key name filtering rules. For information about key name
/// filtering, see Configuring event notifications using object key name filtering
/// (https://docs.aws.amazon.com/AmazonS3/latest/userguide/notification-how-to-filtering.html)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationLambdaFunctionConfigurationsFilter
{
    /// <summary>A container for object key name prefix and suffix filtering rules.</summary>
    [JsonPropertyName("key")]
    public V1alpha1BucketSpecNotificationLambdaFunctionConfigurationsFilterKey? Key { get; set; }
}

/// <summary>A container for specifying the configuration for Lambda notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationLambdaFunctionConfigurations
{
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>
    /// Specifies object key name filtering rules. For information about key name
    /// filtering, see Configuring event notifications using object key name filtering
    /// (https://docs.aws.amazon.com/AmazonS3/latest/userguide/notification-how-to-filtering.html)
    /// in the Amazon S3 User Guide.
    /// </summary>
    [JsonPropertyName("filter")]
    public V1alpha1BucketSpecNotificationLambdaFunctionConfigurationsFilter? Filter { get; set; }

    /// <summary>
    /// An optional unique identifier for configurations in a notification configuration.
    /// If you don&apos;t provide one, Amazon S3 will assign an ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lambdaFunctionARN")]
    public string? LambdaFunctionARN { get; set; }
}

/// <summary>
/// Specifies the Amazon S3 object key name to filter on. An object key name
/// is the name assigned to an object in your Amazon S3 bucket. You specify whether
/// to filter on the suffix or prefix of the object key name. A prefix is a specific
/// string of characters at the beginning of an object key name, which you can
/// use to organize objects. For example, you can start the key names of related
/// objects with a prefix, such as 2023- or engineering/. Then, you can use FilterRule
/// to find objects in a bucket with key names that have the same prefix. A suffix
/// is similar to a prefix, but it is at the end of the object key name instead
/// of at the beginning.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationQueueConfigurationsFilterKeyFilterRules
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A container for object key name prefix and suffix filtering rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationQueueConfigurationsFilterKey
{
    /// <summary>
    /// A list of containers for the key-value pair that defines the criteria for
    /// the filter rule.
    /// </summary>
    [JsonPropertyName("filterRules")]
    public IList<V1alpha1BucketSpecNotificationQueueConfigurationsFilterKeyFilterRules>? FilterRules { get; set; }
}

/// <summary>
/// Specifies object key name filtering rules. For information about key name
/// filtering, see Configuring event notifications using object key name filtering
/// (https://docs.aws.amazon.com/AmazonS3/latest/userguide/notification-how-to-filtering.html)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationQueueConfigurationsFilter
{
    /// <summary>A container for object key name prefix and suffix filtering rules.</summary>
    [JsonPropertyName("key")]
    public V1alpha1BucketSpecNotificationQueueConfigurationsFilterKey? Key { get; set; }
}

/// <summary>
/// Specifies the configuration for publishing messages to an Amazon Simple Queue
/// Service (Amazon SQS) queue when Amazon S3 detects specified events.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationQueueConfigurations
{
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>
    /// Specifies object key name filtering rules. For information about key name
    /// filtering, see Configuring event notifications using object key name filtering
    /// (https://docs.aws.amazon.com/AmazonS3/latest/userguide/notification-how-to-filtering.html)
    /// in the Amazon S3 User Guide.
    /// </summary>
    [JsonPropertyName("filter")]
    public V1alpha1BucketSpecNotificationQueueConfigurationsFilter? Filter { get; set; }

    /// <summary>
    /// An optional unique identifier for configurations in a notification configuration.
    /// If you don&apos;t provide one, Amazon S3 will assign an ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("queueARN")]
    public string? QueueARN { get; set; }
}

/// <summary>
/// Specifies the Amazon S3 object key name to filter on. An object key name
/// is the name assigned to an object in your Amazon S3 bucket. You specify whether
/// to filter on the suffix or prefix of the object key name. A prefix is a specific
/// string of characters at the beginning of an object key name, which you can
/// use to organize objects. For example, you can start the key names of related
/// objects with a prefix, such as 2023- or engineering/. Then, you can use FilterRule
/// to find objects in a bucket with key names that have the same prefix. A suffix
/// is similar to a prefix, but it is at the end of the object key name instead
/// of at the beginning.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationTopicConfigurationsFilterKeyFilterRules
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>A container for object key name prefix and suffix filtering rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationTopicConfigurationsFilterKey
{
    /// <summary>
    /// A list of containers for the key-value pair that defines the criteria for
    /// the filter rule.
    /// </summary>
    [JsonPropertyName("filterRules")]
    public IList<V1alpha1BucketSpecNotificationTopicConfigurationsFilterKeyFilterRules>? FilterRules { get; set; }
}

/// <summary>
/// Specifies object key name filtering rules. For information about key name
/// filtering, see Configuring event notifications using object key name filtering
/// (https://docs.aws.amazon.com/AmazonS3/latest/userguide/notification-how-to-filtering.html)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationTopicConfigurationsFilter
{
    /// <summary>A container for object key name prefix and suffix filtering rules.</summary>
    [JsonPropertyName("key")]
    public V1alpha1BucketSpecNotificationTopicConfigurationsFilterKey? Key { get; set; }
}

/// <summary>
/// A container for specifying the configuration for publication of messages
/// to an Amazon Simple Notification Service (Amazon SNS) topic when Amazon S3
/// detects specified events.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotificationTopicConfigurations
{
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>
    /// Specifies object key name filtering rules. For information about key name
    /// filtering, see Configuring event notifications using object key name filtering
    /// (https://docs.aws.amazon.com/AmazonS3/latest/userguide/notification-how-to-filtering.html)
    /// in the Amazon S3 User Guide.
    /// </summary>
    [JsonPropertyName("filter")]
    public V1alpha1BucketSpecNotificationTopicConfigurationsFilter? Filter { get; set; }

    /// <summary>
    /// An optional unique identifier for configurations in a notification configuration.
    /// If you don&apos;t provide one, Amazon S3 will assign an ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("topicARN")]
    public string? TopicARN { get; set; }
}

/// <summary>
/// A container for specifying the notification configuration of the bucket.
/// If this element is empty, notifications are turned off for the bucket.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecNotification
{
    [JsonPropertyName("lambdaFunctionConfigurations")]
    public IList<V1alpha1BucketSpecNotificationLambdaFunctionConfigurations>? LambdaFunctionConfigurations { get; set; }

    [JsonPropertyName("queueConfigurations")]
    public IList<V1alpha1BucketSpecNotificationQueueConfigurations>? QueueConfigurations { get; set; }

    [JsonPropertyName("topicConfigurations")]
    public IList<V1alpha1BucketSpecNotificationTopicConfigurations>? TopicConfigurations { get; set; }
}

/// <summary>
/// The container element for optionally specifying the default Object Lock retention
/// settings for new objects placed in the specified bucket.
/// 
///    * The DefaultRetention settings require both a mode and a period.
/// 
///    * The DefaultRetention period can be either Days or Years but you must
///    select one. You cannot specify Days and Years at the same time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecObjectLockConfigurationRuleDefaultRetention
{
    [JsonPropertyName("days")]
    public long? Days { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("years")]
    public long? Years { get; set; }
}

/// <summary>The container element for an Object Lock rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecObjectLockConfigurationRule
{
    /// <summary>
    /// The container element for optionally specifying the default Object Lock retention
    /// settings for new objects placed in the specified bucket.
    /// 
    ///    * The DefaultRetention settings require both a mode and a period.
    /// 
    ///    * The DefaultRetention period can be either Days or Years but you must
    ///    select one. You cannot specify Days and Years at the same time.
    /// </summary>
    [JsonPropertyName("defaultRetention")]
    public V1alpha1BucketSpecObjectLockConfigurationRuleDefaultRetention? DefaultRetention { get; set; }
}

/// <summary>The Object Lock configuration that you want to apply to the specified bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecObjectLockConfiguration
{
    /// <summary>The container element for an Object Lock rule.</summary>
    [JsonPropertyName("rule")]
    public V1alpha1BucketSpecObjectLockConfigurationRule? Rule { get; set; }
}

/// <summary>The container element for an ownership control rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecOwnershipControlsRules
{
    /// <summary>
    /// The container element for object ownership for a bucket&apos;s ownership controls.
    /// 
    /// BucketOwnerPreferred - Objects uploaded to the bucket change ownership to
    /// the bucket owner if the objects are uploaded with the bucket-owner-full-control
    /// canned ACL.
    /// 
    /// ObjectWriter - The uploading account will own the object if the object is
    /// uploaded with the bucket-owner-full-control canned ACL.
    /// 
    /// BucketOwnerEnforced - Access control lists (ACLs) are disabled and no longer
    /// affect permissions. The bucket owner automatically owns and has full control
    /// over every object in the bucket. The bucket only accepts PUT requests that
    /// don&apos;t specify an ACL or specify bucket owner full control ACLs (such as the
    /// predefined bucket-owner-full-control canned ACL or a custom ACL in XML format
    /// that grants the same permissions).
    /// 
    /// By default, ObjectOwnership is set to BucketOwnerEnforced and ACLs are disabled.
    /// We recommend keeping ACLs disabled, except in uncommon use cases where you
    /// must control access for each object individually. For more information about
    /// S3 Object Ownership, see Controlling ownership of objects and disabling ACLs
    /// for your bucket (https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html)
    /// in the Amazon S3 User Guide.
    /// 
    /// This functionality is not supported for directory buckets. Directory buckets
    /// use the bucket owner enforced setting for S3 Object Ownership.
    /// </summary>
    [JsonPropertyName("objectOwnership")]
    public string? ObjectOwnership { get; set; }
}

/// <summary>
/// The OwnershipControls (BucketOwnerEnforced, BucketOwnerPreferred, or ObjectWriter)
/// that you want to apply to this Amazon S3 bucket.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecOwnershipControls
{
    [JsonPropertyName("rules")]
    public IList<V1alpha1BucketSpecOwnershipControlsRules>? Rules { get; set; }
}

/// <summary>
/// The PublicAccessBlock configuration that you want to apply to this Amazon
/// S3 bucket. You can enable the configuration options in any combination. For
/// more information about when Amazon S3 considers a bucket or object public,
/// see The Meaning of &quot;Public&quot; (https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html#access-control-block-public-access-policy-status)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecPublicAccessBlock
{
    [JsonPropertyName("blockPublicACLs")]
    public bool? BlockPublicACLs { get; set; }

    [JsonPropertyName("blockPublicPolicy")]
    public bool? BlockPublicPolicy { get; set; }

    [JsonPropertyName("ignorePublicACLs")]
    public bool? IgnorePublicACLs { get; set; }

    [JsonPropertyName("restrictPublicBuckets")]
    public bool? RestrictPublicBuckets { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRoleRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for Role</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1BucketSpecReplicationRoleRefFrom? From { get; set; }
}

/// <summary>
/// Specifies whether Amazon S3 replicates delete markers. If you specify a Filter
/// in your replication configuration, you must also include a DeleteMarkerReplication
/// element. If your Filter includes a Tag element, the DeleteMarkerReplication
/// Status must be set to Disabled, because Amazon S3 does not support replicating
/// delete markers for tag-based rules. For an example configuration, see Basic
/// Rule Configuration (https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-add-config.html#replication-config-min-rule-config).
/// 
/// For more information about delete marker replication, see Basic Rule Configuration
/// (https://docs.aws.amazon.com/AmazonS3/latest/dev/delete-marker-replication.html).
/// 
/// If you are using an earlier version of the replication configuration, Amazon
/// S3 handles replication of delete markers differently. For more information,
/// see Backward Compatibility (https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-add-config.html#replication-backward-compat-considerations).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesDeleteMarkerReplication
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>A container for information about access control for replicas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesDestinationAccessControlTranslation
{
    [JsonPropertyName("owner")]
    public string? Owner { get; set; }
}

/// <summary>
/// Specifies encryption-related information for an Amazon S3 bucket that is
/// a destination for replicated objects.
/// 
/// If you&apos;re specifying a customer managed KMS key, we recommend using a fully
/// qualified KMS key ARN. If you use a KMS key alias instead, then KMS resolves
/// the key within the requester’s account. This behavior can result in data
/// that&apos;s encrypted with a KMS key that belongs to the requester, and not the
/// bucket owner.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesDestinationEncryptionConfiguration
{
    [JsonPropertyName("replicaKMSKeyID")]
    public string? ReplicaKMSKeyID { get; set; }
}

/// <summary>
/// A container specifying the time value for S3 Replication Time Control (S3
/// RTC) and replication metrics EventThreshold.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesDestinationMetricsEventThreshold
{
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }
}

/// <summary>
/// A container specifying replication metrics-related settings enabling replication
/// metrics and events.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesDestinationMetrics
{
    /// <summary>
    /// A container specifying the time value for S3 Replication Time Control (S3
    /// RTC) and replication metrics EventThreshold.
    /// </summary>
    [JsonPropertyName("eventThreshold")]
    public V1alpha1BucketSpecReplicationRulesDestinationMetricsEventThreshold? EventThreshold { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// A container specifying the time value for S3 Replication Time Control (S3
/// RTC) and replication metrics EventThreshold.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesDestinationReplicationTimeTime
{
    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }
}

/// <summary>
/// A container specifying S3 Replication Time Control (S3 RTC) related information,
/// including whether S3 RTC is enabled and the time when all objects and operations
/// on objects must be replicated. Must be specified together with a Metrics
/// block.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesDestinationReplicationTime
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// A container specifying the time value for S3 Replication Time Control (S3
    /// RTC) and replication metrics EventThreshold.
    /// </summary>
    [JsonPropertyName("time")]
    public V1alpha1BucketSpecReplicationRulesDestinationReplicationTimeTime? Time { get; set; }
}

/// <summary>
/// Specifies information about where to publish analysis or configuration results
/// for an Amazon S3 bucket and S3 Replication Time Control (S3 RTC).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesDestination
{
    /// <summary>A container for information about access control for replicas.</summary>
    [JsonPropertyName("accessControlTranslation")]
    public V1alpha1BucketSpecReplicationRulesDestinationAccessControlTranslation? AccessControlTranslation { get; set; }

    [JsonPropertyName("account")]
    public string? Account { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Specifies encryption-related information for an Amazon S3 bucket that is
    /// a destination for replicated objects.
    /// 
    /// If you&apos;re specifying a customer managed KMS key, we recommend using a fully
    /// qualified KMS key ARN. If you use a KMS key alias instead, then KMS resolves
    /// the key within the requester’s account. This behavior can result in data
    /// that&apos;s encrypted with a KMS key that belongs to the requester, and not the
    /// bucket owner.
    /// </summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1alpha1BucketSpecReplicationRulesDestinationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>
    /// A container specifying replication metrics-related settings enabling replication
    /// metrics and events.
    /// </summary>
    [JsonPropertyName("metrics")]
    public V1alpha1BucketSpecReplicationRulesDestinationMetrics? Metrics { get; set; }

    /// <summary>
    /// A container specifying S3 Replication Time Control (S3 RTC) related information,
    /// including whether S3 RTC is enabled and the time when all objects and operations
    /// on objects must be replicated. Must be specified together with a Metrics
    /// block.
    /// </summary>
    [JsonPropertyName("replicationTime")]
    public V1alpha1BucketSpecReplicationRulesDestinationReplicationTime? ReplicationTime { get; set; }

    [JsonPropertyName("storageClass")]
    public string? StorageClass { get; set; }
}

/// <summary>
/// Optional configuration to replicate existing source bucket objects.
/// 
/// This parameter is no longer supported. To replicate existing objects, see
/// Replicating existing objects with S3 Batch Replication (https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-batch-replication-batch.html)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesExistingObjectReplication
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>A container of a key value name pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesFilterAndTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A container for specifying rule filters. The filters determine the subset
/// of objects to which the rule applies. This element is required only if you
/// specify more than one filter.
/// 
/// For example:
/// 
///    * If you specify both a Prefix and a Tag filter, wrap these filters in
///    an And tag.
/// 
///    * If you specify a filter based on multiple tags, wrap the Tag elements
///    in an And tag.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesFilterAnd
{
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1BucketSpecReplicationRulesFilterAndTags>? Tags { get; set; }
}

/// <summary>A container of a key value name pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesFilterTag
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A filter that identifies the subset of objects to which the replication rule
/// applies. A Filter must specify exactly one Prefix, Tag, or an And child element.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesFilter
{
    /// <summary>
    /// A container for specifying rule filters. The filters determine the subset
    /// of objects to which the rule applies. This element is required only if you
    /// specify more than one filter.
    /// 
    /// For example:
    /// 
    ///    * If you specify both a Prefix and a Tag filter, wrap these filters in
    ///    an And tag.
    /// 
    ///    * If you specify a filter based on multiple tags, wrap the Tag elements
    ///    in an And tag.
    /// </summary>
    [JsonPropertyName("and")]
    public V1alpha1BucketSpecReplicationRulesFilterAnd? And { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>A container of a key value name pair.</summary>
    [JsonPropertyName("tag")]
    public V1alpha1BucketSpecReplicationRulesFilterTag? Tag { get; set; }
}

/// <summary>
/// A filter that you can specify for selection for modifications on replicas.
/// Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest
/// version of replication configuration (when Filter is specified), you can
/// specify this element and set the status to Enabled to replicate modifications
/// on replicas.
/// 
/// If you don&apos;t specify the Filter element, Amazon S3 assumes that the replication
/// configuration is the earlier version, V1. In the earlier version, this element
/// is not allowed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesSourceSelectionCriteriaReplicaModifications
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// A container for filter information for the selection of S3 objects encrypted
/// with Amazon Web Services KMS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesSourceSelectionCriteriaSseKMSEncryptedObjects
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// A container that describes additional filters for identifying the source
/// objects that you want to replicate. You can choose to enable or disable the
/// replication of these objects. Currently, Amazon S3 supports only the filter
/// that you can specify for objects created with server-side encryption using
/// a customer managed key stored in Amazon Web Services Key Management Service
/// (SSE-KMS).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRulesSourceSelectionCriteria
{
    /// <summary>
    /// A filter that you can specify for selection for modifications on replicas.
    /// Amazon S3 doesn&apos;t replicate replica modifications by default. In the latest
    /// version of replication configuration (when Filter is specified), you can
    /// specify this element and set the status to Enabled to replicate modifications
    /// on replicas.
    /// 
    /// If you don&apos;t specify the Filter element, Amazon S3 assumes that the replication
    /// configuration is the earlier version, V1. In the earlier version, this element
    /// is not allowed.
    /// </summary>
    [JsonPropertyName("replicaModifications")]
    public V1alpha1BucketSpecReplicationRulesSourceSelectionCriteriaReplicaModifications? ReplicaModifications { get; set; }

    /// <summary>
    /// A container for filter information for the selection of S3 objects encrypted
    /// with Amazon Web Services KMS.
    /// </summary>
    [JsonPropertyName("sseKMSEncryptedObjects")]
    public V1alpha1BucketSpecReplicationRulesSourceSelectionCriteriaSseKMSEncryptedObjects? SseKMSEncryptedObjects { get; set; }
}

/// <summary>Specifies which Amazon S3 objects to replicate and where to store the replicas.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplicationRules
{
    /// <summary>
    /// Specifies whether Amazon S3 replicates delete markers. If you specify a Filter
    /// in your replication configuration, you must also include a DeleteMarkerReplication
    /// element. If your Filter includes a Tag element, the DeleteMarkerReplication
    /// Status must be set to Disabled, because Amazon S3 does not support replicating
    /// delete markers for tag-based rules. For an example configuration, see Basic
    /// Rule Configuration (https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-add-config.html#replication-config-min-rule-config).
    /// 
    /// For more information about delete marker replication, see Basic Rule Configuration
    /// (https://docs.aws.amazon.com/AmazonS3/latest/dev/delete-marker-replication.html).
    /// 
    /// If you are using an earlier version of the replication configuration, Amazon
    /// S3 handles replication of delete markers differently. For more information,
    /// see Backward Compatibility (https://docs.aws.amazon.com/AmazonS3/latest/dev/replication-add-config.html#replication-backward-compat-considerations).
    /// </summary>
    [JsonPropertyName("deleteMarkerReplication")]
    public V1alpha1BucketSpecReplicationRulesDeleteMarkerReplication? DeleteMarkerReplication { get; set; }

    /// <summary>
    /// Specifies information about where to publish analysis or configuration results
    /// for an Amazon S3 bucket and S3 Replication Time Control (S3 RTC).
    /// </summary>
    [JsonPropertyName("destination")]
    public V1alpha1BucketSpecReplicationRulesDestination? Destination { get; set; }

    /// <summary>
    /// Optional configuration to replicate existing source bucket objects.
    /// 
    /// This parameter is no longer supported. To replicate existing objects, see
    /// Replicating existing objects with S3 Batch Replication (https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-batch-replication-batch.html)
    /// in the Amazon S3 User Guide.
    /// </summary>
    [JsonPropertyName("existingObjectReplication")]
    public V1alpha1BucketSpecReplicationRulesExistingObjectReplication? ExistingObjectReplication { get; set; }

    /// <summary>
    /// A filter that identifies the subset of objects to which the replication rule
    /// applies. A Filter must specify exactly one Prefix, Tag, or an And child element.
    /// </summary>
    [JsonPropertyName("filter")]
    public V1alpha1BucketSpecReplicationRulesFilter? Filter { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    /// <summary>
    /// A container that describes additional filters for identifying the source
    /// objects that you want to replicate. You can choose to enable or disable the
    /// replication of these objects. Currently, Amazon S3 supports only the filter
    /// that you can specify for objects created with server-side encryption using
    /// a customer managed key stored in Amazon Web Services Key Management Service
    /// (SSE-KMS).
    /// </summary>
    [JsonPropertyName("sourceSelectionCriteria")]
    public V1alpha1BucketSpecReplicationRulesSourceSelectionCriteria? SourceSelectionCriteria { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// A container for replication rules. You can add up to 1,000 rules. The maximum
/// size of a replication configuration is 2 MB.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecReplication
{
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Reference field for Role</summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1BucketSpecReplicationRoleRef? RoleRef { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1alpha1BucketSpecReplicationRules>? Rules { get; set; }
}

/// <summary>Container for Payer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecRequestPayment
{
    [JsonPropertyName("payer")]
    public string? Payer { get; set; }
}

/// <summary>A container of a key value name pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecTaggingTagSet
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Container for the TagSet and Tag elements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecTagging
{
    [JsonPropertyName("tagSet")]
    public IList<V1alpha1BucketSpecTaggingTagSet>? TagSet { get; set; }
}

/// <summary>Container for setting the versioning state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecVersioning
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The error information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecWebsiteErrorDocument
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>Container for the Suffix element.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecWebsiteIndexDocument
{
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>
/// Specifies the redirect behavior of all requests to a website endpoint of
/// an Amazon S3 bucket.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecWebsiteRedirectAllRequestsTo
{
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>
/// A container for describing a condition that must be met for the specified
/// redirect to apply. For example, 1. If request is for pages in the /docs folder,
/// redirect to the /documents folder. 2. If request results in HTTP error 4xx,
/// redirect request to another host where you might process the error.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecWebsiteRoutingRulesCondition
{
    [JsonPropertyName("httpErrorCodeReturnedEquals")]
    public string? HttpErrorCodeReturnedEquals { get; set; }

    [JsonPropertyName("keyPrefixEquals")]
    public string? KeyPrefixEquals { get; set; }
}

/// <summary>
/// Specifies how requests are redirected. In the event of an error, you can
/// specify a different error code to return.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecWebsiteRoutingRulesRedirect
{
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    [JsonPropertyName("httpRedirectCode")]
    public string? HttpRedirectCode { get; set; }

    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    [JsonPropertyName("replaceKeyPrefixWith")]
    public string? ReplaceKeyPrefixWith { get; set; }

    [JsonPropertyName("replaceKeyWith")]
    public string? ReplaceKeyWith { get; set; }
}

/// <summary>
/// Specifies the redirect behavior and when a redirect is applied. For more
/// information about routing rules, see Configuring advanced conditional redirects
/// (https://docs.aws.amazon.com/AmazonS3/latest/dev/how-to-page-redirect.html#advanced-conditional-redirects)
/// in the Amazon S3 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecWebsiteRoutingRules
{
    /// <summary>
    /// A container for describing a condition that must be met for the specified
    /// redirect to apply. For example, 1. If request is for pages in the /docs folder,
    /// redirect to the /documents folder. 2. If request results in HTTP error 4xx,
    /// redirect request to another host where you might process the error.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1alpha1BucketSpecWebsiteRoutingRulesCondition? Condition { get; set; }

    /// <summary>
    /// Specifies how requests are redirected. In the event of an error, you can
    /// specify a different error code to return.
    /// </summary>
    [JsonPropertyName("redirect")]
    public V1alpha1BucketSpecWebsiteRoutingRulesRedirect? Redirect { get; set; }
}

/// <summary>Container for the request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpecWebsite
{
    /// <summary>The error information.</summary>
    [JsonPropertyName("errorDocument")]
    public V1alpha1BucketSpecWebsiteErrorDocument? ErrorDocument { get; set; }

    /// <summary>Container for the Suffix element.</summary>
    [JsonPropertyName("indexDocument")]
    public V1alpha1BucketSpecWebsiteIndexDocument? IndexDocument { get; set; }

    /// <summary>
    /// Specifies the redirect behavior of all requests to a website endpoint of
    /// an Amazon S3 bucket.
    /// </summary>
    [JsonPropertyName("redirectAllRequestsTo")]
    public V1alpha1BucketSpecWebsiteRedirectAllRequestsTo? RedirectAllRequestsTo { get; set; }

    [JsonPropertyName("routingRules")]
    public IList<V1alpha1BucketSpecWebsiteRoutingRules>? RoutingRules { get; set; }
}

/// <summary>
/// BucketSpec defines the desired state of Bucket.
/// 
/// In terms of implementation, a Bucket is a resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketSpec
{
    /// <summary>Container for setting the transfer acceleration state.</summary>
    [JsonPropertyName("accelerate")]
    public V1alpha1BucketSpecAccelerate? Accelerate { get; set; }

    /// <summary>
    /// The canned ACL to apply to the bucket.
    /// 
    /// This functionality is not supported for directory buckets.
    /// </summary>
    [JsonPropertyName("acl")]
    public string? Acl { get; set; }

    [JsonPropertyName("analytics")]
    public IList<V1alpha1BucketSpecAnalytics>? Analytics { get; set; }

    /// <summary>
    /// Describes the cross-origin access configuration for objects in an Amazon
    /// S3 bucket. For more information, see Enabling Cross-Origin Resource Sharing
    /// (https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html) in the Amazon
    /// S3 User Guide.
    /// </summary>
    [JsonPropertyName("cors")]
    public V1alpha1BucketSpecCors? Cors { get; set; }

    /// <summary>The configuration information for the bucket.</summary>
    [JsonPropertyName("createBucketConfiguration")]
    public V1alpha1BucketSpecCreateBucketConfiguration? CreateBucketConfiguration { get; set; }

    /// <summary>Specifies the default server-side-encryption configuration.</summary>
    [JsonPropertyName("encryption")]
    public V1alpha1BucketSpecEncryption? Encryption { get; set; }

    /// <summary>
    /// Allows grantee the read, write, read ACP, and write ACP permissions on the
    /// bucket.
    /// 
    /// This functionality is not supported for directory buckets.
    /// </summary>
    [JsonPropertyName("grantFullControl")]
    public string? GrantFullControl { get; set; }

    /// <summary>
    /// Allows grantee to list the objects in the bucket.
    /// 
    /// This functionality is not supported for directory buckets.
    /// </summary>
    [JsonPropertyName("grantRead")]
    public string? GrantRead { get; set; }

    /// <summary>
    /// Allows grantee to read the bucket ACL.
    /// 
    /// This functionality is not supported for directory buckets.
    /// </summary>
    [JsonPropertyName("grantReadACP")]
    public string? GrantReadACP { get; set; }

    /// <summary>
    /// Allows grantee to create new objects in the bucket.
    /// 
    /// For the bucket and object owners of existing objects, also allows deletions
    /// and overwrites of those objects.
    /// 
    /// This functionality is not supported for directory buckets.
    /// </summary>
    [JsonPropertyName("grantWrite")]
    public string? GrantWrite { get; set; }

    /// <summary>
    /// Allows grantee to write the ACL for the applicable bucket.
    /// 
    /// This functionality is not supported for directory buckets.
    /// </summary>
    [JsonPropertyName("grantWriteACP")]
    public string? GrantWriteACP { get; set; }

    [JsonPropertyName("intelligentTiering")]
    public IList<V1alpha1BucketSpecIntelligentTiering>? IntelligentTiering { get; set; }

    [JsonPropertyName("inventory")]
    public IList<V1alpha1BucketSpecInventory>? Inventory { get; set; }

    /// <summary>Container for lifecycle rules. You can add as many as 1,000 rules.</summary>
    [JsonPropertyName("lifecycle")]
    public V1alpha1BucketSpecLifecycle? Lifecycle { get; set; }

    /// <summary>Container for logging status information.</summary>
    [JsonPropertyName("logging")]
    public V1alpha1BucketSpecLogging? Logging { get; set; }

    [JsonPropertyName("metrics")]
    public IList<V1alpha1BucketSpecMetrics>? Metrics { get; set; }

    /// <summary>
    /// The name of the bucket to create.
    /// 
    /// General purpose buckets - For information about bucket naming restrictions,
    /// see Bucket naming rules (https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html)
    /// in the Amazon S3 User Guide.
    /// 
    /// Directory buckets - When you use this operation with a directory bucket,
    /// you must use path-style requests in the format https://s3express-control.region-code.amazonaws.com/bucket-name
    /// . Virtual-hosted-style requests aren&apos;t supported. Directory bucket names
    /// must be unique in the chosen Zone (Availability Zone or Local Zone). Bucket
    /// names must also follow the format bucket-base-name--zone-id--x-s3 (for example,
    /// DOC-EXAMPLE-BUCKET--usw2-az1--x-s3). For information about bucket naming
    /// restrictions, see Directory bucket naming rules (https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html)
    /// in the Amazon S3 User Guide
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Specifies the namespace where you want to create your general purpose bucket.
    /// When you create a general purpose bucket, you can choose to create a bucket
    /// in the shared global namespace or you can choose to create a bucket in your
    /// account regional namespace. Your account regional namespace is a subdivision
    /// of the global namespace that only your account can create buckets in. For
    /// more information on bucket namespaces, see Namespaces for general purpose
    /// buckets (https://docs.aws.amazon.com/AmazonS3/latest/userguide/gpbucketnamespaces.html).
    /// 
    /// General purpose buckets in your account regional namespace must follow a
    /// specific naming convention. These buckets consist of a bucket name prefix
    /// that you create, and a suffix that contains your 12-digit Amazon Web Services
    /// Account ID, the Amazon Web Services Region code, and ends with -an. Bucket
    /// names must follow the format bucket-name-prefix-accountId-region-an (for
    /// example, amzn-s3-demo-bucket-111122223333-us-west-2-an). For information
    /// about bucket naming restrictions, see Account regional namespace naming rules
    /// (https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html#account-regional-naming-rules)
    /// in the Amazon S3 User Guide.
    /// 
    /// This functionality is not supported for directory buckets.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// A container for specifying the notification configuration of the bucket.
    /// If this element is empty, notifications are turned off for the bucket.
    /// </summary>
    [JsonPropertyName("notification")]
    public V1alpha1BucketSpecNotification? Notification { get; set; }

    /// <summary>The Object Lock configuration that you want to apply to the specified bucket.</summary>
    [JsonPropertyName("objectLockConfiguration")]
    public V1alpha1BucketSpecObjectLockConfiguration? ObjectLockConfiguration { get; set; }

    /// <summary>
    /// Specifies whether you want S3 Object Lock to be enabled for the new bucket.
    /// 
    /// This functionality is not supported for directory buckets.
    /// </summary>
    [JsonPropertyName("objectLockEnabledForBucket")]
    public bool? ObjectLockEnabledForBucket { get; set; }

    [JsonPropertyName("objectOwnership")]
    public string? ObjectOwnership { get; set; }

    /// <summary>
    /// The OwnershipControls (BucketOwnerEnforced, BucketOwnerPreferred, or ObjectWriter)
    /// that you want to apply to this Amazon S3 bucket.
    /// </summary>
    [JsonPropertyName("ownershipControls")]
    public V1alpha1BucketSpecOwnershipControls? OwnershipControls { get; set; }

    /// <summary>
    /// The bucket policy as a JSON document.
    /// 
    /// For directory buckets, the only IAM action supported in the bucket policy
    /// is s3express:CreateSession.
    /// </summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>
    /// The PublicAccessBlock configuration that you want to apply to this Amazon
    /// S3 bucket. You can enable the configuration options in any combination. For
    /// more information about when Amazon S3 considers a bucket or object public,
    /// see The Meaning of &quot;Public&quot; (https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html#access-control-block-public-access-policy-status)
    /// in the Amazon S3 User Guide.
    /// </summary>
    [JsonPropertyName("publicAccessBlock")]
    public V1alpha1BucketSpecPublicAccessBlock? PublicAccessBlock { get; set; }

    /// <summary>
    /// A container for replication rules. You can add up to 1,000 rules. The maximum
    /// size of a replication configuration is 2 MB.
    /// </summary>
    [JsonPropertyName("replication")]
    public V1alpha1BucketSpecReplication? Replication { get; set; }

    /// <summary>Container for Payer.</summary>
    [JsonPropertyName("requestPayment")]
    public V1alpha1BucketSpecRequestPayment? RequestPayment { get; set; }

    /// <summary>Container for the TagSet and Tag elements.</summary>
    [JsonPropertyName("tagging")]
    public V1alpha1BucketSpecTagging? Tagging { get; set; }

    /// <summary>Container for setting the versioning state.</summary>
    [JsonPropertyName("versioning")]
    public V1alpha1BucketSpecVersioning? Versioning { get; set; }

    /// <summary>Container for the request.</summary>
    [JsonPropertyName("website")]
    public V1alpha1BucketSpecWebsite? Website { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketStatusAckResourceMetadata
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
public partial class V1alpha1BucketStatusConditions
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

/// <summary>BucketStatus defines the observed state of Bucket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BucketStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1BucketStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BucketStatusConditions>? Conditions { get; set; }

    /// <summary>A forward slash followed by the name of the bucket.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>Bucket is the Schema for the Buckets API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Bucket : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BucketSpec?>, IStatus<V1alpha1BucketStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Bucket";
    public const string KubeGroup = "s3.services.k8s.aws";
    public const string KubePluralName = "buckets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "s3.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Bucket";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// BucketSpec defines the desired state of Bucket.
    /// 
    /// In terms of implementation, a Bucket is a resource.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1BucketSpec? Spec { get; set; }

    /// <summary>BucketStatus defines the observed state of Bucket</summary>
    [JsonPropertyName("status")]
    public V1alpha1BucketStatus? Status { get; set; }
}