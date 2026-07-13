#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.batch.azure.com;
/// <summary>
/// Storage version of v20240701.BatchAccount
/// Generator information:
/// - Generated from: /batch/resource-manager/Microsoft.Batch/Batch/stable/2024-07-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240701storageBatchAccountList : IKubernetesObject<V1ListMeta>, IItems<V20240701storageBatchAccount>
{
    public const string KubeApiVersion = "v20240701storage";
    public const string KubeKind = "BatchAccountList";
    public const string KubeGroup = "batch.azure.com";
    public const string KubePluralName = "batchaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "batch.azure.com/v20240701storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BatchAccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240701storageBatchAccount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240701storageBatchAccount> Items { get; set; }
}

/// <summary>ResourceReference: The ARM resource id of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecAutoStorageNodeIdentityReferenceResourceReference
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
/// Storage version of v20240701.ComputeNodeIdentityReference
/// The reference to a user assigned identity associated with the Batch pool which a compute node will use.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecAutoStorageNodeIdentityReference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference: The ARM resource id of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V20240701storageBatchAccountSpecAutoStorageNodeIdentityReferenceResourceReference? ResourceReference { get; set; }
}

/// <summary>StorageAccountReference: The resource ID of the storage account to be used for auto-storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecAutoStorageStorageAccountReference
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
/// Storage version of v20240701.AutoStorageBaseProperties
/// The properties related to the auto-storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecAutoStorage
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    /// <summary>
    /// Storage version of v20240701.ComputeNodeIdentityReference
    /// The reference to a user assigned identity associated with the Batch pool which a compute node will use.
    /// </summary>
    [JsonPropertyName("nodeIdentityReference")]
    public V20240701storageBatchAccountSpecAutoStorageNodeIdentityReference? NodeIdentityReference { get; set; }

    /// <summary>StorageAccountReference: The resource ID of the storage account to be used for auto-storage account.</summary>
    [JsonPropertyName("storageAccountReference")]
    public required V20240701storageBatchAccountSpecAutoStorageStorageAccountReference StorageAccountReference { get; set; }
}

/// <summary>
/// Storage version of v20240701.KeyVaultProperties
/// KeyVault configuration when using an encryption KeySource of Microsoft.KeyVault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecEncryptionKeyVaultProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }
}

/// <summary>
/// Storage version of v20240701.EncryptionProperties
/// Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft
/// managed key. For additional control, a customer-managed key can be used instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>
    /// Storage version of v20240701.KeyVaultProperties
    /// KeyVault configuration when using an encryption KeySource of Microsoft.KeyVault.
    /// </summary>
    [JsonPropertyName("keyVaultProperties")]
    public V20240701storageBatchAccountSpecEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v20240701.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20240701storageBatchAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20240701.BatchAccountIdentity
/// The identity of the Batch account, if configured. This is used when the user specifies &apos;Microsoft.KeyVault&apos; as their
/// Batch account encryption configuration or when `ManagedIdentity` is selected as the auto-storage authentication mode.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20240701storageBatchAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Reference: The resource ID of the Azure key vault associated with the Batch account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecKeyVaultReferenceReference
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
/// Storage version of v20240701.KeyVaultReference
/// Identifies the Azure key vault associated with a Batch account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecKeyVaultReference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The resource ID of the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("reference")]
    public required V20240701storageBatchAccountSpecKeyVaultReferenceReference Reference { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v20240701.IPRule
/// Rule to filter client IP address.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecNetworkProfileAccountAccessIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v20240701.EndpointAccessProfile
/// Network access profile for Batch endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecNetworkProfileAccountAccess
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V20240701storageBatchAccountSpecNetworkProfileAccountAccessIpRules>? IpRules { get; set; }
}

/// <summary>
/// Storage version of v20240701.IPRule
/// Rule to filter client IP address.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecNetworkProfileNodeManagementAccessIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v20240701.EndpointAccessProfile
/// Network access profile for Batch endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecNetworkProfileNodeManagementAccess
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V20240701storageBatchAccountSpecNetworkProfileNodeManagementAccessIpRules>? IpRules { get; set; }
}

