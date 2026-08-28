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
/// Storage version of v20250215.EventSubscription
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2025-02-15/EventGrid.json
/// - ARM URI: /{scope}/providers/Microsoft.EventGrid/eventSubscriptions/{eventSubscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250215storageEventSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V20250215storageEventSubscription>
{
    public const string KubeApiVersion = "v20250215storage";
    public const string KubeKind = "EventSubscriptionList";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "eventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20250215storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSubscriptionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250215storageEventSubscription objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250215storageEventSubscription> Items { get; set; }
}

/// <summary>ResourceReference: The Azure Resource ID of the storage account that is the destination of the deadletter events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeadLetterDestinationStorageBlobResourceReference
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

/// <summary>Storage version of v20250215.StorageBlobDeadLetterDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeadLetterDestinationStorageBlob
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
    public V20250215storageEventSubscriptionSpecDeadLetterDestinationStorageBlobResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20250215.DeadLetterDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeadLetterDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.StorageBlobDeadLetterDestination</summary>
    [JsonPropertyName("storageBlob")]
    public V20250215storageEventSubscriptionSpecDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>ResourceReference: The Azure Resource ID of the storage account that is the destination of the deadletter events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlobResourceReference
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

/// <summary>Storage version of v20250215.StorageBlobDeadLetterDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlob
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
    public V20250215storageEventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlobResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20250215.DeadLetterDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.StorageBlobDeadLetterDestination</summary>
    [JsonPropertyName("storageBlob")]
    public V20250215storageEventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>
/// Storage version of v20250215.EventSubscriptionIdentity
/// The identity information with the event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeadLetterWithResourceIdentityIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// Storage version of v20250215.DeadLetterWithResourceIdentity
/// Information about the deadletter destination with resource identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeadLetterWithResourceIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DeadLetterDestination</summary>
    [JsonPropertyName("deadLetterDestination")]
    public V20250215storageEventSubscriptionSpecDeadLetterWithResourceIdentityDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>
    /// Storage version of v20250215.EventSubscriptionIdentity
    /// The identity information with the event subscription.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250215storageEventSubscriptionSpecDeadLetterWithResourceIdentityIdentity? Identity { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Azure Function destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionResourceReference
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

/// <summary>Storage version of v20250215.AzureFunctionEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

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
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunctionResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubResourceReference
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

/// <summary>Storage version of v20250215.EventHubEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHubResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionResourceReference
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

/// <summary>Storage version of v20250215.HybridConnectionEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnectionResourceReference? ResourceReference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlertActionGroupsReferences
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

