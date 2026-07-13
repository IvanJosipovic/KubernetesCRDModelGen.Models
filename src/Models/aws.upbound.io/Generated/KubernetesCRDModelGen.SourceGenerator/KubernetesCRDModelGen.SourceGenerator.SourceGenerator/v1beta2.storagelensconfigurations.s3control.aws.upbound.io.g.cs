#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.s3control.aws.upbound.io;
/// <summary>StorageLensConfiguration is the Schema for the StorageLensConfigurations API. Provides a resource to manage an S3 Storage Lens configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2StorageLensConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2StorageLensConfiguration>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "StorageLensConfigurationList";
    public const string KubeGroup = "s3control.aws.upbound.io";
    public const string KubePluralName = "storagelensconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "s3control.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageLensConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2StorageLensConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2StorageLensConfiguration> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecDeletionPolicyEnum>))]
public enum V1beta2StorageLensConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelActivityMetrics
{
    /// <summary>Whether the activity metrics are enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Selection criteria. See Selection Criteria below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria
{
    /// <summary>The delimiter of the selection criteria being used.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>The max depth of the selection criteria.</summary>
    [JsonPropertyName("maxDepth")]
    public double? MaxDepth { get; set; }

    /// <summary>The minimum number of storage bytes percentage whose metrics will be selected.</summary>
    [JsonPropertyName("minStorageBytesPercentage")]
    public double? MinStorageBytesPercentage { get; set; }
}

/// <summary>level storage metrics for S3 Storage Lens. See Prefix Level Storage Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Selection criteria. See Selection Criteria below for more details.</summary>
    [JsonPropertyName("selectionCriteria")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria? SelectionCriteria { get; set; }
}

/// <summary>level metrics for S3 Storage Lens. See Prefix Level below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel
{
    /// <summary>level storage metrics for S3 Storage Lens. See Prefix Level Storage Metrics below for more details.</summary>
    [JsonPropertyName("storageMetrics")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics? StorageMetrics { get; set; }
}

/// <summary>level configuration. See Bucket Level below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics? DetailedStatusCodeMetrics { get; set; }

    /// <summary>level metrics for S3 Storage Lens. See Prefix Level below for more details.</summary>
    [JsonPropertyName("prefixLevel")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel? PrefixLevel { get; set; }
}

/// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>level configurations of the S3 Storage Lens configuration. See Account Level below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelActivityMetrics? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>level configuration. See Bucket Level below for more details.</summary>
    [JsonPropertyName("bucketLevel")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelBucketLevel? BucketLevel { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics? DetailedStatusCodeMetrics { get; set; }
}

/// <summary>The Amazon Web Services organization for the S3 Storage Lens configuration. See AWS Org below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAwsOrg
{
    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Amazon CloudWatch publishing for S3 Storage Lens metrics. See Cloud Watch Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportCloudWatchMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolutionEnum>))]
public enum V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolveEnum>))]
public enum V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolveEnum>))]
public enum V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelector
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
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>KMS encryption. See SSE KMS below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms
{
    /// <summary>KMS key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3
{
}

/// <summary>Encryption of the metrics exports in this bucket. See Encryption below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption
{
    /// <summary>KMS encryption. See SSE KMS below for more details.</summary>
    [JsonPropertyName("sseKms")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms? SseKms { get; set; }

    /// <summary>S3 encryption. An empty configuration block {} should be used.</summary>
    [JsonPropertyName("sseS3")]
    public IList<V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3>? SseS3 { get; set; }
}

/// <summary>The bucket where the S3 Storage Lens metrics export will be located. See S3 Bucket Destination below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestination
{
    /// <summary>The account ID of the owner of the S3 Storage Lens metrics export bucket.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelector? ArnSelector { get; set; }

    /// <summary>Encryption of the metrics exports in this bucket. See Encryption below for more details.</summary>
    [JsonPropertyName("encryption")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption? Encryption { get; set; }

    /// <summary>The export format. Valid values: CSV, Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The schema version of the export file. Valid values: V_1.</summary>
    [JsonPropertyName("outputSchemaVersion")]
    public string? OutputSchemaVersion { get; set; }

    /// <summary>The prefix of the destination bucket where the metrics export will be delivered.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Properties of S3 Storage Lens metrics export including the destination, schema and format. See Data Export below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExport
{
    /// <summary>Amazon CloudWatch publishing for S3 Storage Lens metrics. See Cloud Watch Metrics below for more details.</summary>
    [JsonPropertyName("cloudWatchMetrics")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportCloudWatchMetrics? CloudWatchMetrics { get; set; }

    /// <summary>The bucket where the S3 Storage Lens metrics export will be located. See S3 Bucket Destination below for more details.</summary>
    [JsonPropertyName("s3BucketDestination")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExportS3BucketDestination? S3BucketDestination { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolutionEnum>))]
public enum V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolveEnum>))]
public enum V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolutionEnum>))]
public enum V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolveEnum>))]
public enum V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Bucket in s3 to populate buckets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelector
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
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelectorPolicy? Policy { get; set; }
}

