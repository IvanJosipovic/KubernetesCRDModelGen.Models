#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elasticache.services.k8s.aws;
/// <summary>Snapshot is the Schema for the Snapshots API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SnapshotList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Snapshot>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SnapshotList";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "snapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SnapshotList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Snapshot objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Snapshot> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotSpecKmsKeyRefFrom
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
public partial class V1alpha1SnapshotSpecKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SnapshotSpecKmsKeyRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotSpecReplicationGroupRefFrom
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
public partial class V1alpha1SnapshotSpecReplicationGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SnapshotSpecReplicationGroupRefFrom? From { get; set; }
}

/// <summary>
/// A tag that can be added to an ElastiCache cluster or replication group. Tags
/// are composed of a Key/Value pair. You can use tags to categorize and track
/// all your ElastiCache resources, with the exception of global replication
/// group. When you add or remove tags on replication groups, those actions will
/// be replicated to all nodes in the replication group. A tag with a null Value
/// is permitted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// SnapshotSpec defines the desired state of Snapshot.
/// 
/// Represents a copy of an entire Valkey or Redis OSS cluster as of the time
/// when the snapshot was taken.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotSpec
{
    /// <summary>
    /// The identifier of an existing cluster. The snapshot is created from this
    /// cluster.
    /// </summary>
    [JsonPropertyName("cacheClusterID")]
    public string? CacheClusterID { get; set; }

    /// <summary>The ID of the KMS key used to encrypt the snapshot.</summary>
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
    public V1alpha1SnapshotSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>
    /// The identifier of an existing replication group. The snapshot is created
    /// from this replication group.
    /// </summary>
    [JsonPropertyName("replicationGroupID")]
    public string? ReplicationGroupID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("replicationGroupRef")]
    public V1alpha1SnapshotSpecReplicationGroupRef? ReplicationGroupRef { get; set; }

    /// <summary>A name for the snapshot being created.</summary>
    [JsonPropertyName("snapshotName")]
    public required string SnapshotName { get; set; }

    /// <summary>The name of an existing snapshot from which to make a copy.</summary>
    [JsonPropertyName("sourceSnapshotName")]
    public string? SourceSnapshotName { get; set; }

    /// <summary>
    /// A list of tags to be added to this resource. A tag is a key-value pair. A
    /// tag key must be accompanied by a tag value, although null is accepted.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1SnapshotSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotStatusAckResourceMetadata
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
public partial class V1alpha1SnapshotStatusConditions
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
/// Node group (shard) configuration options. Each node group (shard) configuration
/// has the following: Slots, PrimaryAvailabilityZone, ReplicaAvailabilityZones,
/// ReplicaCount.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotStatusNodeSnapshotsNodeGroupConfiguration
{
    [JsonPropertyName("nodeGroupID")]
    public string? NodeGroupID { get; set; }

    [JsonPropertyName("primaryAvailabilityZone")]
    public string? PrimaryAvailabilityZone { get; set; }

    [JsonPropertyName("primaryOutpostARN")]
    public string? PrimaryOutpostARN { get; set; }

    [JsonPropertyName("replicaAvailabilityZones")]
    public IList<string>? ReplicaAvailabilityZones { get; set; }

    [JsonPropertyName("replicaCount")]
    public long? ReplicaCount { get; set; }

    [JsonPropertyName("replicaOutpostARNs")]
    public IList<string>? ReplicaOutpostARNs { get; set; }

    [JsonPropertyName("slots")]
    public string? Slots { get; set; }
}

/// <summary>Represents an individual cache node in a snapshot of a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotStatusNodeSnapshots
{
    [JsonPropertyName("cacheClusterID")]
    public string? CacheClusterID { get; set; }

    [JsonPropertyName("cacheNodeCreateTime")]
    public DateTime? CacheNodeCreateTime { get; set; }

    [JsonPropertyName("cacheNodeID")]
    public string? CacheNodeID { get; set; }

    [JsonPropertyName("cacheSize")]
    public string? CacheSize { get; set; }

    /// <summary>
    /// Node group (shard) configuration options. Each node group (shard) configuration
    /// has the following: Slots, PrimaryAvailabilityZone, ReplicaAvailabilityZones,
    /// ReplicaCount.
    /// </summary>
    [JsonPropertyName("nodeGroupConfiguration")]
    public V1alpha1SnapshotStatusNodeSnapshotsNodeGroupConfiguration? NodeGroupConfiguration { get; set; }

    [JsonPropertyName("nodeGroupID")]
    public string? NodeGroupID { get; set; }

    [JsonPropertyName("snapshotCreateTime")]
    public DateTime? SnapshotCreateTime { get; set; }
}

