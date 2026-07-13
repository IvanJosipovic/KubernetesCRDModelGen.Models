#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.athena.aws.upbound.io;
/// <summary>Workgroup is the Schema for the Workgroups API. Manages an Athena Workgroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2WorkgroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Workgroup>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "WorkgroupList";
    public const string KubeGroup = "athena.aws.upbound.io";
    public const string KubePluralName = "workgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "athena.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkgroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Workgroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Workgroup> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecDeletionPolicyEnum>))]
public enum V1beta2WorkgroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configuration block to specify the KMS key that is used to encrypt the user&apos;s data stores in Athena. This setting applies to the PySpark engine for Athena notebooks. See Customer Content Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationCustomerContentEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationEngineVersion
{
    /// <summary>Requested engine version. Defaults to AUTO.</summary>
    [JsonPropertyName("selectedEngineVersion")]
    public string? SelectedEngineVersion { get; set; }
}

/// <summary>Configuration block to set up an IAM Identity Center enabled workgroup. See Identity Center Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationIdentityCenterConfiguration
{
    /// <summary>Specifies whether the workgroup is IAM Identity Center supported.</summary>
    [JsonPropertyName("enableIdentityCenter")]
    public bool? EnableIdentityCenter { get; set; }

    /// <summary>The IAM Identity Center instance ARN that the workgroup associates to.</summary>
    [JsonPropertyName("identityCenterInstanceArn")]
    public string? IdentityCenterInstanceArn { get; set; }
}

/// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationManagedQueryResultsConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType
{
    /// <summary>Type of worker to deliver logs to CloudWatch (for example, SPARK_DRIVER and SPARK_EXECUTOR).</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>List of log types to be delivered to CloudWatch (for example, STDOUT and STDERR).</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Configuration block for delivering logs to Amazon CloudWatch log groups. See CloudWatch Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the log group in Amazon CloudWatch Logs where you want to publish your logs.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Prefix for the CloudWatch log stream name.</summary>
    [JsonPropertyName("logStreamNamePrefix")]
    public string? LogStreamNamePrefix { get; set; }

    /// <summary>Repeatable block defining log types to be delivered to CloudWatch.</summary>
    [JsonPropertyName("logType")]
    public IList<V1beta2WorkgroupSpecForProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType>? LogType { get; set; }
}

/// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for delivering logs to Amazon S3 buckets. See S3 Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationMonitoringConfigurationS3LoggingConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Amazon S3 destination URI (s3://bucket/prefix) for log publishing.</summary>
    [JsonPropertyName("logLocation")]
    public string? LogLocation { get; set; }
}

