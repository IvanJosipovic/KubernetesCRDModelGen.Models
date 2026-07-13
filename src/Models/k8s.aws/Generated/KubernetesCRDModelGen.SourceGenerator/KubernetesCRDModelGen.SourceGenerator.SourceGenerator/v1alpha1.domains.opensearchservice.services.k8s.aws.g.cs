#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.opensearchservice.services.k8s.aws;
/// <summary>Domain is the Schema for the Domains API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DomainList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Domain>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DomainList";
    public const string KubeGroup = "opensearchservice.services.k8s.aws";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "opensearchservice.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DomainList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Domain objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Domain> Items { get; set; }
}

/// <summary>
/// The JWT authentication and authorization configuration for an Amazon OpenSearch
/// Service domain.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecAdvancedSecurityOptionsJwtOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    [JsonPropertyName("rolesKey")]
    public string? RolesKey { get; set; }

    [JsonPropertyName("subjectKey")]
    public string? SubjectKey { get; set; }
}

/// <summary>
/// SecretKeyReference combines a k8s corev1.SecretReference with a
/// specific key within the referred-to Secret
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecAdvancedSecurityOptionsMasterUserOptionsMasterUserPassword
{
    /// <summary>Key is the key within the secret</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>name is unique within a namespace to reference a secret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>namespace defines the space within which the secret name must be unique.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Credentials for the master user for a domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecAdvancedSecurityOptionsMasterUserOptions
{
    /// <summary>
    /// The Amazon Resource Name (ARN) of the domain. See Identifiers for IAM Entities
    /// (https://docs.aws.amazon.com/IAM/latest/UserGuide/index.html) in Using Amazon
    /// Web Services Identity and Access Management for more information.
    /// </summary>
    [JsonPropertyName("masterUserARN")]
    public string? MasterUserARN { get; set; }

    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }

    /// <summary>
    /// SecretKeyReference combines a k8s corev1.SecretReference with a
    /// specific key within the referred-to Secret
    /// </summary>
    [JsonPropertyName("masterUserPassword")]
    public V1alpha1DomainSpecAdvancedSecurityOptionsMasterUserOptionsMasterUserPassword? MasterUserPassword { get; set; }
}

/// <summary>The SAML identity povider information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecAdvancedSecurityOptionsSAMLOptionsIdp
{
    [JsonPropertyName("entityID")]
    public string? EntityID { get; set; }

    [JsonPropertyName("metadataContent")]
    public string? MetadataContent { get; set; }
}

/// <summary>The SAML authentication configuration for an Amazon OpenSearch Service domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecAdvancedSecurityOptionsSAMLOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The SAML identity povider information.</summary>
    [JsonPropertyName("idp")]
    public V1alpha1DomainSpecAdvancedSecurityOptionsSAMLOptionsIdp? Idp { get; set; }

    [JsonPropertyName("masterBackendRole")]
    public string? MasterBackendRole { get; set; }

    [JsonPropertyName("masterUserName")]
    public string? MasterUserName { get; set; }

    [JsonPropertyName("rolesKey")]
    public string? RolesKey { get; set; }

    [JsonPropertyName("sessionTimeoutMinutes")]
    public long? SessionTimeoutMinutes { get; set; }

    [JsonPropertyName("subjectKey")]
    public string? SubjectKey { get; set; }
}

/// <summary>Options for fine-grained access control.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecAdvancedSecurityOptions
{
    [JsonPropertyName("anonymousAuthEnabled")]
    public bool? AnonymousAuthEnabled { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("internalUserDatabaseEnabled")]
    public bool? InternalUserDatabaseEnabled { get; set; }

    /// <summary>
    /// The JWT authentication and authorization configuration for an Amazon OpenSearch
    /// Service domain.
    /// </summary>
    [JsonPropertyName("jwtOptions")]
    public V1alpha1DomainSpecAdvancedSecurityOptionsJwtOptions? JwtOptions { get; set; }

    /// <summary>Credentials for the master user for a domain.</summary>
    [JsonPropertyName("masterUserOptions")]
    public V1alpha1DomainSpecAdvancedSecurityOptionsMasterUserOptions? MasterUserOptions { get; set; }

    /// <summary>The SAML authentication configuration for an Amazon OpenSearch Service domain.</summary>
    [JsonPropertyName("sAMLOptions")]
    public V1alpha1DomainSpecAdvancedSecurityOptionsSAMLOptions? SAMLOptions { get; set; }
}

