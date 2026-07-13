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
/// <summary>NATGateway is the Schema for the NATGateways API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NATGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NATGateway>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NATGatewayList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "natgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NATGatewayList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NATGateway objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NATGateway> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NATGatewaySpecAllocationRefFrom
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
public partial class V1alpha1NATGatewaySpecAllocationRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1NATGatewaySpecAllocationRefFrom? From { get; set; }
}

/// <summary>
/// For regional NAT gateways only: The configuration specifying which Elastic
/// IP address (EIP) to use for handling outbound NAT traffic from a specific
/// Availability Zone.
/// 
/// A regional NAT gateway is a single NAT Gateway that works across multiple
/// availability zones (AZs) in your VPC, providing redundancy, scalability and
/// availability across all the AZs in a Region.
/// 
/// For more information, see Regional NAT gateways for automatic multi-AZ expansion
/// (https://docs.aws.amazon.com/vpc/latest/userguide/nat-gateways-regional.html)
/// in the Amazon VPC User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NATGatewaySpecAvailabilityZoneAddresses
{
    [JsonPropertyName("allocationIDs")]
    public IList<string>? AllocationIDs { get; set; }

    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("availabilityZoneID")]
    public string? AvailabilityZoneID { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NATGatewaySpecSubnetRefFrom
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
public partial class V1alpha1NATGatewaySpecSubnetRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1NATGatewaySpecSubnetRefFrom? From { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NATGatewaySpecTags
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
public partial class V1alpha1NATGatewaySpecVpcRefFrom
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
public partial class V1alpha1NATGatewaySpecVpcRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1NATGatewaySpecVpcRefFrom? From { get; set; }
}

/// <summary>
/// NatGatewaySpec defines the desired state of NatGateway.
/// 
/// Describes a NAT gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NATGatewaySpec
{
    /// <summary>
    /// [Public NAT gateways only] The allocation ID of an Elastic IP address to
    /// associate with the NAT gateway. You cannot specify an Elastic IP address
    /// with a private NAT gateway. If the Elastic IP address is associated with
    /// another resource, you must first disassociate it.
    /// </summary>
    [JsonPropertyName("allocationID")]
    public string? AllocationID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("allocationRef")]
    public V1alpha1NATGatewaySpecAllocationRef? AllocationRef { get; set; }

    /// <summary>
    /// Specifies whether to create a zonal (single-AZ) or regional (multi-AZ) NAT
    /// gateway. Defaults to zonal.
    /// 
    /// A zonal NAT gateway is a NAT Gateway that provides redundancy and scalability
    /// within a single availability zone. A regional NAT gateway is a single NAT
    /// Gateway that works across multiple availability zones (AZs) in your VPC,
    /// providing redundancy, scalability and availability across all the AZs in
    /// a Region.
    /// 
    /// For more information, see Regional NAT gateways for automatic multi-AZ expansion
    /// (https://docs.aws.amazon.com/vpc/latest/userguide/nat-gateways-regional.html)
    /// in the Amazon VPC User Guide.
    /// </summary>
    [JsonPropertyName("availabilityMode")]
    public string? AvailabilityMode { get; set; }

    /// <summary>
    /// For regional NAT gateways only: Specifies which Availability Zones you want
    /// the NAT gateway to support and the Elastic IP addresses (EIPs) to use in
    /// each AZ. The regional NAT gateway uses these EIPs to handle outbound NAT
    /// traffic from their respective AZs. If not specified, the NAT gateway will
    /// automatically expand to new AZs and associate EIPs upon detection of an elastic
    /// network interface. If you specify this parameter, auto-expansion is disabled
    /// and you must manually manage AZ coverage.
    /// 
    /// A regional NAT gateway is a single NAT Gateway that works across multiple
    /// availability zones (AZs) in your VPC, providing redundancy, scalability and
    /// availability across all the AZs in a Region.
    /// 
    /// For more information, see Regional NAT gateways for automatic multi-AZ expansion
    /// (https://docs.aws.amazon.com/vpc/latest/userguide/nat-gateways-regional.html)
    /// in the Amazon VPC User Guide.
    /// </summary>
    [JsonPropertyName("availabilityZoneAddresses")]
    public IList<V1alpha1NATGatewaySpecAvailabilityZoneAddresses>? AvailabilityZoneAddresses { get; set; }

    /// <summary>
    /// Indicates whether the NAT gateway supports public or private connectivity.
    /// The default is public connectivity.
    /// </summary>
    [JsonPropertyName("connectivityType")]
    public string? ConnectivityType { get; set; }

    /// <summary>The ID of the subnet in which to create the NAT gateway.</summary>
    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("subnetRef")]
    public V1alpha1NATGatewaySpecSubnetRef? SubnetRef { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1NATGatewaySpecTags>? Tags { get; set; }

    /// <summary>The ID of the VPC where you want to create a regional NAT gateway.</summary>
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
    public V1alpha1NATGatewaySpecVpcRef? VpcRef { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NATGatewayStatusAckResourceMetadata
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
public partial class V1alpha1NATGatewayStatusConditions
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

/// <summary>Describes the IP addresses and network interface associated with a NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NATGatewayStatusNatGatewayAddresses
{
    [JsonPropertyName("allocationID")]
    public string? AllocationID { get; set; }

    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("availabilityZoneID")]
    public string? AvailabilityZoneID { get; set; }

    [JsonPropertyName("networkInterfaceID")]
    public string? NetworkInterfaceID { get; set; }

    [JsonPropertyName("privateIP")]
    public string? PrivateIP { get; set; }

    [JsonPropertyName("publicIP")]
    public string? PublicIP { get; set; }
}

/// <summary>
/// Reserved. If you need to sustain traffic greater than the documented limits
/// (https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html#vpc-limits-gateways),
/// contact Amazon Web Services Support.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NATGatewayStatusProvisionedBandwidth
{
    [JsonPropertyName("provisionTime")]
    public DateTime? ProvisionTime { get; set; }

    [JsonPropertyName("provisioned")]
    public string? Provisioned { get; set; }

    [JsonPropertyName("requestTime")]
    public DateTime? RequestTime { get; set; }

    [JsonPropertyName("requested")]
    public string? Requested { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>NATGatewayStatus defines the observed state of NATGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NATGatewayStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1NATGatewayStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NATGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time the NAT gateway was created.</summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>The date and time the NAT gateway was deleted, if applicable.</summary>
    [JsonPropertyName("deleteTime")]
    public DateTime? DeleteTime { get; set; }

    /// <summary>
    /// If the NAT gateway could not be created, specifies the error code for the
    /// failure. (InsufficientFreeAddressesInSubnet | Gateway.NotAttached | InvalidAllocationID.NotFound
    /// | Resource.AlreadyAssociated | InternalError | InvalidSubnetID.NotFound)
    /// </summary>
    [JsonPropertyName("failureCode")]
    public string? FailureCode { get; set; }

    /// <summary>
    /// If the NAT gateway could not be created, specifies the error message for
    /// the failure, that corresponds to the error code.
    /// 
    ///    * For InsufficientFreeAddressesInSubnet: &quot;Subnet has insufficient free
    ///    addresses to create this NAT gateway&quot;
    /// 
    ///    * For Gateway.NotAttached: &quot;Network vpc-xxxxxxxx has no Internet gateway
    ///    attached&quot;
    /// 
    ///    * For InvalidAllocationID.NotFound: &quot;Elastic IP address eipalloc-xxxxxxxx
    ///    could not be associated with this NAT gateway&quot;
    /// 
    ///    * For Resource.AlreadyAssociated: &quot;Elastic IP address eipalloc-xxxxxxxx
    ///    is already associated&quot;
    /// 
    ///    * For InternalError: &quot;Network interface eni-xxxxxxxx, created and used
    ///    internally by this NAT gateway is in an invalid state. Please try again.&quot;
    /// 
    ///    * For InvalidSubnetID.NotFound: &quot;The specified subnet subnet-xxxxxxxx
    ///    does not exist or could not be found.&quot;
    /// </summary>
    [JsonPropertyName("failureMessage")]
    public string? FailureMessage { get; set; }

    /// <summary>
    /// Information about the IP addresses and network interface associated with
    /// the NAT gateway.
    /// </summary>
    [JsonPropertyName("natGatewayAddresses")]
    public IList<V1alpha1NATGatewayStatusNatGatewayAddresses>? NatGatewayAddresses { get; set; }

    /// <summary>The ID of the NAT gateway.</summary>
    [JsonPropertyName("natGatewayID")]
    public string? NatGatewayID { get; set; }

    /// <summary>
    /// Reserved. If you need to sustain traffic greater than the documented limits
    /// (https://docs.aws.amazon.com/vpc/latest/userguide/amazon-vpc-limits.html#vpc-limits-gateways),
    /// contact Amazon Web Services Support.
    /// </summary>
    [JsonPropertyName("provisionedBandwidth")]
    public V1alpha1NATGatewayStatusProvisionedBandwidth? ProvisionedBandwidth { get; set; }

    /// <summary>
    /// The state of the NAT gateway.
    /// 
    ///    * pending: The NAT gateway is being created and is not ready to process
    ///    traffic.
    /// 
    ///    * failed: The NAT gateway could not be created. Check the failureCode
    ///    and failureMessage fields for the reason.
    /// 
    ///    * available: The NAT gateway is able to process traffic. This status remains
    ///    until you delete the NAT gateway, and does not indicate the health of
    ///    the NAT gateway.
    /// 
    ///    * deleting: The NAT gateway is in the process of being terminated and
    ///    may still be processing traffic.
    /// 
    ///    * deleted: The NAT gateway has been terminated and is no longer processing
    ///    traffic.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The ID of the VPC in which the NAT gateway is located.</summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>NATGateway is the Schema for the NATGateways API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NATGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NATGatewaySpec?>, IStatus<V1alpha1NATGatewayStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NATGateway";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "natgateways";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NATGateway";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// NatGatewaySpec defines the desired state of NatGateway.
    /// 
    /// Describes a NAT gateway.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1NATGatewaySpec? Spec { get; set; }

    /// <summary>NATGatewayStatus defines the observed state of NATGateway</summary>
    [JsonPropertyName("status")]
    public V1alpha1NATGatewayStatus? Status { get; set; }
}