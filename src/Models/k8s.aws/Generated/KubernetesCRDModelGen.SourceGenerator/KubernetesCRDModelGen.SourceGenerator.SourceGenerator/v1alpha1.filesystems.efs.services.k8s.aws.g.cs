#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.efs.services.k8s.aws;
/// <summary>FileSystem is the Schema for the FileSystems API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FileSystemList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1FileSystem>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FileSystemList";
    public const string KubeGroup = "efs.services.k8s.aws";
    public const string KubePluralName = "filesystems";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "efs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FileSystemList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1FileSystem objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1FileSystem> Items { get; set; }
}

/// <summary>The backup policy included in the PutBackupPolicy request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecBackupPolicy
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecFileSystemProtection
{
    [JsonPropertyName("replicationOverwriteProtection")]
    public string? ReplicationOverwriteProtection { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecKmsKeyRefFrom
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
public partial class V1alpha1FileSystemSpecKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FileSystemSpecKmsKeyRefFrom? From { get; set; }
}

/// <summary>
/// Describes a policy used by lifecycle management that specifies when to transition
/// files into and out of storage classes. For more information, see Managing
/// file system storage (https://docs.aws.amazon.com/efs/latest/ug/lifecycle-management-efs.html).
/// 
/// When using the put-lifecycle-configuration CLI command or the PutLifecycleConfiguration
/// API action, Amazon EFS requires that each LifecyclePolicy object have only
/// a single transition. This means that in a request body, LifecyclePolicies
/// must be structured as an array of LifecyclePolicy objects, one object for
/// each transition. For more information, see the request examples in PutLifecycleConfiguration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecLifecyclePolicies
{
    [JsonPropertyName("transitionToArchive")]
    public string? TransitionToArchive { get; set; }

    [JsonPropertyName("transitionToIA")]
    public string? TransitionToIA { get; set; }

    [JsonPropertyName("transitionToPrimaryStorageClass")]
    public string? TransitionToPrimaryStorageClass { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecReplicationConfigurationFileSystemRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for FileSystemID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecReplicationConfigurationFileSystemRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FileSystemSpecReplicationConfigurationFileSystemRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecReplicationConfigurationKmsKeyRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for KMSKeyID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecReplicationConfigurationKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FileSystemSpecReplicationConfigurationKmsKeyRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecReplicationConfigurationRoleRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for RoleARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecReplicationConfigurationRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1FileSystemSpecReplicationConfigurationRoleRefFrom? From { get; set; }
}

/// <summary>
/// Describes the new or existing destination file system for the replication
/// configuration.
/// 
///   - If you want to replicate to a new file system, do not specify the File
///     System ID for the destination file system. Amazon EFS creates a new, empty
///     file system. For One Zone storage, specify the Availability Zone to create
///     the file system in. To use an Key Management Service key other than the
///     default KMS key, then specify it. For more information, see Configuring
///     replication to new Amazon EFS file system (https://docs.aws.amazon.com/efs/latest/ug/create-replication.html)
///     in the Amazon EFS User Guide. After the file system is created, you cannot
///     change the KMS key or the performance mode.
/// 
///   - If you want to replicate to an existing file system that&apos;s in the same
///     account as the source file system, then you need to provide the ID or
///     Amazon Resource Name (ARN) of the file system to which to replicate. The
///     file system&apos;s replication overwrite protection must be disabled. For more
///     information, see Replicating to an existing file system (https://docs.aws.amazon.com/efs/latest/ug/efs-replication#replicate-existing-destination)
///     in the Amazon EFS User Guide.
/// 
///   - If you are replicating the file system to a file system that&apos;s in a
///     different account than the source file system (cross-account replication),
///     you need to provide the ARN for the file system and the IAM role that
///     allows Amazon EFS to perform replication on the destination account. The
///     file system&apos;s replication overwrite protection must be disabled. For more
///     information, see Replicating across Amazon Web Services accounts (https://docs.aws.amazon.com/efs/latest/ug/cross-account-replication.html)
///     in the Amazon EFS User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecReplicationConfiguration
{
    [JsonPropertyName("availabilityZoneName")]
    public string? AvailabilityZoneName { get; set; }

    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }

    /// <summary>Reference field for FileSystemID</summary>
    [JsonPropertyName("fileSystemRef")]
    public V1alpha1FileSystemSpecReplicationConfigurationFileSystemRef? FileSystemRef { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>Reference field for KMSKeyID</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1FileSystemSpecReplicationConfigurationKmsKeyRef? KmsKeyRef { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>Reference field for RoleARN</summary>
    [JsonPropertyName("roleRef")]
    public V1alpha1FileSystemSpecReplicationConfigurationRoleRef? RoleRef { get; set; }
}

/// <summary>
/// A tag is a key-value pair. Allowed characters are letters, white space, and
/// numbers that can be represented in UTF-8, and the following characters:+
/// - = . _ : /.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>FileSystemSpec defines the desired state of FileSystem.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemSpec
{
    /// <summary>
    /// For One Zone file systems, specify the Amazon Web Services Availability Zone
    /// in which to create the file system. Use the format us-east-1a to specify
    /// the Availability Zone. For more information about One Zone file systems,
    /// see EFS file system types (https://docs.aws.amazon.com/efs/latest/ug/availability-durability.html#file-system-type)
    /// in the Amazon EFS User Guide.
    /// 
    /// One Zone file systems are not available in all Availability Zones in Amazon
    /// Web Services Regions where Amazon EFS is available.
    /// 
    /// Regex Pattern: `^.+$`
    /// </summary>
    [JsonPropertyName("availabilityZoneName")]
    public string? AvailabilityZoneName { get; set; }

    /// <summary>
    /// Specifies whether automatic backups are enabled on the file system that you
    /// are creating. Set the value to true to enable automatic backups. If you are
    /// creating a One Zone file system, automatic backups are enabled by default.
    /// For more information, see Automatic backups (https://docs.aws.amazon.com/efs/latest/ug/awsbackup.html#automatic-backups)
    /// in the Amazon EFS User Guide.
    /// 
    /// Default is false. However, if you specify an AvailabilityZoneName, the default
    /// is true.
    /// 
    /// Backup is not available in all Amazon Web Services Regions where Amazon EFS
    /// is available.
    /// </summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; set; }

    /// <summary>The backup policy included in the PutBackupPolicy request.</summary>
    [JsonPropertyName("backupPolicy")]
    public V1alpha1FileSystemSpecBackupPolicy? BackupPolicy { get; set; }

    /// <summary>
    /// A Boolean value that, if true, creates an encrypted file system. When creating
    /// an encrypted file system, you have the option of specifying an existing Key
    /// Management Service key (KMS key). If you don&apos;t specify a KMS key, then the
    /// default KMS key for Amazon EFS, /aws/elasticfilesystem, is used to protect
    /// the encrypted file system.
    /// </summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("fileSystemProtection")]
    public V1alpha1FileSystemSpecFileSystemProtection? FileSystemProtection { get; set; }

    /// <summary>
    /// The ID of the KMS key that you want to use to protect the encrypted file
    /// system. This parameter is required only if you want to use a non-default
    /// KMS key. If this parameter is not specified, the default KMS key for Amazon
    /// EFS is used. You can specify a KMS key ID using the following formats:
    /// 
    ///   - Key ID - A unique identifier of the key, for example 1234abcd-12ab-34cd-56ef-1234567890ab.
    /// 
    ///   - ARN - An Amazon Resource Name (ARN) for the key, for example arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab.
    /// 
    ///   - Key alias - A previously created display name for a key, for example
    ///     alias/projectKey1.
    /// 
    ///   - Key alias ARN - An ARN for a key alias, for example arn:aws:kms:us-west-2:444455556666:alias/projectKey1.
    /// 
    /// If you use KmsKeyId, you must set the CreateFileSystemRequest$Encrypted parameter
    /// to true.
    /// 
    /// EFS accepts only symmetric KMS keys. You cannot use asymmetric KMS keys with
    /// Amazon EFS file systems.
    /// 
    /// Regex Pattern: `^([0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}|mrk-[0-9a-f]{32}|alias/[a-zA-Z0-9/_-]+|(arn:aws[-a-z]*:kms:[a-z0-9-]+:\d{12}:((key/[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12})|(key/mrk-[0-9a-f]{32})|(alias/[a-zA-Z0-9/_-]+))))$`
    /// </summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1FileSystemSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>
    /// An array of LifecyclePolicy objects that define the file system&apos;s LifecycleConfiguration
    /// object. A LifecycleConfiguration object informs lifecycle management of the
    /// following:
    /// 
    ///   - TransitionToIA – When to move files in the file system from primary
    ///     storage (Standard storage class) into the Infrequent Access (IA) storage.
    /// 
    ///   - TransitionToArchive – When to move files in the file system from their
    ///     current storage class (either IA or Standard storage) into the Archive
    ///     storage. File systems cannot transition into Archive storage before transitioning
    ///     into IA storage. Therefore, TransitionToArchive must either not be set
    ///     or must be later than TransitionToIA. The Archive storage class is available
    ///     only for file systems that use the Elastic throughput mode and the General
    ///     Purpose performance mode.
    /// 
    ///   - TransitionToPrimaryStorageClass – Whether to move files in the file
    ///     system back to primary storage (Standard storage class) after they are
    ///     accessed in IA or Archive storage.
    /// 
    /// When using the put-lifecycle-configuration CLI command or the PutLifecycleConfiguration
    /// API action, Amazon EFS requires that each LifecyclePolicy object have only
    /// a single transition. This means that in a request body, LifecyclePolicies
    /// must be structured as an array of LifecyclePolicy objects, one object for
    /// each storage transition. See the example requests in the following section
    /// for more information.
    /// </summary>
    [JsonPropertyName("lifecyclePolicies")]
    public IList<V1alpha1FileSystemSpecLifecyclePolicies>? LifecyclePolicies { get; set; }

    /// <summary>
    /// The performance mode of the file system. We recommend generalPurpose performance
    /// mode for all file systems. File systems using the maxIO performance mode
    /// can scale to higher levels of aggregate throughput and operations per second
    /// with a tradeoff of slightly higher latencies for most file operations. The
    /// performance mode can&apos;t be changed after the file system has been created.
    /// The maxIO mode is not supported on One Zone file systems.
    /// 
    /// Due to the higher per-operation latencies with Max I/O, we recommend using
    /// General Purpose performance mode for all file systems.
    /// 
    /// Default is generalPurpose.
    /// </summary>
    [JsonPropertyName("performanceMode")]
    public string? PerformanceMode { get; set; }

    /// <summary>
    /// The FileSystemPolicy that you&apos;re creating. Accepts a JSON formatted policy
    /// definition. EFS file system policies have a 20,000 character limit. To find
    /// out more about the elements that make up a file system policy, see Resource-based
    /// policies within Amazon EFS (https://docs.aws.amazon.com/efs/latest/ug/security_iam_service-with-iam.html#security_iam_service-with-iam-resource-based-policies).
    /// 
    /// Regex Pattern: `^[\s\S]+$`
    /// </summary>
    [JsonPropertyName("policy")]
    public string? Policy { get; set; }

    /// <summary>
    /// The throughput, measured in mebibytes per second (MiBps), that you want to
    /// provision for a file system that you&apos;re creating. Required if ThroughputMode
    /// is set to provisioned. Valid values are 1-3414 MiBps, with the upper limit
    /// depending on Region. To increase this limit, contact Amazon Web Services
    /// Support. For more information, see Amazon EFS quotas that you can increase
    /// (https://docs.aws.amazon.com/efs/latest/ug/limits.html#soft-limits) in the
    /// Amazon EFS User Guide.
    /// </summary>
    [JsonPropertyName("provisionedThroughputInMiBps")]
    public double? ProvisionedThroughputInMiBps { get; set; }

    /// <summary>
    /// An array of destination configuration objects. Only one destination configuration
    /// object is supported.
    /// </summary>
    [JsonPropertyName("replicationConfiguration")]
    public IList<V1alpha1FileSystemSpecReplicationConfiguration>? ReplicationConfiguration { get; set; }

    /// <summary>
    /// Use to create one or more tags associated with the file system. Each tag
    /// is a user-defined key-value pair. Name your file system on creation by including
    /// a &quot;Key&quot;:&quot;Name&quot;,&quot;Value&quot;:&quot;{value}&quot; key-value pair. Each key must be unique.
    /// For more information, see Tagging Amazon Web Services resources (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html)
    /// in the Amazon Web Services General Reference Guide.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1FileSystemSpecTags>? Tags { get; set; }

    /// <summary>
    /// Specifies the throughput mode for the file system. The mode can be bursting,
    /// provisioned, or elastic. If you set ThroughputMode to provisioned, you must
    /// also set a value for ProvisionedThroughputInMibps. After you create the file
    /// system, you can decrease your file system&apos;s Provisioned throughput or change
    /// between the throughput modes, with certain time restrictions. For more information,
    /// see Specifying throughput with provisioned mode (https://docs.aws.amazon.com/efs/latest/ug/performance.html#provisioned-throughput)
    /// in the Amazon EFS User Guide.
    /// 
    /// Default is bursting.
    /// </summary>
    [JsonPropertyName("throughputMode")]
    public string? ThroughputMode { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemStatusAckResourceMetadata
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
public partial class V1alpha1FileSystemStatusConditions
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

/// <summary>Describes the destination file system in the replication configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemStatusReplicationConfigurationStatus
{
    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }

    [JsonPropertyName("lastReplicatedTimestamp")]
    public DateTime? LastReplicatedTimestamp { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>
/// The latest known metered size (in bytes) of data stored in the file system,
/// in its Value field, and the time at which that size was determined in its
/// Timestamp field. The Timestamp value is the integer number of seconds since
/// 1970-01-01T00:00:00Z. The SizeInBytes value doesn&apos;t represent the size of
/// a consistent snapshot of the file system, but it is eventually consistent
/// when there are no writes to the file system. That is, SizeInBytes represents
/// actual size only if the file system is not modified for a period longer than
/// a couple of hours. Otherwise, the value is not the exact size that the file
/// system was at any point in time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemStatusSizeInBytes
{
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }

    [JsonPropertyName("valueInArchive")]
    public long? ValueInArchive { get; set; }

    [JsonPropertyName("valueInIA")]
    public long? ValueInIA { get; set; }

    [JsonPropertyName("valueInStandard")]
    public long? ValueInStandard { get; set; }
}

/// <summary>FileSystemStatus defines the observed state of FileSystem</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FileSystemStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1FileSystemStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The unique and consistent identifier of the Availability Zone in which the
    /// file system is located, and is valid only for One Zone file systems. For
    /// example, use1-az1 is an Availability Zone ID for the us-east-1 Amazon Web
    /// Services Region, and it has the same location in every Amazon Web Services
    /// account.
    /// </summary>
    [JsonPropertyName("availabilityZoneID")]
    public string? AvailabilityZoneID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FileSystemStatusConditions>? Conditions { get; set; }

    /// <summary>The time that the file system was created, in seconds (since 1970-01-01T00:00:00Z).</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// The ID of the file system, assigned by Amazon EFS.
    /// 
    /// Regex Pattern: `^(arn:aws[-a-z]*:elasticfilesystem:[0-9a-z-:]+:file-system/fs-[0-9a-f]{8,40}|fs-[0-9a-f]{8,40})$`
    /// </summary>
    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }

    /// <summary>The lifecycle phase of the file system.</summary>
    [JsonPropertyName("lifeCycleState")]
    public string? LifeCycleState { get; set; }

    /// <summary>
    /// You can add tags to a file system, including a Name tag. For more information,
    /// see CreateFileSystem. If the file system has a Name tag, Amazon EFS returns
    /// the value in this field.
    /// 
    /// Regex Pattern: `^([\p{L}\p{Z}\p{N}_.:/=+\-@]*)$`
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The current number of mount targets that the file system has. For more information,
    /// see CreateMountTarget.
    /// </summary>
    [JsonPropertyName("numberOfMountTargets")]
    public long? NumberOfMountTargets { get; set; }

    /// <summary>
    /// The Amazon Web Services account that created the file system.
    /// 
    /// Regex Pattern: `^(\d{12})|(\d{4}-\d{4}-\d{4})$`
    /// </summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>An array of destination objects. Only one destination object is supported.</summary>
    [JsonPropertyName("replicationConfigurationStatus")]
    public IList<V1alpha1FileSystemStatusReplicationConfigurationStatus>? ReplicationConfigurationStatus { get; set; }

    /// <summary>
    /// The latest known metered size (in bytes) of data stored in the file system,
    /// in its Value field, and the time at which that size was determined in its
    /// Timestamp field. The Timestamp value is the integer number of seconds since
    /// 1970-01-01T00:00:00Z. The SizeInBytes value doesn&apos;t represent the size of
    /// a consistent snapshot of the file system, but it is eventually consistent
    /// when there are no writes to the file system. That is, SizeInBytes represents
    /// actual size only if the file system is not modified for a period longer than
    /// a couple of hours. Otherwise, the value is not the exact size that the file
    /// system was at any point in time.
    /// </summary>
    [JsonPropertyName("sizeInBytes")]
    public V1alpha1FileSystemStatusSizeInBytes? SizeInBytes { get; set; }
}

/// <summary>FileSystem is the Schema for the FileSystems API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FileSystem : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FileSystemSpec?>, IStatus<V1alpha1FileSystemStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FileSystem";
    public const string KubeGroup = "efs.services.k8s.aws";
    public const string KubePluralName = "filesystems";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "efs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FileSystem";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FileSystemSpec defines the desired state of FileSystem.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1FileSystemSpec? Spec { get; set; }

    /// <summary>FileSystemStatus defines the observed state of FileSystem</summary>
    [JsonPropertyName("status")]
    public V1alpha1FileSystemStatus? Status { get; set; }
}