/// <summary>
/// Container for parameters required to enable the natural language query generation
/// feature.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecAimlOptionsNaturalLanguageQueryGenerationOptions
{
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }
}

/// <summary>Options for all machine learning features for the specified domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecAimlOptions
{
    /// <summary>
    /// Container for parameters required to enable the natural language query generation
    /// feature.
    /// </summary>
    [JsonPropertyName("naturalLanguageQueryGenerationOptions")]
    public V1alpha1DomainSpecAimlOptionsNaturalLanguageQueryGenerationOptions? NaturalLanguageQueryGenerationOptions { get; set; }
}

/// <summary>
/// The duration of a maintenance schedule. For more information, see Auto-Tune
/// for Amazon OpenSearch Service (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecAutoTuneOptionsMaintenanceSchedulesDuration
{
    /// <summary>The unit of a maintenance schedule duration. Valid value is HOUR.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Integer that specifies the value of a maintenance schedule duration.</summary>
    [JsonPropertyName("value")]
    public long? Value { get; set; }
}

/// <summary>
/// This object is deprecated. Use the domain&apos;s off-peak window (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/off-peak.html)
/// to schedule Auto-Tune optimizations. For migration instructions, see Migrating
/// from Auto-Tune maintenance windows (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/off-peak.html#off-peak-migrate).
/// 
/// The Auto-Tune maintenance schedule. For more information, see Auto-Tune for
/// Amazon OpenSearch Service (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecAutoTuneOptionsMaintenanceSchedules
{
    [JsonPropertyName("cronExpressionForRecurrence")]
    public string? CronExpressionForRecurrence { get; set; }

    /// <summary>
    /// The duration of a maintenance schedule. For more information, see Auto-Tune
    /// for Amazon OpenSearch Service (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html).
    /// </summary>
    [JsonPropertyName("duration")]
    public V1alpha1DomainSpecAutoTuneOptionsMaintenanceSchedulesDuration? Duration { get; set; }

    [JsonPropertyName("startAt")]
    public DateTime? StartAt { get; set; }
}

/// <summary>Options for Auto-Tune.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecAutoTuneOptions
{
    /// <summary>The Auto-Tune desired state. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("desiredState")]
    public string? DesiredState { get; set; }

    [JsonPropertyName("maintenanceSchedules")]
    public IList<V1alpha1DomainSpecAutoTuneOptionsMaintenanceSchedules>? MaintenanceSchedules { get; set; }

    [JsonPropertyName("useOffPeakWindow")]
    public bool? UseOffPeakWindow { get; set; }
}

/// <summary>
/// Container for the parameters required to enable cold storage for an OpenSearch
/// Service domain. For more information, see Cold storage for Amazon OpenSearch
/// Service (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cold-storage.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecClusterConfigColdStorageOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The zone awareness configuration for an Amazon OpenSearch Service domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecClusterConfigZoneAwarenessConfig
{
    [JsonPropertyName("availabilityZoneCount")]
    public long? AvailabilityZoneCount { get; set; }
}

