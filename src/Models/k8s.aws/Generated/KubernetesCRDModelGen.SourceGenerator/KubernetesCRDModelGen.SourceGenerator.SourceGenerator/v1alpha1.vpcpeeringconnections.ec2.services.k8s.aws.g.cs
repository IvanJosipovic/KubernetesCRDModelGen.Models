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
/// <summary>VPCPeeringConnection is the Schema for the VPCPeeringConnections API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VPCPeeringConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VPCPeeringConnection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VPCPeeringConnectionList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "vpcpeeringconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPCPeeringConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VPCPeeringConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VPCPeeringConnection> Items { get; set; }
}

/// <summary>The VPC peering connection options for the accepter VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionSpecAccepterPeeringConnectionOptions
{
    [JsonPropertyName("allowDNSResolutionFromRemoteVPC")]
    public bool? AllowDNSResolutionFromRemoteVPC { get; set; }

    [JsonPropertyName("allowEgressFromLocalClassicLinkToRemoteVPC")]
    public bool? AllowEgressFromLocalClassicLinkToRemoteVPC { get; set; }

    [JsonPropertyName("allowEgressFromLocalVPCToRemoteClassicLink")]
    public bool? AllowEgressFromLocalVPCToRemoteClassicLink { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionSpecPeerVPCRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionSpecPeerVPCRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1VPCPeeringConnectionSpecPeerVPCRefFrom? From { get; set; }
}

/// <summary>The VPC peering connection options for the requester VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionSpecRequesterPeeringConnectionOptions
{
    [JsonPropertyName("allowDNSResolutionFromRemoteVPC")]
    public bool? AllowDNSResolutionFromRemoteVPC { get; set; }

    [JsonPropertyName("allowEgressFromLocalClassicLinkToRemoteVPC")]
    public bool? AllowEgressFromLocalClassicLinkToRemoteVPC { get; set; }

    [JsonPropertyName("allowEgressFromLocalVPCToRemoteClassicLink")]
    public bool? AllowEgressFromLocalVPCToRemoteClassicLink { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionSpecTags
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionSpecVpcRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionSpecVpcRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1VPCPeeringConnectionSpecVpcRefFrom? From { get; set; }
}

/// <summary>
/// VpcPeeringConnectionSpec defines the desired state of VpcPeeringConnection.
/// 
/// Describes a VPC peering connection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionSpec
{
    [JsonPropertyName("acceptRequest")]
    public bool? AcceptRequest { get; set; }

    /// <summary>The VPC peering connection options for the accepter VPC.</summary>
    [JsonPropertyName("accepterPeeringConnectionOptions")]
    public V1alpha1VPCPeeringConnectionSpecAccepterPeeringConnectionOptions? AccepterPeeringConnectionOptions { get; set; }

    /// <summary>
    /// The Amazon Web Services account ID of the owner of the accepter VPC.
    /// 
    /// Default: Your Amazon Web Services account ID
    /// </summary>
    [JsonPropertyName("peerOwnerID")]
    public string? PeerOwnerID { get; set; }

    /// <summary>
    /// The Region code for the accepter VPC, if the accepter VPC is located in a
    /// Region other than the Region in which you make the request.
    /// 
    /// Default: The Region in which you make the request.
    /// </summary>
    [JsonPropertyName("peerRegion")]
    public string? PeerRegion { get; set; }

    /// <summary>
    /// The ID of the VPC with which you are creating the VPC peering connection.
    /// You must specify this parameter in the request.
    /// </summary>
    [JsonPropertyName("peerVPCID")]
    public string? PeerVPCID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("peerVPCRef")]
    public V1alpha1VPCPeeringConnectionSpecPeerVPCRef? PeerVPCRef { get; set; }

    /// <summary>The VPC peering connection options for the requester VPC.</summary>
    [JsonPropertyName("requesterPeeringConnectionOptions")]
    public V1alpha1VPCPeeringConnectionSpecRequesterPeeringConnectionOptions? RequesterPeeringConnectionOptions { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1VPCPeeringConnectionSpecTags>? Tags { get; set; }

    /// <summary>The ID of the requester VPC. You must specify this parameter in the request.</summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("vpcRef")]
    public V1alpha1VPCPeeringConnectionSpecVpcRef? VpcRef { get; set; }
}

/// <summary>Describes an IPv4 CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionStatusAccepterVPCInfoCidrBlockSet
{
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }
}

/// <summary>Describes an IPv6 CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionStatusAccepterVPCInfoIpv6CIDRBlockSet
{
    [JsonPropertyName("ipv6CIDRBlock")]
    public string? Ipv6CIDRBlock { get; set; }
}

/// <summary>Describes the VPC peering connection options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionStatusAccepterVPCInfoPeeringOptions
{
    [JsonPropertyName("allowDNSResolutionFromRemoteVPC")]
    public bool? AllowDNSResolutionFromRemoteVPC { get; set; }

    [JsonPropertyName("allowEgressFromLocalClassicLinkToRemoteVPC")]
    public bool? AllowEgressFromLocalClassicLinkToRemoteVPC { get; set; }

    [JsonPropertyName("allowEgressFromLocalVPCToRemoteClassicLink")]
    public bool? AllowEgressFromLocalVPCToRemoteClassicLink { get; set; }
}

/// <summary>
/// Information about the accepter VPC. CIDR block information is only returned
/// when describing an active VPC peering connection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionStatusAccepterVPCInfo
{
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    [JsonPropertyName("cidrBlockSet")]
    public IList<V1alpha1VPCPeeringConnectionStatusAccepterVPCInfoCidrBlockSet>? CidrBlockSet { get; set; }

    [JsonPropertyName("ipv6CIDRBlockSet")]
    public IList<V1alpha1VPCPeeringConnectionStatusAccepterVPCInfoIpv6CIDRBlockSet>? Ipv6CIDRBlockSet { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>Describes the VPC peering connection options.</summary>
    [JsonPropertyName("peeringOptions")]
    public V1alpha1VPCPeeringConnectionStatusAccepterVPCInfoPeeringOptions? PeeringOptions { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionStatusAckResourceMetadata
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
public partial class V1alpha1VPCPeeringConnectionStatusConditions
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

/// <summary>Describes an IPv4 CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionStatusRequesterVPCInfoCidrBlockSet
{
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }
}

/// <summary>Describes an IPv6 CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionStatusRequesterVPCInfoIpv6CIDRBlockSet
{
    [JsonPropertyName("ipv6CIDRBlock")]
    public string? Ipv6CIDRBlock { get; set; }
}

/// <summary>Describes the VPC peering connection options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionStatusRequesterVPCInfoPeeringOptions
{
    [JsonPropertyName("allowDNSResolutionFromRemoteVPC")]
    public bool? AllowDNSResolutionFromRemoteVPC { get; set; }

    [JsonPropertyName("allowEgressFromLocalClassicLinkToRemoteVPC")]
    public bool? AllowEgressFromLocalClassicLinkToRemoteVPC { get; set; }

    [JsonPropertyName("allowEgressFromLocalVPCToRemoteClassicLink")]
    public bool? AllowEgressFromLocalVPCToRemoteClassicLink { get; set; }
}

/// <summary>
/// Information about the requester VPC. CIDR block information is only returned
/// when describing an active VPC peering connection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionStatusRequesterVPCInfo
{
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    [JsonPropertyName("cidrBlockSet")]
    public IList<V1alpha1VPCPeeringConnectionStatusRequesterVPCInfoCidrBlockSet>? CidrBlockSet { get; set; }

    [JsonPropertyName("ipv6CIDRBlockSet")]
    public IList<V1alpha1VPCPeeringConnectionStatusRequesterVPCInfoIpv6CIDRBlockSet>? Ipv6CIDRBlockSet { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>Describes the VPC peering connection options.</summary>
    [JsonPropertyName("peeringOptions")]
    public V1alpha1VPCPeeringConnectionStatusRequesterVPCInfoPeeringOptions? PeeringOptions { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>The status of the VPC peering connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionStatusStatus
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>VPCPeeringConnectionStatus defines the observed state of VPCPeeringConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCPeeringConnectionStatus
{
    /// <summary>
    /// Information about the accepter VPC. CIDR block information is only returned
    /// when describing an active VPC peering connection.
    /// </summary>
    [JsonPropertyName("accepterVPCInfo")]
    public V1alpha1VPCPeeringConnectionStatusAccepterVPCInfo? AccepterVPCInfo { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1VPCPeeringConnectionStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VPCPeeringConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>The time that an unaccepted VPC peering connection will expire.</summary>
    [JsonPropertyName("expirationTime")]
    public DateTime? ExpirationTime { get; set; }

    /// <summary>
    /// Information about the requester VPC. CIDR block information is only returned
    /// when describing an active VPC peering connection.
    /// </summary>
    [JsonPropertyName("requesterVPCInfo")]
    public V1alpha1VPCPeeringConnectionStatusRequesterVPCInfo? RequesterVPCInfo { get; set; }

    /// <summary>The status of the VPC peering connection.</summary>
    [JsonPropertyName("status")]
    public V1alpha1VPCPeeringConnectionStatusStatus? Status { get; set; }

    /// <summary>The ID of the VPC peering connection.</summary>
    [JsonPropertyName("vpcPeeringConnectionID")]
    public string? VpcPeeringConnectionID { get; set; }
}

/// <summary>VPCPeeringConnection is the Schema for the VPCPeeringConnections API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VPCPeeringConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VPCPeeringConnectionSpec?>, IStatus<V1alpha1VPCPeeringConnectionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VPCPeeringConnection";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "vpcpeeringconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPCPeeringConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// VpcPeeringConnectionSpec defines the desired state of VpcPeeringConnection.
    /// 
    /// Describes a VPC peering connection.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1VPCPeeringConnectionSpec? Spec { get; set; }

    /// <summary>VPCPeeringConnectionStatus defines the observed state of VPCPeeringConnection</summary>
    [JsonPropertyName("status")]
    public V1alpha1VPCPeeringConnectionStatus? Status { get; set; }
}