/// <summary>SnapshotStatus defines the observed state of Snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SnapshotStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1SnapshotStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// If you are running Valkey 7.2 and above or Redis OSS engine version 6.0 and
    /// above, set this parameter to yes if you want to opt-in to the next auto minor
    /// version upgrade campaign. This parameter is disabled for previous versions.
    /// </summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// Indicates the status of automatic failover for the source Valkey or Redis
    /// OSS replication group.
    /// </summary>
    [JsonPropertyName("automaticFailover")]
    public string? AutomaticFailover { get; set; }

    /// <summary>The date and time when the source cluster was created.</summary>
    [JsonPropertyName("cacheClusterCreateTime")]
    public DateTime? CacheClusterCreateTime { get; set; }

    /// <summary>
    /// The name of the compute and memory capacity node type for the source cluster.
    /// 
    /// The following node types are supported by ElastiCache. Generally speaking,
    /// the current generation types provide more memory and computational power
    /// at lower cost when compared to their equivalent previous generation counterparts.
    /// 
    ///    * General purpose: Current generation: M7g node types: cache.m7g.large,
    ///    cache.m7g.xlarge, cache.m7g.2xlarge, cache.m7g.4xlarge, cache.m7g.8xlarge,
    ///    cache.m7g.12xlarge, cache.m7g.16xlarge For region availability, see Supported
    ///    Node Types (https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion)
    ///    M6g node types (available only for Redis OSS engine version 5.0.6 onward
    ///    and for Memcached engine version 1.5.16 onward): cache.m6g.large, cache.m6g.xlarge,
    ///    cache.m6g.2xlarge, cache.m6g.4xlarge, cache.m6g.8xlarge, cache.m6g.12xlarge,
    ///    cache.m6g.16xlarge M5 node types: cache.m5.large, cache.m5.xlarge, cache.m5.2xlarge,
    ///    cache.m5.4xlarge, cache.m5.12xlarge, cache.m5.24xlarge M4 node types:
    ///    cache.m4.large, cache.m4.xlarge, cache.m4.2xlarge, cache.m4.4xlarge, cache.m4.10xlarge
    ///    T4g node types (available only for Redis OSS engine version 5.0.6 onward
    ///    and Memcached engine version 1.5.16 onward): cache.t4g.micro, cache.t4g.small,
    ///    cache.t4g.medium T3 node types: cache.t3.micro, cache.t3.small, cache.t3.medium
    ///    T2 node types: cache.t2.micro, cache.t2.small, cache.t2.medium Previous
    ///    generation: (not recommended. Existing clusters are still supported but
    ///    creation of new clusters is not supported for these types.) T1 node types:
    ///    cache.t1.micro M1 node types: cache.m1.small, cache.m1.medium, cache.m1.large,
    ///    cache.m1.xlarge M3 node types: cache.m3.medium, cache.m3.large, cache.m3.xlarge,
    ///    cache.m3.2xlarge
    /// 
    ///    * Compute optimized: Previous generation: (not recommended. Existing clusters
    ///    are still supported but creation of new clusters is not supported for
    ///    these types.) C1 node types: cache.c1.xlarge
    /// 
    ///    * Memory optimized: Current generation: R7g node types: cache.r7g.large,
    ///    cache.r7g.xlarge, cache.r7g.2xlarge, cache.r7g.4xlarge, cache.r7g.8xlarge,
    ///    cache.r7g.12xlarge, cache.r7g.16xlarge For region availability, see Supported
    ///    Node Types (https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion)
    ///    R6g node types (available only for Redis OSS engine version 5.0.6 onward
    ///    and for Memcached engine version 1.5.16 onward): cache.r6g.large, cache.r6g.xlarge,
    ///    cache.r6g.2xlarge, cache.r6g.4xlarge, cache.r6g.8xlarge, cache.r6g.12xlarge,
    ///    cache.r6g.16xlarge R5 node types: cache.r5.large, cache.r5.xlarge, cache.r5.2xlarge,
    ///    cache.r5.4xlarge, cache.r5.12xlarge, cache.r5.24xlarge R4 node types:
    ///    cache.r4.large, cache.r4.xlarge, cache.r4.2xlarge, cache.r4.4xlarge, cache.r4.8xlarge,
    ///    cache.r4.16xlarge Previous generation: (not recommended. Existing clusters
    ///    are still supported but creation of new clusters is not supported for
    ///    these types.) M2 node types: cache.m2.xlarge, cache.m2.2xlarge, cache.m2.4xlarge
    ///    R3 node types: cache.r3.large, cache.r3.xlarge, cache.r3.2xlarge, cache.r3.4xlarge,
    ///    cache.r3.8xlarge
    /// 
    /// Additional node type info
    /// 
    ///    * All current generation instance types are created in Amazon VPC by default.
    /// 
    ///    * Valkey or Redis OSS append-only files (AOF) are not supported for T1
    ///    or T2 instances.
    /// 
    ///    * Valkey or Redis OSS Multi-AZ with automatic failover is not supported
    ///    on T1 instances.
    /// 
    ///    * The configuration variables appendonly and appendfsync are not supported
    ///    on Valkey, or on Redis OSS version 2.8.22 and later.
    /// </summary>
    [JsonPropertyName("cacheNodeType")]
    public string? CacheNodeType { get; set; }

    /// <summary>The cache parameter group that is associated with the source cluster.</summary>
    [JsonPropertyName("cacheParameterGroupName")]
    public string? CacheParameterGroupName { get; set; }

    /// <summary>The name of the cache subnet group associated with the source cluster.</summary>
    [JsonPropertyName("cacheSubnetGroupName")]
    public string? CacheSubnetGroupName { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Enables data tiering. Data tiering is only supported for replication groups
    /// using the r6gd node type. This parameter must be set to true when using r6gd
    /// nodes. For more information, see Data tiering (https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/data-tiering.html).
    /// </summary>
    [JsonPropertyName("dataTiering")]
    public string? DataTiering { get; set; }

    /// <summary>The name of the cache engine (memcached or redis) used by the source cluster.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The version of the cache engine version that is used by the source cluster.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>A list of the cache nodes in the source cluster.</summary>
    [JsonPropertyName("nodeSnapshots")]
    public IList<V1alpha1SnapshotStatusNodeSnapshots>? NodeSnapshots { get; set; }

    /// <summary>
    /// The number of cache nodes in the source cluster.
    /// 
    /// For clusters running Valkey or Redis OSS, this value must be 1. For clusters
    /// running Memcached, this value must be between 1 and 40.
    /// </summary>
    [JsonPropertyName("numCacheNodes")]
    public long? NumCacheNodes { get; set; }

    /// <summary>
    /// The number of node groups (shards) in this snapshot. When restoring from
    /// a snapshot, the number of node groups (shards) in the snapshot and in the
    /// restored replication group must be the same.
    /// </summary>
    [JsonPropertyName("numNodeGroups")]
    public long? NumNodeGroups { get; set; }

    /// <summary>The port number used by each cache nodes in the source cluster.</summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>The name of the Availability Zone in which the source cluster is located.</summary>
    [JsonPropertyName("preferredAvailabilityZone")]
    public string? PreferredAvailabilityZone { get; set; }

    /// <summary>
    /// Specifies the weekly time range during which maintenance on the cluster is
    /// performed. It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi
    /// (24H Clock UTC). The minimum maintenance window is a 60 minute period.
    /// 
    /// Valid values for ddd are:
    /// 
    ///    * sun
    /// 
    ///    * mon
    /// 
    ///    * tue
    /// 
    ///    * wed
    /// 
    ///    * thu
    /// 
    ///    * fri
    /// 
    ///    * sat
    /// 
    /// Example: sun:23:00-mon:01:30
    /// </summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>The ARN (Amazon Resource Name) of the preferred outpost.</summary>
    [JsonPropertyName("preferredOutpostARN")]
    public string? PreferredOutpostARN { get; set; }

    /// <summary>A description of the source replication group.</summary>
    [JsonPropertyName("replicationGroupDescription")]
    public string? ReplicationGroupDescription { get; set; }

    /// <summary>
    /// For an automatic snapshot, the number of days for which ElastiCache retains
    /// the snapshot before deleting it.
    /// 
    /// For manual snapshots, this field reflects the SnapshotRetentionLimit for
    /// the source cluster when the snapshot was created. This field is otherwise
    /// ignored: Manual snapshots do not expire, and can only be deleted using the
    /// DeleteSnapshot operation.
    /// 
    /// Important If the value of SnapshotRetentionLimit is set to zero (0), backups
    /// are turned off.
    /// </summary>
    [JsonPropertyName("snapshotRetentionLimit")]
    public long? SnapshotRetentionLimit { get; set; }

    /// <summary>
    /// Indicates whether the snapshot is from an automatic backup (automated) or
    /// was created manually (manual).
    /// </summary>
    [JsonPropertyName("snapshotSource")]
    public string? SnapshotSource { get; set; }

    /// <summary>
    /// The status of the snapshot. Valid values: creating | available | restoring
    /// | copying | deleting.
    /// </summary>
    [JsonPropertyName("snapshotStatus")]
    public string? SnapshotStatus { get; set; }

    /// <summary>
    /// The daily time range during which ElastiCache takes daily snapshots of the
    /// source cluster.
    /// </summary>
    [JsonPropertyName("snapshotWindow")]
    public string? SnapshotWindow { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) for the topic used by the source cluster for
    /// publishing notifications.
    /// </summary>
    [JsonPropertyName("topicARN")]
    public string? TopicARN { get; set; }

    /// <summary>
    /// The Amazon Virtual Private Cloud identifier (VPC ID) of the cache subnet
    /// group for the source cluster.
    /// </summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>Snapshot is the Schema for the Snapshots API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Snapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SnapshotSpec?>, IStatus<V1alpha1SnapshotStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Snapshot";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "snapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Snapshot";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// SnapshotSpec defines the desired state of Snapshot.
    /// 
    /// Represents a copy of an entire Valkey or Redis OSS cluster as of the time
    /// when the snapshot was taken.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1SnapshotSpec? Spec { get; set; }

    /// <summary>SnapshotStatus defines the observed state of Snapshot</summary>
    [JsonPropertyName("status")]
    public V1alpha1SnapshotStatus? Status { get; set; }
}