/// <summary>Container for the cluster configuration of a domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecClusterConfig
{
    /// <summary>
    /// Container for the parameters required to enable cold storage for an OpenSearch
    /// Service domain. For more information, see Cold storage for Amazon OpenSearch
    /// Service (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cold-storage.html).
    /// </summary>
    [JsonPropertyName("coldStorageOptions")]
    public V1alpha1DomainSpecClusterConfigColdStorageOptions? ColdStorageOptions { get; set; }

    [JsonPropertyName("dedicatedMasterCount")]
    public long? DedicatedMasterCount { get; set; }

    [JsonPropertyName("dedicatedMasterEnabled")]
    public bool? DedicatedMasterEnabled { get; set; }

    [JsonPropertyName("dedicatedMasterType")]
    public string? DedicatedMasterType { get; set; }

    [JsonPropertyName("instanceCount")]
    public long? InstanceCount { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("multiAZWithStandbyEnabled")]
    public bool? MultiAZWithStandbyEnabled { get; set; }

    [JsonPropertyName("warmCount")]
    public long? WarmCount { get; set; }

    [JsonPropertyName("warmEnabled")]
    public bool? WarmEnabled { get; set; }

    [JsonPropertyName("warmType")]
    public string? WarmType { get; set; }

    /// <summary>The zone awareness configuration for an Amazon OpenSearch Service domain.</summary>
    [JsonPropertyName("zoneAwarenessConfig")]
    public V1alpha1DomainSpecClusterConfigZoneAwarenessConfig? ZoneAwarenessConfig { get; set; }

    [JsonPropertyName("zoneAwarenessEnabled")]
    public bool? ZoneAwarenessEnabled { get; set; }
}

/// <summary>
/// Key-value pairs to configure Amazon Cognito authentication. For more information,
/// see Configuring Amazon Cognito authentication for OpenSearch Dashboards (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cognito-auth.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecCognitoOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("identityPoolID")]
    public string? IdentityPoolID { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("userPoolID")]
    public string? UserPoolID { get; set; }
}

