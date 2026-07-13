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
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/throughputSettings/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingList : IKubernetesObject<V1ListMeta>, IItems<V1api20231115SqlDatabaseContainerThroughputSetting>
{
    public const string KubeApiVersion = "v1api20231115";
    public const string KubeKind = "SqlDatabaseContainerThroughputSettingList";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "sqldatabasecontainerthroughputsettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20231115";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SqlDatabaseContainerThroughputSettingList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20231115SqlDatabaseContainerThroughputSetting objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20231115SqlDatabaseContainerThroughputSetting> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20231115SqlDatabaseContainerThroughputSettingSpecOperatorSpecSecretExpressions
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
public partial class V1api20231115SqlDatabaseContainerThroughputSettingSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231115SqlDatabaseContainerThroughputSettingSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231115SqlDatabaseContainerThroughputSettingSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a documentdb.azure.com/SqlDatabaseContainer resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ThroughputPolicy: Represents throughput policy which service must adhere to for auto-upgrade</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy
{
    /// <summary>IncrementPercent: Represents the percentage by which throughput can increase every time throughput policy kicks in.</summary>
    [JsonPropertyName("incrementPercent")]
    public int? IncrementPercent { get; set; }

    /// <summary>IsEnabled: Determines whether the ThroughputPolicy is active or not</summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }
}

/// <summary>AutoUpgradePolicy: Cosmos DB resource auto-upgrade policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicy
{
    /// <summary>ThroughputPolicy: Represents throughput policy which service must adhere to for auto-upgrade</summary>
    [JsonPropertyName("throughputPolicy")]
    public V1api20231115SqlDatabaseContainerThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy? ThroughputPolicy { get; set; }
}

/// <summary>
/// AutoscaleSettings: Cosmos DB resource for autoscale settings. Either throughput is required or autoscaleSettings is
/// required, but not both.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingSpecResourceAutoscaleSettings
{
    /// <summary>AutoUpgradePolicy: Cosmos DB resource auto-upgrade policy</summary>
    [JsonPropertyName("autoUpgradePolicy")]
    public V1api20231115SqlDatabaseContainerThroughputSettingSpecResourceAutoscaleSettingsAutoUpgradePolicy? AutoUpgradePolicy { get; set; }

    /// <summary>MaxThroughput: Represents maximum throughput container can scale up to.</summary>
    [JsonPropertyName("maxThroughput")]
    public required int MaxThroughput { get; set; }
}

/// <summary>Resource: The standard JSON format of a resource throughput</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingSpecResource
{
    /// <summary>
    /// AutoscaleSettings: Cosmos DB resource for autoscale settings. Either throughput is required or autoscaleSettings is
    /// required, but not both.
    /// </summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115SqlDatabaseContainerThroughputSettingSpecResourceAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>
    /// Throughput: Value of the Cosmos DB resource throughput. Either throughput is required or autoscaleSettings is required,
    /// but not both.
    /// </summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingSpec
{
    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231115SqlDatabaseContainerThroughputSettingSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a documentdb.azure.com/SqlDatabaseContainer resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20231115SqlDatabaseContainerThroughputSettingSpecOwner Owner { get; set; }

    /// <summary>Resource: The standard JSON format of a resource throughput</summary>
    [JsonPropertyName("resource")]
    public required V1api20231115SqlDatabaseContainerThroughputSettingSpecResource Resource { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingStatusConditions
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

/// <summary>ThroughputPolicy: Represents throughput policy which service must adhere to for auto-upgrade</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy
{
    /// <summary>IncrementPercent: Represents the percentage by which throughput can increase every time throughput policy kicks in.</summary>
    [JsonPropertyName("incrementPercent")]
    public int? IncrementPercent { get; set; }

    /// <summary>IsEnabled: Determines whether the ThroughputPolicy is active or not</summary>
    [JsonPropertyName("isEnabled")]
    public bool? IsEnabled { get; set; }
}

/// <summary>AutoUpgradePolicy: Cosmos DB resource auto-upgrade policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicy
{
    /// <summary>ThroughputPolicy: Represents throughput policy which service must adhere to for auto-upgrade</summary>
    [JsonPropertyName("throughputPolicy")]
    public V1api20231115SqlDatabaseContainerThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicyThroughputPolicy? ThroughputPolicy { get; set; }
}

/// <summary>
/// AutoscaleSettings: Cosmos DB resource for autoscale settings. Either throughput is required or autoscaleSettings is
/// required, but not both.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingStatusResourceAutoscaleSettings
{
    /// <summary>AutoUpgradePolicy: Cosmos DB resource auto-upgrade policy</summary>
    [JsonPropertyName("autoUpgradePolicy")]
    public V1api20231115SqlDatabaseContainerThroughputSettingStatusResourceAutoscaleSettingsAutoUpgradePolicy? AutoUpgradePolicy { get; set; }

    /// <summary>MaxThroughput: Represents maximum throughput container can scale up to.</summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }

    /// <summary>
    /// TargetMaxThroughput: Represents target maximum throughput container can scale up to once offer is no longer in pending
    /// state.
    /// </summary>
    [JsonPropertyName("targetMaxThroughput")]
    public int? TargetMaxThroughput { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingStatusResource
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

    /// <summary>
    /// AutoscaleSettings: Cosmos DB resource for autoscale settings. Either throughput is required or autoscaleSettings is
    /// required, but not both.
    /// </summary>
    [JsonPropertyName("autoscaleSettings")]
    public V1api20231115SqlDatabaseContainerThroughputSettingStatusResourceAutoscaleSettings? AutoscaleSettings { get; set; }

    /// <summary>InstantMaximumThroughput: The offer throughput value to instantly scale up without triggering splits</summary>
    [JsonPropertyName("instantMaximumThroughput")]
    public string? InstantMaximumThroughput { get; set; }

    /// <summary>MinimumThroughput: The minimum throughput of the resource</summary>
    [JsonPropertyName("minimumThroughput")]
    public string? MinimumThroughput { get; set; }

    /// <summary>OfferReplacePending: The throughput replace is pending</summary>
    [JsonPropertyName("offerReplacePending")]
    public string? OfferReplacePending { get; set; }

    /// <summary>
    /// SoftAllowedMaximumThroughput: The maximum throughput value or the maximum maxThroughput value (for autoscale) that can
    /// be specified
    /// </summary>
    [JsonPropertyName("softAllowedMaximumThroughput")]
    public string? SoftAllowedMaximumThroughput { get; set; }

    /// <summary>
    /// Throughput: Value of the Cosmos DB resource throughput. Either throughput is required or autoscaleSettings is required,
    /// but not both.
    /// </summary>
    [JsonPropertyName("throughput")]
    public int? Throughput { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231115SqlDatabaseContainerThroughputSettingStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231115SqlDatabaseContainerThroughputSettingStatusConditions>? Conditions { get; set; }

    /// <summary>Id: The unique resource identifier of the ARM resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The location of the resource group to which the resource belongs.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the ARM resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resource")]
    public V1api20231115SqlDatabaseContainerThroughputSettingStatusResource? Resource { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of Azure resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cosmos-db/resource-manager/Microsoft.DocumentDB/DocumentDB/stable/2023-11-15/cosmos-db.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}/throughputSettings/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231115SqlDatabaseContainerThroughputSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231115SqlDatabaseContainerThroughputSettingSpec?>, IStatus<V1api20231115SqlDatabaseContainerThroughputSettingStatus?>
{
    public const string KubeApiVersion = "v1api20231115";
    public const string KubeKind = "SqlDatabaseContainerThroughputSetting";
    public const string KubeGroup = "documentdb.azure.com";
    public const string KubePluralName = "sqldatabasecontainerthroughputsettings";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "documentdb.azure.com/v1api20231115";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SqlDatabaseContainerThroughputSetting";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20231115SqlDatabaseContainerThroughputSettingSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20231115SqlDatabaseContainerThroughputSettingStatus? Status { get; set; }
}