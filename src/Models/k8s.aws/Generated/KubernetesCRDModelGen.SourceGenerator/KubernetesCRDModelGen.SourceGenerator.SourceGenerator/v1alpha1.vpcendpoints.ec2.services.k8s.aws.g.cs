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
/// <summary>VPCEndpoint is the Schema for the VPCEndpoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VPCEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VPCEndpoint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VPCEndpointList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "vpcendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPCEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VPCEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VPCEndpoint> Items { get; set; }
}

/// <summary>The DNS options for the endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointSpecDnsOptions
{
    [JsonPropertyName("dnsRecordIPType")]
    public string? DnsRecordIPType { get; set; }

    [JsonPropertyName("privateDNSPreference")]
    public string? PrivateDNSPreference { get; set; }

    [JsonPropertyName("privateDNSSpecifiedDomains")]
    public IList<string>? PrivateDNSSpecifiedDomains { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointSpecRouteTableRefsFrom
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
public partial class V1alpha1VPCEndpointSpecRouteTableRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1VPCEndpointSpecRouteTableRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointSpecSecurityGroupRefsFrom
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
public partial class V1alpha1VPCEndpointSpecSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1VPCEndpointSpecSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointSpecSubnetRefsFrom
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
public partial class V1alpha1VPCEndpointSpecSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1VPCEndpointSpecSubnetRefsFrom? From { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointSpecTags
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
public partial class V1alpha1VPCEndpointSpecVpcRefFrom
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
public partial class V1alpha1VPCEndpointSpecVpcRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1VPCEndpointSpecVpcRefFrom? From { get; set; }
}

/// <summary>
/// VpcEndpointSpec defines the desired state of VpcEndpoint.
/// 
/// Describes a VPC endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointSpec
{
    /// <summary>The DNS options for the endpoint.</summary>
    [JsonPropertyName("dnsOptions")]
    public V1alpha1VPCEndpointSpecDnsOptions? DnsOptions { get; set; }

    /// <summary>The IP address type for the endpoint.</summary>
    [JsonPropertyName("ipAddressType")]
    public string? IpAddressType { get; set; }

    /// <summary>
    /// (Interface and gateway endpoints) A policy to attach to the endpoint that
    /// controls access to the service. The policy must be in valid JSON format.
    /// If this parameter is not specified, we attach a default policy that allows
    /// full access to the service.
    /// </summary>
    [JsonPropertyName("policyDocument")]
    public string? PolicyDocument { get; set; }

    /// <summary>
    /// (Interface endpoint) Indicates whether to associate a private hosted zone
    /// with the specified VPC. The private hosted zone contains a record set for
    /// the default public DNS name for the service for the Region (for example,
    /// kinesis.us-east-1.amazonaws.com), which resolves to the private IP addresses
    /// of the endpoint network interfaces in the VPC. This enables you to make requests
    /// to the default public DNS name for the service instead of the public DNS
    /// names that are automatically generated by the VPC endpoint service.
    /// 
    /// To use a private hosted zone, you must set the following VPC attributes to
    /// true: enableDnsHostnames and enableDnsSupport. Use ModifyVpcAttribute to
    /// set the VPC attributes.
    /// </summary>
    [JsonPropertyName("privateDNSEnabled")]
    public bool? PrivateDNSEnabled { get; set; }

    /// <summary>(Gateway endpoint) The route table IDs.</summary>
    [JsonPropertyName("routeTableIDs")]
    public IList<string>? RouteTableIDs { get; set; }

    [JsonPropertyName("routeTableRefs")]
    public IList<V1alpha1VPCEndpointSpecRouteTableRefs>? RouteTableRefs { get; set; }

    /// <summary>
    /// (Interface endpoint) The IDs of the security groups to associate with the
    /// endpoint network interfaces. If this parameter is not specified, we use the
    /// default security group for the VPC.
    /// </summary>
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1VPCEndpointSpecSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>The name of the endpoint service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of a service network that will be associated
    /// with the VPC endpoint of type service-network.
    /// </summary>
    [JsonPropertyName("serviceNetworkARN")]
    public string? ServiceNetworkARN { get; set; }

    /// <summary>The Region where the service is hosted. The default is the current Region.</summary>
    [JsonPropertyName("serviceRegion")]
    public string? ServiceRegion { get; set; }

    /// <summary>
    /// (Interface and Gateway Load Balancer endpoints) The IDs of the subnets in
    /// which to create endpoint network interfaces. For a Gateway Load Balancer
    /// endpoint, you can specify only one subnet.
    /// </summary>
    [JsonPropertyName("subnetIDs")]
    public IList<string>? SubnetIDs { get; set; }

    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1VPCEndpointSpecSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1VPCEndpointSpecTags>? Tags { get; set; }

    /// <summary>
    /// The type of endpoint.
    /// 
    /// Default: Gateway
    /// </summary>
    [JsonPropertyName("vpcEndpointType")]
    public string? VpcEndpointType { get; set; }

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
    public V1alpha1VPCEndpointSpecVpcRef? VpcRef { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointStatusAckResourceMetadata
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
public partial class V1alpha1VPCEndpointStatusConditions
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

/// <summary>Describes a DNS entry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointStatusDnsEntries
{
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    [JsonPropertyName("hostedZoneID")]
    public string? HostedZoneID { get; set; }
}

/// <summary>Describes a security group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointStatusGroups
{
    [JsonPropertyName("groupID")]
    public string? GroupID { get; set; }

    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }
}

/// <summary>The last error that occurred for endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointStatusLastError
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>VPCEndpointStatus defines the observed state of VPCEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1VPCEndpointStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VPCEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>The date and time that the endpoint was created.</summary>
    [JsonPropertyName("creationTimestamp")]
    public DateTime? CreationTimestamp { get; set; }

    /// <summary>(Interface endpoint) The DNS entries for the endpoint.</summary>
    [JsonPropertyName("dnsEntries")]
    public IList<V1alpha1VPCEndpointStatusDnsEntries>? DnsEntries { get; set; }

    /// <summary>
    /// (Interface endpoint) Information about the security groups that are associated
    /// with the network interface.
    /// </summary>
    [JsonPropertyName("groups")]
    public IList<V1alpha1VPCEndpointStatusGroups>? Groups { get; set; }

    /// <summary>The last error that occurred for endpoint.</summary>
    [JsonPropertyName("lastError")]
    public V1alpha1VPCEndpointStatusLastError? LastError { get; set; }

    /// <summary>(Interface endpoint) The network interfaces for the endpoint.</summary>
    [JsonPropertyName("networkInterfaceIDs")]
    public IList<string>? NetworkInterfaceIDs { get; set; }

    /// <summary>The ID of the Amazon Web Services account that owns the endpoint.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>Indicates whether the endpoint is being managed by its service.</summary>
    [JsonPropertyName("requesterManaged")]
    public bool? RequesterManaged { get; set; }

    /// <summary>The state of the endpoint.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The ID of the endpoint.</summary>
    [JsonPropertyName("vpcEndpointID")]
    public string? VpcEndpointID { get; set; }
}

/// <summary>VPCEndpoint is the Schema for the VPCEndpoints API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VPCEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VPCEndpointSpec?>, IStatus<V1alpha1VPCEndpointStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VPCEndpoint";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "vpcendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPCEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// VpcEndpointSpec defines the desired state of VpcEndpoint.
    /// 
    /// Describes a VPC endpoint.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1VPCEndpointSpec? Spec { get; set; }

    /// <summary>VPCEndpointStatus defines the observed state of VPCEndpoint</summary>
    [JsonPropertyName("status")]
    public V1alpha1VPCEndpointStatus? Status { get; set; }
}