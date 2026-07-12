#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.route53resolver.services.k8s.aws;
/// <summary>ResolverEndpoint is the Schema for the ResolverEndpoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResolverEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ResolverEndpoint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResolverEndpointList";
    public const string KubeGroup = "route53resolver.services.k8s.aws";
    public const string KubePluralName = "resolverendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53resolver.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResolverEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ResolverEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ResolverEndpoint> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverEndpointSpecIpAddressesSubnetRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for SubnetID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverEndpointSpecIpAddressesSubnetRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ResolverEndpointSpecIpAddressesSubnetRefFrom? From { get; set; }
}

/// <summary>
/// In a CreateResolverEndpoint (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverEndpoint.html)
/// request, the IP address that DNS queries originate from (for outbound endpoints)
/// or that you forward DNS queries to (for inbound endpoints). IpAddressRequest
/// also includes the ID of the subnet that contains the IP address.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverEndpointSpecIpAddresses
{
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("ipv6")]
    public string? Ipv6 { get; set; }

    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }

    /// <summary>Reference field for SubnetID</summary>
    [JsonPropertyName("subnetRef")]
    public V1alpha1ResolverEndpointSpecIpAddressesSubnetRef? SubnetRef { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverEndpointSpecSecurityGroupRefsFrom
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
public partial class V1alpha1ResolverEndpointSpecSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ResolverEndpointSpecSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// One tag that you want to add to the specified resource. A tag consists of
/// a Key (a name for the tag) and a Value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverEndpointSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ResolverEndpointSpec defines the desired state of ResolverEndpoint.
/// 
/// In the response to a CreateResolverEndpoint (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverEndpoint.html),
/// DeleteResolverEndpoint (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DeleteResolverEndpoint.html),
/// GetResolverEndpoint (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverEndpoint.html),
/// Updates the name, or ResolverEndpointType for an endpoint, or UpdateResolverEndpoint
/// (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_UpdateResolverEndpoint.html)
/// request, a complex type that contains settings for an existing inbound or
/// outbound Resolver endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverEndpointSpec
{
    /// <summary>
    /// Specify the applicable value:
    /// 
    ///   - INBOUND: Resolver forwards DNS queries to the DNS service for a VPC
    ///     from your network
    /// 
    ///   - OUTBOUND: Resolver forwards DNS queries from the DNS service for a VPC
    ///     to your network
    /// </summary>
    [JsonPropertyName("direction")]
    public required string Direction { get; set; }

    /// <summary>
    /// The subnets and IP addresses in your VPC that DNS queries originate from
    /// (for outbound endpoints) or that you forward DNS queries to (for inbound
    /// endpoints). The subnet ID uniquely identifies a VPC.
    /// 
    /// Even though the minimum is 1, Route 53 requires that you create at least
    /// two.
    /// </summary>
    [JsonPropertyName("ipAddresses")]
    public required IList<V1alpha1ResolverEndpointSpecIpAddresses> IpAddresses { get; set; }

    /// <summary>
    /// A friendly name that lets you easily find a configuration in the Resolver
    /// dashboard in the Route 53 console.
    /// 
    /// Regex Pattern: `^(?!^[0-9]+$)([a-zA-Z0-9\-_&apos; &apos;]+)$`
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// For the endpoint type you can choose either IPv4, IPv6, or dual-stack. A
    /// dual-stack endpoint means that it will resolve via both IPv4 and IPv6. This
    /// endpoint type is applied to all IP addresses.
    /// </summary>
    [JsonPropertyName("resolverEndpointType")]
    public string? ResolverEndpointType { get; set; }

    /// <summary>
    /// The ID of one or more security groups that you want to use to control access
    /// to this VPC. The security group that you specify must include one or more
    /// inbound rules (for inbound Resolver endpoints) or outbound rules (for outbound
    /// Resolver endpoints). Inbound and outbound rules must allow TCP and UDP access.
    /// For inbound access, open port 53. For outbound access, open the port that
    /// you&apos;re using for DNS queries on your network.
    /// 
    /// Some security group rules will cause your connection to be tracked. For outbound
    /// resolver endpoint, it can potentially impact the maximum queries per second
    /// from outbound endpoint to your target name server. For inbound resolver endpoint,
    /// it can bring down the overall maximum queries per second per IP address to
    /// as low as 1500. To avoid connection tracking caused by security group, see
    /// Untracked connections (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/security-group-connection-tracking.html#untracked-connectionsl).
    /// </summary>
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1ResolverEndpointSpecSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>A list of the tag keys and values that you want to associate with the endpoint.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ResolverEndpointSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverEndpointStatusAckResourceMetadata
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
public partial class V1alpha1ResolverEndpointStatusConditions
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
/// In the response to a GetResolverEndpoint (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverEndpoint.html)
/// request, information about the IP addresses that the Resolver endpoint uses
/// for DNS queries.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverEndpointStatusIpAddresses
{
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("ipID")]
    public string? IpID { get; set; }

    [JsonPropertyName("ipv6")]
    public string? Ipv6 { get; set; }

    [JsonPropertyName("modificationTime")]
    public string? ModificationTime { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }

    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }
}

