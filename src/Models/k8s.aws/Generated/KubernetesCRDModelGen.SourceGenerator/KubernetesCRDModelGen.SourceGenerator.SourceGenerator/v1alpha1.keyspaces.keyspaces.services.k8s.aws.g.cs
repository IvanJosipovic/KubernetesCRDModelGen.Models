#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keyspaces.services.k8s.aws;
/// <summary>Keyspace is the Schema for the Keyspaces API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1KeyspaceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Keyspace>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "KeyspaceList";
    public const string KubeGroup = "keyspaces.services.k8s.aws";
    public const string KubePluralName = "keyspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keyspaces.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KeyspaceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Keyspace objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Keyspace> Items { get; set; }
}

/// <summary>
/// The replication specification of the keyspace includes:
/// 
///   - replicationStrategy - the required value is SINGLE_REGION or MULTI_REGION.
/// 
///   - regionList - if the replicationStrategy is MULTI_REGION, the regionList
///     requires the current Region and at least one additional Amazon Web Services
///     Region where the keyspace is going to be replicated in. The maximum number
///     of supported replication Regions including the current Region is six.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeyspaceSpecReplicationSpecification
{
    [JsonPropertyName("regionList")]
    public IList<string>? RegionList { get; set; }

    [JsonPropertyName("replicationStrategy")]
    public string? ReplicationStrategy { get; set; }
}

/// <summary>
/// Describes a tag. A tag is a key-value pair. You can add up to 50 tags to
/// a single Amazon Keyspaces resource.
/// 
/// Amazon Web Services-assigned tag names and values are automatically assigned
/// the aws: prefix, which the user cannot assign. Amazon Web Services-assigned
/// tag names do not count towards the tag limit of 50. User-assigned tag names
/// have the prefix user: in the Cost Allocation Report. You cannot backdate
/// the application of a tag.
/// 
/// For more information, see Adding tags and labels to Amazon Keyspaces resources
/// (https://docs.aws.amazon.com/keyspaces/latest/devguide/tagging-keyspaces.html)
/// in the Amazon Keyspaces Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeyspaceSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>KeyspaceSpec defines the desired state of Keyspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeyspaceSpec
{
    /// <summary>
    /// The name of the keyspace to be created.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9][a-zA-Z0-9_]{0,47}$`
    /// </summary>
    [JsonPropertyName("keyspaceName")]
    public required string KeyspaceName { get; set; }

    /// <summary>
    /// The replication specification of the keyspace includes:
    /// 
    ///   - replicationStrategy - the required value is SINGLE_REGION or MULTI_REGION.
    /// 
    ///   - regionList - if the replicationStrategy is MULTI_REGION, the regionList
    ///     requires the current Region and at least one additional Amazon Web Services
    ///     Region where the keyspace is going to be replicated in. The maximum number
    ///     of supported replication Regions including the current Region is six.
    /// </summary>
    [JsonPropertyName("replicationSpecification")]
    public V1alpha1KeyspaceSpecReplicationSpecification? ReplicationSpecification { get; set; }

    /// <summary>
    /// A list of key-value pair tags to be attached to the keyspace.
    /// 
    /// For more information, see Adding tags and labels to Amazon Keyspaces resources
    /// (https://docs.aws.amazon.com/keyspaces/latest/devguide/tagging-keyspaces.html)
    /// in the Amazon Keyspaces Developer Guide.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1KeyspaceSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeyspaceStatusAckResourceMetadata
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
public partial class V1alpha1KeyspaceStatusConditions
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

/// <summary>KeyspaceStatus defines the observed state of Keyspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1KeyspaceStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1KeyspaceStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1KeyspaceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The unique identifier of the keyspace in the format of an Amazon Resource
    /// Name (ARN).
    /// 
    /// Regex Pattern: `^arn:(aws[a-zA-Z0-9-]*):cassandra:.+`
    /// </summary>
    [JsonPropertyName("resourceARN")]
    public string? ResourceARN { get; set; }
}

/// <summary>Keyspace is the Schema for the Keyspaces API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Keyspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1KeyspaceSpec?>, IStatus<V1alpha1KeyspaceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Keyspace";
    public const string KubeGroup = "keyspaces.services.k8s.aws";
    public const string KubePluralName = "keyspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "keyspaces.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Keyspace";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KeyspaceSpec defines the desired state of Keyspace.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1KeyspaceSpec? Spec { get; set; }

    /// <summary>KeyspaceStatus defines the observed state of Keyspace</summary>
    [JsonPropertyName("status")]
    public V1alpha1KeyspaceStatus? Status { get; set; }
}