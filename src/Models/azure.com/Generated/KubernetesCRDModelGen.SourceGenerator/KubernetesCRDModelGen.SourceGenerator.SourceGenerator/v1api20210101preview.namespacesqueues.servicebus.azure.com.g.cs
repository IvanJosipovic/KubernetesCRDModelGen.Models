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
/// - Generated from: /servicebus/resource-manager/Microsoft.ServiceBus/ServiceBus/preview/2021-01-01-preview/Queue.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210101previewNamespacesQueueList : IKubernetesObject<V1ListMeta>, IItems<V1api20210101previewNamespacesQueue>
{
    public const string KubeApiVersion = "v1api20210101preview";
    public const string KubeKind = "NamespacesQueueList";
    public const string KubeGroup = "servicebus.azure.com";
    public const string KubePluralName = "namespacesqueues";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicebus.azure.com/v1api20210101preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacesQueueList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210101previewNamespacesQueue objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210101previewNamespacesQueue> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210101previewNamespacesQueueSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210101previewNamespacesQueueSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210101previewNamespacesQueueSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210101previewNamespacesQueueSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210101previewNamespacesQueueSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a servicebus.azure.com/Namespace resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210101previewNamespacesQueueSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210101previewNamespacesQueueSpec
{
    /// <summary>
    /// AutoDeleteOnIdle: ISO 8061 timeSpan idle interval after which the queue is automatically deleted. The minimum duration
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

    /// <summary>
    /// DeadLetteringOnMessageExpiration: A value that indicates whether this queue has dead letter support when a message
    /// expires.
    /// </summary>
    [JsonPropertyName("deadLetteringOnMessageExpiration")]
    public bool? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary>
    /// DefaultMessageTimeToLive: ISO 8601 default message timespan to live value. This is the duration after which the message
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

    /// <summary>
    /// EnableExpress: A value that indicates whether Express Entities are enabled. An express queue holds a message in memory
    /// temporarily before writing it to persistent storage.
    /// </summary>
    [JsonPropertyName("enableExpress")]
    public bool? EnableExpress { get; set; }

    /// <summary>EnablePartitioning: A value that indicates whether the queue is to be partitioned across multiple message brokers.</summary>
    [JsonPropertyName("enablePartitioning")]
    public bool? EnablePartitioning { get; set; }

    /// <summary>ForwardDeadLetteredMessagesTo: Queue/Topic name to forward the Dead Letter message</summary>
    [JsonPropertyName("forwardDeadLetteredMessagesTo")]
    public string? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary>ForwardTo: Queue/Topic name to forward the messages</summary>
    [JsonPropertyName("forwardTo")]
    public string? ForwardTo { get; set; }

    /// <summary>
    /// LockDuration: ISO 8601 timespan duration of a peek-lock; that is, the amount of time that the message is locked for
    /// other receivers. The maximum value for LockDuration is 5 minutes; the default value is 1 minute.
    /// </summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>
    /// MaxDeliveryCount: The maximum delivery count. A message is automatically deadlettered after this number of deliveries.
    /// default value is 10.
    /// </summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    /// <summary>
    /// MaxSizeInMegabytes: The maximum size of the queue in megabytes, which is the size of memory allocated for the queue.
    /// Default is 1024.
    /// </summary>
    [JsonPropertyName("maxSizeInMegabytes")]
    public int? MaxSizeInMegabytes { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210101previewNamespacesQueueSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a servicebus.azure.com/Namespace resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210101previewNamespacesQueueSpecOwner Owner { get; set; }

    /// <summary>RequiresDuplicateDetection: A value indicating if this queue requires duplicate detection.</summary>
    [JsonPropertyName("requiresDuplicateDetection")]
    public bool? RequiresDuplicateDetection { get; set; }

    /// <summary>RequiresSession: A value that indicates whether the queue supports the concept of sessions.</summary>
    [JsonPropertyName("requiresSession")]
    public bool? RequiresSession { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210101previewNamespacesQueueStatusConditions
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

/// <summary>CountDetails: Message Count Details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210101previewNamespacesQueueStatusCountDetails
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210101previewNamespacesQueueStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210101previewNamespacesQueueStatus
{
    /// <summary>AccessedAt: Last time a message was sent, or the last time there was a receive request to this queue.</summary>
    [JsonPropertyName("accessedAt")]
    public string? AccessedAt { get; set; }

    /// <summary>
    /// AutoDeleteOnIdle: ISO 8061 timeSpan idle interval after which the queue is automatically deleted. The minimum duration
    /// is 5 minutes.
    /// </summary>
    [JsonPropertyName("autoDeleteOnIdle")]
    public string? AutoDeleteOnIdle { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210101previewNamespacesQueueStatusConditions>? Conditions { get; set; }

    /// <summary>CountDetails: Message Count Details.</summary>
    [JsonPropertyName("countDetails")]
    public V1api20210101previewNamespacesQueueStatusCountDetails? CountDetails { get; set; }

    /// <summary>CreatedAt: The exact time the message was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>
    /// DeadLetteringOnMessageExpiration: A value that indicates whether this queue has dead letter support when a message
    /// expires.
    /// </summary>
    [JsonPropertyName("deadLetteringOnMessageExpiration")]
    public bool? DeadLetteringOnMessageExpiration { get; set; }

    /// <summary>
    /// DefaultMessageTimeToLive: ISO 8601 default message timespan to live value. This is the duration after which the message
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

    /// <summary>
    /// EnableExpress: A value that indicates whether Express Entities are enabled. An express queue holds a message in memory
    /// temporarily before writing it to persistent storage.
    /// </summary>
    [JsonPropertyName("enableExpress")]
    public bool? EnableExpress { get; set; }

    /// <summary>EnablePartitioning: A value that indicates whether the queue is to be partitioned across multiple message brokers.</summary>
    [JsonPropertyName("enablePartitioning")]
    public bool? EnablePartitioning { get; set; }

    /// <summary>ForwardDeadLetteredMessagesTo: Queue/Topic name to forward the Dead Letter message</summary>
    [JsonPropertyName("forwardDeadLetteredMessagesTo")]
    public string? ForwardDeadLetteredMessagesTo { get; set; }

    /// <summary>ForwardTo: Queue/Topic name to forward the messages</summary>
    [JsonPropertyName("forwardTo")]
    public string? ForwardTo { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// LockDuration: ISO 8601 timespan duration of a peek-lock; that is, the amount of time that the message is locked for
    /// other receivers. The maximum value for LockDuration is 5 minutes; the default value is 1 minute.
    /// </summary>
    [JsonPropertyName("lockDuration")]
    public string? LockDuration { get; set; }

    /// <summary>
    /// MaxDeliveryCount: The maximum delivery count. A message is automatically deadlettered after this number of deliveries.
    /// default value is 10.
    /// </summary>
    [JsonPropertyName("maxDeliveryCount")]
    public int? MaxDeliveryCount { get; set; }

    /// <summary>
    /// MaxSizeInMegabytes: The maximum size of the queue in megabytes, which is the size of memory allocated for the queue.
    /// Default is 1024.
    /// </summary>
    [JsonPropertyName("maxSizeInMegabytes")]
    public int? MaxSizeInMegabytes { get; set; }

    /// <summary>MessageCount: The number of messages in the queue.</summary>
    [JsonPropertyName("messageCount")]
    public int? MessageCount { get; set; }

    /// <summary>Name: Resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>RequiresDuplicateDetection: A value indicating if this queue requires duplicate detection.</summary>
    [JsonPropertyName("requiresDuplicateDetection")]
    public bool? RequiresDuplicateDetection { get; set; }

    /// <summary>RequiresSession: A value that indicates whether the queue supports the concept of sessions.</summary>
    [JsonPropertyName("requiresSession")]
    public bool? RequiresSession { get; set; }

    /// <summary>SizeInBytes: The size of the queue, in bytes.</summary>
    [JsonPropertyName("sizeInBytes")]
    public int? SizeInBytes { get; set; }

    /// <summary>Status: Enumerates the possible values for the status of a messaging entity.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>SystemData: The system meta data relating to this resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20210101previewNamespacesQueueStatusSystemData? SystemData { get; set; }

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpdatedAt: The exact time the message was updated.</summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /servicebus/resource-manager/Microsoft.ServiceBus/ServiceBus/preview/2021-01-01-preview/Queue.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210101previewNamespacesQueue : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210101previewNamespacesQueueSpec?>, IStatus<V1api20210101previewNamespacesQueueStatus?>
{
    public const string KubeApiVersion = "v1api20210101preview";
    public const string KubeKind = "NamespacesQueue";
    public const string KubeGroup = "servicebus.azure.com";
    public const string KubePluralName = "namespacesqueues";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "servicebus.azure.com/v1api20210101preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacesQueue";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210101previewNamespacesQueueSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20210101previewNamespacesQueueStatus? Status { get; set; }
}