#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sns.services.k8s.aws;
/// <summary>Subscription is the Schema for the Subscriptions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Subscription>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SubscriptionList";
    public const string KubeGroup = "sns.services.k8s.aws";
    public const string KubePluralName = "subscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sns.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Subscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Subscription> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubscriptionSpecSubscriptionRoleRefFrom
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
public partial class V1alpha1SubscriptionSpecSubscriptionRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SubscriptionSpecSubscriptionRoleRefFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubscriptionSpecTopicRefFrom
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
public partial class V1alpha1SubscriptionSpecTopicRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1SubscriptionSpecTopicRefFrom? From { get; set; }
}

/// <summary>
/// SubscriptionSpec defines the desired state of Subscription.
/// 
/// A wrapper type for the attributes of an Amazon SNS subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubscriptionSpec
{
    [JsonPropertyName("deliveryPolicy")]
    public string? DeliveryPolicy { get; set; }

    /// <summary>
    /// The endpoint that you want to receive notifications. Endpoints vary by protocol:
    /// 
    ///   - For the http protocol, the (public) endpoint is a URL beginning with
    ///     http://.
    /// 
    ///   - For the https protocol, the (public) endpoint is a URL beginning with
    ///     https://.
    /// 
    ///   - For the email protocol, the endpoint is an email address.
    /// 
    ///   - For the email-json protocol, the endpoint is an email address.
    /// 
    ///   - For the sms protocol, the endpoint is a phone number of an SMS-enabled
    ///     device.
    /// 
    ///   - For the sqs protocol, the endpoint is the ARN of an Amazon SQS queue.
    /// 
    ///   - For the application protocol, the endpoint is the EndpointArn of a mobile
    ///     app and device.
    /// 
    ///   - For the lambda protocol, the endpoint is the ARN of an Lambda function.
    /// 
    ///   - For the firehose protocol, the endpoint is the ARN of an Amazon Kinesis
    ///     Data Firehose delivery stream.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("filterPolicy")]
    public string? FilterPolicy { get; set; }

    [JsonPropertyName("filterPolicyScope")]
    public string? FilterPolicyScope { get; set; }

    /// <summary>
    /// The protocol that you want to use. Supported protocols include:
    /// 
    ///   - http – delivery of JSON-encoded message via HTTP POST
    /// 
    ///   - https – delivery of JSON-encoded message via HTTPS POST
    /// 
    ///   - email – delivery of message via SMTP
    /// 
    ///   - email-json – delivery of JSON-encoded message via SMTP
    /// 
    ///   - sms – delivery of message via SMS
    /// 
    ///   - sqs – delivery of JSON-encoded message to an Amazon SQS queue
    /// 
    ///   - application – delivery of JSON-encoded message to an EndpointArn for
    ///     a mobile app and device
    /// 
    ///   - lambda – delivery of JSON-encoded message to an Lambda function
    /// 
    ///   - firehose – delivery of JSON-encoded message to an Amazon Kinesis Data
    ///     Firehose delivery stream.
    /// </summary>
    [JsonPropertyName("protocol")]
    public required string Protocol { get; set; }

    [JsonPropertyName("rawMessageDelivery")]
    public string? RawMessageDelivery { get; set; }

    [JsonPropertyName("redrivePolicy")]
    public string? RedrivePolicy { get; set; }

    [JsonPropertyName("subscriptionRoleARN")]
    public string? SubscriptionRoleARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("subscriptionRoleRef")]
    public V1alpha1SubscriptionSpecSubscriptionRoleRef? SubscriptionRoleRef { get; set; }

    /// <summary>The ARN of the topic you want to subscribe to.</summary>
    [JsonPropertyName("topicARN")]
    public string? TopicARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("topicRef")]
    public V1alpha1SubscriptionSpecTopicRef? TopicRef { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubscriptionStatusAckResourceMetadata
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
public partial class V1alpha1SubscriptionStatusConditions
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

/// <summary>SubscriptionStatus defines the observed state of Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SubscriptionStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1SubscriptionStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SubscriptionStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("confirmationWasAuthenticated")]
    public string? ConfirmationWasAuthenticated { get; set; }

    [JsonPropertyName("effectiveDeliveryPolicy")]
    public string? EffectiveDeliveryPolicy { get; set; }

    [JsonPropertyName("owner")]
    public string? Owner { get; set; }

    [JsonPropertyName("pendingConfirmation")]
    public string? PendingConfirmation { get; set; }
}

/// <summary>Subscription is the Schema for the Subscriptions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Subscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SubscriptionSpec?>, IStatus<V1alpha1SubscriptionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Subscription";
    public const string KubeGroup = "sns.services.k8s.aws";
    public const string KubePluralName = "subscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sns.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Subscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// SubscriptionSpec defines the desired state of Subscription.
    /// 
    /// A wrapper type for the attributes of an Amazon SNS subscription.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1SubscriptionSpec? Spec { get; set; }

    /// <summary>SubscriptionStatus defines the observed state of Subscription</summary>
    [JsonPropertyName("status")]
    public V1alpha1SubscriptionStatus? Status { get; set; }
}