#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.services.k8s.aws;
/// <summary>ConnectionGroup is the Schema for the ConnectionGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ConnectionGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ConnectionGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ConnectionGroupList";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "connectiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConnectionGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ConnectionGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ConnectionGroup> Items { get; set; }
}

/// <summary>A complex type that contains Tag key and Tag value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectionGroupSpecTags
{
    /// <summary>
    /// A string that contains Tag key.
    /// 
    /// The string length should be between 1 and 128 characters. Valid characters
    /// include a-z, A-Z, 0-9, space, and the special characters _ - . : / = + @.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ConnectionGroupSpec defines the desired state of ConnectionGroup.
/// 
/// The connection group for your distribution tenants. When you first create
/// a distribution tenant and you don&apos;t specify a connection group, CloudFront
/// will automatically create a default connection group for you. When you create
/// a new distribution tenant and don&apos;t specify a connection group, the default
/// one will be associated with your distribution tenant.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectionGroupSpec
{
    /// <summary>The ID of the Anycast static IP list.</summary>
    [JsonPropertyName("anycastIPListID")]
    public string? AnycastIPListID { get; set; }

    /// <summary>Enable the connection group.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Enable IPv6 for the connection group. The default is true. For more information,
    /// see Enable IPv6 (https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesEnableIPv6)
    /// in the Amazon CloudFront Developer Guide.
    /// </summary>
    [JsonPropertyName("ipv6Enabled")]
    public bool? Ipv6Enabled { get; set; }

    /// <summary>
    /// The name of the connection group. Enter a friendly identifier that is unique
    /// within your Amazon Web Services account. This name can&apos;t be updated after
    /// you create the connection group.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>A complex type that contains Tag elements.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ConnectionGroupSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectionGroupStatusAckResourceMetadata
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
public partial class V1alpha1ConnectionGroupStatusConditions
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

/// <summary>ConnectionGroupStatus defines the observed state of ConnectionGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ConnectionGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ConnectionGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ConnectionGroupStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time when the connection group was created.</summary>
    [JsonPropertyName("createdTime")]
    public DateTime? CreatedTime { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>The ID of the connection group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Whether the connection group is the default connection group for the distribution
    /// tenants.
    /// </summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The date and time when the connection group was updated.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>
    /// The routing endpoint (also known as the DNS name) that is assigned to the
    /// connection group, such as d111111abcdef8.cloudfront.net.
    /// </summary>
    [JsonPropertyName("routingEndpoint")]
    public string? RoutingEndpoint { get; set; }

    /// <summary>The status of the connection group.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ConnectionGroup is the Schema for the ConnectionGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ConnectionGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ConnectionGroupSpec?>, IStatus<V1alpha1ConnectionGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ConnectionGroup";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "connectiongroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ConnectionGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ConnectionGroupSpec defines the desired state of ConnectionGroup.
    /// 
    /// The connection group for your distribution tenants. When you first create
    /// a distribution tenant and you don&apos;t specify a connection group, CloudFront
    /// will automatically create a default connection group for you. When you create
    /// a new distribution tenant and don&apos;t specify a connection group, the default
    /// one will be associated with your distribution tenant.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ConnectionGroupSpec? Spec { get; set; }

    /// <summary>ConnectionGroupStatus defines the observed state of ConnectionGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1ConnectionGroupStatus? Status { get; set; }
}