/// <summary>What is excluded in this configuration. Conflicts with include. See Exclude below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>References to Bucket in s3 to populate buckets.</summary>
    [JsonPropertyName("bucketsRefs")]
    public IList<V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsRefs>? BucketsRefs { get; set; }

    /// <summary>Selector for a list of Bucket in s3 to populate buckets.</summary>
    [JsonPropertyName("bucketsSelector")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExcludeBucketsSelector? BucketsSelector { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary>What is included in this configuration. Conflicts with exclude. See Include below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationInclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary>The S3 Storage Lens configuration. See Storage Lens Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProviderStorageLensConfiguration
{
    /// <summary>level configurations of the S3 Storage Lens configuration. See Account Level below for more details.</summary>
    [JsonPropertyName("accountLevel")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAccountLevel? AccountLevel { get; set; }

    /// <summary>The Amazon Web Services organization for the S3 Storage Lens configuration. See AWS Org below for more details.</summary>
    [JsonPropertyName("awsOrg")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationAwsOrg? AwsOrg { get; set; }

    /// <summary>Properties of S3 Storage Lens metrics export including the destination, schema and format. See Data Export below for more details.</summary>
    [JsonPropertyName("dataExport")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationDataExport? DataExport { get; set; }

    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>What is excluded in this configuration. Conflicts with include. See Exclude below for more details.</summary>
    [JsonPropertyName("exclude")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationExclude? Exclude { get; set; }

    /// <summary>What is included in this configuration. Conflicts with exclude. See Include below for more details.</summary>
    [JsonPropertyName("include")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfigurationInclude? Include { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecForProvider
{
    /// <summary>The AWS account ID for the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The ID of the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The S3 Storage Lens configuration. See Storage Lens Configuration below for more details.</summary>
    [JsonPropertyName("storageLensConfiguration")]
    public V1beta2StorageLensConfigurationSpecForProviderStorageLensConfiguration? StorageLensConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelActivityMetrics
{
    /// <summary>Whether the activity metrics are enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Selection criteria. See Selection Criteria below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria
{
    /// <summary>The delimiter of the selection criteria being used.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>The max depth of the selection criteria.</summary>
    [JsonPropertyName("maxDepth")]
    public double? MaxDepth { get; set; }

    /// <summary>The minimum number of storage bytes percentage whose metrics will be selected.</summary>
    [JsonPropertyName("minStorageBytesPercentage")]
    public double? MinStorageBytesPercentage { get; set; }
}

/// <summary>level storage metrics for S3 Storage Lens. See Prefix Level Storage Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Selection criteria. See Selection Criteria below for more details.</summary>
    [JsonPropertyName("selectionCriteria")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria? SelectionCriteria { get; set; }
}

/// <summary>level metrics for S3 Storage Lens. See Prefix Level below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel
{
    /// <summary>level storage metrics for S3 Storage Lens. See Prefix Level Storage Metrics below for more details.</summary>
    [JsonPropertyName("storageMetrics")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics? StorageMetrics { get; set; }
}

/// <summary>level configuration. See Bucket Level below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics? DetailedStatusCodeMetrics { get; set; }

    /// <summary>level metrics for S3 Storage Lens. See Prefix Level below for more details.</summary>
    [JsonPropertyName("prefixLevel")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel? PrefixLevel { get; set; }
}

/// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>level configurations of the S3 Storage Lens configuration. See Account Level below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelActivityMetrics? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>level configuration. See Bucket Level below for more details.</summary>
    [JsonPropertyName("bucketLevel")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelBucketLevel? BucketLevel { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics? DetailedStatusCodeMetrics { get; set; }
}

/// <summary>The Amazon Web Services organization for the S3 Storage Lens configuration. See AWS Org below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAwsOrg
{
    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Amazon CloudWatch publishing for S3 Storage Lens metrics. See Cloud Watch Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportCloudWatchMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolutionEnum>))]
public enum V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolveEnum>))]
public enum V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in s3 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolveEnum>))]
public enum V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in s3 to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelector
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
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>KMS encryption. See SSE KMS below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms
{
    /// <summary>KMS key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3
{
}

/// <summary>Encryption of the metrics exports in this bucket. See Encryption below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption
{
    /// <summary>KMS encryption. See SSE KMS below for more details.</summary>
    [JsonPropertyName("sseKms")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms? SseKms { get; set; }

    /// <summary>S3 encryption. An empty configuration block {} should be used.</summary>
    [JsonPropertyName("sseS3")]
    public IList<V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3>? SseS3 { get; set; }
}

/// <summary>The bucket where the S3 Storage Lens metrics export will be located. See S3 Bucket Destination below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestination
{
    /// <summary>The account ID of the owner of the S3 Storage Lens metrics export bucket.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Bucket in s3 to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Bucket in s3 to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationArnSelector? ArnSelector { get; set; }

    /// <summary>Encryption of the metrics exports in this bucket. See Encryption below for more details.</summary>
    [JsonPropertyName("encryption")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption? Encryption { get; set; }

    /// <summary>The export format. Valid values: CSV, Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The schema version of the export file. Valid values: V_1.</summary>
    [JsonPropertyName("outputSchemaVersion")]
    public string? OutputSchemaVersion { get; set; }

    /// <summary>The prefix of the destination bucket where the metrics export will be delivered.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Properties of S3 Storage Lens metrics export including the destination, schema and format. See Data Export below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExport
{
    /// <summary>Amazon CloudWatch publishing for S3 Storage Lens metrics. See Cloud Watch Metrics below for more details.</summary>
    [JsonPropertyName("cloudWatchMetrics")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportCloudWatchMetrics? CloudWatchMetrics { get; set; }

    /// <summary>The bucket where the S3 Storage Lens metrics export will be located. See S3 Bucket Destination below for more details.</summary>
    [JsonPropertyName("s3BucketDestination")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExportS3BucketDestination? S3BucketDestination { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolutionEnum>))]
public enum V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolveEnum>))]
public enum V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolutionEnum>))]
public enum V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolveEnum>))]
public enum V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Bucket in s3 to populate buckets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelector
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
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelectorPolicy? Policy { get; set; }
}

