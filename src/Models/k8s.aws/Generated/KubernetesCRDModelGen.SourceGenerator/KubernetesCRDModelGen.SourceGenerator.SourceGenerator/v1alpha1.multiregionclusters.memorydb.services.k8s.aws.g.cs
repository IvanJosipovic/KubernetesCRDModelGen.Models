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
/// <summary>MultiRegionCluster is the Schema for the MultiRegionClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MultiRegionClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MultiRegionCluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MultiRegionClusterList";
    public const string KubeGroup = "memorydb.services.k8s.aws";
    public const string KubePluralName = "multiregionclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorydb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MultiRegionClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MultiRegionCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MultiRegionCluster> Items { get; set; }
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
public partial class V1alpha1MultiRegionClusterSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// MultiRegionClusterSpec defines the desired state of MultiRegionCluster.
/// 
/// Represents a multi-Region cluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MultiRegionClusterSpec
{
    /// <summary>A description for the multi-Region cluster.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of the engine to be used for the multi-Region cluster.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>The version of the engine to be used for the multi-Region cluster.</summary>
    [JsonPropertyName("engineVersion")]
    public string? EngineVersion { get; set; }

    /// <summary>A suffix to be added to the multi-Region cluster name.</summary>
    [JsonPropertyName("multiRegionClusterNameSuffix")]
    public required string MultiRegionClusterNameSuffix { get; set; }

    /// <summary>The name of the multi-Region parameter group to be associated with the cluster.</summary>
    [JsonPropertyName("multiRegionParameterGroupName")]
    public string? MultiRegionParameterGroupName { get; set; }

    /// <summary>The node type to be used for the multi-Region cluster.</summary>
    [JsonPropertyName("nodeType")]
    public required string NodeType { get; set; }

    /// <summary>The number of shards for the multi-Region cluster.</summary>
    [JsonPropertyName("numShards")]
    public long? NumShards { get; set; }

    /// <summary>A list of tags to be applied to the multi-Region cluster.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1MultiRegionClusterSpecTags>? Tags { get; set; }

    /// <summary>Whether to enable TLS encryption for the multi-Region cluster.</summary>
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
public partial class V1alpha1MultiRegionClusterStatusAckResourceMetadata
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

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>Represents a Regional cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MultiRegionClusterStatusClusters
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MultiRegionClusterStatusConditions
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

/// <summary>MultiRegionClusterStatus defines the observed state of MultiRegionCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MultiRegionClusterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1MultiRegionClusterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The clusters in this multi-Region cluster.</summary>
    [JsonPropertyName("clusters")]
    public IList<V1alpha1MultiRegionClusterStatusClusters>? Clusters { get; set; }

    /// <summary>
    /// All CRS managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MultiRegionClusterStatusConditions>? Conditions { get; set; }

    /// <summary>The name of the multi-Region cluster.</summary>
    [JsonPropertyName("multiRegionClusterName")]
    public string? MultiRegionClusterName { get; set; }

    /// <summary>The number of shards in the multi-Region cluster.</summary>
    [JsonPropertyName("numberOfShards")]
    public long? NumberOfShards { get; set; }

    /// <summary>The current status of the multi-Region cluster.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>MultiRegionCluster is the Schema for the MultiRegionClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MultiRegionCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MultiRegionClusterSpec?>, IStatus<V1alpha1MultiRegionClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MultiRegionCluster";
    public const string KubeGroup = "memorydb.services.k8s.aws";
    public const string KubePluralName = "multiregionclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorydb.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MultiRegionCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// MultiRegionClusterSpec defines the desired state of MultiRegionCluster.
    /// 
    /// Represents a multi-Region cluster.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1MultiRegionClusterSpec? Spec { get; set; }

    /// <summary>MultiRegionClusterStatus defines the observed state of MultiRegionCluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1MultiRegionClusterStatus? Status { get; set; }
}