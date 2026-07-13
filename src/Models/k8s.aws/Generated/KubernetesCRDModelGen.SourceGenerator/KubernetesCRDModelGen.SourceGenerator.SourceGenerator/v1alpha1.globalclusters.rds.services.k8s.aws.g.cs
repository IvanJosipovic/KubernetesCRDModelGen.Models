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
/// <summary>GlobalCluster is the Schema for the GlobalClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GlobalClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1GlobalCluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GlobalClusterList";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "globalclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GlobalClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1GlobalCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1GlobalCluster> Items { get; set; }
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
public partial class V1alpha1GlobalClusterSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// GlobalClusterSpec defines the desired state of GlobalCluster.
/// 
/// A data type representing an Aurora global database.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GlobalClusterSpec
{
    /// <summary>
    /// The name for your database of up to 64 alphanumeric characters. If you don&apos;t
    /// specify a name, Amazon Aurora doesn&apos;t create a database in the global database
    /// cluster.
    /// 
    /// Constraints:
    /// 
    ///   - Can&apos;t be specified if SourceDBClusterIdentifier is specified. In this
    ///     case, Amazon Aurora uses the database name from the source DB cluster.
    /// </summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>
    /// Specifies whether to enable deletion protection for the new global database
    /// cluster. The global database can&apos;t be deleted when deletion protection is
    /// enabled.
    /// </summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>
    /// The database engine to use for this global database cluster.
    /// 
    /// Valid Values: aurora-mysql | aurora-postgresql
    /// 
    /// Constraints:
    /// 
    ///   - Can&apos;t be specified if SourceDBClusterIdentifier is specified. In this
    ///     case, Amazon Aurora uses the engine of the source DB cluster.
    /// </summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>
    /// The engine version to use for this global database cluster.
    /// 
    /// Constraints:
    /// 
    ///   - Can&apos;t be specified if SourceDBClusterIdentifier is specified. In this
    ///     case, Amazon Aurora uses the engine version of the source DB cluster.
    /// </summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// The cluster identifier for this global database cluster. This parameter is
    /// stored as a lowercase string.
    /// </summary>
    [JsonPropertyName("globalClusterIdentifier")]
    public string? GlobalClusterIdentifier { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) to use as the primary cluster of the global
    /// database.
    /// 
    /// If you provide a value for this parameter, don&apos;t specify values for the following
    /// settings because Amazon Aurora uses the values from the specified source
    /// DB cluster:
    /// 
    ///   - DatabaseName
    /// 
    ///   - Engine
    /// 
    ///   - EngineVersion
    /// 
    ///   - StorageEncrypted
    /// </summary>
    [JsonPropertyName("sourceDBClusterIdentifier")]
    public string? SourceDBClusterIdentifier { get; set; }

    /// <summary>
    /// Specifies whether to enable storage encryption for the new global database
    /// cluster.
    /// 
    /// Constraints:
    /// 
    ///   - Can&apos;t be specified if SourceDBClusterIdentifier is specified. In this
    ///     case, Amazon Aurora uses the setting from the source DB cluster.
    /// </summary>
    [JsonPropertyName("storageEncrypted")]
    public bool? StorageEncrypted { get; set; }

    /// <summary>Tags to assign to the global cluster.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1GlobalClusterSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GlobalClusterStatusAckResourceMetadata
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
public partial class V1alpha1GlobalClusterStatusConditions
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
/// A data object containing all properties for the current state of an in-process
/// or pending switchover or failover process for this global cluster (Aurora
/// global database). This object is empty unless the SwitchoverGlobalCluster
/// or FailoverGlobalCluster operation was called on this global cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GlobalClusterStatusFailoverState
{
    [JsonPropertyName("fromDBClusterARN")]
    public string? FromDBClusterARN { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("toDBClusterARN")]
    public string? ToDBClusterARN { get; set; }
}

/// <summary>
/// A data structure with information about any primary and secondary clusters
/// associated with a global cluster (Aurora global database).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GlobalClusterStatusGlobalClusterMembers
{
    [JsonPropertyName("dbClusterARN")]
    public string? DbClusterARN { get; set; }

    [JsonPropertyName("globalWriteForwardingStatus")]
    public string? GlobalWriteForwardingStatus { get; set; }

    [JsonPropertyName("isWriter")]
    public bool? IsWriter { get; set; }

    [JsonPropertyName("readers")]
    public IList<string>? Readers { get; set; }
}

/// <summary>GlobalClusterStatus defines the observed state of GlobalCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1GlobalClusterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1GlobalClusterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1GlobalClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The life cycle type for the global cluster.
    /// 
    /// For more information, see CreateGlobalCluster.
    /// </summary>
    [JsonPropertyName("engineLifecycleSupport")]
    public string? EngineLifecycleSupport { get; set; }

    /// <summary>
    /// A data object containing all properties for the current state of an in-process
    /// or pending switchover or failover process for this global cluster (Aurora
    /// global database). This object is empty unless the SwitchoverGlobalCluster
    /// or FailoverGlobalCluster operation was called on this global cluster.
    /// </summary>
    [JsonPropertyName("failoverState")]
    public V1alpha1GlobalClusterStatusFailoverState? FailoverState { get; set; }

    /// <summary>The list of primary and secondary clusters within the global database cluster.</summary>
    [JsonPropertyName("globalClusterMembers")]
    public IList<V1alpha1GlobalClusterStatusGlobalClusterMembers>? GlobalClusterMembers { get; set; }

    /// <summary>
    /// The Amazon Web Services Region-unique, immutable identifier for the global
    /// database cluster. This identifier is found in Amazon Web Services CloudTrail
    /// log entries whenever the Amazon Web Services KMS key for the DB cluster is
    /// accessed.
    /// </summary>
    [JsonPropertyName("globalClusterResourceID")]
    public string? GlobalClusterResourceID { get; set; }

    /// <summary>Specifies the current state of this global database cluster.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>GlobalCluster is the Schema for the GlobalClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1GlobalCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1GlobalClusterSpec?>, IStatus<V1alpha1GlobalClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "GlobalCluster";
    public const string KubeGroup = "rds.services.k8s.aws";
    public const string KubePluralName = "globalclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "rds.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "GlobalCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// GlobalClusterSpec defines the desired state of GlobalCluster.
    /// 
    /// A data type representing an Aurora global database.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1GlobalClusterSpec? Spec { get; set; }

    /// <summary>GlobalClusterStatus defines the observed state of GlobalCluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1GlobalClusterStatus? Status { get; set; }
}