/// <summary>
/// Storage version of v20240701.NetworkProfile
/// Network profile for Batch account, which contains network rule settings for each endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240701.EndpointAccessProfile
    /// Network access profile for Batch endpoint.
    /// </summary>
    [JsonPropertyName("accountAccess")]
    public V20240701storageBatchAccountSpecNetworkProfileAccountAccess? AccountAccess { get; set; }

    /// <summary>
    /// Storage version of v20240701.EndpointAccessProfile
    /// Network access profile for Batch endpoint.
    /// </summary>
    [JsonPropertyName("nodeManagementAccess")]
    public V20240701storageBatchAccountSpecNetworkProfileNodeManagementAccess? NodeManagementAccess { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecOperatorSpecConfigMapExpressions
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
public partial class V20240701storageBatchAccountSpecOperatorSpecSecretExpressions
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
/// Storage version of v20240701.BatchAccountOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20240701storageBatchAccountSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20240701storageBatchAccountSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20240701.BatchAccount_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowedAuthenticationModes")]
    public IList<string>? AllowedAuthenticationModes { get; set; }

    /// <summary>
    /// Storage version of v20240701.AutoStorageBaseProperties
    /// The properties related to the auto-storage account.
    /// </summary>
    [JsonPropertyName("autoStorage")]
    public V20240701storageBatchAccountSpecAutoStorage? AutoStorage { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v20240701.EncryptionProperties
    /// Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft
    /// managed key. For additional control, a customer-managed key can be used instead.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V20240701storageBatchAccountSpecEncryption? Encryption { get; set; }

    /// <summary>
    /// Storage version of v20240701.BatchAccountIdentity
    /// The identity of the Batch account, if configured. This is used when the user specifies &apos;Microsoft.KeyVault&apos; as their
    /// Batch account encryption configuration or when `ManagedIdentity` is selected as the auto-storage authentication mode.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20240701storageBatchAccountSpecIdentity? Identity { get; set; }

    /// <summary>
    /// Storage version of v20240701.KeyVaultReference
    /// Identifies the Azure key vault associated with a Batch account.
    /// </summary>
    [JsonPropertyName("keyVaultReference")]
    public V20240701storageBatchAccountSpecKeyVaultReference? KeyVaultReference { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v20240701.NetworkProfile
    /// Network profile for Batch account, which contains network rule settings for each endpoint.
    /// </summary>
    [JsonPropertyName("networkProfile")]
    public V20240701storageBatchAccountSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>
    /// Storage version of v20240701.BatchAccountOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240701storageBatchAccountSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240701storageBatchAccountSpecOwner Owner { get; set; }

    [JsonPropertyName("poolAllocationMode")]
    public string? PoolAllocationMode { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Storage version of v20240701.ComputeNodeIdentityReference_STATUS
/// The reference to a user assigned identity associated with the Batch pool which a compute node will use.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusAutoStorageNodeIdentityReference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>
/// Storage version of v20240701.AutoStorageProperties_STATUS
/// Contains information about the auto-storage account associated with a Batch account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusAutoStorage
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("authenticationMode")]
    public string? AuthenticationMode { get; set; }

    [JsonPropertyName("lastKeySync")]
    public string? LastKeySync { get; set; }

    /// <summary>
    /// Storage version of v20240701.ComputeNodeIdentityReference_STATUS
    /// The reference to a user assigned identity associated with the Batch pool which a compute node will use.
    /// </summary>
    [JsonPropertyName("nodeIdentityReference")]
    public V20240701storageBatchAccountStatusAutoStorageNodeIdentityReference? NodeIdentityReference { get; set; }

    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusConditions
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
/// Storage version of v20240701.VirtualMachineFamilyCoreQuota_STATUS
/// A VM Family and its associated core quota for the Batch account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusDedicatedCoreQuotaPerVMFamily
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("coreQuota")]
    public int? CoreQuota { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20240701.KeyVaultProperties_STATUS
/// KeyVault configuration when using an encryption KeySource of Microsoft.KeyVault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusEncryptionKeyVaultProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }
}

/// <summary>
/// Storage version of v20240701.EncryptionProperties_STATUS
/// Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft
/// managed key. For additional control, a customer-managed key can be used instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>
    /// Storage version of v20240701.KeyVaultProperties_STATUS
    /// KeyVault configuration when using an encryption KeySource of Microsoft.KeyVault.
    /// </summary>
    [JsonPropertyName("keyVaultProperties")]
    public V20240701storageBatchAccountStatusEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

/// <summary>
/// Storage version of v20240701.UserAssignedIdentities_STATUS
/// The list of associated user identities.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Storage version of v20240701.BatchAccountIdentity_STATUS
/// The identity of the Batch account, if configured. This is used when the user specifies &apos;Microsoft.KeyVault&apos; as their
/// Batch account encryption configuration or when `ManagedIdentity` is selected as the auto-storage authentication mode.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20240701storageBatchAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v20240701.KeyVaultReference_STATUS
/// Identifies the Azure key vault associated with a Batch account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusKeyVaultReference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Storage version of v20240701.IPRule_STATUS
/// Rule to filter client IP address.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusNetworkProfileAccountAccessIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v20240701.EndpointAccessProfile_STATUS
/// Network access profile for Batch endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusNetworkProfileAccountAccess
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V20240701storageBatchAccountStatusNetworkProfileAccountAccessIpRules>? IpRules { get; set; }
}

/// <summary>
/// Storage version of v20240701.IPRule_STATUS
/// Rule to filter client IP address.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusNetworkProfileNodeManagementAccessIpRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v20240701.EndpointAccessProfile_STATUS
/// Network access profile for Batch endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusNetworkProfileNodeManagementAccess
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V20240701storageBatchAccountStatusNetworkProfileNodeManagementAccessIpRules>? IpRules { get; set; }
}

