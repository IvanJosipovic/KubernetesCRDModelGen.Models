#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicebus.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /servicebus/resource-manager/Microsoft.ServiceBus/ServiceBus/stable/2024-01-01/subscriptions.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240101NamespacesTopicsSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1api20240101NamespacesTopicsSubscription>
{
    public const string KubeApiVersion = "v1api20240101";
    public const string KubeKind = "NamespacesTopicsSubscriptionList";
    public const string KubeGroup = "servicebus.azure.com";
    public const string KubePluralName = "namespacestopicssubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicebus.azure.com/v1api20240101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacesTopicsSubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240101NamespacesTopicsSubscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240101NamespacesTopicsSubscription> Items { get; set; }
}

/// <summary>ClientAffineProperties: Properties specific to client affine subscriptions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101NamespacesTopicsSubscriptionSpecClientAffineProperties
{
    /// <summary>ClientId: Indicates the Client ID of the application that created the client-affine subscription.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>IsDurable: For client-affine subscriptions, this value indicates whether the subscription is durable or not.</summary>
    [JsonPropertyName("isDurable")]
    public bool? IsDurable { get; set; }

    /// <summary>IsShared: For client-affine subscriptions, this value indicates whether the subscription is shared or not.</summary>
    [JsonPropertyName("isShared")]
    public bool? IsShared { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101NamespacesTopicsSubscriptionSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101NamespacesTopicsSubscriptionSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101NamespacesTopicsSubscriptionSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240101NamespacesTopicsSubscriptionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240101NamespacesTopicsSubscriptionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a servicebus.azure.com/NamespacesTopic resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101NamespacesTopicsSubscriptionSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101NamespacesTopicsSubscriptionSpec
{
    /// <summary>
    /// AutoDeleteOnIdle: ISO 8061 timeSpan idle interval after which the topic is automatically deleted. The minimum duration
    /// is 5 minutes.
    /// </summary>
    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>ClientAffineProperties: Properties specific to client affine subscriptions.</summary>
    [JsonPropertyName("clientAffineProperties")]
    public V1api20240101NamespacesTopicsSubscriptionSpecClientAffineProperties? ClientAffineProperties { get; set; }

    /// <summary>
    /// DeadLetteringOnFilterEvaluationExceptions: Value that indicates whether a subscription has dead letter support on filter
    /// evaluation exceptions.
    /// </summary>
    [JsonPropertyName("deadLetteringOnFilterEvaluationExceptions")]
    public bool? DeadLetteringOnFilterEvaluationExceptions { get; set; }

    /// <summary>
    /// DeadLetteringOnMessageExpiration: Value that indicates whether a subscription has dead letter support when a message
    /// expires.
    /// </summary>
    [JsonPropertyName("deadLetteringOnMessageExpiration")]
    public bool? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary>
    /// DefaultMessageTimeToLive: ISO 8061 Default message timespan to live value. This is the duration after which the message
    /// expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not
    /// set on a message itself.
    /// </summary>
    [JsonPropertyName("defaultMessageTimeToLive")]
    public string? DefaultMessageTimeToLive { get; set; }

    /// <summary>
    /// DuplicateDetectionHistoryTimeWindow: ISO 8601 timeSpan structure that defines the duration of the duplicate detection
    /// history. The default value is 10 minutes.
    /// </summary>
    [JsonPropertyName("duplicateDetectionHistoryTimeWindow")]
    public string? DuplicateDetectionHistoryTimeWindow { get; set; }

    /// <summary>EnableBatchedOperations: Value that indicates whether server-side batched operations are enabled.</summary>
    [JsonPropertyName("enableBatchedOperations")]
    public bool? EnableBatchedOperations { get; set; }

    /// <summary>ForwardDeadLetteredMessagesTo: Queue/Topic name to forward the Dead Letter message</summary>
    [JsonPropertyName("forwardDeadLetteredMessagesTo")]
    public string? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary>ForwardTo: Queue/Topic name to forward the messages</summary>
    [JsonPropertyName("forwardTo")]
    public string? ForwardTo { get; set; }

    /// <summary>IsClientAffine: Value that indicates whether the subscription has an affinity to the client id.</summary>
    [JsonPropertyName("isClientAffine")]
    public bool? IsClientAffine { get; set; }

    /// <summary>LockDuration: ISO 8061 lock duration timespan for the subscription. The default value is 1 minute.</summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>MaxDeliveryCount: Number of maximum deliveries.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240101NamespacesTopicsSubscriptionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a servicebus.azure.com/NamespacesTopic resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240101NamespacesTopicsSubscriptionSpecOwner Owner { get; set; }

    /// <summary>RequiresSession: Value indicating if a subscription supports the concept of sessions.</summary>
    [JsonPropertyName("requiresSession")]
    public bool? RequiresSession { get; set; }
}

/// <summary>ClientAffineProperties: Properties specific to client affine subscriptions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101NamespacesTopicsSubscriptionStatusClientAffineProperties
{
    /// <summary>ClientId: Indicates the Client ID of the application that created the client-affine subscription.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>IsDurable: For client-affine subscriptions, this value indicates whether the subscription is durable or not.</summary>
    [JsonPropertyName("isDurable")]
    public bool? IsDurable { get; set; }

    /// <summary>IsShared: For client-affine subscriptions, this value indicates whether the subscription is shared or not.</summary>
    [JsonPropertyName("isShared")]
    public bool? IsShared { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101NamespacesTopicsSubscriptionStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>CountDetails: Message count details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101NamespacesTopicsSubscriptionStatusCountDetails
{
    /// <summary>ActiveMessageCount: Number of active messages in the queue, topic, or subscription.</summary>
    [JsonPropertyName("activeMessageCount")]
    public int? ActiveMessageCount { get; set; }

    /// <summary>DeadLetterMessageCount: Number of messages that are dead lettered.</summary>
    [JsonPropertyName("deadLetterMessageCount")]
    public int? DeadLetterMessageCount { get; set; }

    /// <summary>ScheduledMessageCount: Number of scheduled messages.</summary>
    [JsonPropertyName("scheduledMessageCount")]
    public int? ScheduledMessageCount { get; set; }

    /// <summary>TransferDeadLetterMessageCount: Number of messages transferred into dead letters.</summary>
    [JsonPropertyName("transferDeadLetterMessageCount")]
    public int? TransferDeadLetterMessageCount { get; set; }

    /// <summary>TransferMessageCount: Number of messages transferred to another queue, topic, or subscription.</summary>
    [JsonPropertyName("transferMessageCount")]
    public int? TransferMessageCount { get; set; }
}

/// <summary>SystemData: The system meta data relating to this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101NamespacesTopicsSubscriptionStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240101NamespacesTopicsSubscriptionStatus
{
    /// <summary>AccessedAt: Last time there was a receive request to this subscription.</summary>
    [JsonPropertyName("accessedAt")]
    public string? AccessedAt { get; set; }

    /// <summary>
    /// AutoDeleteOnIdle: ISO 8061 timeSpan idle interval after which the topic is automatically deleted. The minimum duration
    /// is 5 minutes.
    /// </summary>
    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>ClientAffineProperties: Properties specific to client affine subscriptions.</summary>
    [JsonPropertyName("clientAffineProperties")]
    public V1api20240101NamespacesTopicsSubscriptionStatusClientAffineProperties? ClientAffineProperties { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240101NamespacesTopicsSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>CountDetails: Message count details</summary>
    [JsonPropertyName("countDetails")]
    public V1api20240101NamespacesTopicsSubscriptionStatusCountDetails? CountDetails { get; set; }

    /// <summary>CreatedAt: Exact time the message was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>
    /// DeadLetteringOnFilterEvaluationExceptions: Value that indicates whether a subscription has dead letter support on filter
    /// evaluation exceptions.
    /// </summary>
    [JsonPropertyName("deadLetteringOnFilterEvaluationExceptions")]
    public bool? DeadLetteringOnFilterEvaluationExceptions { get; set; }

    /// <summary>
    /// DeadLetteringOnMessageExpiration: Value that indicates whether a subscription has dead letter support when a message
    /// expires.
    /// </summary>
    [JsonPropertyName("deadLetteringOnMessageExpiration")]
    public bool? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary>
    /// DefaultMessageTimeToLive: ISO 8061 Default message timespan to live value. This is the duration after which the message
    /// expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not
    /// set on a message itself.
    /// </summary>
    [JsonPropertyName("defaultMessageTimeToLive")]
    public string? DefaultMessageTimeToLive { get; set; }

    /// <summary>
    /// DuplicateDetectionHistoryTimeWindow: ISO 8601 timeSpan structure that defines the duration of the duplicate detection
    /// history. The default value is 10 minutes.
    /// </summary>
    [JsonPropertyName("duplicateDetectionHistoryTimeWindow")]
    public string? DuplicateDetectionHistoryTimeWindow { get; set; }

    /// <summary>EnableBatchedOperations: Value that indicates whether server-side batched operations are enabled.</summary>
    [JsonPropertyName("enableBatchedOperations")]
    public bool? EnableBatchedOperations { get; set; }

    /// <summary>ForwardDeadLetteredMessagesTo: Queue/Topic name to forward the Dead Letter message</summary>
    [JsonPropertyName("forwardDeadLetteredMessagesTo")]
    public string? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary>ForwardTo: Queue/Topic name to forward the messages</summary>
    [JsonPropertyName("forwardTo")]
    public string? ForwardTo { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsClientAffine: Value that indicates whether the subscription has an affinity to the client id.</summary>
    [JsonPropertyName("isClientAffine")]
    public bool? IsClientAffine { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>LockDuration: ISO 8061 lock duration timespan for the subscription. The default value is 1 minute.</summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>MaxDeliveryCount: Number of maximum deliveries.</summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    /// <summary>MessageCount: Number of messages.</summary>
    [JsonPropertyName("messageCount")]
    public int? MessageCount { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RequiresSession: Value indicating if a subscription supports the concept of sessions.</summary>
    [JsonPropertyName("requiresSession")]
    public bool? RequiresSession { get; set; }

    /// <summary>Status: Enumerates the possible values for the status of a messaging entity.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>SystemData: The system meta data relating to this resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240101NamespacesTopicsSubscriptionStatusSystemData? SystemData { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.EventHub/Namespaces&quot; or &quot;Microsoft.EventHub/Namespaces/EventHubs&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpdatedAt: The exact time the message was updated.</summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /servicebus/resource-manager/Microsoft.ServiceBus/ServiceBus/stable/2024-01-01/subscriptions.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}/subscriptions/{subscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240101NamespacesTopicsSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240101NamespacesTopicsSubscriptionSpec?>, IStatus<V1api20240101NamespacesTopicsSubscriptionStatus?>
{
    public const string KubeApiVersion = "v1api20240101";
    public const string KubeKind = "NamespacesTopicsSubscription";
    public const string KubeGroup = "servicebus.azure.com";
    public const string KubePluralName = "namespacestopicssubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicebus.azure.com/v1api20240101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacesTopicsSubscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240101NamespacesTopicsSubscriptionSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20240101NamespacesTopicsSubscriptionStatus? Status { get; set; }
}