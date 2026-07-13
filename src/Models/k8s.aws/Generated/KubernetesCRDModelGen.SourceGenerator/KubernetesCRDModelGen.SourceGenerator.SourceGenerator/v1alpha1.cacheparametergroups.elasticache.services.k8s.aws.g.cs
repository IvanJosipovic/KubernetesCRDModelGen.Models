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
/// <summary>CacheParameterGroup is the Schema for the CacheParameterGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CacheParameterGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CacheParameterGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CacheParameterGroupList";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "cacheparametergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CacheParameterGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CacheParameterGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CacheParameterGroup> Items { get; set; }
}

/// <summary>Describes a name-value pair that is used to update the value of a parameter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheParameterGroupSpecParameterNameValues
{
    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }
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
public partial class V1alpha1CacheParameterGroupSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// CacheParameterGroupSpec defines the desired state of CacheParameterGroup.
/// 
/// Represents the output of a CreateCacheParameterGroup operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheParameterGroupSpec
{
    /// <summary>
    /// The name of the cache parameter group family that the cache parameter group
    /// can be used with.
    /// 
    /// Valid values are: valkey8 | valkey7 | memcached1.4 | memcached1.5 | memcached1.6
    /// | redis2.6 | redis2.8 |redis3.2 | redis4.0 | redis5.0 | redis6.x | redis7
    /// </summary>
    [JsonPropertyName("cacheParameterGroupFamily")]
    public required string CacheParameterGroupFamily { get; set; }

    /// <summary>A user-specified name for the cache parameter group.</summary>
    [JsonPropertyName("cacheParameterGroupName")]
    public required string CacheParameterGroupName { get; set; }

    /// <summary>A user-specified description for the cache parameter group.</summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// An array of parameter names and values for the parameter update. You must
    /// supply at least one parameter name and value; subsequent arguments are optional.
    /// A maximum of 20 parameters may be modified per request.
    /// </summary>
    [JsonPropertyName("parameterNameValues")]
    public IList<V1alpha1CacheParameterGroupSpecParameterNameValues>? ParameterNameValues { get; set; }

    /// <summary>
    /// A list of tags to be added to this resource. A tag is a key-value pair. A
    /// tag key must be accompanied by a tag value, although null is accepted.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1CacheParameterGroupSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheParameterGroupStatusAckResourceMetadata
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
public partial class V1alpha1CacheParameterGroupStatusConditions
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
public partial class V1alpha1CacheParameterGroupStatusEvents
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
/// Describes an individual setting that controls some aspect of ElastiCache
/// behavior.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheParameterGroupStatusParameters
{
    [JsonPropertyName("allowedValues")]
    public string? AllowedValues { get; set; }

    [JsonPropertyName("changeType")]
    public string? ChangeType { get; set; }

    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("isModifiable")]
    public bool? IsModifiable { get; set; }

    [JsonPropertyName("minimumEngineVersion")]
    public string? MinimumEngineVersion { get; set; }

    [JsonPropertyName("parameterName")]
    public string? ParameterName { get; set; }

    [JsonPropertyName("parameterValue")]
    public string? ParameterValue { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>CacheParameterGroupStatus defines the observed state of CacheParameterGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CacheParameterGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1CacheParameterGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CacheParameterGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// A list of events. Each element in the list contains detailed information
    /// about one event.
    /// </summary>
    [JsonPropertyName("events")]
    public IList<V1alpha1CacheParameterGroupStatusEvents>? Events { get; set; }

    /// <summary>Indicates whether the parameter group is associated with a Global datastore</summary>
    [JsonPropertyName("isGlobal")]
    public bool? IsGlobal { get; set; }

    /// <summary>A list of Parameter instances.</summary>
    [JsonPropertyName("parameters")]
    public IList<V1alpha1CacheParameterGroupStatusParameters>? Parameters { get; set; }
}

/// <summary>CacheParameterGroup is the Schema for the CacheParameterGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CacheParameterGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CacheParameterGroupSpec?>, IStatus<V1alpha1CacheParameterGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CacheParameterGroup";
    public const string KubeGroup = "elasticache.services.k8s.aws";
    public const string KubePluralName = "cacheparametergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elasticache.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CacheParameterGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// CacheParameterGroupSpec defines the desired state of CacheParameterGroup.
    /// 
    /// Represents the output of a CreateCacheParameterGroup operation.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1CacheParameterGroupSpec? Spec { get; set; }

    /// <summary>CacheParameterGroupStatus defines the observed state of CacheParameterGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1CacheParameterGroupStatus? Status { get; set; }
}