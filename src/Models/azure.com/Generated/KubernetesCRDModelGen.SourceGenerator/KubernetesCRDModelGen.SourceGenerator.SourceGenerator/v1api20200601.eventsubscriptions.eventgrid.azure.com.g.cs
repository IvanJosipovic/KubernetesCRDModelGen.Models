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
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2020-06-01/EventGrid.json
/// - ARM URI: /{scope}/providers/Microsoft.EventGrid/eventSubscriptions/{eventSubscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200601EventSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1api20200601EventSubscription>
{
    public const string KubeApiVersion = "v1api20200601";
    public const string KubeKind = "EventSubscriptionList";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "eventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v1api20200601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20200601EventSubscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20200601EventSubscription> Items { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the dead letter destination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecDeadLetterDestinationStorageBlobEndpointTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecDeadLetterDestinationStorageBlobEndpointTypeEnum
{
    [EnumMember(Value = "StorageBlob"), JsonStringEnumMemberName("StorageBlob")]
    StorageBlob
}

/// <summary>ResourceReference: The Azure Resource ID of the storage account that is the destination of the deadletter events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDeadLetterDestinationStorageBlobResourceReference
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

/// <summary>StorageBlob: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDeadLetterDestinationStorageBlob
{
    /// <summary>BlobContainerName: The name of the Storage blob container that is the destination of the deadletter events</summary>
    [JsonPropertyName("blobContainerName")]
    public string? BlobContainerName { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the dead letter destination</summary>
    [JsonPropertyName("endpointType")]
    public required V1api20200601EventSubscriptionSpecDeadLetterDestinationStorageBlobEndpointTypeEnum EndpointType { get; set; }

    /// <summary>ResourceReference: The Azure Resource ID of the storage account that is the destination of the deadletter events</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20200601EventSubscriptionSpecDeadLetterDestinationStorageBlobResourceReference? ResourceReference { get; set; }
}

/// <summary>DeadLetterDestination: The DeadLetter destination of the event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDeadLetterDestination
{
    /// <summary>StorageBlob: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageBlob")]
    public V1api20200601EventSubscriptionSpecDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecDestinationAzureFunctionEndpointTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecDestinationAzureFunctionEndpointTypeEnum
{
    [EnumMember(Value = "AzureFunction"), JsonStringEnumMemberName("AzureFunction")]
    AzureFunction
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Azure Function destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationAzureFunctionResourceReference
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

/// <summary>AzureFunction: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationAzureFunction
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V1api20200601EventSubscriptionSpecDestinationAzureFunctionEndpointTypeEnum EndpointType { get; set; }

    /// <summary>MaxEventsPerBatch: Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    /// <summary>PreferredBatchSizeInKilobytes: Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Azure Function destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V1api20200601EventSubscriptionSpecDestinationAzureFunctionResourceReference? ResourceReference { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecDestinationEventHubEndpointTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecDestinationEventHubEndpointTypeEnum
{
    [EnumMember(Value = "EventHub"), JsonStringEnumMemberName("EventHub")]
    EventHub
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationEventHubResourceReference
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

/// <summary>EventHub: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationEventHub
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V1api20200601EventSubscriptionSpecDestinationEventHubEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V1api20200601EventSubscriptionSpecDestinationEventHubResourceReference? ResourceReference { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecDestinationHybridConnectionEndpointTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecDestinationHybridConnectionEndpointTypeEnum
{
    [EnumMember(Value = "HybridConnection"), JsonStringEnumMemberName("HybridConnection")]
    HybridConnection
}

/// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationHybridConnectionResourceReference
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

/// <summary>HybridConnection: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationHybridConnection
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V1api20200601EventSubscriptionSpecDestinationHybridConnectionEndpointTypeEnum EndpointType { get; set; }

    /// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20200601EventSubscriptionSpecDestinationHybridConnectionResourceReference? ResourceReference { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecDestinationServiceBusQueueEndpointTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecDestinationServiceBusQueueEndpointTypeEnum
{
    [EnumMember(Value = "ServiceBusQueue"), JsonStringEnumMemberName("ServiceBusQueue")]
    ServiceBusQueue
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationServiceBusQueueResourceReference
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

/// <summary>ServiceBusQueue: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationServiceBusQueue
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V1api20200601EventSubscriptionSpecDestinationServiceBusQueueEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V1api20200601EventSubscriptionSpecDestinationServiceBusQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecDestinationServiceBusTopicEndpointTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecDestinationServiceBusTopicEndpointTypeEnum
{
    [EnumMember(Value = "ServiceBusTopic"), JsonStringEnumMemberName("ServiceBusTopic")]
    ServiceBusTopic
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationServiceBusTopicResourceReference
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

/// <summary>ServiceBusTopic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationServiceBusTopic
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V1api20200601EventSubscriptionSpecDestinationServiceBusTopicEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V1api20200601EventSubscriptionSpecDestinationServiceBusTopicResourceReference? ResourceReference { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecDestinationStorageQueueEndpointTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecDestinationStorageQueueEndpointTypeEnum
{
    [EnumMember(Value = "StorageQueue"), JsonStringEnumMemberName("StorageQueue")]
    StorageQueue
}

/// <summary>
/// ResourceReference: The Azure Resource ID of the storage account that contains the queue that is the destination of an
/// event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationStorageQueueResourceReference
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

/// <summary>StorageQueue: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationStorageQueue
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V1api20200601EventSubscriptionSpecDestinationStorageQueueEndpointTypeEnum EndpointType { get; set; }

    /// <summary>QueueName: The name of the Storage queue under a storage account that is the destination of an event subscription.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource ID of the storage account that contains the queue that is the destination of an
    /// event subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V1api20200601EventSubscriptionSpecDestinationStorageQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecDestinationWebHookEndpointTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecDestinationWebHookEndpointTypeEnum
{
    [EnumMember(Value = "WebHook"), JsonStringEnumMemberName("WebHook")]
    WebHook
}

/// <summary>EndpointUrl: The URL that represents the endpoint of the destination of an event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationWebHookEndpointUrl
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

/// <summary>WebHook: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestinationWebHook
{
    /// <summary>
    /// AzureActiveDirectoryApplicationIdOrUri: The Azure Active Directory Application ID or URI to get the access token that
    /// will be included as the bearer token in delivery requests.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUri")]
    public string? AzureActiveDirectoryApplicationIdOrUri { get; set; }

    /// <summary>
    /// AzureActiveDirectoryTenantId: The Azure Active Directory Tenant ID to get the access token that will be included as the
    /// bearer token in delivery requests.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryTenantId")]
    public string? AzureActiveDirectoryTenantId { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V1api20200601EventSubscriptionSpecDestinationWebHookEndpointTypeEnum EndpointType { get; set; }

    /// <summary>EndpointUrl: The URL that represents the endpoint of the destination of an event subscription.</summary>
    [JsonPropertyName("endpointUrl")]
    public V1api20200601EventSubscriptionSpecDestinationWebHookEndpointUrl? EndpointUrl { get; set; }

    /// <summary>MaxEventsPerBatch: Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    /// <summary>PreferredBatchSizeInKilobytes: Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>Destination: Information about the destination where events have to be delivered for the event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecDestination
{
    /// <summary>AzureFunction: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureFunction")]
    public V1api20200601EventSubscriptionSpecDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>EventHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("eventHub")]
    public V1api20200601EventSubscriptionSpecDestinationEventHub? EventHub { get; set; }

    /// <summary>HybridConnection: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hybridConnection")]
    public V1api20200601EventSubscriptionSpecDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>ServiceBusQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V1api20200601EventSubscriptionSpecDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>ServiceBusTopic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V1api20200601EventSubscriptionSpecDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>StorageQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageQueue")]
    public V1api20200601EventSubscriptionSpecDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>WebHook: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("webHook")]
    public V1api20200601EventSubscriptionSpecDestinationWebHook? WebHook { get; set; }
}

/// <summary>EventDeliverySchema: The event delivery schema for the event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecEventDeliverySchemaEnum>))]
public enum V1api20200601EventSubscriptionSpecEventDeliverySchemaEnum
{
    [EnumMember(Value = "CloudEventSchemaV1_0"), JsonStringEnumMemberName("CloudEventSchemaV1_0")]
    CloudEventSchemaV10,
    [EnumMember(Value = "CustomInputSchema"), JsonStringEnumMemberName("CustomInputSchema")]
    CustomInputSchema,
    [EnumMember(Value = "EventGridSchema"), JsonStringEnumMemberName("EventGridSchema")]
    EventGridSchema
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersBoolEqualsOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersBoolEqualsOperatorTypeEnum
{
    [EnumMember(Value = "BoolEquals"), JsonStringEnumMemberName("BoolEquals")]
    BoolEquals
}

/// <summary>BoolEquals: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersBoolEquals
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersBoolEqualsOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Value: The boolean filter value.</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOperatorTypeEnum
{
    [EnumMember(Value = "NumberGreaterThan"), JsonStringEnumMemberName("NumberGreaterThan")]
    NumberGreaterThan
}

/// <summary>NumberGreaterThan: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThan
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEqualsOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEqualsOperatorTypeEnum
{
    [EnumMember(Value = "NumberGreaterThanOrEquals"), JsonStringEnumMemberName("NumberGreaterThanOrEquals")]
    NumberGreaterThanOrEquals
}

/// <summary>NumberGreaterThanOrEquals: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEquals
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEqualsOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberInOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberInOperatorTypeEnum
{
    [EnumMember(Value = "NumberIn"), JsonStringEnumMemberName("NumberIn")]
    NumberIn
}

/// <summary>NumberIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberInOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOperatorTypeEnum
{
    [EnumMember(Value = "NumberLessThan"), JsonStringEnumMemberName("NumberLessThan")]
    NumberLessThan
}

/// <summary>NumberLessThan: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberLessThan
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEqualsOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEqualsOperatorTypeEnum
{
    [EnumMember(Value = "NumberLessThanOrEquals"), JsonStringEnumMemberName("NumberLessThanOrEquals")]
    NumberLessThanOrEquals
}

/// <summary>NumberLessThanOrEquals: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEquals
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEqualsOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberNotInOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberNotInOperatorTypeEnum
{
    [EnumMember(Value = "NumberNotIn"), JsonStringEnumMemberName("NumberNotIn")]
    NumberNotIn
}

/// <summary>NumberNotIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberNotIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberNotInOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringBeginsWithOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringBeginsWithOperatorTypeEnum
{
    [EnumMember(Value = "StringBeginsWith"), JsonStringEnumMemberName("StringBeginsWith")]
    StringBeginsWith
}

/// <summary>StringBeginsWith: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringBeginsWith
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringBeginsWithOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringContainsOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringContainsOperatorTypeEnum
{
    [EnumMember(Value = "StringContains"), JsonStringEnumMemberName("StringContains")]
    StringContains
}

/// <summary>StringContains: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringContains
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringContainsOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringEndsWithOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringEndsWithOperatorTypeEnum
{
    [EnumMember(Value = "StringEndsWith"), JsonStringEnumMemberName("StringEndsWith")]
    StringEndsWith
}

/// <summary>StringEndsWith: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringEndsWith
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringEndsWithOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringInOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringInOperatorTypeEnum
{
    [EnumMember(Value = "StringIn"), JsonStringEnumMemberName("StringIn")]
    StringIn
}

/// <summary>StringIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringInOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringNotInOperatorTypeEnum>))]
public enum V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringNotInOperatorTypeEnum
{
    [EnumMember(Value = "StringNotIn"), JsonStringEnumMemberName("StringNotIn")]
    StringNotIn
}

/// <summary>StringNotIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringNotIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringNotInOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilterAdvancedFilters
{
    /// <summary>BoolEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("boolEquals")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersBoolEquals? BoolEquals { get; set; }

    /// <summary>NumberGreaterThan: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberGreaterThan")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThan? NumberGreaterThan { get; set; }

    /// <summary>NumberGreaterThanOrEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEquals? NumberGreaterThanOrEquals { get; set; }

    /// <summary>NumberIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberIn")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberIn? NumberIn { get; set; }

    /// <summary>NumberLessThan: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberLessThan")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberLessThan? NumberLessThan { get; set; }

    /// <summary>NumberLessThanOrEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEquals? NumberLessThanOrEquals { get; set; }

    /// <summary>NumberNotIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberNotIn")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersNumberNotIn? NumberNotIn { get; set; }

    /// <summary>StringBeginsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringBeginsWith")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringBeginsWith? StringBeginsWith { get; set; }

    /// <summary>StringContains: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringContains")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringContains? StringContains { get; set; }

    /// <summary>StringEndsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringEndsWith")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringEndsWith? StringEndsWith { get; set; }

    /// <summary>StringIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringIn")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringIn? StringIn { get; set; }

    /// <summary>StringNotIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringNotIn")]
    public V1api20200601EventSubscriptionSpecFilterAdvancedFiltersStringNotIn? StringNotIn { get; set; }
}

/// <summary>Filter: Information about the filter for the event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecFilter
{
    /// <summary>AdvancedFilters: An array of advanced filters that are used for filtering event subscriptions.</summary>
    [JsonPropertyName("advancedFilters")]
    public IList<V1api20200601EventSubscriptionSpecFilterAdvancedFilters>? AdvancedFilters { get; set; }

    /// <summary>
    /// IncludedEventTypes: A list of applicable event types that need to be part of the event subscription. If it is desired to
    /// subscribe to all default event types, set the IncludedEventTypes to null.
    /// </summary>
    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }

    /// <summary>
    /// IsSubjectCaseSensitive: Specifies if the SubjectBeginsWith and SubjectEndsWith properties of the filter
    /// should be compared in a case sensitive manner.
    /// </summary>
    [JsonPropertyName("isSubjectCaseSensitive")]
    public bool? IsSubjectCaseSensitive { get; set; }

    /// <summary>
    /// SubjectBeginsWith: An optional string to filter events for an event subscription based on a resource path prefix.
    /// The format of this depends on the publisher of the events.
    /// Wildcard characters are not supported in this path.
    /// </summary>
    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    /// <summary>
    /// SubjectEndsWith: An optional string to filter events for an event subscription based on a resource path suffix.
    /// Wildcard characters are not supported in this path.
    /// </summary>
    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20200601EventSubscriptionSpecOperatorSpecSecretExpressions
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
public partial class V1api20200601EventSubscriptionSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20200601EventSubscriptionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20200601EventSubscriptionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
/// extension resource, which means that any other Azure resource can be its owner.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecOwner
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
/// RetryPolicy: The retry policy for events. This can be used to configure maximum number of delivery attempts and time to
/// live for events.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpecRetryPolicy
{
    /// <summary>EventTimeToLiveInMinutes: Time To Live (in minutes) for events.</summary>
    [JsonPropertyName("eventTimeToLiveInMinutes")]
    public int? EventTimeToLiveInMinutes { get; set; }

    /// <summary>MaxDeliveryAttempts: Maximum number of delivery retry attempts for events.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public int? MaxDeliveryAttempts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>DeadLetterDestination: The DeadLetter destination of the event subscription.</summary>
    [JsonPropertyName("deadLetterDestination")]
    public V1api20200601EventSubscriptionSpecDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>Destination: Information about the destination where events have to be delivered for the event subscription.</summary>
    [JsonPropertyName("destination")]
    public V1api20200601EventSubscriptionSpecDestination? Destination { get; set; }

    /// <summary>EventDeliverySchema: The event delivery schema for the event subscription.</summary>
    [JsonPropertyName("eventDeliverySchema")]
    public V1api20200601EventSubscriptionSpecEventDeliverySchemaEnum? EventDeliverySchema { get; set; }

    /// <summary>ExpirationTimeUtc: Expiration time of the event subscription.</summary>
    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>Filter: Information about the filter for the event subscription.</summary>
    [JsonPropertyName("filter")]
    public V1api20200601EventSubscriptionSpecFilter? Filter { get; set; }

    /// <summary>Labels: List of user defined labels.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20200601EventSubscriptionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
    /// extension resource, which means that any other Azure resource can be its owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20200601EventSubscriptionSpecOwner Owner { get; set; }

    /// <summary>
    /// RetryPolicy: The retry policy for events. This can be used to configure maximum number of delivery attempts and time to
    /// live for events.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1api20200601EventSubscriptionSpecRetryPolicy? RetryPolicy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusConditions
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

/// <summary>StorageBlob: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusDeadLetterDestinationStorageBlob
{
    /// <summary>BlobContainerName: The name of the Storage blob container that is the destination of the deadletter events</summary>
    [JsonPropertyName("blobContainerName")]
    public string? BlobContainerName { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the dead letter destination</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceId: The Azure Resource ID of the storage account that is the destination of the deadletter events</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>DeadLetterDestination: The DeadLetter destination of the event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusDeadLetterDestination
{
    /// <summary>StorageBlob: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageBlob")]
    public V1api20200601EventSubscriptionStatusDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>AzureFunction: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusDestinationAzureFunction
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>MaxEventsPerBatch: Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    /// <summary>PreferredBatchSizeInKilobytes: Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }

    /// <summary>
    /// ResourceId: The Azure Resource Id that represents the endpoint of the Azure Function destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>EventHub: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusDestinationEventHub
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceId: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event subscription.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>HybridConnection: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusDestinationHybridConnection
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceId: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>ServiceBusQueue: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusDestinationServiceBusQueue
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceId: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event subscription.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>ServiceBusTopic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusDestinationServiceBusTopic
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceId: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>StorageQueue: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusDestinationStorageQueue
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>QueueName: The name of the Storage queue under a storage account that is the destination of an event subscription.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>
    /// ResourceId: The Azure Resource ID of the storage account that contains the queue that is the destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>WebHook: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusDestinationWebHook
{
    /// <summary>
    /// AzureActiveDirectoryApplicationIdOrUri: The Azure Active Directory Application ID or URI to get the access token that
    /// will be included as the bearer token in delivery requests.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUri")]
    public string? AzureActiveDirectoryApplicationIdOrUri { get; set; }

    /// <summary>
    /// AzureActiveDirectoryTenantId: The Azure Active Directory Tenant ID to get the access token that will be included as the
    /// bearer token in delivery requests.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryTenantId")]
    public string? AzureActiveDirectoryTenantId { get; set; }

    /// <summary>EndpointBaseUrl: The base URL that represents the endpoint of the destination of an event subscription.</summary>
    [JsonPropertyName("endpointBaseUrl")]
    public string? EndpointBaseUrl { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>MaxEventsPerBatch: Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    /// <summary>PreferredBatchSizeInKilobytes: Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>Destination: Information about the destination where events have to be delivered for the event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusDestination
{
    /// <summary>AzureFunction: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureFunction")]
    public V1api20200601EventSubscriptionStatusDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>EventHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("eventHub")]
    public V1api20200601EventSubscriptionStatusDestinationEventHub? EventHub { get; set; }

    /// <summary>HybridConnection: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hybridConnection")]
    public V1api20200601EventSubscriptionStatusDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>ServiceBusQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V1api20200601EventSubscriptionStatusDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>ServiceBusTopic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V1api20200601EventSubscriptionStatusDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>StorageQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageQueue")]
    public V1api20200601EventSubscriptionStatusDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>WebHook: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("webHook")]
    public V1api20200601EventSubscriptionStatusDestinationWebHook? WebHook { get; set; }
}

/// <summary>BoolEquals: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersBoolEquals
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Value: The boolean filter value.</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>NumberGreaterThan: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThan
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>NumberGreaterThanOrEquals: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThanOrEquals
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>NumberIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary>NumberLessThan: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberLessThan
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>NumberLessThanOrEquals: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberLessThanOrEquals
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>NumberNotIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberNotIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary>StringBeginsWith: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersStringBeginsWith
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>StringContains: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersStringContains
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>StringEndsWith: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersStringEndsWith
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>StringIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersStringIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>StringNotIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFiltersStringNotIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilterAdvancedFilters
{
    /// <summary>BoolEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("boolEquals")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersBoolEquals? BoolEquals { get; set; }

    /// <summary>NumberGreaterThan: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberGreaterThan")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThan? NumberGreaterThan { get; set; }

    /// <summary>NumberGreaterThanOrEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThanOrEquals? NumberGreaterThanOrEquals { get; set; }

    /// <summary>NumberIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberIn")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberIn? NumberIn { get; set; }

    /// <summary>NumberLessThan: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberLessThan")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberLessThan? NumberLessThan { get; set; }

    /// <summary>NumberLessThanOrEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberLessThanOrEquals? NumberLessThanOrEquals { get; set; }

    /// <summary>NumberNotIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberNotIn")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersNumberNotIn? NumberNotIn { get; set; }

    /// <summary>StringBeginsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringBeginsWith")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersStringBeginsWith? StringBeginsWith { get; set; }

    /// <summary>StringContains: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringContains")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersStringContains? StringContains { get; set; }

    /// <summary>StringEndsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringEndsWith")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersStringEndsWith? StringEndsWith { get; set; }

    /// <summary>StringIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringIn")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersStringIn? StringIn { get; set; }

    /// <summary>StringNotIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringNotIn")]
    public V1api20200601EventSubscriptionStatusFilterAdvancedFiltersStringNotIn? StringNotIn { get; set; }
}

/// <summary>Filter: Information about the filter for the event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusFilter
{
    /// <summary>AdvancedFilters: An array of advanced filters that are used for filtering event subscriptions.</summary>
    [JsonPropertyName("advancedFilters")]
    public IList<V1api20200601EventSubscriptionStatusFilterAdvancedFilters>? AdvancedFilters { get; set; }

    /// <summary>
    /// IncludedEventTypes: A list of applicable event types that need to be part of the event subscription. If it is desired to
    /// subscribe to all default event types, set the IncludedEventTypes to null.
    /// </summary>
    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }

    /// <summary>
    /// IsSubjectCaseSensitive: Specifies if the SubjectBeginsWith and SubjectEndsWith properties of the filter
    /// should be compared in a case sensitive manner.
    /// </summary>
    [JsonPropertyName("isSubjectCaseSensitive")]
    public bool? IsSubjectCaseSensitive { get; set; }

    /// <summary>
    /// SubjectBeginsWith: An optional string to filter events for an event subscription based on a resource path prefix.
    /// The format of this depends on the publisher of the events.
    /// Wildcard characters are not supported in this path.
    /// </summary>
    [JsonPropertyName("subjectBeginsWith")]
    public string? SubjectBeginsWith { get; set; }

    /// <summary>
    /// SubjectEndsWith: An optional string to filter events for an event subscription based on a resource path suffix.
    /// Wildcard characters are not supported in this path.
    /// </summary>
    [JsonPropertyName("subjectEndsWith")]
    public string? SubjectEndsWith { get; set; }
}

/// <summary>
/// RetryPolicy: The retry policy for events. This can be used to configure maximum number of delivery attempts and time to
/// live for events.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusRetryPolicy
{
    /// <summary>EventTimeToLiveInMinutes: Time To Live (in minutes) for events.</summary>
    [JsonPropertyName("eventTimeToLiveInMinutes")]
    public int? EventTimeToLiveInMinutes { get; set; }

    /// <summary>MaxDeliveryAttempts: Maximum number of delivery retry attempts for events.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public int? MaxDeliveryAttempts { get; set; }
}

/// <summary>SystemData: The system metadata relating to Event Subscription resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatusSystemData
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

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Event Subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200601EventSubscriptionStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20200601EventSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>DeadLetterDestination: The DeadLetter destination of the event subscription.</summary>
    [JsonPropertyName("deadLetterDestination")]
    public V1api20200601EventSubscriptionStatusDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>Destination: Information about the destination where events have to be delivered for the event subscription.</summary>
    [JsonPropertyName("destination")]
    public V1api20200601EventSubscriptionStatusDestination? Destination { get; set; }

    /// <summary>EventDeliverySchema: The event delivery schema for the event subscription.</summary>
    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    /// <summary>ExpirationTimeUtc: Expiration time of the event subscription.</summary>
    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>Filter: Information about the filter for the event subscription.</summary>
    [JsonPropertyName("filter")]
    public V1api20200601EventSubscriptionStatusFilter? Filter { get; set; }

    /// <summary>Id: Fully qualified identifier of the resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Labels: List of user defined labels.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>Name: Name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the event subscription.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RetryPolicy: The retry policy for events. This can be used to configure maximum number of delivery attempts and time to
    /// live for events.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V1api20200601EventSubscriptionStatusRetryPolicy? RetryPolicy { get; set; }

    /// <summary>SystemData: The system metadata relating to Event Subscription resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20200601EventSubscriptionStatusSystemData? SystemData { get; set; }

    /// <summary>Topic: Name of the topic of the event subscription.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2020-06-01/EventGrid.json
/// - ARM URI: /{scope}/providers/Microsoft.EventGrid/eventSubscriptions/{eventSubscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200601EventSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20200601EventSubscriptionSpec?>, IStatus<V1api20200601EventSubscriptionStatus?>
{
    public const string KubeApiVersion = "v1api20200601";
    public const string KubeKind = "EventSubscription";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "eventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v1api20200601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSubscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20200601EventSubscriptionSpec? Spec { get; set; }

    /// <summary>Event Subscription</summary>
    [JsonPropertyName("status")]
    public V1api20200601EventSubscriptionStatus? Status { get; set; }
}