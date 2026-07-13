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
/// Storage version of v1api20220901.StorageAccountsManagementPolicy
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2022-09-01/storage.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220901storageStorageAccountsManagementPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1api20220901storageStorageAccountsManagementPolicy>
{
    public const string KubeApiVersion = "v1api20220901storage";
    public const string KubeKind = "StorageAccountsManagementPolicyList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsmanagementpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v1api20220901storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsManagementPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20220901storageStorageAccountsManagementPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20220901storageStorageAccountsManagementPolicy> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecOperatorSpecConfigMapExpressions
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
public partial class V1api20220901storageStorageAccountsManagementPolicySpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20220901.StorageAccountsManagementPolicyOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220901storageStorageAccountsManagementPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220901storageStorageAccountsManagementPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a storage.azure.com/StorageAccount resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterModification
/// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
/// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
/// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
/// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
/// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobDelete
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterModification
/// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
/// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
/// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
/// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
/// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToArchive
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterModification
/// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
/// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
/// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
/// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
/// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCold
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterModification
/// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
/// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
/// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
/// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
/// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterModification
/// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
/// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
/// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
/// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
/// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToHot
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public int? DaysAfterLastAccessTimeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public int? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyBaseBlob
/// Management policy action for base blob.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlob
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterModification
    /// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
    /// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
    /// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
    /// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
    /// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
    /// </summary>
    [JsonPropertyName("delete")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobDelete? Delete { get; set; }

    [JsonPropertyName("enableAutoTierToHotFromCool")]
    public bool? EnableAutoTierToHotFromCool { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterModification
    /// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
    /// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
    /// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
    /// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
    /// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
    /// </summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToArchive? TierToArchive { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterModification
    /// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
    /// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
    /// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
    /// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
    /// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
    /// </summary>
    [JsonPropertyName("tierToCold")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCold? TierToCold { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterModification
    /// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
    /// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
    /// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
    /// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
    /// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
    /// </summary>
    [JsonPropertyName("tierToCool")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToCool? TierToCool { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterModification
    /// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
    /// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
    /// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
    /// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
    /// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlobTierToHot? TierToHot { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotDelete
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToArchive
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCold
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToHot
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicySnapShot
/// Management policy action for snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshot
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("delete")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotDelete? Delete { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToArchive? TierToArchive { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToCold")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCold? TierToCold { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToCool")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToCool? TierToCool { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshotTierToHot? TierToHot { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionDelete
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToArchive
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCold
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToHot
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public int? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public int? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyVersion
/// Management policy action for blob version.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersion
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("delete")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionDelete? Delete { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToArchive? TierToArchive { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToCold")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCold? TierToCold { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToCool")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToCool? TierToCool { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersionTierToHot? TierToHot { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyAction
/// Actions are applied to the filtered blobs when the execution condition is met.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicyBaseBlob
    /// Management policy action for base blob.
    /// </summary>
    [JsonPropertyName("baseBlob")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicySnapShot
    /// Management policy action for snapshot.
    /// </summary>
    [JsonPropertyName("snapshot")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsSnapshot? Snapshot { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicyVersion
    /// Management policy action for blob version.
    /// </summary>
    [JsonPropertyName("version")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActionsVersion? Version { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.TagFilter
/// Blob index tag based filtering for blob objects
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionFiltersBlobIndexMatch
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("op")]
    public string? Op { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyFilter
/// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical
/// AND is performed on all filters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionFilters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobIndexMatch")]
    public IList<V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionFiltersBlobIndexMatch>? BlobIndexMatch { get; set; }

    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyDefinition
/// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinition
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicyAction
    /// Actions are applied to the filtered blobs when the execution condition is met.
    /// </summary>
    [JsonPropertyName("actions")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionActions? Actions { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicyFilter
    /// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical
    /// AND is performed on all filters.
    /// </summary>
    [JsonPropertyName("filters")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinitionFilters? Filters { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyRule
/// An object that wraps the Lifecycle rule. Each rule is uniquely defined by name.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicyRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicyDefinition
    /// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
    /// </summary>
    [JsonPropertyName("definition")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicyRulesDefinition? Definition { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicySchema
/// The Storage Account ManagementPolicies Rules. See more details in:
/// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpecPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20220901storageStorageAccountsManagementPolicySpecPolicyRules>? Rules { get; set; }
}

/// <summary>Storage version of v1api20220901.StorageAccountsManagementPolicy_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicySpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.StorageAccountsManagementPolicyOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220901storageStorageAccountsManagementPolicySpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a storage.azure.com/StorageAccount resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20220901storageStorageAccountsManagementPolicySpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicySchema
    /// The Storage Account ManagementPolicies Rules. See more details in:
    /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
    /// </summary>
    [JsonPropertyName("policy")]
    public V1api20220901storageStorageAccountsManagementPolicySpecPolicy? Policy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusConditions
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
/// Storage version of v1api20220901.DateAfterModification_STATUS
/// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
/// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
/// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
/// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
/// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobDelete
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterModification_STATUS
/// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
/// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
/// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
/// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
/// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToArchive
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterModification_STATUS
/// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
/// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
/// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
/// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
/// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCold
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterModification_STATUS
/// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
/// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
/// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
/// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
/// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterModification_STATUS
/// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
/// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
/// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
/// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
/// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToHot
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
    public double? DaysAfterLastAccessTimeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }

    [JsonPropertyName("daysAfterModificationGreaterThan")]
    public double? DaysAfterModificationGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyBaseBlob_STATUS
/// Management policy action for base blob.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlob
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterModification_STATUS
    /// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
    /// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
    /// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
    /// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
    /// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
    /// </summary>
    [JsonPropertyName("delete")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobDelete? Delete { get; set; }

    [JsonPropertyName("enableAutoTierToHotFromCool")]
    public bool? EnableAutoTierToHotFromCool { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterModification_STATUS
    /// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
    /// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
    /// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
    /// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
    /// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
    /// </summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToArchive? TierToArchive { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterModification_STATUS
    /// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
    /// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
    /// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
    /// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
    /// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
    /// </summary>
    [JsonPropertyName("tierToCold")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCold? TierToCold { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterModification_STATUS
    /// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
    /// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
    /// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
    /// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
    /// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
    /// </summary>
    [JsonPropertyName("tierToCool")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToCool? TierToCool { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterModification_STATUS
    /// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan,
    /// daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The
    /// daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires
    /// daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with
    /// daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlobTierToHot? TierToHot { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation_STATUS
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotDelete
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation_STATUS
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToArchive
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation_STATUS
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCold
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation_STATUS
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation_STATUS
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToHot
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicySnapShot_STATUS
/// Management policy action for snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshot
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation_STATUS
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("delete")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotDelete? Delete { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation_STATUS
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToArchive? TierToArchive { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation_STATUS
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToCold")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCold? TierToCold { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation_STATUS
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToCool")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToCool? TierToCool { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation_STATUS
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshotTierToHot? TierToHot { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation_STATUS
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionDelete
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation_STATUS
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToArchive
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation_STATUS
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCold
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation_STATUS
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCool
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.DateAfterCreation_STATUS
/// Object to define snapshot and version action conditions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToHot
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("daysAfterCreationGreaterThan")]
    public double? DaysAfterCreationGreaterThan { get; set; }

    [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
    public double? DaysAfterLastTierChangeGreaterThan { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyVersion_STATUS
/// Management policy action for blob version.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersion
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation_STATUS
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("delete")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionDelete? Delete { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation_STATUS
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToArchive")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToArchive? TierToArchive { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation_STATUS
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToCold")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCold? TierToCold { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation_STATUS
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToCool")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToCool? TierToCool { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.DateAfterCreation_STATUS
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [JsonPropertyName("tierToHot")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersionTierToHot? TierToHot { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyAction_STATUS
/// Actions are applied to the filtered blobs when the execution condition is met.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicyBaseBlob_STATUS
    /// Management policy action for base blob.
    /// </summary>
    [JsonPropertyName("baseBlob")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsBaseBlob? BaseBlob { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicySnapShot_STATUS
    /// Management policy action for snapshot.
    /// </summary>
    [JsonPropertyName("snapshot")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsSnapshot? Snapshot { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicyVersion_STATUS
    /// Management policy action for blob version.
    /// </summary>
    [JsonPropertyName("version")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActionsVersion? Version { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.TagFilter_STATUS
/// Blob index tag based filtering for blob objects
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionFiltersBlobIndexMatch
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("op")]
    public string? Op { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyFilter_STATUS
/// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical
/// AND is performed on all filters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionFilters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobIndexMatch")]
    public IList<V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionFiltersBlobIndexMatch>? BlobIndexMatch { get; set; }

    [JsonPropertyName("blobTypes")]
    public IList<string>? BlobTypes { get; set; }

    [JsonPropertyName("prefixMatch")]
    public IList<string>? PrefixMatch { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyDefinition_STATUS
/// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinition
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicyAction_STATUS
    /// Actions are applied to the filtered blobs when the execution condition is met.
    /// </summary>
    [JsonPropertyName("actions")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionActions? Actions { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicyFilter_STATUS
    /// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical
    /// AND is performed on all filters.
    /// </summary>
    [JsonPropertyName("filters")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinitionFilters? Filters { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicyRule_STATUS
/// An object that wraps the Lifecycle rule. Each rule is uniquely defined by name.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicyDefinition_STATUS
    /// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
    /// </summary>
    [JsonPropertyName("definition")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRulesDefinition? Definition { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.ManagementPolicySchema_STATUS
/// The Storage Account ManagementPolicies Rules. See more details in:
/// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatusPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("rules")]
    public IList<V1api20220901storageStorageAccountsManagementPolicyStatusPolicyRules>? Rules { get; set; }
}

/// <summary>Storage version of v1api20220901.StorageAccountsManagementPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220901storageStorageAccountsManagementPolicyStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20220901storageStorageAccountsManagementPolicyStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20220901.ManagementPolicySchema_STATUS
    /// The Storage Account ManagementPolicies Rules. See more details in:
    /// https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
    /// </summary>
    [JsonPropertyName("policy")]
    public V1api20220901storageStorageAccountsManagementPolicyStatusPolicy? Policy { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20220901.StorageAccountsManagementPolicy
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2022-09-01/storage.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220901storageStorageAccountsManagementPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220901storageStorageAccountsManagementPolicySpec?>, IStatus<V1api20220901storageStorageAccountsManagementPolicyStatus?>
{
    public const string KubeApiVersion = "v1api20220901storage";
    public const string KubeKind = "StorageAccountsManagementPolicy";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccountsmanagementpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v1api20220901storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountsManagementPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220901.StorageAccountsManagementPolicy_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220901storageStorageAccountsManagementPolicySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220901.StorageAccountsManagementPolicy_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20220901storageStorageAccountsManagementPolicyStatus? Status { get; set; }
}