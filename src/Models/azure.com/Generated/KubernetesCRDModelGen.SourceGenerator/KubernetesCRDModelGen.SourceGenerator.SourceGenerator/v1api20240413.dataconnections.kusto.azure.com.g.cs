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
/// Generator information:
/// - Generated from: /azure-kusto/resource-manager/Microsoft.Kusto/Kusto/stable/2024-04-13/kusto.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240413DataConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1api20240413DataConnection>
{
    public const string KubeApiVersion = "v1api20240413";
    public const string KubeKind = "DataConnectionList";
    public const string KubeGroup = "kusto.azure.com";
    public const string KubePluralName = "dataconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kusto.azure.com/v1api20240413";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240413DataConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240413DataConnection> Items { get; set; }
}

/// <summary>CosmosDbAccountResourceReference: The resource ID of the Cosmos DB account used to create the data connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpecCosmosDbDataConnectionCosmosDbAccountResourceReference
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

/// <summary>Kind: Kind of the endpoint for the data connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecCosmosDbDataConnectionKindEnum>))]
public enum V1api20240413DataConnectionSpecCosmosDbDataConnectionKindEnum
{
    [EnumMember(Value = "CosmosDb"), JsonStringEnumMemberName("CosmosDb")]
    CosmosDb
}

/// <summary>
/// ManagedIdentityResourceReference: The resource ID of a managed system or user-assigned identity. The identity is used to
/// authenticate with Cosmos DB.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpecCosmosDbDataConnectionManagedIdentityResourceReference
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

