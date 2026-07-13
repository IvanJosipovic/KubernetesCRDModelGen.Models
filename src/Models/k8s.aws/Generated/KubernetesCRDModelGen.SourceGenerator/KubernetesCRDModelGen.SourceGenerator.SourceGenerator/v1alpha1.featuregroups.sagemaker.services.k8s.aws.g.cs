#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.services.k8s.aws;
/// <summary>FeatureGroup is the Schema for the FeatureGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FeatureGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1FeatureGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FeatureGroupList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "featuregroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FeatureGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1FeatureGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1FeatureGroup> Items { get; set; }
}

/// <summary>Configuration for your vector collection type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpecFeatureDefinitionsCollectionConfigVectorConfig
{
    [JsonPropertyName("dimension")]
    public long? Dimension { get; set; }
}

/// <summary>Configuration for your collection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpecFeatureDefinitionsCollectionConfig
{
    /// <summary>Configuration for your vector collection type.</summary>
    [JsonPropertyName("vectorConfig")]
    public V1alpha1FeatureGroupSpecFeatureDefinitionsCollectionConfigVectorConfig? VectorConfig { get; set; }
}

/// <summary>
/// A list of features. You must include FeatureName and FeatureType. Valid feature
/// FeatureTypes are Integral, Fractional and String.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpecFeatureDefinitions
{
    /// <summary>Configuration for your collection.</summary>
    [JsonPropertyName("collectionConfig")]
    public V1alpha1FeatureGroupSpecFeatureDefinitionsCollectionConfig? CollectionConfig { get; set; }

    [JsonPropertyName("collectionType")]
    public string? CollectionType { get; set; }

    [JsonPropertyName("featureName")]
    public string? FeatureName { get; set; }

    [JsonPropertyName("featureType")]
    public string? FeatureType { get; set; }
}

/// <summary>The meta data of the Glue table which serves as data catalog for the OfflineStore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpecOfflineStoreConfigDataCatalogConfig
{
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    [JsonPropertyName("database")]
    public string? Database { get; set; }

    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>
/// The Amazon Simple Storage (Amazon S3) location and security configuration
/// for OfflineStore.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpecOfflineStoreConfigS3StorageConfig
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("resolvedOutputS3URI")]
    public string? ResolvedOutputS3URI { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// Use this to configure an OfflineFeatureStore. This parameter allows you to
/// specify:
/// 
///   - The Amazon Simple Storage Service (Amazon S3) location of an OfflineStore.
/// 
///   - A configuration for an Amazon Web Services Glue or Amazon Web Services
///     Hive data catalog.
/// 
///   - An KMS encryption key to encrypt the Amazon S3 location used for OfflineStore.
///     If KMS encryption key is not specified, by default we encrypt all data
///     at rest using Amazon Web Services KMS key. By defining your bucket-level
///     key (https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucket-key.html)
///     for SSE, you can reduce Amazon Web Services KMS requests costs by up to
///     99 percent.
/// 
///   - Format for the offline store table. Supported formats are Glue (Default)
///     and Apache Iceberg (https://iceberg.apache.org/).
/// 
/// To learn more about this parameter, see OfflineStoreConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_OfflineStoreConfig.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpecOfflineStoreConfig
{
    /// <summary>The meta data of the Glue table which serves as data catalog for the OfflineStore.</summary>
    [JsonPropertyName("dataCatalogConfig")]
    public V1alpha1FeatureGroupSpecOfflineStoreConfigDataCatalogConfig? DataCatalogConfig { get; set; }

    [JsonPropertyName("disableGlueTableCreation")]
    public bool? DisableGlueTableCreation { get; set; }

    /// <summary>
    /// The Amazon Simple Storage (Amazon S3) location and security configuration
    /// for OfflineStore.
    /// </summary>
    [JsonPropertyName("s3StorageConfig")]
    public V1alpha1FeatureGroupSpecOfflineStoreConfigS3StorageConfig? S3StorageConfig { get; set; }
}

/// <summary>The security configuration for OnlineStore.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpecOnlineStoreConfigSecurityConfig
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }
}

