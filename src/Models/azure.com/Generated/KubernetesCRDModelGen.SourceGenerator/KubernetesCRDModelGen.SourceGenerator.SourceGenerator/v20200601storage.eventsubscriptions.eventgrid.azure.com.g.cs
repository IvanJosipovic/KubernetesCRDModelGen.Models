#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventgrid.azure.com;
/// <summary>
/// Storage version of v20200601.EventSubscription
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2020-06-01/EventGrid.json
/// - ARM URI: /{scope}/providers/Microsoft.EventGrid/eventSubscriptions/{eventSubscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20200601storageEventSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V20200601storageEventSubscription>
{
    public const string KubeApiVersion = "v20200601storage";
    public const string KubeKind = "EventSubscriptionList";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "eventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20200601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20200601storageEventSubscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20200601storageEventSubscription> Items { get; set; }
}

/// <summary>ResourceReference: The Azure Resource ID of the storage account that is the destination of the deadletter events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDeadLetterDestinationStorageBlobResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20200601.StorageBlobDeadLetterDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDeadLetterDestinationStorageBlob
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobContainerName")]
    public string? BlobContainerName { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceReference: The Azure Resource ID of the storage account that is the destination of the deadletter events</summary>
    [JsonPropertyName("resourceReference")]
    public V20200601storageEventSubscriptionSpecDeadLetterDestinationStorageBlobResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20200601.DeadLetterDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDeadLetterDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20200601.StorageBlobDeadLetterDestination</summary>
    [JsonPropertyName("storageBlob")]
    public V20200601storageEventSubscriptionSpecDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Azure Function destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationAzureFunctionResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20200601.AzureFunctionEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationAzureFunction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Azure Function destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20200601storageEventSubscriptionSpecDestinationAzureFunctionResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationEventHubResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20200601.EventHubEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationEventHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20200601storageEventSubscriptionSpecDestinationEventHubResourceReference? ResourceReference { get; set; }
}

/// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationHybridConnectionResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20200601.HybridConnectionEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationHybridConnection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
    [JsonPropertyName("resourceReference")]
    public V20200601storageEventSubscriptionSpecDestinationHybridConnectionResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationServiceBusQueueResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20200601.ServiceBusQueueEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationServiceBusQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20200601storageEventSubscriptionSpecDestinationServiceBusQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationServiceBusTopicResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20200601.ServiceBusTopicEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationServiceBusTopic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20200601storageEventSubscriptionSpecDestinationServiceBusTopicResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource ID of the storage account that contains the queue that is the destination of an
/// event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationStorageQueueResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20200601.StorageQueueEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationStorageQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource ID of the storage account that contains the queue that is the destination of an
    /// event subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20200601storageEventSubscriptionSpecDestinationStorageQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationWebHookEndpointUrl
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Storage version of v20200601.WebHookEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestinationWebHook
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUri")]
    public string? AzureActiveDirectoryApplicationIdOrUri { get; set; }

    [JsonPropertyName("azureActiveDirectoryTenantId")]
    public string? AzureActiveDirectoryTenantId { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("endpointUrl")]
    public V20200601storageEventSubscriptionSpecDestinationWebHookEndpointUrl? EndpointUrl { get; set; }

    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>Storage version of v20200601.EventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20200601.AzureFunctionEventSubscriptionDestination</summary>
    [JsonPropertyName("azureFunction")]
    public V20200601storageEventSubscriptionSpecDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>Storage version of v20200601.EventHubEventSubscriptionDestination</summary>
    [JsonPropertyName("eventHub")]
    public V20200601storageEventSubscriptionSpecDestinationEventHub? EventHub { get; set; }

    /// <summary>Storage version of v20200601.HybridConnectionEventSubscriptionDestination</summary>
    [JsonPropertyName("hybridConnection")]
    public V20200601storageEventSubscriptionSpecDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>Storage version of v20200601.ServiceBusQueueEventSubscriptionDestination</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V20200601storageEventSubscriptionSpecDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>Storage version of v20200601.ServiceBusTopicEventSubscriptionDestination</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V20200601storageEventSubscriptionSpecDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>Storage version of v20200601.StorageQueueEventSubscriptionDestination</summary>
    [JsonPropertyName("storageQueue")]
    public V20200601storageEventSubscriptionSpecDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>Storage version of v20200601.WebHookEventSubscriptionDestination</summary>
    [JsonPropertyName("webHook")]
    public V20200601storageEventSubscriptionSpecDestinationWebHook? WebHook { get; set; }
}

