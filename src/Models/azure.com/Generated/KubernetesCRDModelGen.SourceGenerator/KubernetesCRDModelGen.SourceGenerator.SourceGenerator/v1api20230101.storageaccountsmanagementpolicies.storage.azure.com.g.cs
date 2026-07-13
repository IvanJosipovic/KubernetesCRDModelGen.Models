#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storage.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/storage.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101StorageAccountsManagementPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1api20230101StorageAccountsManagementPolicy>
{
    public const string KubeApiVersion = "v1api20230101";
    public const string KubeKind = "StorageAccountsManagementPolicyList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsmanagementpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v1api20230101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsManagementPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230101StorageAccountsManagementPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230101StorageAccountsManagementPolicy> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230101StorageAccountsManagementPolicySpecOperatorSpecSecretExpressions
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
public partial class V1api20230101StorageAccountsManagementPolicySpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230101StorageAccountsManagementPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230101StorageAccountsManagementPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a storage.azure.com/StorageAccount resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Delete: The function to delete the blob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobDelete
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after blob creation.</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastAccessTimeGreaterThan: Value indicating the age in days after last blob access. This property can only be
    /// used in conjunction with last access time tracking policy
    /// </summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based
    /// actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary>DaysAfterModificationGreaterThan: Value indicating the age in days after last modification</summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>TierToArchive: The function to tier blobs to archive storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToArchive
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after blob creation.</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastAccessTimeGreaterThan: Value indicating the age in days after last blob access. This property can only be
    /// used in conjunction with last access time tracking policy
    /// </summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based
    /// actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary>DaysAfterModificationGreaterThan: Value indicating the age in days after last modification</summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCold
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after blob creation.</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastAccessTimeGreaterThan: Value indicating the age in days after last blob access. This property can only be
    /// used in conjunction with last access time tracking policy
    /// </summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based
    /// actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary>DaysAfterModificationGreaterThan: Value indicating the age in days after last modification</summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>TierToCool: The function to tier blobs to cool storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCool
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after blob creation.</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastAccessTimeGreaterThan: Value indicating the age in days after last blob access. This property can only be
    /// used in conjunction with last access time tracking policy
    /// </summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based
    /// actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary>DaysAfterModificationGreaterThan: Value indicating the age in days after last modification</summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
/// Accounts
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToHot
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after blob creation.</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastAccessTimeGreaterThan: Value indicating the age in days after last blob access. This property can only be
    /// used in conjunction with last access time tracking policy
    /// </summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based
    /// actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary>DaysAfterModificationGreaterThan: Value indicating the age in days after last modification</summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>BaseBlob: The management policy action for base blob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlob
{
    /// <summary>Delete: The function to delete the blob</summary>
    [JsonPropertyName("delete")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobDelete? Delete { get; set; }

    /// <summary>
    /// EnableAutoTierToHotFromCool: This property enables auto tiering of a blob from cool to hot on a blob access. This
    /// property requires tierToCool.daysAfterLastAccessTimeGreaterThan.
    /// </summary>
    [JsonPropertyName("enableAutoTierToHotFromCool")]
    public bool? EnableAutoTierToHotFromCool { get; set; }

    /// <summary>TierToArchive: The function to tier blobs to archive storage.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToArchive? TierToArchive { get; set; }

    /// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCold? TierToCold { get; set; }

    /// <summary>TierToCool: The function to tier blobs to cool storage.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCool? TierToCool { get; set; }

    /// <summary>
    /// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
    /// Accounts
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToHot? TierToHot { get; set; }
}

/// <summary>Delete: The function to delete the blob snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotDelete
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public required int DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToArchive: The function to tier blob snapshot to archive storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToArchive
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public required int DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCold
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public required int DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToCool: The function to tier blob snapshot to cool storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCool
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public required int DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
/// Accounts
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToHot
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public required int DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Snapshot: The management policy action for snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshot
{
    /// <summary>Delete: The function to delete the blob snapshot</summary>
    [JsonPropertyName("delete")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotDelete? Delete { get; set; }

    /// <summary>TierToArchive: The function to tier blob snapshot to archive storage.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToArchive? TierToArchive { get; set; }

    /// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCold? TierToCold { get; set; }

    /// <summary>TierToCool: The function to tier blob snapshot to cool storage.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCool? TierToCool { get; set; }

    /// <summary>
    /// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
    /// Accounts
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToHot? TierToHot { get; set; }
}

/// <summary>Delete: The function to delete the blob version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionDelete
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public required int DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToArchive: The function to tier blob version to archive storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToArchive
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public required int DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCold
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public required int DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToCool: The function to tier blob version to cool storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCool
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public required int DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
/// Accounts
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToHot
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public required int DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Version: The management policy action for version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersion
{
    /// <summary>Delete: The function to delete the blob version</summary>
    [JsonPropertyName("delete")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionDelete? Delete { get; set; }

    /// <summary>TierToArchive: The function to tier blob version to archive storage.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToArchive? TierToArchive { get; set; }

    /// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCold? TierToCold { get; set; }

    /// <summary>TierToCool: The function to tier blob version to cool storage.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCool? TierToCool { get; set; }

    /// <summary>
    /// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
    /// Accounts
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToHot? TierToHot { get; set; }
}

/// <summary>Actions: An object that defines the action set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActions
{
    /// <summary>BaseBlob: The management policy action for base blob</summary>
    [JsonPropertyName("baseBlob")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>Snapshot: The management policy action for snapshot</summary>
    [JsonPropertyName("snapshot")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshot? Snapshot { get; set; }

    /// <summary>Version: The management policy action for version</summary>
    [JsonPropertyName("version")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersion? Version { get; set; }
}

/// <summary>Blob index tag based filtering for blob objects</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionFiltersBlobIndexMatch
{
    /// <summary>Name: This is the filter tag name, it can have 1 - 128 characters</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Op: This is the comparison operator which is used for object comparison and filtering. Only == (equality operator) is
    /// currently supported
    /// </summary>
    [JsonPropertyName("op")]
    public required string Op { get; set; }

    /// <summary>Value: This is the filter tag value field used for tag based filtering, it can have 0 - 256 characters</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>Filters: An object that defines the filter set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionFilters
{
    /// <summary>BlobIndexMatch: An array of blob index tag based filters, there can be at most 10 tag filters</summary>
    [JsonPropertyName("blobIndexMatch")]
    public IList<V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionFiltersBlobIndexMatch>? BlobIndexMatch { get; set; }

    /// <summary>
    /// BlobTypes: An array of predefined enum values. Currently blockBlob supports all tiering and delete actions. Only delete
    /// actions are supported for appendBlob.
    /// </summary>
    [JsonPropertyName("blobTypes")]
    public required IList<string> BlobTypes { get; set; }

    /// <summary>PrefixMatch: An array of strings for prefixes to be match.</summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

/// <summary>Definition: An object that defines the Lifecycle rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinition
{
    /// <summary>Actions: An object that defines the action set.</summary>
    [JsonPropertyName("actions")]
    public required V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionActions Actions { get; set; }

    /// <summary>Filters: An object that defines the filter set.</summary>
    [JsonPropertyName("filters")]
    public V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinitionFilters? Filters { get; set; }
}

/// <summary>Type: The valid value is Lifecycle</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230101StorageAccountsManagementPolicySpecPolicyRulesTypeEnum>))]
public enum V1api20230101StorageAccountsManagementPolicySpecPolicyRulesTypeEnum
{
    [EnumMember(Value = "Lifecycle"), JsonStringEnumMemberName("Lifecycle")]
    Lifecycle
}

/// <summary>An object that wraps the Lifecycle rule. Each rule is uniquely defined by name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicyRules
{
    /// <summary>Definition: An object that defines the Lifecycle rule.</summary>
    [JsonPropertyName("definition")]
    public required V1api20230101StorageAccountsManagementPolicySpecPolicyRulesDefinition Definition { get; set; }

    /// <summary>Enabled: Rule is enabled if set to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Name: A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be
    /// unique within a policy.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Type: The valid value is Lifecycle</summary>
    [JsonPropertyName("type")]
    public required V1api20230101StorageAccountsManagementPolicySpecPolicyRulesTypeEnum Type { get; set; }
}

/// <summary>
/// Policy: The Storage Account ManagementPolicy, in JSON format. See more details in:
/// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpecPolicy
{
    /// <summary>
    /// Rules: The Storage Account ManagementPolicies Rules. See more details in:
    /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
    /// </summary>
    [JsonPropertyName("rules")]
    public required IList<V1api20230101StorageAccountsManagementPolicySpecPolicyRules> Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicySpec
{
    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230101StorageAccountsManagementPolicySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a storage.azure.com/StorageAccount resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230101StorageAccountsManagementPolicySpecOwner Owner { get; set; }

    /// <summary>
    /// Policy: The Storage Account ManagementPolicy, in JSON format. See more details in:
    /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
    /// </summary>
    [JsonPropertyName("policy")]
    public required V1api20230101StorageAccountsManagementPolicySpecPolicy Policy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusConditions
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

/// <summary>Delete: The function to delete the blob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobDelete
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after blob creation.</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastAccessTimeGreaterThan: Value indicating the age in days after last blob access. This property can only be
    /// used in conjunction with last access time tracking policy
    /// </summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based
    /// actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary>DaysAfterModificationGreaterThan: Value indicating the age in days after last modification</summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>TierToArchive: The function to tier blobs to archive storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToArchive
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after blob creation.</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastAccessTimeGreaterThan: Value indicating the age in days after last blob access. This property can only be
    /// used in conjunction with last access time tracking policy
    /// </summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based
    /// actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary>DaysAfterModificationGreaterThan: Value indicating the age in days after last modification</summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCold
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after blob creation.</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastAccessTimeGreaterThan: Value indicating the age in days after last blob access. This property can only be
    /// used in conjunction with last access time tracking policy
    /// </summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based
    /// actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary>DaysAfterModificationGreaterThan: Value indicating the age in days after last modification</summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>TierToCool: The function to tier blobs to cool storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCool
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after blob creation.</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastAccessTimeGreaterThan: Value indicating the age in days after last blob access. This property can only be
    /// used in conjunction with last access time tracking policy
    /// </summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based
    /// actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary>DaysAfterModificationGreaterThan: Value indicating the age in days after last modification</summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
/// Accounts
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToHot
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after blob creation.</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastAccessTimeGreaterThan: Value indicating the age in days after last blob access. This property can only be
    /// used in conjunction with last access time tracking policy
    /// </summary>
    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based
    /// actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    /// <summary>DaysAfterModificationGreaterThan: Value indicating the age in days after last modification</summary>
    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>BaseBlob: The management policy action for base blob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlob
{
    /// <summary>Delete: The function to delete the blob</summary>
    [JsonPropertyName("delete")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobDelete? Delete { get; set; }

    /// <summary>
    /// EnableAutoTierToHotFromCool: This property enables auto tiering of a blob from cool to hot on a blob access. This
    /// property requires tierToCool.daysAfterLastAccessTimeGreaterThan.
    /// </summary>
    [JsonPropertyName("enableAutoTierToHotFromCool")]
    public bool? EnableAutoTierToHotFromCool { get; set; }

    /// <summary>TierToArchive: The function to tier blobs to archive storage.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToArchive? TierToArchive { get; set; }

    /// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCold? TierToCold { get; set; }

    /// <summary>TierToCool: The function to tier blobs to cool storage.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCool? TierToCool { get; set; }

    /// <summary>
    /// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
    /// Accounts
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToHot? TierToHot { get; set; }
}

/// <summary>Delete: The function to delete the blob snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotDelete
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToArchive: The function to tier blob snapshot to archive storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToArchive
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCold
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToCool: The function to tier blob snapshot to cool storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCool
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
/// Accounts
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToHot
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Snapshot: The management policy action for snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshot
{
    /// <summary>Delete: The function to delete the blob snapshot</summary>
    [JsonPropertyName("delete")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotDelete? Delete { get; set; }

    /// <summary>TierToArchive: The function to tier blob snapshot to archive storage.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToArchive? TierToArchive { get; set; }

    /// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCold? TierToCold { get; set; }

    /// <summary>TierToCool: The function to tier blob snapshot to cool storage.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCool? TierToCool { get; set; }

    /// <summary>
    /// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
    /// Accounts
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToHot? TierToHot { get; set; }
}

/// <summary>Delete: The function to delete the blob version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionDelete
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToArchive: The function to tier blob version to archive storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToArchive
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCold
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>TierToCool: The function to tier blob version to cool storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCool
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
/// Accounts
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToHot
{
    /// <summary>DaysAfterCreationGreaterThan: Value indicating the age in days after creation</summary>
    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    /// <summary>
    /// DaysAfterLastTierChangeGreaterThan: Value indicating the age in days after last blob tier change time. This property is
    /// only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob
    /// version based actions. The blob will be archived if both the conditions are satisfied.
    /// </summary>
    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>Version: The management policy action for version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersion
{
    /// <summary>Delete: The function to delete the blob version</summary>
    [JsonPropertyName("delete")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionDelete? Delete { get; set; }

    /// <summary>TierToArchive: The function to tier blob version to archive storage.</summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToArchive? TierToArchive { get; set; }

    /// <summary>TierToCold: The function to tier blobs to cold storage.</summary>
    [JsonPropertyName("tierToCold")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCold? TierToCold { get; set; }

    /// <summary>TierToCool: The function to tier blob version to cool storage.</summary>
    [JsonPropertyName("tierToCool")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCool? TierToCool { get; set; }

    /// <summary>
    /// TierToHot: The function to tier blobs to hot storage. This action can only be used with Premium Block Blob Storage
    /// Accounts
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToHot? TierToHot { get; set; }
}

/// <summary>Actions: An object that defines the action set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActions
{
    /// <summary>BaseBlob: The management policy action for base blob</summary>
    [JsonPropertyName("baseBlob")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>Snapshot: The management policy action for snapshot</summary>
    [JsonPropertyName("snapshot")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshot? Snapshot { get; set; }

    /// <summary>Version: The management policy action for version</summary>
    [JsonPropertyName("version")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersion? Version { get; set; }
}

/// <summary>Blob index tag based filtering for blob objects</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionFiltersBlobIndexMatch
{
    /// <summary>Name: This is the filter tag name, it can have 1 - 128 characters</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Op: This is the comparison operator which is used for object comparison and filtering. Only == (equality operator) is
    /// currently supported
    /// </summary>
    [JsonPropertyName("op")]
    public string? Op { get; set; }

    /// <summary>Value: This is the filter tag value field used for tag based filtering, it can have 0 - 256 characters</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Filters: An object that defines the filter set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionFilters
{
    /// <summary>BlobIndexMatch: An array of blob index tag based filters, there can be at most 10 tag filters</summary>
    [JsonPropertyName("blobIndexMatch")]
    public IList<V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionFiltersBlobIndexMatch>? BlobIndexMatch { get; set; }

    /// <summary>
    /// BlobTypes: An array of predefined enum values. Currently blockBlob supports all tiering and delete actions. Only delete
    /// actions are supported for appendBlob.
    /// </summary>
    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    /// <summary>PrefixMatch: An array of strings for prefixes to be match.</summary>
    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

/// <summary>Definition: An object that defines the Lifecycle rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinition
{
    /// <summary>Actions: An object that defines the action set.</summary>
    [JsonPropertyName("actions")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionActions? Actions { get; set; }

    /// <summary>Filters: An object that defines the filter set.</summary>
    [JsonPropertyName("filters")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinitionFilters? Filters { get; set; }
}

/// <summary>An object that wraps the Lifecycle rule. Each rule is uniquely defined by name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicyRules
{
    /// <summary>Definition: An object that defines the Lifecycle rule.</summary>
    [JsonPropertyName("definition")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicyRulesDefinition? Definition { get; set; }

    /// <summary>Enabled: Rule is enabled if set to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Name: A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be
    /// unique within a policy.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The valid value is Lifecycle</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Policy: The Storage Account ManagementPolicy, in JSON format. See more details in:
/// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatusPolicy
{
    /// <summary>
    /// Rules: The Storage Account ManagementPolicies Rules. See more details in:
    /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
    /// </summary>
    [JsonPropertyName("rules")]
    public IList<V1api20230101StorageAccountsManagementPolicyStatusPolicyRules>? Rules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101StorageAccountsManagementPolicyStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230101StorageAccountsManagementPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>LastModifiedTime: Returns the date and time the ManagementPolicies was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Policy: The Storage Account ManagementPolicy, in JSON format. See more details in:
    /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
    /// </summary>
    [JsonPropertyName("policy")]
    public V1api20230101StorageAccountsManagementPolicyStatusPolicy? Policy { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/storage.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101StorageAccountsManagementPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230101StorageAccountsManagementPolicySpec?>, IStatus<V1api20230101StorageAccountsManagementPolicyStatus?>
{
    public const string KubeApiVersion = "v1api20230101";
    public const string KubeKind = "StorageAccountsManagementPolicy";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsmanagementpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v1api20230101";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsManagementPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230101StorageAccountsManagementPolicySpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20230101StorageAccountsManagementPolicyStatus? Status { get; set; }
}