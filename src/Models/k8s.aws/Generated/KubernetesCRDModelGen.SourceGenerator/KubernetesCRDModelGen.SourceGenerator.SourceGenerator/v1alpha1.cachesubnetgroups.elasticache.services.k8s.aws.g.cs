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
/// <summary>CacheSubnetGroup is the Schema for the CacheSubnetGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CacheSubnetGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CacheSubnetGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CacheSubnetGroupList";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "cachesubnetgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CacheSubnetGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CacheSubnetGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CacheSubnetGroup> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheSubnetGroupSpecSubnetRefsFrom
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
public partial class V1alpha1CacheSubnetGroupSpecSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CacheSubnetGroupSpecSubnetRefsFrom? From { get; set; }
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
public partial class V1alpha1CacheSubnetGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// CacheSubnetGroupSpec defines the desired state of CacheSubnetGroup.
/// 
/// Represents the output of one of the following operations:
/// 
///   - CreateCacheSubnetGroup
/// 
///   - ModifyCacheSubnetGroup
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheSubnetGroupSpec
{
    /// <summary>A description for the cache subnet group.</summary>
    [JsonPropertyName("cacheSubnetGroupDescription")]
    public required string CacheSubnetGroupDescription { get; set; }

    /// <summary>
    /// A name for the cache subnet group. This value is stored as a lowercase string.
    /// 
    /// Constraints: Must contain no more than 255 alphanumeric characters or hyphens.
    /// 
    /// Example: mysubnetgroup
    /// </summary>
    [JsonPropertyName("cacheSubnetGroupName")]
    public required string CacheSubnetGroupName { get; set; }

    /// <summary>A list of VPC subnet IDs for the cache subnet group.</summary>
    [JsonPropertyName("subnetIDs")]
    public IList<string>? SubnetIDs { get; set; }

    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1CacheSubnetGroupSpecSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>
    /// A list of tags to be added to this resource. A tag is a key-value pair. A
    /// tag key must be accompanied by a tag value, although null is accepted.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1CacheSubnetGroupSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheSubnetGroupStatusAckResourceMetadata
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
public partial class V1alpha1CacheSubnetGroupStatusConditions
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
/// Some examples of events are creating a cluster, adding or removing a cache
/// node, or rebooting a node.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheSubnetGroupStatusEvents
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

/// <summary>Describes an Availability Zone in which the cluster is launched.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheSubnetGroupStatusSubnetsSubnetAvailabilityZone
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The ID of the outpost subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheSubnetGroupStatusSubnetsSubnetOutpost
{
    [JsonPropertyName("subnetOutpostARN")]
    public string? SubnetOutpostARN { get; set; }
}

/// <summary>
/// Represents the subnet associated with a cluster. This parameter refers to
/// subnets defined in Amazon Virtual Private Cloud (Amazon VPC) and used with
/// ElastiCache.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheSubnetGroupStatusSubnets
{
    /// <summary>Describes an Availability Zone in which the cluster is launched.</summary>
    [JsonPropertyName("subnetAvailabilityZone")]
    public V1alpha1CacheSubnetGroupStatusSubnetsSubnetAvailabilityZone? SubnetAvailabilityZone { get; set; }

    [JsonPropertyName("subnetIdentifier")]
    public string? SubnetIdentifier { get; set; }

    /// <summary>The ID of the outpost subnet.</summary>
    [JsonPropertyName("subnetOutpost")]
    public V1alpha1CacheSubnetGroupStatusSubnetsSubnetOutpost? SubnetOutpost { get; set; }
}

/// <summary>CacheSubnetGroupStatus defines the observed state of CacheSubnetGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheSubnetGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1CacheSubnetGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CacheSubnetGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// A list of events. Each element in the list contains detailed information
    /// about one event.
    /// </summary>
    [JsonPropertyName("events")]
    public IList<V1alpha1CacheSubnetGroupStatusEvents>? Events { get; set; }

    /// <summary>A list of subnets associated with the cache subnet group.</summary>
    [JsonPropertyName("subnets")]
    public IList<V1alpha1CacheSubnetGroupStatusSubnets>? Subnets { get; set; }

    /// <summary>
    /// The Amazon Virtual Private Cloud identifier (VPC ID) of the cache subnet
    /// group.
    /// </summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>CacheSubnetGroup is the Schema for the CacheSubnetGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CacheSubnetGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CacheSubnetGroupSpec?>, IStatus<V1alpha1CacheSubnetGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CacheSubnetGroup";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "cachesubnetgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CacheSubnetGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// CacheSubnetGroupSpec defines the desired state of CacheSubnetGroup.
    /// 
    /// Represents the output of one of the following operations:
    /// 
    ///   - CreateCacheSubnetGroup
    /// 
    ///   - ModifyCacheSubnetGroup
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1CacheSubnetGroupSpec? Spec { get; set; }

    /// <summary>CacheSubnetGroupStatus defines the observed state of CacheSubnetGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1CacheSubnetGroupStatus? Status { get; set; }
}