/// <summary>
/// Time to live duration, where the record is hard deleted after the expiration
/// time is reached; ExpiresAt = EventTime + TtlDuration. For information on
/// HardDelete, see the DeleteRecord (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_feature_store_DeleteRecord.html)
/// API in the Amazon SageMaker API Reference guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpecOnlineStoreConfigTtlDuration
{
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }
}

/// <summary>
/// You can turn the OnlineStore on or off by specifying True for the EnableOnlineStore
/// flag in OnlineStoreConfig.
/// 
/// You can also include an Amazon Web Services KMS key ID (KMSKeyId) for at-rest
/// encryption of the OnlineStore.
/// 
/// The default value is False.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpecOnlineStoreConfig
{
    [JsonPropertyName("enableOnlineStore")]
    public bool? EnableOnlineStore { get; set; }

    /// <summary>The security configuration for OnlineStore.</summary>
    [JsonPropertyName("securityConfig")]
    public V1alpha1FeatureGroupSpecOnlineStoreConfigSecurityConfig? SecurityConfig { get; set; }

    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>
    /// Time to live duration, where the record is hard deleted after the expiration
    /// time is reached; ExpiresAt = EventTime + TtlDuration. For information on
    /// HardDelete, see the DeleteRecord (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_feature_store_DeleteRecord.html)
    /// API in the Amazon SageMaker API Reference guide.
    /// </summary>
    [JsonPropertyName("ttlDuration")]
    public V1alpha1FeatureGroupSpecOnlineStoreConfigTtlDuration? TtlDuration { get; set; }
}

/// <summary>
/// A tag object that consists of a key and an optional value, used to manage
/// metadata for SageMaker Amazon Web Services resources.
/// 
/// You can add tags to notebook instances, training jobs, hyperparameter tuning
/// jobs, batch transform jobs, models, labeling jobs, work teams, endpoint configurations,
/// and endpoints. For more information on adding tags to SageMaker resources,
/// see AddTags (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AddTags.html).
/// 
/// For more information on adding metadata to your Amazon Web Services resources
/// with tagging, see Tagging Amazon Web Services resources (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html).
/// For advice on best practices for managing Amazon Web Services resources with
/// tagging, see Tagging Best Practices: Implement an Effective Amazon Web Services
/// Resource Tagging Strategy (https://d1.awsstatic.com/whitepapers/aws-tagging-best-practices.pdf).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Used to set feature group throughput configuration. There are two modes:
/// ON_DEMAND and PROVISIONED. With on-demand mode, you are charged for data
/// reads and writes that your application performs on your feature group. You
/// do not need to specify read and write throughput because Feature Store accommodates
/// your workloads as they ramp up and down. You can switch a feature group to
/// on-demand only once in a 24 hour period. With provisioned throughput mode,
/// you specify the read and write capacity per second that you expect your application
/// to require, and you are billed based on those limits. Exceeding provisioned
/// throughput will result in your requests being throttled.
/// 
/// Note: PROVISIONED throughput mode is supported only for feature groups that
/// are offline-only, or use the Standard (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_OnlineStoreConfig.html#sagemaker-Type-OnlineStoreConfig-StorageType)
/// tier online store.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpecThroughputConfig
{
    [JsonPropertyName("provisionedReadCapacityUnits")]
    public long? ProvisionedReadCapacityUnits { get; set; }

    [JsonPropertyName("provisionedWriteCapacityUnits")]
    public long? ProvisionedWriteCapacityUnits { get; set; }

    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }
}

