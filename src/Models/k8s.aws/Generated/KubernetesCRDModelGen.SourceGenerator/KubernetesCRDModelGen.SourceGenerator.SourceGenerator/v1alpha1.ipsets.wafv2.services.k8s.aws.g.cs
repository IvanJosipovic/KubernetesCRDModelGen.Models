#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.wafv2.services.k8s.aws;
/// <summary>IPSet is the Schema for the IPSets API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IPSetList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1IPSet>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IPSetList";
    public const string KubeGroup = "wafv2.services.k8s.aws";
    public const string KubePluralName = "ipsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "wafv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IPSetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1IPSet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1IPSet> Items { get; set; }
}

/// <summary>
/// A tag associated with an Amazon Web Services resource. Tags are key:value
/// pairs that you can use to categorize and manage your resources, for purposes
/// like billing or other management. Typically, the tag key represents a category,
/// such as &quot;environment&quot;, and the tag value represents a specific value within
/// that category, such as &quot;test,&quot; &quot;development,&quot; or &quot;production&quot;. Or you might
/// set the tag key to &quot;customer&quot; and the value to the customer name or ID. You
/// can specify one or more tags to add to each Amazon Web Services resource,
/// up to 50 tags for a resource.
/// 
/// You can tag the Amazon Web Services resources that you manage through WAF:
/// web ACLs, rule groups, IP sets, and regex pattern sets. You can&apos;t manage
/// or view tags through the WAF console.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IPSetSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// IPSetSpec defines the desired state of IPSet.
/// 
/// Contains zero or more IP addresses or blocks of IP addresses specified in
/// Classless Inter-Domain Routing (CIDR) notation. WAF supports all IPv4 and
/// IPv6 CIDR ranges except for /0. For information about CIDR notation, see
/// the Wikipedia entry Classless Inter-Domain Routing (https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing).
/// 
/// WAF assigns an ARN to each IPSet that you create. To use an IP set in a rule,
/// you provide the ARN to the Rule statement IPSetReferenceStatement.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IPSetSpec
{
    /// <summary>
    /// Contains an array of strings that specifies zero or more IP addresses or
    /// blocks of IP addresses that you want WAF to inspect for in incoming requests.
    /// All addresses must be specified using Classless Inter-Domain Routing (CIDR)
    /// notation. WAF supports all IPv4 and IPv6 CIDR ranges except for /0.
    /// 
    /// Example address strings:
    /// 
    ///   - For requests that originated from the IP address 192.0.2.44, specify
    ///     192.0.2.44/32.
    /// 
    ///   - For requests that originated from IP addresses from 192.0.2.0 to 192.0.2.255,
    ///     specify 192.0.2.0/24.
    /// 
    ///   - For requests that originated from the IP address 1111:0000:0000:0000:0000:0000:0000:0111,
    ///     specify 1111:0000:0000:0000:0000:0000:0000:0111/128.
    /// 
    ///   - For requests that originated from IP addresses 1111:0000:0000:0000:0000:0000:0000:0000
    ///     to 1111:0000:0000:0000:ffff:ffff:ffff:ffff, specify 1111:0000:0000:0000:0000:0000:0000:0000/64.
    /// 
    /// For more information about CIDR notation, see the Wikipedia entry Classless
    /// Inter-Domain Routing (https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing).
    /// 
    /// Example JSON Addresses specifications:
    /// 
    ///   - Empty array: &quot;Addresses&quot;: []
    /// 
    ///   - Array with one address: &quot;Addresses&quot;: [&quot;192.0.2.44/32&quot;]
    /// 
    ///   - Array with three addresses: &quot;Addresses&quot;: [&quot;192.0.2.44/32&quot;, &quot;192.0.2.0/24&quot;,
    ///     &quot;192.0.0.0/16&quot;]
    /// 
    ///   - INVALID specification: &quot;Addresses&quot;: [&quot; &quot;] INVALID
    /// </summary>
    [JsonPropertyName("addresses")]
    public required IList<string> Addresses { get; set; }

    /// <summary>
    /// A description of the IP set that helps with identification.
    /// 
    /// Regex Pattern: `^[\w+=:#@/\-,\.][\w+=:#@/\-,\.\s]+[\w+=:#@/\-,\.]$`
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The version of the IP addresses, either IPV4 or IPV6.</summary>
    [JsonPropertyName("ipAddressVersion")]
    public required string IpAddressVersion { get; set; }

    /// <summary>
    /// The name of the IP set. You cannot change the name of an IPSet after you
    /// create it.
    /// 
    /// Regex Pattern: `^[\w\-]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Specifies whether this is for an Amazon CloudFront distribution or for a
    /// regional application. A regional application can be an Application Load Balancer
    /// (ALB), an Amazon API Gateway REST API, an AppSync GraphQL API, an Amazon
    /// Cognito user pool, an App Runner service, or an Amazon Web Services Verified
    /// Access instance.
    /// 
    /// To work with CloudFront, you must also specify the Region US East (N. Virginia)
    /// as follows:
    /// 
    ///   - CLI - Specify the Region when you use the CloudFront scope: --scope=CLOUDFRONT
    ///     --region=us-east-1.
    /// 
    ///   - API and SDKs - For all calls, use the Region endpoint us-east-1.
    /// </summary>
    [JsonPropertyName("scope")]
    public required string Scope { get; set; }

    /// <summary>An array of key:value pairs to associate with the resource.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1IPSetSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IPSetStatusAckResourceMetadata
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
public partial class V1alpha1IPSetStatusConditions
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

/// <summary>IPSetStatus defines the observed state of IPSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IPSetStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1IPSetStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1IPSetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// A unique identifier for the set. This ID is returned in the responses to
    /// create and list commands. You provide it to operations like update and delete.
    /// 
    /// Regex Pattern: `^[0-9a-f]{8}-(?:[0-9a-f]{4}-){3}[0-9a-f]{12}$`
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A token used for optimistic locking. WAF returns a token to your get and
    /// list requests, to mark the state of the entity at the time of the request.
    /// To make changes to the entity associated with the token, you provide the
    /// token to operations like update and delete. WAF uses the token to ensure
    /// that no changes have been made to the entity since you last retrieved it.
    /// If a change has been made, the update fails with a WAFOptimisticLockException.
    /// If this happens, perform another get, and use the new token returned by that
    /// operation.
    /// 
    /// Regex Pattern: `^[0-9a-f]{8}-(?:[0-9a-f]{4}-){3}[0-9a-f]{12}$`
    /// </summary>
    [JsonPropertyName("lockToken")]
    public string? LockToken { get; set; }
}

/// <summary>IPSet is the Schema for the IPSets API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IPSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IPSetSpec?>, IStatus<V1alpha1IPSetStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IPSet";
    public const string KubeGroup = "wafv2.services.k8s.aws";
    public const string KubePluralName = "ipsets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "wafv2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "IPSet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// IPSetSpec defines the desired state of IPSet.
    /// 
    /// Contains zero or more IP addresses or blocks of IP addresses specified in
    /// Classless Inter-Domain Routing (CIDR) notation. WAF supports all IPv4 and
    /// IPv6 CIDR ranges except for /0. For information about CIDR notation, see
    /// the Wikipedia entry Classless Inter-Domain Routing (https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing).
    /// 
    /// WAF assigns an ARN to each IPSet that you create. To use an IP set in a rule,
    /// you provide the ARN to the Rule statement IPSetReferenceStatement.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1IPSetSpec? Spec { get; set; }

    /// <summary>IPSetStatus defines the observed state of IPSet</summary>
    [JsonPropertyName("status")]
    public V1alpha1IPSetStatus? Status { get; set; }
}