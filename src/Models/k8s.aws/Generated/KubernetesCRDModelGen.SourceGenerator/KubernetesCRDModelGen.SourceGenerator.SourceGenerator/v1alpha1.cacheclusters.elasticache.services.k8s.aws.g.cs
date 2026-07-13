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
/// <summary>CacheCluster is the Schema for the CacheClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CacheClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CacheCluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CacheClusterList";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "cacheclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CacheClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CacheCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CacheCluster> Items { get; set; }
}

/// <summary>
/// Reserved parameter. The password used to access a password protected server.
/// 
/// Password constraints:
/// 
///   - Must be only printable ASCII characters.
/// 
///   - Must be at least 16 characters and no more than 128 characters in length.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterSpecAuthToken
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
public partial class V1alpha1CacheClusterSpecCacheParameterGroupRefFrom
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
public partial class V1alpha1CacheClusterSpecCacheParameterGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CacheClusterSpecCacheParameterGroupRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterSpecCacheSubnetGroupRefFrom
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
public partial class V1alpha1CacheClusterSpecCacheSubnetGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CacheClusterSpecCacheSubnetGroupRefFrom? From { get; set; }
}

/// <summary>The configuration details of the CloudWatch Logs destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterSpecLogDeliveryConfigurationsDestinationDetailsCloudWatchLogsDetails
{
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

/// <summary>The configuration details of the Kinesis Data Firehose destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterSpecLogDeliveryConfigurationsDestinationDetailsKinesisFirehoseDetails
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
public partial class V1alpha1CacheClusterSpecLogDeliveryConfigurationsDestinationDetails
{
    /// <summary>The configuration details of the CloudWatch Logs destination.</summary>
    [JsonPropertyName("cloudWatchLogsDetails")]
    public V1alpha1CacheClusterSpecLogDeliveryConfigurationsDestinationDetailsCloudWatchLogsDetails? CloudWatchLogsDetails { get; set; }

    /// <summary>The configuration details of the Kinesis Data Firehose destination.</summary>
    [JsonPropertyName("kinesisFirehoseDetails")]
    public V1alpha1CacheClusterSpecLogDeliveryConfigurationsDestinationDetailsKinesisFirehoseDetails? KinesisFirehoseDetails { get; set; }
}

/// <summary>Specifies the destination, format and type of the logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterSpecLogDeliveryConfigurations
{
    /// <summary>
    /// Configuration details of either a CloudWatch Logs destination or Kinesis
    /// Data Firehose destination.
    /// </summary>
    [JsonPropertyName("destinationDetails")]
    public V1alpha1CacheClusterSpecLogDeliveryConfigurationsDestinationDetails? DestinationDetails { get; set; }

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
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterSpecNotificationTopicRefFrom
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
public partial class V1alpha1CacheClusterSpecNotificationTopicRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CacheClusterSpecNotificationTopicRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterSpecReplicationGroupRefFrom
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
public partial class V1alpha1CacheClusterSpecReplicationGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CacheClusterSpecReplicationGroupRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterSpecSecurityGroupRefsFrom
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
public partial class V1alpha1CacheClusterSpecSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CacheClusterSpecSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterSpecSnapshotRefFrom
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
public partial class V1alpha1CacheClusterSpecSnapshotRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CacheClusterSpecSnapshotRefFrom? From { get; set; }
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
public partial class V1alpha1CacheClusterSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// CacheClusterSpec defines the desired state of CacheCluster.
/// 
/// Contains all of the attributes of a specific cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterSpec
{
    /// <summary>
    /// Reserved parameter. The password used to access a password protected server.
    /// 
    /// Password constraints:
    /// 
    ///   - Must be only printable ASCII characters.
    /// 
    ///   - Must be at least 16 characters and no more than 128 characters in length.
    /// </summary>
    [JsonPropertyName("authToken")]
    public V1alpha1CacheClusterSpecAuthToken? AuthToken { get; set; }

    /// <summary>
    /// If you are running Valkey 7.2 and above or Redis OSS engine version 6.0 and
    /// above, set this parameter to yes to opt-in to the next auto minor version
    /// upgrade campaign. This parameter is disabled for previous versions.
    /// </summary>
    [JsonPropertyName("autoMinorVersionUpgrade")]
    public bool? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// Specifies whether the nodes in this Memcached cluster are created in a single
    /// Availability Zone or created across multiple Availability Zones in the cluster&apos;s
    /// region.
    /// 
    /// This parameter is only supported for Memcached clusters.
    /// 
    /// If the AZMode and PreferredAvailabilityZones are not specified, ElastiCache
    /// assumes single-az mode.
    /// </summary>
    [JsonPropertyName("azMode")]
    public string? AzMode { get; set; }

    /// <summary>
    /// The node group (shard) identifier. This parameter is stored as a lowercase
    /// string.
    /// 
    /// Constraints:
    /// 
    ///   - A name must contain from 1 to 50 alphanumeric characters or hyphens.
    /// 
    ///   - The first character must be a letter.
    /// 
    ///   - A name cannot end with a hyphen or contain two consecutive hyphens.
    /// </summary>
    [JsonPropertyName("cacheClusterID")]
    public required string CacheClusterID { get; set; }

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
    /// The name of the parameter group to associate with this cluster. If this argument
    /// is omitted, the default parameter group for the specified engine is used.
    /// You cannot use any parameter group which has cluster-enabled=&apos;yes&apos; when creating
    /// a cluster.
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
    public V1alpha1CacheClusterSpecCacheParameterGroupRef? CacheParameterGroupRef { get; set; }

    /// <summary>
    /// A list of security group names to associate with this cluster.
    /// 
    /// Use this parameter only when you are creating a cluster outside of an Amazon
    /// Virtual Private Cloud (Amazon VPC).
    /// </summary>
    [JsonPropertyName("cacheSecurityGroupNames")]
    public IList<string>? CacheSecurityGroupNames { get; set; }

    /// <summary>
    /// The name of the subnet group to be used for the cluster.
    /// 
    /// Use this parameter only when you are creating a cluster in an Amazon Virtual
    /// Private Cloud (Amazon VPC).
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
    public V1alpha1CacheClusterSpecCacheSubnetGroupRef? CacheSubnetGroupRef { get; set; }

    /// <summary>
    /// The name of the cache engine to be used for this cluster.
    /// 
    /// Valid values for this parameter are: memcached | redis
    /// </summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>
    /// The version number of the cache engine to be used for this cluster. To view
    /// the supported cache engine versions, use the DescribeCacheEngineVersions
    /// operation.
    /// 
    /// Important: You can upgrade to a newer engine version (see Selecting a Cache
    /// Engine and Version (https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/SelectEngine.html#VersionManagement)),
    /// but you cannot downgrade to an earlier engine version. If you want to use
    /// an earlier engine version, you must delete the existing cluster or replication
    /// group and create it anew with the earlier engine version.
    /// </summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>
    /// The network type you choose when modifying a cluster, either ipv4 | ipv6.
    /// IPv6 is supported for workloads using Valkey 7.2 and above, Redis OSS engine
    /// version 6.2 to 7.1 and Memcached engine version 1.6.6 and above on all instances
    /// built on the Nitro system (http://aws.amazon.com/ec2/nitro/).
    /// </summary>
    [JsonPropertyName("ipDiscovery")]
    public string? IpDiscovery { get; set; }

    /// <summary>Specifies the destination, format and type of the logs.</summary>
    [JsonPropertyName("logDeliveryConfigurations")]
    public IList<V1alpha1CacheClusterSpecLogDeliveryConfigurations>? LogDeliveryConfigurations { get; set; }

    /// <summary>
    /// Must be either ipv4 | ipv6 | dual_stack. IPv6 is supported for workloads
    /// using Valkey 7.2 and above, Redis OSS engine version 6.2 to 7.1 and Memcached
    /// engine version 1.6.6 and above on all instances built on the Nitro system
    /// (http://aws.amazon.com/ec2/nitro/).
    /// </summary>
    [JsonPropertyName("networkType")]
    public string? NetworkType { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service
    /// (SNS) topic to which notifications are sent.
    /// 
    /// The Amazon SNS topic owner must be the same as the cluster owner.
    /// </summary>
    [JsonPropertyName("notificationTopicARN")]
    public string? NotificationTopicARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("notificationTopicRef")]
    public V1alpha1CacheClusterSpecNotificationTopicRef? NotificationTopicRef { get; set; }

    /// <summary>
    /// The initial number of cache nodes that the cluster has.
    /// 
    /// For clusters running Valkey or Redis OSS, this value must be 1. For clusters
    /// running Memcached, this value must be between 1 and 40.
    /// 
    /// If you need more than 40 nodes for your Memcached cluster, please fill out
    /// the ElastiCache Limit Increase Request form at http://aws.amazon.com/contact-us/elasticache-node-limit-request/
    /// (http://aws.amazon.com/contact-us/elasticache-node-limit-request/).
    /// </summary>
    [JsonPropertyName("numCacheNodes")]
    public long? NumCacheNodes { get; set; }

    /// <summary>
    /// Specifies whether the nodes in the cluster are created in a single outpost
    /// or across multiple outposts.
    /// </summary>
    [JsonPropertyName("outpostMode")]
    public string? OutpostMode { get; set; }

    /// <summary>The port number on which each of the cache nodes accepts connections.</summary>
    [JsonPropertyName("port")]
    public long? Port { get; set; }

    /// <summary>
    /// The EC2 Availability Zone in which the cluster is created.
    /// 
    /// All nodes belonging to this cluster are placed in the preferred Availability
    /// Zone. If you want to create your nodes across multiple Availability Zones,
    /// use PreferredAvailabilityZones.
    /// 
    /// Default: System chosen Availability Zone.
    /// </summary>
    [JsonPropertyName("preferredAvailabilityZone")]
    public string? PreferredAvailabilityZone { get; set; }

    /// <summary>
    /// A list of the Availability Zones in which cache nodes are created. The order
    /// of the zones in the list is not important.
    /// 
    /// This option is only supported on Memcached.
    /// 
    /// If you are creating your cluster in an Amazon VPC (recommended) you can only
    /// locate nodes in Availability Zones that are associated with the subnets in
    /// the selected subnet group.
    /// 
    /// The number of Availability Zones listed must equal the value of NumCacheNodes.
    /// 
    /// If you want all the nodes in the same Availability Zone, use PreferredAvailabilityZone
    /// instead, or repeat the Availability Zone multiple times in the list.
    /// 
    /// Default: System chosen Availability Zones.
    /// </summary>
    [JsonPropertyName("preferredAvailabilityZones")]
    public IList<string>? PreferredAvailabilityZones { get; set; }

    /// <summary>
    /// Specifies the weekly time range during which maintenance on the cluster is
    /// performed. It is specified as a range in the format ddd:hh24:mi-ddd:hh24:mi
    /// (24H Clock UTC). The minimum maintenance window is a 60 minute period.
    /// </summary>
    [JsonPropertyName("preferredMaintenanceWindow")]
    public string? PreferredMaintenanceWindow { get; set; }

    /// <summary>The outpost ARN in which the cache cluster is created.</summary>
    [JsonPropertyName("preferredOutpostARN")]
    public string? PreferredOutpostARN { get; set; }

    /// <summary>The outpost ARNs in which the cache cluster is created.</summary>
    [JsonPropertyName("preferredOutpostARNs")]
    public IList<string>? PreferredOutpostARNs { get; set; }

    /// <summary>
    /// The ID of the replication group to which this cluster should belong. If this
    /// parameter is specified, the cluster is added to the specified replication
    /// group as a read replica; otherwise, the cluster is a standalone primary that
    /// is not part of any replication group.
    /// 
    /// If the specified replication group is Multi-AZ enabled and the Availability
    /// Zone is not specified, the cluster is created in Availability Zones that
    /// provide the best spread of read replicas across Availability Zones.
    /// 
    /// This parameter is only valid if the Engine parameter is redis.
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
    public V1alpha1CacheClusterSpecReplicationGroupRef? ReplicationGroupRef { get; set; }

    /// <summary>
    /// One or more VPC security groups associated with the cluster.
    /// 
    /// Use this parameter only when you are creating a cluster in an Amazon Virtual
    /// Private Cloud (Amazon VPC).
    /// </summary>
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1CacheClusterSpecSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>
    /// A single-element string list containing an Amazon Resource Name (ARN) that
    /// uniquely identifies a Valkey or Redis OSS RDB snapshot file stored in Amazon
    /// S3. The snapshot file is used to populate the node group (shard). The Amazon
    /// S3 object name in the ARN cannot contain any commas.
    /// 
    /// This parameter is only valid if the Engine parameter is redis.
    /// 
    /// Example of an Amazon S3 ARN: arn:aws:s3:::my_bucket/snapshot1.rdb
    /// </summary>
    [JsonPropertyName("snapshotARNs")]
    public IList<string>? SnapshotARNs { get; set; }

    /// <summary>
    /// The name of a Valkey or Redis OSS snapshot from which to restore data into
    /// the new node group (shard). The snapshot status changes to restoring while
    /// the new node group (shard) is being created.
    /// 
    /// This parameter is only valid if the Engine parameter is redis.
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
    public V1alpha1CacheClusterSpecSnapshotRef? SnapshotRef { get; set; }

    /// <summary>
    /// The number of days for which ElastiCache retains automatic snapshots before
    /// deleting them. For example, if you set SnapshotRetentionLimit to 5, a snapshot
    /// taken today is retained for 5 days before being deleted.
    /// 
    /// This parameter is only valid if the Engine parameter is redis.
    /// 
    /// Default: 0 (i.e., automatic backups are disabled for this cache cluster).
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
    /// 
    /// This parameter is only valid if the Engine parameter is redis.
    /// </summary>
    [JsonPropertyName("snapshotWindow")]
    public string? SnapshotWindow { get; set; }

    /// <summary>A list of tags to be added to this resource.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1CacheClusterSpecTags>? Tags { get; set; }

    /// <summary>A flag that enables in-transit encryption when set to true.</summary>
    [JsonPropertyName("transitEncryptionEnabled")]
    public bool? TransitEncryptionEnabled { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterStatusAckResourceMetadata
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
/// Represents the information required for client programs to connect to a cache
/// node. This value is read-only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterStatusCacheNodesEndpoint
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// Represents an individual cache node within a cluster. Each cache node runs
/// its own instance of the cluster&apos;s protocol-compliant caching software - either
/// Memcached, Valkey or Redis OSS.
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterStatusCacheNodes
{
    [JsonPropertyName("cacheNodeCreateTime")]
    public DateTime? CacheNodeCreateTime { get; set; }

    [JsonPropertyName("cacheNodeID")]
    public string? CacheNodeID { get; set; }

    [JsonPropertyName("cacheNodeStatus")]
    public string? CacheNodeStatus { get; set; }

    [JsonPropertyName("customerAvailabilityZone")]
    public string? CustomerAvailabilityZone { get; set; }

    [JsonPropertyName("customerOutpostARN")]
    public string? CustomerOutpostARN { get; set; }

    /// <summary>
    /// Represents the information required for client programs to connect to a cache
    /// node. This value is read-only.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public V1alpha1CacheClusterStatusCacheNodesEndpoint? Endpoint { get; set; }

    [JsonPropertyName("parameterGroupStatus")]
    public string? ParameterGroupStatus { get; set; }

    [JsonPropertyName("sourceCacheNodeID")]
    public string? SourceCacheNodeID { get; set; }
}

/// <summary>Status of the cache parameter group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterStatusCacheParameterGroup
{
    [JsonPropertyName("cacheNodeIDsToReboot")]
    public IList<string>? CacheNodeIDsToReboot { get; set; }

    [JsonPropertyName("cacheParameterGroupName")]
    public string? CacheParameterGroupName { get; set; }

    [JsonPropertyName("parameterApplyStatus")]
    public string? ParameterApplyStatus { get; set; }
}

/// <summary>Represents a cluster&apos;s status within a particular cache security group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterStatusCacheSecurityGroups
{
    [JsonPropertyName("cacheSecurityGroupName")]
    public string? CacheSecurityGroupName { get; set; }

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
public partial class V1alpha1CacheClusterStatusConditions
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
/// Represents a Memcached cluster endpoint which can be used by an application
/// to connect to any node in the cluster. The configuration endpoint will always
/// have .cfg in it.
/// 
/// Example: mem-3.9dvc4r.cfg.usw2.cache.amazonaws.com:11211
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterStatusConfigurationEndpoint
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// Describes a notification topic and its status. Notification topics are used
/// for publishing ElastiCache events to subscribers using Amazon Simple Notification
/// Service (SNS).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterStatusNotificationConfiguration
{
    [JsonPropertyName("topicARN")]
    public string? TopicARN { get; set; }

    [JsonPropertyName("topicStatus")]
    public string? TopicStatus { get; set; }
}

/// <summary>
/// A group of settings that are applied to the cluster in the future, or that
/// are currently being applied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterStatusPendingModifiedValues
{
    [JsonPropertyName("authTokenStatus")]
    public string? AuthTokenStatus { get; set; }

    [JsonPropertyName("cacheNodeIDsToRemove")]
    public IList<string>? CacheNodeIDsToRemove { get; set; }

    [JsonPropertyName("cacheNodeType")]
    public string? CacheNodeType { get; set; }

    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    [JsonPropertyName("numCacheNodes")]
    public long? NumCacheNodes { get; set; }

    [JsonPropertyName("transitEncryptionEnabled")]
    public bool? TransitEncryptionEnabled { get; set; }

    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }
}

/// <summary>Represents a single cache security group and its status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterStatusSecurityGroups
{
    [JsonPropertyName("securityGroupID")]
    public string? SecurityGroupID { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>CacheClusterStatus defines the observed state of CacheCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheClusterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1CacheClusterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// A flag that enables encryption at-rest when set to true.
    /// 
    /// You cannot modify the value of AtRestEncryptionEnabled after the cluster
    /// is created. To enable at-rest encryption on a cluster you must set AtRestEncryptionEnabled
    /// to true when you create a cluster.
    /// 
    /// Required: Only available when creating a replication group in an Amazon VPC
    /// using Redis OSS version 3.2.6, 4.x or later.
    /// 
    /// Default: false
    /// </summary>
    [JsonPropertyName("atRestEncryptionEnabled")]
    public bool? AtRestEncryptionEnabled { get; set; }

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

    /// <summary>The date and time when the cluster was created.</summary>
    [JsonPropertyName("cacheClusterCreateTime")]
    public DateTime? CacheClusterCreateTime { get; set; }

    /// <summary>
    /// The current state of this cluster, one of the following values: available,
    /// creating, deleted, deleting, incompatible-network, modifying, rebooting cluster
    /// nodes, restore-failed, or snapshotting.
    /// </summary>
    [JsonPropertyName("cacheClusterStatus")]
    public string? CacheClusterStatus { get; set; }

    /// <summary>A list of cache nodes that are members of the cluster.</summary>
    [JsonPropertyName("cacheNodes")]
    public IList<V1alpha1CacheClusterStatusCacheNodes>? CacheNodes { get; set; }

    /// <summary>Status of the cache parameter group.</summary>
    [JsonPropertyName("cacheParameterGroup")]
    public V1alpha1CacheClusterStatusCacheParameterGroup? CacheParameterGroup { get; set; }

    /// <summary>A list of cache security group elements, composed of name and status sub-elements.</summary>
    [JsonPropertyName("cacheSecurityGroups")]
    public IList<V1alpha1CacheClusterStatusCacheSecurityGroups>? CacheSecurityGroups { get; set; }

    /// <summary>
    /// The URL of the web page where you can download the latest ElastiCache client
    /// library.
    /// </summary>
    [JsonPropertyName("clientDownloadLandingPage")]
    public string? ClientDownloadLandingPage { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CacheClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Represents a Memcached cluster endpoint which can be used by an application
    /// to connect to any node in the cluster. The configuration endpoint will always
    /// have .cfg in it.
    /// 
    /// Example: mem-3.9dvc4r.cfg.usw2.cache.amazonaws.com:11211
    /// </summary>
    [JsonPropertyName("configurationEndpoint")]
    public V1alpha1CacheClusterStatusConfigurationEndpoint? ConfigurationEndpoint { get; set; }

    /// <summary>
    /// Describes a notification topic and its status. Notification topics are used
    /// for publishing ElastiCache events to subscribers using Amazon Simple Notification
    /// Service (SNS).
    /// </summary>
    [JsonPropertyName("notificationConfiguration")]
    public V1alpha1CacheClusterStatusNotificationConfiguration? NotificationConfiguration { get; set; }

    /// <summary>
    /// A group of settings that are applied to the cluster in the future, or that
    /// are currently being applied.
    /// </summary>
    [JsonPropertyName("pendingModifiedValues")]
    public V1alpha1CacheClusterStatusPendingModifiedValues? PendingModifiedValues { get; set; }

    /// <summary>
    /// A boolean value indicating whether log delivery is enabled for the replication
    /// group.
    /// </summary>
    [JsonPropertyName("replicationGroupLogDeliveryEnabled")]
    public bool? ReplicationGroupLogDeliveryEnabled { get; set; }

    /// <summary>A list of VPC Security Groups associated with the cluster.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<V1alpha1CacheClusterStatusSecurityGroups>? SecurityGroups { get; set; }

    /// <summary>
    /// A setting that allows you to migrate your clients to use in-transit encryption,
    /// with no downtime.
    /// </summary>
    [JsonPropertyName("transitEncryptionMode")]
    public string? TransitEncryptionMode { get; set; }
}

/// <summary>CacheCluster is the Schema for the CacheClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CacheCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CacheClusterSpec?>, IStatus<V1alpha1CacheClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CacheCluster";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "cacheclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CacheCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// CacheClusterSpec defines the desired state of CacheCluster.
    /// 
    /// Contains all of the attributes of a specific cluster.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1CacheClusterSpec? Spec { get; set; }

    /// <summary>CacheClusterStatus defines the observed state of CacheCluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1CacheClusterStatus? Status { get; set; }
}