/// <summary>ResolverEndpointStatus defines the observed state of ResolverEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverEndpointStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ResolverEndpointStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ResolverEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time that the endpoint was created, in Unix time format and
    /// Coordinated Universal Time (UTC).
    /// </summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>
    /// A unique string that identifies the request that created the Resolver endpoint.
    /// The CreatorRequestId allows failed requests to be retried without the risk
    /// of running the operation twice.
    /// </summary>
    [JsonPropertyName("creatorRequestID")]
    public string? CreatorRequestID { get; set; }

    /// <summary>The ID of the VPC that you want to create the Resolver endpoint in.</summary>
    [JsonPropertyName("hostVPCID")]
    public string? HostVPCID { get; set; }

    /// <summary>The ID of the Resolver endpoint.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The number of IP addresses that the Resolver endpoint can use for DNS queries.</summary>
    [JsonPropertyName("ipAddressCount")]
    public long? IpAddressCount { get; set; }

    [JsonPropertyName("ipAddresses")]
    public IList<V1alpha1ResolverEndpointStatusIpAddresses>? IpAddresses { get; set; }

    /// <summary>
    /// The date and time that the endpoint was last modified, in Unix time format
    /// and Coordinated Universal Time (UTC).
    /// </summary>
    [JsonPropertyName("modificationTime")]
    public string? ModificationTime { get; set; }

    /// <summary>
    /// A code that specifies the current status of the Resolver endpoint. Valid
    /// values include the following:
    /// 
    ///    * CREATING: Resolver is creating and configuring one or more Amazon VPC
    ///    network interfaces for this endpoint.
    /// 
    ///    * OPERATIONAL: The Amazon VPC network interfaces for this endpoint are
    ///    correctly configured and able to pass inbound or outbound DNS queries
    ///    between your network and Resolver.
    /// 
    ///    * UPDATING: Resolver is associating or disassociating one or more network
    ///    interfaces with this endpoint.
    /// 
    ///    * AUTO_RECOVERING: Resolver is trying to recover one or more of the network
    ///    interfaces that are associated with this endpoint. During the recovery
    ///    process, the endpoint functions with limited capacity because of the limit
    ///    on the number of DNS queries per IP address (per network interface). For
    ///    the current limit, see Limits on Route 53 Resolver (https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities-resolver).
    /// 
    ///    * ACTION_NEEDED: This endpoint is unhealthy, and Resolver can&apos;t automatically
    ///    recover it. To resolve the problem, we recommend that you check each IP
    ///    address that you associated with the endpoint. For each IP address that
    ///    isn&apos;t available, add another IP address and then delete the IP address
    ///    that isn&apos;t available. (An endpoint must always include at least two IP
    ///    addresses.) A status of ACTION_NEEDED can have a variety of causes. Here
    ///    are two common causes: One or more of the network interfaces that are
    ///    associated with the endpoint were deleted using Amazon VPC. The network
    ///    interface couldn&apos;t be created for some reason that&apos;s outside the control
    ///    of Resolver.
    /// 
    ///    * DELETING: Resolver is deleting this endpoint and the associated network
    ///    interfaces.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A detailed description of the status of the Resolver endpoint.</summary>
    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>ResolverEndpoint is the Schema for the ResolverEndpoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResolverEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ResolverEndpointSpec?>, IStatus<V1alpha1ResolverEndpointStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResolverEndpoint";
    public const string KubeGroup = "route53resolver.services.k8s.aws";
    public const string KubePluralName = "resolverendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53resolver.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResolverEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ResolverEndpointSpec defines the desired state of ResolverEndpoint.
    /// 
    /// In the response to a CreateResolverEndpoint (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverEndpoint.html),
    /// DeleteResolverEndpoint (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DeleteResolverEndpoint.html),
    /// GetResolverEndpoint (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverEndpoint.html),
    /// Updates the name, or ResolverEndpointType for an endpoint, or UpdateResolverEndpoint
    /// (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_UpdateResolverEndpoint.html)
    /// request, a complex type that contains settings for an existing inbound or
    /// outbound Resolver endpoint.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ResolverEndpointSpec? Spec { get; set; }

    /// <summary>ResolverEndpointStatus defines the observed state of ResolverEndpoint</summary>
    [JsonPropertyName("status")]
    public V1alpha1ResolverEndpointStatus? Status { get; set; }
}