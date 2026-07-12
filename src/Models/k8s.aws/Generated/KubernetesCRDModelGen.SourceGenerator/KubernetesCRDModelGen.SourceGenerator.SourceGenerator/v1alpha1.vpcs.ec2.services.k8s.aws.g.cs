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
/// <summary>VPC is the Schema for the VPCS API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VPCList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VPC>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VPCList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "vpcs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPCList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VPC objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VPC> Items { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// VpcSpec defines the desired state of Vpc.
/// 
/// Describes a VPC.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCSpec
{
    /// <summary>
    /// Requests an Amazon-provided IPv6 CIDR block with a /56 prefix length for
    /// the VPC. You cannot specify the range of IP addresses, or the size of the
    /// CIDR block.
    /// </summary>
    [JsonPropertyName("amazonProvidedIPv6CIDRBlock")]
    public bool? AmazonProvidedIPv6CIDRBlock { get; set; }

    [JsonPropertyName("cidrBlocks")]
    public required IList<string> CidrBlocks { get; set; }

    [JsonPropertyName("disallowSecurityGroupDefaultRules")]
    public bool? DisallowSecurityGroupDefaultRules { get; set; }

    /// <summary>The attribute value. The valid values are true or false.</summary>
    [JsonPropertyName("enableDNSHostnames")]
    public bool? EnableDNSHostnames { get; set; }

    /// <summary>The attribute value. The valid values are true or false.</summary>
    [JsonPropertyName("enableDNSSupport")]
    public bool? EnableDNSSupport { get; set; }

    /// <summary>The attribute value. The valid values are true or false.</summary>
    [JsonPropertyName("enableNetworkAddressUsageMetrics")]
    public bool? EnableNetworkAddressUsageMetrics { get; set; }

    /// <summary>
    /// The tenancy options for instances launched into the VPC. For default, instances
    /// are launched with shared tenancy by default. You can launch instances with
    /// any tenancy into a shared tenancy VPC. For dedicated, instances are launched
    /// as dedicated tenancy instances by default. You can only launch instances
    /// with a tenancy of dedicated or host into a dedicated tenancy VPC.
    /// 
    /// Important: The host value cannot be used with this parameter. Use the default
    /// or dedicated values only.
    /// 
    /// Default: default
    /// </summary>
    [JsonPropertyName("instanceTenancy")]
    public string? InstanceTenancy { get; set; }

    /// <summary>
    /// The ID of an IPv4 IPAM pool you want to use for allocating this VPC&apos;s CIDR.
    /// For more information, see What is IPAM? (https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html)
    /// in the Amazon VPC IPAM User Guide.
    /// </summary>
    [JsonPropertyName("ipv4IPAMPoolID")]
    public string? Ipv4IPAMPoolID { get; set; }

    /// <summary>
    /// The netmask length of the IPv4 CIDR you want to allocate to this VPC from
    /// an Amazon VPC IP Address Manager (IPAM) pool. For more information about
    /// IPAM, see What is IPAM? (https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html)
    /// in the Amazon VPC IPAM User Guide.
    /// </summary>
    [JsonPropertyName("ipv4NetmaskLength")]
    public long? Ipv4NetmaskLength { get; set; }

    /// <summary>
    /// The IPv6 CIDR block from the IPv6 address pool. You must also specify Ipv6Pool
    /// in the request.
    /// 
    /// To let Amazon choose the IPv6 CIDR block for you, omit this parameter.
    /// </summary>
    [JsonPropertyName("ipv6CIDRBlock")]
    public string? Ipv6CIDRBlock { get; set; }

    /// <summary>
    /// The name of the location from which we advertise the IPV6 CIDR block. Use
    /// this parameter to limit the address to this location.
    /// 
    /// You must set AmazonProvidedIpv6CidrBlock to true to use this parameter.
    /// </summary>
    [JsonPropertyName("ipv6CIDRBlockNetworkBorderGroup")]
    public string? Ipv6CIDRBlockNetworkBorderGroup { get; set; }

    /// <summary>
    /// The ID of an IPv6 IPAM pool which will be used to allocate this VPC an IPv6
    /// CIDR. IPAM is a VPC feature that you can use to automate your IP address
    /// management workflows including assigning, tracking, troubleshooting, and
    /// auditing IP addresses across Amazon Web Services Regions and accounts throughout
    /// your Amazon Web Services Organization. For more information, see What is
    /// IPAM? (https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html)
    /// in the Amazon VPC IPAM User Guide.
    /// </summary>
    [JsonPropertyName("ipv6IPAMPoolID")]
    public string? Ipv6IPAMPoolID { get; set; }

    /// <summary>
    /// The netmask length of the IPv6 CIDR you want to allocate to this VPC from
    /// an Amazon VPC IP Address Manager (IPAM) pool. For more information about
    /// IPAM, see What is IPAM? (https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html)
    /// in the Amazon VPC IPAM User Guide.
    /// </summary>
    [JsonPropertyName("ipv6NetmaskLength")]
    public long? Ipv6NetmaskLength { get; set; }

    /// <summary>The ID of an IPv6 address pool from which to allocate the IPv6 CIDR block.</summary>
    [JsonPropertyName("ipv6Pool")]
    public string? Ipv6Pool { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1VPCSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCStatusAckResourceMetadata
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

/// <summary>Describes the state of a CIDR block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCStatusCidrBlockAssociationSetCidrBlockState
{
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>Describes an IPv4 CIDR block associated with a VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCStatusCidrBlockAssociationSet
{
    [JsonPropertyName("associationID")]
    public string? AssociationID { get; set; }

    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>Describes the state of a CIDR block.</summary>
    [JsonPropertyName("cidrBlockState")]
    public V1alpha1VPCStatusCidrBlockAssociationSetCidrBlockState? CidrBlockState { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCStatusIpv6CIDRBlockAssociationSetIpv6CIDRBlockState
{
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>Describes an IPv6 CIDR block associated with a VPC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCStatusIpv6CIDRBlockAssociationSet
{
    [JsonPropertyName("associationID")]
    public string? AssociationID { get; set; }

    [JsonPropertyName("ipv6CIDRBlock")]
    public string? Ipv6CIDRBlock { get; set; }

    /// <summary>Describes the state of a CIDR block.</summary>
    [JsonPropertyName("ipv6CIDRBlockState")]
    public V1alpha1VPCStatusIpv6CIDRBlockAssociationSetIpv6CIDRBlockState? Ipv6CIDRBlockState { get; set; }

    [JsonPropertyName("ipv6Pool")]
    public string? Ipv6Pool { get; set; }

    [JsonPropertyName("networkBorderGroup")]
    public string? NetworkBorderGroup { get; set; }
}

/// <summary>VPCStatus defines the observed state of VPC</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1VPCStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>Information about the IPv4 CIDR blocks associated with the VPC.</summary>
    [JsonPropertyName("cidrBlockAssociationSet")]
    public IList<V1alpha1VPCStatusCidrBlockAssociationSet>? CidrBlockAssociationSet { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VPCStatusConditions>? Conditions { get; set; }

    /// <summary>The ID of the set of DHCP options you&apos;ve associated with the VPC.</summary>
    [JsonPropertyName("dhcpOptionsID")]
    public string? DhcpOptionsID { get; set; }

    /// <summary>Information about the IPv6 CIDR blocks associated with the VPC.</summary>
    [JsonPropertyName("ipv6CIDRBlockAssociationSet")]
    public IList<V1alpha1VPCStatusIpv6CIDRBlockAssociationSet>? Ipv6CIDRBlockAssociationSet { get; set; }

    /// <summary>Indicates whether the VPC is the default VPC.</summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>The ID of the Amazon Web Services account that owns the VPC.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    [JsonPropertyName("securityGroupDefaultRulesExist")]
    public bool? SecurityGroupDefaultRulesExist { get; set; }

    /// <summary>The current state of the VPC.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The ID of the VPC.</summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>VPC is the Schema for the VPCS API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VPC : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VPCSpec?>, IStatus<V1alpha1VPCStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VPC";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "vpcs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPC";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// VpcSpec defines the desired state of Vpc.
    /// 
    /// Describes a VPC.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1VPCSpec? Spec { get; set; }

    /// <summary>VPCStatus defines the observed state of VPC</summary>
    [JsonPropertyName("status")]
    public V1alpha1VPCStatus? Status { get; set; }
}