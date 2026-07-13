#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.upbound.io;
/// <summary>FeatureGroup is the Schema for the FeatureGroups API. Provides a SageMaker AI Feature Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FeatureGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2FeatureGroup>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FeatureGroupList";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "featuregroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FeatureGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2FeatureGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2FeatureGroup> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecDeletionPolicyEnum>))]
public enum V1beta2FeatureGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderFeatureDefinitionCollectionConfigVectorConfig
{
    [JsonPropertyName("dimension")]
    public double? Dimension { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderFeatureDefinitionCollectionConfig
{
    [JsonPropertyName("vectorConfig")]
    public V1beta2FeatureGroupSpecForProviderFeatureDefinitionCollectionConfigVectorConfig? VectorConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderFeatureDefinition
{
    [JsonPropertyName("collectionConfig")]
    public V1beta2FeatureGroupSpecForProviderFeatureDefinitionCollectionConfig? CollectionConfig { get; set; }

    [JsonPropertyName("collectionType")]
    public string? CollectionType { get; set; }

    /// <summary>The name of a feature. feature_name cannot be any of the following: is_deleted, write_time, api_invocation_time.</summary>
    [JsonPropertyName("featureName")]
    public string? FeatureName { get; set; }

    /// <summary>The value type of a feature. Valid values are Integral, Fractional, or String.</summary>
    [JsonPropertyName("featureType")]
    public string? FeatureType { get; set; }
}

/// <summary>The meta data of the Glue table that is autogenerated when an OfflineStore is created. See Data Catalog Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderOfflineStoreConfigDataCatalogConfig
{
    /// <summary>The name of the Glue table catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>The name of the Glue table database.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The name of the Glue table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>The Amazon Simple Storage (Amazon S3) location of OfflineStore. See S3 Storage Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderOfflineStoreConfigS3StorageConfig
{
    /// <summary>The AWS Key Management Service (KMS) key ID of the key used to encrypt any objects written into the OfflineStore S3 location.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The S3 path where offline records are written.</summary>
    [JsonPropertyName("resolvedOutputS3Uri")]
    public string? ResolvedOutputS3Uri { get; set; }

    /// <summary>The S3 URI, or location in Amazon S3, of OfflineStore.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>The Offline Feature Store Configuration. See Offline Store Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderOfflineStoreConfig
{
    /// <summary>The meta data of the Glue table that is autogenerated when an OfflineStore is created. See Data Catalog Config Below.</summary>
    [JsonPropertyName("dataCatalogConfig")]
    public V1beta2FeatureGroupSpecForProviderOfflineStoreConfigDataCatalogConfig? DataCatalogConfig { get; set; }

    /// <summary>Set to true to turn Online Store On.</summary>
    [JsonPropertyName("disableGlueTableCreation")]
    public bool? DisableGlueTableCreation { get; set; }

    /// <summary>The Amazon Simple Storage (Amazon S3) location of OfflineStore. See S3 Storage Config Below.</summary>
    [JsonPropertyName("s3StorageConfig")]
    public V1beta2FeatureGroupSpecForProviderOfflineStoreConfigS3StorageConfig? S3StorageConfig { get; set; }

    /// <summary>Format for the offline store table. Supported formats are Glue (Default) and Apache Iceberg (https://iceberg.apache.org/).</summary>
    [JsonPropertyName("tableFormat")]
    public string? TableFormat { get; set; }
}

/// <summary>Security config for at-rest encryption of your OnlineStore. See Security Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderOnlineStoreConfigSecurityConfig
{
    /// <summary>The AWS Key Management Service (KMS) key ID of the key used to encrypt any objects written into the OfflineStore S3 location.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Time to live duration, where the record is hard deleted after the expiration time is reached; ExpiresAt = EventTime + TtlDuration.. See TTl Duration Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderOnlineStoreConfigTtlDuration
{
    /// <summary>TtlDuration time unit. Valid values are Seconds, Minutes, Hours, Days, or Weeks.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>TtlDuration time value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>The Online Feature Store Configuration. See Online Store Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderOnlineStoreConfig
{
    /// <summary>Set to true to disable the automatic creation of an AWS Glue table when configuring an OfflineStore.</summary>
    [JsonPropertyName("enableOnlineStore")]
    public bool? EnableOnlineStore { get; set; }

    /// <summary>Security config for at-rest encryption of your OnlineStore. See Security Config Below.</summary>
    [JsonPropertyName("securityConfig")]
    public V1beta2FeatureGroupSpecForProviderOnlineStoreConfigSecurityConfig? SecurityConfig { get; set; }

    /// <summary>Option for different tiers of low latency storage for real-time data retrieval. Valid values are Standard, or InMemory.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Time to live duration, where the record is hard deleted after the expiration time is reached; ExpiresAt = EventTime + TtlDuration.. See TTl Duration Below.</summary>
    [JsonPropertyName("ttlDuration")]
    public V1beta2FeatureGroupSpecForProviderOnlineStoreConfigTtlDuration? TtlDuration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecForProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2FeatureGroupSpecForProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecForProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta2FeatureGroupSpecForProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FeatureGroupSpecForProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FeatureGroupSpecForProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FeatureGroupSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecForProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2FeatureGroupSpecForProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2FeatureGroupSpecForProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FeatureGroupSpecForProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FeatureGroupSpecForProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderRoleArnSelector
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
    public V1beta2FeatureGroupSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProviderThroughputConfig
{
    [JsonPropertyName("provisionedReadCapacityUnits")]
    public double? ProvisionedReadCapacityUnits { get; set; }

    [JsonPropertyName("provisionedWriteCapacityUnits")]
    public double? ProvisionedWriteCapacityUnits { get; set; }

    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecForProvider
{
    /// <summary>A free-form description of a Feature Group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the feature that stores the EventTime of a Record in a Feature Group.</summary>
    [JsonPropertyName("eventTimeFeatureName")]
    public string? EventTimeFeatureName { get; set; }

    /// <summary>A list of Feature names and types. See Feature Definition Below.</summary>
    [JsonPropertyName("featureDefinition")]
    public IList<V1beta2FeatureGroupSpecForProviderFeatureDefinition>? FeatureDefinition { get; set; }

    /// <summary>The Offline Feature Store Configuration. See Offline Store Config Below.</summary>
    [JsonPropertyName("offlineStoreConfig")]
    public V1beta2FeatureGroupSpecForProviderOfflineStoreConfig? OfflineStoreConfig { get; set; }

    /// <summary>The Online Feature Store Configuration. See Online Store Config Below.</summary>
    [JsonPropertyName("onlineStoreConfig")]
    public V1beta2FeatureGroupSpecForProviderOnlineStoreConfig? OnlineStoreConfig { get; set; }

    /// <summary>The name of the Feature whose value uniquely identifies a Record defined in the Feature Store. Only the latest record per identifier value will be stored in the Online Store.</summary>
    [JsonPropertyName("recordIdentifierFeatureName")]
    public string? RecordIdentifierFeatureName { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM execution role used to persist data into the Offline Store if an offline_store_config is provided.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2FeatureGroupSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2FeatureGroupSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("throughputConfig")]
    public V1beta2FeatureGroupSpecForProviderThroughputConfig? ThroughputConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderFeatureDefinitionCollectionConfigVectorConfig
{
    [JsonPropertyName("dimension")]
    public double? Dimension { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderFeatureDefinitionCollectionConfig
{
    [JsonPropertyName("vectorConfig")]
    public V1beta2FeatureGroupSpecInitProviderFeatureDefinitionCollectionConfigVectorConfig? VectorConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderFeatureDefinition
{
    [JsonPropertyName("collectionConfig")]
    public V1beta2FeatureGroupSpecInitProviderFeatureDefinitionCollectionConfig? CollectionConfig { get; set; }

    [JsonPropertyName("collectionType")]
    public string? CollectionType { get; set; }

    /// <summary>The name of a feature. feature_name cannot be any of the following: is_deleted, write_time, api_invocation_time.</summary>
    [JsonPropertyName("featureName")]
    public string? FeatureName { get; set; }

    /// <summary>The value type of a feature. Valid values are Integral, Fractional, or String.</summary>
    [JsonPropertyName("featureType")]
    public string? FeatureType { get; set; }
}

/// <summary>The meta data of the Glue table that is autogenerated when an OfflineStore is created. See Data Catalog Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderOfflineStoreConfigDataCatalogConfig
{
    /// <summary>The name of the Glue table catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>The name of the Glue table database.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The name of the Glue table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>The Amazon Simple Storage (Amazon S3) location of OfflineStore. See S3 Storage Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderOfflineStoreConfigS3StorageConfig
{
    /// <summary>The AWS Key Management Service (KMS) key ID of the key used to encrypt any objects written into the OfflineStore S3 location.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The S3 path where offline records are written.</summary>
    [JsonPropertyName("resolvedOutputS3Uri")]
    public string? ResolvedOutputS3Uri { get; set; }

    /// <summary>The S3 URI, or location in Amazon S3, of OfflineStore.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>The Offline Feature Store Configuration. See Offline Store Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderOfflineStoreConfig
{
    /// <summary>The meta data of the Glue table that is autogenerated when an OfflineStore is created. See Data Catalog Config Below.</summary>
    [JsonPropertyName("dataCatalogConfig")]
    public V1beta2FeatureGroupSpecInitProviderOfflineStoreConfigDataCatalogConfig? DataCatalogConfig { get; set; }

    /// <summary>Set to true to turn Online Store On.</summary>
    [JsonPropertyName("disableGlueTableCreation")]
    public bool? DisableGlueTableCreation { get; set; }

    /// <summary>The Amazon Simple Storage (Amazon S3) location of OfflineStore. See S3 Storage Config Below.</summary>
    [JsonPropertyName("s3StorageConfig")]
    public V1beta2FeatureGroupSpecInitProviderOfflineStoreConfigS3StorageConfig? S3StorageConfig { get; set; }

    /// <summary>Format for the offline store table. Supported formats are Glue (Default) and Apache Iceberg (https://iceberg.apache.org/).</summary>
    [JsonPropertyName("tableFormat")]
    public string? TableFormat { get; set; }
}

/// <summary>Security config for at-rest encryption of your OnlineStore. See Security Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderOnlineStoreConfigSecurityConfig
{
    /// <summary>The AWS Key Management Service (KMS) key ID of the key used to encrypt any objects written into the OfflineStore S3 location.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Time to live duration, where the record is hard deleted after the expiration time is reached; ExpiresAt = EventTime + TtlDuration.. See TTl Duration Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderOnlineStoreConfigTtlDuration
{
    /// <summary>TtlDuration time unit. Valid values are Seconds, Minutes, Hours, Days, or Weeks.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>TtlDuration time value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>The Online Feature Store Configuration. See Online Store Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderOnlineStoreConfig
{
    /// <summary>Set to true to disable the automatic creation of an AWS Glue table when configuring an OfflineStore.</summary>
    [JsonPropertyName("enableOnlineStore")]
    public bool? EnableOnlineStore { get; set; }

    /// <summary>Security config for at-rest encryption of your OnlineStore. See Security Config Below.</summary>
    [JsonPropertyName("securityConfig")]
    public V1beta2FeatureGroupSpecInitProviderOnlineStoreConfigSecurityConfig? SecurityConfig { get; set; }

    /// <summary>Option for different tiers of low latency storage for real-time data retrieval. Valid values are Standard, or InMemory.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Time to live duration, where the record is hard deleted after the expiration time is reached; ExpiresAt = EventTime + TtlDuration.. See TTl Duration Below.</summary>
    [JsonPropertyName("ttlDuration")]
    public V1beta2FeatureGroupSpecInitProviderOnlineStoreConfigTtlDuration? TtlDuration { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecInitProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2FeatureGroupSpecInitProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecInitProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta2FeatureGroupSpecInitProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FeatureGroupSpecInitProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FeatureGroupSpecInitProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FeatureGroupSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecInitProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2FeatureGroupSpecInitProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2FeatureGroupSpecInitProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FeatureGroupSpecInitProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FeatureGroupSpecInitProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderRoleArnSelector
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
    public V1beta2FeatureGroupSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecInitProviderThroughputConfig
{
    [JsonPropertyName("provisionedReadCapacityUnits")]
    public double? ProvisionedReadCapacityUnits { get; set; }

    [JsonPropertyName("provisionedWriteCapacityUnits")]
    public double? ProvisionedWriteCapacityUnits { get; set; }

    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }
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
public partial class V1beta2FeatureGroupSpecInitProvider
{
    /// <summary>A free-form description of a Feature Group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the feature that stores the EventTime of a Record in a Feature Group.</summary>
    [JsonPropertyName("eventTimeFeatureName")]
    public string? EventTimeFeatureName { get; set; }

    /// <summary>A list of Feature names and types. See Feature Definition Below.</summary>
    [JsonPropertyName("featureDefinition")]
    public IList<V1beta2FeatureGroupSpecInitProviderFeatureDefinition>? FeatureDefinition { get; set; }

    /// <summary>The Offline Feature Store Configuration. See Offline Store Config Below.</summary>
    [JsonPropertyName("offlineStoreConfig")]
    public V1beta2FeatureGroupSpecInitProviderOfflineStoreConfig? OfflineStoreConfig { get; set; }

    /// <summary>The Online Feature Store Configuration. See Online Store Config Below.</summary>
    [JsonPropertyName("onlineStoreConfig")]
    public V1beta2FeatureGroupSpecInitProviderOnlineStoreConfig? OnlineStoreConfig { get; set; }

    /// <summary>The name of the Feature whose value uniquely identifies a Record defined in the Feature Store. Only the latest record per identifier value will be stored in the Online Store.</summary>
    [JsonPropertyName("recordIdentifierFeatureName")]
    public string? RecordIdentifierFeatureName { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM execution role used to persist data into the Offline Store if an offline_store_config is provided.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2FeatureGroupSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2FeatureGroupSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("throughputConfig")]
    public V1beta2FeatureGroupSpecInitProviderThroughputConfig? ThroughputConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecManagementPoliciesEnum>))]
public enum V1beta2FeatureGroupSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FeatureGroupSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FeatureGroupSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FeatureGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FeatureGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FeatureGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FeatureGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FeatureGroupSpec defines the desired state of FeatureGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupSpec
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
    public V1beta2FeatureGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FeatureGroupSpecForProvider ForProvider { get; set; }

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
    public V1beta2FeatureGroupSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FeatureGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FeatureGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FeatureGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusAtProviderFeatureDefinitionCollectionConfigVectorConfig
{
    [JsonPropertyName("dimension")]
    public double? Dimension { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusAtProviderFeatureDefinitionCollectionConfig
{
    [JsonPropertyName("vectorConfig")]
    public V1beta2FeatureGroupStatusAtProviderFeatureDefinitionCollectionConfigVectorConfig? VectorConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusAtProviderFeatureDefinition
{
    [JsonPropertyName("collectionConfig")]
    public V1beta2FeatureGroupStatusAtProviderFeatureDefinitionCollectionConfig? CollectionConfig { get; set; }

    [JsonPropertyName("collectionType")]
    public string? CollectionType { get; set; }

    /// <summary>The name of a feature. feature_name cannot be any of the following: is_deleted, write_time, api_invocation_time.</summary>
    [JsonPropertyName("featureName")]
    public string? FeatureName { get; set; }

    /// <summary>The value type of a feature. Valid values are Integral, Fractional, or String.</summary>
    [JsonPropertyName("featureType")]
    public string? FeatureType { get; set; }
}

/// <summary>The meta data of the Glue table that is autogenerated when an OfflineStore is created. See Data Catalog Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusAtProviderOfflineStoreConfigDataCatalogConfig
{
    /// <summary>The name of the Glue table catalog.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>The name of the Glue table database.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The name of the Glue table.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>The Amazon Simple Storage (Amazon S3) location of OfflineStore. See S3 Storage Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusAtProviderOfflineStoreConfigS3StorageConfig
{
    /// <summary>The AWS Key Management Service (KMS) key ID of the key used to encrypt any objects written into the OfflineStore S3 location.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The S3 path where offline records are written.</summary>
    [JsonPropertyName("resolvedOutputS3Uri")]
    public string? ResolvedOutputS3Uri { get; set; }

    /// <summary>The S3 URI, or location in Amazon S3, of OfflineStore.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>The Offline Feature Store Configuration. See Offline Store Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusAtProviderOfflineStoreConfig
{
    /// <summary>The meta data of the Glue table that is autogenerated when an OfflineStore is created. See Data Catalog Config Below.</summary>
    [JsonPropertyName("dataCatalogConfig")]
    public V1beta2FeatureGroupStatusAtProviderOfflineStoreConfigDataCatalogConfig? DataCatalogConfig { get; set; }

    /// <summary>Set to true to turn Online Store On.</summary>
    [JsonPropertyName("disableGlueTableCreation")]
    public bool? DisableGlueTableCreation { get; set; }

    /// <summary>The Amazon Simple Storage (Amazon S3) location of OfflineStore. See S3 Storage Config Below.</summary>
    [JsonPropertyName("s3StorageConfig")]
    public V1beta2FeatureGroupStatusAtProviderOfflineStoreConfigS3StorageConfig? S3StorageConfig { get; set; }

    /// <summary>Format for the offline store table. Supported formats are Glue (Default) and Apache Iceberg (https://iceberg.apache.org/).</summary>
    [JsonPropertyName("tableFormat")]
    public string? TableFormat { get; set; }
}

/// <summary>Security config for at-rest encryption of your OnlineStore. See Security Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusAtProviderOnlineStoreConfigSecurityConfig
{
    /// <summary>The AWS Key Management Service (KMS) key ID of the key used to encrypt any objects written into the OfflineStore S3 location.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Time to live duration, where the record is hard deleted after the expiration time is reached; ExpiresAt = EventTime + TtlDuration.. See TTl Duration Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusAtProviderOnlineStoreConfigTtlDuration
{
    /// <summary>TtlDuration time unit. Valid values are Seconds, Minutes, Hours, Days, or Weeks.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>TtlDuration time value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>The Online Feature Store Configuration. See Online Store Config Below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusAtProviderOnlineStoreConfig
{
    /// <summary>Set to true to disable the automatic creation of an AWS Glue table when configuring an OfflineStore.</summary>
    [JsonPropertyName("enableOnlineStore")]
    public bool? EnableOnlineStore { get; set; }

    /// <summary>Security config for at-rest encryption of your OnlineStore. See Security Config Below.</summary>
    [JsonPropertyName("securityConfig")]
    public V1beta2FeatureGroupStatusAtProviderOnlineStoreConfigSecurityConfig? SecurityConfig { get; set; }

    /// <summary>Option for different tiers of low latency storage for real-time data retrieval. Valid values are Standard, or InMemory.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>Time to live duration, where the record is hard deleted after the expiration time is reached; ExpiresAt = EventTime + TtlDuration.. See TTl Duration Below.</summary>
    [JsonPropertyName("ttlDuration")]
    public V1beta2FeatureGroupStatusAtProviderOnlineStoreConfigTtlDuration? TtlDuration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusAtProviderThroughputConfig
{
    [JsonPropertyName("provisionedReadCapacityUnits")]
    public double? ProvisionedReadCapacityUnits { get; set; }

    [JsonPropertyName("provisionedWriteCapacityUnits")]
    public double? ProvisionedWriteCapacityUnits { get; set; }

    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusAtProvider
{
    /// <summary>The Amazon Resource Name (ARN) assigned by AWS to this feature_group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>A free-form description of a Feature Group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the feature that stores the EventTime of a Record in a Feature Group.</summary>
    [JsonPropertyName("eventTimeFeatureName")]
    public string? EventTimeFeatureName { get; set; }

    /// <summary>A list of Feature names and types. See Feature Definition Below.</summary>
    [JsonPropertyName("featureDefinition")]
    public IList<V1beta2FeatureGroupStatusAtProviderFeatureDefinition>? FeatureDefinition { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Offline Feature Store Configuration. See Offline Store Config Below.</summary>
    [JsonPropertyName("offlineStoreConfig")]
    public V1beta2FeatureGroupStatusAtProviderOfflineStoreConfig? OfflineStoreConfig { get; set; }

    /// <summary>The Online Feature Store Configuration. See Online Store Config Below.</summary>
    [JsonPropertyName("onlineStoreConfig")]
    public V1beta2FeatureGroupStatusAtProviderOnlineStoreConfig? OnlineStoreConfig { get; set; }

    /// <summary>The name of the Feature whose value uniquely identifies a Record defined in the Feature Store. Only the latest record per identifier value will be stored in the Online Store.</summary>
    [JsonPropertyName("recordIdentifierFeatureName")]
    public string? RecordIdentifierFeatureName { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the IAM execution role used to persist data into the Offline Store if an offline_store_config is provided.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    [JsonPropertyName("throughputConfig")]
    public V1beta2FeatureGroupStatusAtProviderThroughputConfig? ThroughputConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatusConditions
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

/// <summary>FeatureGroupStatus defines the observed state of FeatureGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FeatureGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FeatureGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FeatureGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FeatureGroup is the Schema for the FeatureGroups API. Provides a SageMaker AI Feature Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FeatureGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FeatureGroupSpec>, IStatus<V1beta2FeatureGroupStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FeatureGroup";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "featuregroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FeatureGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FeatureGroupSpec defines the desired state of FeatureGroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FeatureGroupSpec Spec { get; set; }

    /// <summary>FeatureGroupStatus defines the observed state of FeatureGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta2FeatureGroupStatus? Status { get; set; }
}