#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.services.k8s.aws;
/// <summary>ElasticIPAddress is the Schema for the ElasticIPAddresses API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ElasticIPAddressList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ElasticIPAddress>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ElasticIPAddressList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "elasticipaddresses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ElasticIPAddressList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ElasticIPAddress objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ElasticIPAddress> Items { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ElasticIPAddressSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ElasticIPAddressSpec defines the desired state of ElasticIPAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ElasticIPAddressSpec
{
    /// <summary>The Elastic IP address to recover or an IPv4 address from an address pool.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// The ID of a customer-owned address pool. Use this parameter to let Amazon
    /// EC2 select an address from the address pool. Alternatively, specify a specific
    /// address from the address pool.
    /// </summary>
    [JsonPropertyName("customerOwnedIPv4Pool")]
    public string? CustomerOwnedIPv4Pool { get; set; }

    /// <summary>
    /// A unique set of Availability Zones, Local Zones, or Wavelength Zones from
    /// which Amazon Web Services advertises IP addresses. Use this parameter to
    /// limit the IP address to this location. IP addresses cannot move between network
    /// border groups.
    /// </summary>
    [JsonPropertyName("networkBorderGroup")]
    public string? NetworkBorderGroup { get; set; }

    /// <summary>
    /// The ID of an address pool that you own. Use this parameter to let Amazon
    /// EC2 select an address from the address pool. To specify a specific address
    /// from the address pool, use the Address parameter instead.
    /// </summary>
    [JsonPropertyName("publicIPv4Pool")]
    public string? PublicIPv4Pool { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ElasticIPAddressSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ElasticIPAddressStatusAckResourceMetadata
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
public partial class V1alpha1ElasticIPAddressStatusConditions
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

/// <summary>ElasticIPAddressStatus defines the observed state of ElasticIPAddress</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ElasticIPAddressStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ElasticIPAddressStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The ID that represents the allocation of the Elastic IP address.</summary>
    [JsonPropertyName("allocationID")]
    public string? AllocationID { get; set; }

    /// <summary>
    /// The carrier IP address. Available only for network interfaces that reside
    /// in a subnet in a Wavelength Zone.
    /// </summary>
    [JsonPropertyName("carrierIP")]
    public string? CarrierIP { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ElasticIPAddressStatusConditions>? Conditions { get; set; }

    /// <summary>The customer-owned IP address.</summary>
    [JsonPropertyName("customerOwnedIP")]
    public string? CustomerOwnedIP { get; set; }

    /// <summary>
    /// The Amazon-owned IP address. Not available when using an address pool that
    /// you own.
    /// </summary>
    [JsonPropertyName("publicIP")]
    public string? PublicIP { get; set; }
}

/// <summary>ElasticIPAddress is the Schema for the ElasticIPAddresses API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ElasticIPAddress : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ElasticIPAddressSpec?>, IStatus<V1alpha1ElasticIPAddressStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ElasticIPAddress";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "elasticipaddresses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ElasticIPAddress";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ElasticIPAddressSpec defines the desired state of ElasticIPAddress.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ElasticIPAddressSpec? Spec { get; set; }

    /// <summary>ElasticIPAddressStatus defines the observed state of ElasticIPAddress</summary>
    [JsonPropertyName("status")]
    public V1alpha1ElasticIPAddressStatus? Status { get; set; }
}