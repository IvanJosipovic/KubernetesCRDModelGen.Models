#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.elbv2.services.k8s.aws;
/// <summary>LoadBalancer is the Schema for the LoadBalancers API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LoadBalancerList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1LoadBalancer>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LoadBalancerList";
    public const string KubeGroup = "elbv2.services.k8s.aws";
    public const string KubePluralName = "loadbalancers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1LoadBalancer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1LoadBalancer> Items { get; set; }
}

/// <summary>Information about a load balancer attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerSpecAttributes
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
public partial class V1alpha1LoadBalancerSpecSecurityGroupRefsFrom
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
public partial class V1alpha1LoadBalancerSpecSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1LoadBalancerSpecSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerSpecSubnetMappingsSubnetRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for SubnetID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerSpecSubnetMappingsSubnetRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1LoadBalancerSpecSubnetMappingsSubnetRefFrom? From { get; set; }
}

/// <summary>Information about a subnet mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerSpecSubnetMappings
{
    [JsonPropertyName("allocationID")]
    public string? AllocationID { get; set; }

    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    [JsonPropertyName("privateIPv4Address")]
    public string? PrivateIPv4Address { get; set; }

    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }

    /// <summary>Reference field for SubnetID</summary>
    [JsonPropertyName("subnetRef")]
    public V1alpha1LoadBalancerSpecSubnetMappingsSubnetRef? SubnetRef { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerSpecSubnetRefsFrom
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
public partial class V1alpha1LoadBalancerSpecSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1LoadBalancerSpecSubnetRefsFrom? From { get; set; }
}

