#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/ElasticPools.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101ServersElasticPoolList : IKubernetesObject<V1ListMeta>, IItems<V1api20211101ServersElasticPool>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "ServersElasticPoolList";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serverselasticpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersElasticPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20211101ServersElasticPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20211101ServersElasticPool> Items { get; set; }
}

/// <summary>LicenseType: The license type to apply for this elastic pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211101ServersElasticPoolSpecLicenseTypeEnum>))]
public enum V1api20211101ServersElasticPoolSpecLicenseTypeEnum
{
    [EnumMember(Value = "BasePrice"), JsonStringEnumMemberName("BasePrice")]
    BasePrice,
    [EnumMember(Value = "LicenseIncluded"), JsonStringEnumMemberName("LicenseIncluded")]
    LicenseIncluded
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersElasticPoolSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20211101ServersElasticPoolSpecOperatorSpecSecretExpressions
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
public partial class V1api20211101ServersElasticPoolSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20211101ServersElasticPoolSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20211101ServersElasticPoolSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a sql.azure.com/Server resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersElasticPoolSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PerDatabaseSettings: The per database settings for the elastic pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersElasticPoolSpecPerDatabaseSettings
{
    /// <summary>MaxCapacity: The maximum capacity any one database can consume.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>MinCapacity: The minimum capacity all databases are guaranteed.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }
}

/// <summary>
/// Sku: The elastic pool SKU.
/// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
/// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
/// REST API or the following command:
/// ```azurecli
/// az sql elastic-pool list-editions -l &lt;location&gt; -o table
/// ````
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersElasticPoolSpecSku
{
    /// <summary>Capacity: Capacity of the particular SKU.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU, typically, a letter + Number code, e.g. P3.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Size: Size of the particular SKU</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Tier: The tier or edition of the particular SKU, e.g. Basic, Premium.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersElasticPoolSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// HighAvailabilityReplicaCount: The number of secondary replicas associated with the elastic pool that are used to provide
    /// high availability. Applicable only to Hyperscale elastic pools.
    /// </summary>
    [JsonPropertyName("highAvailabilityReplicaCount")]
    public int? HighAvailabilityReplicaCount { get; set; }

    /// <summary>LicenseType: The license type to apply for this elastic pool.</summary>
    [JsonPropertyName("licenseType")]
    public V1api20211101ServersElasticPoolSpecLicenseTypeEnum? LicenseType { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// MaintenanceConfigurationId: Maintenance configuration id assigned to the elastic pool. This configuration defines the
    /// period when the maintenance updates will will occur.
    /// </summary>
    [JsonPropertyName("maintenanceConfigurationId")]
    public string? MaintenanceConfigurationId { get; set; }

    /// <summary>MaxSizeBytes: The storage limit for the database elastic pool in bytes.</summary>
    [JsonPropertyName("maxSizeBytes")]
    public int? MaxSizeBytes { get; set; }

    /// <summary>MinCapacity: Minimal capacity that serverless pool will not shrink below, if not paused</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20211101ServersElasticPoolSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a sql.azure.com/Server resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20211101ServersElasticPoolSpecOwner Owner { get; set; }

    /// <summary>PerDatabaseSettings: The per database settings for the elastic pool.</summary>
    [JsonPropertyName("perDatabaseSettings")]
    public V1api20211101ServersElasticPoolSpecPerDatabaseSettings? PerDatabaseSettings { get; set; }

    /// <summary>
    /// Sku: The elastic pool SKU.
    /// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
    /// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
    /// REST API or the following command:
    /// ```azurecli
    /// az sql elastic-pool list-editions -l &lt;location&gt; -o table
    /// ````
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20211101ServersElasticPoolSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// ZoneRedundant: Whether or not this elastic pool is zone redundant, which means the replicas of this elastic pool will be
    /// spread across multiple availability zones.
    /// </summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersElasticPoolStatusConditions
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

/// <summary>PerDatabaseSettings: The per database settings for the elastic pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersElasticPoolStatusPerDatabaseSettings
{
    /// <summary>MaxCapacity: The maximum capacity any one database can consume.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>MinCapacity: The minimum capacity all databases are guaranteed.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }
}

/// <summary>
/// Sku: The elastic pool SKU.
/// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
/// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
/// REST API or the following command:
/// ```azurecli
/// az sql elastic-pool list-editions -l &lt;location&gt; -o table
/// ````
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersElasticPoolStatusSku
{
    /// <summary>Capacity: Capacity of the particular SKU.</summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary>Family: If the service has different generations of hardware, for the same SKU, then that can be captured here.</summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>Name: The name of the SKU, typically, a letter + Number code, e.g. P3.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Size: Size of the particular SKU</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>Tier: The tier or edition of the particular SKU, e.g. Basic, Premium.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211101ServersElasticPoolStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211101ServersElasticPoolStatusConditions>? Conditions { get; set; }

    /// <summary>CreationDate: The creation date of the elastic pool (ISO8601 format).</summary>
    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    /// <summary>
    /// HighAvailabilityReplicaCount: The number of secondary replicas associated with the elastic pool that are used to provide
    /// high availability. Applicable only to Hyperscale elastic pools.
    /// </summary>
    [JsonPropertyName("highAvailabilityReplicaCount")]
    public int? HighAvailabilityReplicaCount { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Kind: Kind of elastic pool. This is metadata used for the Azure portal experience.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>LicenseType: The license type to apply for this elastic pool.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Location: Resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// MaintenanceConfigurationId: Maintenance configuration id assigned to the elastic pool. This configuration defines the
    /// period when the maintenance updates will will occur.
    /// </summary>
    [JsonPropertyName("maintenanceConfigurationId")]
    public string? MaintenanceConfigurationId { get; set; }

    /// <summary>MaxSizeBytes: The storage limit for the database elastic pool in bytes.</summary>
    [JsonPropertyName("maxSizeBytes")]
    public int? MaxSizeBytes { get; set; }

    /// <summary>MinCapacity: Minimal capacity that serverless pool will not shrink below, if not paused</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PerDatabaseSettings: The per database settings for the elastic pool.</summary>
    [JsonPropertyName("perDatabaseSettings")]
    public V1api20211101ServersElasticPoolStatusPerDatabaseSettings? PerDatabaseSettings { get; set; }

    /// <summary>
    /// Sku: The elastic pool SKU.
    /// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition,
    /// family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation`
    /// REST API or the following command:
    /// ```azurecli
    /// az sql elastic-pool list-editions -l &lt;location&gt; -o table
    /// ````
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20211101ServersElasticPoolStatusSku? Sku { get; set; }

    /// <summary>State: The state of the elastic pool.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// ZoneRedundant: Whether or not this elastic pool is zone redundant, which means the replicas of this elastic pool will be
    /// spread across multiple availability zones.
    /// </summary>
    [JsonPropertyName("zoneRedundant")]
    public bool? ZoneRedundant { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /sql/resource-manager/Microsoft.Sql/stable/2021-11-01/ElasticPools.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211101ServersElasticPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211101ServersElasticPoolSpec?>, IStatus<V1api20211101ServersElasticPoolStatus?>
{
    public const string KubeApiVersion = "v1api20211101";
    public const string KubeKind = "ServersElasticPool";
    public const string KubeGroup = "sql.azure.com";
    public const string KubePluralName = "serverselasticpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.azure.com/v1api20211101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServersElasticPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20211101ServersElasticPoolSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20211101ServersElasticPoolStatus? Status { get; set; }
}