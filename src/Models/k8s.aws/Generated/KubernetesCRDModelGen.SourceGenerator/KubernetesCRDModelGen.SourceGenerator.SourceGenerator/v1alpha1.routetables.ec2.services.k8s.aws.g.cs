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
/// <summary>RouteTable is the Schema for the RouteTables API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RouteTableList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1RouteTable>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RouteTableList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "routetables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RouteTableList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1RouteTable objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1RouteTable> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecRoutesGatewayRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for GatewayID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecRoutesGatewayRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RouteTableSpecRoutesGatewayRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecRoutesNatGatewayRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for NATGatewayID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecRoutesNatGatewayRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RouteTableSpecRoutesNatGatewayRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecRoutesTransitGatewayRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for TransitGatewayID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecRoutesTransitGatewayRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RouteTableSpecRoutesTransitGatewayRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecRoutesVpcEndpointRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for VPCEndpointID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecRoutesVpcEndpointRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RouteTableSpecRoutesVpcEndpointRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecRoutesVpcPeeringConnectionRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for VPCPeeringConnectionID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecRoutesVpcPeeringConnectionRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RouteTableSpecRoutesVpcPeeringConnectionRefFrom? From { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecRoutes
{
    [JsonPropertyName("carrierGatewayID")]
    public string? CarrierGatewayID { get; set; }

    [JsonPropertyName("coreNetworkARN")]
    public string? CoreNetworkARN { get; set; }

    [JsonPropertyName("destinationCIDRBlock")]
    public string? DestinationCIDRBlock { get; set; }

    [JsonPropertyName("destinationIPv6CIDRBlock")]
    public string? DestinationIPv6CIDRBlock { get; set; }

    [JsonPropertyName("destinationPrefixListID")]
    public string? DestinationPrefixListID { get; set; }

    [JsonPropertyName("egressOnlyInternetGatewayID")]
    public string? EgressOnlyInternetGatewayID { get; set; }

    [JsonPropertyName("gatewayID")]
    public string? GatewayID { get; set; }

    /// <summary>Reference field for GatewayID</summary>
    [JsonPropertyName("gatewayRef")]
    public V1alpha1RouteTableSpecRoutesGatewayRef? GatewayRef { get; set; }

    [JsonPropertyName("instanceID")]
    public string? InstanceID { get; set; }

    [JsonPropertyName("localGatewayID")]
    public string? LocalGatewayID { get; set; }

    [JsonPropertyName("natGatewayID")]
    public string? NatGatewayID { get; set; }

    /// <summary>Reference field for NATGatewayID</summary>
    [JsonPropertyName("natGatewayRef")]
    public V1alpha1RouteTableSpecRoutesNatGatewayRef? NatGatewayRef { get; set; }

    [JsonPropertyName("networkInterfaceID")]
    public string? NetworkInterfaceID { get; set; }

    [JsonPropertyName("transitGatewayID")]
    public string? TransitGatewayID { get; set; }

    /// <summary>Reference field for TransitGatewayID</summary>
    [JsonPropertyName("transitGatewayRef")]
    public V1alpha1RouteTableSpecRoutesTransitGatewayRef? TransitGatewayRef { get; set; }

    [JsonPropertyName("vpcEndpointID")]
    public string? VpcEndpointID { get; set; }

    /// <summary>Reference field for VPCEndpointID</summary>
    [JsonPropertyName("vpcEndpointRef")]
    public V1alpha1RouteTableSpecRoutesVpcEndpointRef? VpcEndpointRef { get; set; }

    [JsonPropertyName("vpcPeeringConnectionID")]
    public string? VpcPeeringConnectionID { get; set; }

    /// <summary>Reference field for VPCPeeringConnectionID</summary>
    [JsonPropertyName("vpcPeeringConnectionRef")]
    public V1alpha1RouteTableSpecRoutesVpcPeeringConnectionRef? VpcPeeringConnectionRef { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpecTags
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
public partial class V1alpha1RouteTableSpecVpcRefFrom
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
public partial class V1alpha1RouteTableSpecVpcRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1RouteTableSpecVpcRefFrom? From { get; set; }
}

/// <summary>
/// RouteTableSpec defines the desired state of RouteTable.
/// 
/// Describes a route table.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableSpec
{
    [JsonPropertyName("routes")]
    public IList<V1alpha1RouteTableSpecRoutes>? Routes { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1RouteTableSpecTags>? Tags { get; set; }

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
    public V1alpha1RouteTableSpecVpcRef? VpcRef { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableStatusAckResourceMetadata
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
/// Describes the state of an association between a route table and a subnet
/// or gateway.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableStatusAssociationsAssociationState
{
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>Describes an association between a route table and a subnet or gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableStatusAssociations
{
    /// <summary>
    /// Describes the state of an association between a route table and a subnet
    /// or gateway.
    /// </summary>
    [JsonPropertyName("associationState")]
    public V1alpha1RouteTableStatusAssociationsAssociationState? AssociationState { get; set; }

    [JsonPropertyName("gatewayID")]
    public string? GatewayID { get; set; }

    [JsonPropertyName("main")]
    public bool? Main { get; set; }

    [JsonPropertyName("routeTableAssociationID")]
    public string? RouteTableAssociationID { get; set; }

    [JsonPropertyName("routeTableID")]
    public string? RouteTableID { get; set; }

    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableStatusConditions
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

/// <summary>Describes a virtual private gateway propagating route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableStatusPropagatingVGWs
{
    [JsonPropertyName("gatewayID")]
    public string? GatewayID { get; set; }
}

/// <summary>Describes a route in a route table.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableStatusRouteStatuses
{
    [JsonPropertyName("carrierGatewayID")]
    public string? CarrierGatewayID { get; set; }

    [JsonPropertyName("coreNetworkARN")]
    public string? CoreNetworkARN { get; set; }

    [JsonPropertyName("destinationCIDRBlock")]
    public string? DestinationCIDRBlock { get; set; }

    [JsonPropertyName("destinationIPv6CIDRBlock")]
    public string? DestinationIPv6CIDRBlock { get; set; }

    [JsonPropertyName("destinationPrefixListID")]
    public string? DestinationPrefixListID { get; set; }

    [JsonPropertyName("egressOnlyInternetGatewayID")]
    public string? EgressOnlyInternetGatewayID { get; set; }

    [JsonPropertyName("gatewayID")]
    public string? GatewayID { get; set; }

    [JsonPropertyName("instanceID")]
    public string? InstanceID { get; set; }

    [JsonPropertyName("instanceOwnerID")]
    public string? InstanceOwnerID { get; set; }

    [JsonPropertyName("localGatewayID")]
    public string? LocalGatewayID { get; set; }

    [JsonPropertyName("natGatewayID")]
    public string? NatGatewayID { get; set; }

    [JsonPropertyName("networkInterfaceID")]
    public string? NetworkInterfaceID { get; set; }

    [JsonPropertyName("origin")]
    public string? Origin { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("transitGatewayID")]
    public string? TransitGatewayID { get; set; }

    [JsonPropertyName("vpcPeeringConnectionID")]
    public string? VpcPeeringConnectionID { get; set; }
}

/// <summary>RouteTableStatus defines the observed state of RouteTable</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RouteTableStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1RouteTableStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The associations between the route table and your subnets or gateways.</summary>
    [JsonPropertyName("associations")]
    public IList<V1alpha1RouteTableStatusAssociations>? Associations { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RouteTableStatusConditions>? Conditions { get; set; }

    /// <summary>The ID of the Amazon Web Services account that owns the route table.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>Any virtual private gateway (VGW) propagating routes.</summary>
    [JsonPropertyName("propagatingVGWs")]
    public IList<V1alpha1RouteTableStatusPropagatingVGWs>? PropagatingVGWs { get; set; }

    /// <summary>The routes in the route table.</summary>
    [JsonPropertyName("routeStatuses")]
    public IList<V1alpha1RouteTableStatusRouteStatuses>? RouteStatuses { get; set; }

    /// <summary>The ID of the route table.</summary>
    [JsonPropertyName("routeTableID")]
    public string? RouteTableID { get; set; }
}

/// <summary>RouteTable is the Schema for the RouteTables API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RouteTable : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RouteTableSpec?>, IStatus<V1alpha1RouteTableStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RouteTable";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "routetables";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RouteTable";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// RouteTableSpec defines the desired state of RouteTable.
    /// 
    /// Describes a route table.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1RouteTableSpec? Spec { get; set; }

    /// <summary>RouteTableStatus defines the observed state of RouteTable</summary>
    [JsonPropertyName("status")]
    public V1alpha1RouteTableStatus? Status { get; set; }
}