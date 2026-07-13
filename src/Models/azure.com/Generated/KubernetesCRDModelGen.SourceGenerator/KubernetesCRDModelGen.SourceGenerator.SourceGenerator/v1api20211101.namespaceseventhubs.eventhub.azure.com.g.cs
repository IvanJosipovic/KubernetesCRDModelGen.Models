#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventhub.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /eventhub/resource-manager/Microsoft.EventHub/Eventhub/stable/2021-11-01/eventhubs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101NamespacesEventhubList : IKubernetesObject<V1ListMeta>, IItems<V1api20211101NamespacesEventhub>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "NamespacesEventhubList";
    public const string KubeGroup = "eventhub.azure.com";
    public const string KubePluralName = "namespaceseventhubs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventhub.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacesEventhubList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20211101NamespacesEventhub objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20211101NamespacesEventhub> Items { get; set; }
}

/// <summary>StorageAccountResourceReference: Resource id of the storage account to be used to create the blobs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesEventhubSpecCaptureDescriptionDestinationStorageAccountResourceReference
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

/// <summary>Destination: Properties of Destination where capture will be stored. (Storage Account, Blob Names)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesEventhubSpecCaptureDescriptionDestination
{
    /// <summary>
    /// ArchiveNameFormat: Blob naming convention for archive, e.g.
    /// {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters
    /// (Namespace,EventHub .. etc) are mandatory irrespective of order
    /// </summary>
    [JsonPropertyName("archiveNameFormat")]
    public string? ArchiveNameFormat { get; set; }

    /// <summary>BlobContainer: Blob container Name</summary>
    [JsonPropertyName("blobContainer")]
    public string? BlobContainer { get; set; }

    /// <summary>DataLakeAccountName: The Azure Data Lake Store name for the captured events</summary>
    [JsonPropertyName("dataLakeAccountName")]
    public string? DataLakeAccountName { get; set; }

    /// <summary>DataLakeFolderPath: The destination folder path for the captured events</summary>
    [JsonPropertyName("dataLakeFolderPath")]
    public string? DataLakeFolderPath { get; set; }

    /// <summary>DataLakeSubscriptionId: Subscription Id of Azure Data Lake Store</summary>
    [JsonPropertyName("dataLakeSubscriptionId")]
    public string? DataLakeSubscriptionId { get; set; }

    /// <summary>Name: Name for capture destination</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceReference: Resource id of the storage account to be used to create the blobs</summary>
    [JsonPropertyName("storageAccountResourceReference")]
    public V1api20211101NamespacesEventhubSpecCaptureDescriptionDestinationStorageAccountResourceReference? StorageAccountResourceReference { get; set; }
}

/// <summary>
/// Encoding: Enumerates the possible values for the encoding format of capture description. Note: &apos;AvroDeflate&apos; will be
/// deprecated in New API Version
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101NamespacesEventhubSpecCaptureDescriptionEncodingEnum>))]
public enum V1api20211101NamespacesEventhubSpecCaptureDescriptionEncodingEnum
{
    [EnumMember(Value = "Avro"), JsonStringEnumMemberName("Avro")]
    Avro,
    [EnumMember(Value = "AvroDeflate"), JsonStringEnumMemberName("AvroDeflate")]
    AvroDeflate
}

