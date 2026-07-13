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
/// <summary>ReplicationGroup is the Schema for the ReplicationGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ReplicationGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ReplicationGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ReplicationGroupList";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "replicationgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReplicationGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ReplicationGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ReplicationGroup> Items { get; set; }
}

/// <summary>
/// Reserved parameter. The password used to access a password protected server.
/// 
/// AuthToken can be specified only on replication groups where TransitEncryptionEnabled
/// is true.
/// 
/// For HIPAA compliance, you must specify TransitEncryptionEnabled as true,
/// an AuthToken, and a CacheSubnetGroup.
/// 
/// Password constraints:
/// 
///   - Must be only printable ASCII characters.
/// 
///   - Must be at least 16 characters and no more than 128 characters in length.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupSpecAuthToken
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
public partial class V1alpha1ReplicationGroupSpecCacheParameterGroupRefFrom
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
public partial class V1alpha1ReplicationGroupSpecCacheParameterGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ReplicationGroupSpecCacheParameterGroupRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupSpecCacheSubnetGroupRefFrom
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
public partial class V1alpha1ReplicationGroupSpecCacheSubnetGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ReplicationGroupSpecCacheSubnetGroupRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupSpecKmsKeyRefFrom
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
public partial class V1alpha1ReplicationGroupSpecKmsKeyRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ReplicationGroupSpecKmsKeyRefFrom? From { get; set; }
}

/// <summary>The configuration details of the CloudWatch Logs destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupSpecLogDeliveryConfigurationsDestinationDetailsCloudWatchLogsDetails
{
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

/// <summary>The configuration details of the Kinesis Data Firehose destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupSpecLogDeliveryConfigurationsDestinationDetailsKinesisFirehoseDetails
{
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }
}

/// <summary>
/// Configuration details of either a CloudWatch Logs destination or Kinesis
/// Data Firehose destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupSpecLogDeliveryConfigurationsDestinationDetails
{
    /// <summary>The configuration details of the CloudWatch Logs destination.</summary>
    [JsonPropertyName("cloudWatchLogsDetails")]
    public V1alpha1ReplicationGroupSpecLogDeliveryConfigurationsDestinationDetailsCloudWatchLogsDetails? CloudWatchLogsDetails { get; set; }

    /// <summary>The configuration details of the Kinesis Data Firehose destination.</summary>
    [JsonPropertyName("kinesisFirehoseDetails")]
    public V1alpha1ReplicationGroupSpecLogDeliveryConfigurationsDestinationDetailsKinesisFirehoseDetails? KinesisFirehoseDetails { get; set; }
}

/// <summary>Specifies the destination, format and type of the logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupSpecLogDeliveryConfigurations
{
    /// <summary>
    /// Configuration details of either a CloudWatch Logs destination or Kinesis
    /// Data Firehose destination.
    /// </summary>
    [JsonPropertyName("destinationDetails")]
    public V1alpha1ReplicationGroupSpecLogDeliveryConfigurationsDestinationDetails? DestinationDetails { get; set; }

    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }

    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary>
