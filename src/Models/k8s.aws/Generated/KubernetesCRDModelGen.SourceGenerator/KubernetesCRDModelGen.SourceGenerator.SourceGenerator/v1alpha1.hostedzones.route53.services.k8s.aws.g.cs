#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.route53.services.k8s.aws;
/// <summary>HostedZone is the Schema for the HostedZones API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1HostedZoneList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1HostedZone>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "HostedZoneList";
    public const string KubeGroup = "route53.services.k8s.aws";
    public const string KubePluralName = "hostedzones";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HostedZoneList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1HostedZone objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1HostedZone> Items { get; set; }
}

/// <summary>
/// (Optional) A complex type that contains the following optional values:
/// 
///   - For public and private hosted zones, an optional comment
/// 
///   - For private hosted zones, an optional PrivateZone element
/// 
/// If you don&apos;t specify a comment or the PrivateZone element, omit HostedZoneConfig
/// and the other elements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HostedZoneSpecHostedZoneConfig
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("privateZone")]
    public bool? PrivateZone { get; set; }
}

/// <summary>
/// A complex type that contains information about a tag that you want to add
/// or edit for the specified health check or hosted zone.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HostedZoneSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// (Private hosted zones only) A complex type that contains information about
/// the Amazon VPC that you&apos;re associating with this hosted zone.
/// 
/// You can specify only one Amazon VPC when you create a private hosted zone.
/// If you are associating a VPC with a hosted zone with this request, the paramaters
/// VPCId and VPCRegion are also required.
/// 
/// To associate additional Amazon VPCs with the hosted zone, use AssociateVPCWithHostedZone
/// (https://docs.aws.amazon.com/Route53/latest/APIReference/API_AssociateVPCWithHostedZone.html)
/// after you create a hosted zone.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HostedZoneSpecVpc
{
    /// <summary>(Private hosted zones only) The ID of an Amazon VPC.</summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }

    [JsonPropertyName("vpcRegion")]
    public string? VpcRegion { get; set; }
}

/// <summary>
/// (Private hosted zones only) A complex type that contains information about
/// an Amazon VPC.
/// 
/// If you associate a private hosted zone with an Amazon VPC when you make a
/// CreateHostedZone (https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateHostedZone.html)
/// request, the following parameters are also required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HostedZoneSpecVpcs
{
    /// <summary>(Private hosted zones only) The ID of an Amazon VPC.</summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }

    [JsonPropertyName("vpcRegion")]
    public string? VpcRegion { get; set; }
}

/// <summary>
/// HostedZoneSpec defines the desired state of HostedZone.
/// 
/// A complex type that contains general information about the hosted zone.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HostedZoneSpec
{
    /// <summary>
    /// If you want to associate a reusable delegation set with this hosted zone,
    /// the ID that Amazon Route 53 assigned to the reusable delegation set when
    /// you created it. For more information about reusable delegation sets, see
    /// CreateReusableDelegationSet (https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateReusableDelegationSet.html).
    /// 
    /// If you are using a reusable delegation set to create a public hosted zone
    /// for a subdomain, make sure that the parent hosted zone doesn&apos;t use one or
    /// more of the same name servers. If you have overlapping nameservers, the operation
    /// will cause a ConflictingDomainsExist error.
    /// </summary>
    [JsonPropertyName("delegationSetID")]
    public string? DelegationSetID { get; set; }

    /// <summary>
    /// (Optional) A complex type that contains the following optional values:
    /// 
    ///   - For public and private hosted zones, an optional comment
    /// 
    ///   - For private hosted zones, an optional PrivateZone element
    /// 
    /// If you don&apos;t specify a comment or the PrivateZone element, omit HostedZoneConfig
    /// and the other elements.
    /// </summary>
    [JsonPropertyName("hostedZoneConfig")]
    public V1alpha1HostedZoneSpecHostedZoneConfig? HostedZoneConfig { get; set; }

    /// <summary>
    /// The name of the domain. Specify a fully qualified domain name, for example,
    /// www.example.com. The trailing dot is optional; Amazon Route 53 assumes that
    /// the domain name is fully qualified. This means that Route 53 treats www.example.com
    /// (without a trailing dot) and www.example.com. (with a trailing dot) as identical.
    /// 
    /// If you&apos;re creating a public hosted zone, this is the name you have registered
    /// with your DNS registrar. If your domain name is registered with a registrar
    /// other than Route 53, change the name servers for your domain to the set of
    /// NameServers that CreateHostedZone returns in DelegationSet.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A complex type that contains a list of the tags that you want to add to the
    /// specified health check or hosted zone and/or the tags that you want to edit
    /// Value for.
    /// 
    /// You can add a maximum of 10 tags to a health check or a hosted zone.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1HostedZoneSpecTags>? Tags { get; set; }

    /// <summary>
    /// (Private hosted zones only) A complex type that contains information about
    /// the Amazon VPC that you&apos;re associating with this hosted zone.
    /// 
    /// You can specify only one Amazon VPC when you create a private hosted zone.
    /// If you are associating a VPC with a hosted zone with this request, the paramaters
    /// VPCId and VPCRegion are also required.
    /// 
    /// To associate additional Amazon VPCs with the hosted zone, use AssociateVPCWithHostedZone
    /// (https://docs.aws.amazon.com/Route53/latest/APIReference/API_AssociateVPCWithHostedZone.html)
    /// after you create a hosted zone.
    /// </summary>
    [JsonPropertyName("vpc")]
    public V1alpha1HostedZoneSpecVpc? Vpc { get; set; }

    /// <summary>
    /// VPCs is the list of Amazon VPCs to associate with this private hosted
    /// zone. Use this field to manage all VPC associations in one place. It
    /// is mutually exclusive with spec.vpc — set one or the other, not both.
    /// The controller will reject requests that set both fields with a
    /// terminal error condition.
    /// 
    /// The first VPC in the list (spec.vpcs[0]) is used as the initial VPC
    /// when creating the hosted zone. Additional VPCs are associated after
    /// creation.
    /// </summary>
    [JsonPropertyName("vpcs")]
    public IList<V1alpha1HostedZoneSpecVpcs>? Vpcs { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HostedZoneStatusAckResourceMetadata
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
public partial class V1alpha1HostedZoneStatusConditions
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
/// A complex type that includes the Comment and PrivateZone elements. If you
/// omitted the HostedZoneConfig and Comment elements from the request, the Config
/// and Comment elements don&apos;t appear in the response.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HostedZoneStatusConfig
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("privateZone")]
    public bool? PrivateZone { get; set; }
}

