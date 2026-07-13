#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.emrcontainers.services.k8s.aws;
/// <summary>VirtualCluster is the Schema for the VirtualClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VirtualClusterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VirtualCluster>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VirtualClusterList";
    public const string KubeGroup = "emrcontainers.services.k8s.aws";
    public const string KubePluralName = "virtualclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "emrcontainers.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualClusterList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VirtualCluster objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VirtualCluster> Items { get; set; }
}

/// <summary>The information about the Amazon EKS cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VirtualClusterSpecContainerProviderInfoEksInfo
{
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The information about the container used for a job run or a managed endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VirtualClusterSpecContainerProviderInfo
{
    /// <summary>The information about the Amazon EKS cluster.</summary>
    [JsonPropertyName("eksInfo")]
    public V1alpha1VirtualClusterSpecContainerProviderInfoEksInfo? EksInfo { get; set; }
}

/// <summary>The container provider of the virtual cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VirtualClusterSpecContainerProvider
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The information about the container used for a job run or a managed endpoint.</summary>
    [JsonPropertyName("info")]
    public V1alpha1VirtualClusterSpecContainerProviderInfo? Info { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// VirtualClusterSpec defines the desired state of VirtualCluster.
/// 
/// This entity describes a virtual cluster. A virtual cluster is a Kubernetes
/// namespace that Amazon EMR is registered with. Amazon EMR uses virtual clusters
/// to run jobs and host endpoints. Multiple virtual clusters can be backed by
/// the same physical cluster. However, each virtual cluster maps to one namespace
/// on an Amazon EKS cluster. Virtual clusters do not create any active resources
/// that contribute to your bill or that require lifecycle management outside
/// the service.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VirtualClusterSpec
{
    /// <summary>The container provider of the virtual cluster.</summary>
    [JsonPropertyName("containerProvider")]
    public required V1alpha1VirtualClusterSpecContainerProvider ContainerProvider { get; set; }

    /// <summary>
    /// The specified name of the virtual cluster.
    /// 
    /// Regex Pattern: `^[\.\-_/#A-Za-z0-9]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The tags assigned to the virtual cluster.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VirtualClusterStatusAckResourceMetadata
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
public partial class V1alpha1VirtualClusterStatusConditions
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

/// <summary>VirtualClusterStatus defines the observed state of VirtualCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VirtualClusterStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1VirtualClusterStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VirtualClusterStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// This output contains the virtual cluster ID.
    /// 
    /// Regex Pattern: `^[0-9a-z]+$`
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>VirtualCluster is the Schema for the VirtualClusters API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VirtualCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VirtualClusterSpec?>, IStatus<V1alpha1VirtualClusterStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VirtualCluster";
    public const string KubeGroup = "emrcontainers.services.k8s.aws";
    public const string KubePluralName = "virtualclusters";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "emrcontainers.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualCluster";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// VirtualClusterSpec defines the desired state of VirtualCluster.
    /// 
    /// This entity describes a virtual cluster. A virtual cluster is a Kubernetes
    /// namespace that Amazon EMR is registered with. Amazon EMR uses virtual clusters
    /// to run jobs and host endpoints. Multiple virtual clusters can be backed by
    /// the same physical cluster. However, each virtual cluster maps to one namespace
    /// on an Amazon EKS cluster. Virtual clusters do not create any active resources
    /// that contribute to your bill or that require lifecycle management outside
    /// the service.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1VirtualClusterSpec? Spec { get; set; }

    /// <summary>VirtualClusterStatus defines the observed state of VirtualCluster</summary>
    [JsonPropertyName("status")]
    public V1alpha1VirtualClusterStatus? Status { get; set; }
}