/// <summary>
/// Additional options for the domain endpoint, such as whether to require HTTPS
/// for all traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecDomainEndpointOptions
{
    [JsonPropertyName("customEndpoint")]
    public string? CustomEndpoint { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the domain. See Identifiers for IAM Entities
    /// (https://docs.aws.amazon.com/IAM/latest/UserGuide/index.html) in Using Amazon
    /// Web Services Identity and Access Management for more information.
    /// </summary>
    [JsonPropertyName("customEndpointCertificateARN")]
    public string? CustomEndpointCertificateARN { get; set; }

    [JsonPropertyName("customEndpointEnabled")]
    public bool? CustomEndpointEnabled { get; set; }

    [JsonPropertyName("enforceHTTPS")]
    public bool? EnforceHTTPS { get; set; }

    [JsonPropertyName("tlsSecurityPolicy")]
    public string? TlsSecurityPolicy { get; set; }
}

/// <summary>
/// Container for the parameters required to enable EBS-based storage for an
/// OpenSearch Service domain.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecEbsOptions
{
    [JsonPropertyName("ebsEnabled")]
    public bool? EbsEnabled { get; set; }

    [JsonPropertyName("iops")]
    public long? Iops { get; set; }

    [JsonPropertyName("throughput")]
    public long? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public long? VolumeSize { get; set; }

    /// <summary>
    /// The type of EBS volume that a domain uses. For more information, see Configuring
    /// EBS-based storage (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/opensearch-createupdatedomains.html#opensearch-createdomain-configure-ebs).
    /// </summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Key-value pairs to enable encryption at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecEncryptionAtRestOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }
}

/// <summary>
/// Specifies whether the Amazon OpenSearch Service domain publishes the OpenSearch
/// application and slow logs to Amazon CloudWatch. For more information, see
/// Monitoring OpenSearch logs with Amazon CloudWatch Logs (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createdomain-configure-slow-logs.html).
/// 
/// After you enable log publishing, you still have to enable the collection
/// of slow logs using the OpenSearch REST API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecLogPublishingOptions
{
    /// <summary>ARN of the Cloudwatch log group to publish logs to.</summary>
    [JsonPropertyName("cloudWatchLogsLogGroupARN")]
    public string? CloudWatchLogsLogGroupARN { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Enables node-to-node encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecNodeToNodeEncryptionOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The desired start time for an off-peak maintenance window (https://docs.aws.amazon.com/opensearch-service/latest/APIReference/API_OffPeakWindow.html).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecOffPeakWindowOptionsOffPeakWindowWindowStartTime
{
    [JsonPropertyName("hours")]
    public long? Hours { get; set; }

    [JsonPropertyName("minutes")]
    public long? Minutes { get; set; }
}

/// <summary>
/// A custom 10-hour, low-traffic window during which OpenSearch Service can
/// perform mandatory configuration changes on the domain. These actions can
/// include scheduled service software updates and blue/green Auto-Tune enhancements.
/// OpenSearch Service will schedule these actions during the window that you
/// specify.
/// 
/// If you don&apos;t specify a window start time, it defaults to 10:00 P.M. local
/// time.
/// 
/// For more information, see Defining off-peak maintenance windows for Amazon
/// OpenSearch Service (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/off-peak.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecOffPeakWindowOptionsOffPeakWindow
{
    /// <summary>The desired start time for an off-peak maintenance window (https://docs.aws.amazon.com/opensearch-service/latest/APIReference/API_OffPeakWindow.html).</summary>
    [JsonPropertyName("windowStartTime")]
    public V1alpha1DomainSpecOffPeakWindowOptionsOffPeakWindowWindowStartTime? WindowStartTime { get; set; }
}

/// <summary>
/// Specifies a daily 10-hour time block during which OpenSearch Service can
/// perform configuration changes on the domain, including service software updates
/// and Auto-Tune enhancements that require a blue/green deployment. If no options
/// are specified, the default start time of 10:00 P.M. local time (for the Region
/// that the domain is created in) is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecOffPeakWindowOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// A custom 10-hour, low-traffic window during which OpenSearch Service can
    /// perform mandatory configuration changes on the domain. These actions can
    /// include scheduled service software updates and blue/green Auto-Tune enhancements.
    /// OpenSearch Service will schedule these actions during the window that you
    /// specify.
    /// 
    /// If you don&apos;t specify a window start time, it defaults to 10:00 P.M. local
    /// time.
    /// 
    /// For more information, see Defining off-peak maintenance windows for Amazon
    /// OpenSearch Service (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/off-peak.html).
    /// </summary>
    [JsonPropertyName("offPeakWindow")]
    public V1alpha1DomainSpecOffPeakWindowOptionsOffPeakWindow? OffPeakWindow { get; set; }
}

/// <summary>Software update options for the domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecSoftwareUpdateOptions
{
    [JsonPropertyName("autoSoftwareUpdateEnabled")]
    public bool? AutoSoftwareUpdateEnabled { get; set; }
}

/// <summary>A tag (key-value pair) for an Amazon OpenSearch Service resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecTags
{
    /// <summary>
    /// A string between 1 to 128 characters that specifies the key for a tag. Tag
    /// keys must be unique for the domain to which they&apos;re attached.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// A string between 0 to 256 characters that specifies the value for a tag.
    /// Tag values can be null and don&apos;t have to be unique in a tag set.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecVpcOptionsSecurityGroupRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecVpcOptionsSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DomainSpecVpcOptionsSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecVpcOptionsSubnetRefsFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecVpcOptionsSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DomainSpecVpcOptionsSubnetRefsFrom? From { get; set; }
}

/// <summary>
/// Container for the values required to configure VPC access domains. If you
/// don&apos;t specify these values, OpenSearch Service creates the domain with a
/// public endpoint. For more information, see Launching your Amazon OpenSearch
/// Service domains using a VPC (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/vpc.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpecVpcOptions
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    /// <summary>Reference field for SecurityGroupIDs</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1DomainSpecVpcOptionsSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    [JsonPropertyName("subnetIDs")]
    public IList<string>? SubnetIDs { get; set; }

    /// <summary>Reference field for SubnetIDs</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1DomainSpecVpcOptionsSubnetRefs>? SubnetRefs { get; set; }
}

/// <summary>DomainSpec defines the desired state of Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainSpec
{
    /// <summary>
    /// Identity and Access Management (IAM) policy document specifying the access
    /// policies for the new domain.
    /// 
    /// Regex Pattern: `.*`
    /// </summary>
    [JsonPropertyName("accessPolicies")]
    public string? AccessPolicies { get; set; }

    /// <summary>
    /// Key-value pairs to specify advanced configuration options. The following
    /// key-value pairs are supported:
    /// 
    ///   - &quot;rest.action.multi.allow_explicit_index&quot;: &quot;true&quot; | &quot;false&quot; - Note the
    ///     use of a string rather than a boolean. Specifies whether explicit references
    ///     to indexes are allowed inside the body of HTTP requests. If you want to
    ///     configure access policies for domain sub-resources, such as specific indexes
    ///     and domain APIs, you must disable this property. Default is true.
    /// 
    ///   - &quot;indices.fielddata.cache.size&quot;: &quot;80&quot; - Note the use of a string rather
    ///     than a boolean. Specifies the percentage of heap space allocated to field
    ///     data. Default is unbounded.
    /// 
    ///   - &quot;indices.query.bool.max_clause_count&quot;: &quot;1024&quot; - Note the use of a string
    ///     rather than a boolean. Specifies the maximum number of clauses allowed
    ///     in a Lucene boolean query. Default is 1,024. Queries with more than the
    ///     permitted number of clauses result in a TooManyClauses error.
    /// 
    ///   - &quot;override_main_response_version&quot;: &quot;true&quot; | &quot;false&quot; - Note the use of
    ///     a string rather than a boolean. Specifies whether the domain reports its
    ///     version as 7.10 to allow Elasticsearch OSS clients and plugins to continue
    ///     working with it. Default is false when creating a domain and true when
    ///     upgrading a domain.
    /// 
    /// For more information, see Advanced cluster parameters (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html#createdomain-configure-advanced-options).
    /// </summary>
    [JsonPropertyName("advancedOptions")]
    public IDictionary<string, string>? AdvancedOptions { get; set; }

    /// <summary>Options for fine-grained access control.</summary>
    [JsonPropertyName("advancedSecurityOptions")]
    public V1alpha1DomainSpecAdvancedSecurityOptions? AdvancedSecurityOptions { get; set; }

    /// <summary>Options for all machine learning features for the specified domain.</summary>
    [JsonPropertyName("aimlOptions")]
    public V1alpha1DomainSpecAimlOptions? AimlOptions { get; set; }

    /// <summary>Options for Auto-Tune.</summary>
    [JsonPropertyName("autoTuneOptions")]
    public V1alpha1DomainSpecAutoTuneOptions? AutoTuneOptions { get; set; }

    /// <summary>Container for the cluster configuration of a domain.</summary>
    [JsonPropertyName("clusterConfig")]
    public V1alpha1DomainSpecClusterConfig? ClusterConfig { get; set; }

    /// <summary>
    /// Key-value pairs to configure Amazon Cognito authentication. For more information,
    /// see Configuring Amazon Cognito authentication for OpenSearch Dashboards (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cognito-auth.html).
    /// </summary>
    [JsonPropertyName("cognitoOptions")]
    public V1alpha1DomainSpecCognitoOptions? CognitoOptions { get; set; }

    /// <summary>
    /// Additional options for the domain endpoint, such as whether to require HTTPS
    /// for all traffic.
    /// </summary>
    [JsonPropertyName("domainEndpointOptions")]
    public V1alpha1DomainSpecDomainEndpointOptions? DomainEndpointOptions { get; set; }

    /// <summary>
    /// Container for the parameters required to enable EBS-based storage for an
    /// OpenSearch Service domain.
    /// </summary>
    [JsonPropertyName("ebsOptions")]
    public V1alpha1DomainSpecEbsOptions? EbsOptions { get; set; }

    /// <summary>Key-value pairs to enable encryption at rest.</summary>
    [JsonPropertyName("encryptionAtRestOptions")]
    public V1alpha1DomainSpecEncryptionAtRestOptions? EncryptionAtRestOptions { get; set; }

    /// <summary>
    /// String of format Elasticsearch_X.Y or OpenSearch_X.Y to specify the engine
    /// version for the OpenSearch Service domain. For example, OpenSearch_1.0 or
    /// Elasticsearch_7.9. For more information, see Creating and managing Amazon
    /// OpenSearch Service domains (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html#createdomains).
    /// 
    /// Regex Pattern: `^Elasticsearch_[0-9]{1}\.[0-9]{1,2}$|^OpenSearch_[0-9]{1,2}\.[0-9]{1,2}$`
    /// </summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// Specify either dual stack or IPv4 as your IP address type. Dual stack allows
    /// you to share domain resources across IPv4 and IPv6 address types, and is
    /// the recommended option. If you set your IP address type to dual stack, you
    /// can&apos;t change your address type later.
    /// </summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>Key-value pairs to configure log publishing.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IDictionary<string, V1alpha1DomainSpecLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>
    /// Name of the OpenSearch Service domain to create. Domain names are unique
    /// across the domains owned by an account within an Amazon Web Services Region.
    /// 
    /// Regex Pattern: `^[a-z][a-z0-9\-]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Enables node-to-node encryption.</summary>
    [JsonPropertyName("nodeToNodeEncryptionOptions")]
    public V1alpha1DomainSpecNodeToNodeEncryptionOptions? NodeToNodeEncryptionOptions { get; set; }

    /// <summary>
    /// Specifies a daily 10-hour time block during which OpenSearch Service can
    /// perform configuration changes on the domain, including service software updates
    /// and Auto-Tune enhancements that require a blue/green deployment. If no options
    /// are specified, the default start time of 10:00 P.M. local time (for the Region
    /// that the domain is created in) is used.
    /// </summary>
    [JsonPropertyName("offPeakWindowOptions")]
    public V1alpha1DomainSpecOffPeakWindowOptions? OffPeakWindowOptions { get; set; }

    /// <summary>Software update options for the domain.</summary>
    [JsonPropertyName("softwareUpdateOptions")]
    public V1alpha1DomainSpecSoftwareUpdateOptions? SoftwareUpdateOptions { get; set; }

    /// <summary>List of tags to add to the domain upon creation.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DomainSpecTags>? Tags { get; set; }

    /// <summary>
    /// Container for the values required to configure VPC access domains. If you
    /// don&apos;t specify these values, OpenSearch Service creates the domain with a
    /// public endpoint. For more information, see Launching your Amazon OpenSearch
    /// Service domains using a VPC (https://docs.aws.amazon.com/opensearch-service/latest/developerguide/vpc.html).
    /// </summary>
    [JsonPropertyName("vpcOptions")]
    public V1alpha1DomainSpecVpcOptions? VpcOptions { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainStatusAckResourceMetadata
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

/// <summary>Information about a configuration change happening on the domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainStatusChangeProgressDetails
{
    [JsonPropertyName("changeID")]
    public string? ChangeID { get; set; }

    [JsonPropertyName("configChangeStatus")]
    public string? ConfigChangeStatus { get; set; }

    [JsonPropertyName("initiatedBy")]
    public string? InitiatedBy { get; set; }

    [JsonPropertyName("lastUpdatedTime")]
    public DateTime? LastUpdatedTime { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainStatusConditions
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

/// <summary>Information about the domain properties that are currently being modified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainStatusModifyingProperties
{
    [JsonPropertyName("activeValue")]
    public string? ActiveValue { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("pendingValue")]
    public string? PendingValue { get; set; }

    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary>The current status of the domain&apos;s service software.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainStatusServiceSoftwareOptions
{
    [JsonPropertyName("automatedUpdateDate")]
    public DateTime? AutomatedUpdateDate { get; set; }

    [JsonPropertyName("cancellable")]
    public bool? Cancellable { get; set; }

    [JsonPropertyName("currentVersion")]
    public string? CurrentVersion { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("newVersion")]
    public string? NewVersion { get; set; }

    [JsonPropertyName("optionalDeployment")]
    public bool? OptionalDeployment { get; set; }

    [JsonPropertyName("updateAvailable")]
    public bool? UpdateAvailable { get; set; }

    [JsonPropertyName("updateStatus")]
    public string? UpdateStatus { get; set; }
}

/// <summary>
/// DEPRECATED. Container for parameters required to configure automated snapshots
/// of domain indexes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainStatusSnapshotOptions
{
    [JsonPropertyName("automatedSnapshotStartHour")]
    public long? AutomatedSnapshotStartHour { get; set; }
}

/// <summary>DomainStatus defines the observed state of Domain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DomainStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DomainStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>Information about a configuration change happening on the domain.</summary>
    [JsonPropertyName("changeProgressDetails")]
    public V1alpha1DomainStatusChangeProgressDetails? ChangeProgressDetails { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DomainStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Creation status of an OpenSearch Service domain. True if domain creation
    /// is complete. False if domain creation is still in progress.
    /// </summary>
    [JsonPropertyName("created")]
    public bool? Created { get; set; }

    /// <summary>
    /// Deletion status of an OpenSearch Service domain. True if domain deletion
    /// is complete. False if domain deletion is still in progress. Once deletion
    /// is complete, the status of the domain is no longer returned.
    /// </summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }

    /// <summary>The dual stack hosted zone ID for the domain.</summary>
    [JsonPropertyName("domainEndpointV2HostedZoneID")]
    public string? DomainEndpointV2HostedZoneID { get; set; }

    /// <summary>Unique identifier for the domain.</summary>
    [JsonPropertyName("domainID")]
    public string? DomainID { get; set; }

    /// <summary>The status of any changes that are currently in progress for the domain.</summary>
    [JsonPropertyName("domainProcessingStatus")]
    public string? DomainProcessingStatus { get; set; }

    /// <summary>
    /// Domain-specific endpoint used to submit index, search, and data upload requests
    /// to the domain.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>
    /// If IPAddressType to set to dualstack, a version 2 domain endpoint is provisioned.
    /// This endpoint functions like a normal endpoint, except that it works with
    /// both IPv4 and IPv6 IP addresses. Normal endpoints work only with IPv4 IP
    /// addresses.
    /// </summary>
    [JsonPropertyName("endpointV2")]
    public string? EndpointV2 { get; set; }

    /// <summary>
    /// The key-value pair that exists if the OpenSearch Service domain uses VPC
    /// endpoints. For example:
    /// 
    ///    * IPv4 IP addresses - &apos;vpc&apos;,&apos;vpc-endpoint-h2dsd34efgyghrtguk5gt6j2foh4.us-east-1.es.amazonaws.com&apos;
    /// 
    ///    * Dual stack IP addresses - &apos;vpcv2&apos;:&apos;vpc-endpoint-h2dsd34efgyghrtguk5gt6j2foh4.aos.us-east-1.on.aws&apos;
    /// </summary>
    [JsonPropertyName("endpoints")]
    public IDictionary<string, string>? Endpoints { get; set; }

    /// <summary>Information about the domain properties that are currently being modified.</summary>
    [JsonPropertyName("modifyingProperties")]
    public IList<V1alpha1DomainStatusModifyingProperties>? ModifyingProperties { get; set; }

    /// <summary>
    /// The status of the domain configuration. True if OpenSearch Service is processing
    /// configuration changes. False if the configuration is active.
    /// </summary>
    [JsonPropertyName("processing")]
    public bool? Processing { get; set; }

    /// <summary>The current status of the domain&apos;s service software.</summary>
    [JsonPropertyName("serviceSoftwareOptions")]
    public V1alpha1DomainStatusServiceSoftwareOptions? ServiceSoftwareOptions { get; set; }

    /// <summary>
    /// DEPRECATED. Container for parameters required to configure automated snapshots
    /// of domain indexes.
    /// </summary>
    [JsonPropertyName("snapshotOptions")]
    public V1alpha1DomainStatusSnapshotOptions? SnapshotOptions { get; set; }

    /// <summary>
    /// The status of a domain version upgrade to a new version of OpenSearch or
    /// Elasticsearch. True if OpenSearch Service is in the process of a version
    /// upgrade. False if the configuration is active.
    /// </summary>
    [JsonPropertyName("upgradeProcessing")]
    public bool? UpgradeProcessing { get; set; }
}

/// <summary>Domain is the Schema for the Domains API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Domain : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DomainSpec?>, IStatus<V1alpha1DomainStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Domain";
    public const string KubeGroup = "opensearchservice.services.k8s.aws";
    public const string KubePluralName = "domains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "opensearchservice.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Domain";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DomainSpec defines the desired state of Domain.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1DomainSpec? Spec { get; set; }

    /// <summary>DomainStatus defines the observed state of Domain</summary>
    [JsonPropertyName("status")]
    public V1alpha1DomainStatus? Status { get; set; }
}