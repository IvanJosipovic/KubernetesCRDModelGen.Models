#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.opensearch.aws.upbound.io;
/// <summary>Domain is the Schema for the Domains API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DomainList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Domain>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DomainList";
    public const string KubeGroup = "opensearch.aws.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "opensearch.aws.upbound.io/v1beta2";

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

/// <summary>Configuration block for JWT authentication. Requires OpenSearch 2.11 or later. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAdvancedSecurityOptionsJwtOptions
{
    /// <summary>Whether JWT authentication is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>PEM-encoded public key used to verify JWT signatures.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>Element of the JWT assertion to use for roles. Default is roles.</summary>
    [JsonPropertyName("rolesKey")]
    public string? RolesKey { get; set; }

    /// <summary>Element of the JWT assertion to use for the user name. Default is sub.</summary>
    [JsonPropertyName("subjectKey")]
    public string? SubjectKey { get; set; }
}

/// <summary>Main user&apos;s password, which is stored in the Amazon OpenSearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
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

    /// <summary>Main user&apos;s username, which is stored in the Amazon OpenSearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }

    /// <summary>Main user&apos;s password, which is stored in the Amazon OpenSearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserPasswordSecretRef")]
    public V1beta2DomainSpecForProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef? MasterUserPasswordSecretRef { get; set; }
}

/// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAdvancedSecurityOptions
{
    /// <summary>Whether Anonymous auth is enabled. Enables fine-grained access control on an existing domain. Ignored unless advanced_security_options are enabled. Can only be enabled on an existing domain.</summary>
    [JsonPropertyName("anonymousAuthEnabled")]
    public bool? AnonymousAuthEnabled { get; set; }

    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. Default is false.</summary>
    [JsonPropertyName("internalUserDatabaseEnabled")]
    public bool? InternalUserDatabaseEnabled { get; set; }

    /// <summary>Configuration block for JWT authentication. Requires OpenSearch 2.11 or later. Detailed below.</summary>
    [JsonPropertyName("jwtOptions")]
    public V1beta2DomainSpecForProviderAdvancedSecurityOptionsJwtOptions? JwtOptions { get; set; }

    /// <summary>Configuration block for the main user. Detailed below.</summary>
    [JsonPropertyName("masterUserOptions")]
    public V1beta2DomainSpecForProviderAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions { get; set; }
}

/// <summary>Configuration block for parameters required for natural language query generation on the specified domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAimlOptionsNaturalLanguageQueryGenerationOptions
{
    /// <summary>The desired state of the natural language query generation feature. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }
}