/// Node group (shard) configuration options. Each node group (shard) configuration
/// has the following: Slots, PrimaryAvailabilityZone, ReplicaAvailabilityZones,
/// ReplicaCount.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupSpecNodeGroupConfiguration
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

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupSpecSecurityGroupRefsFrom
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
public partial class V1alpha1ReplicationGroupSpecSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ReplicationGroupSpecSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// A tag that can be added to an ElastiCache cluster or replication group. Tags
/// are composed of a Key/Value pair. You can use tags to categorize and track
/// all your ElastiCache resources, with the exception of global replication
/// group. When you add or remove tags on replication groups, those actions will
/// be replicated to all nodes in the replication group. A tag with a null Value
/// is permitted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ReplicationGroupSpec defines the desired state of ReplicationGroup.
/// 
/// Contains all of the attributes of a specific Valkey or Redis OSS replication
/// group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupSpec
{
    /// <summary>
    /// A flag that enables encryption at rest when set to true.
    /// 
    /// You cannot modify the value of AtRestEncryptionEnabled after the replication
    /// group is created. To enable encryption at rest on a replication group you
    /// must set AtRestEncryptionEnabled to true when you create the replication
    /// group.
    /// 
    /// Required: Only available when creating a replication group in an Amazon VPC
    /// using Valkey 7.2 and later, Redis OSS version 3.2.6, or Redis OSS 4.x and
    /// later.
    /// 
    /// Default: true when using Valkey, false when using Redis OSS
    /// </summary>
    [JsonPropertyName("atRestEncryptionEnabled")]
    public bool? AtRestEncryptionEnabled { get; set; }

    /// <summary>
    /// Reserved parameter. The password used to access a password protected server.
    /// 
    /// AuthToken can be specified only on replication groups where TransitEncryptionEnabled
    /// is true.
    /// 
    /// For HIPAA compliance, you must specify TransitEncryptionEnabled as true,
    /// an AuthToken, and a CacheSubnetGroup.
    /// 
    /// Password constraints:
    /// 
    ///   - Must be only printable ASCII characters.
    /// 
    ///   - Must be at least 16 characters and no more than 128 characters in length.
    /// </summary>
    [JsonPropertyName("authToken")]
    public V1alpha1ReplicationGroupSpecAuthToken? AuthToken { get; set; }

    /// <summary>
    /// Specifies whether a read-only replica is automatically promoted to read/write
    /// primary if the existing primary fails.
    /// 
    /// AutomaticFailoverEnabled must be enabled for Valkey or Redis OSS (cluster
    /// mode enabled) replication groups.
    /// 
    /// Default: false
    /// </summary>
    [JsonPropertyName("automaticFailoverEnabled")]
    public bool? AutomaticFailoverEnabled { get; set; }

    /// <summary>
    /// The compute and memory capacity of the nodes in the node group (shard).
    /// 
    /// The following node types are supported by ElastiCache. Generally speaking,
    /// the current generation types provide more memory and computational power
    /// at lower cost when compared to their equivalent previous generation counterparts.
    /// 
    ///   - General purpose: Current generation: M7g node types: cache.m7g.large,
    ///     cache.m7g.xlarge, cache.m7g.2xlarge, cache.m7g.4xlarge, cache.m7g.8xlarge,
    ///     cache.m7g.12xlarge, cache.m7g.16xlarge For region availability, see Supported
    ///     Node Types (https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion)
    ///     M6g node types (available only for Redis OSS engine version 5.0.6 onward
    ///     and for Memcached engine version 1.5.16 onward): cache.m6g.large, cache.m6g.xlarge,
    ///     cache.m6g.2xlarge, cache.m6g.4xlarge, cache.m6g.8xlarge, cache.m6g.12xlarge,
    ///     cache.m6g.16xlarge M5 node types: cache.m5.large, cache.m5.xlarge, cache.m5.2xlarge,
    ///     cache.m5.4xlarge, cache.m5.12xlarge, cache.m5.24xlarge M4 node types:
    ///     cache.m4.large, cache.m4.xlarge, cache.m4.2xlarge, cache.m4.4xlarge, cache.m4.10xlarge
    ///     T4g node types (available only for Redis OSS engine version 5.0.6 onward
    ///     and Memcached engine version 1.5.16 onward): cache.t4g.micro, cache.t4g.small,
    ///     cache.t4g.medium T3 node types: cache.t3.micro, cache.t3.small, cache.t3.medium
    ///     T2 node types: cache.t2.micro, cache.t2.small, cache.t2.medium Previous
    ///     generation: (not recommended. Existing clusters are still supported but
    ///     creation of new clusters is not supported for these types.) T1 node types:
    ///     cache.t1.micro M1 node types: cache.m1.small, cache.m1.medium, cache.m1.large,
    ///     cache.m1.xlarge M3 node types: cache.m3.medium, cache.m3.large, cache.m3.xlarge,
    ///     cache.m3.2xlarge
    /// 
    ///   - Compute optimized: Previous generation: (not recommended. Existing clusters
    ///     are still supported but creation of new clusters is not supported for
    ///     these types.) C1 node types: cache.c1.xlarge
    /// 
    ///   - Memory optimized: Current generation: R7g node types: cache.r7g.large,
    ///     cache.r7g.xlarge, cache.r7g.2xlarge, cache.r7g.4xlarge, cache.r7g.8xlarge,
    ///     cache.r7g.12xlarge, cache.r7g.16xlarge For region availability, see Supported
    ///     Node Types (https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion)
    ///     R6g node types (available only for Redis OSS engine version 5.0.6 onward
    ///     and for Memcached engine version 1.5.16 onward): cache.r6g.large, cache.r6g.xlarge,
    ///     cache.r6g.2xlarge, cache.r6g.4xlarge, cache.r6g.8xlarge, cache.r6g.12xlarge,
    ///     cache.r6g.16xlarge R5 node types: cache.r5.large, cache.r5.xlarge, cache.r5.2xlarge,
    ///     cache.r5.4xlarge, cache.r5.12xlarge, cache.r5.24xlarge R4 node types:
    ///     cache.r4.large, cache.r4.xlarge, cache.r4.2xlarge, cache.r4.4xlarge, cache.r4.8xlarge,
    ///     cache.r4.16xlarge Previous generation: (not recommended. Existing clusters
    ///     are still supported but creation of new clusters is not supported for
    ///     these types.) M2 node types: cache.m2.xlarge, cache.m2.2xlarge, cache.m2.4xlarge
    ///     R3 node types: cache.r3.large, cache.r3.xlarge, cache.r3.2xlarge, cache.r3.4xlarge,
    ///     cache.r3.8xlarge
    /// 
    /// Additional node type info
    /// 
    ///   - All current generation instance types are created in Amazon VPC by default.
    /// 
    ///   - Valkey or Redis OSS append-only files (AOF) are not supported for T1
    ///     or T2 instances.
    /// 
    ///   - Valkey or Redis OSS Multi-AZ with automatic failover is not supported
    ///     on T1 instances.
    /// 
    ///   - The configuration variables appendonly and appendfsync are not supported
    ///     on Valkey, or on Redis OSS version 2.8.22 and later.
    /// </summary>
    [JsonPropertyName("cacheNodeType")]
    public string? CacheNodeType { get; set; }

    /// <summary>
    /// The name of the parameter group to associate with this replication group.
    /// If this argument is omitted, the default cache parameter group for the specified
    /// engine is used.
    /// 
    /// If you are running Valkey or Redis OSS version 3.2.4 or later, only one node
    /// group (shard), and want to use a default parameter group, we recommend that
    /// you specify the parameter group by name.
    /// 
    ///   - To create a Valkey or Redis OSS (cluster mode disabled) replication
    ///     group, use CacheParameterGroupName=default.redis3.2.
    /// 
    ///   - To create a Valkey or Redis OSS (cluster mode enabled) replication group,
    ///     use CacheParameterGroupName=default.redis3.2.cluster.on.
    /// </summary>
    [JsonPropertyName("cacheParameterGroupName")]
    public string? CacheParameterGroupName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("cacheParameterGroupRef")]
    public V1alpha1ReplicationGroupSpecCacheParameterGroupRef? CacheParameterGroupRef { get; set; }

    /// <summary>A list of cache security group names to associate with this replication group.</summary>
    [JsonPropertyName("cacheSecurityGroupNames")]
    public IList<string>? CacheSecurityGroupNames { get; set; }

    /// <summary>
    /// The name of the cache subnet group to be used for the replication group.
    /// 
    /// If you&apos;re going to launch your cluster in an Amazon VPC, you need to create
    /// a subnet group before you start creating a cluster. For more information,
    /// see Subnets and Subnet Groups (https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/SubnetGroups.html).
    /// </summary>
    [JsonPropertyName("cacheSubnetGroupName")]
    public string? CacheSubnetGroupName { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("cacheSubnetGroupRef")]
    public V1alpha1ReplicationGroupSpecCacheSubnetGroupRef? CacheSubnetGroupRef { get; set; }

    /// <summary>
    /// Enables data tiering. Data tiering is only supported for replication groups
    /// using the r6gd node type. This parameter must be set to true when using r6gd
    /// nodes. For more information, see Data tiering (https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/data-tiering.html).
    /// </summary>
    [JsonPropertyName("dataTieringEnabled")]
    public bool? DataTieringEnabled { get; set; }

    /// <summary>A user-created description for the replication group.</summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// The name of the cache engine to be used for the clusters in this replication
    /// group. The value must be set to valkey or redis.
    /// </summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>
    /// The version number of the cache engine to be used for the clusters in this
    /// replication group. To view the supported cache engine versions, use the DescribeCacheEngineVersions
    /// operation.
    /// 
    /// Important: You can upgrade to a newer engine version (see Selecting a Cache
    /// Engine and Version (https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/SelectEngine.html#VersionManagement))
    /// in the ElastiCache User Guide, but you cannot downgrade to an earlier engine
    /// version. If you want to use an earlier engine version, you must delete the
    /// existing cluster or replication group and create it anew with the earlier
    /// engine version.
    /// </summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// The network type you choose when creating a replication group, either ipv4
    /// | ipv6. IPv6 is supported for workloads using Valkey 7.2 and above, Redis
    /// OSS engine version 6.2 to 7.1 or Memcached engine version 1.6.6 and above
    /// on all instances built on the Nitro system (http://aws.amazon.com/ec2/nitro/).
    /// </summary>
    [JsonPropertyName("ipDiscovery")]
    public string? IpDiscovery { get; set; }

    /// <summary>The ID of the KMS key used to encrypt the disk in the cluster.</summary>
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
    public V1alpha1ReplicationGroupSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Specifies the destination, format and type of the logs.</summary>
    [JsonPropertyName("logDeliveryConfigurations")]
    public IList<V1alpha1ReplicationGroupSpecLogDeliveryConfigurations>? LogDeliveryConfigurations { get; set; }

    /// <summary>
    /// A flag indicating if you have Multi-AZ enabled to enhance fault tolerance.
    /// For more information, see Minimizing Downtime: Multi-AZ (http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/AutoFailover.html).
    /// </summary>
    [JsonPropertyName("multiAZEnabled")]
    public bool? MultiAZEnabled { get; set; }

    /// <summary>
    /// Must be either ipv4 | ipv6 | dual_stack. IPv6 is supported for workloads
    /// using Valkey 7.2 and above, Redis OSS engine version 6.2 to 7.1 and Memcached
    /// engine version 1.6.6 and above on all instances built on the Nitro system
    /// (http://aws.amazon.com/ec2/nitro/).
    /// </summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>
    /// A list of node group (shard) configuration options. Each node group (shard)
    /// configuration has the following members: PrimaryAvailabilityZone, ReplicaAvailabilityZones,
    /// ReplicaCount, and Slots.
    /// 
    /// If you&apos;re creating a Valkey or Redis OSS (cluster mode disabled) or a Valkey
    /// or Redis OSS (cluster mode enabled) replication group, you can use this parameter
    /// to individually configure each node group (shard), or you can omit this parameter.
    /// However, it is required when seeding a Valkey or Redis OSS (cluster mode
    /// enabled) cluster from a S3 rdb file. You must configure each node group (shard)
    /// using this parameter because you must specify the slots for each node group.
    /// </summary>
    [JsonPropertyName("nodeGroupConfiguration")]
    public IList<V1alpha1ReplicationGroupSpecNodeGroupConfiguration>? NodeGroupConfiguration { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service
    /// (SNS) topic to which notifications are sent.
    /// 
    /// The Amazon SNS topic owner must be the same as the cluster owner.
    /// </summary>
    [JsonPropertyName("notificationTopicARN")]
    public string? NotificationTopicARN { get; set; }

    /// <summary>
    /// An optional parameter that specifies the number of node groups (shards) for
    /// this Valkey or Redis OSS (cluster mode enabled) replication group. For Valkey
    /// or Redis OSS (cluster mode disabled) either omit this parameter or set it
    /// to 1.
    /// 
    /// Default: 1
    /// </summary>
    [JsonPropertyName("numNodeGroups")]
    public long? NumNodeGroups { get; set; }

    /// <summary>The port number on which each member of the replication group accepts connections.</summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>
    /// A list of EC2 Availability Zones in which the replication group&apos;s clusters
    /// are created. The order of the Availability Zones in the list is the order
    /// in which clusters are allocated. The primary cluster is created in the first
    /// AZ in the list.
    /// 
    /// This parameter is not used if there is more than one node group (shard).
    /// You should use NodeGroupConfiguration instead.
    /// 
    /// If you are creating your replication group in an Amazon VPC (recommended),
    /// you can only locate clusters in Availability Zones associated with the subnets
    /// in the selected subnet group.
    /// 
    /// The number of Availability Zones listed must equal the value of NumCacheClusters.
    /// 
    /// Default: system chosen Availability Zones.
    /// </summary>
    [JsonPropertyName("preferredCacheClusterAZs")]
    public IList<string>? PreferredCacheClusterAZs { get; set; }

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
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// The identifier of the cluster that serves as the primary for this replication
    /// group. This cluster must already exist and have a status of available.
    /// 
    /// This parameter is not required if NumCacheClusters, NumNodeGroups, or ReplicasPerNodeGroup
    /// is specified.
    /// </summary>
    [JsonPropertyName("primaryClusterID")]
    public string? PrimaryClusterID { get; set; }

    /// <summary>
    /// An optional parameter that specifies the number of replica nodes in each
    /// node group (shard). Valid values are 0 to 5.
    /// </summary>
    [JsonPropertyName("replicasPerNodeGroup")]
    public long? ReplicasPerNodeGroup { get; set; }

    /// <summary>
    /// The replication group identifier. This parameter is stored as a lowercase
    /// string.
    /// 
    /// Constraints:
    /// 
    ///   - A name must contain from 1 to 40 alphanumeric characters or hyphens.
    /// 
    ///   - The first character must be a letter.
    /// 
    ///   - A name cannot end with a hyphen or contain two consecutive hyphens.
    /// </summary>
    [JsonPropertyName("replicationGroupID")]
    public required string ReplicationGroupID { get; set; }

    /// <summary>
    /// One or more Amazon VPC security groups associated with this replication group.
    /// 
    /// Use this parameter only when you are creating a replication group in an Amazon
    /// Virtual Private Cloud (Amazon VPC).
    /// </summary>
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1ReplicationGroupSpecSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>
    /// A list of Amazon Resource Names (ARN) that uniquely identify the Valkey or
    /// Redis OSS RDB snapshot files stored in Amazon S3. The snapshot files are
    /// used to populate the new replication group. The Amazon S3 object name in
    /// the ARN cannot contain any commas. The new replication group will have the
    /// number of node groups (console: shards) specified by the parameter NumNodeGroups
    /// or the number of node groups configured by NodeGroupConfiguration regardless
    /// of the number of ARNs specified here.
    /// 
    /// Example of an Amazon S3 ARN: arn:aws:s3:::my_bucket/snapshot1.rdb
    /// </summary>
    [JsonPropertyName("snapshotARNs")]
    public IList<string>? SnapshotARNs { get; set; }

    /// <summary>
    /// The name of a snapshot from which to restore data into the new replication
    /// group. The snapshot status changes to restoring while the new replication
    /// group is being created.
    /// </summary>
    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }

    /// <summary>
    /// The number of days for which ElastiCache retains automatic snapshots before
    /// deleting them. For example, if you set SnapshotRetentionLimit to 5, a snapshot
    /// that was taken today is retained for 5 days before being deleted.
    /// 
    /// Default: 0 (i.e., automatic backups are disabled for this cluster).
    /// </summary>
    [JsonPropertyName("snapshotRetentionLimit")]
    public long? SnapshotRetentionLimit { get; set; }

    /// <summary>
    /// The daily time range (in UTC) during which ElastiCache begins taking a daily
    /// snapshot of your node group (shard).
    /// 
    /// Example: 05:00-09:00
    /// 
    /// If you do not specify this parameter, ElastiCache automatically chooses an
    /// appropriate time range.
    /// </summary>
    [JsonPropertyName("snapshotWindow")]
    public string? SnapshotWindow { get; set; }

    /// <summary>
    /// A list of tags to be added to this resource. Tags are comma-separated key,value
    /// pairs (e.g. Key=myKey, Value=myKeyValue. You can include multiple tags as
    /// shown following: Key=myKey, Value=myKeyValue Key=mySecondKey, Value=mySecondKeyValue.
    /// Tags on replication groups will be replicated to all nodes.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ReplicationGroupSpecTags>? Tags { get; set; }

    /// <summary>
    /// A flag that enables in-transit encryption when set to true.
    /// 
    /// This parameter is valid only if the Engine parameter is redis, the EngineVersion
    /// parameter is 3.2.6, 4.x or later, and the cluster is being created in an
    /// Amazon VPC.
    /// 
    /// If you enable in-transit encryption, you must also specify a value for CacheSubnetGroup.
    /// 
    /// Required: Only available when creating a replication group in an Amazon VPC
    /// using Redis OSS version 3.2.6, 4.x or later.
    /// 
    /// Default: false
    /// 
    /// For HIPAA compliance, you must specify TransitEncryptionEnabled as true,
    /// an AuthToken, and a CacheSubnetGroup.
    /// </summary>
    [JsonPropertyName("transitEncryptionEnabled")]
    public bool? TransitEncryptionEnabled { get; set; }

    /// <summary>The user group to associate with the replication group.</summary>
    [JsonPropertyName("userGroupIDs")]
    public IList<string>? UserGroupIDs { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusConditions
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
/// The configuration endpoint for this replication group. Use the configuration
/// endpoint to connect to this replication group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusConfigurationEndpoint
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// Represents a single occurrence of something interesting within the system.
/// Some examples of events are creating a cluster, adding or removing a cache
/// node, or rebooting a node.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusEvents
{
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("sourceIdentifier")]
    public string? SourceIdentifier { get; set; }

    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

/// <summary>
/// The name of the Global datastore and role of this replication group in the
/// Global datastore.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusGlobalReplicationGroupInfo
{
    [JsonPropertyName("globalReplicationGroupID")]
    public string? GlobalReplicationGroupID { get; set; }

    [JsonPropertyName("globalReplicationGroupMemberRole")]
    public string? GlobalReplicationGroupMemberRole { get; set; }
}

/// <summary>The configuration details of the CloudWatch Logs destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusLogDeliveryConfigurationsDestinationDetailsCloudWatchLogsDetails
{
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

/// <summary>The configuration details of the Kinesis Data Firehose destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusLogDeliveryConfigurationsDestinationDetailsKinesisFirehoseDetails
{
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }
}

/// <summary>
/// Configuration details of either a CloudWatch Logs destination or Kinesis
/// Data Firehose destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusLogDeliveryConfigurationsDestinationDetails
{
    /// <summary>The configuration details of the CloudWatch Logs destination.</summary>
    [JsonPropertyName("cloudWatchLogsDetails")]
    public V1alpha1ReplicationGroupStatusLogDeliveryConfigurationsDestinationDetailsCloudWatchLogsDetails? CloudWatchLogsDetails { get; set; }

    /// <summary>The configuration details of the Kinesis Data Firehose destination.</summary>
    [JsonPropertyName("kinesisFirehoseDetails")]
    public V1alpha1ReplicationGroupStatusLogDeliveryConfigurationsDestinationDetailsKinesisFirehoseDetails? KinesisFirehoseDetails { get; set; }
}

/// <summary>Returns the destination, format and type of the logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusLogDeliveryConfigurations
{
    /// <summary>
    /// Configuration details of either a CloudWatch Logs destination or Kinesis
    /// Data Firehose destination.
    /// </summary>
    [JsonPropertyName("destinationDetails")]
    public V1alpha1ReplicationGroupStatusLogDeliveryConfigurationsDestinationDetails? DestinationDetails { get; set; }

    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }

    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Represents the information required for client programs to connect to a cache
/// node. This value is read-only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusNodeGroupsNodeGroupMembersReadEndpoint
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>Represents a single node within a node group (shard).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusNodeGroupsNodeGroupMembers
{
    [JsonPropertyName("cacheClusterID")]
    public string? CacheClusterID { get; set; }

    [JsonPropertyName("cacheNodeID")]
    public string? CacheNodeID { get; set; }

    [JsonPropertyName("currentRole")]
    public string? CurrentRole { get; set; }

    [JsonPropertyName("preferredAvailabilityZone")]
    public string? PreferredAvailabilityZone { get; set; }

    [JsonPropertyName("preferredOutpostARN")]
    public string? PreferredOutpostARN { get; set; }

    /// <summary>
    /// Represents the information required for client programs to connect to a cache
    /// node. This value is read-only.
    /// </summary>
    [JsonPropertyName("readEndpoint")]
    public V1alpha1ReplicationGroupStatusNodeGroupsNodeGroupMembersReadEndpoint? ReadEndpoint { get; set; }
}

/// <summary>
/// Represents the information required for client programs to connect to a cache
/// node. This value is read-only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusNodeGroupsPrimaryEndpoint
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// Represents the information required for client programs to connect to a cache
/// node. This value is read-only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusNodeGroupsReaderEndpoint
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// Represents a collection of cache nodes in a replication group. One node in
/// the node group is the read/write primary node. All the other nodes are read-only
/// Replica nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusNodeGroups
{
    [JsonPropertyName("nodeGroupID")]
    public string? NodeGroupID { get; set; }

    [JsonPropertyName("nodeGroupMembers")]
    public IList<V1alpha1ReplicationGroupStatusNodeGroupsNodeGroupMembers>? NodeGroupMembers { get; set; }

    /// <summary>
    /// Represents the information required for client programs to connect to a cache
    /// node. This value is read-only.
    /// </summary>
    [JsonPropertyName("primaryEndpoint")]
    public V1alpha1ReplicationGroupStatusNodeGroupsPrimaryEndpoint? PrimaryEndpoint { get; set; }

    /// <summary>
    /// Represents the information required for client programs to connect to a cache
    /// node. This value is read-only.
    /// </summary>
    [JsonPropertyName("readerEndpoint")]
    public V1alpha1ReplicationGroupStatusNodeGroupsReaderEndpoint? ReaderEndpoint { get; set; }

    [JsonPropertyName("slots")]
    public string? Slots { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>The configuration details of the CloudWatch Logs destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusPendingModifiedValuesLogDeliveryConfigurationsDestinationDetailsCloudWatchLogsDetails
{
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

/// <summary>The configuration details of the Kinesis Data Firehose destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusPendingModifiedValuesLogDeliveryConfigurationsDestinationDetailsKinesisFirehoseDetails
{
    [JsonPropertyName("deliveryStream")]
    public string? DeliveryStream { get; set; }
}

/// <summary>
/// Configuration details of either a CloudWatch Logs destination or Kinesis
/// Data Firehose destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusPendingModifiedValuesLogDeliveryConfigurationsDestinationDetails
{
    /// <summary>The configuration details of the CloudWatch Logs destination.</summary>
    [JsonPropertyName("cloudWatchLogsDetails")]
    public V1alpha1ReplicationGroupStatusPendingModifiedValuesLogDeliveryConfigurationsDestinationDetailsCloudWatchLogsDetails? CloudWatchLogsDetails { get; set; }

    /// <summary>The configuration details of the Kinesis Data Firehose destination.</summary>
    [JsonPropertyName("kinesisFirehoseDetails")]
    public V1alpha1ReplicationGroupStatusPendingModifiedValuesLogDeliveryConfigurationsDestinationDetailsKinesisFirehoseDetails? KinesisFirehoseDetails { get; set; }
}

/// <summary>The log delivery configurations being modified</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusPendingModifiedValuesLogDeliveryConfigurations
{
    /// <summary>
    /// Configuration details of either a CloudWatch Logs destination or Kinesis
    /// Data Firehose destination.
    /// </summary>
    [JsonPropertyName("destinationDetails")]
    public V1alpha1ReplicationGroupStatusPendingModifiedValuesLogDeliveryConfigurationsDestinationDetails? DestinationDetails { get; set; }

    [JsonPropertyName("destinationType")]
    public string? DestinationType { get; set; }

    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }

    [JsonPropertyName("logType")]
    public string? LogType { get; set; }
}

/// <summary>Represents the progress of an online resharding operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusPendingModifiedValuesReshardingSlotMigration
{
    [JsonPropertyName("progressPercentage")]
    public double? ProgressPercentage { get; set; }
}

/// <summary>The status of an online resharding operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusPendingModifiedValuesResharding
{
    /// <summary>Represents the progress of an online resharding operation.</summary>
    [JsonPropertyName("slotMigration")]
    public V1alpha1ReplicationGroupStatusPendingModifiedValuesReshardingSlotMigration? SlotMigration { get; set; }
}

/// <summary>The status of the user group update.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusPendingModifiedValuesUserGroups
{
    [JsonPropertyName("userGroupIDsToAdd")]
    public IList<string>? UserGroupIDsToAdd { get; set; }

    [JsonPropertyName("userGroupIDsToRemove")]
    public IList<string>? UserGroupIDsToRemove { get; set; }
}

/// <summary>
/// A group of settings to be applied to the replication group, either immediately
/// or during the next maintenance window.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatusPendingModifiedValues
{
    [JsonPropertyName("authTokenStatus")]
    public string? AuthTokenStatus { get; set; }

    [JsonPropertyName("automaticFailoverStatus")]
    public string? AutomaticFailoverStatus { get; set; }

    [JsonPropertyName("logDeliveryConfigurations")]
    public IList<V1alpha1ReplicationGroupStatusPendingModifiedValuesLogDeliveryConfigurations>? LogDeliveryConfigurations { get; set; }

    [JsonPropertyName("primaryClusterID")]
    public string? PrimaryClusterID { get; set; }

    /// <summary>The status of an online resharding operation.</summary>
    [JsonPropertyName("resharding")]
    public V1alpha1ReplicationGroupStatusPendingModifiedValuesResharding? Resharding { get; set; }

    /// <summary>The status of the user group update.</summary>
    [JsonPropertyName("userGroups")]
    public V1alpha1ReplicationGroupStatusPendingModifiedValuesUserGroups? UserGroups { get; set; }
}

/// <summary>ReplicationGroupStatus defines the observed state of ReplicationGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ReplicationGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ReplicationGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// A string list, each element of which specifies a cache node type which you
    /// can use to scale your cluster or replication group. When scaling down a Valkey
    /// or Redis OSS cluster or replication group using ModifyCacheCluster or ModifyReplicationGroup,
    /// use a value from this list for the CacheNodeType parameter.
    /// </summary>
    [JsonPropertyName("allowedScaleDownModifications")]
    public IList<string>? AllowedScaleDownModifications { get; set; }

    /// <summary>
    /// A string list, each element of which specifies a cache node type which you
    /// can use to scale your cluster or replication group.
    /// 
    /// When scaling up a Valkey or Redis OSS cluster or replication group using
    /// ModifyCacheCluster or ModifyReplicationGroup, use a value from this list
    /// for the CacheNodeType parameter.
    /// </summary>
    [JsonPropertyName("allowedScaleUpModifications")]
    public IList<string>? AllowedScaleUpModifications { get; set; }

    /// <summary>
    /// A flag that enables using an AuthToken (password) when issuing Valkey or
    /// Redis OSS commands.
    /// 
    /// Default: false
    /// </summary>
    [JsonPropertyName("authTokenEnabled")]
    public bool? AuthTokenEnabled { get; set; }

    /// <summary>The date the auth token was last modified</summary>
    [JsonPropertyName("authTokenLastModifiedDate")]
    public DateTime? AuthTokenLastModifiedDate { get; set; }

    /// <summary>
    /// If you are running Valkey 7.2 and above, or Redis OSS engine version 6.0
    /// and above, set this parameter to yes if you want to opt-in to the next auto
    /// minor version upgrade campaign. This parameter is disabled for previous versions.
    /// </summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// Indicates the status of automatic failover for this Valkey or Redis OSS replication
    /// group.
    /// </summary>
    [JsonPropertyName("automaticFailover")]
    public string? AutomaticFailover { get; set; }

    /// <summary>
    /// A flag indicating whether or not this replication group is cluster enabled;
    /// i.e., whether its data can be partitioned across multiple shards (API/CLI:
    /// node groups).
    /// 
    /// Valid values: true | false
    /// </summary>
    [JsonPropertyName("clusterEnabled")]
    public bool? ClusterEnabled { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ReplicationGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The configuration endpoint for this replication group. Use the configuration
    /// endpoint to connect to this replication group.
    /// </summary>
    [JsonPropertyName("configurationEndpoint")]
    public V1alpha1ReplicationGroupStatusConfigurationEndpoint? ConfigurationEndpoint { get; set; }

    /// <summary>
    /// Enables data tiering. Data tiering is only supported for replication groups
    /// using the r6gd node type. This parameter must be set to true when using r6gd
    /// nodes. For more information, see Data tiering (https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/data-tiering.html).
    /// </summary>
    [JsonPropertyName("dataTiering")]
    public string? DataTiering { get; set; }

    /// <summary>
    /// A list of events. Each element in the list contains detailed information
    /// about one event.
    /// </summary>
    [JsonPropertyName("events")]
    public IList<V1alpha1ReplicationGroupStatusEvents>? Events { get; set; }

    /// <summary>
    /// The name of the Global datastore and role of this replication group in the
    /// Global datastore.
    /// </summary>
    [JsonPropertyName("globalReplicationGroupInfo")]
    public V1alpha1ReplicationGroupStatusGlobalReplicationGroupInfo? GlobalReplicationGroupInfo { get; set; }

    /// <summary>Returns the destination, format and type of the logs.</summary>
    [JsonPropertyName("logDeliveryConfigurations")]
    public IList<V1alpha1ReplicationGroupStatusLogDeliveryConfigurations>? LogDeliveryConfigurations { get; set; }

    /// <summary>The names of all the cache clusters that are part of this replication group.</summary>
    [JsonPropertyName("memberClusters")]
    public IList<string>? MemberClusters { get; set; }

    /// <summary>The outpost ARNs of the replication group&apos;s member clusters.</summary>
    [JsonPropertyName("memberClustersOutpostARNs")]
    public IList<string>? MemberClustersOutpostARNs { get; set; }

    /// <summary>
    /// A flag indicating if you have Multi-AZ enabled to enhance fault tolerance.
    /// For more information, see Minimizing Downtime: Multi-AZ (http://docs.aws.amazon.com/AmazonElastiCache/latest/dg/AutoFailover.html)
    /// </summary>
    [JsonPropertyName("multiAZ")]
    public string? MultiAZ { get; set; }

    /// <summary>
    /// A list of node groups in this replication group. For Valkey or Redis OSS
    /// (cluster mode disabled) replication groups, this is a single-element list.
    /// For Valkey or Redis OSS (cluster mode enabled) replication groups, the list
    /// contains an entry for each node group (shard).
    /// </summary>
    [JsonPropertyName("nodeGroups")]
    public IList<V1alpha1ReplicationGroupStatusNodeGroups>? NodeGroups { get; set; }

    /// <summary>
    /// A group of settings to be applied to the replication group, either immediately
    /// or during the next maintenance window.
    /// </summary>
    [JsonPropertyName("pendingModifiedValues")]
    public V1alpha1ReplicationGroupStatusPendingModifiedValues? PendingModifiedValues { get; set; }

    /// <summary>The date and time when the cluster was created.</summary>
    [JsonPropertyName("replicationGroupCreateTime")]
    public DateTime? ReplicationGroupCreateTime { get; set; }

    /// <summary>
    /// The cluster ID that is used as the daily snapshot source for the replication
    /// group.
    /// </summary>
    [JsonPropertyName("snapshottingClusterID")]
    public string? SnapshottingClusterID { get; set; }

    /// <summary>
    /// The current state of this replication group - creating, available, modifying,
    /// deleting, create-failed, snapshotting.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ReplicationGroup is the Schema for the ReplicationGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ReplicationGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ReplicationGroupSpec?>, IStatus<V1alpha1ReplicationGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ReplicationGroup";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "replicationgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ReplicationGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ReplicationGroupSpec defines the desired state of ReplicationGroup.
    /// 
    /// Contains all of the attributes of a specific Valkey or Redis OSS replication
    /// group.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ReplicationGroupSpec? Spec { get; set; }

    /// <summary>ReplicationGroupStatus defines the observed state of ReplicationGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1ReplicationGroupStatus? Status { get; set; }
}