/// <summary>What is excluded in this configuration. Conflicts with include. See Exclude below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>References to Bucket in s3 to populate buckets.</summary>
    [JsonPropertyName("bucketsRefs")]
    public IList<V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsRefs>? BucketsRefs { get; set; }

    /// <summary>Selector for a list of Bucket in s3 to populate buckets.</summary>
    [JsonPropertyName("bucketsSelector")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExcludeBucketsSelector? BucketsSelector { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary>What is included in this configuration. Conflicts with exclude. See Include below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationInclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary>The S3 Storage Lens configuration. See Storage Lens Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfiguration
{
    /// <summary>level configurations of the S3 Storage Lens configuration. See Account Level below for more details.</summary>
    [JsonPropertyName("accountLevel")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAccountLevel? AccountLevel { get; set; }

    /// <summary>The Amazon Web Services organization for the S3 Storage Lens configuration. See AWS Org below for more details.</summary>
    [JsonPropertyName("awsOrg")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationAwsOrg? AwsOrg { get; set; }

    /// <summary>Properties of S3 Storage Lens metrics export including the destination, schema and format. See Data Export below for more details.</summary>
    [JsonPropertyName("dataExport")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationDataExport? DataExport { get; set; }

    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>What is excluded in this configuration. Conflicts with include. See Exclude below for more details.</summary>
    [JsonPropertyName("exclude")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationExclude? Exclude { get; set; }

    /// <summary>What is included in this configuration. Conflicts with exclude. See Include below for more details.</summary>
    [JsonPropertyName("include")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfigurationInclude? Include { get; set; }
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
public partial class V1beta2StorageLensConfigurationSpecInitProvider
{
    /// <summary>The AWS account ID for the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The ID of the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    /// <summary>The S3 Storage Lens configuration. See Storage Lens Configuration below for more details.</summary>
    [JsonPropertyName("storageLensConfiguration")]
    public V1beta2StorageLensConfigurationSpecInitProviderStorageLensConfiguration? StorageLensConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecManagementPoliciesEnum>))]
public enum V1beta2StorageLensConfigurationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2StorageLensConfigurationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2StorageLensConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2StorageLensConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2StorageLensConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2StorageLensConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2StorageLensConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>StorageLensConfigurationSpec defines the desired state of StorageLensConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationSpec
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
    public V1beta2StorageLensConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2StorageLensConfigurationSpecForProvider ForProvider { get; set; }

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
    public V1beta2StorageLensConfigurationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2StorageLensConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2StorageLensConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2StorageLensConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelActivityMetrics
{
    /// <summary>Whether the activity metrics are enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Selection criteria. See Selection Criteria below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria
{
    /// <summary>The delimiter of the selection criteria being used.</summary>
    [JsonPropertyName("delimiter")]
    public string? Delimiter { get; set; }

    /// <summary>The max depth of the selection criteria.</summary>
    [JsonPropertyName("maxDepth")]
    public double? MaxDepth { get; set; }

    /// <summary>The minimum number of storage bytes percentage whose metrics will be selected.</summary>
    [JsonPropertyName("minStorageBytesPercentage")]
    public double? MinStorageBytesPercentage { get; set; }
}

/// <summary>level storage metrics for S3 Storage Lens. See Prefix Level Storage Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Selection criteria. See Selection Criteria below for more details.</summary>
    [JsonPropertyName("selectionCriteria")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetricsSelectionCriteria? SelectionCriteria { get; set; }
}

/// <summary>level metrics for S3 Storage Lens. See Prefix Level below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel
{
    /// <summary>level storage metrics for S3 Storage Lens. See Prefix Level Storage Metrics below for more details.</summary>
    [JsonPropertyName("storageMetrics")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevelStorageMetrics? StorageMetrics { get; set; }
}

/// <summary>level configuration. See Bucket Level below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelActivityMetrics? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedCostOptimizationMetrics? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelAdvancedDataProtectionMetrics? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelDetailedStatusCodeMetrics? DetailedStatusCodeMetrics { get; set; }

    /// <summary>level metrics for S3 Storage Lens. See Prefix Level below for more details.</summary>
    [JsonPropertyName("prefixLevel")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevelPrefixLevel? PrefixLevel { get; set; }
}

/// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>level configurations of the S3 Storage Lens configuration. See Account Level below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevel
{
    /// <summary>S3 Storage Lens activity metrics. See Activity Metrics below for more details.</summary>
    [JsonPropertyName("activityMetrics")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelActivityMetrics? ActivityMetrics { get; set; }

    /// <summary>optimization metrics for S3 Storage Lens. See Advanced Cost-Optimization Metrics below for more details.</summary>
    [JsonPropertyName("advancedCostOptimizationMetrics")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelAdvancedCostOptimizationMetrics? AdvancedCostOptimizationMetrics { get; set; }

    /// <summary>protection metrics for S3 Storage Lens. See Advanced Data-Protection Metrics below for more details.</summary>
    [JsonPropertyName("advancedDataProtectionMetrics")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelAdvancedDataProtectionMetrics? AdvancedDataProtectionMetrics { get; set; }

    /// <summary>level configuration. See Bucket Level below for more details.</summary>
    [JsonPropertyName("bucketLevel")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelBucketLevel? BucketLevel { get; set; }

    /// <summary>Detailed status code metrics for S3 Storage Lens. See Detailed Status Code Metrics below for more details.</summary>
    [JsonPropertyName("detailedStatusCodeMetrics")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevelDetailedStatusCodeMetrics? DetailedStatusCodeMetrics { get; set; }
}

/// <summary>The Amazon Web Services organization for the S3 Storage Lens configuration. See AWS Org below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAwsOrg
{
    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

/// <summary>Amazon CloudWatch publishing for S3 Storage Lens metrics. See Cloud Watch Metrics below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportCloudWatchMetrics
{
    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>KMS encryption. See SSE KMS below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms
{
    /// <summary>KMS key ARN.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3
{
}

/// <summary>Encryption of the metrics exports in this bucket. See Encryption below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption
{
    /// <summary>KMS encryption. See SSE KMS below for more details.</summary>
    [JsonPropertyName("sseKms")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseKms? SseKms { get; set; }

    /// <summary>S3 encryption. An empty configuration block {} should be used.</summary>
    [JsonPropertyName("sseS3")]
    public IList<V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryptionSseS3>? SseS3 { get; set; }
}

/// <summary>The bucket where the S3 Storage Lens metrics export will be located. See S3 Bucket Destination below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestination
{
    /// <summary>The account ID of the owner of the S3 Storage Lens metrics export bucket.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the bucket.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Encryption of the metrics exports in this bucket. See Encryption below for more details.</summary>
    [JsonPropertyName("encryption")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestinationEncryption? Encryption { get; set; }

    /// <summary>The export format. Valid values: CSV, Parquet.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The schema version of the export file. Valid values: V_1.</summary>
    [JsonPropertyName("outputSchemaVersion")]
    public string? OutputSchemaVersion { get; set; }

    /// <summary>The prefix of the destination bucket where the metrics export will be delivered.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
}

/// <summary>Properties of S3 Storage Lens metrics export including the destination, schema and format. See Data Export below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExport
{
    /// <summary>Amazon CloudWatch publishing for S3 Storage Lens metrics. See Cloud Watch Metrics below for more details.</summary>
    [JsonPropertyName("cloudWatchMetrics")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportCloudWatchMetrics? CloudWatchMetrics { get; set; }

    /// <summary>The bucket where the S3 Storage Lens metrics export will be located. See S3 Bucket Destination below for more details.</summary>
    [JsonPropertyName("s3BucketDestination")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExportS3BucketDestination? S3BucketDestination { get; set; }
}

/// <summary>What is excluded in this configuration. Conflicts with include. See Exclude below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationExclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary>What is included in this configuration. Conflicts with exclude. See Include below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationInclude
{
    /// <summary>List of S3 bucket ARNs.</summary>
    [JsonPropertyName("buckets")]
    public IList<string>? Buckets { get; set; }

    /// <summary>List of AWS Regions.</summary>
    [JsonPropertyName("regions")]
    public IList<string>? Regions { get; set; }
}

/// <summary>The S3 Storage Lens configuration. See Storage Lens Configuration below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfiguration
{
    /// <summary>level configurations of the S3 Storage Lens configuration. See Account Level below for more details.</summary>
    [JsonPropertyName("accountLevel")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAccountLevel? AccountLevel { get; set; }

    /// <summary>The Amazon Web Services organization for the S3 Storage Lens configuration. See AWS Org below for more details.</summary>
    [JsonPropertyName("awsOrg")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationAwsOrg? AwsOrg { get; set; }

    /// <summary>Properties of S3 Storage Lens metrics export including the destination, schema and format. See Data Export below for more details.</summary>
    [JsonPropertyName("dataExport")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationDataExport? DataExport { get; set; }

    /// <summary>Whether the S3 Storage Lens configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>What is excluded in this configuration. Conflicts with include. See Exclude below for more details.</summary>
    [JsonPropertyName("exclude")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationExclude? Exclude { get; set; }

    /// <summary>What is included in this configuration. Conflicts with exclude. See Include below for more details.</summary>
    [JsonPropertyName("include")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfigurationInclude? Include { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusAtProvider
{
    /// <summary>The AWS account ID for the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The ID of the S3 Storage Lens configuration.</summary>
    [JsonPropertyName("configId")]
    public string? ConfigId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The S3 Storage Lens configuration. See Storage Lens Configuration below for more details.</summary>
    [JsonPropertyName("storageLensConfiguration")]
    public V1beta2StorageLensConfigurationStatusAtProviderStorageLensConfiguration? StorageLensConfiguration { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatusConditions
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

/// <summary>StorageLensConfigurationStatus defines the observed state of StorageLensConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2StorageLensConfigurationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2StorageLensConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2StorageLensConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>StorageLensConfiguration is the Schema for the StorageLensConfigurations API. Provides a resource to manage an S3 Storage Lens configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2StorageLensConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2StorageLensConfigurationSpec>, IStatus<V1beta2StorageLensConfigurationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "StorageLensConfiguration";
    public const string KubeGroup = "s3control.aws.upbound.io";
    public const string KubePluralName = "storagelensconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "s3control.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageLensConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>StorageLensConfigurationSpec defines the desired state of StorageLensConfiguration</summary>
    [JsonPropertyName("spec")]
    public required V1beta2StorageLensConfigurationSpec Spec { get; set; }

    /// <summary>StorageLensConfigurationStatus defines the observed state of StorageLensConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta2StorageLensConfigurationStatus? Status { get; set; }
}