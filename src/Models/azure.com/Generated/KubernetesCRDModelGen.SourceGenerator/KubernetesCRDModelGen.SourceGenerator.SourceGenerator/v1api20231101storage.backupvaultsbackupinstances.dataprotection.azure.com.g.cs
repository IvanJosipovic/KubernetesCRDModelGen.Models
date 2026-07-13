#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataprotection.azure.com;
/// <summary>
/// Storage version of v1api20231101.BackupVaultsBackupInstance
/// Generator information:
/// - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/DataProtection/stable/2023-11-01/dataprotection.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101storageBackupVaultsBackupInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1api20231101storageBackupVaultsBackupInstance>
{
    public const string KubeApiVersion = "v1api20231101storage";
    public const string KubeKind = "BackupVaultsBackupInstanceList";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaultsbackupinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.com/v1api20231101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVaultsBackupInstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20231101storageBackupVaultsBackupInstance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20231101storageBackupVaultsBackupInstance> Items { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20231101.BackupVaultsBackupInstanceOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a dataprotection.azure.com/BackupVault resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20231101.DefaultResourceProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BaseResourceProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.DefaultResourceProperties</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>
/// ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will
/// be the ID created by backup service via Fabric/Vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceReference
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
/// Storage version of v1api20231101.Datasource
/// Datasource to be backed up
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>Storage version of v1api20231101.BaseResourceProperties</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceProperties? ResourceProperties { get; set; }

    /// <summary>
    /// ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will
    /// be the ID created by backup service via Fabric/Vault.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public required V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceReference ResourceReference { get; set; }

    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>Storage version of v1api20231101.DefaultResourceProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BaseResourceProperties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.DefaultResourceProperties</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>
/// ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will
/// be the ID created by backup service via Fabric/Vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceReference
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
/// Storage version of v1api20231101.DatasourceSet
/// DatasourceSet details of datasource to be backed up
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>Storage version of v1api20231101.BaseResourceProperties</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceProperties? ResourceProperties { get; set; }

    /// <summary>
    /// ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will
    /// be the ID created by backup service via Fabric/Vault.
    /// </summary>
    [JsonPropertyName("resourceReference")]
    public required V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceReference ResourceReference { get; set; }

    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.SecretStoreResource
/// Class representing a secret store resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("secretStoreType")]
    public string? SecretStoreType { get; set; }

    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20231101.SecretStoreBasedAuthCredentials</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.SecretStoreResource
    /// Class representing a secret store resource.
    /// </summary>
    [JsonPropertyName("secretStoreResource")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource? SecretStoreResource { get; set; }
}

/// <summary>Storage version of v1api20231101.AuthCredentials</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentials
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.SecretStoreBasedAuthCredentials</summary>
    [JsonPropertyName("secretStoreBasedAuthCredentials")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials? SecretStoreBasedAuthCredentials { get; set; }
}

/// <summary>Storage version of v1api20231101.IdentityDetails</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesIdentityDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    [JsonPropertyName("userAssignedIdentityArmUrl")]
    public string? UserAssignedIdentityArmUrl { get; set; }
}

/// <summary>Storage version of v1api20231101.BlobBackupDatasourceParameters</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containersList")]
    public IList<string>? ContainersList { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.NamespacedNameResource
/// Class to refer resources which contains namespace and name
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Storage version of v1api20231101.KubernetesClusterBackupDatasourceParameters</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backupHookReferences")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences>? BackupHookReferences { get; set; }

    [JsonPropertyName("excludedNamespaces")]
    public IList<string>? ExcludedNamespaces { get; set; }

    [JsonPropertyName("excludedResourceTypes")]
    public IList<string>? ExcludedResourceTypes { get; set; }

    [JsonPropertyName("includeClusterScopeResources")]
    public bool? IncludeClusterScopeResources { get; set; }

    [JsonPropertyName("includedNamespaces")]
    public IList<string>? IncludedNamespaces { get; set; }

    [JsonPropertyName("includedResourceTypes")]
    public IList<string>? IncludedResourceTypes { get; set; }

    [JsonPropertyName("labelSelectors")]
    public IList<string>? LabelSelectors { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("snapshotVolumes")]
    public bool? SnapshotVolumes { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupDatasourceParameters</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.BlobBackupDatasourceParameters</summary>
    [JsonPropertyName("blobBackupDatasourceParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters? BlobBackupDatasourceParameters { get; set; }

    /// <summary>Storage version of v1api20231101.KubernetesClusterBackupDatasourceParameters</summary>
    [JsonPropertyName("kubernetesClusterBackupDatasourceParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters? KubernetesClusterBackupDatasourceParameters { get; set; }
}

/// <summary>ResourceGroupReference: Gets or sets the Snapshot Resource Group Uri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersResourceGroupReference
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

/// <summary>Storage version of v1api20231101.AzureOperationalStoreParameters</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>ResourceGroupReference: Gets or sets the Snapshot Resource Group Uri.</summary>
    [JsonPropertyName("resourceGroupReference")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersResourceGroupReference? ResourceGroupReference { get; set; }
}

/// <summary>Storage version of v1api20231101.DataStoreParameters</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersList
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AzureOperationalStoreParameters</summary>
    [JsonPropertyName("azureOperationalStoreParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters? AzureOperationalStoreParameters { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.PolicyParameters
/// Parameters in Policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backupDatasourceParametersList")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList>? BackupDatasourceParametersList { get; set; }

    [JsonPropertyName("dataStoreParametersList")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersList>? DataStoreParametersList { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyReference
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
/// Storage version of v1api20231101.PolicyInfo
/// Policy Info in backupInstance
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.PolicyParameters
    /// Parameters in Policy
    /// </summary>
    [JsonPropertyName("policyParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParameters? PolicyParameters { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("policyReference")]
    public required V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyReference PolicyReference { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.BackupInstance
/// Backup Instance
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.Datasource
    /// Datasource to be backed up
    /// </summary>
    [JsonPropertyName("dataSourceInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfo? DataSourceInfo { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.DatasourceSet
    /// DatasourceSet details of datasource to be backed up
    /// </summary>
    [JsonPropertyName("dataSourceSetInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfo? DataSourceSetInfo { get; set; }

    /// <summary>Storage version of v1api20231101.AuthCredentials</summary>
    [JsonPropertyName("datasourceAuthCredentials")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentials? DatasourceAuthCredentials { get; set; }

    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>Storage version of v1api20231101.IdentityDetails</summary>
    [JsonPropertyName("identityDetails")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesIdentityDetails? IdentityDetails { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.PolicyInfo
    /// Policy Info in backupInstance
    /// </summary>
    [JsonPropertyName("policyInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfo? PolicyInfo { get; set; }

    [JsonPropertyName("validationType")]
    public string? ValidationType { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupVaultsBackupInstance_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceSpec
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

    /// <summary>
    /// Storage version of v1api20231101.BackupVaultsBackupInstanceOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a dataprotection.azure.com/BackupVault resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20231101storageBackupVaultsBackupInstanceSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.BackupInstance
    /// Backup Instance
    /// </summary>
    [JsonPropertyName("properties")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecProperties? Properties { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusConditions
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

/// <summary>Storage version of v1api20231101.DefaultResourceProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BaseResourceProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourceProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.DefaultResourceProperties_STATUS</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.Datasource_STATUS
/// Datasource to be backed up
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>Storage version of v1api20231101.BaseResourceProperties_STATUS</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourceProperties? ResourceProperties { get; set; }

    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>Storage version of v1api20231101.DefaultResourceProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BaseResourceProperties_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourceProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.DefaultResourceProperties_STATUS</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.DatasourceSet_STATUS
/// DatasourceSet details of datasource to be backed up
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>Storage version of v1api20231101.BaseResourceProperties_STATUS</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourceProperties? ResourceProperties { get; set; }

    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.SecretStoreResource_STATUS
/// Class representing a secret store resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("secretStoreType")]
    public string? SecretStoreType { get; set; }

    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20231101.SecretStoreBasedAuthCredentials_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.SecretStoreResource_STATUS
    /// Class representing a secret store resource.
    /// </summary>
    [JsonPropertyName("secretStoreResource")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource? SecretStoreResource { get; set; }
}

/// <summary>Storage version of v1api20231101.AuthCredentials_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentials
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.SecretStoreBasedAuthCredentials_STATUS</summary>
    [JsonPropertyName("secretStoreBasedAuthCredentials")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials? SecretStoreBasedAuthCredentials { get; set; }
}

/// <summary>Storage version of v1api20231101.IdentityDetails_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesIdentityDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    [JsonPropertyName("userAssignedIdentityArmUrl")]
    public string? UserAssignedIdentityArmUrl { get; set; }
}

/// <summary>Storage version of v1api20231101.BlobBackupDatasourceParameters_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containersList")]
    public IList<string>? ContainersList { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.NamespacedNameResource_STATUS
/// Class to refer resources which contains namespace and name
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Storage version of v1api20231101.KubernetesClusterBackupDatasourceParameters_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backupHookReferences")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences>? BackupHookReferences { get; set; }

    [JsonPropertyName("excludedNamespaces")]
    public IList<string>? ExcludedNamespaces { get; set; }

    [JsonPropertyName("excludedResourceTypes")]
    public IList<string>? ExcludedResourceTypes { get; set; }

    [JsonPropertyName("includeClusterScopeResources")]
    public bool? IncludeClusterScopeResources { get; set; }

    [JsonPropertyName("includedNamespaces")]
    public IList<string>? IncludedNamespaces { get; set; }

    [JsonPropertyName("includedResourceTypes")]
    public IList<string>? IncludedResourceTypes { get; set; }

    [JsonPropertyName("labelSelectors")]
    public IList<string>? LabelSelectors { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("snapshotVolumes")]
    public bool? SnapshotVolumes { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupDatasourceParameters_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.BlobBackupDatasourceParameters_STATUS</summary>
    [JsonPropertyName("blobBackupDatasourceParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters? BlobBackupDatasourceParameters { get; set; }

    /// <summary>Storage version of v1api20231101.KubernetesClusterBackupDatasourceParameters_STATUS</summary>
    [JsonPropertyName("kubernetesClusterBackupDatasourceParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters? KubernetesClusterBackupDatasourceParameters { get; set; }
}

/// <summary>Storage version of v1api20231101.AzureOperationalStoreParameters_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }
}

/// <summary>Storage version of v1api20231101.DataStoreParameters_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersList
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AzureOperationalStoreParameters_STATUS</summary>
    [JsonPropertyName("azureOperationalStoreParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters? AzureOperationalStoreParameters { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.PolicyParameters_STATUS
/// Parameters in Policy
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("backupDatasourceParametersList")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList>? BackupDatasourceParametersList { get; set; }

    [JsonPropertyName("dataStoreParametersList")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersList>? DataStoreParametersList { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.PolicyInfo_STATUS
/// Policy Info in backupInstance
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.PolicyParameters_STATUS
    /// Parameters in Policy
    /// </summary>
    [JsonPropertyName("policyParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParameters? PolicyParameters { get; set; }

    [JsonPropertyName("policyVersion")]
    public string? PolicyVersion { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.InnerError_STATUS
/// Inner Error
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

/// <summary>Storage version of v1api20231101.UserFacingError_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.InnerError_STATUS
    /// Inner Error
    /// </summary>
    [JsonPropertyName("innerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerError? InnerError { get; set; }

    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.InnerError_STATUS
/// Inner Error
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.UserFacingError_STATUS
/// Error object used by layers that have access to localized content, and propagate that to user
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetails>? Details { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.InnerError_STATUS
    /// Inner Error
    /// </summary>
    [JsonPropertyName("innerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerError? InnerError { get; set; }

    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.InnerError_STATUS
/// Inner Error
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

/// <summary>Storage version of v1api20231101.UserFacingError_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.InnerError_STATUS
    /// Inner Error
    /// </summary>
    [JsonPropertyName("innerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerError? InnerError { get; set; }

    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.InnerError_STATUS
/// Inner Error
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.UserFacingError_STATUS
/// Error object used by layers that have access to localized content, and propagate that to user
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetails>? Details { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.InnerError_STATUS
    /// Inner Error
    /// </summary>
    [JsonPropertyName("innerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerError? InnerError { get; set; }

    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.ProtectionStatusDetails_STATUS
/// Protection status details
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.UserFacingError_STATUS
    /// Error object used by layers that have access to localized content, and propagate that to user
    /// </summary>
    [JsonPropertyName("errorDetails")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetails? ErrorDetails { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.BackupInstance_STATUS
/// Backup Instance
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("currentProtectionState")]
    public string? CurrentProtectionState { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.Datasource_STATUS
    /// Datasource to be backed up
    /// </summary>
    [JsonPropertyName("dataSourceInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfo? DataSourceInfo { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.DatasourceSet_STATUS
    /// DatasourceSet details of datasource to be backed up
    /// </summary>
    [JsonPropertyName("dataSourceSetInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfo? DataSourceSetInfo { get; set; }

    /// <summary>Storage version of v1api20231101.AuthCredentials_STATUS</summary>
    [JsonPropertyName("datasourceAuthCredentials")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentials? DatasourceAuthCredentials { get; set; }

    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>Storage version of v1api20231101.IdentityDetails_STATUS</summary>
    [JsonPropertyName("identityDetails")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesIdentityDetails? IdentityDetails { get; set; }

    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.PolicyInfo_STATUS
    /// Policy Info in backupInstance
    /// </summary>
    [JsonPropertyName("policyInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfo? PolicyInfo { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.UserFacingError_STATUS
    /// Error object used by layers that have access to localized content, and propagate that to user
    /// </summary>
    [JsonPropertyName("protectionErrorDetails")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetails? ProtectionErrorDetails { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.ProtectionStatusDetails_STATUS
    /// Protection status details
    /// </summary>
    [JsonPropertyName("protectionStatus")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatus? ProtectionStatus { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("validationType")]
    public string? ValidationType { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupVaultsBackupInstance_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupInstanceStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.BackupInstance_STATUS
    /// Backup Instance
    /// </summary>
    [JsonPropertyName("properties")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusProperties? Properties { get; set; }

    /// <summary>
    /// Storage version of v1api20231101.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20231101.BackupVaultsBackupInstance
/// Generator information:
/// - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/DataProtection/stable/2023-11-01/dataprotection.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101storageBackupVaultsBackupInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231101storageBackupVaultsBackupInstanceSpec?>, IStatus<V1api20231101storageBackupVaultsBackupInstanceStatus?>
{
    public const string KubeApiVersion = "v1api20231101storage";
    public const string KubeKind = "BackupVaultsBackupInstance";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaultsbackupinstances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataprotection.azure.com/v1api20231101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVaultsBackupInstance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVaultsBackupInstance_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20231101storageBackupVaultsBackupInstanceSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVaultsBackupInstance_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20231101storageBackupVaultsBackupInstanceStatus? Status { get; set; }
}