/// <summary>Configuration block for managed log persistence, delivering logs to Amazon S3 buckets, Amazon CloudWatch log groups etc. Only applicable to Apache Spark engine. See Monitoring Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationMonitoringConfiguration
{
    /// <summary>Configuration block for delivering logs to Amazon CloudWatch log groups. See CloudWatch Logging Configuration below.</summary>
    [JsonPropertyName("cloudWatchLoggingConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration? CloudWatchLoggingConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
    [JsonPropertyName("managedLoggingConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration? ManagedLoggingConfiguration { get; set; }

    /// <summary>Configuration block for delivering logs to Amazon S3 buckets. See S3 Logging Configuration below.</summary>
    [JsonPropertyName("s3LoggingConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationMonitoringConfigurationS3LoggingConfiguration? S3LoggingConfiguration { get; set; }
}

/// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationQueryResultsS3AccessGrantsConfiguration
{
    /// <summary>The authentication type used for Amazon S3 access grants. Currently, only DIRECTORY_IDENTITY is supported.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>When enabled, appends the user ID as an Amazon S3 path prefix to the query result output location. Defaults to false.</summary>
    [JsonPropertyName("createUserLevelPrefix")]
    public bool? CreateUserLevelPrefix { get; set; }

    /// <summary>Specifies whether Amazon S3 access grants are enabled for query results.</summary>
    [JsonPropertyName("enableS3AccessGrants")]
    public bool? EnableS3AccessGrants { get; set; }
}

/// <summary>That an Amazon S3 canned ACL should be set to control ownership of stored query results. See ACL Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationAclConfiguration
{
    /// <summary>Amazon S3 canned ACL that Athena should specify when storing query results. Valid value is BUCKET_OWNER_FULL_CONTROL.</summary>
    [JsonPropertyName("s3AclOption")]
    public string? S3AclOption { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelector
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
    public V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfiguration
{
    /// <summary>Whether Amazon S3 server-side encryption with Amazon S3-managed keys (SSE_S3), server-side encryption with KMS-managed keys (SSE_KMS), or client-side encryption with KMS-managed keys (CSE_KMS) is used. If a query runs in a workgroup and the workgroup overrides client-side settings, then the workgroup&apos;s setting for encryption is used. It specifies whether query results must be encrypted, for all queries that run in this workgroup.</summary>
    [JsonPropertyName("encryptionOption")]
    public string? EncryptionOption { get; set; }

    /// <summary>Customer managed KMS key that is used to encrypt the user&apos;s data stores in Athena.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
}

/// <summary>Configuration block with result settings. See Result Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfigurationResultConfiguration
{
    /// <summary>That an Amazon S3 canned ACL should be set to control ownership of stored query results. See ACL Configuration below.</summary>
    [JsonPropertyName("aclConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationAclConfiguration? AclConfiguration { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>AWS account ID that you expect to be the owner of the Amazon S3 bucket.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Location in Amazon S3 where your query results are stored, such as s3://path/to/query/bucket/. For more information, see Queries and Query Result Files.</summary>
    [JsonPropertyName("outputLocation")]
    public string? OutputLocation { get; set; }
}

/// <summary>Configuration block with various settings for the workgroup. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProviderConfiguration
{
    /// <summary>Integer for the upper data usage limit (cutoff) for the amount of bytes a single query in a workgroup is allowed to scan. Must be at least 10485760.</summary>
    [JsonPropertyName("bytesScannedCutoffPerQuery")]
    public double? BytesScannedCutoffPerQuery { get; set; }

    /// <summary>Configuration block to specify the KMS key that is used to encrypt the user&apos;s data stores in Athena. This setting applies to the PySpark engine for Athena notebooks. See Customer Content Encryption Configuration below.</summary>
    [JsonPropertyName("customerContentEncryptionConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationCustomerContentEncryptionConfiguration? CustomerContentEncryptionConfiguration { get; set; }

    /// <summary>Boolean indicating whether a minimum level of encryption is enforced for the workgroup for query and calculation results written to Amazon S3.</summary>
    [JsonPropertyName("enableMinimumEncryptionConfiguration")]
    public bool? EnableMinimumEncryptionConfiguration { get; set; }

    /// <summary>Boolean whether the settings for the workgroup override client-side settings. For more information, see Workgroup Settings Override Client-Side Settings. Defaults to true.</summary>
    [JsonPropertyName("enforceWorkgroupConfiguration")]
    public bool? EnforceWorkgroupConfiguration { get; set; }

    /// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
    [JsonPropertyName("engineVersion")]
    public V1beta2WorkgroupSpecForProviderConfigurationEngineVersion? EngineVersion { get; set; }

    /// <summary>Role used to access user resources in notebook sessions and IAM Identity Center enabled workgroups. The property is required for IAM Identity Center enabled workgroups.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Configuration block to set up an IAM Identity Center enabled workgroup. See Identity Center Configuration below.</summary>
    [JsonPropertyName("identityCenterConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationIdentityCenterConfiguration? IdentityCenterConfiguration { get; set; }

    /// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
    [JsonPropertyName("managedQueryResultsConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationManagedQueryResultsConfiguration? ManagedQueryResultsConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence, delivering logs to Amazon S3 buckets, Amazon CloudWatch log groups etc. Only applicable to Apache Spark engine. See Monitoring Configuration below.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Boolean whether Amazon CloudWatch metrics are enabled for the workgroup. Defaults to true.</summary>
    [JsonPropertyName("publishCloudwatchMetricsEnabled")]
    public bool? PublishCloudwatchMetricsEnabled { get; set; }

    /// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
    [JsonPropertyName("queryResultsS3AccessGrantsConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationQueryResultsS3AccessGrantsConfiguration? QueryResultsS3AccessGrantsConfiguration { get; set; }

    /// <summary>If set to true , allows members assigned to a workgroup to reference Amazon S3 Requester Pays buckets in queries. If set to false , workgroup members cannot query data from Requester Pays buckets, and queries that retrieve data from Requester Pays buckets cause an error. The default is false . For more information about Requester Pays buckets, see Requester Pays Buckets in the Amazon Simple Storage Service Developer Guide.</summary>
    [JsonPropertyName("requesterPaysEnabled")]
    public bool? RequesterPaysEnabled { get; set; }

    /// <summary>Configuration block with result settings. See Result Configuration below.</summary>
    [JsonPropertyName("resultConfiguration")]
    public V1beta2WorkgroupSpecForProviderConfigurationResultConfiguration? ResultConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecForProvider
{
    /// <summary>Configuration block with various settings for the workgroup. Documented below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta2WorkgroupSpecForProviderConfiguration? Configuration { get; set; }

    /// <summary>Description of the workgroup.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Option to delete the workgroup and its contents even if the workgroup contains any named queries.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>State of the workgroup. Valid values are DISABLED or ENABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configuration block to specify the KMS key that is used to encrypt the user&apos;s data stores in Athena. This setting applies to the PySpark engine for Athena notebooks. See Customer Content Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationCustomerContentEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationEngineVersion
{
    /// <summary>Requested engine version. Defaults to AUTO.</summary>
    [JsonPropertyName("selectedEngineVersion")]
    public string? SelectedEngineVersion { get; set; }
}

/// <summary>Configuration block to set up an IAM Identity Center enabled workgroup. See Identity Center Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationIdentityCenterConfiguration
{
    /// <summary>Specifies whether the workgroup is IAM Identity Center supported.</summary>
    [JsonPropertyName("enableIdentityCenter")]
    public bool? EnableIdentityCenter { get; set; }

    /// <summary>The IAM Identity Center instance ARN that the workgroup associates to.</summary>
    [JsonPropertyName("identityCenterInstanceArn")]
    public string? IdentityCenterInstanceArn { get; set; }
}

/// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationManagedQueryResultsConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType
{
    /// <summary>Type of worker to deliver logs to CloudWatch (for example, SPARK_DRIVER and SPARK_EXECUTOR).</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>List of log types to be delivered to CloudWatch (for example, STDOUT and STDERR).</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Configuration block for delivering logs to Amazon CloudWatch log groups. See CloudWatch Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the log group in Amazon CloudWatch Logs where you want to publish your logs.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Prefix for the CloudWatch log stream name.</summary>
    [JsonPropertyName("logStreamNamePrefix")]
    public string? LogStreamNamePrefix { get; set; }

    /// <summary>Repeatable block defining log types to be delivered to CloudWatch.</summary>
    [JsonPropertyName("logType")]
    public IList<V1beta2WorkgroupSpecInitProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType>? LogType { get; set; }
}

/// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for delivering logs to Amazon S3 buckets. See S3 Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationMonitoringConfigurationS3LoggingConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Amazon S3 destination URI (s3://bucket/prefix) for log publishing.</summary>
    [JsonPropertyName("logLocation")]
    public string? LogLocation { get; set; }
}

/// <summary>Configuration block for managed log persistence, delivering logs to Amazon S3 buckets, Amazon CloudWatch log groups etc. Only applicable to Apache Spark engine. See Monitoring Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationMonitoringConfiguration
{
    /// <summary>Configuration block for delivering logs to Amazon CloudWatch log groups. See CloudWatch Logging Configuration below.</summary>
    [JsonPropertyName("cloudWatchLoggingConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration? CloudWatchLoggingConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
    [JsonPropertyName("managedLoggingConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration? ManagedLoggingConfiguration { get; set; }

    /// <summary>Configuration block for delivering logs to Amazon S3 buckets. See S3 Logging Configuration below.</summary>
    [JsonPropertyName("s3LoggingConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationMonitoringConfigurationS3LoggingConfiguration? S3LoggingConfiguration { get; set; }
}

/// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationQueryResultsS3AccessGrantsConfiguration
{
    /// <summary>The authentication type used for Amazon S3 access grants. Currently, only DIRECTORY_IDENTITY is supported.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>When enabled, appends the user ID as an Amazon S3 path prefix to the query result output location. Defaults to false.</summary>
    [JsonPropertyName("createUserLevelPrefix")]
    public bool? CreateUserLevelPrefix { get; set; }

    /// <summary>Specifies whether Amazon S3 access grants are enabled for query results.</summary>
    [JsonPropertyName("enableS3AccessGrants")]
    public bool? EnableS3AccessGrants { get; set; }
}

/// <summary>That an Amazon S3 canned ACL should be set to control ownership of stored query results. See ACL Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationAclConfiguration
{
    /// <summary>Amazon S3 canned ACL that Athena should specify when storing query results. Valid value is BUCKET_OWNER_FULL_CONTROL.</summary>
    [JsonPropertyName("s3AclOption")]
    public string? S3AclOption { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelector
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
    public V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfiguration
{
    /// <summary>Whether Amazon S3 server-side encryption with Amazon S3-managed keys (SSE_S3), server-side encryption with KMS-managed keys (SSE_KMS), or client-side encryption with KMS-managed keys (CSE_KMS) is used. If a query runs in a workgroup and the workgroup overrides client-side settings, then the workgroup&apos;s setting for encryption is used. It specifies whether query results must be encrypted, for all queries that run in this workgroup.</summary>
    [JsonPropertyName("encryptionOption")]
    public string? EncryptionOption { get; set; }

    /// <summary>Customer managed KMS key that is used to encrypt the user&apos;s data stores in Athena.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
}

/// <summary>Configuration block with result settings. See Result Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfigurationResultConfiguration
{
    /// <summary>That an Amazon S3 canned ACL should be set to control ownership of stored query results. See ACL Configuration below.</summary>
    [JsonPropertyName("aclConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationAclConfiguration? AclConfiguration { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>AWS account ID that you expect to be the owner of the Amazon S3 bucket.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Location in Amazon S3 where your query results are stored, such as s3://path/to/query/bucket/. For more information, see Queries and Query Result Files.</summary>
    [JsonPropertyName("outputLocation")]
    public string? OutputLocation { get; set; }
}

/// <summary>Configuration block with various settings for the workgroup. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecInitProviderConfiguration
{
    /// <summary>Integer for the upper data usage limit (cutoff) for the amount of bytes a single query in a workgroup is allowed to scan. Must be at least 10485760.</summary>
    [JsonPropertyName("bytesScannedCutoffPerQuery")]
    public double? BytesScannedCutoffPerQuery { get; set; }

    /// <summary>Configuration block to specify the KMS key that is used to encrypt the user&apos;s data stores in Athena. This setting applies to the PySpark engine for Athena notebooks. See Customer Content Encryption Configuration below.</summary>
    [JsonPropertyName("customerContentEncryptionConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationCustomerContentEncryptionConfiguration? CustomerContentEncryptionConfiguration { get; set; }

    /// <summary>Boolean indicating whether a minimum level of encryption is enforced for the workgroup for query and calculation results written to Amazon S3.</summary>
    [JsonPropertyName("enableMinimumEncryptionConfiguration")]
    public bool? EnableMinimumEncryptionConfiguration { get; set; }

    /// <summary>Boolean whether the settings for the workgroup override client-side settings. For more information, see Workgroup Settings Override Client-Side Settings. Defaults to true.</summary>
    [JsonPropertyName("enforceWorkgroupConfiguration")]
    public bool? EnforceWorkgroupConfiguration { get; set; }

    /// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
    [JsonPropertyName("engineVersion")]
    public V1beta2WorkgroupSpecInitProviderConfigurationEngineVersion? EngineVersion { get; set; }

    /// <summary>Role used to access user resources in notebook sessions and IAM Identity Center enabled workgroups. The property is required for IAM Identity Center enabled workgroups.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Configuration block to set up an IAM Identity Center enabled workgroup. See Identity Center Configuration below.</summary>
    [JsonPropertyName("identityCenterConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationIdentityCenterConfiguration? IdentityCenterConfiguration { get; set; }

    /// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
    [JsonPropertyName("managedQueryResultsConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationManagedQueryResultsConfiguration? ManagedQueryResultsConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence, delivering logs to Amazon S3 buckets, Amazon CloudWatch log groups etc. Only applicable to Apache Spark engine. See Monitoring Configuration below.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Boolean whether Amazon CloudWatch metrics are enabled for the workgroup. Defaults to true.</summary>
    [JsonPropertyName("publishCloudwatchMetricsEnabled")]
    public bool? PublishCloudwatchMetricsEnabled { get; set; }

    /// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
    [JsonPropertyName("queryResultsS3AccessGrantsConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationQueryResultsS3AccessGrantsConfiguration? QueryResultsS3AccessGrantsConfiguration { get; set; }

    /// <summary>If set to true , allows members assigned to a workgroup to reference Amazon S3 Requester Pays buckets in queries. If set to false , workgroup members cannot query data from Requester Pays buckets, and queries that retrieve data from Requester Pays buckets cause an error. The default is false . For more information about Requester Pays buckets, see Requester Pays Buckets in the Amazon Simple Storage Service Developer Guide.</summary>
    [JsonPropertyName("requesterPaysEnabled")]
    public bool? RequesterPaysEnabled { get; set; }

    /// <summary>Configuration block with result settings. See Result Configuration below.</summary>
    [JsonPropertyName("resultConfiguration")]
    public V1beta2WorkgroupSpecInitProviderConfigurationResultConfiguration? ResultConfiguration { get; set; }
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
public partial class V1beta2WorkgroupSpecInitProvider
{
    /// <summary>Configuration block with various settings for the workgroup. Documented below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta2WorkgroupSpecInitProviderConfiguration? Configuration { get; set; }

    /// <summary>Description of the workgroup.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Option to delete the workgroup and its contents even if the workgroup contains any named queries.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>State of the workgroup. Valid values are DISABLED or ENABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecManagementPoliciesEnum>))]
public enum V1beta2WorkgroupSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2WorkgroupSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2WorkgroupSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2WorkgroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2WorkgroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2WorkgroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2WorkgroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>WorkgroupSpec defines the desired state of Workgroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupSpec
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
    public V1beta2WorkgroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2WorkgroupSpecForProvider ForProvider { get; set; }

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
    public V1beta2WorkgroupSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2WorkgroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2WorkgroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2WorkgroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block to specify the KMS key that is used to encrypt the user&apos;s data stores in Athena. This setting applies to the PySpark engine for Athena notebooks. See Customer Content Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationCustomerContentEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationEngineVersion
{
    /// <summary>The engine version on which the query runs. If selected_engine_version is set to AUTO, the effective engine version is chosen by Athena.</summary>
    [JsonPropertyName("effectiveEngineVersion")]
    public string? EffectiveEngineVersion { get; set; }

    /// <summary>Requested engine version. Defaults to AUTO.</summary>
    [JsonPropertyName("selectedEngineVersion")]
    public string? SelectedEngineVersion { get; set; }
}

/// <summary>Configuration block to set up an IAM Identity Center enabled workgroup. See Identity Center Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationIdentityCenterConfiguration
{
    /// <summary>Specifies whether the workgroup is IAM Identity Center supported.</summary>
    [JsonPropertyName("enableIdentityCenter")]
    public bool? EnableIdentityCenter { get; set; }

    /// <summary>The IAM Identity Center instance ARN that the workgroup associates to.</summary>
    [JsonPropertyName("identityCenterInstanceArn")]
    public string? IdentityCenterInstanceArn { get; set; }
}

/// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationManagedQueryResultsConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType
{
    /// <summary>Type of worker to deliver logs to CloudWatch (for example, SPARK_DRIVER and SPARK_EXECUTOR).</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>List of log types to be delivered to CloudWatch (for example, STDOUT and STDERR).</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Configuration block for delivering logs to Amazon CloudWatch log groups. See CloudWatch Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Name of the log group in Amazon CloudWatch Logs where you want to publish your logs.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }

    /// <summary>Prefix for the CloudWatch log stream name.</summary>
    [JsonPropertyName("logStreamNamePrefix")]
    public string? LogStreamNamePrefix { get; set; }

    /// <summary>Repeatable block defining log types to be delivered to CloudWatch.</summary>
    [JsonPropertyName("logType")]
    public IList<V1beta2WorkgroupStatusAtProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType>? LogType { get; set; }
}

/// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for delivering logs to Amazon S3 buckets. See S3 Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationMonitoringConfigurationS3LoggingConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Amazon S3 destination URI (s3://bucket/prefix) for log publishing.</summary>
    [JsonPropertyName("logLocation")]
    public string? LogLocation { get; set; }
}

/// <summary>Configuration block for managed log persistence, delivering logs to Amazon S3 buckets, Amazon CloudWatch log groups etc. Only applicable to Apache Spark engine. See Monitoring Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationMonitoringConfiguration
{
    /// <summary>Configuration block for delivering logs to Amazon CloudWatch log groups. See CloudWatch Logging Configuration below.</summary>
    [JsonPropertyName("cloudWatchLoggingConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration? CloudWatchLoggingConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
    [JsonPropertyName("managedLoggingConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration? ManagedLoggingConfiguration { get; set; }

    /// <summary>Configuration block for delivering logs to Amazon S3 buckets. See S3 Logging Configuration below.</summary>
    [JsonPropertyName("s3LoggingConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationMonitoringConfigurationS3LoggingConfiguration? S3LoggingConfiguration { get; set; }
}

/// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationQueryResultsS3AccessGrantsConfiguration
{
    /// <summary>The authentication type used for Amazon S3 access grants. Currently, only DIRECTORY_IDENTITY is supported.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>When enabled, appends the user ID as an Amazon S3 path prefix to the query result output location. Defaults to false.</summary>
    [JsonPropertyName("createUserLevelPrefix")]
    public bool? CreateUserLevelPrefix { get; set; }

    /// <summary>Specifies whether Amazon S3 access grants are enabled for query results.</summary>
    [JsonPropertyName("enableS3AccessGrants")]
    public bool? EnableS3AccessGrants { get; set; }
}

/// <summary>That an Amazon S3 canned ACL should be set to control ownership of stored query results. See ACL Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationResultConfigurationAclConfiguration
{
    /// <summary>Amazon S3 canned ACL that Athena should specify when storing query results. Valid value is BUCKET_OWNER_FULL_CONTROL.</summary>
    [JsonPropertyName("s3AclOption")]
    public string? S3AclOption { get; set; }
}

/// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationResultConfigurationEncryptionConfiguration
{
    /// <summary>Whether Amazon S3 server-side encryption with Amazon S3-managed keys (SSE_S3), server-side encryption with KMS-managed keys (SSE_KMS), or client-side encryption with KMS-managed keys (CSE_KMS) is used. If a query runs in a workgroup and the workgroup overrides client-side settings, then the workgroup&apos;s setting for encryption is used. It specifies whether query results must be encrypted, for all queries that run in this workgroup.</summary>
    [JsonPropertyName("encryptionOption")]
    public string? EncryptionOption { get; set; }

    /// <summary>Customer managed KMS key that is used to encrypt the user&apos;s data stores in Athena.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

/// <summary>Configuration block with result settings. See Result Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfigurationResultConfiguration
{
    /// <summary>That an Amazon S3 canned ACL should be set to control ownership of stored query results. See ACL Configuration below.</summary>
    [JsonPropertyName("aclConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationResultConfigurationAclConfiguration? AclConfiguration { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>AWS account ID that you expect to be the owner of the Amazon S3 bucket.</summary>
    [JsonPropertyName("expectedBucketOwner")]
    public string? ExpectedBucketOwner { get; set; }

    /// <summary>Location in Amazon S3 where your query results are stored, such as s3://path/to/query/bucket/. For more information, see Queries and Query Result Files.</summary>
    [JsonPropertyName("outputLocation")]
    public string? OutputLocation { get; set; }
}

/// <summary>Configuration block with various settings for the workgroup. Documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProviderConfiguration
{
    /// <summary>Integer for the upper data usage limit (cutoff) for the amount of bytes a single query in a workgroup is allowed to scan. Must be at least 10485760.</summary>
    [JsonPropertyName("bytesScannedCutoffPerQuery")]
    public double? BytesScannedCutoffPerQuery { get; set; }

    /// <summary>Configuration block to specify the KMS key that is used to encrypt the user&apos;s data stores in Athena. This setting applies to the PySpark engine for Athena notebooks. See Customer Content Encryption Configuration below.</summary>
    [JsonPropertyName("customerContentEncryptionConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationCustomerContentEncryptionConfiguration? CustomerContentEncryptionConfiguration { get; set; }

    /// <summary>Boolean indicating whether a minimum level of encryption is enforced for the workgroup for query and calculation results written to Amazon S3.</summary>
    [JsonPropertyName("enableMinimumEncryptionConfiguration")]
    public bool? EnableMinimumEncryptionConfiguration { get; set; }

    /// <summary>Boolean whether the settings for the workgroup override client-side settings. For more information, see Workgroup Settings Override Client-Side Settings. Defaults to true.</summary>
    [JsonPropertyName("enforceWorkgroupConfiguration")]
    public bool? EnforceWorkgroupConfiguration { get; set; }

    /// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
    [JsonPropertyName("engineVersion")]
    public V1beta2WorkgroupStatusAtProviderConfigurationEngineVersion? EngineVersion { get; set; }

    /// <summary>Role used to access user resources in notebook sessions and IAM Identity Center enabled workgroups. The property is required for IAM Identity Center enabled workgroups.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Configuration block to set up an IAM Identity Center enabled workgroup. See Identity Center Configuration below.</summary>
    [JsonPropertyName("identityCenterConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationIdentityCenterConfiguration? IdentityCenterConfiguration { get; set; }

    /// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
    [JsonPropertyName("managedQueryResultsConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationManagedQueryResultsConfiguration? ManagedQueryResultsConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence, delivering logs to Amazon S3 buckets, Amazon CloudWatch log groups etc. Only applicable to Apache Spark engine. See Monitoring Configuration below.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Boolean whether Amazon CloudWatch metrics are enabled for the workgroup. Defaults to true.</summary>
    [JsonPropertyName("publishCloudwatchMetricsEnabled")]
    public bool? PublishCloudwatchMetricsEnabled { get; set; }

    /// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
    [JsonPropertyName("queryResultsS3AccessGrantsConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationQueryResultsS3AccessGrantsConfiguration? QueryResultsS3AccessGrantsConfiguration { get; set; }

    /// <summary>If set to true , allows members assigned to a workgroup to reference Amazon S3 Requester Pays buckets in queries. If set to false , workgroup members cannot query data from Requester Pays buckets, and queries that retrieve data from Requester Pays buckets cause an error. The default is false . For more information about Requester Pays buckets, see Requester Pays Buckets in the Amazon Simple Storage Service Developer Guide.</summary>
    [JsonPropertyName("requesterPaysEnabled")]
    public bool? RequesterPaysEnabled { get; set; }

    /// <summary>Configuration block with result settings. See Result Configuration below.</summary>
    [JsonPropertyName("resultConfiguration")]
    public V1beta2WorkgroupStatusAtProviderConfigurationResultConfiguration? ResultConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusAtProvider
{
    /// <summary>ARN of the workgroup</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block with various settings for the workgroup. Documented below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta2WorkgroupStatusAtProviderConfiguration? Configuration { get; set; }

    /// <summary>Description of the workgroup.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Option to delete the workgroup and its contents even if the workgroup contains any named queries.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>Workgroup name</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>State of the workgroup. Valid values are DISABLED or ENABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatusConditions
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

/// <summary>WorkgroupStatus defines the observed state of Workgroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2WorkgroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2WorkgroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2WorkgroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Workgroup is the Schema for the Workgroups API. Manages an Athena Workgroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Workgroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2WorkgroupSpec>, IStatus<V1beta2WorkgroupStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Workgroup";
    public const string KubeGroup = "athena.aws.upbound.io";
    public const string KubePluralName = "workgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "athena.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Workgroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkgroupSpec defines the desired state of Workgroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta2WorkgroupSpec Spec { get; set; }

    /// <summary>WorkgroupStatus defines the observed state of Workgroup.</summary>
    [JsonPropertyName("status")]
    public V1beta2WorkgroupStatus? Status { get; set; }
}