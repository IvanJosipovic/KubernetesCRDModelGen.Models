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
/// <summary>SecurityGroup is the Schema for the SecurityGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecurityGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecurityGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecurityGroupList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "securitygroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecurityGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecurityGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecurityGroup> Items { get; set; }
}

/// <summary>Describes an IPv4 address range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecEgressRulesIpRanges
{
    [JsonPropertyName("cidrIP")]
    public string? CidrIP { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>Describes an IPv6 address range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecEgressRulesIpv6Ranges
{
    [JsonPropertyName("cidrIPv6")]
    public string? CidrIPv6 { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>Describes a prefix list ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecEgressRulesPrefixListIDs
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("prefixListID")]
    public string? PrefixListID { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecEgressRulesUserIDGroupPairsGroupRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for GroupID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecEgressRulesUserIDGroupPairsGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SecurityGroupSpecEgressRulesUserIDGroupPairsGroupRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecEgressRulesUserIDGroupPairsVpcRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for VPCID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecEgressRulesUserIDGroupPairsVpcRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SecurityGroupSpecEgressRulesUserIDGroupPairsVpcRefFrom? From { get; set; }
}

/// <summary>Describes a security group and Amazon Web Services account ID pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecEgressRulesUserIDGroupPairs
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("groupID")]
    public string? GroupID { get; set; }

    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>Reference field for GroupID</summary>
    [JsonPropertyName("groupRef")]
    public V1alpha1SecurityGroupSpecEgressRulesUserIDGroupPairsGroupRef? GroupRef { get; set; }

    [JsonPropertyName("peeringStatus")]
    public string? PeeringStatus { get; set; }

    [JsonPropertyName("userID")]
    public string? UserID { get; set; }

    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }

    [JsonPropertyName("vpcPeeringConnectionID")]
    public string? VpcPeeringConnectionID { get; set; }

    /// <summary>Reference field for VPCID</summary>
    [JsonPropertyName("vpcRef")]
    public V1alpha1SecurityGroupSpecEgressRulesUserIDGroupPairsVpcRef? VpcRef { get; set; }
}

/// <summary>Describes the permissions for a security group rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecEgressRules
{
    [JsonPropertyName("fromPort")]
    public long? FromPort { get; set; }

    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    [JsonPropertyName("ipRanges")]
    public IList<V1alpha1SecurityGroupSpecEgressRulesIpRanges>? IpRanges { get; set; }

    [JsonPropertyName("ipv6Ranges")]
    public IList<V1alpha1SecurityGroupSpecEgressRulesIpv6Ranges>? Ipv6Ranges { get; set; }

    [JsonPropertyName("prefixListIDs")]
    public IList<V1alpha1SecurityGroupSpecEgressRulesPrefixListIDs>? PrefixListIDs { get; set; }

    [JsonPropertyName("toPort")]
    public long? ToPort { get; set; }

    [JsonPropertyName("userIDGroupPairs")]
    public IList<V1alpha1SecurityGroupSpecEgressRulesUserIDGroupPairs>? UserIDGroupPairs { get; set; }
}

/// <summary>Describes an IPv4 address range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecIngressRulesIpRanges
{
    [JsonPropertyName("cidrIP")]
    public string? CidrIP { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>Describes an IPv6 address range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecIngressRulesIpv6Ranges
{
    [JsonPropertyName("cidrIPv6")]
    public string? CidrIPv6 { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>Describes a prefix list ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecIngressRulesPrefixListIDs
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("prefixListID")]
    public string? PrefixListID { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecIngressRulesUserIDGroupPairsGroupRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for GroupID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecIngressRulesUserIDGroupPairsGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SecurityGroupSpecIngressRulesUserIDGroupPairsGroupRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecIngressRulesUserIDGroupPairsVpcRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for VPCID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecIngressRulesUserIDGroupPairsVpcRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SecurityGroupSpecIngressRulesUserIDGroupPairsVpcRefFrom? From { get; set; }
}

/// <summary>Describes a security group and Amazon Web Services account ID pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecIngressRulesUserIDGroupPairs
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("groupID")]
    public string? GroupID { get; set; }

    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>Reference field for GroupID</summary>
    [JsonPropertyName("groupRef")]
    public V1alpha1SecurityGroupSpecIngressRulesUserIDGroupPairsGroupRef? GroupRef { get; set; }

    [JsonPropertyName("peeringStatus")]
    public string? PeeringStatus { get; set; }

    [JsonPropertyName("userID")]
    public string? UserID { get; set; }

    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }

    [JsonPropertyName("vpcPeeringConnectionID")]
    public string? VpcPeeringConnectionID { get; set; }

    /// <summary>Reference field for VPCID</summary>
    [JsonPropertyName("vpcRef")]
    public V1alpha1SecurityGroupSpecIngressRulesUserIDGroupPairsVpcRef? VpcRef { get; set; }
}

