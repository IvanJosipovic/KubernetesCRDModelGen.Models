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
/// <summary>ACL is the Schema for the ACLS API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ACLList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ACL>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ACLList";
    public const string KubeGroup = "memorydb.services.k8s.aws";
    public const string KubePluralName = "acls";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorydb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ACLList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ACL objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ACL> Items { get; set; }
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
public partial class V1alpha1ACLSpecTags
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ACLSpecUserRefsFrom
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
public partial class V1alpha1ACLSpecUserRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ACLSpecUserRefsFrom? From { get; set; }
}

/// <summary>
/// ACLSpec defines the desired state of ACL.
/// 
/// An Access Control List. You can authenticate users with Access Contol Lists.
/// ACLs enable you to control cluster access by grouping users. These Access
/// control lists are designed as a way to organize access to clusters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ACLSpec
{
    /// <summary>The name of the Access Control List.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A list of tags to be added to this resource. A tag is a key-value pair. A
    /// tag key must be accompanied by a tag value, although null is accepted.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ACLSpecTags>? Tags { get; set; }

    /// <summary>The list of users that belong to the Access Control List.</summary>
    [JsonPropertyName("userNames")]
    public IList<string>? UserNames { get; set; }

    [JsonPropertyName("userRefs")]
    public IList<V1alpha1ACLSpecUserRefs>? UserRefs { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ACLStatusAckResourceMetadata
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
public partial class V1alpha1ACLStatusConditions
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
public partial class V1alpha1ACLStatusEvents
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

/// <summary>A list of updates being applied to the ACL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ACLStatusPendingChanges
{
    [JsonPropertyName("userNamesToAdd")]
    public IList<string>? UserNamesToAdd { get; set; }

    [JsonPropertyName("userNamesToRemove")]
    public IList<string>? UserNamesToRemove { get; set; }
}

/// <summary>ACLStatus defines the observed state of ACL</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ACLStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ACLStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>A list of clusters associated with the ACL.</summary>
    [JsonPropertyName("clusters")]
    public IList<string>? Clusters { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ACLStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// A list of events. Each element in the list contains detailed information
    /// about one event.
    /// </summary>
    [JsonPropertyName("events")]
    public IList<V1alpha1ACLStatusEvents>? Events { get; set; }

    /// <summary>The minimum engine version supported for the ACL</summary>
    [JsonPropertyName("minimumEngineVersion")]
    public string? MinimumEngineVersion { get; set; }

    /// <summary>A list of updates being applied to the ACL.</summary>
    [JsonPropertyName("pendingChanges")]
    public V1alpha1ACLStatusPendingChanges? PendingChanges { get; set; }

    /// <summary>Indicates ACL status. Can be &quot;creating&quot;, &quot;active&quot;, &quot;modifying&quot;, &quot;deleting&quot;.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ACL is the Schema for the ACLS API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ACL : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ACLSpec?>, IStatus<V1alpha1ACLStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ACL";
    public const string KubeGroup = "memorydb.services.k8s.aws";
    public const string KubePluralName = "acls";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorydb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ACL";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ACLSpec defines the desired state of ACL.
    /// 
    /// An Access Control List. You can authenticate users with Access Contol Lists.
    /// ACLs enable you to control cluster access by grouping users. These Access
    /// control lists are designed as a way to organize access to clusters.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ACLSpec? Spec { get; set; }

    /// <summary>ACLStatus defines the observed state of ACL</summary>
    [JsonPropertyName("status")]
    public V1alpha1ACLStatus? Status { get; set; }
}