/// <summary>CosmosDb: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpecCosmosDbDataConnection
{
    /// <summary>CosmosDbAccountResourceReference: The resource ID of the Cosmos DB account used to create the data connection.</summary>
    [JsonPropertyName("cosmosDbAccountResourceReference")]
    public required V1api20240413DataConnectionSpecCosmosDbDataConnectionCosmosDbAccountResourceReference CosmosDbAccountResourceReference { get; set; }

    /// <summary>CosmosDbContainer: The name of an existing container in the Cosmos DB database.</summary>
    [JsonPropertyName("cosmosDbContainer")]
    public required string CosmosDbContainer { get; set; }

    /// <summary>CosmosDbDatabase: The name of an existing database in the Cosmos DB account.</summary>
    [JsonPropertyName("cosmosDbDatabase")]
    public required string CosmosDbDatabase { get; set; }

    /// <summary>Kind: Kind of the endpoint for the data connection</summary>
    [JsonPropertyName("kind")]
    public required V1api20240413DataConnectionSpecCosmosDbDataConnectionKindEnum Kind { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ManagedIdentityResourceReference: The resource ID of a managed system or user-assigned identity. The identity is used to
    /// authenticate with Cosmos DB.
    /// </summary>
    [JsonPropertyName("managedIdentityResourceReference")]
    public required V1api20240413DataConnectionSpecCosmosDbDataConnectionManagedIdentityResourceReference ManagedIdentityResourceReference { get; set; }

    /// <summary>MappingRuleName: The name of an existing mapping rule to use when ingesting the retrieved data.</summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary>
    /// RetrievalStartDate: Optional. If defined, the data connection retrieves Cosmos DB documents created or updated after the
    /// specified retrieval start date.
    /// </summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary>
    /// TableName: The case-sensitive name of the existing target table in your cluster. Retrieved data is ingested into this
    /// table.
    /// </summary>
    [JsonPropertyName("tableName")]
    public required string TableName { get; set; }
}

/// <summary>BlobStorageEventType: The name of blob storage event type to process.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecEventGridDataConnectionBlobStorageEventTypeEnum>))]
public enum V1api20240413DataConnectionSpecEventGridDataConnectionBlobStorageEventTypeEnum
{
    [EnumMember(Value = "Microsoft.Storage.BlobCreated"), JsonStringEnumMemberName("Microsoft.Storage.BlobCreated")]
    MicrosoftStorageBlobCreated,
    [EnumMember(Value = "Microsoft.Storage.BlobRenamed"), JsonStringEnumMemberName("Microsoft.Storage.BlobRenamed")]
    MicrosoftStorageBlobRenamed
}

/// <summary>DataFormat: The data format of the message. Optionally the data format can be added to each message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecEventGridDataConnectionDataFormatEnum>))]
public enum V1api20240413DataConnectionSpecEventGridDataConnectionDataFormatEnum
{
    [EnumMember(Value = "APACHEAVRO"), JsonStringEnumMemberName("APACHEAVRO")]
    APACHEAVRO,
    [EnumMember(Value = "AVRO"), JsonStringEnumMemberName("AVRO")]
    AVRO,
    [EnumMember(Value = "CSV"), JsonStringEnumMemberName("CSV")]
    CSV,
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON,
    [EnumMember(Value = "MULTIJSON"), JsonStringEnumMemberName("MULTIJSON")]
    MULTIJSON,
    [EnumMember(Value = "ORC"), JsonStringEnumMemberName("ORC")]
    ORC,
    [EnumMember(Value = "PARQUET"), JsonStringEnumMemberName("PARQUET")]
    PARQUET,
    [EnumMember(Value = "PSV"), JsonStringEnumMemberName("PSV")]
    PSV,
    [EnumMember(Value = "RAW"), JsonStringEnumMemberName("RAW")]
    RAW,
    [EnumMember(Value = "SCSV"), JsonStringEnumMemberName("SCSV")]
    SCSV,
    [EnumMember(Value = "SINGLEJSON"), JsonStringEnumMemberName("SINGLEJSON")]
    SINGLEJSON,
    [EnumMember(Value = "SOHSV"), JsonStringEnumMemberName("SOHSV")]
    SOHSV,
    [EnumMember(Value = "TSV"), JsonStringEnumMemberName("TSV")]
    TSV,
    [EnumMember(Value = "TSVE"), JsonStringEnumMemberName("TSVE")]
    TSVE,
    [EnumMember(Value = "TXT"), JsonStringEnumMemberName("TXT")]
    TXT,
    [EnumMember(Value = "W3CLOGFILE"), JsonStringEnumMemberName("W3CLOGFILE")]
    W3CLOGFILE
}

/// <summary>
/// DatabaseRouting: Indication for database routing information from the data connection, by default only database routing
/// information is allowed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecEventGridDataConnectionDatabaseRoutingEnum>))]
public enum V1api20240413DataConnectionSpecEventGridDataConnectionDatabaseRoutingEnum
{
    [EnumMember(Value = "Multi"), JsonStringEnumMemberName("Multi")]
    Multi,
    [EnumMember(Value = "Single"), JsonStringEnumMemberName("Single")]
    Single
}

/// <summary>EventGridResourceReference: The resource ID of the event grid that is subscribed to the storage account events.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpecEventGridDataConnectionEventGridResourceReference
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
public partial class V1api20240413DataConnectionSpecEventGridDataConnectionEventHubResourceReference
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

/// <summary>Kind: Kind of the endpoint for the data connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecEventGridDataConnectionKindEnum>))]
public enum V1api20240413DataConnectionSpecEventGridDataConnectionKindEnum
{
    [EnumMember(Value = "EventGrid"), JsonStringEnumMemberName("EventGrid")]
    EventGrid
}

/// <summary>
/// ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to
/// authenticate with event hub and storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpecEventGridDataConnectionManagedIdentityResourceReference
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
public partial class V1api20240413DataConnectionSpecEventGridDataConnectionStorageAccountResourceReference
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

/// <summary>EventGrid: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpecEventGridDataConnection
{
    /// <summary>BlobStorageEventType: The name of blob storage event type to process.</summary>
    [JsonPropertyName("blobStorageEventType")]
    public V1api20240413DataConnectionSpecEventGridDataConnectionBlobStorageEventTypeEnum? BlobStorageEventType { get; set; }

    /// <summary>ConsumerGroup: The event hub consumer group.</summary>
    [JsonPropertyName("consumerGroup")]
    public required string ConsumerGroup { get; set; }

    /// <summary>DataFormat: The data format of the message. Optionally the data format can be added to each message.</summary>
    [JsonPropertyName("dataFormat")]
    public V1api20240413DataConnectionSpecEventGridDataConnectionDataFormatEnum? DataFormat { get; set; }

    /// <summary>
    /// DatabaseRouting: Indication for database routing information from the data connection, by default only database routing
    /// information is allowed
    /// </summary>
    [JsonPropertyName("databaseRouting")]
    public V1api20240413DataConnectionSpecEventGridDataConnectionDatabaseRoutingEnum? DatabaseRouting { get; set; }

    /// <summary>EventGridResourceReference: The resource ID of the event grid that is subscribed to the storage account events.</summary>
    [JsonPropertyName("eventGridResourceReference")]
    public V1api20240413DataConnectionSpecEventGridDataConnectionEventGridResourceReference? EventGridResourceReference { get; set; }

    /// <summary>EventHubResourceReference: The resource ID where the event grid is configured to send events.</summary>
    [JsonPropertyName("eventHubResourceReference")]
    public required V1api20240413DataConnectionSpecEventGridDataConnectionEventHubResourceReference EventHubResourceReference { get; set; }

    /// <summary>
    /// IgnoreFirstRecord: A Boolean value that, if set to true, indicates that ingestion should ignore the first record of
    /// every file
    /// </summary>
    [JsonPropertyName("ignoreFirstRecord")]
    public bool? IgnoreFirstRecord { get; set; }

    /// <summary>Kind: Kind of the endpoint for the data connection</summary>
    [JsonPropertyName("kind")]
    public required V1api20240413DataConnectionSpecEventGridDataConnectionKindEnum Kind { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to
    /// authenticate with event hub and storage account.
    /// </summary>
    [JsonPropertyName("managedIdentityResourceReference")]
    public V1api20240413DataConnectionSpecEventGridDataConnectionManagedIdentityResourceReference? ManagedIdentityResourceReference { get; set; }

    /// <summary>
    /// MappingRuleName: The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each
    /// message.
    /// </summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary>StorageAccountResourceReference: The resource ID of the storage account where the data resides.</summary>
    [JsonPropertyName("storageAccountResourceReference")]
    public required V1api20240413DataConnectionSpecEventGridDataConnectionStorageAccountResourceReference StorageAccountResourceReference { get; set; }

    /// <summary>TableName: The table where the data should be ingested. Optionally the table information can be added to each message.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>Compression: The event hub messages compression type</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecEventHubDataConnectionCompressionEnum>))]
public enum V1api20240413DataConnectionSpecEventHubDataConnectionCompressionEnum
{
    [EnumMember(Value = "GZip"), JsonStringEnumMemberName("GZip")]
    GZip,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>DataFormat: The data format of the message. Optionally the data format can be added to each message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecEventHubDataConnectionDataFormatEnum>))]
public enum V1api20240413DataConnectionSpecEventHubDataConnectionDataFormatEnum
{
    [EnumMember(Value = "APACHEAVRO"), JsonStringEnumMemberName("APACHEAVRO")]
    APACHEAVRO,
    [EnumMember(Value = "AVRO"), JsonStringEnumMemberName("AVRO")]
    AVRO,
    [EnumMember(Value = "CSV"), JsonStringEnumMemberName("CSV")]
    CSV,
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON,
    [EnumMember(Value = "MULTIJSON"), JsonStringEnumMemberName("MULTIJSON")]
    MULTIJSON,
    [EnumMember(Value = "ORC"), JsonStringEnumMemberName("ORC")]
    ORC,
    [EnumMember(Value = "PARQUET"), JsonStringEnumMemberName("PARQUET")]
    PARQUET,
    [EnumMember(Value = "PSV"), JsonStringEnumMemberName("PSV")]
    PSV,
    [EnumMember(Value = "RAW"), JsonStringEnumMemberName("RAW")]
    RAW,
    [EnumMember(Value = "SCSV"), JsonStringEnumMemberName("SCSV")]
    SCSV,
    [EnumMember(Value = "SINGLEJSON"), JsonStringEnumMemberName("SINGLEJSON")]
    SINGLEJSON,
    [EnumMember(Value = "SOHSV"), JsonStringEnumMemberName("SOHSV")]
    SOHSV,
    [EnumMember(Value = "TSV"), JsonStringEnumMemberName("TSV")]
    TSV,
    [EnumMember(Value = "TSVE"), JsonStringEnumMemberName("TSVE")]
    TSVE,
    [EnumMember(Value = "TXT"), JsonStringEnumMemberName("TXT")]
    TXT,
    [EnumMember(Value = "W3CLOGFILE"), JsonStringEnumMemberName("W3CLOGFILE")]
    W3CLOGFILE
}

/// <summary>
/// DatabaseRouting: Indication for database routing information from the data connection, by default only database routing
/// information is allowed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecEventHubDataConnectionDatabaseRoutingEnum>))]
public enum V1api20240413DataConnectionSpecEventHubDataConnectionDatabaseRoutingEnum
{
    [EnumMember(Value = "Multi"), JsonStringEnumMemberName("Multi")]
    Multi,
    [EnumMember(Value = "Single"), JsonStringEnumMemberName("Single")]
    Single
}

/// <summary>EventHubResourceReference: The resource ID of the event hub to be used to create a data connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpecEventHubDataConnectionEventHubResourceReference
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

/// <summary>Kind: Kind of the endpoint for the data connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecEventHubDataConnectionKindEnum>))]
public enum V1api20240413DataConnectionSpecEventHubDataConnectionKindEnum
{
    [EnumMember(Value = "EventHub"), JsonStringEnumMemberName("EventHub")]
    EventHub
}

/// <summary>
/// ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to
/// authenticate with event hub.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpecEventHubDataConnectionManagedIdentityResourceReference
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
public partial class V1api20240413DataConnectionSpecEventHubDataConnection
{
    /// <summary>Compression: The event hub messages compression type</summary>
    [JsonPropertyName("compression")]
    public V1api20240413DataConnectionSpecEventHubDataConnectionCompressionEnum? Compression { get; set; }

    /// <summary>ConsumerGroup: The event hub consumer group.</summary>
    [JsonPropertyName("consumerGroup")]
    public required string ConsumerGroup { get; set; }

    /// <summary>DataFormat: The data format of the message. Optionally the data format can be added to each message.</summary>
    [JsonPropertyName("dataFormat")]
    public V1api20240413DataConnectionSpecEventHubDataConnectionDataFormatEnum? DataFormat { get; set; }

    /// <summary>
    /// DatabaseRouting: Indication for database routing information from the data connection, by default only database routing
    /// information is allowed
    /// </summary>
    [JsonPropertyName("databaseRouting")]
    public V1api20240413DataConnectionSpecEventHubDataConnectionDatabaseRoutingEnum? DatabaseRouting { get; set; }

    /// <summary>EventHubResourceReference: The resource ID of the event hub to be used to create a data connection.</summary>
    [JsonPropertyName("eventHubResourceReference")]
    public required V1api20240413DataConnectionSpecEventHubDataConnectionEventHubResourceReference EventHubResourceReference { get; set; }

    /// <summary>EventSystemProperties: System properties of the event hub</summary>
    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    /// <summary>Kind: Kind of the endpoint for the data connection</summary>
    [JsonPropertyName("kind")]
    public required V1api20240413DataConnectionSpecEventHubDataConnectionKindEnum Kind { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ManagedIdentityResourceReference: The resource ID of a managed identity (system or user assigned) to be used to
    /// authenticate with event hub.
    /// </summary>
    [JsonPropertyName("managedIdentityResourceReference")]
    public V1api20240413DataConnectionSpecEventHubDataConnectionManagedIdentityResourceReference? ManagedIdentityResourceReference { get; set; }

    /// <summary>
    /// MappingRuleName: The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each
    /// message.
    /// </summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary>
    /// RetrievalStartDate: When defined, the data connection retrieves existing Event hub events created since the Retrieval
    /// start date. It can only retrieve events retained by the Event hub, based on its retention period.
    /// </summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary>TableName: The table where the data should be ingested. Optionally the table information can be added to each message.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }
}

/// <summary>DataFormat: The data format of the message. Optionally the data format can be added to each message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecIotHubDataConnectionDataFormatEnum>))]
public enum V1api20240413DataConnectionSpecIotHubDataConnectionDataFormatEnum
{
    [EnumMember(Value = "APACHEAVRO"), JsonStringEnumMemberName("APACHEAVRO")]
    APACHEAVRO,
    [EnumMember(Value = "AVRO"), JsonStringEnumMemberName("AVRO")]
    AVRO,
    [EnumMember(Value = "CSV"), JsonStringEnumMemberName("CSV")]
    CSV,
    [EnumMember(Value = "JSON"), JsonStringEnumMemberName("JSON")]
    JSON,
    [EnumMember(Value = "MULTIJSON"), JsonStringEnumMemberName("MULTIJSON")]
    MULTIJSON,
    [EnumMember(Value = "ORC"), JsonStringEnumMemberName("ORC")]
    ORC,
    [EnumMember(Value = "PARQUET"), JsonStringEnumMemberName("PARQUET")]
    PARQUET,
    [EnumMember(Value = "PSV"), JsonStringEnumMemberName("PSV")]
    PSV,
    [EnumMember(Value = "RAW"), JsonStringEnumMemberName("RAW")]
    RAW,
    [EnumMember(Value = "SCSV"), JsonStringEnumMemberName("SCSV")]
    SCSV,
    [EnumMember(Value = "SINGLEJSON"), JsonStringEnumMemberName("SINGLEJSON")]
    SINGLEJSON,
    [EnumMember(Value = "SOHSV"), JsonStringEnumMemberName("SOHSV")]
    SOHSV,
    [EnumMember(Value = "TSV"), JsonStringEnumMemberName("TSV")]
    TSV,
    [EnumMember(Value = "TSVE"), JsonStringEnumMemberName("TSVE")]
    TSVE,
    [EnumMember(Value = "TXT"), JsonStringEnumMemberName("TXT")]
    TXT,
    [EnumMember(Value = "W3CLOGFILE"), JsonStringEnumMemberName("W3CLOGFILE")]
    W3CLOGFILE
}

/// <summary>
/// DatabaseRouting: Indication for database routing information from the data connection, by default only database routing
/// information is allowed
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecIotHubDataConnectionDatabaseRoutingEnum>))]
public enum V1api20240413DataConnectionSpecIotHubDataConnectionDatabaseRoutingEnum
{
    [EnumMember(Value = "Multi"), JsonStringEnumMemberName("Multi")]
    Multi,
    [EnumMember(Value = "Single"), JsonStringEnumMemberName("Single")]
    Single
}

