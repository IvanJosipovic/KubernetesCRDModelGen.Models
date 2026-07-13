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
/// <summary>Subnet is the Schema for the Subnets API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SubnetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Subnet>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SubnetList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "subnets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SubnetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Subnet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Subnet> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubnetSpecRouteTableRefsFrom
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
public partial class V1alpha1SubnetSpecRouteTableRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SubnetSpecRouteTableRefsFrom? From { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubnetSpecTags
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
public partial class V1alpha1SubnetSpecVpcRefFrom
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
public partial class V1alpha1SubnetSpecVpcRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SubnetSpecVpcRefFrom? From { get; set; }
}

/// <summary>
/// SubnetSpec defines the desired state of Subnet.
/// 
/// Describes a subnet.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubnetSpec
{
    [JsonPropertyName("assignIPv6AddressOnCreation")]
    public bool? AssignIPv6AddressOnCreation { get; set; }

    /// <summary>
    /// The Availability Zone or Local Zone for the subnet.
    /// 
    /// Default: Amazon Web Services selects one for you. If you create more than
    /// one subnet in your VPC, we do not necessarily select a different zone for
    /// each subnet.
    /// 
    /// To create a subnet in a Local Zone, set this value to the Local Zone ID,
    /// for example us-west-2-lax-1a. For information about the Regions that support
    /// Local Zones, see Available Local Zones (https://docs.aws.amazon.com/local-zones/latest/ug/available-local-zones.html).
    /// 
    /// To create a subnet in an Outpost, set this value to the Availability Zone
    /// for the Outpost and specify the Outpost ARN.
    /// </summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The AZ ID or the Local Zone ID of the subnet.</summary>
    [JsonPropertyName("availabilityZoneID")]
    public string? AvailabilityZoneID { get; set; }

    /// <summary>
    /// The IPv4 network range for the subnet, in CIDR notation. For example, 10.0.0.0/24.
    /// We modify the specified CIDR block to its canonical form; for example, if
    /// you specify 100.68.0.18/18, we modify it to 100.68.0.0/18.
    /// 
    /// This parameter is not supported for an IPv6 only subnet.
    /// </summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    [JsonPropertyName("customerOwnedIPv4Pool")]
    public string? CustomerOwnedIPv4Pool { get; set; }

    [JsonPropertyName("enableDNS64")]
    public bool? EnableDNS64 { get; set; }

    [JsonPropertyName("enableResourceNameDNSAAAARecord")]
    public bool? EnableResourceNameDNSAAAARecord { get; set; }

    [JsonPropertyName("enableResourceNameDNSARecord")]
    public bool? EnableResourceNameDNSARecord { get; set; }

    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }

    /// <summary>
    /// The IPv6 network range for the subnet, in CIDR notation. This parameter is
    /// required for an IPv6 only subnet.
    /// </summary>
    [JsonPropertyName("ipv6CIDRBlock")]
    public string? Ipv6CIDRBlock { get; set; }

    /// <summary>Indicates whether to create an IPv6 only subnet.</summary>
    [JsonPropertyName("ipv6Native")]
    public bool? Ipv6Native { get; set; }

    [JsonPropertyName("mapPublicIPOnLaunch")]
    public bool? MapPublicIPOnLaunch { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the Outpost. If you specify an Outpost
    /// ARN, you must also specify the Availability Zone of the Outpost subnet.
    /// </summary>
    [JsonPropertyName("outpostARN")]
    public string? OutpostARN { get; set; }

    [JsonPropertyName("routeTableRefs")]
    public IList<V1alpha1SubnetSpecRouteTableRefs>? RouteTableRefs { get; set; }

    [JsonPropertyName("routeTables")]
    public IList<string>? RouteTables { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1SubnetSpecTags>? Tags { get; set; }

    /// <summary>The ID of the VPC.</summary>
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
    public V1alpha1SubnetSpecVpcRef? VpcRef { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubnetStatusAckResourceMetadata
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
public partial class V1alpha1SubnetStatusConditions
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

/// <summary>Describes the state of a CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubnetStatusIpv6CIDRBlockAssociationSetIpv6CIDRBlockState
{
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>Describes an association between a subnet and an IPv6 CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubnetStatusIpv6CIDRBlockAssociationSet
{
    [JsonPropertyName("associationID")]
    public string? AssociationID { get; set; }

    [JsonPropertyName("ipv6CIDRBlock")]
    public string? Ipv6CIDRBlock { get; set; }

    /// <summary>Describes the state of a CIDR block.</summary>
    [JsonPropertyName("ipv6CIDRBlockState")]
    public V1alpha1SubnetStatusIpv6CIDRBlockAssociationSetIpv6CIDRBlockState? Ipv6CIDRBlockState { get; set; }
}

/// <summary>
/// The type of hostnames to assign to instances in the subnet at launch. An
/// instance hostname is based on the IPv4 address or ID of the instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubnetStatusPrivateDNSNameOptionsOnLaunch
{
    [JsonPropertyName("enableResourceNameDNSAAAARecord")]
    public bool? EnableResourceNameDNSAAAARecord { get; set; }

    [JsonPropertyName("enableResourceNameDNSARecord")]
    public bool? EnableResourceNameDNSARecord { get; set; }

    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

/// <summary>SubnetStatus defines the observed state of Subnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubnetStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1SubnetStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The number of unused private IPv4 addresses in the subnet. The IPv4 addresses
    /// for any stopped instances are considered unavailable.
    /// </summary>
    [JsonPropertyName("availableIPAddressCount")]
    public long? AvailableIPAddressCount { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SubnetStatusConditions>? Conditions { get; set; }

    /// <summary>Indicates whether this is the default subnet for the Availability Zone.</summary>
    [JsonPropertyName("defaultForAZ")]
    public bool? DefaultForAZ { get; set; }

    /// <summary>
    /// Indicates the device position for local network interfaces in this subnet.
    /// For example, 1 indicates local network interfaces in this subnet are the
    /// secondary network interface (eth1).
    /// </summary>
    [JsonPropertyName("enableLniAtDeviceIndex")]
    public long? EnableLniAtDeviceIndex { get; set; }

    /// <summary>Information about the IPv6 CIDR blocks associated with the subnet.</summary>
    [JsonPropertyName("ipv6CIDRBlockAssociationSet")]
    public IList<V1alpha1SubnetStatusIpv6CIDRBlockAssociationSet>? Ipv6CIDRBlockAssociationSet { get; set; }

    /// <summary>
    /// Indicates whether a network interface created in this subnet (including a
    /// network interface created by RunInstances) receives a customer-owned IPv4
    /// address.
    /// </summary>
    [JsonPropertyName("mapCustomerOwnedIPOnLaunch")]
    public bool? MapCustomerOwnedIPOnLaunch { get; set; }

    /// <summary>The ID of the Amazon Web Services account that owns the subnet.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>
    /// The type of hostnames to assign to instances in the subnet at launch. An
    /// instance hostname is based on the IPv4 address or ID of the instance.
    /// </summary>
    [JsonPropertyName("privateDNSNameOptionsOnLaunch")]
    public V1alpha1SubnetStatusPrivateDNSNameOptionsOnLaunch? PrivateDNSNameOptionsOnLaunch { get; set; }

    /// <summary>
    /// The current state of the subnet.
    /// 
    ///    * failed: The underlying infrastructure to support the subnet failed to
    ///    provision as expected.
    /// 
    ///    * failed-insufficient-capacity: The underlying infrastructure to support
    ///    the subnet failed to provision due to a shortage of EC2 instance capacity.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The ID of the subnet.</summary>
    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }
}

/// <summary>Subnet is the Schema for the Subnets API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Subnet : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SubnetSpec?>, IStatus<V1alpha1SubnetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Subnet";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "subnets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Subnet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// SubnetSpec defines the desired state of Subnet.
    /// 
    /// Describes a subnet.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1SubnetSpec? Spec { get; set; }

    /// <summary>SubnetStatus defines the observed state of Subnet</summary>
    [JsonPropertyName("status")]
    public V1alpha1SubnetStatus? Status { get; set; }
}