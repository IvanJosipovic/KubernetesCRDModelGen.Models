#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.services.k8s.aws;
/// <summary>DBInstance is the Schema for the DBInstances API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DBInstance>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBInstanceList";
    public const string KubeGroup = "documentdb.services.k8s.aws";
    public const string KubePluralName = "dbinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DBInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DBInstance> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceSpecPerformanceInsightsKMSKeyRefFrom
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
public partial class V1alpha1DBInstanceSpecPerformanceInsightsKMSKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBInstanceSpecPerformanceInsightsKMSKeyRefFrom? From { get; set; }
}

/// <summary>
/// Metadata assigned to an Amazon DocumentDB resource consisting of a key-value
/// pair.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DBInstanceSpec defines the desired state of DBInstance.
/// 
/// Detailed information about an instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceSpec
{
    /// <summary>
    /// This parameter does not apply to Amazon DocumentDB. Amazon DocumentDB does
    /// not perform minor version upgrades regardless of the value set.
    /// 
    /// Default: false
    /// </summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The Amazon EC2 Availability Zone that the instance is created in.
    /// 
    /// Default: A random, system-chosen Availability Zone in the endpoint&apos;s Amazon
    /// Web Services Region.
    /// 
    /// Example: us-east-1d
    /// </summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>
    /// The CA certificate identifier to use for the DB instance&apos;s server certificate.
    /// 
    /// For more information, see Updating Your Amazon DocumentDB TLS Certificates
    /// (https://docs.aws.amazon.com/documentdb/latest/developerguide/ca_cert_rotation.html)
    /// and Encrypting Data in Transit (https://docs.aws.amazon.com/documentdb/latest/developerguide/security.encryption.ssl.html)
    /// in the Amazon DocumentDB Developer Guide.
    /// </summary>
    [JsonPropertyName("caCertificateIdentifier")]
    public string? CaCertificateIdentifier { get; set; }

    /// <summary>
    /// A value that indicates whether to copy tags from the DB instance to snapshots
    /// of the DB instance. By default, tags are not copied.
    /// </summary>
    [JsonPropertyName("copyTagsToSnapshot")]
    public bool? CopyTagsToSnapshot { get; set; }

    /// <summary>The identifier of the cluster that the instance will belong to.</summary>
    [JsonPropertyName("dbClusterIdentifier")]
    public required string DbClusterIdentifier { get; set; }

    /// <summary>The compute and memory capacity of the instance; for example, db.r5.large.</summary>
    [JsonPropertyName("dbInstanceClass")]
    public required string DbInstanceClass { get; set; }

    /// <summary>
    /// The instance identifier. This parameter is stored as a lowercase string.
    /// 
    /// Constraints:
    /// 
    ///   - Must contain from 1 to 63 letters, numbers, or hyphens.
    /// 
    ///   - The first character must be a letter.
    /// 
    ///   - Cannot end with a hyphen or contain two consecutive hyphens.
    /// 
    /// Example: mydbinstance
    /// </summary>
    [JsonPropertyName("dbInstanceIdentifier")]
    public required string DbInstanceIdentifier { get; set; }

    /// <summary>
    /// The name of the database engine to be used for this instance.
    /// 
    /// Valid value: docdb
    /// </summary>
    [JsonPropertyName("engine")]
    public required string Engine { get; set; }

    /// <summary>
    /// A value that indicates whether to enable Performance Insights for the DB
    /// Instance. For more information, see Using Amazon Performance Insights (https://docs.aws.amazon.com/documentdb/latest/developerguide/performance-insights.html).
    /// </summary>
    [JsonPropertyName("performanceInsightsEnabled")]
    public bool? PerformanceInsightsEnabled { get; set; }

    /// <summary>
    /// The KMS key identifier for encryption of Performance Insights data.
    /// 
    /// The KMS key identifier is the key ARN, key ID, alias ARN, or alias name for
    /// the KMS key.
    /// 
    /// If you do not specify a value for PerformanceInsightsKMSKeyId, then Amazon
    /// DocumentDB uses your default KMS key. There is a default KMS key for your
    /// Amazon Web Services account. Your Amazon Web Services account has a different
    /// default KMS key for each Amazon Web Services region.
    /// </summary>
    [JsonPropertyName("performanceInsightsKMSKeyID")]
    public string? PerformanceInsightsKMSKeyID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("performanceInsightsKMSKeyRef")]
    public V1alpha1DBInstanceSpecPerformanceInsightsKMSKeyRef? PerformanceInsightsKMSKeyRef { get; set; }

    /// <summary>
    /// The time range each week during which system maintenance can occur, in Universal
    /// Coordinated Time (UTC).
    /// 
    /// Format: ddd:hh24:mi-ddd:hh24:mi
    /// 
    /// The default is a 30-minute window selected at random from an 8-hour block
    /// of time for each Amazon Web Services Region, occurring on a random day of
    /// the week.
    /// 
    /// Valid days: Mon, Tue, Wed, Thu, Fri, Sat, Sun
    /// 
    /// Constraints: Minimum 30-minute window.
    /// </summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// A value that specifies the order in which an Amazon DocumentDB replica is
    /// promoted to the primary instance after a failure of the existing primary
    /// instance.
    /// 
    /// Default: 1
    /// 
    /// Valid values: 0-15
    /// </summary>
    [JsonPropertyName("promotionTier")]
    public long? PromotionTier { get; set; }

    /// <summary>
    /// The tags to be assigned to the instance. You can assign up to 10 tags to
    /// an instance.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DBInstanceSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatusAckResourceMetadata
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

