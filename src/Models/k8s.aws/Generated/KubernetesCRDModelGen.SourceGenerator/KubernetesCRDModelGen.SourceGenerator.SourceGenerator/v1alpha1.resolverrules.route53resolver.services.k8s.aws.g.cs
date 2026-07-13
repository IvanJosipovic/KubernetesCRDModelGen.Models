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
/// <summary>ResolverRule is the Schema for the ResolverRules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResolverRuleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ResolverRule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResolverRuleList";
    public const string KubeGroup = "route53resolver.services.k8s.aws";
    public const string KubePluralName = "resolverrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53resolver.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResolverRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ResolverRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ResolverRule> Items { get; set; }
}

/// <summary>
/// In the response to an AssociateResolverRule (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_AssociateResolverRule.html),
/// DisassociateResolverRule (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DisassociateResolverRule.html),
/// or ListResolverRuleAssociations (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRuleAssociations.html)
/// request, provides information about an association between a Resolver rule
/// and a VPC. The association determines which DNS queries that originate in
/// the VPC are forwarded to your network.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverRuleSpecAssociations
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resolverRuleID")]
    public string? ResolverRuleID { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }

    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverRuleSpecResolverEndpointRefFrom
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
public partial class V1alpha1ResolverRuleSpecResolverEndpointRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1ResolverRuleSpecResolverEndpointRefFrom? From { get; set; }
}

/// <summary>
/// One tag that you want to add to the specified resource. A tag consists of
/// a Key (a name for the tag) and a Value.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverRuleSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// In a CreateResolverRule (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverRule.html)
/// request, an array of the IPs that you want to forward DNS queries to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverRuleSpecTargetIPs
{
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("ipv6")]
    public string? Ipv6 { get; set; }

    [JsonPropertyName("port")]
    public long? Port { get; set; }
}

/// <summary>
/// ResolverRuleSpec defines the desired state of ResolverRule.
/// 
/// For queries that originate in your VPC, detailed information about a Resolver
/// rule, which specifies how to route DNS queries out of the VPC. The ResolverRule
/// parameter appears in the response to a CreateResolverRule (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverRule.html),
/// DeleteResolverRule (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DeleteResolverRule.html),
/// GetResolverRule (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverRule.html),
/// ListResolverRules (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRules.html),
/// or UpdateResolverRule (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_UpdateResolverRule.html)
/// request.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverRuleSpec
{
    [JsonPropertyName("associations")]
    public IList<V1alpha1ResolverRuleSpecAssociations>? Associations { get; set; }

    /// <summary>
    /// DNS queries for this domain name are forwarded to the IP addresses that you
    /// specify in TargetIps. If a query matches multiple Resolver rules (example.com
    /// and www.example.com), outbound DNS queries are routed using the Resolver
    /// rule that contains the most specific domain name (www.example.com).
    /// </summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>
    /// A friendly name that lets you easily find a rule in the Resolver dashboard
    /// in the Route 53 console.
    /// 
    /// Regex Pattern: `^(?!^[0-9]+$)([a-zA-Z0-9\-_&apos; &apos;]+)$`
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the outbound Resolver endpoint that you want to use to route DNS
    /// queries to the IP addresses that you specify in TargetIps.
    /// </summary>
    [JsonPropertyName("resolverEndpointID")]
    public string? ResolverEndpointID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("resolverEndpointRef")]
    public V1alpha1ResolverRuleSpecResolverEndpointRef? ResolverEndpointRef { get; set; }

    /// <summary>
    /// When you want to forward DNS queries for specified domain name to resolvers
    /// on your network, specify FORWARD.
    /// 
    /// When you have a forwarding rule to forward DNS queries for a domain to your
    /// network and you want Resolver to process queries for a subdomain of that
    /// domain, specify SYSTEM.
    /// 
    /// For example, to forward DNS queries for example.com to resolvers on your
    /// network, you create a rule and specify FORWARD for RuleType. To then have
    /// Resolver process queries for apex.example.com, you create a rule and specify
    /// SYSTEM for RuleType.
    /// 
    /// Currently, only Resolver can create rules that have a value of RECURSIVE
    /// for RuleType.
    /// </summary>
    [JsonPropertyName("ruleType")]
    public required string RuleType { get; set; }

    /// <summary>A list of the tag keys and values that you want to associate with the endpoint.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ResolverRuleSpecTags>? Tags { get; set; }

    /// <summary>
    /// The IPs that you want Resolver to forward DNS queries to. You can specify
    /// either Ipv4 or Ipv6 addresses but not both in the same rule. Separate IP
    /// addresses with a space.
    /// 
    /// TargetIps is available only when the value of Rule type is FORWARD.
    /// </summary>
    [JsonPropertyName("targetIPs")]
    public IList<V1alpha1ResolverRuleSpecTargetIPs>? TargetIPs { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverRuleStatusAckResourceMetadata
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
public partial class V1alpha1ResolverRuleStatusConditions
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

/// <summary>ResolverRuleStatus defines the observed state of ResolverRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResolverRuleStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ResolverRuleStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ResolverRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The date and time that the Resolver rule was created, in Unix time format
    /// and Coordinated Universal Time (UTC).
    /// </summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>
    /// A unique string that you specified when you created the Resolver rule. CreatorRequestId
    /// identifies the request and allows failed requests to be retried without the
    /// risk of running the operation twice.
    /// </summary>
    [JsonPropertyName("creatorRequestID")]
    public string? CreatorRequestID { get; set; }

    /// <summary>The ID that Resolver assigned to the Resolver rule when you created it.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The date and time that the Resolver rule was last updated, in Unix time format
    /// and Coordinated Universal Time (UTC).
    /// </summary>
    [JsonPropertyName("modificationTime")]
    public string? ModificationTime { get; set; }

    /// <summary>
    /// When a rule is shared with another Amazon Web Services account, the account
    /// ID of the account that the rule is shared with.
    /// </summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>
    /// Whether the rule is shared and, if so, whether the current account is sharing
    /// the rule with another account, or another account is sharing the rule with
    /// the current account.
    /// </summary>
    [JsonPropertyName("shareStatus")]
    public string? ShareStatus { get; set; }

    /// <summary>A code that specifies the current status of the Resolver rule.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A detailed description of the status of a Resolver rule.</summary>
    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
}

/// <summary>ResolverRule is the Schema for the ResolverRules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResolverRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ResolverRuleSpec?>, IStatus<V1alpha1ResolverRuleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResolverRule";
    public const string KubeGroup = "route53resolver.services.k8s.aws";
    public const string KubePluralName = "resolverrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "route53resolver.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResolverRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ResolverRuleSpec defines the desired state of ResolverRule.
    /// 
    /// For queries that originate in your VPC, detailed information about a Resolver
    /// rule, which specifies how to route DNS queries out of the VPC. The ResolverRule
    /// parameter appears in the response to a CreateResolverRule (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverRule.html),
    /// DeleteResolverRule (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DeleteResolverRule.html),
    /// GetResolverRule (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverRule.html),
    /// ListResolverRules (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRules.html),
    /// or UpdateResolverRule (https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_UpdateResolverRule.html)
    /// request.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ResolverRuleSpec? Spec { get; set; }

    /// <summary>ResolverRuleStatus defines the observed state of ResolverRule</summary>
    [JsonPropertyName("status")]
    public V1alpha1ResolverRuleStatus? Status { get; set; }
}