/// <summary>Storage version of v20250215.MonitorAlertEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlert
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionGroupsReferences")]
    public IList<V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlertActionGroupsReferences>? ActionGroupsReferences { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
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
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationNamespaceTopicResourceReference
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

/// <summary>Storage version of v20250215.NamespaceTopicEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationNamespaceTopic
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
    /// ResourceReference: The Azure resource Id that represents the endpoint of the Event Grid Namespace Topic destination of
    /// an event subscription.
    /// This field is required and the Namespace Topic resource listed must already exist.
    /// The resource ARM Id should follow this pattern:
    /// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.EventGrid/namespaces/{NamespaceName}/topics/{TopicName}.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationNamespaceTopicResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueResourceReference
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

/// <summary>Storage version of v20250215.ServiceBusQueueEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicResourceReference
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

/// <summary>Storage version of v20250215.ServiceBusTopicEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopicResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueueQueueNameFromConfig
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
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueueResourceReference
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

/// <summary>Storage version of v20250215.StorageQueueEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public int? QueueMessageTimeToLiveInSeconds { get; set; }

    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("queueNameFromConfig")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueueQueueNameFromConfig? QueueNameFromConfig { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource ID of the storage account that contains the queue that is the destination of an
    /// event subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookAzureActiveDirectoryApplicationIdOrUriFromConfig
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

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookEndpointUrl
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

/// <summary>Storage version of v20250215.WebHookEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHook
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUri")]
    public string? AzureActiveDirectoryApplicationIdOrUri { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUriFromConfig")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookAzureActiveDirectoryApplicationIdOrUriFromConfig? AzureActiveDirectoryApplicationIdOrUriFromConfig { get; set; }

    [JsonPropertyName("azureActiveDirectoryTenantId")]
    public string? AzureActiveDirectoryTenantId { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("endpointUrl")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHookEndpointUrl? EndpointUrl { get; set; }

    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    [JsonPropertyName("minimumTlsVersionAllowed")]
    public string? MinimumTlsVersionAllowed { get; set; }

    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>Storage version of v20250215.EventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.AzureFunctionEventSubscriptionDestination</summary>
    [JsonPropertyName("azureFunction")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>Storage version of v20250215.EventHubEventSubscriptionDestination</summary>
    [JsonPropertyName("eventHub")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationEventHub? EventHub { get; set; }

    /// <summary>Storage version of v20250215.HybridConnectionEventSubscriptionDestination</summary>
    [JsonPropertyName("hybridConnection")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>Storage version of v20250215.MonitorAlertEventSubscriptionDestination</summary>
    [JsonPropertyName("monitorAlert")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationMonitorAlert? MonitorAlert { get; set; }

    /// <summary>Storage version of v20250215.NamespaceTopicEventSubscriptionDestination</summary>
    [JsonPropertyName("namespaceTopic")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationNamespaceTopic? NamespaceTopic { get; set; }

    /// <summary>Storage version of v20250215.ServiceBusQueueEventSubscriptionDestination</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>Storage version of v20250215.ServiceBusTopicEventSubscriptionDestination</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>Storage version of v20250215.StorageQueueEventSubscriptionDestination</summary>
    [JsonPropertyName("storageQueue")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>Storage version of v20250215.WebHookEventSubscriptionDestination</summary>
    [JsonPropertyName("webHook")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestinationWebHook? WebHook { get; set; }
}

/// <summary>
/// Storage version of v20250215.EventSubscriptionIdentity
/// The identity information with the event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// Storage version of v20250215.DeliveryWithResourceIdentity
/// Information about the delivery for an event subscription with resource identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.EventSubscriptionDestination</summary>
    [JsonPropertyName("destination")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityDestination? Destination { get; set; }

    /// <summary>
    /// Storage version of v20250215.EventSubscriptionIdentity
    /// The identity information with the event subscription.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentityIdentity? Identity { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Azure Function destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationAzureFunctionResourceReference
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

/// <summary>Storage version of v20250215.AzureFunctionEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationAzureFunction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDestinationAzureFunctionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

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
    public V20250215storageEventSubscriptionSpecDestinationAzureFunctionResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationEventHubDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDestinationEventHubDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationEventHubResourceReference
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

/// <summary>Storage version of v20250215.EventHubEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationEventHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDestinationEventHubDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of an Event Hub destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDestinationEventHubResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationHybridConnectionResourceReference
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

/// <summary>Storage version of v20250215.HybridConnectionEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationHybridConnection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDestinationHybridConnectionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>ResourceReference: The Azure Resource ID of an hybrid connection that is the destination of an event subscription.</summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDestinationHybridConnectionResourceReference? ResourceReference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationMonitorAlertActionGroupsReferences
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

/// <summary>Storage version of v20250215.MonitorAlertEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationMonitorAlert
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionGroupsReferences")]
    public IList<V20250215storageEventSubscriptionSpecDestinationMonitorAlertActionGroupsReferences>? ActionGroupsReferences { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
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
public partial class V20250215storageEventSubscriptionSpecDestinationNamespaceTopicResourceReference
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

/// <summary>Storage version of v20250215.NamespaceTopicEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationNamespaceTopic
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
    /// ResourceReference: The Azure resource Id that represents the endpoint of the Event Grid Namespace Topic destination of
    /// an event subscription.
    /// This field is required and the Namespace Topic resource listed must already exist.
    /// The resource ARM Id should follow this pattern:
    /// /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.EventGrid/namespaces/{NamespaceName}/topics/{TopicName}.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDestinationNamespaceTopicResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationServiceBusQueueResourceReference
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

/// <summary>Storage version of v20250215.ServiceBusQueueEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationServiceBusQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDestinationServiceBusQueueDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDestinationServiceBusQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>
/// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
/// subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationServiceBusTopicResourceReference
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

/// <summary>Storage version of v20250215.ServiceBusTopicEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationServiceBusTopic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDestinationServiceBusTopicDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource Id that represents the endpoint of the Service Bus Topic destination of an event
    /// subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDestinationServiceBusTopicResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationStorageQueueQueueNameFromConfig
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
public partial class V20250215storageEventSubscriptionSpecDestinationStorageQueueResourceReference
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

/// <summary>Storage version of v20250215.StorageQueueEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationStorageQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public int? QueueMessageTimeToLiveInSeconds { get; set; }

    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("queueNameFromConfig")]
    public V20250215storageEventSubscriptionSpecDestinationStorageQueueQueueNameFromConfig? QueueNameFromConfig { get; set; }

    /// <summary>
    /// ResourceReference: The Azure Resource ID of the storage account that contains the queue that is the destination of an
    /// event subscription.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public V20250215storageEventSubscriptionSpecDestinationStorageQueueResourceReference? ResourceReference { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationWebHookAzureActiveDirectoryApplicationIdOrUriFromConfig
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

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationWebHookDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionSpecDestinationWebHookDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationWebHookEndpointUrl
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

/// <summary>Storage version of v20250215.WebHookEventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestinationWebHook
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUri")]
    public string? AzureActiveDirectoryApplicationIdOrUri { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("azureActiveDirectoryApplicationIdOrUriFromConfig")]
    public V20250215storageEventSubscriptionSpecDestinationWebHookAzureActiveDirectoryApplicationIdOrUriFromConfig? AzureActiveDirectoryApplicationIdOrUriFromConfig { get; set; }

    [JsonPropertyName("azureActiveDirectoryTenantId")]
    public string? AzureActiveDirectoryTenantId { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionSpecDestinationWebHookDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("endpointUrl")]
    public V20250215storageEventSubscriptionSpecDestinationWebHookEndpointUrl? EndpointUrl { get; set; }

    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    [JsonPropertyName("minimumTlsVersionAllowed")]
    public string? MinimumTlsVersionAllowed { get; set; }

    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>Storage version of v20250215.EventSubscriptionDestination</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.AzureFunctionEventSubscriptionDestination</summary>
    [JsonPropertyName("azureFunction")]
    public V20250215storageEventSubscriptionSpecDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>Storage version of v20250215.EventHubEventSubscriptionDestination</summary>
    [JsonPropertyName("eventHub")]
    public V20250215storageEventSubscriptionSpecDestinationEventHub? EventHub { get; set; }

    /// <summary>Storage version of v20250215.HybridConnectionEventSubscriptionDestination</summary>
    [JsonPropertyName("hybridConnection")]
    public V20250215storageEventSubscriptionSpecDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>Storage version of v20250215.MonitorAlertEventSubscriptionDestination</summary>
    [JsonPropertyName("monitorAlert")]
    public V20250215storageEventSubscriptionSpecDestinationMonitorAlert? MonitorAlert { get; set; }

    /// <summary>Storage version of v20250215.NamespaceTopicEventSubscriptionDestination</summary>
    [JsonPropertyName("namespaceTopic")]
    public V20250215storageEventSubscriptionSpecDestinationNamespaceTopic? NamespaceTopic { get; set; }

    /// <summary>Storage version of v20250215.ServiceBusQueueEventSubscriptionDestination</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V20250215storageEventSubscriptionSpecDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>Storage version of v20250215.ServiceBusTopicEventSubscriptionDestination</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V20250215storageEventSubscriptionSpecDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>Storage version of v20250215.StorageQueueEventSubscriptionDestination</summary>
    [JsonPropertyName("storageQueue")]
    public V20250215storageEventSubscriptionSpecDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>Storage version of v20250215.WebHookEventSubscriptionDestination</summary>
    [JsonPropertyName("webHook")]
    public V20250215storageEventSubscriptionSpecDestinationWebHook? WebHook { get; set; }
}

/// <summary>Storage version of v20250215.BoolEqualsAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersBoolEquals
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

/// <summary>Storage version of v20250215.IsNotNullAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersIsNotNull
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
}

/// <summary>Storage version of v20250215.IsNullOrUndefinedAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersIsNullOrUndefined
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
}

/// <summary>Storage version of v20250215.NumberGreaterThanAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThan
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

/// <summary>Storage version of v20250215.NumberGreaterThanOrEqualsAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEquals
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

/// <summary>Storage version of v20250215.NumberInAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberIn
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

/// <summary>Storage version of v20250215.NumberInRangeAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberInRange
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
    public IList<IList<double>>? Values { get; set; }
}

/// <summary>Storage version of v20250215.NumberLessThanAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberLessThan
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

/// <summary>Storage version of v20250215.NumberLessThanOrEqualsAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEquals
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

/// <summary>Storage version of v20250215.NumberNotInAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberNotIn
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

/// <summary>Storage version of v20250215.NumberNotInRangeAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberNotInRange
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
    public IList<IList<double>>? Values { get; set; }
}

/// <summary>Storage version of v20250215.StringBeginsWithAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringBeginsWith
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

/// <summary>Storage version of v20250215.StringContainsAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringContains
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

/// <summary>Storage version of v20250215.StringEndsWithAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringEndsWith
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

/// <summary>Storage version of v20250215.StringInAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringIn
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

/// <summary>Storage version of v20250215.StringNotBeginsWithAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringNotBeginsWith
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

/// <summary>Storage version of v20250215.StringNotContainsAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringNotContains
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

/// <summary>Storage version of v20250215.StringNotEndsWithAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringNotEndsWith
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

/// <summary>Storage version of v20250215.StringNotInAdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringNotIn
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

/// <summary>Storage version of v20250215.AdvancedFilter</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilterAdvancedFilters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.BoolEqualsAdvancedFilter</summary>
    [JsonPropertyName("boolEquals")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersBoolEquals? BoolEquals { get; set; }

    /// <summary>Storage version of v20250215.IsNotNullAdvancedFilter</summary>
    [JsonPropertyName("isNotNull")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersIsNotNull? IsNotNull { get; set; }

    /// <summary>Storage version of v20250215.IsNullOrUndefinedAdvancedFilter</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersIsNullOrUndefined? IsNullOrUndefined { get; set; }

    /// <summary>Storage version of v20250215.NumberGreaterThanAdvancedFilter</summary>
    [JsonPropertyName("numberGreaterThan")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThan? NumberGreaterThan { get; set; }

    /// <summary>Storage version of v20250215.NumberGreaterThanOrEqualsAdvancedFilter</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberGreaterThanOrEquals? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Storage version of v20250215.NumberInAdvancedFilter</summary>
    [JsonPropertyName("numberIn")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberIn? NumberIn { get; set; }

    /// <summary>Storage version of v20250215.NumberInRangeAdvancedFilter</summary>
    [JsonPropertyName("numberInRange")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberInRange? NumberInRange { get; set; }

    /// <summary>Storage version of v20250215.NumberLessThanAdvancedFilter</summary>
    [JsonPropertyName("numberLessThan")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberLessThan? NumberLessThan { get; set; }

    /// <summary>Storage version of v20250215.NumberLessThanOrEqualsAdvancedFilter</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberLessThanOrEquals? NumberLessThanOrEquals { get; set; }

    /// <summary>Storage version of v20250215.NumberNotInAdvancedFilter</summary>
    [JsonPropertyName("numberNotIn")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberNotIn? NumberNotIn { get; set; }

    /// <summary>Storage version of v20250215.NumberNotInRangeAdvancedFilter</summary>
    [JsonPropertyName("numberNotInRange")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersNumberNotInRange? NumberNotInRange { get; set; }

    /// <summary>Storage version of v20250215.StringBeginsWithAdvancedFilter</summary>
    [JsonPropertyName("stringBeginsWith")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringBeginsWith? StringBeginsWith { get; set; }

    /// <summary>Storage version of v20250215.StringContainsAdvancedFilter</summary>
    [JsonPropertyName("stringContains")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringContains? StringContains { get; set; }

    /// <summary>Storage version of v20250215.StringEndsWithAdvancedFilter</summary>
    [JsonPropertyName("stringEndsWith")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringEndsWith? StringEndsWith { get; set; }

    /// <summary>Storage version of v20250215.StringInAdvancedFilter</summary>
    [JsonPropertyName("stringIn")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringIn? StringIn { get; set; }

    /// <summary>Storage version of v20250215.StringNotBeginsWithAdvancedFilter</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringNotBeginsWith? StringNotBeginsWith { get; set; }

    /// <summary>Storage version of v20250215.StringNotContainsAdvancedFilter</summary>
    [JsonPropertyName("stringNotContains")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringNotContains? StringNotContains { get; set; }

    /// <summary>Storage version of v20250215.StringNotEndsWithAdvancedFilter</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringNotEndsWith? StringNotEndsWith { get; set; }

    /// <summary>Storage version of v20250215.StringNotInAdvancedFilter</summary>
    [JsonPropertyName("stringNotIn")]
    public V20250215storageEventSubscriptionSpecFilterAdvancedFiltersStringNotIn? StringNotIn { get; set; }
}

/// <summary>
/// Storage version of v20250215.EventSubscriptionFilter
/// Filter for the Event Subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecFilter
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("advancedFilters")]
    public IList<V20250215storageEventSubscriptionSpecFilterAdvancedFilters>? AdvancedFilters { get; set; }

    [JsonPropertyName("enableAdvancedFilteringOnArrays")]
    public bool? EnableAdvancedFilteringOnArrays { get; set; }

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
public partial class V20250215storageEventSubscriptionSpecOperatorSpecConfigMapExpressions
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
public partial class V20250215storageEventSubscriptionSpecOperatorSpecSecretExpressions
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
/// Storage version of v20250215.EventSubscriptionOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20250215storageEventSubscriptionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20250215storageEventSubscriptionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
/// extension resource, which means that any other Azure resource can be its owner.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecOwner
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
/// Storage version of v20250215.RetryPolicy
/// Information about the retry policy for an event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpecRetryPolicy
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

/// <summary>Storage version of v20250215.EventSubscription_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionSpec
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

    /// <summary>Storage version of v20250215.DeadLetterDestination</summary>
    [JsonPropertyName("deadLetterDestination")]
    public V20250215storageEventSubscriptionSpecDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>
    /// Storage version of v20250215.DeadLetterWithResourceIdentity
    /// Information about the deadletter destination with resource identity.
    /// </summary>
    [JsonPropertyName("deadLetterWithResourceIdentity")]
    public V20250215storageEventSubscriptionSpecDeadLetterWithResourceIdentity? DeadLetterWithResourceIdentity { get; set; }

    /// <summary>
    /// Storage version of v20250215.DeliveryWithResourceIdentity
    /// Information about the delivery for an event subscription with resource identity.
    /// </summary>
    [JsonPropertyName("deliveryWithResourceIdentity")]
    public V20250215storageEventSubscriptionSpecDeliveryWithResourceIdentity? DeliveryWithResourceIdentity { get; set; }

    /// <summary>Storage version of v20250215.EventSubscriptionDestination</summary>
    [JsonPropertyName("destination")]
    public V20250215storageEventSubscriptionSpecDestination? Destination { get; set; }

    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>
    /// Storage version of v20250215.EventSubscriptionFilter
    /// Filter for the Event Subscription.
    /// </summary>
    [JsonPropertyName("filter")]
    public V20250215storageEventSubscriptionSpecFilter? Filter { get; set; }

    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    /// <summary>
    /// Storage version of v20250215.EventSubscriptionOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250215storageEventSubscriptionSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. This resource is an
    /// extension resource, which means that any other Azure resource can be its owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250215storageEventSubscriptionSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20250215.RetryPolicy
    /// Information about the retry policy for an event subscription.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V20250215storageEventSubscriptionSpecRetryPolicy? RetryPolicy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusConditions
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

/// <summary>Storage version of v20250215.StorageBlobDeadLetterDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeadLetterDestinationStorageBlob
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

/// <summary>Storage version of v20250215.DeadLetterDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeadLetterDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.StorageBlobDeadLetterDestination_STATUS</summary>
    [JsonPropertyName("storageBlob")]
    public V20250215storageEventSubscriptionStatusDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>Storage version of v20250215.StorageBlobDeadLetterDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlob
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

/// <summary>Storage version of v20250215.DeadLetterDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeadLetterWithResourceIdentityDeadLetterDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.StorageBlobDeadLetterDestination_STATUS</summary>
    [JsonPropertyName("storageBlob")]
    public V20250215storageEventSubscriptionStatusDeadLetterWithResourceIdentityDeadLetterDestinationStorageBlob? StorageBlob { get; set; }
}

/// <summary>
/// Storage version of v20250215.EventSubscriptionIdentity_STATUS
/// The identity information with the event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeadLetterWithResourceIdentityIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// Storage version of v20250215.DeadLetterWithResourceIdentity_STATUS
/// Information about the deadletter destination with resource identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeadLetterWithResourceIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DeadLetterDestination_STATUS</summary>
    [JsonPropertyName("deadLetterDestination")]
    public V20250215storageEventSubscriptionStatusDeadLetterWithResourceIdentityDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>
    /// Storage version of v20250215.EventSubscriptionIdentity_STATUS
    /// The identity information with the event subscription.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250215storageEventSubscriptionStatusDeadLetterWithResourceIdentityIdentity? Identity { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.AzureFunctionEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunctionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.EventHubEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHubDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.HybridConnectionEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnectionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.MonitorAlertEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationMonitorAlert
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionGroups")]
    public IList<string>? ActionGroups { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

/// <summary>Storage version of v20250215.NamespaceTopicEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationNamespaceTopic
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

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.ServiceBusQueueEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueueDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.ServiceBusTopicEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopicDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.StorageQueueEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationStorageQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public int? QueueMessageTimeToLiveInSeconds { get; set; }

    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.WebHookEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHook
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

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHookDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointBaseUrl")]
    public string? EndpointBaseUrl { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    [JsonPropertyName("minimumTlsVersionAllowed")]
    public string? MinimumTlsVersionAllowed { get; set; }

    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>Storage version of v20250215.EventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.AzureFunctionEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("azureFunction")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>Storage version of v20250215.EventHubEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("eventHub")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationEventHub? EventHub { get; set; }

    /// <summary>Storage version of v20250215.HybridConnectionEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("hybridConnection")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>Storage version of v20250215.MonitorAlertEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("monitorAlert")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationMonitorAlert? MonitorAlert { get; set; }

    /// <summary>Storage version of v20250215.NamespaceTopicEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("namespaceTopic")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationNamespaceTopic? NamespaceTopic { get; set; }

    /// <summary>Storage version of v20250215.ServiceBusQueueEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>Storage version of v20250215.ServiceBusTopicEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>Storage version of v20250215.StorageQueueEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("storageQueue")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>Storage version of v20250215.WebHookEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("webHook")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestinationWebHook? WebHook { get; set; }
}

/// <summary>
/// Storage version of v20250215.EventSubscriptionIdentity_STATUS
/// The identity information with the event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// Storage version of v20250215.DeliveryWithResourceIdentity_STATUS
/// Information about the delivery for an event subscription with resource identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.EventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("destination")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityDestination? Destination { get; set; }

    /// <summary>
    /// Storage version of v20250215.EventSubscriptionIdentity_STATUS
    /// The identity information with the event subscription.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentityIdentity? Identity { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.AzureFunctionEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationAzureFunction
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDestinationAzureFunctionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationEventHubDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationEventHubDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationEventHubDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDestinationEventHubDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDestinationEventHubDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.EventHubEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationEventHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDestinationEventHubDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.HybridConnectionEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationHybridConnection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDestinationHybridConnectionDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.MonitorAlertEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationMonitorAlert
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("actionGroups")]
    public IList<string>? ActionGroups { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
}

/// <summary>Storage version of v20250215.NamespaceTopicEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationNamespaceTopic
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

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.ServiceBusQueueEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationServiceBusQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDestinationServiceBusQueueDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.ServiceBusTopicEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationServiceBusTopic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDestinationServiceBusTopicDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.StorageQueueEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationStorageQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("queueMessageTimeToLiveInSeconds")]
    public int? QueueMessageTimeToLiveInSeconds { get; set; }

    [JsonPropertyName("queueName")]
    public string? QueueName { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationWebHookDeliveryAttributeMappingsDynamic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("sourceField")]
    public string? SourceField { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationWebHookDeliveryAttributeMappingsStatic
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSecret")]
    public bool? IsSecret { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250215.DeliveryAttributeMapping_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationWebHookDeliveryAttributeMappings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.DynamicDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("dynamic")]
    public V20250215storageEventSubscriptionStatusDestinationWebHookDeliveryAttributeMappingsDynamic? Dynamic { get; set; }

    /// <summary>Storage version of v20250215.StaticDeliveryAttributeMapping_STATUS</summary>
    [JsonPropertyName("static")]
    public V20250215storageEventSubscriptionStatusDestinationWebHookDeliveryAttributeMappingsStatic? Static { get; set; }
}

/// <summary>Storage version of v20250215.WebHookEventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestinationWebHook
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

    [JsonPropertyName("deliveryAttributeMappings")]
    public IList<V20250215storageEventSubscriptionStatusDestinationWebHookDeliveryAttributeMappings>? DeliveryAttributeMappings { get; set; }

    [JsonPropertyName("endpointBaseUrl")]
    public string? EndpointBaseUrl { get; set; }

    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    [JsonPropertyName("maxEventsPerBatch")]
    public int? MaxEventsPerBatch { get; set; }

    [JsonPropertyName("minimumTlsVersionAllowed")]
    public string? MinimumTlsVersionAllowed { get; set; }

    [JsonPropertyName("preferredBatchSizeInKilobytes")]
    public int? PreferredBatchSizeInKilobytes { get; set; }
}

/// <summary>Storage version of v20250215.EventSubscriptionDestination_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusDestination
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.AzureFunctionEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("azureFunction")]
    public V20250215storageEventSubscriptionStatusDestinationAzureFunction? AzureFunction { get; set; }

    /// <summary>Storage version of v20250215.EventHubEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("eventHub")]
    public V20250215storageEventSubscriptionStatusDestinationEventHub? EventHub { get; set; }

    /// <summary>Storage version of v20250215.HybridConnectionEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("hybridConnection")]
    public V20250215storageEventSubscriptionStatusDestinationHybridConnection? HybridConnection { get; set; }

    /// <summary>Storage version of v20250215.MonitorAlertEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("monitorAlert")]
    public V20250215storageEventSubscriptionStatusDestinationMonitorAlert? MonitorAlert { get; set; }

    /// <summary>Storage version of v20250215.NamespaceTopicEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("namespaceTopic")]
    public V20250215storageEventSubscriptionStatusDestinationNamespaceTopic? NamespaceTopic { get; set; }

    /// <summary>Storage version of v20250215.ServiceBusQueueEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("serviceBusQueue")]
    public V20250215storageEventSubscriptionStatusDestinationServiceBusQueue? ServiceBusQueue { get; set; }

    /// <summary>Storage version of v20250215.ServiceBusTopicEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("serviceBusTopic")]
    public V20250215storageEventSubscriptionStatusDestinationServiceBusTopic? ServiceBusTopic { get; set; }

    /// <summary>Storage version of v20250215.StorageQueueEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("storageQueue")]
    public V20250215storageEventSubscriptionStatusDestinationStorageQueue? StorageQueue { get; set; }

    /// <summary>Storage version of v20250215.WebHookEventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("webHook")]
    public V20250215storageEventSubscriptionStatusDestinationWebHook? WebHook { get; set; }
}

/// <summary>Storage version of v20250215.BoolEqualsAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersBoolEquals
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

/// <summary>Storage version of v20250215.IsNotNullAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersIsNotNull
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
}

/// <summary>Storage version of v20250215.IsNullOrUndefinedAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersIsNullOrUndefined
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
}

/// <summary>Storage version of v20250215.NumberGreaterThanAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThan
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

/// <summary>Storage version of v20250215.NumberGreaterThanOrEqualsAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThanOrEquals
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

/// <summary>Storage version of v20250215.NumberInAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberIn
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

/// <summary>Storage version of v20250215.NumberInRangeAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberInRange
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
    public IList<IList<double>>? Values { get; set; }
}

/// <summary>Storage version of v20250215.NumberLessThanAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberLessThan
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

/// <summary>Storage version of v20250215.NumberLessThanOrEqualsAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberLessThanOrEquals
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

/// <summary>Storage version of v20250215.NumberNotInAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberNotIn
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

/// <summary>Storage version of v20250215.NumberNotInRangeAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberNotInRange
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
    public IList<IList<double>>? Values { get; set; }
}

/// <summary>Storage version of v20250215.StringBeginsWithAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringBeginsWith
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

/// <summary>Storage version of v20250215.StringContainsAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringContains
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

/// <summary>Storage version of v20250215.StringEndsWithAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringEndsWith
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

/// <summary>Storage version of v20250215.StringInAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringIn
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

/// <summary>Storage version of v20250215.StringNotBeginsWithAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringNotBeginsWith
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

/// <summary>Storage version of v20250215.StringNotContainsAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringNotContains
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

/// <summary>Storage version of v20250215.StringNotEndsWithAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringNotEndsWith
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

/// <summary>Storage version of v20250215.StringNotInAdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringNotIn
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

/// <summary>Storage version of v20250215.AdvancedFilter_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilterAdvancedFilters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250215.BoolEqualsAdvancedFilter_STATUS</summary>
    [JsonPropertyName("boolEquals")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersBoolEquals? BoolEquals { get; set; }

    /// <summary>Storage version of v20250215.IsNotNullAdvancedFilter_STATUS</summary>
    [JsonPropertyName("isNotNull")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersIsNotNull? IsNotNull { get; set; }

    /// <summary>Storage version of v20250215.IsNullOrUndefinedAdvancedFilter_STATUS</summary>
    [JsonPropertyName("isNullOrUndefined")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersIsNullOrUndefined? IsNullOrUndefined { get; set; }

    /// <summary>Storage version of v20250215.NumberGreaterThanAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberGreaterThan")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThan? NumberGreaterThan { get; set; }

    /// <summary>Storage version of v20250215.NumberGreaterThanOrEqualsAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberGreaterThanOrEquals")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberGreaterThanOrEquals? NumberGreaterThanOrEquals { get; set; }

    /// <summary>Storage version of v20250215.NumberInAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberIn")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberIn? NumberIn { get; set; }

    /// <summary>Storage version of v20250215.NumberInRangeAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberInRange")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberInRange? NumberInRange { get; set; }

    /// <summary>Storage version of v20250215.NumberLessThanAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberLessThan")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberLessThan? NumberLessThan { get; set; }

    /// <summary>Storage version of v20250215.NumberLessThanOrEqualsAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberLessThanOrEquals")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberLessThanOrEquals? NumberLessThanOrEquals { get; set; }

    /// <summary>Storage version of v20250215.NumberNotInAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberNotIn")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberNotIn? NumberNotIn { get; set; }

    /// <summary>Storage version of v20250215.NumberNotInRangeAdvancedFilter_STATUS</summary>
    [JsonPropertyName("numberNotInRange")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersNumberNotInRange? NumberNotInRange { get; set; }

    /// <summary>Storage version of v20250215.StringBeginsWithAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringBeginsWith")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringBeginsWith? StringBeginsWith { get; set; }

    /// <summary>Storage version of v20250215.StringContainsAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringContains")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringContains? StringContains { get; set; }

    /// <summary>Storage version of v20250215.StringEndsWithAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringEndsWith")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringEndsWith? StringEndsWith { get; set; }

    /// <summary>Storage version of v20250215.StringInAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringIn")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringIn? StringIn { get; set; }

    /// <summary>Storage version of v20250215.StringNotBeginsWithAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringNotBeginsWith")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringNotBeginsWith? StringNotBeginsWith { get; set; }

    /// <summary>Storage version of v20250215.StringNotContainsAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringNotContains")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringNotContains? StringNotContains { get; set; }

    /// <summary>Storage version of v20250215.StringNotEndsWithAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringNotEndsWith")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringNotEndsWith? StringNotEndsWith { get; set; }

    /// <summary>Storage version of v20250215.StringNotInAdvancedFilter_STATUS</summary>
    [JsonPropertyName("stringNotIn")]
    public V20250215storageEventSubscriptionStatusFilterAdvancedFiltersStringNotIn? StringNotIn { get; set; }
}

/// <summary>
/// Storage version of v20250215.EventSubscriptionFilter_STATUS
/// Filter for the Event Subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusFilter
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("advancedFilters")]
    public IList<V20250215storageEventSubscriptionStatusFilterAdvancedFilters>? AdvancedFilters { get; set; }

    [JsonPropertyName("enableAdvancedFilteringOnArrays")]
    public bool? EnableAdvancedFilteringOnArrays { get; set; }

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
/// Storage version of v20250215.RetryPolicy_STATUS
/// Information about the retry policy for an event subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusRetryPolicy
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
/// Storage version of v20250215.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatusSystemData
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
/// Storage version of v20250215.EventSubscription_STATUS
/// Event Subscription.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250215storageEventSubscriptionStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20250215storageEventSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v20250215.DeadLetterDestination_STATUS</summary>
    [JsonPropertyName("deadLetterDestination")]
    public V20250215storageEventSubscriptionStatusDeadLetterDestination? DeadLetterDestination { get; set; }

    /// <summary>
    /// Storage version of v20250215.DeadLetterWithResourceIdentity_STATUS
    /// Information about the deadletter destination with resource identity.
    /// </summary>
    [JsonPropertyName("deadLetterWithResourceIdentity")]
    public V20250215storageEventSubscriptionStatusDeadLetterWithResourceIdentity? DeadLetterWithResourceIdentity { get; set; }

    /// <summary>
    /// Storage version of v20250215.DeliveryWithResourceIdentity_STATUS
    /// Information about the delivery for an event subscription with resource identity.
    /// </summary>
    [JsonPropertyName("deliveryWithResourceIdentity")]
    public V20250215storageEventSubscriptionStatusDeliveryWithResourceIdentity? DeliveryWithResourceIdentity { get; set; }

    /// <summary>Storage version of v20250215.EventSubscriptionDestination_STATUS</summary>
    [JsonPropertyName("destination")]
    public V20250215storageEventSubscriptionStatusDestination? Destination { get; set; }

    [JsonPropertyName("eventDeliverySchema")]
    public string? EventDeliverySchema { get; set; }

    [JsonPropertyName("expirationTimeUtc")]
    public string? ExpirationTimeUtc { get; set; }

    /// <summary>
    /// Storage version of v20250215.EventSubscriptionFilter_STATUS
    /// Filter for the Event Subscription.
    /// </summary>
    [JsonPropertyName("filter")]
    public V20250215storageEventSubscriptionStatusFilter? Filter { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("labels")]
    public IList<string>? Labels { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// Storage version of v20250215.RetryPolicy_STATUS
    /// Information about the retry policy for an event subscription.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public V20250215storageEventSubscriptionStatusRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Storage version of v20250215.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20250215storageEventSubscriptionStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250215.EventSubscription
/// Generator information:
/// - Generated from: /eventgrid/resource-manager/Microsoft.EventGrid/EventGrid/stable/2025-02-15/EventGrid.json
/// - ARM URI: /{scope}/providers/Microsoft.EventGrid/eventSubscriptions/{eventSubscriptionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250215storageEventSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V20250215storageEventSubscriptionSpec?>, IStatus<V20250215storageEventSubscriptionStatus?>
{
    public const string KubeApiVersion = "v20250215storage";
    public const string KubeKind = "EventSubscription";
    public const string KubeGroup = "eventgrid.azure.com";
    public const string KubePluralName = "eventsubscriptions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventgrid.azure.com/v20250215storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EventSubscription";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20250215.EventSubscription_Spec</summary>
    [JsonPropertyName("spec")]
    public V20250215storageEventSubscriptionSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20250215.EventSubscription_STATUS
    /// Event Subscription.
    /// </summary>
    [JsonPropertyName("status")]
    public V20250215storageEventSubscriptionStatus? Status { get; set; }
}