/// <summary>Configuration block for parameters required to enable S3 vectors engine features on the specified domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAimlOptionsS3VectorsEngine
{
    /// <summary>Enables S3 vectors engine features.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for parameters required to enable GPU-accelerated vector search on the specified domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAimlOptionsServerlessVectorAcceleration
{
    /// <summary>Enables GPU-accelerated vector search for improved performance on vector workloads.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for parameters required to enable all machine learning features. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAimlOptions
{
    /// <summary>Configuration block for parameters required for natural language query generation on the specified domain.</summary>
    [JsonPropertyName("naturalLanguageQueryGenerationOptions")]
    public V1beta2DomainSpecForProviderAimlOptionsNaturalLanguageQueryGenerationOptions? NaturalLanguageQueryGenerationOptions { get; set; }

    /// <summary>Configuration block for parameters required to enable S3 vectors engine features on the specified domain.</summary>
    [JsonPropertyName("s3VectorsEngine")]
    public V1beta2DomainSpecForProviderAimlOptionsS3VectorsEngine? S3VectorsEngine { get; set; }

    /// <summary>Configuration block for parameters required to enable GPU-accelerated vector search on the specified domain.</summary>
    [JsonPropertyName("serverlessVectorAcceleration")]
    public V1beta2DomainSpecForProviderAimlOptionsServerlessVectorAcceleration? ServerlessVectorAcceleration { get; set; }
}

/// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderAutoTuneOptionsMaintenanceScheduleDuration
{
    /// <summary>Unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
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
    /// <summary>Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta2DomainSpecForProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }

    /// <summary>Whether to schedule Auto-Tune optimizations that require blue/green deployments during the domain&apos;s configured daily off-peak window. Defaults to false.</summary>
    [JsonPropertyName("useOffPeakWindow")]
    public bool? UseOffPeakWindow { get; set; }
}

/// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an OpenSearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Container to specify sizing of a node type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderClusterConfigNodeOptionsNodeConfig
{
    /// <summary>Number of nodes of a particular node type in the cluster.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Whether a particular node type is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The instance type of a particular node type in the cluster.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderClusterConfigNodeOptions
{
    /// <summary>Container to specify sizing of a node type.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2DomainSpecForProviderClusterConfigNodeOptionsNodeConfig? NodeConfig { get; set; }

    /// <summary>Type of node this configuration describes. Valid values: coordinator.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }
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

    /// <summary>Whether a multi-AZ domain is turned on with a standby AZ. For more information, see Configuring a multi-AZ domain in Amazon OpenSearch Service.</summary>
    [JsonPropertyName("multiAzWithStandbyEnabled")]
    public bool? MultiAzWithStandbyEnabled { get; set; }

    /// <summary>List of node options for the domain.</summary>
    [JsonPropertyName("nodeOptions")]
    public IList<V1beta2DomainSpecForProviderClusterConfigNodeOptions>? NodeOptions { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the OpenSearch cluster&apos;s warm nodes. Valid values are ultrawarm1.medium.search, ultrawarm1.large.search and ultrawarm1.xlarge.search. warm_type can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmType")]
    public string? WarmType { get; set; }

    /// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
    [JsonPropertyName("zoneAwarenessConfig")]
    public V1beta2DomainSpecForProviderClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig { get; set; }

    /// <summary>Whether zone awareness is enabled, set to true for multi-az deployment. To enable awareness with three Availability Zones, the availability_zone_count within the zone_awareness_config must be set to 3.</summary>
    [JsonPropertyName("zoneAwarenessEnabled")]
    public bool? ZoneAwarenessEnabled { get; set; }
}

/// <summary>Configuration block for authenticating dashboard with Cognito. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderCognitoOptions
{
    /// <summary>Whether Amazon Cognito authentication with Dashboard is enabled or not. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonOpenSearchServiceCognitoAccess policy attached.</summary>
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

    /// <summary>Whether to enable custom endpoint for the OpenSearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. For valid values, refer to the AWS documentation.</summary>
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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdSelector
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
    public V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderEncryptAtRest
{
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires an engine_version of OpenSearch_X.Y or Elasticsearch_5.1 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the Elasticsearch domain with. If not specified then it defaults to using the aws/es service KMS key. Note that KMS will accept a KMS key ID but will return the key ARN.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2DomainSpecForProviderEncryptAtRestKmsKeyIdSelector? KmsKeyIdSelector { get; set; }
}

/// <summary>Configuration block for enabling and managing IAM Identity Center integration within a domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderIdentityCenterOptions
{
    /// <summary>is set to true.</summary>
    [JsonPropertyName("enabledApiAccess")]
    public bool? EnabledApiAccess { get; set; }

    /// <summary>ARN of the domain.</summary>
    [JsonPropertyName("identityCenterInstanceArn")]
    public string? IdentityCenterInstanceArn { get; set; }

    /// <summary>Element of the JWT assertion to use for roles. Default is roles.</summary>
    [JsonPropertyName("rolesKey")]
    public string? RolesKey { get; set; }

    /// <summary>Element of the JWT assertion to use for the user name. Default is sub.</summary>
    [JsonPropertyName("subjectKey")]
    public string? SubjectKey { get; set; }
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

    /// <summary>Type of OpenSearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an engine_version of OpenSearch_X.Y or Elasticsearch_6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>10h window for updates</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime
{
    /// <summary>Starting hour of the 10-hour window for updates</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Starting minute of the 10-hour window for updates</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderOffPeakWindowOptionsOffPeakWindow
{
    /// <summary>10h window for updates</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta2DomainSpecForProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>Configuration to add Off Peak update options. (documentation). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderOffPeakWindowOptions
{
    /// <summary>Enabled disabled toggle for off-peak update window.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("offPeakWindow")]
    public V1beta2DomainSpecForProviderOffPeakWindowOptionsOffPeakWindow? OffPeakWindow { get; set; }
}

/// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running OpenSearch 5.3 and later, Amazon OpenSearch takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions, OpenSearch takes daily automated snapshots.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderSnapshotOptions
{
    /// <summary>Hour during which the service takes an automated daily snapshot of the indices in the domain.</summary>
    [JsonPropertyName("automatedSnapshotStartHour")]
    public double? AutomatedSnapshotStartHour { get; set; }
}

/// <summary>Software update options for the domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderSoftwareUpdateOptions
{
    /// <summary>Whether automatic service software updates are enabled for the domain. Defaults to false.</summary>
    [JsonPropertyName("autoSoftwareUpdateEnabled")]
    public bool? AutoSoftwareUpdateEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdSelector
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
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSubnetIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderVpcOptionsSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecForProviderVpcOptionsSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptionsSubnetIdSelector
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
    public V1beta2DomainSpecForProviderVpcOptionsSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProviderVpcOptions
{
    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta2DomainSpecForProviderVpcOptionsSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>List of VPC Security Group IDs to be applied to the OpenSearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta2DomainSpecForProviderVpcOptionsSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2DomainSpecForProviderVpcOptionsSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>List of VPC Subnet IDs for the OpenSearch domain endpoints to be created in.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecForProvider
{
    /// <summary>Key-value string pairs to specify advanced configuration options.</summary>
    [JsonPropertyName("advancedOptions")]
    public IDictionary<string, string>? AdvancedOptions { get; set; }

    /// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityOptions")]
    public V1beta2DomainSpecForProviderAdvancedSecurityOptions? AdvancedSecurityOptions { get; set; }

    /// <summary>Configuration block for parameters required to enable all machine learning features. Detailed below.</summary>
    [JsonPropertyName("aimlOptions")]
    public V1beta2DomainSpecForProviderAimlOptions? AimlOptions { get; set; }

    /// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
    [JsonPropertyName("autoTuneOptions")]
    public V1beta2DomainSpecForProviderAutoTuneOptions? AutoTuneOptions { get; set; }

    /// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
    [JsonPropertyName("clusterConfig")]
    public V1beta2DomainSpecForProviderClusterConfig? ClusterConfig { get; set; }

    /// <summary>Configuration block for authenticating dashboard with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public V1beta2DomainSpecForProviderCognitoOptions? CognitoOptions { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public V1beta2DomainSpecForProviderDomainEndpointOptions? DomainEndpointOptions { get; set; }

    /// <summary>Name of the domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public V1beta2DomainSpecForProviderEbsOptions? EbsOptions { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public V1beta2DomainSpecForProviderEncryptAtRest? EncryptAtRest { get; set; }

    /// <summary>while Elasticsearch has elasticsearch_version</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Configuration block for enabling and managing IAM Identity Center integration within a domain. Detailed below.</summary>
    [JsonPropertyName("identityCenterOptions")]
    public V1beta2DomainSpecForProviderIdentityCenterOptions? IdentityCenterOptions { get; set; }

    /// <summary>The IP address type for the endpoint. Valid values are ipv4 and dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta2DomainSpecForProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public V1beta2DomainSpecForProviderNodeToNodeEncryption? NodeToNodeEncryption { get; set; }

    /// <summary>Configuration to add Off Peak update options. (documentation). Detailed below.</summary>
    [JsonPropertyName("offPeakWindowOptions")]
    public V1beta2DomainSpecForProviderOffPeakWindowOptions? OffPeakWindowOptions { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running OpenSearch 5.3 and later, Amazon OpenSearch takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions, OpenSearch takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public V1beta2DomainSpecForProviderSnapshotOptions? SnapshotOptions { get; set; }

    /// <summary>Software update options for the domain. Detailed below.</summary>
    [JsonPropertyName("softwareUpdateOptions")]
    public V1beta2DomainSpecForProviderSoftwareUpdateOptions? SoftwareUpdateOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
    [JsonPropertyName("vpcOptions")]
    public V1beta2DomainSpecForProviderVpcOptions? VpcOptions { get; set; }
}

/// <summary>Configuration block for JWT authentication. Requires OpenSearch 2.11 or later. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAdvancedSecurityOptionsJwtOptions
{
    /// <summary>Whether JWT authentication is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>PEM-encoded public key used to verify JWT signatures.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>Element of the JWT assertion to use for roles. Default is roles.</summary>
    [JsonPropertyName("rolesKey")]
    public string? RolesKey { get; set; }

    /// <summary>Element of the JWT assertion to use for the user name. Default is sub.</summary>
    [JsonPropertyName("subjectKey")]
    public string? SubjectKey { get; set; }
}

/// <summary>Main user&apos;s password, which is stored in the Amazon OpenSearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
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

    /// <summary>Main user&apos;s username, which is stored in the Amazon OpenSearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }

    /// <summary>Main user&apos;s password, which is stored in the Amazon OpenSearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserPasswordSecretRef")]
    public V1beta2DomainSpecInitProviderAdvancedSecurityOptionsMasterUserOptionsMasterUserPasswordSecretRef? MasterUserPasswordSecretRef { get; set; }
}

/// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAdvancedSecurityOptions
{
    /// <summary>Whether Anonymous auth is enabled. Enables fine-grained access control on an existing domain. Ignored unless advanced_security_options are enabled. Can only be enabled on an existing domain.</summary>
    [JsonPropertyName("anonymousAuthEnabled")]
    public bool? AnonymousAuthEnabled { get; set; }

    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. Default is false.</summary>
    [JsonPropertyName("internalUserDatabaseEnabled")]
    public bool? InternalUserDatabaseEnabled { get; set; }

    /// <summary>Configuration block for JWT authentication. Requires OpenSearch 2.11 or later. Detailed below.</summary>
    [JsonPropertyName("jwtOptions")]
    public V1beta2DomainSpecInitProviderAdvancedSecurityOptionsJwtOptions? JwtOptions { get; set; }

    /// <summary>Configuration block for the main user. Detailed below.</summary>
    [JsonPropertyName("masterUserOptions")]
    public V1beta2DomainSpecInitProviderAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions { get; set; }
}

/// <summary>Configuration block for parameters required for natural language query generation on the specified domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAimlOptionsNaturalLanguageQueryGenerationOptions
{
    /// <summary>The desired state of the natural language query generation feature. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }
}

/// <summary>Configuration block for parameters required to enable S3 vectors engine features on the specified domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAimlOptionsS3VectorsEngine
{
    /// <summary>Enables S3 vectors engine features.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for parameters required to enable GPU-accelerated vector search on the specified domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAimlOptionsServerlessVectorAcceleration
{
    /// <summary>Enables GPU-accelerated vector search for improved performance on vector workloads.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for parameters required to enable all machine learning features. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAimlOptions
{
    /// <summary>Configuration block for parameters required for natural language query generation on the specified domain.</summary>
    [JsonPropertyName("naturalLanguageQueryGenerationOptions")]
    public V1beta2DomainSpecInitProviderAimlOptionsNaturalLanguageQueryGenerationOptions? NaturalLanguageQueryGenerationOptions { get; set; }

    /// <summary>Configuration block for parameters required to enable S3 vectors engine features on the specified domain.</summary>
    [JsonPropertyName("s3VectorsEngine")]
    public V1beta2DomainSpecInitProviderAimlOptionsS3VectorsEngine? S3VectorsEngine { get; set; }

    /// <summary>Configuration block for parameters required to enable GPU-accelerated vector search on the specified domain.</summary>
    [JsonPropertyName("serverlessVectorAcceleration")]
    public V1beta2DomainSpecInitProviderAimlOptionsServerlessVectorAcceleration? ServerlessVectorAcceleration { get; set; }
}

/// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderAutoTuneOptionsMaintenanceScheduleDuration
{
    /// <summary>Unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
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
    /// <summary>Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta2DomainSpecInitProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }

    /// <summary>Whether to schedule Auto-Tune optimizations that require blue/green deployments during the domain&apos;s configured daily off-peak window. Defaults to false.</summary>
    [JsonPropertyName("useOffPeakWindow")]
    public bool? UseOffPeakWindow { get; set; }
}

/// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an OpenSearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Container to specify sizing of a node type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderClusterConfigNodeOptionsNodeConfig
{
    /// <summary>Number of nodes of a particular node type in the cluster.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Whether a particular node type is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The instance type of a particular node type in the cluster.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderClusterConfigNodeOptions
{
    /// <summary>Container to specify sizing of a node type.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2DomainSpecInitProviderClusterConfigNodeOptionsNodeConfig? NodeConfig { get; set; }

    /// <summary>Type of node this configuration describes. Valid values: coordinator.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }
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

    /// <summary>Whether a multi-AZ domain is turned on with a standby AZ. For more information, see Configuring a multi-AZ domain in Amazon OpenSearch Service.</summary>
    [JsonPropertyName("multiAzWithStandbyEnabled")]
    public bool? MultiAzWithStandbyEnabled { get; set; }

    /// <summary>List of node options for the domain.</summary>
    [JsonPropertyName("nodeOptions")]
    public IList<V1beta2DomainSpecInitProviderClusterConfigNodeOptions>? NodeOptions { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the OpenSearch cluster&apos;s warm nodes. Valid values are ultrawarm1.medium.search, ultrawarm1.large.search and ultrawarm1.xlarge.search. warm_type can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmType")]
    public string? WarmType { get; set; }

    /// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
    [JsonPropertyName("zoneAwarenessConfig")]
    public V1beta2DomainSpecInitProviderClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig { get; set; }

    /// <summary>Whether zone awareness is enabled, set to true for multi-az deployment. To enable awareness with three Availability Zones, the availability_zone_count within the zone_awareness_config must be set to 3.</summary>
    [JsonPropertyName("zoneAwarenessEnabled")]
    public bool? ZoneAwarenessEnabled { get; set; }
}

/// <summary>Configuration block for authenticating dashboard with Cognito. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderCognitoOptions
{
    /// <summary>Whether Amazon Cognito authentication with Dashboard is enabled or not. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonOpenSearchServiceCognitoAccess policy attached.</summary>
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

    /// <summary>Whether to enable custom endpoint for the OpenSearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. For valid values, refer to the AWS documentation.</summary>
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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdSelector
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
    public V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderEncryptAtRest
{
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires an engine_version of OpenSearch_X.Y or Elasticsearch_5.1 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the Elasticsearch domain with. If not specified then it defaults to using the aws/es service KMS key. Note that KMS will accept a KMS key ID but will return the key ARN.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2DomainSpecInitProviderEncryptAtRestKmsKeyIdSelector? KmsKeyIdSelector { get; set; }
}

/// <summary>Configuration block for enabling and managing IAM Identity Center integration within a domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderIdentityCenterOptions
{
    /// <summary>is set to true.</summary>
    [JsonPropertyName("enabledApiAccess")]
    public bool? EnabledApiAccess { get; set; }

    /// <summary>ARN of the domain.</summary>
    [JsonPropertyName("identityCenterInstanceArn")]
    public string? IdentityCenterInstanceArn { get; set; }

    /// <summary>Element of the JWT assertion to use for roles. Default is roles.</summary>
    [JsonPropertyName("rolesKey")]
    public string? RolesKey { get; set; }

    /// <summary>Element of the JWT assertion to use for the user name. Default is sub.</summary>
    [JsonPropertyName("subjectKey")]
    public string? SubjectKey { get; set; }
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

    /// <summary>Type of OpenSearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an engine_version of OpenSearch_X.Y or Elasticsearch_6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>10h window for updates</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime
{
    /// <summary>Starting hour of the 10-hour window for updates</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Starting minute of the 10-hour window for updates</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderOffPeakWindowOptionsOffPeakWindow
{
    /// <summary>10h window for updates</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta2DomainSpecInitProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>Configuration to add Off Peak update options. (documentation). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderOffPeakWindowOptions
{
    /// <summary>Enabled disabled toggle for off-peak update window.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("offPeakWindow")]
    public V1beta2DomainSpecInitProviderOffPeakWindowOptionsOffPeakWindow? OffPeakWindow { get; set; }
}

/// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running OpenSearch 5.3 and later, Amazon OpenSearch takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions, OpenSearch takes daily automated snapshots.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderSnapshotOptions
{
    /// <summary>Hour during which the service takes an automated daily snapshot of the indices in the domain.</summary>
    [JsonPropertyName("automatedSnapshotStartHour")]
    public double? AutomatedSnapshotStartHour { get; set; }
}

/// <summary>Software update options for the domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderSoftwareUpdateOptions
{
    /// <summary>Whether automatic service software updates are enabled for the domain. Defaults to false.</summary>
    [JsonPropertyName("autoSoftwareUpdateEnabled")]
    public bool? AutoSoftwareUpdateEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdSelector
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
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSubnetIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DomainSpecInitProviderVpcOptionsSubnetIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptionsSubnetIdSelector
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
    public V1beta2DomainSpecInitProviderVpcOptionsSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainSpecInitProviderVpcOptions
{
    /// <summary>References to SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdRefs")]
    public IList<V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdRefs>? SecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupIds.</summary>
    [JsonPropertyName("securityGroupIdSelector")]
    public V1beta2DomainSpecInitProviderVpcOptionsSecurityGroupIdSelector? SecurityGroupIdSelector { get; set; }

    /// <summary>List of VPC Security Group IDs to be applied to the OpenSearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdRefs")]
    public IList<V1beta2DomainSpecInitProviderVpcOptionsSubnetIdRefs>? SubnetIdRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnetIds.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2DomainSpecInitProviderVpcOptionsSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>List of VPC Subnet IDs for the OpenSearch domain endpoints to be created in.</summary>
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
    /// <summary>Key-value string pairs to specify advanced configuration options.</summary>
    [JsonPropertyName("advancedOptions")]
    public IDictionary<string, string>? AdvancedOptions { get; set; }

    /// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityOptions")]
    public V1beta2DomainSpecInitProviderAdvancedSecurityOptions? AdvancedSecurityOptions { get; set; }

    /// <summary>Configuration block for parameters required to enable all machine learning features. Detailed below.</summary>
    [JsonPropertyName("aimlOptions")]
    public V1beta2DomainSpecInitProviderAimlOptions? AimlOptions { get; set; }

    /// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
    [JsonPropertyName("autoTuneOptions")]
    public V1beta2DomainSpecInitProviderAutoTuneOptions? AutoTuneOptions { get; set; }

    /// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
    [JsonPropertyName("clusterConfig")]
    public V1beta2DomainSpecInitProviderClusterConfig? ClusterConfig { get; set; }

    /// <summary>Configuration block for authenticating dashboard with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public V1beta2DomainSpecInitProviderCognitoOptions? CognitoOptions { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public V1beta2DomainSpecInitProviderDomainEndpointOptions? DomainEndpointOptions { get; set; }

    /// <summary>Name of the domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public V1beta2DomainSpecInitProviderEbsOptions? EbsOptions { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public V1beta2DomainSpecInitProviderEncryptAtRest? EncryptAtRest { get; set; }

    /// <summary>while Elasticsearch has elasticsearch_version</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Configuration block for enabling and managing IAM Identity Center integration within a domain. Detailed below.</summary>
    [JsonPropertyName("identityCenterOptions")]
    public V1beta2DomainSpecInitProviderIdentityCenterOptions? IdentityCenterOptions { get; set; }

    /// <summary>The IP address type for the endpoint. Valid values are ipv4 and dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta2DomainSpecInitProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public V1beta2DomainSpecInitProviderNodeToNodeEncryption? NodeToNodeEncryption { get; set; }

    /// <summary>Configuration to add Off Peak update options. (documentation). Detailed below.</summary>
    [JsonPropertyName("offPeakWindowOptions")]
    public V1beta2DomainSpecInitProviderOffPeakWindowOptions? OffPeakWindowOptions { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running OpenSearch 5.3 and later, Amazon OpenSearch takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions, OpenSearch takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public V1beta2DomainSpecInitProviderSnapshotOptions? SnapshotOptions { get; set; }

    /// <summary>Software update options for the domain. Detailed below.</summary>
    [JsonPropertyName("softwareUpdateOptions")]
    public V1beta2DomainSpecInitProviderSoftwareUpdateOptions? SoftwareUpdateOptions { get; set; }

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

/// <summary>Configuration block for JWT authentication. Requires OpenSearch 2.11 or later. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAdvancedSecurityOptionsJwtOptions
{
    /// <summary>Whether JWT authentication is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>PEM-encoded public key used to verify JWT signatures.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>Element of the JWT assertion to use for roles. Default is roles.</summary>
    [JsonPropertyName("rolesKey")]
    public string? RolesKey { get; set; }

    /// <summary>Element of the JWT assertion to use for the user name. Default is sub.</summary>
    [JsonPropertyName("subjectKey")]
    public string? SubjectKey { get; set; }
}

/// <summary>Configuration block for the main user. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAdvancedSecurityOptionsMasterUserOptions
{
    /// <summary>ARN for the main user. Only specify if internal_user_database_enabled is not set or set to false.</summary>
    [JsonPropertyName("masterUserArn")]
    public string? MasterUserArn { get; set; }

    /// <summary>Main user&apos;s username, which is stored in the Amazon OpenSearch Service domain&apos;s internal database. Only specify if internal_user_database_enabled is set to true.</summary>
    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }
}

/// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAdvancedSecurityOptions
{
    /// <summary>Whether Anonymous auth is enabled. Enables fine-grained access control on an existing domain. Ignored unless advanced_security_options are enabled. Can only be enabled on an existing domain.</summary>
    [JsonPropertyName("anonymousAuthEnabled")]
    public bool? AnonymousAuthEnabled { get; set; }

    /// <summary>Whether advanced security is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Whether the internal user database is enabled. Default is false.</summary>
    [JsonPropertyName("internalUserDatabaseEnabled")]
    public bool? InternalUserDatabaseEnabled { get; set; }

    /// <summary>Configuration block for JWT authentication. Requires OpenSearch 2.11 or later. Detailed below.</summary>
    [JsonPropertyName("jwtOptions")]
    public V1beta2DomainStatusAtProviderAdvancedSecurityOptionsJwtOptions? JwtOptions { get; set; }

    /// <summary>Configuration block for the main user. Detailed below.</summary>
    [JsonPropertyName("masterUserOptions")]
    public V1beta2DomainStatusAtProviderAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions { get; set; }
}

/// <summary>Configuration block for parameters required for natural language query generation on the specified domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAimlOptionsNaturalLanguageQueryGenerationOptions
{
    /// <summary>The desired state of the natural language query generation feature. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }
}

/// <summary>Configuration block for parameters required to enable S3 vectors engine features on the specified domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAimlOptionsS3VectorsEngine
{
    /// <summary>Enables S3 vectors engine features.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for parameters required to enable GPU-accelerated vector search on the specified domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAimlOptionsServerlessVectorAcceleration
{
    /// <summary>Enables GPU-accelerated vector search for improved performance on vector workloads.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Configuration block for parameters required to enable all machine learning features. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAimlOptions
{
    /// <summary>Configuration block for parameters required for natural language query generation on the specified domain.</summary>
    [JsonPropertyName("naturalLanguageQueryGenerationOptions")]
    public V1beta2DomainStatusAtProviderAimlOptionsNaturalLanguageQueryGenerationOptions? NaturalLanguageQueryGenerationOptions { get; set; }

    /// <summary>Configuration block for parameters required to enable S3 vectors engine features on the specified domain.</summary>
    [JsonPropertyName("s3VectorsEngine")]
    public V1beta2DomainStatusAtProviderAimlOptionsS3VectorsEngine? S3VectorsEngine { get; set; }

    /// <summary>Configuration block for parameters required to enable GPU-accelerated vector search on the specified domain.</summary>
    [JsonPropertyName("serverlessVectorAcceleration")]
    public V1beta2DomainStatusAtProviderAimlOptionsServerlessVectorAcceleration? ServerlessVectorAcceleration { get; set; }
}

/// <summary>Configuration block for the duration of the Auto-Tune maintenance window. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderAutoTuneOptionsMaintenanceScheduleDuration
{
    /// <summary>Unit of time specifying the duration of an Auto-Tune maintenance window. Valid values: HOURS.</summary>
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
    /// <summary>Auto-Tune desired state for the domain. Valid values: ENABLED or DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    /// <summary>Configuration block for Auto-Tune maintenance windows. Can be specified multiple times for each maintenance window. Detailed below.</summary>
    [JsonPropertyName("maintenanceSchedule")]
    public IList<V1beta2DomainStatusAtProviderAutoTuneOptionsMaintenanceSchedule>? MaintenanceSchedule { get; set; }

    /// <summary>Whether to roll back to default Auto-Tune settings when disabling Auto-Tune. Valid values: DEFAULT_ROLLBACK or NO_ROLLBACK.</summary>
    [JsonPropertyName("rollbackOnDisable")]
    public string? RollbackOnDisable { get; set; }

    /// <summary>Whether to schedule Auto-Tune optimizations that require blue/green deployments during the domain&apos;s configured daily off-peak window. Defaults to false.</summary>
    [JsonPropertyName("useOffPeakWindow")]
    public bool? UseOffPeakWindow { get; set; }
}

/// <summary>Configuration block containing cold storage configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderClusterConfigColdStorageOptions
{
    /// <summary>Boolean to enable cold storage for an OpenSearch domain. Defaults to false. Master and ultrawarm nodes must be enabled for cold storage.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Container to specify sizing of a node type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderClusterConfigNodeOptionsNodeConfig
{
    /// <summary>Number of nodes of a particular node type in the cluster.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Whether a particular node type is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The instance type of a particular node type in the cluster.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderClusterConfigNodeOptions
{
    /// <summary>Container to specify sizing of a node type.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta2DomainStatusAtProviderClusterConfigNodeOptionsNodeConfig? NodeConfig { get; set; }

    /// <summary>Type of node this configuration describes. Valid values: coordinator.</summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }
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

    /// <summary>Whether a multi-AZ domain is turned on with a standby AZ. For more information, see Configuring a multi-AZ domain in Amazon OpenSearch Service.</summary>
    [JsonPropertyName("multiAzWithStandbyEnabled")]
    public bool? MultiAzWithStandbyEnabled { get; set; }

    /// <summary>List of node options for the domain.</summary>
    [JsonPropertyName("nodeOptions")]
    public IList<V1beta2DomainStatusAtProviderClusterConfigNodeOptions>? NodeOptions { get; set; }

    /// <summary>Number of warm nodes in the cluster. Valid values are between 2 and 150. warm_count can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmCount")]
    public double? WarmCount { get; set; }

    /// <summary>Whether to enable warm storage.</summary>
    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    /// <summary>Instance type for the OpenSearch cluster&apos;s warm nodes. Valid values are ultrawarm1.medium.search, ultrawarm1.large.search and ultrawarm1.xlarge.search. warm_type can be only and must be set when warm_enabled is set to true.</summary>
    [JsonPropertyName("warmType")]
    public string? WarmType { get; set; }

    /// <summary>Configuration block containing zone awareness settings. Detailed below.</summary>
    [JsonPropertyName("zoneAwarenessConfig")]
    public V1beta2DomainStatusAtProviderClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig { get; set; }

    /// <summary>Whether zone awareness is enabled, set to true for multi-az deployment. To enable awareness with three Availability Zones, the availability_zone_count within the zone_awareness_config must be set to 3.</summary>
    [JsonPropertyName("zoneAwarenessEnabled")]
    public bool? ZoneAwarenessEnabled { get; set; }
}

/// <summary>Configuration block for authenticating dashboard with Cognito. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderCognitoOptions
{
    /// <summary>Whether Amazon Cognito authentication with Dashboard is enabled or not. Default is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>ID of the Cognito Identity Pool to use.</summary>
    [JsonPropertyName("identityPoolId")]
    public string? IdentityPoolId { get; set; }

    /// <summary>ARN of the IAM role that has the AmazonOpenSearchServiceCognitoAccess policy attached.</summary>
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

    /// <summary>Whether to enable custom endpoint for the OpenSearch domain.</summary>
    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    /// <summary>Whether or not to require HTTPS. Defaults to true.</summary>
    [JsonPropertyName("enforceHttps")]
    public bool? EnforceHttps { get; set; }

    /// <summary>Name of the TLS security policy that needs to be applied to the HTTPS endpoint. For valid values, refer to the AWS documentation.</summary>
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
    /// <summary>Whether to enable encryption at rest. If the encrypt_at_rest block is not provided then this defaults to false. Enabling encryption on new domains requires an engine_version of OpenSearch_X.Y or Elasticsearch_5.1 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>KMS key ARN to encrypt the Elasticsearch domain with. If not specified then it defaults to using the aws/es service KMS key. Note that KMS will accept a KMS key ID but will return the key ARN.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Configuration block for enabling and managing IAM Identity Center integration within a domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderIdentityCenterOptions
{
    /// <summary>is set to true.</summary>
    [JsonPropertyName("enabledApiAccess")]
    public bool? EnabledApiAccess { get; set; }

    /// <summary>ARN of the domain.</summary>
    [JsonPropertyName("identityCenterInstanceArn")]
    public string? IdentityCenterInstanceArn { get; set; }

    /// <summary>Element of the JWT assertion to use for roles. Default is roles.</summary>
    [JsonPropertyName("rolesKey")]
    public string? RolesKey { get; set; }

    /// <summary>Element of the JWT assertion to use for the user name. Default is sub.</summary>
    [JsonPropertyName("subjectKey")]
    public string? SubjectKey { get; set; }
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

    /// <summary>Type of OpenSearch log. Valid values: INDEX_SLOW_LOGS, SEARCH_SLOW_LOGS, ES_APPLICATION_LOGS, AUDIT_LOGS.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderNodeToNodeEncryption
{
    /// <summary>Whether to enable node-to-node encryption. If the node_to_node_encryption block is not provided then this defaults to false. Enabling node-to-node encryption of a new domain requires an engine_version of OpenSearch_X.Y or Elasticsearch_6.0 or greater.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>10h window for updates</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime
{
    /// <summary>Starting hour of the 10-hour window for updates</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Starting minute of the 10-hour window for updates</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderOffPeakWindowOptionsOffPeakWindow
{
    /// <summary>10h window for updates</summary>
    [JsonPropertyName("windowStartTime")]
    public V1beta2DomainStatusAtProviderOffPeakWindowOptionsOffPeakWindowWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>Configuration to add Off Peak update options. (documentation). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderOffPeakWindowOptions
{
    /// <summary>Enabled disabled toggle for off-peak update window.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("offPeakWindow")]
    public V1beta2DomainStatusAtProviderOffPeakWindowOptionsOffPeakWindow? OffPeakWindow { get; set; }
}

/// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running OpenSearch 5.3 and later, Amazon OpenSearch takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions, OpenSearch takes daily automated snapshots.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderSnapshotOptions
{
    /// <summary>Hour during which the service takes an automated daily snapshot of the indices in the domain.</summary>
    [JsonPropertyName("automatedSnapshotStartHour")]
    public double? AutomatedSnapshotStartHour { get; set; }
}

/// <summary>Software update options for the domain. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderSoftwareUpdateOptions
{
    /// <summary>Whether automatic service software updates are enabled for the domain. Defaults to false.</summary>
    [JsonPropertyName("autoSoftwareUpdateEnabled")]
    public bool? AutoSoftwareUpdateEnabled { get; set; }
}

/// <summary>Configuration block for VPC related options. Adding or removing this configuration forces a new resource (documentation). Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DomainStatusAtProviderVpcOptions
{
    /// <summary>If the domain was created inside a VPC, the names of the availability zones the configured subnet_ids were created inside.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>List of VPC Security Group IDs to be applied to the OpenSearch domain endpoints. If omitted, the default Security Group for the VPC will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>List of VPC Subnet IDs for the OpenSearch domain endpoints to be created in.</summary>
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
    /// <summary>, are prefaced with es: for both.</summary>
    [JsonPropertyName("accessPolicies")]
    public string? AccessPolicies { get; set; }

    /// <summary>Key-value string pairs to specify advanced configuration options.</summary>
    [JsonPropertyName("advancedOptions")]
    public IDictionary<string, string>? AdvancedOptions { get; set; }

    /// <summary>Configuration block for fine-grained access control. Detailed below.</summary>
    [JsonPropertyName("advancedSecurityOptions")]
    public V1beta2DomainStatusAtProviderAdvancedSecurityOptions? AdvancedSecurityOptions { get; set; }

    /// <summary>Configuration block for parameters required to enable all machine learning features. Detailed below.</summary>
    [JsonPropertyName("aimlOptions")]
    public V1beta2DomainStatusAtProviderAimlOptions? AimlOptions { get; set; }

    /// <summary>ARN of the domain.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block for the Auto-Tune options of the domain. Detailed below.</summary>
    [JsonPropertyName("autoTuneOptions")]
    public V1beta2DomainStatusAtProviderAutoTuneOptions? AutoTuneOptions { get; set; }

    /// <summary>Configuration block for the cluster of the domain. Detailed below.</summary>
    [JsonPropertyName("clusterConfig")]
    public V1beta2DomainStatusAtProviderClusterConfig? ClusterConfig { get; set; }

    /// <summary>Configuration block for authenticating dashboard with Cognito. Detailed below.</summary>
    [JsonPropertyName("cognitoOptions")]
    public V1beta2DomainStatusAtProviderCognitoOptions? CognitoOptions { get; set; }

    /// <summary>Domain-specific endpoint for Dashboard without https scheme.</summary>
    [JsonPropertyName("dashboardEndpoint")]
    public string? DashboardEndpoint { get; set; }

    /// <summary>V2 domain endpoint for Dashboard that works with both IPv4 and IPv6 addresses, without https scheme.</summary>
    [JsonPropertyName("dashboardEndpointV2")]
    public string? DashboardEndpointV2 { get; set; }

    /// <summary>Configuration block for domain endpoint HTTP(S) related options. Detailed below.</summary>
    [JsonPropertyName("domainEndpointOptions")]
    public V1beta2DomainStatusAtProviderDomainEndpointOptions? DomainEndpointOptions { get; set; }

    /// <summary>Dual stack hosted zone ID for the domain.</summary>
    [JsonPropertyName("domainEndpointV2HostedZoneId")]
    public string? DomainEndpointV2HostedZoneId { get; set; }

    /// <summary>Unique identifier for the domain.</summary>
    [JsonPropertyName("domainId")]
    public string? DomainId { get; set; }

    /// <summary>Name of the domain.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>Configuration block for EBS related options, may be required based on chosen instance size. Detailed below.</summary>
    [JsonPropertyName("ebsOptions")]
    public V1beta2DomainStatusAtProviderEbsOptions? EbsOptions { get; set; }

    /// <summary>Configuration block for encrypt at rest options. Only available for certain instance types. Detailed below.</summary>
    [JsonPropertyName("encryptAtRest")]
    public V1beta2DomainStatusAtProviderEncryptAtRest? EncryptAtRest { get; set; }

    /// <summary>Domain-specific endpoint used to submit index, search, and data upload requests.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>V2 domain endpoint that works with both IPv4 and IPv6 addresses, used to submit index, search, and data upload requests.</summary>
    [JsonPropertyName("endpointV2")]
    public string? EndpointV2 { get; set; }

    /// <summary>while Elasticsearch has elasticsearch_version</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block for enabling and managing IAM Identity Center integration within a domain. Detailed below.</summary>
    [JsonPropertyName("identityCenterOptions")]
    public V1beta2DomainStatusAtProviderIdentityCenterOptions? IdentityCenterOptions { get; set; }

    /// <summary>The IP address type for the endpoint. Valid values are ipv4 and dualstack.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Configuration block for publishing slow and application logs to CloudWatch Logs. This block can be declared multiple times, for each log_type, within the same resource. Detailed below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta2DomainStatusAtProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>Configuration block for node-to-node encryption options. Detailed below.</summary>
    [JsonPropertyName("nodeToNodeEncryption")]
    public V1beta2DomainStatusAtProviderNodeToNodeEncryption? NodeToNodeEncryption { get; set; }

    /// <summary>Configuration to add Off Peak update options. (documentation). Detailed below.</summary>
    [JsonPropertyName("offPeakWindowOptions")]
    public V1beta2DomainStatusAtProviderOffPeakWindowOptions? OffPeakWindowOptions { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block for snapshot related options. Detailed below. DEPRECATED. For domains running OpenSearch 5.3 and later, Amazon OpenSearch takes hourly automated snapshots, making this setting irrelevant. For domains running earlier versions, OpenSearch takes daily automated snapshots.</summary>
    [JsonPropertyName("snapshotOptions")]
    public V1beta2DomainStatusAtProviderSnapshotOptions? SnapshotOptions { get; set; }

    /// <summary>Software update options for the domain. Detailed below.</summary>
    [JsonPropertyName("softwareUpdateOptions")]
    public V1beta2DomainStatusAtProviderSoftwareUpdateOptions? SoftwareUpdateOptions { get; set; }

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
    public const string KubeGroup = "opensearch.aws.upbound.io";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "opensearch.aws.upbound.io/v1beta2";

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