/// <summary>Information about a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// LoadBalancerSpec defines the desired state of LoadBalancer.
/// 
/// Information about a load balancer.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerSpec
{
    /// <summary>The load balancer attributes.</summary>
    [JsonPropertyName("attributes")]
    public IList<V1alpha1LoadBalancerSpecAttributes>? Attributes { get; set; }

    /// <summary>
    /// [Application Load Balancers on Outposts] The ID of the customer-owned address
    /// pool (CoIP pool).
    /// 
    /// Regex Pattern: `^(ipv4pool-coip-)[a-zA-Z0-9]+$`
    /// </summary>
    [JsonPropertyName("customerOwnedIPv4Pool")]
    public string? CustomerOwnedIPv4Pool { get; set; }

    /// <summary>
    /// [Network Load Balancers with UDP listeners] Indicates whether to use an IPv6
    /// prefix from each subnet for source NAT. The IP address type must be dualstack.
    /// The default value is off.
    /// </summary>
    [JsonPropertyName("enablePrefixForIPv6SourceNAT")]
    public string? EnablePrefixForIPv6SourceNAT { get; set; }

    /// <summary>
    /// The IP address type. Internal load balancers must use ipv4.
    /// 
    /// [Application Load Balancers] The possible values are ipv4 (IPv4 addresses),
    /// dualstack (IPv4 and IPv6 addresses), and dualstack-without-public-ipv4 (public
    /// IPv6 addresses and private IPv4 and IPv6 addresses).
    /// 
    /// [Network Load Balancers and Gateway Load Balancers] The possible values are
    /// ipv4 (IPv4 addresses) and dualstack (IPv4 and IPv6 addresses).
    /// </summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>
    /// The name of the load balancer.
    /// 
    /// This name must be unique per region per account, can have a maximum of 32
    /// characters, must contain only alphanumeric characters or hyphens, must not
    /// begin or end with a hyphen, and must not begin with &quot;internal-&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The nodes of an Internet-facing load balancer have public IP addresses. The
    /// DNS name of an Internet-facing load balancer is publicly resolvable to the
    /// public IP addresses of the nodes. Therefore, Internet-facing load balancers
    /// can route requests from clients over the internet.
    /// 
    /// The nodes of an internal load balancer have only private IP addresses. The
    /// DNS name of an internal load balancer is publicly resolvable to the private
    /// IP addresses of the nodes. Therefore, internal load balancers can route requests
    /// only from clients with access to the VPC for the load balancer.
    /// 
    /// The default is an Internet-facing load balancer.
    /// 
    /// You can&apos;t specify a scheme for a Gateway Load Balancer.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1LoadBalancerSpecSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>
    /// [Application Load Balancers and Network Load Balancers] The IDs of the security
    /// groups for the load balancer.
    /// </summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The IDs of the subnets. You can specify only one subnet per Availability
    /// Zone. You must specify either subnets or subnet mappings, but not both.
    /// 
    /// [Application Load Balancers] You must specify subnets from at least two Availability
    /// Zones. You can&apos;t specify Elastic IP addresses for your subnets.
    /// 
    /// [Application Load Balancers on Outposts] You must specify one Outpost subnet.
    /// 
    /// [Application Load Balancers on Local Zones] You can specify subnets from
    /// one or more Local Zones.
    /// 
    /// [Network Load Balancers] You can specify subnets from one or more Availability
    /// Zones. You can specify one Elastic IP address per subnet if you need static
    /// IP addresses for your internet-facing load balancer. For internal load balancers,
    /// you can specify one private IP address per subnet from the IPv4 range of
    /// the subnet. For internet-facing load balancer, you can specify one IPv6 address
    /// per subnet.
    /// 
    /// [Gateway Load Balancers] You can specify subnets from one or more Availability
    /// Zones. You can&apos;t specify Elastic IP addresses for your subnets.
    /// </summary>
    [JsonPropertyName("subnetMappings")]
    public IList<V1alpha1LoadBalancerSpecSubnetMappings>? SubnetMappings { get; set; }

    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1LoadBalancerSpecSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>
    /// The IDs of the subnets. You can specify only one subnet per Availability
    /// Zone. You must specify either subnets or subnet mappings, but not both. To
    /// specify an Elastic IP address, specify subnet mappings instead of subnets.
    /// 
    /// [Application Load Balancers] You must specify subnets from at least two Availability
    /// Zones.
    /// 
    /// [Application Load Balancers on Outposts] You must specify one Outpost subnet.
    /// 
    /// [Application Load Balancers on Local Zones] You can specify subnets from
    /// one or more Local Zones.
    /// 
    /// [Network Load Balancers and Gateway Load Balancers] You can specify subnets
    /// from one or more Availability Zones.
    /// </summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }

    /// <summary>The tags to assign to the load balancer.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1LoadBalancerSpecTags>? Tags { get; set; }

    /// <summary>The type of load balancer. The default is application.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerStatusAckResourceMetadata
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

/// <summary>Information about a static IP address for a load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerStatusAvailabilityZonesLoadBalancerAddresses
{
    [JsonPropertyName("allocationID")]
    public string? AllocationID { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    [JsonPropertyName("privateIPv4Address")]
    public string? PrivateIPv4Address { get; set; }
}

/// <summary>Information about an Availability Zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerStatusAvailabilityZones
{
    [JsonPropertyName("loadBalancerAddresses")]
    public IList<V1alpha1LoadBalancerStatusAvailabilityZonesLoadBalancerAddresses>? LoadBalancerAddresses { get; set; }

    [JsonPropertyName("outpostID")]
    public string? OutpostID { get; set; }

    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }

    [JsonPropertyName("zoneName")]
    public string? ZoneName { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerStatusConditions
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

/// <summary>The state of the load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerStatusState
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>LoadBalancerStatus defines the observed state of LoadBalancer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LoadBalancerStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1LoadBalancerStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The subnets for the load balancer.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<V1alpha1LoadBalancerStatusAvailabilityZones>? AvailabilityZones { get; set; }

    /// <summary>The ID of the Amazon Route 53 hosted zone associated with the load balancer.</summary>
    [JsonPropertyName("canonicalHostedZoneID")]
    public string? CanonicalHostedZoneID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1LoadBalancerStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time the load balancer was created.</summary>
    [JsonPropertyName("createdTime")]
    public DateTime? CreatedTime { get; set; }

    /// <summary>The public DNS name of the load balancer.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>
    /// Indicates whether to evaluate inbound security group rules for traffic sent
    /// to a Network Load Balancer through Amazon Web Services PrivateLink.
    /// </summary>
    [JsonPropertyName("enforceSecurityGroupInboundRulesOnPrivateLinkTraffic")]
    public string? EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic { get; set; }

    /// <summary>The state of the load balancer.</summary>
    [JsonPropertyName("state")]
    public V1alpha1LoadBalancerStatusState? State { get; set; }

    /// <summary>The ID of the VPC for the load balancer.</summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>LoadBalancer is the Schema for the LoadBalancers API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LoadBalancer : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1LoadBalancerSpec?>, IStatus<V1alpha1LoadBalancerStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LoadBalancer";
    public const string KubeGroup = "elbv2.services.k8s.aws";
    public const string KubePluralName = "loadbalancers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "elbv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// LoadBalancerSpec defines the desired state of LoadBalancer.
    /// 
    /// Information about a load balancer.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1LoadBalancerSpec? Spec { get; set; }

    /// <summary>LoadBalancerStatus defines the observed state of LoadBalancer</summary>
    [JsonPropertyName("status")]
    public V1alpha1LoadBalancerStatus? Status { get; set; }
}