/// <summary>
/// Storage version of v20240701.NetworkProfile_STATUS
/// Network profile for Batch account, which contains network rule settings for each endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusNetworkProfile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20240701.EndpointAccessProfile_STATUS
    /// Network access profile for Batch endpoint.
    /// </summary>
    [JsonPropertyName("accountAccess")]
    public V20240701storageBatchAccountStatusNetworkProfileAccountAccess? AccountAccess { get; set; }

    /// <summary>
    /// Storage version of v20240701.EndpointAccessProfile_STATUS
    /// Network access profile for Batch endpoint.
    /// </summary>
    [JsonPropertyName("nodeManagementAccess")]
    public V20240701storageBatchAccountStatusNetworkProfileNodeManagementAccess? NodeManagementAccess { get; set; }
}

/// <summary>
/// Storage version of v20240701.PrivateEndpointConnection_STATUS
/// Contains information about a private link resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusPrivateEndpointConnections
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// Storage version of v20240701.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatusSystemData
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

/// <summary>
/// Storage version of v20240701.BatchAccount_STATUS
/// Contains information about an Azure Batch account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240701storageBatchAccountStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("accountEndpoint")]
    public string? AccountEndpoint { get; set; }

    [JsonPropertyName("activeJobAndJobScheduleQuota")]
    public int? ActiveJobAndJobScheduleQuota { get; set; }

    [JsonPropertyName("allowedAuthenticationModes")]
    public IList<string>? AllowedAuthenticationModes { get; set; }

    /// <summary>
    /// Storage version of v20240701.AutoStorageProperties_STATUS
    /// Contains information about the auto-storage account associated with a Batch account.
    /// </summary>
    [JsonPropertyName("autoStorage")]
    public V20240701storageBatchAccountStatusAutoStorage? AutoStorage { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20240701storageBatchAccountStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("dedicatedCoreQuota")]
    public int? DedicatedCoreQuota { get; set; }

    [JsonPropertyName("dedicatedCoreQuotaPerVMFamily")]
    public IList<V20240701storageBatchAccountStatusDedicatedCoreQuotaPerVMFamily>? DedicatedCoreQuotaPerVMFamily { get; set; }

    [JsonPropertyName("dedicatedCoreQuotaPerVMFamilyEnforced")]
    public bool? DedicatedCoreQuotaPerVMFamilyEnforced { get; set; }

    /// <summary>
    /// Storage version of v20240701.EncryptionProperties_STATUS
    /// Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft
    /// managed key. For additional control, a customer-managed key can be used instead.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V20240701storageBatchAccountStatusEncryption? Encryption { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20240701.BatchAccountIdentity_STATUS
    /// The identity of the Batch account, if configured. This is used when the user specifies &apos;Microsoft.KeyVault&apos; as their
    /// Batch account encryption configuration or when `ManagedIdentity` is selected as the auto-storage authentication mode.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20240701storageBatchAccountStatusIdentity? Identity { get; set; }

    /// <summary>
    /// Storage version of v20240701.KeyVaultReference_STATUS
    /// Identifies the Azure key vault associated with a Batch account.
    /// </summary>
    [JsonPropertyName("keyVaultReference")]
    public V20240701storageBatchAccountStatusKeyVaultReference? KeyVaultReference { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("lowPriorityCoreQuota")]
    public int? LowPriorityCoreQuota { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v20240701.NetworkProfile_STATUS
    /// Network profile for Batch account, which contains network rule settings for each endpoint.
    /// </summary>
    [JsonPropertyName("networkProfile")]
    public V20240701storageBatchAccountStatusNetworkProfile? NetworkProfile { get; set; }

    [JsonPropertyName("nodeManagementEndpoint")]
    public string? NodeManagementEndpoint { get; set; }

    [JsonPropertyName("poolAllocationMode")]
    public string? PoolAllocationMode { get; set; }

    [JsonPropertyName("poolQuota")]
    public int? PoolQuota { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20240701storageBatchAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v20240701.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20240701storageBatchAccountStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20240701.BatchAccount
/// Generator information:
/// - Generated from: /batch/resource-manager/Microsoft.Batch/Batch/stable/2024-07-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240701storageBatchAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V20240701storageBatchAccountSpec?>, IStatus<V20240701storageBatchAccountStatus?>
{
    public const string KubeApiVersion = "v20240701storage";
    public const string KubeKind = "BatchAccount";
    public const string KubeGroup = "batch.azure.com";
    public const string KubePluralName = "batchaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "batch.azure.com/v20240701storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BatchAccount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20240701.BatchAccount_Spec</summary>
    [JsonPropertyName("spec")]
    public V20240701storageBatchAccountSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20240701.BatchAccount_STATUS
    /// Contains information about an Azure Batch account.
    /// </summary>
    [JsonPropertyName("status")]
    public V20240701storageBatchAccountStatus? Status { get; set; }
}