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
/// Storage version of v1api20231115.MongodbDatabaseCollectionThroughputSetting
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2023-11-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingList : IKubernetesObject<V1ListMeta>, IItems<V1api20231115storageMongodbDatabaseCollectionThroughputSetting>
{
    public const string KubeApiVersion = "v1api20231115storage";
    public const string KubeKind = "MongodbDatabaseCollectionThroughputSettingList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongodbdatabasecollectionthroughputsettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20231115storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MongodbDatabaseCollectionThroughputSettingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20231115storageMongodbDatabaseCollectionThroughputSetting objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20231115storageMongodbDatabaseCollectionThroughputSetting> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20231115.MongodbDatabaseCollectionThroughputSettingOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a documentdb.azure.com/MongodbDatabaseCollection resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.ThroughputPolicyResource
/// Cosmos DB resource throughput policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("incrementPercent")]
    public int? IncrementPercent { get; set; }

    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.AutoUpgradePolicyResource
/// Cosmos DB resource auto-upgrade policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.ThroughputPolicyResource
    /// Cosmos DB resource throughput policy
    /// </summary>
    [JsonPropertyName("throughputPolicy")]
    public V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy? ThroughputPolicy { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.AutoscaleSettingsResource
/// Cosmos DB provisioned throughput settings object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecResourceAutoscaleSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.AutoUpgradePolicyResource
    /// Cosmos DB resource auto-upgrade policy
    /// </summary>
    [JsonPropertyName("autoUpgradePolicy")]
    public V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicy? AutoUpgradePolicy { get; set; }

    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.ThroughputSettingsResource
/// Cosmos DB resource throughput object. Either throughput is required or autoscaleSettings is required, but not both.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecResource
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.AutoscaleSettingsResource
    /// Cosmos DB provisioned throughput settings object
    /// </summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecResourceAutoscaleSettings? AutoscaleSettings { get; set; }

    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>Storage version of v1api20231115.MongodbDatabaseCollectionThroughputSetting_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.MongodbDatabaseCollectionThroughputSettingOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a documentdb.azure.com/MongodbDatabaseCollection resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.ThroughputSettingsResource
    /// Cosmos DB resource throughput object. Either throughput is required or autoscaleSettings is required, but not both.
    /// </summary>
    [JsonPropertyName("resource")]
    public V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpecResource? Resource { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatusConditions
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

/// <summary>
/// Storage version of v1api20231115.ThroughputPolicyResource_STATUS
/// Cosmos DB resource throughput policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("incrementPercent")]
    public int? IncrementPercent { get; set; }

    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.AutoUpgradePolicyResource_STATUS
/// Cosmos DB resource auto-upgrade policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.ThroughputPolicyResource_STATUS
    /// Cosmos DB resource throughput policy
    /// </summary>
    [JsonPropertyName("throughputPolicy")]
    public V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy? ThroughputPolicy { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.AutoscaleSettingsResource_STATUS
/// Cosmos DB provisioned throughput settings object
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatusResourceAutoscaleSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20231115.AutoUpgradePolicyResource_STATUS
    /// Cosmos DB resource auto-upgrade policy
    /// </summary>
    [JsonPropertyName("autoUpgradePolicy")]
    public V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicy? AutoUpgradePolicy { get; set; }

    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }

    [JsonPropertyName("targetMaxThroughput")]
    public int? TargetMaxThroughput { get; set; }
}

/// <summary>Storage version of v1api20231115.ThroughputSettingsGetProperties_Resource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatusResource
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

    /// <summary>
    /// Storage version of v1api20231115.AutoscaleSettingsResource_STATUS
    /// Cosmos DB provisioned throughput settings object
    /// </summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatusResourceAutoscaleSettings? AutoscaleSettings { get; set; }

    [JsonPropertyName("instantMaximumThroughput")]
    public string? InstantMaximumThroughput { get; set; }

    [JsonPropertyName("minimumThroughput")]
    public string? MinimumThroughput { get; set; }

    [JsonPropertyName("offerReplacePending")]
    public string? OfferReplacePending { get; set; }

    [JsonPropertyName("softAllowedMaximumThroughput")]
    public string? SoftAllowedMaximumThroughput { get; set; }

    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

/// <summary>Storage version of v1api20231115.MongodbDatabaseCollectionThroughputSetting_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20231115.ThroughputSettingsGetProperties_Resource_STATUS</summary>
    [JsonPropertyName("resource")]
    public V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatusResource? Resource { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20231115.MongodbDatabaseCollectionThroughputSetting
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2023-11-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}/collections/{collectionName}/throughputSettings/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115storageMongodbDatabaseCollectionThroughputSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpec?>, IStatus<V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatus?>
{
    public const string KubeApiVersion = "v1api20231115storage";
    public const string KubeKind = "MongodbDatabaseCollectionThroughputSetting";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "mongodbdatabasecollectionthroughputsettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20231115storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MongodbDatabaseCollectionThroughputSetting";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20231115.MongodbDatabaseCollectionThroughputSetting_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20231115storageMongodbDatabaseCollectionThroughputSettingSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20231115.MongodbDatabaseCollectionThroughputSetting_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20231115storageMongodbDatabaseCollectionThroughputSettingStatus? Status { get; set; }
}