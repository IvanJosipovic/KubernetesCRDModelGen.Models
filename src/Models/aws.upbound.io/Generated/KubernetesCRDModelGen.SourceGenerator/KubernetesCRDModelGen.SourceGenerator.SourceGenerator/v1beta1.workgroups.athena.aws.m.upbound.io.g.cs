#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.athena.aws.m.upbound.io;
/// <summary>Workgroup is the Schema for the Workgroups API. Manages an Athena Workgroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkgroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Workgroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkgroupList";
    public const string KubeGroup = "athena.aws.m.upbound.io";
    public const string KubePluralName = "workgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "athena.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkgroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Workgroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Workgroup> Items { get; set; }
}

/// <summary>Configuration block to specify the KMS key that is used to encrypt the user&apos;s data stores in Athena. This setting applies to the PySpark engine for Athena notebooks. See Customer Content Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationCustomerContentEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationEngineVersion
{
    /// <summary>Requested engine version. Defaults to AUTO.</summary>
    [JsonPropertyName("selectedEngineVersion")]
    public string? SelectedEngineVersion { get; set; }
}

/// <summary>Configuration block to set up an IAM Identity Center enabled workgroup. See Identity Center Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationIdentityCenterConfiguration
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
public partial class V1beta1WorkgroupSpecForProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationManagedQueryResultsConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType
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
public partial class V1beta1WorkgroupSpecForProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration
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
    public IList<V1beta1WorkgroupSpecForProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType>? LogType { get; set; }
}

/// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration
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
public partial class V1beta1WorkgroupSpecForProviderConfigurationMonitoringConfigurationS3LoggingConfiguration
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
public partial class V1beta1WorkgroupSpecForProviderConfigurationMonitoringConfiguration
{
    /// <summary>Configuration block for delivering logs to Amazon CloudWatch log groups. See CloudWatch Logging Configuration below.</summary>
    [JsonPropertyName("cloudWatchLoggingConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration? CloudWatchLoggingConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
    [JsonPropertyName("managedLoggingConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration? ManagedLoggingConfiguration { get; set; }

    /// <summary>Configuration block for delivering logs to Amazon S3 buckets. See S3 Logging Configuration below.</summary>
    [JsonPropertyName("s3LoggingConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationMonitoringConfigurationS3LoggingConfiguration? S3LoggingConfiguration { get; set; }
}

/// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationQueryResultsS3AccessGrantsConfiguration
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
public partial class V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationAclConfiguration
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelector
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
    public V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfiguration
{
    /// <summary>Whether Amazon S3 server-side encryption with Amazon S3-managed keys (SSE_S3), server-side encryption with KMS-managed keys (SSE_KMS), or client-side encryption with KMS-managed keys (CSE_KMS) is used. If a query runs in a workgroup and the workgroup overrides client-side settings, then the workgroup&apos;s setting for encryption is used. It specifies whether query results must be encrypted, for all queries that run in this workgroup.</summary>
    [JsonPropertyName("encryptionOption")]
    public string? EncryptionOption { get; set; }

    /// <summary>Customer managed KMS key that is used to encrypt the user&apos;s data stores in Athena.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
}

/// <summary>Configuration block with result settings. See Result Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProviderConfigurationResultConfiguration
{
    /// <summary>That an Amazon S3 canned ACL should be set to control ownership of stored query results. See ACL Configuration below.</summary>
    [JsonPropertyName("aclConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationAclConfiguration? AclConfiguration { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }

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
public partial class V1beta1WorkgroupSpecForProviderConfiguration
{
    /// <summary>Integer for the upper data usage limit (cutoff) for the amount of bytes a single query in a workgroup is allowed to scan. Must be at least 10485760.</summary>
    [JsonPropertyName("bytesScannedCutoffPerQuery")]
    public double? BytesScannedCutoffPerQuery { get; set; }

    /// <summary>Configuration block to specify the KMS key that is used to encrypt the user&apos;s data stores in Athena. This setting applies to the PySpark engine for Athena notebooks. See Customer Content Encryption Configuration below.</summary>
    [JsonPropertyName("customerContentEncryptionConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationCustomerContentEncryptionConfiguration? CustomerContentEncryptionConfiguration { get; set; }

    /// <summary>Boolean indicating whether a minimum level of encryption is enforced for the workgroup for query and calculation results written to Amazon S3.</summary>
    [JsonPropertyName("enableMinimumEncryptionConfiguration")]
    public bool? EnableMinimumEncryptionConfiguration { get; set; }

    /// <summary>Boolean whether the settings for the workgroup override client-side settings. For more information, see Workgroup Settings Override Client-Side Settings. Defaults to true.</summary>
    [JsonPropertyName("enforceWorkgroupConfiguration")]
    public bool? EnforceWorkgroupConfiguration { get; set; }

    /// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
    [JsonPropertyName("engineVersion")]
    public V1beta1WorkgroupSpecForProviderConfigurationEngineVersion? EngineVersion { get; set; }

    /// <summary>Role used to access user resources in notebook sessions and IAM Identity Center enabled workgroups. The property is required for IAM Identity Center enabled workgroups.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Configuration block to set up an IAM Identity Center enabled workgroup. See Identity Center Configuration below.</summary>
    [JsonPropertyName("identityCenterConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationIdentityCenterConfiguration? IdentityCenterConfiguration { get; set; }

    /// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
    [JsonPropertyName("managedQueryResultsConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationManagedQueryResultsConfiguration? ManagedQueryResultsConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence, delivering logs to Amazon S3 buckets, Amazon CloudWatch log groups etc. Only applicable to Apache Spark engine. See Monitoring Configuration below.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Boolean whether Amazon CloudWatch metrics are enabled for the workgroup. Defaults to true.</summary>
    [JsonPropertyName("publishCloudwatchMetricsEnabled")]
    public bool? PublishCloudwatchMetricsEnabled { get; set; }

    /// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
    [JsonPropertyName("queryResultsS3AccessGrantsConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationQueryResultsS3AccessGrantsConfiguration? QueryResultsS3AccessGrantsConfiguration { get; set; }

    /// <summary>If set to true , allows members assigned to a workgroup to reference Amazon S3 Requester Pays buckets in queries. If set to false , workgroup members cannot query data from Requester Pays buckets, and queries that retrieve data from Requester Pays buckets cause an error. The default is false . For more information about Requester Pays buckets, see Requester Pays Buckets in the Amazon Simple Storage Service Developer Guide.</summary>
    [JsonPropertyName("requesterPaysEnabled")]
    public bool? RequesterPaysEnabled { get; set; }

    /// <summary>Configuration block with result settings. See Result Configuration below.</summary>
    [JsonPropertyName("resultConfiguration")]
    public V1beta1WorkgroupSpecForProviderConfigurationResultConfiguration? ResultConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecForProvider
{
    /// <summary>Configuration block with various settings for the workgroup. Documented below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1WorkgroupSpecForProviderConfiguration? Configuration { get; set; }

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
public partial class V1beta1WorkgroupSpecInitProviderConfigurationCustomerContentEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationEngineVersion
{
    /// <summary>Requested engine version. Defaults to AUTO.</summary>
    [JsonPropertyName("selectedEngineVersion")]
    public string? SelectedEngineVersion { get; set; }
}

/// <summary>Configuration block to set up an IAM Identity Center enabled workgroup. See Identity Center Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationIdentityCenterConfiguration
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
public partial class V1beta1WorkgroupSpecInitProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationManagedQueryResultsConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType
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
public partial class V1beta1WorkgroupSpecInitProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration
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
    public IList<V1beta1WorkgroupSpecInitProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType>? LogType { get; set; }
}

/// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration
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
public partial class V1beta1WorkgroupSpecInitProviderConfigurationMonitoringConfigurationS3LoggingConfiguration
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
public partial class V1beta1WorkgroupSpecInitProviderConfigurationMonitoringConfiguration
{
    /// <summary>Configuration block for delivering logs to Amazon CloudWatch log groups. See CloudWatch Logging Configuration below.</summary>
    [JsonPropertyName("cloudWatchLoggingConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration? CloudWatchLoggingConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
    [JsonPropertyName("managedLoggingConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration? ManagedLoggingConfiguration { get; set; }

    /// <summary>Configuration block for delivering logs to Amazon S3 buckets. See S3 Logging Configuration below.</summary>
    [JsonPropertyName("s3LoggingConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationMonitoringConfigurationS3LoggingConfiguration? S3LoggingConfiguration { get; set; }
}

/// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationQueryResultsS3AccessGrantsConfiguration
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
public partial class V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationAclConfiguration
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelector
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
    public V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfiguration
{
    /// <summary>Whether Amazon S3 server-side encryption with Amazon S3-managed keys (SSE_S3), server-side encryption with KMS-managed keys (SSE_KMS), or client-side encryption with KMS-managed keys (CSE_KMS) is used. If a query runs in a workgroup and the workgroup overrides client-side settings, then the workgroup&apos;s setting for encryption is used. It specifies whether query results must be encrypted, for all queries that run in this workgroup.</summary>
    [JsonPropertyName("encryptionOption")]
    public string? EncryptionOption { get; set; }

    /// <summary>Customer managed KMS key that is used to encrypt the user&apos;s data stores in Athena.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfigurationKmsKeyArnSelector? KmsKeyArnSelector { get; set; }
}

/// <summary>Configuration block with result settings. See Result Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpecInitProviderConfigurationResultConfiguration
{
    /// <summary>That an Amazon S3 canned ACL should be set to control ownership of stored query results. See ACL Configuration below.</summary>
    [JsonPropertyName("aclConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationAclConfiguration? AclConfiguration { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }

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
public partial class V1beta1WorkgroupSpecInitProviderConfiguration
{
    /// <summary>Integer for the upper data usage limit (cutoff) for the amount of bytes a single query in a workgroup is allowed to scan. Must be at least 10485760.</summary>
    [JsonPropertyName("bytesScannedCutoffPerQuery")]
    public double? BytesScannedCutoffPerQuery { get; set; }

    /// <summary>Configuration block to specify the KMS key that is used to encrypt the user&apos;s data stores in Athena. This setting applies to the PySpark engine for Athena notebooks. See Customer Content Encryption Configuration below.</summary>
    [JsonPropertyName("customerContentEncryptionConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationCustomerContentEncryptionConfiguration? CustomerContentEncryptionConfiguration { get; set; }

    /// <summary>Boolean indicating whether a minimum level of encryption is enforced for the workgroup for query and calculation results written to Amazon S3.</summary>
    [JsonPropertyName("enableMinimumEncryptionConfiguration")]
    public bool? EnableMinimumEncryptionConfiguration { get; set; }

    /// <summary>Boolean whether the settings for the workgroup override client-side settings. For more information, see Workgroup Settings Override Client-Side Settings. Defaults to true.</summary>
    [JsonPropertyName("enforceWorkgroupConfiguration")]
    public bool? EnforceWorkgroupConfiguration { get; set; }

    /// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
    [JsonPropertyName("engineVersion")]
    public V1beta1WorkgroupSpecInitProviderConfigurationEngineVersion? EngineVersion { get; set; }

    /// <summary>Role used to access user resources in notebook sessions and IAM Identity Center enabled workgroups. The property is required for IAM Identity Center enabled workgroups.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Configuration block to set up an IAM Identity Center enabled workgroup. See Identity Center Configuration below.</summary>
    [JsonPropertyName("identityCenterConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationIdentityCenterConfiguration? IdentityCenterConfiguration { get; set; }

    /// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
    [JsonPropertyName("managedQueryResultsConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationManagedQueryResultsConfiguration? ManagedQueryResultsConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence, delivering logs to Amazon S3 buckets, Amazon CloudWatch log groups etc. Only applicable to Apache Spark engine. See Monitoring Configuration below.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Boolean whether Amazon CloudWatch metrics are enabled for the workgroup. Defaults to true.</summary>
    [JsonPropertyName("publishCloudwatchMetricsEnabled")]
    public bool? PublishCloudwatchMetricsEnabled { get; set; }

    /// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
    [JsonPropertyName("queryResultsS3AccessGrantsConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationQueryResultsS3AccessGrantsConfiguration? QueryResultsS3AccessGrantsConfiguration { get; set; }

    /// <summary>If set to true , allows members assigned to a workgroup to reference Amazon S3 Requester Pays buckets in queries. If set to false , workgroup members cannot query data from Requester Pays buckets, and queries that retrieve data from Requester Pays buckets cause an error. The default is false . For more information about Requester Pays buckets, see Requester Pays Buckets in the Amazon Simple Storage Service Developer Guide.</summary>
    [JsonPropertyName("requesterPaysEnabled")]
    public bool? RequesterPaysEnabled { get; set; }

    /// <summary>Configuration block with result settings. See Result Configuration below.</summary>
    [JsonPropertyName("resultConfiguration")]
    public V1beta1WorkgroupSpecInitProviderConfigurationResultConfiguration? ResultConfiguration { get; set; }
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
public partial class V1beta1WorkgroupSpecInitProvider
{
    /// <summary>Configuration block with various settings for the workgroup. Documented below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1WorkgroupSpecInitProviderConfiguration? Configuration { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkgroupSpecManagementPoliciesEnum>))]
public enum V1beta1WorkgroupSpecManagementPoliciesEnum
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
public partial class V1beta1WorkgroupSpecProviderConfigRef
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
public partial class V1beta1WorkgroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WorkgroupSpec defines the desired state of Workgroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1WorkgroupSpecForProvider ForProvider { get; set; }

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
    public V1beta1WorkgroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WorkgroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkgroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkgroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block to specify the KMS key that is used to encrypt the user&apos;s data stores in Athena. This setting applies to the PySpark engine for Athena notebooks. See Customer Content Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderConfigurationCustomerContentEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderConfigurationEngineVersion
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
public partial class V1beta1WorkgroupStatusAtProviderConfigurationIdentityCenterConfiguration
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
public partial class V1beta1WorkgroupStatusAtProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration
{
    /// <summary>KMS key ARN to encrypt the logs published to the given Amazon S3 destination.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderConfigurationManagedQueryResultsConfiguration
{
    /// <summary>Boolean whether Amazon CloudWatch logging is enabled for the workgroup.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationManagedQueryResultsConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType
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
public partial class V1beta1WorkgroupStatusAtProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration
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
    public IList<V1beta1WorkgroupStatusAtProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfigurationLogType>? LogType { get; set; }
}

/// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration
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
public partial class V1beta1WorkgroupStatusAtProviderConfigurationMonitoringConfigurationS3LoggingConfiguration
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
public partial class V1beta1WorkgroupStatusAtProviderConfigurationMonitoringConfiguration
{
    /// <summary>Configuration block for delivering logs to Amazon CloudWatch log groups. See CloudWatch Logging Configuration below.</summary>
    [JsonPropertyName("cloudWatchLoggingConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationMonitoringConfigurationCloudWatchLoggingConfiguration? CloudWatchLoggingConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence. See Managed Logging Configuration below.</summary>
    [JsonPropertyName("managedLoggingConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationMonitoringConfigurationManagedLoggingConfiguration? ManagedLoggingConfiguration { get; set; }

    /// <summary>Configuration block for delivering logs to Amazon S3 buckets. See S3 Logging Configuration below.</summary>
    [JsonPropertyName("s3LoggingConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationMonitoringConfigurationS3LoggingConfiguration? S3LoggingConfiguration { get; set; }
}

/// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderConfigurationQueryResultsS3AccessGrantsConfiguration
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
public partial class V1beta1WorkgroupStatusAtProviderConfigurationResultConfigurationAclConfiguration
{
    /// <summary>Amazon S3 canned ACL that Athena should specify when storing query results. Valid value is BUCKET_OWNER_FULL_CONTROL.</summary>
    [JsonPropertyName("s3AclOption")]
    public string? S3AclOption { get; set; }
}

/// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProviderConfigurationResultConfigurationEncryptionConfiguration
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
public partial class V1beta1WorkgroupStatusAtProviderConfigurationResultConfiguration
{
    /// <summary>That an Amazon S3 canned ACL should be set to control ownership of stored query results. See ACL Configuration below.</summary>
    [JsonPropertyName("aclConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationResultConfigurationAclConfiguration? AclConfiguration { get; set; }

    /// <summary>Configuration block with encryption settings. See Encryption Configuration below.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfiguration { get; set; }

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
public partial class V1beta1WorkgroupStatusAtProviderConfiguration
{
    /// <summary>Integer for the upper data usage limit (cutoff) for the amount of bytes a single query in a workgroup is allowed to scan. Must be at least 10485760.</summary>
    [JsonPropertyName("bytesScannedCutoffPerQuery")]
    public double? BytesScannedCutoffPerQuery { get; set; }

    /// <summary>Configuration block to specify the KMS key that is used to encrypt the user&apos;s data stores in Athena. This setting applies to the PySpark engine for Athena notebooks. See Customer Content Encryption Configuration below.</summary>
    [JsonPropertyName("customerContentEncryptionConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationCustomerContentEncryptionConfiguration? CustomerContentEncryptionConfiguration { get; set; }

    /// <summary>Boolean indicating whether a minimum level of encryption is enforced for the workgroup for query and calculation results written to Amazon S3.</summary>
    [JsonPropertyName("enableMinimumEncryptionConfiguration")]
    public bool? EnableMinimumEncryptionConfiguration { get; set; }

    /// <summary>Boolean whether the settings for the workgroup override client-side settings. For more information, see Workgroup Settings Override Client-Side Settings. Defaults to true.</summary>
    [JsonPropertyName("enforceWorkgroupConfiguration")]
    public bool? EnforceWorkgroupConfiguration { get; set; }

    /// <summary>Configuration block for the Athena Engine Versioning. For more information, see Athena Engine Versioning. See Engine Version below.</summary>
    [JsonPropertyName("engineVersion")]
    public V1beta1WorkgroupStatusAtProviderConfigurationEngineVersion? EngineVersion { get; set; }

    /// <summary>Role used to access user resources in notebook sessions and IAM Identity Center enabled workgroups. The property is required for IAM Identity Center enabled workgroups.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Configuration block to set up an IAM Identity Center enabled workgroup. See Identity Center Configuration below.</summary>
    [JsonPropertyName("identityCenterConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationIdentityCenterConfiguration? IdentityCenterConfiguration { get; set; }

    /// <summary>Configuration block for storing results in Athena owned storage. See Managed Query Results Configuration below.</summary>
    [JsonPropertyName("managedQueryResultsConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationManagedQueryResultsConfiguration? ManagedQueryResultsConfiguration { get; set; }

    /// <summary>Configuration block for managed log persistence, delivering logs to Amazon S3 buckets, Amazon CloudWatch log groups etc. Only applicable to Apache Spark engine. See Monitoring Configuration below.</summary>
    [JsonPropertyName("monitoringConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationMonitoringConfiguration? MonitoringConfiguration { get; set; }

    /// <summary>Boolean whether Amazon CloudWatch metrics are enabled for the workgroup. Defaults to true.</summary>
    [JsonPropertyName("publishCloudwatchMetricsEnabled")]
    public bool? PublishCloudwatchMetricsEnabled { get; set; }

    /// <summary>Configuration block for S3 access grants. See Query Results S3 Access Grants Configuration below.</summary>
    [JsonPropertyName("queryResultsS3AccessGrantsConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationQueryResultsS3AccessGrantsConfiguration? QueryResultsS3AccessGrantsConfiguration { get; set; }

    /// <summary>If set to true , allows members assigned to a workgroup to reference Amazon S3 Requester Pays buckets in queries. If set to false , workgroup members cannot query data from Requester Pays buckets, and queries that retrieve data from Requester Pays buckets cause an error. The default is false . For more information about Requester Pays buckets, see Requester Pays Buckets in the Amazon Simple Storage Service Developer Guide.</summary>
    [JsonPropertyName("requesterPaysEnabled")]
    public bool? RequesterPaysEnabled { get; set; }

    /// <summary>Configuration block with result settings. See Result Configuration below.</summary>
    [JsonPropertyName("resultConfiguration")]
    public V1beta1WorkgroupStatusAtProviderConfigurationResultConfiguration? ResultConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkgroupStatusAtProvider
{
    /// <summary>ARN of the workgroup</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block with various settings for the workgroup. Documented below.</summary>
    [JsonPropertyName("configuration")]
    public V1beta1WorkgroupStatusAtProviderConfiguration? Configuration { get; set; }

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
public partial class V1beta1WorkgroupStatusConditions
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
public partial class V1beta1WorkgroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1WorkgroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkgroupStatusConditions>? Conditions { get; set; }

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
public partial class V1beta1Workgroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkgroupSpec>, IStatus<V1beta1WorkgroupStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Workgroup";
    public const string KubeGroup = "athena.aws.m.upbound.io";
    public const string KubePluralName = "workgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "athena.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Workgroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkgroupSpec defines the desired state of Workgroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta1WorkgroupSpec Spec { get; set; }

    /// <summary>WorkgroupStatus defines the observed state of Workgroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkgroupStatus? Status { get; set; }
}