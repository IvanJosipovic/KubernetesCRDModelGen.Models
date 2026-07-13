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
/// <summary>DBClusterSnapshot is the Schema for the DBClusterSnapshots API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBClusterSnapshotList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DBClusterSnapshot>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBClusterSnapshotList";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbclustersnapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBClusterSnapshotList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DBClusterSnapshot objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DBClusterSnapshot> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSnapshotSpecDbClusterIdentifierRefFrom
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
public partial class V1alpha1DBClusterSnapshotSpecDbClusterIdentifierRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1DBClusterSnapshotSpecDbClusterIdentifierRefFrom? From { get; set; }
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
public partial class V1alpha1DBClusterSnapshotSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// DBClusterSnapshotSpec defines the desired state of DBClusterSnapshot.
/// 
/// # Contains the details for an Amazon RDS DB cluster snapshot
/// 
/// This data type is used as a response element in the DescribeDBClusterSnapshots
/// action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSnapshotSpec
{
    /// <summary>
    /// The identifier of the DB cluster to create a snapshot for. This parameter
    /// isn&apos;t case-sensitive.
    /// 
    /// Constraints:
    /// 
    ///   - Must match the identifier of an existing DBCluster.
    /// 
    /// Example: my-cluster1
    /// </summary>
    [JsonPropertyName("dbClusterIdentifier")]
    public string? DbClusterIdentifier { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("dbClusterIdentifierRef")]
    public V1alpha1DBClusterSnapshotSpecDbClusterIdentifierRef? DbClusterIdentifierRef { get; set; }

    /// <summary>
    /// The identifier of the DB cluster snapshot. This parameter is stored as a
    /// lowercase string.
    /// 
    /// Constraints:
    /// 
    ///   - Must contain from 1 to 63 letters, numbers, or hyphens.
    /// 
    ///   - First character must be a letter.
    /// 
    ///   - Can&apos;t end with a hyphen or contain two consecutive hyphens.
    /// 
    /// Example: my-cluster1-snapshot1
    /// </summary>
    [JsonPropertyName("dbClusterSnapshotIdentifier")]
    public required string DbClusterSnapshotIdentifier { get; set; }

    /// <summary>The tags to be assigned to the DB cluster snapshot.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1DBClusterSnapshotSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSnapshotStatusAckResourceMetadata
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
public partial class V1alpha1DBClusterSnapshotStatusConditions
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
/// Metadata assigned to an Amazon RDS resource consisting of a key-value pair.
/// 
/// For more information, see Tagging Amazon RDS resources (https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html)
/// in the Amazon RDS User Guide or Tagging Amazon Aurora and Amazon RDS resources
/// (https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html)
/// in the Amazon Aurora User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSnapshotStatusTagList
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>DBClusterSnapshotStatus defines the observed state of DBClusterSnapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DBClusterSnapshotStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1DBClusterSnapshotStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The allocated storage size of the DB cluster snapshot in gibibytes (GiB).</summary>
    [JsonPropertyName("allocatedStorage")]
    public long? AllocatedStorage { get; set; }

    /// <summary>
    /// The list of Availability Zones (AZs) where instances in the DB cluster snapshot
    /// can be restored.
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>The time when the DB cluster was created, in Universal Coordinated Time (UTC).</summary>
    [JsonPropertyName("clusterCreateTime")]
    public DateTime? ClusterCreateTime { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DBClusterSnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>Reserved for future use.</summary>
    [JsonPropertyName("dbSystemID")]
    public string? DbSystemID { get; set; }

    /// <summary>The name of the database engine for this DB cluster snapshot.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The engine mode of the database engine for this DB cluster snapshot.</summary>
    [JsonPropertyName("engineMode")]
    public string? EngineMode { get; set; }

    /// <summary>The version of the database engine for this DB cluster snapshot.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// Indicates whether mapping of Amazon Web Services Identity and Access Management
    /// (IAM) accounts to database accounts is enabled.
    /// </summary>
    [JsonPropertyName("iamDatabaseAuthenticationEnabled")]
    public bool? IamDatabaseAuthenticationEnabled { get; set; }

    /// <summary>
    /// If StorageEncrypted is true, the Amazon Web Services KMS key identifier for
    /// the encrypted DB cluster snapshot.
    /// 
    /// The Amazon Web Services KMS key identifier is the key ARN, key ID, alias
    /// ARN, or alias name for the KMS key.
    /// </summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>The license model information for this DB cluster snapshot.</summary>
    [JsonPropertyName("licenseModel")]
    public string? LicenseModel { get; set; }

    /// <summary>The master username for this DB cluster snapshot.</summary>
    [JsonPropertyName("masterUsername")]
    public string? MasterUsername { get; set; }

    /// <summary>The percentage of the estimated data that has been transferred.</summary>
    [JsonPropertyName("percentProgress")]
    public long? PercentProgress { get; set; }

    /// <summary>The port that the DB cluster was listening on at the time of the snapshot.</summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>The time when the snapshot was taken, in Universal Coordinated Time (UTC).</summary>
    [JsonPropertyName("snapshotCreateTime")]
    public DateTime? SnapshotCreateTime { get; set; }

    /// <summary>The type of the DB cluster snapshot.</summary>
    [JsonPropertyName("snapshotType")]
    public string? SnapshotType { get; set; }

    /// <summary>
    /// If the DB cluster snapshot was copied from a source DB cluster snapshot,
    /// the Amazon Resource Name (ARN) for the source DB cluster snapshot, otherwise,
    /// a null value.
    /// </summary>
    [JsonPropertyName("sourceDBClusterSnapshotARN")]
    public string? SourceDBClusterSnapshotARN { get; set; }

    /// <summary>
    /// The status of this DB cluster snapshot. Valid statuses are the following:
    /// 
    ///    * available
    /// 
    ///    * copying
    /// 
    ///    * creating
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Indicates whether the DB cluster snapshot is encrypted.</summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    [JsonPropertyName("tagList")]
    public IList<V1alpha1DBClusterSnapshotStatusTagList>? TagList { get; set; }

    /// <summary>The VPC ID associated with the DB cluster snapshot.</summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>DBClusterSnapshot is the Schema for the DBClusterSnapshots API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DBClusterSnapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DBClusterSnapshotSpec?>, IStatus<V1alpha1DBClusterSnapshotStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DBClusterSnapshot";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "dbclustersnapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DBClusterSnapshot";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DBClusterSnapshotSpec defines the desired state of DBClusterSnapshot.
    /// 
    /// # Contains the details for an Amazon RDS DB cluster snapshot
    /// 
    /// This data type is used as a response element in the DescribeDBClusterSnapshots
    /// action.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1DBClusterSnapshotSpec? Spec { get; set; }

    /// <summary>DBClusterSnapshotStatus defines the observed state of DBClusterSnapshot</summary>
    [JsonPropertyName("status")]
    public V1alpha1DBClusterSnapshotStatus? Status { get; set; }
}