/// <summary>CaptureDescription: Properties of capture description</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesEventhubSpecCaptureDescription
{
    /// <summary>Destination: Properties of Destination where capture will be stored. (Storage Account, Blob Names)</summary>
    [JsonPropertyName("destination")]
    public V1api20211101NamespacesEventhubSpecCaptureDescriptionDestination? Destination { get; set; }

    /// <summary>Enabled: A value that indicates whether capture description is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Encoding: Enumerates the possible values for the encoding format of capture description. Note: &apos;AvroDeflate&apos; will be
    /// deprecated in New API Version
    /// </summary>
    [JsonPropertyName("encoding")]
    public V1api20211101NamespacesEventhubSpecCaptureDescriptionEncodingEnum? Encoding { get; set; }

    /// <summary>
    /// IntervalInSeconds: The time window allows you to set the frequency with which the capture to Azure Blobs will happen,
    /// value should between 60 to 900 seconds
    /// </summary>
    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    /// <summary>
    /// SizeLimitInBytes: The size window defines the amount of data built up in your Event Hub before an capture operation,
    /// value should be between 10485760 to 524288000 bytes
    /// </summary>
    [JsonPropertyName("sizeLimitInBytes")]
    public int? SizeLimitInBytes { get; set; }

    /// <summary>SkipEmptyArchives: A value that indicates whether to Skip Empty Archives</summary>
    [JsonPropertyName("skipEmptyArchives")]
    public bool? SkipEmptyArchives { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesEventhubSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20211101NamespacesEventhubSpecOperatorSpecSecretExpressions
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
public partial class V1api20211101NamespacesEventhubSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20211101NamespacesEventhubSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20211101NamespacesEventhubSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a eventhub.azure.com/Namespace resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesEventhubSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesEventhubSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CaptureDescription: Properties of capture description</summary>
    [JsonPropertyName("captureDescription")]
    public V1api20211101NamespacesEventhubSpecCaptureDescription? CaptureDescription { get; set; }

    /// <summary>MessageRetentionInDays: Number of days to retain the events for this Event Hub, value should be 1 to 7 days</summary>
    [JsonPropertyName("messageRetentionInDays")]
    public int? MessageRetentionInDays { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20211101NamespacesEventhubSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a eventhub.azure.com/Namespace resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20211101NamespacesEventhubSpecOwner Owner { get; set; }

    /// <summary>PartitionCount: Number of partitions created for the Event Hub, allowed values are from 1 to 32 partitions.</summary>
    [JsonPropertyName("partitionCount")]
    public int? PartitionCount { get; set; }
}

/// <summary>Destination: Properties of Destination where capture will be stored. (Storage Account, Blob Names)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesEventhubStatusCaptureDescriptionDestination
{
    /// <summary>
    /// ArchiveNameFormat: Blob naming convention for archive, e.g.
    /// {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters
    /// (Namespace,EventHub .. etc) are mandatory irrespective of order
    /// </summary>
    [JsonPropertyName("archiveNameFormat")]
    public string? ArchiveNameFormat { get; set; }

    /// <summary>BlobContainer: Blob container Name</summary>
    [JsonPropertyName("blobContainer")]
    public string? BlobContainer { get; set; }

    /// <summary>DataLakeAccountName: The Azure Data Lake Store name for the captured events</summary>
    [JsonPropertyName("dataLakeAccountName")]
    public string? DataLakeAccountName { get; set; }

    /// <summary>DataLakeFolderPath: The destination folder path for the captured events</summary>
    [JsonPropertyName("dataLakeFolderPath")]
    public string? DataLakeFolderPath { get; set; }

    /// <summary>DataLakeSubscriptionId: Subscription Id of Azure Data Lake Store</summary>
    [JsonPropertyName("dataLakeSubscriptionId")]
    public string? DataLakeSubscriptionId { get; set; }

    /// <summary>Name: Name for capture destination</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>StorageAccountResourceId: Resource id of the storage account to be used to create the blobs</summary>
    [JsonPropertyName("storageAccountResourceId")]
    public string? StorageAccountResourceId { get; set; }
}

/// <summary>CaptureDescription: Properties of capture description</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesEventhubStatusCaptureDescription
{
    /// <summary>Destination: Properties of Destination where capture will be stored. (Storage Account, Blob Names)</summary>
    [JsonPropertyName("destination")]
    public V1api20211101NamespacesEventhubStatusCaptureDescriptionDestination? Destination { get; set; }

    /// <summary>Enabled: A value that indicates whether capture description is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Encoding: Enumerates the possible values for the encoding format of capture description. Note: &apos;AvroDeflate&apos; will be
    /// deprecated in New API Version
    /// </summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary>
    /// IntervalInSeconds: The time window allows you to set the frequency with which the capture to Azure Blobs will happen,
    /// value should between 60 to 900 seconds
    /// </summary>
    [JsonPropertyName("intervalInSeconds")]
    public int? IntervalInSeconds { get; set; }

    /// <summary>
    /// SizeLimitInBytes: The size window defines the amount of data built up in your Event Hub before an capture operation,
    /// value should be between 10485760 to 524288000 bytes
    /// </summary>
    [JsonPropertyName("sizeLimitInBytes")]
    public int? SizeLimitInBytes { get; set; }

    /// <summary>SkipEmptyArchives: A value that indicates whether to Skip Empty Archives</summary>
    [JsonPropertyName("skipEmptyArchives")]
    public bool? SkipEmptyArchives { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesEventhubStatusConditions
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

/// <summary>SystemData: The system meta data relating to this resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101NamespacesEventhubStatusSystemData
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
public partial class V1api20211101NamespacesEventhubStatus
{
    /// <summary>CaptureDescription: Properties of capture description</summary>
    [JsonPropertyName("captureDescription")]
    public V1api20211101NamespacesEventhubStatusCaptureDescription? CaptureDescription { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211101NamespacesEventhubStatusConditions>? Conditions { get; set; }

    /// <summary>CreatedAt: Exact time the Event Hub was created.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>MessageRetentionInDays: Number of days to retain the events for this Event Hub, value should be 1 to 7 days</summary>
    [JsonPropertyName("messageRetentionInDays")]
    public int? MessageRetentionInDays { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PartitionCount: Number of partitions created for the Event Hub, allowed values are from 1 to 32 partitions.</summary>
    [JsonPropertyName("partitionCount")]
    public int? PartitionCount { get; set; }

    /// <summary>PartitionIds: Current number of shards on the Event Hub.</summary>
    [JsonPropertyName("partitionIds")]
    public IList<string>? PartitionIds { get; set; }

    /// <summary>Status: Enumerates the possible values for the status of the Event Hub.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>SystemData: The system meta data relating to this resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20211101NamespacesEventhubStatusSystemData? SystemData { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.EventHub/Namespaces&quot; or &quot;Microsoft.EventHub/Namespaces/EventHubs&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UpdatedAt: The exact time the message was updated.</summary>
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /eventhub/resource-manager/Microsoft.EventHub/Eventhub/stable/2021-11-01/eventhubs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/namespaces/{namespaceName}/eventhubs/{eventHubName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101NamespacesEventhub : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101NamespacesEventhubSpec?>, IStatus<V1api20211101NamespacesEventhubStatus?>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "NamespacesEventhub";
    public const string KubeGroup = "eventhub.azure.com";
    public const string KubePluralName = "namespaceseventhubs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventhub.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacesEventhub";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20211101NamespacesEventhubSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20211101NamespacesEventhubStatus? Status { get; set; }
}