/// <summary>Storage version of v20200601.BoolEqualsAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersBoolEquals
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>Storage version of v20200601.NumberGreaterThanAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThan
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Storage version of v20200601.NumberGreaterThanOrEqualsAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEquals
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Storage version of v20200601.NumberInAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberIn
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary>Storage version of v20200601.NumberLessThanAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberLessThan
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Storage version of v20200601.NumberLessThanOrEqualsAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEquals
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Storage version of v20200601.NumberNotInAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberNotIn
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary>Storage version of v20200601.StringBeginsWithAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersStringBeginsWith
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v20200601.StringContainsAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersStringContains
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v20200601.StringEndsWithAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersStringEndsWith
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v20200601.StringInAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersStringIn
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v20200601.StringNotInAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFiltersStringNotIn
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v20200601.AdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilterAdvancedFilters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20200601.BoolEqualsAdvancedFilter</summary>
    [JsonPropertyName("boolEquals")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersBoolEquals? BoolEquals { get; set; }

    /// <summary>Storage version of v20200601.NumberGreaterThanAdvancedFilter</summary>
    [JsonPropertyName("numberGreaterThan")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThan? NumberGreaterThan { get; set; }

    /// <summary>Storage version of v20200601.NumberGreaterThanOrEqualsAdvancedFilter</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEquals? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Storage version of v20200601.NumberInAdvancedFilter</summary>
    [JsonPropertyName("numberIn")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberIn? NumberIn { get; set; }

    /// <summary>Storage version of v20200601.NumberLessThanAdvancedFilter</summary>
    [JsonPropertyName("numberLessThan")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberLessThan? NumberLessThan { get; set; }

    /// <summary>Storage version of v20200601.NumberLessThanOrEqualsAdvancedFilter</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEquals? NumberLessThanOrEquals { get; set; }

    /// <summary>Storage version of v20200601.NumberNotInAdvancedFilter</summary>
    [JsonPropertyName("numberNotIn")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersNumberNotIn? NumberNotIn { get; set; }

    /// <summary>Storage version of v20200601.StringBeginsWithAdvancedFilter</summary>
    [JsonPropertyName("stringBeginsWith")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersStringBeginsWith? StringBeginsWith { get; set; }

    /// <summary>Storage version of v20200601.StringContainsAdvancedFilter</summary>
    [JsonPropertyName("stringContains")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersStringContains? StringContains { get; set; }

    /// <summary>Storage version of v20200601.StringEndsWithAdvancedFilter</summary>
    [JsonPropertyName("stringEndsWith")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersStringEndsWith? StringEndsWith { get; set; }

    /// <summary>Storage version of v20200601.StringInAdvancedFilter</summary>
    [JsonPropertyName("stringIn")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersStringIn? StringIn { get; set; }

    /// <summary>Storage version of v20200601.StringNotInAdvancedFilter</summary>
    [JsonPropertyName("stringNotIn")]
    public V20200601storageEventSubscriptionSpecFilterAdvancedFiltersStringNotIn? StringNotIn { get; set; }
}

/// <summary>
/// Storage version of v20200601.EventSubscriptionFilter
/// Filter for the Event Subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecFilter
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("advancedFilters")]
    public IList<V20200601storageEventSubscriptionSpecFilterAdvancedFilters>? AdvancedFilters { get; set; }

    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }

    [JsonPropertyName("isSubjectCaseSensitive")]
    public bool? IsSubjectCaseSensitive { get; set; }

    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecOperatorSpecConfigMapExpressions
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
public partial class V20200601storageEventSubscriptionSpecOperatorSpecSecretExpressions
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
/// Storage version of v20200601.EventSubscriptionOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20200601storageEventSubscriptionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20200601storageEventSubscriptionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
/// extension resource, which means that any other Azure resource can be its owner.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecOwner
{
    /// <summary>Ownership across namespaces is not supported.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20200601.RetryPolicy
/// Information about the retry policy for an event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpecRetryPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("eventTimeToLiveInMinutes")]
    public int? EventTimeToLiveInMinutes { get; set; }

    [JsonPropertyName("maxDeliveryAttempts")]
    public int? MaxDeliveryAttempts { get; set; }
}

/// <summary>Storage version of v20200601.EventSubscription_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v20200601.DeadLetterDestination</summary>
    [JsonPropertyName("deadLetterDestination")]
    public V20200601storageEventSubscriptionSpecDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>Storage version of v20200601.EventSubscriptionDestination</summary>
    [JsonPropertyName("destination")]
    public V20200601storageEventSubscriptionSpecDestination? Destination { get; set; }

    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>
    /// Storage version of v20200601.EventSubscriptionFilter
    /// Filter for the Event Subscription.
    /// </summary>
    [JsonPropertyName("filter")]
    public V20200601storageEventSubscriptionSpecFilter? Filter { get; set; }

    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>
    /// Storage version of v20200601.EventSubscriptionOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20200601storageEventSubscriptionSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
    /// extension resource, which means that any other Azure resource can be its owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20200601storageEventSubscriptionSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20200601.RetryPolicy
    /// Information about the retry policy for an event subscription.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V20200601storageEventSubscriptionSpecRetryPolicy? RetryPolicy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusConditions
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

/// <summary>Storage version of v20200601.StorageBlobDeadLetterDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusDeadLetterDestinationStorageBlob
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobContainerName")]
    public string? BlobContainerName { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20200601.DeadLetterDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusDeadLetterDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20200601.StorageBlobDeadLetterDestination_STATUS</summary>
    [JsonPropertyName("storageBlob")]
    public V20200601storageEventSubscriptionStatusDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>Storage version of v20200601.AzureFunctionEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusDestinationAzureFunction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20200601.EventHubEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusDestinationEventHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20200601.HybridConnectionEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusDestinationHybridConnection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20200601.ServiceBusQueueEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusDestinationServiceBusQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20200601.ServiceBusTopicEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusDestinationServiceBusTopic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20200601.StorageQueueEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusDestinationStorageQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20200601.WebHookEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusDestinationWebHook
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUri")]
    public string? AzureActiveDirectoryApplicationIdOrUri { get; set; }

    [JsonPropertyName("azureActiveDirectoryTenantId")]
    public string? AzureActiveDirectoryTenantId { get; set; }

    [JsonPropertyName("endpointBaseUrl")]
    public string? EndpointBaseUrl { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>Storage version of v20200601.EventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20200601.AzureFunctionEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("azureFunction")]
    public V20200601storageEventSubscriptionStatusDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>Storage version of v20200601.EventHubEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("eventHub")]
    public V20200601storageEventSubscriptionStatusDestinationEventHub? EventHub { get; set; }

    /// <summary>Storage version of v20200601.HybridConnectionEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("hybridConnection")]
    public V20200601storageEventSubscriptionStatusDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>Storage version of v20200601.ServiceBusQueueEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V20200601storageEventSubscriptionStatusDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>Storage version of v20200601.ServiceBusTopicEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V20200601storageEventSubscriptionStatusDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>Storage version of v20200601.StorageQueueEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("storageQueue")]
    public V20200601storageEventSubscriptionStatusDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>Storage version of v20200601.WebHookEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("webHook")]
    public V20200601storageEventSubscriptionStatusDestinationWebHook? WebHook { get; set; }
}

/// <summary>Storage version of v20200601.BoolEqualsAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersBoolEquals
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>Storage version of v20200601.NumberGreaterThanAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThan
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Storage version of v20200601.NumberGreaterThanOrEqualsAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThanOrEquals
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Storage version of v20200601.NumberInAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberIn
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary>Storage version of v20200601.NumberLessThanAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberLessThan
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Storage version of v20200601.NumberLessThanOrEqualsAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberLessThanOrEquals
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Storage version of v20200601.NumberNotInAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberNotIn
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary>Storage version of v20200601.StringBeginsWithAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersStringBeginsWith
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v20200601.StringContainsAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersStringContains
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v20200601.StringEndsWithAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersStringEndsWith
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v20200601.StringInAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersStringIn
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v20200601.StringNotInAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFiltersStringNotIn
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v20200601.AdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilterAdvancedFilters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20200601.BoolEqualsAdvancedFilter_STATUS</summary>
    [JsonPropertyName("boolEquals")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersBoolEquals? BoolEquals { get; set; }

    /// <summary>Storage version of v20200601.NumberGreaterThanAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberGreaterThan")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThan? NumberGreaterThan { get; set; }

    /// <summary>Storage version of v20200601.NumberGreaterThanOrEqualsAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThanOrEquals? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Storage version of v20200601.NumberInAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberIn")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberIn? NumberIn { get; set; }

    /// <summary>Storage version of v20200601.NumberLessThanAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberLessThan")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberLessThan? NumberLessThan { get; set; }

    /// <summary>Storage version of v20200601.NumberLessThanOrEqualsAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberLessThanOrEquals? NumberLessThanOrEquals { get; set; }

    /// <summary>Storage version of v20200601.NumberNotInAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberNotIn")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersNumberNotIn? NumberNotIn { get; set; }

    /// <summary>Storage version of v20200601.StringBeginsWithAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringBeginsWith")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersStringBeginsWith? StringBeginsWith { get; set; }

    /// <summary>Storage version of v20200601.StringContainsAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringContains")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersStringContains? StringContains { get; set; }

    /// <summary>Storage version of v20200601.StringEndsWithAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringEndsWith")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersStringEndsWith? StringEndsWith { get; set; }

    /// <summary>Storage version of v20200601.StringInAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringIn")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersStringIn? StringIn { get; set; }

    /// <summary>Storage version of v20200601.StringNotInAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringNotIn")]
    public V20200601storageEventSubscriptionStatusFilterAdvancedFiltersStringNotIn? StringNotIn { get; set; }
}

/// <summary>
/// Storage version of v20200601.EventSubscriptionFilter_STATUS
/// Filter for the Event Subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusFilter
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("advancedFilters")]
    public IList<V20200601storageEventSubscriptionStatusFilterAdvancedFilters>? AdvancedFilters { get; set; }

    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }

    [JsonPropertyName("isSubjectCaseSensitive")]
    public bool? IsSubjectCaseSensitive { get; set; }

    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

/// <summary>
/// Storage version of v20200601.RetryPolicy_STATUS
/// Information about the retry policy for an event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusRetryPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("eventTimeToLiveInMinutes")]
    public int? EventTimeToLiveInMinutes { get; set; }

    [JsonPropertyName("maxDeliveryAttempts")]
    public int? MaxDeliveryAttempts { get; set; }
}

