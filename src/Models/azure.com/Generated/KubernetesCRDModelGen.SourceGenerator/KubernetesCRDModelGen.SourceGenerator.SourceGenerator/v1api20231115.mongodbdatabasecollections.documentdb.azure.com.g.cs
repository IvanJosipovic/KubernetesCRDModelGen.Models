#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.documentdb.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2023-11-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115MongodbDatabaseCollectionList : IKubernetesObject<V1ListMeta>, IItems<V1api20231115MongodbDatabaseCollection>
{
    public const string KubeApiVersion = "v1api20231115";
    public const string KubeKind = "MongodbDatabaseCollectionList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongodbdatabasecollections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20231115";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MongodbDatabaseCollectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20231115MongodbDatabaseCollection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20231115MongodbDatabaseCollection> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20231115MongodbDatabaseCollectionSpecOperatorSpecSecretExpressions
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
public partial class V1api20231115MongodbDatabaseCollectionSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231115MongodbDatabaseCollectionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231115MongodbDatabaseCollectionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// AutoscaleSettings: Specifies the Autoscale settings. Note: Either throughput or autoscaleSettings is required, but not
/// both.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionSpecOptionsAutoscaleSettings
{
    /// <summary>MaxThroughput: Represents maximum throughput, the resource can scale up to.</summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>
/// Options: A key-value pair of options to be applied for the request. This corresponds to the headers sent with the
/// request.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionSpecOptions
{
    /// <summary>
    /// AutoscaleSettings: Specifies the Autoscale settings. Note: Either throughput or autoscaleSettings is required, but not
    /// both.
    /// </summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115MongodbDatabaseCollectionSpecOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>Throughput: Request Units per second. For example, &quot;throughput&quot;: 10000.</summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a documentdb.azure.com/MongodbDatabase resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>CreateMode: Enum to indicate the mode of resource creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20231115MongodbDatabaseCollectionSpecResourceCreateModeEnum>))]
public enum V1api20231115MongodbDatabaseCollectionSpecResourceCreateModeEnum
{
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "Restore"), JsonStringEnumMemberName("Restore")]
    Restore
}

/// <summary>Key: Cosmos DB MongoDB collection index keys</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionSpecResourceIndexesKey
{
    /// <summary>Keys: List of keys for each MongoDB collection in the Azure Cosmos DB service</summary>
    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }
}

/// <summary>Options: Cosmos DB MongoDB collection index key options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionSpecResourceIndexesOptions
{
    /// <summary>ExpireAfterSeconds: Expire after seconds</summary>
    [JsonPropertyName("expireAfterSeconds")]
    public int? ExpireAfterSeconds { get; set; }

    /// <summary>Unique: Is unique or not</summary>
    [JsonPropertyName("unique")]
    public bool? Unique { get; set; }
}

/// <summary>Cosmos DB MongoDB collection index key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionSpecResourceIndexes
{
    /// <summary>Key: Cosmos DB MongoDB collection index keys</summary>
    [JsonPropertyName("key")]
    public V1api20231115MongodbDatabaseCollectionSpecResourceIndexesKey? Key { get; set; }

    /// <summary>Options: Cosmos DB MongoDB collection index key options</summary>
    [JsonPropertyName("options")]
    public V1api20231115MongodbDatabaseCollectionSpecResourceIndexesOptions? Options { get; set; }
}

/// <summary>RestoreParameters: Parameters to indicate the information about the restore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionSpecResourceRestoreParameters
{
    /// <summary>
    /// RestoreSource: The id of the restorable database account from which the restore has to be initiated. For example:
    /// /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{restorableDatabaseAccountName}
    /// </summary>
    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    /// <summary>RestoreTimestampInUtc: Time to which the account has to be restored (ISO-8601 format).</summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }
}

