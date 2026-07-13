#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elasticsearch.aws.upbound.io;
/// <summary>Domain is the Schema for the Domains API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DomainList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Domain>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DomainList";
    public const string KubeGroup = "elasticsearch.aws.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticsearch.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Domain objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Domain> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecDeletionPolicyEnum>))]
public enum V1beta2DomainSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Main user&apos;s password, which is stored in the Amazon Elasticsearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Configuration block for the main user. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAdvancedSecurityOptionsMasterUserOptions
{
    /// <summary>ARN for the main user. Only specify if internal_user_database_enabled is not set or set to false.</summary>
    [JsonPropertyName("masterUserArn")]
    public string? MasterUserArn { get; set; }

    /// <summary>Main user&apos;s username, which is stored in the Amazon Elasticsearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }

    /// <summary>Main user&apos;s password, which is stored in the Amazon Elasticsearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserPasswordSecretRef")]
    public V1beta2DomainSpecForProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef? MasterUserPasswordSecretRef { get; set; }
}

/// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAdvancedSecurityOptions
{
    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. If not set, defaults to false by the AWS API.</summary>
    [JsonPropertyName("internalUserDatabaseEnabled")]
    public bool? InternalUserDatabaseEnabled { get; set; }

    /// <summary>Configuration block for the main user. Detailed below.</summary>
    [JsonPropertyName("masterUserOptions")]
    public V1beta2DomainSpecForProviderAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions { get; set; }
}

/// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAutoTuneOptionsMaintenanceScheduleDuration
{
    /// <summary>The unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>An integer specifying the value of the duration of an Auto-Tune maintenance window.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAutoTuneOptionsMaintenanceSchedule
{
    /// <summary>A cron expression specifying the recurrence pattern for an Auto-Tune maintenance schedule.</summary>
    [JsonPropertyName("cronExpressionForRecurrence")]
    public string? CronExpressionForRecurrence { get; set; }

    /// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
    [JsonPropertyName("duration")]
    public V1beta2DomainSpecForProviderAutoTuneOptionsMaintenanceScheduleDuration? Duration { get; set; }

    /// <summary>Date and time at which to start the Auto-Tune maintenance schedule in RFC3339 format.</summary>
    [JsonPropertyName("startAt")]
    public string? StartAt { get; set; }
}

/// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAutoTuneOptions
{
    /// <summary>The Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta2DomainSpecForProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }
}

/// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an Elasticsearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderClusterConfigZoneAwarenessConfig
{
    /// <summary>Number of Availability Zones for the domain to use with zone_awareness_enabled. Defaults to 2. Valid values: 2 or 3.</summary>
    [JsonPropertyName("availabilityZoneCount")]
    public double? AvailabilityZoneCount { get; set; }
}

/// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderClusterConfig
{
    /// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
    [JsonPropertyName("coldStorageOptions")]
    public V1beta2DomainSpecForProviderClusterConfigColdStorageOptions? ColdStorageOptions { get; set; }

    /// <summary>Number of dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterCount")]
    public double? DedicatedMasterCount { get; set; }

    /// <summary>Whether dedicated main nodes are enabled for the cluster.</summary>
    [JsonPropertyName("dedicatedMasterEnabled")]
    public bool? DedicatedMasterEnabled { get; set; }

    /// <summary>Instance type of the dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterType")]
    public string? DedicatedMasterType { get; set; }

    /// <summary>Number of instances in the cluster.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Instance type of data nodes in the cluster.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the Elasticsearch cluster&apos;s warm nodes. Valid values are ultrawarm1.medium.elasticsearch, ultrawarm1.large.elasticsearch and ultrawarm1.xlarge.elasticsearch. warm_type can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmType")]
    public string? WarmType { get; set; }

    /// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
    [JsonPropertyName("zoneAwarenessConfig")]
    public V1beta2DomainSpecForProviderClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig { get; set; }

    /// <summary>Whether zone awareness is enabled, set to true for multi-az deployment. To enable awareness with three Availability Zones, the availability_zone_count within the zone_awareness_config must be set to 3.</summary>
    [JsonPropertyName("zoneAwarenessEnabled")]
    public bool? ZoneAwarenessEnabled { get; set; }
}

/// <summary>Configuration block for authenticating Kibana with Cognito. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderCognitoOptions
{
    /// <summary>Whether Amazon Cognito authentication with Kibana is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonESCognitoAccess policy attached.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>ID of the Cognito User Pool to use.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderDomainEndpointOptions
{
    /// <summary>Fully qualified domain for your custom endpoint.</summary>
    [JsonPropertyName("customEndpoint")]
    public string? CustomEndpoint { get; set; }

    /// <summary>ACM certificate ARN for your custom endpoint.</summary>
    [JsonPropertyName("customEndpointCertificateArn")]
    public string? CustomEndpointCertificateArn { get; set; }

    /// <summary>Whether to enable custom endpoint for the Elasticsearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. Valid values:  Policy-Min-TLS-1-0-2019-07, Policy-Min-TLS-1-2-2019-07, and Policy-Min-TLS-1-2-PFS-2023-10.</summary>
    [JsonPropertyName("tlsSecurityPolicy")]
    public string? TlsSecurityPolicy { get; set; }
}

/// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderEbsOptions
{
    /// <summary>Whether EBS volumes are attached to data nodes in the domain.</summary>
    [JsonPropertyName("ebsEnabled")]
    public bool? EbsEnabled { get; set; }

    /// <summary>Baseline input/output (I/O) performance of EBS volumes attached to data nodes. Applicable only for the GP3 and Provisioned IOPS EBS volume types.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Specifies the throughput (in MiB/s) of the EBS volumes attached to data nodes. Applicable only for the gp3 volume type.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of EBS volumes attached to data nodes (in GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of EBS volumes attached to data nodes.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderEncryptAtRest
{
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires elasticsearch_version 5.1 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the Elasticsearch domain with. If not specified then it defaults to using the aws/es service KMS key. Note that KMS will accept a KMS key ID but will return the key ARN.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelector
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
    public V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderLogPublishingOptions
{
    /// <summary>ARN of the Cloudwatch log group to which log needs to be published.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnRef")]
    public V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnRef? CloudwatchLogGroupArnRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnSelector")]
    public V1beta2DomainSpecForProviderLogPublishingOptionsCloudwatchLogGroupArnSelector? CloudwatchLogGroupArnSelector { get; set; }

    /// <summary>Whether given log publishing option is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Type of Elasticsearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an elasticsearch_version of 6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running Elasticsearch 5.3 and later, Amazon ES takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions of Elasticsearch, Amazon ES takes daily automated snapshots.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderSnapshotOptions
{
    /// <summary>Hour during which the service takes an automated daily snapshot of the indices in the domain.</summary>
    [JsonPropertyName("automatedSnapshotStartHour")]
    public double? AutomatedSnapshotStartHour { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsSelector
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
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptions
{
    /// <summary>List of VPC Security Group IDs to be applied to the Elasticsearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>List of VPC Subnet IDs for the Elasticsearch domain endpoints to be created in.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProvider
{
    /// <summary>IAM policy document specifying the access policies for the domain.</summary>
    [JsonPropertyName("accessPolicies")]
    public string? AccessPolicies { get; set; }

    /// <summary>Key-value string pairs to specify advanced configuration options.</summary>
    [JsonPropertyName("advancedOptions")]
    public IDictionary<string, string>? AdvancedOptions { get; set; }

    /// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityOptions")]
    public V1beta2DomainSpecForProviderAdvancedSecurityOptions? AdvancedSecurityOptions { get; set; }

    /// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
    [JsonPropertyName("autoTuneOptions")]
    public V1beta2DomainSpecForProviderAutoTuneOptions? AutoTuneOptions { get; set; }

    /// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
    [JsonPropertyName("clusterConfig")]
    public V1beta2DomainSpecForProviderClusterConfig? ClusterConfig { get; set; }

    /// <summary>Configuration block for authenticating Kibana with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public V1beta2DomainSpecForProviderCognitoOptions? CognitoOptions { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public V1beta2DomainSpecForProviderDomainEndpointOptions? DomainEndpointOptions { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public V1beta2DomainSpecForProviderEbsOptions? EbsOptions { get; set; }

    /// <summary>Version of Elasticsearch to deploy. Defaults to 1.5.</summary>
    [JsonPropertyName("elasticsearchVersion")]
    public string? ElasticsearchVersion { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public V1beta2DomainSpecForProviderEncryptAtRest? EncryptAtRest { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta2DomainSpecForProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public V1beta2DomainSpecForProviderNodeToNodeEncryption? NodeToNodeEncryption { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running Elasticsearch 5.3 and later, Amazon ES takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions of Elasticsearch, Amazon ES takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public V1beta2DomainSpecForProviderSnapshotOptions? SnapshotOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
    [JsonPropertyName("vpcOptions")]
    public V1beta2DomainSpecForProviderVpcOptions? VpcOptions { get; set; }
}

/// <summary>Main user&apos;s password, which is stored in the Amazon Elasticsearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>Configuration block for the main user. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAdvancedSecurityOptionsMasterUserOptions
{
    /// <summary>ARN for the main user. Only specify if internal_user_database_enabled is not set or set to false.</summary>
    [JsonPropertyName("masterUserArn")]
    public string? MasterUserArn { get; set; }

    /// <summary>Main user&apos;s username, which is stored in the Amazon Elasticsearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }

    /// <summary>Main user&apos;s password, which is stored in the Amazon Elasticsearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserPasswordSecretRef")]
    public V1beta2DomainSpecInitProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef? MasterUserPasswordSecretRef { get; set; }
}

/// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAdvancedSecurityOptions
{
    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. If not set, defaults to false by the AWS API.</summary>
    [JsonPropertyName("internalUserDatabaseEnabled")]
    public bool? InternalUserDatabaseEnabled { get; set; }

    /// <summary>Configuration block for the main user. Detailed below.</summary>
    [JsonPropertyName("masterUserOptions")]
    public V1beta2DomainSpecInitProviderAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions { get; set; }
}

/// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAutoTuneOptionsMaintenanceScheduleDuration
{
    /// <summary>The unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>An integer specifying the value of the duration of an Auto-Tune maintenance window.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAutoTuneOptionsMaintenanceSchedule
{
    /// <summary>A cron expression specifying the recurrence pattern for an Auto-Tune maintenance schedule.</summary>
    [JsonPropertyName("cronExpressionForRecurrence")]
    public string? CronExpressionForRecurrence { get; set; }

    /// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
    [JsonPropertyName("duration")]
    public V1beta2DomainSpecInitProviderAutoTuneOptionsMaintenanceScheduleDuration? Duration { get; set; }

    /// <summary>Date and time at which to start the Auto-Tune maintenance schedule in RFC3339 format.</summary>
    [JsonPropertyName("startAt")]
    public string? StartAt { get; set; }
}

/// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAutoTuneOptions
{
    /// <summary>The Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta2DomainSpecInitProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }
}

/// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an Elasticsearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderClusterConfigZoneAwarenessConfig
{
    /// <summary>Number of Availability Zones for the domain to use with zone_awareness_enabled. Defaults to 2. Valid values: 2 or 3.</summary>
    [JsonPropertyName("availabilityZoneCount")]
    public double? AvailabilityZoneCount { get; set; }
}

/// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderClusterConfig
{
    /// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
    [JsonPropertyName("coldStorageOptions")]
    public V1beta2DomainSpecInitProviderClusterConfigColdStorageOptions? ColdStorageOptions { get; set; }

    /// <summary>Number of dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterCount")]
    public double? DedicatedMasterCount { get; set; }

    /// <summary>Whether dedicated main nodes are enabled for the cluster.</summary>
    [JsonPropertyName("dedicatedMasterEnabled")]
    public bool? DedicatedMasterEnabled { get; set; }

    /// <summary>Instance type of the dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterType")]
    public string? DedicatedMasterType { get; set; }

    /// <summary>Number of instances in the cluster.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Instance type of data nodes in the cluster.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the Elasticsearch cluster&apos;s warm nodes. Valid values are ultrawarm1.medium.elasticsearch, ultrawarm1.large.elasticsearch and ultrawarm1.xlarge.elasticsearch. warm_type can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmType")]
    public string? WarmType { get; set; }

    /// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
    [JsonPropertyName("zoneAwarenessConfig")]
    public V1beta2DomainSpecInitProviderClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig { get; set; }

    /// <summary>Whether zone awareness is enabled, set to true for multi-az deployment. To enable awareness with three Availability Zones, the availability_zone_count within the zone_awareness_config must be set to 3.</summary>
    [JsonPropertyName("zoneAwarenessEnabled")]
    public bool? ZoneAwarenessEnabled { get; set; }
}

/// <summary>Configuration block for authenticating Kibana with Cognito. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderCognitoOptions
{
    /// <summary>Whether Amazon Cognito authentication with Kibana is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonESCognitoAccess policy attached.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>ID of the Cognito User Pool to use.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderDomainEndpointOptions
{
    /// <summary>Fully qualified domain for your custom endpoint.</summary>
    [JsonPropertyName("customEndpoint")]
    public string? CustomEndpoint { get; set; }

    /// <summary>ACM certificate ARN for your custom endpoint.</summary>
    [JsonPropertyName("customEndpointCertificateArn")]
    public string? CustomEndpointCertificateArn { get; set; }

    /// <summary>Whether to enable custom endpoint for the Elasticsearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. Valid values:  Policy-Min-TLS-1-0-2019-07, Policy-Min-TLS-1-2-2019-07, and Policy-Min-TLS-1-2-PFS-2023-10.</summary>
    [JsonPropertyName("tlsSecurityPolicy")]
    public string? TlsSecurityPolicy { get; set; }
}

/// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderEbsOptions
{
    /// <summary>Whether EBS volumes are attached to data nodes in the domain.</summary>
    [JsonPropertyName("ebsEnabled")]
    public bool? EbsEnabled { get; set; }

    /// <summary>Baseline input/output (I/O) performance of EBS volumes attached to data nodes. Applicable only for the GP3 and Provisioned IOPS EBS volume types.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Specifies the throughput (in MiB/s) of the EBS volumes attached to data nodes. Applicable only for the gp3 volume type.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of EBS volumes attached to data nodes (in GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of EBS volumes attached to data nodes.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderEncryptAtRest
{
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires elasticsearch_version 5.1 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the Elasticsearch domain with. If not specified then it defaults to using the aws/es service KMS key. Note that KMS will accept a KMS key ID but will return the key ARN.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelector
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
    public V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderLogPublishingOptions
{
    /// <summary>ARN of the Cloudwatch log group to which log needs to be published.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Reference to a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnRef")]
    public V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnRef? CloudwatchLogGroupArnRef { get; set; }

    /// <summary>Selector for a Group in cloudwatchlogs to populate cloudwatchLogGroupArn.</summary>
    [JsonPropertyName("cloudwatchLogGroupArnSelector")]
    public V1beta2DomainSpecInitProviderLogPublishingOptionsCloudwatchLogGroupArnSelector? CloudwatchLogGroupArnSelector { get; set; }

    /// <summary>Whether given log publishing option is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Type of Elasticsearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an elasticsearch_version of 6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running Elasticsearch 5.3 and later, Amazon ES takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions of Elasticsearch, Amazon ES takes daily automated snapshots.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderSnapshotOptions
{
    /// <summary>Hour during which the service takes an automated daily snapshot of the indices in the domain.</summary>
    [JsonPropertyName("automatedSnapshotStartHour")]
    public double? AutomatedSnapshotStartHour { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefsPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefsPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelector
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
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptions
{
    /// <summary>List of VPC Security Group IDs to be applied to the Elasticsearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsRefs")]
    public IList<V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsRefs>? SecurityGroupIdsRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdsSelector")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdsSelector? SecurityGroupIdsSelector { get; set; }

    /// <summary>List of VPC Subnet IDs for the Elasticsearch domain endpoints to be created in.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
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
public partial class V1beta2DomainSpecInitProvider
{
    /// <summary>IAM policy document specifying the access policies for the domain.</summary>
    [JsonPropertyName("accessPolicies")]
    public string? AccessPolicies { get; set; }

    /// <summary>Key-value string pairs to specify advanced configuration options.</summary>
    [JsonPropertyName("advancedOptions")]
    public IDictionary<string, string>? AdvancedOptions { get; set; }

    /// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityOptions")]
    public V1beta2DomainSpecInitProviderAdvancedSecurityOptions? AdvancedSecurityOptions { get; set; }

    /// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
    [JsonPropertyName("autoTuneOptions")]
    public V1beta2DomainSpecInitProviderAutoTuneOptions? AutoTuneOptions { get; set; }

    /// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
    [JsonPropertyName("clusterConfig")]
    public V1beta2DomainSpecInitProviderClusterConfig? ClusterConfig { get; set; }

    /// <summary>Configuration block for authenticating Kibana with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public V1beta2DomainSpecInitProviderCognitoOptions? CognitoOptions { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public V1beta2DomainSpecInitProviderDomainEndpointOptions? DomainEndpointOptions { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public V1beta2DomainSpecInitProviderEbsOptions? EbsOptions { get; set; }

    /// <summary>Version of Elasticsearch to deploy. Defaults to 1.5.</summary>
    [JsonPropertyName("elasticsearchVersion")]
    public string? ElasticsearchVersion { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public V1beta2DomainSpecInitProviderEncryptAtRest? EncryptAtRest { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta2DomainSpecInitProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public V1beta2DomainSpecInitProviderNodeToNodeEncryption? NodeToNodeEncryption { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running Elasticsearch 5.3 and later, Amazon ES takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions of Elasticsearch, Amazon ES takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public V1beta2DomainSpecInitProviderSnapshotOptions? SnapshotOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
    [JsonPropertyName("vpcOptions")]
    public V1beta2DomainSpecInitProviderVpcOptions? VpcOptions { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecManagementPoliciesEnum>))]
public enum V1beta2DomainSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DomainSpec defines the desired state of Domain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpec
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
    public V1beta2DomainSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DomainSpecForProvider ForProvider { get; set; }

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
    public V1beta2DomainSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DomainSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block for the main user. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAdvancedSecurityOptionsMasterUserOptions
{
    /// <summary>ARN for the main user. Only specify if internal_user_database_enabled is not set or set to false.</summary>
    [JsonPropertyName("masterUserArn")]
    public string? MasterUserArn { get; set; }

    /// <summary>Main user&apos;s username, which is stored in the Amazon Elasticsearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }
}

/// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAdvancedSecurityOptions
{
    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. If not set, defaults to false by the AWS API.</summary>
    [JsonPropertyName("internalUserDatabaseEnabled")]
    public bool? InternalUserDatabaseEnabled { get; set; }

    /// <summary>Configuration block for the main user. Detailed below.</summary>
    [JsonPropertyName("masterUserOptions")]
    public V1beta2DomainStatusAtProviderAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions { get; set; }
}

/// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAutoTuneOptionsMaintenanceScheduleDuration
{
    /// <summary>The unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>An integer specifying the value of the duration of an Auto-Tune maintenance window.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAutoTuneOptionsMaintenanceSchedule
{
    /// <summary>A cron expression specifying the recurrence pattern for an Auto-Tune maintenance schedule.</summary>
    [JsonPropertyName("cronExpressionForRecurrence")]
    public string? CronExpressionForRecurrence { get; set; }

    /// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
    [JsonPropertyName("duration")]
    public V1beta2DomainStatusAtProviderAutoTuneOptionsMaintenanceScheduleDuration? Duration { get; set; }

    /// <summary>Date and time at which to start the Auto-Tune maintenance schedule in RFC3339 format.</summary>
    [JsonPropertyName("startAt")]
    public string? StartAt { get; set; }
}

/// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAutoTuneOptions
{
    /// <summary>The Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta2DomainStatusAtProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }
}

/// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an Elasticsearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderClusterConfigZoneAwarenessConfig
{
    /// <summary>Number of Availability Zones for the domain to use with zone_awareness_enabled. Defaults to 2. Valid values: 2 or 3.</summary>
    [JsonPropertyName("availabilityZoneCount")]
    public double? AvailabilityZoneCount { get; set; }
}

/// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderClusterConfig
{
    /// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
    [JsonPropertyName("coldStorageOptions")]
    public V1beta2DomainStatusAtProviderClusterConfigColdStorageOptions? ColdStorageOptions { get; set; }

    /// <summary>Number of dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterCount")]
    public double? DedicatedMasterCount { get; set; }

    /// <summary>Whether dedicated main nodes are enabled for the cluster.</summary>
    [JsonPropertyName("dedicatedMasterEnabled")]
    public bool? DedicatedMasterEnabled { get; set; }

    /// <summary>Instance type of the dedicated main nodes in the cluster.</summary>
    [JsonPropertyName("dedicatedMasterType")]
    public string? DedicatedMasterType { get; set; }

    /// <summary>Number of instances in the cluster.</summary>
    [JsonPropertyName("instanceCount")]
    public double? InstanceCount { get; set; }

    /// <summary>Instance type of data nodes in the cluster.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the Elasticsearch cluster&apos;s warm nodes. Valid values are ultrawarm1.medium.elasticsearch, ultrawarm1.large.elasticsearch and ultrawarm1.xlarge.elasticsearch. warm_type can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmType")]
    public string? WarmType { get; set; }

    /// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
    [JsonPropertyName("zoneAwarenessConfig")]
    public V1beta2DomainStatusAtProviderClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig { get; set; }

    /// <summary>Whether zone awareness is enabled, set to true for multi-az deployment. To enable awareness with three Availability Zones, the availability_zone_count within the zone_awareness_config must be set to 3.</summary>
    [JsonPropertyName("zoneAwarenessEnabled")]
    public bool? ZoneAwarenessEnabled { get; set; }
}

/// <summary>Configuration block for authenticating Kibana with Cognito. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderCognitoOptions
{
    /// <summary>Whether Amazon Cognito authentication with Kibana is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonESCognitoAccess policy attached.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>ID of the Cognito User Pool to use.</summary>
    [JsonPropertyName("userPoolId")]
    public string? UserPoolId { get; set; }
}

/// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderDomainEndpointOptions
{
    /// <summary>Fully qualified domain for your custom endpoint.</summary>
    [JsonPropertyName("customEndpoint")]
    public string? CustomEndpoint { get; set; }

    /// <summary>ACM certificate ARN for your custom endpoint.</summary>
    [JsonPropertyName("customEndpointCertificateArn")]
    public string? CustomEndpointCertificateArn { get; set; }

    /// <summary>Whether to enable custom endpoint for the Elasticsearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. Valid values:  Policy-Min-TLS-1-0-2019-07, Policy-Min-TLS-1-2-2019-07, and Policy-Min-TLS-1-2-PFS-2023-10.</summary>
    [JsonPropertyName("tlsSecurityPolicy")]
    public string? TlsSecurityPolicy { get; set; }
}

/// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderEbsOptions
{
    /// <summary>Whether EBS volumes are attached to data nodes in the domain.</summary>
    [JsonPropertyName("ebsEnabled")]
    public bool? EbsEnabled { get; set; }

    /// <summary>Baseline input/output (I/O) performance of EBS volumes attached to data nodes. Applicable only for the GP3 and Provisioned IOPS EBS volume types.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Specifies the throughput (in MiB/s) of the EBS volumes attached to data nodes. Applicable only for the gp3 volume type.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of EBS volumes attached to data nodes (in GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of EBS volumes attached to data nodes.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderEncryptAtRest
{
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires elasticsearch_version 5.1 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the Elasticsearch domain with. If not specified then it defaults to using the aws/es service KMS key. Note that KMS will accept a KMS key ID but will return the key ARN.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderLogPublishingOptions
{
    /// <summary>ARN of the Cloudwatch log group to which log needs to be published.</summary>
    [JsonPropertyName("cloudwatchLogGroupArn")]
    public string? CloudwatchLogGroupArn { get; set; }

    /// <summary>Whether given log publishing option is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Type of Elasticsearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an elasticsearch_version of 6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running Elasticsearch 5.3 and later, Amazon ES takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions of Elasticsearch, Amazon ES takes daily automated snapshots.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderSnapshotOptions
{
    /// <summary>Hour during which the service takes an automated daily snapshot of the indices in the domain.</summary>
    [JsonPropertyName("automatedSnapshotStartHour")]
    public double? AutomatedSnapshotStartHour { get; set; }
}

/// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderVpcOptions
{
    /// <summary>If the domain was created inside a VPC, the names of the availability zones the configured subnet_ids were created inside.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>List of VPC Security Group IDs to be applied to the Elasticsearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>List of VPC Subnet IDs for the Elasticsearch domain endpoints to be created in.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>If the domain was created inside a VPC, the ID of the VPC.</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProvider
{
    /// <summary>IAM policy document specifying the access policies for the domain.</summary>
    [JsonPropertyName("accessPolicies")]
    public string? AccessPolicies { get; set; }

    /// <summary>Key-value string pairs to specify advanced configuration options.</summary>
    [JsonPropertyName("advancedOptions")]
    public IDictionary<string, string>? AdvancedOptions { get; set; }

    /// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityOptions")]
    public V1beta2DomainStatusAtProviderAdvancedSecurityOptions? AdvancedSecurityOptions { get; set; }

    /// <summary>ARN of the domain.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
    [JsonPropertyName("autoTuneOptions")]
    public V1beta2DomainStatusAtProviderAutoTuneOptions? AutoTuneOptions { get; set; }

    /// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
    [JsonPropertyName("clusterConfig")]
    public V1beta2DomainStatusAtProviderClusterConfig? ClusterConfig { get; set; }

    /// <summary>Configuration block for authenticating Kibana with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public V1beta2DomainStatusAtProviderCognitoOptions? CognitoOptions { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public V1beta2DomainStatusAtProviderDomainEndpointOptions? DomainEndpointOptions { get; set; }

    /// <summary>Unique identifier for the domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public V1beta2DomainStatusAtProviderEbsOptions? EbsOptions { get; set; }

    /// <summary>Version of Elasticsearch to deploy. Defaults to 1.5.</summary>
    [JsonPropertyName("elasticsearchVersion")]
    public string? ElasticsearchVersion { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public V1beta2DomainStatusAtProviderEncryptAtRest? EncryptAtRest { get; set; }

    /// <summary>Domain-specific endpoint used to submit index, search, and data upload requests.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Domain-specific endpoint for kibana without https scheme.</summary>
    [JsonPropertyName("kibanaEndpoint")]
    public string? KibanaEndpoint { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta2DomainStatusAtProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public V1beta2DomainStatusAtProviderNodeToNodeEncryption? NodeToNodeEncryption { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running Elasticsearch 5.3 and later, Amazon ES takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions of Elasticsearch, Amazon ES takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public V1beta2DomainStatusAtProviderSnapshotOptions? SnapshotOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
    [JsonPropertyName("vpcOptions")]
    public V1beta2DomainStatusAtProviderVpcOptions? VpcOptions { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusConditions
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

/// <summary>DomainStatus defines the observed state of Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DomainStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Domain is the Schema for the Domains API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DomainSpec>, IStatus<V1beta2DomainStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "elasticsearch.aws.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticsearch.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Domain";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainSpec defines the desired state of Domain</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DomainSpec Spec { get; set; }

    /// <summary>DomainStatus defines the observed state of Domain.</summary>
    [JsonPropertyName("status")]
    public V1beta2DomainStatus? Status { get; set; }
}