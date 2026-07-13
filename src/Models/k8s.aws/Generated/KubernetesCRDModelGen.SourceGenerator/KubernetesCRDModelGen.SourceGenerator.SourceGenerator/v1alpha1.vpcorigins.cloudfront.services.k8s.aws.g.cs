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
/// <summary>VPCOrigin is the Schema for the VPCOrigins API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VPCOriginList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VPCOrigin>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VPCOriginList";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "vpcorigins";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPCOriginList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VPCOrigin objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VPCOrigin> Items { get; set; }
}

/// <summary>A complex type that contains Tag key and Tag value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCOriginSpecTags
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
/// A complex type that contains information about the SSL/TLS protocols that
/// CloudFront can use when establishing an HTTPS connection with your origin.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCOriginSpecVpcOriginEndpointConfigOriginSSLProtocols
{
    [JsonPropertyName("items")]
    public IList<string>? Items { get; set; }
}

/// <summary>The VPC origin endpoint configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCOriginSpecVpcOriginEndpointConfig
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("httpPort")]
    public long? HttpPort { get; set; }

    [JsonPropertyName("httpsPort")]
    public long? HttpsPort { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("originProtocolPolicy")]
    public string? OriginProtocolPolicy { get; set; }

    /// <summary>
    /// A complex type that contains information about the SSL/TLS protocols that
    /// CloudFront can use when establishing an HTTPS connection with your origin.
    /// </summary>
    [JsonPropertyName("originSSLProtocols")]
    public V1alpha1VPCOriginSpecVpcOriginEndpointConfigOriginSSLProtocols? OriginSSLProtocols { get; set; }
}

/// <summary>
/// VpcOriginSpec defines the desired state of VpcOrigin.
/// 
/// An Amazon CloudFront VPC origin.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCOriginSpec
{
    /// <summary>A complex type that contains Tag elements.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1VPCOriginSpecTags>? Tags { get; set; }

    /// <summary>The VPC origin endpoint configuration.</summary>
    [JsonPropertyName("vpcOriginEndpointConfig")]
    public required V1alpha1VPCOriginSpecVpcOriginEndpointConfig VpcOriginEndpointConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCOriginStatusAckResourceMetadata
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
public partial class V1alpha1VPCOriginStatusConditions
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

/// <summary>VPCOriginStatus defines the observed state of VPCOrigin</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCOriginStatus
{
    /// <summary>The account ID of the Amazon Web Services account that owns the VPC origin.</summary>
    [JsonPropertyName("accountID")]
    public string? AccountID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1VPCOriginStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VPCOriginStatusConditions>? Conditions { get; set; }

    /// <summary>The VPC origin created time.</summary>
    [JsonPropertyName("createdTime")]
    public DateTime? CreatedTime { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>The VPC origin ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The VPC origin last modified time.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>The VPC origin status.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>VPCOrigin is the Schema for the VPCOrigins API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VPCOrigin : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VPCOriginSpec?>, IStatus<V1alpha1VPCOriginStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VPCOrigin";
    public const string KubeGroup = "cloudfront.services.k8s.aws";
    public const string KubePluralName = "vpcorigins";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPCOrigin";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// VpcOriginSpec defines the desired state of VpcOrigin.
    /// 
    /// An Amazon CloudFront VPC origin.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1VPCOriginSpec? Spec { get; set; }

    /// <summary>VPCOriginStatus defines the observed state of VPCOrigin</summary>
    [JsonPropertyName("status")]
    public V1alpha1VPCOriginStatus? Status { get; set; }
}