/// <summary>
/// FeatureGroupSpec defines the desired state of FeatureGroup.
/// 
/// Amazon SageMaker Feature Store stores features in a collection called Feature
/// Group. A Feature Group can be visualized as a table which has rows, with
/// a unique identifier for each row where each column in the table is a feature.
/// In principle, a Feature Group is composed of features and values per features.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupSpec
{
    /// <summary>A free-form description of a FeatureGroup.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The name of the feature that stores the EventTime of a Record in a FeatureGroup.
    /// 
    /// An EventTime is a point in time when a new event occurs that corresponds
    /// to the creation or update of a Record in a FeatureGroup. All Records in the
    /// FeatureGroup must have a corresponding EventTime.
    /// 
    /// An EventTime can be a String or Fractional.
    /// 
    ///   - Fractional: EventTime feature values must be a Unix timestamp in seconds.
    /// 
    ///   - String: EventTime feature values must be an ISO-8601 string in the format.
    ///     The following formats are supported yyyy-MM-dd&apos;T&apos;HH:mm:ssZ and yyyy-MM-dd&apos;T&apos;HH:mm:ss.SSSZ
    ///     where yyyy, MM, and dd represent the year, month, and day respectively
    ///     and HH, mm, ss, and if applicable, SSS represent the hour, month, second
    ///     and milliseconds respsectively. &apos;T&apos; and Z are constants.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9]([-_]*[a-zA-Z0-9]){0,63}$`
    /// </summary>
    [JsonPropertyName("eventTimeFeatureName")]
    public required string EventTimeFeatureName { get; set; }

    /// <summary>
    /// A list of Feature names and types. Name and Type is compulsory per Feature.
    /// 
    /// Valid feature FeatureTypes are Integral, Fractional and String.
    /// 
    /// FeatureNames cannot be any of the following: is_deleted, write_time, api_invocation_time
    /// 
    /// You can create up to 2,500 FeatureDefinitions per FeatureGroup.
    /// </summary>
    [JsonPropertyName("featureDefinitions")]
    public required IList<V1alpha1FeatureGroupSpecFeatureDefinitions> FeatureDefinitions { get; set; }

    /// <summary>
    /// The name of the FeatureGroup. The name must be unique within an Amazon Web
    /// Services Region in an Amazon Web Services account.
    /// 
    /// The name:
    /// 
    ///   - Must start with an alphanumeric character.
    /// 
    ///   - Can only include alphanumeric characters, underscores, and hyphens.
    ///     Spaces are not allowed.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9]([_-]*[a-zA-Z0-9]){0,63}$`
    /// </summary>
    [JsonPropertyName("featureGroupName")]
    public required string FeatureGroupName { get; set; }

    /// <summary>
    /// Use this to configure an OfflineFeatureStore. This parameter allows you to
    /// specify:
    /// 
    ///   - The Amazon Simple Storage Service (Amazon S3) location of an OfflineStore.
    /// 
    ///   - A configuration for an Amazon Web Services Glue or Amazon Web Services
    ///     Hive data catalog.
    /// 
    ///   - An KMS encryption key to encrypt the Amazon S3 location used for OfflineStore.
    ///     If KMS encryption key is not specified, by default we encrypt all data
    ///     at rest using Amazon Web Services KMS key. By defining your bucket-level
    ///     key (https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucket-key.html)
    ///     for SSE, you can reduce Amazon Web Services KMS requests costs by up to
    ///     99 percent.
    /// 
    ///   - Format for the offline store table. Supported formats are Glue (Default)
    ///     and Apache Iceberg (https://iceberg.apache.org/).
    /// 
    /// To learn more about this parameter, see OfflineStoreConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_OfflineStoreConfig.html).
    /// </summary>
    [JsonPropertyName("offlineStoreConfig")]
    public V1alpha1FeatureGroupSpecOfflineStoreConfig? OfflineStoreConfig { get; set; }

    /// <summary>
    /// You can turn the OnlineStore on or off by specifying True for the EnableOnlineStore
    /// flag in OnlineStoreConfig.
    /// 
    /// You can also include an Amazon Web Services KMS key ID (KMSKeyId) for at-rest
    /// encryption of the OnlineStore.
    /// 
    /// The default value is False.
    /// </summary>
    [JsonPropertyName("onlineStoreConfig")]
    public V1alpha1FeatureGroupSpecOnlineStoreConfig? OnlineStoreConfig { get; set; }

    /// <summary>
    /// The name of the Feature whose value uniquely identifies a Record defined
    /// in the FeatureStore. Only the latest record per identifier value will be
    /// stored in the OnlineStore. RecordIdentifierFeatureName must be one of feature
    /// definitions&apos; names.
    /// 
    /// You use the RecordIdentifierFeatureName to access data in a FeatureStore.
    /// 
    /// This name:
    /// 
    ///   - Must start with an alphanumeric character.
    /// 
    ///   - Can only contains alphanumeric characters, hyphens, underscores. Spaces
    ///     are not allowed.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9]([-_]*[a-zA-Z0-9]){0,63}$`
    /// </summary>
    [JsonPropertyName("recordIdentifierFeatureName")]
    public required string RecordIdentifierFeatureName { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the IAM execution role used to persist
    /// data into the OfflineStore if an OfflineStoreConfig is provided.
    /// 
    /// Regex Pattern: `^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,.@\-_/]+$`
    /// </summary>
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>Tags used to identify Features in each FeatureGroup.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1FeatureGroupSpecTags>? Tags { get; set; }

    /// <summary>
    /// Used to set feature group throughput configuration. There are two modes:
    /// ON_DEMAND and PROVISIONED. With on-demand mode, you are charged for data
    /// reads and writes that your application performs on your feature group. You
    /// do not need to specify read and write throughput because Feature Store accommodates
    /// your workloads as they ramp up and down. You can switch a feature group to
    /// on-demand only once in a 24 hour period. With provisioned throughput mode,
    /// you specify the read and write capacity per second that you expect your application
    /// to require, and you are billed based on those limits. Exceeding provisioned
    /// throughput will result in your requests being throttled.
    /// 
    /// Note: PROVISIONED throughput mode is supported only for feature groups that
    /// are offline-only, or use the Standard (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_OnlineStoreConfig.html#sagemaker-Type-OnlineStoreConfig-StorageType)
    /// tier online store.
    /// </summary>
    [JsonPropertyName("throughputConfig")]
    public V1alpha1FeatureGroupSpecThroughputConfig? ThroughputConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupStatusAckResourceMetadata
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
public partial class V1alpha1FeatureGroupStatusConditions
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

/// <summary>FeatureGroupStatus defines the observed state of FeatureGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FeatureGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1FeatureGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FeatureGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The reason that the FeatureGroup failed to be replicated in the OfflineStore.
    /// This is failure can occur because:
    /// 
    ///    * The FeatureGroup could not be created in the OfflineStore.
    /// 
    ///    * The FeatureGroup could not be deleted from the OfflineStore.
    /// </summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>The status of the feature group.</summary>
    [JsonPropertyName("featureGroupStatus")]
    public string? FeatureGroupStatus { get; set; }
}

/// <summary>FeatureGroup is the Schema for the FeatureGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FeatureGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FeatureGroupSpec?>, IStatus<V1alpha1FeatureGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FeatureGroup";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "featuregroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FeatureGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// FeatureGroupSpec defines the desired state of FeatureGroup.
    /// 
    /// Amazon SageMaker Feature Store stores features in a collection called Feature
    /// Group. A Feature Group can be visualized as a table which has rows, with
    /// a unique identifier for each row where each column in the table is a feature.
    /// In principle, a Feature Group is composed of features and values per features.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1FeatureGroupSpec? Spec { get; set; }

    /// <summary>FeatureGroupStatus defines the observed state of FeatureGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1FeatureGroupStatus? Status { get; set; }
}