/// <summary>A complex type that describes the name servers for this hosted zone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HostedZoneStatusDelegationSet
{
    [JsonPropertyName("callerReference")]
    public string? CallerReference { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nameServers")]
    public IList<string>? NameServers { get; set; }
}

/// <summary>
/// If the hosted zone was created by another service, the service that created
/// the hosted zone. When a hosted zone is created by another service, you can&apos;t
/// edit or delete it using Route 53.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HostedZoneStatusLinkedService
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("servicePrincipal")]
    public string? ServicePrincipal { get; set; }
}

/// <summary>HostedZoneStatus defines the observed state of HostedZone</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HostedZoneStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1HostedZoneStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The value that you specified for CallerReference when you created the hosted
    /// zone.
    /// </summary>
    [JsonPropertyName("callerReference")]
    public string? CallerReference { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1HostedZoneStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// A complex type that includes the Comment and PrivateZone elements. If you
    /// omitted the HostedZoneConfig and Comment elements from the request, the Config
    /// and Comment elements don&apos;t appear in the response.
    /// </summary>
    [JsonPropertyName("config")]
    public V1alpha1HostedZoneStatusConfig? Config { get; set; }

    /// <summary>A complex type that describes the name servers for this hosted zone.</summary>
    [JsonPropertyName("delegationSet")]
    public V1alpha1HostedZoneStatusDelegationSet? DelegationSet { get; set; }

    /// <summary>
    /// The ID that Amazon Route 53 assigned to the hosted zone when you created
    /// it.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// If the hosted zone was created by another service, the service that created
    /// the hosted zone. When a hosted zone is created by another service, you can&apos;t
    /// edit or delete it using Route 53.
    /// </summary>
    [JsonPropertyName("linkedService")]
    public V1alpha1HostedZoneStatusLinkedService? LinkedService { get; set; }

    /// <summary>The number of resource record sets in the hosted zone.</summary>
    [JsonPropertyName("resourceRecordSetCount")]
    public long? ResourceRecordSetCount { get; set; }
}

/// <summary>HostedZone is the Schema for the HostedZones API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1HostedZone : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1HostedZoneSpec?>, IStatus<V1alpha1HostedZoneStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "HostedZone";
    public const string KubeGroup = "route53.services.k8s.aws";
    public const string KubePluralName = "hostedzones";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HostedZone";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// HostedZoneSpec defines the desired state of HostedZone.
    /// 
    /// A complex type that contains general information about the hosted zone.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1HostedZoneSpec? Spec { get; set; }

    /// <summary>HostedZoneStatus defines the observed state of HostedZone</summary>
    [JsonPropertyName("status")]
    public V1alpha1HostedZoneStatus? Status { get; set; }
}