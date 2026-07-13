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
/// <summary>DBCluster is the Schema for the DBClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DBCluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBClusterList";
    public const string KubeGroup = "documentdb.services.k8s.aws";
    public const string KubePluralName = "dbclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DBCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DBCluster> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecDbSubnetGroupRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecDbSubnetGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSpecDbSubnetGroupRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecKmsKeyRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSpecKmsKeyRefFrom? From { get; set; }
}

/// <summary>
/// The password for the master database user. This password can contain any
/// printable ASCII character except forward slash (/), double quote (&quot;), or
/// the &quot;at&quot; symbol (@).
/// 
/// Constraints: Must contain from 8 to 100 characters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecMasterUserPassword
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

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecMasterUserSecretKMSKeyRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecMasterUserSecretKMSKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSpecMasterUserSecretKMSKeyRefFrom? From { get; set; }
}

/// <summary>Contains the scaling configuration of an Amazon DocumentDB Serverless cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecServerlessV2ScalingConfiguration
{
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }
}

/// <summary>
/// Metadata assigned to an Amazon DocumentDB resource consisting of a key-value
/// pair.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecVpcSecurityGroupRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpecVpcSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSpecVpcSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// DBClusterSpec defines the desired state of DBCluster.
/// 
/// Detailed information about a cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSpec
{
    /// <summary>
    /// A list of Amazon EC2 Availability Zones that instances in the cluster can
    /// be created in.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>
    /// The number of days for which automated backups are retained. You must specify
    /// a minimum value of 1.
    /// 
    /// Default: 1
    /// 
    /// Constraints:
    /// 
    ///   - Must be a value from 1 to 35.
    /// </summary>
    [JsonPropertyName("backupRetentionPeriod")]
    public long? BackupRetentionPeriod { get; set; }

    /// <summary>
    /// The cluster identifier. This parameter is stored as a lowercase string.
    /// 
    /// Constraints:
    /// 
    ///   - Must contain from 1 to 63 letters, numbers, or hyphens.
    /// 
    ///   - The first character must be a letter.
    /// 
    ///   - Cannot end with a hyphen or contain two consecutive hyphens.
    /// 
    /// Example: my-cluster
    /// </summary>
    [JsonPropertyName("dbClusterIdentifier")]
    public required string DbClusterIdentifier { get; set; }

    /// <summary>The name of the cluster parameter group to associate with this cluster.</summary>
    [JsonPropertyName("dbClusterParameterGroupName")]
    public string? DbClusterParameterGroupName { get; set; }

    /// <summary>
    /// A subnet group to associate with this cluster.
    /// 
    /// Constraints: Must match the name of an existing DBSubnetGroup. Must not be
    /// default.
    /// 
    /// Example: mySubnetgroup
    /// </summary>
    [JsonPropertyName("dbSubnetGroupName")]
    public string? DbSubnetGroupName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("dbSubnetGroupRef")]
    public V1alpha1DBClusterSpecDbSubnetGroupRef? DbSubnetGroupRef { get; set; }

    /// <summary>
    /// Specifies whether this cluster can be deleted. If DeletionProtection is enabled,
    /// the cluster cannot be deleted unless it is modified and DeletionProtection
    /// is disabled. DeletionProtection protects clusters from being accidentally
    /// deleted.
    /// </summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>DestinationRegion is used for presigning the request to a given region.</summary>
    [JsonPropertyName("destinationRegion")]
    public string? DestinationRegion { get; set; }

    /// <summary>
    /// A list of log types that need to be enabled for exporting to Amazon CloudWatch
    /// Logs. You can enable audit logs or profiler logs. For more information, see
    /// Auditing Amazon DocumentDB Events (https://docs.aws.amazon.com/documentdb/latest/developerguide/event-auditing.html)
    /// and Profiling Amazon DocumentDB Operations (https://docs.aws.amazon.com/documentdb/latest/developerguide/profiling.html).
    /// </summary>
    [JsonPropertyName("enableCloudwatchLogsExports")]
    public IList<string>? EnableCloudwatchLogsExports { get; set; }

    /// <summary>
    /// The name of the database engine to be used for this cluster.
    /// 
    /// Valid values: docdb
    /// </summary>
    [JsonPropertyName("engine")]
    public required string Engine { get; set; }

    /// <summary>
    /// The version number of the database engine to use. The --engine-version will
    /// default to the latest major engine version. For production workloads, we
    /// recommend explicitly declaring this parameter with the intended major engine
    /// version.
    /// </summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// The cluster identifier of the new global cluster.
    /// 
    /// Regex Pattern: `^[A-Za-z][0-9A-Za-z-:._]*$`
    /// </summary>
    [JsonPropertyName("globalClusterIdentifier")]
    public string? GlobalClusterIdentifier { get; set; }

    /// <summary>
    /// The KMS key identifier for an encrypted cluster.
    /// 
    /// The KMS key identifier is the Amazon Resource Name (ARN) for the KMS encryption
    /// key. If you are creating a cluster using the same Amazon Web Services account
    /// that owns the KMS encryption key that is used to encrypt the new cluster,
    /// you can use the KMS key alias instead of the ARN for the KMS encryption key.
    /// 
    /// If an encryption key is not specified in KmsKeyId:
    /// 
    ///   - If the StorageEncrypted parameter is true, Amazon DocumentDB uses your
    ///     default encryption key.
    /// 
    /// KMS creates the default encryption key for your Amazon Web Services account.
    /// Your Amazon Web Services account has a different default encryption key for
    /// each Amazon Web Services Regions.
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
    public V1alpha1DBClusterSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>
    /// Specifies whether to manage the master user password with Amazon Web Services
    /// Secrets Manager.
    /// 
    /// Constraint: You can&apos;t manage the master user password with Amazon Web Services
    /// Secrets Manager if MasterUserPassword is specified.
    /// </summary>
    [JsonPropertyName("manageMasterUserPassword")]
    public bool? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// The password for the master database user. This password can contain any
    /// printable ASCII character except forward slash (/), double quote (&quot;), or
    /// the &quot;at&quot; symbol (@).
    /// 
    /// Constraints: Must contain from 8 to 100 characters.
    /// </summary>
    [JsonPropertyName("masterUserPassword")]
    public V1alpha1DBClusterSpecMasterUserPassword? MasterUserPassword { get; set; }

    /// <summary>
    /// The Amazon Web Services KMS key identifier to encrypt a secret that is automatically
    /// generated and managed in Amazon Web Services Secrets Manager. This setting
    /// is valid only if the master user password is managed by Amazon DocumentDB
    /// in Amazon Web Services Secrets Manager for the DB cluster.
    /// 
    /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias
    /// ARN, or alias name for the KMS key. To use a KMS key in a different Amazon
    /// Web Services account, specify the key ARN or alias ARN.
    /// 
    /// If you don&apos;t specify MasterUserSecretKmsKeyId, then the aws/secretsmanager
    /// KMS key is used to encrypt the secret. If the secret is in a different Amazon
    /// Web Services account, then you can&apos;t use the aws/secretsmanager KMS key to
    /// encrypt the secret, and you must use a customer managed KMS key.
    /// 
    /// There is a default KMS key for your Amazon Web Services account. Your Amazon
    /// Web Services account has a different default KMS key for each Amazon Web
    /// Services Region.
    /// </summary>
    [JsonPropertyName("masterUserSecretKMSKeyID")]
    public string? MasterUserSecretKMSKeyID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("masterUserSecretKMSKeyRef")]
    public V1alpha1DBClusterSpecMasterUserSecretKMSKeyRef? MasterUserSecretKMSKeyRef { get; set; }

    /// <summary>
    /// The name of the master user for the cluster.
    /// 
    /// Constraints:
    /// 
    ///   - Must be from 1 to 63 letters or numbers.
    /// 
    ///   - The first character must be a letter.
    /// 
    ///   - Cannot be a reserved word for the chosen database engine.
    /// </summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>
    /// The network type of the cluster.
    /// 
    /// The network type is determined by the DBSubnetGroup specified for the cluster.
    /// A DBSubnetGroup can support only the IPv4 protocol or the IPv4 and the IPv6
    /// protocols (DUAL).
    /// 
    /// For more information, see DocumentDB clusters in a VPC (https://docs.aws.amazon.com/documentdb/latest/developerguide/vpc-clusters.html)
    /// in the Amazon DocumentDB Developer Guide.
    /// 
    /// Valid Values: IPV4 | DUAL
    /// </summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>The port number on which the instances in the cluster accept connections.</summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>Not currently supported.</summary>
    [JsonPropertyName("preSignedURL")]
    public string? PreSignedURL { get; set; }

    /// <summary>
    /// The daily time range during which automated backups are created if automated
    /// backups are enabled using the BackupRetentionPeriod parameter.
    /// 
    /// The default is a 30-minute window selected at random from an 8-hour block
    /// of time for each Amazon Web Services Region.
    /// 
    /// Constraints:
    /// 
    ///   - Must be in the format hh24:mi-hh24:mi.
    /// 
    ///   - Must be in Universal Coordinated Time (UTC).
    /// 
    ///   - Must not conflict with the preferred maintenance window.
    /// 
    ///   - Must be at least 30 minutes.
    /// </summary>
    [JsonPropertyName("preferredBackupWindow")]
    public string? PreferredBackupWindow { get; set; }

    /// <summary>
    /// The weekly time range during which system maintenance can occur, in Universal
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

    /// <summary>Contains the scaling configuration of an Amazon DocumentDB Serverless cluster.</summary>
    [JsonPropertyName("serverlessV2ScalingConfiguration")]
    public V1alpha1DBClusterSpecServerlessV2ScalingConfiguration? ServerlessV2ScalingConfiguration { get; set; }

    /// <summary>
    /// The identifier for the snapshot or cluster snapshot to restore from.
    /// 
    /// You can use either the name or the Amazon Resource Name (ARN) to specify
    /// a cluster snapshot. However, you can use only the ARN to specify a snapshot.
    /// 
    /// Constraints:
    /// 
    ///   - Must match the identifier of an existing snapshot.
    /// </summary>
    [JsonPropertyName("snapshotIdentifier")]
    public string? SnapshotIdentifier { get; set; }

    /// <summary>
    /// SourceRegion is the source region where the resource exists. This is not
    /// sent over the wire and is only used for presigning. This value should always
    /// have the same region as the source ARN.
    /// </summary>
    [JsonPropertyName("sourceRegion")]
    public string? SourceRegion { get; set; }

    /// <summary>Specifies whether the cluster is encrypted.</summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>
    /// The storage type to associate with the DB cluster.
    /// 
    /// For information on storage types for Amazon DocumentDB clusters, see Cluster
    /// storage configurations in the Amazon DocumentDB Developer Guide.
    /// 
    /// # Valid values for storage type - standard | iopt1
    /// 
    /// # Default value is standard
    /// 
    /// When you create an Amazon DocumentDB cluster with the storage type set to
    /// iopt1, the storage type is returned in the response. The storage type isn&apos;t
    /// returned when you set it to standard.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }

    /// <summary>The tags to be assigned to the cluster.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DBClusterSpecTags>? Tags { get; set; }

    /// <summary>A list of EC2 VPC security groups to associate with this cluster.</summary>
    [JsonPropertyName("vpcSecurityGroupIDs")]
    public IList<string>? VpcSecurityGroupIDs { get; set; }

    [JsonPropertyName("vpcSecurityGroupRefs")]
    public IList<V1alpha1DBClusterSpecVpcSecurityGroupRefs>? VpcSecurityGroupRefs { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusAckResourceMetadata
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
/// Describes an Identity and Access Management (IAM) role that is associated
/// with a cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusAssociatedRoles
{
    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusConditions
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

/// <summary>Contains information about an instance that is part of a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusDbClusterMembers
{
    [JsonPropertyName("dbClusterParameterGroupStatus")]
    public string? DbClusterParameterGroupStatus { get; set; }

    [JsonPropertyName("dbInstanceIdentifier")]
    public string? DbInstanceIdentifier { get; set; }

    [JsonPropertyName("isClusterWriter")]
    public bool? IsClusterWriter { get; set; }

    [JsonPropertyName("promotionTier")]
    public long? PromotionTier { get; set; }
}

/// <summary>
/// The secret managed by Amazon DocumentDB in Amazon Web Services Secrets Manager
/// for the master user password.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusMasterUserSecret
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("secretARN")]
    public string? SecretARN { get; set; }

    [JsonPropertyName("secretStatus")]
    public string? SecretStatus { get; set; }
}