/// <summary>Resource: The standard JSON format of a MongoDB collection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionSpecResource
{
    /// <summary>AnalyticalStorageTtl: Analytical TTL.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public int? AnalyticalStorageTtl { get; set; }

    /// <summary>CreateMode: Enum to indicate the mode of resource creation.</summary>
    [JsonPropertyName("createMode")]
    public V1api20231115MongodbDatabaseCollectionSpecResourceCreateModeEnum? CreateMode { get; set; }

    /// <summary>Id: Name of the Cosmos DB MongoDB collection</summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>Indexes: List of index keys</summary>
    [JsonPropertyName("indexes")]
    public IList<V1api20231115MongodbDatabaseCollectionSpecResourceIndexes>? Indexes { get; set; }

    /// <summary>RestoreParameters: Parameters to indicate the information about the restore</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115MongodbDatabaseCollectionSpecResourceRestoreParameters? RestoreParameters { get; set; }

    /// <summary>ShardKey: A key-value pair of shard keys to be applied for the request.</summary>
    [JsonPropertyName("shardKey")]
    public IDictionary<string, string>? ShardKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231115MongodbDatabaseCollectionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Options: A key-value pair of options to be applied for the request. This corresponds to the headers sent with the
    /// request.
    /// </summary>
    [JsonPropertyName("options")]
    public V1api20231115MongodbDatabaseCollectionSpecOptions? Options { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a documentdb.azure.com/MongodbDatabase resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20231115MongodbDatabaseCollectionSpecOwner Owner { get; set; }

    /// <summary>Resource: The standard JSON format of a MongoDB collection</summary>
    [JsonPropertyName("resource")]
    public required V1api20231115MongodbDatabaseCollectionSpecResource Resource { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionStatusConditions
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

/// <summary>AutoscaleSettings: Specifies the Autoscale settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionStatusOptionsAutoscaleSettings
{
    /// <summary>MaxThroughput: Represents maximum throughput, the resource can scale up to.</summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>Options: Cosmos DB options resource object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionStatusOptions
{
    /// <summary>AutoscaleSettings: Specifies the Autoscale settings.</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115MongodbDatabaseCollectionStatusOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>
    /// Throughput: Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when
    /// retrieving offer details.
    /// </summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>Key: Cosmos DB MongoDB collection index keys</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionStatusResourceIndexesKey
{
    /// <summary>Keys: List of keys for each MongoDB collection in the Azure Cosmos DB service</summary>
    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }
}

/// <summary>Options: Cosmos DB MongoDB collection index key options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionStatusResourceIndexesOptions
{
    /// <summary>ExpireAfterSeconds: Expire after seconds</summary>
    [JsonPropertyName("expireAfterSeconds")]
    public int? ExpireAfterSeconds { get; set; }

    /// <summary>Unique: Is unique or not</summary>
    [JsonPropertyName("unique")]
    public bool? Unique { get; set; }
}

/// <summary>Cosmos DB MongoDB collection index key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionStatusResourceIndexes
{
    /// <summary>Key: Cosmos DB MongoDB collection index keys</summary>
    [JsonPropertyName("key")]
    public V1api20231115MongodbDatabaseCollectionStatusResourceIndexesKey? Key { get; set; }

    /// <summary>Options: Cosmos DB MongoDB collection index key options</summary>
    [JsonPropertyName("options")]
    public V1api20231115MongodbDatabaseCollectionStatusResourceIndexesOptions? Options { get; set; }
}

/// <summary>RestoreParameters: Parameters to indicate the information about the restore</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionStatusResourceRestoreParameters
{
    /// <summary>
    /// RestoreSource: The id of the restorable database account from which the restore has to be initiated. For example:
    /// /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{restorableDatabaseAccountName}
    /// </summary>
    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    /// <summary>RestoreTimestampInUtc: Time to which the account has to be restored (ISO-8601 format).</summary>
    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionStatusResource
{
    /// <summary>Etag: A system generated property representing the resource etag required for optimistic concurrency control.</summary>
    [JsonPropertyName("_etag")]
    public string? Etag { get; set; }

    /// <summary>Rid: A system generated property. A unique identifier.</summary>
    [JsonPropertyName("_rid")]
    public string? Rid { get; set; }

    /// <summary>Ts: A system generated property that denotes the last updated timestamp of the resource.</summary>
    [JsonPropertyName("_ts")]
    public double? Ts { get; set; }

    /// <summary>AnalyticalStorageTtl: Analytical TTL.</summary>
    [JsonPropertyName("analyticalStorageTtl")]
    public int? AnalyticalStorageTtl { get; set; }

    /// <summary>CreateMode: Enum to indicate the mode of resource creation.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>Id: Name of the Cosmos DB MongoDB collection</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Indexes: List of index keys</summary>
    [JsonPropertyName("indexes")]
    public IList<V1api20231115MongodbDatabaseCollectionStatusResourceIndexes>? Indexes { get; set; }

    /// <summary>RestoreParameters: Parameters to indicate the information about the restore</summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115MongodbDatabaseCollectionStatusResourceRestoreParameters? RestoreParameters { get; set; }

    /// <summary>ShardKey: A key-value pair of shard keys to be applied for the request.</summary>
    [JsonPropertyName("shardKey")]
    public IDictionary<string, string>? ShardKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115MongodbDatabaseCollectionStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231115MongodbDatabaseCollectionStatusConditions>? Conditions { get; set; }

    /// <summary>Id: The unique resource identifier of the ARM resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the ARM resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Options: Cosmos DB options resource object</summary>
    [JsonPropertyName("options")]
    public V1api20231115MongodbDatabaseCollectionStatusOptions? Options { get; set; }

    [JsonPropertyName("resource")]
    public V1api20231115MongodbDatabaseCollectionStatusResource? Resource { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of Azure resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2023-11-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115MongodbDatabaseCollection : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231115MongodbDatabaseCollectionSpec?>, IStatus<V1api20231115MongodbDatabaseCollectionStatus?>
{
    public const string KubeApiVersion = "v1api20231115";
    public const string KubeKind = "MongodbDatabaseCollection";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongodbdatabasecollections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20231115";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MongodbDatabaseCollection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20231115MongodbDatabaseCollectionSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20231115MongodbDatabaseCollectionStatus? Status { get; set; }
}