/// <summary>The details of the DB instance&apos;s server certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatusCertificateDetails
{
    [JsonPropertyName("cAIdentifier")]
    public string? CAIdentifier { get; set; }

    [JsonPropertyName("validTill")]
    public DateTime? ValidTill { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatusConditions
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

/// <summary>Information about an Availability Zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatusDbSubnetGroupSubnetsSubnetAvailabilityZone
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Detailed information about a subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatusDbSubnetGroupSubnets
{
    /// <summary>Information about an Availability Zone.</summary>
    [JsonPropertyName("subnetAvailabilityZone")]
    public V1alpha1DBInstanceStatusDbSubnetGroupSubnetsSubnetAvailabilityZone? SubnetAvailabilityZone { get; set; }

    [JsonPropertyName("subnetIdentifier")]
    public string? SubnetIdentifier { get; set; }

    [JsonPropertyName("subnetStatus")]
    public string? SubnetStatus { get; set; }
}

/// <summary>
/// Specifies information on the subnet group that is associated with the instance,
/// including the name, description, and subnets in the subnet group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatusDbSubnetGroup
{
    [JsonPropertyName("dbSubnetGroupARN")]
    public string? DbSubnetGroupARN { get; set; }

    [JsonPropertyName("dbSubnetGroupDescription")]
    public string? DbSubnetGroupDescription { get; set; }

    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    [JsonPropertyName("subnetGroupStatus")]
    public string? SubnetGroupStatus { get; set; }

    [JsonPropertyName("subnets")]
    public IList<V1alpha1DBInstanceStatusDbSubnetGroupSubnets>? Subnets { get; set; }

    [JsonPropertyName("supportedNetworkTypes")]
    public IList<string>? SupportedNetworkTypes { get; set; }

    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>Specifies the connection endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatusEndpoint
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("hostedZoneID")]
    public string? HostedZoneID { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// A list of the log types whose configuration is still pending. These log types
/// are in the process of being activated or deactivated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatusPendingModifiedValuesPendingCloudwatchLogsExports
{
    [JsonPropertyName("logTypesToDisable")]
    public IList<string>? LogTypesToDisable { get; set; }

    [JsonPropertyName("logTypesToEnable")]
    public IList<string>? LogTypesToEnable { get; set; }
}

/// <summary>
/// Specifies that changes to the instance are pending. This element is included
/// only when changes are pending. Specific changes are identified by subelements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatusPendingModifiedValues
{
    [JsonPropertyName("allocatedStorage")]
    public long? AllocatedStorage { get; set; }

    [JsonPropertyName("backupRetentionPeriod")]
    public long? BackupRetentionPeriod { get; set; }

    [JsonPropertyName("caCertificateIdentifier")]
    public string? CaCertificateIdentifier { get; set; }

    [JsonPropertyName("dbInstanceClass")]
    public string? DbInstanceClass { get; set; }

    [JsonPropertyName("dbInstanceIdentifier")]
    public string? DbInstanceIdentifier { get; set; }

    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    [JsonPropertyName("iops")]
    public long? Iops { get; set; }

    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    [JsonPropertyName("masterUserPassword")]
    public string? MasterUserPassword { get; set; }

    [JsonPropertyName("multiAZ")]
    public bool? MultiAZ { get; set; }

    /// <summary>
    /// A list of the log types whose configuration is still pending. These log types
    /// are in the process of being activated or deactivated.
    /// </summary>
    [JsonPropertyName("pendingCloudwatchLogsExports")]
    public V1alpha1DBInstanceStatusPendingModifiedValuesPendingCloudwatchLogsExports? PendingCloudwatchLogsExports { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }

    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>Provides a list of status information for an instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatusStatusInfos
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("normal")]
    public bool? Normal { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("statusType")]
    public string? StatusType { get; set; }
}

/// <summary>
/// Used as a response element for queries on virtual private cloud (VPC) security
/// group membership.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatusVpcSecurityGroups
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("vpcSecurityGroupID")]
    public string? VpcSecurityGroupID { get; set; }
}

