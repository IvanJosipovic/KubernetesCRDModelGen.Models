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
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2025-02-15/EventGrid.json
/// - ARM URI: /{scope}/providers/Microsoft.EventGrid/eventSubscriptions/{eventSubscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250215EventSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V20250215EventSubscription>
{
    public const string KubeApiVersion = "v20250215";
    public const string KubeKind = "EventSubscriptionList";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "eventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20250215";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250215EventSubscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250215EventSubscription> Items { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the dead letter destination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeadLetterDestinationStorageBlobEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeadLetterDestinationStorageBlobEndpointTypeEnum
{
    [EnumMember(Value = "StorageBlob"), JsonStringEnumMemberName("StorageBlob")]
    StorageBlob
}

/// <summary>ResourceReference: The Azure Resource ID of the storage account that is the destination of the deadletter events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeadLetterDestinationStorageBlobResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeadLetterDestinationStorageBlob
{
    /// <summary>BlobContainerName: The name of the Storage blob container that is the destination of the deadletter events</summary>
    [JsonPropertyName("blobContainerName")]
    public string? BlobContainerName { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the dead letter destination</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDeadLetterDestinationStorageBlobEndpointTypeEnum EndpointType { get; set; }

    /// <summary>ResourceReference: The Azure Resource ID of the storage account that is the destination of the deadletter events</summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDeadLetterDestinationStorageBlobResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// DeadLetterDestination: The dead letter destination of the event subscription. Any event that cannot be delivered to its&apos;
/// destination is sent to the dead letter destination.
/// Uses Azure Event Grid&apos;s identity to acquire the authentication tokens being used during delivery / dead-lettering.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeadLetterDestination
{
    /// <summary>StorageBlob: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageBlob")]
    public V20250215EventSubscriptionSpecDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the dead letter destination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlobEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlobEndpointTypeEnum
{
    [EnumMember(Value = "StorageBlob"), JsonStringEnumMemberName("StorageBlob")]
    StorageBlob
}

/// <summary>ResourceReference: The Azure Resource ID of the storage account that is the destination of the deadletter events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlobResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlob
{
    /// <summary>BlobContainerName: The name of the Storage blob container that is the destination of the deadletter events</summary>
    [JsonPropertyName("blobContainerName")]
    public string? BlobContainerName { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the dead letter destination</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlobEndpointTypeEnum EndpointType { get; set; }

    /// <summary>ResourceReference: The Azure Resource ID of the storage account that is the destination of the deadletter events</summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlobResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// DeadLetterDestination: Information about the destination where events have to be delivered for the event subscription.
/// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
/// being used during dead-lettering.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestination
{
    /// <summary>StorageBlob: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageBlob")]
    public V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>Type: The type of managed identity used. Can be either &apos;SystemAssigned&apos; or &apos;UserAssigned&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityIdentityTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityIdentityTypeEnum
{
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>Identity: The identity to use when dead-lettering events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityIdentity
{
    /// <summary>Type: The type of managed identity used. Can be either &apos;SystemAssigned&apos; or &apos;UserAssigned&apos;.</summary>
    [JsonPropertyName("type")]
    public V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentity: The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// DeadLetterWithResourceIdentity: The dead letter destination of the event subscription. Any event that cannot be
/// delivered to its&apos; destination is sent to the dead letter destination.
/// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
/// being used during delivery / dead-lettering.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeadLetterWithResourceIdentity
{
    /// <summary>
    /// DeadLetterDestination: Information about the destination where events have to be delivered for the event subscription.
    /// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
    /// being used during dead-lettering.
    /// </summary>
    [JsonPropertyName("deadLetterDestination")]
    public V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>Identity: The identity to use when dead-lettering events.</summary>
    [JsonPropertyName("identity")]
    public V20250215EventSubscriptionSpecDeadLetterWithResourceIdentityIdentity? Identity { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionEndpointTypeEnum
{
    [EnumMember(Value = "AzureFunction"), JsonStringEnumMemberName("AzureFunction")]
    AzureFunction
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Azure Function destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunction
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionEndpointTypeEnum EndpointType { get; set; }

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
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionResourceReference? ResourceReference { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubEndpointTypeEnum
{
    [EnumMember(Value = "EventHub"), JsonStringEnumMemberName("EventHub")]
    EventHub
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHub
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubResourceReference? ResourceReference { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionEndpointTypeEnum
{
    [EnumMember(Value = "HybridConnection"), JsonStringEnumMemberName("HybridConnection")]
    HybridConnection
}

/// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnection
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionEndpointTypeEnum EndpointType { get; set; }

    /// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionResourceReference? ResourceReference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlertActionGroupsReferences
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

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlertEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlertEndpointTypeEnum
{
    [EnumMember(Value = "MonitorAlert"), JsonStringEnumMemberName("MonitorAlert")]
    MonitorAlert
}

/// <summary>
/// Severity: The severity that will be attached to every Alert fired through this event subscription.
/// This field must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlertSeverityEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlertSeverityEnum
{
    [EnumMember(Value = "Sev0"), JsonStringEnumMemberName("Sev0")]
    Sev0,
    [EnumMember(Value = "Sev1"), JsonStringEnumMemberName("Sev1")]
    Sev1,
    [EnumMember(Value = "Sev2"), JsonStringEnumMemberName("Sev2")]
    Sev2,
    [EnumMember(Value = "Sev3"), JsonStringEnumMemberName("Sev3")]
    Sev3,
    [EnumMember(Value = "Sev4"), JsonStringEnumMemberName("Sev4")]
    Sev4
}

/// <summary>MonitorAlert: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlert
{
    /// <summary>
    /// ActionGroupsReferences: The list of ARM Ids of Action Groups that will be triggered on every Alert fired through this
    /// event subscription.
    /// Each resource ARM Id should follow this pattern:
    /// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Insights/actionGroups/{ActionGroupName}.
    /// </summary>
    [JsonPropertyName("actionGroupsReferences")]
    public IList<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlertActionGroupsReferences>? ActionGroupsReferences { get; set; }

    /// <summary>Description: The description that will be attached to every Alert fired through this event subscription.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlertEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// Severity: The severity that will be attached to every Alert fired through this event subscription.
    /// This field must be provided.
    /// </summary>
    [JsonPropertyName("severity")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlertSeverityEnum? Severity { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationNamespaceTopicEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationNamespaceTopicEndpointTypeEnum
{
    [EnumMember(Value = "NamespaceTopic"), JsonStringEnumMemberName("NamespaceTopic")]
    NamespaceTopic
}

/// <summary>
/// ResourceReference: The Azure resource Id that represents the endpoint of the Event Grid Namespace Topic destination of
/// an event subscription.
/// This field is required and the Namespace Topic resource listed must already exist.
/// The resource ARM Id should follow this pattern:
/// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.EventGrid/namespaces/{NamespaceName}/topics/{TopicName}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationNamespaceTopicResourceReference
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

/// <summary>NamespaceTopic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationNamespaceTopic
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationNamespaceTopicEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure resource Id that represents the endpoint of the Event Grid Namespace Topic destination of
    /// an event subscription.
    /// This field is required and the Namespace Topic resource listed must already exist.
    /// The resource ARM Id should follow this pattern:
    /// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.EventGrid/namespaces/{NamespaceName}/topics/{TopicName}.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationNamespaceTopicResourceReference? ResourceReference { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueEndpointTypeEnum
{
    [EnumMember(Value = "ServiceBusQueue"), JsonStringEnumMemberName("ServiceBusQueue")]
    ServiceBusQueue
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueue
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicEndpointTypeEnum
{
    [EnumMember(Value = "ServiceBusTopic"), JsonStringEnumMemberName("ServiceBusTopic")]
    ServiceBusTopic
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopic
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicResourceReference? ResourceReference { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueueEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueueEndpointTypeEnum
{
    [EnumMember(Value = "StorageQueue"), JsonStringEnumMemberName("StorageQueue")]
    StorageQueue
}

/// <summary>
/// QueueNameFromConfig: The name of the Storage queue under a storage account that is the destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueueQueueNameFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource ID of the storage account that contains the queue that is the destination of an
/// event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueueResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueue
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueueEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// QueueMessageTimeToLiveInSeconds: Storage queue message time to live in seconds. This value cannot be zero or negative
    /// with the exception of using -1 to indicate that the Time To Live of the message is Infinite.
    /// </summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public int? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>QueueName: The name of the Storage queue under a storage account that is the destination of an event subscription.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>
    /// QueueNameFromConfig: The name of the Storage queue under a storage account that is the destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("queueNameFromConfig")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueueQueueNameFromConfig? QueueNameFromConfig { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource ID of the storage account that contains the queue that is the destination of an
    /// event subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// AzureActiveDirectoryApplicationIdOrUriFromConfig: The Azure Active Directory Application ID or URI to get the access
/// token that will be included as the bearer token in delivery requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookAzureActiveDirectoryApplicationIdOrUriFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookEndpointTypeEnum
{
    [EnumMember(Value = "WebHook"), JsonStringEnumMemberName("WebHook")]
    WebHook
}

/// <summary>EndpointUrl: The URL that represents the endpoint of the destination of an event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookEndpointUrl
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

/// <summary>MinimumTlsVersionAllowed: Minimum TLS version that should be supported by webhook endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookMinimumTlsVersionAllowedEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookMinimumTlsVersionAllowedEnum
{
    [EnumMember(Value = "1.0"), JsonStringEnumMemberName("1.0")]
    _10,
    [EnumMember(Value = "1.1"), JsonStringEnumMemberName("1.1")]
    _11,
    [EnumMember(Value = "1.2"), JsonStringEnumMemberName("1.2")]
    _12
}

/// <summary>WebHook: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHook
{
    /// <summary>
    /// AzureActiveDirectoryApplicationIdOrUri: The Azure Active Directory Application ID or URI to get the access token that
    /// will be included as the bearer token in delivery requests.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUri")]
    public string? AzureActiveDirectoryApplicationIdOrUri { get; set; }

    /// <summary>
    /// AzureActiveDirectoryApplicationIdOrUriFromConfig: The Azure Active Directory Application ID or URI to get the access
    /// token that will be included as the bearer token in delivery requests.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUriFromConfig")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookAzureActiveDirectoryApplicationIdOrUriFromConfig? AzureActiveDirectoryApplicationIdOrUriFromConfig { get; set; }

    /// <summary>
    /// AzureActiveDirectoryTenantId: The Azure Active Directory Tenant ID to get the access token that will be included as the
    /// bearer token in delivery requests.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryTenantId")]
    public string? AzureActiveDirectoryTenantId { get; set; }

    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookEndpointTypeEnum EndpointType { get; set; }

    /// <summary>EndpointUrl: The URL that represents the endpoint of the destination of an event subscription.</summary>
    [JsonPropertyName("endpointUrl")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookEndpointUrl? EndpointUrl { get; set; }

    /// <summary>MaxEventsPerBatch: Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    /// <summary>MinimumTlsVersionAllowed: Minimum TLS version that should be supported by webhook endpoint</summary>
    [JsonPropertyName("minimumTlsVersionAllowed")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookMinimumTlsVersionAllowedEnum? MinimumTlsVersionAllowed { get; set; }

    /// <summary>PreferredBatchSizeInKilobytes: Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>
/// Destination: Information about the destination where events have to be delivered for the event subscription.
/// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
/// being used during delivery.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestination
{
    /// <summary>AzureFunction: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureFunction")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>EventHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("eventHub")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHub? EventHub { get; set; }

    /// <summary>HybridConnection: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hybridConnection")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>MonitorAlert: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("monitorAlert")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlert? MonitorAlert { get; set; }

    /// <summary>NamespaceTopic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("namespaceTopic")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationNamespaceTopic? NamespaceTopic { get; set; }

    /// <summary>ServiceBusQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>ServiceBusTopic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>StorageQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageQueue")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>WebHook: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("webHook")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHook? WebHook { get; set; }
}

/// <summary>Type: The type of managed identity used. Can be either &apos;SystemAssigned&apos; or &apos;UserAssigned&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDeliveryWithResourceIdentityIdentityTypeEnum>))]
public enum V20250215EventSubscriptionSpecDeliveryWithResourceIdentityIdentityTypeEnum
{
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>Identity: The identity to use when delivering events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentityIdentity
{
    /// <summary>Type: The type of managed identity used. Can be either &apos;SystemAssigned&apos; or &apos;UserAssigned&apos;.</summary>
    [JsonPropertyName("type")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentity: The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// DeliveryWithResourceIdentity: Information about the destination where events have to be delivered for the event
/// subscription.
/// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
/// being used during delivery / dead-lettering.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDeliveryWithResourceIdentity
{
    /// <summary>
    /// Destination: Information about the destination where events have to be delivered for the event subscription.
    /// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
    /// being used during delivery.
    /// </summary>
    [JsonPropertyName("destination")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityDestination? Destination { get; set; }

    /// <summary>Identity: The identity to use when delivering events.</summary>
    [JsonPropertyName("identity")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentityIdentity? Identity { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationAzureFunctionEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationAzureFunctionEndpointTypeEnum
{
    [EnumMember(Value = "AzureFunction"), JsonStringEnumMemberName("AzureFunction")]
    AzureFunction
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Azure Function destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationAzureFunctionResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationAzureFunction
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDestinationAzureFunctionEndpointTypeEnum EndpointType { get; set; }

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
    public V20250215EventSubscriptionSpecDestinationAzureFunctionResourceReference? ResourceReference { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationEventHubEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationEventHubEndpointTypeEnum
{
    [EnumMember(Value = "EventHub"), JsonStringEnumMemberName("EventHub")]
    EventHub
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationEventHubResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationEventHub
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDestinationEventHubDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDestinationEventHubEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDestinationEventHubResourceReference? ResourceReference { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationHybridConnectionEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationHybridConnectionEndpointTypeEnum
{
    [EnumMember(Value = "HybridConnection"), JsonStringEnumMemberName("HybridConnection")]
    HybridConnection
}

/// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationHybridConnectionResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationHybridConnection
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDestinationHybridConnectionEndpointTypeEnum EndpointType { get; set; }

    /// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDestinationHybridConnectionResourceReference? ResourceReference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationMonitorAlertActionGroupsReferences
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

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationMonitorAlertEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationMonitorAlertEndpointTypeEnum
{
    [EnumMember(Value = "MonitorAlert"), JsonStringEnumMemberName("MonitorAlert")]
    MonitorAlert
}

/// <summary>
/// Severity: The severity that will be attached to every Alert fired through this event subscription.
/// This field must be provided.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationMonitorAlertSeverityEnum>))]
public enum V20250215EventSubscriptionSpecDestinationMonitorAlertSeverityEnum
{
    [EnumMember(Value = "Sev0"), JsonStringEnumMemberName("Sev0")]
    Sev0,
    [EnumMember(Value = "Sev1"), JsonStringEnumMemberName("Sev1")]
    Sev1,
    [EnumMember(Value = "Sev2"), JsonStringEnumMemberName("Sev2")]
    Sev2,
    [EnumMember(Value = "Sev3"), JsonStringEnumMemberName("Sev3")]
    Sev3,
    [EnumMember(Value = "Sev4"), JsonStringEnumMemberName("Sev4")]
    Sev4
}

/// <summary>MonitorAlert: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationMonitorAlert
{
    /// <summary>
    /// ActionGroupsReferences: The list of ARM Ids of Action Groups that will be triggered on every Alert fired through this
    /// event subscription.
    /// Each resource ARM Id should follow this pattern:
    /// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Insights/actionGroups/{ActionGroupName}.
    /// </summary>
    [JsonPropertyName("actionGroupsReferences")]
    public IList<V20250215EventSubscriptionSpecDestinationMonitorAlertActionGroupsReferences>? ActionGroupsReferences { get; set; }

    /// <summary>Description: The description that will be attached to every Alert fired through this event subscription.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDestinationMonitorAlertEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// Severity: The severity that will be attached to every Alert fired through this event subscription.
    /// This field must be provided.
    /// </summary>
    [JsonPropertyName("severity")]
    public V20250215EventSubscriptionSpecDestinationMonitorAlertSeverityEnum? Severity { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationNamespaceTopicEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationNamespaceTopicEndpointTypeEnum
{
    [EnumMember(Value = "NamespaceTopic"), JsonStringEnumMemberName("NamespaceTopic")]
    NamespaceTopic
}

/// <summary>
/// ResourceReference: The Azure resource Id that represents the endpoint of the Event Grid Namespace Topic destination of
/// an event subscription.
/// This field is required and the Namespace Topic resource listed must already exist.
/// The resource ARM Id should follow this pattern:
/// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.EventGrid/namespaces/{NamespaceName}/topics/{TopicName}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationNamespaceTopicResourceReference
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

/// <summary>NamespaceTopic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationNamespaceTopic
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDestinationNamespaceTopicEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure resource Id that represents the endpoint of the Event Grid Namespace Topic destination of
    /// an event subscription.
    /// This field is required and the Namespace Topic resource listed must already exist.
    /// The resource ARM Id should follow this pattern:
    /// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.EventGrid/namespaces/{NamespaceName}/topics/{TopicName}.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDestinationNamespaceTopicResourceReference? ResourceReference { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationServiceBusQueueEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationServiceBusQueueEndpointTypeEnum
{
    [EnumMember(Value = "ServiceBusQueue"), JsonStringEnumMemberName("ServiceBusQueue")]
    ServiceBusQueue
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationServiceBusQueueResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationServiceBusQueue
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDestinationServiceBusQueueEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDestinationServiceBusQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationServiceBusTopicEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationServiceBusTopicEndpointTypeEnum
{
    [EnumMember(Value = "ServiceBusTopic"), JsonStringEnumMemberName("ServiceBusTopic")]
    ServiceBusTopic
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationServiceBusTopicResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationServiceBusTopic
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDestinationServiceBusTopicEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDestinationServiceBusTopicResourceReference? ResourceReference { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationStorageQueueEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationStorageQueueEndpointTypeEnum
{
    [EnumMember(Value = "StorageQueue"), JsonStringEnumMemberName("StorageQueue")]
    StorageQueue
}

/// <summary>
/// QueueNameFromConfig: The name of the Storage queue under a storage account that is the destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationStorageQueueQueueNameFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource ID of the storage account that contains the queue that is the destination of an
/// event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationStorageQueueResourceReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationStorageQueue
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDestinationStorageQueueEndpointTypeEnum EndpointType { get; set; }

    /// <summary>
    /// QueueMessageTimeToLiveInSeconds: Storage queue message time to live in seconds. This value cannot be zero or negative
    /// with the exception of using -1 to indicate that the Time To Live of the message is Infinite.
    /// </summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public int? QueueMessageTimeToLiveInSeconds { get; set; }

    /// <summary>QueueName: The name of the Storage queue under a storage account that is the destination of an event subscription.</summary>
    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>
    /// QueueNameFromConfig: The name of the Storage queue under a storage account that is the destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("queueNameFromConfig")]
    public V20250215EventSubscriptionSpecDestinationStorageQueueQueueNameFromConfig? QueueNameFromConfig { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource ID of the storage account that contains the queue that is the destination of an
    /// event subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215EventSubscriptionSpecDestinationStorageQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// AzureActiveDirectoryApplicationIdOrUriFromConfig: The Azure Active Directory Application ID or URI to get the access
/// token that will be included as the bearer token in delivery requests.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationWebHookAzureActiveDirectoryApplicationIdOrUriFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsDynamicTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsDynamicTypeEnum
{
    [EnumMember(Value = "Dynamic"), JsonStringEnumMemberName("Dynamic")]
    Dynamic
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsDynamicTypeEnum Type { get; set; }
}

/// <summary>Type: Type of the delivery attribute or header name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsStaticTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsStaticTypeEnum
{
    [EnumMember(Value = "Static"), JsonStringEnumMemberName("Static")]
    Static
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public required V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsStaticTypeEnum Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationWebHookEndpointTypeEnum>))]
public enum V20250215EventSubscriptionSpecDestinationWebHookEndpointTypeEnum
{
    [EnumMember(Value = "WebHook"), JsonStringEnumMemberName("WebHook")]
    WebHook
}

/// <summary>EndpointUrl: The URL that represents the endpoint of the destination of an event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationWebHookEndpointUrl
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

/// <summary>MinimumTlsVersionAllowed: Minimum TLS version that should be supported by webhook endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecDestinationWebHookMinimumTlsVersionAllowedEnum>))]
public enum V20250215EventSubscriptionSpecDestinationWebHookMinimumTlsVersionAllowedEnum
{
    [EnumMember(Value = "1.0"), JsonStringEnumMemberName("1.0")]
    _10,
    [EnumMember(Value = "1.1"), JsonStringEnumMemberName("1.1")]
    _11,
    [EnumMember(Value = "1.2"), JsonStringEnumMemberName("1.2")]
    _12
}

/// <summary>WebHook: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestinationWebHook
{
    /// <summary>
    /// AzureActiveDirectoryApplicationIdOrUri: The Azure Active Directory Application ID or URI to get the access token that
    /// will be included as the bearer token in delivery requests.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUri")]
    public string? AzureActiveDirectoryApplicationIdOrUri { get; set; }

    /// <summary>
    /// AzureActiveDirectoryApplicationIdOrUriFromConfig: The Azure Active Directory Application ID or URI to get the access
    /// token that will be included as the bearer token in delivery requests.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUriFromConfig")]
    public V20250215EventSubscriptionSpecDestinationWebHookAzureActiveDirectoryApplicationIdOrUriFromConfig? AzureActiveDirectoryApplicationIdOrUriFromConfig { get; set; }

    /// <summary>
    /// AzureActiveDirectoryTenantId: The Azure Active Directory Tenant ID to get the access token that will be included as the
    /// bearer token in delivery requests.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryTenantId")]
    public string? AzureActiveDirectoryTenantId { get; set; }

    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionSpecDestinationWebHookDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public required V20250215EventSubscriptionSpecDestinationWebHookEndpointTypeEnum EndpointType { get; set; }

    /// <summary>EndpointUrl: The URL that represents the endpoint of the destination of an event subscription.</summary>
    [JsonPropertyName("endpointUrl")]
    public V20250215EventSubscriptionSpecDestinationWebHookEndpointUrl? EndpointUrl { get; set; }

    /// <summary>MaxEventsPerBatch: Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    /// <summary>MinimumTlsVersionAllowed: Minimum TLS version that should be supported by webhook endpoint</summary>
    [JsonPropertyName("minimumTlsVersionAllowed")]
    public V20250215EventSubscriptionSpecDestinationWebHookMinimumTlsVersionAllowedEnum? MinimumTlsVersionAllowed { get; set; }

    /// <summary>PreferredBatchSizeInKilobytes: Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>
/// Destination: Information about the destination where events have to be delivered for the event subscription.
/// Uses Azure Event Grid&apos;s identity to acquire the authentication tokens being used during delivery / dead-lettering.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecDestination
{
    /// <summary>AzureFunction: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureFunction")]
    public V20250215EventSubscriptionSpecDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>EventHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("eventHub")]
    public V20250215EventSubscriptionSpecDestinationEventHub? EventHub { get; set; }

    /// <summary>HybridConnection: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hybridConnection")]
    public V20250215EventSubscriptionSpecDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>MonitorAlert: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("monitorAlert")]
    public V20250215EventSubscriptionSpecDestinationMonitorAlert? MonitorAlert { get; set; }

    /// <summary>NamespaceTopic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("namespaceTopic")]
    public V20250215EventSubscriptionSpecDestinationNamespaceTopic? NamespaceTopic { get; set; }

    /// <summary>ServiceBusQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V20250215EventSubscriptionSpecDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>ServiceBusTopic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V20250215EventSubscriptionSpecDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>StorageQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageQueue")]
    public V20250215EventSubscriptionSpecDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>WebHook: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("webHook")]
    public V20250215EventSubscriptionSpecDestinationWebHook? WebHook { get; set; }
}

/// <summary>EventDeliverySchema: The event delivery schema for the event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecEventDeliverySchemaEnum>))]
public enum V20250215EventSubscriptionSpecEventDeliverySchemaEnum
{
    [EnumMember(Value = "CloudEventSchemaV1_0"), JsonStringEnumMemberName("CloudEventSchemaV1_0")]
    CloudEventSchemaV10,
    [EnumMember(Value = "CustomInputSchema"), JsonStringEnumMemberName("CustomInputSchema")]
    CustomInputSchema,
    [EnumMember(Value = "EventGridSchema"), JsonStringEnumMemberName("EventGridSchema")]
    EventGridSchema
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersBoolEqualsOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersBoolEqualsOperatorTypeEnum
{
    [EnumMember(Value = "BoolEquals"), JsonStringEnumMemberName("BoolEquals")]
    BoolEquals
}

/// <summary>BoolEquals: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersBoolEquals
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersBoolEqualsOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Value: The boolean filter value.</summary>
    [JsonPropertyName("value")]
    public bool? Value { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersIsNotNullOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersIsNotNullOperatorTypeEnum
{
    [EnumMember(Value = "IsNotNull"), JsonStringEnumMemberName("IsNotNull")]
    IsNotNull
}

/// <summary>IsNotNull: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersIsNotNull
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersIsNotNullOperatorTypeEnum OperatorType { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersIsNullOrUndefinedOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersIsNullOrUndefinedOperatorTypeEnum
{
    [EnumMember(Value = "IsNullOrUndefined"), JsonStringEnumMemberName("IsNullOrUndefined")]
    IsNullOrUndefined
}

/// <summary>IsNullOrUndefined: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersIsNullOrUndefined
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersIsNullOrUndefinedOperatorTypeEnum OperatorType { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOperatorTypeEnum
{
    [EnumMember(Value = "NumberGreaterThan"), JsonStringEnumMemberName("NumberGreaterThan")]
    NumberGreaterThan
}

/// <summary>NumberGreaterThan: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThan
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEqualsOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEqualsOperatorTypeEnum
{
    [EnumMember(Value = "NumberGreaterThanOrEquals"), JsonStringEnumMemberName("NumberGreaterThanOrEquals")]
    NumberGreaterThanOrEquals
}

/// <summary>NumberGreaterThanOrEquals: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEquals
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEqualsOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberInOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberInOperatorTypeEnum
{
    [EnumMember(Value = "NumberIn"), JsonStringEnumMemberName("NumberIn")]
    NumberIn
}

/// <summary>NumberIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberInOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberInRangeOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberInRangeOperatorTypeEnum
{
    [EnumMember(Value = "NumberInRange"), JsonStringEnumMemberName("NumberInRange")]
    NumberInRange
}

/// <summary>NumberInRange: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberInRange
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberInRangeOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOperatorTypeEnum
{
    [EnumMember(Value = "NumberLessThan"), JsonStringEnumMemberName("NumberLessThan")]
    NumberLessThan
}

/// <summary>NumberLessThan: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberLessThan
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEqualsOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEqualsOperatorTypeEnum
{
    [EnumMember(Value = "NumberLessThanOrEquals"), JsonStringEnumMemberName("NumberLessThanOrEquals")]
    NumberLessThanOrEquals
}

/// <summary>NumberLessThanOrEquals: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEquals
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEqualsOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Value: The filter value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberNotInOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberNotInOperatorTypeEnum
{
    [EnumMember(Value = "NumberNotIn"), JsonStringEnumMemberName("NumberNotIn")]
    NumberNotIn
}

/// <summary>NumberNotIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberNotIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberNotInOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<double>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberNotInRangeOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberNotInRangeOperatorTypeEnum
{
    [EnumMember(Value = "NumberNotInRange"), JsonStringEnumMemberName("NumberNotInRange")]
    NumberNotInRange
}

/// <summary>NumberNotInRange: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberNotInRange
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberNotInRangeOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersStringBeginsWithOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersStringBeginsWithOperatorTypeEnum
{
    [EnumMember(Value = "StringBeginsWith"), JsonStringEnumMemberName("StringBeginsWith")]
    StringBeginsWith
}

/// <summary>StringBeginsWith: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersStringBeginsWith
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersStringBeginsWithOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersStringContainsOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersStringContainsOperatorTypeEnum
{
    [EnumMember(Value = "StringContains"), JsonStringEnumMemberName("StringContains")]
    StringContains
}

/// <summary>StringContains: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersStringContains
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersStringContainsOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersStringEndsWithOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersStringEndsWithOperatorTypeEnum
{
    [EnumMember(Value = "StringEndsWith"), JsonStringEnumMemberName("StringEndsWith")]
    StringEndsWith
}

/// <summary>StringEndsWith: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersStringEndsWith
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersStringEndsWithOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersStringInOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersStringInOperatorTypeEnum
{
    [EnumMember(Value = "StringIn"), JsonStringEnumMemberName("StringIn")]
    StringIn
}

/// <summary>StringIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersStringIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersStringInOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotBeginsWithOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotBeginsWithOperatorTypeEnum
{
    [EnumMember(Value = "StringNotBeginsWith"), JsonStringEnumMemberName("StringNotBeginsWith")]
    StringNotBeginsWith
}

/// <summary>StringNotBeginsWith: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotBeginsWith
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotBeginsWithOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotContainsOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotContainsOperatorTypeEnum
{
    [EnumMember(Value = "StringNotContains"), JsonStringEnumMemberName("StringNotContains")]
    StringNotContains
}

/// <summary>StringNotContains: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotContains
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotContainsOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotEndsWithOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotEndsWithOperatorTypeEnum
{
    [EnumMember(Value = "StringNotEndsWith"), JsonStringEnumMemberName("StringNotEndsWith")]
    StringNotEndsWith
}

/// <summary>StringNotEndsWith: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotEndsWith
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotEndsWithOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotInOperatorTypeEnum>))]
public enum V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotInOperatorTypeEnum
{
    [EnumMember(Value = "StringNotIn"), JsonStringEnumMemberName("StringNotIn")]
    StringNotIn
}

/// <summary>StringNotIn: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotIn
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public required V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotInOperatorTypeEnum OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilterAdvancedFilters
{
    /// <summary>BoolEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("boolEquals")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersBoolEquals? BoolEquals { get; set; }

    /// <summary>IsNotNull: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("isNotNull")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersIsNotNull? IsNotNull { get; set; }

    /// <summary>IsNullOrUndefined: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersIsNullOrUndefined? IsNullOrUndefined { get; set; }

    /// <summary>NumberGreaterThan: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberGreaterThan")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThan? NumberGreaterThan { get; set; }

    /// <summary>NumberGreaterThanOrEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEquals? NumberGreaterThanOrEquals { get; set; }

    /// <summary>NumberIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberIn")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberIn? NumberIn { get; set; }

    /// <summary>NumberInRange: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberInRange")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberInRange? NumberInRange { get; set; }

    /// <summary>NumberLessThan: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberLessThan")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberLessThan? NumberLessThan { get; set; }

    /// <summary>NumberLessThanOrEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEquals? NumberLessThanOrEquals { get; set; }

    /// <summary>NumberNotIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberNotIn")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberNotIn? NumberNotIn { get; set; }

    /// <summary>NumberNotInRange: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberNotInRange")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersNumberNotInRange? NumberNotInRange { get; set; }

    /// <summary>StringBeginsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringBeginsWith")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersStringBeginsWith? StringBeginsWith { get; set; }

    /// <summary>StringContains: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringContains")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersStringContains? StringContains { get; set; }

    /// <summary>StringEndsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringEndsWith")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersStringEndsWith? StringEndsWith { get; set; }

    /// <summary>StringIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringIn")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersStringIn? StringIn { get; set; }

    /// <summary>StringNotBeginsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotBeginsWith? StringNotBeginsWith { get; set; }

    /// <summary>StringNotContains: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringNotContains")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotContains? StringNotContains { get; set; }

    /// <summary>StringNotEndsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotEndsWith? StringNotEndsWith { get; set; }

    /// <summary>StringNotIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringNotIn")]
    public V20250215EventSubscriptionSpecFilterAdvancedFiltersStringNotIn? StringNotIn { get; set; }
}

/// <summary>Filter: Information about the filter for the event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecFilter
{
    /// <summary>AdvancedFilters: An array of advanced filters that are used for filtering event subscriptions.</summary>
    [JsonPropertyName("advancedFilters")]
    public IList<V20250215EventSubscriptionSpecFilterAdvancedFilters>? AdvancedFilters { get; set; }

    /// <summary>
    /// EnableAdvancedFilteringOnArrays: Allows advanced filters to be evaluated against an array of values instead of expecting
    /// a singular value.
    /// </summary>
    [JsonPropertyName("enableAdvancedFilteringOnArrays")]
    public bool? EnableAdvancedFilteringOnArrays { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecOperatorSpecConfigMapExpressions
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
public partial class V20250215EventSubscriptionSpecOperatorSpecSecretExpressions
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
public partial class V20250215EventSubscriptionSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250215EventSubscriptionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250215EventSubscriptionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
/// extension resource, which means that any other Azure resource can be its owner.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecOwner
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpecRetryPolicy
{
    /// <summary>EventTimeToLiveInMinutes: Time To Live (in minutes) for events.</summary>
    [JsonPropertyName("eventTimeToLiveInMinutes")]
    public int? EventTimeToLiveInMinutes { get; set; }

    /// <summary>MaxDeliveryAttempts: Maximum number of delivery retry attempts for events.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public int? MaxDeliveryAttempts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// DeadLetterDestination: The dead letter destination of the event subscription. Any event that cannot be delivered to its&apos;
    /// destination is sent to the dead letter destination.
    /// Uses Azure Event Grid&apos;s identity to acquire the authentication tokens being used during delivery / dead-lettering.
    /// </summary>
    [JsonPropertyName("deadLetterDestination")]
    public V20250215EventSubscriptionSpecDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>
    /// DeadLetterWithResourceIdentity: The dead letter destination of the event subscription. Any event that cannot be
    /// delivered to its&apos; destination is sent to the dead letter destination.
    /// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
    /// being used during delivery / dead-lettering.
    /// </summary>
    [JsonPropertyName("deadLetterWithResourceIdentity")]
    public V20250215EventSubscriptionSpecDeadLetterWithResourceIdentity? DeadLetterWithResourceIdentity { get; set; }

    /// <summary>
    /// DeliveryWithResourceIdentity: Information about the destination where events have to be delivered for the event
    /// subscription.
    /// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
    /// being used during delivery / dead-lettering.
    /// </summary>
    [JsonPropertyName("deliveryWithResourceIdentity")]
    public V20250215EventSubscriptionSpecDeliveryWithResourceIdentity? DeliveryWithResourceIdentity { get; set; }

    /// <summary>
    /// Destination: Information about the destination where events have to be delivered for the event subscription.
    /// Uses Azure Event Grid&apos;s identity to acquire the authentication tokens being used during delivery / dead-lettering.
    /// </summary>
    [JsonPropertyName("destination")]
    public V20250215EventSubscriptionSpecDestination? Destination { get; set; }

    /// <summary>EventDeliverySchema: The event delivery schema for the event subscription.</summary>
    [JsonPropertyName("eventDeliverySchema")]
    public V20250215EventSubscriptionSpecEventDeliverySchemaEnum? EventDeliverySchema { get; set; }

    /// <summary>ExpirationTimeUtc: Expiration time of the event subscription.</summary>
    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>Filter: Information about the filter for the event subscription.</summary>
    [JsonPropertyName("filter")]
    public V20250215EventSubscriptionSpecFilter? Filter { get; set; }

    /// <summary>Labels: List of user defined labels.</summary>
    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250215EventSubscriptionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
    /// extension resource, which means that any other Azure resource can be its owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250215EventSubscriptionSpecOwner Owner { get; set; }

    /// <summary>
    /// RetryPolicy: The retry policy for events. This can be used to configure maximum number of delivery attempts and time to
    /// live for events.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V20250215EventSubscriptionSpecRetryPolicy? RetryPolicy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeadLetterDestinationStorageBlob
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

/// <summary>
/// DeadLetterDestination: The dead letter destination of the event subscription. Any event that cannot be delivered to its&apos;
/// destination is sent to the dead letter destination.
/// Uses Azure Event Grid&apos;s identity to acquire the authentication tokens being used during delivery / dead-lettering.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeadLetterDestination
{
    /// <summary>StorageBlob: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageBlob")]
    public V20250215EventSubscriptionStatusDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>StorageBlob: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlob
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

/// <summary>
/// DeadLetterDestination: Information about the destination where events have to be delivered for the event subscription.
/// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
/// being used during dead-lettering.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeadLetterWithResourceIdentityDeadLetterDestination
{
    /// <summary>StorageBlob: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageBlob")]
    public V20250215EventSubscriptionStatusDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>Identity: The identity to use when dead-lettering events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeadLetterWithResourceIdentityIdentity
{
    /// <summary>Type: The type of managed identity used. Can be either &apos;SystemAssigned&apos; or &apos;UserAssigned&apos;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentity: The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// DeadLetterWithResourceIdentity: The dead letter destination of the event subscription. Any event that cannot be
/// delivered to its&apos; destination is sent to the dead letter destination.
/// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
/// being used during delivery / dead-lettering.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeadLetterWithResourceIdentity
{
    /// <summary>
    /// DeadLetterDestination: Information about the destination where events have to be delivered for the event subscription.
    /// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
    /// being used during dead-lettering.
    /// </summary>
    [JsonPropertyName("deadLetterDestination")]
    public V20250215EventSubscriptionStatusDeadLetterWithResourceIdentityDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>Identity: The identity to use when dead-lettering events.</summary>
    [JsonPropertyName("identity")]
    public V20250215EventSubscriptionStatusDeadLetterWithResourceIdentityIdentity? Identity { get; set; }
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>AzureFunction: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunction
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

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

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EventHub: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHub
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceId: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event subscription.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>HybridConnection: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnection
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceId: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>MonitorAlert: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationMonitorAlert
{
    /// <summary>
    /// ActionGroups: The list of ARM Ids of Action Groups that will be triggered on every Alert fired through this event
    /// subscription.
    /// Each resource ARM Id should follow this pattern:
    /// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Insights/actionGroups/{ActionGroupName}.
    /// </summary>
    [JsonPropertyName("actionGroups")]
    public IList<string>? ActionGroups { get; set; }

    /// <summary>Description: The description that will be attached to every Alert fired through this event subscription.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// Severity: The severity that will be attached to every Alert fired through this event subscription.
    /// This field must be provided.
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

/// <summary>NamespaceTopic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationNamespaceTopic
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceId: The Azure resource Id that represents the endpoint of the Event Grid Namespace Topic destination of an event
    /// subscription.
    /// This field is required and the Namespace Topic resource listed must already exist.
    /// The resource ARM Id should follow this pattern:
    /// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.EventGrid/namespaces/{NamespaceName}/topics/{TopicName}.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>ServiceBusQueue: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueue
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceId: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event subscription.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>ServiceBusTopic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopic
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationStorageQueue
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// QueueMessageTimeToLiveInSeconds: Storage queue message time to live in seconds. This value cannot be zero or negative
    /// with the exception of using -1 to indicate that the Time To Live of the message is Infinite.
    /// </summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public int? QueueMessageTimeToLiveInSeconds { get; set; }

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

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>WebHook: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHook
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

    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointBaseUrl: The base URL that represents the endpoint of the destination of an event subscription.</summary>
    [JsonPropertyName("endpointBaseUrl")]
    public string? EndpointBaseUrl { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>MaxEventsPerBatch: Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    /// <summary>MinimumTlsVersionAllowed: Minimum TLS version that should be supported by webhook endpoint</summary>
    [JsonPropertyName("minimumTlsVersionAllowed")]
    public string? MinimumTlsVersionAllowed { get; set; }

    /// <summary>PreferredBatchSizeInKilobytes: Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>
/// Destination: Information about the destination where events have to be delivered for the event subscription.
/// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
/// being used during delivery.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestination
{
    /// <summary>AzureFunction: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureFunction")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>EventHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("eventHub")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHub? EventHub { get; set; }

    /// <summary>HybridConnection: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hybridConnection")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>MonitorAlert: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("monitorAlert")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationMonitorAlert? MonitorAlert { get; set; }

    /// <summary>NamespaceTopic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("namespaceTopic")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationNamespaceTopic? NamespaceTopic { get; set; }

    /// <summary>ServiceBusQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>ServiceBusTopic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>StorageQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageQueue")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>WebHook: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("webHook")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHook? WebHook { get; set; }
}

/// <summary>Identity: The identity to use when delivering events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentityIdentity
{
    /// <summary>Type: The type of managed identity used. Can be either &apos;SystemAssigned&apos; or &apos;UserAssigned&apos;.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentity: The user identity associated with the resource.</summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// DeliveryWithResourceIdentity: Information about the destination where events have to be delivered for the event
/// subscription.
/// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
/// being used during delivery / dead-lettering.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDeliveryWithResourceIdentity
{
    /// <summary>
    /// Destination: Information about the destination where events have to be delivered for the event subscription.
    /// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
    /// being used during delivery.
    /// </summary>
    [JsonPropertyName("destination")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityDestination? Destination { get; set; }

    /// <summary>Identity: The identity to use when delivering events.</summary>
    [JsonPropertyName("identity")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentityIdentity? Identity { get; set; }
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>AzureFunction: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationAzureFunction
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

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

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationEventHubDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationEventHubDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationEventHubDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDestinationEventHubDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDestinationEventHubDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>EventHub: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationEventHub
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDestinationEventHubDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceId: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event subscription.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>HybridConnection: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationHybridConnection
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceId: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>MonitorAlert: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationMonitorAlert
{
    /// <summary>
    /// ActionGroups: The list of ARM Ids of Action Groups that will be triggered on every Alert fired through this event
    /// subscription.
    /// Each resource ARM Id should follow this pattern:
    /// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Insights/actionGroups/{ActionGroupName}.
    /// </summary>
    [JsonPropertyName("actionGroups")]
    public IList<string>? ActionGroups { get; set; }

    /// <summary>Description: The description that will be attached to every Alert fired through this event subscription.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// Severity: The severity that will be attached to every Alert fired through this event subscription.
    /// This field must be provided.
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

/// <summary>NamespaceTopic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationNamespaceTopic
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceId: The Azure resource Id that represents the endpoint of the Event Grid Namespace Topic destination of an event
    /// subscription.
    /// This field is required and the Namespace Topic resource listed must already exist.
    /// The resource ARM Id should follow this pattern:
    /// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.EventGrid/namespaces/{NamespaceName}/topics/{TopicName}.
    /// </summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>ServiceBusQueue: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationServiceBusQueue
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceId: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event subscription.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>ServiceBusTopic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationServiceBusTopic
{
    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationStorageQueue
{
    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// QueueMessageTimeToLiveInSeconds: Storage queue message time to live in seconds. This value cannot be zero or negative
    /// with the exception of using -1 to indicate that the Time To Live of the message is Infinite.
    /// </summary>
    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public int? QueueMessageTimeToLiveInSeconds { get; set; }

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

/// <summary>Dynamic: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationWebHookDeliveryAttributeMappingsDynamic
{
    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SourceField: JSON path in the event which contains attribute value.</summary>
    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Static: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationWebHookDeliveryAttributeMappingsStatic
{
    /// <summary>IsSecret: Boolean flag to tell if the attribute contains sensitive information .</summary>
    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    /// <summary>Name: Name of the delivery attribute or header.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: Type of the delivery attribute or header name.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Value: Value of the delivery attribute.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationWebHookDeliveryAttributeMappings
{
    /// <summary>Dynamic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("dynamic")]
    public V20250215EventSubscriptionStatusDestinationWebHookDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Static: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("static")]
    public V20250215EventSubscriptionStatusDestinationWebHookDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>WebHook: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestinationWebHook
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

    /// <summary>DeliveryAttributeMappings: Delivery attribute details.</summary>
    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215EventSubscriptionStatusDestinationWebHookDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    /// <summary>EndpointBaseUrl: The base URL that represents the endpoint of the destination of an event subscription.</summary>
    [JsonPropertyName("endpointBaseUrl")]
    public string? EndpointBaseUrl { get; set; }

    /// <summary>EndpointType: Type of the endpoint for the event subscription destination.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>MaxEventsPerBatch: Maximum number of events per batch.</summary>
    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    /// <summary>MinimumTlsVersionAllowed: Minimum TLS version that should be supported by webhook endpoint</summary>
    [JsonPropertyName("minimumTlsVersionAllowed")]
    public string? MinimumTlsVersionAllowed { get; set; }

    /// <summary>PreferredBatchSizeInKilobytes: Preferred batch size in Kilobytes.</summary>
    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>
/// Destination: Information about the destination where events have to be delivered for the event subscription.
/// Uses Azure Event Grid&apos;s identity to acquire the authentication tokens being used during delivery / dead-lettering.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusDestination
{
    /// <summary>AzureFunction: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("azureFunction")]
    public V20250215EventSubscriptionStatusDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>EventHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("eventHub")]
    public V20250215EventSubscriptionStatusDestinationEventHub? EventHub { get; set; }

    /// <summary>HybridConnection: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("hybridConnection")]
    public V20250215EventSubscriptionStatusDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>MonitorAlert: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("monitorAlert")]
    public V20250215EventSubscriptionStatusDestinationMonitorAlert? MonitorAlert { get; set; }

    /// <summary>NamespaceTopic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("namespaceTopic")]
    public V20250215EventSubscriptionStatusDestinationNamespaceTopic? NamespaceTopic { get; set; }

    /// <summary>ServiceBusQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V20250215EventSubscriptionStatusDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>ServiceBusTopic: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V20250215EventSubscriptionStatusDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>StorageQueue: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("storageQueue")]
    public V20250215EventSubscriptionStatusDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>WebHook: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("webHook")]
    public V20250215EventSubscriptionStatusDestinationWebHook? WebHook { get; set; }
}

/// <summary>BoolEquals: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersBoolEquals
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

/// <summary>IsNotNull: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersIsNotNull
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }
}

/// <summary>IsNullOrUndefined: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersIsNullOrUndefined
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }
}

/// <summary>NumberGreaterThan: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThan
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThanOrEquals
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberIn
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

/// <summary>NumberInRange: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberInRange
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

/// <summary>NumberLessThan: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberLessThan
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberLessThanOrEquals
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberNotIn
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

/// <summary>NumberNotInRange: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberNotInRange
{
    /// <summary>Key: The field/property in the event based on which you want to filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>OperatorType: The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others.</summary>
    [JsonPropertyName("operatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Values: The set of filter values.</summary>
    [JsonPropertyName("values")]
    public IList<IList<double>>? Values { get; set; }
}

/// <summary>StringBeginsWith: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersStringBeginsWith
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersStringContains
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersStringEndsWith
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersStringIn
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

/// <summary>StringNotBeginsWith: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersStringNotBeginsWith
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

/// <summary>StringNotContains: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersStringNotContains
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

/// <summary>StringNotEndsWith: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersStringNotEndsWith
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFiltersStringNotIn
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilterAdvancedFilters
{
    /// <summary>BoolEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("boolEquals")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersBoolEquals? BoolEquals { get; set; }

    /// <summary>IsNotNull: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("isNotNull")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersIsNotNull? IsNotNull { get; set; }

    /// <summary>IsNullOrUndefined: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersIsNullOrUndefined? IsNullOrUndefined { get; set; }

    /// <summary>NumberGreaterThan: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberGreaterThan")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThan? NumberGreaterThan { get; set; }

    /// <summary>NumberGreaterThanOrEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThanOrEquals? NumberGreaterThanOrEquals { get; set; }

    /// <summary>NumberIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberIn")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberIn? NumberIn { get; set; }

    /// <summary>NumberInRange: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberInRange")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberInRange? NumberInRange { get; set; }

    /// <summary>NumberLessThan: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberLessThan")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberLessThan? NumberLessThan { get; set; }

    /// <summary>NumberLessThanOrEquals: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberLessThanOrEquals? NumberLessThanOrEquals { get; set; }

    /// <summary>NumberNotIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberNotIn")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberNotIn? NumberNotIn { get; set; }

    /// <summary>NumberNotInRange: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("numberNotInRange")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersNumberNotInRange? NumberNotInRange { get; set; }

    /// <summary>StringBeginsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringBeginsWith")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersStringBeginsWith? StringBeginsWith { get; set; }

    /// <summary>StringContains: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringContains")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersStringContains? StringContains { get; set; }

    /// <summary>StringEndsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringEndsWith")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersStringEndsWith? StringEndsWith { get; set; }

    /// <summary>StringIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringIn")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersStringIn? StringIn { get; set; }

    /// <summary>StringNotBeginsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersStringNotBeginsWith? StringNotBeginsWith { get; set; }

    /// <summary>StringNotContains: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringNotContains")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersStringNotContains? StringNotContains { get; set; }

    /// <summary>StringNotEndsWith: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersStringNotEndsWith? StringNotEndsWith { get; set; }

    /// <summary>StringNotIn: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("stringNotIn")]
    public V20250215EventSubscriptionStatusFilterAdvancedFiltersStringNotIn? StringNotIn { get; set; }
}

/// <summary>Filter: Information about the filter for the event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusFilter
{
    /// <summary>AdvancedFilters: An array of advanced filters that are used for filtering event subscriptions.</summary>
    [JsonPropertyName("advancedFilters")]
    public IList<V20250215EventSubscriptionStatusFilterAdvancedFilters>? AdvancedFilters { get; set; }

    /// <summary>
    /// EnableAdvancedFilteringOnArrays: Allows advanced filters to be evaluated against an array of values instead of expecting
    /// a singular value.
    /// </summary>
    [JsonPropertyName("enableAdvancedFilteringOnArrays")]
    public bool? EnableAdvancedFilteringOnArrays { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusRetryPolicy
{
    /// <summary>EventTimeToLiveInMinutes: Time To Live (in minutes) for events.</summary>
    [JsonPropertyName("eventTimeToLiveInMinutes")]
    public int? EventTimeToLiveInMinutes { get; set; }

    /// <summary>MaxDeliveryAttempts: Maximum number of delivery retry attempts for events.</summary>
    [JsonPropertyName("maxDeliveryAttempts")]
    public int? MaxDeliveryAttempts { get; set; }
}

/// <summary>SystemData: The system metadata relating to the Event Grid resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatusSystemData
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

/// <summary>Event Subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215EventSubscriptionStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250215EventSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// DeadLetterDestination: The dead letter destination of the event subscription. Any event that cannot be delivered to its&apos;
    /// destination is sent to the dead letter destination.
    /// Uses Azure Event Grid&apos;s identity to acquire the authentication tokens being used during delivery / dead-lettering.
    /// </summary>
    [JsonPropertyName("deadLetterDestination")]
    public V20250215EventSubscriptionStatusDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>
    /// DeadLetterWithResourceIdentity: The dead letter destination of the event subscription. Any event that cannot be
    /// delivered to its&apos; destination is sent to the dead letter destination.
    /// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
    /// being used during delivery / dead-lettering.
    /// </summary>
    [JsonPropertyName("deadLetterWithResourceIdentity")]
    public V20250215EventSubscriptionStatusDeadLetterWithResourceIdentity? DeadLetterWithResourceIdentity { get; set; }

    /// <summary>
    /// DeliveryWithResourceIdentity: Information about the destination where events have to be delivered for the event
    /// subscription.
    /// Uses the managed identity setup on the parent resource (namely, topic or domain) to acquire the authentication tokens
    /// being used during delivery / dead-lettering.
    /// </summary>
    [JsonPropertyName("deliveryWithResourceIdentity")]
    public V20250215EventSubscriptionStatusDeliveryWithResourceIdentity? DeliveryWithResourceIdentity { get; set; }

    /// <summary>
    /// Destination: Information about the destination where events have to be delivered for the event subscription.
    /// Uses Azure Event Grid&apos;s identity to acquire the authentication tokens being used during delivery / dead-lettering.
    /// </summary>
    [JsonPropertyName("destination")]
    public V20250215EventSubscriptionStatusDestination? Destination { get; set; }

    /// <summary>EventDeliverySchema: The event delivery schema for the event subscription.</summary>
    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    /// <summary>ExpirationTimeUtc: Expiration time of the event subscription.</summary>
    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>Filter: Information about the filter for the event subscription.</summary>
    [JsonPropertyName("filter")]
    public V20250215EventSubscriptionStatusFilter? Filter { get; set; }

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
    public V20250215EventSubscriptionStatusRetryPolicy? RetryPolicy { get; set; }

    /// <summary>SystemData: The system metadata relating to the Event Grid resource.</summary>
    [JsonPropertyName("systemData")]
    public V20250215EventSubscriptionStatusSystemData? SystemData { get; set; }

    /// <summary>Topic: Name of the topic of the event subscription.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Type: Type of the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2025-02-15/EventGrid.json
/// - ARM URI: /{scope}/providers/Microsoft.EventGrid/eventSubscriptions/{eventSubscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250215EventSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V20250215EventSubscriptionSpec?>, IStatus<V20250215EventSubscriptionStatus?>
{
    public const string KubeApiVersion = "v20250215";
    public const string KubeKind = "EventSubscription";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "eventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20250215";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSubscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250215EventSubscriptionSpec? Spec { get; set; }

    /// <summary>Event Subscription.</summary>
    [JsonPropertyName("status")]
    public V20250215EventSubscriptionStatus? Status { get; set; }
}