/// <summary>
/// Used as a response element for queries on virtual private cloud (VPC) security
/// group membership.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatusVpcSecurityGroups
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("vpcSecurityGroupID")]
    public string? VpcSecurityGroupID { get; set; }
}

/// <summary>DBClusterStatus defines the observed state of DBCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DBClusterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// Provides a list of the Identity and Access Management (IAM) roles that are
    /// associated with the cluster. (IAM) roles that are associated with a cluster
    /// grant permission for the cluster to access other Amazon Web Services services
    /// on your behalf.
    /// </summary>
    [JsonPropertyName("associatedRoles")]
    public IList<V1alpha1DBClusterStatusAssociatedRoles>? AssociatedRoles { get; set; }

    /// <summary>Identifies the clone group to which the DB cluster is associated.</summary>
    [JsonPropertyName("cloneGroupID")]
    public string? CloneGroupID { get; set; }

    /// <summary>
    /// Specifies the time when the cluster was created, in Universal Coordinated
    /// Time (UTC).
    /// </summary>
    [JsonPropertyName("clusterCreateTime")]
    public DateTime? ClusterCreateTime { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DBClusterStatusConditions>? Conditions { get; set; }

    /// <summary>Provides the list of instances that make up the cluster.</summary>
    [JsonPropertyName("dbClusterMembers")]
    public IList<V1alpha1DBClusterStatusDbClusterMembers>? DbClusterMembers { get; set; }

    /// <summary>Specifies the name of the cluster parameter group for the cluster.</summary>
    [JsonPropertyName("dbClusterParameterGroup")]
    public string? DbClusterParameterGroup { get; set; }

    /// <summary>
    /// The Amazon Web Services Region-unique, immutable identifier for the cluster.
    /// This identifier is found in CloudTrail log entries whenever the KMS key for
    /// the cluster is accessed.
    /// </summary>
    [JsonPropertyName("dbClusterResourceID")]
    public string? DbClusterResourceID { get; set; }

    /// <summary>
    /// Specifies information on the subnet group that is associated with the cluster,
    /// including the name, description, and subnets in the subnet group.
    /// </summary>
    [JsonPropertyName("dbSubnetGroup")]
    public string? DbSubnetGroup { get; set; }

    /// <summary>
    /// The earliest time to which a database can be restored with point-in-time
    /// restore.
    /// </summary>
    [JsonPropertyName("earliestRestorableTime")]
    public DateTime? EarliestRestorableTime { get; set; }

    /// <summary>
    /// A list of log types that this cluster is configured to export to Amazon CloudWatch
    /// Logs.
    /// </summary>
    [JsonPropertyName("enabledCloudwatchLogsExports")]
    public IList<string>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>Specifies the connection endpoint for the primary instance of the cluster.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Specifies the ID that Amazon Route 53 assigns when you create a hosted zone.</summary>
    [JsonPropertyName("hostedZoneID")]
    public string? HostedZoneID { get; set; }

    /// <summary>
    /// The next time you can modify the Amazon DocumentDB cluster to use the iopt1
    /// storage type.
    /// </summary>
    [JsonPropertyName("iOOptimizedNextAllowedModificationTime")]
    public DateTime? IOOptimizedNextAllowedModificationTime { get; set; }

    /// <summary>
    /// Specifies the latest time to which a database can be restored with point-in-time
    /// restore.
    /// </summary>
    [JsonPropertyName("latestRestorableTime")]
    public DateTime? LatestRestorableTime { get; set; }

    /// <summary>
    /// The secret managed by Amazon DocumentDB in Amazon Web Services Secrets Manager
    /// for the master user password.
    /// </summary>
    [JsonPropertyName("masterUserSecret")]
    public V1alpha1DBClusterStatusMasterUserSecret? MasterUserSecret { get; set; }

    /// <summary>Specifies whether the cluster has instances in multiple Availability Zones.</summary>
    [JsonPropertyName("multiAZ")]
    public bool? MultiAZ { get; set; }

    /// <summary>Specifies the progress of the operation as a percentage.</summary>
    [JsonPropertyName("percentProgress")]
    public string? PercentProgress { get; set; }

    /// <summary>
    /// Contains one or more identifiers of the secondary clusters that are associated
    /// with this cluster.
    /// </summary>
    [JsonPropertyName("readReplicaIdentifiers")]
    public IList<string>? ReadReplicaIdentifiers { get; set; }

    /// <summary>
    /// The reader endpoint for the cluster. The reader endpoint for a cluster load
    /// balances connections across the Amazon DocumentDB replicas that are available
    /// in a cluster. As clients request new connections to the reader endpoint,
    /// Amazon DocumentDB distributes the connection requests among the Amazon DocumentDB
    /// replicas in the cluster. This functionality can help balance your read workload
    /// across multiple Amazon DocumentDB replicas in your cluster.
    /// 
    /// If a failover occurs, and the Amazon DocumentDB replica that you are connected
    /// to is promoted to be the primary instance, your connection is dropped. To
    /// continue sending your read workload to other Amazon DocumentDB replicas in
    /// the cluster, you can then reconnect to the reader endpoint.
    /// </summary>
    [JsonPropertyName("readerEndpoint")]
    public string? ReaderEndpoint { get; set; }

    /// <summary>
    /// Contains the identifier of the source cluster if this cluster is a secondary
    /// cluster.
    /// </summary>
    [JsonPropertyName("replicationSourceIdentifier")]
    public string? ReplicationSourceIdentifier { get; set; }

    /// <summary>Specifies the current state of this cluster.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Provides a list of virtual private cloud (VPC) security groups that the cluster
    /// belongs to.
    /// </summary>
    [JsonPropertyName("vpcSecurityGroups")]
    public IList<V1alpha1DBClusterStatusVpcSecurityGroups>? VpcSecurityGroups { get; set; }
}

/// <summary>DBCluster is the Schema for the DBClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DBClusterSpec?>, IStatus<V1alpha1DBClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBCluster";
    public const string KubeGroup = "documentdb.services.k8s.aws";
    public const string KubePluralName = "dbclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DBClusterSpec defines the desired state of DBCluster.
    /// 
    /// Detailed information about a cluster.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DBClusterSpec? Spec { get; set; }

    /// <summary>DBClusterStatus defines the observed state of DBCluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1DBClusterStatus? Status { get; set; }
}