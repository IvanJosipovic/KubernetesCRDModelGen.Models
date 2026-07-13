#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kusto.azure.com;
/// <summary>
/// Storage version of v1api20240413.DataConnection
/// Generator information:
/// - Generated from: /azure-kusto/resource-manager/Microsoft.Kusto/Kusto/stable/2024-04-13/kusto.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240413storageDataConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1api20240413storageDataConnection>
{
    public const string KubeApiVersion = "v1api20240413storage";
    public const string KubeKind = "DataConnectionList";
    public const string KubeGroup = "kusto.azure.com";
    public const string KubePluralName = "dataconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kusto.azure.com/v1api20240413storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240413storageDataConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240413storageDataConnection> Items { get; set; }
}

/// <summary>CosmosDbAccountResourceReference: The resource ID of the Cosmos DB account used to create the data connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecCosmosDbDataConnectionCosmosDbAccountResourceReference
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

/// <summary>
/// ManagedIdentityResourceReference: The resource ID of a managed system or user-assigned identity. The identity is used to
/// authenticate with Cosmos DB.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecCosmosDbDataConnectionManagedIdentityResourceReference
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

/// <summary>Storage version of v1api20240413.CosmosDbDataConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecCosmosDbDataConnection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>CosmosDbAccountResourceReference: The resource ID of the Cosmos DB account used to create the data connection.</summary>
    [JsonPropertyName("cosmosDbAccountResourceReference")]
    public required V1api20240413storageDataConnectionSpecCosmosDbDataConnectionCosmosDbAccountResourceReference CosmosDbAccountResourceReference { get; set; }

    [JsonPropertyName("cosmosDbContainer")]
    public string? CosmosDbContainer { get; set; }

    [JsonPropertyName("cosmosDbDatabase")]
    public string? CosmosDbDatabase { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ManagedIdentityResourceReference: The resource ID of a managed system or user-assigned identity. The identity is used to
    /// authenticate with Cosmos DB.
    /// </summary>
    [JsonPropertyName("managedIdentityResourceReference")]
    public required V1api20240413storageDataConnectionSpecCosmosDbDataConnectionManagedIdentityResourceReference ManagedIdentityResourceReference { get; set; }

    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>EventGridResourceReference: The resource ID of the event grid that is subscribed to the storage account events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecEventGridDataConnectionEventGridResourceReference
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

/// <summary>EventHubResourceReference: The resource ID where the event grid is configured to send events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecEventGridDataConnectionEventHubResourceReference
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

/// <summary>
/// ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to
/// authenticate with event hub and storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecEventGridDataConnectionManagedIdentityResourceReference
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

/// <summary>StorageAccountResourceReference: The resource ID of the storage account where the data resides.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecEventGridDataConnectionStorageAccountResourceReference
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

/// <summary>Storage version of v1api20240413.EventGridDataConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecEventGridDataConnection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobStorageEventType")]
    public string? BlobStorageEventType { get; set; }

    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    /// <summary>EventGridResourceReference: The resource ID of the event grid that is subscribed to the storage account events.</summary>
    [JsonPropertyName("eventGridResourceReference")]
    public V1api20240413storageDataConnectionSpecEventGridDataConnectionEventGridResourceReference? EventGridResourceReference { get; set; }

    /// <summary>EventHubResourceReference: The resource ID where the event grid is configured to send events.</summary>
    [JsonPropertyName("eventHubResourceReference")]
    public required V1api20240413storageDataConnectionSpecEventGridDataConnectionEventHubResourceReference EventHubResourceReference { get; set; }

    [JsonPropertyName("ignoreFirstRecord")]
    public bool? IgnoreFirstRecord { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to
    /// authenticate with event hub and storage account.
    /// </summary>
    [JsonPropertyName("managedIdentityResourceReference")]
    public V1api20240413storageDataConnectionSpecEventGridDataConnectionManagedIdentityResourceReference? ManagedIdentityResourceReference { get; set; }

    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary>StorageAccountResourceReference: The resource ID of the storage account where the data resides.</summary>
    [JsonPropertyName("storageAccountResourceReference")]
    public required V1api20240413storageDataConnectionSpecEventGridDataConnectionStorageAccountResourceReference StorageAccountResourceReference { get; set; }

    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>EventHubResourceReference: The resource ID of the event hub to be used to create a data connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecEventHubDataConnectionEventHubResourceReference
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

/// <summary>
/// ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to
/// authenticate with event hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecEventHubDataConnectionManagedIdentityResourceReference
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

/// <summary>Storage version of v1api20240413.EventHubDataConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecEventHubDataConnection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    /// <summary>EventHubResourceReference: The resource ID of the event hub to be used to create a data connection.</summary>
    [JsonPropertyName("eventHubResourceReference")]
    public required V1api20240413storageDataConnectionSpecEventHubDataConnectionEventHubResourceReference EventHubResourceReference { get; set; }

    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to
    /// authenticate with event hub.
    /// </summary>
    [JsonPropertyName("managedIdentityResourceReference")]
    public V1api20240413storageDataConnectionSpecEventHubDataConnectionManagedIdentityResourceReference? ManagedIdentityResourceReference { get; set; }

    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>IotHubResourceReference: The resource ID of the Iot hub to be used to create a data connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecIotHubDataConnectionIotHubResourceReference
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

/// <summary>Storage version of v1api20240413.IotHubDataConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecIotHubDataConnection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    /// <summary>IotHubResourceReference: The resource ID of the Iot hub to be used to create a data connection.</summary>
    [JsonPropertyName("iotHubResourceReference")]
    public required V1api20240413storageDataConnectionSpecIotHubDataConnectionIotHubResourceReference IotHubResourceReference { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    [JsonPropertyName("sharedAccessPolicyName")]
    public string? SharedAccessPolicyName { get; set; }

    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240413storageDataConnectionSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20240413.DataConnectionOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240413storageDataConnectionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240413storageDataConnectionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a kusto.azure.com/Database resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240413.DataConnection_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionSpec
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

    /// <summary>Storage version of v1api20240413.CosmosDbDataConnection</summary>
    [JsonPropertyName("cosmosDbDataConnection")]
    public V1api20240413storageDataConnectionSpecCosmosDbDataConnection? CosmosDbDataConnection { get; set; }

    /// <summary>Storage version of v1api20240413.EventGridDataConnection</summary>
    [JsonPropertyName("eventGridDataConnection")]
    public V1api20240413storageDataConnectionSpecEventGridDataConnection? EventGridDataConnection { get; set; }

    /// <summary>Storage version of v1api20240413.EventHubDataConnection</summary>
    [JsonPropertyName("eventHubDataConnection")]
    public V1api20240413storageDataConnectionSpecEventHubDataConnection? EventHubDataConnection { get; set; }

    /// <summary>Storage version of v1api20240413.IotHubDataConnection</summary>
    [JsonPropertyName("iotHubDataConnection")]
    public V1api20240413storageDataConnectionSpecIotHubDataConnection? IotHubDataConnection { get; set; }

    /// <summary>
    /// Storage version of v1api20240413.DataConnectionOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240413storageDataConnectionSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a kusto.azure.com/Database resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240413storageDataConnectionSpecOwner Owner { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionStatusConditions
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

/// <summary>Storage version of v1api20240413.CosmosDbDataConnection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionStatusCosmosDb
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cosmosDbAccountResourceId")]
    public string? CosmosDbAccountResourceId { get; set; }

    [JsonPropertyName("cosmosDbContainer")]
    public string? CosmosDbContainer { get; set; }

    [JsonPropertyName("cosmosDbDatabase")]
    public string? CosmosDbDatabase { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("managedIdentityObjectId")]
    public string? ManagedIdentityObjectId { get; set; }

    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240413.EventGridDataConnection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionStatusEventGrid
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobStorageEventType")]
    public string? BlobStorageEventType { get; set; }

    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    [JsonPropertyName("eventGridResourceId")]
    public string? EventGridResourceId { get; set; }

    [JsonPropertyName("eventHubResourceId")]
    public string? EventHubResourceId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("ignoreFirstRecord")]
    public bool? IgnoreFirstRecord { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("managedIdentityObjectId")]
    public string? ManagedIdentityObjectId { get; set; }

    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("storageAccountResourceId")]
    public string? StorageAccountResourceId { get; set; }

    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240413.EventHubDataConnection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionStatusEventHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    [JsonPropertyName("eventHubResourceId")]
    public string? EventHubResourceId { get; set; }

    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("managedIdentityObjectId")]
    public string? ManagedIdentityObjectId { get; set; }

    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240413.IotHubDataConnection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionStatusIotHub
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("iotHubResourceId")]
    public string? IotHubResourceId { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    [JsonPropertyName("sharedAccessPolicyName")]
    public string? SharedAccessPolicyName { get; set; }

    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240413.DataConnection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413storageDataConnectionStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20240413storageDataConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20240413.CosmosDbDataConnection_STATUS</summary>
    [JsonPropertyName("cosmosDb")]
    public V1api20240413storageDataConnectionStatusCosmosDb? CosmosDb { get; set; }

    /// <summary>Storage version of v1api20240413.EventGridDataConnection_STATUS</summary>
    [JsonPropertyName("eventGrid")]
    public V1api20240413storageDataConnectionStatusEventGrid? EventGrid { get; set; }

    /// <summary>Storage version of v1api20240413.EventHubDataConnection_STATUS</summary>
    [JsonPropertyName("eventHub")]
    public V1api20240413storageDataConnectionStatusEventHub? EventHub { get; set; }

    /// <summary>Storage version of v1api20240413.IotHubDataConnection_STATUS</summary>
    [JsonPropertyName("iotHub")]
    public V1api20240413storageDataConnectionStatusIotHub? IotHub { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20240413.DataConnection
/// Generator information:
/// - Generated from: /azure-kusto/resource-manager/Microsoft.Kusto/Kusto/stable/2024-04-13/kusto.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240413storageDataConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240413storageDataConnectionSpec?>, IStatus<V1api20240413storageDataConnectionStatus?>
{
    public const string KubeApiVersion = "v1api20240413storage";
    public const string KubeKind = "DataConnection";
    public const string KubeGroup = "kusto.azure.com";
    public const string KubePluralName = "dataconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kusto.azure.com/v1api20240413storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240413.DataConnection_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240413storageDataConnectionSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240413.DataConnection_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240413storageDataConnectionStatus? Status { get; set; }
}