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
/// Storage version of v1api20231115.MongodbDatabaseCollection
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2023-11-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115storageMongodbDatabaseCollectionList : IKubernetesObject<V1ListMeta>, IItems<V1api20231115storageMongodbDatabaseCollection>
{
    public const string KubeApiVersion = "v1api20231115storage";
    public const string KubeKind = "MongodbDatabaseCollectionList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongodbdatabasecollections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20231115storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MongodbDatabaseCollectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20231115storageMongodbDatabaseCollection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20231115storageMongodbDatabaseCollection> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20231115storageMongodbDatabaseCollectionSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20231115.MongodbDatabaseCollectionOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231115storageMongodbDatabaseCollectionSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231115storageMongodbDatabaseCollectionSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Storage version of v1api20231115.AutoscaleSettings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionSpecOptionsAutoscaleSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.CreateUpdateOptions
/// CreateUpdateOptions are a list of key-value pairs that describe the resource. Supported keys are &quot;If-Match&quot;,
/// &quot;If-None-Match&quot;, &quot;Session-Token&quot; and &quot;Throughput&quot;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionSpecOptions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AutoscaleSettings</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115storageMongodbDatabaseCollectionSpecOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

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
public partial class V1api20231115storageMongodbDatabaseCollectionSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.MongoIndexKeys
/// Cosmos DB MongoDB collection resource object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionSpecResourceIndexesKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.MongoIndexOptions
/// Cosmos DB MongoDB collection index options
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionSpecResourceIndexesOptions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("expireAfterSeconds")]
    public int? ExpireAfterSeconds { get; set; }

    [JsonPropertyName("unique")]
    public bool? Unique { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.MongoIndex
/// Cosmos DB MongoDB collection index key
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionSpecResourceIndexes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.MongoIndexKeys
    /// Cosmos DB MongoDB collection resource object
    /// </summary>
    [JsonPropertyName("key")]
    public V1api20231115storageMongodbDatabaseCollectionSpecResourceIndexesKey? Key { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.MongoIndexOptions
    /// Cosmos DB MongoDB collection index options
    /// </summary>
    [JsonPropertyName("options")]
    public V1api20231115storageMongodbDatabaseCollectionSpecResourceIndexesOptions? Options { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.RestoreParametersBase
/// Parameters to indicate the information about the restore.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionSpecResourceRestoreParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.MongoDBCollectionResource
/// Cosmos DB MongoDB collection resource object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionSpecResource
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("analyticalStorageTtl")]
    public int? AnalyticalStorageTtl { get; set; }

    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("indexes")]
    public IList<V1api20231115storageMongodbDatabaseCollectionSpecResourceIndexes>? Indexes { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.RestoreParametersBase
    /// Parameters to indicate the information about the restore.
    /// </summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115storageMongodbDatabaseCollectionSpecResourceRestoreParameters? RestoreParameters { get; set; }

    [JsonPropertyName("shardKey")]
    public IDictionary<string, string>? ShardKey { get; set; }
}

/// <summary>Storage version of v1api20231115.MongodbDatabaseCollection_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionSpec
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

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.MongodbDatabaseCollectionOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231115storageMongodbDatabaseCollectionSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.CreateUpdateOptions
    /// CreateUpdateOptions are a list of key-value pairs that describe the resource. Supported keys are &quot;If-Match&quot;,
    /// &quot;If-None-Match&quot;, &quot;Session-Token&quot; and &quot;Throughput&quot;
    /// </summary>
    [JsonPropertyName("options")]
    public V1api20231115storageMongodbDatabaseCollectionSpecOptions? Options { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a documentdb.azure.com/MongodbDatabase resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20231115storageMongodbDatabaseCollectionSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.MongoDBCollectionResource
    /// Cosmos DB MongoDB collection resource object
    /// </summary>
    [JsonPropertyName("resource")]
    public V1api20231115storageMongodbDatabaseCollectionSpecResource? Resource { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionStatusConditions
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

/// <summary>Storage version of v1api20231115.AutoscaleSettings_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionStatusOptionsAutoscaleSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.OptionsResource_STATUS
/// Cosmos DB options resource object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionStatusOptions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231115.AutoscaleSettings_STATUS</summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115storageMongodbDatabaseCollectionStatusOptionsAutoscaleSettings? AutoscaleSettings { get; set; }

    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.MongoIndexKeys_STATUS
/// Cosmos DB MongoDB collection resource object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionStatusResourceIndexesKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keys")]
    public IList<string>? Keys { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.MongoIndexOptions_STATUS
/// Cosmos DB MongoDB collection index options
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionStatusResourceIndexesOptions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("expireAfterSeconds")]
    public int? ExpireAfterSeconds { get; set; }

    [JsonPropertyName("unique")]
    public bool? Unique { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.MongoIndex_STATUS
/// Cosmos DB MongoDB collection index key
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionStatusResourceIndexes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.MongoIndexKeys_STATUS
    /// Cosmos DB MongoDB collection resource object
    /// </summary>
    [JsonPropertyName("key")]
    public V1api20231115storageMongodbDatabaseCollectionStatusResourceIndexesKey? Key { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.MongoIndexOptions_STATUS
    /// Cosmos DB MongoDB collection index options
    /// </summary>
    [JsonPropertyName("options")]
    public V1api20231115storageMongodbDatabaseCollectionStatusResourceIndexesOptions? Options { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.RestoreParametersBase_STATUS
/// Parameters to indicate the information about the restore.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionStatusResourceRestoreParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("restoreSource")]
    public string? RestoreSource { get; set; }

    [JsonPropertyName("restoreTimestampInUtc")]
    public string? RestoreTimestampInUtc { get; set; }
}

/// <summary>Storage version of v1api20231115.MongoDBCollectionGetProperties_Resource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionStatusResource
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("_etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("_rid")]
    public string? Rid { get; set; }

    [JsonPropertyName("_ts")]
    public double? Ts { get; set; }

    [JsonPropertyName("analyticalStorageTtl")]
    public int? AnalyticalStorageTtl { get; set; }

    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("indexes")]
    public IList<V1api20231115storageMongodbDatabaseCollectionStatusResourceIndexes>? Indexes { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.RestoreParametersBase_STATUS
    /// Parameters to indicate the information about the restore.
    /// </summary>
    [JsonPropertyName("restoreParameters")]
    public V1api20231115storageMongodbDatabaseCollectionStatusResourceRestoreParameters? RestoreParameters { get; set; }

    [JsonPropertyName("shardKey")]
    public IDictionary<string, string>? ShardKey { get; set; }
}

/// <summary>Storage version of v1api20231115.MongodbDatabaseCollection_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20231115storageMongodbDatabaseCollectionStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.OptionsResource_STATUS
    /// Cosmos DB options resource object
    /// </summary>
    [JsonPropertyName("options")]
    public V1api20231115storageMongodbDatabaseCollectionStatusOptions? Options { get; set; }

    /// <summary>Storage version of v1api20231115.MongoDBCollectionGetProperties_Resource_STATUS</summary>
    [JsonPropertyName("resource")]
    public V1api20231115storageMongodbDatabaseCollectionStatusResource? Resource { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.MongodbDatabaseCollection
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2023-11-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115storageMongodbDatabaseCollection : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231115storageMongodbDatabaseCollectionSpec?>, IStatus<V1api20231115storageMongodbDatabaseCollectionStatus?>
{
    public const string KubeApiVersion = "v1api20231115storage";
    public const string KubeKind = "MongodbDatabaseCollection";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongodbdatabasecollections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20231115storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MongodbDatabaseCollection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20231115.MongodbDatabaseCollection_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20231115storageMongodbDatabaseCollectionSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20231115.MongodbDatabaseCollection_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20231115storageMongodbDatabaseCollectionStatus? Status { get; set; }
}