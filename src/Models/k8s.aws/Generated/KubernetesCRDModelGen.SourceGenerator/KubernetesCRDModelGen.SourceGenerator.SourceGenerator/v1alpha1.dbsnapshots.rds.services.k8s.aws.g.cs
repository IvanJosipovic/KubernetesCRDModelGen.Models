#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.rds.services.k8s.aws;
/// <summary>DBSnapshot is the Schema for the DBSnapshots API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBSnapshotList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DBSnapshot>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBSnapshotList";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbsnapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBSnapshotList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DBSnapshot objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DBSnapshot> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSnapshotSpecDbInstanceIdentifierRefFrom
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
public partial class V1alpha1DBSnapshotSpecDbInstanceIdentifierRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBSnapshotSpecDbInstanceIdentifierRefFrom? From { get; set; }
}

/// <summary>
/// Metadata assigned to an Amazon RDS resource consisting of a key-value pair.
/// 
/// For more information, see Tagging Amazon RDS resources (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html)
/// in the Amazon RDS User Guide or Tagging Amazon Aurora and Amazon RDS resources
/// (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html)
/// in the Amazon Aurora User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSnapshotSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DBSnapshotSpec defines the desired state of DBSnapshot.
/// 
/// Contains the details of an Amazon RDS DB snapshot.
/// 
/// This data type is used as a response element in the DescribeDBSnapshots action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSnapshotSpec
{
    /// <summary>
    /// The identifier of the DB instance that you want to create the snapshot of.
    /// 
    /// Constraints:
    /// 
    ///   - Must match the identifier of an existing DBInstance.
    /// </summary>
    [JsonPropertyName("dbInstanceIdentifier")]
    public string? DbInstanceIdentifier { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("dbInstanceIdentifierRef")]
    public V1alpha1DBSnapshotSpecDbInstanceIdentifierRef? DbInstanceIdentifierRef { get; set; }

    /// <summary>
    /// The identifier for the DB snapshot.
    /// 
    /// Constraints:
    /// 
    ///   - Can&apos;t be null, empty, or blank
    /// 
    ///   - Must contain from 1 to 255 letters, numbers, or hyphens
    /// 
    ///   - First character must be a letter
    /// 
    ///   - Can&apos;t end with a hyphen or contain two consecutive hyphens
    /// 
    /// Example: my-snapshot-id
    /// </summary>
    [JsonPropertyName("dbSnapshotIdentifier")]
    public required string DbSnapshotIdentifier { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1DBSnapshotSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSnapshotStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSnapshotStatusConditions
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

/// <summary>
/// Contains the processor features of a DB instance class.
/// 
/// To specify the number of CPU cores, use the coreCount feature name for the
/// Name parameter. To specify the number of threads per core, use the threadsPerCore
/// feature name for the Name parameter.
/// 
/// You can set the processor features of the DB instance class for a DB instance
/// when you call one of the following actions:
/// 
///   - CreateDBInstance
/// 
///   - ModifyDBInstance
/// 
///   - RestoreDBInstanceFromDBSnapshot
/// 
///   - RestoreDBInstanceFromS3
/// 
///   - RestoreDBInstanceToPointInTime
/// 
/// You can view the valid processor values for a particular instance class by
/// calling the DescribeOrderableDBInstanceOptions action and specifying the
/// instance class for the DBInstanceClass parameter.
/// 
/// In addition, you can use the following actions for DB instance class processor
/// information:
/// 
///   - DescribeDBInstances
/// 
///   - DescribeDBSnapshots
/// 
///   - DescribeValidDBInstanceModifications
/// 
/// If you call DescribeDBInstances, ProcessorFeature returns non-null values
/// only if the following conditions are met:
/// 
///   - You are accessing an Oracle DB instance.
/// 
///   - Your Oracle DB instance class supports configuring the number of CPU
///     cores and threads per core.
/// 
///   - The current number CPU cores and threads is set to a non-default value.
/// 
/// For more information, see Configuring the processor for a DB instance class
/// in RDS for Oracle (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.DBInstanceClass.html#USER_ConfigureProcessor)
/// in the Amazon RDS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSnapshotStatusProcessorFeatures
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Metadata assigned to an Amazon RDS resource consisting of a key-value pair.
/// 
/// For more information, see Tagging Amazon RDS resources (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html)
/// in the Amazon RDS User Guide or Tagging Amazon Aurora and Amazon RDS resources
/// (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html)
/// in the Amazon Aurora User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSnapshotStatusTagList
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DBSnapshotStatus defines the observed state of DBSnapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBSnapshotStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DBSnapshotStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>Specifies the allocated storage size in gibibytes (GiB).</summary>
    [JsonPropertyName("allocatedStorage")]
    public long? AllocatedStorage { get; set; }

    /// <summary>
    /// Specifies the name of the Availability Zone the DB instance was located in
    /// at the time of the DB snapshot.
    /// </summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DBSnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The identifier for the source DB instance, which can&apos;t be changed and which
    /// is unique to an Amazon Web Services Region.
    /// </summary>
    [JsonPropertyName("dbiResourceID")]
    public string? DbiResourceID { get; set; }

    /// <summary>Indicates whether the DB snapshot is encrypted.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Specifies the name of the database engine.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>
    /// Indicates whether mapping of Amazon Web Services Identity and Access Management
    /// (IAM) accounts to database accounts is enabled.
    /// </summary>
    [JsonPropertyName("iamDatabaseAuthenticationEnabled")]
    public bool? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>
    /// Specifies the time in Coordinated Universal Time (UTC) when the DB instance,
    /// from which the snapshot was taken, was created.
    /// </summary>
    [JsonPropertyName("instanceCreateTime")]
    public DateTime? InstanceCreateTime { get; set; }

    /// <summary>
    /// Specifies the Provisioned IOPS (I/O operations per second) value of the DB
    /// instance at the time of the snapshot.
    /// </summary>
    [JsonPropertyName("iops")]
    public long? Iops { get; set; }

    /// <summary>
    /// If Encrypted is true, the Amazon Web Services KMS key identifier for the
    /// encrypted DB snapshot.
    /// 
    /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias
    /// ARN, or alias name for the KMS key.
    /// </summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>License model information for the restored DB instance.</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>Provides the master username for the DB snapshot.</summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>
    /// Specifies the time of the CreateDBSnapshot operation in Coordinated Universal
    /// Time (UTC). Doesn&apos;t change when the snapshot is copied.
    /// </summary>
    [JsonPropertyName("originalSnapshotCreateTime")]
    public DateTime? OriginalSnapshotCreateTime { get; set; }

    /// <summary>The percentage of the estimated data that has been transferred.</summary>
    [JsonPropertyName("percentProgress")]
    public long? PercentProgress { get; set; }

    /// <summary>
    /// Specifies the port that the database engine was listening on at the time
    /// of the snapshot.
    /// </summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>
    /// The number of CPU cores and the number of threads per core for the DB instance
    /// class of the DB instance when the DB snapshot was created.
    /// </summary>
    [JsonPropertyName("processorFeatures")]
    public IList<V1alpha1DBSnapshotStatusProcessorFeatures>? ProcessorFeatures { get; set; }

    /// <summary>
    /// Specifies when the snapshot was taken in Coordinated Universal Time (UTC).
    /// Changes for the copy when the snapshot is copied.
    /// </summary>
    [JsonPropertyName("snapshotCreateTime")]
    public DateTime? SnapshotCreateTime { get; set; }

    /// <summary>
    /// The timestamp of the most recent transaction applied to the database that
    /// you&apos;re backing up. Thus, if you restore a snapshot, SnapshotDatabaseTime
    /// is the most recent transaction in the restored DB instance. In contrast,
    /// originalSnapshotCreateTime specifies the system time that the snapshot completed.
    /// 
    /// If you back up a read replica, you can determine the replica lag by comparing
    /// SnapshotDatabaseTime with originalSnapshotCreateTime. For example, if originalSnapshotCreateTime
    /// is two hours later than SnapshotDatabaseTime, then the replica lag is two
    /// hours.
    /// </summary>
    [JsonPropertyName("snapshotDatabaseTime")]
    public DateTime? SnapshotDatabaseTime { get; set; }

    /// <summary>
    /// Specifies where manual snapshots are stored: Amazon Web Services Outposts
    /// or the Amazon Web Services Region.
    /// </summary>
    [JsonPropertyName("snapshotTarget")]
    public string? SnapshotTarget { get; set; }

    /// <summary>Provides the type of the DB snapshot.</summary>
    [JsonPropertyName("snapshotType")]
    public string? SnapshotType { get; set; }

    /// <summary>
    /// The DB snapshot Amazon Resource Name (ARN) that the DB snapshot was copied
    /// from. It only has a value in the case of a cross-account or cross-Region
    /// copy.
    /// </summary>
    [JsonPropertyName("sourceDBSnapshotIdentifier")]
    public string? SourceDBSnapshotIdentifier { get; set; }

    /// <summary>
    /// The Amazon Web Services Region that the DB snapshot was created in or copied
    /// from.
    /// </summary>
    [JsonPropertyName("sourceRegion")]
    public string? SourceRegion { get; set; }

    /// <summary>Specifies the status of this DB snapshot.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Specifies the storage throughput for the DB snapshot.</summary>
    [JsonPropertyName("storageThroughput")]
    public long? StorageThroughput { get; set; }

    /// <summary>Specifies the storage type associated with DB snapshot.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    [JsonPropertyName("tagList")]
    public IList<V1alpha1DBSnapshotStatusTagList>? TagList { get; set; }

    /// <summary>The ARN from the key store with which to associate the instance for TDE encryption.</summary>
    [JsonPropertyName("tdeCredentialARN")]
    public string? TdeCredentialARN { get; set; }

    /// <summary>
    /// The time zone of the DB snapshot. In most cases, the Timezone element is
    /// empty. Timezone content appears only for snapshots taken from Microsoft SQL
    /// Server DB instances that were created with a time zone specified.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>Provides the VPC ID associated with the DB snapshot.</summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>DBSnapshot is the Schema for the DBSnapshots API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBSnapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DBSnapshotSpec?>, IStatus<V1alpha1DBSnapshotStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBSnapshot";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbsnapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBSnapshot";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DBSnapshotSpec defines the desired state of DBSnapshot.
    /// 
    /// Contains the details of an Amazon RDS DB snapshot.
    /// 
    /// This data type is used as a response element in the DescribeDBSnapshots action.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DBSnapshotSpec? Spec { get; set; }

    /// <summary>DBSnapshotStatus defines the observed state of DBSnapshot</summary>
    [JsonPropertyName("status")]
    public V1alpha1DBSnapshotStatus? Status { get; set; }
}