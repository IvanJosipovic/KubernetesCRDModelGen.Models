#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudwatchlogs.services.k8s.aws;
/// <summary>ResourcePolicy is the Schema for the ResourcePolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResourcePolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ResourcePolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResourcePolicyList";
    public const string KubeGroup = "cloudwatchlogs.services.k8s.aws";
    public const string KubePluralName = "resourcepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudwatchlogs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourcePolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ResourcePolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ResourcePolicy> Items { get; set; }
}

/// <summary>
/// ResourcePolicySpec defines the desired state of ResourcePolicy.
/// 
/// A policy enabling one or more entities to put logs to a log group in this
/// account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourcePolicySpec
{
    /// <summary>
    /// Details of the new policy, including the identity of the principal that is
    /// enabled to put logs to this account. This is formatted as a JSON string.
    /// This parameter is required.
    /// 
    /// The following example creates a resource policy enabling the Route 53 service
    /// to put DNS query logs in to the specified log group. Replace &quot;logArn&quot; with
    /// the ARN of your CloudWatch Logs resource, such as a log group or log stream.
    /// 
    /// CloudWatch Logs also supports aws:SourceArn (https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_condition-keys.html#condition-keys-sourcearn)
    /// and aws:SourceAccount (https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_condition-keys.html#condition-keys-sourceaccount)
    /// condition context keys.
    /// 
    /// In the example resource policy, you would replace the value of SourceArn
    /// with the resource making the call from Route 53 to CloudWatch Logs. You would
    /// also replace the value of SourceAccount with the Amazon Web Services account
    /// ID making that call.
    /// 
    /// { &quot;Version&quot;: &quot;2012-10-17&quot;, &quot;Statement&quot;: [ { &quot;Sid&quot;: &quot;Route53LogsToCloudWatchLogs&quot;,
    /// &quot;Effect&quot;: &quot;Allow&quot;, &quot;Principal&quot;: { &quot;Service&quot;: [ &quot;route53.amazonaws.com&quot; ]
    /// }, &quot;Action&quot;: &quot;logs:PutLogEvents&quot;, &quot;Resource&quot;: &quot;logArn&quot;, &quot;Condition&quot;: { &quot;ArnLike&quot;:
    /// { &quot;aws:SourceArn&quot;: &quot;myRoute53ResourceArn&quot; }, &quot;StringEquals&quot;: { &quot;aws:SourceAccount&quot;:
    /// &quot;myAwsAccountId&quot; } } } ] }
    /// </summary>
    [JsonPropertyName("policyDocument")]
    public string? PolicyDocument { get; set; }

    /// <summary>Name of the new policy. This parameter is required.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>
    /// The ARN of the CloudWatch Logs resource to which the resource policy needs
    /// to be added or attached. Currently only supports LogGroup ARN.
    /// </summary>
    [JsonPropertyName("resourceARN")]
    public string? ResourceARN { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourcePolicyStatusAckResourceMetadata
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
public partial class V1alpha1ResourcePolicyStatusConditions
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

/// <summary>ResourcePolicyStatus defines the observed state of ResourcePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ResourcePolicyStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ResourcePolicyStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ResourcePolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Timestamp showing when this policy was last updated, expressed as the number
    /// of milliseconds after Jan 1, 1970 00:00:00 UTC.
    /// </summary>
    [JsonPropertyName("lastUpdatedTime")]
    public long? LastUpdatedTime { get; set; }

    /// <summary>Specifies scope of the resource policy. Valid values are ACCOUNT or RESOURCE.</summary>
    [JsonPropertyName("policyScope")]
    public string? PolicyScope { get; set; }

    /// <summary>
    /// The revision ID of the resource policy. Only populated for resource-scoped
    /// policies.
    /// </summary>
    [JsonPropertyName("revisionID")]
    public string? RevisionID { get; set; }
}

/// <summary>ResourcePolicy is the Schema for the ResourcePolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ResourcePolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ResourcePolicySpec?>, IStatus<V1alpha1ResourcePolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ResourcePolicy";
    public const string KubeGroup = "cloudwatchlogs.services.k8s.aws";
    public const string KubePluralName = "resourcepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudwatchlogs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ResourcePolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ResourcePolicySpec defines the desired state of ResourcePolicy.
    /// 
    /// A policy enabling one or more entities to put logs to a log group in this
    /// account.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ResourcePolicySpec? Spec { get; set; }

    /// <summary>ResourcePolicyStatus defines the observed state of ResourcePolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1ResourcePolicyStatus? Status { get; set; }
}