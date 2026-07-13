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
/// <summary>ServerlessCache is the Schema for the ServerlessCaches API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServerlessCacheList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ServerlessCache>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServerlessCacheList";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "serverlesscaches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerlessCacheList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ServerlessCache objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ServerlessCache> Items { get; set; }
}

/// <summary>The data storage limit.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSpecCacheUsageLimitsDataStorage
{
    [JsonPropertyName("maximum")]
    public long? Maximum { get; set; }

    [JsonPropertyName("minimum")]
    public long? Minimum { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// The configuration for the number of ElastiCache Processing Units (ECPU) the
/// cache can consume per second.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSpecCacheUsageLimitsECPUPerSecond
{
    [JsonPropertyName("maximum")]
    public long? Maximum { get; set; }

    [JsonPropertyName("minimum")]
    public long? Minimum { get; set; }
}

/// <summary>
/// Sets the cache usage limits for storage and ElastiCache Processing Units
/// for the cache.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSpecCacheUsageLimits
{
    /// <summary>The data storage limit.</summary>
    [JsonPropertyName("dataStorage")]
    public V1alpha1ServerlessCacheSpecCacheUsageLimitsDataStorage? DataStorage { get; set; }

    /// <summary>
    /// The configuration for the number of ElastiCache Processing Units (ECPU) the
    /// cache can consume per second.
    /// </summary>
    [JsonPropertyName("eCPUPerSecond")]
    public V1alpha1ServerlessCacheSpecCacheUsageLimitsECPUPerSecond? ECPUPerSecond { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSpecSecurityGroupRefsFrom
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
public partial class V1alpha1ServerlessCacheSpecSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServerlessCacheSpecSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSpecSubnetRefsFrom
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
public partial class V1alpha1ServerlessCacheSpecSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ServerlessCacheSpecSubnetRefsFrom? From { get; set; }
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
public partial class V1alpha1ServerlessCacheSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ServerlessCacheSpec defines the desired state of ServerlessCache.
/// 
/// The resource representing a serverless cache.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheSpec
{
    /// <summary>
    /// Sets the cache usage limits for storage and ElastiCache Processing Units
    /// for the cache.
    /// </summary>
    [JsonPropertyName("cacheUsageLimits")]
    public V1alpha1ServerlessCacheSpecCacheUsageLimits? CacheUsageLimits { get; set; }

    /// <summary>
    /// The daily time that snapshots will be created from the new serverless cache.
    /// By default this number is populated with 0, i.e. no snapshots will be created
    /// on an automatic daily basis. Available for Valkey, Redis OSS and Serverless
    /// Memcached only.
    /// </summary>
    [JsonPropertyName("dailySnapshotTime")]
    public string? DailySnapshotTime { get; set; }

    /// <summary>
    /// User-provided description for the serverless cache. The default is NULL,
    /// i.e. if no description is provided then an empty string will be returned.
    /// The maximum length is 255 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the cache engine to be used for creating the serverless cache.</summary>
    [JsonPropertyName("engine")]
    public required string Engine { get; set; }

    /// <summary>
    /// ARN of the customer managed key for encrypting the data at rest. If no KMS
    /// key is provided, a default service key is used.
    /// </summary>
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>
    /// The version of the cache engine that will be used to create the serverless
    /// cache.
    /// </summary>
    [JsonPropertyName("majorEngineVersion")]
    public string? MajorEngineVersion { get; set; }

    /// <summary>
    /// A list of the one or more VPC security groups to be associated with the serverless
    /// cache. The security group will authorize traffic access for the VPC end-point
    /// (private-link). If no other information is given this will be the VPC’s
    /// Default Security Group that is associated with the cluster VPC end-point.
    /// </summary>
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1ServerlessCacheSpecSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>
    /// User-provided identifier for the serverless cache. This parameter is stored
    /// as a lowercase string.
    /// </summary>
    [JsonPropertyName("serverlessCacheName")]
    public required string ServerlessCacheName { get; set; }

    /// <summary>
    /// The ARN(s) of the snapshot that the new serverless cache will be created
    /// from. Available for Valkey, Redis OSS and Serverless Memcached only.
    /// </summary>
    [JsonPropertyName("snapshotARNsToRestore")]
    public IList<string>? SnapshotARNsToRestore { get; set; }

    /// <summary>
    /// The number of snapshots that will be retained for the serverless cache that
    /// is being created. As new snapshots beyond this limit are added, the oldest
    /// snapshots will be deleted on a rolling basis. Available for Valkey, Redis
    /// OSS and Serverless Memcached only.
    /// </summary>
    [JsonPropertyName("snapshotRetentionLimit")]
    public long? SnapshotRetentionLimit { get; set; }

    /// <summary>
    /// A list of the identifiers of the subnets where the VPC endpoint for the serverless
    /// cache will be deployed. All the subnetIds must belong to the same VPC.
    /// </summary>
    [JsonPropertyName("subnetIDs")]
    public IList<string>? SubnetIDs { get; set; }

    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1ServerlessCacheSpecSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>
    /// The list of tags (key, value) pairs to be added to the serverless cache resource.
    /// Default is NULL.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ServerlessCacheSpecTags>? Tags { get; set; }

    /// <summary>
    /// The identifier of the UserGroup to be associated with the serverless cache.
    /// Available for Valkey and Redis OSS only. Default is NULL.
    /// </summary>
    [JsonPropertyName("userGroupID")]
    public string? UserGroupID { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheStatusAckResourceMetadata
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
public partial class V1alpha1ServerlessCacheStatusConditions
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
/// Represents the information required for client programs to connect to a cache
/// node. This value is read-only.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheStatusEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheStatusReaderEndpoint
{
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>ServerlessCacheStatus defines the observed state of ServerlessCache</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ServerlessCacheStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ServerlessCacheStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ServerlessCacheStatusConditions>? Conditions { get; set; }

    /// <summary>When the serverless cache was created.</summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// Represents the information required for client programs to connect to a cache
    /// node. This value is read-only.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public V1alpha1ServerlessCacheStatusEndpoint? Endpoint { get; set; }

    /// <summary>
    /// The name and version number of the engine the serverless cache is compatible
    /// with.
    /// </summary>
    [JsonPropertyName("fullEngineVersion")]
    public string? FullEngineVersion { get; set; }

    /// <summary>
    /// Represents the information required for client programs to connect to a cache
    /// node. This value is read-only.
    /// </summary>
    [JsonPropertyName("readerEndpoint")]
    public V1alpha1ServerlessCacheStatusReaderEndpoint? ReaderEndpoint { get; set; }

    /// <summary>
    /// The current status of the serverless cache. The allowed values are CREATING,
    /// AVAILABLE, DELETING, CREATE-FAILED and MODIFYING.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ServerlessCache is the Schema for the ServerlessCaches API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ServerlessCache : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ServerlessCacheSpec?>, IStatus<V1alpha1ServerlessCacheStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ServerlessCache";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "serverlesscaches";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServerlessCache";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ServerlessCacheSpec defines the desired state of ServerlessCache.
    /// 
    /// The resource representing a serverless cache.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ServerlessCacheSpec? Spec { get; set; }

    /// <summary>ServerlessCacheStatus defines the observed state of ServerlessCache</summary>
    [JsonPropertyName("status")]
    public V1alpha1ServerlessCacheStatus? Status { get; set; }
}