/// <summary>DBInstanceStatus defines the observed state of DBInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBInstanceStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DBInstanceStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>Specifies the number of days for which automatic snapshots are retained.</summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public long? BackupRetentionPeriod { get; set; }

    /// <summary>The details of the DB instance&apos;s server certificate.</summary>
    [JsonPropertyName("certificateDetails")]
    public V1alpha1DBInstanceStatusCertificateDetails? CertificateDetails { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DBInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>Specifies the current state of this database.</summary>
    [JsonPropertyName("dbInstanceStatus")]
    public string? DbInstanceStatus { get; set; }

    /// <summary>
    /// Specifies information on the subnet group that is associated with the instance,
    /// including the name, description, and subnets in the subnet group.
    /// </summary>
    [JsonPropertyName("dbSubnetGroup")]
    public V1alpha1DBInstanceStatusDbSubnetGroup? DbSubnetGroup { get; set; }

    /// <summary>
    /// The Amazon Web Services Region-unique, immutable identifier for the instance.
    /// This identifier is found in CloudTrail log entries whenever the KMS key for
    /// the instance is accessed.
    /// </summary>
    [JsonPropertyName("dbiResourceID")]
    public string? DbiResourceID { get; set; }

    /// <summary>
    /// A list of log types that this instance is configured to export to CloudWatch
    /// Logs.
    /// </summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>Specifies the connection endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public V1alpha1DBInstanceStatusEndpoint? Endpoint { get; set; }

    /// <summary>Indicates the database engine version.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>Provides the date and time that the instance was created.</summary>
    [JsonPropertyName("instanceCreateTime")]
    public DateTime? InstanceCreateTime { get; set; }

    /// <summary>If StorageEncrypted is true, the KMS key identifier for the encrypted instance.</summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// Specifies the latest time to which a database can be restored with point-in-time
    /// restore.
    /// </summary>
    [JsonPropertyName("latestRestorableTime")]
    public DateTime? LatestRestorableTime { get; set; }

    /// <summary>
    /// Specifies that changes to the instance are pending. This element is included
    /// only when changes are pending. Specific changes are identified by subelements.
    /// </summary>
    [JsonPropertyName("pendingModifiedValues")]
    public V1alpha1DBInstanceStatusPendingModifiedValues? PendingModifiedValues { get; set; }

    /// <summary>
    /// Specifies the daily time range during which automated backups are created
    /// if automated backups are enabled, as determined by the BackupRetentionPeriod.
    /// </summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>
    /// Not supported. Amazon DocumentDB does not currently support public endpoints.
    /// The value of PubliclyAccessible is always false.
    /// </summary>
    [JsonPropertyName("publiclyAccessible")]
    public bool? PubliclyAccessible { get; set; }

    /// <summary>
    /// The status of a read replica. If the instance is not a read replica, this
    /// is blank.
    /// </summary>
    [JsonPropertyName("statusInfos")]
    public IList<V1alpha1DBInstanceStatusStatusInfos>? StatusInfos { get; set; }

    /// <summary>Specifies whether or not the instance is encrypted.</summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>
    /// Provides a list of VPC security group elements that the instance belongs
    /// to.
    /// </summary>
    [JsonPropertyName("vpcSecurityGroups")]
    public IList<V1alpha1DBInstanceStatusVpcSecurityGroups>? VpcSecurityGroups { get; set; }
}

/// <summary>DBInstance is the Schema for the DBInstances API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DBInstanceSpec?>, IStatus<V1alpha1DBInstanceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBInstance";
    public const string KubeGroup = "documentdb.services.k8s.aws";
    public const string KubePluralName = "dbinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DBInstanceSpec defines the desired state of DBInstance.
    /// 
    /// Detailed information about an instance.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DBInstanceSpec? Spec { get; set; }

    /// <summary>DBInstanceStatus defines the observed state of DBInstance</summary>
    [JsonPropertyName("status")]
    public V1alpha1DBInstanceStatus? Status { get; set; }
}