/// <summary>
/// Storage version of v20200601.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>
/// Storage version of v20200601.EventSubscription_STATUS
/// Event Subscription
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20200601storageEventSubscriptionStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20200601storageEventSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v20200601.DeadLetterDestination_STATUS</summary>
    [JsonPropertyName("deadLetterDestination")]
    public V20200601storageEventSubscriptionStatusDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>Storage version of v20200601.EventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("destination")]
    public V20200601storageEventSubscriptionStatusDestination? Destination { get; set; }

    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>
    /// Storage version of v20200601.EventSubscriptionFilter_STATUS
    /// Filter for the Event Subscription.
    /// </summary>
    [JsonPropertyName("filter")]
    public V20200601storageEventSubscriptionStatusFilter? Filter { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// Storage version of v20200601.RetryPolicy_STATUS
    /// Information about the retry policy for an event subscription.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V20200601storageEventSubscriptionStatusRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Storage version of v20200601.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20200601storageEventSubscriptionStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20200601.EventSubscription
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2020-06-01/EventGrid.json
/// - ARM URI: /{scope}/providers/Microsoft.EventGrid/eventSubscriptions/{eventSubscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20200601storageEventSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V20200601storageEventSubscriptionSpec?>, IStatus<V20200601storageEventSubscriptionStatus?>
{
    public const string KubeApiVersion = "v20200601storage";
    public const string KubeKind = "EventSubscription";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "eventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20200601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSubscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20200601.EventSubscription_Spec</summary>
    [JsonPropertyName("spec")]
    public V20200601storageEventSubscriptionSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20200601.EventSubscription_STATUS
    /// Event Subscription
    /// </summary>
    [JsonPropertyName("status")]
    public V20200601storageEventSubscriptionStatus? Status { get; set; }
}