/// <summary>Describes the permissions for a security group rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecIngressRules
{
    [JsonPropertyName("fromPort")]
    public long? FromPort { get; set; }

    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    [JsonPropertyName("ipRanges")]
    public IList<V1alpha1SecurityGroupSpecIngressRulesIpRanges>? IpRanges { get; set; }

    [JsonPropertyName("ipv6Ranges")]
    public IList<V1alpha1SecurityGroupSpecIngressRulesIpv6Ranges>? Ipv6Ranges { get; set; }

    [JsonPropertyName("prefixListIDs")]
    public IList<V1alpha1SecurityGroupSpecIngressRulesPrefixListIDs>? PrefixListIDs { get; set; }

    [JsonPropertyName("toPort")]
    public long? ToPort { get; set; }

    [JsonPropertyName("userIDGroupPairs")]
    public IList<V1alpha1SecurityGroupSpecIngressRulesUserIDGroupPairs>? UserIDGroupPairs { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpecTags
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
public partial class V1alpha1SecurityGroupSpecVpcRefFrom
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
public partial class V1alpha1SecurityGroupSpecVpcRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SecurityGroupSpecVpcRefFrom? From { get; set; }
}

/// <summary>
/// SecurityGroupSpec defines the desired state of SecurityGroup.
/// 
/// Describes a security group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupSpec
{
    /// <summary>
    /// A description for the security group.
    /// 
    /// Constraints: Up to 255 characters in length
    /// 
    /// Valid characters: a-z, A-Z, 0-9, spaces, and ._-:/()#,@[]+=&amp;;{}!$*
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("egressRules")]
    public IList<V1alpha1SecurityGroupSpecEgressRules>? EgressRules { get; set; }

    [JsonPropertyName("ingressRules")]
    public IList<V1alpha1SecurityGroupSpecIngressRules>? IngressRules { get; set; }

    /// <summary>
    /// The name of the security group. Names are case-insensitive and must be unique
    /// within the VPC.
    /// 
    /// Constraints: Up to 255 characters in length. Can&apos;t start with sg-.
    /// 
    /// Valid characters: a-z, A-Z, 0-9, spaces, and ._-:/()#,@[]+=&amp;;{}!$*
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1SecurityGroupSpecTags>? Tags { get; set; }

    /// <summary>The ID of the VPC. Required for a nondefault VPC.</summary>
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
    public V1alpha1SecurityGroupSpecVpcRef? VpcRef { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupStatusAckResourceMetadata
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
public partial class V1alpha1SecurityGroupStatusConditions
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

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupStatusRulesTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Describes a security group rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupStatusRules
{
    [JsonPropertyName("cidrIPv4")]
    public string? CidrIPv4 { get; set; }

    [JsonPropertyName("cidrIPv6")]
    public string? CidrIPv6 { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("fromPort")]
    public long? FromPort { get; set; }

    [JsonPropertyName("ipProtocol")]
    public string? IpProtocol { get; set; }

    [JsonPropertyName("isEgress")]
    public bool? IsEgress { get; set; }

    [JsonPropertyName("prefixListID")]
    public string? PrefixListID { get; set; }

    [JsonPropertyName("securityGroupRuleID")]
    public string? SecurityGroupRuleID { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1SecurityGroupStatusRulesTags>? Tags { get; set; }

    [JsonPropertyName("toPort")]
    public long? ToPort { get; set; }
}

/// <summary>SecurityGroupStatus defines the observed state of SecurityGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecurityGroupStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1SecurityGroupStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecurityGroupStatusConditions>? Conditions { get; set; }

    /// <summary>The ID of the security group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Information about security group rules.</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1SecurityGroupStatusRules>? Rules { get; set; }
}

/// <summary>SecurityGroup is the Schema for the SecurityGroups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecurityGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecurityGroupSpec?>, IStatus<V1alpha1SecurityGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecurityGroup";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "securitygroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecurityGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// SecurityGroupSpec defines the desired state of SecurityGroup.
    /// 
    /// Describes a security group.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1SecurityGroupSpec? Spec { get; set; }

    /// <summary>SecurityGroupStatus defines the observed state of SecurityGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecurityGroupStatus? Status { get; set; }
}