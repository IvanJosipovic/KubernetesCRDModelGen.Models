#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.memorydb.services.k8s.aws;
/// <summary>Cluster is the Schema for the Clusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Cluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "memorydb.services.k8s.aws";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorydb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Cluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Cluster> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecAclRefFrom
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
public partial class V1alpha1ClusterSpecAclRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecAclRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecKmsKeyRefFrom
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
public partial class V1alpha1ClusterSpecKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecKmsKeyRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecParameterGroupRefFrom
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
public partial class V1alpha1ClusterSpecParameterGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecParameterGroupRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecSecurityGroupRefsFrom
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
public partial class V1alpha1ClusterSpecSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecSnapshotRefFrom
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
public partial class V1alpha1ClusterSpecSnapshotRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecSnapshotRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecSnsTopicRefFrom
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
public partial class V1alpha1ClusterSpecSnsTopicRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecSnsTopicRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecSubnetGroupRefFrom
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
public partial class V1alpha1ClusterSpecSubnetGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ClusterSpecSubnetGroupRefFrom? From { get; set; }
}

/// <summary>
/// A tag that can be added to an MemoryDB resource. Tags are composed of a Key/Value
/// pair. You can use tags to categorize and track all your MemoryDB resources.
/// When you add or remove tags on clusters, those actions will be replicated
/// to all nodes in the cluster. A tag with a null Value is permitted. For more
/// information, see Tagging your MemoryDB resources (https://docs.aws.amazon.com/MemoryDB/latest/devguide/tagging-resources.html)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ClusterSpec defines the desired state of Cluster.
/// 
/// Contains all of the attributes of a specific cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterSpec
{
    /// <summary>
    /// The name of the Access Control List to associate with the cluster.
    /// 
    /// Regex Pattern: `^[a-zA-Z][a-zA-Z0-9\-]*$`
    /// </summary>
    [JsonPropertyName("aclName")]
    public string? AclName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("aclRef")]
    public V1alpha1ClusterSpecAclRef? AclRef { get; set; }

    /// <summary>
    /// When set to true, the cluster will automatically receive minor engine version
    /// upgrades after launch.
    /// </summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>An optional description of the cluster.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The version number of the Redis OSS engine to be used for the cluster.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>The ID of the KMS key used to encrypt the cluster.</summary>
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
    public V1alpha1ClusterSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>
    /// Specifies the weekly time range during which maintenance on the cluster is
    /// performed. It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi
    /// (24H Clock UTC). The minimum maintenance window is a 60 minute period.
    /// 
    /// Valid values for ddd are:
    /// 
    ///   - sun
    /// 
    ///   - mon
    /// 
    ///   - tue
    /// 
    ///   - wed
    /// 
    ///   - thu
    /// 
    ///   - fri
    /// 
    ///   - sat
    /// 
    /// Example: sun:23:00-mon:01:30
    /// </summary>
    [JsonPropertyName("maintenanceWindow")]
    public string? MaintenanceWindow { get; set; }

    /// <summary>
    /// The name of the cluster. This value must be unique as it also serves as the
    /// cluster identifier.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The compute and memory capacity of the nodes in the cluster.</summary>
    [JsonPropertyName("nodeType")]
    public required string NodeType { get; set; }

    /// <summary>
    /// The number of replicas to apply to each shard. The default value is 1. The
    /// maximum is 5.
    /// </summary>
    [JsonPropertyName("numReplicasPerShard")]
    public long? NumReplicasPerShard { get; set; }

    /// <summary>The number of shards the cluster will contain. The default value is 1.</summary>
    [JsonPropertyName("numShards")]
    public long? NumShards { get; set; }

    /// <summary>The name of the parameter group associated with the cluster.</summary>
    [JsonPropertyName("parameterGroupName")]
    public string? ParameterGroupName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("parameterGroupRef")]
    public V1alpha1ClusterSpecParameterGroupRef? ParameterGroupRef { get; set; }

    /// <summary>The port number on which each of the nodes accepts connections.</summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>A list of security group names to associate with this cluster.</summary>
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1ClusterSpecSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>
    /// A list of Amazon Resource Names (ARN) that uniquely identify the RDB snapshot
    /// files stored in Amazon S3. The snapshot files are used to populate the new
    /// cluster. The Amazon S3 object name in the ARN cannot contain any commas.
    /// </summary>
    [JsonPropertyName("snapshotARNs")]
    public IList<string>? SnapshotARNs { get; set; }

    /// <summary>
    /// The name of a snapshot from which to restore data into the new cluster. The
    /// snapshot status changes to restoring while the new cluster is being created.
    /// </summary>
    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("snapshotRef")]
    public V1alpha1ClusterSpecSnapshotRef? SnapshotRef { get; set; }

    /// <summary>
    /// The number of days for which MemoryDB retains automatic snapshots before
    /// deleting them. For example, if you set SnapshotRetentionLimit to 5, a snapshot
    /// that was taken today is retained for 5 days before being deleted.
    /// </summary>
    [JsonPropertyName("snapshotRetentionLimit")]
    public long? SnapshotRetentionLimit { get; set; }

    /// <summary>
    /// The daily time range (in UTC) during which MemoryDB begins taking a daily
    /// snapshot of your shard.
    /// 
    /// Example: 05:00-09:00
    /// 
    /// If you do not specify this parameter, MemoryDB automatically chooses an appropriate
    /// time range.
    /// </summary>
    [JsonPropertyName("snapshotWindow")]
    public string? SnapshotWindow { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service
    /// (SNS) topic to which notifications are sent.
    /// </summary>
    [JsonPropertyName("snsTopicARN")]
    public string? SnsTopicARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("snsTopicRef")]
    public V1alpha1ClusterSpecSnsTopicRef? SnsTopicRef { get; set; }

    /// <summary>The name of the subnet group to be used for the cluster.</summary>
    [JsonPropertyName("subnetGroupName")]
    public string? SubnetGroupName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("subnetGroupRef")]
    public V1alpha1ClusterSpecSubnetGroupRef? SubnetGroupRef { get; set; }

    /// <summary>
    /// A list of tags to be added to this resource. Tags are comma-separated key,value
    /// pairs (e.g. Key=myKey, Value=myKeyValue. You can include multiple tags as
    /// shown following: Key=myKey, Value=myKeyValue Key=mySecondKey, Value=mySecondKeyValue.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ClusterSpecTags>? Tags { get; set; }

    /// <summary>A flag to enable in-transit encryption on the cluster.</summary>
    [JsonPropertyName("tlsEnabled")]
    public bool? TlsEnabled { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusAckResourceMetadata
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

/// <summary>The cluster&apos;s configuration endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusClusterEndpoint
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusConditions
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
/// Represents a single occurrence of something interesting within the system.
/// Some examples of events are creating a cluster or adding or removing a node.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusEvents
{
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("sourceName")]
    public string? SourceName { get; set; }

    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>The status of the ACL update</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusPendingUpdatesAcls
{
    [JsonPropertyName("aclToApply")]
    public string? AclToApply { get; set; }
}

/// <summary>Represents the progress of an online resharding operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusPendingUpdatesReshardingSlotMigration
{
    [JsonPropertyName("progressPercentage")]
    public double? ProgressPercentage { get; set; }
}

/// <summary>The status of the online resharding</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusPendingUpdatesResharding
{
    /// <summary>Represents the progress of an online resharding operation.</summary>
    [JsonPropertyName("slotMigration")]
    public V1alpha1ClusterStatusPendingUpdatesReshardingSlotMigration? SlotMigration { get; set; }
}

/// <summary>
/// Update action that has yet to be processed for the corresponding apply/stop
/// request
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusPendingUpdatesServiceUpdates
{
    [JsonPropertyName("serviceUpdateName")]
    public string? ServiceUpdateName { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>A group of settings that are currently being applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusPendingUpdates
{
    /// <summary>The status of the ACL update</summary>
    [JsonPropertyName("acls")]
    public V1alpha1ClusterStatusPendingUpdatesAcls? Acls { get; set; }

    /// <summary>The status of the online resharding</summary>
    [JsonPropertyName("resharding")]
    public V1alpha1ClusterStatusPendingUpdatesResharding? Resharding { get; set; }

    [JsonPropertyName("serviceUpdates")]
    public IList<V1alpha1ClusterStatusPendingUpdatesServiceUpdates>? ServiceUpdates { get; set; }
}

/// <summary>Represents a single security group and its status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusSecurityGroups
{
    [JsonPropertyName("securityGroupID")]
    public string? SecurityGroupID { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Represents the information required for client programs to connect to the
/// cluster and its nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusShardsNodesEndpoint
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// Represents an individual node within a cluster. Each node runs its own instance
/// of the cluster&apos;s protocol-compliant caching software.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusShardsNodes
{
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// Represents the information required for client programs to connect to the
    /// cluster and its nodes.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public V1alpha1ClusterStatusShardsNodesEndpoint? Endpoint { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Represents a collection of nodes in a cluster. One node in the node group
/// is the read/write primary node. All the other nodes are read-only Replica
/// nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatusShards
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("nodes")]
    public IList<V1alpha1ClusterStatusShardsNodes>? Nodes { get; set; }

    [JsonPropertyName("numberOfNodes")]
    public long? NumberOfNodes { get; set; }

    [JsonPropertyName("slots")]
    public string? Slots { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ClusterStatus defines the observed state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ClusterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>A list node types which you can use to scale down your cluster.</summary>
    [JsonPropertyName("allowedScaleDownNodeTypes")]
    public IList<string>? AllowedScaleDownNodeTypes { get; set; }

    /// <summary>A list node types which you can use to scale up your cluster.</summary>
    [JsonPropertyName("allowedScaleUpNodeTypes")]
    public IList<string>? AllowedScaleUpNodeTypes { get; set; }

    /// <summary>Indicates if the cluster has a Multi-AZ configuration (multiaz) or not (singleaz).</summary>
    [JsonPropertyName("availabilityMode")]
    public string? AvailabilityMode { get; set; }

    /// <summary>The cluster&apos;s configuration endpoint</summary>
    [JsonPropertyName("clusterEndpoint")]
    public V1alpha1ClusterStatusClusterEndpoint? ClusterEndpoint { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ClusterStatusConditions>? Conditions { get; set; }

    /// <summary>The Redis OSS engine patch version used by the cluster</summary>
    [JsonPropertyName("enginePatchVersion")]
    public string? EnginePatchVersion { get; set; }

    /// <summary>
    /// A list of events. Each element in the list contains detailed information
    /// about one event.
    /// </summary>
    [JsonPropertyName("events")]
    public IList<V1alpha1ClusterStatusEvents>? Events { get; set; }

    /// <summary>The number of shards in the cluster</summary>
    [JsonPropertyName("numberOfShards")]
    public long? NumberOfShards { get; set; }

    /// <summary>
    /// The status of the parameter group used by the cluster, for example &apos;active&apos;
    /// or &apos;applying&apos;.
    /// </summary>
    [JsonPropertyName("parameterGroupStatus")]
    public string? ParameterGroupStatus { get; set; }

    /// <summary>A group of settings that are currently being applied.</summary>
    [JsonPropertyName("pendingUpdates")]
    public V1alpha1ClusterStatusPendingUpdates? PendingUpdates { get; set; }

    /// <summary>A list of security groups used by the cluster</summary>
    [JsonPropertyName("securityGroups")]
    public IList<V1alpha1ClusterStatusSecurityGroups>? SecurityGroups { get; set; }

    /// <summary>A list of shards that are members of the cluster.</summary>
    [JsonPropertyName("shards")]
    public IList<V1alpha1ClusterStatusShards>? Shards { get; set; }

    /// <summary>The SNS topic must be in Active status to receive notifications</summary>
    [JsonPropertyName("snsTopicStatus")]
    public string? SnsTopicStatus { get; set; }

    /// <summary>The status of the cluster. For example, Available, Updating, Creating.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Cluster is the Schema for the Clusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterSpec?>, IStatus<V1alpha1ClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "memorydb.services.k8s.aws";
    public const string KubePluralName = "clusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorydb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Cluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ClusterSpec defines the desired state of Cluster.
    /// 
    /// Contains all of the attributes of a specific cluster.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ClusterSpec? Spec { get; set; }

    /// <summary>ClusterStatus defines the observed state of Cluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterStatus? Status { get; set; }
}