/// <summary>IotHubResourceReference: The resource ID of the Iot hub to be used to create a data connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpecIotHubDataConnectionIotHubResourceReference
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

/// <summary>Kind: Kind of the endpoint for the data connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240413DataConnectionSpecIotHubDataConnectionKindEnum>))]
public enum V1api20240413DataConnectionSpecIotHubDataConnectionKindEnum
{
    [EnumMember(Value = "IotHub"), JsonStringEnumMemberName("IotHub")]
    IotHub
}

/// <summary>IotHub: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpecIotHubDataConnection
{
    /// <summary>ConsumerGroup: The iot hub consumer group.</summary>
    [JsonPropertyName("consumerGroup")]
    public required string ConsumerGroup { get; set; }

    /// <summary>DataFormat: The data format of the message. Optionally the data format can be added to each message.</summary>
    [JsonPropertyName("dataFormat")]
    public V1api20240413DataConnectionSpecIotHubDataConnectionDataFormatEnum? DataFormat { get; set; }

    /// <summary>
    /// DatabaseRouting: Indication for database routing information from the data connection, by default only database routing
    /// information is allowed
    /// </summary>
    [JsonPropertyName("databaseRouting")]
    public V1api20240413DataConnectionSpecIotHubDataConnectionDatabaseRoutingEnum? DatabaseRouting { get; set; }

    /// <summary>EventSystemProperties: System properties of the iot hub</summary>
    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    /// <summary>IotHubResourceReference: The resource ID of the Iot hub to be used to create a data connection.</summary>
    [JsonPropertyName("iotHubResourceReference")]
    public required V1api20240413DataConnectionSpecIotHubDataConnectionIotHubResourceReference IotHubResourceReference { get; set; }

    /// <summary>Kind: Kind of the endpoint for the data connection</summary>
    [JsonPropertyName("kind")]
    public required V1api20240413DataConnectionSpecIotHubDataConnectionKindEnum Kind { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// MappingRuleName: The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each
    /// message.
    /// </summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary>
    /// RetrievalStartDate: When defined, the data connection retrieves existing Event hub events created since the Retrieval
    /// start date. It can only retrieve events retained by the Event hub, based on its retention period.
    /// </summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary>SharedAccessPolicyName: The name of the share access policy</summary>
    [JsonPropertyName("sharedAccessPolicyName")]
    public required string SharedAccessPolicyName { get; set; }

    /// <summary>TableName: The table where the data should be ingested. Optionally the table information can be added to each message.</summary>
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
public partial class V1api20240413DataConnectionSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240413DataConnectionSpecOperatorSpecSecretExpressions
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
public partial class V1api20240413DataConnectionSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240413DataConnectionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240413DataConnectionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a kusto.azure.com/Database resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CosmosDb: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cosmosDbDataConnection")]
    public V1api20240413DataConnectionSpecCosmosDbDataConnection? CosmosDbDataConnection { get; set; }

    /// <summary>EventGrid: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("eventGridDataConnection")]
    public V1api20240413DataConnectionSpecEventGridDataConnection? EventGridDataConnection { get; set; }

    /// <summary>EventHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("eventHubDataConnection")]
    public V1api20240413DataConnectionSpecEventHubDataConnection? EventHubDataConnection { get; set; }

    /// <summary>IotHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("iotHubDataConnection")]
    public V1api20240413DataConnectionSpecIotHubDataConnection? IotHubDataConnection { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240413DataConnectionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a kusto.azure.com/Database resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240413DataConnectionSpecOwner Owner { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionStatusConditions
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

/// <summary>CosmosDb: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionStatusCosmosDb
{
    /// <summary>CosmosDbAccountResourceId: The resource ID of the Cosmos DB account used to create the data connection.</summary>
    [JsonPropertyName("cosmosDbAccountResourceId")]
    public string? CosmosDbAccountResourceId { get; set; }

    /// <summary>CosmosDbContainer: The name of an existing container in the Cosmos DB database.</summary>
    [JsonPropertyName("cosmosDbContainer")]
    public string? CosmosDbContainer { get; set; }

    /// <summary>CosmosDbDatabase: The name of an existing database in the Cosmos DB account.</summary>
    [JsonPropertyName("cosmosDbDatabase")]
    public string? CosmosDbDatabase { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Kind: Kind of the endpoint for the data connection</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedIdentityObjectId: The object ID of the managed identity resource.</summary>
    [JsonPropertyName("managedIdentityObjectId")]
    public string? ManagedIdentityObjectId { get; set; }

    /// <summary>
    /// ManagedIdentityResourceId: The resource ID of a managed system or user-assigned identity. The identity is used to
    /// authenticate with Cosmos DB.
    /// </summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary>MappingRuleName: The name of an existing mapping rule to use when ingesting the retrieved data.</summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary>ProvisioningState: The provisioned state of the resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RetrievalStartDate: Optional. If defined, the data connection retrieves Cosmos DB documents created or updated after the
    /// specified retrieval start date.
    /// </summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary>
    /// TableName: The case-sensitive name of the existing target table in your cluster. Retrieved data is ingested into this
    /// table.
    /// </summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>EventGrid: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionStatusEventGrid
{
    /// <summary>BlobStorageEventType: The name of blob storage event type to process.</summary>
    [JsonPropertyName("blobStorageEventType")]
    public string? BlobStorageEventType { get; set; }

    /// <summary>ConsumerGroup: The event hub consumer group.</summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary>DataFormat: The data format of the message. Optionally the data format can be added to each message.</summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary>
    /// DatabaseRouting: Indication for database routing information from the data connection, by default only database routing
    /// information is allowed
    /// </summary>
    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    /// <summary>EventGridResourceId: The resource ID of the event grid that is subscribed to the storage account events.</summary>
    [JsonPropertyName("eventGridResourceId")]
    public string? EventGridResourceId { get; set; }

    /// <summary>EventHubResourceId: The resource ID where the event grid is configured to send events.</summary>
    [JsonPropertyName("eventHubResourceId")]
    public string? EventHubResourceId { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IgnoreFirstRecord: A Boolean value that, if set to true, indicates that ingestion should ignore the first record of
    /// every file
    /// </summary>
    [JsonPropertyName("ignoreFirstRecord")]
    public bool? IgnoreFirstRecord { get; set; }

    /// <summary>Kind: Kind of the endpoint for the data connection</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedIdentityObjectId: The object ID of managedIdentityResourceId</summary>
    [JsonPropertyName("managedIdentityObjectId")]
    public string? ManagedIdentityObjectId { get; set; }

    /// <summary>
    /// ManagedIdentityResourceId: The resource ID of a managed identity (system or user assigned) to be used to authenticate
    /// with event hub and storage account.
    /// </summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary>
    /// MappingRuleName: The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each
    /// message.
    /// </summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary>ProvisioningState: The provisioned state of the resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>StorageAccountResourceId: The resource ID of the storage account where the data resides.</summary>
    [JsonPropertyName("storageAccountResourceId")]
    public string? StorageAccountResourceId { get; set; }

    /// <summary>TableName: The table where the data should be ingested. Optionally the table information can be added to each message.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>EventHub: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionStatusEventHub
{
    /// <summary>Compression: The event hub messages compression type</summary>
    [JsonPropertyName("compression")]
    public string? Compression { get; set; }

    /// <summary>ConsumerGroup: The event hub consumer group.</summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary>DataFormat: The data format of the message. Optionally the data format can be added to each message.</summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary>
    /// DatabaseRouting: Indication for database routing information from the data connection, by default only database routing
    /// information is allowed
    /// </summary>
    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    /// <summary>EventHubResourceId: The resource ID of the event hub to be used to create a data connection.</summary>
    [JsonPropertyName("eventHubResourceId")]
    public string? EventHubResourceId { get; set; }

    /// <summary>EventSystemProperties: System properties of the event hub</summary>
    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Kind: Kind of the endpoint for the data connection</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedIdentityObjectId: The object ID of the managedIdentityResourceId</summary>
    [JsonPropertyName("managedIdentityObjectId")]
    public string? ManagedIdentityObjectId { get; set; }

    /// <summary>
    /// ManagedIdentityResourceId: The resource ID of a managed identity (system or user assigned) to be used to authenticate
    /// with event hub.
    /// </summary>
    [JsonPropertyName("managedIdentityResourceId")]
    public string? ManagedIdentityResourceId { get; set; }

    /// <summary>
    /// MappingRuleName: The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each
    /// message.
    /// </summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary>ProvisioningState: The provisioned state of the resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RetrievalStartDate: When defined, the data connection retrieves existing Event hub events created since the Retrieval
    /// start date. It can only retrieve events retained by the Event hub, based on its retention period.
    /// </summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary>TableName: The table where the data should be ingested. Optionally the table information can be added to each message.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>IotHub: Mutually exclusive with all other properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionStatusIotHub
{
    /// <summary>ConsumerGroup: The iot hub consumer group.</summary>
    [JsonPropertyName("consumerGroup")]
    public string? ConsumerGroup { get; set; }

    /// <summary>DataFormat: The data format of the message. Optionally the data format can be added to each message.</summary>
    [JsonPropertyName("dataFormat")]
    public string? DataFormat { get; set; }

    /// <summary>
    /// DatabaseRouting: Indication for database routing information from the data connection, by default only database routing
    /// information is allowed
    /// </summary>
    [JsonPropertyName("databaseRouting")]
    public string? DatabaseRouting { get; set; }

    /// <summary>EventSystemProperties: System properties of the iot hub</summary>
    [JsonPropertyName("eventSystemProperties")]
    public IList<string>? EventSystemProperties { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IotHubResourceId: The resource ID of the Iot hub to be used to create a data connection.</summary>
    [JsonPropertyName("iotHubResourceId")]
    public string? IotHubResourceId { get; set; }

    /// <summary>Kind: Kind of the endpoint for the data connection</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// MappingRuleName: The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each
    /// message.
    /// </summary>
    [JsonPropertyName("mappingRuleName")]
    public string? MappingRuleName { get; set; }

    /// <summary>ProvisioningState: The provisioned state of the resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RetrievalStartDate: When defined, the data connection retrieves existing Event hub events created since the Retrieval
    /// start date. It can only retrieve events retained by the Event hub, based on its retention period.
    /// </summary>
    [JsonPropertyName("retrievalStartDate")]
    public string? RetrievalStartDate { get; set; }

    /// <summary>SharedAccessPolicyName: The name of the share access policy</summary>
    [JsonPropertyName("sharedAccessPolicyName")]
    public string? SharedAccessPolicyName { get; set; }

    /// <summary>TableName: The table where the data should be ingested. Optionally the table information can be added to each message.</summary>
    [JsonPropertyName("tableName")]
    public string? TableName { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240413DataConnectionStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240413DataConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>CosmosDb: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("cosmosDb")]
    public V1api20240413DataConnectionStatusCosmosDb? CosmosDb { get; set; }

    /// <summary>EventGrid: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("eventGrid")]
    public V1api20240413DataConnectionStatusEventGrid? EventGrid { get; set; }

    /// <summary>EventHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("eventHub")]
    public V1api20240413DataConnectionStatusEventHub? EventHub { get; set; }

    /// <summary>IotHub: Mutually exclusive with all other properties</summary>
    [JsonPropertyName("iotHub")]
    public V1api20240413DataConnectionStatusIotHub? IotHub { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /azure-kusto/resource-manager/Microsoft.Kusto/Kusto/stable/2024-04-13/kusto.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}/databases/{databaseName}/dataConnections/{dataConnectionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240413DataConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240413DataConnectionSpec?>, IStatus<V1api20240413DataConnectionStatus?>
{
    public const string KubeApiVersion = "v1api20240413";
    public const string KubeKind = "DataConnection";
    public const string KubeGroup = "kusto.azure.com";
    public const string KubePluralName = "dataconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kusto.azure.com/v1api20240413";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240413DataConnectionSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20240413DataConnectionStatus? Status { get; set; }
}